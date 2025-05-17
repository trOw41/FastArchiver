Imports System.Windows.Forms
Imports Windows.UI

Public Class Dialog1
    Private colors As New List(Of String) From {"Red", "Green", "Blue", "Yellow", "Black"}
    Dim cold As ColorDialog
    Private Sub Dialog1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Initialize the PageSetupDialog
        ComboBox1.Items.Clear()
        For Each c As String In colors
            ComboBox1.Items.Add(c)
        Next
        FontBox.Items.Clear()
        For Each f As FontFamily In System.Drawing.FontFamily.Families
            FontBox.Items.Add(f.Name)
        Next
    End Sub
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Öffnen Sie den Farbauswahldialog
        Dim colorDialog As New ColorDialog()
        If colorDialog.ShowDialog() = DialogResult.OK Then
            ' Setzen Sie die Hintergrundfarbe des Formulars auf die ausgewählte Farbe
            ComboBox1.Items.Add(colorDialog.Color.ToString())
            Form1.BackColor = colorDialog.Color
            Me.BackColor = colorDialog.Color
        End If
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        ' Die Farbauswahl anhand des ausgewählten Index setzen
        Dim selectedIndex As Integer = ComboBox1.SelectedIndex
        If selectedIndex >= 0 Then
            Dim color As System.Drawing.Color
            Select Case selectedIndex
                Case 0
                    color = System.Drawing.Color.Red
                Case 1
                    color = System.Drawing.Color.Green
                Case 2
                    color = System.Drawing.Color.Blue
                Case 3
                    color = System.Drawing.Color.Yellow
                Case 4
                    color = System.Drawing.Color.Black
                Case Else
                    color = System.Drawing.Color.White

            End Select
            Form1.BackColor = color
            Me.BackColor = color
        End If
    End Sub


    Private Sub FontBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles FontBox.SelectedIndexChanged
        If FontBox.SelectedItem IsNot Nothing Then

            Form1.Form1Font(Me, New Font(FontBox.SelectedItem.ToString(), 9, FontStyle.Regular))

        End If
    End Sub
End Class
