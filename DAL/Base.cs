using MongoDB.Driver;
using System;

namespace DAL
{
    public class Base
    {
        MongoClient dbClient;

        public Base()
        {
            dbClient = new MongoClient("mongodb+srv://admin:admin@cluster.70ubhms.mongodb.net/test");
        }
    }
}