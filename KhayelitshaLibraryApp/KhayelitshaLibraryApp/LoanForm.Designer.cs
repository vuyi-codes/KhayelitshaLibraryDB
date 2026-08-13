namespace KhayelitshaLibraryApp
{
    partial class LoanForm
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
            this.grpIssue = new System.Windows.Forms.GroupBox();
            this.dtpDueDate = new System.Windows.Forms.DateTimePicker();
            this.dtpLoanDate = new System.Windows.Forms.DateTimePicker();
            this.cboStaff = new System.Windows.Forms.ComboBox();
            this.cboCopy = new System.Windows.Forms.ComboBox();
            this.cboMember = new System.Windows.Forms.ComboBox();
            this.lblDueDate = new System.Windows.Forms.Label();
            this.lblLoanDate = new System.Windows.Forms.Label();
            this.lblStaff = new System.Windows.Forms.Label();
            this.lblCopy = new System.Windows.Forms.Label();
            this.lblMember = new System.Windows.Forms.Label();
            this.btnIssue = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.lblFilter = new System.Windows.Forms.Label();
            this.cboFilter = new System.Windows.Forms.ComboBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblLoans = new System.Windows.Forms.Label();
            this.dgvLoans = new System.Windows.Forms.DataGridView();
            this.grpIssue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoans)).BeginInit();
            this.SuspendLayout();
            //
            // grpIssue
            //
            this.grpIssue.Controls.Add(this.btnReturn);
            this.grpIssue.Controls.Add(this.btnIssue);
            this.grpIssue.Controls.Add(this.dtpDueDate);
            this.grpIssue.Controls.Add(this.dtpLoanDate);
            this.grpIssue.Controls.Add(this.cboStaff);
            this.grpIssue.Controls.Add(this.cboCopy);
            this.grpIssue.Controls.Add(this.cboMember);
            this.grpIssue.Controls.Add(this.lblDueDate);
            this.grpIssue.Controls.Add(this.lblLoanDate);
            this.grpIssue.Controls.Add(this.lblStaff);
            this.grpIssue.Controls.Add(this.lblCopy);
            this.grpIssue.Controls.Add(this.lblMember);
            this.grpIssue.Location = new System.Drawing.Point(20, 15);
            this.grpIssue.Name = "grpIssue";
            this.grpIssue.Size = new System.Drawing.Size(860, 180);
            this.grpIssue.TabIndex = 0;
            this.grpIssue.TabStop = false;
            this.grpIssue.Text = "Issue and Return";
            //
            // lblMember
            //
            this.lblMember.AutoSize = true;
            this.lblMember.Location = new System.Drawing.Point(20, 35);
            this.lblMember.Name = "lblMember";
            this.lblMember.Size = new System.Drawing.Size(53, 15);
            this.lblMember.TabIndex = 0;
            this.lblMember.Text = "Member";
            //
            // cboMember
            //
            this.cboMember.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMember.FormattingEnabled = true;
            this.cboMember.Location = new System.Drawing.Point(110, 32);
            this.cboMember.Name = "cboMember";
            this.cboMember.Size = new System.Drawing.Size(280, 23);
            this.cboMember.TabIndex = 1;
            //
            // lblCopy
            //
            this.lblCopy.AutoSize = true;
            this.lblCopy.Location = new System.Drawing.Point(20, 70);
            this.lblCopy.Name = "lblCopy";
            this.lblCopy.Size = new System.Drawing.Size(85, 15);
            this.lblCopy.TabIndex = 2;
            this.lblCopy.Text = "Available Copy";
            //
            // cboCopy
            //
            this.cboCopy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCopy.FormattingEnabled = true;
            this.cboCopy.Location = new System.Drawing.Point(110, 67);
            this.cboCopy.Name = "cboCopy";
            this.cboCopy.Size = new System.Drawing.Size(280, 23);
            this.cboCopy.TabIndex = 3;
            //
            // lblStaff
            //
            this.lblStaff.AutoSize = true;
            this.lblStaff.Location = new System.Drawing.Point(20, 105);
            this.lblStaff.Name = "lblStaff";
            this.lblStaff.Size = new System.Drawing.Size(82, 15);
            this.lblStaff.TabIndex = 4;
            this.lblStaff.Text = "Staff Member";
            //
            // cboStaff
            //
            this.cboStaff.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStaff.FormattingEnabled = true;
            this.cboStaff.Location = new System.Drawing.Point(110, 102);
            this.cboStaff.Name = "cboStaff";
            this.cboStaff.Size = new System.Drawing.Size(280, 23);
            this.cboStaff.TabIndex = 5;
            //
            // lblLoanDate
            //
            this.lblLoanDate.AutoSize = true;
            this.lblLoanDate.Location = new System.Drawing.Point(430, 35);
            this.lblLoanDate.Name = "lblLoanDate";
            this.lblLoanDate.Size = new System.Drawing.Size(61, 15);
            this.lblLoanDate.TabIndex = 6;
            this.lblLoanDate.Text = "Loan Date";
            //
            // dtpLoanDate
            //
            this.dtpLoanDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpLoanDate.Location = new System.Drawing.Point(520, 32);
            this.dtpLoanDate.Name = "dtpLoanDate";
            this.dtpLoanDate.Size = new System.Drawing.Size(150, 23);
            this.dtpLoanDate.TabIndex = 7;
            //
            // lblDueDate
            //
            this.lblDueDate.AutoSize = true;
            this.lblDueDate.Location = new System.Drawing.Point(430, 70);
            this.lblDueDate.Name = "lblDueDate";
            this.lblDueDate.Size = new System.Drawing.Size(55, 15);
            this.lblDueDate.TabIndex = 8;
            this.lblDueDate.Text = "Due Date";
            //
            // dtpDueDate
            //
            this.dtpDueDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDueDate.Location = new System.Drawing.Point(520, 67);
            this.dtpDueDate.Name = "dtpDueDate";
            this.dtpDueDate.Size = new System.Drawing.Size(150, 23);
            this.dtpDueDate.TabIndex = 9;
            //
            // btnIssue
            //
            this.btnIssue.Location = new System.Drawing.Point(430, 110);
            this.btnIssue.Name = "btnIssue";
            this.btnIssue.Size = new System.Drawing.Size(140, 40);
            this.btnIssue.TabIndex = 10;
            this.btnIssue.Text = "Issue Book";
            this.btnIssue.UseVisualStyleBackColor = true;
            this.btnIssue.Click += new System.EventHandler(this.btnIssue_Click);
            //
            // btnReturn
            //
            this.btnReturn.Location = new System.Drawing.Point(590, 110);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(140, 40);
            this.btnReturn.TabIndex = 11;
            this.btnReturn.Text = "Return Book";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            //
            // lblFilter
            //
            this.lblFilter.AutoSize = true;
            this.lblFilter.Location = new System.Drawing.Point(20, 210);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(65, 15);
            this.lblFilter.TabIndex = 1;
            this.lblFilter.Text = "Filter Loans";
            //
            // cboFilter
            //
            this.cboFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFilter.FormattingEnabled = true;
            this.cboFilter.Location = new System.Drawing.Point(100, 207);
            this.cboFilter.Name = "cboFilter";
            this.cboFilter.Size = new System.Drawing.Size(150, 23);
            this.cboFilter.TabIndex = 2;
            //
            // btnFilter
            //
            this.btnFilter.Location = new System.Drawing.Point(265, 204);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(90, 28);
            this.btnFilter.TabIndex = 3;
            this.btnFilter.Text = "Apply Filter";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            //
            // btnRefresh
            //
            this.btnRefresh.Location = new System.Drawing.Point(370, 204);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(90, 28);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            //
            // btnClose
            //
            this.btnClose.Location = new System.Drawing.Point(790, 204);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(90, 28);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            //
            // lblLoans
            //
            this.lblLoans.AutoSize = true;
            this.lblLoans.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblLoans.Location = new System.Drawing.Point(20, 245);
            this.lblLoans.Name = "lblLoans";
            this.lblLoans.Size = new System.Drawing.Size(180, 15);
            this.lblLoans.TabIndex = 6;
            this.lblLoans.Text = "Current and Historical Loans";
            //
            // dgvLoans
            //
            this.dgvLoans.AllowUserToAddRows = false;
            this.dgvLoans.AllowUserToDeleteRows = false;
            this.dgvLoans.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLoans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoans.Location = new System.Drawing.Point(20, 265);
            this.dgvLoans.MultiSelect = false;
            this.dgvLoans.Name = "dgvLoans";
            this.dgvLoans.ReadOnly = true;
            this.dgvLoans.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLoans.Size = new System.Drawing.Size(860, 310);
            this.dgvLoans.TabIndex = 7;
            this.dgvLoans.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLoans_CellClick);
            //
            // LoanForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.dgvLoans);
            this.Controls.Add(this.lblLoans);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.cboFilter);
            this.Controls.Add(this.lblFilter);
            this.Controls.Add(this.grpIssue);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "LoanForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Loan and Return Management";
            this.Load += new System.EventHandler(this.LoanForm_Load);
            this.grpIssue.ResumeLayout(false);
            this.grpIssue.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoans)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.GroupBox grpIssue;
        private System.Windows.Forms.DateTimePicker dtpDueDate;
        private System.Windows.Forms.DateTimePicker dtpLoanDate;
        private System.Windows.Forms.ComboBox cboStaff;
        private System.Windows.Forms.ComboBox cboCopy;
        private System.Windows.Forms.ComboBox cboMember;
        private System.Windows.Forms.Label lblDueDate;
        private System.Windows.Forms.Label lblLoanDate;
        private System.Windows.Forms.Label lblStaff;
        private System.Windows.Forms.Label lblCopy;
        private System.Windows.Forms.Label lblMember;
        private System.Windows.Forms.Button btnIssue;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.ComboBox cboFilter;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblLoans;
        private System.Windows.Forms.DataGridView dgvLoans;
    }
}
