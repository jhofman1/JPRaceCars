using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TECH497_Final_Group_Project.Database
{
    public class DatabaseFactory
    {
        IDatabase GetDatabase()
        {
            return new SillyDatabase();
        }
    }
}