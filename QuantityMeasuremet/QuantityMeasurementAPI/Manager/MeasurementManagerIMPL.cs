using System;
using System.Collections.Generic;
using System.Text;


namespace Manager
{
    public class MeasurementManagerIMPL
    {
        private readonly IRepository lengthRepository;

        public MeasurementManagerIMPL(IRepository lengthRepository)
        {
            this.lengthRepository = lengthRepository;
        }

        public double FeetToInche(double feet)
        {
            return lengthRepository.FeetToInche(feet);
        }

        public double IncheToFeet(double inch)
        {
            return lengthRepository.IncheToFeet(inch);
        }
    }
}
