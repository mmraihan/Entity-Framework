using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooApp.Models;
using ZooApp.ViewModels;

namespace ZooApp.Services
{
    public class AnimalService
    {
        public List<ViewAnimal> GetAnmals()
        {
            //Create Db Object
            ZooContext db = new ZooContext();

            //Fetch db.Animal
           //Bring all rows from table into Ram
            List<Animal> animals = db.Animals.ToList();

            //Convert data into view data

            List<ViewAnimal> viewAnimals = new List<ViewAnimal>();

            foreach (Animal animal in animals)
            {
                ViewAnimal viewAnimal = new ViewAnimal()
                {
                    Id = animal.Id,
                    Name = animal.Name,
                    Food = animal.Food,
                    Origin = animal.Origin,
                    Quantity = animal.Quantity
                    
                };
                viewAnimals.Add(viewAnimal);
            }
            return viewAnimals;
            
        }

    }
}
