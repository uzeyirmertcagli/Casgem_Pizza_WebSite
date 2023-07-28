using Microsoft.AspNetCore.Mvc;
using Pizzapan.BusinessLayer.Abstract;
using Pizzapan.EntityLayer.Concrete;
using System.Collections.Generic;

namespace Pizzapan.PresentationLayer.Controllers
{
    public class StatisticController : Controller
    {
        private readonly IOurTeamService _OurTeamService;

        public StatisticController(IOurTeamService ourTeamService)
        {
            _OurTeamService = ourTeamService;
        }
        public IActionResult Index()
        {
            List<OurTeam> ourTeam = _OurTeamService.TGetList();
            return View(ourTeam);
        }
    }
}
