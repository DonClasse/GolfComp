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

namespace GolfComp
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

        private void BanaSave_Click(object sender, RoutedEventArgs e)
        {
           
            string namn = banaNamnBox.Text;

            bana.BanName.Add(namn);
            

        }

        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            AllBanNamnBox.DataContext = bana.BanName;
        }
    }
}
