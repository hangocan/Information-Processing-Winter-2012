using System;
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
using Coding4Fun.Phone.Controls;
using WP7SQLiteClient.Dal;
using System.Collections.ObjectModel;//ObservableCollection
using System.ComponentModel;
using SQLiteClient;
using Community.CsharpSqlite;
using System.Collections;

namespace WP7SQLiteClient.Control
{
    public partial class manage : PhoneApplicationPage
    {
        public manage()
        {
            InitializeComponent();
        }

        private void Addbook_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("/Control/Add.xaml", UriKind.Relative));
        }

        private void Search_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("/Control/Searchform.xaml", UriKind.Relative));
        }

        private void booklocation_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("/Control/locationsearch.xaml", UriKind.Relative));
        }
        private void BackButton_Click( object sender , EventArgs e )
        {
            this.NavigationService.Navigate( new Uri( "/MainPage.xaml" , UriKind.Relative ) );
        }
        private void loan_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("/Control/Loansearch.xaml", UriKind.Relative));
        }

       
    //LayoutRoot.Background = new SolidColorBrush( Colors.Brown);
        

        
    }
}