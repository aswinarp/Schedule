using ScheduleMicroService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScheduleMicroService.Services
{
    public interface IScheduleService
    {
        public ScheduleList Schedule();
    }
}
