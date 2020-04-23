using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class Celcius
    {
        double celsius = 0.0;

        public Celcius(double celsius)
        {
            this.celsius = celsius;
        }

        public double Convert(Fahrenhiet fahrenhietObject)
        {
            return (this.celsius * 9 / 5) + 32; 
        }
    }
}
