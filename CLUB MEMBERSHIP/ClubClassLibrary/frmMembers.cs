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

namespace ClubUI
{
    public partial class frmMembers : Form
    {
        MemberRepository repoMember = new MemberRepository();
        private int SelectedId;
        public frmMembers()
        {
            InitializeComponent();
        }

        private async void ViewMembers()
        {
            var data = await repoMember.GetAllMembersAsync();
            DGV.DataSource = data.Select(mb => new
            {
                mb.Id,
                mb.Name,
                mb.PhoneNumber,
                mb.Address,
                mb.BirthDate,
                mb.JoinDate
            }).ToList();
            DGV.Columns[0].Visible = false;
            DGV.Columns[1].HeaderText = "Name";
            DGV.Columns[2].HeaderText = "Phone Number";
            DGV.Columns[3].HeaderText = "Address";
            DGV.Columns[4].HeaderText = "D.O.B";
            DGV.Columns[5].HeaderText = "D.O.J";
        }

        private void frmMembers_Load(object sender, EventArgs e)
        {
            ViewMembers();
        }

        private bool ValidateData()
        {
            bool valid = false;
            if (MbNameTB.Text == "")
            {
               valid = true;
               MessageBox.Show("PLEASE ENTER A VALID NAME!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (MbPhoneNumberTB.Text == "")
            {
                valid = true;
                MessageBox.Show("PLEASE ENTER A VALID PHONE NUMBER!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (MbAddressTB.Text == "")
            {
                valid = true;
                MessageBox.Show("PLEASE ENTER A VALID ADDRESS!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (!dobDT.Checked)
            {
                valid = true;
                MessageBox.Show("PLEASE ENTER YOUR DATE OF BIRTH!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (!jobDT.Checked)
            {
                valid = true;
                MessageBox.Show("PLEASE ENTER YOUR JOINED DATE!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            
            return valid;
        }

        private void ClearData()
        {
            MbNameTB.Text = "";
            MbPhoneNumberTB.Text = "";
            MbAddressTB.Text = "";
            dobDT.Value = DateTime.Now;
            jobDT.Value = DateTime.Now;
        }

        private async void addBtn_Click(object sender, EventArgs e)
        {
            if (ValidateData())
            {
                return;
            }

            await repoMember.AddMemberAsync(new Member
            {
                Name = MbNameTB.Text,
                PhoneNumber = MbPhoneNumberTB.Text,
                Address = MbAddressTB.Text,
                BirthDate = dobDT.Value,
                JoinDate = jobDT.Value,
            });

            ClearData();
            MessageBox.Show("ADDED SUCCESSFULLY!", "CONFIRMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ViewMembers();
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
                var item = await repoMember.GetMemberByIdAsync(Id);
                MbNameTB.Text = item.Name;
                MbPhoneNumberTB.Text = item.PhoneNumber;
                MbAddressTB.Text = item.Address;
                dobDT.Value = item.BirthDate;
                jobDT.Value = item.JoinDate;
                SelectedId = Id;

            }
        }

        private async void updateBtn_Click(object sender, EventArgs e)
        {
            var itemToUpdate = await repoMember.GetMemberByIdAsync(SelectedId);
            itemToUpdate.Name = MbNameTB.Text;
            itemToUpdate.PhoneNumber = MbPhoneNumberTB.Text;
            itemToUpdate.Address = MbAddressTB.Text;
            await repoMember.UpdateMemberAsync(itemToUpdate);

            ClearData();
            MessageBox.Show("UPDATED SUCCESSFULLY!", "CONFIRMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ViewMembers();
        }

        private async void deleteBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("ARE YOU SURE YOU WANT TO DELETE?", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(result == DialogResult.No)
            {
                return;
            }

            await repoMember.DeleteMemberAsync(SelectedId);

            ClearData();
            MessageBox.Show("DELETED SUCCESSFULLY!", "CONFIRMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ViewMembers();
        }
    }
}
