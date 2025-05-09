﻿namespace ClassLibrary.Command
{
    public class CommandInvoker
    {
        private readonly Stack<ICommand> _commandHistory = new Stack<ICommand>();

        public void ExecuteCommand(ICommand command)
        {
            command.Execute();
            _commandHistory.Push(command);
        }

        public void UndoLastCommand()
        {
            if (_commandHistory.Count > 0)
            {
                if( _commandHistory.Count > 0)
                {
                    var command = _commandHistory.Pop();
                    command.Undo();
                }
            }
                
        }
    }
}
