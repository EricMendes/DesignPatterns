using DesignPatterns.Command.Vendors;

namespace DesignPatterns.Command.Commands
{
    public class CeilingFanOffCommand : ICommand
    {
        private CeilingSpeed _previousSpeed;
        private readonly CeilingFan _fan;

        public CeilingFanOffCommand(CeilingFan fan)
        {
            _fan = fan;
        }
        public void Execute()
        {
            _previousSpeed = _fan.Speed;
            _fan.Off();
        }

        public void Undo()
        {
            _fan.Speed = _previousSpeed;
        }
    }
}
