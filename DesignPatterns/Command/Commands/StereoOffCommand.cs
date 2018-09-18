using DesignPatterns.Command.Vendors;

namespace DesignPatterns.Command.Commands
{
    class StereoOffCommand : ICommand
    {
        private readonly Stereo _stereo;
        private StereoMode _previousMode;
        private int _previousVolume;

        public StereoOffCommand(Stereo stereo)
        {
            _stereo = stereo;
        }

        public void Execute()
        {
            _previousMode = _stereo.Mode;
            _previousVolume = _stereo.Volume;
            _stereo.Off();
        }

        public void Undo()
        {
            _stereo.Volume = _previousVolume;
            _stereo.Mode = _previousMode;
            _stereo.On();
        }
    }
}
