using Microsoft.AspNetCore.Http;

namespace Pizzapan.PresentationLayer.Models
{
    public class OurTeams
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Title { get; set; }
        public string Facebook { get; set; }
        public string Twitter { get; set; }
        public string ImageUrl { get; set; }
        public IFormFile Image { get; set; }
 

    }

}

