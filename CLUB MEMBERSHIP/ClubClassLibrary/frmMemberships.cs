using ClubClassLibrary.Models;
using ClubClassLibrary.Repositories;
using ClubUI.ViewModels;
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
    public partial class frmMemberships : Form
    {
        MemberRepository repoMember = new MemberRepository();
        MembershipTypeRepository repoMembershipType = new MembershipTypeRepository();
        MembershipRepository repoMembership = new MembershipRepository();
        private int SelectedId;
        public frmMemberships()
        {
            InitializeComponent();
            FillMemberCB();
            FillMembershipTypeCB();
            LoadMembershipsDGV();
        }

        private void FillMemberCB()
        {
            MemberCB.DataSource = repoMember.GetAllMembers();
            MemberCB.ValueMember = "Id";
            MemberCB.DisplayMember = "Name";
        }

        private void FillMembershipTypeCB()
        {
            MembershipTypeCB.DataSource = repoMembershipType.GetAllMembershipTypes();
            MembershipTypeCB.ValueMember = "Id";
            MembershipTypeCB.DisplayMember = "Name";
        }

        private void LoadMembershipsDGV()
        {
            var data = repoMembership.GetAll();
            DGV.DataSource = data.Select(x => new MembershipViewModel
            {
                Id = x.Id,
                MemberName = x.Member.Name,
                MembershipTypeName = x.MembershipType.Name,
                StartDate = x.StartDate,
                EndDate = x.EndDate,
                Price = x.MembershipType.BasePrice,
            }).ToList();
            DGV.Columns[0].Visible = false;
            DGV.Columns[1].HeaderText = "Name";
            DGV.Columns[2].HeaderText = "Membership";
            DGV.Columns[3].HeaderText = "Start Date";
            DGV.Columns[4].HeaderText = "End Date";
            DGV.Columns[5].HeaderText = "Price";
        }

        private void DGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0) // Check if a real cell was clicked
            {

                int Id = (int)DGV.Rows[e.RowIndex].Cells[0].Value;
                var item = repoMembership.GetById(Id);
                MemberCB.SelectedValue = item.MemberId;
                MembershipTypeCB.SelectedValue = item.MembershipTypeId;
                StartDatePicker.Value = item.StartDate;
                EndDatePicker.Value = item.EndDate;
                SelectedId = Id;

            }
        }

        private bool ValidateData()
        {
            bool valid = false;
            if (MemberCB.SelectedValue == null)
            {
                valid = true;
            }
            if (MembershipTypeCB.SelectedValue == null)
            {
                valid = true;
            }


            return valid;
        }

        private void ClearData()
        {
            MemberCB.SelectedValue = "";
            MembershipTypeCB.SelectedValue = "";
            StartDatePicker.Value = DateTime.Now;
            EndDatePicker.Value = DateTime.Now;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (ValidateData())
            {
                return;
            }

            repoMembership.Add(new Membership
            {
                MemberId = Convert.ToInt32(MemberCB.SelectedValue),
                MembershipTypeId = Convert.ToInt32(MembershipTypeCB.SelectedValue),
                StartDate = StartDatePicker.Value,
                EndDate = EndDatePicker.Value,
            });

            ClearData();
            MessageBox.Show("ADDED SUCCESSFULLY!", "CONFIRMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadMembershipsDGV();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            var itemToUpdate = repoMembership.GetById(SelectedId);
            itemToUpdate.MemberId = Convert.ToInt32(MemberCB.SelectedValue);
            itemToUpdate.MembershipTypeId = Convert.ToInt32(MembershipTypeCB.SelectedValue);
            itemToUpdate.StartDate = StartDatePicker.Value;
            itemToUpdate.EndDate = EndDatePicker.Value;
            repoMembership.Update(itemToUpdate);

            ClearData();
            MessageBox.Show("UPDATED SUCCESSFULLY!", "CONFIRMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadMembershipsDGV();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            repoMembership.Delete(SelectedId);

            ClearData();
            MessageBox.Show("DELETED SUCCESSFULLY!", "CONFIRMATION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            LoadMembershipsDGV();
        }
    }
}
