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
        Me.ResultBox = New System.Windows.Forms.RichTextBox()
        Me.MakeSongButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ResultBox
        '
        Me.ResultBox.Location = New System.Drawing.Point(156, 181)
        Me.ResultBox.Name = "ResultBox"
        Me.ResultBox.ReadOnly = True
        Me.ResultBox.Size = New System.Drawing.Size(263, 233)
        Me.ResultBox.TabIndex = 0
        Me.ResultBox.Text = ""
        '
        'MakeSongButton
        '
        Me.MakeSongButton.Location = New System.Drawing.Point(223, 123)
        Me.MakeSongButton.Name = "MakeSongButton"
        Me.MakeSongButton.Size = New System.Drawing.Size(133, 23)
        Me.MakeSongButton.TabIndex = 1
        Me.MakeSongButton.Text = "Make a Song"
        Me.MakeSongButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(578, 478)
        Me.Controls.Add(Me.MakeSongButton)
        Me.Controls.Add(Me.ResultBox)
        Me.Name = "Form1"
        Me.Text = "Make a Country Song!"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ResultBox As RichTextBox
    Friend WithEvents MakeSongButton As Button
End Class
