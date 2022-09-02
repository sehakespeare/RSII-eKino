using AutoMapper;
using eKino.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eKino.Services
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Database.User, Model.User>();

            CreateMap<Database.UserRole, Model.UserRole>();
            CreateMap<Database.Role, Model.Role>();

            CreateMap<UserInsertRequest, Database.User>();
            CreateMap<UserUpdateRequest, Database.User>();

        }
    }
}
