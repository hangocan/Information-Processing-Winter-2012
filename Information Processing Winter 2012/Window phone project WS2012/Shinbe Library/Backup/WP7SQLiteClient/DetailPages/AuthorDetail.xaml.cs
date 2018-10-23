using Microsoft.Phone.Controls;
using System;
using System.Collections.ObjectModel;//ObservableCollection
using System.Windows;
using WP7SQLiteClient.Dal;

namespace WP7SQLiteClient.Control
{
    public partial class AuthorDetail : PhoneApplicationPage
    {   ObservableCollection<Library> customerEntries = new ObservableCollection<Library>();

        public AuthorDetail()
        {   InitializeComponent();

        string strSelect = "SELECT  Ausurname,Auforename,Auhomepage,Auemail,Aucv FROM Library WHERE Author ='" + getdata.authorname + "' Group by Author";
            customerEntries = (Application.Current as App).db.SelectObservableCollection<Library>(strSelect);
          
            
            foreach (Library data in customerEntries)
            {
                AusurnameTextBox.Text += data.Ausurname;
                AuforenameTextBox.Text += data.Auforename;
                AuemailTextBox.Text += data.Auemail;
                AucvTextBox.Text += data.Aucv;
                AuhomepageTextBox.Text += data.Auhomepage;
                
            }
            string sSelect = "SELECT DISTINCT Book FROM Library WHERE Author ='" + getdata.authorname + "' ";
            customerEntries = (Application.Current as App).db.SelectObservableCollection<Library>(sSelect);
            foreach (Library data in customerEntries)
            {
                booklistTextBox.Text += data.Book + Environment.NewLine;
            
            }
        }
        
            string ausurname = "";
            string auforename = "";
            string auhomepage = "";
            string auemail = "";
            string aucv = "";
            string author = "";
        

        private void EditbookButton_Click(object sender, EventArgs e)
        {
            author = (AuforenameTextBox.Text + ' ' + AusurnameTextBox.Text);
            ausurname = AusurnameTextBox.Text;
            auforename = AuforenameTextBox.Text;
            auhomepage = AuhomepageTextBox.Text;
            auemail = AuemailTextBox.Text;
            aucv = AucvTextBox.Text;

            DateTime start = DateTime.Now;
            Random rnd = new Random();
            string strEdit = " UPDATE Library SET Author = '" + author + "' ,Ausurname = '" + ausurname + "',Auforename = '" + auforename + "',Auhomepage = '" + auhomepage + "',Auemail = '" + auemail + "',Aucv = '" + aucv + "' WHERE Author='" + getdata.authorname + "' ";
            customerEntries = (Application.Current as App).db.SelectObservableCollection<Library>(strEdit);
            MessageBox.Show(" Information Update ! ");
       }
        private void BackButton_Click(object sender, EventArgs e)
        {
            this.NavigationService.Navigate(new Uri("/Control/browse.xaml", UriKind.Relative));
        }

        

        
    }
}