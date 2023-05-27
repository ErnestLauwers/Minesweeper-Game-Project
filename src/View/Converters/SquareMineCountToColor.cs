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
        public object? One { get; set; }
        public object? Two { get; set; }
        public object? Three { get; set; }
        public object? Four { get; set; }
        public object? Five { get; set; }
        public object? Six { get; set; }
        public object? Rest { get; set; }

        public object? Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is int neighboringMineCount && neighboringMineCount > 0)
            {
                switch (neighboringMineCount)
                {
                    case 1:
                        return One;
                    case 2:
                        return Two;
                    case 3:
                        return Three;
                    case 4:
                        return Four;
                    case 5:
                        return Five;
                    case 6:
                        return Six;
                }
            }
            return Rest;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
