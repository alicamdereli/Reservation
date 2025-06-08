﻿using System;
using AutoMapper;
using HotelProject.DtoLayer.Dtos.RoomDto;
using HotelProject.EntityLayer.Concreate;

namespace HotelProject.WebApi.Mapping
{
	public class AutoMapperConfig : Profile
	{
		public AutoMapperConfig()
		{
			CreateMap<RoomAddDto, Room>().ReverseMap();
			CreateMap<UpdateRoomDto, Room>().ReverseMap();
        }
	}
}

