<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MedicalRecords
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MedicalRecords))
        Me.btnBack3 = New System.Windows.Forms.Button()
        Me.btnExit3 = New System.Windows.Forms.Button()
        Me.btnPhysician2 = New System.Windows.Forms.Button()
        Me.btnUpdate3 = New System.Windows.Forms.Button()
        Me.lbLabResults = New System.Windows.Forms.Label()
        Me.lbXrayID = New System.Windows.Forms.Label()
        Me.lbMRIID = New System.Windows.Forms.Label()
        Me.lbAccountNo4 = New System.Windows.Forms.Label()
        Me.lbTitle3 = New System.Windows.Forms.Label()
        Me.lbPNotes = New System.Windows.Forms.Label()
        Me.PatientTableDataSet = New DoctorCRM.PatientTableDataSet()
        Me.PATIENTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
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
        Me.txtACCOUNTNO3 = New System.Windows.Forms.TextBox()
        Me.txtMRI_ID = New System.Windows.Forms.TextBox()
        Me.txtXRAY_ID = New System.Windows.Forms.TextBox()
        Me.txtPNOTES = New System.Windows.Forms.TextBox()
        Me.txtLABRESULT = New System.Windows.Forms.TextBox()
        Me.btnSave3 = New System.Windows.Forms.Button()
        Me.lbSearch3 = New System.Windows.Forms.Label()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.btnSearchForward3 = New System.Windows.Forms.Button()
        Me.btnSearchBack3 = New System.Windows.Forms.Button()
        CType(Me.PatientTableDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PATIENTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PATIENTBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PATIENTBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnBack3
        '
        Me.btnBack3.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnBack3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack3.ForeColor = System.Drawing.Color.Black
        Me.btnBack3.Location = New System.Drawing.Point(326, 526)
        Me.btnBack3.Name = "btnBack3"
        Me.btnBack3.Size = New System.Drawing.Size(161, 25)
        Me.btnBack3.TabIndex = 49
        Me.btnBack3.Text = "Patient Information"
        Me.btnBack3.UseVisualStyleBackColor = False
        '
        'btnExit3
        '
        Me.btnExit3.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnExit3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit3.ForeColor = System.Drawing.Color.Black
        Me.btnExit3.Location = New System.Drawing.Point(660, 526)
        Me.btnExit3.Name = "btnExit3"
        Me.btnExit3.Size = New System.Drawing.Size(161, 25)
        Me.btnExit3.TabIndex = 48
        Me.btnExit3.Text = "Exit"
        Me.btnExit3.UseVisualStyleBackColor = False
        '
        'btnPhysician2
        '
        Me.btnPhysician2.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnPhysician2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPhysician2.ForeColor = System.Drawing.Color.Black
        Me.btnPhysician2.Location = New System.Drawing.Point(493, 526)
        Me.btnPhysician2.Name = "btnPhysician2"
        Me.btnPhysician2.Size = New System.Drawing.Size(161, 25)
        Me.btnPhysician2.TabIndex = 47
        Me.btnPhysician2.Text = "Physician Information"
        Me.btnPhysician2.UseVisualStyleBackColor = False
        '
        'btnUpdate3
        '
        Me.btnUpdate3.BackColor = System.Drawing.Color.Cornsilk
        Me.btnUpdate3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate3.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.btnUpdate3.Location = New System.Drawing.Point(507, 493)
        Me.btnUpdate3.Name = "btnUpdate3"
        Me.btnUpdate3.Size = New System.Drawing.Size(75, 28)
        Me.btnUpdate3.TabIndex = 45
        Me.btnUpdate3.Text = "Update"
        Me.btnUpdate3.UseVisualStyleBackColor = False
        '
        'lbLabResults
        '
        Me.lbLabResults.AutoSize = True
        Me.lbLabResults.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbLabResults.Location = New System.Drawing.Point(279, 249)
        Me.lbLabResults.Name = "lbLabResults"
        Me.lbLabResults.Size = New System.Drawing.Size(85, 16)
        Me.lbLabResults.TabIndex = 39
        Me.lbLabResults.Text = "Lab Results:"
        '
        'lbXrayID
        '
        Me.lbXrayID.AutoSize = True
        Me.lbXrayID.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbXrayID.Location = New System.Drawing.Point(279, 102)
        Me.lbXrayID.Name = "lbXrayID"
        Me.lbXrayID.Size = New System.Drawing.Size(61, 16)
        Me.lbXrayID.TabIndex = 38
        Me.lbXrayID.Text = "xRay ID:"
        '
        'lbMRIID
        '
        Me.lbMRIID.AutoSize = True
        Me.lbMRIID.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbMRIID.Location = New System.Drawing.Point(279, 76)
        Me.lbMRIID.Name = "lbMRIID"
        Me.lbMRIID.Size = New System.Drawing.Size(53, 16)
        Me.lbMRIID.TabIndex = 37
        Me.lbMRIID.Text = "MRI ID:"
        '
        'lbAccountNo4
        '
        Me.lbAccountNo4.AutoSize = True
        Me.lbAccountNo4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbAccountNo4.Location = New System.Drawing.Point(279, 50)
        Me.lbAccountNo4.Name = "lbAccountNo4"
        Me.lbAccountNo4.Size = New System.Drawing.Size(70, 16)
        Me.lbAccountNo4.TabIndex = 36
        Me.lbAccountNo4.Text = "Account#:"
        '
        'lbTitle3
        '
        Me.lbTitle3.AutoSize = True
        Me.lbTitle3.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTitle3.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lbTitle3.Location = New System.Drawing.Point(503, 9)
        Me.lbTitle3.Name = "lbTitle3"
        Me.lbTitle3.Size = New System.Drawing.Size(165, 22)
        Me.lbTitle3.TabIndex = 35
        Me.lbTitle3.Text = "Medical Records"
        '
        'lbPNotes
        '
        Me.lbPNotes.AutoSize = True
        Me.lbPNotes.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbPNotes.Location = New System.Drawing.Point(279, 128)
        Me.lbPNotes.Name = "lbPNotes"
        Me.lbPNotes.Size = New System.Drawing.Size(112, 16)
        Me.lbPNotes.TabIndex = 50
        Me.lbPNotes.Text = "Physician Notes:"
        '
        'PatientTableDataSet
        '
        Me.PatientTableDataSet.DataSetName = "PatientTableDataSet"
        Me.PatientTableDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PATIENTBindingSource
        '
        Me.PATIENTBindingSource.DataMember = "PATIENT"
        Me.PATIENTBindingSource.DataSource = Me.PatientTableDataSet
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
        Me.PATIENTBindingNavigator.TabIndex = 53
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
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
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
        'txtACCOUNTNO3
        '
        Me.txtACCOUNTNO3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PATIENTBindingSource, "ACCOUNTNO", True))
        Me.txtACCOUNTNO3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtACCOUNTNO3.ForeColor = System.Drawing.SystemColors.Desktop
        Me.txtACCOUNTNO3.Location = New System.Drawing.Point(426, 49)
        Me.txtACCOUNTNO3.Name = "txtACCOUNTNO3"
        Me.txtACCOUNTNO3.Size = New System.Drawing.Size(165, 20)
        Me.txtACCOUNTNO3.TabIndex = 54
        Me.txtACCOUNTNO3.Text = "Account #"
        '
        'txtMRI_ID
        '
        Me.txtMRI_ID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PATIENTBindingSource, "MRI_ID", True))
        Me.txtMRI_ID.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMRI_ID.ForeColor = System.Drawing.SystemColors.Desktop
        Me.txtMRI_ID.Location = New System.Drawing.Point(426, 75)
        Me.txtMRI_ID.Name = "txtMRI_ID"
        Me.txtMRI_ID.Size = New System.Drawing.Size(165, 20)
        Me.txtMRI_ID.TabIndex = 55
        Me.txtMRI_ID.Text = "MRI_ID"
        '
        'txtXRAY_ID
        '
        Me.txtXRAY_ID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PATIENTBindingSource, "XRAY_ID", True))
        Me.txtXRAY_ID.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtXRAY_ID.ForeColor = System.Drawing.SystemColors.Desktop
        Me.txtXRAY_ID.Location = New System.Drawing.Point(426, 101)
        Me.txtXRAY_ID.Name = "txtXRAY_ID"
        Me.txtXRAY_ID.Size = New System.Drawing.Size(165, 20)
        Me.txtXRAY_ID.TabIndex = 56
        Me.txtXRAY_ID.Text = "xRay_ID"
        '
        'txtPNOTES
        '
        Me.txtPNOTES.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PATIENTBindingSource, "PNOTES", True))
        Me.txtPNOTES.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPNOTES.ForeColor = System.Drawing.SystemColors.Desktop
        Me.txtPNOTES.Location = New System.Drawing.Point(426, 127)
        Me.txtPNOTES.Multiline = True
        Me.txtPNOTES.Name = "txtPNOTES"
        Me.txtPNOTES.Size = New System.Drawing.Size(361, 114)
        Me.txtPNOTES.TabIndex = 57
        Me.txtPNOTES.Text = "Physician Notes"
        '
        'txtLABRESULT
        '
        Me.txtLABRESULT.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PATIENTBindingSource, "LABRESULT", True))
        Me.txtLABRESULT.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLABRESULT.ForeColor = System.Drawing.SystemColors.Desktop
        Me.txtLABRESULT.Location = New System.Drawing.Point(426, 247)
        Me.txtLABRESULT.Multiline = True
        Me.txtLABRESULT.Name = "txtLABRESULT"
        Me.txtLABRESULT.Size = New System.Drawing.Size(361, 113)
        Me.txtLABRESULT.TabIndex = 58
        Me.txtLABRESULT.Text = "Lab Results"
        '
        'btnSave3
        '
        Me.btnSave3.BackColor = System.Drawing.Color.Cornsilk
        Me.btnSave3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave3.ForeColor = System.Drawing.Color.Green
        Me.btnSave3.Location = New System.Drawing.Point(588, 492)
        Me.btnSave3.Name = "btnSave3"
        Me.btnSave3.Size = New System.Drawing.Size(75, 29)
        Me.btnSave3.TabIndex = 118
        Me.btnSave3.Text = "Save"
        Me.btnSave3.UseVisualStyleBackColor = False
        '
        'lbSearch3
        '
        Me.lbSearch3.AutoSize = True
        Me.lbSearch3.Location = New System.Drawing.Point(527, 404)
        Me.lbSearch3.Name = "lbSearch3"
        Me.lbSearch3.Size = New System.Drawing.Size(121, 14)
        Me.lbSearch3.TabIndex = 122
        Me.lbSearch3.Text = "Search Patient Records"
        '
        'ComboBox3
        '
        Me.ComboBox3.DataSource = Me.PATIENTBindingSource
        Me.ComboBox3.DisplayMember = "ACCOUNTNO"
        Me.ComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox3.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.ItemHeight = 22
        Me.ComboBox3.Location = New System.Drawing.Point(426, 421)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(321, 30)
        Me.ComboBox3.TabIndex = 121
        '
        'btnSearchForward3
        '
        Me.btnSearchForward3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnSearchForward3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchForward3.Location = New System.Drawing.Point(588, 457)
        Me.btnSearchForward3.Name = "btnSearchForward3"
        Me.btnSearchForward3.Size = New System.Drawing.Size(75, 29)
        Me.btnSearchForward3.TabIndex = 120
        Me.btnSearchForward3.Text = ">"
        Me.btnSearchForward3.UseVisualStyleBackColor = False
        '
        'btnSearchBack3
        '
        Me.btnSearchBack3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnSearchBack3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchBack3.Location = New System.Drawing.Point(507, 457)
        Me.btnSearchBack3.Name = "btnSearchBack3"
        Me.btnSearchBack3.Size = New System.Drawing.Size(75, 29)
        Me.btnSearchBack3.TabIndex = 119
        Me.btnSearchBack3.Text = "<"
        Me.btnSearchBack3.UseVisualStyleBackColor = False
        '
        'MedicalRecords
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1058, 557)
        Me.Controls.Add(Me.lbSearch3)
        Me.Controls.Add(Me.ComboBox3)
        Me.Controls.Add(Me.btnSearchForward3)
        Me.Controls.Add(Me.btnSearchBack3)
        Me.Controls.Add(Me.btnSave3)
        Me.Controls.Add(Me.txtLABRESULT)
        Me.Controls.Add(Me.txtPNOTES)
        Me.Controls.Add(Me.txtXRAY_ID)
        Me.Controls.Add(Me.txtMRI_ID)
        Me.Controls.Add(Me.txtACCOUNTNO3)
        Me.Controls.Add(Me.PATIENTBindingNavigator)
        Me.Controls.Add(Me.lbPNotes)
        Me.Controls.Add(Me.btnBack3)
        Me.Controls.Add(Me.btnExit3)
        Me.Controls.Add(Me.btnPhysician2)
        Me.Controls.Add(Me.btnUpdate3)
        Me.Controls.Add(Me.lbLabResults)
        Me.Controls.Add(Me.lbXrayID)
        Me.Controls.Add(Me.lbMRIID)
        Me.Controls.Add(Me.lbAccountNo4)
        Me.Controls.Add(Me.lbTitle3)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MedicalRecords"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Medical Records"
        CType(Me.PatientTableDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PATIENTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PATIENTBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PATIENTBindingNavigator.ResumeLayout(False)
        Me.PATIENTBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnBack3 As Button
    Friend WithEvents btnExit3 As Button
    Friend WithEvents btnPhysician2 As Button
    Friend WithEvents btnUpdate3 As Button
    Friend WithEvents lbLabResults As Label
    Friend WithEvents lbXrayID As Label
    Friend WithEvents lbMRIID As Label
    Friend WithEvents lbAccountNo4 As Label
    Friend WithEvents lbTitle3 As Label
    Friend WithEvents lbPNotes As Label
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
    Friend WithEvents txtACCOUNTNO3 As TextBox
    Friend WithEvents txtMRI_ID As TextBox
    Friend WithEvents txtXRAY_ID As TextBox
    Friend WithEvents txtPNOTES As TextBox
    Friend WithEvents txtLABRESULT As TextBox
    Friend WithEvents btnSave3 As Button
    Friend WithEvents lbSearch3 As Label
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents btnSearchForward3 As Button
    Friend WithEvents btnSearchBack3 As Button
End Class
