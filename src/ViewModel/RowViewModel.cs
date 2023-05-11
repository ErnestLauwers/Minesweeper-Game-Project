using Cells;
using Model.MineSweeper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class RowViewModel
    {
        public RowViewModel(IEnumerable<SquareViewModel> squares)
        {
            Squares = squares;
        }

        public IEnumerable<SquareViewModel> Squares { get; }

    }
}
