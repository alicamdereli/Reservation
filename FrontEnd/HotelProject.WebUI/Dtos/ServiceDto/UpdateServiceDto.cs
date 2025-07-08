using System;
using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.Dtos.ServiceDto
{
	public class UpdateServiceDto
	{
        public int ServiceId { get; set; }
        [Required(ErrorMessage = "Servis ikon linki giriniz.")]
        public string ServiceIcon { get; set; }
        [Required(ErrorMessage = "Hizmet başlığı giriniz.")]
        [StringLength(100, ErrorMessage = "Hizmet başlığı en fazla 100 karekter olabilir")]
        public string Title { get; set; }
        [StringLength(500, ErrorMessage = "Hizmet açıklaması en fazla 500 karekter olabilir")]
        public string Description { get; set; }
    }
}

