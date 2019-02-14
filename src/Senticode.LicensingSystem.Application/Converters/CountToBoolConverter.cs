﻿using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Markup;

namespace Senticode.LicensingSystem.Application.Converters
{
    [ValueConversion(typeof(int), typeof(bool))]
    public class CountToBoolConverter : MarkupExtension, IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if ((int) value > 0)
            {
                return true;
            }

            return false;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return this;
        }
    }
}
