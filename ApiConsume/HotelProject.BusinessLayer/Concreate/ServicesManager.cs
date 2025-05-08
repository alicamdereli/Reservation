using System;
using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.EntityLayer.Concreate;

namespace HotelProject.BusinessLayer.Concreate
{
	public class ServicesManager : IServicesService
	{
        private readonly IServicesDal _iservicesDal;

        public ServicesManager(IServicesDal iservicesDal)
        {
            _iservicesDal = iservicesDal;
        }

        public void TDelete(Service t)
        {
            _iservicesDal.Delete(t);
        }

        public Service TGetById(int id)
        {
            return _iservicesDal.GetById(id);
        }

        public List<Service> TGetList()
        {
            return _iservicesDal.GetList();
        }

        public void TInsert(Service t)
        {
            _iservicesDal.Insert(t);
        }

        public void TUpdate(Service t)
        {
            _iservicesDal.Update(t);
        }
    }
}

