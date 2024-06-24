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
        components = New ComponentModel.Container()
        btnCompatibilidad = New Button()
        PictureBox1 = New PictureBox()
        ContextMenuStrip1 = New ContextMenuStrip(components)
        btnHoroscopo = New Button()
        btnNumerologia = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnCompatibilidad
        ' 
        btnCompatibilidad.Font = New Font("Pristina", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnCompatibilidad.Location = New Point(483, 180)
        btnCompatibilidad.Name = "btnCompatibilidad"
        btnCompatibilidad.Size = New Size(280, 94)
        btnCompatibilidad.TabIndex = 1
        btnCompatibilidad.Text = "COMPATIBILIDAD ENTRE SIGNOS"
        btnCompatibilidad.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.horoscopo
        PictureBox1.Location = New Point(26, 23)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(401, 378)
        PictureBox1.TabIndex = 5
        PictureBox1.TabStop = False
        ' 
        ' ContextMenuStrip1
        ' 
        ContextMenuStrip1.Name = "ContextMenuStrip1"
        ContextMenuStrip1.Size = New Size(61, 4)
        ' 
        ' btnHoroscopo
        ' 
        btnHoroscopo.BackColor = SystemColors.Control
        btnHoroscopo.Font = New Font("Pristina", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnHoroscopo.Location = New Point(483, 23)
        btnHoroscopo.Name = "btnHoroscopo"
        btnHoroscopo.Size = New Size(280, 111)
        btnHoroscopo.TabIndex = 0
        btnHoroscopo.Text = "HOROSCOPO Y SIGNOS DEL ZODIACO"
        btnHoroscopo.UseVisualStyleBackColor = False
        ' 
        ' btnNumerologia
        ' 
        btnNumerologia.Font = New Font("Pristina", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnNumerologia.Location = New Point(483, 323)
        btnNumerologia.Name = "btnNumerologia"
        btnNumerologia.Size = New Size(280, 78)
        btnNumerologia.TabIndex = 2
        btnNumerologia.Text = "NUMEROLOGIA"
        btnNumerologia.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.HotTrack
        ClientSize = New Size(800, 450)
        Controls.Add(btnNumerologia)
        Controls.Add(btnHoroscopo)
        Controls.Add(PictureBox1)
        Controls.Add(btnCompatibilidad)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Horoscopo"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents btnCompatibilidad As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents btnHoroscopo As Button
    Friend WithEvents btnNumerologia As Button

End Class
