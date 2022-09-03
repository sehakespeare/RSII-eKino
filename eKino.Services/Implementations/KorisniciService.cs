using AutoMapper;
using eKino.Model.Requests;
using eKino.Model.SearchObjects;
using eKino.Services.Database;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using Microsoft.EntityFrameworkCore;
using eKino.Model;
using eKino.Services.Helpers;
using eKino.Services.Interfaces;

namespace eKino.Services.Implementations
{
    public class UsersService : BaseCRUDService<Model.User, Database.User, UserSearchObject, UserInsertRequest, UserUpdateRequest>, IUsersService
    {
        public UsersService(eKinoContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public override Model.User Insert(UserInsertRequest insert)
        {

            if (insert.Password != insert.PasswordConfirm)
            {
                throw new UserException("Password and confirmation must be the same");
            }

            var entity = base.Insert(insert);


            foreach (var roleId in insert.RoleIdList)
            {
                Database.UserRole userRole = new Database.UserRole
                {
                    RoleId = roleId,
                    UserId = entity.UserId,
                    DateModified = DateTime.Now
                };

                Context.UserRoles.Add(userRole);
            }

            Context.SaveChanges();

            return entity;
        }

        public override void BeforeInsert(UserInsertRequest insert, Database.User entity)
        {
            var salt = Hashing.GenerateSalt();
            entity.PasswordSalt = salt;
            entity.PasswordHash = Hashing.GenerateHash(salt, insert.Password) ?? "";
            base.BeforeInsert(insert, entity);
        }


        public override IQueryable<Database.User> AddFilter(IQueryable<Database.User> query, UserSearchObject search = null)
        {
            var filteredQuery = base.AddFilter(query, search);

            if (!string.IsNullOrWhiteSpace(search?.Username))
            {
                filteredQuery = filteredQuery.Where(x => x.Username.Contains(search.Username));
            }
            
            if (!string.IsNullOrWhiteSpace(search?.Name))
            {
                filteredQuery = filteredQuery.Where(x => (x.FirstName + " " + x.LastName).Contains(search.Name));
            }

            return filteredQuery;
        }

        public override IQueryable<Database.User> AddInclude(IQueryable<Database.User> query, UserSearchObject search = null)
        {
            if (search?.IncludeRoles == true)
            {
                query = query.Include("UserRoles.Role");
            }
            return query;
        }

        public Model.User? Login(string username, string password)
        {
            var entity = Context.Users.Include("UserRoles.Role").FirstOrDefault(x => x.Username == username);
            if (entity == null)
            {
                return null;
            }

            var hash = Hashing.GenerateHash(entity.PasswordSalt, password);

            if (hash != entity.PasswordHash)
            {
                return null;
            }

            return Mapper.Map<Model.User>(entity);
        }
    }
}
