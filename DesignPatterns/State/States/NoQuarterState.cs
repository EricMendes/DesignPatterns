using System;

namespace DesignPatterns.State
{
    public class NoQuarterState : IState
    {
        private readonly GumballMachine _gumballMachine;
        public NoQuarterState(GumballMachine gumballMachine)
        {
            _gumballMachine = gumballMachine;
        }
        public void Dispense()
        {
            Console.WriteLine("No quarter inserted.");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("No quarter inserted.");
        }

        public void Fill()
        {
        }

        public StateEnum GetState()
        {
            return StateEnum.NoQuarter;
        }

        public void InsertQuarter()
        {
            Console.WriteLine("Quarter inserted");
            _gumballMachine.SetState(StateEnum.HasQuarter);
        }

        public void TurnCrank()
        {
            Console.WriteLine("No quarter inserted.");
        }
    }
}
