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
    public partial class frmPayments : Form
    {
        MemberRepository repoMember = new MemberRepository();
        MembershipTypeRepository repoMembershipType = new MembershipTypeRepository();
        MembershipRepository repoMembership = new MembershipRepository();
        private int SelectedId;
        public frmPayments()
        {
            InitializeComponent();
            LoadMembershipsDGV();
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
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Get the ID of the selected row from the first DGV.
                int Id = (int)DGV.Rows[e.RowIndex].Cells[0].Value;

                // Retrieve the single membership object from the repository.
                var item = repoMembership.GetById(Id);

                // Clear existing data from DGV2 before adding new data.
                DGV2.DataSource = null;

                // Create a new list containing a single MembershipViewModel.
                var singleViewModelList = new List<MembershipViewModel>
                {
                    new MembershipViewModel
                    {
                        Id = item.Id,
                        MemberName = item.Member.Name,
                        MembershipTypeName = item.MembershipType.Name,
                        StartDate = item.StartDate,
                        EndDate = item.EndDate,
                        Price = item.MembershipType.BasePrice,
                    }
                };

                // Bind the list to the second DataGridView.
                DGV2.DataSource = singleViewModelList;

                // Manually set the column headers for DGV2 to match the first DGV.
                DGV2.Columns[0].Visible = false;
                DGV2.Columns[1].HeaderText = "Name";
                DGV2.Columns[2].HeaderText = "Membership";
                DGV2.Columns[3].HeaderText = "Start Date";
                DGV2.Columns[4].HeaderText = "End Date";
                DGV2.Columns[5].HeaderText = "Price";
            }
        }
    }
}
