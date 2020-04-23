using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Manager;
using Model;
using Microsoft.Extensions.Logging;

namespace QuantityMeasurementAPIProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MeasurementController : ControllerBase
    {
        private readonly IMeasurementManager _manager;

        public MeasurementController(IMeasurementManager manager)
        {
            this._manager = manager;
        }

        /// <summary>
        /// GET: api/Employee/5.
        /// </summary>
        /// <param name="id">id.</param>
        /// <returns>async Task.<IActionResult></returns>
        [Route("Convert")]
        [HttpPost]
        public async Task<IActionResult> GetConvertor(Data data)
        {
           // Logger.LogInformation("Get Employee based on id");
            double employee = this._manager.Convert(data);

            if (employee == 0)
                return this.NotFound("Employee record Not Found");

            return this.Ok(employee);
        }

       /* // GET api/values/5
        [Route("Convert")]
        [HttpGet]
        public double Get(Data data)
        {
            double convertedValue = this._manager.Convert(data);
            return convertedValue;
            //return this.Ok(convertedValue);
        }
*/
        /*/// <summary>
        /// GET api/values/5
        /// </summary>
        /// <param name="id">id.</param>
        /// <returns>async Task.<IActionResult></returns>
        [Route("Convert")]
        [HttpGet("{data}")]
        public ActionResult<string> Get(Data data)
        {
            // logger.LogInformation("Get Employee based on id"); 
            double convertedValue = this._manager.Convert(data);
            return this.Ok(convertedValue);
        }*/
    }
}
