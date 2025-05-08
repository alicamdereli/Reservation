using System;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.DataAccessLayer.Concreate;
using HotelProject.DataAccessLayer.Repositories;
using HotelProject.EntityLayer.Concreate;
namespace HotelProject.DataAccessLayer.EntityFrameWork
{
	public class EfServiceDal :GenericRepository<Service>, IServicesDal
	{
		public EfServiceDal(Context context) : base(context)
		{
		}
	}
}

