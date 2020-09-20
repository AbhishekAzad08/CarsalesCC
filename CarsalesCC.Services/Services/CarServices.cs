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
        public Task<CarCreateResponseDto> Create(CarCreateRequestDto carDto)
        {
            var car=_mapper.Map<CarCreateRequestDto, CarEntity>(carDto);
            var result = _carsRepository.Create(car);
            
           return Task.FromResult(_mapper.Map <CarEntity,CarCreateResponseDto >(result ));
        }

        public List<CarGetResponseDto> GetAll()
        {
            var result = _carsRepository.GetAll();
            return _mapper.Map< List<CarEntity>, List<CarGetResponseDto>>(result);
           
        }
    }
}
