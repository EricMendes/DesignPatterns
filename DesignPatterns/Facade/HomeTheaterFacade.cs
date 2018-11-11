using DesignPatterns.Facade.Components;
using System;

namespace DesignPatterns.Facade
{
    public class HomeTheaterFacade
    {
        private readonly Amplifier _amplifier;
        private readonly Tuner _tuner;
        private readonly DvdPlayer _dvdPlayer;
        private readonly CdPlayer _cdPlayer;
        private readonly Projector _projector;
        private readonly EnvironmentLight _light;
        private readonly Screen _screen;
        private readonly PopcornMachine _popcornMachine;

        public HomeTheaterFacade(
            Amplifier amplifier,
            Tuner tuner,
            DvdPlayer dvdPlayer,
            CdPlayer cdPlayer,
            Projector projector,
            EnvironmentLight environmentLight,
            Screen screen,
            PopcornMachine popcornMachine
            )
        {
            _amplifier = amplifier;
            _tuner = tuner;
            _dvdPlayer = dvdPlayer;
            _cdPlayer = cdPlayer;
            _projector = projector;
            _light = environmentLight;
            _screen = screen;
            _popcornMachine = popcornMachine;
        }

        public void WatchMovie(string movieName)
        {
            Console.WriteLine("Preparing to watch {0}", movieName);
            _popcornMachine.On();
            _popcornMachine.Pop();
            _light.On();
            _light.Dim(10);
            _screen.Down();
            _projector.On();
            _projector.WideScreenMode();
            _amplifier.On();
            _amplifier.DvdPlayer = _dvdPlayer;
            _amplifier.SetSurroundSound();
            _amplifier.SetVolume(10);
            _dvdPlayer.On();
            _dvdPlayer.Play(movieName);
        }
    }
}
