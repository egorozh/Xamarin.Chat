using System;
using System.Globalization;
using Xamarin.Forms;

namespace Chat
{
    public class SentByMeToAlignmentConverter : BaseValueConverter<SentByMeToAlignmentConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (parameter == null)
                return (bool) value ? LayoutOptions.End : LayoutOptions.Start;
            else
                return (bool) value ? LayoutOptions.Start : LayoutOptions.End;
        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}