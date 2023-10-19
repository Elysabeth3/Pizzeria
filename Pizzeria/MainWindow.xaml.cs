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

namespace Pizzeria
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Masa1_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void Masa2_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void Masa3_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void Bebida1_Checked(object sender, RoutedEventArgs e)
        {
            int posicionImagen = getIndiceImagen(ListaBebidas);

            Image imagen = (Image)ListaBebidas.Children[posicionImagen];

            imagen.Source = new BitmapImage(new Uri("/CocaCola.jpg", UriKind.Relative));
        }

        private void Bebida2_Checked(object sender, RoutedEventArgs e)
        {
            int posicionImagen = getIndiceImagen(ListaBebidas);

            Image imagen = (Image)ListaBebidas.Children[posicionImagen];

            imagen.Source = new BitmapImage(new Uri("/CocaColaLigth.jpg", UriKind.Relative));
        }

        private void Bebida3_Checked(object sender, RoutedEventArgs e)
        {
            int posicionImagen = getIndiceImagen(ListaBebidas);

            Image imagen = (Image)ListaBebidas.Children[posicionImagen];

            imagen.Source = new BitmapImage(new Uri("/CocaColaZero.jpg", UriKind.Relative));
        }

        private void Bebida4_Checked(object sender, RoutedEventArgs e)
        {
            int posicionImagen = getIndiceImagen(ListaBebidas);

            Image imagen = (Image)ListaBebidas.Children[posicionImagen];

            imagen.Source = new BitmapImage(new Uri("/Nestea.jpg", UriKind.Relative));
        }

        private void Bebida5_Checked(object sender, RoutedEventArgs e)
        {
            int posicionImagen = getIndiceImagen(ListaBebidas);

            Image imagen = (Image)ListaBebidas.Children[posicionImagen];

            imagen.Source = new BitmapImage(new Uri("/NesteaZero.jpg", UriKind.Relative));
        }

        private void Bebida6_Checked(object sender, RoutedEventArgs e)
        {
            int posicionImagen = getIndiceImagen(ListaBebidas);

            Image imagen = (Image)ListaBebidas.Children[posicionImagen];

            imagen.Source = new BitmapImage(new Uri("/Aquarius.jpg", UriKind.Relative));
        }

        private void Bebida7_Checked(object sender, RoutedEventArgs e)
        {
            int posicionImagen = getIndiceImagen(ListaBebidas);

            Image imagen = (Image)ListaBebidas.Children[posicionImagen];

            imagen.Source = new BitmapImage(new Uri("/AquariusNaranja.jpg", UriKind.Relative));
        }

        private void Bebida8_Checked(object sender, RoutedEventArgs e)
        {
            int posicionImagen = getIndiceImagen(ListaBebidas);

            Image imagen = (Image)ListaBebidas.Children[posicionImagen];

            imagen.Source = new BitmapImage(new Uri("/Sprite.jpg", UriKind.Relative));
        }

        private void Bebida9_Checked(object sender, RoutedEventArgs e)
        {
            int posicionImagen = getIndiceImagen(ListaBebidas);

            Image imagen = (Image)ListaBebidas.Children[posicionImagen];

            imagen.Source = new BitmapImage(new Uri("/FantaNaranja.jpg", UriKind.Relative));
        }

        private void Bebida10_Checked(object sender, RoutedEventArgs e)
        {
            int posicionImagen = getIndiceImagen(ListaBebidas);

            Image imagen = (Image)ListaBebidas.Children[posicionImagen];

            imagen.Source = new BitmapImage(new Uri("/FantaLimon.jpg", UriKind.Relative));
        }

        private void Bebida11_Checked(object sender, RoutedEventArgs e)
        {
            int posicionImagen = getIndiceImagen(ListaBebidas);

            Image imagen = (Image)ListaBebidas.Children[posicionImagen];

            imagen.Source = new BitmapImage(new Uri("/Schweppes.jpg", UriKind.Relative));
        }

        private void Ingrediente1_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void Ingrediente2_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void Ingrediente3_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void Ingrediente4_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void Ingrediente5_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void Ingrediente6_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void Ingrediente7_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void Ingrediente8_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void Ingrediente9_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void Aceptar_Click(object sender, RoutedEventArgs e)
        {
            anyadirTexto(TipoMasa);
            anyadirTexto(ListaBebidas);
            anyadirTexto(ListaIngredientes);

            Reset_Click(sender, e);
        }

        private void Reset_Click(object sender, RoutedEventArgs e)
        {
            borrarRadioButton(TipoMasa);
            borrarRadioButton(ListaBebidas);
            borrarCheckBox(ListaIngredientes);

            int posicionImagen = getIndiceImagen(ListaBebidas);

            Image imagen = (Image)ListaBebidas.Children[posicionImagen];

            imagen.Source = new BitmapImage(new Uri("", UriKind.Relative));
        }

        private void borrarRadioButton(StackPanel stackPanel)
        {
            for(int i = 0; i < stackPanel.Children.Count; i++)
            {
                if (stackPanel.Children[i].GetType() == typeof(RadioButton))
                {
                    RadioButton radioButton = (RadioButton) stackPanel.Children[i];
                    radioButton.IsChecked = false;
                }
            }
        }

        private void borrarCheckBox(StackPanel stackPanel)
        {

            for (int i = 0; i < stackPanel.Children.Count; i++)
            {
                if (stackPanel.Children[i].GetType() == typeof(CheckBox))
                {
                    CheckBox checkBox = (CheckBox)stackPanel.Children[i];
                    checkBox.IsChecked = false;
                }
            }
        }

        private void anyadirTexto(StackPanel stackPanel)
        {
            String texto;

            if (stackPanel.Children[0].GetType() == typeof(CheckBox))
            {
                for (int i = 0; i < stackPanel.Children.Count; i++)
                {
                    if (stackPanel.Children[i].GetType() == typeof(CheckBox))
                    {
                        CheckBox checkBox = (CheckBox)stackPanel.Children[i];
                        if (checkBox.IsChecked == true)
                        {
                            texto = checkBox.Content.ToString();
                            Pedido.Items.Add(texto);
                        }

                    }
                }
            }

            if (stackPanel.Children[0].GetType() == typeof(RadioButton))
            {
                for (int i = 0; i < stackPanel.Children.Count; i++)
                {
                    if (stackPanel.Children[i].GetType() == typeof(RadioButton))
                    {
                        RadioButton radioButton = (RadioButton)stackPanel.Children[i];
                        if (radioButton.IsChecked == true)
                        {
                            texto = radioButton.Content.ToString();
                            Pedido.Items.Add(texto);
                        }

                    }
                }
            }

        }

        private int getIndiceImagen(StackPanel stackPanel)
        {
            for (int i = 0; i < stackPanel.Children.Count; i++)
            {
                if (stackPanel.Children[i].GetType() == typeof(Image))
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
