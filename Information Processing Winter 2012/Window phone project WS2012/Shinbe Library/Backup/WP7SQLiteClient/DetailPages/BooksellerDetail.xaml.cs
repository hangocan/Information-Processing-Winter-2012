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
    public partial class BooksellerDetail : PhoneApplicationPage
    {
        ObservableCollection<Library> customerEntries = new ObservableCollection<Library>( );

        public BooksellerDetail( )
        {
            InitializeComponent( );

            string strSelect = "SELECT DISTINCT Boname,Boaddress,Boemail,Bohomepage,Bophone,Bonewemail,Bonewordmail,Boassbooks,Boevents,Bospeciality,Bbaddress FROM Library WHERE Boname ='" + getdata.booksellername + "' GROUP BY Boname";
            customerEntries = ( Application.Current as App ).db.SelectObservableCollection<Library>( strSelect );
            Branches.DataContext = customerEntries;
            foreach ( Library data in customerEntries )
            {
                BookSellerNameTextBox.Text += data.Boname;
                BookSellerAdrTextBox.Text += data.Boaddress;
                BookSellerEmailTextBox.Text += data.Boemail;
                BookSellerHomePgTextBox.Text += data.Bohomepage;
                BookSellerPhoneTextBox.Text += data.Bophone;
                AssortmentofbookTextBox.Text += data.Boassbooks;
                bsnewsemailTextBox.Text += data.Bonewemail;
                bsnewsmailTextBox.Text += data.Bonewordmail;
                BookSellerEventTextBox.Text += data.Boevents;
                BooksellerSpecialityTextBox.Text += data.Bospeciality;

            }
        }

        string boname = "";
        string boaddress = "";
        string boemail = "";
        string bohomepage = "";
        string bophone = "";
        string bonewemail = "";
        string bonewordmail = "";
        string boassbooks = "";
        string boevents = "";
        string bospeciality = "";

        private void EditbookButton_Click( object sender , EventArgs e )
        {

            boname = BookSellerNameTextBox.Text;
            boaddress = BookSellerAdrTextBox.Text;
            boemail = BookSellerEmailTextBox.Text;
            bohomepage = BookSellerHomePgTextBox.Text;
            bophone = BookSellerPhoneTextBox.Text;
            boassbooks = AssortmentofbookTextBox.Text;
            bonewemail = bsnewsemailTextBox.Text;
            bonewordmail = bsnewsmailTextBox.Text;
            boevents = BookSellerEventTextBox.Text;
            bospeciality = BooksellerSpecialityTextBox.Text;

            Random rnd = new Random( );
            string strEdit = " UPDATE Library SET  Boname = '" + boname + "' , Boaddress = '" + boaddress + "',Bohomepage = '" + bohomepage + "',Boemail = '" + boemail + "',Bophone = '" + bophone + "',Boevents = '" + boevents + "',Bospeciality = '" + bospeciality + "',Bonewemail = '" + bonewemail + "',Bonewordmail = '" + bonewordmail + "',Boassbooks = '" + boassbooks + "' WHERE Boname='" + getdata.booksellername + "'";
            customerEntries = ( Application.Current as App ).db.SelectObservableCollection<Library>( strEdit );
            MessageBox.Show( "Information Update" );
        }

        private void BackButton_Click( object sender , EventArgs e )
        {
            this.NavigationService.Navigate( new Uri( "/Control/browse.xaml" , UriKind.Relative ) );
        }

        private void branch_Tap( object sender , System.Windows.Input.GestureEventArgs e )
        {
            var branch = Branches.SelectedItem as Library;
            if ( null != branch )
            {
                getdata.branchname = branch.Bbaddress;
                NavigationService.Navigate( new Uri( "/DetailPages/BranchDetail.xaml" , UriKind.RelativeOrAbsolute ) );
            }
        }



    }
}