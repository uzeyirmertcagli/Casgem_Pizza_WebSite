using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzapan.EntityLayer.Concrete
{

    // IdentityUser<int> yazmamızın sebebi primary key olarak string yerine int gelmesini istememiz.
    public class AppUser : IdentityUser<int>
    {

        //Identity tablosundaki otomatik verilere buradan manuel olarak veri ekleme yapılır.
        public string Name { get; set; }
        public string Surname { get; set; }
        public string City { get; set; }

        public int? ConfirmCode { get; set; }
    }
}
