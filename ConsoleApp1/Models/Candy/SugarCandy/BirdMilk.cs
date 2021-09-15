using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models.Candy.SugarCandy
{
   public class BirdMilk : SouffleCandy
    {
        public override object Clone()
        {
            return new BirdMilk() { Name = Name, Calories = Calories, Weight = Weight };
        }
    }
}
