<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
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

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.DateOfBorn = New System.Windows.Forms.ComboBox()
        Me.ChildsList = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NewChild = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'DateOfBorn
        '
        Me.DateOfBorn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DateOfBorn.FormattingEnabled = True
        Me.DateOfBorn.Location = New System.Drawing.Point(262, 55)
        Me.DateOfBorn.Name = "DateOfBorn"
        Me.DateOfBorn.Size = New System.Drawing.Size(121, 21)
        Me.DateOfBorn.TabIndex = 0
        '
        'ChildsList
        '
        Me.ChildsList.FormattingEnabled = True
        Me.ChildsList.Location = New System.Drawing.Point(31, 55)
        Me.ChildsList.Name = "ChildsList"
        Me.ChildsList.Size = New System.Drawing.Size(211, 199)
        Me.ChildsList.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 288)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Label1"
        '
        'NewChild
        '
        Me.NewChild.Location = New System.Drawing.Point(307, 230)
        Me.NewChild.Name = "NewChild"
        Me.NewChild.Size = New System.Drawing.Size(75, 23)
        Me.NewChild.TabIndex = 3
        Me.NewChild.Text = "Добавить"
        Me.NewChild.UseVisualStyleBackColor = True
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(453, 354)
        Me.Controls.Add(Me.NewChild)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ChildsList)
        Me.Controls.Add(Me.DateOfBorn)
        Me.Name = "Main"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DateOfBorn As ComboBox
    Friend WithEvents ChildsList As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents NewChild As Button
End Class
