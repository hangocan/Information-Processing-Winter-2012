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

namespace WP7SQLiteClient.DetaiPages
{
    public partial class EditorDetail : PhoneApplicationPage
    {
        ObservableCollection<Library> customerEntries = new ObservableCollection<Library>( );

        public EditorDetail( )
        {
            InitializeComponent( );

            string strSelect = "SELECT DISTINCT Editor, Edsurname,Edforename,Edhomepage,Edemail  FROM Library WHERE Editor ='" + getdata.editorname + "' GROUP BY Editor";
            customerEntries = ( Application.Current as App ).db.SelectObservableCollection<Library>( strSelect );
            foreach ( Library data in customerEntries )
            {
                EditorSurnameTextBox.Text += data.Edsurname;
                EditorForenameTextBox.Text += data.Edforename;
                EditorHomePageTextBox.Text += data.Edhomepage;
                EditorEmailTextBox.Text += data.Edemail;
            }
        }

        string editor = "";
        string edsurname = "";
        string edforename = "";
        string edhomepage = "";
        string edemail = "";


        private void EditbookButton_Click( object sender , EventArgs e )
        {
            edsurname = EditorSurnameTextBox.Text;
            edforename = EditorForenameTextBox.Text;
            edhomepage = EditorHomePageTextBox.Text;
            edemail = EditorEmailTextBox.Text;
            editor = ( EditorForenameTextBox.Text + ' ' + EditorSurnameTextBox.Text );


            Random rnd = new Random( );
            string strEdit = " UPDATE Library SET  Edemail = '" + edemail + "' , Editor = '" + editor + "' , Edhomepage = '" + edhomepage + "',Edsurname = '" + edsurname + "',Edforename = '" + edforename + "' WHERE Editor='" + getdata.editorname + "'";
            customerEntries = ( Application.Current as App ).db.SelectObservableCollection<Library>( strEdit );
            MessageBox.Show( "Information Update" );
        }

        private void BackButton_Click( object sender , EventArgs e )
        {
            this.NavigationService.Navigate( new Uri( "/Control/browse.xaml" , UriKind.Relative ) );
        }

    }
}