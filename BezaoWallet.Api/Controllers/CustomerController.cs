using AutoMapper;
using BezaoWallet.Api.ActionFilter;
using BezaoWallet.Entities.Dtos;
using BezaoWallet.Entities.Models;
using BezaoWallet.LoggerService.Interface;
using BezaoWallet.Service.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace BezaoWallet.Api.Controllers
{
    [Route("api/customer")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _customerService;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;


        public CustomerController(ICustomerService customerService, ILoggerManager logger, IMapper mapper)
        {
            _customerService = customerService;
            _logger = logger;
            _mapper = mapper;
        }

        [HttpGet("GetCustomerById")]
        [ProducesResponseType(typeof(Customer), 200)]
        public async Task<IActionResult> GetSingleCustomers(Guid id)
        {
            var customerEntity = await _customerService.GetSingleCustomer(id);
            return Ok(customerEntity);
        }

        [HttpGet( Name = "GetAllCustomers"), Authorize (Roles = "Administrator")]
        [ProducesResponseType(typeof(Customer), 200)]
        public async Task<IActionResult> Customers()
        {
            return Ok(await _customerService.GetCustomersAsync());
        }


        [HttpGet("GetWalletDetail")]
        public async Task<IActionResult> WalletDetail(string walletId)
        {
            return Ok(await _customerService.GetCustomerBywalletId(walletId));
        } 

        [HttpPost("Create Customer")]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        public async Task<IActionResult> CreateCustomer([FromBody] CustomerForCreationDto customer)
        {
            if (customer == null)
            {
                return BadRequest();
            }
            else
            {
                await _customerService.CreateCustomer(customer.UserId);
                return Ok();
            }
        }

    } 
}
