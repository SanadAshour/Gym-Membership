using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClubClassLibrary.Data;

namespace ClubUI
{
    public partial class frmMembershipTypes : Form
    {
        public frmMembershipTypes()
        {
            InitializeComponent();
        }

        private void MembershipTypes_Load(object sender, EventArgs e)
        {
            AppDbContext ADC = new AppDbContext();
            DGV.DataSource = ADC.MembershipTypes.ToList();
        }
    }
}
