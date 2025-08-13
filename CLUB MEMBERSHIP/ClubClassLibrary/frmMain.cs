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

        private void MemberBtn_Click(object sender, EventArgs e)
        {
            frmMembers mb = new frmMembers();
            mb.ShowDialog();
        }

        private void MembershipsBtn_Click(object sender, EventArgs e)
        {
            frmMemberships mship = new frmMemberships();
            mship.ShowDialog();
        }

        private void PayementBtn_Click(object sender, EventArgs e)
        {
            frmPayments p = new frmPayments();
            p.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
