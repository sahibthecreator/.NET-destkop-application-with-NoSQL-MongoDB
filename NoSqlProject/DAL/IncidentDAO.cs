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

        public List<Incident> GetTickets(User user, Status status)
        {
            return collectionIncident.Find(i => i.Reporter == user.Id && i.Status == status).ToList<Incident>();
        }

        public List<Incident> GetAllUserTickets(User user)
        {
            return collectionIncident.Find(i => i.Reporter == user.Id).ToList<Incident>();
        }

        public void deleteTicket(Incident incident)
        {
            collectionIncident.DeleteOne(x => x.Id == incident.Id);
        }

        public void closeTicket(Incident incident)
        {
            incident.Status = Status.closed;
            collectionIncident.ReplaceOne(x => x.Id == incident.Id, incident);
        }

        public void resolveTicket(Incident incident)
        {
            incident.Status = Status.resolved;
            collectionIncident.ReplaceOne(x => x.Id == incident.Id, incident);
        }

        public void editTicket(Incident incident)
        {

        }

    }
}
