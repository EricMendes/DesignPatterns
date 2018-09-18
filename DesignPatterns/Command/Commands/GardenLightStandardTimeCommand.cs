using DesignPatterns.Command.Vendors;

namespace DesignPatterns.Command.Commands
{
    public class GardenLightStandardTimeCommand: ICommand
    {
        private int _previousDuskHour;
        private int _previousDuskMinute;
        private int _previousDawnHour;
        private int _previousDawnMinute;
        private readonly GardenLight _gardenLight;

        public GardenLightStandardTimeCommand(GardenLight gardenLight)
        {
            _gardenLight = gardenLight;
        }

        public void Execute()
        {
            _previousDawnHour = _gardenLight.DawnHour;
            _previousDawnMinute = _gardenLight.DawnMinute;
            _previousDuskHour = _gardenLight.DuskHour;
            _previousDuskMinute = _gardenLight.DuskMinute;
            _gardenLight.SetDawnTime(5, 0);
            _gardenLight.SetDuskTime(18, 0);
        }

        public void Undo()
        {
            _gardenLight.SetDawnTime(_previousDawnHour, _previousDawnMinute);
            _gardenLight.SetDuskTime(_previousDuskHour, _previousDuskMinute);
        }
    }
}
