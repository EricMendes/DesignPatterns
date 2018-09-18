using DesignPatterns.Command.Vendors;

namespace DesignPatterns.Command.Commands
{
    public class TVOffCommand: ICommand
    {
        private int _previousChannel;
        private int _previousVolume;

        private readonly TV _tv;
        public TVOffCommand(TV tv)
        {
            _tv = tv;
        }

        public void Execute()
        {
            _previousChannel = _tv.Channel;
            _previousVolume = _tv.Volume;
            _tv.Off();

        }

        public void Undo()
        {
            _tv.Channel = _previousChannel;
            _tv.Volume = _previousVolume;
            _tv.On();
        }
    }
}
