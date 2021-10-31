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

using Vistas.Ventas;

namespace Vistas
{
    /// <summary>
    /// Lógica de interacción para Mesas.xaml
    /// </summary>
    public partial class Mesas : Window
    {
        public static int idMesa;

        public Mesas()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            int left = 25;
            int top = 15;

            for (int i = 1; i <= 20; i++)
            {
                //Create new button element
                Button oBtn = new Button();
                //Set name and content
                oBtn.Name = "button" + i.ToString();
                oBtn.Content = i.ToString();
                //Set background color & click event
                oBtn.Background = Brushes.Green;
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
                if (i % 4 == 0 && i >=4)
                {
                    top = top + 70;
                }
                //left property back to 25
                if (left > 400)
                {
                    left = 25;
                }
                //Disabled 11th & 17th Table (BgColor red)
                if (i == 11 || i == 17)
                {
                    oBtn.Background = Brushes.Red;
                }
                //Add button to grid
                Grilla.Children.Add(oBtn);
            }

        }

        private void CheckLibre(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            if (button.Background == Brushes.Green)
            {
                idMesa = Convert.ToInt32(button.Content.ToString());
                //MessageBox.Show(button.Content.ToString());
                Pedidos oPedidos = new Pedidos();
                oPedidos.Show();
            }
            else
            {
                MessageBox.Show("Mesa ocupada");
            }
        }
    }
}
