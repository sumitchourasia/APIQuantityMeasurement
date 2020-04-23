using QuantityUnits;
using QuantityUnits.LengthUnits;
using QuantityUnits.TemperatureUnits;
using QuantityUnits.WeightUnits;
using QuantityUnits.WeightUnits;

namespace Repository
{
    public class QuantityUnitFactory
    {
        /// <summary>
        /// Factory method
        /// </summary>
        /// <param name="type"></param>
        /// <returns>Instance</returns> 
        public static dynamic CreateQuantityUnitObject(string type, double valueToConvert = 0 )
        {
            if (type.Equals("Feet"))
                return new Feet(valueToConvert);
            else if (type.Equals("Inch"))
                return new Inch(valueToConvert);
            else if (type.Equals("Yard"))
                return new Yard(valueToConvert);
            else if (type.Equals("Fahrenhiet"))
                return new Fahrenhiet(valueToConvert);
            else if (type.Equals("Celcius"))
                return new Celcius(valueToConvert);
            else if (type.Equals("KiloGrams"))
                return new KiloGrams(valueToConvert);
            else if (type.Equals("Grams"))
                return new Grams(valueToConvert);
            return null;
        }
    }
}
