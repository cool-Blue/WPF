﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace ContentToggleButton.Converters
{
	public class ContentChecked : IMultiValueConverter
	{
		public object Convert(object[] values, Type targetType, 
			object parameter, CultureInfo culture)
		{
			try
			{
				var options = (List<string>) values[0];
				var isChecked = (bool) values[1];
				return isChecked 
					? options[0] ?? DependencyProperty.UnsetValue.ToString()
					: options[1] ?? DependencyProperty.UnsetValue.ToString();
			}
			catch (Exception e)
			{
				return DependencyProperty.UnsetValue.ToString();
			}
		}

		public object[] ConvertBack(object value, Type[] targetTypes, 
			object parameter, CultureInfo culture)
		{
			throw new NotImplementedException();
		}
	}
}
