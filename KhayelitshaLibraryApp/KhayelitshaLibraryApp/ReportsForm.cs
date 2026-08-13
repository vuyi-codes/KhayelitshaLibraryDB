using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace KhayelitshaLibraryApp
{
    public partial class ReportsForm : Form
    {
        public ReportsForm()
        {
            InitializeComponent();
        }

        private void ReportsForm_Load(object sender, EventArgs e)
        {
            LoadOverdueReport();
            LoadLoansPerMember();
        }

        private void LoadOverdueReport()
        {
            try
            {
                string sql = @"SELECT m.FullName AS MemberName,
                                      t.Title AS BookTitle,
                                      l.DueDate,
                                      c.CopyID,
                                      DATEDIFF(DAY, l.DueDate, CAST(GETDATE() AS DATE)) AS DaysOverdue
                               FROM Loan l
                               INNER JOIN Member m ON l.MemberID = m.MemberID
                               INNER JOIN BookCopy c ON l.CopyID = c.CopyID
                               INNER JOIN BookTitle t ON c.TitleID = t.TitleID
                               WHERE l.ReturnDate IS NULL
                                 AND l.DueDate < CAST(GETDATE() AS DATE)
                               ORDER BY l.DueDate ASC";

                dgvOverdue.DataSource = DatabaseHelper.ExecuteSelect(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading overdue report.\n" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadLoansPerMember()
        {
            try
            {
                string sql = @"SELECT m.MemberID,
                                      m.FullName AS MemberName,
                                      COUNT(l.LoanID) AS TotalLoans
                               FROM Member m
                               LEFT JOIN Loan l ON m.MemberID = l.MemberID
                               GROUP BY m.MemberID, m.FullName
                               ORDER BY TotalLoans DESC, m.FullName";

                dgvLoansPerMember.DataSource = DatabaseHelper.ExecuteSelect(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading loans per member report.\n" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearchMembers_Click(object sender, EventArgs e)
        {
            try
            {
                string searchText = txtMemberSearch.Text.Trim();

                if (string.IsNullOrWhiteSpace(searchText))
                {
                    MessageBox.Show("Enter a member name or MemberID to search.", "Validation",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string sql = @"SELECT MemberID, FullName, Address, Phone, JoinDate
                               FROM Member
                               WHERE FullName LIKE @Search
                                  OR CAST(MemberID AS NVARCHAR(20)) = @ExactId
                               ORDER BY MemberID";

                dgvSearchResults.DataSource = DatabaseHelper.ExecuteSelect(sql,
                    new SqlParameter("@Search", "%" + searchText + "%"),
                    new SqlParameter("@ExactId", searchText));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Member search failed.\n" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearchBooks_Click(object sender, EventArgs e)
        {
            try
            {
                string searchText = txtBookSearch.Text.Trim();

                if (string.IsNullOrWhiteSpace(searchText))
                {
                    MessageBox.Show("Enter a book title or author to search.", "Validation",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string sql = @"SELECT TitleID, Title, Author, ISBN, Category, YearPublished
                               FROM BookTitle
                               WHERE Title LIKE @Search OR Author LIKE @Search
                               ORDER BY Title";

                dgvSearchResults.DataSource = DatabaseHelper.ExecuteSelect(sql,
                    new SqlParameter("@Search", "%" + searchText + "%"));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Book search failed.\n" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadOverdueReport();
            LoadLoansPerMember();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
