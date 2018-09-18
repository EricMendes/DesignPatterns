using System;

namespace DesignPatterns.Command.Commands
{
    public class NoCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("No command to execute.");
        }

        public void Undo()
        {
            Console.WriteLine("No command to undo.");
        }
    }
}
