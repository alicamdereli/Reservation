using System;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.DataAccessLayer.Concreate;
using HotelProject.DataAccessLayer.Repositories;
using HotelProject.EntityLayer.Concreate;
namespace HotelProject.DataAccessLayer.EntityFrameWork
{
	public class EfStaffDal : GenericRepository<Staff>, IStaffDal
	{
		public EfStaffDal(Context context) : base(context)
		{

		}
	}
}

