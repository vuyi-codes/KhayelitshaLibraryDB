using System;
using System.Drawing;
using System.Windows.Forms;

namespace KhayelitshaLibraryApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Quick connection check when the app starts
            DatabaseHelper.TestConnection();
        }

        private void btnMembers_Click(object sender, EventArgs e)
        {
            MemberForm form = new MemberForm();
            form.ShowDialog();
        }

        private void btnBooks_Click(object sender, EventArgs e)
        {
            BookForm form = new BookForm();
            form.ShowDialog();
        }

        private void btnLoans_Click(object sender, EventArgs e)
        {
            LoanForm form = new LoanForm();
            form.ShowDialog();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            ReportsForm form = new ReportsForm();
            form.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void membersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnMembers_Click(sender, e);
        }

        private void booksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnBooks_Click(sender, e);
        }

        private void loansToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnLoans_Click(sender, e);
        }

        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnReports_Click(sender, e);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnExit_Click(sender, e);
        }

        private void lblSubtitle_Click(object sender, EventArgs e)
        {

        }
    }
}
