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
using ClubClassLibrary.Models;
using Microsoft.Reporting.WinForms;

namespace ClubUI
{
    public partial class frmInquiries : Form
    {
        MemberRepository repoMember = new MemberRepository();
        List<Member> data = new List<Member>();
        public frmInquiries()
        {
            InitializeComponent();
        }

        private void Showbtn_Click(object sender, EventArgs e)
        {
            if (MembersRB.Checked)
            {
                data = repoMember.FilterByDate(FromDT.Value, ToDT.Value).ToList();
            }
            DGV.DataSource = data;
        }

        private void Printbtn_Click(object sender, EventArgs e)
        {
            frmReport r = new frmReport();
            r.reportViewer1.LocalReport.ReportEmbeddedResource = "ClubUI.Reports.MemberReport.rdlc";
            r.reportViewer1.LocalReport.DataSources.Clear();
            r.reportViewer1.LocalReport.DataSources.Add(
                new ReportDataSource("DataSetMembers", data)
                );
            r.reportViewer1.RefreshReport();
            r.ShowDialog();
        }
    }
}
