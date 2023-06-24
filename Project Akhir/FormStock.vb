Imports System.Data.OracleClient
Public Class FormStock

    Dim stocks() As String = {"Nasi", "Bahan Pecel", "Telor", "Bahan Nasi Campur", "Mie Goreng/Kuah", "Gula", "Es Batu", "Teh Celup", "Kopi Sachet", "Nutrisari Sachet", "Coklat Sachet", "Le Minerale"}

    Dim conn As New OracleConnection
    Dim cmd As New OracleCommand
    Dim dtr As OracleDataReader

    Sub koneksi()
        conn.Close()
        conn = New OracleConnection("data source=(DESCRIPTION = " &
        "(ADDRESS = (PROTOCOL = TCP)(HOST = LAPTOP-FLAPCOIQ)(PORT = 1521)) " &
         "(CONNECT_DATA = " &
        "(SERVER = DEDICATED) " &
        "(SERVICE_NAME = XE) " &
        ") " &
        "); user id=hr; password=hr;")
        conn.Open()
    End Sub

    Sub DisplayAll()
        koneksi()
        cmd = New OracleCommand("Select * from stocks", conn)
        dtr = cmd.ExecuteReader()
        ListView1.Items.Clear()
        If dtr.HasRows Then
            While dtr.Read()
                ListView1.Items.Add(dtr.Item(0))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(dtr.Item(1))
            End While
            dtr.Close()
        End If
        dtr.Close()
        cmd.Dispose()
    End Sub

    Sub DisplaySpesifik()
        koneksi()
        cmd = New OracleCommand("Select * from stocks where barang = '" & ComboBox1.Text & "'", conn)
        dtr = cmd.ExecuteReader()
        ListView1.Items.Clear()
        If dtr.HasRows Then
            While dtr.Read()
                ListView1.Items.Add(dtr.Item(0))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(dtr.Item(1))
            End While
            dtr.Close()
        End If
        dtr.Close()
        cmd.Dispose()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MainForm.Show()
        Me.Close()
    End Sub

    Private Sub FormStock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For i As Integer = 0 To stocks.GetUpperBound(i)
            ComboBox1.Items.Add(stocks(i))
        Next

        DisplayAll()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        cmd = New OracleCommand("Update stocks set jumlah = (select jumlah from stocks where barang = '" & ComboBox1.Text & "') + " & NumericUpDown1.Value & " where barang = '" & ComboBox1.Text & "'", conn)
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        DisplaySpesifik()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        DisplaySpesifik()
    End Sub
End Class