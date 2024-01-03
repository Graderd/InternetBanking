using AutoMapper;
using InternetBanking.core.Dtos.Customers;
using InternetBanking.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetBanking.core.Profiles
{
    public class CustomerProfile : Profile
    {
        public CustomerProfile() 
        { 
            CreateMap<CustomersInsertDto, Customers>().ReverseMap();
        }
    }
}
