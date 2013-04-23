'Program Name: Wood Cabinet Estimate
'Author: Corinne Hoisington
'Date: January 29, 2012
'Purpose : This mobile application computes the estimated cost
'           of wood cabinets based on the number of linear feet of
'           cabinets and the following cost per linear foot:
'           Pine -$100.00 per linear foot; Oak -$150.00 per
'           linear foot; Cherry -$250.00 per linear foot.
Option Strict On
Partial Public Class MainPage
    Inherits PhoneApplicationPage

    ' Constructor
    Public Sub New()
        InitializeComponent()
    End Sub

    Dim charactersAllowed As String = "0123456789."
    Dim charactersDisallowed As String = "abcdefghijklmopqrstuvwxyz!@#$%^&*()_+"

    Private Sub btnCalculate_Click(sender As System.Object, e As System.Windows.RoutedEventArgs) Handles btnCalculate.Click
        'The btnCalculate event handler calculates the estimated cost of 16 cabinets based on the linear feet and the wood type.
        'Declaration Section
        Dim decLinearFeet As Decimal
        Dim decCostPerFoot As Decimal
        Dim decCostEstimate As Decimal
        Dim decPineCost As Decimal = 1000
        Dim decOakCost As Decimal = 150D
        Dim decCherryCost As Decimal = 250D

        Dim input As String = txtLinearFeet.Text
        Dim Letter As String
        Dim SelectionInder As Integer = txtLinearFeet.SelectionStart
        'Did user enter a numeric value?

        For X As Integer = 0 To txtLinearFeet.Text.Length - 1
            Letter = txtLinearFeet.Text.Substring(X, 1)
            If charactersAllowed.Contains(Letter) Then
                decLinearFeet = Convert.ToDecimal(Me.txtLinearFeet.Text)

                'Is Linear Feet greater than zero
                If decLinearFeet > 0 Then
                    'Determine cost per foot of wood
                    If Me.radPine.IsChecked Then
                        decCostPerFoot = decPineCost
                    ElseIf Me.radOak.IsChecked Then
                        decCostPerFoot = decOakCost
                    ElseIf Me.radCherry.IsChecked Then
                        decCostPerFoot = decCherryCost
                    End If
                    'Calculate and display the cost estimate
                    decCostEstimate = decLinearFeet * decCostPerFoot
                    Me.lblCostEstimate.Text = decCostEstimate.ToString("C")
                Else
                    'Display error message if user entered a negative value
                    MessageBox.Show("You entered" & decLinearFeet.ToString() & _
                        " . Enter a Number Greater Than Zero.  Input Error")
                    Me.txtLinearFeet.Text = ""
                    Me.txtLinearFeet.Focus()
                End If

            End If
            If charactersDisallowed.Contains(Letter) Then
                ' Display error message if user entered a nonnumeric value
                MessageBox.Show("Enter the Linear Feet of the Cabinets.  Input Error")
                Me.txtLinearFeet.Text = Me.txtLinearFeet.Text
                Me.txtLinearFeet.Focus()
            End If
        Next
    End Sub

    Private Sub btnClear_Click(sender As System.Object, e As System.Windows.RoutedEventArgs) Handles btnClear.Click
        Me.txtLinearFeet.Text = ""
        Me.lblCostEstimate.Text = ""
        Me.radPine.IsChecked = True
        Me.radOak.IsChecked = False
        Me.radCherry.IsChecked = False
        Me.txtLinearFeet.Focus()
    End Sub

    Private Sub Estimate_Loaded(sender As System.Object, e As System.Windows.RoutedEventArgs) Handles MyBase.Loaded
        Me.txtLinearFeet.Focus()
        Me.radPine.IsChecked = True
        lblCostEstimate.Text = ""
    End Sub
End Class
