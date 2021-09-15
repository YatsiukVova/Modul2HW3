using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models.Candy.SugarCandy
{
   public class BuzyBee : JellyCandy
    {
        public override object Clone()
        {
            return new BuzyBee() { Name = Name, Calories = Calories, Weight = Weight };
        }
    }
}
