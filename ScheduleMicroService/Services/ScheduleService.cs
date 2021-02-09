using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ScheduleMicroService.Models;
using ScheduleMicroService.Repository;

namespace ScheduleMicroService.Services
{
    public class ScheduleService:IScheduleService
    {
        private readonly IScheduleRepository _scheduleRepository;
        public ScheduleService(IScheduleRepository scheduleRepository)
        {
            _scheduleRepository = scheduleRepository;
        }
        public ScheduleList Schedule()
        {
            return _scheduleRepository.Schedule();
        }
    }
}
