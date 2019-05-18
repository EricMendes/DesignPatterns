namespace DesignPatterns.State
{
    public interface IState
    {
        StateEnum GetState();
        void InsertQuarter();
        void EjectQuarter();
        void TurnCrank();
        void Dispense();
        void Fill();
    }
}
