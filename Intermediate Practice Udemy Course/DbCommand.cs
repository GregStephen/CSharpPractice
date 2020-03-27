using System;
using System.Collections.Generic;
using System.Text;

namespace Intermediate_Practice_Udemy_Course
{
    class DbCommand
    {
        public DbConnection Connection { get; set; }
        public string Instruction { get; set; }
        public DbCommand(DbConnection dbConnection, string instruction)
        {
            if(dbConnection == null)
            {
                throw new InvalidOperationException("Connection is null");
            }
            if (instruction == null || instruction == "")
            {
                throw new InvalidOperationException("Instruction must not be null or empty");
            }
            Connection = dbConnection;
            Instruction = instruction;

        }

        public void Execute()
        {
            Connection.Open();
            Console.WriteLine(Instruction);
            Connection.Close();
        }
    }
}
