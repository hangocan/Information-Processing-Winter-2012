using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace Library_test_7.Pages
{
    public partial class Author : PhoneApplicationPage
    {
        public Author()
        {
            InitializeComponent();
            this.DataContext = App.ControlModel;
        }

        private void AuthorSelected(object sender, SelectionChangedEventArgs e)
        {
            // If selected index is -1 (no selection) do nothing
            if (AuthorsMainList.SelectedIndex == -1)
                return;

            // Navigate to the new page
            NavigationService.Navigate(new Uri("/Pages/Author_DetailPage2.xaml?selectedItem=" + AuthorsMainList.SelectedIndex, UriKind.Relative));

            // Reset selected index to -1 (no selection)
            AuthorsMainList.SelectedIndex = -1;
        }
    }
}