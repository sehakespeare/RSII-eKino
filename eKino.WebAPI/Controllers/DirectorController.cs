using eKino.Model;
using eKino.Model.Requests;
using eKino.Model.SearchObjects;
using eKino.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace eKino.WebAPI.Controllers
{
    
    public class DirectorController : BaseController<Model.Role, BaseSearchObject>
    {
        public DirectorController(IService<Model.Role, BaseSearchObject> service)
            : base(service)
        {
        }
    }
}
