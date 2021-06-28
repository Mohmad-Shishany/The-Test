﻿using AutoMapper;
using MB.Taxi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using The_Test.Models;

namespace The_Test.AutoMapper
{
    public class BookingProfile : Profile
    {
        public BookingProfile()
        {
            CreateMap<Booking, BookingVM>().ReverseMap();
        }
    }
}
