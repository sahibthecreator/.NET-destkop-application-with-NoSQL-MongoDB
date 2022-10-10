using MongoDB.Driver;
using MongoDB.Driver.Core.Authentication;
using System;
using Model;

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