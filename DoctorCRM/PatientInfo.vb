Public Class PatientInfo


    Private Sub PatientInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Setting Windows state to normal.
        Me.WindowState = FormWindowState.Normal
        'TODO: This line of code loads data into the 'PatientTableDataSet.PATIENT' table. You can move, or remove it, as needed.
        Me.PATIENTTableAdapter.Fill(Me.PatientTableDataSet.PATIENT)
        If ComboBox1.Text = Nothing Then
            Try
                PATIENTBindingSource.AddNew()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnAdd1_Click(sender As Object, e As EventArgs) Handles btnAdd1.Click
        ' Add a new record.
        Try
            PATIENTBindingSource.AddNew()
            txtACCOUNTNO.Select()
            MessageBox.Show("The record has been added.", "Information", MessageBoxButtons.OK)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub btnUpdate1_Click(sender As Object, e As EventArgs) Handles btnUpdate1.Click
        ' Update and existing record.
        Try
            Me.Validate()
            Me.PATIENTBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.PatientTableDataSet)
            MessageBox.Show("The record has been updated.", "Information", MessageBoxButtons.OK)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        ' Delete an existing record
        Select Case MsgBox("Are you sure you want to delete the current record?", MsgBoxStyle.YesNo, "Are you sure?")
            Case MsgBoxResult.Yes
                Try
                    PATIENTBindingSource.RemoveCurrent()
                    MessageBox.Show("The record has been deleted.", "Information", MessageBoxButtons.OK)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            Case MsgBoxResult.No
                ' Do Nothing
        End Select
    End Sub
    Private Sub btnSave1_Click(sender As Object, e As EventArgs) Handles btnSave1.Click
        ' Save a record.
        Try
            Me.Validate()
            Me.PATIENTBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.PatientTableDataSet)
            MessageBox.Show("The record has been saved.", "Information", MessageBoxButtons.OK)
            PATIENTBindingSource.AddNew()
            txtACCOUNTNO.Select()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    Private Sub btnSearchBack_Click(sender As Object, e As EventArgs) Handles btnSearchBack.Click
        ' Search back through records
        Try
            PATIENTBindingSource.MovePrevious()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnSearchForward_Click(sender As Object, e As EventArgs) Handles btnSearchForward.Click
        ' Search forward through records
        Try
            PATIENTBindingSource.MoveNext()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnPhysician_Click(sender As Object, e As EventArgs) Handles btnPhysician.Click
        ' Navigate to the Physician Screen.
        PhysicianInfo.Show()
        Me.Close()
    End Sub

    Private Sub btnMedical2_Click(sender As Object, e As EventArgs) Handles btnMedical2.Click
        ' Navigate to the Medical Records Screen.
        MedicalRecords.Show()
        Me.Close()
    End Sub
    Private Sub btnExit1_Click(sender As Object, e As EventArgs) Handles btnExit1.Click
        ' Exit the application.
        Me.Close()
    End Sub

    ' This code validates the lenght of the information being entered ( MD)

    Private Sub txtACCOUNTNO_TextChanged(sender As Object, e As EventArgs) Handles txtACCOUNTNO.TextChanged
        If txtACCOUNTNO.Text.Length > 10 Then

            MessageBox.Show("Please enter a number with 10 or less digits")

        End If

    End Sub


    Private Sub txtZIPCODE_TextChanged(sender As Object, e As EventArgs) Handles txtZIPCODE.TextChanged
        If txtZIPCODE.Text.Length > 10 Then

            MessageBox.Show("Please enter a number with 10 or less characters 00000-0000")

        End If
    End Sub

    Private Sub txtPHONE_TextChanged(sender As Object, e As EventArgs) Handles txtPHONE.TextChanged
        If txtPHONE.Text.Length > 12 Then

            MessageBox.Show("Please enter a phone number in this format 123-456-5678")

        End If
    End Sub
End Class