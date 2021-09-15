using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Servises;
using ConsoleApp1.Providers;
using ConsoleApp1.Common;

namespace ConsoleApp1
{
    class Starter
    {
        private readonly BoxService _boxService;
        private readonly CandyProvider _candyProvider;
        private readonly RandomCandy _randomCandy;

        public Starter()
        {
            _boxService = new BoxService();
            _candyProvider = new CandyProvider();
            _randomCandy = new RandomCandy();
        }

        public void Run()
        {
            _boxService.CreateBox("Create random box", _randomCandy.GetRandomCandy(10, _candyProvider.GetCandys()));
            var calories = _boxService.Calories;
            
        }
        }
}
