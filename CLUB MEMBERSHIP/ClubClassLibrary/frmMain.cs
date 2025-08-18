using System.Globalization;
using System.Resources;
using System.Threading;

namespace ClubUI
{
    public partial class frmMain : Form
    {
        ResourceManager rm;
        public frmMain()
        {
            InitializeComponent();
            rm = new ResourceManager("ClubUI.ResFiles.Strings", typeof(frmMain).Assembly);

            SetLanguage("en"); // Default
        }

        private void SetLanguage(string culture)
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(culture);
            //rm = new ResourceManager("ClubUI.Strings", typeof(frmMain).Assembly);

            this.Text = rm.GetString("FormTitle");
            label1.Text = rm.GetString("LabelMain");
            MemberBtn.Text = rm.GetString("BtnMembers");
            MembershipsBtn.Text = rm.GetString("BtnMemberships");
            PayementBtn.Text = rm.GetString("BtnPayments");
            ViewMembershipTypes.Text = rm.GetString("BtnViewTypes");


            if (culture == "ar")
            {
                this.RightToLeft = RightToLeft.Yes;
                this.RightToLeftLayout = true;
            }
            else
            {
                this.RightToLeft = RightToLeft.No;
                this.RightToLeftLayout = false;
            }
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

        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetLanguage("en");
        }

        private void arabicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetLanguage("ar");
        }

        private void inQuiriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInquiries IQ = new frmInquiries();
            IQ.ShowDialog();
        }
    }
}
