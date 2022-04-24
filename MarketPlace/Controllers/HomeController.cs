using System;
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
        public ActionResult LogInPage(string Name, string password)
        {


            var pwd = _uow.Users.GetPasswordByUsername(Name);

            if (string.IsNullOrWhiteSpace(pwd))
            {

                // TODO: throw error 
                // response 400 
                return View("LogInPage");


            }
            if (pwd == password)
            {
                return RedirectToAction("SearchPage");
            }
            else
            {
                ModelState.AddModelError("", "invalid User name or Password");
                return View("LogInPage");
            }

          

        }

      
        public ActionResult SignUpPage()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpPost]
        public ActionResult SignUpPage(UserInfoVM userInfo)
        {
            if (ModelState.IsValid)
            {
                tblUser newUser = new tblUser();
                newUser.User_Name = userInfo.Name;
                newUser.User_Password = userInfo.Password;
                newUser.User_Email = userInfo.Email;
            
                _uow.Users.Add(newUser);
                _uow.Complete();
          


                return View("Products");
            }
            else
            {

                //If the validation fails, we are returning the model object with errors to the view, which will display the error messages.
                return View("LogInPage");
            }
        
        
        }



        public ActionResult Products()
        {


            var result = _uow.Products.GetAll();
            List<ProductInfoVM> productList = new List<ProductInfoVM>();

            foreach (var item in result)
            {
                ProductInfoVM productVM = new ProductInfoVM();
                productVM.Product_ID= item.Product_ID;
                productVM.ProductName= item.Product_Name;

                productList.Add(productVM);
            }

            return View("Products", productList);
        }

    }
}