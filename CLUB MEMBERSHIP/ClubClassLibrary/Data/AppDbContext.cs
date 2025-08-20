using ClubClassLibrary.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubClassLibrary.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Member> Members { get; set; }
        public DbSet<Membership> Memberships { get; set; }
        public DbSet<MembershipType> MembershipTypes { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"server=.\SQLEXPRESS;database=CLUB;integrated security=true;TrustServerCertificate=true");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Member - Membership (one to many)
            modelBuilder.Entity<Membership>()
                .HasOne(m => m.Member)
                .WithMany(mb => mb.Memberships)
                .HasForeignKey(m => m.MemberId)
                .OnDelete(DeleteBehavior.NoAction);

            //MembershipType - Membership (one to many)
            modelBuilder.Entity<Membership>()
                .HasOne(m => m.MembershipType)
                .WithMany(mt => mt.Memberships)
                .HasForeignKey(m => m.MembershipTypeId)
                .OnDelete(DeleteBehavior.NoAction);

            //Member - Payment (one to many)
            modelBuilder.Entity<Payment>()
                .HasOne(p => p.Member)
                .WithMany(m => m.Payments)
                .HasForeignKey(p => p.MemberId)
                .OnDelete(DeleteBehavior.NoAction);

            //Membership - Payment (one to many)
            modelBuilder.Entity<Payment>()
                .HasOne(p => p.Membership)
                .WithMany(m => m.Payments)
                .HasForeignKey(p => p.MemberShipId)
                .OnDelete(DeleteBehavior.NoAction);


            //SEEDING MEMBERSHIPS
            modelBuilder.Entity<MembershipType>().HasData(
                new MembershipType { Id = 1, Name = "Monthly", Description="A MONTHLY DESCRIPTION", BasePrice=50 },
                new MembershipType { Id = 2, Name = "Annual", Description = "AN ANNUAL DESCRIPTION", BasePrice = 200 },
                new MembershipType { Id = 3, Name = "Premium", Description = "A PREMIUM DESCRIPTION", BasePrice = 500 }
                );

            //SEEDING MEMBERS
            modelBuilder.Entity<Member>().HasData(
                new Member {Id=1, PhoneNumber = "1234", Name="Sanad", Address="SARAJ", BirthDate= new DateTime(2002,11,10), JoinDate= new DateTime(2024, 01, 01) },
                new Member { Id = 2, PhoneNumber="1234", Name = "Seraj", Address = "SARAJ", BirthDate = new DateTime(2004, 10, 24), JoinDate = new DateTime(2024, 01, 01) }
                );

            //SEEDING USERS
            modelBuilder.Entity<User>().HasData(
                new User { Id = 1, Name = "admin1", Email = "admin1@yahoo.com", Password = "123", UsersPermission = true, MembersPermission = false, ReportsPermission = false },
                new User { Id = 2, Name = "admin2", Email = "admin2@yahoo.com", Password = "456", UsersPermission = false, MembersPermission = true, ReportsPermission = false },
                new User { Id = 3, Name = "admin3", Email = "admin3@yahoo.com", Password = "789", UsersPermission = false, MembersPermission = false, ReportsPermission = true }
                );

            base.OnModelCreating(modelBuilder);
        }

    }
}
