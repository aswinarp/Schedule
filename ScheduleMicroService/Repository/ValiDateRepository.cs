using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScheduleMicroService.Repository
{
    public class ValiDateRepository : IValiDateRepository
    {
        public bool IsValidDate(string datestr)
        {
            if (DateTime.Parse(datestr) <= DateTime.Now.Date)
                return false;
            return true;
        }
    }
}
