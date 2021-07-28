using System;
using System.Data.SqlClient;//for .net framework , for web application - microsoft.data.sqlclient
using System.Data;
using Microsoft.Extensions.Configuration;

//install from nuget

//         Microsoft.Extensions.Configuration
//         Microsoft.Extensions.Configuration.FileExtensions
//         Microsoft.Extensions.Configuration.Json

namespace Adodemo
{
    class Class1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hii");
            Console.WriteLine("hello");
            Console.WriteLine("hello2");
            Console.WriteLine("master branch");
            //var builder = new ConfigurationBuilder()
            //                    .AddJsonFile("appsettings.json", optional: false);
            //var configuration = builder.Build();


            //string constr = configuration.GetConnectionString("DBCon");
            //string constr = @"Data Source=DESKTOP-8PK1FTS;database=org3;Integrated Security=true";//connection
            string constr = @"Data Source=DESKTOP-8PK1FTS;database=org3;Integrated Security=true";//connection
            
            SqlConnection con = new SqlConnection(constr);//connection
            con.Open();//open a connection//can skipped for dataset
            SqlCommand cmd = new SqlCommand("select * from department ;select * from location", con);//writing command
            SqlDataAdapter da = new SqlDataAdapter(cmd);//we get the data
            DataSet ds = new DataSet();
            da.Fill(ds);//method used by sqldataadapter to fill database into ds

            SqlCommandBuilder mySqlCommandBuilder = new SqlCommandBuilder(da);

            //Insert into DB
            //DataRow dr = ds.Tables[0].NewRow();
            //dr["departmentID"] = 111;
            //dr["deptname"] = "From code";
            //ds.Tables[0].Rows.Add(dr);

            //da.Update(ds);

            //update values in the DB

            //ds.Tables[0].Rows[0]["deptname"] = "dsupdate";
            //da.Update(ds);


            //   // To Delete the data in DB
            ds.Tables[0].Rows[5].Delete();
            da.Update(ds);


            foreach (DataRow row in ds.Tables[0].Rows)
            {
                Console.WriteLine(row["departmentid"] + ",  " + row["deptname"]);
            }


            //con.Close();//can skipped for dataset
            //Console.WriteLine("Department Table");
            //foreach (DataRow dr in ds.Tables[0].Rows)
            //{
            //    Console.WriteLine(dr[0] + " " + dr[1]);
            //}
            //Console.WriteLine("Location Table");
            //foreach (DataRow dr in ds.Tables[1].Rows)
            //{
            //    Console.WriteLine(dr[0] + " " + dr[1]);
            //}

        }
    }
}


/*-------------------------------------------------------------------------------------
 

[2:48 AM] sravya (Guest)
 static void Main()

        {​​​​

            string constr = @"Data Source=LAPTOP-070R2R4B\SQLEXPRESS;database=org3;Integrated Security=true";

            SqlConnection con = new SqlConnection(constr);

            SqlCommand cmd = new SqlCommand("select * from department ", con);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            DataSet ds = new DataSet();

            adapter.Fill(ds);

            //Console.WriteLine(ds.GetXml());

            SqlCommandBuilder mySqlCommandBuilder = new SqlCommandBuilder(adapter);         //Insert into DB

            DataRow dr = ds.Tables[0].NewRow();

            dr["departmentID"] = 111;

            dr["deptname"] = "From code";

            ds.Tables[0].Rows.Add(dr);             adapter.Update(ds); 

            //update values in the DB

        //    ds.Tables[0].Rows[0]["deptname"] = "dsupdate";

        //    adapter.Update(ds);         //   // To Delete the data in DB

        //     ds.Tables[0].Rows[8].Delete();

        //adapter.Update(ds);             foreach (DataRow row in ds.Tables[0].Rows)

            {​​​​

                Console.WriteLine(row["departmentid"] + ",  " + row["deptname"]);

            }​​​​     //foreach (DataRow row in ds.Tables[1].Rows)

    //{​​​​

    //    Console.WriteLine(row["empid"] + ",  " + row["name"]);

    //}​​​​     Console.ReadKey();

        }​​​​

[2:49 AM] sravya (Guest)
static void Main(string[] args)

        {​​​​

            var builder = new ConfigurationBuilder()

                                .AddJsonFile("AppSetting.json", optional: false);

            var configuration = builder.Build();

            string constr = configuration.GetConnectionString("DBCon");

            //string constr = @"Data Source=LAPTOP-070R2R4B\SQLEXPRESS;database=org3;Integrated Security=true";

            SqlConnection con = new SqlConnection(constr);

            con.Open();

            SqlCommand cmd = new SqlCommand("select * from department;select * from location",con);

            SqlDataReader dr=cmd.ExecuteReader();

            int count=dr.FieldCount;

            Console.WriteLine(dr.GetName(0)+" "+ dr.GetName(1));

            //while (dr.Read())

            //{​​​​

            //    Console.WriteLine(dr["departmentid"] + " " + dr[1]);            

            //}​​​​

            if (dr.NextResult())

            {​​​​

                while (dr.Read())

                {​​​​

                    Console.WriteLine(dr[0] + " " + dr[1]);

                }​​​​

            }​​​​

            con.Close();          }​​​​

*/
