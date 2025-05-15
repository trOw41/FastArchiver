'Imports FastArchiver.FastArchiver
Imports Windows.System


<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        DataSet1 = New DataSet()
        ItemNo = New Label()
        FileList = New ListView()
        FileListContextMenuStrip = New ContextMenuStrip(components)
        RemoveToolStripMenuItem = New ToolStripMenuItem()
        SizeText = New Label()
        StatusText = New Label()
        MenuStrip1 = New MenuStrip()
        FIleToolStripMenuItem = New ToolStripMenuItem()
        ExitToolStripMenuItem = New ToolStripMenuItem()
        HelpToolStripMenuItem = New ToolStripMenuItem()
        FAQToolStripMenuItem = New ToolStripMenuItem()
        OptionsToolStripMenuItem = New ToolStripMenuItem()
        InfoToolStripMenuItem = New ToolStripMenuItem()
        Combo1 = New ToolStripComboBox()
        BinfoText = New Label()
        Label1 = New Label()
        ZipFormatButton = New RadioButton()
        Button1 = New Button()
        ProgressBar1 = New ProgressBar()
        CheckBox1 = New CheckBox()
        OpenArchiv = New Button()
        StartButton = New Button()
        SelectButton = New Button()
        Label2 = New Label()
        OpenZip = New OpenFileDialog()
        FolderBrowserDialog1 = New FolderBrowserDialog()
        NotifyIcon1 = New NotifyIcon(components)
        Process1 = New Process()
        CType(DataSet1, ComponentModel.ISupportInitialize).BeginInit()
        FileListContextMenuStrip.SuspendLayout()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' DataSet1
        ' 
        DataSet1.DataSetName = "NewDataSet"
        ' 
        ' ItemNo
        ' 
        resources.ApplyResources(ItemNo, "ItemNo")
        ItemNo.FlatStyle = FlatStyle.Popup
        ItemNo.Name = "ItemNo"
        ' 
        ' FileList
        ' 
        resources.ApplyResources(FileList, "FileList")
        FileList.CheckBoxes = True
        FileList.ContextMenuStrip = FileListContextMenuStrip
        FileList.FullRowSelect = True
        FileList.GridLines = True
        FileList.Name = "FileList"
        FileList.UseCompatibleStateImageBehavior = False
        ' 
        ' FileListContextMenuStrip
        ' 
        resources.ApplyResources(FileListContextMenuStrip, "FileListContextMenuStrip")
        FileListContextMenuStrip.Items.AddRange(New ToolStripItem() {RemoveToolStripMenuItem})
        FileListContextMenuStrip.Name = "ContextMenuStrip1"
        FileListContextMenuStrip.RenderMode = ToolStripRenderMode.Professional
        ' 
        ' RemoveToolStripMenuItem
        ' 
        resources.ApplyResources(RemoveToolStripMenuItem, "RemoveToolStripMenuItem")
        RemoveToolStripMenuItem.Name = "RemoveToolStripMenuItem"
        ' 
        ' SizeText
        ' 
        resources.ApplyResources(SizeText, "SizeText")
        SizeText.Name = "SizeText"
        ' 
        ' StatusText
        ' 
        resources.ApplyResources(StatusText, "StatusText")
        StatusText.Name = "StatusText"
        ' 
        ' MenuStrip1
        ' 
        resources.ApplyResources(MenuStrip1, "MenuStrip1")
        MenuStrip1.Items.AddRange(New ToolStripItem() {FIleToolStripMenuItem, HelpToolStripMenuItem, InfoToolStripMenuItem, Combo1})
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.RenderMode = ToolStripRenderMode.Professional
        MenuStrip1.ShowItemToolTips = True
        ' 
        ' FIleToolStripMenuItem
        ' 
        resources.ApplyResources(FIleToolStripMenuItem, "FIleToolStripMenuItem")
        FIleToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ExitToolStripMenuItem})
        FIleToolStripMenuItem.Name = "FIleToolStripMenuItem"
        FIleToolStripMenuItem.Overflow = ToolStripItemOverflow.AsNeeded
        ' 
        ' ExitToolStripMenuItem
        ' 
        resources.ApplyResources(ExitToolStripMenuItem, "ExitToolStripMenuItem")
        ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        ' 
        ' HelpToolStripMenuItem
        ' 
        resources.ApplyResources(HelpToolStripMenuItem, "HelpToolStripMenuItem")
        HelpToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {FAQToolStripMenuItem, OptionsToolStripMenuItem})
        HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        ' 
        ' FAQToolStripMenuItem
        ' 
        resources.ApplyResources(FAQToolStripMenuItem, "FAQToolStripMenuItem")
        FAQToolStripMenuItem.Name = "FAQToolStripMenuItem"
        ' 
        ' OptionsToolStripMenuItem
        ' 
        resources.ApplyResources(OptionsToolStripMenuItem, "OptionsToolStripMenuItem")
        OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        ' 
        ' InfoToolStripMenuItem
        ' 
        resources.ApplyResources(InfoToolStripMenuItem, "InfoToolStripMenuItem")
        InfoToolStripMenuItem.Name = "InfoToolStripMenuItem"
        ' 
        ' Combo1
        ' 
        resources.ApplyResources(Combo1, "Combo1")
        Combo1.Name = "Combo1"
        ' 
        ' BinfoText
        ' 
        resources.ApplyResources(BinfoText, "BinfoText")
        BinfoText.AutoEllipsis = True
        BinfoText.FlatStyle = FlatStyle.Flat
        BinfoText.Name = "BinfoText"
        BinfoText.UseCompatibleTextRendering = True
        ' 
        ' Label1
        ' 
        resources.ApplyResources(Label1, "Label1")
        Label1.Name = "Label1"
        ' 
        ' ZipFormatButton
        ' 
        resources.ApplyResources(ZipFormatButton, "ZipFormatButton")
        ZipFormatButton.Name = "ZipFormatButton"
        ZipFormatButton.TabStop = True
        ZipFormatButton.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        resources.ApplyResources(Button1, "Button1")
        Button1.Name = "Button1"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' ProgressBar1
        ' 
        resources.ApplyResources(ProgressBar1, "ProgressBar1")
        ProgressBar1.ForeColor = SystemColors.HotTrack
        ProgressBar1.Name = "ProgressBar1"
        ProgressBar1.Step = 1
        ProgressBar1.Value = 10
        ' 
        ' CheckBox1
        ' 
        resources.ApplyResources(CheckBox1, "CheckBox1")
        CheckBox1.Name = "CheckBox1"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' OpenArchiv
        ' 
        resources.ApplyResources(OpenArchiv, "OpenArchiv")
        OpenArchiv.FlatAppearance.BorderSize = 0
        OpenArchiv.FlatAppearance.MouseDownBackColor = Color.Gray
        OpenArchiv.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        OpenArchiv.Name = "OpenArchiv"
        OpenArchiv.UseVisualStyleBackColor = True
        ' 
        ' StartButton
        ' 
        resources.ApplyResources(StartButton, "StartButton")
        StartButton.FlatAppearance.BorderSize = 0
        StartButton.FlatAppearance.MouseDownBackColor = Color.Gray
        StartButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        StartButton.Name = "StartButton"
        StartButton.UseVisualStyleBackColor = True
        ' 
        ' SelectButton
        ' 
        resources.ApplyResources(SelectButton, "SelectButton")
        SelectButton.FlatAppearance.BorderSize = 0
        SelectButton.FlatAppearance.MouseDownBackColor = Color.Gray
        SelectButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        SelectButton.Name = "SelectButton"
        SelectButton.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        resources.ApplyResources(Label2, "Label2")
        Label2.Name = "Label2"
        ' 
        ' OpenZip
        ' 
        OpenZip.FileName = "OpenFileDialog1"
        resources.ApplyResources(OpenZip, "OpenZip")
        ' 
        ' FolderBrowserDialog1
        ' 
        resources.ApplyResources(FolderBrowserDialog1, "FolderBrowserDialog1")
        ' 
        ' NotifyIcon1
        ' 
        NotifyIcon1.BalloonTipIcon = ToolTipIcon.Info
        resources.ApplyResources(NotifyIcon1, "NotifyIcon1")
        NotifyIcon1.ContextMenuStrip = FileListContextMenuStrip
        ' 
        ' Process1
        ' 
        Process1.StartInfo.Domain = ""
        Process1.StartInfo.LoadUserProfile = False
        Process1.StartInfo.Password = Nothing
        Process1.StartInfo.StandardErrorEncoding = Nothing
        Process1.StartInfo.StandardInputEncoding = Nothing
        Process1.StartInfo.StandardOutputEncoding = Nothing
        Process1.StartInfo.UseCredentialsForNetworkingOnly = False
        Process1.StartInfo.UserName = ""
        Process1.SynchronizingObject = Me
        ' 
        ' Form1
        ' 
        resources.ApplyResources(Me, "$this")
        AutoScaleMode = AutoScaleMode.Dpi
        Controls.Add(Label2)
        Controls.Add(CheckBox1)
        Controls.Add(ProgressBar1)
        Controls.Add(Button1)
        Controls.Add(ZipFormatButton)
        Controls.Add(Label1)
        Controls.Add(StartButton)
        Controls.Add(BinfoText)
        Controls.Add(SelectButton)
        Controls.Add(StatusText)
        Controls.Add(SizeText)
        Controls.Add(FileList)
        Controls.Add(ItemNo)
        Controls.Add(MenuStrip1)
        Controls.Add(OpenArchiv)
        FormBorderStyle = FormBorderStyle.Fixed3D
        HelpButton = True
        KeyPreview = True
        MainMenuStrip = MenuStrip1
        MaximizeBox = False
        Name = "Form1"
        CType(DataSet1, ComponentModel.ISupportInitialize).EndInit()
        FileListContextMenuStrip.ResumeLayout(False)
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents DataSet1 As DataSet
    Friend WithEvents ItemNo As Label
    Friend WithEvents FileList As ListView
    Friend WithEvents SizeText As Label
    Friend WithEvents StatusText As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FIleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FAQToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InfoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SelectButton As Button
    Friend WithEvents BinfoText As Label
    Friend WithEvents StartButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents ZipFormatButton As RadioButton
    Friend WithEvents Button1 As Button
    Friend WithEvents FileListContextMenuStrip As ContextMenuStrip
    Friend WithEvents RemoveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents OpenArchiv As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents OpenZip As OpenFileDialog
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents Process1 As Process
    Friend WithEvents OptionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Combo1 As ToolStripComboBox
End Class

