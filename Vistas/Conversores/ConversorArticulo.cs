using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

using ClasesBase;

namespace Vistas.Conversores
{
    class ConversorArticulo: IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {

            int id = (int)value;

            return TrabajarArticulos.TraerArticuloPorId(id);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new InvalidOperationException("Conversión en un solo sentido.");
        }
    }
}
