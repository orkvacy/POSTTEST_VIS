Imports System.Xml

Public Class Form1
    Private daftarIPS As New List(Of Double)()

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ipsBaru As Double

        Label3.Text = ""
        'paksa ubah keyboard jadi eng
        If Double.TryParse(txtIPS.Text, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, ipsBaru) Then

            If ipsBaru >= 0 AndAlso ipsBaru <= 4.0 Then
                daftarIPS.Add(ipsBaru)
                Histori.Items.Add("Semester " & daftarIPS.Count & " : " & ipsBaru.ToString("0.00", System.Globalization.CultureInfo.InvariantCulture))

                KalkulasiIPK()

                txtIPS.Clear()
                txtIPS.Focus()
            Else
                Label3.Text = "Rentang IP hanya 0-4!"
                Label3.ForeColor = Color.Red
            End If
        Else
            Label3.Text = "Input harus berupa angka"
            Label3.ForeColor = Color.Red
        End If
    End Sub

    ' --- Tombol Reset ---
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        daftarIPS.Clear()
        Histori.Items.Clear()
        Label1.Text = "-"
        Label2.Text = "-"
        Label3.Text = ""
        txtIPS.Clear()
        txtIPS.Focus()
    End Sub

    Private Sub KalkulasiIPK()
        If daftarIPS.Count > 0 Then
            Dim ipk As Double = daftarIPS.Average()

            Label1.Text = ipk.ToString("0.00", System.Globalization.CultureInfo.InvariantCulture)

            If ipk >= 3.01 Then
                Label2.Text = "Sangat Memuaskan"
            ElseIf ipk >= 2.76 Then
                Label2.Text = "Memuaskan"
            ElseIf ipk >= 2.0 Then
                Label2.Text = "Cukup"
            Else
                Label2.Text = "Kurang"
            End If
        End If
    End Sub

    'error handling
    Private Sub txtIPS_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtIPS.KeyPress
        'error handling cuma bisa input angka, titik, dan backspace
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "."c Then
            e.Handled = True
            Label3.Text = "Gunakan titik '.' untuk penggunaan koma"
            Label3.ForeColor = Color.Red
        Else
            Label3.Text = ""
        End If

        'titik cuma bisa sekali
        If e.KeyChar = "."c AndAlso txtIPS.Text.Contains(".") Then
            e.Handled = True
        End If
    End Sub


    Private Sub cekRiwayat(sender As Object, e As EventArgs) Handles Histori.SelectedIndexChanged
    End Sub

End Class