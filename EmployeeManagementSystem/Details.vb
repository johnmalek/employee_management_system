Imports System.Data.SqlClient
Public Class Details
    Dim conn As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\School Files\3.2\Application Programming II\EmployeeManagementSystem\Database\EmployeesDB.mdf;Integrated Security=True;Connect Timeout=30")
    Private Sub FetchEmployeeData()
        If EmpIDtxt.Text = "" Then
            MsgBox("Enter Employee ID")
        Else
            conn.Open()
            Dim query As String
            query = "SELECT * FROM EmployeesTbl where ID = " & EmpIDtxt.Text & ""
            Dim cmd As New SqlCommand(query, conn)
            Dim dt As New DataTable
            Dim sda As New SqlDataAdapter(cmd)
            sda.Fill(dt)
            For Each dr In dt.Rows
                EmpName.Text = dr(1).ToString()
                EmpAddress.Text = dr(2).ToString()
                EmpGender.Text = dr(3).ToString()
                EmpPosition.Text = dr(4).ToString()
                EmpPhone.Text = dr(5).ToString()
                EmpEducation.Text = dr(6).ToString()
                EmpDOB.Text = dr(7).ToString()
                EmpName.Visible = True
                EmpAddress.Visible = True
                EmpGender.Visible = True
                EmpPosition.Visible = True
                EmpPhone.Visible = True
                EmpEducation.Visible = True
                EmpDOB.Visible = True
            Next
            conn.Close()
        End If
    End Sub
    Private Sub Details_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FetchEmployeeData()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Application.Exit()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        MainForm.Show()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawString("Employee Management System", New Font("Century Gothic", 25), Brushes.DarkGreen, 180, 40)
        e.Graphics.DrawString("****Employee Summary****", New Font("Arial", 20), Brushes.Crimson, 250, 100)
        e.Graphics.DrawString("Name: " + EmpName.Text + vbTab + "Address: " + EmpAddress.Text, New Font("Century Gothic", 22), Brushes.Black, 140, 205)
        e.Graphics.DrawString("Gender: " + EmpGender.Text + vbTab + "Position: " + EmpPosition.Text, New Font("Century Gothic", 22), Brushes.Black, 140, 260)
        e.Graphics.DrawString("Phone No: " + EmpPhone.Text + vbTab + "Education: " + EmpEducation.Text, New Font("Century Gothic", 22), Brushes.Black, 140, 325)
        e.Graphics.DrawString("DOB: " + EmpDOB.Text, New Font("Century Gothic", 20), Brushes.Black, 200, 385)

        e.Graphics.DrawString("**********Group 4**********", New Font("Century Gothic", 15), Brushes.DarkGreen, 150, 550)
    End Sub

    Private Sub PrintPreviewDialog1_Load(sender As Object, e As EventArgs) Handles PrintPreviewDialog1.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PrintPreviewDialog1.Show()
    End Sub
End Class