using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationExample
{
    public class Person
    {
        //private field
        private double _wallet = 0;

        //properties
        public string Name { get; set; }
        public int Age { get; set; }

        //methods that can access our field
        public void AddMoney(double moneyToAdd)
        {
            _wallet += moneyToAdd;
        }

        public double CheckWallet()
        {
            return _wallet;
        }
    }
}
