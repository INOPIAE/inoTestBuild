<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMath
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        CmdAdd = New Button()
        CmdClose = New Button()
        Label1 = New Label()
        TxtValue1 = New TextBox()
        Label2 = New Label()
        TxtValue2 = New TextBox()
        Label3 = New Label()
        TxtResult = New TextBox()
        SuspendLayout()
        ' 
        ' CmdAdd
        ' 
        CmdAdd.Location = New Point(649, 67)
        CmdAdd.Name = "CmdAdd"
        CmdAdd.Size = New Size(77, 35)
        CmdAdd.TabIndex = 0
        CmdAdd.Text = "Add"
        CmdAdd.UseVisualStyleBackColor = True
        ' 
        ' CmdClose
        ' 
        CmdClose.Location = New Point(649, 332)
        CmdClose.Name = "CmdClose"
        CmdClose.Size = New Size(77, 35)
        CmdClose.TabIndex = 0
        CmdClose.Text = "Close"
        CmdClose.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(58, 55)
        Label1.Name = "Label1"
        Label1.Size = New Size(57, 20)
        Label1.TabIndex = 1
        Label1.Text = "Value 1"
        ' 
        ' TxtValue1
        ' 
        TxtValue1.Location = New Point(142, 52)
        TxtValue1.Name = "TxtValue1"
        TxtValue1.Size = New Size(156, 27)
        TxtValue1.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(58, 104)
        Label2.Name = "Label2"
        Label2.Size = New Size(57, 20)
        Label2.TabIndex = 1
        Label2.Text = "Value 2"
        ' 
        ' TxtValue2
        ' 
        TxtValue2.Location = New Point(142, 101)
        TxtValue2.Name = "TxtValue2"
        TxtValue2.Size = New Size(156, 27)
        TxtValue2.TabIndex = 2
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(58, 204)
        Label3.Name = "Label3"
        Label3.Size = New Size(49, 20)
        Label3.TabIndex = 1
        Label3.Text = "Result"
        ' 
        ' TxtResult
        ' 
        TxtResult.Location = New Point(142, 201)
        TxtResult.Name = "TxtResult"
        TxtResult.Size = New Size(156, 27)
        TxtResult.TabIndex = 2
        ' 
        ' FrmMath
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(TxtResult)
        Controls.Add(Label3)
        Controls.Add(TxtValue2)
        Controls.Add(Label2)
        Controls.Add(TxtValue1)
        Controls.Add(Label1)
        Controls.Add(CmdClose)
        Controls.Add(CmdAdd)
        Name = "FrmMath"
        Text = "FrmMath"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents CmdAdd As Button
    Friend WithEvents CmdClose As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtValue1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtValue2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtResult As TextBox
End Class
