using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class FilteringList
    {
        public List<Incident> FilterIncidentByStatus(List<Incident> incidents, Status? status)
        {
            List<Incident> result = new List<Incident>();
            foreach (Incident incident in incidents)
            {
                if (incident.Status == status)
                    result.Add(incident);
            }
            return result;
        }
    }
}
