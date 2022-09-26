using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Model
{
    public class User
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        [BsonElement("Plant")]
        public string PlantName { get; set; }
        [BsonElement("Temperature")]
        public string Temp { get; set; }

        [BsonElement("humidity")]
        public string Humidity { get; set; }

        [BsonElement("CO2")]
        public string C02 { get; set; }

        [BsonElement("CherryTomatoes")]
        public string CherryTomatoes { get; set; }
    }
}
