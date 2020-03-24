using System;
using System.Collections.Generic;
using System.Text;

namespace Intermediate_Practice_Udemy_Course
{
    class GoldCustomersAccessModifiers : CustomerAccessModifiers
    {
        public void OfferVoucher()
        {
            this.Promote();
        }
    }
}
