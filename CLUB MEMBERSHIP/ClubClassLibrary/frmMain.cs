namespace ClubUI
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAbout about = new frmAbout();
            about.ShowDialog();
        }

        private void ViewMembershipTypes_Click(object sender, EventArgs e)
        {
             frmMembershipTypes mbt = new frmMembershipTypes();
             mbt.ShowDialog();
        }
    }
}
