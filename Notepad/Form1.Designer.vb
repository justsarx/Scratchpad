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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        MenuStrip1 = New MenuStrip()
        FileToolStripMenuItem = New ToolStripMenuItem()
        NewToolStripMenuItem = New ToolStripMenuItem()
        OpenToolStripMenuItem = New ToolStripMenuItem()
        SaveToolStripMenuItem = New ToolStripMenuItem()
        SaveAsToolStripMenuItem = New ToolStripMenuItem()
        ExitToolStripMenuItem = New ToolStripMenuItem()
        EditToolStripMenuItem = New ToolStripMenuItem()
        CutToolStripMenuItem = New ToolStripMenuItem()
        CopyToolStripMenuItem = New ToolStripMenuItem()
        PasteToolStripMenuItem = New ToolStripMenuItem()
        FontToolStripMenuItem = New ToolStripMenuItem()
        ViewToolStripMenuItem = New ToolStripMenuItem()
        ZoomInToolStripMenuItem = New ToolStripMenuItem()
        ZoomOutToolStripMenuItem = New ToolStripMenuItem()
        RichTextBox1 = New RichTextBox()
        OpenFileDialog1 = New OpenFileDialog()
        SaveFileDialog1 = New SaveFileDialog()
        FontDialog1 = New FontDialog()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {FileToolStripMenuItem, EditToolStripMenuItem, ViewToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(800, 24)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' FileToolStripMenuItem
        ' 
        FileToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {NewToolStripMenuItem, OpenToolStripMenuItem, SaveToolStripMenuItem, SaveAsToolStripMenuItem, ExitToolStripMenuItem})
        FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        FileToolStripMenuItem.Size = New Size(37, 20)
        FileToolStripMenuItem.Text = "File"
        ' 
        ' NewToolStripMenuItem
        ' 
        NewToolStripMenuItem.Image = CType(resources.GetObject("NewToolStripMenuItem.Image"), Image)
        NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        NewToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.N
        NewToolStripMenuItem.Size = New Size(186, 22)
        NewToolStripMenuItem.Text = "New"
        ' 
        ' OpenToolStripMenuItem
        ' 
        OpenToolStripMenuItem.Image = CType(resources.GetObject("OpenToolStripMenuItem.Image"), Image)
        OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        OpenToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.O
        OpenToolStripMenuItem.Size = New Size(186, 22)
        OpenToolStripMenuItem.Text = "Open"
        ' 
        ' SaveToolStripMenuItem
        ' 
        SaveToolStripMenuItem.Image = CType(resources.GetObject("SaveToolStripMenuItem.Image"), Image)
        SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        SaveToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.S
        SaveToolStripMenuItem.Size = New Size(186, 22)
        SaveToolStripMenuItem.Text = "Save "
        ' 
        ' SaveAsToolStripMenuItem
        ' 
        SaveAsToolStripMenuItem.Image = CType(resources.GetObject("SaveAsToolStripMenuItem.Image"), Image)
        SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem"
        SaveAsToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.Shift Or Keys.S
        SaveAsToolStripMenuItem.Size = New Size(186, 22)
        SaveAsToolStripMenuItem.Text = "Save As"
        ' 
        ' ExitToolStripMenuItem
        ' 
        ExitToolStripMenuItem.Image = CType(resources.GetObject("ExitToolStripMenuItem.Image"), Image)
        ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        ExitToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.Q
        ExitToolStripMenuItem.Size = New Size(186, 22)
        ExitToolStripMenuItem.Text = "Exit"
        ' 
        ' EditToolStripMenuItem
        ' 
        EditToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {CutToolStripMenuItem, CopyToolStripMenuItem, PasteToolStripMenuItem, FontToolStripMenuItem})
        EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        EditToolStripMenuItem.Size = New Size(39, 20)
        EditToolStripMenuItem.Text = "Edit"
        ' 
        ' CutToolStripMenuItem
        ' 
        CutToolStripMenuItem.Image = CType(resources.GetObject("CutToolStripMenuItem.Image"), Image)
        CutToolStripMenuItem.Name = "CutToolStripMenuItem"
        CutToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.X
        CutToolStripMenuItem.Size = New Size(161, 22)
        CutToolStripMenuItem.Text = "Cut"
        ' 
        ' CopyToolStripMenuItem
        ' 
        CopyToolStripMenuItem.Image = CType(resources.GetObject("CopyToolStripMenuItem.Image"), Image)
        CopyToolStripMenuItem.Name = "CopyToolStripMenuItem"
        CopyToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.C
        CopyToolStripMenuItem.Size = New Size(161, 22)
        CopyToolStripMenuItem.Text = "Copy"
        ' 
        ' PasteToolStripMenuItem
        ' 
        PasteToolStripMenuItem.Image = CType(resources.GetObject("PasteToolStripMenuItem.Image"), Image)
        PasteToolStripMenuItem.Name = "PasteToolStripMenuItem"
        PasteToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.V
        PasteToolStripMenuItem.Size = New Size(161, 22)
        PasteToolStripMenuItem.Text = "Paste"
        ' 
        ' FontToolStripMenuItem
        ' 
        FontToolStripMenuItem.Image = CType(resources.GetObject("FontToolStripMenuItem.Image"), Image)
        FontToolStripMenuItem.Name = "FontToolStripMenuItem"
        FontToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.Alt Or Keys.F
        FontToolStripMenuItem.Size = New Size(161, 22)
        FontToolStripMenuItem.Text = "Font"
        ' 
        ' ViewToolStripMenuItem
        ' 
        ViewToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ZoomInToolStripMenuItem, ZoomOutToolStripMenuItem})
        ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        ViewToolStripMenuItem.Size = New Size(44, 20)
        ViewToolStripMenuItem.Text = "View"
        ' 
        ' ZoomInToolStripMenuItem
        ' 
        ZoomInToolStripMenuItem.Image = CType(resources.GetObject("ZoomInToolStripMenuItem.Image"), Image)
        ZoomInToolStripMenuItem.Name = "ZoomInToolStripMenuItem"
        ZoomInToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.Up
        ZoomInToolStripMenuItem.Size = New Size(194, 22)
        ZoomInToolStripMenuItem.Text = "Zoom In"
        ' 
        ' ZoomOutToolStripMenuItem
        ' 
        ZoomOutToolStripMenuItem.Image = CType(resources.GetObject("ZoomOutToolStripMenuItem.Image"), Image)
        ZoomOutToolStripMenuItem.Name = "ZoomOutToolStripMenuItem"
        ZoomOutToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.Down
        ZoomOutToolStripMenuItem.Size = New Size(194, 22)
        ZoomOutToolStripMenuItem.Text = "Zoom Out"
        ' 
        ' RichTextBox1
        ' 
        RichTextBox1.AcceptsTab = True
        RichTextBox1.BackColor = SystemColors.Window
        RichTextBox1.BorderStyle = BorderStyle.None
        RichTextBox1.Dock = DockStyle.Fill
        RichTextBox1.EnableAutoDragDrop = True
        RichTextBox1.Location = New Point(0, 24)
        RichTextBox1.Name = "RichTextBox1"
        RichTextBox1.ScrollBars = RichTextBoxScrollBars.ForcedBoth
        RichTextBox1.Size = New Size(800, 426)
        RichTextBox1.TabIndex = 1
        RichTextBox1.Text = ""
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.DefaultExt = "txt"
        OpenFileDialog1.Filter = "Text Files|*.txt|All Files|"
        ' 
        ' SaveFileDialog1
        ' 
        SaveFileDialog1.DefaultExt = "txt"
        SaveFileDialog1.Filter = "Text Files|*.txt|All Files|"
        ' 
        ' FontDialog1
        ' 
        FontDialog1.Color = Color.White
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Desktop
        ClientSize = New Size(800, 450)
        Controls.Add(RichTextBox1)
        Controls.Add(MenuStrip1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MainMenuStrip = MenuStrip1
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Scratchpad"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveAsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CopyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PasteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FontToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ZoomInToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ZoomOutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents FontDialog1 As FontDialog

End Class
