﻿#pragma checksum "E:\Project Compilation\Information Processing Winter 2012\Window phone project WS2012\Shinbe Library\WP7SQLiteClient\DetailPages\EditorDetail.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "5BA6FCC89BFED070687860BF695F5750"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
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


namespace WP7SQLiteClient.DetaiPages {
    
    
    public partial class EditorDetail : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal System.Windows.Controls.ListBox Editor;
        
        internal System.Windows.Controls.TextBox EditorForenameTextBox;
        
        internal System.Windows.Controls.TextBox EditorSurnameTextBox;
        
        internal System.Windows.Controls.TextBox EditorHomePageTextBox;
        
        internal System.Windows.Controls.TextBox EditorEmailTextBox;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/WP7SQLiteClient;component/DetailPages/EditorDetail.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.Editor = ((System.Windows.Controls.ListBox)(this.FindName("Editor")));
            this.EditorForenameTextBox = ((System.Windows.Controls.TextBox)(this.FindName("EditorForenameTextBox")));
            this.EditorSurnameTextBox = ((System.Windows.Controls.TextBox)(this.FindName("EditorSurnameTextBox")));
            this.EditorHomePageTextBox = ((System.Windows.Controls.TextBox)(this.FindName("EditorHomePageTextBox")));
            this.EditorEmailTextBox = ((System.Windows.Controls.TextBox)(this.FindName("EditorEmailTextBox")));
            this.editbookButton = ((Microsoft.Phone.Shell.ApplicationBarIconButton)(this.FindName("editbookButton")));
            this.backButton = ((Microsoft.Phone.Shell.ApplicationBarIconButton)(this.FindName("backButton")));
        }
    }
}

