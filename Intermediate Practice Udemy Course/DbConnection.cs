using System;
using System.Collections.Generic;
using System.Text;

namespace Intermediate_Practice_Udemy_Course
{
    public abstract class DbConnection
    {
        public TimeSpan Timeout { get; set; }
        public string ConnectionString { get; set; }
        public DbConnection(string connectionString)
        {
            if (connectionString == null || connectionString == "")
            {
                throw new InvalidOperationException("Connection string must not be null or empty");
            }

            ConnectionString = connectionString;
        }

        public abstract void Open();
        public abstract void Close();
    }
}
