using AutoMapper;
using FluentValidationApp.DTOs;
using FluentValidationApp.Models;

namespace FluentValidationApp.Mapping
{
    public class CustomerProfile : Profile
    {
        public CustomerProfile()
        {
            // Way 1
            //CreateMap<Customer, CustomerDTO>();
            //CreateMap<CustomerDTO, Customer>();

            //Way2
            CreateMap<Customer, CustomerDTO>().ReverseMap();

        }

    }
}
