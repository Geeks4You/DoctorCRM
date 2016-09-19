Public Class MedicalRecords
    Private Sub MedicalRecords_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PatientTableDataSet.PATIENT' table. You can move, or remove it, as needed.
        Me.PATIENTTableAdapter.Fill(Me.PatientTableDataSet.PATIENT)

    End Sub

    Private Sub btnSearchBack3_Click(sender As Object, e As EventArgs) Handles btnSearchBack3.Click
        ' Search back through records.
        Try
            PATIENTBindingSource.MovePrevious()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnSearchForward3_Click(sender As Object, e As EventArgs) Handles btnSearchForward3.Click
        ' Search forward through records.
        Try
            PATIENTBindingSource.MoveNext()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub btnUpdate3_Click(sender As Object, e As EventArgs) Handles btnUpdate3.Click
        ' Update existing record.
        Me.Validate()
        Me.PATIENTBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.PatientTableDataSet)
        MessageBox.Show("The record has been updated.", "Information", MessageBoxButtons.OK)
    End Sub
    Private Sub btnSave3_Click(sender As Object, e As EventArgs) Handles btnSave3.Click
        ' Save a record
        Try
            Me.Validate()
            Me.PATIENTBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.PatientTableDataSet)
            MessageBox.Show("The record has been saved.", "Information", MessageBoxButtons.OK)
            PATIENTBindingSource.AddNew()
            txtACCOUNTNO3.Select()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub btnBack3_Click(sender As Object, e As EventArgs) Handles btnBack3.Click
        ' Navigate to Patient screen
        PatientInfo.Show()
        Me.Close()
    End Sub

    Private Sub btnPhysician2_Click(sender As Object, e As EventArgs) Handles btnPhysician2.Click
        ' Navigate to Physician screen
        PhysicianInfo.Show()
        Me.Close()
    End Sub
    Private Sub btnExit1_Click(sender As Object, e As EventArgs) Handles btnExit3.Click
        ' Exit the application.
        Me.Close()
    End Sub

    'the next textchanged handlers verify data length

    Private Sub txtMRI_ID_TextChanged(sender As Object, e As EventArgs) Handles txtMRI_ID.TextChanged

        If txtMRI_ID.Text.Length > 10 Then

            MessageBox.Show("Please enter an ID of 10 characters or less")

        End If


    End Sub

    Private Sub txtXRAY_ID_TextChanged(sender As Object, e As EventArgs) Handles txtXRAY_ID.TextChanged

        If txtXRAY_ID.Text.Length > 10 Then

            MessageBox.Show("Please enter an ID of 10 characters or less")

        End If
    End Sub

End Class