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


namespace Online_Skak
{
    /// <summary>
    /// Interaction logic for Settings.xaml
    /// </summary>
    public partial class Settings : Page
    {
        Page1 page1;

        public Settings(Page1 test)
        {
            page1 = test;
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

           // Head.Content = new Menu();
            page1.menu.Visibility = Visibility.Visible;
            page1.main.Content = null;
        }
    }
}
