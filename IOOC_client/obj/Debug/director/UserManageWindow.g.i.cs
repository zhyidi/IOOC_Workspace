﻿#pragma checksum "..\..\..\director\UserManageWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "735ED2A0F4B54B66911942ED098AFB79D6EA9394074A700EFAF860AF917636D2"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using IOOC_client.director;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
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


namespace IOOC_client {
    
    
    /// <summary>
    /// UserManageWindow
    /// </summary>
    public partial class UserManageWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\..\director\UserManageWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Menu Take;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\director\UserManageWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Menu diagnosis;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\director\UserManageWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Menu director;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\director\UserManageWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid datagrid_case;
        
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
            System.Uri resourceLocater = new System.Uri("/IOOC_client;component/director/usermanagewindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\director\UserManageWindow.xaml"
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
            this.Take = ((System.Windows.Controls.Menu)(target));
            
            #line 16 "..\..\..\director\UserManageWindow.xaml"
            this.Take.MouseEnter += new System.Windows.Input.MouseEventHandler(this.Take_MouseEnter);
            
            #line default
            #line hidden
            
            #line 16 "..\..\..\director\UserManageWindow.xaml"
            this.Take.MouseLeave += new System.Windows.Input.MouseEventHandler(this.Take_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 2:
            this.diagnosis = ((System.Windows.Controls.Menu)(target));
            
            #line 22 "..\..\..\director\UserManageWindow.xaml"
            this.diagnosis.MouseEnter += new System.Windows.Input.MouseEventHandler(this.diagnosis_MouseEnter);
            
            #line default
            #line hidden
            
            #line 22 "..\..\..\director\UserManageWindow.xaml"
            this.diagnosis.MouseLeave += new System.Windows.Input.MouseEventHandler(this.diagnosis_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 3:
            this.director = ((System.Windows.Controls.Menu)(target));
            
            #line 27 "..\..\..\director\UserManageWindow.xaml"
            this.director.MouseEnter += new System.Windows.Input.MouseEventHandler(this.director_MouseEnter);
            
            #line default
            #line hidden
            
            #line 27 "..\..\..\director\UserManageWindow.xaml"
            this.director.MouseLeave += new System.Windows.Input.MouseEventHandler(this.director_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 4:
            this.datagrid_case = ((System.Windows.Controls.DataGrid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
