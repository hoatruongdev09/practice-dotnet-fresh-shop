using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace FreshShop.Components
{
    public class FeatureProductViewComponent : ViewComponent
    {
        private ILogger<FeatureProductViewComponent> _logger;

        public FeatureProductViewComponent(ILogger<FeatureProductViewComponent> logger)
        {
            _logger = logger;
        }

        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}