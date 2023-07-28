using Microsoft.AspNetCore.Mvc;
using Pizzapan.BusinessLayer.Abstract;

namespace Pizzapan.PresentationLayer.Controllers
{
    public class ReferanceController : Controller
    {
        private readonly IReferanceService _referanceService;

        public ReferanceController(IReferanceService referanceService)
        {
            _referanceService = referanceService;
        }

        public IActionResult Index()
        {
            var values = _referanceService.TGetList();
            return View(values);
        }
    }
}
