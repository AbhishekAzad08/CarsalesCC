using AutoMapper;
using CarsalesCC.Data;
using CarsalesCC.Services;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarsalesCC.RequestDTOs
{
    public class DtoMapper:Profile
    {
        public DtoMapper()
        {
            CreateMap<JRaw, JRaw>().ConvertUsing(value => value);
            //CreateMap<CarEntity, CarDto>()
            //    .ForMember(destination => destination.model, options => options.MapFrom(source => source.Model))
            //    .ForMember(destination => destination.make, options => options.MapFrom(source => source.Make))
            //    .ForMember(destination => destination.vehicletype, options => options.MapFrom(source => source.VehicleType))
            //    .ForMember(destination => destination.doors, options => options.MapFrom(source => source.Doors))
            //    .ForMember(destination => destination.engine, options => options.MapFrom(source => source.Engine))
            //    .ForMember(destination => destination.bodytype, options => options.MapFrom(source => source.BodyType))
            //    .ForMember(destination => destination.wheels, options => options.MapFrom(source => source.Wheels));
            CreateMap<CarCreateRequestDto, CarEntity>()
                .ForMember(destination => destination.Model, options => options.MapFrom(source => source.model))
                .ForMember(destination => destination.Make, options => options.MapFrom(source => source.make))
                .ForMember(destination => destination.VehicleType, options => options.MapFrom(source => source.vehicletype))
                .ForMember(destination => destination.Doors, options => options.MapFrom(source => source.doors))
                .ForMember(destination => destination.Engine, options => options.MapFrom(source => source.engine))
                .ForMember(destination => destination.BodyType, options => options.MapFrom(source => source.bodytype))
                .ForMember(destination => destination.Wheels, options => options.MapFrom(source => source.wheels));

        }
       
    }
}
