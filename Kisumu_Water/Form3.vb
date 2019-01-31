Imports System.Data.SqlClient

Public Class metered
    Dim total As Double
    Dim Unit As Double
    Dim discount As Double
    Dim discount1 As Double
    Dim con As New OleDb.OleDbConnection
    Dim dbProvider As String
    Dim dbSource As String
    Dim ds As New DataSet
    Dim da As OleDb.OleDbDataAdapter
    Dim sql As String
    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtunit.TextChanged

    End Sub

    Private Sub txtamount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtamount.TextChanged

    End Sub

    Private Sub calculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub



    Private Sub visam_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles visam.Click

        If visam.Checked Then
            paye.Text = "Visa"
        End If

        If txtunit.Text < 100 Then
            Unit = txtunit.Text * 33
            discount = Unit - (Unit * 0.1)
            total = discount + 500
            total = total - (total * 0.05)

            txtamount.Text = total
        End If
        If txtunit.Text >= 100 Then
            Unit = txtunit.Text * 30
            discount = Unit - (Unit * 0.1)
            total = total - (total * 0.09)
            total = discount + 500
            total = total - (total * 0.05)

            txtamount.Text = total
        End If

    End Sub

    Private Sub manualm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles manualm.Click
        If manualm.Checked Then
            paye.Text = "Manual"
        End If

        If txtunit.Text < 100 Then
            Unit = txtunit.Text * 33
            discount = Unit - (Unit * 0.1)
            total = discount + 500
            txtamount.Text = total
        End If
        If txtunit.Text >= 100 Then
            Unit = txtunit.Text * 30
            discount = Unit - (Unit * 0.1)
            total = total - (total * 0.09)
            total = discount + 500
            txtamount.Text = total
        End If
    End Sub

    Private Sub metered_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexit.Click
        Application.Exit()
    End Sub



    Private Sub btnLoad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoad.Click

        dbProvider = "PROVIDER=Microsoft.Jet.OLEDB.4.0;"
        dbSource = "Data Source=C:/Users/Raquelito/Documents/Kisumu.mdb"
        con.ConnectionString = dbProvider & dbSource


        con.Open()
        sql = "Select * FROM metered"
        da = New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(ds, "kisumu")
        ' MsgBox("Dbase is open")

        txtNo.Text = ds.Tables("kisumu").Rows(0).Item(0)
        txtunit.Text = ds.Tables("kisumu").Rows(0).Item(1)
        txtamount.Text = ds.Tables("kisumu").Rows(0).Item(2)
        paye.Text = ds.Tables("kisumu").Rows(0).Item(3)

        con.Close()
        txtNo.Clear()
        txtunit.Clear()
        txtamount.Clear()
        paye.Clear()

        '        MsgBox("Dbase is close")

    End Sub

    Private Sub btbAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btbAdd.Click
        Dim cb As New OleDb.OleDbCommandBuilder(da)
        Dim dsNewRow As DataRow
        Dim count As Integer

        Try
            If count <> -1 Then
                dsNewRow = ds.Tables("kisumu").NewRow()
                dsNewRow.Item("meter_no") = txtNo.Text
                dsNewRow.Item("units") = txtunit.Text
                dsNewRow.Item("mode") = paye.Text
                dsNewRow.Item("total") = txtamount.Text

                ds.Tables("kisumu").Rows.Add(dsNewRow)
                da.Update(ds, "kisumu")
                MsgBox("New Record Added To The Database")

            End If
        Catch ex As Exception
            MsgBox("Update not possible" + ex.Message)
        End Try
    End Sub

    Private Sub btnprint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnprint.Click
        Dim mySearch As String = InputBox("Enter Name")

        Try
            If mySearch <> "" Then
                sql = "select * from metered where full_name LIKE '%" & mySearch & "%' "
                Dim dt As New DataTable
                ds = New DataSet()
                da = New OleDb.OleDbDataAdapter(sql, con)
                ds.Tables.Add(dt)
                da.Fill(dt)


                Me.Hide()
                Form4.Show()
                Form4.txtmeter.Text = txtNo.Text
                Form4.txtmode.Text = paye.Text
                Form4.txtunit.Text = txtunit.Text
                Form4.txtamount.Text = txtamount.Text
            End If
        Catch ex As Exception
            MsgBox("Search Failed!!!" + ex.Message)
        End Try
    End Sub

    Private Sub paye_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles paye.TextChanged

    End Sub

    Private Sub visam_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles visam.CheckedChanged

    End Sub
End Class