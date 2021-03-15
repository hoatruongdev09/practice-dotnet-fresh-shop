using System.Collections.Generic;
using FreshShop.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace FreshShop.Controllers
{
    public class ProductCommentsViewComponent : ViewComponent
    {
        private ILogger<ProductCommentsViewComponent> _logger;

        public ProductCommentsViewComponent(ILogger<ProductCommentsViewComponent> logger)
        {
            _logger = logger;
        }
        public IViewComponentResult Invoke(int productID)
        {
            var listComments = new List<ProductCommentViewModel>(){
                new ProductCommentViewModel(){ID=0,Content="comment 1"},
                new ProductCommentViewModel(){ID=1,Content="comment 2"},
                new ProductCommentViewModel(){ID=2,Content="comment 3"},
            };
            return View(listComments);
        }

    }
}