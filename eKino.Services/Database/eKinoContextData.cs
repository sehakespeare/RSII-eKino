using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eKino.Services.Database
{
    partial class eKinoContext
    {
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Role>().HasData(new Role{ RoleId = 1, Name = "Administrator" });
            modelBuilder.Entity<Role>().HasData(new Role { RoleId = 2, Name = "Client" });

            //u:admin p:admin
            modelBuilder.Entity<User>().HasData(new User
            {
                UserId = 1,
                FirstName = "Administrator",
                LastName = "Administrator",
                Email = "admin@fit.ba",
                Username = "admin",
                PasswordHash = "JfJzsL3ngGWki+Dn67C+8WLy73I=",
                PasswordSalt = "7TUJfmgkkDvcY3PB/M4fhg==",
                Phone = "061456789",
                Status = true
            });

            //u:client p:client
            modelBuilder.Entity<User>().HasData(new User
            {
                UserId = 2,
                FirstName = "Client",
                LastName = "Client",
                Email = "client@fit.ba",
                Username = "client",
                PasswordHash = "Qt4/SE4hNB9rKyspn+e8q4C79Sw=",
                PasswordSalt = "l6n9Ck0LvsyNX1/V47AePQ==",
                Phone = "061123123",
                Status = true
            });

            modelBuilder.Entity<UserRole>().HasData(new UserRole() { UserRoleId = 1, UserId = 1, RoleId = 1, DateModified = DateTime.Today });
            modelBuilder.Entity<UserRole>().HasData(new UserRole() { UserRoleId = 2, UserId = 2, RoleId = 2, DateModified = DateTime.Today });
        }
    }
}
