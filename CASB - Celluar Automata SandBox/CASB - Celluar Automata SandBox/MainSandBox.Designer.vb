<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainSandBox
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainSandBox))
        Me.MideaTimer = New System.Windows.Forms.Timer(Me.components)
        Me.TwoDimentionsTab = New System.Windows.Forms.TabPage()
        Me.Seed2D = New System.Windows.Forms.RichTextBox()
        Me.Save2D = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SilverJuice = New System.Windows.Forms.Panel()
        Me.FPS = New System.Windows.Forms.TrackBar()
        Me.MN = New System.Windows.Forms.RadioButton()
        Me.VNN = New System.Windows.Forms.RadioButton()
        Me.ProgressBar2D = New System.Windows.Forms.ProgressBar()
        Me.Sim2D = New System.Windows.Forms.PictureBox()
        Me.Randomize2DButton = New System.Windows.Forms.Button()
        Me.Make2DButton = New System.Windows.Forms.Button()
        Me.TottalStepCount = New System.Windows.Forms.Label()
        Me.CurrentStepIndex = New System.Windows.Forms.Label()
        Me.FPSL = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.CoD2D = New System.Windows.Forms.TextBox()
        Me.CoB2D = New System.Windows.Forms.TextBox()
        Me.NotG2D = New System.Windows.Forms.TextBox()
        Me.HotG2D = New System.Windows.Forms.TextBox()
        Me.WotG2D = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.OneDimentionTab = New System.Windows.Forms.TabPage()
        Me.Seed1D = New System.Windows.Forms.RichTextBox()
        Me.Save1D = New System.Windows.Forms.Button()
        Me.ProgressBar1D = New System.Windows.Forms.ProgressBar()
        Me.Sim1D = New System.Windows.Forms.PictureBox()
        Me.RandomizeButton = New System.Windows.Forms.Button()
        Me.MakeButton = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CoD1D = New System.Windows.Forms.TextBox()
        Me.CoB1D = New System.Windows.Forms.TextBox()
        Me.NotG1D = New System.Windows.Forms.TextBox()
        Me.WotG1D = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.SeedMaker2D = New System.Windows.Forms.TabPage()
        Me.Seed2DBox = New System.Windows.Forms.RichTextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.SeedProgress = New System.Windows.Forms.ProgressBar()
        Me.Copy = New System.Windows.Forms.Button()
        Me.UploadImage = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImportProjectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportProjectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.QuitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TwoDimentionsTab.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.FPS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sim2D, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.OneDimentionTab.SuspendLayout()
        CType(Me.Sim1D, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.SeedMaker2D.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MideaTimer
        '
        Me.MideaTimer.Interval = 1
        '
        'TwoDimentionsTab
        '
        Me.TwoDimentionsTab.Controls.Add(Me.Seed2D)
        Me.TwoDimentionsTab.Controls.Add(Me.Save2D)
        Me.TwoDimentionsTab.Controls.Add(Me.Panel1)
        Me.TwoDimentionsTab.Controls.Add(Me.FPS)
        Me.TwoDimentionsTab.Controls.Add(Me.MN)
        Me.TwoDimentionsTab.Controls.Add(Me.VNN)
        Me.TwoDimentionsTab.Controls.Add(Me.ProgressBar2D)
        Me.TwoDimentionsTab.Controls.Add(Me.Sim2D)
        Me.TwoDimentionsTab.Controls.Add(Me.Randomize2DButton)
        Me.TwoDimentionsTab.Controls.Add(Me.Make2DButton)
        Me.TwoDimentionsTab.Controls.Add(Me.TottalStepCount)
        Me.TwoDimentionsTab.Controls.Add(Me.CurrentStepIndex)
        Me.TwoDimentionsTab.Controls.Add(Me.FPSL)
        Me.TwoDimentionsTab.Controls.Add(Me.Label13)
        Me.TwoDimentionsTab.Controls.Add(Me.Label12)
        Me.TwoDimentionsTab.Controls.Add(Me.Label6)
        Me.TwoDimentionsTab.Controls.Add(Me.Label7)
        Me.TwoDimentionsTab.Controls.Add(Me.Label8)
        Me.TwoDimentionsTab.Controls.Add(Me.Label9)
        Me.TwoDimentionsTab.Controls.Add(Me.CoD2D)
        Me.TwoDimentionsTab.Controls.Add(Me.CoB2D)
        Me.TwoDimentionsTab.Controls.Add(Me.NotG2D)
        Me.TwoDimentionsTab.Controls.Add(Me.HotG2D)
        Me.TwoDimentionsTab.Controls.Add(Me.WotG2D)
        Me.TwoDimentionsTab.Controls.Add(Me.Label11)
        Me.TwoDimentionsTab.Controls.Add(Me.Label10)
        Me.TwoDimentionsTab.Location = New System.Drawing.Point(4, 25)
        Me.TwoDimentionsTab.Name = "TwoDimentionsTab"
        Me.TwoDimentionsTab.Padding = New System.Windows.Forms.Padding(3)
        Me.TwoDimentionsTab.Size = New System.Drawing.Size(756, 413)
        Me.TwoDimentionsTab.TabIndex = 1
        Me.TwoDimentionsTab.Text = "2D"
        Me.TwoDimentionsTab.UseVisualStyleBackColor = True
        '
        'Seed2D
        '
        Me.Seed2D.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Seed2D.Location = New System.Drawing.Point(533, 187)
        Me.Seed2D.Name = "Seed2D"
        Me.Seed2D.Size = New System.Drawing.Size(221, 80)
        Me.Seed2D.TabIndex = 22
        Me.Seed2D.Text = resources.GetString("Seed2D.Text")
        '
        'Save2D
        '
        Me.Save2D.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Save2D.Enabled = False
        Me.Save2D.Location = New System.Drawing.Point(668, 355)
        Me.Save2D.Name = "Save2D"
        Me.Save2D.Size = New System.Drawing.Size(80, 23)
        Me.Save2D.TabIndex = 21
        Me.Save2D.Text = "Save"
        Me.Save2D.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.SilverJuice)
        Me.Panel1.Location = New System.Drawing.Point(492, 292)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(256, 25)
        Me.Panel1.TabIndex = 20
        '
        'SilverJuice
        '
        Me.SilverJuice.BackColor = System.Drawing.Color.Silver
        Me.SilverJuice.Location = New System.Drawing.Point(0, 0)
        Me.SilverJuice.Name = "SilverJuice"
        Me.SilverJuice.Size = New System.Drawing.Size(0, 25)
        Me.SilverJuice.TabIndex = 21
        '
        'FPS
        '
        Me.FPS.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FPS.AutoSize = False
        Me.FPS.LargeChange = 20
        Me.FPS.Location = New System.Drawing.Point(526, 323)
        Me.FPS.Maximum = 1000
        Me.FPS.Name = "FPS"
        Me.FPS.Size = New System.Drawing.Size(181, 25)
        Me.FPS.TabIndex = 19
        Me.FPS.TickFrequency = 20
        '
        'MN
        '
        Me.MN.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MN.AutoSize = True
        Me.MN.Checked = True
        Me.MN.Location = New System.Drawing.Point(635, 163)
        Me.MN.Name = "MN"
        Me.MN.Size = New System.Drawing.Size(60, 18)
        Me.MN.TabIndex = 18
        Me.MN.TabStop = True
        Me.MN.Text = "Moore"
        Me.MN.UseVisualStyleBackColor = True
        '
        'VNN
        '
        Me.VNN.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.VNN.AutoSize = True
        Me.VNN.Location = New System.Drawing.Point(635, 139)
        Me.VNN.Name = "VNN"
        Me.VNN.Size = New System.Drawing.Size(102, 18)
        Me.VNN.TabIndex = 18
        Me.VNN.Text = "Von Neumann"
        Me.VNN.UseVisualStyleBackColor = True
        '
        'ProgressBar2D
        '
        Me.ProgressBar2D.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProgressBar2D.Location = New System.Drawing.Point(492, 384)
        Me.ProgressBar2D.Name = "ProgressBar2D"
        Me.ProgressBar2D.Size = New System.Drawing.Size(256, 23)
        Me.ProgressBar2D.TabIndex = 17
        '
        'Sim2D
        '
        Me.Sim2D.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Sim2D.Location = New System.Drawing.Point(6, 7)
        Me.Sim2D.Name = "Sim2D"
        Me.Sim2D.Size = New System.Drawing.Size(480, 400)
        Me.Sim2D.TabIndex = 16
        Me.Sim2D.TabStop = False
        '
        'Randomize2DButton
        '
        Me.Randomize2DButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Randomize2DButton.Location = New System.Drawing.Point(578, 355)
        Me.Randomize2DButton.Name = "Randomize2DButton"
        Me.Randomize2DButton.Size = New System.Drawing.Size(84, 23)
        Me.Randomize2DButton.TabIndex = 14
        Me.Randomize2DButton.Text = "Randomize"
        Me.Randomize2DButton.UseVisualStyleBackColor = True
        '
        'Make2DButton
        '
        Me.Make2DButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Make2DButton.Location = New System.Drawing.Point(492, 355)
        Me.Make2DButton.Name = "Make2DButton"
        Me.Make2DButton.Size = New System.Drawing.Size(80, 23)
        Me.Make2DButton.TabIndex = 15
        Me.Make2DButton.Text = "Make"
        Me.Make2DButton.UseVisualStyleBackColor = True
        '
        'TottalStepCount
        '
        Me.TottalStepCount.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TottalStepCount.AutoSize = True
        Me.TottalStepCount.Location = New System.Drawing.Point(735, 273)
        Me.TottalStepCount.Name = "TottalStepCount"
        Me.TottalStepCount.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TottalStepCount.Size = New System.Drawing.Size(14, 14)
        Me.TottalStepCount.TabIndex = 11
        Me.TottalStepCount.Text = "0"
        Me.TottalStepCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CurrentStepIndex
        '
        Me.CurrentStepIndex.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CurrentStepIndex.AutoSize = True
        Me.CurrentStepIndex.Location = New System.Drawing.Point(489, 273)
        Me.CurrentStepIndex.Name = "CurrentStepIndex"
        Me.CurrentStepIndex.Size = New System.Drawing.Size(14, 14)
        Me.CurrentStepIndex.TabIndex = 11
        Me.CurrentStepIndex.Text = "0"
        '
        'FPSL
        '
        Me.FPSL.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FPSL.AutoSize = True
        Me.FPSL.Location = New System.Drawing.Point(721, 328)
        Me.FPSL.Name = "FPSL"
        Me.FPSL.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.FPSL.Size = New System.Drawing.Size(28, 14)
        Me.FPSL.TabIndex = 11
        Me.FPSL.Text = "fps"
        Me.FPSL.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label13
        '
        Me.Label13.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(492, 328)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(28, 14)
        Me.Label13.TabIndex = 11
        Me.Label13.Text = "FPS"
        '
        'Label12
        '
        Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(489, 141)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(140, 14)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "Type Of Nighborhood"
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(492, 190)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(35, 14)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Seed"
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(489, 114)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(133, 14)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Condition Of Death"
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(489, 88)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(126, 14)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Condition Of Born"
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(489, 62)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(182, 14)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Number Of The Generations"
        '
        'CoD2D
        '
        Me.CoD2D.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CoD2D.Location = New System.Drawing.Point(628, 111)
        Me.CoD2D.Name = "CoD2D"
        Me.CoD2D.Size = New System.Drawing.Size(123, 22)
        Me.CoD2D.TabIndex = 5
        Me.CoD2D.Text = "0, 1, 4, 6, 7, 8"
        '
        'CoB2D
        '
        Me.CoB2D.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CoB2D.Location = New System.Drawing.Point(621, 85)
        Me.CoB2D.Name = "CoB2D"
        Me.CoB2D.Size = New System.Drawing.Size(130, 22)
        Me.CoB2D.TabIndex = 4
        Me.CoB2D.Text = "3"
        '
        'NotG2D
        '
        Me.NotG2D.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NotG2D.Location = New System.Drawing.Point(677, 59)
        Me.NotG2D.Name = "NotG2D"
        Me.NotG2D.Size = New System.Drawing.Size(74, 22)
        Me.NotG2D.TabIndex = 8
        Me.NotG2D.Text = "40"
        '
        'HotG2D
        '
        Me.HotG2D.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.HotG2D.Location = New System.Drawing.Point(670, 33)
        Me.HotG2D.Name = "HotG2D"
        Me.HotG2D.Size = New System.Drawing.Size(81, 22)
        Me.HotG2D.TabIndex = 10
        Me.HotG2D.Text = "100"
        '
        'WotG2D
        '
        Me.WotG2D.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WotG2D.Location = New System.Drawing.Point(663, 7)
        Me.WotG2D.Name = "WotG2D"
        Me.WotG2D.Size = New System.Drawing.Size(88, 22)
        Me.WotG2D.TabIndex = 10
        Me.WotG2D.Text = "100"
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(489, 36)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(175, 14)
        Me.Label11.TabIndex = 9
        Me.Label11.Text = "Height Of The Generation"
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(489, 10)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(168, 14)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Width Of The Generation"
        '
        'OneDimentionTab
        '
        Me.OneDimentionTab.Controls.Add(Me.Seed1D)
        Me.OneDimentionTab.Controls.Add(Me.Save1D)
        Me.OneDimentionTab.Controls.Add(Me.ProgressBar1D)
        Me.OneDimentionTab.Controls.Add(Me.Sim1D)
        Me.OneDimentionTab.Controls.Add(Me.RandomizeButton)
        Me.OneDimentionTab.Controls.Add(Me.MakeButton)
        Me.OneDimentionTab.Controls.Add(Me.Label5)
        Me.OneDimentionTab.Controls.Add(Me.Label4)
        Me.OneDimentionTab.Controls.Add(Me.Label3)
        Me.OneDimentionTab.Controls.Add(Me.Label2)
        Me.OneDimentionTab.Controls.Add(Me.CoD1D)
        Me.OneDimentionTab.Controls.Add(Me.CoB1D)
        Me.OneDimentionTab.Controls.Add(Me.NotG1D)
        Me.OneDimentionTab.Controls.Add(Me.WotG1D)
        Me.OneDimentionTab.Controls.Add(Me.Label1)
        Me.OneDimentionTab.Location = New System.Drawing.Point(4, 25)
        Me.OneDimentionTab.Name = "OneDimentionTab"
        Me.OneDimentionTab.Padding = New System.Windows.Forms.Padding(3)
        Me.OneDimentionTab.Size = New System.Drawing.Size(756, 413)
        Me.OneDimentionTab.TabIndex = 0
        Me.OneDimentionTab.Text = "1D"
        Me.OneDimentionTab.UseVisualStyleBackColor = True
        '
        'Seed1D
        '
        Me.Seed1D.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Seed1D.Location = New System.Drawing.Point(530, 110)
        Me.Seed1D.Name = "Seed1D"
        Me.Seed1D.Size = New System.Drawing.Size(218, 238)
        Me.Seed1D.TabIndex = 23
        Me.Seed1D.Text = ""
        '
        'Save1D
        '
        Me.Save1D.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Save1D.Enabled = False
        Me.Save1D.Location = New System.Drawing.Point(668, 354)
        Me.Save1D.Name = "Save1D"
        Me.Save1D.Size = New System.Drawing.Size(80, 23)
        Me.Save1D.TabIndex = 22
        Me.Save1D.Text = "Save"
        Me.Save1D.UseVisualStyleBackColor = True
        '
        'ProgressBar1D
        '
        Me.ProgressBar1D.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProgressBar1D.Location = New System.Drawing.Point(492, 383)
        Me.ProgressBar1D.Name = "ProgressBar1D"
        Me.ProgressBar1D.Size = New System.Drawing.Size(256, 23)
        Me.ProgressBar1D.TabIndex = 4
        '
        'Sim1D
        '
        Me.Sim1D.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Sim1D.Location = New System.Drawing.Point(3, 6)
        Me.Sim1D.Name = "Sim1D"
        Me.Sim1D.Size = New System.Drawing.Size(480, 400)
        Me.Sim1D.TabIndex = 3
        Me.Sim1D.TabStop = False
        '
        'RandomizeButton
        '
        Me.RandomizeButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RandomizeButton.Location = New System.Drawing.Point(578, 354)
        Me.RandomizeButton.Name = "RandomizeButton"
        Me.RandomizeButton.Size = New System.Drawing.Size(84, 23)
        Me.RandomizeButton.TabIndex = 2
        Me.RandomizeButton.Text = "Randomize"
        Me.RandomizeButton.UseVisualStyleBackColor = True
        '
        'MakeButton
        '
        Me.MakeButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MakeButton.Location = New System.Drawing.Point(492, 354)
        Me.MakeButton.Name = "MakeButton"
        Me.MakeButton.Size = New System.Drawing.Size(80, 23)
        Me.MakeButton.TabIndex = 2
        Me.MakeButton.Text = "Make"
        Me.MakeButton.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(489, 113)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 14)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Seed"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(489, 87)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(133, 14)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Condition Of Death"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(489, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(126, 14)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Condition Of Born"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(489, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(182, 14)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Number Of The Generations"
        '
        'CoD1D
        '
        Me.CoD1D.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CoD1D.Location = New System.Drawing.Point(628, 84)
        Me.CoD1D.Name = "CoD1D"
        Me.CoD1D.Size = New System.Drawing.Size(120, 22)
        Me.CoD1D.TabIndex = 0
        '
        'CoB1D
        '
        Me.CoB1D.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CoB1D.Location = New System.Drawing.Point(621, 58)
        Me.CoB1D.Name = "CoB1D"
        Me.CoB1D.Size = New System.Drawing.Size(127, 22)
        Me.CoB1D.TabIndex = 0
        '
        'NotG1D
        '
        Me.NotG1D.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NotG1D.Location = New System.Drawing.Point(677, 32)
        Me.NotG1D.Name = "NotG1D"
        Me.NotG1D.Size = New System.Drawing.Size(71, 22)
        Me.NotG1D.TabIndex = 0
        '
        'WotG1D
        '
        Me.WotG1D.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WotG1D.Location = New System.Drawing.Point(663, 6)
        Me.WotG1D.Name = "WotG1D"
        Me.WotG1D.Size = New System.Drawing.Size(85, 22)
        Me.WotG1D.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(489, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(168, 14)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Width Of The Generation"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.OneDimentionTab)
        Me.TabControl1.Controls.Add(Me.TwoDimentionsTab)
        Me.TabControl1.Controls.Add(Me.SeedMaker2D)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Font = New System.Drawing.Font("Consolas", 9.0!)
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.Padding = New System.Drawing.Point(6, 4)
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(764, 442)
        Me.TabControl1.TabIndex = 2
        '
        'SeedMaker2D
        '
        Me.SeedMaker2D.Controls.Add(Me.Seed2DBox)
        Me.SeedMaker2D.Controls.Add(Me.Label14)
        Me.SeedMaker2D.Controls.Add(Me.SeedProgress)
        Me.SeedMaker2D.Controls.Add(Me.Copy)
        Me.SeedMaker2D.Controls.Add(Me.UploadImage)
        Me.SeedMaker2D.Location = New System.Drawing.Point(4, 25)
        Me.SeedMaker2D.Name = "SeedMaker2D"
        Me.SeedMaker2D.Padding = New System.Windows.Forms.Padding(3)
        Me.SeedMaker2D.Size = New System.Drawing.Size(756, 413)
        Me.SeedMaker2D.TabIndex = 2
        Me.SeedMaker2D.Text = "2d Seed Maker"
        Me.SeedMaker2D.UseVisualStyleBackColor = True
        '
        'Seed2DBox
        '
        Me.Seed2DBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Seed2DBox.Location = New System.Drawing.Point(8, 6)
        Me.Seed2DBox.Name = "Seed2DBox"
        Me.Seed2DBox.Size = New System.Drawing.Size(740, 371)
        Me.Seed2DBox.TabIndex = 6
        Me.Seed2DBox.Text = ""
        '
        'Label14
        '
        Me.Label14.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(363, 387)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(385, 14)
        Me.Label14.TabIndex = 5
        Me.Label14.Text = "Choose Images with big constract to get better results"
        '
        'SeedProgress
        '
        Me.SeedProgress.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SeedProgress.Location = New System.Drawing.Point(213, 383)
        Me.SeedProgress.Name = "SeedProgress"
        Me.SeedProgress.Size = New System.Drawing.Size(144, 23)
        Me.SeedProgress.TabIndex = 4
        '
        'Copy
        '
        Me.Copy.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Copy.Location = New System.Drawing.Point(115, 383)
        Me.Copy.Name = "Copy"
        Me.Copy.Size = New System.Drawing.Size(92, 23)
        Me.Copy.TabIndex = 0
        Me.Copy.Text = "Use Seed"
        Me.Copy.UseVisualStyleBackColor = True
        '
        'UploadImage
        '
        Me.UploadImage.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.UploadImage.Location = New System.Drawing.Point(8, 383)
        Me.UploadImage.Name = "UploadImage"
        Me.UploadImage.Size = New System.Drawing.Size(101, 23)
        Me.UploadImage.TabIndex = 0
        Me.UploadImage.Text = "Upload Image"
        Me.UploadImage.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MenuStrip1.AutoSize = False
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Font = New System.Drawing.Font("Consolas", 9.0!)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(705, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(58, 22)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ImportProjectToolStripMenuItem, Me.ExportProjectToolStripMenuItem, Me.ToolStripSeparator1, Me.QuitToolStripMenuItem})
        Me.MenuToolStripMenuItem.Font = New System.Drawing.Font("Consolas", 9.0!)
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(47, 18)
        Me.MenuToolStripMenuItem.Text = "Menu"
        '
        'ImportProjectToolStripMenuItem
        '
        Me.ImportProjectToolStripMenuItem.Name = "ImportProjectToolStripMenuItem"
        Me.ImportProjectToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.ImportProjectToolStripMenuItem.Size = New System.Drawing.Size(235, 22)
        Me.ImportProjectToolStripMenuItem.Text = "&Open Project"
        '
        'ExportProjectToolStripMenuItem
        '
        Me.ExportProjectToolStripMenuItem.Name = "ExportProjectToolStripMenuItem"
        Me.ExportProjectToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.ExportProjectToolStripMenuItem.Size = New System.Drawing.Size(235, 22)
        Me.ExportProjectToolStripMenuItem.Text = "&Save Project"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(232, 6)
        '
        'QuitToolStripMenuItem
        '
        Me.QuitToolStripMenuItem.Name = "QuitToolStripMenuItem"
        Me.QuitToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.QuitToolStripMenuItem.Size = New System.Drawing.Size(235, 22)
        Me.QuitToolStripMenuItem.Text = "&Quit"
        '
        'MainSandBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(764, 442)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Consolas", 8.0!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MinimumSize = New System.Drawing.Size(780, 480)
        Me.Name = "MainSandBox"
        Me.Text = "CASB - Celluar Automata SandBox"
        Me.TwoDimentionsTab.ResumeLayout(False)
        Me.TwoDimentionsTab.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.FPS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sim2D, System.ComponentModel.ISupportInitialize).EndInit()
        Me.OneDimentionTab.ResumeLayout(False)
        Me.OneDimentionTab.PerformLayout()
        CType(Me.Sim1D, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.SeedMaker2D.ResumeLayout(False)
        Me.SeedMaker2D.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MideaTimer As System.Windows.Forms.Timer
    Friend WithEvents TwoDimentionsTab As System.Windows.Forms.TabPage
    Friend WithEvents Save2D As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents SilverJuice As System.Windows.Forms.Panel
    Friend WithEvents FPS As System.Windows.Forms.TrackBar
    Friend WithEvents MN As System.Windows.Forms.RadioButton
    Friend WithEvents VNN As System.Windows.Forms.RadioButton
    Friend WithEvents ProgressBar2D As System.Windows.Forms.ProgressBar
    Friend WithEvents Sim2D As System.Windows.Forms.PictureBox
    Friend WithEvents Randomize2DButton As System.Windows.Forms.Button
    Friend WithEvents Make2DButton As System.Windows.Forms.Button
    Friend WithEvents FPSL As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents CoD2D As System.Windows.Forms.TextBox
    Friend WithEvents CoB2D As System.Windows.Forms.TextBox
    Friend WithEvents NotG2D As System.Windows.Forms.TextBox
    Friend WithEvents HotG2D As System.Windows.Forms.TextBox
    Friend WithEvents WotG2D As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents OneDimentionTab As System.Windows.Forms.TabPage
    Friend WithEvents Save1D As System.Windows.Forms.Button
    Friend WithEvents ProgressBar1D As System.Windows.Forms.ProgressBar
    Friend WithEvents Sim1D As System.Windows.Forms.PictureBox
    Friend WithEvents RandomizeButton As System.Windows.Forms.Button
    Friend WithEvents MakeButton As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CoD1D As System.Windows.Forms.TextBox
    Friend WithEvents CoB1D As System.Windows.Forms.TextBox
    Friend WithEvents NotG1D As System.Windows.Forms.TextBox
    Friend WithEvents WotG1D As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents SeedMaker2D As System.Windows.Forms.TabPage
    Friend WithEvents Copy As System.Windows.Forms.Button
    Friend WithEvents UploadImage As System.Windows.Forms.Button
    Friend WithEvents SeedProgress As System.Windows.Forms.ProgressBar
    Friend WithEvents Seed2D As System.Windows.Forms.RichTextBox
    Friend WithEvents Seed1D As System.Windows.Forms.RichTextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents MenuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImportProjectToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExportProjectToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents QuitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Seed2DBox As System.Windows.Forms.RichTextBox
    Friend WithEvents TottalStepCount As System.Windows.Forms.Label
    Friend WithEvents CurrentStepIndex As System.Windows.Forms.Label

End Class
