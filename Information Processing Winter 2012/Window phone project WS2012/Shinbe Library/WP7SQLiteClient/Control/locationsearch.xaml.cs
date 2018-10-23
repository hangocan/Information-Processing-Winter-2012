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
    public partial class locationsearch : PhoneApplicationPage
    {
        private ObservableCollection<Library> _myList = new ObservableCollection<Library>();
        private ObservableCollection<Library> myList = new ObservableCollection<Library>();
        public locationsearch()
        {
            InitializeComponent();
            string strSelect = "SELECT DISTINCT Book FROM Library ORDER BY ID ASC";
            _myList = (Application.Current as App).db.SelectObservableCollection<Library>(strSelect);
            Booklist.DataContext = _myList;
        }
        private void BackButton_Click( object sender , EventArgs e )
        {
            this.NavigationService.Navigate( new Uri( "/Control/manage.xaml" , UriKind.Relative ) );
        }
        private void Booklist_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            var book = Booklist.SelectedItem as Library;
            if (null != book)
            {
                getdata.booklocation = book.Book;
            }
            string strSelect = "SELECT DISTINCT Book,Sllocname,Sladdress,Slroom,Slracklabel,Slshelflabel FROM Library WHERE Book ='" + getdata.booklocation + "'";
            myList = (Application.Current as App).db.SelectObservableCollection<Library>(strSelect);
            foreach (Library data in myList)
            {
                textBlock1.Text ="In "+ data.Sllocname +Environment.NewLine +"At "+ data.Sladdress+Environment.NewLine+"Room " + data.Slroom +Environment.NewLine+ "Rack " +data.Slracklabel +Environment.NewLine+ "Shelf "+ data.Slshelflabel;
            }
        }
    }
}