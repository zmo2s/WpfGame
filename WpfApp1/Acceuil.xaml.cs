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

namespace WpfApp1
{
    /// <summary>
    /// Logique d'interaction pour Page2.xaml
    /// </summary>
    public partial class Acceuil 
    {
        private int cpt = 0;
        public Acceuil()
        {
            InitializeComponent();
        }
        
        
        private void throwDice(object sender, RoutedEventArgs e)
        {
            if (cpt == 0)
            {
                Fight page = new Fight(this);
                this.NavigationService.Navigate(page);
            }
            if (cpt == 1)
            {
                Merlin page = new Merlin(this);
                this.NavigationService.Navigate(page);
            }
            else if( cpt == 2)
            {
                MasterOfArms page = new MasterOfArms(this);
                this.NavigationService.Navigate(page);
            }
            cpt++;
        }
    }
}
