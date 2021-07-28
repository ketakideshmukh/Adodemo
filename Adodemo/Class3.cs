using System;
using System.Data.SqlClient;//for .net framework , for web application - microsoft.data.sqlclient
using System.Data;


namespace Adodemo
{
    class Class3
    {
        static void Main(string[] args)
        {
            int id; string name;
            Console.WriteLine("delete from department");
            id = Convert.ToInt32(Console.ReadLine());
            name = Console.ReadLine();

            string constr = @"Data Source=DESKTOP-8PK1FTS;database=org3;Integrated Security=true;";
            using (SqlConnection con = new SqlConnection(constr))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("sp_dele", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);
                

                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                    Console.WriteLine("Deleted  Successfully");
                else
                    Console.WriteLine("deletion Failed");
                con.Close();
            }

        }
    }
}
