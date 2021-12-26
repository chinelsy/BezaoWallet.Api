using AutoMapper;
using BezaoWallet.Api.ActionFilter;
using BezaoWallet.Entities.Dtos;
using BezaoWallet.LoggerService.Interface;
using BezaoWallet.Service.Interface;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BezaoWallet.Api.Controllers
{
    [Route("api/transaction")]
    [ApiController]
    public class TransactionController : ControllerBase
    {
        private readonly ITransactionService _transactionService;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;
        public TransactionController(ITransactionService transactionService, ILoggerManager logger, IMapper mapper)
        {
            _transactionService = transactionService;
            _logger = logger;
            _mapper = mapper;
        }

        [HttpPost("Deposit")]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        public async Task<IActionResult> Deposit([FromBody] DepositeDto depositeDto)
        {
            if (depositeDto == null)
            {
                return BadRequest("Not Found");
            }
            else
            {
                var amountDposited = await _transactionService.Deposit(depositeDto);
                return Ok(amountDposited);
            }
        }

        [HttpPost("Withdraw")]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        public async Task<IActionResult> Withdraw([FromBody] WithdrawalDto withdrawalDto)
        {
            if (withdrawalDto == null)
            {
                return BadRequest("Not found");
            }
            else
            {
                var amountWithdrawn = await _transactionService.Withdraw(withdrawalDto);
                return Ok(amountWithdrawn);
            }
        }

        [HttpPost("Transfer")]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        public async Task<IActionResult> Transfer([FromBody] TransactionDto transactionDto)
        {
            if (transactionDto == null)
            {
                return BadRequest("Not found");
            }
            else
            {
                var amountTransfered = await _transactionService.Transfer(transactionDto);
                return Ok(amountTransfered);
            }

        }
    }
}
