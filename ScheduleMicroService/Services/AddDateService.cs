using ScheduleMicroService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ScheduleMicroService.Repository;

namespace ScheduleMicroService.Services
{
    public class AddDateService:IAddDateService
    {
        private readonly IAddDateRepository _addDateRepository;
        public AddDateService(IAddDateRepository addDateRepository)
        {
            _addDateRepository = addDateRepository; 
        }
        public ScheduleList AddDateToList(ScheduleList scheduleList, string dateStr)
        {
            return _addDateRepository.AddDateToList(scheduleList, dateStr);
        }
    }
}
