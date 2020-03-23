using System;
using System.Collections.Generic;
using System.Text;

namespace Intermediate_Practice_Udemy_Course
{
    class Text : PresentationObject
    {
        public int FontSize { get; set; }
        public string FontName { get; set; }
        public void AddHyperlink(string url)
        {
            Console.WriteLine("we added a link to " + url);
        }
    }
}
