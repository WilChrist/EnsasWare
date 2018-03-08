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
    /// Logique d'interaction pour GestionFiliere.xaml
    /// </summary>
    public partial class GestionFiliere : UserControl
    {
        public GestionFiliere()
        {
            InitializeComponent();
        }

        private void ajouterFil_Click(object sender, RoutedEventArgs e)
        {
            //ajouter une filière
        }

        private void modifierFil_Click(object sender, RoutedEventArgs e)
        {
            //modifier une filière
        }

        private void supprimerFil_Click(object sender, RoutedEventArgs e)
        {
            //supprimer une filire
        }

        private void radfil_Loaded(object sender, RoutedEventArgs e)
        {
            //chargement des données
            //DataClasses1DataContext bd = new DataClasses1DataContext();
            //radfil.ItemsSource = bd.Filiere;
        }
    }
}
