using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using CertificationTracker.Application.Dtos;
using CertificationTracker.Data.Models;

namespace CertificationTracker.Services.ProfileMapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<UserAuthorization, User>().ReverseMap();
            CreateMap<ApplicationUserTokenDto, User>().ReverseMap();
        }
    }
}
