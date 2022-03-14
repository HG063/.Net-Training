using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Data.SqlClient;
namespace ConsoleApp1
{
    class Program60
    {
        static void Main(string[] args)
        {
            string cs = "server=G1-443HZH3-L\\SQLEXPRESS; integrated security=true; database=IncedoEmployeeDB";
            SqlConnection cn = new SqlConnection(cs);
            cn.Open();

            string query = "Select * from tblEmployees";
            SqlCommand cmd = new SqlCommand(query, cn);

            SqlDataReader dr = cmd.ExecuteReader();

            while(dr.Read())
                Console.WriteLine($"{dr[0].ToString()} {dr[1].ToString()} {dr[2].ToString()} {dr[3].ToString()}");
        }
    }
}
