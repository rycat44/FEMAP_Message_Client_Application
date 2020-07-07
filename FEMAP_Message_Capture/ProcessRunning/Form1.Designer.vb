<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.CaptureMsgButton = New System.Windows.Forms.Button()
        Me.ListModelInfoButton = New System.Windows.Forms.Button()
        Me.ReleaseMsgButton = New System.Windows.Forms.Button()
        Me.FemapMsgHandlerListBox = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'CaptureMsgButton
        '
        Me.CaptureMsgButton.Location = New System.Drawing.Point(58, 39)
        Me.CaptureMsgButton.Name = "CaptureMsgButton"
        Me.CaptureMsgButton.Size = New System.Drawing.Size(153, 55)
        Me.CaptureMsgButton.TabIndex = 1
        Me.CaptureMsgButton.Text = "Capture"
        Me.CaptureMsgButton.UseVisualStyleBackColor = True
        '
        'ListModelInfoButton
        '
        Me.ListModelInfoButton.Location = New System.Drawing.Point(58, 121)
        Me.ListModelInfoButton.Name = "ListModelInfoButton"
        Me.ListModelInfoButton.Size = New System.Drawing.Size(153, 55)
        Me.ListModelInfoButton.TabIndex = 2
        Me.ListModelInfoButton.Text = "List Info"
        Me.ListModelInfoButton.UseVisualStyleBackColor = True
        '
        'ReleaseMsgButton
        '
        Me.ReleaseMsgButton.Location = New System.Drawing.Point(58, 205)
        Me.ReleaseMsgButton.Name = "ReleaseMsgButton"
        Me.ReleaseMsgButton.Size = New System.Drawing.Size(153, 55)
        Me.ReleaseMsgButton.TabIndex = 3
        Me.ReleaseMsgButton.Text = "Release"
        Me.ReleaseMsgButton.UseVisualStyleBackColor = True
        '
        'FemapMsgHandlerListBox
        '
        Me.FemapMsgHandlerListBox.FormattingEnabled = True
        Me.FemapMsgHandlerListBox.ItemHeight = 16
        Me.FemapMsgHandlerListBox.Location = New System.Drawing.Point(240, 39)
        Me.FemapMsgHandlerListBox.Name = "FemapMsgHandlerListBox"
        Me.FemapMsgHandlerListBox.Size = New System.Drawing.Size(487, 228)
        Me.FemapMsgHandlerListBox.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.FemapMsgHandlerListBox)
        Me.Controls.Add(Me.ReleaseMsgButton)
        Me.Controls.Add(Me.ListModelInfoButton)
        Me.Controls.Add(Me.CaptureMsgButton)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CaptureMsgButton As Button
    Friend WithEvents ListModelInfoButton As Button
    Friend WithEvents ReleaseMsgButton As Button
    Friend WithEvents FemapMsgHandlerListBox As ListBox
End Class
