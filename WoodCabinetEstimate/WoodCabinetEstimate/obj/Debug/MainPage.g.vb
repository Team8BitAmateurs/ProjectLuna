﻿#ExternalChecksum("C:\Users\1409756\ProjectLuna\ProjectLuna\WoodCabinetEstimate\WoodCabinetEstimate\MainPage.xaml","{406ea660-64cf-4c82-b6f0-42d48172a799}","0ECC7998AB0E01A31C11957A9D871FA7")
'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.18034
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



<Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>  _
Partial Public Class MainPage
    Inherits Microsoft.Phone.Controls.PhoneApplicationPage
    
    Friend WithEvents Estimate As Microsoft.Phone.Controls.PhoneApplicationPage
    
    Friend WithEvents LayoutRoot As System.Windows.Controls.Grid
    
    Friend WithEvents TitlePanel As System.Windows.Controls.StackPanel
    
    Friend WithEvents ApplicationTitle As System.Windows.Controls.TextBlock
    
    Friend WithEvents PageTitle As System.Windows.Controls.TextBlock
    
    Friend WithEvents ContentPanel As System.Windows.Controls.Grid
    
    Friend WithEvents txtLinearFeet As System.Windows.Controls.TextBox
    
    Friend WithEvents lblLinearFeet As System.Windows.Controls.TextBlock
    
    Friend WithEvents lblWoodType As System.Windows.Controls.TextBlock
    
    Friend WithEvents pnlWoodType As System.Windows.Shapes.Rectangle
    
    Friend WithEvents radPine As System.Windows.Controls.RadioButton
    
    Friend WithEvents radOak As System.Windows.Controls.RadioButton
    
    Friend WithEvents radCherry As System.Windows.Controls.RadioButton
    
    Friend WithEvents lblCostEstimateLabel As System.Windows.Controls.TextBlock
    
    Friend WithEvents lblCostEstimate As System.Windows.Controls.TextBlock
    
    Friend WithEvents btnCalculate As System.Windows.Controls.Button
    
    Friend WithEvents btnClear As System.Windows.Controls.Button
    
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
        System.Windows.Application.LoadComponent(Me, New System.Uri("/WoodCabinetEstimate;component/MainPage.xaml", System.UriKind.Relative))
        Me.Estimate = CType(Me.FindName("Estimate"),Microsoft.Phone.Controls.PhoneApplicationPage)
        Me.LayoutRoot = CType(Me.FindName("LayoutRoot"),System.Windows.Controls.Grid)
        Me.TitlePanel = CType(Me.FindName("TitlePanel"),System.Windows.Controls.StackPanel)
        Me.ApplicationTitle = CType(Me.FindName("ApplicationTitle"),System.Windows.Controls.TextBlock)
        Me.PageTitle = CType(Me.FindName("PageTitle"),System.Windows.Controls.TextBlock)
        Me.ContentPanel = CType(Me.FindName("ContentPanel"),System.Windows.Controls.Grid)
        Me.txtLinearFeet = CType(Me.FindName("txtLinearFeet"),System.Windows.Controls.TextBox)
        Me.lblLinearFeet = CType(Me.FindName("lblLinearFeet"),System.Windows.Controls.TextBlock)
        Me.lblWoodType = CType(Me.FindName("lblWoodType"),System.Windows.Controls.TextBlock)
        Me.pnlWoodType = CType(Me.FindName("pnlWoodType"),System.Windows.Shapes.Rectangle)
        Me.radPine = CType(Me.FindName("radPine"),System.Windows.Controls.RadioButton)
        Me.radOak = CType(Me.FindName("radOak"),System.Windows.Controls.RadioButton)
        Me.radCherry = CType(Me.FindName("radCherry"),System.Windows.Controls.RadioButton)
        Me.lblCostEstimateLabel = CType(Me.FindName("lblCostEstimateLabel"),System.Windows.Controls.TextBlock)
        Me.lblCostEstimate = CType(Me.FindName("lblCostEstimate"),System.Windows.Controls.TextBlock)
        Me.btnCalculate = CType(Me.FindName("btnCalculate"),System.Windows.Controls.Button)
        Me.btnClear = CType(Me.FindName("btnClear"),System.Windows.Controls.Button)
    End Sub
End Class
