Imports System.Data.SqlClient
Public Class Employee
    Dim conn As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\School Files\3.2\Application Programming II\EmployeeManagementSystem\Database\EmployeesDB.mdf;Integrated Security=True;Connect Timeout=30")

    Private Sub Employee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PopulateDataGrid()
    End Sub

    Private Sub PopulateDataGrid()
        conn.Open()
        Dim sql_query = "SELECT * FROM EmployeesTbl"
        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter(sql_query, conn)
        Dim builder As SqlCommandBuilder
        builder = New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0)
        conn.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        conn.Open()
        Dim query As String
        query = "INSERT INTO EmployeesTbl VALUES('" & Empname.Text & "','" & Empaddress.Text & "','" & Empgender.SelectedItem.ToString() & "', '" & Empposition.SelectedItem.ToString() & "', '" & Empphone.Text & "', '" & Empeducation.SelectedItem.ToString() & "', '" & EmpDOB.Value & "')"
        Dim cmd As SqlCommand
        cmd = New SqlCommand(query, conn)
        cmd.ExecuteNonQuery()
        MsgBox("Employee Added")
        conn.Close()
        PopulateDataGrid()
    End Sub
    Dim key = 0
    Private Sub Clear()
        Empname.Clear()
        Empaddress.Text = ""
        Empphone.Text = ""
        Empposition.Text = ""
        Empgender.Text = ""
        Empeducation.Text = ""
        key = 0
    End Sub

    Private Sub DataGridView1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
        key = Convert.ToInt32(row.Cells(0).Value.ToString())
        Empname.Text = row.Cells(1).Value.ToString()
        Empaddress.Text = row.Cells(2).Value.ToString()
        Empgender.Text = row.Cells(3).Value.ToString()
        Empposition.Text = row.Cells(4).Value.ToString()
        Empphone.Text = row.Cells(5).Value.ToString()
        Empeducation.Text = row.Cells(6).Value.ToString()
        EmpDOB.Value = row.Cells(7).Value.ToString()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If key = 0 Then
            MsgBox("Select the employee to be deleted")
        Else
            Try
                conn.Open()
                Dim query As String
                query = "DELETE FROM EmployeesTbl WHERE ID = " & key & ""
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, conn)
                cmd.ExecuteNonQuery()
                MsgBox("Employed Deleted")
                conn.Close()
                PopulateDataGrid()
                Clear()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Empname.Text = "" Or Empaddress.Text = "" Or Empphone.Text = "" Then
            MsgBox("Missing Information")
        Else
            conn.Open()
            Dim query As String
            query = "UPDATE EmployeesTbl set name='" & Empname.Text & "', address='" & Empaddress.Text & "', gender='" & Empgender.SelectedItem.ToString() & "', position='" & Empposition.SelectedItem.ToString() & "', phone='" & Empphone.Text & "', education='" & Empeducation.SelectedItem.ToString() & "', DOB='" & EmpDOB.Value & "' where ID=" & key & ""
            Dim cmd As New SqlCommand(query, conn)
            cmd.ExecuteNonQuery()
            MsgBox("Employee Data Updated Succesfully")
            conn.Close()
            PopulateDataGrid()
            Clear()
        End If
    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click
        Application.Exit()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        MainForm.Show()
    End Sub
End Class