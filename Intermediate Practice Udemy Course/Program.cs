using System;

namespace Intermediate_Practice_Udemy_Course
{
    public class Person
    {
        public string Name;
        public void Introduce(string to)
        {
            Console.WriteLine("Hi {0}, I am {1}", to, Name);
        }

        public static Person Parse(string str)
        {
            var person = new Person();
            person.Name = str;
            return person;
        }
    }
    class Program
    {
        static void UsePoints()
        {
            try
            {
                var point = new Point(10, 20);
                point.Move(null);
                point.Move(100, 200);
            }
            catch (Exception)
            {
                Console.WriteLine("crashed");
            }
        }
        static void Main(string[] args)
        {
     
            var customer = new Customer(1);
            // object initialization 
            var person = Person.Parse("Greg");
            person.Introduce("Bill");

            var stopWatch = new StopwatchExercise();
            stopWatch.Start();
            stopWatch.Stop();
            stopWatch.Start();
            stopWatch.Stop();
        }
    }
}
