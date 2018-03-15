using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet.o2.Models;
using Microsoft.AspNetCore.Mvc;
using MyHobbies;

namespace dotnet.o2.Controllers
{
    public class BandLidController : Controller
    {
        private BandModel model = new BandModel();

        [HttpGet]
        public IActionResult Maak(string band)
        {
            ViewBag.Band = model.GetByName(band);
            return View();
        }

        [HttpPost]
        public IActionResult Maak(string naam, string band, string geslacht, int leeftijd)
        {
            BandModel model = new BandModel();
            Band _band = model.GetByName(band);
            if (_band != null)
            {
                Geslacht _geslacht = Geslacht.Undefined;
                if (geslacht == "Man")
                {
                    _geslacht = Geslacht.Man;
                }
                else
                {
                    _geslacht = Geslacht.Vrouw;
                }
                BandLid lid = new BandLid { Geslacht = _geslacht, Naam = naam, Leeftijd = leeftijd };
                _band.AddLid(lid);
                model.SaveBand(_band);
                return Redirect("/Band/LijstMetLeden");
            }
            return View();
        }
    }
}