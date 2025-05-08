using System;
namespace HotelProject.BusinessLayer.Abstract
{
	public interface IGenericServices <T> where T : class
	{
        void TInsert(T t);
        void TDelete(T t);
        void TUpdate(T t);
        List<T> TGetList();
        T TGetById(int id);
    }
}

