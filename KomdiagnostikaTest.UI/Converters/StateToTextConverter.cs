using KomdiagnostikaTest.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Windows.Data;

namespace KomdiagnostikaTest.UI.Converters
{
    public class StateToTextConverter : IValueConverter
    {
        private static IDictionary<State, string> _descriptions = new Dictionary<State, string>
        {
            { State.Norm, "Норма" },
            { State.Alarm, "Тревога" },
            { State.Accident, "Авария" },
            { State.Malfunction, "Неисправность" },
        };

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (!(value is State))
                return null;
            var state = (State)value;
            if (!_descriptions.ContainsKey(state))
                return null;
            return _descriptions[state];
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotSupportedException();
        }
    }
}
