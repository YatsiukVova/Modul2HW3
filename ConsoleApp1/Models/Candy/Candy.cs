using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models.Candy
{
   public abstract class Candy : ICloneable
    {
        public string Name { get; init; }
        public int Calories { get; init; }
        public double Weight { get; init; }

        public abstract object Clone();
    }
}
