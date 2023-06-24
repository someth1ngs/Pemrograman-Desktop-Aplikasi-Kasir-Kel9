Imports System.Data.OracleClient
Module AlatModule

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
End Module
