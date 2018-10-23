using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Library_test_7.Control;
using Library_test_7.Model;
using Library_test_7.Pages;


namespace Library_test_7.Pages
{
    public partial class Book_Detail : PhoneApplicationPage
    {
        public Book_Detail()
        {
            InitializeComponent();
        }

        // When page is navigated to set data context to selected item in list

        public string T;
        public int Y;
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            string selectedIndex = "";
            if (NavigationContext.QueryString.TryGetValue("selectedItem", out selectedIndex))
            {
                Y = int.Parse(selectedIndex);
                DataContext = App.ControlModel.BookItems[Y];
                T = App.ControlModel.BookItems[Y].Title;           
                
                //App.ControlModel.detailbook(T);

                //DataContext = App.ControlModel.AuthorofBookItems[Y];
                
            }
          

        }

        private void GotoAUthor(object sender, RoutedEventArgs e)
        {
            App.ControlModel.detailbook(T);
            DataContext = App.ControlModel.AuthorofBookItems[Y];
            Focus();
        }

        

        
    }
}