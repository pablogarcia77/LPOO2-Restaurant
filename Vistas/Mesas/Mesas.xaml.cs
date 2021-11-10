using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Data;
using System.Globalization;
using Vistas.Ventas;
using ClasesBase;

using Vistas.Conversores;
using Vistas.Impresiones;

namespace Vistas
{
    /// <summary>
    /// Lógica de interacción para Mesas.xaml
    /// </summary>
    public partial class Mesas : Page
    {
        public static int idMesa;

        public string estadoMesa = null;

        public Mesas()
        {
            InitializeComponent();
        }

        private Brush convertString(string color)
        {
            if (color == "Libre")
            {
                return new SolidColorBrush(Colors.Green);
            }
            else if (color == "Reservada")
            {
                return new SolidColorBrush(Colors.Chocolate);
            }
            else if (color == "Ocupada")
            {
                return new SolidColorBrush(Colors.Red);
            }
            else if (color == "Pidiendo")
            {
                return new SolidColorBrush(Colors.Purple);
            }
            else if (color == "En espera de comida")
            {
                return new SolidColorBrush(Colors.PaleGreen);
            }
            else if (color == "Servidos")
            {
                return new SolidColorBrush(Colors.Coral);
            }
            else if (color == "Esperando cuenta")
            {
                return new SolidColorBrush(Colors.LightBlue);
            }
            else if (color == "Pagando")
            {
                return new SolidColorBrush(Colors.YellowGreen);
            }
            else
            {
                return new SolidColorBrush(Colors.Wheat);
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            CargarMesas();
        }

        private void CargarMesas()
        {
            ConversorDeEstados ce = new ConversorDeEstados();

            int left = 25;
            int top = 50;
            DataTable mesas = TrabajarMesa.TotalMesas();

            for (int i = 1; i <= mesas.Rows.Count; i++)
            {
                //Create new button element
                Button oBtn = new Button();
                //Set name and content
                oBtn.Name = "button" + i.ToString();
                oBtn.Content = i.ToString();
                //Set tooltip
                oBtn.ToolTip = mesas.Rows[i - 1]["Mesa_Estado"].ToString();
                //Set bolder font
                oBtn.FontWeight = FontWeights.Bold;
                //Set background color & click event
                oBtn.Background = convertString(mesas.Rows[i - 1]["Mesa_Estado"].ToString());
                oBtn.Click += new RoutedEventHandler(CheckLibre);
                //Set width, height & VHAlign
                oBtn.Height = 55;
                oBtn.Width = 105;
                oBtn.VerticalAlignment = VerticalAlignment.Top;
                oBtn.HorizontalAlignment = HorizontalAlignment.Left;
                //Set text color
                oBtn.Foreground = Brushes.White;

                //Set positions
                oBtn.Margin = new Thickness(left, top, 0, 0);

                //Increase in 125 to draw first column
                left = left + 125;

                //2th, 3th & 4th Row
                if (i % 4 == 0 && i >= 4)
                {
                    top = top + 70;
                }
                //left property back to 25
                if (left > 400)
                {
                    left = 25;
                }

                //Disabled 11th & 17th Table (BgColor red)
                //if (i == 11 || i == 17)
                //{
                //    oBtn.Background = Brushes.Red;
                //}
                //Add button to grid
                Grilla.Children.Add(oBtn);
            }
        }

        private void CheckLibre(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            idMesa = Convert.ToInt32(button.Content.ToString());
            Mesa oMesa = new Mesa();
            oMesa = TrabajarMesa.TraerMesaPorId(idMesa);

            if (estadoMesa == null)
            {
                
                //MessageBox.Show(button.GetBindingExpression(BackgroundProperty).DataItem.ToString());
                if (oMesa.Mesa_estado == "Libre" || oMesa.Mesa_estado == "En espera de comida" || oMesa.Mesa_estado == "Servidos" || oMesa.Mesa_estado == "Pidiendo")
                {
                    //MessageBox.Show(button.Content.ToString());
                    //Pedidos oPedidos = new Pedidos();
                    //oPedidos.Show();
                    if (oMesa.Mesa_estado == "Libre")
                    {
                        oMesa.Mesa_estado = "Pidiendo";
                        TrabajarMesa.ModificarEstadoMesa(oMesa);
                    }
                    Principal.Container.Source = new Uri("/Ventas/Pedidos.xaml", UriKind.RelativeOrAbsolute);

                }
                if (oMesa.Mesa_estado == "Esperando cuenta" || oMesa.Mesa_estado == "Pagando")
                {
                    if (oMesa.Mesa_estado == "Esperando cuenta")
                    {
                        oMesa.Mesa_estado = "Pagando";
                        TrabajarMesa.ModificarEstadoMesa(oMesa);
                    }
                    Pedidos.idMesa = idMesa;
                    ImpresionPedidos oImpP = new ImpresionPedidos();
                    oImpP.Show();
                }
            }
            else {
                oMesa.Mesa_estado = estadoMesa;
                TrabajarMesa.ModificarEstadoMesa(oMesa);
                estadoMesa = null;
                CargarMesas();
            }
            CargarMesas();
        }
        
        private void listEstados_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //estadoMesa = listEstados.SelectedValue.ToString();
        }

        private void btnCambiarEstado_Click(object sender, RoutedEventArgs e)
        {
            estadoMesa = listEstados.SelectedValue.ToString();
            if (listEstados.SelectedValue != null)
            {
                listEstados.SelectedValue = null;
            }
        }
        
    }
}
