using Repository.Length;
using Repository.Weight;
using Repository.Temperature;

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
                return new Fahrenheit(valueToConvert);
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
