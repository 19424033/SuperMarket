﻿#pragma checksum "..\..\..\NhaCungCapList.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2034CD5E9EDDAB3B2F83CDB94D2E54CE1C9290D7"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using SuperMarket;
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


namespace SuperMarket {
    
    
    /// <summary>
    /// NhaCungCapList
    /// </summary>
    public partial class NhaCungCapList : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 23 "..\..\..\NhaCungCapList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dataNCC;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\NhaCungCapList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dataNCCSP;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\NhaCungCapList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnOKALL;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\NhaCungCapList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnOK;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\NhaCungCapList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnUpdate;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\NhaCungCapList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCan;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\NhaCungCapList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCanALL;
        
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
            System.Uri resourceLocater = new System.Uri("/SuperMarket;component/nhacungcaplist.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\NhaCungCapList.xaml"
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
            this.dataNCC = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 2:
            this.dataNCCSP = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 3:
            this.btnOKALL = ((System.Windows.Controls.Button)(target));
            
            #line 42 "..\..\..\NhaCungCapList.xaml"
            this.btnOKALL.Click += new System.Windows.RoutedEventHandler(this.BtnOKALL_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnOK = ((System.Windows.Controls.Button)(target));
            
            #line 43 "..\..\..\NhaCungCapList.xaml"
            this.btnOK.Click += new System.Windows.RoutedEventHandler(this.BtnOK_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnUpdate = ((System.Windows.Controls.Button)(target));
            
            #line 44 "..\..\..\NhaCungCapList.xaml"
            this.btnUpdate.Click += new System.Windows.RoutedEventHandler(this.BtnCN_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btnCan = ((System.Windows.Controls.Button)(target));
            
            #line 45 "..\..\..\NhaCungCapList.xaml"
            this.btnCan.Click += new System.Windows.RoutedEventHandler(this.BtnCan_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btnCanALL = ((System.Windows.Controls.Button)(target));
            
            #line 46 "..\..\..\NhaCungCapList.xaml"
            this.btnCanALL.Click += new System.Windows.RoutedEventHandler(this.BtnCanALL_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
