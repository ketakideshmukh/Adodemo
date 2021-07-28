using System;
using System.Data.SqlClient;//for .net framework , for web application - microsoft.data.sqlclient
using System.Data;

namespace Adodemo
{
    class Class2
    {
        static void Main(string[] args) 
        {
            int id; string name;
            Console.WriteLine("Enter the department id and name");
            id = Convert.ToInt32(Console.ReadLine());
            name = Console.ReadLine();

            string constr = @"Data Source=DESKTOP-8PK1FTS;database=org3;Integrated Security=true;";
            using (SqlConnection con = new SqlConnection(constr))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into department values(" + id + ",'" + name + "')", con);
                cmd.CommandType = CommandType.Text;
                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                    Console.WriteLine("Inserted Successfully");
                else
                    Console.WriteLine("Inserted Failed");
                con.Close();
            }

        }
    }
}
