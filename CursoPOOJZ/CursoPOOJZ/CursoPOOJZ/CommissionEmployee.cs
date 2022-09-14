using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoPOOJZ
{
    public class CommissionEmployee : Employee
    {
        public float CommissionPercentege { get; set; }
        public decimal Sales { get; set; }
        public override decimal GetValueToPay()
        {
            return Sales*(decimal)CommissionPercentege;
        }
        public override string ToString()
        {
            return $"{base.ToString()}\n\t Value to pay: $ {GetValueToPay():C2}";
        }
    }
}
