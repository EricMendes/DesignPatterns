using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Decorator
{
    public abstract class Beverage
    {
        private string description = "Unknown beverage";

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public abstract double Cost();
        
    }
}
