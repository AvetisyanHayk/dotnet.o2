using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet.o2.Models;
using Microsoft.AspNetCore.Mvc;
using MyHobbies;

namespace dotnet.o2.Controllers
{
    public class BandController : Controller
    {
        private BandModel model = new BandModel();
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Lijst()
        {
            ViewBag.Bands = model.GetAll();
            return View();
        }

        public IActionResult LijstMetLeden()
        {
            ViewBag.Bands = model.GetAll();
            return View();
        }

        [HttpGet]
        public IActionResult Maak()
        {
            ViewBag.Band = new Band();
            return View();
        }

        [HttpPost]
        public IActionResult Maak(string naam, int jaar)
        {
            model.AddBand(naam, jaar);
            return Redirect("/Band/Lijst");
        }

        [HttpGet]
        public IActionResult Wijzig(string naam)
        {
            Band band = model.GetByName(naam);
            if (band == null)
            {
                return Redirect("/Band/Maak");
            }
            ViewBag.Band = band;
            return View();
        }

        [HttpPost]
        public IActionResult Wijzig(string naam, string nieuweNaam, int jaar)
        {
            Band band = model.GetByName(naam);
            if (band != null)
            {
                band.Naam = nieuweNaam;
                band.Jaar = jaar;
                model.SaveBand(band);
            }
            return Redirect("/Band/Lijst");
        }

    }
}