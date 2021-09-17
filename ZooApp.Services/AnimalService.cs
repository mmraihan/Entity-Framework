using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooApp.Models;
using ZooApp.ViewModels;

namespace ZooApp.Services
{
    public class AnimalService
    {
        //Create Db Object
        ZooContext db = new ZooContext();
        public List<ViewAnimal> GetAnmals()
        {
         
           

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

        

        public ViewAnimal GetAnimal(int id)
        {
            Animal animal=  db.Animals.Find(id);
            return new ViewAnimal()
            {
                Id = animal.Id,
                Quantity = animal.Quantity,
                Origin = animal.Origin,
                Food = animal.Food,
                Name = animal.Name
            };

        }

       

        

        public bool Save(Animal animal)
        {
           Animal add= db.Animals.Add(animal);
            db.SaveChanges();
            return true;

        }

        public bool Update(Animal animal)
        {
            db.Entry(animal).State = EntityState.Modified;
            db.SaveChanges();
            return true;
        }

        public bool Delete(Animal animal)
        {
            Animal dbANimal=db.Animals.Find(animal.Id);
            db.Animals.Remove(dbANimal);
            db.SaveChanges();
            return true;
        }

        public Animal GetDbAnimal(int id)
        {
            return db.Animals.Find(id);
        }

    }
}
