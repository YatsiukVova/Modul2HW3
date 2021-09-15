using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Servises.ServiseInterfaces;
using ConsoleApp1.Models.Candy;
using ConsoleApp1.Helpers;
using ConsoleApp1.Models;

namespace ConsoleApp1.Servises
{
    public class BoxService : IBoxServise
    {
        private readonly WeightCandyComparer _weightCandyComparer;
        private readonly CaloriesCandyComparer _caloriesCandyComparer;
        private Box _box;
        private Candy[] _candy;

        public BoxService()
        {
            _weightCandyComparer = new WeightCandyComparer();
            _caloriesCandyComparer = new CaloriesCandyComparer();
            _candy = new Candy[0];
        }

        public int Calories
        {
            get
            {
                var calories = 0;
                foreach (var candy in _candy)
                {
                    calories += candy.Calories;
                }

                return calories;
            }
        }

        public double Weight
        {
            get
            {
                var weight = 0D;
                foreach (var candy in _candy)
                {
                    weight += candy.Weight;
                }

                return weight;
            }
        }

        public Box CreateBox(string name, Candy[] candy)
        {
            if (!string.IsNullOrEmpty(name) && candy.Length > 1)
            {
                _box = new Box() { Name = name, Candy = candy };
                _candy = _box.Candy;
                return _box;
            }

            return null;
        }

        /*   public void SortByWeight()
           {
               Array.Sort(_candy, _weightCandyComparer);
           }

           public void SortByCalories()
           {
               Array.Sort(_candy, _caloriesCandyComparer);
           }
        */
        public Candy[] GetCandy()
        {
            var candy = new Candy[_candy.Length];

            for (var i = 0; i < _candy.Length; i++)
            {
                candy[i] = _candy[i].Clone() as Candy;
            }

            return candy;
        }
    }
}
