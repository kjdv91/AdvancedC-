<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btn1 = New System.Windows.Forms.Button()
        Me.myTextName = New System.Windows.Forms.TextBox()
        Me.name = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ListOcupations = New System.Windows.Forms.ListBox()
        Me.myTextSex = New System.Windows.Forms.TextBox()
        Me.myTextLastName = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btn1
        '
        Me.btn1.AccessibleDescription = "btn1"
        Me.btn1.Location = New System.Drawing.Point(312, 174)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(75, 23)
        Me.btn1.TabIndex = 0
        Me.btn1.Text = "Press Here"
        Me.btn1.UseVisualStyleBackColor = True
        '
        'myTextName
        '
        Me.myTextName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.myTextName.Location = New System.Drawing.Point(270, 86)
        Me.myTextName.Name = "myTextName"
        Me.myTextName.Size = New System.Drawing.Size(100, 13)
        Me.myTextName.TabIndex = 1
        Me.myTextName.UseSystemPasswordChar = True
        '
        'name
        '
        Me.name.AutoSize = True
        Me.name.Location = New System.Drawing.Point(207, 89)
        Me.name.Name = "name"
        Me.name.Size = New System.Drawing.Size(57, 13)
        Me.name.TabIndex = 2
        Me.name.Text = "First Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(207, 89)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "First Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(207, 141)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(25, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Sex"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(207, 118)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Last Name"
        '
        'ListOcupations
        '
        Me.ListOcupations.FormattingEnabled = True
        Me.ListOcupations.Items.AddRange(New Object() {"Doctor", "Programmer", "Chef"})
        Me.ListOcupations.Location = New System.Drawing.Point(382, 59)
        Me.ListOcupations.Name = "ListOcupations"
        Me.ListOcupations.Size = New System.Drawing.Size(120, 95)
        Me.ListOcupations.TabIndex = 5
        '
        'myTextSex
        '
        Me.myTextSex.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.myTextSex.Location = New System.Drawing.Point(270, 141)
        Me.myTextSex.Name = "myTextSex"
        Me.myTextSex.Size = New System.Drawing.Size(100, 13)
        Me.myTextSex.TabIndex = 6
        Me.myTextSex.UseSystemPasswordChar = True
        '
        'myTextLastName
        '
        Me.myTextLastName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.myTextLastName.Location = New System.Drawing.Point(270, 118)
        Me.myTextLastName.Name = "myTextLastName"
        Me.myTextLastName.Size = New System.Drawing.Size(100, 13)
        Me.myTextLastName.TabIndex = 7
        Me.myTextLastName.UseSystemPasswordChar = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(514, 450)
        Me.Controls.Add(Me.myTextLastName)
        Me.Controls.Add(Me.myTextSex)
        Me.Controls.Add(Me.ListOcupations)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.name)
        Me.Controls.Add(Me.myTextName)
        Me.Controls.Add(Me.btn1)
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn1 As Button
    Friend WithEvents myTextName As TextBox
    Friend WithEvents name As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ListOcupations As ListBox
    Friend WithEvents myTextSex As TextBox
    Friend WithEvents myTextLastName As TextBox
End Class
