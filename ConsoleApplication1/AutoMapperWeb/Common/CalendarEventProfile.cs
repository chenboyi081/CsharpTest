using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AutoMapperWeb.Common
{
    public class CalendarEventProfile: Profile
    {
        public CalendarEventProfile()
        {
           CreateMap<Models.CalendarEvent, Models.Dto.CalendarEventForm>()
            .ForMember(dest => dest.EventDate, opt => opt.MapFrom(src => src.Date.Date))
            .ForMember(dest => dest.EventHour, opt => opt.MapFrom(src => src.Date.Hour))
            .ForMember(dest => dest.EventMinute, opt => opt.MapFrom(src => src.Date.Minute))
            .ForMember(dest => dest.DisplayTitle, opt => opt.MapFrom(src => src.Title));
        }
    }
}