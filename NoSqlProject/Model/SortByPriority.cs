using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class SortByPriority
    {
        public List<Incident> SortByHigh(List<Incident> incidents)
        {
            return incidents = incidents.OrderByDescending(i => i.Priority).ToList();
        }

        public List<Incident> SortByLow(List<Incident> incidents)
        {
           return incidents = incidents.OrderBy(i => i.Priority).ToList();

        }
    }
}
