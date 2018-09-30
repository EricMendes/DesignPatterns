using System;

namespace DesignPatterns.Adapter
{
    public class Gobble : IGobbleBehavior
    {
        void IGobbleBehavior.Gobble()
        {
            Console.WriteLine("Gobble gobble.");
        }
    }
}
