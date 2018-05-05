<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.aceptar = New System.Windows.Forms.Button
        Me.hombre = New System.Windows.Forms.RadioButton
        Me.mujer = New System.Windows.Forms.RadioButton
        Me.personafisica = New System.Windows.Forms.RadioButton
        Me.personajuridica = New System.Windows.Forms.RadioButton
        Me.persona = New System.Windows.Forms.GroupBox
        Me.sexo = New System.Windows.Forms.GroupBox
        Me.persona.SuspendLayout()
        Me.sexo.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(247, 229)
        Me.TextBox1.MaxLength = 11
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(135, 20)
        Me.TextBox1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(180, 236)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Ingrese cuil"
        '
        'aceptar
        '
        Me.aceptar.Location = New System.Drawing.Point(234, 289)
        Me.aceptar.Name = "aceptar"
        Me.aceptar.Size = New System.Drawing.Size(130, 53)
        Me.aceptar.TabIndex = 2
        Me.aceptar.Text = "aceptar"
        Me.aceptar.UseVisualStyleBackColor = True
        '
        'hombre
        '
        Me.hombre.AutoSize = True
        Me.hombre.Enabled = False
        Me.hombre.Location = New System.Drawing.Point(6, 19)
        Me.hombre.Name = "hombre"
        Me.hombre.Size = New System.Drawing.Size(62, 17)
        Me.hombre.TabIndex = 3
        Me.hombre.TabStop = True
        Me.hombre.Text = "Hombre"
        Me.hombre.UseVisualStyleBackColor = True
        '
        'mujer
        '
        Me.mujer.AutoSize = True
        Me.mujer.Enabled = False
        Me.mujer.Location = New System.Drawing.Point(6, 61)
        Me.mujer.Name = "mujer"
        Me.mujer.Size = New System.Drawing.Size(51, 17)
        Me.mujer.TabIndex = 4
        Me.mujer.TabStop = True
        Me.mujer.Text = "Mujer"
        Me.mujer.UseVisualStyleBackColor = True
        '
        'personafisica
        '
        Me.personafisica.AutoSize = True
        Me.personafisica.Location = New System.Drawing.Point(7, 29)
        Me.personafisica.Name = "personafisica"
        Me.personafisica.Size = New System.Drawing.Size(90, 17)
        Me.personafisica.TabIndex = 5
        Me.personafisica.TabStop = True
        Me.personafisica.Text = "persona fisica"
        Me.personafisica.UseVisualStyleBackColor = True
        '
        'personajuridica
        '
        Me.personajuridica.AutoSize = True
        Me.personajuridica.Location = New System.Drawing.Point(7, 77)
        Me.personajuridica.Name = "personajuridica"
        Me.personajuridica.Size = New System.Drawing.Size(99, 17)
        Me.personajuridica.TabIndex = 6
        Me.personajuridica.TabStop = True
        Me.personajuridica.Text = "persona juridica"
        Me.personajuridica.UseVisualStyleBackColor = True
        '
        'persona
        '
        Me.persona.Controls.Add(Me.personafisica)
        Me.persona.Controls.Add(Me.personajuridica)
        Me.persona.Location = New System.Drawing.Point(7, 21)
        Me.persona.Name = "persona"
        Me.persona.Size = New System.Drawing.Size(118, 145)
        Me.persona.TabIndex = 7
        Me.persona.TabStop = False
        Me.persona.Text = "persona"
        '
        'sexo
        '
        Me.sexo.Controls.Add(Me.mujer)
        Me.sexo.Controls.Add(Me.hombre)
        Me.sexo.Location = New System.Drawing.Point(247, 23)
        Me.sexo.Name = "sexo"
        Me.sexo.Size = New System.Drawing.Size(116, 143)
        Me.sexo.TabIndex = 8
        Me.sexo.TabStop = False
        Me.sexo.Text = "sexo"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(440, 400)
        Me.Controls.Add(Me.sexo)
        Me.Controls.Add(Me.persona)
        Me.Controls.Add(Me.aceptar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.persona.ResumeLayout(False)
        Me.persona.PerformLayout()
        Me.sexo.ResumeLayout(False)
        Me.sexo.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents aceptar As System.Windows.Forms.Button
    Friend WithEvents hombre As System.Windows.Forms.RadioButton
    Friend WithEvents mujer As System.Windows.Forms.RadioButton
    Friend WithEvents personafisica As System.Windows.Forms.RadioButton
    Friend WithEvents personajuridica As System.Windows.Forms.RadioButton
    Friend WithEvents persona As System.Windows.Forms.GroupBox
    Friend WithEvents sexo As System.Windows.Forms.GroupBox

End Class
