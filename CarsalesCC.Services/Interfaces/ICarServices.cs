using CarsalesCC.Data;
using CarsalesCC.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CarsalesCC.Services
{
    public interface ICarService
    {
        Task<CarCreateResponseDto> Create(CarCreateRequestDto carDto);
        List<CarGetResponseDto> GetAll();
    }
}
