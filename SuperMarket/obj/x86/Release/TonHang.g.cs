#pragma checksum "..\..\..\TonHang.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "85569EDAF031D60380A01385EF0115CF172A6AB4"
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
    /// TonHang
    /// </summary>
    public partial class TonHang : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\..\TonHang.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas filterCanvas;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\TonHang.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock hintText;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\TonHang.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox keywordTextBox;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\TonHang.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView dataListLSP;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\TonHang.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView dataTon;
        
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
            System.Uri resourceLocater = new System.Uri("/SuperMarket;component/tonhang.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\TonHang.xaml"
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
            this.filterCanvas = ((System.Windows.Controls.Canvas)(target));
            return;
            case 2:
            this.hintText = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.keywordTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 19 "..\..\..\TonHang.xaml"
            this.keywordTextBox.LostFocus += new System.Windows.RoutedEventHandler(this.KeywordTextBox_LostFocus);
            
            #line default
            #line hidden
            
            #line 20 "..\..\..\TonHang.xaml"
            this.keywordTextBox.GotFocus += new System.Windows.RoutedEventHandler(this.KeywordTextBox_GotFocus);
            
            #line default
            #line hidden
            
            #line 21 "..\..\..\TonHang.xaml"
            this.keywordTextBox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.KeywordTextBox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.dataListLSP = ((System.Windows.Controls.ListView)(target));
            
            #line 33 "..\..\..\TonHang.xaml"
            this.dataListLSP.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.DataListLSP_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.dataTon = ((System.Windows.Controls.ListView)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

