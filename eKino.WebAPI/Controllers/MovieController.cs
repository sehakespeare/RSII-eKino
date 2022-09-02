using eKino.Model;
using eKino.Model.Requests;
using eKino.Model.SearchObjects;
using eKino.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace eKino.WebAPI.Controllers
{
    
    public class MovieController : BaseController<Model.Role, BaseSearchObject>
    {
        public MovieController(IService<Model.Role, BaseSearchObject> service)
            : base(service)
        {
        }
    }
}
