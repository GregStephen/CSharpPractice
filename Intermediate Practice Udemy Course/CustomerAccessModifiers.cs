using System;
using System.Collections.Generic;
using System.Text;

namespace Intermediate_Practice_Udemy_Course
{
    class CustomerAccessModifiers
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void Promote()
        {
            var rating = CalculateRating();
            if (rating == 0 )
                Console.WriteLine("Promoted to Level 1");
            else
                Console.WriteLine("Promoted to Level 2");
        }

        private int CalculateRating()
        {
            return 0;
        }
    }
}
