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
            CreateMap<Customer, CustomerDTO>()
                .ForMember(to => to.FullName, from => from.MapFrom(p => p.Name))
                .ForMember(to => to.Email, from => from.MapFrom(p => p.Mail))
                //.ForMember(to=>to.FullProperty,from => from.MapFrom(p=>p.TestFullProperyMethod()))
                .ForMember(to => to.CCNumber, from => from.MapFrom(c => c.CreditCard.Number))
                .ForMember(to => to.CCValidDate, from => from.MapFrom(c => c.CreditCard.ValidDate))
                ;

        }

    }
}
