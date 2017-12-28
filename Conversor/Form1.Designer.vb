<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.groupDestino = New System.Windows.Forms.GroupBox()
        Me.rbDesHex = New System.Windows.Forms.RadioButton()
        Me.rbDesBin = New System.Windows.Forms.RadioButton()
        Me.rbDesDec = New System.Windows.Forms.RadioButton()
        Me.groupOrigen = New System.Windows.Forms.GroupBox()
        Me.rbOrigHex = New System.Windows.Forms.RadioButton()
        Me.rbOrigBin = New System.Windows.Forms.RadioButton()
        Me.rbOriDec = New System.Windows.Forms.RadioButton()
        Me.editDestino = New System.Windows.Forms.TextBox()
        Me.txtDestino = New System.Windows.Forms.Label()
        Me.editOrigen = New System.Windows.Forms.TextBox()
        Me.txtOrigen = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.groupDestino.SuspendLayout()
        Me.groupOrigen.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        resources.ApplyResources(Me.Panel1, "Panel1")
        Me.Panel1.Controls.Add(Me.btnCalcular)
        Me.Panel1.Controls.Add(Me.btnLimpiar)
        Me.Panel1.Controls.Add(Me.groupDestino)
        Me.Panel1.Controls.Add(Me.groupOrigen)
        Me.Panel1.Controls.Add(Me.editDestino)
        Me.Panel1.Controls.Add(Me.txtDestino)
        Me.Panel1.Controls.Add(Me.editOrigen)
        Me.Panel1.Controls.Add(Me.txtOrigen)
        Me.Panel1.Name = "Panel1"
        '
        'btnCalcular
        '
        resources.ApplyResources(Me.btnCalcular, "btnCalcular")
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        resources.ApplyResources(Me.btnLimpiar, "btnLimpiar")
        Me.btnLimpiar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'groupDestino
        '
        resources.ApplyResources(Me.groupDestino, "groupDestino")
        Me.groupDestino.Controls.Add(Me.rbDesHex)
        Me.groupDestino.Controls.Add(Me.rbDesBin)
        Me.groupDestino.Controls.Add(Me.rbDesDec)
        Me.groupDestino.Name = "groupDestino"
        Me.groupDestino.TabStop = False
        '
        'rbDesHex
        '
        resources.ApplyResources(Me.rbDesHex, "rbDesHex")
        Me.rbDesHex.Name = "rbDesHex"
        Me.rbDesHex.TabStop = True
        Me.rbDesHex.UseVisualStyleBackColor = True
        '
        'rbDesBin
        '
        resources.ApplyResources(Me.rbDesBin, "rbDesBin")
        Me.rbDesBin.Name = "rbDesBin"
        Me.rbDesBin.TabStop = True
        Me.rbDesBin.UseVisualStyleBackColor = True
        '
        'rbDesDec
        '
        resources.ApplyResources(Me.rbDesDec, "rbDesDec")
        Me.rbDesDec.Name = "rbDesDec"
        Me.rbDesDec.TabStop = True
        Me.rbDesDec.UseVisualStyleBackColor = True
        '
        'groupOrigen
        '
        resources.ApplyResources(Me.groupOrigen, "groupOrigen")
        Me.groupOrigen.Controls.Add(Me.rbOrigHex)
        Me.groupOrigen.Controls.Add(Me.rbOrigBin)
        Me.groupOrigen.Controls.Add(Me.rbOriDec)
        Me.groupOrigen.Name = "groupOrigen"
        Me.groupOrigen.TabStop = False
        '
        'rbOrigHex
        '
        resources.ApplyResources(Me.rbOrigHex, "rbOrigHex")
        Me.rbOrigHex.Name = "rbOrigHex"
        Me.rbOrigHex.TabStop = True
        Me.rbOrigHex.UseVisualStyleBackColor = True
        '
        'rbOrigBin
        '
        resources.ApplyResources(Me.rbOrigBin, "rbOrigBin")
        Me.rbOrigBin.Name = "rbOrigBin"
        Me.rbOrigBin.TabStop = True
        Me.rbOrigBin.UseVisualStyleBackColor = True
        '
        'rbOriDec
        '
        resources.ApplyResources(Me.rbOriDec, "rbOriDec")
        Me.rbOriDec.Name = "rbOriDec"
        Me.rbOriDec.TabStop = True
        Me.rbOriDec.UseVisualStyleBackColor = True
        '
        'editDestino
        '
        resources.ApplyResources(Me.editDestino, "editDestino")
        Me.editDestino.Name = "editDestino"
        '
        'txtDestino
        '
        resources.ApplyResources(Me.txtDestino, "txtDestino")
        Me.txtDestino.Name = "txtDestino"
        '
        'editOrigen
        '
        resources.ApplyResources(Me.editOrigen, "editOrigen")
        Me.editOrigen.Name = "editOrigen"
        '
        'txtOrigen
        '
        resources.ApplyResources(Me.txtOrigen, "txtOrigen")
        Me.txtOrigen.Name = "txtOrigen"
        '
        'Form1
        '
        Me.AcceptButton = Me.btnCalcular
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnLimpiar
        Me.Controls.Add(Me.Panel1)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.groupDestino.ResumeLayout(False)
        Me.groupDestino.PerformLayout()
        Me.groupOrigen.ResumeLayout(False)
        Me.groupOrigen.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents groupOrigen As GroupBox
    Friend WithEvents editDestino As TextBox
    Friend WithEvents txtDestino As Label
    Friend WithEvents editOrigen As TextBox
    Friend WithEvents txtOrigen As Label
    Friend WithEvents groupDestino As GroupBox
    Friend WithEvents rbDesHex As RadioButton
    Friend WithEvents rbDesBin As RadioButton
    Friend WithEvents rbDesDec As RadioButton
    Friend WithEvents rbOrigHex As RadioButton
    Friend WithEvents rbOrigBin As RadioButton
    Friend WithEvents rbOriDec As RadioButton
    Friend WithEvents btnCalcular As Button
    Friend WithEvents btnLimpiar As Button
End Class
