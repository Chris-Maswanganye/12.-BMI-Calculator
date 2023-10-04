Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Height As Double
        Dim weight As Double
        Dim BMI As Double

        Height = Val(TextBox1.Text)
        weight = Val(TextBox2.Text)

        BMI = Height / (weight) * 2

        TextBox3.Text = BMI

        If BMI < 18 Then
            TextBox4.Text = "Yo are overweight"
        ElseIf 18 <= BMI And BMI < 26 Then
            TextBox4.Text = "You are normal"
        Else
            TextBox4.Text = "You are overweight"
        End If


    End Sub
End Class
