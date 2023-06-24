Imports System.Data.OracleClient
Public Class MinumanForm

    Dim conn As New OracleConnection
    Dim cmd As New OracleCommand
    Dim dtr As OracleDataReader
    Dim ctr As Control

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

    Sub DisplayListViewPesanan()
        koneksi()
        cmd = New OracleCommand("Select * from pesanan where ID_PESANAN = '" & MainForm.idpesan.Text & "' and tipe = 'Minuman'", conn)
        dtr = cmd.ExecuteReader()
        ListView1.Items.Clear()
        If dtr.HasRows Then
            While dtr.Read()
                ListView1.Items.Add(dtr.Item(4))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(dtr.Item(5))
            End While
            dtr.Close()
        End If
        dtr.Close()
        cmd.Dispose()
    End Sub

    Sub Total()
        If LinkLabel1.Enabled Or LinkLabel2.Enabled Or LinkLabel3.Enabled Or LinkLabel4.Enabled Or LinkLabel5.Enabled Or LinkLabel6.Enabled Then
            Dim total As Integer
            For i As Integer = 0 To ListView1.Items.Count - 1
                total = total + ListView1.Items(i).SubItems(1).Text
            Next
            TextBox1.Text = total
        End If
    End Sub

    Private Sub MinumanForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        ListView1.Items.Clear()
        DisplayListViewPesanan()
        Total()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        cmd = New OracleCommand("Insert into pesanan values ('" & MainForm.idpesan.Text & "','" &
MainForm.nama.Text & "','" & MainForm.meja.Text & "', 'Minuman', 'Es Teh Jumbo', 5000, (Select To_Char(Sysdate, 'DD-MON-YY') from dual))", conn)
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        cmd = New OracleCommand("Update stocks set jumlah = (select jumlah from stocks where barang = 'Es Batu') - 1 where barang = 'Es Batu'", conn)
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        cmd = New OracleCommand("Update stocks set jumlah = (select jumlah from stocks where barang = 'Gula') - 1 where barang = 'Gula'", conn)
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        cmd = New OracleCommand("Update stocks set jumlah = (select jumlah from stocks where barang = 'Teh Celup') - 1 where barang = 'Teh Celup'", conn)
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        DisplayListViewPesanan()
        Total()
    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        cmd = New OracleCommand("Insert into pesanan values ('" & MainForm.idpesan.Text & "','" &
MainForm.nama.Text & "','" & MainForm.meja.Text & "', 'Minuman', 'Es Kopi', 6000, (Select To_Char(Sysdate, 'DD-MON-YY') from dual))", conn)
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        cmd = New OracleCommand("Update stocks set jumlah = (select jumlah from stocks where barang = 'Es Batu') - 1 where barang = 'Es Batu'", conn)
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        cmd = New OracleCommand("Update stocks set jumlah = (select jumlah from stocks where barang = 'Kopi Sachet') - 1 where barang = 'Kopi Sachet'", conn)
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        DisplayListViewPesanan()
        Total()
    End Sub

    Private Sub LinkLabel4_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel4.LinkClicked
        cmd = New OracleCommand("Insert into pesanan values ('" & MainForm.idpesan.Text & "','" &
MainForm.nama.Text & "','" & MainForm.meja.Text & "', 'Minuman', 'Es Nutrisari', 7000, (Select To_Char(Sysdate, 'DD-MON-YY') from dual))", conn)
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        cmd = New OracleCommand("Update stocks set jumlah = (select jumlah from stocks where barang = 'Es Batu') - 1 where barang = 'Es Batu'", conn)
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        cmd = New OracleCommand("Update stocks set jumlah = (select jumlah from stocks where barang = 'Nutrisari Sachet') - 1 where barang = 'Nutrisari Sachet'", conn)
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        DisplayListViewPesanan()
        Total()
    End Sub

    Private Sub LinkLabel6_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel6.LinkClicked
        cmd = New OracleCommand("Insert into pesanan values ('" & MainForm.idpesan.Text & "','" &
MainForm.nama.Text & "','" & MainForm.meja.Text & "', 'Minuman', 'Es Coklat', 8000, (Select To_Char(Sysdate, 'DD-MON-YY') from dual))", conn)
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        cmd = New OracleCommand("Update stocks set jumlah = (select jumlah from stocks where barang = 'Es Batu') - 1 where barang = 'Es Batu'", conn)
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        cmd = New OracleCommand("Update stocks set jumlah = (select jumlah from stocks where barang = 'Coklat Sachet') - 1 where barang = 'Coklat Sachet'", conn)
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        DisplayListViewPesanan()
        Total()
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        cmd = New OracleCommand("Insert into pesanan values ('" & MainForm.idpesan.Text & "','" &
MainForm.nama.Text & "','" & MainForm.meja.Text & "', 'Minuman', 'Teh Hangat Jumbo', 4000, (Select To_Char(Sysdate, 'DD-MON-YY') from dual))", conn)
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        cmd = New OracleCommand("Update stocks set jumlah = (select jumlah from stocks where barang = 'Gula') - 1 where barang = 'Gula'", conn)
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        cmd = New OracleCommand("Update stocks set jumlah = (select jumlah from stocks where barang = 'Teh Celup') - 1 where barang = 'Teh Celup'", conn)
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        DisplayListViewPesanan()
        Total()
    End Sub

    Private Sub LinkLabel5_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel5.LinkClicked
        cmd = New OracleCommand("Insert into pesanan values ('" & MainForm.idpesan.Text & "','" &
MainForm.nama.Text & "','" & MainForm.meja.Text & "', 'Minuman', 'Le Minerale', 4000, (Select To_Char(Sysdate, 'DD-MON-YY') from dual))", conn)
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        cmd = New OracleCommand("Update stocks set jumlah = (select jumlah from stocks where barang = 'Le Minerale') - 1 where barang = 'Le Minerale'", conn)
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        DisplayListViewPesanan()
        Total()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        cmd = New OracleCommand("Select * from pesanan where ID_PESANAN = '" & MainForm.idpesan.Text & "'", conn)
        dtr = cmd.ExecuteReader()
        MainForm.ListView1.Items.Clear()
        If dtr.HasRows Then
            While dtr.Read()
                MainForm.ListView1.Items.Add(dtr.Item(4))
                MainForm.ListView1.Items(MainForm.ListView1.Items.Count - 1).SubItems.Add(dtr.Item(3))
                MainForm.ListView1.Items(MainForm.ListView1.Items.Count - 1).SubItems.Add(dtr.Item(5))
            End While
            dtr.Close()
        End If
        dtr.Close()
        cmd.Dispose()
        MainForm.Show()
        MainForm.Total()
        Me.Close()
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        cmd = New OracleCommand("delete from pesanan where rowid in (select MIN(rowid) from pesanan group by pesanan) and pesanan = '" & ListView1.Items(ListView1.FocusedItem.Index).SubItems(0).Text & "' and id_pesanan ='" & MainForm.idpesan.Text & "'", conn)
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        If ListView1.Items(ListView1.FocusedItem.Index).SubItems(0).Text = "Es Teh Jumbo" Then

            cmd = New OracleCommand("Update stocks set jumlah = (select jumlah from stocks where barang = 'Es Batu') + 1 where barang = 'Es Batu'", conn)
            cmd.ExecuteNonQuery()
            cmd.Dispose()

            cmd = New OracleCommand("Update stocks set jumlah = (select jumlah from stocks where barang = 'Gula') + 1 where barang = 'Gula'", conn)
            cmd.ExecuteNonQuery()
            cmd.Dispose()

            cmd = New OracleCommand("Update stocks set jumlah = (select jumlah from stocks where barang = 'Teh Celup') + 1 where barang = 'Teh Celup'", conn)
            cmd.ExecuteNonQuery()
            cmd.Dispose()

        ElseIf ListView1.Items(ListView1.FocusedItem.Index).SubItems(0).Text = "Es Kopi" Then

            cmd = New OracleCommand("Update stocks set jumlah = (select jumlah from stocks where barang = 'Es Batu') + 1 where barang = 'Es Batu'", conn)
            cmd.ExecuteNonQuery()
            cmd.Dispose()

            cmd = New OracleCommand("Update stocks set jumlah = (select jumlah from stocks where barang = 'Kopi Sachet') + 1 where barang = 'Kopi Sachet'", conn)
            cmd.ExecuteNonQuery()
            cmd.Dispose()

        ElseIf ListView1.Items(ListView1.FocusedItem.Index).SubItems(0).Text = "Es Nutrisari" Then

            cmd = New OracleCommand("Update stocks set jumlah = (select jumlah from stocks where barang = 'Es Batu') + 1 where barang = 'Es Batu'", conn)
            cmd.ExecuteNonQuery()
            cmd.Dispose()

            cmd = New OracleCommand("Update stocks set jumlah = (select jumlah from stocks where barang = 'Nutrisari Sachet') + 1 where barang = 'Nutrisari Sachet'", conn)
            cmd.ExecuteNonQuery()
            cmd.Dispose()

        ElseIf ListView1.Items(ListView1.FocusedItem.Index).SubItems(0).Text = "Es Coklat" Then

            cmd = New OracleCommand("Update stocks set jumlah = (select jumlah from stocks where barang = 'Es Batu') + 1 where barang = 'Es Batu'", conn)
            cmd.ExecuteNonQuery()
            cmd.Dispose()

            cmd = New OracleCommand("Update stocks set jumlah = (select jumlah from stocks where barang = 'Coklat Sachet') + 1 where barang = 'Coklat Sachet'", conn)
            cmd.ExecuteNonQuery()
            cmd.Dispose()

        ElseIf ListView1.Items(ListView1.FocusedItem.Index).SubItems(0).Text = "Teh Hangat Jumbo" Then

            cmd = New OracleCommand("Update stocks set jumlah = (select jumlah from stocks where barang = 'Gula') + 1 where barang = 'Gula'", conn)
            cmd.ExecuteNonQuery()
            cmd.Dispose()

            cmd = New OracleCommand("Update stocks set jumlah = (select jumlah from stocks where barang = 'Teh Celup') + 1 where barang = 'Teh Celup'", conn)
            cmd.ExecuteNonQuery()
            cmd.Dispose()

        ElseIf ListView1.Items(ListView1.FocusedItem.Index).SubItems(0).Text = "Le Minerale" Then

            cmd = New OracleCommand("Update stocks set jumlah = (select jumlah from stocks where barang = 'Le Minerale') + 1 where barang = 'Le Minerale'", conn)
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        End If


        DisplayListViewPesanan()
        Total()
    End Sub
End Class