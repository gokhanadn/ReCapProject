using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            ColorManager colorManager = new ColorManager(new EfColorDal());
            BrandManager brandManager = new BrandManager(new EfBrandDal());

            //FirstHW(carManager);

            ////////////////////////////////////////////////////////////


            //SecondHW(carManager);

            ////////////////////////////////////////////////////////////


            ThirdHW(carManager, colorManager, brandManager);

            ////////////////////////////////////////////////////////////

            UserManager userManager = new UserManager(new EfUserDal());

            userManager.Add(new User
            {
                Id = 1,
                FirstName = "Ahmet",
                LastName = "Yılmaz",
                Email = "ahmetyilmaz@gmail.com",
                Password = "1234556"
            });

            userManager.Add(new User
            {
                Id = 2,
                FirstName = "Süleyman",
                LastName = "Açıkgöz",
                Email = "süleymanacikgoz@gmail.com",
                Password = "09876"
            });

            userManager.Add(new User
            {
                Id = 3,
                FirstName = "Gökhan",
                LastName = "Aydın",
                Email = "gokhanaydin@gmail.com",
                Password = "12345642"
            });

            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());

            customerManager.Add(new Customer
            {
                Id = 1,
                UserId = 1,
                CompanyName = "sada"
            });

            customerManager.Add(new Customer
            {
                Id = 2,
                UserId = 2
            });

            RentalManager rentalManager = new RentalManager(new EfRentalDal());

            rentalManager.Add(new Rental 
            {
                Id = 1,
                CarId = 2,
                CustomerId = 1,
                RentDate = new DateTime(2021, 2, 13),
                ReturnDate = new DateTime(2021, 2, 13)
            });

        }

        ///////////////////////////////////////
        
        private static void ThirdHW(CarManager carManager, ColorManager colorManager, BrandManager brandManager)
        {
            Dictionary<int, string> colors = new Dictionary<int, string>()
            {
                [1] = "Mavi",
                [2] = "Kırmızı",
                [3] = "Siyah",
                [4] = "Turuncu",
                [5] = "Beyaz",
            };


            foreach (var color in colors)
            {
                colorManager.Add(new Color
                {
                    Id = color.Key,
                    Name = color.Value
                });
            }

            colorManager.GetAll();

            ///////////////////////////////

            Dictionary<int, string> brands = new Dictionary<int, string>()
            {
                [1] = "BMW",
                [2] = "Mercedes",
                [3] = "Toyoto",
                [4] = "Tofaş",
                [5] = "Audi",
            };

            foreach (var brand in brands)
            {
                brandManager.Add(new Brand
                {
                    Id = brand.Key,
                    Name = brand.Value
                });
            }



            ///////////////////////////////

            carManager.Add(new Car
            {
                Id = 1,
                BrandId = 1,
                ColorId = 3,
                CarName = "BMW",
                ModelYear = 2010,
                DailyPrice = 1000
            });


            carManager.Add(new Car
            {
                Id = 2,
                BrandId = 2,
                ColorId = 3,
                CarName = "Mercedes",
                ModelYear = 2014,
                DailyPrice = 1500
            });

            ///////////////////////////////


            //    carManager.Update(new Car { Id = 2, BrandId = 2, ColorId = 2, CarName = "Mercedes", DailyPrice = 2000, ModelYear = 2014 });

            //    System.Console.WriteLine("-------------GetAll----------");
            //    foreach (var car in carManager.GetAll())
            //    {
            //        System.Console.WriteLine(car.CarName);
            //    }
            //    System.Console.WriteLine("-------------------------------------------");

            //    brandManager.Delete(new Brand { Id = 4 });

            //    System.Console.WriteLine("-------------GetAllBrands----------");

            //    foreach (var brand in brandManager.GetAll())
            //    {
            //        System.Console.WriteLine(brand.Name);
            //    }
            //    System.Console.WriteLine("-------------------------------------------");


            //    System.Console.WriteLine("-------------GetCarDetails----------");

            //    foreach (var car in carManager.GetCarDetails())
            //    {
            //        System.Console.WriteLine("Araba ismi: {0}, Markası: {1}, Rengi: {2}, Günlük Ücreti: {3}", car.CarName, car.BrandName, car.ColorName, car.DailyPrice);
            //    }
            //}

            //private static void SecondHW(CarManager carManager)
            //{
            //    // Hata Mesajı Verir.
            //    carManager.Add(new Car
            //    {
            //        BrandId = 2,
            //        ColorId = 3,
            //        CarName = "W",
            //        ModelYear = 2010,
            //        DailyPrice = 1000,

            //    });

            //    // Başarılı bir şekilde ekleme yapar.
            //    carManager.Add(new Car
            //    {
            //        BrandId = 2,
            //        ColorId = 3,
            //        CarName = "BMW",
            //        ModelYear = 2010,
            //        DailyPrice = 1000,

            //    });

            //    foreach (var car in carManager.GetAll())
            //    {
            //        System.Console.WriteLine(car.CarName);
            //    }
            //    System.Console.WriteLine("------------------");
            //}

            //private static void FirstHW(CarManager carManager)
            //{
            //    foreach (var car in carManager.GetAll())
            //    {
            //        System.Console.WriteLine("Araba ID: " + car.Id + " " +
            //                                "Araba Modeli: " + car.Description + " " +
            //                                "Araba Marka ID: " + car.BrandId + " " +
            //                                "Araba Renk ID: " + car.ColorId + " " +
            //                                "Araba Günlük Ücreti: " + car.DailyPrice);
            //    }
            //    System.Console.WriteLine("-----------------------\n");

            //    System.Console.WriteLine("Get By ID");

            //    System.Console.WriteLine("------------");

            //    foreach (var car1 in carManager.GetById(2))
            //    {
            //        System.Console.WriteLine("Araba ID: " + car1.Id + " " + "Araba Modeli: " + car1.Description);
            //    }

            //    for (int ID = 1; ID <= carManager.GetAll().Count; ID++)
            //    {
            //        foreach (var car1 in carManager.GetById(ID))
            //        {
            //            System.Console.WriteLine("Araba ID: " + car1.Id + " " + "Araba Modeli: " + car1.Description);
            //        }
            //    }
            //}
        }
    }
}
