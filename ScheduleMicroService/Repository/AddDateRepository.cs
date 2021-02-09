using System;
using ScheduleMicroService.Models;

namespace ScheduleMicroService.Repository
{
    public class AddDateRepository:IAddDateRepository
    {
        public ScheduleList AddDateToList(ScheduleList scheduleList,string dateStr)
        {
            DateTime startdate = DateTime.Parse(dateStr);
            foreach (Schedule schedule in scheduleList.Schedules)
            {
                if (startdate.DayOfWeek == DayOfWeek.Sunday)
                {
                    startdate = startdate.AddDays(1);
                    schedule.Date = startdate;
                    startdate = startdate.AddDays(1);
                }
                else
                {
                    schedule.Date = startdate;
                    startdate = startdate.AddDays(1);
                }               
            }
            return scheduleList;
        }
    }
}
