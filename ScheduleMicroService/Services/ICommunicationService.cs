using Microsoft.Extensions.Configuration;
using ScheduleMicroService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScheduleMicroService.Services
{
    public interface ICommunicationService
    {
        public List<Medicine> GetMedicineList(IConfiguration _config);
    }
}
