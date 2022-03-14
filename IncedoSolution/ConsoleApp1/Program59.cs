using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Data.SqlClient;

namespace ConsoleApp1
{
    class Program59
    {
        static void Main(string[] args)
        {
            try
            {
                string cs = "server=G1-443HZH3-L\\SQLEXPRESS; integrated security=true; database=IncedoEmployeeDB";
                SqlConnection cn = new SqlConnection(cs);
                cn.Open();
                Console.WriteLine("Connection established successfully...");
            }
            catch(SqlException ex)
            {
                Console.WriteLine("DB Connection Error : " + ex.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error : "+ ex.Message);
            }
        }
    }
}
