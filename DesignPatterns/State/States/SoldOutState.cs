using System;

namespace DesignPatterns.State
{
    public class SoldOutState : IState
    {
        private readonly GumballMachine _gumballMachine;
        public SoldOutState(GumballMachine gumballMachine)
        {
            _gumballMachine = gumballMachine;
        }
        public void Dispense()
        {
            Console.WriteLine("Gumball Machine is sold out!");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("Gumball Machine is sold out!");
        }

        public void Fill()
        {
            _gumballMachine.SetState(StateEnum.NoQuarter);
        }

        public StateEnum GetState()
        {
            return StateEnum.SoldOut;
        }

        public void InsertQuarter()
        {
            Console.WriteLine("Gumball Machine is sold out!");
        }

        public void TurnCrank()
        {
            Console.WriteLine("Gumball Machine is sold out!");
        }
    }
}
