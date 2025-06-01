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
        Label1 = New Label()
        lblMsk = New Label()
        TxtUsia = New TextBox()
        btnCek = New Button()
        LblKet = New Label()
        LblHasil = New Label()
        Lbld = New Label()
        LblDet = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.BackColor = Color.Turquoise
        Label1.Font = New Font("Sitka Display", 10F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ControlDarkDark
        Label1.Location = New Point(178, 20)
        Label1.Name = "Label1"
        Label1.Size = New Size(224, 36)
        Label1.TabIndex = 0
        Label1.Text = "Klasifikasi Usia Sederhana"
        ' 
        ' lblMsk
        ' 
        lblMsk.BackColor = Color.MediumTurquoise
        lblMsk.BorderStyle = BorderStyle.Fixed3D
        lblMsk.ForeColor = SystemColors.ControlDarkDark
        lblMsk.Location = New Point(12, 75)
        lblMsk.Name = "lblMsk"
        lblMsk.Size = New Size(148, 35)
        lblMsk.TabIndex = 1
        lblMsk.Text = "Masukkan Usia :"
        ' 
        ' TxtUsia
        ' 
        TxtUsia.BackColor = Color.LightGray
        TxtUsia.Location = New Point(178, 77)
        TxtUsia.Name = "TxtUsia"
        TxtUsia.Size = New Size(375, 31)
        TxtUsia.TabIndex = 2
        ' 
        ' btnCek
        ' 
        btnCek.BackColor = Color.Teal
        btnCek.ForeColor = SystemColors.ControlLight
        btnCek.Location = New Point(12, 129)
        btnCek.Name = "btnCek"
        btnCek.Size = New Size(541, 48)
        btnCek.TabIndex = 3
        btnCek.Text = "Klasifikasikan"
        btnCek.UseVisualStyleBackColor = False
        ' 
        ' LblKet
        ' 
        LblKet.BackColor = Color.MediumTurquoise
        LblKet.BorderStyle = BorderStyle.FixedSingle
        LblKet.ForeColor = SystemColors.ControlDarkDark
        LblKet.Location = New Point(12, 200)
        LblKet.Name = "LblKet"
        LblKet.Size = New Size(148, 33)
        LblKet.TabIndex = 4
        LblKet.Text = "Keterangan "
        ' 
        ' LblHasil
        ' 
        LblHasil.BackColor = Color.Gainsboro
        LblHasil.Location = New Point(178, 205)
        LblHasil.Name = "LblHasil"
        LblHasil.Size = New Size(375, 28)
        LblHasil.TabIndex = 5
        ' 
        ' Lbld
        ' 
        Lbld.BackColor = Color.MediumTurquoise
        Lbld.BorderStyle = BorderStyle.FixedSingle
        Lbld.ForeColor = SystemColors.ControlDarkDark
        Lbld.Location = New Point(12, 248)
        Lbld.Name = "Lbld"
        Lbld.Size = New Size(148, 33)
        Lbld.TabIndex = 6
        Lbld.Text = "Detail"
        ' 
        ' LblDet
        ' 
        LblDet.BackColor = Color.Gainsboro
        LblDet.Location = New Point(178, 248)
        LblDet.Name = "LblDet"
        LblDet.Size = New Size(375, 28)
        LblDet.TabIndex = 7
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightSeaGreen
        BackgroundImageLayout = ImageLayout.None
        ClientSize = New Size(584, 302)
        Controls.Add(LblDet)
        Controls.Add(Lbld)
        Controls.Add(LblHasil)
        Controls.Add(LblKet)
        Controls.Add(btnCek)
        Controls.Add(TxtUsia)
        Controls.Add(lblMsk)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Apk Klasifikasi"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblMsk As Label
    Friend WithEvents TxtUsia As TextBox
    Friend WithEvents btnCek As Button
    Friend WithEvents LblKet As Label
    Friend WithEvents LblHasil As Label
    Friend WithEvents Lbld As Label
    Friend WithEvents LblDet As Label

End Class
