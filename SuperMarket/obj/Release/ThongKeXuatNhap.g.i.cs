﻿#pragma checksum "..\..\ThongKeXuatNhap.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "95EED7FE83E716AC21DFABF6354E1C50A5B52F3D"
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
    /// ThongKeXuatNhap
    /// </summary>
    public partial class ThongKeXuatNhap : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\ThongKeXuatNhap.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnBH;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\ThongKeXuatNhap.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnNH;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\ThongKeXuatNhap.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnTH;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\ThongKeXuatNhap.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid GridMain;
        
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
            System.Uri resourceLocater = new System.Uri("/SuperMarket;component/thongkexuatnhap.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\ThongKeXuatNhap.xaml"
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
            this.btnBH = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\ThongKeXuatNhap.xaml"
            this.btnBH.Click += new System.Windows.RoutedEventHandler(this.BtnBH_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btnNH = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\ThongKeXuatNhap.xaml"
            this.btnNH.Click += new System.Windows.RoutedEventHandler(this.BtnNH_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnTH = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\ThongKeXuatNhap.xaml"
            this.btnTH.Click += new System.Windows.RoutedEventHandler(this.BtnTH_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.GridMain = ((System.Windows.Controls.Grid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

