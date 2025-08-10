using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubClassLibrary.Models
{
    public class Member
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime BirthDate { get; set; }
        public string Address { get; set; }
        public DateTime JoinDate { get; set; } = DateTime.Now;
        public List<Membership> Memberships { get; set; }
        public List<Payment> Payments { get; set; }
    }
}

