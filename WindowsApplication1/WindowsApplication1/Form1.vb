Imports System.IO
Imports System.Numerics
Public Class Form1
    Function OddOrEven(ByVal X As BigInteger) As Boolean
        If X = 1 Then
            Return False
            Exit Function
        End If
        If X Mod 2 = 0 Then 'Evens
            Return True
        Else                'Odds
            Return False
        End If
    End Function
    Function CalcOdds(ByVal XO As BigInteger) As BigInteger
        If XO = 0 Then
            Return 0
            Exit Function
        End If
        Dim N As BigInteger = XO / 2
        Return N
    End Function
    Function CalcEvens(ByVal XE As BigInteger) As BigInteger
        If XE = 0 Then
            Return 0
            Exit Function
        End If
        Dim N As BigInteger = (XE * 3) + 1
        Return N
    End Function
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        KeyPreview = True
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Len(TextBox1.Text) <= 0 Then
            TextBox1.Focus()
            Exit Sub
        End If
        If Len(TextBox2.Text) > 0 Then
            TextBox2.Clear()
        End If
        Dim N2 As List(Of BigInteger) = New List(Of BigInteger)
        Dim N1 As BigInteger = New BigInteger(CInt(TextBox1.Text))
        'Dim N1 As BigInteger = BigInteger.Pow(2, 10000)
        If Len(PwrTxtBox.Text) >= 1 Then
            N1 = BigInteger.Pow(CInt(TextBox1.Text), CInt(PwrTxtBox.Text))
        End If
        Dim Stps As Integer = 0
        Do Until N1 = 1
            If OddOrEven(N1) Then
                Dim Nodd As BigInteger = CalcOdds(N1)
                N1 = Nodd
            Else
                Dim NEven As BigInteger = CalcEvens(N1)
                N1 = NEven
            End If
            N2.Add(N1)
            Stps += 1
        Loop
        TextBox2.Text = String.Join(" ", N2)
        'Number of results
        RstltsTxtBx.Text = Stps.ToString
        'Highest Result
        BgRstTxtBx.Text = N2.Max.ToString
    End Sub
    Private Sub CsvBtn_Click(sender As Object, e As EventArgs) Handles CsvBtn.Click
        If RstltsTxtBx.Text.Length <= 0 Then
            TextBox1.Focus()
            Exit Sub
        End If
        'Save to CSV File Format
        Dim DelimittedContent As String = TextBox2.Text.Replace(" ", ";")
        Dim path As String = IO.Path.Combine(Application.StartupPath, "MyTest.csv")
        ' This text is added only once to the file.
        If File.Exists(path) = False Then
            ' Create a file to write to.
            File.WriteAllText(path, "(" & TextBox1.Text & ")" & vbNewLine & DelimittedContent + vbNewLine)
        Else
            ' This text is always added, making the file longer over time
            ' if it is not deleted.
            File.AppendAllText(path, "(" & TextBox1.Text & ")" & vbNewLine & DelimittedContent + vbNewLine)
        End If
        MsgBox("Done!")
    End Sub
    Private Sub ResetBtn_Click(sender As Object, e As EventArgs) Handles ResetBtn.Click
        TextBox1.Clear()
        TextBox2.Clear()
        PwrTxtBox.Clear()
        TextBox1.Focus()
        BgRstTxtBx.Clear()
        RstltsTxtBx.Clear()
    End Sub
    Private Sub TxtSaveBtn_Click(sender As Object, e As EventArgs) Handles TxtSaveBtn.Click
        If RstltsTxtBx.Text.Length <= 0 Then
            TextBox1.Focus()
            Exit Sub
        End If
        'Save to CSV File Format
        Dim DelimittedContent As String = TextBox2.Text.Replace(" ", ";")
        Dim path As String = IO.Path.Combine(Application.StartupPath, "MyTest.txt")
        ' This text is added only once to the file.
        If File.Exists(path) = False Then
            ' Create a file to write to.
            File.WriteAllText(path, "(" & TextBox1.Text & ")" & vbNewLine & DelimittedContent + vbNewLine)
        Else
            ' This text is always added, making the file longer over time
            ' if it is not deleted.
            File.AppendAllText(path, "(" & TextBox1.Text & ")" & vbNewLine & DelimittedContent + vbNewLine)
        End If
        MsgBox("Done!")
    End Sub
    Private Sub Form1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = ChrW(Keys.Escape) Then Close()
    End Sub
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Dim digitsOnly As Text.RegularExpressions.Regex = New Text.RegularExpressions.Regex("[^\d]")
        TextBox1.Text = digitsOnly.Replace(TextBox1.Text, "")
    End Sub
    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
End Class
