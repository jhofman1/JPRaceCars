using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TECH497_Final_Group_Project.Database
{
    public class DatabaseFactory
    {
        static DatabaseFactory()
        {
            _instance = new Database();
        }
        private static IDatabase _instance;
        public static IDatabase GetDatabase()
        {
            return _instance;
        }
    }
}