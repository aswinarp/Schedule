using ScheduleMicroService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScheduleMicroService.Services
{
    public interface IAddDateService
    {
        public ScheduleList AddDateToList(ScheduleList scheduleList, string dateStr);
    }
}
