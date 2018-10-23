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
    public partial class Edit : PhoneApplicationPage
    {
        ObservableCollection<Library> customerEntries = null;
        public Edit()
        {
            InitializeComponent();
            //show existed book information
            string strSelect = "SELECT Book,Gerne,Author,Editor,Publisher,Yearofpublication,Edition,ISBN,Review,        Purchasedate,Purchaseprice,Currentvalue,Loanedoutto,Conditionloanout,Location,Loanoutdate,Additionalinfo,        Imname,Imaddress,Imhomepage,Imemail,       Reauthor,Retext,Readdinfo,      Ausurname,Auforename,Auhomepage,Auemail,Aucv,       Edsurname,Edforename,Edhomepage,Edemail,        Puname,Pulocation,Pucountry,Puhomepage,Puemail,       Boname,Boaddress,Boemail,Bohomepage,Bophone,Bonewemail,Bonewordmail,Boassbooks,Boevents,Bospeciality,       Bbaddress,Bbphone,Bbhomepage,Bbemail,       Racapacity,Rahumidcontrol,Rahumidity,Rahumidrevalue,Ratemcontrol,Ratemperature,Ratemrefval,Raaddinfo,       Sllocaname,Sladdress,Slroom,Slracklabel,Slshelflabel,Slhumidity,Slhumidrefvalue,Slhumidcontrol,Sltemperature,Sltemrefvalue,Sltemcontrol,Slattribute) FROM Library ORDER BY ID ASC";
            customerEntries = (Application.Current as App).db.SelectObservableCollection<Library>(strSelect);

             BookTitleTextBox.Text= book ;
             BookGenreTextBox.Text = gerne;
             yearofpublicationTextBox.Text = yearofpublication;
            EditionTextBox.Text = edition;
            ISBNTextBox.Text = isbn;
             PAtTextBox.Text=location;
            purchaseprice = PPriceTextBox.Text = purchaseprice;
            review = ReviewTextBox.Text = review;
            currentvalue = CurrentValueTextBox.Text = currentvalue;

             AusurnameTextBox.Text = ausurname;
           AuforenameTextBox.Text = auforename;
             AuhomepageTextBox.Text = auhomepage;
            AuemailTextBox.Text =auemail;
             AuCVTextBox.Text = aucv;

            EditorSurnameTextBox.Text =edsurname;
         EditorForenameTextBox.Text = edforename;
         EditorHomePageTextBox.Text = edhomepage;
      EditorEmailTextBox.Text = edemail;

          IpNameTextBox.Text = imname;
           IpAdrTextBox.Text = imaddress;
           IpHpTextBox.Text = imhomepage;
         IpEmailTextBox.Text = imemail;
 ReauthorTextBox.Text = reauthor;
          RetextTextBox.Text = retext;

         PublisherNameTextBox.Text = puname;
            PublisherLocationTextBox.Text = pulocation;
            PublisherCountryTextBox.Text = pucountry;
          PublisherHomepageTextBox.Text =puhomepage;
           PublisherEmailTextBox.Text = puemail;

           BookSellerNameTextBox.Text=boname;
             BookSellerAdrTextBox.Text =boaddress;
             BookSellerEmailTextBox.Text =boemail;
             BookSellerHomePgTextBox.Text =bohomepage;
            BookSellerPhoneTextBox.Text =bophone;
            AssortmentofbookTextBox.Text=boassbooks;
          bsnewsemailTextBox.Text=bonewemail;
             bsnewsmailTextBox.Text=bonewordmail;
            BookSellerEventTextBox.Text =boevents;
            BooksellerSpecialityTextBox.Text=bospeciality;
             BranchAdrTextBox.Text=bbaddress;
            BranchPhoneTextBox.Text;
        BranchHomePageTextBox.Text;
            BranchEmailTextBox.Text;

           LocationNameTextBox.Text;
           LocationAdrTextBox.Text;
            LcRoomTextBox.Text;
            ShelfLabelTextBox.Text;

           RackLabelTextBox.Text;
            RackCapacityTextBox.Text;
            RackAddInfoTextBox.Text;

        }

        string id = ""; 
        string book = "";
        string gerne = "";
        string author = "";
        string editor = "";
        string publisher = "";
        string yearofpublication = "";
        string edition = "";
        string isbn = "";
        string review = "";

        string purchasedate = "";
        string purchaseprice = "";
        string currentvalue = ""; 
        string loanedoutto = "";  
        string conditionloanout = ""; 
        string location = ""; 
        string loanoutdate = "";  
        string additionalinfo = "";

        string imname = "";
        string imaddress = "";
        string imhomepage = "";
        string imemail = "";

        string reauthor = "";
        string retext = "";
        string readdinfo = "";

        string ausurname = "";
        string auforename = "";
        string auhomepage = "";
        string auemail = "";
        string aucv = "";

        string edsurname = "";
        string edforename = "";
        string edhomepage = "";
        string edemail = "";

        string puname = "";
        string pulocation = "";
        string pucountry = "";
        string puhomepage = "";
        string puemail = "";

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

        string bbaddress = "";
        string bbphone = "";
        string bbhomepage = "";
        string bbemail = "";

        string racapacity = "";
        string rahumidcontrol = "";
        string rahumidity = "";
        string rahumidrevalue = "";
        string ratemcontrol = "";
        string ratemperature = "";
        string ratemrefval = "";
        string raaddinfo = "";

        string sllocaname = "";
        string sladdress = "";
        string slroom = "";
        string slracklabel = "";
        string slshelflabel = "";
        string slhumidity = "";
        string slhumidrefvalue = "";
        string slhumidcontrol = "";
        string sltemperature = "";
        string sltemrefvalue = "";
        string sltemcontrol = "";
        string slattribute = "";
        
        
            //retrieve dat
          
      
        

        void promptInsert_edit(object sender, PopUpEventArgs<object, PopUpResult> e)
        {
            InitializeComponent();

            //retrieve dat
            string strEdit = " UPDATE Library SET  Author = '" + author + "' , Gerne = '" + gerne + "',Book = '" + book + "' WHERE    ID='" + id + "'";
            customerEntries = (Application.Current as App).db.SelectObservableCollection<Library>(strEdit);
            string strSelect = "SELECT ID,Author,Location,Gerne,Book FROM Library WHERE ID = '" + id + "'";
            customerEntries = (Application.Current as App).db.SelectObservableCollection<Library>(strSelect);
            foreach (Library data in customerEntries)
            {
                TextBlockID.Text += data.ID + Environment.NewLine;
                TextBlockAuthor.Text += data.Author + Environment.NewLine;
                TextBlockBook.Text += data.Book + Environment.NewLine;
                TextBlockLocation.Text += data.Location + Environment.NewLine;
                TextBlockGerne.Text += data.Gerne + Environment.NewLine;
            }
           
        }
        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            // navigate
            this.NavigationService.Navigate(new Uri("/TestDataEditor.xaml", UriKind.Relative));
        }
    }
}