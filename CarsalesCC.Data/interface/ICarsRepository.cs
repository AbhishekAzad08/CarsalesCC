using System;
using System.Collections.Generic;
using System.Text;

namespace CarsalesCC.Data
{
    public interface ICarsRepository
    {
        string Create(CarEntity car);
    }
}
