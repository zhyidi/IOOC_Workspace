﻿#pragma checksum "..\..\ReportDiagnosis.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "92FD8777A433576DAB1FDCBEED18AC323FAD793BF1476186B2F82B2D617D90EB"
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
    /// Report_diagnosis
    /// </summary>
    public partial class Report_diagnosis : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 34 "..\..\ReportDiagnosis.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Menu Take;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\ReportDiagnosis.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Menu diagnosis;
        
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
            System.Uri resourceLocater = new System.Uri("/IOOC_client;component/reportdiagnosis.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\ReportDiagnosis.xaml"
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
            
            #line 13 "..\..\ReportDiagnosis.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 19 "..\..\ReportDiagnosis.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_1);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 25 "..\..\ReportDiagnosis.xaml"
            ((System.Windows.Controls.TextBox)(target)).TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TextBox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Take = ((System.Windows.Controls.Menu)(target));
            
            #line 34 "..\..\ReportDiagnosis.xaml"
            this.Take.MouseEnter += new System.Windows.Input.MouseEventHandler(this.Take_MouseEnter);
            
            #line default
            #line hidden
            
            #line 34 "..\..\ReportDiagnosis.xaml"
            this.Take.MouseLeave += new System.Windows.Input.MouseEventHandler(this.Take_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 5:
            this.diagnosis = ((System.Windows.Controls.Menu)(target));
            
            #line 40 "..\..\ReportDiagnosis.xaml"
            this.diagnosis.MouseEnter += new System.Windows.Input.MouseEventHandler(this.diagnosis_MouseEnter);
            
            #line default
            #line hidden
            
            #line 40 "..\..\ReportDiagnosis.xaml"
            this.diagnosis.MouseLeave += new System.Windows.Input.MouseEventHandler(this.diagnosis_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 42 "..\..\ReportDiagnosis.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_2);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 43 "..\..\ReportDiagnosis.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_3);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

