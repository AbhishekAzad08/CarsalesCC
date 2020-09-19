using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CarsalesCC.Services
{
    public interface ICarService
    {
        Task<string> Create(CarCreateRequestDto carDto);
    }
}
