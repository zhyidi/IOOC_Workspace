﻿#pragma checksum "..\..\DepartmentConsultationWindow1.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "68828057BDCC86F8ABB2434F605B08358D2E477E703188A188084F3DEC941F9D"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using IOOC_client;
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
    /// DepartmentConsultationWindow
    /// </summary>
    public partial class DepartmentConsultationWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 23 "..\..\DepartmentConsultationWindow1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox comboBox_state;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\DepartmentConsultationWindow1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Menu Take_Copy;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\DepartmentConsultationWindow1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Menu Diagnosis;
        
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
            System.Uri resourceLocater = new System.Uri("/IOOC_client;component/departmentconsultationwindow1.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\DepartmentConsultationWindow1.xaml"
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
            
            #line 19 "..\..\DepartmentConsultationWindow1.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 20 "..\..\DepartmentConsultationWindow1.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_2);
            
            #line default
            #line hidden
            return;
            case 3:
            this.comboBox_state = ((System.Windows.Controls.ComboBox)(target));
            
            #line 23 "..\..\DepartmentConsultationWindow1.xaml"
            this.comboBox_state.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ComboBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Take_Copy = ((System.Windows.Controls.Menu)(target));
            
            #line 24 "..\..\DepartmentConsultationWindow1.xaml"
            this.Take_Copy.MouseEnter += new System.Windows.Input.MouseEventHandler(this.take_enter);
            
            #line default
            #line hidden
            
            #line 24 "..\..\DepartmentConsultationWindow1.xaml"
            this.Take_Copy.MouseLeave += new System.Windows.Input.MouseEventHandler(this.take_leave);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 26 "..\..\DepartmentConsultationWindow1.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_4);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Diagnosis = ((System.Windows.Controls.Menu)(target));
            
            #line 31 "..\..\DepartmentConsultationWindow1.xaml"
            this.Diagnosis.MouseEnter += new System.Windows.Input.MouseEventHandler(this.diagnose_enter);
            
            #line default
            #line hidden
            
            #line 31 "..\..\DepartmentConsultationWindow1.xaml"
            this.Diagnosis.MouseLeave += new System.Windows.Input.MouseEventHandler(this.diagnose_leave);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 32 "..\..\DepartmentConsultationWindow1.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_1);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 34 "..\..\DepartmentConsultationWindow1.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_3);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 36 "..\..\DepartmentConsultationWindow1.xaml"
            ((System.Windows.Controls.TextBox)(target)).TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TextBox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 37 "..\..\DepartmentConsultationWindow1.xaml"
            ((System.Windows.Controls.DataGrid)(target)).SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.DataGrid_SelectionChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
