
namespace Repository
{
    public class RepositoryIMPL : IRepository
    {
        double IRepository.Convert(Data data)
        {
            dynamic UnitToConvert = QuantityUnitFactory.CreateQuantityUnitObject(data.inputtype, data.valuetoconvert);
            dynamic UnitConvertTo = QuantityUnitFactory.CreateQuantityUnitObject(data.outputtype);
          
            return UnitToConvert.Convert(UnitConvertTo); 
        }
    }
}
