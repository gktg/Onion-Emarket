using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Onion_Emarket.Domain.Enums;
using Onion_Emarket.Domain.Entities;
using System.Security.Claims;
using Onion_Emarket.Application.Repositories;
using Onion_Emarket.Domain.ViewModels;
using AutoMapper;

namespace Onion_Emarket.Web.Controllers
{
    public class CategoriesController : Controller
    {
        private readonly ICategoryReadRepository _categoryReadRepository;
        private readonly ICategoryWriteRepository _categoryWriteRepository;
        private readonly IMapper _mapper;


        public CategoriesController(ICategoryReadRepository categoryReadRepository, ICategoryWriteRepository categoryWriteRepository, IMapper mapper)
        {
            _categoryReadRepository = categoryReadRepository;
            _categoryWriteRepository = categoryWriteRepository;
            _mapper = mapper;
        }

        [Route("/categories/GetAllCategories/")]
        [HttpGet]
        public List<CategoryVM> GetCategories()
        {
            List<Category> categoriesList = _categoryReadRepository.GetAll().ToList();
            List<CategoryVM> categories = _mapper.Map<List<CategoryVM>>(categoriesList);
            return categories;
        }
    }
}
