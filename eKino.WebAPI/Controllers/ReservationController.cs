using eKino.Model;
using eKino.Model.Requests;
using eKino.Model.SearchObjects;
using eKino.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace eKino.WebAPI.Controllers
{

    public class ReservationController : BaseCRUDController<Model.Reservation, ReservationSearchObject, ReservationUpsertRequest, ReservationUpsertRequest>
    {
        public ReservationController(ICRUDService<Model.Reservation, ReservationSearchObject, ReservationUpsertRequest, ReservationUpsertRequest> service)
            : base(service)
        {
        }
    }
}
