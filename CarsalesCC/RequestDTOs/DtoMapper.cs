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
            CreateMap<CarEntity, CarCreateResponseDto>()
                .ForMember(destination => destination.Id, options => options.MapFrom(source => source.Id))
                .ForMember(destination => destination.Vehicletype, options => options.MapFrom(source => source.VehicleType));

            CreateMap<CarEntity, CarGetResponseDto>()
                .ForMember(destination => destination.Model, options => options.MapFrom(source => source.Model))
                .ForMember(destination => destination.Make, options => options.MapFrom(source => source.Make))
                .ForMember(destination => destination.VehicleType, options => options.MapFrom(source => source.VehicleType))
                .ForMember(destination => destination.Doors, options => options.MapFrom(source => source.Doors))
                .ForMember(destination => destination.Engine, options => options.MapFrom(source => source.Engine))
                .ForMember(destination => destination.BodyType, options => options.MapFrom(source => source.BodyType))
                .ForMember(destination => destination.Wheels, options => options.MapFrom(source => source.Wheels));
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
