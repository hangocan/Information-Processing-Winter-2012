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
    public partial class browse : PhoneApplicationPage
    {
        private ObservableCollection<Library> _myList = new ObservableCollection<Library>();
       
        public browse()
        {
            InitializeComponent();
            string strSelect = "SELECT DISTINCT Book,Author,Editor,Puname,Imname,Boname,Slroom FROM Library ORDER BY ID ASC ";
           _myList = (Application.Current as App).db.SelectObservableCollection<Library>(strSelect);
            Book.DataContext = _myList;

            strSelect = "SELECT DISTINCT Author FROM Library WHERE Author != ' '  ORDER BY ID ASC ";
            _myList = (Application.Current as App).db.SelectObservableCollection<Library>(strSelect);
           Author.DataContext = _myList;

           strSelect = "SELECT DISTINCT Imname FROM Library ORDER BY ID ASC ";
           _myList = (Application.Current as App).db.SelectObservableCollection<Library>(strSelect);
           Importer.DataContext = _myList;

           strSelect = "SELECT DISTINCT Editor FROM Library  WHERE Editor !=' '  ORDER BY ID ASC";
           _myList = (Application.Current as App).db.SelectObservableCollection<Library>(strSelect);
           Editor.DataContext = _myList;

           strSelect = "SELECT DISTINCT Puname FROM Library ORDER BY ID ASC ";
           _myList = (Application.Current as App).db.SelectObservableCollection<Library>(strSelect);
           Publisher.DataContext = _myList;

           strSelect = "SELECT DISTINCT Boname FROM Library ORDER BY ID ASC ";
           _myList = (Application.Current as App).db.SelectObservableCollection<Library>(strSelect);
           Bookseller.DataContext = _myList;

           strSelect = "SELECT DISTINCT Sllocname, Slroom, Sladdress  FROM Library ORDER BY ID ASC ";
           _myList = (Application.Current as App).db.SelectObservableCollection<Library>(strSelect);
           Storagelocation.DataContext = _myList;

        }

        private void book_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            var book = Book.SelectedItem as Library;
            if (null != book)
            {
                getdata.bookname = book.Book;
                NavigationService.Navigate(new Uri("/DetailPages/BookDetail.xaml", UriKind.RelativeOrAbsolute));
            }
            
        }

        private void editor_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            var editor = Editor.SelectedItem as Library;
            if (null != editor)
            {
                getdata.editorname = editor.Editor;
                NavigationService.Navigate(new Uri("/DetailPages/EditorDetail.xaml", UriKind.RelativeOrAbsolute));
            }
        }

        private void author_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
           var author = Author.SelectedItem as Library;
            if (null != author)
            {
                 getdata.authorname = author.Author ;
                NavigationService.Navigate(new Uri("/DetailPages/AuthorDetail.xaml", UriKind.RelativeOrAbsolute));
            }
        }

        private void importer_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            var importer = Importer.SelectedItem as Library;
            if (null != importer)
            {
                getdata.importername = importer.Imname;
                NavigationService.Navigate(new Uri("/DetailPages/ImporterDetail.xaml", UriKind.RelativeOrAbsolute));
            }
        }

        private void publisher_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            var publisher = Publisher.SelectedItem as Library;
            if (null != publisher)
            {
                getdata.publishername = publisher.Puname;
                NavigationService.Navigate(new Uri("/DetailPages/PublisherDetail.xaml", UriKind.RelativeOrAbsolute));
            }
        }

        private void bookseller_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            var bookseller = Bookseller.SelectedItem as Library;
            if (null != bookseller)
            {
                getdata.booksellername = bookseller.Boname;
                NavigationService.Navigate(new Uri("/DetailPages/BooksellerDetail.xaml", UriKind.RelativeOrAbsolute));
            }
        }

        private void storage_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            var storage = Storagelocation.SelectedItem as Library;
            if (null != storage)
            {
                getdata.storagename = storage.Sllocname;
                NavigationService.Navigate(new Uri("/DetailPages/StorageDetail.xaml", UriKind.RelativeOrAbsolute));
            }
        }

        private void BackButton_Click( object sender , EventArgs e )
        {
            this.NavigationService.Navigate( new Uri( "/MainPage.xaml" , UriKind.Relative ) );
        }

        private void searchButton_Click_1( object sender , EventArgs e )
        { 
            this.NavigationService.Navigate( new Uri( "/Control/Searchform.xaml" , UriKind.Relative ) );
        }
       }
     }
    

  
