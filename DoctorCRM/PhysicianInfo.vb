Public Class PhysicianInfo
    Private Sub PhysicianInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PatientTableDataSet.PATIENT' table. You can move, or remove it, as needed.
        Me.PATIENTTableAdapter.Fill(Me.PatientTableDataSet.PATIENT)

    End Sub

    Private Sub btnSearchBack2_Click(sender As Object, e As EventArgs) Handles btnSearchBack2.Click
        ' Search back through records.
        Try
            PATIENTBindingSource.MovePrevious()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnSearchForward2_Click(sender As Object, e As EventArgs) Handles btnSearchForward2.Click
        ' Search forward through records.
        Try
            PATIENTBindingSource.MoveNext()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub btnUpdate2_Click(sender As Object, e As EventArgs) Handles btnUpdate2.Click
        ' Update a record.
        Me.Validate()
        Me.PATIENTBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.PatientTableDataSet)
        MessageBox.Show("The record has been updated.", "Information", MessageBoxButtons.OK)
    End Sub
    Private Sub btnSave2_Click(sender As Object, e As EventArgs) Handles btnSave2.Click
        ' Update a record.
        Try
            Me.Validate()
            Me.PATIENTBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.PatientTableDataSet)
            MessageBox.Show("The record has been saved.", "Information", MessageBoxButtons.OK)
            PATIENTBindingSource.AddNew()
            txtACCOUNTNO2.Select()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub btnPrint1_Click(sender As Object, e As EventArgs) Handles btnPrint1.Click
        PrintDialog1.Document = PrintDocument1
        PrintDialog1.PrinterSettings = PrintDocument1.PrinterSettings
        PrintDialog1.AllowSomePages = True
        If PrintDialog1.ShowDialog = DialogResult.OK Then
            PrintDocument1.PrinterSettings = PrintDialog1.PrinterSettings
            PrintDocument1.Print()
        End If
    End Sub
    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage

        Dim ReportFont As Font = New Drawing.Font("Times New Roman", 14)
        e.Graphics.DrawString("The Following is a report for patient :" + txtACCOUNTNO2.Text, ReportFont, Brushes.Black, 100, 100)
        e.Graphics.DrawString("Account #: " + txtACCOUNTNO2.Text + vbCrLf + "Physician Name: " + txtPNAME.Text + vbCrLf + "New Medication(s): " + txtNMEDS.Text + vbCrLf + "Diagnosis: " + txtDIAGCODE.Text + vbCrLf + "Doctor's Recommendations: " + txtRECOMMEND.Text, ReportFont, Brushes.Black, 100, 125)

    End Sub

    Private Sub btnBack2_Click(sender As Object, e As EventArgs) Handles btnBack2.Click
        ' Navigate to Patient screen.
        PatientInfo.Show()
        Me.Close()
    End Sub

    Private Sub btnMedical2_Click(sender As Object, e As EventArgs) Handles btnMedical2.Click
        ' Navigate to Medical Records screen
        MedicalRecords.Show()
        Me.Close()
    End Sub
    Private Sub btnExit2_Click(sender As Object, e As EventArgs) Handles btnExit2.Click
        ' Exit the application.
        Me.Close()
    End Sub
End Class