using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TabbedPagesWithCollectionViewDemo.Models
{
    public class RainReportStyleConverter : IValueConverter
    {
        public object? Convert(object? value, Type targetType, object? parameter, System.Globalization.CultureInfo? culture)
        {
            try
            {
                if (value != null && value.ToString() != "")
                {
                    double _value = (double)value;
                    if (_value >= 1 && _value <= 8)
                    {
                        return Colors.Green;
                    }
                    else if (_value > 8)
                    {
                        return Colors.Red;
                    }
                    else
                    {
                        return Colors.Black;
                    }
                }
                else { return Colors.Black; }
            }
            catch (Exception ex)
            {

                return Colors.Black;
            }
        }

        public object? ConvertBack(object? value, Type targetType, object? parameter, System.Globalization.CultureInfo? culture)
        {
            return value;
        }
    }
}
