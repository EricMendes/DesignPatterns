using System;

namespace DesignPatterns.State
{
    public class GumballMachine
    {
        private IState StateController;
        private SoldOutState SoldOutState;
        private NoQuarterState NoQuarterState;
        private HasQuarterState HasQuarterState;
        private SoldState SoldState;
         
        public int Count { get; set; }
        public readonly int MAX_GUMS = 80;

        public GumballMachine(int count)
        {
            SoldOutState = new SoldOutState(this);
            NoQuarterState = new NoQuarterState(this);
            HasQuarterState = new HasQuarterState(this);
            SoldState = new SoldState(this);
            Count = count;
            if(Count > 0)
            {
                StateController = NoQuarterState;
            }
            else
            {
                StateController = SoldOutState;
            }
        }

        public void SetState(StateEnum state)
        {
            switch (state)
            {
                case StateEnum.SoldOut:
                    StateController = SoldOutState;
                    break;
                case StateEnum.NoQuarter:
                    StateController = NoQuarterState;
                    break;
                case StateEnum.HasQuarter:
                    StateController = HasQuarterState;
                    break;
                case StateEnum.Sold:
                    StateController = SoldState;
                    break;
                default:
                    throw new InvalidStateException(state.ToString());
            }
        }

        public StateEnum GetState()
        {
            return StateController.GetState();
        }

        public void Fill()
        {
            StateController.Fill();
            int quantity = MAX_GUMS - Count;
            Count = MAX_GUMS;
            Console.WriteLine("Gumball Machine filled with {0} gums", quantity);
        }

        public void InsertQuarter()
        {
            StateController.InsertQuarter();
        }

        public void EjectQuarter()
        {
            StateController.EjectQuarter();
        }

        public void TurnCrank()
        {
            StateController.TurnCrank();
        }

        public void ReleaseGum()
        {
            StateController.Dispense();
        }
    }
}
