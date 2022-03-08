<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TeisendajaAken
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
        Me.lblSisendYhik = New System.Windows.Forms.Label()
        Me.lblVastusYhik = New System.Windows.Forms.Label()
        Me.txtSisend = New System.Windows.Forms.TextBox()
        Me.txtVastus = New System.Windows.Forms.TextBox()
        Me.cmbTeisendus = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'lblSisendYhik
        '
        Me.lblSisendYhik.AutoSize = True
        Me.lblSisendYhik.Location = New System.Drawing.Point(538, 102)
        Me.lblSisendYhik.Name = "lblSisendYhik"
        Me.lblSisendYhik.Size = New System.Drawing.Size(58, 20)
        Me.lblSisendYhik.TabIndex = 0
        Me.lblSisendYhik.Text = "Sisend"
        '
        'lblVastusYhik
        '
        Me.lblVastusYhik.AutoSize = True
        Me.lblVastusYhik.Location = New System.Drawing.Point(538, 169)
        Me.lblVastusYhik.Name = "lblVastusYhik"
        Me.lblVastusYhik.Size = New System.Drawing.Size(59, 20)
        Me.lblVastusYhik.TabIndex = 1
        Me.lblVastusYhik.Text = "Vastus"
        '
        'txtSisend
        '
        Me.txtSisend.Location = New System.Drawing.Point(170, 102)
        Me.txtSisend.Name = "txtSisend"
        Me.txtSisend.Size = New System.Drawing.Size(100, 26)
        Me.txtSisend.TabIndex = 2
        '
        'txtVastus
        '
        Me.txtVastus.Location = New System.Drawing.Point(170, 169)
        Me.txtVastus.Name = "txtVastus"
        Me.txtVastus.Size = New System.Drawing.Size(100, 26)
        Me.txtVastus.TabIndex = 3
        '
        'cmbTeisendus
        '
        Me.cmbTeisendus.FormattingEnabled = True
        Me.cmbTeisendus.Location = New System.Drawing.Point(170, 135)
        Me.cmbTeisendus.Name = "cmbTeisendus"
        Me.cmbTeisendus.Size = New System.Drawing.Size(121, 28)
        Me.cmbTeisendus.TabIndex = 4
        '
        'TeisendajaAken
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.cmbTeisendus)
        Me.Controls.Add(Me.txtVastus)
        Me.Controls.Add(Me.txtSisend)
        Me.Controls.Add(Me.lblVastusYhik)
        Me.Controls.Add(Me.lblSisendYhik)
        Me.Name = "TeisendajaAken"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblSisendYhik As Label
    Friend WithEvents lblVastusYhik As Label
    Friend WithEvents txtSisend As TextBox
    Friend WithEvents txtVastus As TextBox
    Friend WithEvents cmbTeisendus As ComboBox
End Class
