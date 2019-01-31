Public Class unmetered
    Dim total As Double
    Dim Unit As Double
    Dim Amount As Double
    Dim discount As Double
    Dim discount1 As Double
    Dim con As New OleDb.OleDbConnection
    Dim dbProvider As String
    Dim dbSource As String
    Dim ds As New DataSet
    Dim da As OleDb.OleDbDataAdapter
    Dim sql As String
  

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub calculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub RadioButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles visa.Click
        If visa.Checked Then
            txtmode.Text = "Visa"
        End If

        If txtunit.Text <= 100 Then
            Unit = txtunit.Text * 33
            total = Unit
            total = total - (total * 0.05)
            txtamount.Text = total
        End If
        If txtunit.Text > 100 Then
            Unit = txtunit.Text * 30
            total = Unit
            total = total - (total * 0.09)
            total = total - (total * 0.05)
            txtamount.Text = total
        End If
    End Sub

    Private Sub txtunit_keypress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtunit.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtamount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtamount.TextChanged

    End Sub

    Private Sub manual_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles manual.Click
        If manual.Checked Then
            txtmode.Text = "Manual"
        End If

        If txtunit.Text < 100 Then
            Unit = txtunit.Text * 33
            txtamount.Text = Unit
        End If
        If txtunit.Text >= 100 Then
            Unit = txtunit.Text * 30
            total = Unit
            total = total - (total * 0.09)
            txtamount.Text = total
        End If
    End Sub

    Private Sub btnexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexit.Click
        Application.Exit()
    End Sub

    Private Sub btnback_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnback.Click
        Me.Hide()
        ksmwater.Show()
    End Sub

    Private Sub btnload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnload.Click
        dbProvider = "PROVIDER=Microsoft.Jet.OLEDB.4.0;"
        dbSource = "Data Source=C:/Users/Raquelito/Documents/Kisumu.mdb"
        con.ConnectionString = dbProvider & dbSource


        con.Open()
        sql = "Select * FROM unmetered"
        da = New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(ds, "kisumu")
        MsgBox("Dbase is open")

        txtmode.Text = ds.Tables("kisumu").Rows(0).Item(0)
        txtamount.Text = ds.Tables("kisumu").Rows(0).Item(1)
        txtunit.Text = ds.Tables("kisumu").Rows(0).Item(2)

        con.Close()
        txtunit.Clear()
        txtamount.Clear()
        txtmode.Clear()

        MsgBox("Dbase is close")
    End Sub

    Private Sub btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd.Click
        Dim cb As New OleDb.OleDbCommandBuilder(da)
        Dim dsNewRow As DataRow
        Dim count As Integer

        Try
            If count <> -1 Then
                dsNewRow = ds.Tables("kisumu").NewRow()
                dsNewRow.Item("mode") = txtmode.Text
                dsNewRow.Item("total") = txtamount.Text
                dsNewRow.Item("units") = txtunit.Text



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
                Form4.txtmeter.Text = "Null"
                Form4.txtmode.Text = txtmode.Text
                Form4.txtunit.Text = txtunit.Text
                Form4.txtamount.Text = txtamount.Text
            End If
        Catch ex As Exception
            MsgBox("Search Failed!!!" + ex.Message)
        End Try
    End Sub
End Class