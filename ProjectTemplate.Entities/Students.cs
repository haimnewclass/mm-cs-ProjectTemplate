using ProjectTemplate.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Mail;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTemplate.Entities
{
    public class Students
    {
        private Student[] list = new Student[10];

        public void AddNewStudent(string name,int age)
        {
            /*Student newStudent = new Student();
            newStudent.Name = name;
            newStudent.Age = age;
            */

         
            Student newStudent = new Student() { Age= age, Name = name };

        }

        void func4(SqlDataReader reader)
        {
            // sdfsdf
             
        }

        void funcRead(SqlDataReader reader)
        {
            while (reader.Read())
            {
                int colIdx = reader.GetOrdinal("CustomerName");
                string name = reader.GetString(colIdx);

            }
        }
        public int CalcMilga()
        {
            try
            {
                DAL.SqlQuery.RunCommand("select * from Customers", funcRead);
            }
            catch(Exception ex)
            {

            }
            return 0;
        }

    }
}
