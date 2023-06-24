Imports System.Data.OracleClient
Public Class MainForm

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

    Sub DisplayListViewPesanan()
        koneksi()
        cmd = New OracleCommand("Select * from pesanan where ID_PESANAN = '" & idpesan.Text & "' order by tipe", conn)
        dtr = cmd.ExecuteReader()
        ListView1.Items.Clear()
        If dtr.HasRows Then
            While dtr.Read()
                ListView1.Items.Add(dtr.Item(4))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(dtr.Item(3))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(dtr.Item(5))
            End While
            dtr.Close()
        End If
        dtr.Close()
        cmd.Dispose()
    End Sub

    Sub Total()
        Dim total As Integer
        For i As Integer = 0 To ListView1.Items.Count - 1
            total = total + ListView1.Items(i).SubItems(2).Text
        Next
        TextBox1.Text = total
    End Sub

    Dim temp As String

    Sub Generate()
        koneksi()
        temp = ""
        cmd = New OracleCommand("select case when max(to_number(substr(id_pesanan, 3, 4))) is null then 1 else max(to_number(substr(id_pesanan, 3, 4))) + 1 END from pesanan", conn)
        dtr = cmd.ExecuteReader()
        dtr.Read()
        idpesan.Text = dtr.Item(0)
        For i As Integer = 1 To 4 - idpesan.TextLength
            temp = temp & "0"
        Next
        idpesan.Text = "PL" & temp & idpesan.Text
        dtr.Close()
        cmd.Dispose()
    End Sub

    Dim mejas() As String = {"Meja ke-1", "Meja ke-2", "Meja ke-3", "Meja ke-4", "Meja ke-5", "Meja ke-6"}

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For i As Integer = 0 To mejas.GetUpperBound(i)
            meja.Items.Add(mejas(i))
        Next
    End Sub

    Private Sub makanan_Click(sender As Object, e As EventArgs) Handles makanan.Click
        MakananForm.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        LoginForm.Show()
        Me.Close()
    End Sub

    Private Sub minuman_Click(sender As Object, e As EventArgs) Handles minuman.Click
        MinumanForm.Show()
        Me.Hide()
    End Sub

    Dim _itm As ListViewItem
    Private Sub pesan_Click(sender As Object, e As EventArgs) Handles pesan.Click
        If ListView1.Items.Count > 0 Then
            ListView1.Items.Clear()
            TextBox1.Text = "Sudah Terbayar"
            nama.Text = ""
            idpesan.Text = ""
            meja.SelectedIndex = -1
        Else MsgBox("Data Masih Kosong")
        End If
    End Sub

    Private Sub history_Click(sender As Object, e As EventArgs) Handles history.Click
        FormHistory.Show()
        Me.Hide()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        FormStock.Show()
        Me.Hide()
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        koneksi()
        cmd = New OracleCommand("delete from pesanan where rowid in (select MAX(rowid) from pesanan group by pesanan) and pesanan = '" & ListView1.Items(ListView1.FocusedItem.Index).SubItems(0).Text & "' and id_pesanan ='" & idpesan.Text & "'", conn)
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        If ListView1.Items(ListView1.FocusedItem.Index).SubItems(0).Text = "Nasi Pecel" Then
            cmd = New OracleCommand("Update stocks set jumlah = (select jumlah from stocks where barang = 'Nasi') + 1 where barang = 'Nasi'", conn)
            cmd.ExecuteNonQuery()
            cmd.Dispose()

            cmd = New OracleCommand("Update stocks set jumlah = (select jumlah from stocks where barang = 'Bahan Pecel') + 1 where barang = 'Bahan Pecel'", conn)
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        ElseIf ListView1.Items(ListView1.FocusedItem.Index).SubItems(0).Text = "Nasi Telor" Then
            cmd = New OracleCommand("Update stocks set jumlah = (select jumlah from stocks where barang = 'Nasi') + 1 where barang = 'Nasi'", conn)
            cmd.ExecuteNonQuery()
            cmd.Dispose()

            cmd = New OracleCommand("Update stocks set jumlah = (select jumlah from stocks where barang = 'Telor') + 1 where barang = 'Telor'", conn)
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        ElseIf ListView1.Items(ListView1.FocusedItem.Index).SubItems(0).Text = "Nasi Campur" Then
            cmd = New OracleCommand("Update stocks set jumlah = (select jumlah from stocks where barang = 'Nasi') + 1 where barang = 'Nasi'", conn)
            cmd.ExecuteNonQuery()
            cmd.Dispose()

            cmd = New OracleCommand("Update stocks set jumlah = (select jumlah from stocks where barang = 'Bahan Nasi Campur') + 1 where barang = 'Bahan Nasi Campur'", conn)
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        ElseIf ListView1.Items(ListView1.FocusedItem.Index).SubItems(0).Text = "Mie Telor" Then
            cmd = New OracleCommand("Update stocks set jumlah = (select jumlah from stocks where barang = 'Mie Goreng/Kuah') + 1 where barang = 'Mie Goreng/Kuah'", conn)
            cmd.ExecuteNonQuery()
            cmd.Dispose()

            cmd = New OracleCommand("Update stocks set jumlah = (select jumlah from stocks where barang = 'Telor') + 1 where barang = 'Telor'", conn)
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        ElseIf ListView1.Items(ListView1.FocusedItem.Index).SubItems(0).Text = "Mie Goreng/Kuah" Then
            cmd = New OracleCommand("Update stocks set jumlah = (select jumlah from stocks where barang = 'Mie Goreng/Kuah') + 1 where barang = 'Mie Goreng/Kuah'", conn)
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        ElseIf ListView1.Items(ListView1.FocusedItem.Index).SubItems(0).Text = "Mie Nasi" Then
            cmd = New OracleCommand("Update stocks set jumlah = (select jumlah from stocks where barang = 'Mie Goreng/Kuah') + 1 where barang = 'Mie Goreng/Kuah'", conn)
            cmd.ExecuteNonQuery()
            cmd.Dispose()

            cmd = New OracleCommand("Update stocks set jumlah = (select jumlah from stocks where barang = 'Nasi') + 1 where barang = 'Nasi'", conn)
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        End If

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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Generate()
    End Sub

    Private Sub idpesan_TextChanged(sender As Object, e As EventArgs) Handles idpesan.TextChanged
        koneksi()
        cmd = New OracleCommand("Select * from pesanan where id_pesanan = '" & idpesan.Text & "' order by tipe", conn)
        dtr = cmd.ExecuteReader()
        ListView1.Items.Clear()
        nama.Text = ""
        meja.SelectedIndex = -1
        If dtr.HasRows Then
            While dtr.Read()
                nama.Text = dtr.Item(1)
                meja.Text = dtr.Item(2)
                ListView1.Items.Add(dtr.Item(4))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(dtr.Item(3))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(dtr.Item(5))
            End While
            dtr.Close()
        End If
        dtr.Close()
        cmd.Dispose()

        Total()
    End Sub

    Private Sub Bayar_TextChanged(sender As Object, e As EventArgs) Handles Bayar.TextChanged
        If Bayar.TextLength > 0 Then
            Kembali.Text = Bayar.Text - TextBox1.Text
        End If
    End Sub
End Class
