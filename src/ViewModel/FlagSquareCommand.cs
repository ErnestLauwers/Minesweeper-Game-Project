﻿using Cells;
using Model.Data;
using Model.MineSweeper;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ViewModel
{
    public class FlagSquareCommand : ICommand
    {

        private readonly ICell<IGame> game;
        private readonly Vector2D position;

        public FlagSquareCommand(ICell<IGame> game, Vector2D position)
        {
            this.game = game;
            this.position = position;
        }

        public event EventHandler? CanExecuteChanged;

        public bool CanExecute(object? parameter)
        {
            return this.game.Value.IsSquareCovered(this.position) & this.game.Value.Status != GameStatus.Lost & this.game.Value.Status != GameStatus.Won;
        }

        public void Execute(object? parameter)
        {
            this.game.Value = this.game.Value.ToggleFlag(this.position);
        }
    }
}
