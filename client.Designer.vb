<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class client
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
        Me.components = New System.ComponentModel.Container()
        Dim Client_idLabel As System.Windows.Forms.Label
        Dim Client_nameLabel As System.Windows.Forms.Label
        Dim Client_addressLabel As System.Windows.Forms.Label
        Dim Cleint_telLabel As System.Windows.Forms.Label
        Dim Client_emailLabel As System.Windows.Forms.Label
        Me.AyzanDataSet = New WindowsApp1.ayzanDataSet()
        Me.ClientBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClientTableAdapter = New WindowsApp1.ayzanDataSetTableAdapters.ClientTableAdapter()
        Me.TableAdapterManager = New WindowsApp1.ayzanDataSetTableAdapters.TableAdapterManager()
        Me.Client_idTextBox = New System.Windows.Forms.TextBox()
        Me.Client_nameTextBox = New System.Windows.Forms.TextBox()
        Me.Client_addressTextBox = New System.Windows.Forms.TextBox()
        Me.Cleint_telTextBox = New System.Windows.Forms.TextBox()
        Me.Client_emailTextBox = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ADDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DELETEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SAVEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BACKToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ClientBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClientListBox = New System.Windows.Forms.ListBox()
        Client_idLabel = New System.Windows.Forms.Label()
        Client_nameLabel = New System.Windows.Forms.Label()
        Client_addressLabel = New System.Windows.Forms.Label()
        Cleint_telLabel = New System.Windows.Forms.Label()
        Client_emailLabel = New System.Windows.Forms.Label()
        CType(Me.AyzanDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.ClientBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Client_idLabel
        '
        Client_idLabel.AutoSize = True
        Client_idLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Client_idLabel.Location = New System.Drawing.Point(120, 33)
        Client_idLabel.Name = "Client_idLabel"
        Client_idLabel.Size = New System.Drawing.Size(102, 29)
        Client_idLabel.TabIndex = 1
        Client_idLabel.Text = "client id:"
        '
        'Client_nameLabel
        '
        Client_nameLabel.AutoSize = True
        Client_nameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Client_nameLabel.Location = New System.Drawing.Point(120, 61)
        Client_nameLabel.Name = "Client_nameLabel"
        Client_nameLabel.Size = New System.Drawing.Size(142, 29)
        Client_nameLabel.TabIndex = 3
        Client_nameLabel.Text = "client name:"
        '
        'Client_addressLabel
        '
        Client_addressLabel.AutoSize = True
        Client_addressLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Client_addressLabel.Location = New System.Drawing.Point(120, 89)
        Client_addressLabel.Name = "Client_addressLabel"
        Client_addressLabel.Size = New System.Drawing.Size(169, 29)
        Client_addressLabel.TabIndex = 5
        Client_addressLabel.Text = "client address:"
        '
        'Cleint_telLabel
        '
        Cleint_telLabel.AutoSize = True
        Cleint_telLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Cleint_telLabel.Location = New System.Drawing.Point(120, 117)
        Cleint_telLabel.Name = "Cleint_telLabel"
        Cleint_telLabel.Size = New System.Drawing.Size(108, 29)
        Cleint_telLabel.TabIndex = 7
        Cleint_telLabel.Text = "client tel:"
        '
        'Client_emailLabel
        '
        Client_emailLabel.AutoSize = True
        Client_emailLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Client_emailLabel.Location = New System.Drawing.Point(120, 145)
        Client_emailLabel.Name = "Client_emailLabel"
        Client_emailLabel.Size = New System.Drawing.Size(141, 29)
        Client_emailLabel.TabIndex = 9
        Client_emailLabel.Text = "client email:"
        '
        'AyzanDataSet
        '
        Me.AyzanDataSet.DataSetName = "ayzanDataSet"
        Me.AyzanDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ClientBindingSource
        '
        Me.ClientBindingSource.DataMember = "Client"
        Me.ClientBindingSource.DataSource = Me.AyzanDataSet
        '
        'ClientTableAdapter
        '
        Me.ClientTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BrandTableAdapter = Nothing
        Me.TableAdapterManager.CarTableAdapter = Nothing
        Me.TableAdapterManager.CategoryTableAdapter = Nothing
        Me.TableAdapterManager.ClientTableAdapter = Me.ClientTableAdapter
        Me.TableAdapterManager.ColorTableAdapter = Nothing
        Me.TableAdapterManager.ModelTableAdapter = Nothing
        Me.TableAdapterManager.RentalTableAdapter = Nothing
        Me.TableAdapterManager.StyleTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApp1.ayzanDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Client_idTextBox
        '
        Me.Client_idTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientBindingSource, "client_id", True))
        Me.Client_idTextBox.Location = New System.Drawing.Point(300, 33)
        Me.Client_idTextBox.Name = "Client_idTextBox"
        Me.Client_idTextBox.Size = New System.Drawing.Size(241, 22)
        Me.Client_idTextBox.TabIndex = 2
        '
        'Client_nameTextBox
        '
        Me.Client_nameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientBindingSource, "client_name", True))
        Me.Client_nameTextBox.Location = New System.Drawing.Point(300, 61)
        Me.Client_nameTextBox.Name = "Client_nameTextBox"
        Me.Client_nameTextBox.Size = New System.Drawing.Size(241, 22)
        Me.Client_nameTextBox.TabIndex = 4
        '
        'Client_addressTextBox
        '
        Me.Client_addressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientBindingSource, "client_address", True))
        Me.Client_addressTextBox.Location = New System.Drawing.Point(300, 89)
        Me.Client_addressTextBox.Name = "Client_addressTextBox"
        Me.Client_addressTextBox.Size = New System.Drawing.Size(241, 22)
        Me.Client_addressTextBox.TabIndex = 6
        '
        'Cleint_telTextBox
        '
        Me.Cleint_telTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientBindingSource, "cleint_tel", True))
        Me.Cleint_telTextBox.Location = New System.Drawing.Point(300, 117)
        Me.Cleint_telTextBox.Name = "Cleint_telTextBox"
        Me.Cleint_telTextBox.Size = New System.Drawing.Size(241, 22)
        Me.Cleint_telTextBox.TabIndex = 8
        '
        'Client_emailTextBox
        '
        Me.Client_emailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientBindingSource, "client_email", True))
        Me.Client_emailTextBox.Location = New System.Drawing.Point(300, 145)
        Me.Client_emailTextBox.Name = "Client_emailTextBox"
        Me.Client_emailTextBox.Size = New System.Drawing.Size(241, 22)
        Me.Client_emailTextBox.TabIndex = 10
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.Left
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ADDToolStripMenuItem, Me.DELETEToolStripMenuItem, Me.SAVEToolStripMenuItem, Me.BACKToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(156, 605)
        Me.MenuStrip1.TabIndex = 11
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ADDToolStripMenuItem
        '
        Me.ADDToolStripMenuItem.Name = "ADDToolStripMenuItem"
        Me.ADDToolStripMenuItem.Size = New System.Drawing.Size(143, 24)
        Me.ADDToolStripMenuItem.Text = "ADD"
        '
        'DELETEToolStripMenuItem
        '
        Me.DELETEToolStripMenuItem.Name = "DELETEToolStripMenuItem"
        Me.DELETEToolStripMenuItem.Size = New System.Drawing.Size(143, 24)
        Me.DELETEToolStripMenuItem.Text = "DELETE"
        '
        'SAVEToolStripMenuItem
        '
        Me.SAVEToolStripMenuItem.Name = "SAVEToolStripMenuItem"
        Me.SAVEToolStripMenuItem.Size = New System.Drawing.Size(143, 24)
        Me.SAVEToolStripMenuItem.Text = "SAVE"
        '
        'BACKToolStripMenuItem
        '
        Me.BACKToolStripMenuItem.Name = "BACKToolStripMenuItem"
        Me.BACKToolStripMenuItem.Size = New System.Drawing.Size(143, 24)
        Me.BACKToolStripMenuItem.Text = "BACK"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(125, 218)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "<<"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(343, 217)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = ">>"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ClientBindingSource1
        '
        Me.ClientBindingSource1.DataMember = "Client"
        Me.ClientBindingSource1.DataSource = Me.AyzanDataSet
        '
        'ClientListBox
        '
        Me.ClientListBox.DataSource = Me.ClientBindingSource1
        Me.ClientListBox.DisplayMember = "client_name"
        Me.ClientListBox.FormattingEnabled = True
        Me.ClientListBox.ItemHeight = 16
        Me.ClientListBox.Location = New System.Drawing.Point(125, 275)
        Me.ClientListBox.Name = "ClientListBox"
        Me.ClientListBox.Size = New System.Drawing.Size(300, 212)
        Me.ClientListBox.TabIndex = 13
        Me.ClientListBox.ValueMember = "client_id"
        '
        'client
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(1118, 605)
        Me.Controls.Add(Me.ClientListBox)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Client_idLabel)
        Me.Controls.Add(Me.Client_idTextBox)
        Me.Controls.Add(Client_nameLabel)
        Me.Controls.Add(Me.Client_nameTextBox)
        Me.Controls.Add(Client_addressLabel)
        Me.Controls.Add(Me.Client_addressTextBox)
        Me.Controls.Add(Cleint_telLabel)
        Me.Controls.Add(Me.Cleint_telTextBox)
        Me.Controls.Add(Client_emailLabel)
        Me.Controls.Add(Me.Client_emailTextBox)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "client"
        Me.Text = "client"
        CType(Me.AyzanDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.ClientBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AyzanDataSet As ayzanDataSet
    Friend WithEvents ClientBindingSource As BindingSource
    Friend WithEvents ClientTableAdapter As ayzanDataSetTableAdapters.ClientTableAdapter
    Friend WithEvents TableAdapterManager As ayzanDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Client_idTextBox As TextBox
    Friend WithEvents Client_nameTextBox As TextBox
    Friend WithEvents Client_addressTextBox As TextBox
    Friend WithEvents Cleint_telTextBox As TextBox
    Friend WithEvents Client_emailTextBox As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ADDToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DELETEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SAVEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BACKToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents ClientBindingSource1 As BindingSource
    Friend WithEvents ClientListBox As ListBox
End Class
