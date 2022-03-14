using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace ConsoleApp1
{
    class Program61
    {
        static void Main(string[] args)
        {
            string cs = "server=G1-443HZH3-L\\SQLEXPRESS; integrated security=true; database=IncedoEmployeeDB";
            SqlConnection cn = new SqlConnection(cs);
            cn.Open();
            Console.Write("Enter id : ");
            int id = Convert.ToInt32(Console.ReadLine());

            string query = "Select * from tblEmployees where id=@id";
            SqlCommand cmd = new SqlCommand(query, cn);
            cmd.Parameters.AddWithValue("@id", id);

            SqlDataReader dr = cmd.ExecuteReader();

            if(dr.Read())
                Console.WriteLine($"{dr[0].ToString()} {dr[1].ToString()} {dr[2].ToString()} {dr[3].ToString()}");
            else
                Console.WriteLine($"{id} id not exist!");
        }
    }
}
