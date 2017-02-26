Imports System.Data.SqlClient
Public Class Form1

    Dim connection As New SqlConnection("Server=(localdb)\MSSQLLocalDB;Database=VB;")

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim adpater As New SqlDataAdapter("SELECT * FROM Students", connection)

        Dim dataset As New DataSet()

        Try

            adpater.Fill(dataset)

            For Each row In dataset.Tables(0).Rows

                Dim item As ListViewItem = ListView1.Items.Add(row("Id"))
                item.SubItems.Add(row("Name"))
                item.SubItems.Add(row("Email"))
                item.SubItems.Add(row("Age"))

            Next

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try


    End Sub

End Class
