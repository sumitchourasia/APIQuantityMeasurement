using Model;
using System;
using System.Collections.Generic;
using System.Text;
using Repository;
using Model.LengthModel;

namespace Manager
{
    public class MeasurementManagerIMPL : IMeasurementManager
    {
        private readonly IRepository _Repository;

        public MeasurementManagerIMPL( IRepository repository )
        {
            this._Repository = repository;
        }

        public double Convert(Data data)
        {
            return this._Repository.Convert(data);
        }
    }
}
