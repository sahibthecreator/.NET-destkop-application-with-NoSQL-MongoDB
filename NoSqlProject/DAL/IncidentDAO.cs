using Model;
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
            return collectionIncident.Find(i => i.Reporter == user.Id && i.Status == (int)status).ToList<Incident>();
        }
        public List<Incident> GetAllUserTickets(User user)
        {
            return collectionIncident.Find(i => i.Reporter == user.Id).ToList<Incident>();

        }
    }
}
