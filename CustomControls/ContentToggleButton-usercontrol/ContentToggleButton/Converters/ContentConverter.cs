﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
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
				var control = (IContent)values[2];

				var options = (values[0] == DependencyProperty.UnsetValue) || values[0] == null
					?  control.Options 
					: (List<string>)values[0];

				var isChecked = values[1] == DependencyProperty.UnsetValue || values[1] == null
					? control.InitialState
					: (bool)values[1];

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
