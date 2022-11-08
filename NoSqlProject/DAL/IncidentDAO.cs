using Model;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class IncidentDAO : DAO
    {
        IMongoCollection<Incident> collectionIncident;
        public IncidentDAO()
        {
            collectionIncident = Db.GetCollection<Incident>("Incidents");
        }
         
        public List<Incident> GetAllIncidents()
        {
            return collectionIncident.AsQueryable().ToList<Incident>();
        }
        public void addIncident(Incident incident)
        {
            collectionIncident.InsertOne(incident);
        }

        public void deleteTicket(Incident incident)
        {
            collectionIncident.DeleteOne(x => x.Id == incident.Id);
        }

        public void closeTicket(Incident incident)
        {
            incident.Status = TicketStatus.closed;
            collectionIncident.ReplaceOne(x => x.Id == incident.Id, incident);
        }

        public void resolveTicket(Incident incident)
        {
            incident.Status = TicketStatus.resolved;
            collectionIncident.ReplaceOne(x => x.Id == incident.Id, incident);
        }

        public void editTicket(Incident incident)
        {

        }
    }
}
