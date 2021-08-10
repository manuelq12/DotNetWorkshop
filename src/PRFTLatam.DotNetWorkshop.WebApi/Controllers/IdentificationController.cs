using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PRFTLatam.DotNetWorkshop.Services.Logic;

namespace PRFTLatam.DotNetWorkshop.WebApi.Controllers
{
    [ApiController]
    [Route("api/identification")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public class IdentificationController : ControllerBase
    {
        private readonly ILogger<HealthCheckController> _logger;

        private ValidationService validationService;

        public IdentificationController(ILogger<HealthCheckController> logger){
            _logger = logger;
            validationService = new ValidationService();
        }

        [HttpGet("{id}")]
        public  ActionResult GetIdentificationValidated(string id){
            _logger.LogInformation("{0} - Validation Executed",DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
            validationService.SetIdentification(id);
            List<String> errors = validationService.ValidateIdentification();

            if(errors.Count != 0){
                return UnprocessableEntity(errors);
            }
            return Ok();
        }
    }
}