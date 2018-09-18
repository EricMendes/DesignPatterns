using DesignPatterns.Command.Vendors;

namespace DesignPatterns.Command.Commands
{
    public class CeilingFanOnCommand : ICommand
    {
        private readonly CeilingFan _fan;

        public CeilingFanOnCommand(CeilingFan fan)
        {
            _fan = fan;
        }

        public void Execute()
        {
            _fan.High();
        }

        public void Undo()
        {
            _fan.Off();
        }
    }
}
