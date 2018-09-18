using DesignPatterns.Command.Vendors;

namespace DesignPatterns.Command.Commands
{
    class GardenLightSummerTimeCommand: ICommand
    {
        private int _previousDuskHour;
        private int _previousDuskMinute;
        private int _previousDawnHour;
        private int _previousDawnMinute;
        private readonly GardenLight _gardenLight;

        public GardenLightSummerTimeCommand(GardenLight gardenLight)
        {
            _gardenLight = gardenLight;
        }

        public void Execute()
        {
            _previousDawnHour = _gardenLight.DawnHour;
            _previousDawnMinute = _gardenLight.DawnMinute;
            _previousDuskHour = _gardenLight.DuskHour;
            _previousDuskMinute = _gardenLight.DuskMinute;
            _gardenLight.SetDawnTime(6, 30);
            _gardenLight.SetDuskTime(19, 30);
        }

        public void Undo()
        {
            _gardenLight.SetDawnTime(_previousDawnHour, _previousDawnMinute);
            _gardenLight.SetDuskTime(_previousDuskHour, _previousDuskMinute);
        }
    }
}
