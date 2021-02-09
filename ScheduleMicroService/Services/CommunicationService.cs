using Microsoft.Extensions.Configuration;
using ScheduleMicroService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ScheduleMicroService.Repository;

namespace ScheduleMicroService.Services
{
    public class CommunicationService : ICommunicationService
    {
        private readonly ICommunicationRepository _communicationRepository;
        public CommunicationService(ICommunicationRepository communicationRepository)
        {
            _communicationRepository = communicationRepository;
        }
        public List<Medicine> GetMedicineList(IConfiguration _config)
        {
            return _communicationRepository.GetMedicineList(_config);
        }
    }
}
