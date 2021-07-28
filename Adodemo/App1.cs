using System;
using System.Collections.Generic;
using System.Text;

namespace Adodemo
{
    abstract class Course
    {
        int id;
        string name;
        int duration;
        float fees;
        public Course()
        {

        }
        public Course(int id, string name, int duration, float fees)
        {
            this.id = id;
            this.name = name;
            this.duration = duration;
            this.fees = fees;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int Duration { get => duration; set => duration = value; }
        public float Fees { get => fees; set => fees = value; }

        public abstract void calculateMonthlyFee();
        //{
        //    fees = fees + fees * 18 / 100;
        //}
    }

    class DegreeCourse : Course
    {
        enum level { Bachelors, Masters };
        bool isPlacementAvailable;

        public DegreeCourse()
        {

        }
        public DegreeCourse(bool isPlacementAvailable, int id, string name, int duration, float fees): base(id,name,duration,fees)
        {
            this.isPlacementAvailable = isPlacementAvailable;
        }

        public bool IsPlacementAvailable { get => isPlacementAvailable; set => isPlacementAvailable = value; }

        public override void calculateMonthlyFee()
        {
            if(IsPlacementAvailable)
            {
                Fees = Fees + Fees * 10 / 100;
            }
            
        }
    }
    class DiplomaCourse : Course 
    {
        enum type { professional, academic };

        public DiplomaCourse()
        {

        }

        public DiplomaCourse(int id, string name, int duration, float fees) : base(id, name, duration, fees)
        {

        }

        public override void calculateMonthlyFee()
        {
            Console.WriteLine("Choose the course type: professional or academic");
            string t = Console.ReadLine();

            if (t == type.professional.ToString())
            {
                Fees = Fees + Fees * 10 / 100;
            }
            else if (t == type.academic.ToString())
            {
                Fees = Fees + Fees * 5 / 100;
            }
            else
            {
                Console.WriteLine("Invalid choice");
            }
        }
    }

   
    class CInfo
    {
        public void display(Course course)
        {
            //Code here to display the details of given course
            Console.WriteLine("Course ID : " + course.Id);
            Console.WriteLine("Name : " + course.Name);
            Console.WriteLine("Duration : " + course.Duration);
            course.calculateMonthlyFee();
            Console.WriteLine("Fees : " + course.Fees);
        }
    }

    class App1 
    {
        static void Main(string[] args)
        {
            CInfo info = new CInfo();
            //Course c = new Course(1, "Java", 3, 5000);
            //c.calculateMonthlyFee();
            //info.display(c);

            //DegreeCourse dc = new DegreeCourse(true,2,"Dotnet", 6, 6000);
            //dc.calculateMonthlyFee();
            //info.display(dc);

            DiplomaCourse di = new DiplomaCourse(3, "Python", 6, 7000);
            info.display(di);
            di.calculateMonthlyFee();


        }
    }

}
