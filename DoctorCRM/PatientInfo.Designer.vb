<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PatientInfo
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PatientInfo))
        Me.lbTitle2 = New System.Windows.Forms.Label()
        Me.btnAdd1 = New System.Windows.Forms.Button()
        Me.btnUpdate1 = New System.Windows.Forms.Button()
        Me.btnSearchBack = New System.Windows.Forms.Button()
        Me.btnPhysician = New System.Windows.Forms.Button()
        Me.btnExit1 = New System.Windows.Forms.Button()
        Me.lbVisitDate = New System.Windows.Forms.Label()
        Me.btnMedical2 = New System.Windows.Forms.Button()
        Me.gbAddress = New System.Windows.Forms.GroupBox()
        Me.txtSTREETNO = New System.Windows.Forms.TextBox()
        Me.PATIENTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PatientTableDataSet = New DoctorCRM.PatientTableDataSet()
        Me.txtPOBOX = New System.Windows.Forms.TextBox()
        Me.lbStreetNo = New System.Windows.Forms.Label()
        Me.txtSTREET = New System.Windows.Forms.TextBox()
        Me.txtCITY = New System.Windows.Forms.TextBox()
        Me.txtSTATE = New System.Windows.Forms.TextBox()
        Me.txtZIPCODE = New System.Windows.Forms.TextBox()
        Me.lbStreet = New System.Windows.Forms.Label()
        Me.lbCity = New System.Windows.Forms.Label()
        Me.lbPOBoxNo = New System.Windows.Forms.Label()
        Me.lbState = New System.Windows.Forms.Label()
        Me.lbZipcode = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtALLERGY = New System.Windows.Forms.TextBox()
        Me.txtMEDS = New System.Windows.Forms.TextBox()
        Me.txtVREASON = New System.Windows.Forms.TextBox()
        Me.dtpVDATE = New System.Windows.Forms.DateTimePicker()
        Me.lbAllergy = New System.Windows.Forms.Label()
        Me.lbMeds = New System.Windows.Forms.Label()
        Me.lbReason = New System.Windows.Forms.Label()
        Me.gbPInfo = New System.Windows.Forms.GroupBox()
        Me.txtEMAIL = New System.Windows.Forms.TextBox()
        Me.dtpDOB = New System.Windows.Forms.DateTimePicker()
        Me.txtPHONE = New System.Windows.Forms.TextBox()
        Me.txtLNAME = New System.Windows.Forms.TextBox()
        Me.txtMINITIAL = New System.Windows.Forms.TextBox()
        Me.txtFNAME = New System.Windows.Forms.TextBox()
        Me.txtACCOUNTNO = New System.Windows.Forms.TextBox()
        Me.lbEmail = New System.Windows.Forms.Label()
        Me.lbDOB = New System.Windows.Forms.Label()
        Me.lbTelephone = New System.Windows.Forms.Label()
        Me.lbName = New System.Windows.Forms.Label()
        Me.lbAccountNo = New System.Windows.Forms.Label()
        Me.PATIENTTableAdapter = New DoctorCRM.PatientTableDataSetTableAdapters.PATIENTTableAdapter()
        Me.TableAdapterManager = New DoctorCRM.PatientTableDataSetTableAdapters.TableAdapterManager()
        Me.PATIENTBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.PATIENTBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.btnSave1 = New System.Windows.Forms.Button()
        Me.btnSearchForward = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.lbSearch = New System.Windows.Forms.Label()
        Me.gbAddress.SuspendLayout()
        CType(Me.PATIENTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PatientTableDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.gbPInfo.SuspendLayout()
        CType(Me.PATIENTBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PATIENTBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbTitle2
        '
        Me.lbTitle2.AutoSize = True
        Me.lbTitle2.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTitle2.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lbTitle2.Location = New System.Drawing.Point(445, 9)
        Me.lbTitle2.Name = "lbTitle2"
        Me.lbTitle2.Size = New System.Drawing.Size(233, 29)
        Me.lbTitle2.TabIndex = 0
        Me.lbTitle2.Text = "Patient Information"
        '
        'btnAdd1
        '
        Me.btnAdd1.BackColor = System.Drawing.Color.Cornsilk
        Me.btnAdd1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd1.Location = New System.Drawing.Point(396, 487)
        Me.btnAdd1.Name = "btnAdd1"
        Me.btnAdd1.Size = New System.Drawing.Size(75, 29)
        Me.btnAdd1.TabIndex = 11
        Me.btnAdd1.Text = "Add"
        Me.btnAdd1.UseVisualStyleBackColor = False
        '
        'btnUpdate1
        '
        Me.btnUpdate1.BackColor = System.Drawing.Color.Cornsilk
        Me.btnUpdate1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.btnUpdate1.Location = New System.Drawing.Point(477, 487)
        Me.btnUpdate1.Name = "btnUpdate1"
        Me.btnUpdate1.Size = New System.Drawing.Size(75, 29)
        Me.btnUpdate1.TabIndex = 12
        Me.btnUpdate1.Text = "Update"
        Me.btnUpdate1.UseVisualStyleBackColor = False
        '
        'btnSearchBack
        '
        Me.btnSearchBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnSearchBack.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchBack.Location = New System.Drawing.Point(651, 397)
        Me.btnSearchBack.Name = "btnSearchBack"
        Me.btnSearchBack.Size = New System.Drawing.Size(75, 29)
        Me.btnSearchBack.TabIndex = 13
        Me.btnSearchBack.Text = "<"
        Me.btnSearchBack.UseVisualStyleBackColor = False
        '
        'btnPhysician
        '
        Me.btnPhysician.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnPhysician.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPhysician.ForeColor = System.Drawing.Color.Black
        Me.btnPhysician.Location = New System.Drawing.Point(303, 522)
        Me.btnPhysician.Name = "btnPhysician"
        Me.btnPhysician.Size = New System.Drawing.Size(161, 31)
        Me.btnPhysician.TabIndex = 15
        Me.btnPhysician.Text = "Physician Information"
        Me.btnPhysician.UseVisualStyleBackColor = False
        '
        'btnExit1
        '
        Me.btnExit1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnExit1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit1.ForeColor = System.Drawing.Color.Black
        Me.btnExit1.Location = New System.Drawing.Point(635, 522)
        Me.btnExit1.Name = "btnExit1"
        Me.btnExit1.Size = New System.Drawing.Size(161, 31)
        Me.btnExit1.TabIndex = 16
        Me.btnExit1.Text = "Exit"
        Me.btnExit1.UseVisualStyleBackColor = False
        '
        'lbVisitDate
        '
        Me.lbVisitDate.AutoSize = True
        Me.lbVisitDate.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbVisitDate.Location = New System.Drawing.Point(29, 46)
        Me.lbVisitDate.Name = "lbVisitDate"
        Me.lbVisitDate.Size = New System.Drawing.Size(90, 19)
        Me.lbVisitDate.TabIndex = 45
        Me.lbVisitDate.Text = "Visit Date:"
        '
        'btnMedical2
        '
        Me.btnMedical2.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnMedical2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMedical2.ForeColor = System.Drawing.Color.Black
        Me.btnMedical2.Location = New System.Drawing.Point(469, 522)
        Me.btnMedical2.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnMedical2.Name = "btnMedical2"
        Me.btnMedical2.Size = New System.Drawing.Size(161, 31)
        Me.btnMedical2.TabIndex = 53
        Me.btnMedical2.Text = "Medical Records"
        Me.btnMedical2.UseVisualStyleBackColor = False
        '
        'gbAddress
        '
        Me.gbAddress.Controls.Add(Me.txtSTREETNO)
        Me.gbAddress.Controls.Add(Me.txtPOBOX)
        Me.gbAddress.Controls.Add(Me.lbStreetNo)
        Me.gbAddress.Controls.Add(Me.txtSTREET)
        Me.gbAddress.Controls.Add(Me.txtCITY)
        Me.gbAddress.Controls.Add(Me.txtSTATE)
        Me.gbAddress.Controls.Add(Me.txtZIPCODE)
        Me.gbAddress.Controls.Add(Me.lbStreet)
        Me.gbAddress.Controls.Add(Me.lbCity)
        Me.gbAddress.Controls.Add(Me.lbPOBoxNo)
        Me.gbAddress.Controls.Add(Me.lbState)
        Me.gbAddress.Controls.Add(Me.lbZipcode)
        Me.gbAddress.Location = New System.Drawing.Point(25, 251)
        Me.gbAddress.Name = "gbAddress"
        Me.gbAddress.Size = New System.Drawing.Size(425, 217)
        Me.gbAddress.TabIndex = 56
        Me.gbAddress.TabStop = False
        Me.gbAddress.Text = "Patient Address"
        '
        'txtSTREETNO
        '
        Me.txtSTREETNO.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PATIENTBindingSource, "STREETNO", True))
        Me.txtSTREETNO.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSTREETNO.ForeColor = System.Drawing.SystemColors.MenuText
        Me.txtSTREETNO.Location = New System.Drawing.Point(140, 49)
        Me.txtSTREETNO.Name = "txtSTREETNO"
        Me.txtSTREETNO.Size = New System.Drawing.Size(102, 23)
        Me.txtSTREETNO.TabIndex = 84
        Me.txtSTREETNO.Text = "Street #"
        '
        'PATIENTBindingSource
        '
        Me.PATIENTBindingSource.DataMember = "PATIENT"
        Me.PATIENTBindingSource.DataSource = Me.PatientTableDataSet
        '
        'PatientTableDataSet
        '
        Me.PatientTableDataSet.DataSetName = "PatientTableDataSet"
        Me.PatientTableDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtPOBOX
        '
        Me.txtPOBOX.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PATIENTBindingSource, "POBOX", True))
        Me.txtPOBOX.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPOBOX.ForeColor = System.Drawing.SystemColors.MenuText
        Me.txtPOBOX.Location = New System.Drawing.Point(140, 80)
        Me.txtPOBOX.Name = "txtPOBOX"
        Me.txtPOBOX.Size = New System.Drawing.Size(102, 23)
        Me.txtPOBOX.TabIndex = 86
        Me.txtPOBOX.Text = "PO Box#"
        '
        'lbStreetNo
        '
        Me.lbStreetNo.AutoSize = True
        Me.lbStreetNo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbStreetNo.Location = New System.Drawing.Point(8, 50)
        Me.lbStreetNo.Name = "lbStreetNo"
        Me.lbStreetNo.Size = New System.Drawing.Size(72, 19)
        Me.lbStreetNo.TabIndex = 80
        Me.lbStreetNo.Text = "Street#:"
        '
        'txtSTREET
        '
        Me.txtSTREET.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PATIENTBindingSource, "STREET", True))
        Me.txtSTREET.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSTREET.ForeColor = System.Drawing.SystemColors.MenuText
        Me.txtSTREET.Location = New System.Drawing.Point(140, 110)
        Me.txtSTREET.Name = "txtSTREET"
        Me.txtSTREET.Size = New System.Drawing.Size(264, 23)
        Me.txtSTREET.TabIndex = 88
        Me.txtSTREET.Text = "Street"
        '
        'txtCITY
        '
        Me.txtCITY.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PATIENTBindingSource, "CITY", True))
        Me.txtCITY.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCITY.ForeColor = System.Drawing.SystemColors.MenuText
        Me.txtCITY.Location = New System.Drawing.Point(140, 140)
        Me.txtCITY.Name = "txtCITY"
        Me.txtCITY.Size = New System.Drawing.Size(200, 23)
        Me.txtCITY.TabIndex = 90
        Me.txtCITY.Text = "City"
        '
        'txtSTATE
        '
        Me.txtSTATE.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PATIENTBindingSource, "STATE", True))
        Me.txtSTATE.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSTATE.ForeColor = System.Drawing.SystemColors.MenuText
        Me.txtSTATE.Location = New System.Drawing.Point(140, 168)
        Me.txtSTATE.Name = "txtSTATE"
        Me.txtSTATE.Size = New System.Drawing.Size(44, 23)
        Me.txtSTATE.TabIndex = 92
        Me.txtSTATE.Text = "State"
        '
        'txtZIPCODE
        '
        Me.txtZIPCODE.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PATIENTBindingSource, "ZIPCODE", True))
        Me.txtZIPCODE.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtZIPCODE.ForeColor = System.Drawing.SystemColors.MenuText
        Me.txtZIPCODE.Location = New System.Drawing.Point(266, 168)
        Me.txtZIPCODE.Name = "txtZIPCODE"
        Me.txtZIPCODE.Size = New System.Drawing.Size(138, 23)
        Me.txtZIPCODE.TabIndex = 94
        Me.txtZIPCODE.Text = "ZipCode"
        '
        'lbStreet
        '
        Me.lbStreet.AutoSize = True
        Me.lbStreet.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbStreet.Location = New System.Drawing.Point(7, 111)
        Me.lbStreet.Name = "lbStreet"
        Me.lbStreet.Size = New System.Drawing.Size(63, 19)
        Me.lbStreet.TabIndex = 84
        Me.lbStreet.Text = "Street:"
        '
        'lbCity
        '
        Me.lbCity.AutoSize = True
        Me.lbCity.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCity.Location = New System.Drawing.Point(9, 140)
        Me.lbCity.Name = "lbCity"
        Me.lbCity.Size = New System.Drawing.Size(46, 19)
        Me.lbCity.TabIndex = 74
        Me.lbCity.Text = "City:"
        '
        'lbPOBoxNo
        '
        Me.lbPOBoxNo.AutoSize = True
        Me.lbPOBoxNo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbPOBoxNo.Location = New System.Drawing.Point(8, 81)
        Me.lbPOBoxNo.Name = "lbPOBoxNo"
        Me.lbPOBoxNo.Size = New System.Drawing.Size(84, 19)
        Me.lbPOBoxNo.TabIndex = 82
        Me.lbPOBoxNo.Text = "PO Box#:"
        '
        'lbState
        '
        Me.lbState.AutoSize = True
        Me.lbState.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbState.Location = New System.Drawing.Point(7, 169)
        Me.lbState.Name = "lbState"
        Me.lbState.Size = New System.Drawing.Size(56, 19)
        Me.lbState.TabIndex = 76
        Me.lbState.Text = "State:"
        '
        'lbZipcode
        '
        Me.lbZipcode.AutoSize = True
        Me.lbZipcode.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbZipcode.Location = New System.Drawing.Point(196, 169)
        Me.lbZipcode.Name = "lbZipcode"
        Me.lbZipcode.Size = New System.Drawing.Size(79, 19)
        Me.lbZipcode.TabIndex = 78
        Me.lbZipcode.Text = "ZipCode:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtALLERGY)
        Me.GroupBox1.Controls.Add(Me.txtMEDS)
        Me.GroupBox1.Controls.Add(Me.txtVREASON)
        Me.GroupBox1.Controls.Add(Me.dtpVDATE)
        Me.GroupBox1.Controls.Add(Me.lbAllergy)
        Me.GroupBox1.Controls.Add(Me.lbMeds)
        Me.GroupBox1.Controls.Add(Me.lbVisitDate)
        Me.GroupBox1.Controls.Add(Me.lbReason)
        Me.GroupBox1.Location = New System.Drawing.Point(469, 51)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(560, 241)
        Me.GroupBox1.TabIndex = 57
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Information Update"
        '
        'txtALLERGY
        '
        Me.txtALLERGY.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PATIENTBindingSource, "ALLERGY", True))
        Me.txtALLERGY.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtALLERGY.ForeColor = System.Drawing.SystemColors.MenuText
        Me.txtALLERGY.Location = New System.Drawing.Point(373, 120)
        Me.txtALLERGY.Multiline = True
        Me.txtALLERGY.Name = "txtALLERGY"
        Me.txtALLERGY.Size = New System.Drawing.Size(167, 75)
        Me.txtALLERGY.TabIndex = 82
        Me.txtALLERGY.Text = "Allergies"
        '
        'txtMEDS
        '
        Me.txtMEDS.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PATIENTBindingSource, "MEDS", True))
        Me.txtMEDS.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMEDS.ForeColor = System.Drawing.SystemColors.MenuText
        Me.txtMEDS.Location = New System.Drawing.Point(123, 119)
        Me.txtMEDS.Multiline = True
        Me.txtMEDS.Name = "txtMEDS"
        Me.txtMEDS.Size = New System.Drawing.Size(170, 76)
        Me.txtMEDS.TabIndex = 80
        Me.txtMEDS.Text = "Medications"
        '
        'txtVREASON
        '
        Me.txtVREASON.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PATIENTBindingSource, "VREASON", True))
        Me.txtVREASON.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVREASON.ForeColor = System.Drawing.SystemColors.MenuText
        Me.txtVREASON.Location = New System.Drawing.Point(123, 71)
        Me.txtVREASON.Multiline = True
        Me.txtVREASON.Name = "txtVREASON"
        Me.txtVREASON.Size = New System.Drawing.Size(417, 43)
        Me.txtVREASON.TabIndex = 78
        Me.txtVREASON.Text = "Reason for Visit"
        '
        'dtpVDATE
        '
        Me.dtpVDATE.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PATIENTBindingSource, "VDATE", True))
        Me.dtpVDATE.Location = New System.Drawing.Point(123, 43)
        Me.dtpVDATE.Name = "dtpVDATE"
        Me.dtpVDATE.Size = New System.Drawing.Size(200, 23)
        Me.dtpVDATE.TabIndex = 76
        '
        'lbAllergy
        '
        Me.lbAllergy.AutoSize = True
        Me.lbAllergy.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbAllergy.Location = New System.Drawing.Point(299, 125)
        Me.lbAllergy.Name = "lbAllergy"
        Me.lbAllergy.Size = New System.Drawing.Size(82, 19)
        Me.lbAllergy.TabIndex = 56
        Me.lbAllergy.Text = "Allergies:"
        '
        'lbMeds
        '
        Me.lbMeds.AutoSize = True
        Me.lbMeds.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbMeds.Location = New System.Drawing.Point(29, 120)
        Me.lbMeds.Name = "lbMeds"
        Me.lbMeds.Size = New System.Drawing.Size(108, 19)
        Me.lbMeds.TabIndex = 55
        Me.lbMeds.Text = "Medications:"
        '
        'lbReason
        '
        Me.lbReason.AutoSize = True
        Me.lbReason.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbReason.Location = New System.Drawing.Point(29, 72)
        Me.lbReason.Name = "lbReason"
        Me.lbReason.Size = New System.Drawing.Size(113, 19)
        Me.lbReason.TabIndex = 53
        Me.lbReason.Text = "Visit Reason:"
        '
        'gbPInfo
        '
        Me.gbPInfo.Controls.Add(Me.txtEMAIL)
        Me.gbPInfo.Controls.Add(Me.dtpDOB)
        Me.gbPInfo.Controls.Add(Me.txtPHONE)
        Me.gbPInfo.Controls.Add(Me.txtLNAME)
        Me.gbPInfo.Controls.Add(Me.txtMINITIAL)
        Me.gbPInfo.Controls.Add(Me.txtFNAME)
        Me.gbPInfo.Controls.Add(Me.txtACCOUNTNO)
        Me.gbPInfo.Controls.Add(Me.lbEmail)
        Me.gbPInfo.Controls.Add(Me.lbDOB)
        Me.gbPInfo.Controls.Add(Me.lbTelephone)
        Me.gbPInfo.Controls.Add(Me.lbName)
        Me.gbPInfo.Controls.Add(Me.lbAccountNo)
        Me.gbPInfo.Location = New System.Drawing.Point(25, 51)
        Me.gbPInfo.Name = "gbPInfo"
        Me.gbPInfo.Size = New System.Drawing.Size(425, 183)
        Me.gbPInfo.TabIndex = 58
        Me.gbPInfo.TabStop = False
        Me.gbPInfo.Text = "Patient Information"
        '
        'txtEMAIL
        '
        Me.txtEMAIL.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PATIENTBindingSource, "EMAIL", True))
        Me.txtEMAIL.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEMAIL.ForeColor = System.Drawing.SystemColors.MenuText
        Me.txtEMAIL.Location = New System.Drawing.Point(140, 121)
        Me.txtEMAIL.Name = "txtEMAIL"
        Me.txtEMAIL.Size = New System.Drawing.Size(279, 23)
        Me.txtEMAIL.TabIndex = 72
        Me.txtEMAIL.Tag = "name"
        Me.txtEMAIL.Text = "Email Address"
        '
        'dtpDOB
        '
        Me.dtpDOB.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PATIENTBindingSource, "DOB", True))
        Me.dtpDOB.Location = New System.Drawing.Point(140, 147)
        Me.dtpDOB.Name = "dtpDOB"
        Me.dtpDOB.Size = New System.Drawing.Size(200, 23)
        Me.dtpDOB.TabIndex = 74
        '
        'txtPHONE
        '
        Me.txtPHONE.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PATIENTBindingSource, "PHONE", True))
        Me.txtPHONE.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPHONE.ForeColor = System.Drawing.SystemColors.MenuText
        Me.txtPHONE.Location = New System.Drawing.Point(140, 93)
        Me.txtPHONE.Name = "txtPHONE"
        Me.txtPHONE.Size = New System.Drawing.Size(148, 23)
        Me.txtPHONE.TabIndex = 70
        Me.txtPHONE.Text = "Telephone"
        '
        'txtLNAME
        '
        Me.txtLNAME.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PATIENTBindingSource, "LNAME", True))
        Me.txtLNAME.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLNAME.ForeColor = System.Drawing.SystemColors.MenuText
        Me.txtLNAME.Location = New System.Drawing.Point(294, 63)
        Me.txtLNAME.Name = "txtLNAME"
        Me.txtLNAME.Size = New System.Drawing.Size(125, 23)
        Me.txtLNAME.TabIndex = 68
        Me.txtLNAME.Text = "Last Name"
        '
        'txtMINITIAL
        '
        Me.txtMINITIAL.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PATIENTBindingSource, "MINITIAL", True))
        Me.txtMINITIAL.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMINITIAL.ForeColor = System.Drawing.SystemColors.MenuText
        Me.txtMINITIAL.Location = New System.Drawing.Point(266, 63)
        Me.txtMINITIAL.Name = "txtMINITIAL"
        Me.txtMINITIAL.Size = New System.Drawing.Size(22, 23)
        Me.txtMINITIAL.TabIndex = 66
        Me.txtMINITIAL.Text = "MI"
        '
        'txtFNAME
        '
        Me.txtFNAME.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PATIENTBindingSource, "FNAME", True))
        Me.txtFNAME.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFNAME.ForeColor = System.Drawing.SystemColors.MenuText
        Me.txtFNAME.Location = New System.Drawing.Point(140, 63)
        Me.txtFNAME.Name = "txtFNAME"
        Me.txtFNAME.Size = New System.Drawing.Size(120, 23)
        Me.txtFNAME.TabIndex = 64
        Me.txtFNAME.Text = "First Name"
        '
        'txtACCOUNTNO
        '
        Me.txtACCOUNTNO.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PATIENTBindingSource, "ACCOUNTNO", True))
        Me.txtACCOUNTNO.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtACCOUNTNO.ForeColor = System.Drawing.SystemColors.MenuText
        Me.txtACCOUNTNO.Location = New System.Drawing.Point(140, 34)
        Me.txtACCOUNTNO.Name = "txtACCOUNTNO"
        Me.txtACCOUNTNO.Size = New System.Drawing.Size(120, 23)
        Me.txtACCOUNTNO.TabIndex = 62
        Me.txtACCOUNTNO.Text = "Account #"
        '
        'lbEmail
        '
        Me.lbEmail.AutoSize = True
        Me.lbEmail.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbEmail.Location = New System.Drawing.Point(8, 122)
        Me.lbEmail.Name = "lbEmail"
        Me.lbEmail.Size = New System.Drawing.Size(57, 19)
        Me.lbEmail.TabIndex = 66
        Me.lbEmail.Text = "Email:"
        '
        'lbDOB
        '
        Me.lbDOB.AutoSize = True
        Me.lbDOB.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbDOB.Location = New System.Drawing.Point(12, 150)
        Me.lbDOB.Name = "lbDOB"
        Me.lbDOB.Size = New System.Drawing.Size(52, 19)
        Me.lbDOB.TabIndex = 59
        Me.lbDOB.Text = "DOB:"
        '
        'lbTelephone
        '
        Me.lbTelephone.AutoSize = True
        Me.lbTelephone.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTelephone.Location = New System.Drawing.Point(8, 94)
        Me.lbTelephone.Name = "lbTelephone"
        Me.lbTelephone.Size = New System.Drawing.Size(95, 19)
        Me.lbTelephone.TabIndex = 58
        Me.lbTelephone.Text = "Telephone:"
        '
        'lbName
        '
        Me.lbName.AutoSize = True
        Me.lbName.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbName.Location = New System.Drawing.Point(8, 64)
        Me.lbName.Name = "lbName"
        Me.lbName.Size = New System.Drawing.Size(59, 19)
        Me.lbName.TabIndex = 57
        Me.lbName.Text = "Name:"
        '
        'lbAccountNo
        '
        Me.lbAccountNo.AutoSize = True
        Me.lbAccountNo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbAccountNo.Location = New System.Drawing.Point(8, 35)
        Me.lbAccountNo.Name = "lbAccountNo"
        Me.lbAccountNo.Size = New System.Drawing.Size(89, 19)
        Me.lbAccountNo.TabIndex = 56
        Me.lbAccountNo.Text = "Account#:"
        '
        'PATIENTTableAdapter
        '
        Me.PATIENTTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.PATIENTTableAdapter = Me.PATIENTTableAdapter
        Me.TableAdapterManager.UpdateOrder = DoctorCRM.PatientTableDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'PATIENTBindingNavigator
        '
        Me.PATIENTBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.PATIENTBindingNavigator.BindingSource = Me.PATIENTBindingSource
        Me.PATIENTBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.PATIENTBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.PATIENTBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.PATIENTBindingNavigatorSaveItem})
        Me.PATIENTBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.PATIENTBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.PATIENTBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.PATIENTBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.PATIENTBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.PATIENTBindingNavigator.Name = "PATIENTBindingNavigator"
        Me.PATIENTBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.PATIENTBindingNavigator.Size = New System.Drawing.Size(1058, 25)
        Me.PATIENTBindingNavigator.TabIndex = 59
        Me.PATIENTBindingNavigator.Text = "BindingNavigator1"
        Me.PATIENTBindingNavigator.Visible = False
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(45, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'PATIENTBindingNavigatorSaveItem
        '
        Me.PATIENTBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PATIENTBindingNavigatorSaveItem.Image = CType(resources.GetObject("PATIENTBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.PATIENTBindingNavigatorSaveItem.Name = "PATIENTBindingNavigatorSaveItem"
        Me.PATIENTBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.PATIENTBindingNavigatorSaveItem.Text = "Save Data"
        '
        'btnSave1
        '
        Me.btnSave1.BackColor = System.Drawing.Color.Cornsilk
        Me.btnSave1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave1.ForeColor = System.Drawing.Color.Green
        Me.btnSave1.Location = New System.Drawing.Point(639, 487)
        Me.btnSave1.Name = "btnSave1"
        Me.btnSave1.Size = New System.Drawing.Size(75, 29)
        Me.btnSave1.TabIndex = 61
        Me.btnSave1.Text = "Save"
        Me.btnSave1.UseVisualStyleBackColor = False
        '
        'btnSearchForward
        '
        Me.btnSearchForward.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnSearchForward.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchForward.Location = New System.Drawing.Point(732, 397)
        Me.btnSearchForward.Name = "btnSearchForward"
        Me.btnSearchForward.Size = New System.Drawing.Size(75, 29)
        Me.btnSearchForward.TabIndex = 62
        Me.btnSearchForward.Text = ">"
        Me.btnSearchForward.UseVisualStyleBackColor = False
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.PATIENTBindingSource
        Me.ComboBox1.DisplayMember = "ACCOUNTNO"
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.ItemHeight = 27
        Me.ComboBox1.Location = New System.Drawing.Point(570, 361)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(321, 35)
        Me.ComboBox1.TabIndex = 63
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.Cornsilk
        Me.btnDelete.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.Red
        Me.btnDelete.Location = New System.Drawing.Point(558, 487)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 29)
        Me.btnDelete.TabIndex = 64
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'lbSearch
        '
        Me.lbSearch.AutoSize = True
        Me.lbSearch.Location = New System.Drawing.Point(671, 334)
        Me.lbSearch.Name = "lbSearch"
        Me.lbSearch.Size = New System.Drawing.Size(158, 16)
        Me.lbSearch.TabIndex = 65
        Me.lbSearch.Text = "Search Patient Records"
        '
        'PatientInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1020, 557)
        Me.Controls.Add(Me.lbSearch)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.btnSearchForward)
        Me.Controls.Add(Me.btnSave1)
        Me.Controls.Add(Me.PATIENTBindingNavigator)
        Me.Controls.Add(Me.gbPInfo)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gbAddress)
        Me.Controls.Add(Me.btnMedical2)
        Me.Controls.Add(Me.btnExit1)
        Me.Controls.Add(Me.btnPhysician)
        Me.Controls.Add(Me.btnSearchBack)
        Me.Controls.Add(Me.btnUpdate1)
        Me.Controls.Add(Me.btnAdd1)
        Me.Controls.Add(Me.lbTitle2)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "PatientInfo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Patient Information"
        Me.gbAddress.ResumeLayout(False)
        Me.gbAddress.PerformLayout()
        CType(Me.PATIENTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PatientTableDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.gbPInfo.ResumeLayout(False)
        Me.gbPInfo.PerformLayout()
        CType(Me.PATIENTBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PATIENTBindingNavigator.ResumeLayout(False)
        Me.PATIENTBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbTitle2 As Label
    Friend WithEvents btnAdd1 As Button
    Friend WithEvents btnUpdate1 As Button
    Friend WithEvents btnSearchBack As Button
    Friend WithEvents btnPhysician As Button
    Friend WithEvents btnExit1 As Button
    Friend WithEvents lbVisitDate As Label
    Friend WithEvents btnMedical2 As Button
    Friend WithEvents gbAddress As GroupBox
    Friend WithEvents lbStreetNo As Label
    Friend WithEvents lbStreet As Label
    Friend WithEvents lbCity As Label
    Friend WithEvents lbPOBoxNo As Label
    Friend WithEvents lbState As Label
    Friend WithEvents lbZipcode As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lbAllergy As Label
    Friend WithEvents lbMeds As Label
    Friend WithEvents lbReason As Label
    Friend WithEvents gbPInfo As GroupBox
    Friend WithEvents lbEmail As Label
    Friend WithEvents lbDOB As Label
    Friend WithEvents lbTelephone As Label
    Friend WithEvents lbName As Label
    Friend WithEvents lbAccountNo As Label
    Friend WithEvents PatientTableDataSet As PatientTableDataSet
    Friend WithEvents PATIENTBindingSource As BindingSource
    Friend WithEvents PATIENTTableAdapter As PatientTableDataSetTableAdapters.PATIENTTableAdapter
    Friend WithEvents TableAdapterManager As PatientTableDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PATIENTBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents PATIENTBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents txtEMAIL As TextBox
    Friend WithEvents dtpDOB As DateTimePicker
    Friend WithEvents txtPHONE As TextBox
    Friend WithEvents txtMINITIAL As TextBox
    Friend WithEvents txtACCOUNTNO As TextBox
    Friend WithEvents txtMEDS As TextBox
    Friend WithEvents txtALLERGY As TextBox
    Friend WithEvents txtSTREETNO As TextBox
    Friend WithEvents txtPOBOX As TextBox
    Friend WithEvents txtSTREET As TextBox
    Friend WithEvents txtCITY As TextBox
    Friend WithEvents txtSTATE As TextBox
    Friend WithEvents txtZIPCODE As TextBox
    Friend WithEvents btnSave1 As Button
    Friend WithEvents btnSearchForward As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents btnDelete As Button
    Friend WithEvents lbSearch As Label
    Friend WithEvents txtFNAME As System.Windows.Forms.TextBox
    Friend WithEvents txtVREASON As System.Windows.Forms.TextBox
    Friend WithEvents dtpVDATE As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtLNAME As System.Windows.Forms.TextBox
End Class
