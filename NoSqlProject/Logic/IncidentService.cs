using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace Logic
{
    public class IncidentService
    {
        IncidentDAO incidentDAO;
        public IncidentService()
        {
            incidentDAO = new IncidentDAO();
        }
    }
}
