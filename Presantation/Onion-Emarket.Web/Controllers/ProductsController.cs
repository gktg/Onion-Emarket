using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Onion_Emarket.Application.Repositories;
using Onion_Emarket.Domain.Entities;
using Onion_Emarket.Domain.ViewModels;

namespace Onion_Emarket.Web.Controllers
{


    public class ProductsController : Controller
    {
        private readonly IProductWriteRepository _productWriteRepository;
        private readonly IProductReadRepository _productReadRepository;
        private readonly IMapper _mapper;

        public ProductsController(IProductWriteRepository productWriteRepository, IProductReadRepository productReadRepository, IMapper mapper)
        {
            _productWriteRepository = productWriteRepository;
            _productReadRepository = productReadRepository;
            _mapper = mapper;
        }

        public IActionResult Products()
        {
            return View();
        }

        [Route("/products/GetAllProducts/")]
        [HttpGet]
        public List<ProductVM> GetAllProducts()
        {
            
            try
            {
                List<Product> productList = _productReadRepository.GetAll().ToList();
                List<ProductVM> productVMList = _mapper.Map<List<ProductVM>>(productList);
                return productVMList;
            }
            catch (Exception)
            {
                return null;
                throw;
            }

        }
        [Route("/products/GetProductByCategory/")]
        [HttpPost]
        public List<ProductVM>? GetProductByCategory(List<Guid> filterCategoryList)
        {
            
            try
            {
                List<Product> productList = _productReadRepository.GetAll().ToList();

                List<Product> filterProducts = new List<Product>();


                foreach (Guid item in filterCategoryList)
                {
                    for (int i = 0; i < productList.Count; i++)
                    {
                        if (productList[i].Category.ID == item)
                        {
                            filterProducts.Add(productList[i]);
                        }
                    }
                }

                List<ProductVM> productVMList = _mapper.Map<List<ProductVM>>(filterProducts);
                return productVMList;
            }
            catch (Exception)
            {
                return null;
                throw;
            }

        }




    }
}
