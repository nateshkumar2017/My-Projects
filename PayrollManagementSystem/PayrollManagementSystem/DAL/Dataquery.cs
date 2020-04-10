using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollManagementSystem.DAL
{
    class Dataquery
    {

            public  string getLogin (string user, string password)
            {
                string login = "select * from user1 where username = '" + user + "' and pass = '" + password + "'";

                return login;
    
            }

            public string getDepartments()
            {

                string query = "select Department_Name from departments";
                return query;
            }
            public string getDepartmentID(string dptname, int id)
            {

                string dpt = "select " + id + " from departments where Department_Name = '"+dptname+"'";
                return dpt;
            }
            public string getDestination()
            {

                string query = "select Destination_Name from Destination";
                return query;
            }
            public string getDestinationID(string dstname, int id)
            {

                string dst = "select " + id + " from departments where Department_Name = '" + dstname + "'";
                return dst;
            }
           
    }
}
