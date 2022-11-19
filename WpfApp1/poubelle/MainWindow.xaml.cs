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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        public async void Merlin()
        {
          

            await Task.Delay(2000);
            btnAdd.Visibility = Visibility.Collapsed;
            txtName.Visibility = Visibility.Collapsed;
            ImgDe.Visibility = Visibility.Collapsed;
            ImgMerlin.Visibility = Visibility.Visible;
/*
            var newForm = new Window1(); //create your new form.
            newForm.Show(); //show the new form.
            this.Close(); //only if you want to close the current form.*/
           
        }

        public async void MasterOfArms()
        {


            await Task.Delay(2000);
            btnAdd.Visibility = Visibility.Collapsed;
            txtName.Visibility = Visibility.Collapsed;
            ImgDe.Visibility = Visibility.Collapsed;
            ImgMerlin.Visibility = Visibility.Visible;
        }

        public async void fight()
        {


            await Task.Delay(2000);
            btnAdd.Visibility = Visibility.Collapsed;
            txtName.Visibility = Visibility.Collapsed;
            ImgDe.Visibility = Visibility.Collapsed;
            ImgMerlin.Visibility = Visibility.Visible;
        }

        private void ButtonAddName_Click(object sender, RoutedEventArgs e)
        {


            txtName.Content = "Le dé tombe sur le chiffre 6";
           // round.Content = "7";
            Merlin();


        }

        private void txtName_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
