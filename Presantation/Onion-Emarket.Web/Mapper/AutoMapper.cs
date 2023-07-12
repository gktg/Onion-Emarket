using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Onion_Emarket.Application.Collections.Basket;
using Onion_Emarket.Application.Repositories;
using Onion_Emarket.Domain.Collections;
using Onion_Emarket.Domain.Entities;
using Onion_Emarket.Domain.ViewModels;
using Onion_Emarket.Insfastructure.Tools;

namespace Onion_Emarket.Web.Mapper
{
    public class AutoMapper : Profile
    {

        public AutoMapper()
        {

            CreateMap<Product, ProductVM>().ReverseMap();
            CreateMap<Category, CategoryVM>().ReverseMap();

        }

    }


}
