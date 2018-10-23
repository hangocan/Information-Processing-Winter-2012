using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace Library_test_7.Pages
{
    public partial class Importer_DetailPage2 : PhoneApplicationPage
    {
        public Importer_DetailPage2()
        {
            InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            string selectedIndex = "";
            if (NavigationContext.QueryString.TryGetValue("selectedItem", out selectedIndex))
            {
                int Name = int.Parse(selectedIndex);
                DataContext = App.ControlModel.ImporterItems[Name];
            }
        }
    }
}