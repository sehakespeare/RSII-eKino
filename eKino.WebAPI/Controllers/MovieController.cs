using eKino.Model;
using eKino.Model.Requests;
using eKino.Model.SearchObjects;
using eKino.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace eKino.WebAPI.Controllers
{

    public class MovieController : BaseCRUDController<Model.Movie, MovieSearchObject, MovieUpsertRequest, MovieUpsertRequest>
    {
        public MovieController(ICRUDService<Model.Movie, MovieSearchObject, MovieUpsertRequest, MovieUpsertRequest> service)
            : base(service)
        {
        }
    }
}
