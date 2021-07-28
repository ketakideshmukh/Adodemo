using System;
using System.Data.SqlClient;//for .net framework , for web application - microsoft.data.sqlclient


namespace Adodemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string constr = @"Data Source=DESKTOP-8PK1FTS;database=org3;Integrated Security=true";//connection
            SqlConnection con = new SqlConnection(constr);//connection
            con.Open();//open a connection
            //SqlCommand cmd = new SqlCommand("select * from department ",con);//writing command
            //SqlDataReader dr = cmd.ExecuteReader();//we get the data
            //while(dr.Read())//will iterate till columns end
            //{
            //    Console.WriteLine(dr[0] + " " + dr[1]);//execute a command
            //}
            SqlCommand cmd = new SqlCommand("select * from employee ", con);//writing command
            SqlDataReader dr = cmd.ExecuteReader();//we get the data
            while (dr.Read())//will iterate till columns end
            {
                Console.WriteLine(dr.GetName(0) + " " + dr.GetName(1) + " " + dr.GetName(2));//columne name
                Console.WriteLine(dr[0] + " " + dr[1] + " " + dr[2]) ;//execute a command
            }

            con.Close();



            Console.WriteLine("Hello World!");
        }
    }
}

//indexers


/*class Employee
    {
        int empid;
       public string empname;
       public string designation;
       public float salary;
 
        public int Empid { get => empid; set => empid = value; }
 
        public Employee(int eid, string ename, string desig, float sal)
        {
            this.Empid = eid;
            this.empname = ename;
            this.designation = desig;
            this.salary = sal;
        }
 
        public object this[int index]
        {
            get
            {
                if (index == 0)
                {
                    return Empid;
                }
                else if (index == 1)
                {
                    return empname;
                }
                else if (index == 2)
                {
                    return designation;
 
                }
                else if (index == 3)
                {
                    return salary;
                }
                return null;
 
            }
            set
            {
                if (index == 0)
                    Empid = (int)value;
                else if (index == 1)
                    empname = (string)value;
                else if (index == 2)
                    designation = (string)value;
                else if (index == 3)
                    salary = (float)value;
            }
 

        }
 
        public object this[string name]
        {
            set
            {
                if (name.ToLower() == "empid")
                    Empid = (int)value;
                else if (name.ToLower() == "salary")
                    salary = (float)value;
            }
            get
            {
                if (name.ToLower() == "empid")
                {
                    return Empid;
                }
                else if (name.ToLower() == "empname")
                {
                    return empname;
                }
                else if (name.ToLower() == "designation")
                {
                    return designation;
 
                }
                else if (name.ToLower() == "salary")
                {
                    return salary;
                }
                return null;
 
            }
        }
    }
 
   
    class Program
    {
        static void Main(string[] args)
        {

            Employee emp = new Employee(1, "scott", "manager", 50000);
            emp.Empid = 20;
 

            emp[0] = 30;
            emp["empid"] = 50;
            Console.WriteLine(emp.Empid);
            Console.WriteLine(emp["Empid"]);
            Console.WriteLine("Employee ID :" + emp[0]);
            Console.WriteLine("Employee Name :" + emp[1]);
            Console.WriteLine("Employee designation :" + emp[2]);
            Console.WriteLine("Employee Salary :" + emp[3]);
            emp[0] = 4;
            emp[2] = "Sr.Manager";
            Console.WriteLine("Employee ID :" + emp["Empid"]);
            Console.WriteLine("Employee Name :" + emp["empName"]);
            Console.WriteLine("Employee designation :" + emp["designation"]);
            Console.WriteLine("Employee Salary :" + emp["salary"]);
            Console.ReadLine();

        }
    }*/

/*var h1 = 2;
            int? p=null;
            float? f = null;
            int h = 10;
            int? age = 30;

            object o = null;
            //?? - null coalescing operator
            p= age ?? h;
 
            Console.WriteLine(p);    
 
            Console.WriteLine(age); */

/*class Class2
    {
 
        static int Add(int x,  int y)
        {
            return x + y;
 
        }
        static int Add2(int x,[Optional] int y)
        {
            return x + y;

        }
        static int Add1(int x, int h=30,int y=20) //optional parameters
        {
            return x + y + h;
 
        }
        static void Main()
        {
            Console.WriteLine(Add2(3));//Optional Parameter
            Console.WriteLine(Add(y:5, x:4));    //Named Parameters  
            Console.WriteLine(Add1(4));//optional parameters
        }
    }*/


/*class Class2
    {
 
        static int Add(int x,  int y)
        {
            return x + y;
 
        }
        static int Add2(int x,[Optional] int y)
        {
            return x + y;

        }
        static int? Add1(int? x, int? h=30,int? y=20) //optional parameters
        {
            return x + y + h;
 
        }
 
        static int AddNumbers(params int[] num)
        {
            int sum = 0;
            foreach (int x in num)
            {
                sum += x;

            }
            return sum;
        }
        static void Main()
        {
            Console.WriteLine(AddNumbers(1, 2, 3));
            Console.WriteLine(AddNumbers(1, 2, 3,4,5,6));
            Console.WriteLine(Add2(3));//Optional Parameter
            Console.WriteLine(Add(y:5, x:4));    //Named Parameters  
            Console.WriteLine(Add1(4,3,4));//optional parameters
            Console.WriteLine(Add1(4));//optional parameters
            Console.WriteLine(Add1(12,2,3));
        }
    }*/