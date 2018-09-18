using DesignPatterns.Command.Commands;
using System.Collections.Generic;
using System;

namespace DesignPatterns.Command
{
    public class RemoteControl
    {
        public ICommand[] onCommands;
        public ICommand[] offCommands;
        private readonly Stack<ICommand> lastCommands; 

        public RemoteControl()
        {
            int quantity = 7;
            onCommands = new ICommand[quantity];
            offCommands = new ICommand[quantity];
            lastCommands = new Stack<ICommand>(10);
            for (int i = 0; i < quantity; i++)
            {
                onCommands[i] = new NoCommand();
                offCommands[i] = new NoCommand();
            }
        }

        public void ExecuteOnCommand(int slot)
        {
            onCommands[slot].Execute();
            lastCommands.Push(onCommands[slot]);
        }

        public void ExecuteOffCommand(int slot)
        {
            offCommands[slot].Execute();
            lastCommands.Push(offCommands[slot]);
        }

        public void UndoCommand()
        {
            if(lastCommands.Count == 0)
            {
                throw new InvalidOperationException("There is no command to undo.");
            }
            ICommand command = lastCommands.Pop();
            command.Undo();
        }
    }
}
