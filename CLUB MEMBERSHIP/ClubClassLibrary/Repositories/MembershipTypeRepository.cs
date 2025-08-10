using ClubClassLibrary.Data;
using ClubClassLibrary.Interfaces;
using ClubClassLibrary.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubClassLibrary.Repositories
{
    public class MembershipTypeRepository : IMembershipTypeRepository
    {
        private readonly AppDbContext ADC = new AppDbContext();


        // ... (Implement the methods - very similar to MemberRepository)
        public async Task<MembershipType> GetMembershipTypeByIdAsync(int id)
        {
            return await ADC.MembershipTypes.FindAsync(id);
        }

        public async Task<IEnumerable<MembershipType>> GetAllMembershipTypesAsync()
        {
            return await ADC.MembershipTypes.ToListAsync();
        }

        public IEnumerable<MembershipType> GetAllMembershipTypes()
        {
            return ADC.MembershipTypes.ToList();
        }

        public async Task AddMembershipTypeAsync(MembershipType membershipType)
        {
            await ADC.MembershipTypes.AddAsync(membershipType);
            await ADC.SaveChangesAsync();
        }

        public async Task UpdateMembershipTypeAsync(MembershipType membershipType)
        {
            ADC.Entry(membershipType).State = EntityState.Modified; // Or _context.MembershipTypes.Update(membershipType) in EF Core 5+
            await ADC.SaveChangesAsync();
        }

        public async Task DeleteMembershipTypeAsync(int id)
        {
            var membershipType = await ADC.MembershipTypes.FindAsync(id);
            if (membershipType != null)
            {
                ADC.MembershipTypes.Remove(membershipType);
                await ADC.SaveChangesAsync();
            }
        }
    }
}
