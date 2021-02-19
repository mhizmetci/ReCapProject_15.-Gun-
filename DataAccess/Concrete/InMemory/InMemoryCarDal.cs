using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            { 
                new Car{ Id=1, CarName= "Mercedes CLA", BrandId =1, ColorId = 1, DailyPrice= 800, ModelYear = 2018, Description = "Mercedes CLA \n Otomatik vites\n Benzinli "},
                new Car{ Id=2, CarName= "Renault Clio", BrandId =2, ColorId = 2, DailyPrice= 200, ModelYear = 2004, Description = "Renault Clio \n Manuel vites\n Benzin-LPG "},
                new Car{ Id=3, CarName= "Renault Megane", BrandId =2, ColorId = 2, DailyPrice= 250, ModelYear = 2012, Description = "Renault Megane \n Manuel vites\n Dizel "},
                new Car{ Id=4, CarName= "Skoda Oktavia", BrandId =3, ColorId = 1, DailyPrice= 500, ModelYear = 2015, Description = "Skoda Oktavia \n Otomatik vites\n Benzinli "},
                new Car{ Id=5, CarName= "Volvo Vs", BrandId =4, ColorId = 3, DailyPrice= 450, ModelYear = 2011, Description = "Volvo V5 \n Otomatik vites\n Benzinli "},
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            //Car carToDelete = null;
            //foreach (var c in _cars)
            //{
            //    if (car.Id == c.Id)
            //    {
            //        carToDelete = c;
            //    }
            //}
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll() // tüm araçları getirir.
        {
            //listedeki tüm araçları ve özelliklerini çağıracağız
            return _cars;  //_cars daki elemanları return ile methoddan döndürdük.
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAllByBrand(int brandId) // ürünleri markalara göre filtreler
        {
           return  _cars.Where(c => c.BrandId == brandId).ToList();
        }

        public List<Car> GetallByColor(int colorId)
        {
            return _cars.Where(c => c.ColorId == colorId).ToList();
        }

        public List<Car> GetById(int Id)
        {
            // Car "ıd" sine göre araba nesnesini çağıracağız
            return _cars.Where(c => c.Id == Id).ToList(); //liste döndürdük buradan ama where ile liste alınmadığından listeye çevirdik
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            //Gönderdiğim ürün Id sine sahip olan listedeki ürünü bul.
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.CarName = car.CarName;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;

           
        }
    }
}
