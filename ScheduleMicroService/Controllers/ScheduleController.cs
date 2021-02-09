using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ScheduleMicroService.Repository;
using ScheduleMicroService.Services;
using ScheduleMicroService.Models;
using Microsoft.Extensions.Configuration;

namespace ScheduleMicroService.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class ScheduleController : ControllerBase
    {
        private readonly IConfiguration _config;
        private readonly IAddDateService _addDateService;
        private readonly IAddMedicineService _addMedicineService;
        private readonly ICommunicationService _communicationService;
        private readonly IScheduleService _scheduleService;
        private readonly IValiDateService _valiDateService;
        public ScheduleController(IConfiguration config, IScheduleService scheduleService, IAddDateService addDateService, IAddMedicineService addMedicineService, ICommunicationService communicationService, IValiDateService valiDateService)
        {
            _config = config;
            _scheduleService = scheduleService;
            _communicationService = communicationService;
            _addDateService = addDateService;
            _addMedicineService = addMedicineService;
            _valiDateService = valiDateService;
        }

        [Authorize]
        [HttpGet("Create")]
        public IActionResult CreateSchedule(string datestr)
        {
            if (_valiDateService.IsValidDate(datestr))
                return Ok((_addDateService.AddDateToList(_addMedicineService.AddMedicineList(_communicationService.GetMedicineList(_config), _scheduleService.Schedule()), datestr)).Schedules);
            return StatusCode(405);            
        }

        [AllowAnonymous]
        [HttpGet("Run")]
        public ActionResult<string> Get()
        {
            return "The Schedule Creation MicroService API is Running";
        }
    }
}
