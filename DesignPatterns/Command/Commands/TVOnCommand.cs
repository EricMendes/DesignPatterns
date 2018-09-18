using DesignPatterns.Command.Vendors;

namespace DesignPatterns.Command.Commands
{
    public class TVOnCommand: ICommand
    {
        private readonly TV _tv;
        public TVOnCommand(TV tv)
        {
            _tv = tv;
        }

        public void Execute()
        {
            _tv.Channel = 50;
            _tv.Volume = 20;
            _tv.On();

        }

        public void Undo()
        {
            _tv.Off();
        }
    }
}
