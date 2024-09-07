<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Settings
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Settings))
        Me.BAuS = New System.Windows.Forms.Button()
        Me.LWR = New System.Windows.Forms.Label()
        Me.BSPE = New System.Windows.Forms.Button()
        Me.BABR = New System.Windows.Forms.Button()
        Me.BINFO = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BAuS
        '
        Me.BAuS.Location = New System.Drawing.Point(225, 47)
        Me.BAuS.Name = "BAuS"
        Me.BAuS.Size = New System.Drawing.Size(75, 23)
        Me.BAuS.TabIndex = 0
        Me.BAuS.Text = "An"
        Me.BAuS.UseVisualStyleBackColor = True
        '
        'LWR
        '
        Me.LWR.AutoSize = True
        Me.LWR.Location = New System.Drawing.Point(24, 47)
        Me.LWR.Name = "LWR"
        Me.LWR.Size = New System.Drawing.Size(176, 16)
        Me.LWR.TabIndex = 1
        Me.LWR.Text = "Wissenschaftlicher Rechner "
        '
        'BSPE
        '
        Me.BSPE.Location = New System.Drawing.Point(374, 179)
        Me.BSPE.Name = "BSPE"
        Me.BSPE.Size = New System.Drawing.Size(92, 29)
        Me.BSPE.TabIndex = 2
        Me.BSPE.Tag = ""
        Me.BSPE.Text = "Speichern"
        Me.BSPE.UseVisualStyleBackColor = True
        '
        'BABR
        '
        Me.BABR.Location = New System.Drawing.Point(276, 179)
        Me.BABR.Name = "BABR"
        Me.BABR.Size = New System.Drawing.Size(92, 29)
        Me.BABR.TabIndex = 3
        Me.BABR.Tag = ""
        Me.BABR.Text = "Abrechen"
        Me.BABR.UseVisualStyleBackColor = True
        '
        'BINFO
        '
        Me.BINFO.Location = New System.Drawing.Point(12, 179)
        Me.BINFO.Name = "BINFO"
        Me.BINFO.Size = New System.Drawing.Size(80, 29)
        Me.BINFO.TabIndex = 4
        Me.BINFO.Text = "Info"
        Me.BINFO.UseVisualStyleBackColor = True
        '
        'Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(478, 220)
        Me.Controls.Add(Me.BINFO)
        Me.Controls.Add(Me.BABR)
        Me.Controls.Add(Me.BSPE)
        Me.Controls.Add(Me.LWR)
        Me.Controls.Add(Me.BAuS)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Settings"
        Me.Text = "Einstellungen"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BAuS As Button
    Friend WithEvents LWR As Label
    Friend WithEvents BSPE As Button
    Friend WithEvents BABR As Button
    Friend WithEvents BINFO As Button
End Class
