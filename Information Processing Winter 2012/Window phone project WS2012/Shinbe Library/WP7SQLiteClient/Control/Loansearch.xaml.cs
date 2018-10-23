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
    public partial class Loansearch : PhoneApplicationPage
    {
        private ObservableCollection<Library> myList = new ObservableCollection<Library>( );

        public Loansearch( )
        {

            InitializeComponent( );
            string strSelect = "SELECT Book FROM Library WHERE Loanedoutto ='' OR Loanedoutto IS NULL ORDER BY ID ASC ";
            myList = ( Application.Current as App ).db.SelectObservableCollection<Library>( strSelect );
            Bookforloan.DataContext = myList;


        }
        private void BackButton_Click( object sender , EventArgs e )
        {
            this.NavigationService.Navigate( new Uri( "/Control/manage.xaml" , UriKind.Relative ) );
        }

        private void Booklist_Tap( object sender , System.Windows.Input.GestureEventArgs e )
        {
            var book = Bookforloan.SelectedItem as Library;
            if ( null != book )
            {
                getdata.bookname = book.Book;
                NavigationService.Navigate( new Uri( "/DetailPages/BookDetail.xaml" , UriKind.RelativeOrAbsolute ) );
            }


        }
    }
}