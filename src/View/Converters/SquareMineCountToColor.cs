using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace View.Converters
{
    class SquareMineCountToColor : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is int neighboringMineCount && neighboringMineCount > 0)
            {
                switch (neighboringMineCount)
                {
                    case 1:
                        return Brushes.Blue;
                    case 2:
                        return Brushes.Green;
                    case 3:
                        return Brushes.Red;
                    case 4:
                        return Brushes.Orange;
                    case 5:
                        return Brushes.Purple;
                    case 6:
                        return Brushes.DeepPink;
                }
            }
            return Brushes.Transparent;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
