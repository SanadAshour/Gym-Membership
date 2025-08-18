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
    public class MemberRepository : IMemberRepository
    {
        private readonly AppDbContext ADC = new AppDbContext();


        public async Task<Member> GetMemberByIdAsync(int id)
        {
            return await ADC.Members.FindAsync(id);
        }

        public async Task<IEnumerable<Member>> GetAllMembersAsync()
        {
            return await ADC.Members.ToListAsync();
        }

        public IEnumerable<Member> GetAllMembers()
        {
            return ADC.Members.ToList();
        }
        public IEnumerable<Member> FilterByDate(DateTime From,DateTime To)
        {
            return ADC.Members.Where(m => m.JoinDate >= From && m.JoinDate <= To).ToList();
        }

        public IEnumerable<Member> GetMembersByJoinDate(DateTime dateFrom, DateTime dateTo)
        {
            return ADC.Members
         .Where(m => m.JoinDate >= dateFrom && m.JoinDate <= dateTo)
         .ToList();
        }

        public async Task AddMemberAsync(Member member)
        {
            await ADC.Members.AddAsync(member);
            await ADC.SaveChangesAsync();
        }

        public async Task UpdateMemberAsync(Member member)
        {
            ADC.Entry(member).State = EntityState.Modified; // Or _context.Members.Update(member) in EF Core 5+
            await ADC.SaveChangesAsync();
        }

        public async Task DeleteMemberAsync(int id)
        {
            var member = await ADC.Members.FindAsync(id);
            if (member != null)
            {
                ADC.Members.Remove(member);
                await ADC.SaveChangesAsync();
            }
        }
    }
}
