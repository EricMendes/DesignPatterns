using System;

namespace DesignPatterns.State
{
    public class SoldState: IState
    {
        private readonly GumballMachine _gumballMachine;
        public SoldState(GumballMachine gumballMachine)
        {
            _gumballMachine = gumballMachine;
        }

        public void Dispense()
        {
            Console.Write("Gumball dispensed.");
            _gumballMachine.Count--;
            if(_gumballMachine.Count > 0)
            {
                _gumballMachine.SetState(StateEnum.NoQuarter);
            }
            else
            {
                _gumballMachine.SetState(StateEnum.SoldOut);
            }
        }

        public void EjectQuarter()
        {
            Console.WriteLine("Sorry, you already turned the crank.");
        }

        public void Fill()
        {
        }

        public StateEnum GetState()
        {
            return StateEnum.Sold;
        }

        public void InsertQuarter()
        {
            Console.WriteLine("Please wait, we're already giving you a gumball.");
        }

        public void TurnCrank()
        {
            Console.WriteLine("Turn twice doesn't give you another gumball.");
        }
    }
}
