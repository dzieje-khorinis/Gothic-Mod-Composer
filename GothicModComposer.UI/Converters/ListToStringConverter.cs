using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Data;

namespace GothicModComposer.UI.Converters;

public class ListToStringConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
    {
        if (targetType != typeof(string))
            throw new InvalidOperationException("The target must be a String");

        return string.Join(Environment.NewLine, value: ((ObservableCollection<string>)value)?.ToArray() ?? Array.Empty<string>());
    }

    public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
    {
        return value?.ToString()?.Split(Environment.NewLine).ToList();
    }
}