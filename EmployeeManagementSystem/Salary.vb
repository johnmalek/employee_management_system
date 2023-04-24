Imports System.Data.SqlClient
Public Class Salary
    Dim conn As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\School Files\3.2\Application Programming II\EmployeeManagementSystem\Database\EmployeesDB.mdf;Integrated Security=True;Connect Timeout=30")

    Private Sub FetchEmployeeData()
        If EmpID.Text = "" Then
            MsgBox("Enter Employee ID")
        Else
            conn.Open()
            Dim query As String
            query = "SELECT * FROM EmployeesTbl where ID = " & EmpID.Text & ""
            Dim cmd As New SqlCommand(query, conn)
            Dim dt As New DataTable
            Dim sda As New SqlDataAdapter(cmd)
            sda.Fill(dt)
            For Each dr In dt.Rows
                EmpName.Text = dr(1).ToString()
                EmpPos.Text = dr(4).ToString()
                EmpName.Visible = True
                EmpPos.Visible = True
            Next
            conn.Close()
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        MainForm.Show()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Application.Exit()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FetchEmployeeData()
    End Sub

    Dim daily_pay
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If EmpID.Text = "" Then
            MsgBox("Enter the employee ID")
        ElseIf daysworked.Text = "" Or Convert.ToInt32(daysworked.Text) > 30 Then
            MsgBox("Enter a valid number for days worked")
        Else
            If EmpPos.Text = "Manager" Then
                daily_pay = 1500
            ElseIf EmpPos.Text = "Developer" Then
                daily_pay = 950
            ElseIf EmpPos.Text = "HR" Then
                daily_pay = 1200
            ElseIf EmpPos.Text = "Accountant" Then
                daily_pay = 1300
            Else
                daily_pay = 600
            End If
            Dim salary = daily_pay * Convert.ToInt32(daysworked.Text)
            salaryDetails.Text = "Employee ID:   " + EmpID.Text + vbCrLf + "Employee Name:   " + EmpName.Text + vbCrLf + "Employee Position:   " + EmpPos.Text + vbCrLf + "Days Worked:   " + daysworked.Text + vbCrLf + "Daily Pay(Ksh):   " + Convert.ToString(daily_pay) + vbCrLf + "Total Amount Payable(Ksh):   " + Convert.ToString(salary) + vbCrLf

        End If
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawString("Employee Management System", New Font("Century Gothic", 25), Brushes.DarkGreen, 180, 40)
        e.Graphics.DrawString("****PAYSLIP****", New Font("Arial", 20), Brushes.Crimson, 330, 100)
        e.Graphics.DrawString(salaryDetails.Text, New Font("Century Gothic", 20), Brushes.Black, 150, 150)

        e.Graphics.DrawString("**********Thank you for your service**********", New Font("Century Gothic", 15), Brushes.DarkGreen, 150, 500)
    End Sub

    Private Sub PrintPreviewDialog1_Load(sender As Object, e As EventArgs) Handles PrintPreviewDialog1.Load

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        PrintPreviewDialog1.Show()
    End Sub
End Class