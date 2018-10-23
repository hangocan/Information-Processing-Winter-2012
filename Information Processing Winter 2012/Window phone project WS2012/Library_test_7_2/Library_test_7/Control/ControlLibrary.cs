using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Linq;
using Library_test_7.Model;

namespace Library_test_7.Control
{
    public class ControlLibrary : INotifyPropertyChanged
    {
        // LINQ to SQL data context for the local database.
        private LibraryDataContext Library;
        public const string ConnectionString = @"isostore:/Library.sdf";

        // Local Variable
        private bool existImporter          = false;
        private bool existBook              = false;
        private bool existAuthor            = false;
        private bool existEditor            = false;
        private bool existPublisher         = false;
        private bool existBookseller        = false;
        private bool existStoragelocation   = false;
        
        //Class constructor, create the data context object.
        public ControlLibrary(string toDoDBConnectionString)
        {
            Library = new LibraryDataContext(toDoDBConnectionString);
        }
        //Group of functions use to add data to the database
        public void addDataBase(Book Book, Importer Importer, Author Author, Editor Editor, Publisher Publisher, Bookseller Bookseller, Storagelocation Storagelocation, Rack Rack, Book_importer Book_importer, Book_author Book_author, Book_bookseller Book_bookseller)
        {

            //check if Importer exist or not (Assume that Name of a Importer is unique)
            existImporter = false;
            var Importers = (from A in Library.Importers where A.Name == Importer.Name select A).FirstOrDefault();
            if (Importers != null)
            { existImporter = true; }
            else
            {
                Library.Importers.InsertOnSubmit(Importer);
                ImporterItems.Add(Importer);
            }

            //check if Author exist or not (Assume that Forename & Surname of a Author is unique)
            existAuthor = false;
            var Authors = (from A in Library.Authors where ((A.Forename == Author.Forename) && (A.Surname == Author.Surname)) select A).FirstOrDefault();
            if (Authors != null)
            { existAuthor = true; }
            else
            {
                Library.Authors.InsertOnSubmit(Author);
                AuthorItems.Add(Author);
            }

            //check if Editor exist or not (Assume that Forename & Surname of a Publisher is unique)
            existEditor = false;
            var Editors = (from A in Library.Editors where ((A.Forename == Editor.Forename) && (A.Surname == Editor.Surname)) select A).FirstOrDefault();
            if (Editors != null)
            { existEditor = true; }
            else
            {
                Library.Editors.InsertOnSubmit(Editor);
                EditorItems.Add(Editor);
            }

            //check if Publisher exist or not (Assume that Name of a Publisher is unique)
            existPublisher = false;
            var Publishers = (from A in Library.Publishers where A.Name == Publisher.Name select A).FirstOrDefault();
            if (Publishers != null)
            { existPublisher = true; }
            else
            {
                Library.Publishers.InsertOnSubmit(Publisher);
                PublisherItems.Add(Publisher);
            }

            //check if Bookseller exist or not (Assume that Name of a Bookseller is unique)
            existBookseller = false;
            var Booksellers = (from A in Library.Booksellers where A.Name == Bookseller.Name select A).FirstOrDefault();
            if (Booksellers != null)
            { existBookseller = true; }
            else
            {
                Library.Booksellers.InsertOnSubmit(Bookseller);
                BooksellerItems.Add(Bookseller);
            }

            //check if  Storage Location exist or not (Assume that LocationName, Room, Racklable, Shelflable of a Storage Location's Record are unique)
            existStoragelocation = false;
            var Storagelocations = (from A in Library.Storagelocations where ((A.Locationname == Storagelocation.Locationname) && (A.Room == Storagelocation.Room) && (A.Shelflable == Storagelocation.Shelflable) && (A.Racklable == Storagelocation.Racklable)) select A).FirstOrDefault();
            if (Storagelocations != null)
            { existStoragelocation = true; }
            else
            {
                Library.Storagelocations.InsertOnSubmit(Storagelocation);
                StoragelocationItems.Add(Storagelocation);
            }

            //check if Book exist or not (Assume that Title of a Book is unique)
            existBook = false;
            var Books = (from A in Library.Books where A.Title == Book.Title select A).FirstOrDefault();
            if (Books != null)
            { existBook = true; }
            else
            {
                if (existEditor == true)
                { Book.Editor = Editors; }
                else
                { Book.Editor = Editor; }
                if (existPublisher == true)
                { Book.Publisher = Publishers; }
                else
                { Book.Publisher = Publisher; }
                if (existStoragelocation == true)
                { Book.Storagelocation = Storagelocations; }
                else
                { Book.Storagelocation = Storagelocation; }
                Library.Books.InsertOnSubmit(Book);
                BookItems.Add(Book);
            }

            //Dont know how to express this yet 
            var Racks = (from A in Library.Racks where ((A.Storagelocation.Locationname == Storagelocation.Locationname) && (A.Storagelocation.Room == Storagelocation.Room) && (A.Storagelocation.Racklable == Storagelocation.Racklable) && (A.Storagelocation.Racklable == Rack.Racklable)) select A).FirstOrDefault();
            if (Racks == null)
            {
                Rack.Storagelocation = Storagelocation;
                Library.Racks.InsertOnSubmit(Rack);
                RackItems.Add(Rack);
            }
            //adding information into the junction table between Book and Importer
            if ((existImporter == false) || (existBook == false))
            {
                if ((existImporter == false) && (existBook == false))
                {
                    Book_importer.Book = Book;
                    Book_importer.Importer = Importer;
                }
                else
                {
                    if (existBook == true)
                    {
                        Book_importer.Book = Books;
                        Book_importer.Importer = Importer;
                    }
                    else
                    {
                        Book_importer.Book = Book;
                        Book_importer.Importer = Importers;
                    }
                }
                Library.Book_importers.InsertOnSubmit(Book_importer);
                B_IItems.Add(Book_importer);
            }
            else
            {
                // check if relation between Book and Importer exist or not
                var BIs = (from A in Library.Book_importers where ((A.BookID == Books.BookID) && (A.ImporterID == Importers.ImporterID)) select A).FirstOrDefault();
                if (BIs == null)
                {
                    Book_importer.Book = Books;
                    Book_importer.Importer = Importers;
                    Library.Book_importers.InsertOnSubmit(Book_importer);
                    B_IItems.Add(Book_importer);
                }
            }

            //adding information into the junction table between Book and Author
            if ((existAuthor == false) || (existBook == false))
            {
                if ((existAuthor == false) && (existBook == false))
                {
                    Book_author.Book = Book;
                    Book_author.Author = Author;
                }
                else
                {
                    if (existBook == true)
                    {
                        Book_author.Book = Books;
                        Book_author.Author = Author;
                    }
                    else
                    {
                        Book_author.Book = Book;
                        Book_author.Author = Authors;
                    }
                }
                Library.Book_authors.InsertOnSubmit(Book_author);
                B_AItems.Add(Book_author);
            }
            else
            {
                // check if relation between Book and Author exist or not
                var BAs = (from A in Library.Book_authors where ((A.BookID == Books.BookID) && (A.AuthorID == Authors.AuthorID)) select A).FirstOrDefault();
                if (BAs == null)
                {
                    Book_author.Book = Books;
                    Book_author.Author = Authors;
                    Library.Book_authors.InsertOnSubmit(Book_author);
                    B_AItems.Add(Book_author);
                }
            }

            //adding information into the junction table between Book and Bookseller
            if ((existBookseller == false) || (existBook == false))
            {
                if ((existBookseller == false) && (existBook == false))
                {
                    Book_bookseller.Book = Book;
                    Book_bookseller.Bookseller = Bookseller;
                }
                else
                {
                    if (existBook == true)
                    {
                        Book_bookseller.Book = Books;
                        Book_bookseller.Bookseller = Bookseller;
                    }
                    else
                    {
                        Book_bookseller.Book = Book;
                        Book_bookseller.Bookseller = Booksellers;
                    }
                }
                Library.Book_booksellers.InsertOnSubmit(Book_bookseller);
                B_BItems.Add(Book_bookseller);
            }
            else
            {
                // check if relation between Book and Bookseller exist or not
                var BBs = (from A in Library.Book_booksellers where ((A.BookID == Books.BookID) && (A.BooksellerID == Booksellers.BooksellerID)) select A).FirstOrDefault();
                if (BBs == null)
                {
                    Book_bookseller.Book = Books;
                    Book_bookseller.Bookseller = Booksellers;
                    Library.Book_booksellers.InsertOnSubmit(Book_bookseller);
                    B_BItems.Add(Book_bookseller);
                }
            }
            //save changes to Database
            Library.SubmitChanges();
            MessageBox.Show("Success");
            //Save to collections



        }

        public void addReview(Review Review, int BookID, Author Author)
        {
            var Books = (from A in Library.Books where (A.BookID == BookID) select A).FirstOrDefault();
            var Authors = (from A in Library.Authors where ((A.Forename == Author.Forename) && (A.Surname == Author.Surname)) select A).FirstOrDefault();
            if ((Review.Text.Length == 0) || (Author.Surname.Length == 0) || (Author.Forename.Length == 0))
            {
                if (Review.Text.Length == 0)
                {
                MessageBox.Show("The Review text cannot be empty");
                return;
                }
                if (Author.Surname.Length == 0)
                {
                    MessageBox.Show("Surname cannot be empty");
                    return;
                }
                if (Author.Forename.Length == 0)
                {
                    MessageBox.Show("Forename cannot be empty");
                }
            }
            else
            {
                Review.Book = Books;
                if (Authors == null)
                {
                    Library.Authors.InsertOnSubmit(Author);
                    AuthorItems.Add(Author);
                    Review.Author = Author;
                }
                else
                { Review.Author = Authors; }
                Library.Reviews.InsertOnSubmit(Review);
                ReviewItems.Add(Review);
                Library.SubmitChanges();
            }
        }

        public void addBooksellerBranch(int BooksellerID, Booksellerbrach Booksellerbrach)
        {
            var Booksellers = (from A in Library.Booksellers where A.BooksellerID == BooksellerID select A).FirstOrDefault();
            if (Booksellerbrach.Address.Length == 0)
            {
                MessageBox.Show("Address cannot be empty");
                return;
            }
            else
            {
                Booksellerbrach.Bookseller = Booksellers;
                Library.Booksellerbraches.InsertOnSubmit(Booksellerbrach);
                Library.SubmitChanges();
            }
        }

        //Group of function use to edit data in the database
        public void editBook(Book BookToEdit, string BookpreEditname)
        {
            var Books = (from C in Library.Books where C.Title == BookpreEditname select C).FirstOrDefault();
            if (Books != null)
            {
                Books = BookToEdit;
                Library.SubmitChanges();
            }
            else
            {
                MessageBox.Show("Error while editing book");
            }
        }

        public void editImporter(Importer ImporterToEdit, string ImporterpreEditname)
        {
            var Importers = (from A in Library.Importers where A.Name == ImporterpreEditname select A).FirstOrDefault();
            if (Importers != null)
            {
                Importers = ImporterToEdit;
                Library.SubmitChanges();
            }
            else
            {
                MessageBox.Show("Error while editing Importer");
            }
        }

        public void editAuthor (Author AuthorToEdit, string AuthorpreEditsurname, string AuthorpreEditforename)
        {
            var Authors = (from A in Library.Authors where ((A.Surname == AuthorpreEditsurname) && (A.Forename == AuthorpreEditforename)) select A).FirstOrDefault();
            if (Authors != null)
            {
                Authors = AuthorToEdit;
                Library.SubmitChanges();
            }
            else
            {
                MessageBox.Show("Error while editing Author");
            }
        }

        public void editEditor(Editor EditorToEdit, string EditorpreEditsurname, string EditorpreEditforename)
        {
            var Editors = (from A in Library.Editors where ((A.Surname == EditorpreEditsurname) && (A.Forename == EditorpreEditforename)) select A).FirstOrDefault();
            if (Editors != null)
            {
                Editors = EditorToEdit;
                Library.SubmitChanges();
            }
            else
            {
                MessageBox.Show("Error while editing Editor");
            }
        }

        public void editPublisher(Publisher PublisherToEdit, string PublisherpreEditname)
        {
            var Publishers = (from A in Library.Publishers where A.Name == PublisherpreEditname select A).FirstOrDefault();
            if (Publishers != null)
            {
                Publishers = PublisherToEdit;
                Library.SubmitChanges();
            }
            else
            {
                MessageBox.Show("Error while editing Publisher");
            }
        }

        public void editBookseller(Bookseller BooksellerToEdit, string BooksellerpreEditname)
        {
            var Booksellers = (from A in Library.Booksellers where A.Name == BooksellerpreEditname select A).FirstOrDefault();
            if (Booksellers != null)
            {
                Booksellers = BooksellerToEdit;
                Library.SubmitChanges();
            }
            else
            {
                MessageBox.Show("Error while editing Bookseller");
            }
        }

        //Group of function use to querry Data

        public void searchbookbyname(string Name)
        {
            QueryItems.Clear();
            var Books = from A in Library.Books where A.Title == Name select A;
            QueryItems = new ObservableCollection<Book>(Books);
        }

        public void searchbookbygenre(string Genre)
        {
            QueryItems.Clear();
            var Books = from A in Library.Books where A.Genre == Genre select A;
            QueryItems = new ObservableCollection<Book>(Books);
        }

        public void searchbookbyLocationname(string Locationname)
        {
            QueryItems.Clear();
            var Books = from A in Library.Books where A.Storagelocation.Locationname == Locationname select A;
            QueryItems = new ObservableCollection<Book>(Books);
        }

        //Group of function use to lend and retrive book

        public void lendbook(string Title,string Loanedoutto,string conditionwhenloadout)
        {
            var Books = (from A in Library.Books where A.Title == Title select A).FirstOrDefault();
            if (Books == null)
            {
                MessageBox.Show ("Book doesn't exist in Database");
                return;
            }
            else
            {
                var Bookss = (from B in Library.Books where ((B.Title == Title) && (B.Loadedoutto.Length != 0)) select B).FirstOrDefault();
                if (Bookss != null)
                {
                    MessageBox.Show ("Book has already been loaded out");
                }
                else
                {
                    Books.Loadedoutto = Loanedoutto;
                    Books.Loadoutdate = DateTime.Today;
                    Library.SubmitChanges();
                }
            }
        }

        public void retrivebook(string Title)
        {
            var Books = (from A in Library.Books where A.Title == Title select A).FirstOrDefault();
            if (Books == null)
            {
                MessageBox.Show("Book doesn't exist");
                return;
            }
            var Bookss = (from A in Library.Books where ((A.Title == Title)&&(A.Loadedoutto.Length == 0)) select A).FirstOrDefault();
            if (Bookss != null)
            {
                MessageBox.Show("Book has not been loaded out");
            }
            else
            {
                Bookss.Loadedoutto = null;
                Bookss.Loadoutdate = null;
                Bookss.Conditionwhenloadout = null;
                Library.SubmitChanges();
            }
        }

        //others

        public void detailbook(string title)
        {
            ImporterofBookitems = new ObservableCollection<Importer>();
            ImporterofBookitems.Clear();
            ReviewofBookItems = new ObservableCollection<Review>();
            ReviewofBookItems.Clear();
            AuthorofBookItems = new ObservableCollection<Author>();
            AuthorofBookItems.Clear();
            EditorofBookItems = new ObservableCollection<Editor>();
            EditorofBookItems.Clear();
            PublisherofBookItems = new ObservableCollection<Publisher>();
            PublisherofBookItems.Clear();
            BooksellerofBookItems = new ObservableCollection<Bookseller>();
            BooksellerofBookItems.Clear();
            StoragelocationofBookItems = new ObservableCollection<Storagelocation>();
            StoragelocationofBookItems.Clear();

            var Importers = from A in Library.Book_importers where A.Book.Title == title select A;
            foreach (var B in Importers)
            {
                ImporterofBookitems.Add(B.Importer);
            }

            var Reviews = from A in Library.Reviews where A.Book.Title == title select A;
            foreach (var B in Reviews)
            {
                ReviewofBookItems.Add(B);
            }

            var Authors = from A in Library.Book_authors where A.Book.Title == title select A;
            foreach (var B in Authors)
            {
                AuthorofBookItems.Add(B.Author);
            }

            var Editors = from A in Library.Books where A.Title == title select A;
            foreach (var B in Editors)
            {
                EditorofBookItems.Add(B.Editor);
            }

            var Publishers = from A in Library.Books where A.Title == title select A;
            foreach (var B in Publishers)
            {
                PublisherofBookItems.Add(B.Publisher);
            }

            var Booksellers = from A in Library.Book_booksellers where A.Book.Title == title select A;
            foreach (var B in Booksellers)
            {
                BooksellerofBookItems.Add(B.Bookseller);
            }
            var Storagelocations = from A in Library.Books where A.Title == title select A;
            foreach (var B in Storagelocations)
            {
                StoragelocationofBookItems.Add(B.Storagelocation);
            }
        }

        public void LoadCollectionsFromDatabase()
        {
            // Specify the query for all books in the database.
            var Bs = from Book B in Library.Books
                     select B;
            // Specify the query for all author in the database.
            var As = from Author A in Library.Authors
                     select A;
            // Specify the query for all Bok_au in the database.
            var BA = from Book_author x in Library.Book_authors
                     select x;
            var BB = from Book_bookseller x in Library.Book_booksellers
                     select x;
            var BI = from Book_importer x in Library.Book_importers
                     select x;
            var S = from Bookseller s in Library.Booksellers
                    select s;
            var Branch = from Booksellerbrach x in Library.Booksellerbraches
                         select x;
            var E = from Editor e in Library.Editors
                    select e;
            var I = from Importer i in Library.Importers
                    select i;
            var P = from Publisher p in Library.Publishers
                    select p;
            var R = from Rack r in Library.Racks
                    select r;
            var Storage = from Storagelocation s in Library.Storagelocations
                          select s;
            var Rv = from a in Library.Reviews select a;

            // Load Collections
            AuthorItems = new ObservableCollection<Author>(As);

            BookItems = new ObservableCollection<Book>(Bs);

            B_AItems = new ObservableCollection<Book_author>(BA);

            B_BItems = new ObservableCollection<Book_bookseller>(BB);

            B_IItems = new ObservableCollection<Book_importer>(BI);

            BooksellerItems = new ObservableCollection<Bookseller>(S);

            BooksellerbrachItems = new ObservableCollection<Booksellerbrach>(Branch);

            EditorItems = new ObservableCollection<Editor>(E);

            ImporterItems = new ObservableCollection<Importer>(I);

            PublisherItems = new ObservableCollection<Publisher>(P);

            RackItems = new ObservableCollection<Rack>(R);

            StoragelocationItems = new ObservableCollection<Storagelocation>(Storage);

            ReviewItems = new ObservableCollection<Review>(Rv);


        }

        #region Oservate Collections

        //Oservate Collections
        private ObservableCollection<Book> _BookItems;
        public ObservableCollection<Book> BookItems
        {
            get { return _BookItems; }
            set
            {
                _BookItems = value;
                NotifyPropertyChanged("BookItems");
            }
        }

        private ObservableCollection<Author> _AuthorItems;
        public ObservableCollection<Author> AuthorItems
        {
            get { return _AuthorItems; }
            set
            {
                _AuthorItems = value;
                NotifyPropertyChanged("AuthorItems");
            }
        }

        private ObservableCollection<Book_author> _B_A;
        public ObservableCollection<Book_author> B_AItems
        {
            get { return _B_A; }
            set
            {
                _B_A = value;
                NotifyPropertyChanged("B_AItems");
            }
        }

        private ObservableCollection<Book_bookseller> _B_B;
        public ObservableCollection<Book_bookseller> B_BItems
        {
            get { return _B_B; }
            set
            {
                _B_B = value;
                NotifyPropertyChanged("B_BItems");
            }
        }

        private ObservableCollection<Book_importer> _B_I;
        public ObservableCollection<Book_importer> B_IItems
        {
            get { return _B_I; }
            set
            {
                _B_I = value;
                NotifyPropertyChanged("B_IItems");
            }
        }

        private ObservableCollection<Bookseller> _BooksellerItems;
        public ObservableCollection<Bookseller> BooksellerItems
        {
            get { return _BooksellerItems; }
            set
            {
                _BooksellerItems = value;
                NotifyPropertyChanged("BooksellerItems");
            }
        }

        private ObservableCollection<Booksellerbrach> _BooksellerbrachItems;
        public ObservableCollection<Booksellerbrach> BooksellerbrachItems
        {
            get { return _BooksellerbrachItems; }
            set
            {
                _BooksellerbrachItems = value;
                NotifyPropertyChanged("BooksellerbrachItems");
            }
        }

        private ObservableCollection<Editor> _EditorItems;
        public ObservableCollection<Editor> EditorItems
        {
            get { return _EditorItems; }
            set
            {
                _EditorItems = value;
                NotifyPropertyChanged("EditorItems");
            }
        }

        private ObservableCollection<Importer> _ImporterItems;
        public ObservableCollection<Importer> ImporterItems
        {
            get { return _ImporterItems; }
            set
            {
                _ImporterItems = value;
                NotifyPropertyChanged("ImporterItems");
            }
        }

        private ObservableCollection<Publisher> _PublisherItems;
        public ObservableCollection<Publisher> PublisherItems
        {
            get { return _PublisherItems; }
            set
            {
                _PublisherItems = value;
                NotifyPropertyChanged("PublisherItems");
            }
        }

        private ObservableCollection<Rack> _RackItems;
        public ObservableCollection<Rack> RackItems
        {
            get { return _RackItems; }
            set
            {
                _RackItems = value;
                NotifyPropertyChanged("RackItems");
            }
        }

        private ObservableCollection<Storagelocation> _StoragelocationItems;
        public ObservableCollection<Storagelocation> StoragelocationItems
        {
            get { return _StoragelocationItems; }
            set
            {
                _StoragelocationItems = value;
                NotifyPropertyChanged("StoragelocationItems");
            }
        }

        private ObservableCollection<Review> _ReviewItems;
        public ObservableCollection<Review> ReviewItems
        {
            get { return _ReviewItems; }
            set
            {
                _ReviewItems = value;
                NotifyPropertyChanged("ReviewItems");
            }
        }

        private ObservableCollection<Book> _QueryItems;
        public ObservableCollection<Book> QueryItems
        {
            get { return _QueryItems; }
            set
            {
                _QueryItems = value;
                NotifyPropertyChanged("QueryItems");
            }
        }

        private ObservableCollection<Importer> _ImporterofBookitems;
        public ObservableCollection<Importer> ImporterofBookitems
        {
            get { return _ImporterofBookitems; }
            set
            {
                _ImporterofBookitems = value;
                NotifyPropertyChanged("ImporterofBookitems");
            }
        }

        private ObservableCollection<Review> _ReviewofBookItems;
        public ObservableCollection<Review> ReviewofBookItems
        {
            get { return _ReviewofBookItems; }
            set
            {
                _ReviewofBookItems = value;
                NotifyPropertyChanged("ReviewofBookItems");
            }
        }

        private ObservableCollection<Author> _AuthorofBookItems;
        public ObservableCollection<Author> AuthorofBookItems
        {
            get { return _AuthorofBookItems; }
            set
            {
                _AuthorofBookItems = value;
                NotifyPropertyChanged("AuthorofBookItems");
            }
        }

        private ObservableCollection<Editor> _EditorofBookItems;
        public ObservableCollection<Editor> EditorofBookItems
        {
            get { return _EditorofBookItems; }
            set
            {
                _EditorofBookItems = value;
                NotifyPropertyChanged("EditorofBookItems");
            }
        }

        private ObservableCollection<Publisher> _PublisherofBookItems;
        public ObservableCollection<Publisher> PublisherofBookItems
        {
            get { return _PublisherofBookItems; }
            set
            {
                _PublisherofBookItems = value;
                NotifyPropertyChanged("PublisherofBookItems");
            }
        }

        private ObservableCollection<Bookseller> _BooksellerofBookItems;
        public ObservableCollection<Bookseller> BooksellerofBookItems
        {
            get { return _BooksellerofBookItems; }
            set
            {
                _BooksellerofBookItems = value;
                NotifyPropertyChanged("BooksellerofBookItems");
            }
        }

        private ObservableCollection<Booksellerbrach> _BooksellerbrachofBookItems;
        public ObservableCollection<Booksellerbrach> BooksellerbrachofBookItems
        {
            get { return _BooksellerbrachofBookItems; }
            set
            {
                _BooksellerbrachofBookItems = value;
                NotifyPropertyChanged("BooksellerbrachofBookItems");
            }
        }

        private ObservableCollection<Rack> _RackofBookItems;
        public ObservableCollection<Rack> RackofBookItems
        {
            get { return _RackofBookItems; }
            set
            {
                _RackofBookItems = value;
                NotifyPropertyChanged("RackofBookItems");
            }
        }

        private ObservableCollection<Storagelocation> _StoragelocationofBookItems;
        public ObservableCollection<Storagelocation> StoragelocationofBookItems
        {
            get { return _StoragelocationofBookItems; }
            set
            {
                _StoragelocationofBookItems = value;
                NotifyPropertyChanged("StoragelocationofBookItems");
            }
        }

        #endregion

        #region INotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;

        // Used to notify Silverlight that a property has changed.
        private void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        #endregion
    }
}
