﻿#pragma checksum "..\..\PictureSort.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "71726AFDA253FC87D3F4B7C44DD95833805562961C327C5E31FAE7DB5CF50CD0"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Memory_Test_Game;
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


namespace Memory_Test_Game {
    
    
    /// <summary>
    /// PictureSort
    /// </summary>
    public partial class PictureSort : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 15 "..\..\PictureSort.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image PictureSortImg;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\PictureSort.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox checkboxA;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\PictureSort.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox checkboxB;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\PictureSort.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox checkboxC;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\PictureSort.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox checkboxD;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\PictureSort.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox checkboxE;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\PictureSort.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox checkboxF;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\PictureSort.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label errorLabel;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\PictureSort.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame PictureSortFrame;
        
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
            System.Uri resourceLocater = new System.Uri("/Memory Test Game;component/picturesort.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\PictureSort.xaml"
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
            this.PictureSortImg = ((System.Windows.Controls.Image)(target));
            return;
            case 2:
            
            #line 18 "..\..\PictureSort.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Picture_Sort_Button_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.checkboxA = ((System.Windows.Controls.CheckBox)(target));
            
            #line 19 "..\..\PictureSort.xaml"
            this.checkboxA.Checked += new System.Windows.RoutedEventHandler(this.CheckBox_Checked_A);
            
            #line default
            #line hidden
            return;
            case 4:
            this.checkboxB = ((System.Windows.Controls.CheckBox)(target));
            
            #line 25 "..\..\PictureSort.xaml"
            this.checkboxB.Checked += new System.Windows.RoutedEventHandler(this.CheckBox_Checked_B);
            
            #line default
            #line hidden
            return;
            case 5:
            this.checkboxC = ((System.Windows.Controls.CheckBox)(target));
            
            #line 31 "..\..\PictureSort.xaml"
            this.checkboxC.Checked += new System.Windows.RoutedEventHandler(this.CheckBox_Checked_C);
            
            #line default
            #line hidden
            return;
            case 6:
            this.checkboxD = ((System.Windows.Controls.CheckBox)(target));
            
            #line 37 "..\..\PictureSort.xaml"
            this.checkboxD.Checked += new System.Windows.RoutedEventHandler(this.CheckBox_Checked_D);
            
            #line default
            #line hidden
            return;
            case 7:
            this.checkboxE = ((System.Windows.Controls.CheckBox)(target));
            
            #line 42 "..\..\PictureSort.xaml"
            this.checkboxE.Checked += new System.Windows.RoutedEventHandler(this.CheckBox_Checked_E);
            
            #line default
            #line hidden
            return;
            case 8:
            this.checkboxF = ((System.Windows.Controls.CheckBox)(target));
            
            #line 47 "..\..\PictureSort.xaml"
            this.checkboxF.Checked += new System.Windows.RoutedEventHandler(this.CheckBox_Checked_F);
            
            #line default
            #line hidden
            return;
            case 9:
            this.errorLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 10:
            this.PictureSortFrame = ((System.Windows.Controls.Frame)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

