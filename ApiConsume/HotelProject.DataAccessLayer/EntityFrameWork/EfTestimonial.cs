using System;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.DataAccessLayer.Concreate;
using HotelProject.DataAccessLayer.Repositories;
using HotelProject.EntityLayer.Concreate;
namespace HotelProject.DataAccessLayer.EntityFrameWork
{
	public class EfTestimonial : GenericRepository<Testimonial>,ITestimonialDal
	{
		public EfTestimonial(Context context) : base(context)
		{

		}
	}
}

