using Business.Concrete;
using Entities.Concrete;
using DataAccess.Concrete.InMemory;
using System;


namespace ReCapProject1
{
     class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("Car ID: " + car.Id + " Brand: " + car.BrandId + " Color: " + car.ColorId + " Model Year: " + car.ModelYear + " Daily Price: " + car.DailyPrice + " Description: " + car.Description);
            }

            Console.WriteLine("-----------------------------");
        }
    }
}
