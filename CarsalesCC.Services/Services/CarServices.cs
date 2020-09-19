using AutoMapper;
using CarsalesCC.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CarsalesCC.Services
{
    public class CarService : ICarService
    {
        private readonly ICarsRepository _carsRepository;
        private readonly IMapper _mapper;
        public CarService(ICarsRepository carsRepository,IMapper mapper)
        {
            _carsRepository = carsRepository;
            _mapper = mapper;
        }
        public Task<string> Create(CarCreateRequestDto carDto)
        {
            var car=_mapper.Map<CarCreateRequestDto, CarEntity>(carDto);

           return Task.FromResult( _carsRepository.Create(car));
        }
    }
}
