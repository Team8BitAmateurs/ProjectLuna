Public Class Form1

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.PrintDialog1.ShowDialog()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim strName As String = InputBox("What is your name?")
        MsgBox("Hello" & " " & strName & "." & vbNewLine & "Press OK!")
        TextBox.Text = strName
        Dim nmbMonth As Integer = InputBox("What MONTH were you born at (NUMBERS ONLY!!!)?")
        Dim nmbDay As Integer = InputBox("What DAY were you born at (NUMBERS ONLY!!!)?")
        Dim nmbYear As Integer = InputBox("What YEAR were you born at (NUMBERS ONLY!!!)?")
        Dim nmbTotalYear As String = nmbMonth & " / " & nmbDay & " / " & nmbYear
        DateBorn.Text = nmbTotalYear
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Sub DayDiff()
        Dim sDate As String
        Dim intNumDays As Integer
        On Error GoTo errhandler
        ' Prompt for a date.
        sDate = InputBox$("Enter a date in the mm/dd/yyyy format")
        ' Get difference between dates.
        intNumDays = CInt(DateValue(sDate) - Now())
        ' Determine if difference is past or future.
        If Sign(intNumDays) = 1 Then
            MsgBox("Days between " + sDate + " and today :" + CStr(intNumDays))
        Else
            MsgBox("The date " + sDate + " was" + CStr(Abs(intNumDays)) _
            + " day(s) ago.")
        End If
errhandler:
        If Err > 0 Then MsgBox("Please enter a valid date.")
    End Sub

End Class
