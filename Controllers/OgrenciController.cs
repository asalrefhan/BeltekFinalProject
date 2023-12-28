using BeltekFinalProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BeltekFinalProject.Controllers
{
    public class OgrenciController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult OgrenciListele()
        {
            List<Ogrenci> lst;
            using (var ctx = new OkulDbContext())
            {
                lst = ctx.Ogrenciler.ToList();
            }

            return View(lst);
        }


        public IActionResult OgrenciEkle()
        {
            return View();
        }

        [HttpPost]
        public IActionResult OgrenciEkle(Ogrenci ogr)
        {
            using (var ctx = new OkulDbContext())
            {
                if (ModelState.IsValid)
                {
                    ctx.Ogrenciler.Add(ogr);
                    ctx.SaveChanges();
                    return RedirectToAction("OgrenciListele");
                }

            }
            return View();

        }

        public IActionResult OgrenciDuzenle(int id)
        {
            Ogrenci ogr;
            using (var ctx = new OkulDbContext())
            {
                ogr = ctx.Ogrenciler.Find(id);
            }
            return View(ogr);
        }

        [HttpPost]
        public IActionResult OgrenciDuzenle(Ogrenci ogr)
        {
            using (var ctx = new OkulDbContext())
            {
                if (ModelState.IsValid)
                {
                    ctx.Entry(ogr).State = EntityState.Modified;
                    ctx.SaveChanges();
                    return RedirectToAction("OgrenciListele");
                }
            }

            return View();
        }


        public IActionResult OgrenciSil(int id)
        {
            using (var ctx = new OkulDbContext())
            {
                var ogr = ctx.Ogrenciler.Find(id);
                ctx.Ogrenciler.Remove(ogr);
                ctx.SaveChanges();
            }
            return RedirectToAction("OgrenciListele");

        }

    }
}
