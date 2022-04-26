using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

using System.Web;
using System.Web.Mvc;
using AutoMapper;
using MarketPlace.DataLayer;
using MarketPlace.Models;
using MarketPlace.RepoLayer.Repositorys;
using MarketPlace.ServiceLayer;
using MarketPlace.ServiceLayer.Models;
using static MarketPlace.Models.UserInfoVM;

namespace MarketPlace.Controllers
{
    
    public class HomeController : Controller
    {
        MapperConfiguration config;
        IMapper mapper;
        ProductService productService;
        UserService userService;
        private readonly MarketPlaceEntities1 _marketPlaceEntities;
        private readonly UnitOfWork _uow;
        public HomeController()
        {
            productService = new ProductService();
            config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<ProductDTO, ProductInfoVM>();
                cfg.CreateMap<ProductInfoVM,ProductDTO>();
                cfg.CreateMap<UserDTO, UserInfoVM>();
                cfg.CreateMap<UserInfoVM, UserDTO>();
            });
            mapper = config.CreateMapper();

            this._marketPlaceEntities = new MarketPlaceEntities1();
             _uow= new UnitOfWork(_marketPlaceEntities);
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        // [Route("UserLogin/LoginPage")]
        public ActionResult LogInPage()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        [HttpPost]
        public ActionResult LogInPage(Models.UserInfoVM model)
        {
            
                var pwd = _uow.Users.GetPasswordByUsername(model.Name);
                   if (pwd == model.Password)
                    {
                        return View("SearchPage");
                    }
                   else
                    {
                return Content("The entered username or password is incorrect! please enter again.");
                   }
            
            
           

        }

      
        public ActionResult SignUpPage()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpPost]
        public ActionResult SignUpPage(Models.UserInfoVM model)
        {
            if (ModelState.IsValid)
            {
                tblUser newUser = new tblUser();
                newUser.User_Name = model.Name;
                newUser.User_Password = model.Password;
                newUser.User_Email = model.Email;
                newUser.Credential_ID = 1;
                _uow.Users.Add(newUser);
                _uow.Complete();



                return View("SearchPage");
            }
            else
            {

                //If the validation fails, we are returning the model object with errors to the view, which will display the error messages.
                ModelState.AddModelError("Signup Error", "The entered username or password is incorrect! please enter again.");
                return View();
            }
        
        
        }

       
       
        public ActionResult SearchPage()
        {
           

            return View();
        }
        [HttpPost]
        public ActionResult SearchPage(FormCollection frm)
        {

                 string ProductName = frm["Search"];
          
            var Product = productService.ProductInfoByProdectName(ProductName);
            var ProductInfoVMs = mapper.Map<IEnumerable<ProductDTO>, IEnumerable<ProductInfoVM>>(Product);
            return View("Products", ProductInfoVMs);

            /* ProductService productService = new ProductService();
             var productDetail = productService.ProductInfoByProdectName(ProductName);


             List<ProductInfoVM> productList = new List<ProductInfoVM>();
             foreach (ProductDTO item in productDetail)
             {
             ProductInfoVM productInfoVM = new ProductInfoVM();

             *//*productInfoVM.ProductName = item.ProductName;
             productInfoVM.Product_ID=item.Product_ID;
             productInfoVM.Manufacturer_Name = item.Manufacturer_Name;*//*

             productInfoVM = mapper.Map<IEnumerable<ProductDTO>, IEnumerable<ProductInfoVM>>(item);
             productList.Add(productInfoVM);
             }
         return View("Products", productList);*/
        }    
           
            
        

        public ActionResult Products()
        {


            return View();
        }


    }
}