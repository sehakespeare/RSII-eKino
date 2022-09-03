using eKino.Model;
using eKino.Model.Requests;
using eKino.Model.SearchObjects;
using eKino.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace eKino.WebAPI.Controllers
{

    public class RatingController : BaseCRUDController<Model.Rating, ReservationSearchObject, ReservationUpsertRequest, ReservationUpsertRequest>
    {
        public RatingController(ICRUDService<Model.Rating, ReservationSearchObject, ReservationUpsertRequest, ReservationUpsertRequest> service)
            : base(service)
        {
        }
    }
}
