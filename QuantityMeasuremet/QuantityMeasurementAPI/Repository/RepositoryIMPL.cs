using Model;
using Model.LengthModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class RepositoryIMPL : IRepository
    {
        double IRepository.Convert(Data data)
        {
            dynamic UnitToConvert = QuantityUnitFactory.CreateQuantityUnitObject(data.inputtype, data.valuetoconvert);
            dynamic UnitConvertTo = QuantityUnitFactory.CreateQuantityUnitObject(data.outputtype);
           /* Feet UnitToConvert = (Feet)QuantityUnitFactory.CreateQuantityUnitObject(data.inputtype, data.valuetoconvert);
            Inch UnitConvertTo = (Inch)QuantityUnitFactory.CreateQuantityUnitObject(data.outputtype);
           */ 
            return UnitToConvert.Convert(UnitConvertTo); 
        }
    }
}
