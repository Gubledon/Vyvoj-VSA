using Microsoft.AspNetCore.Mvc;
using MyApiň.Models;
using MyApiň.Service;

namespace MyApiň.Controllers
{
    [ApiController]
    [Route("[controller]")] // => /transaction
    public class TransactionController : ControllerBase
    {
        private readonly ITransactionService service;

        // constructor dependency injection
        public TransactionController(ITransactionService service)
        {
            service = service;
        }

        [HttpGet]
        public ActionResult<List<Transaction>> GetAllTransactions()
        {
            return service.GetAllTransactions();
        }

        [HttpGet("{id}")]
        public ActionResult<Transaction> GetTransactionById(int id)
        {
            var trx = service.GetTransactionById(id);
            return trx is null ? NotFound() : trx;
        }
    }
}
