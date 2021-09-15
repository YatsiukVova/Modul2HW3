using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Models.Candy;

namespace ConsoleApp1.Helpers
{
    public class WeightCandyComparer : IComparer<Candy>
    {
        public int Compare(Candy candy1, Candy candy2)
        {
            if (candy1.Weight > candy2.Weight)
            {
                return 1;
            }
            else if (candy1.Weight < candy2.Weight)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}
