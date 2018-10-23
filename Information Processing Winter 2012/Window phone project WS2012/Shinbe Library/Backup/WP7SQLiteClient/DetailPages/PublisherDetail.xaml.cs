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
    public partial class PublisherDetail : PhoneApplicationPage
    {
        ObservableCollection<Library> customerEntries = new ObservableCollection<Library>( );

        public PublisherDetail( )
        {
            InitializeComponent( );

            string strSelect = "SELECT DISTINCT  Puname,Pulocation,Pucountry,Puhomepage,Puemail         FROM Library WHERE Puname = '" + getdata.publishername + "'GROUP BY Puname";
            customerEntries = ( Application.Current as App ).db.SelectObservableCollection<Library>( strSelect );
            foreach ( Library data in customerEntries )
            {
                PuNameTextBox.Text += data.Puname;
                PulocationTextBox.Text += data.Pulocation;
                PucountryTextBox.Text += data.Pucountry;
                PuHomePage.Text += data.Puhomepage;
                PuEmail.Text += data.Puemail;
            }
        }

        string puname ="";
        string pulocation = "";
        string pucountry = "";
        string puhomepage = "";
        string puemail = "";


        private void EditbookButton_Click( object sender , EventArgs e )
        {


            puname = PuNameTextBox.Text;
            pulocation = PulocationTextBox.Text;
            pucountry = PucountryTextBox.Text;
            puhomepage = PuHomePage.Text;
            puemail = PuEmail.Text;

            DateTime start = DateTime.Now;
            Random rnd = new Random( );
            //string strEdit = " UPDATE Library SET Author = '" + author + "' ,Ausurname = '" + ausurname + "',Auforename = '" + auforename + "',Auhomepage = '" + auhomepage + "',Auemail = '" + auemail + "',Aucv = '" + aucv + "' WHERE Author='" + getdata.authorname + "'";
            string strEdit = " UPDATE Library SET Pucountry = '" + pucountry + "' ,Puname = '" + puname + "' , Pulocation = '" + pulocation + "',Puhomepage = '" + puhomepage + "',Puemail = '" + puemail + "'  WHERE Puname= '" + getdata.publishername + "'";
            customerEntries = (Application.Current as App).db.SelectObservableCollection<Library>(strEdit);

            MessageBox.Show("Information Update");
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.NavigationService.Navigate(new Uri("/Control/browse.xaml", UriKind.Relative));
        }


    }
}