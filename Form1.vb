Imports MySql.Data.MySqlClient
Public Class Form1
    Dim conn As New MySqlConnection("host=localhost;user=root;password=;database=patient")
    Dim i As Integer
    Dim dr As MySqlDataReader
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DGV_Load()
    End Sub

    Public Sub DGV_Load()
        DataGridView1.Rows.Clear()
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT * FROM records", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                DataGridView1.Rows.Add(dr.Item("ID_NO"), dr.Item("Name"), dr.Item("Gender"), dr.Item("Age"), dr.Item("Date"))
            End While

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()

        End Try

    End Sub


    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        save()
        DGV_Load()
    End Sub
    Public Sub save()
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("INSERT INTO `records`(`ID_NO`, `Name`, `Gender`, `Age`, `Date`) VALUES (@ID_NO,@Name,@Gender,@Age,@Date)", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@ID_NO", txt_id.Text)
            cmd.Parameters.AddWithValue("@Name", txt_name.Text)
            cmd.Parameters.AddWithValue("@Gender", cmb_gender.Text)
            cmd.Parameters.AddWithValue("@Age", txt_age.Text)
            cmd.Parameters.AddWithValue("@Date", CDate(exp_datepicker.Value))

            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MessageBox.Show("Record Save Success !", "records", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Record Save Failed !", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)

        Finally
            conn.Close()

        End Try
        Clear()
    End Sub

    Public Sub Clear()
        txt_id.Clear()
        txt_name.Clear()
        cmb_gender.Text = ""
        txt_age.Clear()
        exp_datepicker.Value = Now
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        txt_id.Text = DataGridView1.CurrentRow.Cells(0).Value
        txt_name.Text = DataGridView1.CurrentRow.Cells(1).Value
        cmb_gender.Text = DataGridView1.CurrentRow.Cells(2).Value
        txt_age.Text = DataGridView1.CurrentRow.Cells(3).Value
        exp_datepicker.Text = DataGridView1.CurrentRow.Cells(4).Value

        txt_id.ReadOnly = True
        btn_save.Enabled = False
    End Sub

    Sub Edit()
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("UPDATE `records` SET `ID_NO`=@ID_NO,`Name`=@Name,`Gender`=@Gender,`Age`=@Age,`Date`=@Date WHERE `ID_NO`=@ID_NO", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@ID_NO", txt_id.Text)
            cmd.Parameters.AddWithValue("@Name", txt_name.Text)
            cmd.Parameters.AddWithValue("@Gender", cmb_gender.Text)
            cmd.Parameters.AddWithValue("@Age", txt_age.Text)
            cmd.Parameters.AddWithValue("@Date", exp_datepicker.Text)

            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MessageBox.Show("Record Update Success !", "records", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Record Update Failed !", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)

        Finally
            conn.Close()

        End Try
        Clear()
        DGV_Load()

    End Sub
    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        Edit()

    End Sub

    Public Sub delete()
        If MsgBox("Are You Sure You Want to delete this Record?", MsgBoxStyle.Question + vbYesNo) = vbYes Then
            Try
                conn.Open()
                Dim cmd As New MySqlCommand("DELETE  FROM `records`  WHERE `ID_NO`=@ID_NO", conn)
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@ID_NO", txt_id.Text)

                i = cmd.ExecuteNonQuery
                If i > 0 Then
                    MessageBox.Show("Record Deleted succesfully !", "records", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Record Delete Failed !", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                End If

            Catch ex As Exception
                MsgBox(ex.Message)

            Finally
                conn.Close()

            End Try
            Clear()
            DGV_Load()

        Else
            Return
        End If
    End Sub
    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        delete()
    End Sub

    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        Clear()
    End Sub

    Private Sub txt_search_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged
        DataGridView1.Rows.Clear()
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT * FROM records WHERE ID_NO like '%" & txt_search.Text & "%' OR Name like '%" & txt_search.Text & "%'", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                DataGridView1.Rows.Add(dr.Item("ID_NO"), dr.Item("Name"), dr.Item("Gender"), dr.Item("Age"), dr.Item("Date"))
            End While

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()

        End Try

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub txt_reg_TextChanged(sender As Object, e As EventArgs) Handles txt_id.TextChanged

    End Sub
End Class