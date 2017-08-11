<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_IncomeTaxCalc
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
        Me.lbl_IncomeAmt = New System.Windows.Forms.Label()
        Me.btn_CalcTax = New System.Windows.Forms.Button()
        Me.lbl_TaxesDue = New System.Windows.Forms.Label()
        Me.txt_TaxTotal = New System.Windows.Forms.TextBox()
        Me.msktxt_Income = New System.Windows.Forms.MaskedTextBox()
        Me.SuspendLayout()
        '
        'lbl_IncomeAmt
        '
        Me.lbl_IncomeAmt.AutoSize = True
        Me.lbl_IncomeAmt.Location = New System.Drawing.Point(24, 12)
        Me.lbl_IncomeAmt.Name = "lbl_IncomeAmt"
        Me.lbl_IncomeAmt.Size = New System.Drawing.Size(75, 13)
        Me.lbl_IncomeAmt.TabIndex = 1
        Me.lbl_IncomeAmt.Text = "Total Income :"
        '
        'btn_CalcTax
        '
        Me.btn_CalcTax.Location = New System.Drawing.Point(27, 50)
        Me.btn_CalcTax.Name = "btn_CalcTax"
        Me.btn_CalcTax.Size = New System.Drawing.Size(189, 20)
        Me.btn_CalcTax.TabIndex = 2
        Me.btn_CalcTax.Text = "Calculate Tax"
        Me.btn_CalcTax.UseVisualStyleBackColor = True
        '
        'lbl_TaxesDue
        '
        Me.lbl_TaxesDue.AutoSize = True
        Me.lbl_TaxesDue.Location = New System.Drawing.Point(24, 93)
        Me.lbl_TaxesDue.Name = "lbl_TaxesDue"
        Me.lbl_TaxesDue.Size = New System.Drawing.Size(73, 13)
        Me.lbl_TaxesDue.TabIndex = 4
        Me.lbl_TaxesDue.Text = "Taxes Owed :"
        '
        'txt_TaxTotal
        '
        Me.txt_TaxTotal.Location = New System.Drawing.Point(105, 90)
        Me.txt_TaxTotal.MaxLength = 15
        Me.txt_TaxTotal.Name = "txt_TaxTotal"
        Me.txt_TaxTotal.Size = New System.Drawing.Size(111, 20)
        Me.txt_TaxTotal.TabIndex = 3
        Me.txt_TaxTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'msktxt_Income
        '
        Me.msktxt_Income.BeepOnError = True
        Me.msktxt_Income.HidePromptOnLeave = True
        Me.msktxt_Income.Location = New System.Drawing.Point(105, 9)
        Me.msktxt_Income.Mask = "0000000000"
        Me.msktxt_Income.Name = "msktxt_Income"
        Me.msktxt_Income.RejectInputOnFirstFailure = True
        Me.msktxt_Income.Size = New System.Drawing.Size(111, 20)
        Me.msktxt_Income.TabIndex = 6
        Me.msktxt_Income.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.msktxt_Income.Visible = False
        '
        'frm_IncomeTaxCalc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(256, 119)
        Me.Controls.Add(Me.msktxt_Income)
        Me.Controls.Add(Me.lbl_TaxesDue)
        Me.Controls.Add(Me.txt_TaxTotal)
        Me.Controls.Add(Me.btn_CalcTax)
        Me.Controls.Add(Me.lbl_IncomeAmt)
        Me.Name = "frm_IncomeTaxCalc"
        Me.Text = "Income Tax"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_IncomeAmt As Label
    Friend WithEvents btn_CalcTax As Button
    Friend WithEvents lbl_TaxesDue As Label
    Friend WithEvents txt_TaxTotal As TextBox
    Friend WithEvents msktxt_Income As MaskedTextBox
End Class
