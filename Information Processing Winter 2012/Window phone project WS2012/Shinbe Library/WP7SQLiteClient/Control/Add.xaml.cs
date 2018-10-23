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
//ObservableCollection

namespace WP7SQLiteClient.Control
{
    public partial class Add : PhoneApplicationPage
    {

        string book = "";
        string gerne = "";
        string author = "";
        string editor = "";
       
        string yearofpublication = "";
        string edition = "";
        string isbn = "";
       
        string purchasedate = "";
        string purchaseprice = "";
        string currentvalue = "";
        string loanedoutto = "";
        string conditionloanout = "";
       
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

        string sllocname = "";
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

        public Add( )
        {
            InitializeComponent( );

        }

        private void addbookButton_Click( object sender , EventArgs e )
        {
            book = BookTitleTextBox.Text;
            gerne = BookGenreTextBox.Text;
            yearofpublication = yearofpublicationTextBox.Text;
            edition = EditionTextBox.Text;
            isbn = ISBNTextBox.Text;
            
            purchaseprice = PPriceTextBox.Text;
           
            currentvalue = CurrentValueTextBox.Text;
            purchasedate = PdateTextBox.Text;

            ausurname = AusurnameTextBox.Text;
            auforename = AuforenameTextBox.Text;
            auhomepage = AuhomepageTextBox.Text;
            auemail = AuemailTextBox.Text;
            aucv = AuCVTextBox.Text;
            author = ( AuforenameTextBox.Text + ' ' + AusurnameTextBox.Text );

            editor = ( EditorForenameTextBox.Text + ' ' + EditorSurnameTextBox.Text );
            edsurname = EditorSurnameTextBox.Text;
            edforename = EditorForenameTextBox.Text;
            edhomepage = EditorHomePageTextBox.Text;
            edemail = EditorEmailTextBox.Text;

            imname = IpNameTextBox.Text;
            imaddress = IpAdrTextBox.Text;
            imhomepage = IpHpTextBox.Text;
            imemail = IpEmailTextBox.Text;

            reauthor = ReauthorTextBox.Text;
            retext = RetextTextBox.Text;
            readdinfo = ReinfoTextBox.Text;

            
            puname = PublisherNameTextBox.Text;
            pulocation = PublisherLocationTextBox.Text;
            pucountry = PublisherCountryTextBox.Text;
            puhomepage = PublisherHomepageTextBox.Text;
            puemail = PublisherEmailTextBox.Text;


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
            
            bbaddress = BranchAdrTextBox.Text;
            bbphone = BranchPhoneTextBox.Text;
            bbhomepage = BranchHomePageTextBox.Text;
            bbemail = BranchEmailTextBox.Text;

            sllocname = LocationNameTextBox.Text;
            sladdress = LocationAdrTextBox.Text;
            slroom = LcRoomTextBox.Text;
            slshelflabel = ShelfLabelTextBox.Text;

            slracklabel = RackLabelTextBox.Text;
            racapacity = RackCapacityTextBox.Text;
            raaddinfo = RackAddInfoTextBox.Text;
            //////////////
            var _customerEntriesauthor = new ObservableCollection<Library>();
            var updateauthor = new ObservableCollection<Library>();

            string strSelectauthor = "SELECT Auemail,Aucv,Auhomepage FROM Library WHERE Auforename = '" + auforename + "' AND Ausurname = '" + ausurname + "'";
            _customerEntriesauthor = (Application.Current as App).db.SelectObservableCollection<Library>(strSelectauthor);



            foreach (Library data in _customerEntriesauthor)
            {
                if (AuemailTextBox.Text == "")
                    auemail += data.Auemail;
                else
                {
                    auemail = AuemailTextBox.Text;
                    string strEdit = " UPDATE Library SET   Auemail='" + auemail + "' WHERE Auforename = '" + auforename + "' AND Ausurname = '" + ausurname + "'";
                    updateauthor = (Application.Current as App).db.SelectObservableCollection<Library>(strEdit);
                }


                if (AuCVTextBox.Text == "")
                { aucv += data.Aucv; }
                else
                {
                    aucv = AuCVTextBox.Text;
                    string strEdit = " UPDATE Library SET   Aucv='" + aucv + "'  WHERE Auforename = '" + auforename + "' AND Ausurname = '" + ausurname + "'";
                    updateauthor = (Application.Current as App).db.SelectObservableCollection<Library>(strEdit);
                }
                if (AuhomepageTextBox.Text == "")
                { auhomepage += data.Auhomepage; }
                else
                {
                    auhomepage = AuhomepageTextBox.Text;
                    string strEdit = " UPDATE Library SET   Auhomepage='" + auhomepage + "'  WHERE Auforename = '" + auforename + "' AND Ausurname = '" + ausurname + "'";
                    updateauthor = (Application.Current as App).db.SelectObservableCollection<Library>(strEdit);
                }
            }
            /////////////
            var _customerEntrieseditor = new ObservableCollection<Library>();
            var updateeditor = new ObservableCollection<Library>();

            string strSelecteditor = "SELECT Edemail,Edhomepage FROM Library WHERE Edforename = '" + edforename + "' AND Edsurname = '" + edsurname + "'";
            _customerEntrieseditor = (Application.Current as App).db.SelectObservableCollection<Library>(strSelecteditor);



            foreach (Library data in _customerEntrieseditor)
            {
                if (EditorEmailTextBox.Text == "")
                    edemail += data.Edemail;
                else
                {
                    edemail = EditorEmailTextBox.Text;
                    string strEdit = " UPDATE Library SET   Edemail='" + edemail + "' WHERE Edforename = '" + edforename + "' AND Edsurname = '" + edsurname + "'";
                    updateeditor = (Application.Current as App).db.SelectObservableCollection<Library>(strEdit);
                }


                if (EditorHomePageTextBox.Text == "")
                { edhomepage += data.Edhomepage; }
                else
                {
                    edhomepage = EditorHomePageTextBox.Text;
                    string strEdit = " UPDATE Library SET   Edhomepage='" + edhomepage + "'  WHERE Edforename = '" + edforename + "' AND Edsurname = '" + edsurname + "'";
                    updateeditor = (Application.Current as App).db.SelectObservableCollection<Library>(strEdit);
                }
            }
            ////////////
            var _customerEntriesimporter = new ObservableCollection<Library>();
            var updateimporter = new ObservableCollection<Library>();

            string strSelectimporter = "SELECT Imemail,Imhomepage,Imaddress FROM Library WHERE Imname = '" + imname + "'";
            _customerEntriesimporter = (Application.Current as App).db.SelectObservableCollection<Library>(strSelectimporter);

            foreach (Library data in _customerEntriesimporter)
            {
                if (IpAdrTextBox.Text == "")
                    imaddress += data.Imaddress;
                else
                {
                    imaddress = IpAdrTextBox.Text;
                    string strEdit = " UPDATE Library SET   Imaddress='" + imaddress + "' WHERE Imname = '" + imname + "'";
                    updateimporter = (Application.Current as App).db.SelectObservableCollection<Library>(strEdit);
                }


                if (IpEmailTextBox.Text == "")
                { imemail += data.Imemail; }
                else
                {
                    imemail = IpEmailTextBox.Text;
                    string strEdit = " UPDATE Library SET   Imemail='" + imemail + "'  WHERE Imname = '" + imname + "'";
                    updateimporter = (Application.Current as App).db.SelectObservableCollection<Library>(strEdit);
                }
                if (IpHpTextBox.Text == "")
                { imhomepage += data.Imhomepage; }
                else
                {
                    imhomepage = IpHpTextBox.Text;
                    string strEdit = " UPDATE Library SET   Imhomepage='" + imhomepage + "'  WHERE Imname = '" + imname + "'";
                    updateimporter = (Application.Current as App).db.SelectObservableCollection<Library>(strEdit);
                }

            }
            ////////////
            var _customerEntriespu = new ObservableCollection<Library>();
            var updatepu = new ObservableCollection<Library>();

            string strSelectpu = "SELECT Puemail,Puhomepage,Pulocation,Pucountry FROM Library WHERE Puname = '" + puname + "'";
            _customerEntriespu = (Application.Current as App).db.SelectObservableCollection<Library>(strSelectpu);

            foreach (Library data in _customerEntriespu)
            {
                if (PublisherLocationTextBox.Text == "")
                    pulocation += data.Pulocation;
                else
                {
                    pulocation = PublisherLocationTextBox.Text;
                    string strEdit = " UPDATE Library SET   Pulocation='" + pulocation + "' WHERE Puname = '" + puname + "'";
                    updatepu = (Application.Current as App).db.SelectObservableCollection<Library>(strEdit);
                }


                if (PublisherCountryTextBox.Text == "")
                { pucountry += data.Pucountry; }
                else
                {
                    pucountry = PublisherCountryTextBox.Text;
                    string strEdit = " UPDATE Library SET   Pucountry='" + pucountry + "'  WHERE Puname = '" + puname + "'";
                    updatepu = (Application.Current as App).db.SelectObservableCollection<Library>(strEdit);
                }
                if (PublisherHomepageTextBox.Text == "")
                { puhomepage += data.Puhomepage; }
                else
                {
                    puhomepage = PublisherHomepageTextBox.Text;
                    string strEdit = " UPDATE Library SET   Puhomepage='" + puhomepage + "'  WHERE Puname = '" + puname + "'";
                    updatepu = (Application.Current as App).db.SelectObservableCollection<Library>(strEdit);
                }
                if (PublisherEmailTextBox.Text == "")
                { puemail += data.Puemail; }
                else
                {
                    puemail = PublisherHomepageTextBox.Text;
                    string strEdit = " UPDATE Library SET   Puemail='" + puemail + "'  WHERE Puname = '" + puname + "'";
                    updatepu = (Application.Current as App).db.SelectObservableCollection<Library>(strEdit);
                }
            }
            ////////////
            var _customerEntriesbo = new ObservableCollection<Library>();
            var updatebo = new ObservableCollection<Library>();

            string strSelectbo = "SELECT Boaddress,Boemail,Bohomepage,Bophone,Bonewemail,Bonewordmail,Boassbooks,Boevents,Bospeciality FROM Library WHERE Boname = '" + boname + "'";
            _customerEntriesbo = (Application.Current as App).db.SelectObservableCollection<Library>(strSelectbo);

            foreach (Library data in _customerEntriesbo)
            {
                if (BookSellerAdrTextBox.Text == "")
                    boaddress += data.Boaddress;
                else
                {
                    boaddress = BookSellerAdrTextBox.Text;
                    string strEdit = " UPDATE Library SET   Boaddress='" + boaddress + "' WHERE Boname = '" + boname + "'";
                    updatebo = (Application.Current as App).db.SelectObservableCollection<Library>(strEdit);
                }


                if (BookSellerEmailTextBox.Text == "")
                { boemail += data.Boemail; }
                else
                {
                    boemail = BookSellerEmailTextBox.Text;
                    string strEdit = " UPDATE Library SET   Boemail='" + boemail + "'  WHERE Boname = '" + boname + "'";
                    updatebo = (Application.Current as App).db.SelectObservableCollection<Library>(strEdit);
                }
                if (BookSellerHomePgTextBox.Text == "")
                { bohomepage += data.Bohomepage; }
                else
                {
                    bohomepage = BookSellerHomePgTextBox.Text;
                    string strEdit = " UPDATE Library SET   Bohomepage ='" + bohomepage + "'  WHERE Boname = '" + boname + "'";
                    updatebo = (Application.Current as App).db.SelectObservableCollection<Library>(strEdit);
                }
                if (BookSellerPhoneTextBox.Text == "")
                { bophone += data.Bophone; }
                else
                {
                    bophone = BookSellerPhoneTextBox.Text;
                    string strEdit = " UPDATE Library SET   Bophone='" + bophone + "'  WHERE Boname = '" + boname + "'";
                    updatebo = (Application.Current as App).db.SelectObservableCollection<Library>(strEdit);
                }
                if (AssortmentofbookTextBox.Text == "")
                { boassbooks += data.Boassbooks; }
                else
                {
                    boassbooks = AssortmentofbookTextBox.Text;
                    string strEdit = " UPDATE Library SET   Boassbooks='" + boassbooks + "'  WHERE Boname = '" + boname + "'";
                    updatebo = (Application.Current as App).db.SelectObservableCollection<Library>(strEdit);
                }
                if (bsnewsemailTextBox.Text == "")
                { bonewemail += data.Bonewemail; }
                else
                {
                    bonewemail = bsnewsemailTextBox.Text;
                    string strEdit = " UPDATE Library SET   bonewemail='" + bonewemail + "'  WHERE Boname = '" + boname + "'";
                    updatebo = (Application.Current as App).db.SelectObservableCollection<Library>(strEdit);
                }
                if (bsnewsmailTextBox.Text == "")
                { bonewordmail += data.Bonewordmail; }
                else
                {
                    bonewordmail = bsnewsmailTextBox.Text;
                    string strEdit = " UPDATE Library SET   Bonewordmail='" + bonewordmail + "'  WHERE Boname = '" + boname + "'";
                    updatebo = (Application.Current as App).db.SelectObservableCollection<Library>(strEdit);
                }
                if (BookSellerEventTextBox.Text == "")
                { boevents += data.Boevents; }
                else
                {
                    boevents = BookSellerEventTextBox.Text;
                    string strEdit = " UPDATE Library SET   Boevents='" + boevents + "'  WHERE Boname = '" + boname + "'";
                    updatebo = (Application.Current as App).db.SelectObservableCollection<Library>(strEdit);
                }
                if (BooksellerSpecialityTextBox.Text == "")
                { bospeciality += data.Bospeciality; }
                else
                {
                    bospeciality = BooksellerSpecialityTextBox.Text;
                    string strEdit = " UPDATE Library SET   Bospeciality ='" + bospeciality + "'  WHERE Boname = '" + boname + "'";
                    updatebo = (Application.Current as App).db.SelectObservableCollection<Library>(strEdit);
                }
            }
            ////////////
            DateTime start = DateTime.Now;
            int rec;
            Random rnd = new Random( );
            string strInsertbook = " INSERT into Library (Book,Gerne,Author,Editor,Yearofpublication,Edition,ISBN,        Purchasedate,Purchaseprice,Currentvalue,Loanedoutto,Conditionloanout,Loanoutdate,Additionalinfo,        Imname,Imaddress,Imhomepage,Imemail,       Reauthor,Retext,Readdinfo,      Ausurname,Auforename,Auhomepage,Auemail,Aucv,       Edsurname,Edforename,Edhomepage,Edemail,        Puname,Pulocation,Pucountry,Puhomepage,Puemail,       Boname,Boaddress,Boemail,Bohomepage,Bophone,Bonewemail,Bonewordmail,Boassbooks,Boevents,Bospeciality,       Bbaddress,Bbphone,Bbhomepage,Bbemail,       Racapacity,Rahumidcontrol,Rahumidity,Rahumidrevalue,Ratemcontrol,Ratemperature,Ratemrefval,Raaddinfo,       Sllocname,Sladdress,Slroom,Slracklabel,Slshelflabel,Slhumidity,Slhumidrefvalue,Slhumidcontrol,Sltemperature,Sltemrefvalue,Sltemcontrol,Slattribute) values (@Book,@Gerne,@Author,@Editor,@Yearofpublication,@Edition,@ISBN,        @Purchasedate,@Purchaseprice,@Currentvalue,@Loanedoutto,@Conditionloanout,@Loanoutdate,@Additionalinfo,        @Imname,@Imaddress,@Imhomepage,@Imemail,       @Reauthor,@Retext,@Readdinfo,      @Ausurname,@Auforename,@Auhomepage,@Auemail,@Aucv,       @Edsurname,@Edforename,@Edhomepage,@Edemail,        @Puname,@Pulocation,@Pucountry,@Puhomepage,@Puemail,       @Boname,@Boaddress,@Boemail,@Bohomepage,@Bophone,@Bonewemail,@Bonewordmail,@Boassbooks,@Boevents,@Bospeciality,       @Bbaddress,@Bbphone,@Bbhomepage,@Bbemail,       @Racapacity,@Rahumidcontrol,@Rahumidity,@Rahumidrevalue,@Ratemcontrol,@Ratemperature,@Ratemrefval,@Raaddinfo,       @Sllocname,@Sladdress,@Slroom,@Slracklabel,@Slshelflabel,@Slhumidity,@Slhumidrefvalue,@Slhumidcontrol,@Sltemperature,@Sltemrefvalue,@Sltemcontrol,@Slattribute )";


            Library tst = new Library
            {
                Book = @book ,
                Gerne = @gerne ,
                Author = @author ,
                Editor = @editor ,
                
                Yearofpublication = @yearofpublication ,
                Edition = @edition ,
                ISBN = @isbn ,
                

                Purchasedate = @purchasedate ,
                Purchaseprice = @purchaseprice ,
                Currentvalue = @currentvalue ,
                Loanedoutto = @loanedoutto ,
                Conditionloanout = @conditionloanout ,
              
                Loanoutdate = @loanoutdate ,
                Additionalinfo = @additionalinfo ,

                Imname = @imname ,
                Imaddress = @imaddress ,
                Imhomepage = @imhomepage ,
                Imemail = @imemail ,

                Reauthor = @reauthor ,
                Retext = @retext ,
                Readdinfo = @readdinfo ,

                Ausurname = @ausurname ,
                Auforename = @auforename ,
                Auhomepage = @auhomepage ,
                Auemail = @auemail ,
                Aucv = @aucv ,

                Edsurname = @edsurname ,
                Edforename = @edforename ,
                Edhomepage = @edhomepage ,
                Edemail = @edemail ,

                Puname = @puname ,
                Pulocation = @pulocation ,
                Pucountry = @pucountry ,
                Puhomepage = @puhomepage ,
                Puemail = @puemail ,

                Boname = @boname ,
                Boaddress = @boaddress ,
                Boemail = @boemail ,
                Bohomepage = @bohomepage ,
                Bophone = @bophone ,
                Bonewemail = @bonewemail ,
                Bonewordmail = @bonewordmail ,
                Boassbooks = @boassbooks ,
                Boevents = @boevents ,
                Bospeciality = @bospeciality ,

                Bbaddress = @bbaddress ,
                Bbphone = @bbphone ,
                Bbhomepage = @bbhomepage ,
                Bbemail = @bbemail ,

                Racapacity = @racapacity ,
                Rahumidcontrol = @rahumidcontrol ,
                Rahumidity = @rahumidity ,
                Rahumidrevalue = @rahumidrevalue ,
                Ratemcontrol = @ratemcontrol ,
                Ratemperature = @ratemperature ,
                Ratemrefval = @ratemrefval ,
                Raaddinfo = @raaddinfo ,

                Sllocname = @sllocname ,
                Sladdress = @sladdress ,
                Slroom = @slroom ,
                Slracklabel = @slracklabel ,
                Slshelflabel = @slshelflabel ,
                Slhumidity = @slhumidity ,
                Slhumidrefvalue = @slhumidrefvalue ,
                Slhumidcontrol = @slhumidcontrol ,
                Sltemperature = @sltemperature ,
                Sltemrefvalue = @sltemrefvalue ,
                Sltemcontrol = @sltemcontrol ,
                Slattribute = @slattribute

            };

            rec = ( Application.Current as App ).db.Insert<Library>( tst , strInsertbook );


            // navigate
            MessageBox.Show( "Information Created" );
        }

        private void BackButton_Click( object sender , EventArgs e )
        {
            this.NavigationService.Navigate( new Uri( "/Control/manage.xaml" , UriKind.Relative ) );
        }

    }




}

