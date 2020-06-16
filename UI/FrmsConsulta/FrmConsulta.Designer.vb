<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConsulta
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnChildCons = New System.Windows.Forms.Panel()
        Me.btnConsul = New System.Windows.Forms.Button()
        Me.ComboBox5 = New System.Windows.Forms.ComboBox()
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PanelMensajeDiagnostico = New System.Windows.Forms.Panel()
        Me.btnChat = New System.Windows.Forms.Button()
        Me.ComboBox6 = New System.Windows.Forms.ComboBox()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.ComboBox7 = New System.Windows.Forms.ComboBox()
        Me.ComboBox8 = New System.Windows.Forms.ComboBox()
        Me.ComboBox9 = New System.Windows.Forms.ComboBox()
        Me.pnChildCons.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(223, -126)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(374, 39)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "INGRESE SUS SINTOMAS"
        '
        'pnChildCons
        '
        Me.pnChildCons.Controls.Add(Me.btnConsul)
        Me.pnChildCons.Controls.Add(Me.ComboBox9)
        Me.pnChildCons.Controls.Add(Me.ComboBox5)
        Me.pnChildCons.Controls.Add(Me.ComboBox8)
        Me.pnChildCons.Controls.Add(Me.ComboBox4)
        Me.pnChildCons.Controls.Add(Me.ComboBox2)
        Me.pnChildCons.Controls.Add(Me.ComboBox1)
        Me.pnChildCons.Controls.Add(Me.Label2)
        Me.pnChildCons.Controls.Add(Me.PanelMensajeDiagnostico)
        Me.pnChildCons.Controls.Add(Me.btnChat)
        Me.pnChildCons.Controls.Add(Me.ComboBox7)
        Me.pnChildCons.Controls.Add(Me.ComboBox6)
        Me.pnChildCons.Controls.Add(Me.ComboBox3)
        Me.pnChildCons.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnChildCons.Location = New System.Drawing.Point(0, 0)
        Me.pnChildCons.Name = "pnChildCons"
        Me.pnChildCons.Size = New System.Drawing.Size(778, 699)
        Me.pnChildCons.TabIndex = 12
        '
        'btnConsul
        '
        Me.btnConsul.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.btnConsul.FlatAppearance.BorderSize = 0
        Me.btnConsul.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConsul.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConsul.Location = New System.Drawing.Point(12, 394)
        Me.btnConsul.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnConsul.Name = "btnConsul"
        Me.btnConsul.Size = New System.Drawing.Size(233, 49)
        Me.btnConsul.TabIndex = 34
        Me.btnConsul.Text = "CONSULTAR"
        Me.btnConsul.UseVisualStyleBackColor = False
        '
        'ComboBox5
        '
        Me.ComboBox5.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.ComboBox5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBox5.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox5.ForeColor = System.Drawing.Color.Silver
        Me.ComboBox5.FormattingEnabled = True
        Me.ComboBox5.Location = New System.Drawing.Point(274, 207)
        Me.ComboBox5.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ComboBox5.Name = "ComboBox5"
        Me.ComboBox5.Size = New System.Drawing.Size(233, 24)
        Me.ComboBox5.TabIndex = 33
        Me.ComboBox5.Text = "SINTOMA"
        '
        'ComboBox4
        '
        Me.ComboBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.ComboBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBox4.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox4.ForeColor = System.Drawing.Color.Silver
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Location = New System.Drawing.Point(24, 207)
        Me.ComboBox4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(233, 24)
        Me.ComboBox4.TabIndex = 32
        Me.ComboBox4.Text = "SINTOMA"
        '
        'ComboBox2
        '
        Me.ComboBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.ComboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBox2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox2.ForeColor = System.Drawing.Color.Silver
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(274, 82)
        Me.ComboBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(233, 24)
        Me.ComboBox2.TabIndex = 31
        Me.ComboBox2.Text = "SINTOMA"
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.ComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBox1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.ForeColor = System.Drawing.Color.Silver
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(24, 82)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(233, 24)
        Me.ComboBox1.TabIndex = 30
        Me.ComboBox1.Text = "SINTOMA"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Silver
        Me.Label2.Location = New System.Drawing.Point(176, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(365, 36)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Selecciones sus sintoams"
        '
        'PanelMensajeDiagnostico
        '
        Me.PanelMensajeDiagnostico.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.PanelMensajeDiagnostico.Location = New System.Drawing.Point(11, 451)
        Me.PanelMensajeDiagnostico.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PanelMensajeDiagnostico.Name = "PanelMensajeDiagnostico"
        Me.PanelMensajeDiagnostico.Size = New System.Drawing.Size(757, 225)
        Me.PanelMensajeDiagnostico.TabIndex = 25
        '
        'btnChat
        '
        Me.btnChat.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.btnChat.FlatAppearance.BorderSize = 0
        Me.btnChat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnChat.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChat.Location = New System.Drawing.Point(535, 394)
        Me.btnChat.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnChat.Name = "btnChat"
        Me.btnChat.Size = New System.Drawing.Size(233, 49)
        Me.btnChat.TabIndex = 23
        Me.btnChat.Text = "CHAT"
        Me.btnChat.UseVisualStyleBackColor = False
        '
        'ComboBox6
        '
        Me.ComboBox6.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.ComboBox6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBox6.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox6.ForeColor = System.Drawing.Color.Silver
        Me.ComboBox6.FormattingEnabled = True
        Me.ComboBox6.Location = New System.Drawing.Point(523, 207)
        Me.ComboBox6.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ComboBox6.Name = "ComboBox6"
        Me.ComboBox6.Size = New System.Drawing.Size(233, 24)
        Me.ComboBox6.TabIndex = 27
        Me.ComboBox6.Text = "SINTOMA"
        '
        'ComboBox3
        '
        Me.ComboBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.ComboBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBox3.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox3.ForeColor = System.Drawing.Color.Silver
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(523, 82)
        Me.ComboBox3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(233, 24)
        Me.ComboBox3.TabIndex = 22
        Me.ComboBox3.Text = "SINTOMA"
        '
        'ComboBox7
        '
        Me.ComboBox7.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.ComboBox7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBox7.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox7.ForeColor = System.Drawing.Color.Silver
        Me.ComboBox7.FormattingEnabled = True
        Me.ComboBox7.Location = New System.Drawing.Point(523, 142)
        Me.ComboBox7.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ComboBox7.Name = "ComboBox7"
        Me.ComboBox7.Size = New System.Drawing.Size(233, 24)
        Me.ComboBox7.TabIndex = 27
        Me.ComboBox7.Text = "SINTOMA"
        '
        'ComboBox8
        '
        Me.ComboBox8.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.ComboBox8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBox8.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox8.ForeColor = System.Drawing.Color.Silver
        Me.ComboBox8.FormattingEnabled = True
        Me.ComboBox8.Location = New System.Drawing.Point(24, 142)
        Me.ComboBox8.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ComboBox8.Name = "ComboBox8"
        Me.ComboBox8.Size = New System.Drawing.Size(233, 24)
        Me.ComboBox8.TabIndex = 32
        Me.ComboBox8.Text = "SINTOMA"
        '
        'ComboBox9
        '
        Me.ComboBox9.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.ComboBox9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBox9.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox9.ForeColor = System.Drawing.Color.Silver
        Me.ComboBox9.FormattingEnabled = True
        Me.ComboBox9.Location = New System.Drawing.Point(274, 142)
        Me.ComboBox9.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ComboBox9.Name = "ComboBox9"
        Me.ComboBox9.Size = New System.Drawing.Size(233, 24)
        Me.ComboBox9.TabIndex = 33
        Me.ComboBox9.Text = "SINTOMA"
        '
        'FrmConsulta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(778, 699)
        Me.Controls.Add(Me.pnChildCons)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FrmConsulta"
        Me.Text = "Consulta"
        Me.pnChildCons.ResumeLayout(False)
        Me.pnChildCons.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents pnChildCons As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents PanelMensajeDiagnostico As Panel
    Friend WithEvents btnChat As Button
    Friend WithEvents ComboBox6 As ComboBox
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents btnConsul As Button
    Friend WithEvents ComboBox5 As ComboBox
    Friend WithEvents ComboBox4 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox9 As ComboBox
    Friend WithEvents ComboBox8 As ComboBox
    Friend WithEvents ComboBox7 As ComboBox
End Class
