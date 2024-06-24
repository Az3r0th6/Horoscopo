<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCompatibilidad
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormCompatibilidad))
        btnMenuPrincipal = New Button()
        Label1 = New Label()
        Label2 = New Label()
        ComboBoxSignos = New ComboBox()
        BntCompatibilidad = New Button()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        TextBoxCompatibilidad = New TextBox()
        TextBoxIncompatibilidad = New TextBox()
        SuspendLayout()
        ' 
        ' btnMenuPrincipal
        ' 
        btnMenuPrincipal.Font = New Font("Ravie", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnMenuPrincipal.Location = New Point(12, 12)
        btnMenuPrincipal.Name = "btnMenuPrincipal"
        btnMenuPrincipal.Size = New Size(135, 55)
        btnMenuPrincipal.TabIndex = 0
        btnMenuPrincipal.Text = "Menú Principal"
        btnMenuPrincipal.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Linen
        Label1.Font = New Font("Comic Sans MS", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(181, 23)
        Label1.Name = "Label1"
        Label1.Size = New Size(366, 38)
        Label1.TabIndex = 1
        Label1.Text = "Compatibilidad entre Signos"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(22, 81)
        Label2.Name = "Label2"
        Label2.Size = New Size(133, 17)
        Label2.TabIndex = 2
        Label2.Text = "Elige tu Signo Zodiaco"
        ' 
        ' ComboBoxSignos
        ' 
        ComboBoxSignos.FormattingEnabled = True
        ComboBoxSignos.Location = New Point(172, 79)
        ComboBoxSignos.Name = "ComboBoxSignos"
        ComboBoxSignos.Size = New Size(261, 23)
        ComboBoxSignos.TabIndex = 3
        ' 
        ' BntCompatibilidad
        ' 
        BntCompatibilidad.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BntCompatibilidad.Location = New Point(453, 81)
        BntCompatibilidad.Name = "BntCompatibilidad"
        BntCompatibilidad.Size = New Size(94, 33)
        BntCompatibilidad.TabIndex = 4
        BntCompatibilidad.Text = "BUSCAR"
        BntCompatibilidad.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BorderStyle = BorderStyle.FixedSingle
        Label3.Font = New Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(22, 140)
        Label3.Name = "Label3"
        Label3.Size = New Size(235, 25)
        Label3.TabIndex = 5
        Label3.Text = "Signos Compatibles en el Amor"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BorderStyle = BorderStyle.FixedSingle
        Label4.Font = New Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(297, 140)
        Label4.Name = "Label4"
        Label4.Size = New Size(250, 25)
        Label4.TabIndex = 6
        Label4.Text = "Signos Incompatibles en el Amor"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(147, 286)
        Label5.Name = "Label5"
        Label5.Size = New Size(0, 15)
        Label5.TabIndex = 7
        ' 
        ' TextBoxCompatibilidad
        ' 
        TextBoxCompatibilidad.Location = New Point(22, 177)
        TextBoxCompatibilidad.Multiline = True
        TextBoxCompatibilidad.Name = "TextBoxCompatibilidad"
        TextBoxCompatibilidad.Size = New Size(233, 261)
        TextBoxCompatibilidad.TabIndex = 8
        ' 
        ' TextBoxIncompatibilidad
        ' 
        TextBoxIncompatibilidad.Location = New Point(297, 177)
        TextBoxIncompatibilidad.Multiline = True
        TextBoxIncompatibilidad.Name = "TextBoxIncompatibilidad"
        TextBoxIncompatibilidad.Size = New Size(250, 261)
        TextBoxIncompatibilidad.TabIndex = 9
        ' 
        ' FormCompatibilidad
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(570, 450)
        Controls.Add(TextBoxIncompatibilidad)
        Controls.Add(TextBoxCompatibilidad)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(BntCompatibilidad)
        Controls.Add(ComboBoxSignos)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnMenuPrincipal)
        Name = "FormCompatibilidad"
        Text = "FormCompatibilidad"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnMenuPrincipal As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboBoxSignos As ComboBox
    Friend WithEvents BntCompatibilidad As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBoxCompatibilidad As TextBox
    Friend WithEvents TextBoxIncompatibilidad As TextBox
End Class
