using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Merhaba Zalim Dünya!");

            CarManager carManager = new CarManager(new EfCarDal());


            var result = carManager.GetCarDetails();

            if (result.Success == true)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.CarName + "/ " + car.BrandName + "/" + car.ColorName);

                }

            }
            else
            {
                Console.WriteLine(result.Message);
            }

    
        }
    }
}


//CarManager carManager = new CarManager(new EfCarDal());

//Console.WriteLine("Günlük Araç Kiralama Fiyatları: ");

//foreach (var car in carManager.GetAll())
//{
//    Console.WriteLine("Araç Adı : " +car.CarName+ " \n " + "Model Id : " + car.BrandId + "  \n  " + "Renk Id : " + car.ColorId + "  \n  " + "Model Yılı :" + car.ModelYear + "  \n  "
//    + "Açıklama  : " + car.Description + "  \n " + "Günlük Kiralama Bedeli : " + car.DailyPrice + " TL");
//}
//Console.WriteLine(" ");

//BrandManager brandManager = new BrandManager(new EfBrandDal());
//Console.WriteLine("Araç Marka Bilgileri:");

//foreach (var brand in brandManager.GetAll())
//{
//    Console.WriteLine("Marka Id : " + brand.BrandId + "  \n  " + "Merka Adı : " + brand.BrandName);
//}
//Console.WriteLine(" ");

//ColorManager colorManager = new ColorManager(new EfColorDal());

//Console.WriteLine("Araç Renk Bilgileri:");

//foreach (var color in colorManager.GetAll())
//{
//    Console.WriteLine("Renk Id : " + color.ColorId + "  \n  " + "Renk Adı : " + color.ColorName);
//}