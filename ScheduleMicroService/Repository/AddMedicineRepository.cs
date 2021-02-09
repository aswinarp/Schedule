using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using ScheduleMicroService.Models;

namespace ScheduleMicroService.Repository
{
    public class AddMedicineRepository:IAddMedicineRepository
    {
        //private readonly CommunicationRepository communication = new CommunicationRepository();
        public ScheduleList AddMedicineList(List<Medicine> medicines, ScheduleList scheduleList)
        {
            List<string> tempList = new List<string>(); //To copy list so clearing wont affect it
            //List<Medicine> medicineList = communication.GetMedicineList(_config);

            foreach (Schedule schedule in scheduleList.Schedules)
            {
                foreach(Medicine medicine in medicines)
                {
                    if (medicine.TargetAilment == schedule.Ailment)
                        tempList.Add(medicine.Name);                                        
                }
                string strToList = string.Join(",", tempList.ToArray()); // Makes string and rejoins as list to avoid reference
                schedule.Medicine = strToList.Split(',').ToList();
                tempList.Clear();
            }
            return scheduleList;
        }
    }
}
