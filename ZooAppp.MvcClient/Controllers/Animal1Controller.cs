using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ZooApp.Services;
using ZooApp.ViewModels;

namespace ZooAppp.MvcClient.Controllers
{
    public class Animal1Controller : Controller
    {
        AnimalService service = new AnimalService();
        // GET: Animal1
        public ActionResult Index()
        {
            AnimalService service = new AnimalService();
            var viewAnimals= service.GetAnmals();

            return View(viewAnimals);
        }

        public ActionResult Details(int id)
        {
            ViewAnimal animal = service.GetAnimal(id);
            return View(animal);

        }





    }
}