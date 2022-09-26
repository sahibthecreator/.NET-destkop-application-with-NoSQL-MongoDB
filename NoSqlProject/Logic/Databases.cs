using DAL;
using Model;
using System.Collections.Generic;

namespace Logic
{
    public class Databases
    {
        private Base dao;
        public Databases()
        {
            dao = new Base();
        }

        public List<Databases_Model> Get_All_Databases()
        {
            return dao.GetDatabases();
        }
    }
}
