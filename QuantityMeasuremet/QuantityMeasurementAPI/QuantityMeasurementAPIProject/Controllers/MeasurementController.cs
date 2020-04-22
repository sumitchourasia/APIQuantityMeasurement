using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Manager;


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

            [Route("api/InchToFeet")]
            [HttpGet]
            public async Task<IActionResult> GetFeet(double inch)
            {
                var result = this._manager.IncheToFeet(inch);
                if (result != 0.0)
                    return Ok(result);
                else
                return this.BadRequest();
            }

            [Route("api/FeetToInch")]
            [HttpGet]
            public async Task<IActionResult> GetInch(double feet)
            {
                var result = this._manager.FeetToInche(feet);
                if (result != 0.0)
                    return Ok(result);

                return this.BadRequest();
            }
        }
    }

}
}