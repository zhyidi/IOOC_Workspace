﻿#pragma checksum "..\..\..\director.workstation\PatientInformationManageWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "D34AFA9C5FBA695689B46F83E7D8F5081AECBD2F56CF700A36A66A4E6AC72C8C"
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
    /// PatientInformationManageWindow
    /// </summary>
    public partial class PatientInformationManageWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 18 "..\..\..\director.workstation\PatientInformationManageWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid datagrid1;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\director.workstation\PatientInformationManageWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Menu Take;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\..\director.workstation\PatientInformationManageWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Menu diagnosis;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\..\director.workstation\PatientInformationManageWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Menu director;
        
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
            System.Uri resourceLocater = new System.Uri("/IOOC_client;component/director.workstation/patientinformationmanagewindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\director.workstation\PatientInformationManageWindow.xaml"
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
            
            #line 13 "..\..\..\director.workstation\PatientInformationManageWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_6);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 14 "..\..\..\director.workstation\PatientInformationManageWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_12);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 15 "..\..\..\director.workstation\PatientInformationManageWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.datagrid1 = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 5:
            
            #line 51 "..\..\..\director.workstation\PatientInformationManageWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 52 "..\..\..\director.workstation\PatientInformationManageWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_1);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 53 "..\..\..\director.workstation\PatientInformationManageWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_2);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 54 "..\..\..\director.workstation\PatientInformationManageWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_3);
            
            #line default
            #line hidden
            return;
            case 9:
            this.Take = ((System.Windows.Controls.Menu)(target));
            
            #line 55 "..\..\..\director.workstation\PatientInformationManageWindow.xaml"
            this.Take.MouseEnter += new System.Windows.Input.MouseEventHandler(this.Take_MouseEnter);
            
            #line default
            #line hidden
            
            #line 55 "..\..\..\director.workstation\PatientInformationManageWindow.xaml"
            this.Take.MouseLeave += new System.Windows.Input.MouseEventHandler(this.Take_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 57 "..\..\..\director.workstation\PatientInformationManageWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_7);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 58 "..\..\..\director.workstation\PatientInformationManageWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_8);
            
            #line default
            #line hidden
            return;
            case 12:
            
            #line 59 "..\..\..\director.workstation\PatientInformationManageWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_9);
            
            #line default
            #line hidden
            return;
            case 13:
            this.diagnosis = ((System.Windows.Controls.Menu)(target));
            
            #line 61 "..\..\..\director.workstation\PatientInformationManageWindow.xaml"
            this.diagnosis.MouseEnter += new System.Windows.Input.MouseEventHandler(this.diagnosis_MouseEnter);
            
            #line default
            #line hidden
            
            #line 61 "..\..\..\director.workstation\PatientInformationManageWindow.xaml"
            this.diagnosis.MouseLeave += new System.Windows.Input.MouseEventHandler(this.diagnosis_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 14:
            
            #line 63 "..\..\..\director.workstation\PatientInformationManageWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_10);
            
            #line default
            #line hidden
            return;
            case 15:
            
            #line 64 "..\..\..\director.workstation\PatientInformationManageWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_11);
            
            #line default
            #line hidden
            return;
            case 16:
            this.director = ((System.Windows.Controls.Menu)(target));
            
            #line 66 "..\..\..\director.workstation\PatientInformationManageWindow.xaml"
            this.director.MouseEnter += new System.Windows.Input.MouseEventHandler(this.director_MouseEnter);
            
            #line default
            #line hidden
            
            #line 66 "..\..\..\director.workstation\PatientInformationManageWindow.xaml"
            this.director.MouseLeave += new System.Windows.Input.MouseEventHandler(this.director_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 17:
            
            #line 68 "..\..\..\director.workstation\PatientInformationManageWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_5);
            
            #line default
            #line hidden
            return;
            case 18:
            
            #line 69 "..\..\..\director.workstation\PatientInformationManageWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_4);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

