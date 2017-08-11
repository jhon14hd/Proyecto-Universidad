Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        resultado.Text = Val(nota1.Text) + Val(nota2.Text) + Val(nota3.Text) + Val(nota4.Text) + Val(nota5.Text)
   
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        nota1.Clear()
        nota2.Clear()
        nota3.Clear()
        nota4.Clear()
        nota5.Clear()
        resultado.Clear()
        nota1.Focus()









    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MessageBox.Show("Nombre: Jhon Jairo Heredia, Matricula: 14-EISN-1-198 ", "Datos Del Estudiante")

    End Sub
End Class
