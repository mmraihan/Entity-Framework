using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ZooApp.Models;
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

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Animal animal)
        {
            //Save
            bool saved = service.Save(animal);
            return RedirectToAction("Index");
        }


        [HttpGet]
        public ActionResult Edit(int id)
        {
            Animal animal=service.GetDbAnimal(id);
            return View(animal);
        }

        [HttpPost]
        public ActionResult Edit(Animal animal)
        {
            //Save
            bool saved = service.Update(animal);
            return RedirectToAction("Index");
        }


        [HttpGet]
        public ActionResult Delete()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Delete(Animal animal)
        {
            //Save
            bool saved = service.Delete(animal);
            return RedirectToAction("Index");
        }


    }
}