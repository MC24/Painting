Public Class Form1

    Dim IsMouseDown As Boolean
    Dim PenColor As Color = Color.Black
    Dim PenWidth As Integer = 10

    Dim colorChooser As New ColorDialog()

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pbCanvas.BackColor = Color.White
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        pbCanvas.CreateGraphics.Clear(Color.White)
    End Sub

    Private Sub pbCanvas_MouseDown(sender As Object, e As MouseEventArgs) Handles pbCanvas.MouseDown
        IsMouseDown = True
    End Sub

    Private Sub pbCanvas_MouseMove(sender As Object, e As MouseEventArgs) Handles pbCanvas.MouseMove
        If IsMouseDown = True Then
            pbCanvas.CreateGraphics.DrawRectangle(New Pen(PenColor), e.X, e.Y, PenWidth, 3)
        End If
    End Sub

    Private Sub pbCanvas_MouseUp(sender As Object, e As MouseEventArgs) Handles pbCanvas.MouseUp
        IsMouseDown = False
    End Sub

    Private Sub btnColor_Click(sender As Object, e As EventArgs) Handles btnColor.Click
        colorChooser.FullOpen = True

        Dim colorResult As DialogResult = colorChooser.ShowDialog()

        If colorResult = Windows.Forms.DialogResult.OK Then
            PenColor = colorChooser.Color
        End If

    End Sub

    Private Sub btnSetWidth_Click(sender As Object, e As EventArgs) Handles btnSetWidth.Click
        If Not txtPenWidth.Text Is Nothing Then
            If IsNumeric(txtPenWidth.Text) Then
                PenWidth = Int32.Parse(txtPenWidth.Text)
            End If
        End If


    End Sub
End Class
