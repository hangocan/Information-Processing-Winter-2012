using Microsoft.Phone.Controls;
using System;
using System.Collections.ObjectModel;//ObservableCollection
using System.Windows;
using WP7SQLiteClient.Dal;

namespace WP7SQLiteClient.Control
{
    public partial class BookDetail : PhoneApplicationPage
    {
        ObservableCollection<Library> customerEntries = new ObservableCollection<Library>( );

        public BookDetail( )
        {
            InitializeComponent( );
            string strSelect = "SELECT DISTINCT Imname,Boname,Book,Gerne,Author,Editor,Puname,Yearofpublication,Edition,ISBN,Reauthor,Purchasedate,Purchaseprice,Currentvalue,Loanedoutto,Conditionloanout,Loanoutdate,Additionalinfo     FROM Library WHERE Book ='" + getdata.bookname + "'";
            customerEntries = ( Application.Current as App ).db.SelectObservableCollection<Library>( strSelect );

            foreach ( Library data in customerEntries )
            {
                Bookseller.Text += data.Boname;
                Importer.Text += data.Imname;
                Bookname.Text += data.Book;
                Genre.Text += data.Gerne;
                Author.Text += data.Author;
                Editor.Text += data.Editor;
                Edition.Text += data.Edition;
                Publisher.Text += data.Puname;
                Publishedyear.Text += data.Yearofpublication;
                ISBN.Text += data.ISBN ;
                Review.Text += data.Reauthor;
                Purchasedat.Text += data.Purchasedate;
                Purchaseprice.Text += data.Purchaseprice;
                Currentvalue.Text += data.Currentvalue;
                Loanedouto.Text += data.Loanedoutto;
                Loanedoudate.Text += data.Loanoutdate;
                Condition.Text += data.Conditionloanout;
                Addiinfo.Text += data.Additionalinfo;
            }
        }
        string book = "";
        string gerne = "";
        string author = "";
        string editor = "";
        string puname = "";
        string yearofpublication = "";
        string edition = "";
        string isbn = "";
        string reauthor = "";
        string purchasedate = "";
        string purchaseprice = "";
        string currentvalue = "";
        string loanedoutto = "";
        string conditionloanout = "";
        string loanoutdate = "";
        string additionalinfo = "";
        string imname ="";
        string boname = "";

        private void EditbookButton_Click( object sender , EventArgs e )
        {

            book = Bookname.Text;
            gerne = Genre.Text;
            author = Author.Text;
            editor = Editor.Text;
            edition = Edition.Text;
            puname = Publisher.Text;
            yearofpublication = Publishedyear.Text;
            isbn = ISBN.Text;
            reauthor = Review.Text;
            purchasedate = Purchasedat.Text;
            purchaseprice = Purchaseprice.Text;
            currentvalue = Currentvalue.Text;
            loanedoutto = Loanedouto.Text;
            loanoutdate = Loanedoudate.Text;
            conditionloanout = Condition.Text;
            additionalinfo = Addiinfo.Text;
            imname = Importer.Text;
            boname = Bookseller.Text;
            
            Random rnd = new Random( );
            string strEdit = " UPDATE Library SET Additionalinfo='" + additionalinfo + "', Book='" + book + "',Conditionloanout='" + conditionloanout + "',Loanoutdate='" + loanoutdate + "',Puname='" + puname + "',Loanedoutto='" + loanedoutto + "',Currentvalue='" + currentvalue + "',Purchasedate='" + purchasedate + "',Purchaseprice='" + purchaseprice + "', Reauthor='" + reauthor + "', ISBN='" + isbn + "', Yearofpublication = '" + yearofpublication + "' , Gerne = '" + gerne + "',Author = '" + author + "',Editor = '" + editor + "',Imname = '" + imname + "',Boname = '" + boname + "',Edition = '" + edition + "' WHERE Book='" + getdata.bookname + "'";
            customerEntries = ( Application.Current as App ).db.SelectObservableCollection<Library>( strEdit );

            MessageBox.Show( " Information Update ! " );
        }
        private void BackButton_Click( object sender , EventArgs e )
        {
            this.NavigationService.Navigate( new Uri( "/Control/browse.xaml" , UriKind.Relative ) );
        }

         private void Author_Tap( object sender , System.Windows.Input.GestureEventArgs e )
        {
            
                getdata.authorname = Author.Text;
                NavigationService.Navigate( new Uri( "/DetailPages/AuthorDetail.xaml" , UriKind.RelativeOrAbsolute ) );
            
        }

        private void Review_Tap_1( object sender , System.Windows.Input.GestureEventArgs e )
        {
            getdata.reviewname = Review.Text;
            NavigationService.Navigate( new Uri( "/DetailPages/ReviewDetail.xaml" , UriKind.RelativeOrAbsolute ) );
            
        }

        private void Publisher_Tap_1( object sender , System.Windows.Input.GestureEventArgs e )
        {
            getdata.publishername = Publisher.Text;
            NavigationService.Navigate( new Uri( "/DetailPages/PublisherDetail.xaml" , UriKind.RelativeOrAbsolute ) );
            
        }

        private void Editor_Tap_1( object sender , System.Windows.Input.GestureEventArgs e )
        {
            getdata.editorname = Editor.Text;
            NavigationService.Navigate( new Uri( "/DetailPages/EditorDetail.xaml" , UriKind.RelativeOrAbsolute ) );
            
        }



        private void Importer_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            getdata.importername = Importer.Text;
            NavigationService.Navigate(new Uri("/DetailPages/ImporterDetail.xaml", UriKind.RelativeOrAbsolute));
        }

        private void Bookseller_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            getdata.booksellername = Bookseller.Text;
            NavigationService.Navigate(new Uri("/DetailPages/BooksellerDetail.xaml", UriKind.RelativeOrAbsolute));
        }

      

    }
}