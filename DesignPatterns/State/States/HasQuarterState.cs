using System;

namespace DesignPatterns.State
{
    public class HasQuarterState : IState
    {

        private readonly GumballMachine _gumballMachine;
        public HasQuarterState(GumballMachine gumballMachine)
        {
            _gumballMachine = gumballMachine;
        }
        public void Dispense()
        {
            Console.WriteLine("Turn the crank to release the gum.");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("Quarter ejected.");
            _gumballMachine.SetState(StateEnum.NoQuarter);
        }

        public void Fill()
        {
        }

        public StateEnum GetState()
        {
            return StateEnum.HasQuarter;
        }

        public void InsertQuarter()
        {
            Console.WriteLine("Quarter already inserted.");
        }

        public void TurnCrank()
        {
            Console.WriteLine("Crank turned.");
            _gumballMachine.SetState(StateEnum.Sold);
        }
    }
}
