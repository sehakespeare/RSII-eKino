using eKino.Model;
using eKino.Model.Requests;
using eKino.Model.SearchObjects;
using eKino.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace eKino.WebAPI.Controllers
{

    public class TransactionController : BaseCRUDController<Model.Transaction, TransactionSearchObject, TransactionUpsertRequest, TransactionUpsertRequest>
    {
        public TransactionController(ICRUDService<Model.Transaction, TransactionSearchObject, TransactionUpsertRequest, TransactionUpsertRequest> service)
            : base(service)
        {
        }
    }
}
