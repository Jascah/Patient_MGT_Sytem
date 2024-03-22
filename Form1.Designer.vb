<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        txt_id = New TextBox()
        txt_name = New TextBox()
        cmb_gender = New ComboBox()
        btn_save = New Button()
        btn_edit = New Button()
        btn_delete = New Button()
        btn_clear = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        DataGridView1 = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        txt_search = New TextBox()
        Label6 = New Label()
        Label7 = New Label()
        exp_datepicker = New DateTimePicker()
        txt_age = New TextBox()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txt_id
        ' 
        txt_id.Location = New Point(15, 85)
        txt_id.Name = "txt_id"
        txt_id.Size = New Size(204, 23)
        txt_id.TabIndex = 0
        ' 
        ' txt_name
        ' 
        txt_name.Location = New Point(14, 129)
        txt_name.Name = "txt_name"
        txt_name.Size = New Size(204, 23)
        txt_name.TabIndex = 0
        ' 
        ' cmb_gender
        ' 
        cmb_gender.FormattingEnabled = True
        cmb_gender.Items.AddRange(New Object() {"MALE", "FEMALE", "OTHER"})
        cmb_gender.Location = New Point(14, 178)
        cmb_gender.Name = "cmb_gender"
        cmb_gender.Size = New Size(121, 23)
        cmb_gender.TabIndex = 1
        ' 
        ' btn_save
        ' 
        btn_save.BackColor = Color.DarkSlateGray
        btn_save.Cursor = Cursors.Hand
        btn_save.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_save.ForeColor = Color.White
        btn_save.Location = New Point(14, 345)
        btn_save.Name = "btn_save"
        btn_save.Size = New Size(82, 42)
        btn_save.TabIndex = 2
        btn_save.Text = "Save"
        btn_save.UseVisualStyleBackColor = False
        ' 
        ' btn_edit
        ' 
        btn_edit.BackColor = Color.DarkSlateGray
        btn_edit.Cursor = Cursors.Hand
        btn_edit.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_edit.ForeColor = Color.White
        btn_edit.Location = New Point(114, 345)
        btn_edit.Name = "btn_edit"
        btn_edit.Size = New Size(82, 42)
        btn_edit.TabIndex = 2
        btn_edit.Text = "Update"
        btn_edit.UseVisualStyleBackColor = False
        ' 
        ' btn_delete
        ' 
        btn_delete.BackColor = Color.DarkSlateGray
        btn_delete.Cursor = Cursors.Hand
        btn_delete.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_delete.ForeColor = Color.White
        btn_delete.Location = New Point(14, 388)
        btn_delete.Name = "btn_delete"
        btn_delete.Size = New Size(82, 42)
        btn_delete.TabIndex = 2
        btn_delete.Text = "Delete"
        btn_delete.UseVisualStyleBackColor = False
        ' 
        ' btn_clear
        ' 
        btn_clear.BackColor = Color.DarkSlateGray
        btn_clear.Cursor = Cursors.Hand
        btn_clear.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_clear.ForeColor = Color.White
        btn_clear.Location = New Point(114, 393)
        btn_clear.Name = "btn_clear"
        btn_clear.Size = New Size(82, 42)
        btn_clear.TabIndex = 2
        btn_clear.Text = "Clear"
        btn_clear.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(19, 67)
        Label1.Name = "Label1"
        Label1.Size = New Size(41, 15)
        Label1.TabIndex = 3
        Label1.Text = "ID_NO"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(15, 111)
        Label2.Name = "Label2"
        Label2.Size = New Size(39, 15)
        Label2.TabIndex = 4
        Label2.Text = "Name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(14, 160)
        Label3.Name = "Label3"
        Label3.Size = New Size(45, 15)
        Label3.TabIndex = 5
        Label3.Text = "Gender"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(15, 215)
        Label4.Name = "Label4"
        Label4.Size = New Size(28, 15)
        Label4.TabIndex = 6
        Label4.Text = "Age"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(13, 276)
        Label5.Name = "Label5"
        Label5.Size = New Size(31, 15)
        Label5.TabIndex = 7
        Label5.Text = "Date"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.BackgroundColor = Color.White
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4, Column5})
        DataGridView1.Location = New Point(239, 140)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RowHeadersVisible = False
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView1.Size = New Size(510, 329)
        DataGridView1.TabIndex = 8
        ' 
        ' Column1
        ' 
        Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column1.HeaderText = "ID_NO"
        Column1.Name = "Column1"
        Column1.ReadOnly = True
        Column1.Width = 66
        ' 
        ' Column2
        ' 
        Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Column2.HeaderText = "Name"
        Column2.Name = "Column2"
        Column2.ReadOnly = True
        ' 
        ' Column3
        ' 
        Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column3.HeaderText = "Gender"
        Column3.Name = "Column3"
        Column3.ReadOnly = True
        Column3.Width = 70
        ' 
        ' Column4
        ' 
        Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column4.HeaderText = "Age"
        Column4.Name = "Column4"
        Column4.ReadOnly = True
        Column4.Width = 53
        ' 
        ' Column5
        ' 
        Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column5.HeaderText = "Date"
        Column5.Name = "Column5"
        Column5.ReadOnly = True
        Column5.Width = 56
        ' 
        ' txt_search
        ' 
        txt_search.Location = New Point(239, 85)
        txt_search.Name = "txt_search"
        txt_search.Size = New Size(318, 23)
        txt_search.TabIndex = 0
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(243, 67)
        Label6.Name = "Label6"
        Label6.Size = New Size(42, 15)
        Label6.TabIndex = 3
        Label6.Text = "Search"
        Label6.UseMnemonic = False
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.FlatStyle = FlatStyle.System
        Label7.Font = New Font("Felix Titling", 17.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(210, 9)
        Label7.Name = "Label7"
        Label7.Size = New Size(387, 27)
        Label7.TabIndex = 9
        Label7.Text = "Patient Management System"
        Label7.TextAlign = ContentAlignment.BottomCenter
        ' 
        ' exp_datepicker
        ' 
        exp_datepicker.Location = New Point(12, 294)
        exp_datepicker.Name = "exp_datepicker"
        exp_datepicker.Size = New Size(200, 23)
        exp_datepicker.TabIndex = 10
        ' 
        ' txt_age
        ' 
        txt_age.Location = New Point(19, 235)
        txt_age.Name = "txt_age"
        txt_age.Size = New Size(100, 23)
        txt_age.TabIndex = 11
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightGray
        ClientSize = New Size(771, 522)
        Controls.Add(txt_age)
        Controls.Add(exp_datepicker)
        Controls.Add(Label7)
        Controls.Add(DataGridView1)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label6)
        Controls.Add(Label1)
        Controls.Add(btn_clear)
        Controls.Add(btn_delete)
        Controls.Add(btn_edit)
        Controls.Add(btn_save)
        Controls.Add(cmb_gender)
        Controls.Add(txt_search)
        Controls.Add(txt_name)
        Controls.Add(txt_id)
        Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Margin = New Padding(4, 3, 4, 3)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Patient_Record"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txt_id As TextBox
    Friend WithEvents txt_name As TextBox
    Friend WithEvents cmb_gender As ComboBox
    Friend WithEvents btn_save As Button
    Friend WithEvents btn_edit As Button
    Friend WithEvents btn_delete As Button
    Friend WithEvents btn_clear As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txt_search As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents exp_datepicker As DateTimePicker
    Friend WithEvents txt_age As TextBox

End Class
