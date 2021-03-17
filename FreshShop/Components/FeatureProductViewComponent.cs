using FreshShop.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace FreshShop.Components
{
    public class FeatureProductViewComponent : ViewComponent
    {
        private ILogger<FeatureProductViewComponent> _logger;

        public FeatureProductViewComponent(ILogger<FeatureProductViewComponent> logger)
        {
            _logger = logger;
        }

        public IViewComponentResult Invoke(int productID,int categoryID, int count)
        {
            List<ProductViewModel> featureProducts = new List<ProductViewModel>();
            for(int i = 0;i<count;i++)
            {
                featureProducts.Add(new ProductViewModel()
                {
                    ProductID =i,
                    ProductName = "Feature product",
                    ProductPrice = 7.79,
                    ProductImageLink = "/images/smp-img-01.jpg"
                });
            }
            return View(featureProducts);
        }
    }
}