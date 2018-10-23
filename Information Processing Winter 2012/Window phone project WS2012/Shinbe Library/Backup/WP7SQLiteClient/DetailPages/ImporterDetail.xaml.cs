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
    public partial class ImporterDetail : PhoneApplicationPage
    {
        ObservableCollection<Library> customerEntries = new ObservableCollection<Library>( );

        public ImporterDetail( )
        {
            InitializeComponent( );

            string strSelect = "SELECT DISTINCT Imname,Imaddress,Imhomepage,Imemail FROM Library WHERE Imname = '" + getdata.importername + "' Group by Imname";
            customerEntries = ( Application.Current as App ).db.SelectObservableCollection<Library>( strSelect );
            foreach ( Library data in customerEntries )
            {
                ImnameTextBox.Text = data.Imname;
                IpAdrTextBox.Text += data.Imaddress;
                IpHpTextBox.Text += data.Imhomepage;
                IpEmailTextBox.Text += data.Imemail;
            }
        }


        string imname = "";
        string imaddress = "";
        string imhomepage = "";
        string imemail = "";


        private void EditbookButton_Click( object sender , EventArgs e )
        {

            imname = ImnameTextBox.Text;
            imaddress = IpAdrTextBox.Text;
            imhomepage = IpHpTextBox.Text;
            imemail = IpEmailTextBox.Text;

            DateTime start = DateTime.Now;
            Random rnd = new Random( );
            string strEdit = " UPDATE Library SET  Imname = '"+ imname + "', Imaddress = '" + imaddress + "',Imhomepage = '" + imhomepage + "',Imemail = '" + imemail + "'  WHERE Imname ='" + getdata.importername + "'";
            customerEntries = ( Application.Current as App ).db.SelectObservableCollection<Library>( strEdit );
            MessageBox.Show( "Information Updated !" );
        }

        private void BackButton_Click( object sender , EventArgs e )
        {
            this.NavigationService.Navigate( new Uri( "/Control/browse.xaml" , UriKind.Relative ) );
        }
    }
}