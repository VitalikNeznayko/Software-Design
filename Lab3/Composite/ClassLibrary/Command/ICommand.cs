﻿namespace ClassLibrary.Command
{
    public interface ICommand
    {
        void Execute();
        void Undo();
    }
}
