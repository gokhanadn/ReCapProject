﻿using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());

            //foreach (var car in carManager.GetAll())
            //{
            //    System.Console.WriteLine("Araba ID: " + car.Id + " " +
            //                            "Araba Modeli: " + car.Description + " " +
            //                            "Araba Marka ID: " + car.BrandId + " " +
            //                            "Araba Renk ID: " + car.ColorId + " " +
            //                            "Araba Günlük Ücreti: " + car.DailyPrice);
            //}
            //System.Console.WriteLine("-----------------------\n");

            //System.Console.WriteLine("Get By ID");

            //System.Console.WriteLine("------------");

            //foreach (var car1 in carManager.GetById(2))
            //{
            //    System.Console.WriteLine("Araba ID: " + car1.Id + " " + "Araba Modeli: " + car1.Description);
            //}

            //for (int ID = 1; ID <= carManager.GetAll().Count; ID++)
            //{
            //    foreach (var car1 in carManager.GetById(ID))
            //    {
            //        System.Console.WriteLine("Araba ID: " + car1.Id + " " + "Araba Modeli: " + car1.Description);
            //    }
            //}

            ////////////////////////////////////////////////////////////


            // Hata Mesajı Verir.
            carManager.Add(new Car
            {
                BrandId = 2,
                ColorId = 3,
                CarName = "W",
                ModelYear = 2010,
                DailyPrice = 1000,

            });

            // Başarılı bir şekilde ekleme yapar.
            carManager.Add(new Car
            {
                BrandId = 2,
                ColorId = 3,
                CarName = "BMW",
                ModelYear = 2010,
                DailyPrice = 1000,

            });

            foreach (var car in carManager.GetAll())
            {
                System.Console.WriteLine(car.CarName);
            }
            System.Console.WriteLine("------------------");


        }
    }
}
