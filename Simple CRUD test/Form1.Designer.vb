<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UserForm
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
        txtName = New TextBox()
        txtEmail = New TextBox()
        btnCreate = New Button()
        btnUpdate = New Button()
        btnDelete = New Button()
        dataGridViewUsers = New DataGridView()
        CType(dataGridViewUsers, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(31, 33)
        txtName.Name = "txtName"
        txtName.Size = New Size(167, 27)
        txtName.TabIndex = 0
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(272, 33)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(227, 27)
        txtEmail.TabIndex = 1
        ' 
        ' btnCreate
        ' 
        btnCreate.Location = New Point(31, 86)
        btnCreate.Name = "btnCreate"
        btnCreate.Size = New Size(193, 47)
        btnCreate.TabIndex = 2
        btnCreate.Text = "Create"
        btnCreate.UseVisualStyleBackColor = True
        ' 
        ' btnUpdate
        ' 
        btnUpdate.Location = New Point(272, 86)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(193, 47)
        btnUpdate.TabIndex = 3
        btnUpdate.Text = "Update"
        btnUpdate.UseVisualStyleBackColor = True
        ' 
        ' btnDelete
        ' 
        btnDelete.Location = New Point(572, 86)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(193, 47)
        btnDelete.TabIndex = 4
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' dataGridViewUsers
        ' 
        dataGridViewUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dataGridViewUsers.Location = New Point(31, 163)
        dataGridViewUsers.Name = "dataGridViewUsers"
        dataGridViewUsers.RowHeadersWidth = 51
        dataGridViewUsers.Size = New Size(734, 254)
        dataGridViewUsers.TabIndex = 5
        ' 
        ' UserForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(dataGridViewUsers)
        Controls.Add(btnDelete)
        Controls.Add(btnUpdate)
        Controls.Add(btnCreate)
        Controls.Add(txtEmail)
        Controls.Add(txtName)
        Name = "UserForm"
        Text = "Form1"
        CType(dataGridViewUsers, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtName As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents btnCreate As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents dataGridViewUsers As DataGridView

End Class
