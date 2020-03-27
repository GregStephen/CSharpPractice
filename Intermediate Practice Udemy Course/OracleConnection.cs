using System;
using System.Collections.Generic;
using System.Text;

namespace Intermediate_Practice_Udemy_Course
{
    class OracleConnection : DbConnection
    {
        public OracleConnection(string connectionString)
    : base(connectionString)
        {

        }
        public override void Close()
        {
            Console.WriteLine("Oracle Connection Closed");
        }

        public override void Open()
        {
            Console.WriteLine("Oracle Connection Open");
        }
    }
}
