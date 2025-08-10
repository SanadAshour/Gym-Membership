using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubClassLibrary.Models
{
    public class User
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public bool UsersPermission { get; set; }

        public bool MembersPermission { get; set; }

        public bool ReportsPermission { get; set; }
    }
}
