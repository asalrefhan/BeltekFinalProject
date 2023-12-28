using BeltekFinalProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BeltekFinalProject.Controllers
{
    public class OgretmenController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult OgretmenListele()
        {
            List<Ogretmen> lst;
            using (var ctx = new OkulDbContext())
            {
                lst = ctx.Ogretmenler.ToList();
            }

            return View(lst);
        }


        public IActionResult OgretmenEkle()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult OgretmenEkle(Ogretmen ogr)
        {
            using (var ctx = new OkulDbContext())
            {
                var temp = ctx.Ogretmenler.Find(ogr.TcKimlik);
                if (temp != null)
                {
                    ModelState.AddModelError("tckimlik", "Bu Tc Kimlik No ile aynı olan bir kayıt var!");
                    return View();
                }
                {
                    if (ModelState.IsValid)
                    {
                        ctx.Ogretmenler.Add(ogr);
                        ctx.SaveChanges();
                        return RedirectToAction("OgretmenListele");
                    }
                    return View();
                }

            }


        }

        public IActionResult OgretmenDuzenle(string id)
        {
            Ogretmen ogr;
            using (var ctx = new OkulDbContext())
            {
                ogr = ctx.Ogretmenler.Find(id);
            }
            return View(ogr);
        }



        [HttpPost]
        public IActionResult OgretmenDuzenle(Ogretmen ogr)
        {
            using (var ctx = new OkulDbContext())
            {
                if (ModelState.IsValid)
                {
                    ctx.Entry(ogr).State = EntityState.Modified;
                    ctx.SaveChanges();
                    return RedirectToAction("OgretmenListele");
                }
                return View();

            }


        }


        public IActionResult OgretmenSil(string id)
        {
            using (var ctx = new OkulDbContext())
            {
                var ogr = ctx.Ogretmenler.Find(id);
                ctx.Ogretmenler.Remove(ogr);
                ctx.SaveChanges();
            }
            return RedirectToAction("OgretmenListele");

        }


    }
}
