﻿#pragma checksum "C:\Users\admin\Desktop\Window phone\Source Code - Using on Window Phone SDK\Shinbe Library\WP7SQLiteClient\Control\manage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "96549E53D2F8063829829D17E8C24C73"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.269
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace WP7SQLiteClient.Control {
    
    
    public partial class manage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.StackPanel TitlePanel;
        
        internal System.Windows.Controls.TextBlock Manage;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal System.Windows.Controls.Button Addbook;
        
        internal System.Windows.Controls.Button Search;
        
        internal System.Windows.Controls.Button booklocation;
        
        internal System.Windows.Controls.Button loan;
        
        internal Microsoft.Phone.Shell.ApplicationBarIconButton backButton;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/WP7SQLiteClient;component/Control/manage.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.TitlePanel = ((System.Windows.Controls.StackPanel)(this.FindName("TitlePanel")));
            this.Manage = ((System.Windows.Controls.TextBlock)(this.FindName("Manage")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.Addbook = ((System.Windows.Controls.Button)(this.FindName("Addbook")));
            this.Search = ((System.Windows.Controls.Button)(this.FindName("Search")));
            this.booklocation = ((System.Windows.Controls.Button)(this.FindName("booklocation")));
            this.loan = ((System.Windows.Controls.Button)(this.FindName("loan")));
            this.backButton = ((Microsoft.Phone.Shell.ApplicationBarIconButton)(this.FindName("backButton")));
        }
    }
}

