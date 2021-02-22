using Core.Utilities.Results;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
  public  interface IRentalService
    {
        IDataResult<List<Rental>> GetAll();
        IDataResult <Rental> GetById(int customerId);
        IDataResult<List<RentalDetailDto>>GetRentalDetails();

        IResult Add(Rental rental);
        IResult Delete(Rental rental);
        IResult DeliverCar(int Id, DateTime time);
        IResult Update(Rental rental);
    }
}
