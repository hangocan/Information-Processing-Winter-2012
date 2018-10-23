﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

namespace WP7SQLiteClient
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }

        private void browse_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Control/browse.xaml", UriKind.Relative));

        }

        private void manage_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Control/manage.xaml", UriKind.Relative));

        }

    }
}