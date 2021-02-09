using ScheduleMicroService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScheduleMicroService.Repository
{
    public interface IScheduleRepository
    {
        public ScheduleList Schedule();
    }
}
