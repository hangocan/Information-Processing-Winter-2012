﻿#pragma checksum "E:\Project Compilation\Information Processing Winter 2012\Window phone project WS2012\Shinbe Library\WP7SQLiteClient\Control\browse.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "9D2CA79F197F7E51BE520EF0CF569F3A"
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


namespace WP7SQLiteClient.Control {
    
    
    public partial class browse : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal Microsoft.Phone.Controls.PivotItem book;
        
        internal System.Windows.Controls.Grid ContentPanel1;
        
        internal System.Windows.Controls.ListBox Book;
        
        internal Microsoft.Phone.Controls.PivotItem author;
        
        internal System.Windows.Controls.Grid ContentPanel2;
        
        internal System.Windows.Controls.ListBox Author;
        
        internal Microsoft.Phone.Controls.PivotItem editor;
        
        internal System.Windows.Controls.Grid Contentpanel3;
        
        internal System.Windows.Controls.ListBox Editor;
        
        internal Microsoft.Phone.Controls.PivotItem importer;
        
        internal System.Windows.Controls.Grid ContentPanel4;
        
        internal System.Windows.Controls.ListBox Importer;
        
        internal Microsoft.Phone.Controls.PivotItem publisher;
        
        internal System.Windows.Controls.Grid ContentPanel_Publisher;
        
        internal System.Windows.Controls.ListBox Publisher;
        
        internal Microsoft.Phone.Controls.PivotItem bookseller;
        
        internal System.Windows.Controls.Grid ContentPanel_BookSeller;
        
        internal System.Windows.Controls.ListBox Bookseller;
        
        internal Microsoft.Phone.Controls.PivotItem storage;
        
        internal System.Windows.Controls.Grid ContentPanel_Storagelocation;
        
        internal System.Windows.Controls.ListBox Storagelocation;
        
        internal Microsoft.Phone.Shell.ApplicationBarIconButton searchButton;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/WP7SQLiteClient;component/Control/browse.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.book = ((Microsoft.Phone.Controls.PivotItem)(this.FindName("book")));
            this.ContentPanel1 = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel1")));
            this.Book = ((System.Windows.Controls.ListBox)(this.FindName("Book")));
            this.author = ((Microsoft.Phone.Controls.PivotItem)(this.FindName("author")));
            this.ContentPanel2 = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel2")));
            this.Author = ((System.Windows.Controls.ListBox)(this.FindName("Author")));
            this.editor = ((Microsoft.Phone.Controls.PivotItem)(this.FindName("editor")));
            this.Contentpanel3 = ((System.Windows.Controls.Grid)(this.FindName("Contentpanel3")));
            this.Editor = ((System.Windows.Controls.ListBox)(this.FindName("Editor")));
            this.importer = ((Microsoft.Phone.Controls.PivotItem)(this.FindName("importer")));
            this.ContentPanel4 = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel4")));
            this.Importer = ((System.Windows.Controls.ListBox)(this.FindName("Importer")));
            this.publisher = ((Microsoft.Phone.Controls.PivotItem)(this.FindName("publisher")));
            this.ContentPanel_Publisher = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel_Publisher")));
            this.Publisher = ((System.Windows.Controls.ListBox)(this.FindName("Publisher")));
            this.bookseller = ((Microsoft.Phone.Controls.PivotItem)(this.FindName("bookseller")));
            this.ContentPanel_BookSeller = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel_BookSeller")));
            this.Bookseller = ((System.Windows.Controls.ListBox)(this.FindName("Bookseller")));
            this.storage = ((Microsoft.Phone.Controls.PivotItem)(this.FindName("storage")));
            this.ContentPanel_Storagelocation = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel_Storagelocation")));
            this.Storagelocation = ((System.Windows.Controls.ListBox)(this.FindName("Storagelocation")));
            this.searchButton = ((Microsoft.Phone.Shell.ApplicationBarIconButton)(this.FindName("searchButton")));
            this.backButton = ((Microsoft.Phone.Shell.ApplicationBarIconButton)(this.FindName("backButton")));
        }
    }
}
