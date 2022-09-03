﻿using eKino.Model;
using eKino.Model.Requests;
using eKino.Model.SearchObjects;
using eKino.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace eKino.WebAPI.Controllers
{
    
    public class AuditoriumController : BaseController<Model.Role, BaseSearchObject>
    {
        public AuditoriumController(IService<Model.Role, BaseSearchObject> service)
            : base(service)
        {
        }
    }
}