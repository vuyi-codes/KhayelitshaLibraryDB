using System;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace KhayelitshaLibraryApp
{
    public partial class MemberForm : Form
    {
        private int selectedMemberId = 0;

        public MemberForm()
        {
            InitializeComponent();
        }

        private void MemberForm_Load(object sender, EventArgs e)
        {
            LoadMembers();
            ClearFields();
        }

        private void LoadMembers()
        {
            try
            {
                string sql = "SELECT MemberID, FullName, Address, Phone, JoinDate FROM Member ORDER BY MemberID";
                dgvMembers.DataSource = DatabaseHelper.ExecuteSelect(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading members.\n" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearFields()
        {
            selectedMemberId = 0;
            txtMemberID.Text = "";
            txtFullName.Text = "";
            txtAddress.Text = "";
            txtPhone.Text = "";
            dtpJoinDate.Value = DateTime.Today;
            txtSearch.Text = "";
            dgvMembers.ClearSelection();
        }

        private bool ValidateMemberInput()
        {
            if (string.IsNullOrWhiteSpace(txtFullName.Text))
            {
                MessageBox.Show("Full Name is required.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFullName.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                MessageBox.Show("Address is required.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAddress.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                MessageBox.Show("Phone number is required.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPhone.Focus();
                return false;
            }

            // Basic phone check: digits only, 10 characters
            if (!Regex.IsMatch(txtPhone.Text.Trim(), @"^\d{10}$"))
            {
                MessageBox.Show("Phone number must be 10 digits.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPhone.Focus();
                return false;
            }

            if (dtpJoinDate.Value.Date > DateTime.Today)
            {
                MessageBox.Show("Join Date cannot be in the future.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateMemberInput())
            {
                return;
            }

            try
            {
                string sql = @"INSERT INTO Member (FullName, Address, Phone, JoinDate)
                               VALUES (@FullName, @Address, @Phone, @JoinDate)";

                DatabaseHelper.ExecuteNonQuery(sql,
                    new SqlParameter("@FullName", txtFullName.Text.Trim()),
                    new SqlParameter("@Address", txtAddress.Text.Trim()),
                    new SqlParameter("@Phone", txtPhone.Text.Trim()),
                    new SqlParameter("@JoinDate", dtpJoinDate.Value.Date));

                MessageBox.Show("Member added successfully.", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadMembers();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not add member.\n" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedMemberId == 0)
            {
                MessageBox.Show("Please select a member to update.", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateMemberInput())
            {
                return;
            }

            try
            {
                string sql = @"UPDATE Member
                               SET FullName = @FullName, Address = @Address,
                                   Phone = @Phone, JoinDate = @JoinDate
                               WHERE MemberID = @MemberID";

                DatabaseHelper.ExecuteNonQuery(sql,
                    new SqlParameter("@FullName", txtFullName.Text.Trim()),
                    new SqlParameter("@Address", txtAddress.Text.Trim()),
                    new SqlParameter("@Phone", txtPhone.Text.Trim()),
                    new SqlParameter("@JoinDate", dtpJoinDate.Value.Date),
                    new SqlParameter("@MemberID", selectedMemberId));

                MessageBox.Show("Member updated successfully.", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadMembers();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not update member.\n" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedMemberId == 0)
            {
                MessageBox.Show("Please select a member to delete.", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirm = MessageBox.Show(
                "Are you sure you want to delete this member?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes)
            {
                return;
            }

            try
            {
                // Check if member has loan records before deleting
                object loanCount = DatabaseHelper.ExecuteScalar(
                    "SELECT COUNT(*) FROM Loan WHERE MemberID = @MemberID",
                    new SqlParameter("@MemberID", selectedMemberId));

                if (Convert.ToInt32(loanCount) > 0)
                {
                    MessageBox.Show(
                        "This member cannot be deleted because loan records exist for them.",
                        "Delete Not Allowed",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                string sql = "DELETE FROM Member WHERE MemberID = @MemberID";
                DatabaseHelper.ExecuteNonQuery(sql, new SqlParameter("@MemberID", selectedMemberId));

                MessageBox.Show("Member deleted successfully.", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadMembers();
                ClearFields();
            }
            catch (SqlException)
            {
                MessageBox.Show(
                    "This member cannot be deleted because related records exist.",
                    "Delete Not Allowed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not delete member.\n" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string searchText = txtSearch.Text.Trim();

                if (string.IsNullOrWhiteSpace(searchText))
                {
                    LoadMembers();
                    return;
                }

                // Search by MemberID or by name
                string sql = @"SELECT MemberID, FullName, Address, Phone, JoinDate
                               FROM Member
                               WHERE FullName LIKE @Search
                                  OR CAST(MemberID AS NVARCHAR(20)) = @ExactId
                               ORDER BY MemberID";

                dgvMembers.DataSource = DatabaseHelper.ExecuteSelect(sql,
                    new SqlParameter("@Search", "%" + searchText + "%"),
                    new SqlParameter("@ExactId", searchText));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Search failed.\n" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadMembers();
            ClearFields();
        }

        private void dgvMembers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            DataGridViewRow row = dgvMembers.Rows[e.RowIndex];
            selectedMemberId = Convert.ToInt32(row.Cells["MemberID"].Value);
            txtMemberID.Text = selectedMemberId.ToString();
            txtFullName.Text = row.Cells["FullName"].Value.ToString();
            txtAddress.Text = row.Cells["Address"].Value.ToString();
            txtPhone.Text = row.Cells["Phone"].Value.ToString();
            dtpJoinDate.Value = Convert.ToDateTime(row.Cells["JoinDate"].Value);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
