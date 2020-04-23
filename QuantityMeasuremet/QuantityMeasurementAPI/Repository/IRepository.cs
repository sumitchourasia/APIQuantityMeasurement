using System;
using System.Collections.Generic;
using System.Text;
using QuantityUnits;

namespace Repository
{
    public interface IRepository
    {
        double Convert(Data data);
    }
}
