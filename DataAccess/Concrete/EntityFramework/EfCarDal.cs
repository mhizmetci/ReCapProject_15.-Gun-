using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dtos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    //Nuget : Paket kodların olduğu bir alan. Bunu kullanacağız.
    public class EfCarDal : EfEntityRepositoryBase<Car, ReCapContext>, ICarDal  //Dal: DataAccess Layer.
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (ReCapContext context = new ReCapContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands
                             on c.BrandId equals b.BrandId
                             join p in context.Colors
                             on c.ColorId equals p.ColorId
                             select new CarDetailDto 
                             {Id = c.Id, CarName = c.CarName, BrandName = b.BrandName,ColorName =p.ColorName, DailyPrice = c.DailyPrice,  };
                return result.ToList();

            }
        }
    }
}
