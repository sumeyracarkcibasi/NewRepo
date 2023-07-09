using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class PersonelController : Controller
    {
        public IActionResult Index()
        {
            Personel p1 = new Personel() { Ad="Selami", Soyad = "Şahin", Departman = "Müzik", Aktif = true };

            return View();
        }
    }
}
