using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using FreshShop.Models;
namespace FreshShop.Controllers
{
    public class ShopController : Controller
    {
        private readonly ILogger<ShopController> _logger;
        public ShopController(ILogger<ShopController> logger)
        {
            this._logger = logger;
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Detail(int id)
        {
            var productDetail = new ProductDetailViewModel()
            {
                ProductID = 0,
                ProductName = "Fachion Lorem ipsum dolor sit amet",
                ProductDescription = @"Nam sagittis a augue eget scelerisque. Nullam lacinia consectetur sagittis. Nam sed neque id eros fermentum dignissim quis at tortor. Nullam ultricies urna quis sem sagittis pharetra. Nam erat turpis, cursus in ipsum at, tempor imperdiet metus. In interdum id nulla tristique accumsan. Ut semper in quam nec pretium. Donec egestas finibus suscipit. Curabitur tincidunt convallis arcu.",
                ProductPrice = 60,
                DiscountPrice = 40.79f,
                ProductImages = new string[] { "/images/smp-img-01.jpg", "/images/smp-img-02.jpg", "/images/smp-img-03.jpg" }
            };
            return View(productDetail);
        }
    }
}