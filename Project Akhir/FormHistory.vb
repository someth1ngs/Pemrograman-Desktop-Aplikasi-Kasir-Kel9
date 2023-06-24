Imports System.Data.OracleClient
Public Class FormHistory

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
    Private Sub FormHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        cmd = New OracleCommand("Select * from pesanan where tanggal not in ('01-JAN-00') order by TANGGAL, id_pesanan", conn)
        dtr = cmd.ExecuteReader()
        ListView1.Items.Clear()
        If dtr.HasRows Then
            While dtr.Read()
                ListView1.Items.Add(dtr.Item(6))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(dtr.Item(0))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(dtr.Item(1))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(dtr.Item(2))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(dtr.Item(3))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(dtr.Item(4))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(dtr.Item(5))
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

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        cmd = New OracleCommand("select * from pesanan where tanggal = '" & DateTimePicker1.Value.ToString("dd-MMM-yy").ToUpper & "' and tanggal not in ('01-JAN-00')", conn)
        dtr = cmd.ExecuteReader()
        ListView1.Items.Clear()
        If dtr.HasRows Then
            While dtr.Read()
                ListView1.Items.Add(dtr.Item(6))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(dtr.Item(0))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(dtr.Item(1))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(dtr.Item(2))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(dtr.Item(3))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(dtr.Item(4))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(dtr.Item(5))
            End While
            dtr.Close()
        End If
        dtr.Close()
        cmd.Dispose()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Reports.Show()
        Reports.ShowReports()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Reports.Show()
        Reports.ShowReportsAll()
        Me.Hide()
    End Sub
End Class