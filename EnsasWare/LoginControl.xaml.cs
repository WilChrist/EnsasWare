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
    /// Logique d'interaction pour LoginControl.xaml
    /// </summary>
    public partial class LoginControl : UserControl
    {
        int i;
        public LoginControl()
        {
            InitializeComponent();i = 0;
        }

        private void RadButton_Click(object sender, RoutedEventArgs e)
        {
            if (txtlogin.Text.ToString().Equals("admin") && txtpassword.Password.ToString().Equals("12345"))
            {
                MessageBox.Show("Vous êtes désormais Connecté !");
                MainWindow main= (MainWindow) (Application.Current.MainWindow);
                main.GetMainWindow().accueilBtn.Visibility=System.Windows.Visibility.Hidden;
                main.GetMainWindow().etudiantBtn.Visibility = System.Windows.Visibility.Visible;
                main.GetMainWindow().filiereBtn.Visibility = System.Windows.Visibility.Visible;
                main.GetMainWindow().statistiqueBtn.Visibility = System.Windows.Visibility.Visible;
                main.GetMainWindow().aproposBtn.Visibility = System.Windows.Visibility.Visible;
                main.GetMainWindow().logout.Visibility = System.Windows.Visibility.Visible;

            }
            else
            {
                i++;
                if (i < 3)
                {
                    MessageBox.Show("Veuillez entrez le bon login et le bon password");
                }
                else if(i>=3 && i<5)
                {
                    MessageBox.Show("Indice : adm** and *2*45 ","Veuillez entrez le bon login et le bon password");
                }
                else
                {
                    MessageBox.Show("Vous avez fait plus de 4 essaies l'application va s'arreter", "WARNING !!!");
                    Application.Current.Shutdown();
                }
                
            }
        }
    }
}
