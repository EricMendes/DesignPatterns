using DesignPatterns.Command.Vendors;

namespace DesignPatterns.Command.Commands
{
    public class StereoOnCommand : ICommand
    {
        private readonly Stereo _stereo;

        public StereoOnCommand(Stereo stereo)
        {
            _stereo = stereo;
        }
        public void Execute()
        {
            _stereo.Mode = StereoMode.BluRay;
            _stereo.Volume = 30;
            _stereo.On();
        }

        public void Undo()
        {
            _stereo.Off();
        }
    }
}
