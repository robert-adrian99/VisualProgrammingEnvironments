﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using WpfMVVMAgendaEF.ViewModels;

namespace WpfMVVMAgendaEF.Converters
{
    class PersonConvert : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (values[0] != null && values[1] != null)
            {
                return new PersonVM()
                {
                    Name = values[0].ToString(),
                    Address = values[1].ToString()
                };
            }
            else
            {
                return null;
            }
        }
        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, System.Globalization.CultureInfo culture)
        {
            PersonVM pers = value as PersonVM;
            object[] result = new object[2] { pers.Name, pers.Address };
            return result;
        }
    }
}
