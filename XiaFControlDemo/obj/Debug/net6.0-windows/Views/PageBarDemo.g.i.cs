﻿#pragma checksum "..\..\..\..\Views\PageBarDemo.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "57D5F7E750CFC289B8F0D8FF302A3BCFF5F8FEC4"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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
using XiaFControl.Controls;
using XiaFControlDemo.Views;


namespace XiaFControlDemo.Views {
    
    
    /// <summary>
    /// PageBarDemo
    /// </summary>
    public partial class PageBarDemo : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.4.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/XiaFControlDemo;V1.0.0.0;component/views/pagebardemo.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\PageBarDemo.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.4.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 27 "..\..\..\..\Views\PageBarDemo.xaml"
            ((XiaFControl.Controls.PageBar)(target)).PageIndexChanged += new System.Windows.RoutedPropertyChangedEventHandler<int>(this.PageBar_PageIndexChanged);
            
            #line default
            #line hidden
            
            #line 28 "..\..\..\..\Views\PageBarDemo.xaml"
            ((XiaFControl.Controls.PageBar)(target)).PageSizeChanged += new System.Windows.RoutedPropertyChangedEventHandler<int>(this.PageBar_PageSizeChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 35 "..\..\..\..\Views\PageBarDemo.xaml"
            ((XiaFControl.Controls.PageBar)(target)).PageIndexChanged += new System.Windows.RoutedPropertyChangedEventHandler<int>(this.PageBar_PageIndexChanged);
            
            #line default
            #line hidden
            
            #line 36 "..\..\..\..\Views\PageBarDemo.xaml"
            ((XiaFControl.Controls.PageBar)(target)).PageSizeChanged += new System.Windows.RoutedPropertyChangedEventHandler<int>(this.PageBar_PageSizeChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 41 "..\..\..\..\Views\PageBarDemo.xaml"
            ((XiaFControl.Controls.PageBar)(target)).PageIndexChanged += new System.Windows.RoutedPropertyChangedEventHandler<int>(this.PageBar_PageIndexChanged);
            
            #line default
            #line hidden
            
            #line 42 "..\..\..\..\Views\PageBarDemo.xaml"
            ((XiaFControl.Controls.PageBar)(target)).PageSizeChanged += new System.Windows.RoutedPropertyChangedEventHandler<int>(this.PageBar_PageSizeChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 49 "..\..\..\..\Views\PageBarDemo.xaml"
            ((XiaFControl.Controls.PageBar)(target)).PageIndexChanged += new System.Windows.RoutedPropertyChangedEventHandler<int>(this.PageBar_PageIndexChanged);
            
            #line default
            #line hidden
            
            #line 50 "..\..\..\..\Views\PageBarDemo.xaml"
            ((XiaFControl.Controls.PageBar)(target)).PageSizeChanged += new System.Windows.RoutedPropertyChangedEventHandler<int>(this.PageBar_PageSizeChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
