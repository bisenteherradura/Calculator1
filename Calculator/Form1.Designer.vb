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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form1))
        equals = New Button()
        point = New Button()
        zero = New Button()
        negative = New Button()
        one = New Button()
        two = New Button()
        three = New Button()
        add = New Button()
        four = New Button()
        five = New Button()
        six = New Button()
        minus = New Button()
        seven = New Button()
        eight = New Button()
        nine = New Button()
        multiply = New Button()
        backspace = New Button()
        ce = New Button()
        c = New Button()
        divide = New Button()
        result = New TextBox()
        Label = New TextBox()
        SuspendLayout()
        ' 
        ' equals
        ' 
        equals.Location = New Point(210, 360)
        equals.Name = "equals"
        equals.Size = New Size(87, 47)
        equals.TabIndex = 0
        equals.Text = "="
        equals.UseVisualStyleBackColor = True
        ' 
        ' point
        ' 
        point.Location = New Point(139, 360)
        point.Name = "point"
        point.Size = New Size(65, 47)
        point.TabIndex = 1
        point.Text = "."
        point.UseVisualStyleBackColor = True
        ' 
        ' zero
        ' 
        zero.Location = New Point(68, 360)
        zero.Name = "zero"
        zero.Size = New Size(65, 47)
        zero.TabIndex = 2
        zero.Text = "0"
        zero.UseVisualStyleBackColor = True
        ' 
        ' negative
        ' 
        negative.Location = New Point(6, 360)
        negative.Name = "negative"
        negative.Size = New Size(56, 47)
        negative.TabIndex = 3
        negative.Text = "+/-"
        negative.UseVisualStyleBackColor = True
        ' 
        ' one
        ' 
        one.Location = New Point(6, 307)
        one.Name = "one"
        one.Size = New Size(56, 47)
        one.TabIndex = 7
        one.Text = "1"
        one.UseVisualStyleBackColor = True
        ' 
        ' two
        ' 
        two.Location = New Point(68, 307)
        two.Name = "two"
        two.Size = New Size(65, 47)
        two.TabIndex = 6
        two.Text = "2"
        two.UseVisualStyleBackColor = True
        ' 
        ' three
        ' 
        three.Location = New Point(139, 307)
        three.Name = "three"
        three.Size = New Size(65, 47)
        three.TabIndex = 5
        three.Text = "3"
        three.UseVisualStyleBackColor = True
        ' 
        ' add
        ' 
        add.Location = New Point(210, 307)
        add.Name = "add"
        add.Size = New Size(87, 47)
        add.TabIndex = 4
        add.Text = "+"
        add.UseVisualStyleBackColor = True
        ' 
        ' four
        ' 
        four.Location = New Point(6, 254)
        four.Name = "four"
        four.Size = New Size(56, 47)
        four.TabIndex = 11
        four.Text = "4"
        four.UseVisualStyleBackColor = True
        ' 
        ' five
        ' 
        five.Location = New Point(68, 254)
        five.Name = "five"
        five.Size = New Size(65, 47)
        five.TabIndex = 10
        five.Text = "5"
        five.UseVisualStyleBackColor = True
        ' 
        ' six
        ' 
        six.Location = New Point(139, 254)
        six.Name = "six"
        six.Size = New Size(65, 47)
        six.TabIndex = 9
        six.Text = "6"
        six.UseVisualStyleBackColor = True
        ' 
        ' minus
        ' 
        minus.Location = New Point(210, 254)
        minus.Name = "minus"
        minus.Size = New Size(87, 47)
        minus.TabIndex = 8
        minus.Text = "-"
        minus.UseVisualStyleBackColor = True
        ' 
        ' seven
        ' 
        seven.Location = New Point(6, 201)
        seven.Name = "seven"
        seven.Size = New Size(56, 47)
        seven.TabIndex = 15
        seven.Text = "7"
        seven.UseVisualStyleBackColor = True
        ' 
        ' eight
        ' 
        eight.Location = New Point(68, 201)
        eight.Name = "eight"
        eight.Size = New Size(65, 47)
        eight.TabIndex = 14
        eight.Text = "8"
        eight.UseVisualStyleBackColor = True
        ' 
        ' nine
        ' 
        nine.Location = New Point(139, 201)
        nine.Name = "nine"
        nine.Size = New Size(65, 47)
        nine.TabIndex = 13
        nine.Text = "9"
        nine.UseVisualStyleBackColor = True
        ' 
        ' multiply
        ' 
        multiply.Location = New Point(210, 201)
        multiply.Name = "multiply"
        multiply.Size = New Size(87, 47)
        multiply.TabIndex = 12
        multiply.Text = "×"
        multiply.UseVisualStyleBackColor = True
        ' 
        ' backspace
        ' 
        backspace.Location = New Point(6, 148)
        backspace.Name = "backspace"
        backspace.Size = New Size(56, 47)
        backspace.TabIndex = 19
        backspace.Text = "⌫"
        backspace.UseVisualStyleBackColor = True
        ' 
        ' ce
        ' 
        ce.Location = New Point(68, 148)
        ce.Name = "ce"
        ce.Size = New Size(65, 47)
        ce.TabIndex = 18
        ce.Text = "CE"
        ce.UseVisualStyleBackColor = True
        ' 
        ' c
        ' 
        c.Location = New Point(139, 148)
        c.Name = "c"
        c.Size = New Size(65, 47)
        c.TabIndex = 17
        c.Text = "C"
        c.UseVisualStyleBackColor = True
        ' 
        ' divide
        ' 
        divide.Location = New Point(210, 148)
        divide.Name = "divide"
        divide.Size = New Size(87, 47)
        divide.TabIndex = 16
        divide.Text = "÷"
        divide.UseVisualStyleBackColor = True
        ' 
        ' result
        ' 
        result.BackColor = SystemColors.Control
        result.BorderStyle = BorderStyle.None
        result.Font = New Font("Segoe UI Emoji", 36F, FontStyle.Bold, GraphicsUnit.Point)
        result.Location = New Point(12, 76)
        result.Multiline = True
        result.Name = "result"
        result.Size = New Size(283, 66)
        result.TabIndex = 20
        result.Text = "0"
        result.TextAlign = HorizontalAlignment.Right
        ' 
        ' Label
        ' 
        Label.BackColor = SystemColors.Control
        Label.BorderStyle = BorderStyle.None
        Label.Font = New Font("Segoe UI Emoji", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label.Location = New Point(139, 52)
        Label.Name = "Label"
        Label.Size = New Size(151, 18)
        Label.TabIndex = 21
        Label.TextAlign = HorizontalAlignment.Right
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(299, 414)
        Controls.Add(Label)
        Controls.Add(result)
        Controls.Add(backspace)
        Controls.Add(ce)
        Controls.Add(c)
        Controls.Add(divide)
        Controls.Add(seven)
        Controls.Add(eight)
        Controls.Add(nine)
        Controls.Add(multiply)
        Controls.Add(four)
        Controls.Add(five)
        Controls.Add(six)
        Controls.Add(minus)
        Controls.Add(one)
        Controls.Add(two)
        Controls.Add(three)
        Controls.Add(add)
        Controls.Add(negative)
        Controls.Add(zero)
        Controls.Add(point)
        Controls.Add(equals)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Form1"
        Text = "Calculator"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents equals As Button
    Friend WithEvents point As Button
    Friend WithEvents zero As Button
    Friend WithEvents negative As Button
    Friend WithEvents one As Button
    Friend WithEvents two As Button
    Friend WithEvents three As Button
    Friend WithEvents add As Button
    Friend WithEvents four As Button
    Friend WithEvents five As Button
    Friend WithEvents six As Button
    Friend WithEvents minus As Button
    Friend WithEvents seven As Button
    Friend WithEvents eight As Button
    Friend WithEvents nine As Button
    Friend WithEvents multiply As Button
    Friend WithEvents backspace As Button
    Friend WithEvents ce As Button
    Friend WithEvents c As Button
    Friend WithEvents divide As Button
    Friend WithEvents result As TextBox
    Friend WithEvents Label As TextBox
End Class
