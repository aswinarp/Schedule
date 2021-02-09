using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ScheduleMicroService.Repository;

namespace ScheduleMicroService.Services
{
    public class ValiDateService : IValiDateService
    {
        private IValiDateRepository _valiDateRepository;
        public ValiDateService(IValiDateRepository valiDateRepository)
        {
            _valiDateRepository = valiDateRepository;
        }
        public bool IsValidDate(string datestr)
        {
            return _valiDateRepository.IsValidDate(datestr);
        }
    }
}
