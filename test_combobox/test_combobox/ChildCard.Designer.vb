<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChildCard
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
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

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.SaveData = New System.Windows.Forms.Button()
        Me.DataOfChild = New System.Windows.Forms.GroupBox()
        Me.LastNameChildLabel = New System.Windows.Forms.Label()
        Me.LastNameChild = New System.Windows.Forms.TextBox()
        Me.FirstNameChildLabel = New System.Windows.Forms.Label()
        Me.FirstNameChild = New System.Windows.Forms.TextBox()
        Me.YearOfBornChild = New System.Windows.Forms.TextBox()
        Me.YearOfBornChildLabel = New System.Windows.Forms.Label()
        Me.DataOfChild.SuspendLayout()
        Me.SuspendLayout()
        '
        'Cancel
        '
        Me.Cancel.Location = New System.Drawing.Point(408, 305)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(75, 23)
        Me.Cancel.TabIndex = 0
        Me.Cancel.Text = "Отмена"
        Me.Cancel.UseVisualStyleBackColor = True
        '
        'SaveData
        '
        Me.SaveData.Location = New System.Drawing.Point(327, 305)
        Me.SaveData.Name = "SaveData"
        Me.SaveData.Size = New System.Drawing.Size(75, 23)
        Me.SaveData.TabIndex = 1
        Me.SaveData.Text = "Сохранить"
        Me.SaveData.UseVisualStyleBackColor = True
        '
        'DataOfChild
        '
        Me.DataOfChild.Controls.Add(Me.YearOfBornChild)
        Me.DataOfChild.Controls.Add(Me.YearOfBornChildLabel)
        Me.DataOfChild.Controls.Add(Me.FirstNameChild)
        Me.DataOfChild.Controls.Add(Me.FirstNameChildLabel)
        Me.DataOfChild.Controls.Add(Me.LastNameChild)
        Me.DataOfChild.Controls.Add(Me.LastNameChildLabel)
        Me.DataOfChild.Location = New System.Drawing.Point(13, 13)
        Me.DataOfChild.Name = "DataOfChild"
        Me.DataOfChild.Size = New System.Drawing.Size(212, 103)
        Me.DataOfChild.TabIndex = 2
        Me.DataOfChild.TabStop = False
        Me.DataOfChild.Text = "Информация о ребенке"
        '
        'LastNameChildLabel
        '
        Me.LastNameChildLabel.AutoSize = True
        Me.LastNameChildLabel.Location = New System.Drawing.Point(7, 20)
        Me.LastNameChildLabel.Name = "LastNameChildLabel"
        Me.LastNameChildLabel.Size = New System.Drawing.Size(56, 13)
        Me.LastNameChildLabel.TabIndex = 0
        Me.LastNameChildLabel.Text = "Фамилия"
        '
        'LastNameChild
        '
        Me.LastNameChild.Location = New System.Drawing.Point(98, 17)
        Me.LastNameChild.Name = "LastNameChild"
        Me.LastNameChild.Size = New System.Drawing.Size(100, 20)
        Me.LastNameChild.TabIndex = 1
        '
        'FirstNameChildLabel
        '
        Me.FirstNameChildLabel.AutoSize = True
        Me.FirstNameChildLabel.Location = New System.Drawing.Point(7, 46)
        Me.FirstNameChildLabel.Name = "FirstNameChildLabel"
        Me.FirstNameChildLabel.Size = New System.Drawing.Size(29, 13)
        Me.FirstNameChildLabel.TabIndex = 2
        Me.FirstNameChildLabel.Text = "Имя"
        '
        'FirstNameChild
        '
        Me.FirstNameChild.Location = New System.Drawing.Point(98, 43)
        Me.FirstNameChild.Name = "FirstNameChild"
        Me.FirstNameChild.Size = New System.Drawing.Size(100, 20)
        Me.FirstNameChild.TabIndex = 3
        '
        'YearOfBornChild
        '
        Me.YearOfBornChild.Location = New System.Drawing.Point(98, 69)
        Me.YearOfBornChild.MaxLength = 4
        Me.YearOfBornChild.Name = "YearOfBornChild"
        Me.YearOfBornChild.Size = New System.Drawing.Size(100, 20)
        Me.YearOfBornChild.TabIndex = 5
        '
        'YearOfBornChildLabel
        '
        Me.YearOfBornChildLabel.AutoSize = True
        Me.YearOfBornChildLabel.Location = New System.Drawing.Point(7, 72)
        Me.YearOfBornChildLabel.Name = "YearOfBornChildLabel"
        Me.YearOfBornChildLabel.Size = New System.Drawing.Size(78, 13)
        Me.YearOfBornChildLabel.TabIndex = 4
        Me.YearOfBornChildLabel.Text = "Год рождения"
        '
        'ChildCard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(495, 340)
        Me.Controls.Add(Me.DataOfChild)
        Me.Controls.Add(Me.SaveData)
        Me.Controls.Add(Me.Cancel)
        Me.Name = "ChildCard"
        Me.Text = "ChildCard"
        Me.DataOfChild.ResumeLayout(False)
        Me.DataOfChild.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Cancel As Button
    Friend WithEvents SaveData As Button
    Friend WithEvents DataOfChild As GroupBox
    Friend WithEvents YearOfBornChild As TextBox
    Friend WithEvents YearOfBornChildLabel As Label
    Friend WithEvents FirstNameChild As TextBox
    Friend WithEvents FirstNameChildLabel As Label
    Friend WithEvents LastNameChild As TextBox
    Friend WithEvents LastNameChildLabel As Label
End Class
