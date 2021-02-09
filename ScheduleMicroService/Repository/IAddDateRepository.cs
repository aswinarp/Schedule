using ScheduleMicroService.Models;
using System;

namespace ScheduleMicroService.Repository
{
    public interface IAddDateRepository
    {
        public ScheduleList AddDateToList(ScheduleList scheduleList, string dateStr);
    }
}
