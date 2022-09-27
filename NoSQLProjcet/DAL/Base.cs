using System;
using MongoDB.Driver;
namespace DAL
{
    public class Base
    {
        MongoClient dbMongo;
        public Base()
        {
            dbMongo = new MongoClient("mongodb+srv://admin:admin@cluster.70ubhms.mongodb.net/test");
        }
    }
}
