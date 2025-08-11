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
using ClubClassLibrary.Repositories;
using ClubClassLibrary.Models;


namespace ClubUI
{
    public partial class frmMembershipTypes : Form
    {
        MembershipTypeRepository repoMembershipType = new MembershipTypeRepository();
        public frmMembershipTypes()
        {
            InitializeComponent();
        }

        private async void ViewMembershipTypes()
        {
            var Data = repoMembershipType.GetAllMembershipTypes();
            DGV.DataSource = Data.Select(mt => new
            {
                mt.Name,
                mt.Description,
                mt.BasePrice
            }).ToList();

            DGV.Columns[0].HeaderText = "Membership Name";
            DGV.Columns[1].HeaderText = "Description";
            DGV.Columns[2].HeaderText = "Membership Price";
        }

        private void MembershipTypes_Load(object sender, EventArgs e)
        {
            ViewMembershipTypes();
        }

        private bool ValidateData()
        {
            bool valid = false;
            if (MstNameTB.Text == "")
            {
                valid = true;
            }
            if (MstDescriptionTB.Text == "")
            {
                valid = true;
            }
            if (MstBasePriceTB.Text == "")
            {
                valid = true;
            }

            return valid;
        }

        private void ClearData()
        {
            MstNameTB.Text = "";
            MstDescriptionTB.Text = "";
            MstBasePriceTB.Text = "";
        }

        private async void addBtn_Click(object sender, EventArgs e)
        {
            if (ValidateData())
            {
                return;
            }

            await repoMembershipType.AddMembershipTypeAsync(new MembershipType
            {
                Name = MstNameTB.Text,
                Description = MstDescriptionTB.Text,
                BasePrice = decimal.Parse(MstBasePriceTB.Text)
            });

            ClearData();
            MessageBox.Show("ADDED SUCCESSFULLY!", "CONFIRMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ViewMembershipTypes();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            ClearData();
        }
    }
}
