using Microsoft.AspNetCore.Mvc;
using Pizzapan.BusinessLayer.Abstract;
using System.Linq;

namespace Pizzapan.PresentationLayer.ViewComponents.Menu
{
    public class _DrinkPartial : ViewComponent
    {
        IProductService _productService;

        public _DrinkPartial(IProductService productService)
        {
            _productService = productService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _productService.TGetProductsWithCategory().Where(x => x.CategoryId == 4);
            return View(values);
        }
    }
}