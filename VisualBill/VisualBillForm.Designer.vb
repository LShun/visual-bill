<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class VisualBillForm
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
        Me.TitlePanel = New System.Windows.Forms.Panel()
        Me.TitleLabel = New System.Windows.Forms.Label()
        Me.AddInvoiceGroupBox = New System.Windows.Forms.GroupBox()
        Me.RefreshBtn = New System.Windows.Forms.Button()
        Me.SaveBtn = New System.Windows.Forms.Button()
        Me.DescriptionTxt = New System.Windows.Forms.RichTextBox()
        Me.TotalTxt = New System.Windows.Forms.TextBox()
        Me.DueTxt = New System.Windows.Forms.TextBox()
        Me.ProductTxt = New System.Windows.Forms.TextBox()
        Me.EmailTxt = New System.Windows.Forms.TextBox()
        Me.PhoneTxt = New System.Windows.Forms.TextBox()
        Me.ClientNameTxt = New System.Windows.Forms.TextBox()
        Me.ClientIdTxt = New System.Windows.Forms.TextBox()
        Me.DescriptionLabel = New System.Windows.Forms.Label()
        Me.DueLabel = New System.Windows.Forms.Label()
        Me.ProductLabel = New System.Windows.Forms.Label()
        Me.PhoneLabel = New System.Windows.Forms.Label()
        Me.ClientNameLabel = New System.Windows.Forms.Label()
        Me.TotalLabel = New System.Windows.Forms.Label()
        Me.EmailLabel = New System.Windows.Forms.Label()
        Me.ClientIdLabel = New System.Windows.Forms.Label()
        Me.InvoiceDataGrid = New System.Windows.Forms.DataGridView()
        Me.InvoiceListGroupBox = New System.Windows.Forms.GroupBox()
        Me.TitlePanel.SuspendLayout()
        Me.AddInvoiceGroupBox.SuspendLayout()
        CType(Me.InvoiceDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.InvoiceListGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'TitlePanel
        '
        Me.TitlePanel.BackColor = System.Drawing.Color.CornflowerBlue
        Me.TitlePanel.BackgroundImage = Global.VisualBill.My.Resources.Resources.visualbill_bg
        Me.TitlePanel.Controls.Add(Me.TitleLabel)
        Me.TitlePanel.Location = New System.Drawing.Point(0, 0)
        Me.TitlePanel.Name = "TitlePanel"
        Me.TitlePanel.Size = New System.Drawing.Size(887, 81)
        Me.TitlePanel.TabIndex = 0
        '
        'TitleLabel
        '
        Me.TitleLabel.AutoSize = True
        Me.TitleLabel.BackColor = System.Drawing.Color.DarkSlateGray
        Me.TitleLabel.Font = New System.Drawing.Font("Century", 36.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.TitleLabel.Location = New System.Drawing.Point(12, 9)
        Me.TitleLabel.Name = "TitleLabel"
        Me.TitleLabel.Size = New System.Drawing.Size(258, 57)
        Me.TitleLabel.TabIndex = 0
        Me.TitleLabel.Text = "VisualBill"
        '
        'AddInvoiceGroupBox
        '
        Me.AddInvoiceGroupBox.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.AddInvoiceGroupBox.Controls.Add(Me.RefreshBtn)
        Me.AddInvoiceGroupBox.Controls.Add(Me.SaveBtn)
        Me.AddInvoiceGroupBox.Controls.Add(Me.DescriptionTxt)
        Me.AddInvoiceGroupBox.Controls.Add(Me.TotalTxt)
        Me.AddInvoiceGroupBox.Controls.Add(Me.DueTxt)
        Me.AddInvoiceGroupBox.Controls.Add(Me.ProductTxt)
        Me.AddInvoiceGroupBox.Controls.Add(Me.EmailTxt)
        Me.AddInvoiceGroupBox.Controls.Add(Me.PhoneTxt)
        Me.AddInvoiceGroupBox.Controls.Add(Me.ClientNameTxt)
        Me.AddInvoiceGroupBox.Controls.Add(Me.ClientIdTxt)
        Me.AddInvoiceGroupBox.Controls.Add(Me.DescriptionLabel)
        Me.AddInvoiceGroupBox.Controls.Add(Me.DueLabel)
        Me.AddInvoiceGroupBox.Controls.Add(Me.ProductLabel)
        Me.AddInvoiceGroupBox.Controls.Add(Me.PhoneLabel)
        Me.AddInvoiceGroupBox.Controls.Add(Me.ClientNameLabel)
        Me.AddInvoiceGroupBox.Controls.Add(Me.TotalLabel)
        Me.AddInvoiceGroupBox.Controls.Add(Me.EmailLabel)
        Me.AddInvoiceGroupBox.Controls.Add(Me.ClientIdLabel)
        Me.AddInvoiceGroupBox.Location = New System.Drawing.Point(0, 87)
        Me.AddInvoiceGroupBox.Name = "AddInvoiceGroupBox"
        Me.AddInvoiceGroupBox.Size = New System.Drawing.Size(887, 214)
        Me.AddInvoiceGroupBox.TabIndex = 1
        Me.AddInvoiceGroupBox.TabStop = False
        Me.AddInvoiceGroupBox.Text = "➕ Add Invoice"
        '
        'RefreshBtn
        '
        Me.RefreshBtn.Location = New System.Drawing.Point(782, 138)
        Me.RefreshBtn.Name = "RefreshBtn"
        Me.RefreshBtn.Size = New System.Drawing.Size(87, 59)
        Me.RefreshBtn.TabIndex = 19
        Me.RefreshBtn.Text = "🔄 Refresh Invoice List"
        Me.RefreshBtn.UseVisualStyleBackColor = True
        '
        'SaveBtn
        '
        Me.SaveBtn.Location = New System.Drawing.Point(689, 138)
        Me.SaveBtn.Name = "SaveBtn"
        Me.SaveBtn.Size = New System.Drawing.Size(87, 59)
        Me.SaveBtn.TabIndex = 17
        Me.SaveBtn.Text = "💾 Save"
        Me.SaveBtn.UseVisualStyleBackColor = True
        '
        'DescriptionTxt
        '
        Me.DescriptionTxt.Location = New System.Drawing.Point(78, 138)
        Me.DescriptionTxt.Name = "DescriptionTxt"
        Me.DescriptionTxt.Size = New System.Drawing.Size(472, 59)
        Me.DescriptionTxt.TabIndex = 16
        Me.DescriptionTxt.Text = ""
        '
        'TotalTxt
        '
        Me.TotalTxt.Location = New System.Drawing.Point(450, 81)
        Me.TotalTxt.Name = "TotalTxt"
        Me.TotalTxt.Size = New System.Drawing.Size(100, 20)
        Me.TotalTxt.TabIndex = 14
        '
        'DueTxt
        '
        Me.DueTxt.Location = New System.Drawing.Point(265, 81)
        Me.DueTxt.Name = "DueTxt"
        Me.DueTxt.Size = New System.Drawing.Size(100, 20)
        Me.DueTxt.TabIndex = 13
        '
        'ProductTxt
        '
        Me.ProductTxt.Location = New System.Drawing.Point(78, 81)
        Me.ProductTxt.Name = "ProductTxt"
        Me.ProductTxt.Size = New System.Drawing.Size(100, 20)
        Me.ProductTxt.TabIndex = 12
        '
        'EmailTxt
        '
        Me.EmailTxt.Location = New System.Drawing.Point(630, 17)
        Me.EmailTxt.Name = "EmailTxt"
        Me.EmailTxt.Size = New System.Drawing.Size(239, 20)
        Me.EmailTxt.TabIndex = 11
        '
        'PhoneTxt
        '
        Me.PhoneTxt.Location = New System.Drawing.Point(450, 17)
        Me.PhoneTxt.Name = "PhoneTxt"
        Me.PhoneTxt.Size = New System.Drawing.Size(100, 20)
        Me.PhoneTxt.TabIndex = 10
        '
        'ClientNameTxt
        '
        Me.ClientNameTxt.Location = New System.Drawing.Point(265, 17)
        Me.ClientNameTxt.Name = "ClientNameTxt"
        Me.ClientNameTxt.Size = New System.Drawing.Size(100, 20)
        Me.ClientNameTxt.TabIndex = 9
        '
        'ClientIdTxt
        '
        Me.ClientIdTxt.Location = New System.Drawing.Point(78, 17)
        Me.ClientIdTxt.Name = "ClientIdTxt"
        Me.ClientIdTxt.Size = New System.Drawing.Size(100, 20)
        Me.ClientIdTxt.TabIndex = 8
        '
        'DescriptionLabel
        '
        Me.DescriptionLabel.AutoSize = True
        Me.DescriptionLabel.Location = New System.Drawing.Point(12, 138)
        Me.DescriptionLabel.Name = "DescriptionLabel"
        Me.DescriptionLabel.Size = New System.Drawing.Size(60, 13)
        Me.DescriptionLabel.TabIndex = 7
        Me.DescriptionLabel.Text = "Description"
        '
        'DueLabel
        '
        Me.DueLabel.AutoSize = True
        Me.DueLabel.Location = New System.Drawing.Point(198, 84)
        Me.DueLabel.Name = "DueLabel"
        Me.DueLabel.Size = New System.Drawing.Size(27, 13)
        Me.DueLabel.TabIndex = 6
        Me.DueLabel.Text = "Due"
        '
        'ProductLabel
        '
        Me.ProductLabel.AutoSize = True
        Me.ProductLabel.Location = New System.Drawing.Point(12, 84)
        Me.ProductLabel.Name = "ProductLabel"
        Me.ProductLabel.Size = New System.Drawing.Size(44, 13)
        Me.ProductLabel.TabIndex = 5
        Me.ProductLabel.Text = "Product"
        '
        'PhoneLabel
        '
        Me.PhoneLabel.AutoSize = True
        Me.PhoneLabel.Location = New System.Drawing.Point(406, 20)
        Me.PhoneLabel.Name = "PhoneLabel"
        Me.PhoneLabel.Size = New System.Drawing.Size(38, 13)
        Me.PhoneLabel.TabIndex = 4
        Me.PhoneLabel.Text = "Phone"
        '
        'ClientNameLabel
        '
        Me.ClientNameLabel.AutoSize = True
        Me.ClientNameLabel.Location = New System.Drawing.Point(198, 20)
        Me.ClientNameLabel.Name = "ClientNameLabel"
        Me.ClientNameLabel.Size = New System.Drawing.Size(64, 13)
        Me.ClientNameLabel.TabIndex = 3
        Me.ClientNameLabel.Text = "Client Name"
        '
        'TotalLabel
        '
        Me.TotalLabel.AutoSize = True
        Me.TotalLabel.Location = New System.Drawing.Point(406, 84)
        Me.TotalLabel.Name = "TotalLabel"
        Me.TotalLabel.Size = New System.Drawing.Size(31, 13)
        Me.TotalLabel.TabIndex = 2
        Me.TotalLabel.Text = "Total"
        '
        'EmailLabel
        '
        Me.EmailLabel.AutoSize = True
        Me.EmailLabel.Location = New System.Drawing.Point(592, 20)
        Me.EmailLabel.Name = "EmailLabel"
        Me.EmailLabel.Size = New System.Drawing.Size(32, 13)
        Me.EmailLabel.TabIndex = 1
        Me.EmailLabel.Text = "Email"
        '
        'ClientIdLabel
        '
        Me.ClientIdLabel.AutoSize = True
        Me.ClientIdLabel.Location = New System.Drawing.Point(12, 20)
        Me.ClientIdLabel.Name = "ClientIdLabel"
        Me.ClientIdLabel.Size = New System.Drawing.Size(47, 13)
        Me.ClientIdLabel.TabIndex = 0
        Me.ClientIdLabel.Text = "Client ID"
        '
        'InvoiceDataGrid
        '
        Me.InvoiceDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.InvoiceDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.InvoiceDataGrid.Location = New System.Drawing.Point(6, 19)
        Me.InvoiceDataGrid.Name = "InvoiceDataGrid"
        Me.InvoiceDataGrid.Size = New System.Drawing.Size(881, 119)
        Me.InvoiceDataGrid.TabIndex = 2
        '
        'InvoiceListGroupBox
        '
        Me.InvoiceListGroupBox.Controls.Add(Me.InvoiceDataGrid)
        Me.InvoiceListGroupBox.Location = New System.Drawing.Point(0, 308)
        Me.InvoiceListGroupBox.Name = "InvoiceListGroupBox"
        Me.InvoiceListGroupBox.Size = New System.Drawing.Size(887, 144)
        Me.InvoiceListGroupBox.TabIndex = 3
        Me.InvoiceListGroupBox.TabStop = False
        Me.InvoiceListGroupBox.Text = "🗒️ Invoice List"
        '
        'VisualBillForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(887, 450)
        Me.Controls.Add(Me.InvoiceListGroupBox)
        Me.Controls.Add(Me.AddInvoiceGroupBox)
        Me.Controls.Add(Me.TitlePanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "VisualBillForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "💸 VisualBill"
        Me.TitlePanel.ResumeLayout(False)
        Me.TitlePanel.PerformLayout()
        Me.AddInvoiceGroupBox.ResumeLayout(False)
        Me.AddInvoiceGroupBox.PerformLayout()
        CType(Me.InvoiceDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.InvoiceListGroupBox.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TitlePanel As Panel
    Friend WithEvents TitleLabel As Label
    Friend WithEvents AddInvoiceGroupBox As GroupBox
    Friend WithEvents InvoiceDataGrid As DataGridView
    Friend WithEvents ClientIdLabel As Label
    Friend WithEvents TotalTxt As TextBox
    Friend WithEvents DueTxt As TextBox
    Friend WithEvents ProductTxt As TextBox
    Friend WithEvents EmailTxt As TextBox
    Friend WithEvents PhoneTxt As TextBox
    Friend WithEvents ClientNameTxt As TextBox
    Friend WithEvents ClientIdTxt As TextBox
    Friend WithEvents DescriptionLabel As Label
    Friend WithEvents DueLabel As Label
    Friend WithEvents ProductLabel As Label
    Friend WithEvents PhoneLabel As Label
    Friend WithEvents ClientNameLabel As Label
    Friend WithEvents TotalLabel As Label
    Friend WithEvents EmailLabel As Label
    Friend WithEvents SaveBtn As Button
    Friend WithEvents DescriptionTxt As RichTextBox
    Friend WithEvents RefreshBtn As Button
    Friend WithEvents InvoiceListGroupBox As GroupBox
End Class
