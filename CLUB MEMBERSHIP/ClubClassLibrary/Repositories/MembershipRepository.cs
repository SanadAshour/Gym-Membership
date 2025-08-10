using ClubClassLibrary.Data;
using ClubClassLibrary.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubClassLibrary.Repositories
{
    public class MembershipRepository
    {
        private readonly AppDbContext ADC = new AppDbContext();


        public Membership GetById(int id)
        {
            return ADC.Memberships.Find(id);
        }


        public IEnumerable<Membership> GetAll()
        {
            return ADC.Memberships.Include(m => m.Member).Include(m => m.MembershipType).ToList();
        }

        public void Add(Membership membership)
        {
            ADC.Memberships.Add(membership);
            ADC.SaveChanges();
        }

        public void Update(Membership membership)
        {
            ADC.Entry(membership).State = EntityState.Modified; // Or _context.Members.Update(member) in EF Core 5+
            ADC.SaveChanges();
        }

        public void Delete(int id)
        {
            var membership = ADC.Memberships.Find(id);
            if (membership != null)
            {
                ADC.Memberships.Remove(membership);
                ADC.SaveChanges();
            }
        }
    }
}
