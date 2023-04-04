using EF.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF
{
    public class AppRepository
    {


        public void CreateCar(string name, int id, string model, int tankcapacity)
        {
            using var dbContext = new AppDbContext();

            var Car = new Cars
            {
                Name = name,
                Id = id,
                Model = model,
                TankCapacity = tankcapacity,

            };


            dbContext.Add(Car);

            dbContext.SaveChanges();
        }

      

        public void FindCar(int id)
        {
            using var dbContext = new AppDbContext();
            var data = dbContext.Cars
                .SingleOrDefault(x => x.Id == id);

            Console.WriteLine($"Auto : {data.Name}, {data.Model}, {data.Id}, {data.TankCapacity}");

        }

        public void DisplayAllCars()
        {
            using var dbContext = new AppDbContext();
            foreach (var item in dbContext.Cars) 
            {
                Console.WriteLine($"Auto : {item.Name}");
            }
        }

        public void ChangeCar(int id, string model, int tankCapacity)
        {
            using var dbContext = new AppDbContext();

            var Car = dbContext.Cars.FirstOrDefault(task => task.Id == id);
            Car.Model = model;
            Car.TankCapacity = tankCapacity;

            Car.LastUpdated = DateTime.Now;
            dbContext.SaveChanges();
        }

        public void DeleteFilm(int id)
        {

            using var dbContext = new AppDbContext();
            var CarDelete = dbContext
                .Cars
                .FirstOrDefault(task => task.Id == id);

            dbContext.Cars.Remove(CarDelete);
            CarDelete.LastUpdated = DateTime.Now;
            dbContext.SaveChanges();
        }



    }


}
}
