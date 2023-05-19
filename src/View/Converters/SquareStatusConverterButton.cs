﻿using Model.MineSweeper;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Windows.Media;

namespace View.Converters
{
    public class SquareStatusConverterButton : IValueConverter
    {
        public object? Uncovered { get; set; }
        public object? Covered { get; set; }
        public object? Flagged { get; set; }
        public object? Mine { get; set; }

        public object? Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var squareStatus = (SquareStatus)value;
            switch (squareStatus)
            {
                case SquareStatus.Uncovered:
                    return false;

                case SquareStatus.Covered:
                    return true;

                case SquareStatus.Mine:
                    return false;

                case SquareStatus.Flagged:
                    return true;

                default:
                    throw new ArgumentException("Invalid Square Status Given");
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

    }
}