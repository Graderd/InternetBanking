using AutoMapper;
using InternetBanking.core.Dtos;
using InternetBanking.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetBanking.core.Profiles
{
    public class AccoutsProfile : Profile
    {
        public AccoutsProfile()
        {
            CreateMap<AccountsInsertDto, Accounts>().ReverseMap(); 
        }
    }
}
