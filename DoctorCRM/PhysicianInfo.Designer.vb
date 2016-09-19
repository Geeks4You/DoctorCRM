<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PhysicianInfo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PhysicianInfo))
        Me.btnExit2 = New System.Windows.Forms.Button()
        Me.btnMedical2 = New System.Windows.Forms.Button()
        Me.btnUpdate2 = New System.Windows.Forms.Button()
        Me.lbPhysician = New System.Windows.Forms.Label()
        Me.lbAccountNo3 = New System.Windows.Forms.Label()
        Me.lbTitle3 = New System.Windows.Forms.Label()
        Me.btnBack2 = New System.Windows.Forms.Button()
        Me.lbDiagnosis = New System.Windows.Forms.Label()
        Me.lbRecommend = New System.Windows.Forms.Label()
        Me.lbNewMeds = New System.Windows.Forms.Label()
        Me.btnPrint1 = New System.Windows.Forms.Button()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
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
        Me.txtPNAME = New System.Windows.Forms.TextBox()
        Me.txtNMEDS = New System.Windows.Forms.TextBox()
        Me.txtRECOMMEND = New System.Windows.Forms.TextBox()
        Me.txtACCOUNTNO2 = New System.Windows.Forms.TextBox()
        Me.btnSave2 = New System.Windows.Forms.Button()
        Me.lbSearch2 = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.btnSearchForward2 = New System.Windows.Forms.Button()
        Me.btnSearchBack2 = New System.Windows.Forms.Button()
        Me.txtDIAGCODE = New System.Windows.Forms.TextBox()
        CType(Me.PatientTableDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PATIENTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PATIENTBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PATIENTBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnExit2
        '
        Me.btnExit2.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnExit2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit2.ForeColor = System.Drawing.Color.Black
        Me.btnExit2.Location = New System.Drawing.Point(654, 522)
        Me.btnExit2.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnExit2.Name = "btnExit2"
        Me.btnExit2.Size = New System.Drawing.Size(161, 31)
        Me.btnExit2.TabIndex = 33
        Me.btnExit2.Text = "Exit"
        Me.btnExit2.UseVisualStyleBackColor = False
        '
        'btnMedical2
        '
        Me.btnMedical2.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnMedical2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMedical2.ForeColor = System.Drawing.Color.Black
        Me.btnMedical2.Location = New System.Drawing.Point(489, 522)
        Me.btnMedical2.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnMedical2.Name = "btnMedical2"
        Me.btnMedical2.Size = New System.Drawing.Size(161, 31)
        Me.btnMedical2.TabIndex = 32
        Me.btnMedical2.Text = "Medical Records"
        Me.btnMedical2.UseVisualStyleBackColor = False
        '
        'btnUpdate2
        '
        Me.btnUpdate2.BackColor = System.Drawing.Color.Cornsilk
        Me.btnUpdate2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate2.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.btnUpdate2.Location = New System.Drawing.Point(436, 487)
        Me.btnUpdate2.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnUpdate2.Name = "btnUpdate2"
        Me.btnUpdate2.Size = New System.Drawing.Size(79, 29)
        Me.btnUpdate2.TabIndex = 29
        Me.btnUpdate2.Text = "Update"
        Me.btnUpdate2.UseVisualStyleBackColor = False
        '
        'lbPhysician
        '
        Me.lbPhysician.AutoSize = True
        Me.lbPhysician.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbPhysician.Location = New System.Drawing.Point(240, 83)
        Me.lbPhysician.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbPhysician.Name = "lbPhysician"
        Me.lbPhysician.Size = New System.Drawing.Size(73, 16)
        Me.lbPhysician.TabIndex = 19
        Me.lbPhysician.Text = "Physician:"
        '
        'lbAccountNo3
        '
        Me.lbAccountNo3.AutoSize = True
        Me.lbAccountNo3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbAccountNo3.Location = New System.Drawing.Point(240, 58)
        Me.lbAccountNo3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbAccountNo3.Name = "lbAccountNo3"
        Me.lbAccountNo3.Size = New System.Drawing.Size(70, 16)
        Me.lbAccountNo3.TabIndex = 18
        Me.lbAccountNo3.Text = "Account#:"
        '
        'lbTitle3
        '
        Me.lbTitle3.AutoSize = True
        Me.lbTitle3.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTitle3.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lbTitle3.Location = New System.Drawing.Point(472, 9)
        Me.lbTitle3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbTitle3.Name = "lbTitle3"
        Me.lbTitle3.Size = New System.Drawing.Size(212, 22)
        Me.lbTitle3.TabIndex = 17
        Me.lbTitle3.Text = "Physician Information"
        '
        'btnBack2
        '
        Me.btnBack2.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnBack2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack2.ForeColor = System.Drawing.Color.Black
        Me.btnBack2.Location = New System.Drawing.Point(324, 522)
        Me.btnBack2.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnBack2.Name = "btnBack2"
        Me.btnBack2.Size = New System.Drawing.Size(161, 31)
        Me.btnBack2.TabIndex = 34
        Me.btnBack2.Text = "Patient Information"
        Me.btnBack2.UseVisualStyleBackColor = False
        '
        'lbDiagnosis
        '
        Me.lbDiagnosis.AutoSize = True
        Me.lbDiagnosis.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbDiagnosis.Location = New System.Drawing.Point(240, 208)
        Me.lbDiagnosis.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbDiagnosis.Name = "lbDiagnosis"
        Me.lbDiagnosis.Size = New System.Drawing.Size(73, 16)
        Me.lbDiagnosis.TabIndex = 39
        Me.lbDiagnosis.Text = "Diagnosis:"
        '
        'lbRecommend
        '
        Me.lbRecommend.AutoSize = True
        Me.lbRecommend.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbRecommend.Location = New System.Drawing.Point(240, 233)
        Me.lbRecommend.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbRecommend.Name = "lbRecommend"
        Me.lbRecommend.Size = New System.Drawing.Size(130, 16)
        Me.lbRecommend.TabIndex = 41
        Me.lbRecommend.Text = "Recommendations:"
        '
        'lbNewMeds
        '
        Me.lbNewMeds.AutoSize = True
        Me.lbNewMeds.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbNewMeds.Location = New System.Drawing.Point(240, 107)
        Me.lbNewMeds.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbNewMeds.Name = "lbNewMeds"
        Me.lbNewMeds.Size = New System.Drawing.Size(120, 16)
        Me.lbNewMeds.TabIndex = 52
        Me.lbNewMeds.Text = "New Medications:"
        '
        'btnPrint1
        '
        Me.btnPrint1.BackColor = System.Drawing.Color.Cornsilk
        Me.btnPrint1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint1.Location = New System.Drawing.Point(600, 487)
        Me.btnPrint1.Name = "btnPrint1"
        Me.btnPrint1.Size = New System.Drawing.Size(107, 29)
        Me.btnPrint1.TabIndex = 69
        Me.btnPrint1.Text = "Print Report"
        Me.btnPrint1.UseVisualStyleBackColor = False
        '
        'PrintDialog1
        '
        Me.PrintDialog1.Document = Me.PrintDocument1
        Me.PrintDialog1.UseEXDialog = True
        '
        'PrintDocument1
        '
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
        Me.PATIENTBindingNavigator.Size = New System.Drawing.Size(1104, 25)
        Me.PATIENTBindingNavigator.TabIndex = 70
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
        'txtPNAME
        '
        Me.txtPNAME.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PATIENTBindingSource, "PNAME", True))
        Me.txtPNAME.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPNAME.ForeColor = System.Drawing.SystemColors.Desktop
        Me.txtPNAME.Location = New System.Drawing.Point(405, 81)
        Me.txtPNAME.Name = "txtPNAME"
        Me.txtPNAME.Size = New System.Drawing.Size(200, 20)
        Me.txtPNAME.TabIndex = 107
        Me.txtPNAME.Text = "Physician"
        '
        'txtNMEDS
        '
        Me.txtNMEDS.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PATIENTBindingSource, "NMEDS", True))
        Me.txtNMEDS.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNMEDS.ForeColor = System.Drawing.SystemColors.Desktop
        Me.txtNMEDS.Location = New System.Drawing.Point(405, 105)
        Me.txtNMEDS.Multiline = True
        Me.txtNMEDS.Name = "txtNMEDS"
        Me.txtNMEDS.Size = New System.Drawing.Size(376, 95)
        Me.txtNMEDS.TabIndex = 109
        Me.txtNMEDS.Text = "New Medications"
        '
        'txtRECOMMEND
        '
        Me.txtRECOMMEND.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PATIENTBindingSource, "RECOMMEND", True))
        Me.txtRECOMMEND.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRECOMMEND.ForeColor = System.Drawing.SystemColors.Desktop
        Me.txtRECOMMEND.Location = New System.Drawing.Point(405, 231)
        Me.txtRECOMMEND.Multiline = True
        Me.txtRECOMMEND.Name = "txtRECOMMEND"
        Me.txtRECOMMEND.Size = New System.Drawing.Size(376, 128)
        Me.txtRECOMMEND.TabIndex = 113
        Me.txtRECOMMEND.Text = "Recommendations"
        '
        'txtACCOUNTNO2
        '
        Me.txtACCOUNTNO2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PATIENTBindingSource, "ACCOUNTNO", True))
        Me.txtACCOUNTNO2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtACCOUNTNO2.ForeColor = System.Drawing.SystemColors.Desktop
        Me.txtACCOUNTNO2.Location = New System.Drawing.Point(405, 56)
        Me.txtACCOUNTNO2.Name = "txtACCOUNTNO2"
        Me.txtACCOUNTNO2.Size = New System.Drawing.Size(200, 20)
        Me.txtACCOUNTNO2.TabIndex = 114
        Me.txtACCOUNTNO2.Text = "Account #"
        '
        'btnSave2
        '
        Me.btnSave2.BackColor = System.Drawing.Color.Cornsilk
        Me.btnSave2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave2.ForeColor = System.Drawing.Color.Green
        Me.btnSave2.Location = New System.Drawing.Point(519, 487)
        Me.btnSave2.Name = "btnSave2"
        Me.btnSave2.Size = New System.Drawing.Size(75, 29)
        Me.btnSave2.TabIndex = 115
        Me.btnSave2.Text = "Save"
        Me.btnSave2.UseVisualStyleBackColor = False
        '
        'lbSearch2
        '
        Me.lbSearch2.AutoSize = True
        Me.lbSearch2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbSearch2.Location = New System.Drawing.Point(506, 397)
        Me.lbSearch2.Name = "lbSearch2"
        Me.lbSearch2.Size = New System.Drawing.Size(121, 14)
        Me.lbSearch2.TabIndex = 126
        Me.lbSearch2.Text = "Search Patient Records"
        '
        'ComboBox2
        '
        Me.ComboBox2.DataSource = Me.PATIENTBindingSource
        Me.ComboBox2.DisplayMember = "ACCOUNTNO"
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.ItemHeight = 22
        Me.ComboBox2.Location = New System.Drawing.Point(405, 414)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(321, 30)
        Me.ComboBox2.TabIndex = 125
        '
        'btnSearchForward2
        '
        Me.btnSearchForward2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnSearchForward2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchForward2.Location = New System.Drawing.Point(567, 450)
        Me.btnSearchForward2.Name = "btnSearchForward2"
        Me.btnSearchForward2.Size = New System.Drawing.Size(75, 29)
        Me.btnSearchForward2.TabIndex = 124
        Me.btnSearchForward2.Text = ">"
        Me.btnSearchForward2.UseVisualStyleBackColor = False
        '
        'btnSearchBack2
        '
        Me.btnSearchBack2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnSearchBack2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchBack2.Location = New System.Drawing.Point(486, 450)
        Me.btnSearchBack2.Name = "btnSearchBack2"
        Me.btnSearchBack2.Size = New System.Drawing.Size(75, 29)
        Me.btnSearchBack2.TabIndex = 123
        Me.btnSearchBack2.Text = "<"
        Me.btnSearchBack2.UseVisualStyleBackColor = False
        '
        'txtDIAGCODE
        '
        Me.txtDIAGCODE.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PATIENTBindingSource, "DIAGCODE", True))
        Me.txtDIAGCODE.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDIAGCODE.Location = New System.Drawing.Point(405, 206)
        Me.txtDIAGCODE.Name = "txtDIAGCODE"
        Me.txtDIAGCODE.Size = New System.Drawing.Size(376, 20)
        Me.txtDIAGCODE.TabIndex = 127
        Me.txtDIAGCODE.Text = "Diagnosis"
        '
        'PhysicianInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(5.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1058, 573)
        Me.Controls.Add(Me.txtDIAGCODE)
        Me.Controls.Add(Me.lbSearch2)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.btnSearchForward2)
        Me.Controls.Add(Me.btnSearchBack2)
        Me.Controls.Add(Me.btnSave2)
        Me.Controls.Add(Me.txtACCOUNTNO2)
        Me.Controls.Add(Me.txtPNAME)
        Me.Controls.Add(Me.txtNMEDS)
        Me.Controls.Add(Me.txtRECOMMEND)
        Me.Controls.Add(Me.PATIENTBindingNavigator)
        Me.Controls.Add(Me.btnPrint1)
        Me.Controls.Add(Me.lbNewMeds)
        Me.Controls.Add(Me.lbRecommend)
        Me.Controls.Add(Me.lbDiagnosis)
        Me.Controls.Add(Me.btnBack2)
        Me.Controls.Add(Me.btnExit2)
        Me.Controls.Add(Me.btnMedical2)
        Me.Controls.Add(Me.btnUpdate2)
        Me.Controls.Add(Me.lbPhysician)
        Me.Controls.Add(Me.lbAccountNo3)
        Me.Controls.Add(Me.lbTitle3)
        Me.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Name = "PhysicianInfo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Physician Information"
        CType(Me.PatientTableDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PATIENTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PATIENTBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PATIENTBindingNavigator.ResumeLayout(False)
        Me.PATIENTBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnExit2 As Button
    Friend WithEvents btnMedical2 As Button
    Friend WithEvents btnUpdate2 As Button
    Friend WithEvents lbPhysician As Label
    Friend WithEvents lbAccountNo3 As Label
    Friend WithEvents lbTitle3 As Label
    Friend WithEvents btnBack2 As Button
    Friend WithEvents lbDiagnosis As Label
    Friend WithEvents lbRecommend As Label
    Friend WithEvents lbNewMeds As Label
    Friend WithEvents btnPrint1 As Button
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
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
    Friend WithEvents txtPNAME As TextBox
    Friend WithEvents txtNMEDS As TextBox
    Friend WithEvents txtRECOMMEND As TextBox
    Friend WithEvents txtACCOUNTNO2 As TextBox
    Friend WithEvents btnSave2 As Button
    Friend WithEvents lbSearch2 As Label
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents btnSearchForward2 As Button
    Friend WithEvents btnSearchBack2 As Button
    Friend WithEvents txtDIAGCODE As TextBox
End Class
