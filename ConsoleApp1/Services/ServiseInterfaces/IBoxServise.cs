using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Servises.ServiseInterfaces;
using ConsoleApp1.Providers;
using ConsoleApp1.Models.Candy;
using ConsoleApp1.Helpers;
using ConsoleApp1.Models;

namespace ConsoleApp1.Servises.ServiseInterfaces
{
    public interface IBoxServise
    {
        public int Calories { get; }
        public double Weight { get; }

        public Box CreateBox(string name, Candy[] candy);
 
     
        public Candy[] GetCandys();
    }
}
