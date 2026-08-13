using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace KhayelitshaLibraryApp
{
    public partial class LoanForm : Form
    {
        private int selectedLoanId = 0;
        private int selectedCopyId = 0;

        public LoanForm()
        {
            InitializeComponent();
        }

        private void LoanForm_Load(object sender, EventArgs e)
        {
            cboFilter.Items.Clear();
            cboFilter.Items.AddRange(new object[] { "All", "Active", "Returned", "Overdue" });
            cboFilter.SelectedIndex = 0;

            dtpLoanDate.Value = DateTime.Today;
            dtpDueDate.Value = DateTime.Today.AddDays(14);

            LoadMembers();
            LoadStaff();
            LoadAvailableCopies();
            LoadLoans("All");
        }

        private void LoadMembers()
        {
            try
            {
                DataTable table = DatabaseHelper.ExecuteSelect(
                    "SELECT MemberID, FullName FROM Member ORDER BY FullName");
                cboMember.DisplayMember = "FullName";
                cboMember.ValueMember = "MemberID";
                cboMember.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading members.\n" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadStaff()
        {
            try
            {
                DataTable table = DatabaseHelper.ExecuteSelect(
                    "SELECT StaffID, FullName FROM Staff ORDER BY FullName");
                cboStaff.DisplayMember = "FullName";
                cboStaff.ValueMember = "StaffID";
                cboStaff.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading staff.\n" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadAvailableCopies()
        {
            try
            {
                string sql = @"SELECT c.CopyID,
                                      CAST(c.CopyID AS NVARCHAR(10)) + N' - ' + t.Title AS CopyDisplay
                               FROM BookCopy c
                               INNER JOIN BookTitle t ON c.TitleID = t.TitleID
                               WHERE c.Status = N'Available'
                               ORDER BY t.Title";

                DataTable table = DatabaseHelper.ExecuteSelect(sql);
                cboCopy.DisplayMember = "CopyDisplay";
                cboCopy.ValueMember = "CopyID";
                cboCopy.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading available copies.\n" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadLoans(string filter)
        {
            try
            {
                string sql = @"SELECT l.LoanID, m.FullName AS MemberName, t.Title AS BookTitle,
                                      c.CopyID, s.FullName AS StaffName, l.LoanDate, l.DueDate, l.ReturnDate,
                                      CASE
                                          WHEN l.ReturnDate IS NULL AND l.DueDate < CAST(GETDATE() AS DATE) THEN N'Overdue'
                                          WHEN l.ReturnDate IS NULL THEN N'Active'
                                          ELSE N'Returned'
                                      END AS LoanStatus
                               FROM Loan l
                               INNER JOIN Member m ON l.MemberID = m.MemberID
                               INNER JOIN BookCopy c ON l.CopyID = c.CopyID
                               INNER JOIN BookTitle t ON c.TitleID = t.TitleID
                               INNER JOIN Staff s ON l.StaffID = s.StaffID";

                if (filter == "Active")
                {
                    sql += " WHERE l.ReturnDate IS NULL AND l.DueDate >= CAST(GETDATE() AS DATE)";
                }
                else if (filter == "Returned")
                {
                    sql += " WHERE l.ReturnDate IS NOT NULL";
                }
                else if (filter == "Overdue")
                {
                    sql += " WHERE l.ReturnDate IS NULL AND l.DueDate < CAST(GETDATE() AS DATE)";
                }

                sql += " ORDER BY l.LoanDate DESC";

                dgvLoans.DataSource = DatabaseHelper.ExecuteSelect(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading loans.\n" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateIssueInput()
        {
            if (cboMember.SelectedValue == null)
            {
                MessageBox.Show("Please select a member.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (cboCopy.SelectedValue == null)
            {
                MessageBox.Show("Please select an available book copy.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (cboStaff.SelectedValue == null)
            {
                MessageBox.Show("Please select a staff member.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (dtpDueDate.Value.Date < dtpLoanDate.Value.Date)
            {
                MessageBox.Show("Due Date cannot be earlier than Loan Date.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            if (!ValidateIssueInput())
            {
                return;
            }

            int memberId = Convert.ToInt32(cboMember.SelectedValue);
            int copyId = Convert.ToInt32(cboCopy.SelectedValue);
            int staffId = Convert.ToInt32(cboStaff.SelectedValue);

            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    SqlTransaction transaction = conn.BeginTransaction();

                    try
                    {
                        // Make sure the copy is still Available
                        string statusSql = "SELECT Status FROM BookCopy WHERE CopyID = @CopyID";
                        string status;

                        using (SqlCommand statusCmd = new SqlCommand(statusSql, conn, transaction))
                        {
                            statusCmd.Parameters.AddWithValue("@CopyID", copyId);
                            object result = statusCmd.ExecuteScalar();

                            if (result == null)
                            {
                                MessageBox.Show("The selected book copy was not found.", "Warning",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                transaction.Rollback();
                                return;
                            }

                            status = result.ToString();
                        }

                        if (status != "Available")
                        {
                            MessageBox.Show(
                                "Only book copies with an Available status can be issued.",
                                "Issue Not Allowed",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                            transaction.Rollback();
                            return;
                        }

                        // Stop the same copy from having two active loans
                        string activeLoanSql = @"SELECT COUNT(*) FROM Loan
                                                 WHERE CopyID = @CopyID AND ReturnDate IS NULL";

                        using (SqlCommand activeCmd = new SqlCommand(activeLoanSql, conn, transaction))
                        {
                            activeCmd.Parameters.AddWithValue("@CopyID", copyId);
                            int activeCount = Convert.ToInt32(activeCmd.ExecuteScalar());

                            if (activeCount > 0)
                            {
                                MessageBox.Show(
                                    "This copy already has an active loan and cannot be issued again.",
                                    "Issue Not Allowed",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                                transaction.Rollback();
                                return;
                            }
                        }

                        string insertSql = @"INSERT INTO Loan (MemberID, CopyID, StaffID, LoanDate, DueDate, ReturnDate)
                                             VALUES (@MemberID, @CopyID, @StaffID, @LoanDate, @DueDate, NULL)";

                        using (SqlCommand insertCmd = new SqlCommand(insertSql, conn, transaction))
                        {
                            insertCmd.Parameters.AddWithValue("@MemberID", memberId);
                            insertCmd.Parameters.AddWithValue("@CopyID", copyId);
                            insertCmd.Parameters.AddWithValue("@StaffID", staffId);
                            insertCmd.Parameters.AddWithValue("@LoanDate", dtpLoanDate.Value.Date);
                            insertCmd.Parameters.AddWithValue("@DueDate", dtpDueDate.Value.Date);
                            insertCmd.ExecuteNonQuery();
                        }

                        // Change copy status to On Loan
                        string updateSql = "UPDATE BookCopy SET Status = N'On Loan' WHERE CopyID = @CopyID";
                        using (SqlCommand updateCmd = new SqlCommand(updateSql, conn, transaction))
                        {
                            updateCmd.Parameters.AddWithValue("@CopyID", copyId);
                            updateCmd.ExecuteNonQuery();
                        }

                        transaction.Commit();

                        MessageBox.Show("Book issued successfully.", "Success",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        LoadAvailableCopies();
                        LoadLoans(cboFilter.SelectedItem.ToString());
                        selectedLoanId = 0;
                        selectedCopyId = 0;
                    }
                    catch (Exception)
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not issue the book.\n" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            if (selectedLoanId == 0 || selectedCopyId == 0)
            {
                MessageBox.Show("Please select an active loan from the list to return.", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    SqlTransaction transaction = conn.BeginTransaction();

                    try
                    {
                        // Confirm the loan is still active
                        string checkSql = "SELECT ReturnDate FROM Loan WHERE LoanID = @LoanID";
                        object returnDate;

                        using (SqlCommand checkCmd = new SqlCommand(checkSql, conn, transaction))
                        {
                            checkCmd.Parameters.AddWithValue("@LoanID", selectedLoanId);
                            returnDate = checkCmd.ExecuteScalar();
                        }

                        if (returnDate != null && returnDate != DBNull.Value)
                        {
                            MessageBox.Show("This loan has already been returned.", "Warning",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            transaction.Rollback();
                            return;
                        }

                        string updateLoanSql = @"UPDATE Loan
                                                 SET ReturnDate = @ReturnDate
                                                 WHERE LoanID = @LoanID";

                        using (SqlCommand updateLoanCmd = new SqlCommand(updateLoanSql, conn, transaction))
                        {
                            updateLoanCmd.Parameters.AddWithValue("@ReturnDate", DateTime.Today);
                            updateLoanCmd.Parameters.AddWithValue("@LoanID", selectedLoanId);
                            updateLoanCmd.ExecuteNonQuery();
                        }

                        // Set copy back to Available
                        string updateCopySql = "UPDATE BookCopy SET Status = N'Available' WHERE CopyID = @CopyID";
                        using (SqlCommand updateCopyCmd = new SqlCommand(updateCopySql, conn, transaction))
                        {
                            updateCopyCmd.Parameters.AddWithValue("@CopyID", selectedCopyId);
                            updateCopyCmd.ExecuteNonQuery();
                        }

                        transaction.Commit();

                        MessageBox.Show("Book returned successfully.", "Success",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        selectedLoanId = 0;
                        selectedCopyId = 0;
                        LoadAvailableCopies();
                        LoadLoans(cboFilter.SelectedItem.ToString());
                    }
                    catch (Exception)
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not return the book.\n" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            LoadLoans(cboFilter.SelectedItem.ToString());
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadMembers();
            LoadStaff();
            LoadAvailableCopies();
            LoadLoans(cboFilter.SelectedItem.ToString());
            selectedLoanId = 0;
            selectedCopyId = 0;
        }

        private void dgvLoans_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            DataGridViewRow row = dgvLoans.Rows[e.RowIndex];
            selectedLoanId = Convert.ToInt32(row.Cells["LoanID"].Value);
            selectedCopyId = Convert.ToInt32(row.Cells["CopyID"].Value);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
