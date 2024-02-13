﻿using System;
using System.Globalization;
using Avalonia.Data.Converters;

namespace KalkulatorLeasinguSamochod.Converters
{
	public class NumericUpDownValueConverter : IValueConverter
	{
		public object Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
		{
			if (value is null)
				return default(decimal);
			return (decimal?)((IConvertible)value).ToDecimal(culture);
		}

		public object ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
		{
			if (value is null)
			{
				if (targetType == typeof(int))
					return 0;
				if (targetType == typeof(float))
					return 0f;
				throw new ArgumentNullException($"Unsupported type: {targetType.FullName}");
			}

			if (targetType == typeof(int))
				return ((IConvertible)value).ToInt32(culture);
			if (targetType == typeof(float))
				return ((IConvertible)value).ToSingle(culture);
			throw new ArgumentNullException($"Unsupported type: {targetType.FullName}");
		}
	}
}
