﻿#pragma checksum "C:\Users\admin\Desktop\Window phone\Source Code - Using on Window Phone SDK\Shinbe Library\WP7SQLiteClient\DetailPages\BranchDetail.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "A0000D3FB840BE01940BAC1CC8DB595E"
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
    
    
    public partial class BranchDetail : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.StackPanel TitlePanel;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal System.Windows.Controls.ListBox MainListBox;
        
        internal System.Windows.Controls.TextBox AddressText;
        
        internal System.Windows.Controls.TextBox PhoneText;
        
        internal System.Windows.Controls.TextBox HomepageText;
        
        internal System.Windows.Controls.TextBox EmailText;
        
        internal Microsoft.Phone.Shell.ApplicationBarIconButton editbookButton;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/WP7SQLiteClient;component/DetailPages/BranchDetail.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.TitlePanel = ((System.Windows.Controls.StackPanel)(this.FindName("TitlePanel")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.MainListBox = ((System.Windows.Controls.ListBox)(this.FindName("MainListBox")));
            this.AddressText = ((System.Windows.Controls.TextBox)(this.FindName("AddressText")));
            this.PhoneText = ((System.Windows.Controls.TextBox)(this.FindName("PhoneText")));
            this.HomepageText = ((System.Windows.Controls.TextBox)(this.FindName("HomepageText")));
            this.EmailText = ((System.Windows.Controls.TextBox)(this.FindName("EmailText")));
            this.editbookButton = ((Microsoft.Phone.Shell.ApplicationBarIconButton)(this.FindName("editbookButton")));
            this.backButton = ((Microsoft.Phone.Shell.ApplicationBarIconButton)(this.FindName("backButton")));
        }
    }
}

