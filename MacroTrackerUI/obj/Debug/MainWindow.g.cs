﻿#pragma checksum "..\..\MainWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "C683E8BABBD41A25008B5B0724055B302029F858C0ACE8CDC9995D266A003723"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MacroTrackerUI;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace MacroTrackerUI {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 38 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image ImgProfilePic;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label LblProfileName;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image ImgAddNewItem;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image ImgSearchItem;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image ImgEditItem;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image ImgDeleteItem;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image ImgPrevRunDate;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label LblRunDate;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image ImgNextRunDate;
        
        #line default
        #line hidden
        
        
        #line 87 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnExecuteAction;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/MacroTrackerUI;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MainWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.ImgProfilePic = ((System.Windows.Controls.Image)(target));
            return;
            case 2:
            this.LblProfileName = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.ImgAddNewItem = ((System.Windows.Controls.Image)(target));
            
            #line 43 "..\..\MainWindow.xaml"
            this.ImgAddNewItem.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.ImgAddNewItem_MouseDown);
            
            #line default
            #line hidden
            return;
            case 4:
            this.ImgSearchItem = ((System.Windows.Controls.Image)(target));
            
            #line 45 "..\..\MainWindow.xaml"
            this.ImgSearchItem.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.ImgSearchItem_MouseDown);
            
            #line default
            #line hidden
            return;
            case 5:
            this.ImgEditItem = ((System.Windows.Controls.Image)(target));
            
            #line 47 "..\..\MainWindow.xaml"
            this.ImgEditItem.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.ImgEditItem_MouseDown);
            
            #line default
            #line hidden
            return;
            case 6:
            this.ImgDeleteItem = ((System.Windows.Controls.Image)(target));
            
            #line 49 "..\..\MainWindow.xaml"
            this.ImgDeleteItem.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.ImgDeleteItem_MouseDown);
            
            #line default
            #line hidden
            return;
            case 7:
            this.ImgPrevRunDate = ((System.Windows.Controls.Image)(target));
            
            #line 65 "..\..\MainWindow.xaml"
            this.ImgPrevRunDate.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.ImgPrevRunDate_MouseDown);
            
            #line default
            #line hidden
            return;
            case 8:
            this.LblRunDate = ((System.Windows.Controls.Label)(target));
            return;
            case 9:
            this.ImgNextRunDate = ((System.Windows.Controls.Image)(target));
            
            #line 69 "..\..\MainWindow.xaml"
            this.ImgNextRunDate.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.ImgNextRunDate_MouseDown);
            
            #line default
            #line hidden
            return;
            case 10:
            this.BtnExecuteAction = ((System.Windows.Controls.Button)(target));
            
            #line 88 "..\..\MainWindow.xaml"
            this.BtnExecuteAction.Click += new System.Windows.RoutedEventHandler(this.BtnExecuteAction_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
