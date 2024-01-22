using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPFInalsBankApp
{
    internal class CustomerDesu
    {
        public string Name { get; set; }
        public string AccountNumber { get; set; }
        public string Password { get; set; }
        public decimal Balance { get; private set; }
        public CustomerDesu (string customerNumber)
        {

        }
    }
}
