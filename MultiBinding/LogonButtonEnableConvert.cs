using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace MultiBinding
{
	public class LogonButtonEnableConvert : IMultiValueConverter
	{
		public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
		{

			//判断TextBox有没有空值 和TextBox1等于Textbox2和TextBox3等于Textbox4
			if (!values.Cast<string>().Any(text => string.IsNullOrEmpty(text))
				&& values[0].ToString() == values[1].ToString() 
				&& values[2].ToString() == values[3].ToString())
			{
				return true;
			}

			return false;
		}

		public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
		{
			throw new NotImplementedException();

		}
	}
}
