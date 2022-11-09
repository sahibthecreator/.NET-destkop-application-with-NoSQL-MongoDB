using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class SortByPriority
    {
        public List<Incident> sortByHigh(List<Incident> incidents)
        {
            return incidents = incidents.OrderByDescending(i => i.Priority).ToList();
        }

        public void sortByLow(List<Incident> incidents)
        {
            incidents = incidents.OrderBy(i => i.Priority).ToList();

        }
    }
}
