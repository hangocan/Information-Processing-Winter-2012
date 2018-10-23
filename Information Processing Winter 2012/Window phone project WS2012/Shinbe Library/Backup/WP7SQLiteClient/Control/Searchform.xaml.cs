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

namespace WP7SQLiteClient.Pages
{
    public partial class Search : PhoneApplicationPage
    {    
     private ObservableCollection<Library> _myList = new ObservableCollection<Library>();

        string gerne = "";
        string author = "";

        string book = "";
        string yearofpublication = "";
        string edition = "";
        string isbn = "";
        string imname = "";
        
        
        string puname = "";
        public Search()
        {
            InitializeComponent();
           
            
        }
        private void searchbookButton_Click(object sender, EventArgs e)
        {
            gerne += BookGenreTextBox.Text;
            yearofpublication += yearofpublicationTextBox.Text;
            edition  += EditionTextBox.Text;
            isbn      += ISBNTextBox.Text;
            imname   += ImnameTextBox.Text;
            author   += AunameTextBox.Text;
            book += BookTextBox.Text;
            puname  += PunameTextBox.Text;
          
           
            if ((BookGenreTextBox.Text == "") && (EditionTextBox.Text == "") && (yearofpublicationTextBox.Text == "") && (ISBNTextBox.Text == "") && (ImnameTextBox.Text == "") && (AunameTextBox.Text == "")  && (PunameTextBox.Text == "") && (BookTextBox.Text==""))
                getdata.result = "";
                
            else
            {
                string strSelect = "SELECT Book FROM Library WHERE Book LIKE '%"+ book +"%' AND Gerne LIKE '%" + gerne + "%' AND Yearofpublication LIKE '%" + yearofpublication + "%' AND  Edition LIKE '%" + edition + "%' AND Author LIKE '%" + author + "%' AND ISBN LIKE '%" + isbn + "%' AND Imname LIKE '%" + imname + "%' AND Puname LIKE '%" + puname + "%' ";
                _myList = (Application.Current as App).db.SelectObservableCollection<Library>(strSelect);
                getdata.result = strSelect.ToString();
                this.NavigationService.Navigate(new Uri("/Control/Searchresult.xaml", UriKind.Relative));

            }

            
        }
        private void backButton_Click(object sender, EventArgs e)
        {
            this.NavigationService.Navigate(new Uri("/Control/manage.xaml", UriKind.Relative));
        }
       
    }
}