using DesignPatterns.Command.Vendors;

namespace DesignPatterns.Command.Commands
{
    public class GardenLightOnCommand : ICommand
    {
        public readonly GardenLight _gardenLight;
        public GardenLightOnCommand(GardenLight gardenLight)
        {
            _gardenLight = gardenLight;
        }

        public void Execute()
        {
            _gardenLight.ManualOn();
        }

        public void Undo()
        {
            _gardenLight.ManualOff();
        }
    }
}
