using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class Fahrenhiet
    {
        double fahrenhiet = 0.0;

        public Fahrenhiet(double fahrenhiet)
        {
            this.fahrenhiet = fahrenhiet;
        }

        public double Convert(Celcius celciusObject)
        {
            return (this.fahrenhiet - 32) * 5 / 9;
        }
    }
}
