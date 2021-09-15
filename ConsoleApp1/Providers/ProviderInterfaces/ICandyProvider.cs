using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Models.Candy;

namespace ConsoleApp1.Providers.ProviderInterfaces
{
   public interface ICandyProvider
    {
        public Candy[] GetCandys();
    }
}
