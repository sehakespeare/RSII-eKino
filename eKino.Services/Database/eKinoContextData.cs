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
            modelBuilder.Entity<Role>().HasData(new Role{ RoleId = 1, Name = "Administrator", });
            modelBuilder.Entity<Role>().HasData(new Role { RoleId = 2, Name = "Client", });


            modelBuilder.Entity<User>().HasData(new User
            {
                UserId = 1,
                FirstName = "Client",
                LastName = "Client",
                Email = "client@fit.ba",
                Username = "client",
                PasswordHash = "7p3l25Cnbg+2QxoQRElFJjIqHgA=",
                PasswordSalt = "H4pOSYtdeJgGsU/6HRTxqw==",
            });



            //u:admin p:admin
            modelBuilder.Entity<User>().HasData(new User
            {
                UserId = 2,
                FirstName = "Administrator",
                LastName = "Administrator",
                Email = "admin@fit.ba",
                Username = "admin",
                PasswordHash = "JfJzsL3ngGWki+Dn67C+8WLy73I=",
                PasswordSalt = "7TUJfmgkkDvcY3PB/M4fhg==",
            });

            modelBuilder.Entity<UserRole>().HasData(new UserRole() { UserRoleId = 1, UserId = 1, RoleId = 1, DateModified = DateTime.Today });
            modelBuilder.Entity<UserRole>().HasData(new UserRole() { UserRoleId = 2, UserId = 2, RoleId = 1, DateModified = DateTime.Today });
        }
    }
}
