using AutoMapper;
using SIMPLE_LOGIN_SIGNUP_API.Entities;
using SIMPLE_LOGIN_SIGNUP_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SIMPLE_LOGIN_SIGNUP_API.Helpers
{
    public class AutoMapperProfile: Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<User, UserModel>();
            CreateMap<RegisterModel, User>();
            CreateMap<UpdateModel, User>();
        }
    }
}
