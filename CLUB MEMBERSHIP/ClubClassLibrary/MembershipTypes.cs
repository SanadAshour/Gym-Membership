using ClubClassLibrary.Data;
using ClubClassLibrary.Models;
using ClubClassLibrary.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace ClubUI
{
    public partial class frmMembershipTypes : Form
    {
        MembershipTypeRepository repoMembershipType = new MembershipTypeRepository();
        public frmMembershipTypes()
        {
            InitializeComponent();
        }
        private int SelectedId;


        private async void ViewMembershipTypes()
        {
            var data = await repoMembershipType.GetAllMembershipTypesAsync();
            DGV.DataSource = data.Select(mt => new
            {
                mt.Id,
                mt.Name,
                mt.Description,
                mt.BasePrice
            }).ToList();
            DGV.Columns[0].Visible = false;
            DGV.Columns[1].HeaderText = "Name";
            DGV.Columns[2].HeaderText = "Description";
            DGV.Columns[3].HeaderText = "Price";
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

        private async void DGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0) // Check if a real cell was clicked
            {

                int Id = (int)DGV.Rows[e.RowIndex].Cells[0].Value;
                var item = await repoMembershipType.GetMembershipTypeByIdAsync(Id);
                MstNameTB.Text = item.Name;
                MstDescriptionTB.Text = item.Description;
                MstBasePriceTB.Text = item.BasePrice.ToString();
                SelectedId = Id;

            }
        }

        private async void updateBtn_Click(object sender, EventArgs e)
        {
            var itemToUpdate = await repoMembershipType.GetMembershipTypeByIdAsync(SelectedId);
            itemToUpdate.Name = MstNameTB.Text;
            itemToUpdate.Description = MstDescriptionTB.Text;
            itemToUpdate.BasePrice = decimal.Parse(MstBasePriceTB.Text);
            await repoMembershipType.UpdateMembershipTypeAsync(itemToUpdate);

            ClearData();
            MessageBox.Show("UPDATED SUCCESSFULLY!", "CONFIRMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ViewMembershipTypes();
        }

        private async void deleteBtn_Click(object sender, EventArgs e)
        {
            await repoMembershipType.DeleteMembershipTypeAsync(SelectedId);

            ClearData();
            MessageBox.Show("DELETED SUCCESSFULLY!", "CONFIRMATION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            ViewMembershipTypes();
        }
    }
}
