using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using MyApiň.Models;
using MyApiň.Service;

namespace MyApiň.Controllers;

[ApiController]
[Route("api/[controller]")] // => /api/transaction
public class TransactionController : ControllerBase
{
    private readonly ITransactionService _service;
    private readonly ILogger<TransactionController> _logger;

    // constructor dependency injection
    public TransactionController(ITransactionService service, ILogger<TransactionController> logger)
    {
        _service = service ?? throw new ArgumentNullException(nameof(service));
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
    }

    [HttpGet]
    [ProducesResponseType(typeof(List<Transaction>), StatusCodes.Status200OK)]
    public ActionResult<List<Transaction>> GetAllTransactions()
    {
        var items = _service.GetAllTransactions();
        return Ok(items);
    }

    [HttpGet("{id:int}")]
    [ProducesResponseType(typeof(Transaction), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public ActionResult<Transaction> GetTransactionById(int id)
    {
        var trx = _service.GetTransactionById(id);
        return trx is null ? NotFound() : Ok(trx);
    }
}


