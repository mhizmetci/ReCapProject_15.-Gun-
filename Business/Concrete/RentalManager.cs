using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;

        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }

        public void Add(Rental rental)
        {
            throw new NotImplementedException();
        }

        public void Delete(Rental rental)
        {
            throw new NotImplementedException();
        }

        public List<Rental> GetAll()
        {
            return _rentalDal.GetAll();
        }

        public Rental GetById(int customerId)
        {
            return _rentalDal.Get(r => r.CustomerId == customerId);
        }

        public void Update(Rental rental)
        {
            throw new NotImplementedException();
        }
    }
}
