using eKino.Model;
using eKino.Model.Requests;
using eKino.Model.SearchObjects;
using eKino.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace eKino.WebAPI.Controllers
{

    public class GenreController : BaseCRUDController<Model.Genre, GenreSearchObject, GenreUpsertRequest, GenreUpsertRequest>
    {
        public GenreController(ICRUDService<Model.Genre, GenreSearchObject, GenreUpsertRequest, GenreUpsertRequest> service)
            : base(service)
        {
        }
    }
}
