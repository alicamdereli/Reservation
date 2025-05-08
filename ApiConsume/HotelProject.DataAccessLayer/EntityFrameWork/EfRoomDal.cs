using System;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.DataAccessLayer.Concreate;
using HotelProject.DataAccessLayer.Repositories;
using HotelProject.EntityLayer.Concreate;

namespace HotelProject.DataAccessLayer.EntityFrameWork
{
	public class EfRoomDal : GenericRepository<Room>, IRoomDal
	{
		public EfRoomDal(Context context) : base (context)
		{

		}
	}
}

