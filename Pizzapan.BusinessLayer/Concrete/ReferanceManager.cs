using Pizzapan.BusinessLayer.Abstract;
using Pizzapan.DataAccessLayer.Abstract;
using Pizzapan.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzapan.BusinessLayer.Concrete
{
    public class ReferanceManager : IReferanceService
    {
        private readonly IReferanceDal _referanceDal;

        public ReferanceManager(IReferanceDal referanceDal)
        {
            _referanceDal = referanceDal;
        }

        public void TDelete(Referance t)
        {
            throw new NotImplementedException();
        }

        public Referance TGetByID(int id)
        {
            return _referanceDal.GetByID(id);
        }

        public List<Referance> TGetList()
        {
            return _referanceDal.GetList();
        }

        public void TInsert(Referance t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Referance t)
        {
            throw new NotImplementedException();
        }
    }
}
