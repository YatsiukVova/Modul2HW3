using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Models.Candy;

namespace ConsoleApp1.Common
{
   public class RandomCandy
    {
        public Candy[] GetRandomCandy(int maxSize, Candy[] candy)
        {
            if (maxSize < 2 || candy == null || candy.Length < 2)
            {
                return null;
            }
            else
            {
                var random = new Random();
                var randomCandy = new Candy[maxSize];
                for (var i = 0; i < maxSize; i++)
                {
                    randomCandy[i] = candy[random.Next(candy.Length)];
                }

                return randomCandy;
            }
        }
    }
}
