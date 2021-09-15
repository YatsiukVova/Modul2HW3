using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models.Candy.NotSugarCandy
{
   public class Dzek : WaferCandy
    {
        public override object Clone()
        {
            return new Dzek() { Name = Name, Calories = Calories, Weight = Weight };
        }
    }
}
