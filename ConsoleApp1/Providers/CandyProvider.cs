using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Models.Candy;
using ConsoleApp1.Providers.ProviderInterfaces;
using ConsoleApp1.Models.Candy.SugarCandy;
using ConsoleApp1.Models.Candy.NotSugarCandy;

namespace ConsoleApp1.Providers
{
   public class CandyProvider : ICandyProvider
    {
        private readonly Candy[] _candy;

        public CandyProvider()
        {
            _candy = new Candy[]
            {
                new Cow() { Name = "Cowww", Calories = 102, Weight = 20 },
                new Cherry() { Name = "Alko Cherry", Calories = 276, Weight = 50 },
                new Dzek() { Name = "Pirat Dzek", Calories = 120, Weight = 150 },
                new BirdMilk() { Name = "Bird Milk", Calories = 67, Weight = 100 },
                new DedMoroz() { Name = "Ded Moroz", Calories = 446, Weight = 200 },
                new BuzyBee() { Name = "Buzy Bee", Calories = 34, Weight = 10 },
            };
        }

        public Candy[] GetCandys()
        {
            var vegetables = new Candy[_candy.Length];

            for (var i = 0; i < _candy.Length; i++)
            {
                vegetables[i] = _candy[i].Clone() as Candy;
            }

            return vegetables;
        }
    }
}
