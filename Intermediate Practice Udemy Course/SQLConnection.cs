using System;
using System.Collections.Generic;
using System.Text;

namespace Intermediate_Practice_Udemy_Course
{
    class SQLConnection : DbConnection
    {
        public SQLConnection(string connectionString)
            : base(connectionString)
        {
            
        }
        public override void Close()
        {
            Console.WriteLine("SQL Connection Closed");
        }

        public override void Open()
        {
            Console.WriteLine("SQL Connection Open");
        }
    }
}
