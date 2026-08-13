using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace KhayelitshaLibraryApp
{
    public partial class BookForm : Form
    {
        private int selectedTitleId = 0;
        private int selectedCopyId = 0;

        public BookForm()
        {
            InitializeComponent();
        }

        private void BookForm_Load(object sender, EventArgs e)
        {
            cboStatus.Items.Clear();
            cboStatus.Items.AddRange(new object[] { "Available", "On Loan", "Lost", "Damaged" });
            cboStatus.SelectedIndex = 0;

            LoadTitles();
            LoadCopies();
            ClearTitleFields();
            ClearCopyFields();
        }

        private void LoadTitles()
        {
            try
            {
                string sql = @"SELECT TitleID, Title, Author, ISBN, Category, YearPublished
                               FROM BookTitle
                               ORDER BY TitleID";
                dgvTitles.DataSource = DatabaseHelper.ExecuteSelect(sql);
                LoadTitleCombo();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading book titles.\n" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadTitleCombo()
        {
            try
            {
                string sql = "SELECT TitleID, Title FROM BookTitle ORDER BY Title";
                DataTable table = DatabaseHelper.ExecuteSelect(sql);
                cboTitleForCopy.DisplayMember = "Title";
                cboTitleForCopy.ValueMember = "TitleID";
                cboTitleForCopy.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading title list.\n" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadCopies()
        {
            try
            {
                string sql = @"SELECT c.CopyID, c.TitleID, t.Title, c.Status, c.ShelfLocation
                               FROM BookCopy c
                               INNER JOIN BookTitle t ON c.TitleID = t.TitleID
                               ORDER BY c.CopyID";
                dgvCopies.DataSource = DatabaseHelper.ExecuteSelect(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading book copies.\n" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearTitleFields()
        {
            selectedTitleId = 0;
            txtTitleID.Text = "";
            txtTitle.Text = "";
            txtAuthor.Text = "";
            txtISBN.Text = "";
            txtCategory.Text = "";
            nudYear.Value = 2000;
            txtSearch.Text = "";
            dgvTitles.ClearSelection();
        }

        private void ClearCopyFields()
        {
            selectedCopyId = 0;
            txtCopyID.Text = "";
            if (cboTitleForCopy.Items.Count > 0)
            {
                cboTitleForCopy.SelectedIndex = 0;
            }
            cboStatus.SelectedIndex = 0;
            txtShelfLocation.Text = "";
            dgvCopies.ClearSelection();
        }

        private bool ValidateTitleInput()
        {
            if (string.IsNullOrWhiteSpace(txtTitle.Text))
            {
                MessageBox.Show("Book title is required.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTitle.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtAuthor.Text))
            {
                MessageBox.Show("Author is required.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAuthor.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtCategory.Text))
            {
                MessageBox.Show("Category is required.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCategory.Focus();
                return false;
            }

            return true;
        }

        private bool ValidateCopyInput()
        {
            if (cboTitleForCopy.SelectedValue == null)
            {
                MessageBox.Show("Please select a book title for the copy.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (cboStatus.SelectedItem == null)
            {
                MessageBox.Show("Please select a status.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtShelfLocation.Text))
            {
                MessageBox.Show("Shelf location is required.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtShelfLocation.Focus();
                return false;
            }

            return true;
        }

        private void btnAddTitle_Click(object sender, EventArgs e)
        {
            if (!ValidateTitleInput())
            {
                return;
            }

            try
            {
                string sql = @"INSERT INTO BookTitle (Title, Author, ISBN, Category, YearPublished)
                               VALUES (@Title, @Author, @ISBN, @Category, @YearPublished)";

                DatabaseHelper.ExecuteNonQuery(sql,
                    new SqlParameter("@Title", txtTitle.Text.Trim()),
                    new SqlParameter("@Author", txtAuthor.Text.Trim()),
                    new SqlParameter("@ISBN", string.IsNullOrWhiteSpace(txtISBN.Text) ? (object)DBNull.Value : txtISBN.Text.Trim()),
                    new SqlParameter("@Category", txtCategory.Text.Trim()),
                    new SqlParameter("@YearPublished", (int)nudYear.Value));

                MessageBox.Show("Book title added successfully.", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadTitles();
                ClearTitleFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not add book title.\n" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdateTitle_Click(object sender, EventArgs e)
        {
            if (selectedTitleId == 0)
            {
                MessageBox.Show("Please select a book title to update.", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateTitleInput())
            {
                return;
            }

            try
            {
                string sql = @"UPDATE BookTitle
                               SET Title = @Title, Author = @Author, ISBN = @ISBN,
                                   Category = @Category, YearPublished = @YearPublished
                               WHERE TitleID = @TitleID";

                DatabaseHelper.ExecuteNonQuery(sql,
                    new SqlParameter("@Title", txtTitle.Text.Trim()),
                    new SqlParameter("@Author", txtAuthor.Text.Trim()),
                    new SqlParameter("@ISBN", string.IsNullOrWhiteSpace(txtISBN.Text) ? (object)DBNull.Value : txtISBN.Text.Trim()),
                    new SqlParameter("@Category", txtCategory.Text.Trim()),
                    new SqlParameter("@YearPublished", (int)nudYear.Value),
                    new SqlParameter("@TitleID", selectedTitleId));

                MessageBox.Show("Book title updated successfully.", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadTitles();
                LoadCopies();
                ClearTitleFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not update book title.\n" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteTitle_Click(object sender, EventArgs e)
        {
            if (selectedTitleId == 0)
            {
                MessageBox.Show("Please select a book title to delete.", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirm = MessageBox.Show(
                "Are you sure you want to delete this book title?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes)
            {
                return;
            }

            try
            {
                object copyCount = DatabaseHelper.ExecuteScalar(
                    "SELECT COUNT(*) FROM BookCopy WHERE TitleID = @TitleID",
                    new SqlParameter("@TitleID", selectedTitleId));

                if (Convert.ToInt32(copyCount) > 0)
                {
                    MessageBox.Show(
                        "This title cannot be deleted because physical copies exist for it.",
                        "Delete Not Allowed",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                DatabaseHelper.ExecuteNonQuery(
                    "DELETE FROM BookTitle WHERE TitleID = @TitleID",
                    new SqlParameter("@TitleID", selectedTitleId));

                MessageBox.Show("Book title deleted successfully.", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadTitles();
                ClearTitleFields();
            }
            catch (SqlException)
            {
                MessageBox.Show(
                    "This title cannot be deleted because related records exist.",
                    "Delete Not Allowed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not delete book title.\n" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddCopy_Click(object sender, EventArgs e)
        {
            if (!ValidateCopyInput())
            {
                return;
            }

            try
            {
                string sql = @"INSERT INTO BookCopy (TitleID, Status, ShelfLocation)
                               VALUES (@TitleID, @Status, @ShelfLocation)";

                DatabaseHelper.ExecuteNonQuery(sql,
                    new SqlParameter("@TitleID", Convert.ToInt32(cboTitleForCopy.SelectedValue)),
                    new SqlParameter("@Status", cboStatus.SelectedItem.ToString()),
                    new SqlParameter("@ShelfLocation", txtShelfLocation.Text.Trim()));

                MessageBox.Show("Book copy added successfully.", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadCopies();
                ClearCopyFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not add book copy.\n" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdateCopy_Click(object sender, EventArgs e)
        {
            if (selectedCopyId == 0)
            {
                MessageBox.Show("Please select a book copy to update.", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateCopyInput())
            {
                return;
            }

            try
            {
                string sql = @"UPDATE BookCopy
                               SET TitleID = @TitleID, Status = @Status, ShelfLocation = @ShelfLocation
                               WHERE CopyID = @CopyID";

                DatabaseHelper.ExecuteNonQuery(sql,
                    new SqlParameter("@TitleID", Convert.ToInt32(cboTitleForCopy.SelectedValue)),
                    new SqlParameter("@Status", cboStatus.SelectedItem.ToString()),
                    new SqlParameter("@ShelfLocation", txtShelfLocation.Text.Trim()),
                    new SqlParameter("@CopyID", selectedCopyId));

                MessageBox.Show("Book copy updated successfully.", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadCopies();
                ClearCopyFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not update book copy.\n" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteCopy_Click(object sender, EventArgs e)
        {
            if (selectedCopyId == 0)
            {
                MessageBox.Show("Please select a book copy to delete.", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirm = MessageBox.Show(
                "Are you sure you want to delete this book copy?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes)
            {
                return;
            }

            try
            {
                object loanCount = DatabaseHelper.ExecuteScalar(
                    "SELECT COUNT(*) FROM Loan WHERE CopyID = @CopyID",
                    new SqlParameter("@CopyID", selectedCopyId));

                if (Convert.ToInt32(loanCount) > 0)
                {
                    MessageBox.Show(
                        "This copy cannot be deleted because loan records exist for it.",
                        "Delete Not Allowed",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                DatabaseHelper.ExecuteNonQuery(
                    "DELETE FROM BookCopy WHERE CopyID = @CopyID",
                    new SqlParameter("@CopyID", selectedCopyId));

                MessageBox.Show("Book copy deleted successfully.", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadCopies();
                ClearCopyFields();
            }
            catch (SqlException)
            {
                MessageBox.Show(
                    "This copy cannot be deleted because related records exist.",
                    "Delete Not Allowed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not delete book copy.\n" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string searchText = txtSearch.Text.Trim();

                if (string.IsNullOrWhiteSpace(searchText))
                {
                    LoadTitles();
                    return;
                }

                string sql = @"SELECT TitleID, Title, Author, ISBN, Category, YearPublished
                               FROM BookTitle
                               WHERE Title LIKE @Search OR Author LIKE @Search
                               ORDER BY TitleID";

                dgvTitles.DataSource = DatabaseHelper.ExecuteSelect(sql,
                    new SqlParameter("@Search", "%" + searchText + "%"));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Search failed.\n" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClearTitle_Click(object sender, EventArgs e)
        {
            ClearTitleFields();
        }

        private void btnClearCopy_Click(object sender, EventArgs e)
        {
            ClearCopyFields();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadTitles();
            LoadCopies();
            ClearTitleFields();
            ClearCopyFields();
        }

        private void dgvTitles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            DataGridViewRow row = dgvTitles.Rows[e.RowIndex];
            selectedTitleId = Convert.ToInt32(row.Cells["TitleID"].Value);
            txtTitleID.Text = selectedTitleId.ToString();
            txtTitle.Text = row.Cells["Title"].Value.ToString();
            txtAuthor.Text = row.Cells["Author"].Value.ToString();
            txtISBN.Text = row.Cells["ISBN"].Value == DBNull.Value ? "" : row.Cells["ISBN"].Value.ToString();
            txtCategory.Text = row.Cells["Category"].Value.ToString();
            nudYear.Value = Convert.ToInt32(row.Cells["YearPublished"].Value);
        }

        private void dgvCopies_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            DataGridViewRow row = dgvCopies.Rows[e.RowIndex];
            selectedCopyId = Convert.ToInt32(row.Cells["CopyID"].Value);
            txtCopyID.Text = selectedCopyId.ToString();
            cboTitleForCopy.SelectedValue = Convert.ToInt32(row.Cells["TitleID"].Value);
            cboStatus.SelectedItem = row.Cells["Status"].Value.ToString();
            txtShelfLocation.Text = row.Cells["ShelfLocation"].Value.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
