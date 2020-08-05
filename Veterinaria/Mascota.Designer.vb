<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Mascota
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
        Me.LabelCi = New System.Windows.Forms.Label()
        Me.LabelNombre = New System.Windows.Forms.Label()
        Me.LabelAnoNacimiento = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.ButtonAceptar = New System.Windows.Forms.Button()
        Me.LabelMascota = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LabelCi
        '
        Me.LabelCi.AutoSize = True
        Me.LabelCi.Location = New System.Drawing.Point(94, 88)
        Me.LabelCi.Name = "LabelCi"
        Me.LabelCi.Size = New System.Drawing.Size(20, 13)
        Me.LabelCi.TabIndex = 0
        Me.LabelCi.Text = "CI:"
        '
        'LabelNombre
        '
        Me.LabelNombre.AutoSize = True
        Me.LabelNombre.Location = New System.Drawing.Point(94, 113)
        Me.LabelNombre.Name = "LabelNombre"
        Me.LabelNombre.Size = New System.Drawing.Size(44, 13)
        Me.LabelNombre.TabIndex = 1
        Me.LabelNombre.Text = "Nombre"
        '
        'LabelAnoNacimiento
        '
        Me.LabelAnoNacimiento.AutoSize = True
        Me.LabelAnoNacimiento.Location = New System.Drawing.Point(94, 141)
        Me.LabelAnoNacimiento.Name = "LabelAnoNacimiento"
        Me.LabelAnoNacimiento.Size = New System.Drawing.Size(82, 13)
        Me.LabelAnoNacimiento.TabIndex = 2
        Me.LabelAnoNacimiento.Text = "Año Nacimiento"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(194, 85)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(99, 20)
        Me.TextBox1.TabIndex = 3
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(194, 110)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(99, 20)
        Me.TextBox2.TabIndex = 4
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(194, 138)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(99, 20)
        Me.TextBox3.TabIndex = 5
        '
        'ButtonAceptar
        '
        Me.ButtonAceptar.Location = New System.Drawing.Point(149, 207)
        Me.ButtonAceptar.Name = "ButtonAceptar"
        Me.ButtonAceptar.Size = New System.Drawing.Size(75, 23)
        Me.ButtonAceptar.TabIndex = 6
        Me.ButtonAceptar.Text = "Aceptar"
        Me.ButtonAceptar.UseVisualStyleBackColor = True
        '
        'LabelMascota
        '
        Me.LabelMascota.AutoSize = True
        Me.LabelMascota.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelMascota.Location = New System.Drawing.Point(124, 26)
        Me.LabelMascota.Name = "LabelMascota"
        Me.LabelMascota.Size = New System.Drawing.Size(124, 31)
        Me.LabelMascota.TabIndex = 7
        Me.LabelMascota.Text = "Mascota"
        '
        'Mascota
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 311)
        Me.Controls.Add(Me.LabelMascota)
        Me.Controls.Add(Me.ButtonAceptar)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.LabelAnoNacimiento)
        Me.Controls.Add(Me.LabelNombre)
        Me.Controls.Add(Me.LabelCi)
        Me.Name = "Mascota"
        Me.Text = "Mascota"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelCi As Label
    Friend WithEvents LabelNombre As Label
    Friend WithEvents LabelAnoNacimiento As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents ButtonAceptar As Button
    Friend WithEvents LabelMascota As Label
End Class
