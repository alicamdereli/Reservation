using System;
using System.ComponentModel.DataAnnotations;

namespace HotelProject.DtoLayer.Dtos.RoomDto
{
	public class RoomAddDto
	{
        [Required(ErrorMessage = "Lüten oda numrasını yazınız.")]
        public string RoomNumber { get; set; }
        public string RoomCoverImage { get; set; }       

        [Required(ErrorMessage = "Lüten fiyat bilgisi giriniz.")]
        public int Price { get; set; }

        [Required(ErrorMessage = "Lüten yatak sayısını giriniz.")]
        public string BedCount { get; set; }

        [Required(ErrorMessage = "Lüten banyo sayısını giriniz.")]
        public string BathCount { get; set; }
        public string Wifi { get; set; }
        public string Description { get; set; }
        public string Title { get; set; }
        
    }
}

