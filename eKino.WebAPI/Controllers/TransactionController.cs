﻿using eKino.Model;
using eKino.Model.Requests;
using eKino.Model.SearchObjects;
using eKino.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace eKino.WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorize]
    public class TransactionController : BaseCRUDController<Model.Transaction, TransactionSearchObject, TransactionUpsertRequest, TransactionUpsertRequest>
    {
        public TransactionController(ITransactionService service)
            : base(service)
        {
        }
    }
}
