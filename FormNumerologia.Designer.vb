<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormNumerologia
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormNumerologia))
        Label1 = New Label()
        btnMenuPrincipal = New Button()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        btnCalcular = New Button()
        boxdia = New ComboBox()
        boxmes = New ComboBox()
        boxaño = New ComboBox()
        TextNumerologia = New TextBox()
        Label5 = New Label()
        Textdescripsion = New TextBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.BlueViolet
        Label1.BorderStyle = BorderStyle.FixedSingle
        Label1.Font = New Font("Algerian", 36F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(178, 28)
        Label1.Name = "Label1"
        Label1.Size = New Size(348, 56)
        Label1.TabIndex = 0
        Label1.Text = "Numerologia"
        ' 
        ' btnMenuPrincipal
        ' 
        btnMenuPrincipal.Font = New Font("Ravie", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnMenuPrincipal.Location = New Point(25, 28)
        btnMenuPrincipal.Name = "btnMenuPrincipal"
        btnMenuPrincipal.Size = New Size(147, 54)
        btnMenuPrincipal.TabIndex = 1
        btnMenuPrincipal.Text = "Menú Principal"
        btnMenuPrincipal.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.MediumSlateBlue
        Label2.BorderStyle = BorderStyle.FixedSingle
        Label2.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(25, 98)
        Label2.Name = "Label2"
        Label2.Size = New Size(42, 27)
        Label2.TabIndex = 2
        Label2.Text = "Día"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.MediumSlateBlue
        Label3.BorderStyle = BorderStyle.FixedSingle
        Label3.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(154, 98)
        Label3.Name = "Label3"
        Label3.Size = New Size(49, 27)
        Label3.TabIndex = 3
        Label3.Text = "Mes"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.MediumSlateBlue
        Label4.BorderStyle = BorderStyle.FixedSingle
        Label4.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(287, 98)
        Label4.Name = "Label4"
        Label4.Size = New Size(48, 27)
        Label4.TabIndex = 4
        Label4.Text = "Año"
        ' 
        ' btnCalcular
        ' 
        btnCalcular.BackColor = Color.Plum
        btnCalcular.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnCalcular.Location = New Point(426, 137)
        btnCalcular.Name = "btnCalcular"
        btnCalcular.Size = New Size(83, 24)
        btnCalcular.TabIndex = 5
        btnCalcular.Text = "CALCULAR"
        btnCalcular.UseVisualStyleBackColor = False
        ' 
        ' boxdia
        ' 
        boxdia.FormattingEnabled = True
        boxdia.Location = New Point(25, 138)
        boxdia.Name = "boxdia"
        boxdia.Size = New Size(88, 23)
        boxdia.TabIndex = 6
        ' 
        ' boxmes
        ' 
        boxmes.FormattingEnabled = True
        boxmes.Location = New Point(154, 138)
        boxmes.Name = "boxmes"
        boxmes.Size = New Size(94, 23)
        boxmes.TabIndex = 7
        ' 
        ' boxaño
        ' 
        boxaño.FormattingEnabled = True
        boxaño.Location = New Point(287, 138)
        boxaño.Name = "boxaño"
        boxaño.Size = New Size(121, 23)
        boxaño.TabIndex = 8
        ' 
        ' TextNumerologia
        ' 
        TextNumerologia.Location = New Point(171, 185)
        TextNumerologia.Multiline = True
        TextNumerologia.Name = "TextNumerologia"
        TextNumerologia.Size = New Size(237, 27)
        TextNumerologia.TabIndex = 9
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.MediumSlateBlue
        Label5.BorderStyle = BorderStyle.FixedSingle
        Label5.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(25, 185)
        Label5.Name = "Label5"
        Label5.Size = New Size(136, 27)
        Label5.TabIndex = 10
        Label5.Text = "Tu Número es:"
        ' 
        ' Textdescripsion
        ' 
        Textdescripsion.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Textdescripsion.Location = New Point(25, 239)
        Textdescripsion.Multiline = True
        Textdescripsion.Name = "Textdescripsion"
        Textdescripsion.Size = New Size(484, 432)
        Textdescripsion.TabIndex = 11
        ' 
        ' FormNumerologia
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveBorder
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(542, 702)
        Controls.Add(Textdescripsion)
        Controls.Add(Label5)
        Controls.Add(TextNumerologia)
        Controls.Add(boxaño)
        Controls.Add(boxmes)
        Controls.Add(boxdia)
        Controls.Add(btnCalcular)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(btnMenuPrincipal)
        Controls.Add(Label1)
        Name = "FormNumerologia"
        Text = "FormNumerologia"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnMenuPrincipal As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnCalcular As Button
    Friend WithEvents boxdia As ComboBox
    Friend WithEvents boxmes As ComboBox
    Friend WithEvents boxaño As ComboBox
    Friend WithEvents TextNumerologia As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Textdescripsion As TextBox
End Class
