Imports System.Data.OracleClient
Public Class Reports

    Dim conn As New OracleConnection("data source=(DESCRIPTION = " &
        "(ADDRESS = (PROTOCOL = TCP)(HOST = LAPTOP-FLAPCOIQ)(PORT = 1521)) " &
         "(CONNECT_DATA = " &
        "(SERVER = DEDICATED) " &
        "(SERVICE_NAME = XE) " &
        ") " &
        "); user id=hr; password=hr;")
    Dim cmd As OracleCommand
    Dim dta As New OracleDataAdapter
    Dim dt As New DataSet

    Sub ShowReportsAll()
        Try
            conn.Open()
            FormHistory.DateTimePicker1.Format = DateTimePickerFormat.Custom
            cmd = New OracleCommand("Select tanggal, id_pesanan, pesanan, harga from pesanan order by Tanggal, id_pesanan", conn)
            dta.SelectCommand = cmd
            dta.Fill(dt, "Pesanan")
            Dim report As New CrystalReport1
            report.SetDataSource(dt)
            CrystalReportViewer1.ReportSource = report
            CrystalReportViewer1.Refresh()
            cmd.Dispose()
            dta.Dispose()
            dt.Dispose()
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
        conn.Close()
    End Sub

    Sub ShowReports()
        Try
            conn.Open()
            FormHistory.DateTimePicker1.Format = DateTimePickerFormat.Custom
            cmd = New OracleCommand("Select tanggal, id_pesanan, pesanan, harga from pesanan where Tanggal = '" & FormHistory.DateTimePicker1.Value.ToString("dd-MMM-yy").ToUpper & "' order by Tanggal, id_pesanan", conn)
            dta.SelectCommand = cmd
            dta.Fill(dt, "Pesanan")
            Dim report As New CrystalReport1
            report.SetDataSource(dt)
            CrystalReportViewer1.ReportSource = report
            CrystalReportViewer1.Refresh()
            cmd.Dispose()
            dta.Dispose()
            dt.Dispose()
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
        conn.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FormHistory.Show()
        Me.Close()
    End Sub

    Private Sub Reports_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class