<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.listIds = New System.Windows.Forms.ListBox()
        Me.labEmployees = New System.Windows.Forms.Label()
        Me.labSalary = New System.Windows.Forms.Label()
        Me.outputSalary = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'listIds
        '
        Me.listIds.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listIds.FormattingEnabled = True
        Me.listIds.ItemHeight = 18
        Me.listIds.Location = New System.Drawing.Point(15, 53)
        Me.listIds.Name = "listIds"
        Me.listIds.Size = New System.Drawing.Size(107, 130)
        Me.listIds.TabIndex = 0
        '
        'labEmployees
        '
        Me.labEmployees.AutoSize = True
        Me.labEmployees.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labEmployees.Location = New System.Drawing.Point(19, 28)
        Me.labEmployees.Name = "labEmployees"
        Me.labEmployees.Size = New System.Drawing.Size(104, 18)
        Me.labEmployees.TabIndex = 1
        Me.labEmployees.Text = "&Employee IDs:"
        '
        'labSalary
        '
        Me.labSalary.AutoSize = True
        Me.labSalary.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labSalary.Location = New System.Drawing.Point(145, 28)
        Me.labSalary.Name = "labSalary"
        Me.labSalary.Size = New System.Drawing.Size(53, 18)
        Me.labSalary.TabIndex = 1
        Me.labSalary.Text = "Salary:"
        '
        'outputSalary
        '
        Me.outputSalary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.outputSalary.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.outputSalary.Location = New System.Drawing.Point(148, 64)
        Me.outputSalary.Name = "outputSalary"
        Me.outputSalary.Size = New System.Drawing.Size(93, 30)
        Me.outputSalary.TabIndex = 1
        Me.outputSalary.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(146, 135)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(94, 35)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(274, 213)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.outputSalary)
        Me.Controls.Add(Me.labSalary)
        Me.Controls.Add(Me.labEmployees)
        Me.Controls.Add(Me.listIds)
        Me.Name = "MainForm"
        Me.Text = "Zander Inc."
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents listIds As ListBox
    Friend WithEvents labEmployees As Label
    Friend WithEvents labSalary As Label
    Friend WithEvents outputSalary As Label
    Friend WithEvents btnExit As Button
End Class
