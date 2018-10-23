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
    public partial class BranchDetail : PhoneApplicationPage
    {
        ObservableCollection<Library> customerEntries = new ObservableCollection<Library>( );

        public BranchDetail( )
        {
            InitializeComponent( );

            string strSelect = "SELECT DISTINCT Bbaddress,Bbphone,Bbhomepage,Bbemail FROM Library WHERE Bbaddress ='" + getdata.branchname + "' GROUP BY Bbaddress";
            customerEntries = ( Application.Current as App ).db.SelectObservableCollection<Library>( strSelect );
            foreach ( Library data in customerEntries )
            {
                AddressText.Text += data.Bbaddress;
                EmailText.Text += data.Bbemail;
                HomepageText.Text += data.Bbhomepage;
                PhoneText.Text += data.Bbphone;
            }
        }
        
        string bbaddress = "";
        string bbphone = "";
        string bbhomepage = "";
        string bbemail = "";
        
        private void EditbookButton_Click( object sender , EventArgs e )
        {
            DateTime start = DateTime.Now;
            Random rnd = new Random( );
            string strEdit = " UPDATE Library SET  Bbaddress = '" + bbaddress + "' , Bbhomepage = '" + bbhomepage + "',Bbemail = '" + bbemail + "',Bbphone = '" + bbphone + "' WHERE Bbaddress='" + getdata.branchname + "'";
            customerEntries = ( Application.Current as App ).db.SelectObservableCollection<Library>( strEdit );

            MessageBox.Show( "Information Updated!" );
        }

        private void BackButton_Click( object sender , EventArgs e )
        {
            this.NavigationService.Navigate( new Uri( "/Control/browse.xaml" , UriKind.Relative ) );
        }

    }
}