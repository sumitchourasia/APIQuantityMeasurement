using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    interface IRepository
    {
        double FeetToInche(double feet);

        double IncheToFeet(double inch);
    }
}
