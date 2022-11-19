﻿using System;
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
    /// Logique d'interaction pour Fight.xaml
    /// </summary>
    public partial class Fight : Page
    {
        private Acceuil acceuil;
        public Fight(Acceuil acceuil)
        {
            InitializeComponent();
            this.acceuil = acceuil;
            showPage();
        }

        public async void showPage()
        {
            await Task.Delay(2000);
            this.NavigationService.Navigate(acceuil);
        }
    }
}
