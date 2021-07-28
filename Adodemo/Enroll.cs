using System;
using System.Collections.Generic;
using System.Text;

namespace Adodemo
{
    class Enroll
    {

        private course student;
        private Course course;
        private DateTime enrollmentDate;

        public Enroll(course student, Course course, DateTime enrollmentDate)
        {
            this.student = student;
            this.course = course;
            this.enrollmentDate = enrollmentDate;
        }

        public DateTime EnrollmentDate { get => enrollmentDate; set => enrollmentDate = value; }
        internal course Student { get => student; set => student = value; }
        internal Course Course { get => course; set => course = value; }

        //constructors & getters/setters

    }

    interface AppEngine
    {
        public void introduce(Course course);
        public void register(course student);
        public List<course> listOfStudents();
        public void enroll(course student, Course course);
        public List<Enroll> listOfEnrollments();
    }
    class InMemoryAppEngine : AppEngine
    {
        public List<course> students;
        public List<Course> courses;
        public List<Enroll> Enrolls;

        public void enroll(course student, Course course)
        {
            Enroll enroll = new Enroll(student, course, DateTime.Now);
            Enrolls.Add(enroll);
        }

        public void introduce(Course course)
        {
            courses.Add(course);
        }

        public List<Enroll> listOfEnrollments()
        {
            return Enrolls;
        }

        public List<course> listOfStudents()
        {
            return students;
        }

        public void register(course student)
        {
            students.Add(student);
        }
    }
}