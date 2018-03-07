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

namespace EnsasWare
{
    /// <summary>
    /// Integration of the logic of MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            GridMain.Children.Clear();
            GridMain.Children.Add(new LoginControl());

            etudiantBtn.Visibility = System.Windows.Visibility.Hidden;
            filiereBtn.Visibility = System.Windows.Visibility.Hidden;
            statistiqueBtn.Visibility = System.Windows.Visibility.Hidden;
            aproposBtn.Visibility = System.Windows.Visibility.Hidden;
            logout.Visibility = System.Windows.Visibility.Hidden;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int index = int.Parse(((Button)e.Source).Uid);

            GridCursor.Margin = new Thickness(10 + (150 * index), 0, 0, 0);

            switch(index)
            {
                case 0:
                    GridMain.Children.Clear();
                    GridMain.Background = Brushes.Aquamarine;
                    GridMain.Children.Add(new LoginControl());
                    break;
                case 1:
                    GridMain.Background = Brushes.Beige;
                    break;
                case 2:
                    GridMain.Background = Brushes.CadetBlue;
                    break;
                case 3:
                    GridMain.Background = Brushes.DarkBlue;
                    break;
                case 4:
                    GridMain.Background = Brushes.Firebrick;
                    break;
                case 5:
                    GridMain.Background = Brushes.Gainsboro;
                    break;
                case 6:
                    GridMain.Background = Brushes.HotPink;
                    break;
            }
        }

        private void close_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();

        }
        public MainWindow GetMainWindow()
        {
            return this;
        }

        private void logout_Click(object sender, RoutedEventArgs e)
        {
            accueilBtn.Visibility = System.Windows.Visibility.Visible;
            etudiantBtn.Visibility = System.Windows.Visibility.Hidden;
            filiereBtn.Visibility = System.Windows.Visibility.Hidden;
            statistiqueBtn.Visibility = System.Windows.Visibility.Hidden;
            aproposBtn.Visibility = System.Windows.Visibility.Hidden;
            logout.Visibility = System.Windows.Visibility.Hidden;
        }
    }
}
