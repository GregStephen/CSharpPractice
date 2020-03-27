using System;
using System.Collections;
using System.Collections.Generic;

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


            ////// Exercises //////
            var stopWatch = new StopwatchExercise();
            stopWatch.Start();
            stopWatch.Stop();
            stopWatch.Start();
            stopWatch.Stop();

            var stackPost = new StackPostExercise("Hello World", "This is about saying Hello to the World");
            stackPost.Upvote();
            stackPost.Upvote();
            stackPost.Downvote();
            stackPost.Upvote();
            stackPost.Downvote();
            Console.WriteLine(stackPost.GetTotalVoteValue());


            /////// Inheritance /////
            ///////////////////////////
            var text = new Text();
            text.Width = 100;
            text.Copy();



            //////// Composition ///////////
            ///////////////////////////////
            var dbMigrator = new DBMigrator(new Logger());

            var logger = new Logger();
            var installer = new Installer(logger);
            dbMigrator.Migrate();
            installer.Install();


            //////////////////////CASTING/////////////
            //////////////////////////////////////////

            TextCasting textCasting = new TextCasting();
            ShapeCasting shape = textCasting;

            
            //// THESE BOTH REFERENCE THE SAME OBJ
            
            text.Width = 200;
            shape.Width = 100;

            Console.WriteLine(text.Width);


            ////////// BOXING AND UNBOXING //////////////
            //////////////////////////////////////////
            var list = new ArrayList();
            list.Add(1);
            list.Add("Mosh");
            list.Add(DateTime.Today);
            // boxing happens here so its slower than using a List with a generic type

            var anotherList = new List<int>();
            var names = new List<string>();


            ////////////////// Exercises ///////////////////
            ///
            var stack = new Stack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());


            ////////////// POLYMORPHISM EXERCISES /////////////
            ///////////////////////////////////////////////////

            var sqlConnection = new SQLConnection("Blah da blah");
            var oracleConnection = new OracleConnection("agjgoega");
            var dbCommand = new DbCommand(oracleConnection, "DO THIS THING");
            dbCommand.Execute();
        }
    }
}
