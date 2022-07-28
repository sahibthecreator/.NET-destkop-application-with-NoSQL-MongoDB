using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class User
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("firstName")]
        public string FirstName { get; set; }
        [BsonElement("lastName")]
        public string LastName { get; set; }

        [BsonElement("password")]
        public string Password { get; set; }

        [BsonElement("email")]
        public string Email { get; set; }

        [BsonElement("location")]
        public string Location { get; set; }

        [BsonElement("phone")]
        public string Phone { get; set; }

        [BsonElement("type")]
        public UserType Type { get; set; }
        public User(string firstName, string lastName, string location, string phone, string email, string type)
        {
            FirstName = firstName;
            LastName = lastName;
            Location = location;
            Phone = phone;  
            Email = email;
            Type = convertTypeToUserType(type);    
        }

        private UserType convertTypeToUserType(string type)
        {
            if (type == "Employee")
                return UserType.basic;
            return UserType.admin;
        }
    }
}
