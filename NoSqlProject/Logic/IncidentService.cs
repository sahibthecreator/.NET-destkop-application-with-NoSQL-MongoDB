using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class IncidentService
    {
        IncidentDAO incidentDAO;
        public IncidentService()
        {
            incidentDAO = new IncidentDAO();
        }

       public List<Incident> GetAllIncidents()
        {
            return incidentDAO.GetAllIncidents();
        }
        public void addIncident(Incident incident)
        {
            incidentDAO.addIncident(incident);
        }

        public void deleteTicket(Incident incident)
        {
            incidentDAO.deleteTicket(incident);
        }

        public void closeTicket(Incident incident)
        {
            incidentDAO.closeTicket(incident);
        }
    }
}
