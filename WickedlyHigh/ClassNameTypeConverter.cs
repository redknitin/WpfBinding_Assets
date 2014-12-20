using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

/*
This class is for debugging

 * Usage...

Add this to resources
<local:ClassNameTypeConverter x:Key="GetClassName" />
Then see what is bound by using a Label like this
<Label Content="{Binding Path=Assets, Mode=OneTime, Converter={StaticResource GetClassName}}" HorizontalAlignment="Left" Margin="10,10,0,0" VerticalAlignment="Top"/>
 */

namespace WickedlyHigh
{
    [ValueConversion(typeof(object), typeof(string))]
    public class ClassNameTypeConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return value == null ? "NULL" : value.GetType().FullName;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
