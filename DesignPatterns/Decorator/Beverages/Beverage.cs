﻿namespace DesignPatterns.Decorator
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
