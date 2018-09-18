using DesignPatterns.Command.Vendors;

namespace DesignPatterns.Command.Commands
{
    class GardenLightOffCommand: ICommand
    {
        public readonly GardenLight _gardenLight;
        public GardenLightOffCommand(GardenLight gardenLight)
        {
            _gardenLight = gardenLight;
        }

        public void Execute()
        {
            _gardenLight.ManualOff();
        }

        public void Undo()
        {
            _gardenLight.ManualOn();
        }
    }
}
