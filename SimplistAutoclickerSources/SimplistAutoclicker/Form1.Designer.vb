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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.start_btn = New System.Windows.Forms.Button()
        Me.stop_btn = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'start_btn
        '
        Me.start_btn.Location = New System.Drawing.Point(12, 12)
        Me.start_btn.Name = "start_btn"
        Me.start_btn.Size = New System.Drawing.Size(75, 23)
        Me.start_btn.TabIndex = 0
        Me.start_btn.Text = "Start"
        Me.start_btn.UseVisualStyleBackColor = True
        '
        'stop_btn
        '
        Me.stop_btn.Location = New System.Drawing.Point(93, 12)
        Me.stop_btn.Name = "stop_btn"
        Me.stop_btn.Size = New System.Drawing.Size(75, 23)
        Me.stop_btn.TabIndex = 1
        Me.stop_btn.Text = "Stop"
        Me.stop_btn.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 10
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(184, 47)
        Me.Controls.Add(Me.stop_btn)
        Me.Controls.Add(Me.start_btn)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(200, 86)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(200, 86)
        Me.Name = "Form1"
        Me.Text = "SimplistAutoclicker"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents start_btn As Button
    Friend WithEvents stop_btn As Button
    Friend WithEvents Timer1 As Timer
End Class
