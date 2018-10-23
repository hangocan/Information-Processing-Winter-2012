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
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Text;
using System.Diagnostics;
using Library_test_7.Model;
using Library_test_7.Control;
namespace Library_test_7
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }

        /*private IList<Book> GetBok()
        {
            IList<Book> BookList = null;
            using (LibraryDataContext context = new LibraryDataContext(ControlLibrary.ConnectionString))
            {
                IQueryable<Book> query = from c in context.Books select c;
                BookList = query.ToList();
            }

            return BookList;
        }

        private IList<Author> GetAu()
        {
            IList<Author> AuthorList = null;
            using (LibraryDataContext context = new LibraryDataContext(ControlLibrary.ConnectionString))
            {
                IQueryable<Author> query = from c in context.Authors select c;
                AuthorList = query.ToList();
            }

            return AuthorList;
        }*/

        private void AddBookButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Add_PivotPage1.xaml", UriKind.Relative));
        }

        private void ShowBookButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Pages/Page1.xaml", UriKind.Relative));
        }

        private void BA_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Pages/BA.xaml", UriKind.Relative));
        }

        private void BB_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Pages/BB.xaml", UriKind.Relative));
        }

        private void BI_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Pages/BI.xaml", UriKind.Relative));
        }

        private void Author_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Pages/Author.xaml", UriKind.Relative));
        }

        private void Editor_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Pages/Editor.xaml", UriKind.Relative));
        }

        private void Importer_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Pages/Importer.xaml", UriKind.Relative));
        }

        private void Publisher_Click_1(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Pages/Publisher.xaml", UriKind.Relative));
        }

        private void Rack_Click_1(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Pages/Rack.xaml", UriKind.Relative));
        }

        private void Storeage_Click_1(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Pages/StorageLocation.xaml", UriKind.Relative));
        }
    }
}