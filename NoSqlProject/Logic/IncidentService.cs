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
        public void AddIncident(Incident incident)
        {
            incidentDAO.AddIncident(incident);
        }


        public List<Incident> GetTickets(User user, Status status)
        {
            return incidentDAO.GetTickets(user, status);
        }

        public List<Incident> GetAllUserTickets(User user)
        {
            return incidentDAO.GetAllUserTickets(user);
        }

        public void DeleteTicket(Incident incident)
        {
            incidentDAO.DeleteTicket(incident);
        }

        public void UpdateStatus(Incident incident, Status status)
        {
            incidentDAO.UpdateStatus(incident, status);
        }
        public void EditTicket(Incident incident)
        {
            incidentDAO.EditTicket(incident);
        }
        public void CreateTicket(Incident incident, TicketType type, Status status, Priority priority)
        {
            incidentDAO.CreateTicket(incident, type, status, priority);
        }
        public List<Incident> GetTicketsWithStatus( Status status)
        {
            return incidentDAO.GetTicketsWithStatus(status);
        }
        public List<Incident> GetTicketsPastDeadline(DateTime datetime)
        {
            return incidentDAO.GetTicketsPastDeadline(datetime);
        }
    }
}

