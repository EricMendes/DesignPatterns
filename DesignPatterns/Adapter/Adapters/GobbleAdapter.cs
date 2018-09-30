using DesignPatterns.Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Adapter
{
    public class GobbleAdapter : IQuackBehavior
    {
        private readonly IGobbleBehavior GobbleBehavior;

        public GobbleAdapter(IGobbleBehavior gobbleBehavior)
        {
            GobbleBehavior = gobbleBehavior;
        }

        public void Quack()
        {
            GobbleBehavior.Gobble();
        }
    }
}
