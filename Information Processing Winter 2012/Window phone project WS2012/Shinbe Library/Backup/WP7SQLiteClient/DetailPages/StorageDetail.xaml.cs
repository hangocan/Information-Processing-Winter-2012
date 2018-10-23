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
    public partial class StorageDetail : PhoneApplicationPage
    {
        ObservableCollection<Library> customerEntries = null;
        public StorageDetail( )
        {
            InitializeComponent( );
            //////////////////////////////////////////////////
            ObservableCollection<Library> customerEntries = null;
            string locationSelect = "SELECT  Sllocname,Sladdress,Slhumidity,Slhumidrefvalue,Slhumidcontrol,Sltemperature,Sltemrefvalue,Sltemcontrol,Slattribute  FROM Library WHERE Sllocname ='" + getdata.storagename + "'";
            customerEntries = ( Application.Current as App ).db.SelectObservableCollection<Library>( locationSelect );

            foreach ( Library data in customerEntries )
            {
                StorageNameTextBox.Text += data.Sllocname;
                StorageAddressTextBox.Text += data.Sladdress;
                StorageHumidityTextBox.Text += data.Slhumidity;
                StorageHumidityRefTextBox.Text += data.Slhumidrefvalue;
                StorageTemperatureTextBox.Text += data.Sltemperature;
                StorageTemperRefTextBox.Text += data.Sltemrefvalue;
            }
            //////////////////////////////////////////////
            ObservableCollection<Library> customerEntries1 = null;
            string roomSelect = "SELECT DISTINCT Sllocname,Slroom FROM Library WHERE Sllocname ='" + getdata.storagename + "'";
            customerEntries1 = ( Application.Current as App ).db.SelectObservableCollection<Library>( roomSelect );
            RoomList.DataContext = customerEntries1;
            ///////////////////////////////////////////////
          
            ///////////////////////////////////////////////
           
        }  

        string sllocname = "";
        string sladdress = "";

        string slhumidity = "";
        string slhumidrefvalue = "";

        string sltemperature = "";
        string sltemrefvalue = "";




        private void EditButton_Click( object sender , EventArgs e )
        {
            sllocname = StorageNameTextBox.Text;
            sladdress = StorageAddressTextBox.Text;
            slhumidity = StorageHumidityTextBox.Text;
            slhumidrefvalue = StorageHumidityRefTextBox.Text;
            sltemperature = StorageTemperatureTextBox.Text;
            sltemrefvalue = StorageTemperRefTextBox.Text;

            Random rnd = new Random( );
            string strEdit = " UPDATE Library SET  Sllocname = '" + sllocname + "' , Sladdress = '" + sladdress + "',Slhumidity = '" + slhumidity + "',Slhumidrefvalue = '" + slhumidrefvalue + "', Sltemperature = '" + sltemperature + "',Sltemrefvalue = '" + sltemrefvalue + "' WHERE Sllocname ='" + getdata.storagename + "'";
            customerEntries = ( Application.Current as App ).db.SelectObservableCollection<Library>( strEdit );

            MessageBox.Show( "Information Updated !" );
        }
      
        private void BackButton_Click( object sender , EventArgs e )
        {
            this.NavigationService.Navigate( new Uri( "/Control/browse.xaml" , UriKind.Relative ) );
        }
        
        private void RoomList_Tap( object sender , System.Windows.Input.GestureEventArgs e )
        {
            var room = RoomList.SelectedItem as Library;
            if ( null != room )
            {
                getdata.roomlocation = room.Slroom;
            }
            ObservableCollection<Library> customerEntries2 = null;
            string shelfSelect = "SELECT DISTINCT Slroom,Slracklabel,Slshelflabel FROM Library WHERE Slroom ='" + getdata.roomlocation + "'";
            customerEntries2 = (Application.Current as App).db.SelectObservableCollection<Library>(shelfSelect);
            ShelfList.DataContext = customerEntries2;
        }

     
        private void ShelfList_Tap( object sender , System.Windows.Input.GestureEventArgs e )
        {
            var shelf = ShelfList.SelectedItem as Library;
            if ( null != shelf )
            {
                getdata.shelflocation = shelf.Slshelflabel;
            }
            ObservableCollection<Library> customerEntries3 = null;
            string rackSelect = "SELECT DISTINCT Slracklabel,Slshelflabel,Racapacity,Rahumidcontrol,Rahumidity,Rahumidrevalue,Ratemcontrol,Ratemperature,Ratemrefval,Raaddinfo FROM Library WHERE Slshelflabel ='" + getdata.shelflocation + "'";
            customerEntries3 = (Application.Current as App).db.SelectObservableCollection<Library>(rackSelect);
            foreach (Library data in customerEntries3)
            {
                Raname.Text += data.Slracklabel;
                Rahumidity.Text += data.Rahumidity;
                Rahumidrevalue.Text += data.Rahumidrevalue;
                RaTemperature.Text += data.Ratemperature;
                Ratemrefval.Text += data.Ratemrefval;

            }
        }
    }
}