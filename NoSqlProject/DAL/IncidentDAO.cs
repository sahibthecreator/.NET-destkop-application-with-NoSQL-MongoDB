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

        public void deleteTicket(Incident incident)
        {
            collectionIncident.DeleteOne(x => x.Id == incident.Id);
        }

        public void closeTicket(Incident incident)
        {
            //collectionIncident.UpdateOne(x => x.Id == incident.Id);
        }

        public void editTicket(Incident incident)
        {

        }
    }
}
