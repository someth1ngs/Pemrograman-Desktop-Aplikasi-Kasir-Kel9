Imports System.Data.OracleClient
Imports System.Data.SqlClient
Public Class LoginForm

    Public Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim conn As OracleConnection = New OracleConnection("data source=(DESCRIPTION = " &
        "(ADDRESS = (PROTOCOL = TCP)(HOST = LAPTOP-FLAPCOIQ)(PORT = 1521)) " &
         "(CONNECT_DATA = " &
        "(SERVER = DEDICATED) " &
        "(SERVICE_NAME = XE) " &
        ") " &
        "); user id=hr; password=hr;")
        Dim comd As OracleCommand = New OracleCommand("select * from akun where ID = '" & TextBox1.Text & "' and password = '" & TextBox2.Text & "'", conn)
        Dim sda As OracleDataAdapter = New OracleDataAdapter(comd)
        Dim dt As DataTable = New DataTable()
        sda.Fill(dt)
        If (dt.Rows.Count > 0) Then
            MessageBox.Show("Login Success", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

            MainForm.Show()
            Me.Hide()
            If TextBox1.Text = "kasir" Then
                MainForm.LinkLabel1.Enabled = False
                MainForm.LinkLabel1.Visible = False
            End If
            TextBox1.Text = ""
            TextBox2.Text = ""
        Else
            MessageBox.Show("ID/Password Salah!!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Me.Close()
    End Sub

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            TextBox2.PasswordChar = ""
        Else TextBox2.PasswordChar = "*"
        End If
    End Sub
End Class