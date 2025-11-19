using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using MyApiň.Service;
using MyApiň.ViewModel;

namespace MyApiň.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TransactionController : ControllerBase
{
    private readonly ITransactionService _service;
    private readonly ILogger<TransactionController> _logger;

    public TransactionController(ITransactionService service, ILogger<TransactionController> logger)
    {
        _service = service ?? throw new ArgumentNullException(nameof(service));
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
    }

    [HttpGet]
    [ProducesResponseType(typeof(List<TransactionViewModel>), StatusCodes.Status200OK)]
    public ActionResult<List<TransactionViewModel>> GetAllTransactions()
    {
        var items = _service.GetAllTransactions();
        return Ok(items);
    }

    [HttpGet("{id:int}")]
    [ProducesResponseType(typeof(TransactionViewModel), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public ActionResult<TransactionViewModel> GetTransactionById(int id)
    {
        var trx = _service.GetTransactionById(id);

        if (trx is null)
            return NotFound();

        return Ok(trx);
    }
}
