using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using MarketPlace.Models;
using MarketPlace.ServiceLayer;
using MarketPlace.ServiceLayer.Models;

namespace MarketPlace.Controllers
{
    public class HomeController : Controller
    {
        MapperConfiguration config;
        IMapper mapper;
        ProductService productService;
        UserService userService;

        public HomeController()
        {
            productService = new ProductService();
            config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<ProductDTO, ProductInfoVM>();
                cfg.CreateMap<UserDTO, UserInfoVM>();
            });
            mapper = config.CreateMapper();
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
        [Route("UserLogin/LoginPage")]
        public ActionResult LogInPage()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        [Route("UserLogin/SignUpPage")]
        public ActionResult SignUpPage()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}