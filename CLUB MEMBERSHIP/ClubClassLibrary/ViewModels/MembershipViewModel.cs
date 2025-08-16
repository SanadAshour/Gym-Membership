using ClubClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubUI.ViewModels
{
    internal class MembershipViewModel
    {
        public int Id { get; set; }
        public string MemberName { get; set; }
        public string MembershipTypeName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal Price { get; set; }
    }
}
