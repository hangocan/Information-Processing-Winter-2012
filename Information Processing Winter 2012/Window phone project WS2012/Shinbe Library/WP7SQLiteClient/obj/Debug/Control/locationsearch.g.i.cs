﻿#pragma checksum "C:\Users\admin\Desktop\Window phone\Source Code - Using on Window Phone SDK\Shinbe Library\WP7SQLiteClient\Control\locationsearch.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "36C9B16A99CA50DC93B6644F3C141A19"
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
    
    
    public partial class locationsearch : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal Microsoft.Phone.Controls.PivotItem book;
        
        internal System.Windows.Controls.Grid ContentPanel1;
        
        internal System.Windows.Controls.ListBox Booklist;
        
        internal System.Windows.Controls.TextBlock textBlock1;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/WP7SQLiteClient;component/Control/locationsearch.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.book = ((Microsoft.Phone.Controls.PivotItem)(this.FindName("book")));
            this.ContentPanel1 = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel1")));
            this.Booklist = ((System.Windows.Controls.ListBox)(this.FindName("Booklist")));
            this.textBlock1 = ((System.Windows.Controls.TextBlock)(this.FindName("textBlock1")));
            this.backButton = ((Microsoft.Phone.Shell.ApplicationBarIconButton)(this.FindName("backButton")));
        }
    }
}

