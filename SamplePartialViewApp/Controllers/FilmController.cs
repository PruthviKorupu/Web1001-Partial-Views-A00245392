using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SamplePartialViewApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SamplePartialViewApp.Controllers
{
    public class FilmController : Controller
    {
        public List<Film> _films= new();

        public FilmController() 
        {
            _films = new List<Film>()
            {
            new Film() {FilmName="abc",Description="abc film description",Duration="02:20:00" },
            new Film() {FilmName="efg",Description="efg film description",Duration="01:10:10" },
            new Film() {FilmName="hij",Description="hij film description",Duration="01:20:00" },
            };
            
        }

        public ActionResult Index()
        {
            ViewBag.Films = _films;
            return View();
        }
    }
}
