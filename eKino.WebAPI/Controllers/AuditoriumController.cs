using eKino.Model;
using eKino.Model.Requests;
using eKino.Model.SearchObjects;
using eKino.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace eKino.WebAPI.Controllers
{

    public class AuditoriumController : BaseCRUDController<Model.Auditorium, AuditoriumSearchObject, AuditoriumUpsertRequest, AuditoriumUpsertRequest>
    {
        public AuditoriumController(ICRUDService<Model.Auditorium, AuditoriumSearchObject, AuditoriumUpsertRequest, AuditoriumUpsertRequest> service)
            : base(service)
        {
        }
    }
}
