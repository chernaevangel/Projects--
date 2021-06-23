using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AD_Project_FinalVers
{
    public class Expense
    {
        private string name;
        private double amount;

        public string Name { get { return this.name; } }
        public double Amount { get { return this.amount; } }
        public Expense(string n, double a)
        {
            this.name = n;
            this.amount = a;
        }
    }
}
