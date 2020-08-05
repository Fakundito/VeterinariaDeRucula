<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Persona
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ButtonAceptar = New System.Windows.Forms.Button()
        Me.LabelCi = New System.Windows.Forms.Label()
        Me.LabelNombre = New System.Windows.Forms.Label()
        Me.LabelDireccion = New System.Windows.Forms.Label()
        Me.TextBoxCi = New System.Windows.Forms.TextBox()
        Me.TextBoxNombre = New System.Windows.Forms.TextBox()
        Me.TextBoxDireccion = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.LabelTelefono = New System.Windows.Forms.Label()
        Me.LabelPersona = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ButtonAceptar
        '
        Me.ButtonAceptar.Location = New System.Drawing.Point(156, 219)
        Me.ButtonAceptar.Name = "ButtonAceptar"
        Me.ButtonAceptar.Size = New System.Drawing.Size(75, 23)
        Me.ButtonAceptar.TabIndex = 0
        Me.ButtonAceptar.Text = "Aceptar"
        Me.ButtonAceptar.UseVisualStyleBackColor = True
        '
        'LabelCi
        '
        Me.LabelCi.AutoSize = True
        Me.LabelCi.Location = New System.Drawing.Point(104, 88)
        Me.LabelCi.Name = "LabelCi"
        Me.LabelCi.Size = New System.Drawing.Size(20, 13)
        Me.LabelCi.TabIndex = 1
        Me.LabelCi.Text = "CI:"
        '
        'LabelNombre
        '
        Me.LabelNombre.AutoSize = True
        Me.LabelNombre.Location = New System.Drawing.Point(104, 112)
        Me.LabelNombre.Name = "LabelNombre"
        Me.LabelNombre.Size = New System.Drawing.Size(47, 13)
        Me.LabelNombre.TabIndex = 2
        Me.LabelNombre.Text = "Nombre:"
        '
        'LabelDireccion
        '
        Me.LabelDireccion.AutoSize = True
        Me.LabelDireccion.Location = New System.Drawing.Point(104, 136)
        Me.LabelDireccion.Name = "LabelDireccion"
        Me.LabelDireccion.Size = New System.Drawing.Size(55, 13)
        Me.LabelDireccion.TabIndex = 3
        Me.LabelDireccion.Text = "Direccion:"
        '
        'TextBoxCi
        '
        Me.TextBoxCi.Location = New System.Drawing.Point(179, 85)
        Me.TextBoxCi.Name = "TextBoxCi"
        Me.TextBoxCi.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxCi.TabIndex = 4
        '
        'TextBoxNombre
        '
        Me.TextBoxNombre.Location = New System.Drawing.Point(179, 109)
        Me.TextBoxNombre.Name = "TextBoxNombre"
        Me.TextBoxNombre.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxNombre.TabIndex = 5
        '
        'TextBoxDireccion
        '
        Me.TextBoxDireccion.Location = New System.Drawing.Point(179, 133)
        Me.TextBoxDireccion.Name = "TextBoxDireccion"
        Me.TextBoxDireccion.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxDireccion.TabIndex = 6
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(179, 159)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 8
        '
        'LabelTelefono
        '
        Me.LabelTelefono.AutoSize = True
        Me.LabelTelefono.Location = New System.Drawing.Point(104, 162)
        Me.LabelTelefono.Name = "LabelTelefono"
        Me.LabelTelefono.Size = New System.Drawing.Size(49, 13)
        Me.LabelTelefono.TabIndex = 7
        Me.LabelTelefono.Text = "Telefono"
        '
        'LabelPersona
        '
        Me.LabelPersona.AutoSize = True
        Me.LabelPersona.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPersona.Location = New System.Drawing.Point(126, 24)
        Me.LabelPersona.Name = "LabelPersona"
        Me.LabelPersona.Size = New System.Drawing.Size(122, 31)
        Me.LabelPersona.TabIndex = 9
        Me.LabelPersona.Text = "Persona"
        '
        'Persona
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 311)
        Me.Controls.Add(Me.LabelPersona)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.LabelTelefono)
        Me.Controls.Add(Me.TextBoxDireccion)
        Me.Controls.Add(Me.TextBoxNombre)
        Me.Controls.Add(Me.TextBoxCi)
        Me.Controls.Add(Me.LabelDireccion)
        Me.Controls.Add(Me.LabelNombre)
        Me.Controls.Add(Me.LabelCi)
        Me.Controls.Add(Me.ButtonAceptar)
        Me.Name = "Persona"
        Me.Text = "Persona"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonAceptar As Button
    Friend WithEvents LabelCi As Label
    Friend WithEvents LabelNombre As Label
    Friend WithEvents LabelDireccion As Label
    Friend WithEvents TextBoxCi As TextBox
    Friend WithEvents TextBoxNombre As TextBox
    Friend WithEvents TextBoxDireccion As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents LabelTelefono As Label
    Friend WithEvents LabelPersona As Label
End Class
