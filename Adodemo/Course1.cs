//using System;
//using System.Collections.Generic;


//namespace Adodemo
//{
//    class course1 
//    {


//        int id;
//        string name;
//        string duration;
//        int fees;

//        public course1(int id, string name, string duration, int fees)
//        {
//            this.id = id;
//            this.name = name;
//            this.duration = duration;
//            this.fees = fees;
//        }

//        public int Id { get => id; set => id = value; }
//        public string Name { get => name; set => name = value; }
//        public string Duration { get => duration; set => duration = value; }
//        public int Fees { get => fees; set => fees = value; }


//    }
//    class CInfo
//    {
//        public void display(course1 course) 
//        { 
//        //Code here to display the details of given course
//            Console.WriteLine("Course ID : " + course.Id);
//            Console.WriteLine("Name : " + course.Name);
//            Console.WriteLine("Duration : " + course.Duration);
//            Console.WriteLine("Fees : " + course.Fees);
//        }
//    }

//    class Course
//    {

//        static void Main(string[] args)
//        {
//            //Scenario1();
//            //Scenario2();
//            //Scenario3();
//            //Scenario4();

//        }
//        static void Scenario1()
//        {

//            course1 c1 = new course1(1, "course1", "1 year", 20000);
//            course1 c2 = new course1(2, "course2", "1 year", 20000);
//            course1 c3 = new course1(3, "course3", "1 year", 20000);


//            CInfo info = new CInfo();
//            info.display(c1);
//            info.display(c2);
//            info.display(c3);

//        }
//        static void Scenario2()
//        {
//            course1[] cou = new course1[3];
//            course1 c1 = new course1(1, "Course1", "1 year", 20000 );
//            cou[0] = c1;
//            course1 c2 = new course1(2, "Course2", "1 year", 20000);
//            cou[1] = c2;
//            course1 c3 = new course1(3, "Course3", "1 year", 20000);
//            cou[2] = c3;

//            CInfo info = new CInfo();
//            foreach (course1 a in cou)
//            {
//                info.display(a);
//            }
//        }

//        static void Scenario3()
//        {
//            Console.WriteLine("Enter the Number of courses");
//            int count = int.Parse(Console.ReadLine());
//            int id; string name; string duration; int fees;
//            course1[] co = new course1[count];

//            for (int i = 0; i < count; i++)
//            {
//                Console.WriteLine("Enter course id,name,duration and fees");
//                id = int.Parse(Console.ReadLine());
//                name = Console.ReadLine();
//                duration = Console.ReadLine();
//                fees = int.Parse(Console.ReadLine());

//                co[i] = new course1(id, name, duration, fees);
//            }
//            CInfo info = new CInfo();
//            foreach (course1 cou in co)
//            {
//                info.display(cou); 
//            }


//        }

//        static void Scenario4()
//        {
//            Console.WriteLine("Enter the Number of courses");
//            int count = int.Parse(Console.ReadLine());
//            int id; string name; string duration; int fees;
//            List<course1> co = new List<course1>(); 

//            for (int i = 0; i < count; i++)
//            {
//                Console.WriteLine("Enter student id,name,duration,fees");
//                id = int.Parse(Console.ReadLine());
//                name = Console.ReadLine();
//                duration = Console.ReadLine();
//                fees = int.Parse(Console.ReadLine());

//                co.Add(new course1(id, name, duration, fees));
//            }
//            CInfo info = new CInfo();
//            foreach (course1 cou in co)
//            {
//                info.display(cou);
//            }


//        }






//    }

//}
