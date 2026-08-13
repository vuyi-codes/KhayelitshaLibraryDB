namespace KhayelitshaLibraryApp
{
    partial class ReportsForm
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
            this.grpSearch = new System.Windows.Forms.GroupBox();
            this.btnSearchBooks = new System.Windows.Forms.Button();
            this.btnSearchMembers = new System.Windows.Forms.Button();
            this.txtBookSearch = new System.Windows.Forms.TextBox();
            this.txtMemberSearch = new System.Windows.Forms.TextBox();
            this.lblBookSearch = new System.Windows.Forms.Label();
            this.lblMemberSearch = new System.Windows.Forms.Label();
            this.lblSearchResults = new System.Windows.Forms.Label();
            this.dgvSearchResults = new System.Windows.Forms.DataGridView();
            this.lblOverdue = new System.Windows.Forms.Label();
            this.dgvOverdue = new System.Windows.Forms.DataGridView();
            this.lblLoansPerMember = new System.Windows.Forms.Label();
            this.dgvLoansPerMember = new System.Windows.Forms.DataGridView();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.grpSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchResults)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOverdue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoansPerMember)).BeginInit();
            this.SuspendLayout();
            //
            // grpSearch
            //
            this.grpSearch.Controls.Add(this.btnSearchBooks);
            this.grpSearch.Controls.Add(this.btnSearchMembers);
            this.grpSearch.Controls.Add(this.txtBookSearch);
            this.grpSearch.Controls.Add(this.txtMemberSearch);
            this.grpSearch.Controls.Add(this.lblBookSearch);
            this.grpSearch.Controls.Add(this.lblMemberSearch);
            this.grpSearch.Location = new System.Drawing.Point(20, 15);
            this.grpSearch.Name = "grpSearch";
            this.grpSearch.Size = new System.Drawing.Size(900, 90);
            this.grpSearch.TabIndex = 0;
            this.grpSearch.TabStop = false;
            this.grpSearch.Text = "Search";
            //
            // lblMemberSearch
            //
            this.lblMemberSearch.AutoSize = true;
            this.lblMemberSearch.Location = new System.Drawing.Point(15, 30);
            this.lblMemberSearch.Name = "lblMemberSearch";
            this.lblMemberSearch.Size = new System.Drawing.Size(145, 15);
            this.lblMemberSearch.TabIndex = 0;
            this.lblMemberSearch.Text = "Member Name or MemberID";
            //
            // txtMemberSearch
            //
            this.txtMemberSearch.Location = new System.Drawing.Point(180, 27);
            this.txtMemberSearch.Name = "txtMemberSearch";
            this.txtMemberSearch.Size = new System.Drawing.Size(220, 23);
            this.txtMemberSearch.TabIndex = 1;
            //
            // btnSearchMembers
            //
            this.btnSearchMembers.Location = new System.Drawing.Point(415, 25);
            this.btnSearchMembers.Name = "btnSearchMembers";
            this.btnSearchMembers.Size = new System.Drawing.Size(120, 28);
            this.btnSearchMembers.TabIndex = 2;
            this.btnSearchMembers.Text = "Search Members";
            this.btnSearchMembers.UseVisualStyleBackColor = true;
            this.btnSearchMembers.Click += new System.EventHandler(this.btnSearchMembers_Click);
            //
            // lblBookSearch
            //
            this.lblBookSearch.AutoSize = true;
            this.lblBookSearch.Location = new System.Drawing.Point(15, 60);
            this.lblBookSearch.Name = "lblBookSearch";
            this.lblBookSearch.Size = new System.Drawing.Size(100, 15);
            this.lblBookSearch.TabIndex = 3;
            this.lblBookSearch.Text = "Book Title or Author";
            //
            // txtBookSearch
            //
            this.txtBookSearch.Location = new System.Drawing.Point(180, 57);
            this.txtBookSearch.Name = "txtBookSearch";
            this.txtBookSearch.Size = new System.Drawing.Size(220, 23);
            this.txtBookSearch.TabIndex = 4;
            //
            // btnSearchBooks
            //
            this.btnSearchBooks.Location = new System.Drawing.Point(415, 55);
            this.btnSearchBooks.Name = "btnSearchBooks";
            this.btnSearchBooks.Size = new System.Drawing.Size(120, 28);
            this.btnSearchBooks.TabIndex = 5;
            this.btnSearchBooks.Text = "Search Books";
            this.btnSearchBooks.UseVisualStyleBackColor = true;
            this.btnSearchBooks.Click += new System.EventHandler(this.btnSearchBooks_Click);
            //
            // lblSearchResults
            //
            this.lblSearchResults.AutoSize = true;
            this.lblSearchResults.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblSearchResults.Location = new System.Drawing.Point(20, 115);
            this.lblSearchResults.Name = "lblSearchResults";
            this.lblSearchResults.Size = new System.Drawing.Size(90, 15);
            this.lblSearchResults.TabIndex = 1;
            this.lblSearchResults.Text = "Search Results";
            //
            // dgvSearchResults
            //
            this.dgvSearchResults.AllowUserToAddRows = false;
            this.dgvSearchResults.AllowUserToDeleteRows = false;
            this.dgvSearchResults.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSearchResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearchResults.Location = new System.Drawing.Point(20, 135);
            this.dgvSearchResults.Name = "dgvSearchResults";
            this.dgvSearchResults.ReadOnly = true;
            this.dgvSearchResults.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSearchResults.Size = new System.Drawing.Size(900, 130);
            this.dgvSearchResults.TabIndex = 2;
            //
            // lblOverdue
            //
            this.lblOverdue.AutoSize = true;
            this.lblOverdue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblOverdue.Location = new System.Drawing.Point(20, 280);
            this.lblOverdue.Name = "lblOverdue";
            this.lblOverdue.Size = new System.Drawing.Size(250, 15);
            this.lblOverdue.TabIndex = 3;
            this.lblOverdue.Text = "Overdue Loans Report";
            //
            // dgvOverdue
            //
            this.dgvOverdue.AllowUserToAddRows = false;
            this.dgvOverdue.AllowUserToDeleteRows = false;
            this.dgvOverdue.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOverdue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOverdue.Location = new System.Drawing.Point(20, 300);
            this.dgvOverdue.Name = "dgvOverdue";
            this.dgvOverdue.ReadOnly = true;
            this.dgvOverdue.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOverdue.Size = new System.Drawing.Size(440, 230);
            this.dgvOverdue.TabIndex = 4;
            //
            // lblLoansPerMember
            //
            this.lblLoansPerMember.AutoSize = true;
            this.lblLoansPerMember.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblLoansPerMember.Location = new System.Drawing.Point(480, 280);
            this.lblLoansPerMember.Name = "lblLoansPerMember";
            this.lblLoansPerMember.Size = new System.Drawing.Size(180, 15);
            this.lblLoansPerMember.TabIndex = 5;
            this.lblLoansPerMember.Text = "Loans Per Member Report";
            //
            // dgvLoansPerMember
            //
            this.dgvLoansPerMember.AllowUserToAddRows = false;
            this.dgvLoansPerMember.AllowUserToDeleteRows = false;
            this.dgvLoansPerMember.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLoansPerMember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoansPerMember.Location = new System.Drawing.Point(480, 300);
            this.dgvLoansPerMember.Name = "dgvLoansPerMember";
            this.dgvLoansPerMember.ReadOnly = true;
            this.dgvLoansPerMember.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLoansPerMember.Size = new System.Drawing.Size(440, 230);
            this.dgvLoansPerMember.TabIndex = 6;
            //
            // btnRefresh
            //
            this.btnRefresh.Location = new System.Drawing.Point(720, 545);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(90, 30);
            this.btnRefresh.TabIndex = 7;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            //
            // btnClose
            //
            this.btnClose.Location = new System.Drawing.Point(830, 545);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(90, 30);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            //
            // ReportsForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 590);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.dgvLoansPerMember);
            this.Controls.Add(this.lblLoansPerMember);
            this.Controls.Add(this.dgvOverdue);
            this.Controls.Add(this.lblOverdue);
            this.Controls.Add(this.dgvSearchResults);
            this.Controls.Add(this.lblSearchResults);
            this.Controls.Add(this.grpSearch);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ReportsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Search and Reports";
            this.Load += new System.EventHandler(this.ReportsForm_Load);
            this.grpSearch.ResumeLayout(false);
            this.grpSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchResults)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOverdue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoansPerMember)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.GroupBox grpSearch;
        private System.Windows.Forms.Button btnSearchBooks;
        private System.Windows.Forms.Button btnSearchMembers;
        private System.Windows.Forms.TextBox txtBookSearch;
        private System.Windows.Forms.TextBox txtMemberSearch;
        private System.Windows.Forms.Label lblBookSearch;
        private System.Windows.Forms.Label lblMemberSearch;
        private System.Windows.Forms.Label lblSearchResults;
        private System.Windows.Forms.DataGridView dgvSearchResults;
        private System.Windows.Forms.Label lblOverdue;
        private System.Windows.Forms.DataGridView dgvOverdue;
        private System.Windows.Forms.Label lblLoansPerMember;
        private System.Windows.Forms.DataGridView dgvLoansPerMember;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnClose;
    }
}
