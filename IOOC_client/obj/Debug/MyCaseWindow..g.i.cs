﻿#pragma checksum "..\..\MyCaseWindow..xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "483ADE82D24A2C1CD04D2B32E0FE697AA7D92CADB586B20A1C7CDBD7A7EB0E68"
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
    /// My_cases
    /// </summary>
    public partial class My_cases : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 27 "..\..\MyCaseWindow..xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid datagrid_case;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\MyCaseWindow..xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Menu Take32;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\MyCaseWindow..xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Menu Diagnosis32;
        
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
            System.Uri resourceLocater = new System.Uri("/IOOC_client;component/mycasewindow..xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MyCaseWindow..xaml"
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
            
            #line 19 "..\..\MyCaseWindow..xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 20 "..\..\MyCaseWindow..xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_1);
            
            #line default
            #line hidden
            return;
            case 3:
            this.datagrid_case = ((System.Windows.Controls.DataGrid)(target));
            
            #line 27 "..\..\MyCaseWindow..xaml"
            this.datagrid_case.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.datagrid_case_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Take32 = ((System.Windows.Controls.Menu)(target));
            
            #line 40 "..\..\MyCaseWindow..xaml"
            this.Take32.MouseEnter += new System.Windows.Input.MouseEventHandler(this.Take_MouseEnter32);
            
            #line default
            #line hidden
            
            #line 40 "..\..\MyCaseWindow..xaml"
            this.Take32.MouseLeave += new System.Windows.Input.MouseEventHandler(this.Take_MouseLeave32);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 42 "..\..\MyCaseWindow..xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_4);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Diagnosis32 = ((System.Windows.Controls.Menu)(target));
            
            #line 46 "..\..\MyCaseWindow..xaml"
            this.Diagnosis32.MouseEnter += new System.Windows.Input.MouseEventHandler(this.diagnosis_MouseEnter32);
            
            #line default
            #line hidden
            
            #line 46 "..\..\MyCaseWindow..xaml"
            this.Diagnosis32.MouseLeave += new System.Windows.Input.MouseEventHandler(this.diagnosis_MouseLeave32);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 47 "..\..\MyCaseWindow..xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_1);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 48 "..\..\MyCaseWindow..xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_2);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 51 "..\..\MyCaseWindow..xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_3);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

