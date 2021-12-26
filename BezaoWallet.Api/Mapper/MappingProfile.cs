using AutoMapper;
using BezaoWallet.Entities.Dtos;
using BezaoWallet.Entities.Models;

namespace BezaoWallet.Api.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Account, AccountDto>();

            CreateMap<Customer, CustomerDto>();

            CreateMap<TransactionDto, Transaction>();

            CreateMap<CustomerForCreationDto, Customer>();

            CreateMap<AccountForCreationDto, Account>();

            CreateMap<AccountForUpdateDto, Account>();

            CreateMap<CustomerForUpdateDto, Customer>();

            CreateMap<UserForRegistrationDto, User>();
            

        }
    }
}
