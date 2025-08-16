using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClubClassLibrary.Repositories;
using ClubUI.ViewModels;

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
            DGV.DataSource = data.Select(x => new MembershipViewModel{
                Id = x.Id,
                MemberName = x.Member.Name,
                MembershipTypeName = x.MembershipType.Name,
                StartDate = x.StartDate,
                EndDate = x.EndDate,
                Price = x.Price,
            }).ToList();
            DGV.Columns[0].Visible = false;
            DGV.Columns[1].HeaderText = "Name";
            DGV.Columns[2].HeaderText = "Membership";
            DGV.Columns[3].HeaderText = "Start Date";
            DGV.Columns[4].HeaderText = "End Date";
            DGV.Columns[5].HeaderText = "Price";
        }
    }
}
