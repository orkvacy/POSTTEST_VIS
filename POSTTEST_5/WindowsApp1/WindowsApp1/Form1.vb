Imports System.Data
Imports Guna.UI2.WinForms
Imports MySqlConnector

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TampilLibrary()
    End Sub

    Public Sub TampilLibrary()
        flpLib.Controls.Clear()
        Dim dt As DataTable = DataModule.getExec()

        For Each row As DataRow In dt.Rows
            hardCodeNewData(row)
        Next
    End Sub

    Private Sub hardCodeNewData(row As DataRow)
        Dim pnlItem As New Panel With {
            .Width = flpLib.Width - 25,
            .Height = 50,
            .Margin = New Padding(0, 0, 0, 10)
        }

        Dim btnEx As New Guna2Button With {
            .Text = $"{row("name")} ({row("muscle_group")})",
            .Size = New Size(pnlItem.Width - 90, 45),
            .TextAlign = HorizontalAlignment.Left,
            .TextOffset = New Point(10, 0)
        }

        Dim btnEdit As New Guna2Button With {
            .Text = "🖋",
            .Size = New Size(35, 35),
            .Location = New Point(btnEx.Width + 5, 5)
        }
        AddHandler btnEdit.Click, Sub()
                                      Dim popup As New Form2()
                                      popup.SetEditData(row("id"), row("name"), row("muscle_group"), row("equipment"))
                                      If popup.ShowDialog() = DialogResult.OK Then TampilLibrary()
                                  End Sub

        Dim btnDel As New Guna2Button With {
            .Text = "🗑️",
            .Size = New Size(35, 35),
            .Location = New Point(btnEdit.Location.X + 40, 5)
        }
        AddHandler btnDel.Click, Sub()
                                     If MessageBox.Show($"Hapus '{row("name")}'?", "Konfirmasi", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                                         If DataModule.delExec(row("id")) Then TampilLibrary()
                                     End If
                                 End Sub

        pnlItem.Controls.Add(btnEx)
        pnlItem.Controls.Add(btnEdit)
        pnlItem.Controls.Add(btnDel)
        flpLib.Controls.Add(pnlItem)
    End Sub


    Private Sub btnCustomExercise_Click(sender As Object, e As EventArgs) Handles btnCustomExercise.Click
        Dim popup As New Form2()
        If popup.ShowDialog() = DialogResult.OK Then TampilLibrary()
    End Sub


End Class