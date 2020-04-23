using System;
using System.Collections.Generic;
using System.Text;
using Model.LengthModel;
using Model;

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
                return new Inch(valueToConvert);
            else if (type.Equals("Celcius"))
                return new Yard(valueToConvert);
            else if (type.Equals("KiloGrams"))
                return new Inch(valueToConvert);
            else if (type.Equals("Grams"))
                return new Yard(valueToConvert);
            return null;
        }
    }
}
