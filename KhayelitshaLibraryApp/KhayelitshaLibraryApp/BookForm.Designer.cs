namespace KhayelitshaLibraryApp
{
    partial class BookForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.grpTitle = new System.Windows.Forms.GroupBox();
            this.nudYear = new System.Windows.Forms.NumericUpDown();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtTitleID = new System.Windows.Forms.TextBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblISBN = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblTitleID = new System.Windows.Forms.Label();
            this.btnAddTitle = new System.Windows.Forms.Button();
            this.btnUpdateTitle = new System.Windows.Forms.Button();
            this.btnDeleteTitle = new System.Windows.Forms.Button();
            this.btnClearTitle = new System.Windows.Forms.Button();
            this.grpCopy = new System.Windows.Forms.GroupBox();
            this.txtShelfLocation = new System.Windows.Forms.TextBox();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.cboTitleForCopy = new System.Windows.Forms.ComboBox();
            this.txtCopyID = new System.Windows.Forms.TextBox();
            this.lblShelf = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblCopyTitle = new System.Windows.Forms.Label();
            this.lblCopyID = new System.Windows.Forms.Label();
            this.btnAddCopy = new System.Windows.Forms.Button();
            this.btnUpdateCopy = new System.Windows.Forms.Button();
            this.btnDeleteCopy = new System.Windows.Forms.Button();
            this.btnClearCopy = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblTitlesGrid = new System.Windows.Forms.Label();
            this.dgvTitles = new System.Windows.Forms.DataGridView();
            this.lblCopiesGrid = new System.Windows.Forms.Label();
            this.dgvCopies = new System.Windows.Forms.DataGridView();
            this.grpTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudYear)).BeginInit();
            this.grpCopy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTitles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCopies)).BeginInit();
            this.SuspendLayout();
            //
            // grpTitle
            //
            this.grpTitle.Controls.Add(this.btnClearTitle);
            this.grpTitle.Controls.Add(this.btnDeleteTitle);
            this.grpTitle.Controls.Add(this.btnUpdateTitle);
            this.grpTitle.Controls.Add(this.btnAddTitle);
            this.grpTitle.Controls.Add(this.nudYear);
            this.grpTitle.Controls.Add(this.txtCategory);
            this.grpTitle.Controls.Add(this.txtISBN);
            this.grpTitle.Controls.Add(this.txtAuthor);
            this.grpTitle.Controls.Add(this.txtTitle);
            this.grpTitle.Controls.Add(this.txtTitleID);
            this.grpTitle.Controls.Add(this.lblYear);
            this.grpTitle.Controls.Add(this.lblCategory);
            this.grpTitle.Controls.Add(this.lblISBN);
            this.grpTitle.Controls.Add(this.lblAuthor);
            this.grpTitle.Controls.Add(this.lblTitle);
            this.grpTitle.Controls.Add(this.lblTitleID);
            this.grpTitle.Location = new System.Drawing.Point(15, 15);
            this.grpTitle.Name = "grpTitle";
            this.grpTitle.Size = new System.Drawing.Size(460, 250);
            this.grpTitle.TabIndex = 0;
            this.grpTitle.TabStop = false;
            this.grpTitle.Text = "Book Title Details";
            //
            // lblTitleID
            //
            this.lblTitleID.AutoSize = true;
            this.lblTitleID.Location = new System.Drawing.Point(15, 30);
            this.lblTitleID.Name = "lblTitleID";
            this.lblTitleID.Size = new System.Drawing.Size(45, 15);
            this.lblTitleID.TabIndex = 0;
            this.lblTitleID.Text = "TitleID";
            //
            // txtTitleID
            //
            this.txtTitleID.Location = new System.Drawing.Point(110, 27);
            this.txtTitleID.Name = "txtTitleID";
            this.txtTitleID.ReadOnly = true;
            this.txtTitleID.Size = new System.Drawing.Size(180, 23);
            this.txtTitleID.TabIndex = 1;
            //
            // lblTitle
            //
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(15, 60);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(30, 15);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Title";
            //
            // txtTitle
            //
            this.txtTitle.Location = new System.Drawing.Point(110, 57);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(320, 23);
            this.txtTitle.TabIndex = 3;
            //
            // lblAuthor
            //
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(15, 90);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(47, 15);
            this.lblAuthor.TabIndex = 4;
            this.lblAuthor.Text = "Author";
            //
            // txtAuthor
            //
            this.txtAuthor.Location = new System.Drawing.Point(110, 87);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(320, 23);
            this.txtAuthor.TabIndex = 5;
            //
            // lblISBN
            //
            this.lblISBN.AutoSize = true;
            this.lblISBN.Location = new System.Drawing.Point(15, 120);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(32, 15);
            this.lblISBN.TabIndex = 6;
            this.lblISBN.Text = "ISBN";
            //
            // txtISBN
            //
            this.txtISBN.Location = new System.Drawing.Point(110, 117);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(320, 23);
            this.txtISBN.TabIndex = 7;
            //
            // lblCategory
            //
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(15, 150);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(55, 15);
            this.lblCategory.TabIndex = 8;
            this.lblCategory.Text = "Category";
            //
            // txtCategory
            //
            this.txtCategory.Location = new System.Drawing.Point(110, 147);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(180, 23);
            this.txtCategory.TabIndex = 9;
            //
            // lblYear
            //
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(15, 180);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(90, 15);
            this.lblYear.TabIndex = 10;
            this.lblYear.Text = "Year Published";
            //
            // nudYear
            //
            this.nudYear.Location = new System.Drawing.Point(110, 178);
            this.nudYear.Maximum = new decimal(new int[] { 2100, 0, 0, 0 });
            this.nudYear.Minimum = new decimal(new int[] { 1900, 0, 0, 0 });
            this.nudYear.Name = "nudYear";
            this.nudYear.Size = new System.Drawing.Size(120, 23);
            this.nudYear.TabIndex = 11;
            this.nudYear.Value = new decimal(new int[] { 2000, 0, 0, 0 });
            //
            // btnAddTitle
            //
            this.btnAddTitle.Location = new System.Drawing.Point(15, 210);
            this.btnAddTitle.Name = "btnAddTitle";
            this.btnAddTitle.Size = new System.Drawing.Size(95, 28);
            this.btnAddTitle.TabIndex = 12;
            this.btnAddTitle.Text = "Add Title";
            this.btnAddTitle.UseVisualStyleBackColor = true;
            this.btnAddTitle.Click += new System.EventHandler(this.btnAddTitle_Click);
            //
            // btnUpdateTitle
            //
            this.btnUpdateTitle.Location = new System.Drawing.Point(120, 210);
            this.btnUpdateTitle.Name = "btnUpdateTitle";
            this.btnUpdateTitle.Size = new System.Drawing.Size(95, 28);
            this.btnUpdateTitle.TabIndex = 13;
            this.btnUpdateTitle.Text = "Update Title";
            this.btnUpdateTitle.UseVisualStyleBackColor = true;
            this.btnUpdateTitle.Click += new System.EventHandler(this.btnUpdateTitle_Click);
            //
            // btnDeleteTitle
            //
            this.btnDeleteTitle.Location = new System.Drawing.Point(225, 210);
            this.btnDeleteTitle.Name = "btnDeleteTitle";
            this.btnDeleteTitle.Size = new System.Drawing.Size(95, 28);
            this.btnDeleteTitle.TabIndex = 14;
            this.btnDeleteTitle.Text = "Delete Title";
            this.btnDeleteTitle.UseVisualStyleBackColor = true;
            this.btnDeleteTitle.Click += new System.EventHandler(this.btnDeleteTitle_Click);
            //
            // btnClearTitle
            //
            this.btnClearTitle.Location = new System.Drawing.Point(330, 210);
            this.btnClearTitle.Name = "btnClearTitle";
            this.btnClearTitle.Size = new System.Drawing.Size(95, 28);
            this.btnClearTitle.TabIndex = 15;
            this.btnClearTitle.Text = "Clear";
            this.btnClearTitle.UseVisualStyleBackColor = true;
            this.btnClearTitle.Click += new System.EventHandler(this.btnClearTitle_Click);
            //
            // grpCopy
            //
            this.grpCopy.Controls.Add(this.btnClearCopy);
            this.grpCopy.Controls.Add(this.btnDeleteCopy);
            this.grpCopy.Controls.Add(this.btnUpdateCopy);
            this.grpCopy.Controls.Add(this.btnAddCopy);
            this.grpCopy.Controls.Add(this.txtShelfLocation);
            this.grpCopy.Controls.Add(this.cboStatus);
            this.grpCopy.Controls.Add(this.cboTitleForCopy);
            this.grpCopy.Controls.Add(this.txtCopyID);
            this.grpCopy.Controls.Add(this.lblShelf);
            this.grpCopy.Controls.Add(this.lblStatus);
            this.grpCopy.Controls.Add(this.lblCopyTitle);
            this.grpCopy.Controls.Add(this.lblCopyID);
            this.grpCopy.Location = new System.Drawing.Point(490, 15);
            this.grpCopy.Name = "grpCopy";
            this.grpCopy.Size = new System.Drawing.Size(430, 250);
            this.grpCopy.TabIndex = 1;
            this.grpCopy.TabStop = false;
            this.grpCopy.Text = "Physical Copy Details";
            //
            // lblCopyID
            //
            this.lblCopyID.AutoSize = true;
            this.lblCopyID.Location = new System.Drawing.Point(15, 30);
            this.lblCopyID.Name = "lblCopyID";
            this.lblCopyID.Size = new System.Drawing.Size(48, 15);
            this.lblCopyID.TabIndex = 0;
            this.lblCopyID.Text = "CopyID";
            //
            // txtCopyID
            //
            this.txtCopyID.Location = new System.Drawing.Point(120, 27);
            this.txtCopyID.Name = "txtCopyID";
            this.txtCopyID.ReadOnly = true;
            this.txtCopyID.Size = new System.Drawing.Size(150, 23);
            this.txtCopyID.TabIndex = 1;
            //
            // lblCopyTitle
            //
            this.lblCopyTitle.AutoSize = true;
            this.lblCopyTitle.Location = new System.Drawing.Point(15, 65);
            this.lblCopyTitle.Name = "lblCopyTitle";
            this.lblCopyTitle.Size = new System.Drawing.Size(60, 15);
            this.lblCopyTitle.TabIndex = 2;
            this.lblCopyTitle.Text = "Book Title";
            //
            // cboTitleForCopy
            //
            this.cboTitleForCopy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTitleForCopy.FormattingEnabled = true;
            this.cboTitleForCopy.Location = new System.Drawing.Point(120, 62);
            this.cboTitleForCopy.Name = "cboTitleForCopy";
            this.cboTitleForCopy.Size = new System.Drawing.Size(280, 23);
            this.cboTitleForCopy.TabIndex = 3;
            //
            // lblStatus
            //
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(15, 100);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(39, 15);
            this.lblStatus.TabIndex = 4;
            this.lblStatus.Text = "Status";
            //
            // cboStatus
            //
            this.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Location = new System.Drawing.Point(120, 97);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(180, 23);
            this.cboStatus.TabIndex = 5;
            //
            // lblShelf
            //
            this.lblShelf.AutoSize = true;
            this.lblShelf.Location = new System.Drawing.Point(15, 135);
            this.lblShelf.Name = "lblShelf";
            this.lblShelf.Size = new System.Drawing.Size(85, 15);
            this.lblShelf.TabIndex = 6;
            this.lblShelf.Text = "Shelf Location";
            //
            // txtShelfLocation
            //
            this.txtShelfLocation.Location = new System.Drawing.Point(120, 132);
            this.txtShelfLocation.Name = "txtShelfLocation";
            this.txtShelfLocation.Size = new System.Drawing.Size(180, 23);
            this.txtShelfLocation.TabIndex = 7;
            //
            // btnAddCopy
            //
            this.btnAddCopy.Location = new System.Drawing.Point(15, 180);
            this.btnAddCopy.Name = "btnAddCopy";
            this.btnAddCopy.Size = new System.Drawing.Size(95, 28);
            this.btnAddCopy.TabIndex = 8;
            this.btnAddCopy.Text = "Add Copy";
            this.btnAddCopy.UseVisualStyleBackColor = true;
            this.btnAddCopy.Click += new System.EventHandler(this.btnAddCopy_Click);
            //
            // btnUpdateCopy
            //
            this.btnUpdateCopy.Location = new System.Drawing.Point(120, 180);
            this.btnUpdateCopy.Name = "btnUpdateCopy";
            this.btnUpdateCopy.Size = new System.Drawing.Size(95, 28);
            this.btnUpdateCopy.TabIndex = 9;
            this.btnUpdateCopy.Text = "Update Copy";
            this.btnUpdateCopy.UseVisualStyleBackColor = true;
            this.btnUpdateCopy.Click += new System.EventHandler(this.btnUpdateCopy_Click);
            //
            // btnDeleteCopy
            //
            this.btnDeleteCopy.Location = new System.Drawing.Point(225, 180);
            this.btnDeleteCopy.Name = "btnDeleteCopy";
            this.btnDeleteCopy.Size = new System.Drawing.Size(95, 28);
            this.btnDeleteCopy.TabIndex = 10;
            this.btnDeleteCopy.Text = "Delete Copy";
            this.btnDeleteCopy.UseVisualStyleBackColor = true;
            this.btnDeleteCopy.Click += new System.EventHandler(this.btnDeleteCopy_Click);
            //
            // btnClearCopy
            //
            this.btnClearCopy.Location = new System.Drawing.Point(330, 180);
            this.btnClearCopy.Name = "btnClearCopy";
            this.btnClearCopy.Size = new System.Drawing.Size(70, 28);
            this.btnClearCopy.TabIndex = 11;
            this.btnClearCopy.Text = "Clear";
            this.btnClearCopy.UseVisualStyleBackColor = true;
            this.btnClearCopy.Click += new System.EventHandler(this.btnClearCopy_Click);
            //
            // lblSearch
            //
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(15, 280);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(145, 15);
            this.lblSearch.TabIndex = 2;
            this.lblSearch.Text = "Search by Title or Author";
            //
            // txtSearch
            //
            this.txtSearch.Location = new System.Drawing.Point(170, 277);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(250, 23);
            this.txtSearch.TabIndex = 3;
            //
            // btnSearch
            //
            this.btnSearch.Location = new System.Drawing.Point(430, 274);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(90, 28);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            //
            // btnRefresh
            //
            this.btnRefresh.Location = new System.Drawing.Point(530, 274);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(90, 28);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            //
            // btnClose
            //
            this.btnClose.Location = new System.Drawing.Point(830, 274);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(90, 28);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            //
            // lblTitlesGrid
            //
            this.lblTitlesGrid.AutoSize = true;
            this.lblTitlesGrid.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTitlesGrid.Location = new System.Drawing.Point(15, 315);
            this.lblTitlesGrid.Name = "lblTitlesGrid";
            this.lblTitlesGrid.Size = new System.Drawing.Size(70, 15);
            this.lblTitlesGrid.TabIndex = 7;
            this.lblTitlesGrid.Text = "Book Titles";
            //
            // dgvTitles
            //
            this.dgvTitles.AllowUserToAddRows = false;
            this.dgvTitles.AllowUserToDeleteRows = false;
            this.dgvTitles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTitles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTitles.Location = new System.Drawing.Point(15, 335);
            this.dgvTitles.MultiSelect = false;
            this.dgvTitles.Name = "dgvTitles";
            this.dgvTitles.ReadOnly = true;
            this.dgvTitles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTitles.Size = new System.Drawing.Size(905, 140);
            this.dgvTitles.TabIndex = 8;
            this.dgvTitles.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTitles_CellClick);
            //
            // lblCopiesGrid
            //
            this.lblCopiesGrid.AutoSize = true;
            this.lblCopiesGrid.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCopiesGrid.Location = new System.Drawing.Point(15, 485);
            this.lblCopiesGrid.Name = "lblCopiesGrid";
            this.lblCopiesGrid.Size = new System.Drawing.Size(80, 15);
            this.lblCopiesGrid.TabIndex = 9;
            this.lblCopiesGrid.Text = "Book Copies";
            //
            // dgvCopies
            //
            this.dgvCopies.AllowUserToAddRows = false;
            this.dgvCopies.AllowUserToDeleteRows = false;
            this.dgvCopies.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCopies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCopies.Location = new System.Drawing.Point(15, 505);
            this.dgvCopies.MultiSelect = false;
            this.dgvCopies.Name = "dgvCopies";
            this.dgvCopies.ReadOnly = true;
            this.dgvCopies.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCopies.Size = new System.Drawing.Size(905, 140);
            this.dgvCopies.TabIndex = 10;
            this.dgvCopies.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCopies_CellClick);
            //
            // BookForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 660);
            this.Controls.Add(this.dgvCopies);
            this.Controls.Add(this.lblCopiesGrid);
            this.Controls.Add(this.dgvTitles);
            this.Controls.Add(this.lblTitlesGrid);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.grpCopy);
            this.Controls.Add(this.grpTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "BookForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Book Title and Copy Management";
            this.Load += new System.EventHandler(this.BookForm_Load);
            this.grpTitle.ResumeLayout(false);
            this.grpTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudYear)).EndInit();
            this.grpCopy.ResumeLayout(false);
            this.grpCopy.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTitles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCopies)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.GroupBox grpTitle;
        private System.Windows.Forms.NumericUpDown nudYear;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtTitleID;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblTitleID;
        private System.Windows.Forms.Button btnAddTitle;
        private System.Windows.Forms.Button btnUpdateTitle;
        private System.Windows.Forms.Button btnDeleteTitle;
        private System.Windows.Forms.Button btnClearTitle;
        private System.Windows.Forms.GroupBox grpCopy;
        private System.Windows.Forms.TextBox txtShelfLocation;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.ComboBox cboTitleForCopy;
        private System.Windows.Forms.TextBox txtCopyID;
        private System.Windows.Forms.Label lblShelf;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblCopyTitle;
        private System.Windows.Forms.Label lblCopyID;
        private System.Windows.Forms.Button btnAddCopy;
        private System.Windows.Forms.Button btnUpdateCopy;
        private System.Windows.Forms.Button btnDeleteCopy;
        private System.Windows.Forms.Button btnClearCopy;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblTitlesGrid;
        private System.Windows.Forms.DataGridView dgvTitles;
        private System.Windows.Forms.Label lblCopiesGrid;
        private System.Windows.Forms.DataGridView dgvCopies;
    }
}
