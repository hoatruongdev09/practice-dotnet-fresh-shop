using System.Collections.Generic;
using FreshShop.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace FreshShop.Controllers
{
    public class CommentController : Controller
    {
        private ILogger<CommentController> _logger;

        public CommentController(ILogger<CommentController> logger)
        {
            _logger = logger;
        }

        public ActionResult ProductComments(int productID)
        {
            var listComments = new List<ProductCommentViewModel>(){
                new ProductCommentViewModel(){ID=0,Content="Lorem ipsum dolor sit amet, consectetur adipisicing elit. Omnis et enim aperiam inventore, similique necessitatibus neque non! Doloribus, modi sapiente laboriosam aperiam fugiat laborum. Sequi mollitia, necessitatibus quae sint natus."},
                new ProductCommentViewModel(){ID=1,Content="Lorem ipsum dolor sit amet, consectetur adipisicing elit. Omnis et enim aperiam inventore, similique necessitatibus neque non! Doloribus, modi sapiente laboriosam aperiam fugiat laborum. Sequi mollitia, necessitatibus quae sint natus."},
                new ProductCommentViewModel(){ID=2,Content="Lorem ipsum dolor sit amet, consectetur adipisicing elit. Omnis et enim aperiam inventore, similique necessitatibus neque non! Doloribus, modi sapiente laboriosam aperiam fugiat laborum. Sequi mollitia, necessitatibus quae sint natus."},
            };
            return View(listComments);
        }

    }
}