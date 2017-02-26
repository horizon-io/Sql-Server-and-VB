﻿Imports System.Data.SqlClient
Public Class Form1

    Dim connection As New SqlConnection("Server=(localdb)\MSSQLLocalDB;Database=VB;")

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim command As New SqlCommand("SELECT * FROM Students", connection)

        Try
            connection.Open()

            Dim reader = command.ExecuteReader()

            While reader.Read()

                ListView1.Items.Add(New ListViewItem(New String() {reader("Id"), reader("Name"), reader("Email"), reader("Age")}))

            End While

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        Finally
            connection.Close()
        End Try


    End Sub

End Class
