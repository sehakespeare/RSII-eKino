using eKino.Model;
using eKino.Model.Requests;
using eKino.Model.SearchObjects;
using eKino.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace eKino.WebAPI.Controllers
{
    
    public class ProjectionController : BaseController<Model.Role, BaseSearchObject>
    {
        public ProjectionController(IService<Model.Role, BaseSearchObject> service)
            : base(service)
        {
        }
    }
}
