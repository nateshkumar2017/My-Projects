using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollManagementSystem.DAL
{
    class EmployeeData
    {
        public string insertEmployee(string id, string firstname, string lastname, char gender, string email, string contact, string dateofjoin, string designation,string Address, string dateofbirth, string qualification)
        {
            string query = "insert into Employees (Employee_ID,First_Name,Last_Name,Gender,Email,Contact,Date_Of_Join,Designation,Address,DOB,Qualification) values (\'" + Convert.ToInt32(id) + "\',\'" + firstname + "\',\'" + lastname + "\',\'" + gender + "\',\'" + email + "\',\'" + contact + "\',\'" + Convert.ToDateTime(dateofjoin) + "\',\'" + designation +"\',\'" + Address + "\',\'" + Convert.ToDateTime(dateofbirth) + "\',\'" + qualification + "\');";

            return query;

        }

            public string getAllEmployees()
            {
                string query = "select * from Employees";
                return query;
            }
            public string getEmployeByid(int id)
            {
                string query = "select * from Employees where Employee_id = "+id;
                return query;
            }
            public string getEmloyeeByName(string name)
            {
                string query= "select * from Employees where First_Name= '"+name+"' ";
                return query;
            }
        public string updateEmployee(string employeeid,string Fname,string LName,string email,string contact,string designation,string address,string qualification)
        {

             string  query=   "update Employees set First_Name = '"+ Fname+"',Last_Name = '"+LName+"' ,Email = '"+email+"',Contact = '"+contact+"',Designation = '"+designation+"',Address = '"+address+"',Qualification = '"+qualification+"' where Employee_id= "+Convert.ToInt32(employeeid);
        

            return query;
        
        }
       
    }
}
