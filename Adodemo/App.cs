using System;
using System.Collections.Generic;

namespace Adodemo 
{
    class course
    {
        int id;
        string name;
        DateTime dob;
        static string collegename;
        string[] phone;
        public course()
        {

        }

        public course(int id, string name, DateTime dob, string[] phone)
        {
            this.id = id;
            this.name = name;
            this.dob = dob;
            this.phone = phone;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public DateTime Dob { get => dob; set => dob = value; }
        public static string Collegename { get => collegename; set => collegename = value; }
        public string[] Phone { get => phone; set => phone = value; }
    }



        class Info
        {

            public void display(course student)
            { 
                Console.WriteLine("Student Id: " + student.Id);
                Console.WriteLine("Name: " + student.Name);
                Console.WriteLine("Date of Birth: " + student.Dob);
                Console.WriteLine("College Name: " + course.Collegename);
                foreach (string a in student.Phone)
                {
                    Console.WriteLine("Phone Number: " + a);
                }

            }
        }

        class App 
        {

            static void Main(string[] args)
            {
            //Scenario1();
            //Scenario2();
            //Scenario3();
            Scenario4();

            }
            static void Scenario1()
                {

                    course s1 = new course(1, "Mary", DateTime.Parse("2000-03-04"), new string[] { "1234", "3456" });
                    course s2 = new course(2, "Mary1", DateTime.Parse("2000-03-04"), new string[] { "3456" });
                    course s3 = new course(3, "Mary2", DateTime.Parse("2000-03-04"), new string[] { "1234", "3456", "4567" });

                    Info info = new Info();
                    info.display(s1);
                    info.display(s2);
                    info.display(s3);

                }
            static void Scenario2()
            {
                course[] stud = new course[3];
                course s1 = new course(1, "Mary", DateTime.Parse("2000-03-04"), new string[] { "1234", "3456" });
                stud[0] = s1;
                course s2 = new course(2, "Mary1", DateTime.Parse("2000-03-04"), new string[] { "3456" });
                stud[1] = s2;
                course s3 = new course(3, "Mary2", DateTime.Parse("2000-03-04"), new string[] { "1234", "3456", "4567" });
                stud[2] = s3;

                Info info = new Info();
                foreach (course a in stud)
                {
                    info.display(a);
                }
            }

            static void Scenario3()
            {
                Console.WriteLine("Enter the Number of students");
                int count = int.Parse(Console.ReadLine());
                int id; string name; DateTime dob; string[] phone;
                course[] students = new course[count];

                for (int i = 0; i < count; i++)
                {
                    Console.WriteLine("Enter student id,name,DOB");
                    id = int.Parse(Console.ReadLine());
                    name = Console.ReadLine();
                    dob = DateTime.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the number of phone numbers");
                    int count1 = int.Parse(Console.ReadLine());
                    phone = new string[count1];
                    for (int j = 0; j < count1; j++)
                    {
                        phone[j] = Console.ReadLine();

                    }
                    students[i] = new course(id, name, dob, phone);
                }
                Info info = new Info();
                foreach (course stud in students)
                {
                    info.display(stud);
                }


            }

        static void Scenario4()
        {
            Console.WriteLine("Enter the Number of students");
            int count = int.Parse(Console.ReadLine());
            int id; string name; DateTime dob; string[] phone;
            List<course> students = new List<course>();

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Enter student id,name,DOB");
                id = int.Parse(Console.ReadLine());
                name = Console.ReadLine();
                dob = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Enter the number of phone numbers");
                int count1 = int.Parse(Console.ReadLine());
                phone = new string[count1];
                for (int j = 0; j < count1; j++)
                {
                    phone[j] = Console.ReadLine();

                }
                students.Add(new course(id, name, dob, phone));
            }
            Info info = new Info();
            foreach (course stud in students)
            {
                info.display(stud);
            }


        }






    }

}


