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
        Me.cmdno = New System.Windows.Forms.Button()
        Me.cmdok = New System.Windows.Forms.Button()
        Me.pbcapture = New PictureBoxAbouAmmar.صورة_دائرة()
        Me.pbcaptureimage = New System.Windows.Forms.PictureBox()
        CType(Me.pbcapture, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbcaptureimage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdno
        '
        Me.cmdno.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdno.Image = Global.WebCam.My.Resources.Resources.Actions_edit_delete_icon
        Me.cmdno.Location = New System.Drawing.Point(255, 334)
        Me.cmdno.Name = "cmdno"
        Me.cmdno.Size = New System.Drawing.Size(32, 24)
        Me.cmdno.TabIndex = 3
        Me.cmdno.UseVisualStyleBackColor = True
        '
        'cmdok
        '
        Me.cmdok.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdok.Image = Global.WebCam.My.Resources.Resources.Ok_icon__1_1
        Me.cmdok.Location = New System.Drawing.Point(217, 334)
        Me.cmdok.Name = "cmdok"
        Me.cmdok.Size = New System.Drawing.Size(32, 24)
        Me.cmdok.TabIndex = 2
        Me.cmdok.UseVisualStyleBackColor = True
        '
        'pbcapture
        '
        Me.pbcapture.BackColor = System.Drawing.Color.DarkGray
        Me.pbcapture.BackgroundImage = Global.WebCam.My.Resources.Resources.Image_Capture_icon
        Me.pbcapture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbcapture.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbcapture.Location = New System.Drawing.Point(224, 318)
        Me.pbcapture.Name = "pbcapture"
        Me.pbcapture.Size = New System.Drawing.Size(52, 50)
        Me.pbcapture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbcapture.TabIndex = 1
        Me.pbcapture.TabStop = False
        '
        'pbcaptureimage
        '
        Me.pbcaptureimage.Location = New System.Drawing.Point(-1, -1)
        Me.pbcaptureimage.Name = "pbcaptureimage"
        Me.pbcaptureimage.Size = New System.Drawing.Size(487, 313)
        Me.pbcaptureimage.TabIndex = 0
        Me.pbcaptureimage.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(485, 372)
        Me.Controls.Add(Me.cmdno)
        Me.Controls.Add(Me.cmdok)
        Me.Controls.Add(Me.pbcapture)
        Me.Controls.Add(Me.pbcaptureimage)
        Me.Name = "Form1"
        Me.Text = "WebCam"
        CType(Me.pbcapture, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbcaptureimage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pbcaptureimage As System.Windows.Forms.PictureBox
    Friend WithEvents pbcapture As PictureBoxAbouAmmar.صورة_دائرة
    Friend WithEvents cmdok As System.Windows.Forms.Button
    Friend WithEvents cmdno As System.Windows.Forms.Button

End Class
