using Microsoft.Extensions.Configuration;
using ScheduleMicroService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScheduleMicroService.Repository
{
    public interface IAddMedicineRepository
    {
        public ScheduleList AddMedicineList(List<Medicine> medicines,ScheduleList scheduleList);
    }
}
