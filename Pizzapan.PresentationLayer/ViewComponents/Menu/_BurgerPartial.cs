using Microsoft.AspNetCore.Mvc;
using Pizzapan.BusinessLayer.Abstract;
using System.Linq;

namespace Pizzapan.PresentationLayer.ViewComponents.Menu
{
    public class _BurgerPartial : ViewComponent
    {

        IProductService _productService;
        public _BurgerPartial(IProductService productService)
        {
            _productService = productService;
        }
        public IViewComponentResult Invoke()
        {
            var values = _productService.TGetProductsWithCategory().Where(x => x.CategoryId == 2);
            return View(values);
        }
    }
}