using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Manager;
using Microsoft.Extensions.Logging;
using Experimental.System.Messaging;
using Repository;
using QuantityMeasurementAPIProject.MSMQService;
using QuantityMeasurementAPIProject.RedisServices;
using Newtonsoft.Json;

namespace QuantityMeasurementAPIProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MeasurementController : ControllerBase
    {
        private readonly IMeasurementManager _manager;
        private readonly RedisService _redisService;

        Sender senderQueue = new Sender();

        public MeasurementController(IMeasurementManager manager, RedisService redisService)
        {
            this._manager = manager;
            this._redisService = redisService;
        }

        /// <summary>
        ///  // POST api/values
        /// </summary>
        /// <param name="id">id.</param>
        /// <returns>async Task.<IActionResult></returns>
        [Route("Convert")]
        [HttpPost]
        public async Task<IActionResult> Post(Data data)
        {
            double convertedData=-1;
            string key = JsonConvert.SerializeObject(data);
            var definitely = await _redisService.Get(key);
            if (definitely == null)
            {
                convertedData = this._manager.Convert(data);
            }
            else
            {
                return this.Ok(definitely);
            }
            if (convertedData >= 0)
            {
                senderQueue.SendMessage(data.valuetoconvert+data.inputtype+"="+convertedData+data.outputtype);
                await _redisService.Set(key, convertedData.ToString());
                return this.Ok(convertedData);
            }
            return this.NotFound("Employee record Not Found");
        }
    }
}
