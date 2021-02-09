using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using ScheduleMicroService.Models;

namespace ScheduleMicroService.Repository
{
    public class ScheduleRepository:IScheduleRepository
    {
        readonly List<Doctor> doctors = new List<Doctor>();
        readonly RepresentativeList repList = new RepresentativeList();
        public ScheduleList Schedule()
        {
            doctors.Add(new Doctor { Name = "Obiwan Kenobi", Specialization = "Orthopaedics", Mobile = 8745421586 });
            doctors.Add(new Doctor { Name = "Luke Skywalker", Specialization = "General", Mobile = 8452175396 });
            doctors.Add(new Doctor { Name = "QuiGonn Jin", Specialization = "General", Mobile = 9964512785 });
            doctors.Add(new Doctor { Name = "Mace Windu", Specialization = "Orthopaedics", Mobile = 9968574589 });
            doctors.Add(new Doctor { Name = "Han Solo", Specialization = "Gynaecology", Mobile = 9988667732 });

            ScheduleList scheduleList = new ScheduleList();
            scheduleList.Schedules.Add(new Schedule { RepName = repList.representatives[0].RepName , DocName = doctors[0].Name , Ailment = doctors[0].Specialization , Time = "1 PM to 2 PM" , Mobile = doctors[0].Mobile }); 
            scheduleList.Schedules.Add(new Schedule { RepName = repList.representatives[1].RepName , DocName = doctors[1].Name , Ailment = doctors[1].Specialization , Time = "1 PM to 2 PM" , Mobile = doctors[1].Mobile }); 
            scheduleList.Schedules.Add(new Schedule { RepName = repList.representatives[2].RepName , DocName = doctors[2].Name , Ailment = doctors[2].Specialization , Time = "1 PM to 2 PM" , Mobile = doctors[2].Mobile });
            scheduleList.Schedules.Add(new Schedule { RepName = repList.representatives[0].RepName , DocName = doctors[3].Name , Ailment = doctors[3].Specialization , Time = "1 PM to 2 PM" , Mobile = doctors[3].Mobile }); 
            scheduleList.Schedules.Add(new Schedule { RepName = repList.representatives[1].RepName , DocName = doctors[4].Name , Ailment = doctors[4].Specialization , Time = "1 PM to 2 PM" , Mobile = doctors[4].Mobile }); 
            return scheduleList;            
        }
    }
}
