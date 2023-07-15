using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ConsoleApp1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            try
            {

                string ConString = "data source=(localdb)\\MSSQLLocalDB; database=StudentDB; integrated security=SSPI";
                using (SqlConnection connection = new SqlConnection(ConString))
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "select * from student";
                    cmd.Connection = connection;
                    // Opening Connection  
                    connection.Open();
                    // Executing the SQL query  
                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        Console.WriteLine(sdr["Name"] + ",  " + sdr["Email"] + ",  " + sdr["Mobile"]);
                    }


                    //int id = 9; string name = "shvez"; string email = "shve@gmail"; int mobile = 56784;
                    //SqlCommand cmd = new SqlCommand();
                    //cmd.CommandText = $"INSERT INTO Student VALUES ({id}, '{name}', '{email}', '{mobile}')";
                    //cmd.Connection = connection;
                    //connection.Open();
                    //// Executing the SQL query  
                    //cmd.ExecuteNonQuery();
                    //Console.WriteLine("inserted successfully...");


                    //SqlCommand cmd = new SqlCommand($"DELETE from Student WHERE Id={9}", connection);
                    //connection.Open();
                    //cmd.ExecuteNonQuery();
                    //Console.WriteLine("Deleted sucessfully..");
                    //Console.WriteLine();



                    // SqlCommand cmd = new SqlCommand("UPDATE Student SET  Name='Anurag', Email='anu@gmail',Mobile='67478908' WHERE Id=9", connection);
                    //connection.Open();
                    //cmd.ExecuteNonQuery();
                    //Console.WriteLine("Updated sucessfully..");


                }
            }
            catch (Exception e)
            {
                Console.WriteLine("OOPs, something went wrong.\n" + e);
            }
            Console.ReadLine();
        }
    }
}
