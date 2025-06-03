using System;
using System.ComponentModel.DataAnnotations;

namespace HotelProject.DtoLayer.Dtos.RoomDto
{
	public class UpdateRoomDto
	{
        public int RoomId { get; set; }

        [Required(ErrorMessage = "Lüten oda numrasını yazınız.")]
        public string RoomNumber { get; set; }

        [Required(ErrorMessage = "Lüten oda görselini giriniz.")]
        public string RoomCoverImage { get; set; }

        [Required(ErrorMessage = "Lüten fiyat bilgisi giriniz.")]
        public int Price { get; set; }

        [Required(ErrorMessage = "Lüten yatak sayısını giriniz.")]
        public string BedCount { get; set; }

        [Required(ErrorMessage = "Lüten banyo sayısını giriniz.")]
        public string BathCount { get; set; }
        public string Wifi { get; set; }

        [StringLength(100,ErrorMessage = "Lütfen en fazla 100 karekter veri girişi yazınız")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Lüten açıklamayı yazınız")]
        public string Description { get; set; }
    }
}

