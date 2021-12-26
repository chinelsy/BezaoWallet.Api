using AutoMapper;
using BezaoWallet.DataLayer.Interface;
using BezaoWallet.Entities.Models;
using BezaoWallet.LoggerService.Interface;
using BezaoWallet.Service.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BezaoWallet.Api.Controllers
{
    [Route("api/account")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IAccountService _accountService;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;


        public AccountController(IUnitOfWork unitOfWork, IAccountService accountService, ILoggerManager logger, IMapper mapper)
        {
            _accountService = accountService;
            _logger = logger;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        [HttpGet(Name = "GetAccounts"), Authorize(Roles = "Adminstrator")]
        public async Task<IActionResult> GetAcccounts()
        {
            var account = _accountService.GetAccounts();
            return Ok(await account);
        }

        [HttpGet("AccountBalance")]
        public async Task<IActionResult> GetAccountBalance(string walletId)
        {
            return Ok(await _accountService.GetAccountBalance(walletId));
        }

        [HttpGet("GetWalletId")]
        public async Task<IActionResult> WalletDetail(string walletId)
        {
            return Ok(await _accountService.GetByWalletId(walletId));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAccount(Account account)
        {
            _accountService.DeleteAccount(account);
            await _unitOfWork.SaveChangesAsync();
            return NoContent();
        }
    }
}
