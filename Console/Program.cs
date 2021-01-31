using Business.Concrete;
using DataAccess.Concrete.InMemory;
using System;

namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());

            foreach (var car in carManager.GetAll())
            {
                System.Console.WriteLine(car.Description, car.BrandId);
            }
            System.Console.WriteLine("-----------------------\n");

            System.Console.WriteLine("Get By ID\n");

            foreach (var car1 in carManager.GetById(2))
            {
                System.Console.WriteLine(car1.Description, car1.BrandId);
            }
        }
    }
}
