using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Manager;
using QuantityUnits;
using Microsoft.Extensions.Logging;
using Experimental.System.Messaging;
using QuantityMeasurementAPIProject.MSMQService;

namespace QuantityMeasurementAPIProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MeasurementController : ControllerBase
    {
        private readonly IMeasurementManager _manager;

        Sender senderQueue = new Sender();

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
            double convertedData = this._manager.Convert(data);

            if (convertedData >= 0)
            {
                senderQueue.SendMessage(data.valuetoconvert+data.inputtype+"="+convertedData+data.outputtype);
                return this.Ok(convertedData);
            }
            return this.NotFound("Employee record Not Found");
        }
    }
}
