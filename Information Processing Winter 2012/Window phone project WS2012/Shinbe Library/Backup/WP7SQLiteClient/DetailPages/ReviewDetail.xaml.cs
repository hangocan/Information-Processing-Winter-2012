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

namespace WP7SQLiteClient.DetailPages
{
    public partial class ReviewDetail : PhoneApplicationPage
    {
        ObservableCollection<Library> customerEntries = new ObservableCollection<Library>( );
        public ReviewDetail( )
        {
            InitializeComponent( );
            string strSelect = "SELECT DISTINCT  Reauthor,Retext,Readdinfo          FROM Library WHERE Reauthor ='" + getdata.reviewname + "'";
            customerEntries = ( Application.Current as App ).db.SelectObservableCollection<Library>( strSelect );
            foreach ( Library data in customerEntries )
            {
               
                Retext.Text += data.Retext;
                Reauthor.Text += data.Reauthor;
                Readdinfo.Text += data.Readdinfo;
            }
        }

        
        string reauthor = "";
        string retext = "";
        string readdinfo = "";



        private void BackButton_Click( object sender , EventArgs e )
        {
            this.NavigationService.Navigate( new Uri( "/Control/browse.xaml" , UriKind.Relative ) );
        }

        private void EditbookButton_Click( object sender , EventArgs e )
        {
            reauthor = Reauthor.Text;
            retext = Retext.Text;
            readdinfo = Readdinfo.Text;

            Random rnd = new Random( );
            string strEdit = " UPDATE Library SET  Reauthor = '" + reauthor + "',Retext = '" + retext + "',Readdinfo = '" + readdinfo + "'  WHERE Reauthor='" + getdata.reviewname + "'";
            customerEntries = ( Application.Current as App ).db.SelectObservableCollection<Library>( strEdit );

            MessageBox.Show( "Information Updated !" );
        }
    }
}