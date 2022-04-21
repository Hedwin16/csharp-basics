using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace wpfClass
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hello World! - Direct Event");

        }
        private void Button_MouseUP(object sender, MouseEventArgs e)
        {
            MessageBox.Show("El boton ha sido soltado... - Bubbling Event");
        }
        private void Button_PreviewMouseUp(object sender, MouseEventArgs e)
        {
            MessageBox.Show("El boton ha sido soltado... - Tunneling Event");
        }
    }
}
