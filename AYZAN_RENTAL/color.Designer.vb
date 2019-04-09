<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class color
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Color_idLabel As System.Windows.Forms.Label
        Dim Colore_nameLabel As System.Windows.Forms.Label
        Me.AyzanDataSet = New AYZAN_RENTAL.ayzanDataSet()
        Me.ColorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ColorTableAdapter = New AYZAN_RENTAL.ayzanDataSetTableAdapters.ColorTableAdapter()
        Me.TableAdapterManager = New AYZAN_RENTAL.ayzanDataSetTableAdapters.TableAdapterManager()
        Me.Color_idTextBox = New System.Windows.Forms.TextBox()
        Me.Colore_nameTextBox = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ADDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DELETEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SAVEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BACKToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ColorBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ColorListBox = New System.Windows.Forms.ListBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Color_idLabel = New System.Windows.Forms.Label()
        Colore_nameLabel = New System.Windows.Forms.Label()
        CType(Me.AyzanDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.ColorBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AyzanDataSet
        '
        Me.AyzanDataSet.DataSetName = "ayzanDataSet"
        Me.AyzanDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ColorBindingSource
        '
        Me.ColorBindingSource.DataMember = "Color"
        Me.ColorBindingSource.DataSource = Me.AyzanDataSet
        '
        'ColorTableAdapter
        '
        Me.ColorTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BrandTableAdapter = Nothing
        Me.TableAdapterManager.CarTableAdapter = Nothing
        Me.TableAdapterManager.CategoryTableAdapter = Nothing
        Me.TableAdapterManager.ClientTableAdapter = Nothing
        Me.TableAdapterManager.ColorTableAdapter = Me.ColorTableAdapter
        Me.TableAdapterManager.ModelTableAdapter = Nothing
        Me.TableAdapterManager.RentalTableAdapter = Nothing
        Me.TableAdapterManager.StyleTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = AYZAN_RENTAL.ayzanDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Color_idLabel
        '
        Color_idLabel.AutoSize = True
        Color_idLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Color_idLabel.Location = New System.Drawing.Point(103, 32)
        Color_idLabel.Name = "Color_idLabel"
        Color_idLabel.Size = New System.Drawing.Size(99, 29)
        Color_idLabel.TabIndex = 1
        Color_idLabel.Text = "color id:"
        '
        'Color_idTextBox
        '
        Me.Color_idTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ColorBindingSource, "color_id", True))
        Me.Color_idTextBox.Location = New System.Drawing.Point(264, 39)
        Me.Color_idTextBox.Name = "Color_idTextBox"
        Me.Color_idTextBox.Size = New System.Drawing.Size(215, 22)
        Me.Color_idTextBox.TabIndex = 2
        '
        'Colore_nameLabel
        '
        Colore_nameLabel.AutoSize = True
        Colore_nameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Colore_nameLabel.Location = New System.Drawing.Point(103, 60)
        Colore_nameLabel.Name = "Colore_nameLabel"
        Colore_nameLabel.Size = New System.Drawing.Size(139, 29)
        Colore_nameLabel.TabIndex = 3
        Colore_nameLabel.Text = "color name:"
        '
        'Colore_nameTextBox
        '
        Me.Colore_nameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ColorBindingSource, "colore_name", True))
        Me.Colore_nameTextBox.Location = New System.Drawing.Point(264, 67)
        Me.Colore_nameTextBox.Name = "Colore_nameTextBox"
        Me.Colore_nameTextBox.Size = New System.Drawing.Size(215, 22)
        Me.Colore_nameTextBox.TabIndex = 4
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.Left
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ADDToolStripMenuItem, Me.DELETEToolStripMenuItem, Me.SAVEToolStripMenuItem, Me.BACKToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(77, 605)
        Me.MenuStrip1.TabIndex = 5
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
        'ColorBindingSource1
        '
        Me.ColorBindingSource1.DataMember = "Color"
        Me.ColorBindingSource1.DataSource = Me.AyzanDataSet
        '
        'ColorListBox
        '
        Me.ColorListBox.DataSource = Me.ColorBindingSource1
        Me.ColorListBox.DisplayMember = "colore_name"
        Me.ColorListBox.FormattingEnabled = True
        Me.ColorListBox.ItemHeight = 16
        Me.ColorListBox.Location = New System.Drawing.Point(108, 165)
        Me.ColorListBox.Name = "ColorListBox"
        Me.ColorListBox.Size = New System.Drawing.Size(300, 212)
        Me.ColorListBox.TabIndex = 5
        Me.ColorListBox.ValueMember = "color_id"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(108, 136)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "<<"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(333, 136)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = ">>"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'color
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(1116, 605)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ColorListBox)
        Me.Controls.Add(Color_idLabel)
        Me.Controls.Add(Me.Color_idTextBox)
        Me.Controls.Add(Colore_nameLabel)
        Me.Controls.Add(Me.Colore_nameTextBox)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "color"
        Me.Text = "color"
        CType(Me.AyzanDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.ColorBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AyzanDataSet As ayzanDataSet
    Friend WithEvents ColorBindingSource As BindingSource
    Friend WithEvents ColorTableAdapter As ayzanDataSetTableAdapters.ColorTableAdapter
    Friend WithEvents TableAdapterManager As ayzanDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Color_idTextBox As TextBox
    Friend WithEvents Colore_nameTextBox As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ADDToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DELETEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SAVEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BACKToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ColorBindingSource1 As BindingSource
    Friend WithEvents ColorListBox As ListBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
