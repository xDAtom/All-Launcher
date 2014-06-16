<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.WindowContent = New System.Windows.Forms.Panel
        Me.ItemBox = New System.Windows.Forms.ComboBox
        Me.MinimizeButton = New System.Windows.Forms.Button
        Me.CloseButton = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.EditItemsButton = New System.Windows.Forms.Button
        Me.PopupCloseButton = New System.Windows.Forms.Button
        Me.PopupContent = New System.Windows.Forms.Panel
        Me.PopupItemsList = New System.Windows.Forms.ComboBox
        Me.NameTextBox = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.ExeTextBox = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.PopupBrowseButton = New System.Windows.Forms.Button
        Me.CreateNew = New System.Windows.Forms.Button
        Me.RemoveSelect = New System.Windows.Forms.Button
        Me.RawEdit = New System.Windows.Forms.Button
        Me.Apply = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.EditItemsPanel = New System.Windows.Forms.Panel
        Me.Launch = New System.Windows.Forms.Button
        Me.WindowContent.SuspendLayout()
        Me.PopupContent.SuspendLayout()
        Me.EditItemsPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'WindowContent
        '
        Me.WindowContent.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.WindowContent.Controls.Add(Me.EditItemsPanel)
        Me.WindowContent.Controls.Add(Me.Launch)
        Me.WindowContent.Controls.Add(Me.EditItemsButton)
        Me.WindowContent.Controls.Add(Me.ItemBox)
        Me.WindowContent.Location = New System.Drawing.Point(12, 48)
        Me.WindowContent.Name = "WindowContent"
        Me.WindowContent.Size = New System.Drawing.Size(776, 540)
        Me.WindowContent.TabIndex = 2
        '
        'ItemBox
        '
        Me.ItemBox.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ItemBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ItemBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ItemBox.Font = New System.Drawing.Font("SketchFlow Print", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ItemBox.FormattingEnabled = True
        Me.ItemBox.Location = New System.Drawing.Point(14, 103)
        Me.ItemBox.Name = "ItemBox"
        Me.ItemBox.Size = New System.Drawing.Size(748, 37)
        Me.ItemBox.TabIndex = 0
        '
        'MinimizeButton
        '
        Me.MinimizeButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MinimizeButton.BackColor = System.Drawing.Color.RoyalBlue
        Me.MinimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MinimizeButton.Font = New System.Drawing.Font("Papyrus", 11.0!, System.Drawing.FontStyle.Bold)
        Me.MinimizeButton.ForeColor = System.Drawing.Color.White
        Me.MinimizeButton.Location = New System.Drawing.Point(727, 9)
        Me.MinimizeButton.Name = "MinimizeButton"
        Me.MinimizeButton.Size = New System.Drawing.Size(30, 30)
        Me.MinimizeButton.TabIndex = 4
        Me.MinimizeButton.TabStop = False
        Me.MinimizeButton.Text = "_"
        Me.MinimizeButton.UseVisualStyleBackColor = False
        '
        'CloseButton
        '
        Me.CloseButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CloseButton.BackColor = System.Drawing.Color.Red
        Me.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CloseButton.Font = New System.Drawing.Font("Papyrus", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CloseButton.ForeColor = System.Drawing.Color.White
        Me.CloseButton.Location = New System.Drawing.Point(758, 9)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(30, 30)
        Me.CloseButton.TabIndex = 3
        Me.CloseButton.TabStop = False
        Me.CloseButton.Text = "X"
        Me.CloseButton.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("SketchFlow Print", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(194, 29)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "All-Launcher"
        '
        'EditItemsButton
        '
        Me.EditItemsButton.BackColor = System.Drawing.Color.LightSteelBlue
        Me.EditItemsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EditItemsButton.Font = New System.Drawing.Font("SketchFlow Print", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditItemsButton.Location = New System.Drawing.Point(591, 146)
        Me.EditItemsButton.Name = "EditItemsButton"
        Me.EditItemsButton.Size = New System.Drawing.Size(171, 40)
        Me.EditItemsButton.TabIndex = 1
        Me.EditItemsButton.Text = "Edit Items..."
        Me.EditItemsButton.UseVisualStyleBackColor = False
        '
        'PopupCloseButton
        '
        Me.PopupCloseButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PopupCloseButton.BackColor = System.Drawing.Color.Red
        Me.PopupCloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PopupCloseButton.Font = New System.Drawing.Font("Papyrus", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PopupCloseButton.ForeColor = System.Drawing.Color.White
        Me.PopupCloseButton.Location = New System.Drawing.Point(714, 8)
        Me.PopupCloseButton.Name = "PopupCloseButton"
        Me.PopupCloseButton.Size = New System.Drawing.Size(30, 30)
        Me.PopupCloseButton.TabIndex = 1
        Me.PopupCloseButton.TabStop = False
        Me.PopupCloseButton.Text = "X"
        Me.PopupCloseButton.UseVisualStyleBackColor = False
        '
        'PopupContent
        '
        Me.PopupContent.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.PopupContent.Controls.Add(Me.Apply)
        Me.PopupContent.Controls.Add(Me.RawEdit)
        Me.PopupContent.Controls.Add(Me.RemoveSelect)
        Me.PopupContent.Controls.Add(Me.CreateNew)
        Me.PopupContent.Controls.Add(Me.PopupBrowseButton)
        Me.PopupContent.Controls.Add(Me.Label4)
        Me.PopupContent.Controls.Add(Me.ExeTextBox)
        Me.PopupContent.Controls.Add(Me.Label3)
        Me.PopupContent.Controls.Add(Me.NameTextBox)
        Me.PopupContent.Controls.Add(Me.PopupItemsList)
        Me.PopupContent.Location = New System.Drawing.Point(12, 46)
        Me.PopupContent.Name = "PopupContent"
        Me.PopupContent.Size = New System.Drawing.Size(732, 462)
        Me.PopupContent.TabIndex = 2
        '
        'PopupItemsList
        '
        Me.PopupItemsList.BackColor = System.Drawing.Color.LightSteelBlue
        Me.PopupItemsList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.PopupItemsList.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PopupItemsList.Font = New System.Drawing.Font("SketchFlow Print", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PopupItemsList.FormattingEnabled = True
        Me.PopupItemsList.Location = New System.Drawing.Point(30, 82)
        Me.PopupItemsList.Name = "PopupItemsList"
        Me.PopupItemsList.Size = New System.Drawing.Size(672, 37)
        Me.PopupItemsList.TabIndex = 1
        '
        'NameTextBox
        '
        Me.NameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NameTextBox.Enabled = False
        Me.NameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameTextBox.Location = New System.Drawing.Point(150, 189)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(552, 35)
        Me.NameTextBox.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("SketchFlow Print", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(26, 198)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(118, 21)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Item Name:"
        '
        'ExeTextBox
        '
        Me.ExeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ExeTextBox.Enabled = False
        Me.ExeTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExeTextBox.Location = New System.Drawing.Point(150, 230)
        Me.ExeTextBox.Name = "ExeTextBox"
        Me.ExeTextBox.Size = New System.Drawing.Size(437, 35)
        Me.ExeTextBox.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("SketchFlow Print", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(26, 239)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(118, 21)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Executable:"
        '
        'PopupBrowseButton
        '
        Me.PopupBrowseButton.BackColor = System.Drawing.Color.LightSteelBlue
        Me.PopupBrowseButton.Enabled = False
        Me.PopupBrowseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PopupBrowseButton.Font = New System.Drawing.Font("SketchFlow Print", 14.25!)
        Me.PopupBrowseButton.Location = New System.Drawing.Point(593, 230)
        Me.PopupBrowseButton.Name = "PopupBrowseButton"
        Me.PopupBrowseButton.Size = New System.Drawing.Size(109, 35)
        Me.PopupBrowseButton.TabIndex = 6
        Me.PopupBrowseButton.Text = "Browse"
        Me.PopupBrowseButton.UseVisualStyleBackColor = False
        '
        'CreateNew
        '
        Me.CreateNew.BackColor = System.Drawing.Color.LightSteelBlue
        Me.CreateNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CreateNew.Font = New System.Drawing.Font("SketchFlow Print", 14.25!)
        Me.CreateNew.Location = New System.Drawing.Point(30, 125)
        Me.CreateNew.Name = "CreateNew"
        Me.CreateNew.Size = New System.Drawing.Size(200, 35)
        Me.CreateNew.TabIndex = 7
        Me.CreateNew.Text = "Create a New Item"
        Me.CreateNew.UseVisualStyleBackColor = False
        '
        'RemoveSelect
        '
        Me.RemoveSelect.BackColor = System.Drawing.Color.LightSteelBlue
        Me.RemoveSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RemoveSelect.Font = New System.Drawing.Font("SketchFlow Print", 14.25!)
        Me.RemoveSelect.Location = New System.Drawing.Point(236, 125)
        Me.RemoveSelect.Name = "RemoveSelect"
        Me.RemoveSelect.Size = New System.Drawing.Size(234, 35)
        Me.RemoveSelect.TabIndex = 8
        Me.RemoveSelect.Text = "Remove Selected Item"
        Me.RemoveSelect.UseVisualStyleBackColor = False
        '
        'RawEdit
        '
        Me.RawEdit.BackColor = System.Drawing.Color.LightSteelBlue
        Me.RawEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RawEdit.Font = New System.Drawing.Font("SketchFlow Print", 14.25!)
        Me.RawEdit.Location = New System.Drawing.Point(476, 125)
        Me.RawEdit.Name = "RawEdit"
        Me.RawEdit.Size = New System.Drawing.Size(226, 35)
        Me.RawEdit.TabIndex = 9
        Me.RawEdit.Text = "Raw Edit (Advanced)"
        Me.RawEdit.UseVisualStyleBackColor = False
        '
        'Apply
        '
        Me.Apply.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Apply.Enabled = False
        Me.Apply.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Apply.Font = New System.Drawing.Font("SketchFlow Print", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Apply.Location = New System.Drawing.Point(313, 298)
        Me.Apply.Name = "Apply"
        Me.Apply.Size = New System.Drawing.Size(109, 35)
        Me.Apply.TabIndex = 10
        Me.Apply.Text = "Apply"
        Me.Apply.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("SketchFlow Print", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(11, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(158, 29)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Edit Items"
        '
        'EditItemsPanel
        '
        Me.EditItemsPanel.BackColor = System.Drawing.Color.SteelBlue
        Me.EditItemsPanel.Controls.Add(Me.Label2)
        Me.EditItemsPanel.Controls.Add(Me.PopupContent)
        Me.EditItemsPanel.Controls.Add(Me.PopupCloseButton)
        Me.EditItemsPanel.Location = New System.Drawing.Point(10, 10)
        Me.EditItemsPanel.Name = "EditItemsPanel"
        Me.EditItemsPanel.Size = New System.Drawing.Size(756, 520)
        Me.EditItemsPanel.TabIndex = 2
        Me.EditItemsPanel.Visible = False
        '
        'Launch
        '
        Me.Launch.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Launch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Launch.Font = New System.Drawing.Font("SketchFlow Print", 51.0!)
        Me.Launch.Location = New System.Drawing.Point(249, 289)
        Me.Launch.Name = "Launch"
        Me.Launch.Size = New System.Drawing.Size(309, 101)
        Me.Launch.TabIndex = 3
        Me.Launch.Text = "Launch!"
        Me.Launch.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(800, 600)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MinimizeButton)
        Me.Controls.Add(Me.CloseButton)
        Me.Controls.Add(Me.WindowContent)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.Text = "All-Launcher"
        Me.WindowContent.ResumeLayout(False)
        Me.PopupContent.ResumeLayout(False)
        Me.PopupContent.PerformLayout()
        Me.EditItemsPanel.ResumeLayout(False)
        Me.EditItemsPanel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents WindowContent As System.Windows.Forms.Panel
    Friend WithEvents ItemBox As System.Windows.Forms.ComboBox
    Friend WithEvents MinimizeButton As System.Windows.Forms.Button
    Friend WithEvents CloseButton As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Launch As System.Windows.Forms.Button
    Friend WithEvents EditItemsPanel As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PopupContent As System.Windows.Forms.Panel
    Friend WithEvents Apply As System.Windows.Forms.Button
    Friend WithEvents RawEdit As System.Windows.Forms.Button
    Friend WithEvents RemoveSelect As System.Windows.Forms.Button
    Friend WithEvents CreateNew As System.Windows.Forms.Button
    Friend WithEvents PopupBrowseButton As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ExeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PopupItemsList As System.Windows.Forms.ComboBox
    Friend WithEvents PopupCloseButton As System.Windows.Forms.Button
    Friend WithEvents EditItemsButton As System.Windows.Forms.Button

End Class
