﻿#ExternalChecksum("C:\Users\Texrat\Documents\GitHub\PortaMorse\PortaMorse\MainPage.xaml","{406ea660-64cf-4c82-b6f0-42d48172a799}","0DE9A57E7DFD7F94319D1C9099E9D460")
'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.17379
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On

Imports Microsoft.Phone.Controls
Imports System
Imports System.Windows
Imports System.Windows.Automation
Imports System.Windows.Automation.Peers
Imports System.Windows.Automation.Provider
Imports System.Windows.Controls
Imports System.Windows.Controls.Primitives
Imports System.Windows.Data
Imports System.Windows.Documents
Imports System.Windows.Ink
Imports System.Windows.Input
Imports System.Windows.Interop
Imports System.Windows.Markup
Imports System.Windows.Media
Imports System.Windows.Media.Animation
Imports System.Windows.Media.Imaging
Imports System.Windows.Resources
Imports System.Windows.Shapes
Imports System.Windows.Threading
Imports Telerik.Windows.Controls



<Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>  _
Partial Public Class MainPage
    Inherits Microsoft.Phone.Controls.PhoneApplicationPage
    
    Friend WithEvents LayoutRoot As System.Windows.Controls.Grid
    
    Friend WithEvents TitlePanel As System.Windows.Controls.StackPanel
    
    Friend WithEvents ApplicationTitle As System.Windows.Controls.TextBlock
    
    Friend WithEvents PageTitle As System.Windows.Controls.TextBlock
    
    Friend WithEvents ContentPanel As System.Windows.Controls.Grid
    
    Friend WithEvents Button1 As System.Windows.Controls.Button
    
    Friend WithEvents ListBox1 As System.Windows.Controls.ListBox
    
    Friend WithEvents RadNumericUpDown1 As Telerik.Windows.Controls.RadNumericUpDown
    
    Friend WithEvents RadLoopingList1 As Telerik.Windows.Controls.RadLoopingList
    
    Private _contentLoaded As Boolean
    
    '''<summary>
    '''InitializeComponent
    '''</summary>
    <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
    Public Sub InitializeComponent()
        If _contentLoaded Then
            Return
        End If
        _contentLoaded = true
        System.Windows.Application.LoadComponent(Me, New System.Uri("/PortaMorse;component/MainPage.xaml", System.UriKind.Relative))
        Me.LayoutRoot = CType(Me.FindName("LayoutRoot"),System.Windows.Controls.Grid)
        Me.TitlePanel = CType(Me.FindName("TitlePanel"),System.Windows.Controls.StackPanel)
        Me.ApplicationTitle = CType(Me.FindName("ApplicationTitle"),System.Windows.Controls.TextBlock)
        Me.PageTitle = CType(Me.FindName("PageTitle"),System.Windows.Controls.TextBlock)
        Me.ContentPanel = CType(Me.FindName("ContentPanel"),System.Windows.Controls.Grid)
        Me.Button1 = CType(Me.FindName("Button1"),System.Windows.Controls.Button)
        Me.ListBox1 = CType(Me.FindName("ListBox1"),System.Windows.Controls.ListBox)
        Me.RadNumericUpDown1 = CType(Me.FindName("RadNumericUpDown1"),Telerik.Windows.Controls.RadNumericUpDown)
        Me.RadLoopingList1 = CType(Me.FindName("RadLoopingList1"),Telerik.Windows.Controls.RadLoopingList)
    End Sub
End Class
