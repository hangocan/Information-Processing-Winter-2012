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
    public partial class BA : PhoneApplicationPage
    {
        public BA()
        {
            InitializeComponent();
            this.DataContext = App.ControlModel;
        }
    }
}