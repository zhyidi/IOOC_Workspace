﻿#pragma checksum "..\..\Server_Home.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "FE625B2C86DB3C31FA926BEEACBDE9F68554F7CA268AC1EA34EA0AC9B17DF148"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using IOOC_server;
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


namespace IOOC_server {
    
    
    /// <summary>
    /// Server_Home
    /// </summary>
    public partial class Server_Home : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\Server_Home.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button connection;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\Server_Home.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox text_zaixian;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\Server_Home.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button close_connection;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\Server_Home.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox text_statue;
        
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
            System.Uri resourceLocater = new System.Uri("/IOOC_server;component/server_home.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Server_Home.xaml"
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
            this.connection = ((System.Windows.Controls.Button)(target));
            
            #line 13 "..\..\Server_Home.xaml"
            this.connection.Click += new System.Windows.RoutedEventHandler(this.connection_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.text_zaixian = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.close_connection = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\Server_Home.xaml"
            this.close_connection.Click += new System.Windows.RoutedEventHandler(this.close_connection_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.text_statue = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
