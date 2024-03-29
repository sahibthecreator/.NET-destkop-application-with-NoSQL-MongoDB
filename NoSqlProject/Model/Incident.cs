﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace Model
{
    public class Incident
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("date")]
        public DateTime Date { get; set; }
        [BsonElement("subject")]
        public string Subject { get; set; }

        [BsonElement("type")]
        public TicketType Type { get; set; }

        [BsonElement("reporter_id")]
        public string Reporter { get; set; }

        [BsonElement("deadline")]
        public DateTime Deadline { get; set; }

        [BsonElement("description")]
        public string Description { get; set; }

        [BsonElement("status")]
        public Status Status { get; set; }

        [BsonElement("priority")]
        public Priority Priority { get; set; }
        public Incident(DateTime date, string subject, TicketType type, string reporter, DateTime deadline, string description, Status status)
        {
            Date = date;
            Subject = subject;
            Type = type;
            Reporter = reporter;
            Deadline = deadline;
            Description = description;
            Status = status;
            Priority = Priority.none;
        }
    }
}
