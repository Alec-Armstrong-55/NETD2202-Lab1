<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAverageUnitsShipped
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
        Me.btnEnterUseable = New System.Windows.Forms.Button()
        Me.btnResetForm = New System.Windows.Forms.Button()
        Me.btnExitForm = New System.Windows.Forms.Button()
        Me.txtGetUnits = New System.Windows.Forms.TextBox()
        Me.txtShowPrevUnits = New System.Windows.Forms.TextBox()
        Me.lblUnits = New System.Windows.Forms.Label()
        Me.lblDay = New System.Windows.Forms.Label()
        Me.ttpAverageUnitsShippedForm = New System.Windows.Forms.ToolTip(Me.components)
        Me.lblShowAverage = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnEnterUseable
        '
        Me.btnEnterUseable.BackColor = System.Drawing.Color.White
        Me.btnEnterUseable.Location = New System.Drawing.Point(68, 552)
        Me.btnEnterUseable.Name = "btnEnterUseable"
        Me.btnEnterUseable.Size = New System.Drawing.Size(153, 75)
        Me.btnEnterUseable.TabIndex = 5
        Me.btnEnterUseable.Text = "&Enter"
        Me.ttpAverageUnitsShippedForm.SetToolTip(Me.btnEnterUseable, "Assign the units entered to the day of the week.")
        Me.btnEnterUseable.UseVisualStyleBackColor = False
        '
        'btnResetForm
        '
        Me.btnResetForm.BackColor = System.Drawing.Color.White
        Me.btnResetForm.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnResetForm.Location = New System.Drawing.Point(326, 552)
        Me.btnResetForm.Name = "btnResetForm"
        Me.btnResetForm.Size = New System.Drawing.Size(153, 75)
        Me.btnResetForm.TabIndex = 6
        Me.btnResetForm.Text = "&Reset"
        Me.ttpAverageUnitsShippedForm.SetToolTip(Me.btnResetForm, "Reset the form to day one.")
        Me.btnResetForm.UseVisualStyleBackColor = False
        '
        'btnExitForm
        '
        Me.btnExitForm.BackColor = System.Drawing.Color.White
        Me.btnExitForm.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExitForm.Location = New System.Drawing.Point(584, 552)
        Me.btnExitForm.Name = "btnExitForm"
        Me.btnExitForm.Size = New System.Drawing.Size(153, 75)
        Me.btnExitForm.TabIndex = 7
        Me.btnExitForm.Text = "E&xit"
        Me.ttpAverageUnitsShippedForm.SetToolTip(Me.btnExitForm, "Exit the form.")
        Me.btnExitForm.UseVisualStyleBackColor = False
        '
        'txtGetUnits
        '
        Me.txtGetUnits.BackColor = System.Drawing.Color.White
        Me.txtGetUnits.Location = New System.Drawing.Point(331, 70)
        Me.txtGetUnits.MaxLength = 4
        Me.txtGetUnits.Name = "txtGetUnits"
        Me.txtGetUnits.Size = New System.Drawing.Size(100, 38)
        Me.txtGetUnits.TabIndex = 1
        Me.ttpAverageUnitsShippedForm.SetToolTip(Me.txtGetUnits, "Enter the number of units shipped.")
        '
        'txtShowPrevUnits
        '
        Me.txtShowPrevUnits.BackColor = System.Drawing.Color.White
        Me.txtShowPrevUnits.Location = New System.Drawing.Point(222, 143)
        Me.txtShowPrevUnits.Multiline = True
        Me.txtShowPrevUnits.Name = "txtShowPrevUnits"
        Me.txtShowPrevUnits.ReadOnly = True
        Me.txtShowPrevUnits.Size = New System.Drawing.Size(360, 300)
        Me.txtShowPrevUnits.TabIndex = 3
        Me.txtShowPrevUnits.TabStop = False
        Me.ttpAverageUnitsShippedForm.SetToolTip(Me.txtShowPrevUnits, "Shows the units shipped on previous days.")
        '
        'lblUnits
        '
        Me.lblUnits.AutoSize = True
        Me.lblUnits.Location = New System.Drawing.Point(237, 73)
        Me.lblUnits.Name = "lblUnits"
        Me.lblUnits.Size = New System.Drawing.Size(88, 32)
        Me.lblUnits.TabIndex = 0
        Me.lblUnits.Text = "&Units:"
        Me.ttpAverageUnitsShippedForm.SetToolTip(Me.lblUnits, "Enter the number of units shipped.")
        '
        'lblDay
        '
        Me.lblDay.AutoSize = True
        Me.lblDay.Location = New System.Drawing.Point(455, 73)
        Me.lblDay.Name = "lblDay"
        Me.lblDay.Size = New System.Drawing.Size(0, 32)
        Me.lblDay.TabIndex = 2
        Me.ttpAverageUnitsShippedForm.SetToolTip(Me.lblDay, "Specifies the day of the week.")
        '
        'lblShowAverage
        '
        Me.lblShowAverage.BackColor = System.Drawing.Color.LightGray
        Me.lblShowAverage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblShowAverage.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblShowAverage.Location = New System.Drawing.Point(222, 457)
        Me.lblShowAverage.Name = "lblShowAverage"
        Me.lblShowAverage.Size = New System.Drawing.Size(360, 60)
        Me.lblShowAverage.TabIndex = 4
        Me.lblShowAverage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ttpAverageUnitsShippedForm.SetToolTip(Me.lblShowAverage, "Displays the average units shipped over the seven days.")
        '
        'frmAverageUnitsShipped
        '
        Me.AcceptButton = Me.btnEnterUseable
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.CancelButton = Me.btnResetForm
        Me.ClientSize = New System.Drawing.Size(799, 693)
        Me.Controls.Add(Me.lblShowAverage)
        Me.Controls.Add(Me.lblDay)
        Me.Controls.Add(Me.lblUnits)
        Me.Controls.Add(Me.txtShowPrevUnits)
        Me.Controls.Add(Me.txtGetUnits)
        Me.Controls.Add(Me.btnExitForm)
        Me.Controls.Add(Me.btnResetForm)
        Me.Controls.Add(Me.btnEnterUseable)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAverageUnitsShipped"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Average Units Shipped"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnEnterUseable As Button
    Friend WithEvents btnResetForm As Button
    Friend WithEvents btnExitForm As Button
    Friend WithEvents txtGetUnits As TextBox
    Friend WithEvents txtShowPrevUnits As TextBox
    Friend WithEvents lblUnits As Label
    Friend WithEvents lblDay As Label
    Friend WithEvents ttpAverageUnitsShippedForm As ToolTip
    Friend WithEvents lblShowAverage As Label
End Class
