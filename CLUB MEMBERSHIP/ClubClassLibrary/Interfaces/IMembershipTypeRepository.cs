using ClubClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubClassLibrary.Interfaces
{
    internal interface IMembershipTypeRepository
    {
        Task<MembershipType> GetMembershipTypeByIdAsync(int id);
        Task<IEnumerable<MembershipType>> GetAllMembershipTypesAsync();
        Task AddMembershipTypeAsync(MembershipType membershipType);
        Task UpdateMembershipTypeAsync(MembershipType membershipType);
        Task DeleteMembershipTypeAsync(int id);
    }
}
