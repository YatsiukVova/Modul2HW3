using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models.Candy.NotSugarCandy
{
   public class Cherry : NotSugarCandy
    {
        public override object Clone()
        {
            return new Cherry() { Name = Name, Calories = Calories, Weight = Weight };
        }
    }
}
