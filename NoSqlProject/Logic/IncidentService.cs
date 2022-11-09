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


        public List<Incident> GetTickets(User user, Status status)
        {
            return incidentDAO.GetTickets(user, status);
        }

        public List<Incident> GetAllUserTickets(User user)
        {
            return incidentDAO.GetAllUserTickets(user);
        }

        public void deleteTicket(Incident incident)
        {
            incidentDAO.deleteTicket(incident);
        }

        public void updateStatus(Incident incident, Status status)
        {
            incidentDAO.updateStatus(incident, status);
        }
        public void CreateTicket(Incident incident, string type, Status status, Priority priority)
        {
            incidentDAO.CreateTicket(incident,  type,  status,  priority);
        }
    }
}
