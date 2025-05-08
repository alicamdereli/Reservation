using System;
using HotelProject.EntityLayer.Concreate;

namespace HotelProject.DataAccessLayer.Abstract
{
    public interface ISubscribeDal : IGenericDal<Subscribe>
    {
        void Delete(HotelProject.EntityLayer.Concreate.Subscribe t);
    }
}

