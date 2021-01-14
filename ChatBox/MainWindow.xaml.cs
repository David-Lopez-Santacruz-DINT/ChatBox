using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using WECPOFLogic;

namespace ChatBox
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<Usuario> listaMensajes;

        public MainWindow()
        {
            InitializeComponent();
            listaMensajes = new ObservableCollection<Usuario>();
            conversacionListBox.DataContext = listaMensajes;
        }

        // BOTON ENVIAR MENSAJE

        private void botonEnviarCommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            listaMensajes.Add(new Usuario("imagenes/hombre.png", "Usuario", cajaTextBox.Text.ToString()));
            listaMensajes.Add(new Usuario("imagenes/robot.png", "Robot", "Lo siento, estoy un poco cansado para hablar"));
        }

        private void botonEnviarCommandBinding_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            if (cajaTextBox.Text.Length > 0)
            {
                e.CanExecute = true;
            }
            else
            {
                e.CanExecute = false;
            }
        }

        // BOTON SALIR

        private void botonSalirCommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }

        private void botonCheckCommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBoxManager.OK = "Aceptar";
            MessageBox.Show("Conexión correcto con el servidor del Bot", "Comprobar conexión", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        // BOTON CONFIGURAR

        private void botonConfigurarCommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            ventanaConfigurar hija = new ventanaConfigurar();
            hija.Owner = this;
            hija.ShowInTaskbar = false;
            hija.ResizeMode = ResizeMode.NoResize;
            hija.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            hija.Show();
        }

        // BOTON GUARDAR


    }
}
