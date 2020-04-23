using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Manager
{
    public interface IMeasurementManager
    {
        double Convert(Data data);
    }
}
