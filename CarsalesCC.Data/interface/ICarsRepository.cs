using System;
using System.Collections.Generic;
using System.Text;

namespace CarsalesCC.Data
{
    public interface ICarsRepository
    {
        CarEntity Create(CarEntity car);
        List<CarEntity> GetAll();
    }
}
