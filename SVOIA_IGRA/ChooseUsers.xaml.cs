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
using System.Windows.Shapes;

namespace SVOIA_IGRA
{
    /// <summary>
    /// Логика взаимодействия для ChooseUsers.xaml
    /// </summary>
    public partial class ChooseUsers : UserControl
    {
        public ChooseUsers()
        {
           InitializeComponent();
        }


        private void Button_Close_Click(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Collapsed;
        }

    }
}
