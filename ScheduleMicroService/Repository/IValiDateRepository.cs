using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScheduleMicroService.Repository
{
    public interface IValiDateRepository
    {
        public bool IsValidDate(string datestr);
    }
}
