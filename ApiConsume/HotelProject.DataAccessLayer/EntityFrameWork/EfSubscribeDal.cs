using System;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.DataAccessLayer.Concreate;
using HotelProject.DataAccessLayer.Repositories;
using HotelProject.EntityLayer.Concreate;

namespace HotelProject.DataAccessLayer.EntityFrameWork
{
	public class EfSubscribeDal : GenericRepository<Subscribe>, ISubscribeDal
	{
		public EfSubscribeDal(Context context) : base(context)
		{

		}
	}
}

