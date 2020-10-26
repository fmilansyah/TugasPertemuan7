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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.cb_class = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cb_date = New System.Windows.Forms.ComboBox()
        Me.cb_month = New System.Windows.Forms.ComboBox()
        Me.cb_year = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cb_weight = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cb_height = New System.Windows.Forms.ComboBox()
        Me.cb_age = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(97, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nama"
        '
        'txt_name
        '
        Me.txt_name.Location = New System.Drawing.Point(148, 8)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(174, 20)
        Me.txt_name.TabIndex = 1
        '
        'cb_class
        '
        Me.cb_class.FormattingEnabled = True
        Me.cb_class.Location = New System.Drawing.Point(148, 35)
        Me.cb_class.Name = "cb_class"
        Me.cb_class.Size = New System.Drawing.Size(174, 21)
        Me.cb_class.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(97, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Kelas"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(46, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Tanggal Lahir"
        '
        'cb_date
        '
        Me.cb_date.FormattingEnabled = True
        Me.cb_date.Location = New System.Drawing.Point(148, 65)
        Me.cb_date.Name = "cb_date"
        Me.cb_date.Size = New System.Drawing.Size(43, 21)
        Me.cb_date.TabIndex = 5
        '
        'cb_month
        '
        Me.cb_month.FormattingEnabled = True
        Me.cb_month.Location = New System.Drawing.Point(197, 65)
        Me.cb_month.Name = "cb_month"
        Me.cb_month.Size = New System.Drawing.Size(49, 21)
        Me.cb_month.TabIndex = 6
        '
        'cb_year
        '
        Me.cb_year.FormattingEnabled = True
        Me.cb_year.Location = New System.Drawing.Point(252, 65)
        Me.cb_year.Name = "cb_year"
        Me.cb_year.Size = New System.Drawing.Size(70, 21)
        Me.cb_year.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(55, 94)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 17)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Berat Badan"
        '
        'cb_weight
        '
        Me.cb_weight.FormattingEnabled = True
        Me.cb_weight.Location = New System.Drawing.Point(148, 94)
        Me.cb_weight.Name = "cb_weight"
        Me.cb_weight.Size = New System.Drawing.Size(174, 21)
        Me.cb_weight.TabIndex = 9
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(55, 121)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(92, 17)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Tinggi Badan"
        '
        'cb_height
        '
        Me.cb_height.FormattingEnabled = True
        Me.cb_height.Location = New System.Drawing.Point(148, 121)
        Me.cb_height.Name = "cb_height"
        Me.cb_height.Size = New System.Drawing.Size(174, 21)
        Me.cb_height.TabIndex = 11
        '
        'cb_age
        '
        Me.cb_age.FormattingEnabled = True
        Me.cb_age.Location = New System.Drawing.Point(148, 148)
        Me.cb_age.Name = "cb_age"
        Me.cb_age.Size = New System.Drawing.Size(174, 21)
        Me.cb_age.TabIndex = 13
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(100, 149)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 17)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Umur"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(246, 176)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Simpan"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(917, 595)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cb_age)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cb_height)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cb_weight)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cb_year)
        Me.Controls.Add(Me.cb_month)
        Me.Controls.Add(Me.cb_date)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cb_class)
        Me.Controls.Add(Me.txt_name)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txt_name As TextBox
    Friend WithEvents cb_class As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cb_date As ComboBox
    Friend WithEvents cb_month As ComboBox
    Friend WithEvents cb_year As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cb_weight As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents cb_height As ComboBox
    Friend WithEvents cb_age As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Button1 As Button
End Class
