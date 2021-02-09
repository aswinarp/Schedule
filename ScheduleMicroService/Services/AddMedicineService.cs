using ScheduleMicroService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ScheduleMicroService.Repository;
using Microsoft.Extensions.Configuration;

namespace ScheduleMicroService.Services
{
    public class AddMedicineService: IAddMedicineService
    {
        private readonly IAddMedicineRepository _addMedicineRepository;
        public AddMedicineService(IAddMedicineRepository addMedicineRepository)
        {
            _addMedicineRepository = addMedicineRepository; 
        }
        public ScheduleList AddMedicineList(List<Medicine> medicines,ScheduleList scheduleList)
        {
            return _addMedicineRepository.AddMedicineList(medicines,scheduleList);
        }
    }
}
