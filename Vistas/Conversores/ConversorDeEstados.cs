using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace Vistas.Conversores
{
    
    public class ConversorDeEstados: IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            String estado = (String)value;

            if (estado == "Libre")
            {
                return new SolidColorBrush(Colors.Green);
            }
            else if (estado == "Reservada")
            {
                return new SolidColorBrush(Colors.Chocolate);
            }
            else if (estado == "Ocupada")
            {
                return new SolidColorBrush(Colors.Red);
            }
            else if (estado == "Pidiendo")
            {
                return new SolidColorBrush(Colors.Purple);
            }
            else if (estado == "En espera de comida")
            {
                return new SolidColorBrush(Colors.PaleGreen);
            }
            else if (estado == "Servidos")
            {
                return new SolidColorBrush(Colors.Coral);
            }
            else if (estado == "Esperando cuenta")
            {
                return new SolidColorBrush(Colors.LightBlue);
            }
            else if (estado == "Pagando")
            {
                return new SolidColorBrush(Colors.YellowGreen);
            }
            else
            {
                return new SolidColorBrush(Colors.Wheat);
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
                throw new InvalidOperationException("Conversión en un solo sentido.");
        }
    }
}
