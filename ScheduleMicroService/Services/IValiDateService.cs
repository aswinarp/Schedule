using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScheduleMicroService.Services
{
    public interface IValiDateService
    {
        public bool IsValidDate(string datestr);
    }
}
