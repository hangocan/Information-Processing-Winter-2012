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
using System.Text;
using Library_test_7.Control;
using Library_test_7.Model;

namespace Library_test_7
{
    public partial class Add_Page : PhoneApplicationPage
    {
        public Add_Page()
        {
            InitializeComponent();
        }

            private void add_Click(object sender, RoutedEventArgs e)
            {
                if(BookTitleTextBox.Text.Length >0
                    && SurnameTextBox.Text.Length > 0
                    && ForenameTextBox.Text.Length > 0
                    && EditorForenameTextBox.Text.Length > 0
                    && EditorSurnameTextBox.Text.Length > 0
                    && PublisherNameTextBox.Text.Length > 0
                    && BookSellerNameTextBox.Text.Length > 0
                    && BranchAdrTextBox.Text.Length > 0
                    && LocationAdrTextBox.Text.Length > 0
                    )
                {
                    Book nBook = new Book { 
                        Title = BookTitleTextBox.Text , 
                        Genre = BookGenreTextBox.Text,
                        Yearofpublication = BookYoPTextBox.Text,
                        Edition = EditionTextBox.Text,
                        ISBN = ISBNTextBox.Text,
                        /*Loadedoutto = LoanedOutToTextBox.Text,
                        Currentvalue = CurrentValueTextBox.Text,
                        Conditionwhenloadout = LoanConditionTextBox.Text,
                        Additionalinfo1 = addInfoTextBox.Text,
                        Purchaseprice = PPriceTextBox.Text,*/

                        };
                    Author nAuthor = new Author {
                        Surname = SurnameTextBox.Text,
                        Forename = ForenameTextBox.Text,
                        Homepage = AuthorHomePgTextBox.Text,
                        Email=AuthorEmailTextBox.Text,
                        Cv=AuthorCVTextBox.Text,
                        };
                    Bookseller nBSeller = new Bookseller {
                        Name = BookSellerNameTextBox.Text,
                        Address = BookSellerAdrTextBox.Text,
                        Email = BookSellerEmailTextBox.Text,
                        Homepage= BookSellerHomePgTextBox.Text,
                        Phone = BookSellerPhoneTextBox.Text,
                        Newletterbymail= NewletterbyMailCheckBox.IsChecked,
                        Newletterbyemail= NewletterbyEmailCheckBox.IsChecked,
                        Assortmentofbook= AssortmentofbookTextBox.Text,
                        Event= BookSellerEventTextBox.Text,
                        Speciality= BookSellerSpecialityTextBox.Text,

                        };
                    Booksellerbrach nBranch = new Booksellerbrach{
                        Address = BranchAdrTextBox.Text,
                        Phone = BranchPhoneTextBox.Text,
                        Homepage = BranchHomePageTextBox.Text,
                        Email = BranchEmailTextBox.Text,

                        };
                    Editor nEditor = new Editor {
                        Surname = EditorSurnameTextBox.Text,
                        Forename = EditorForenameTextBox.Text,
                        Homepage = EditorHomePageTextBox.Text,
                        Email = EditorEmailTextBox.Text,
                    };
                    Importer nImporter = new Importer {
                        Name = IpNameTextBox.Text,
                        Address = IpAdrTextBox.Text,
                        Homepage = IpHpTextBox.Text,
                        Email = IpEmailTextBox.Text,

                        };
                    Publisher nPublisher = new Publisher {
                        Name = PublisherNameTextBox.Text,
                        Location = PublisherLocationTextBox.Text,
                        Country = PublisherCountryTextBox.Text,
                        Homepage = PublisherHomepageTextBox.Text,
                        Email = PublisherEmailTextBox.Text,

                    };
                    Rack nRack = new Rack {
                        Racklable = RackLabelTextBox.Text,
                        Capacity = RackCapacityTextBox.Text,
                        Additionalinfo1 = RackAddInfoTextBox.Text,
                   
                    };

                    Storagelocation nStorage = new Storagelocation {
                        Locationname = LocationNameTextBox.Text,
                        Address = LocationAdrTextBox.Text,
                        Room = LcRoomTextBox.Text,
                        Shelflable = ShelfLabelTextBox.Text,
                        Racklable = RackLabelTextBox.Text,
                                      
                    };
                    Book_importer nBI = new Book_importer { };
                    Book_author nBA = new Book_author { };
                    Book_bookseller nBB = new Book_bookseller { };

                    App.ControlModel.addDataBase(nBook, nImporter, nAuthor, nEditor, nPublisher,nBSeller,nStorage,nRack, nBI, nBA, nBB);
                }
            
            
                if (NavigationService.CanGoBack)
                    {
                        NavigationService.GoBack();
                    }
        
            }


    }
}