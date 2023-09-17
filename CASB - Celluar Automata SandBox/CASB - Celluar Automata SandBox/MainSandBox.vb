Imports System.Text.RegularExpressions
Imports CASB.CASBEngin
Imports System.Drawing
Imports System.Drawing.Imaging

Public Class MainSandBox

    Enum dimentions
        One
        Two
    End Enum

    Dim SimDimentions As dimentions

    Dim SimList2D As New List(Of Bitmap)

    Private Sub MainSandBox_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        FPS.Value = 30
    End Sub

    Private Sub MakeButton_Click(sender As System.Object, e As System.EventArgs) Handles MakeButton.Click

        Save1D.Enabled = True

        Dim WotGv As Integer
        Dim NotGv As Integer
        Dim CoBv As New List(Of List(Of Boolean))
        Dim CoDv As New List(Of List(Of Boolean))
        Dim Seedv As New List(Of Boolean)

        Try
            WotGv = WotG1D.Text

            NotGv = NotG1D.Text


            For Each match As Match In Regex.Matches(CoB1D.Text, "\d{3}")
                Dim matchValue As String = match.Value
                Dim boolList As New List(Of Boolean)
                For Each bit As Char In matchValue
                    boolList.Add(bit = "1")
                Next
                CoBv.Add(boolList)
            Next

            For Each match As Match In Regex.Matches(CoD1D.Text, "\d{3}")
                Dim matchValue As String = match.Value
                Dim boolList As New List(Of Boolean)
                For Each bit As Char In matchValue
                    boolList.Add(bit = "1")
                Next
                CoDv.Add(boolList)
            Next

            For Each match As Match In Regex.Matches(Seed1D.Text, "\d")
                Dim digit As Integer = Integer.Parse(match.Value)
                Dim boolValue As Boolean = (digit = 1)
                Seedv.Add(boolValue)
            Next

        Catch ex As Exception
            MsgBox("invalid input")
            Exit Sub
        End Try

        SimDimentions = dimentions.One

        progression = 0

        ProgressBar1D.Maximum = NotGv * 2

        Dim FinalSilmulation = CelluarAutomataGenerator1D(WotGv, NotGv, CoBv, CoDv, Seedv)

        Sim1D.Image = FinalSilmulation

    End Sub

    Private Sub RandomizeButton_Click(sender As System.Object, e As System.EventArgs) Handles RandomizeButton.Click

        ProgressBar1D.Value = 0

        Dim Randomizer As New Random

        WotG1D.Text = Randomizer.Next(1, 10001)

        NotG1D.Text = Randomizer.Next(1, 1001)

        Dim Con As List(Of List(Of Boolean))
        Con = {{False, False, True}.ToList, {False, True, False}.ToList, {False, True, True}.ToList, {True, False, False}.ToList, {True, False, True}.ToList, {True, True, False}.ToList, {True, True, True}.ToList, {False, False, False}.ToList}.ToList
        Dim CoBv = ""
        Dim CoDv = ""
        Dim UC As New List(Of List(Of Boolean))
        For i = 0 To 7
            Dim D = Randomizer.Next(0, 3)
            If D = 0 Then
                Dim s = ""
                For j = 0 To 2
                    s += CInt(-Con(i)(j)).ToString
                Next
                CoBv += s + ", "
            ElseIf D = 1 Then
                Dim s = ""
                For j = 0 To 2
                    s += CInt(-Con(i)(j)).ToString
                Next
                CoDv += s + ", "
            Else
                UC.Add(Con(i))
            End If
        Next
        If CoBv = "" Then
            Do Until CoBv <> ""
                Dim i = Randomizer.Next(0, UC.Count)
                Dim s = ""
                For j = 0 To 2
                    s += CInt(-UC(i)(j)).ToString
                Next
                CoBv += s
            Loop
        End If
        If CoDv = "" Then
            Do Until CoDv <> ""
                Dim i = Randomizer.Next(0, UC.Count)
                Dim s = ""
                For j = 0 To 2
                    s += CInt(-UC(i)(j)).ToString
                Next
                CoDv += s
            Loop
        End If
        CoB1D.Text = CoBv
        CoD1D.Text = CoDv

        Dim SeedV = ""

        For i = 0 To CInt(NotG1D.Text)
            SeedV += Randomizer.Next(0, 2).ToString
        Next

        Seed1D.Text = SeedV

        MakeButton_Click(Nothing, Nothing)

    End Sub

    Private Sub Save1D_Click(sender As System.Object, e As System.EventArgs) Handles Save1D.Click
        Dim SFD As New SaveFileDialog With {.Filter = "PNG|*.png"}
        If SFD.ShowDialog = Windows.Forms.DialogResult.OK Then
            Sim1D.Image.Save(SFD.FileName)
            MsgBox("Saved!")
        End If
    End Sub

    Private Sub Make2DButton_Click(sender As System.Object, e As System.EventArgs) Handles Make2DButton.Click
        MideaTimer.Stop()
        SimList2D.Clear()
        IndexChanger = 0
        ProgressBar2D.Value = 0

        Save2D.Enabled = True

        Dim WotGv As Integer
        Dim HotGv As Integer
        Dim NotGv As Integer
        Dim CoBv As New List(Of Integer)
        Dim CoDv As New List(Of Integer)
        Dim Seedv As New List(Of Boolean)

        Try
            WotGv = WotG2D.Text

            HotGv = HotG2D.Text

            NotGv = NotG2D.Text


            For Each match As Match In Regex.Matches(CoB2D.Text, "\d{1}")
                Dim matchValue As String = match.Value
                For Each digit As Char In matchValue
                    CoBv.Add(Val(digit))
                Next
            Next

            For Each match As Match In Regex.Matches(CoD2D.Text, "\d{1}")
                Dim matchValue As String = match.Value
                For Each digit As Char In matchValue
                    CoDv.Add(Val(digit))
                Next
            Next

            For Each match As Match In Regex.Matches(Seed2D.Text, "\d")
                Dim digit As Integer = Integer.Parse(match.Value)
                Dim boolValue As Boolean = (digit = 1)
                Seedv.Add(boolValue)
            Next

        Catch ex As Exception
            MsgBox("invalid input")
            Exit Sub
        End Try


        ProgressBar2D.Maximum = NotGv * 2

        Dim ToNv As SimulationNighborhood

        If VNN.Checked Then
            ToNv = SimulationNighborhood.VonNeumann
        ElseIf MN.Checked Then
            ToNv = SimulationNighborhood.Moore
        End If

        Dim FinalSilmulation = CelluarAutomataGenerator2D(WotGv, HotGv, NotGv, CoBv, CoDv, Seedv, ToNv)

        SimList2D = FinalSilmulation
        TottalStepCount.Text = (NotGv - 1).ToString
        MideaTimer.Start()

    End Sub

    Private Sub FPS_ValueChanged(sender As System.Object, e As System.EventArgs) Handles FPS.ValueChanged
        FPSL.Text = FPS.Value
    End Sub

    Dim SimulationTimer = 0
    Dim IndexChanger = 0

    Private Sub MideaTimer_Tick(sender As System.Object, e As System.EventArgs) Handles MideaTimer.Tick
        If Math.IEEERemainder(SimulationTimer, Math.Floor(1000 / FPS.Value)) = 0 Then
            SimulationTimer = 0
            Sim2D.Image = SimList2D(IndexChanger)
            SilverJuice.Width = IndexChanger / SimList2D.Count * 227
            CurrentStepIndex.Text = IndexChanger.ToString
            IndexChanger += 1
            If IndexChanger = SimList2D.Count Then IndexChanger = 0
        End If
        SimulationTimer += 1
    End Sub


    Private Sub Randomize2DButton_Click(sender As System.Object, e As System.EventArgs) Handles Randomize2DButton.Click

        ProgressBar2D.Value = 0

        Dim Randomizer As New Random

        WotG2D.Text = Randomizer.Next(1, 1001)

        HotG2D.Text = Randomizer.Next(1, 1001)

        NotG2D.Text = Randomizer.Next(1, 1001)

        If Randomizer.Next(0, 2) = 0 Then
            VNN.Checked = True
        Else
            MN.Checked = True
        End If
        Dim Con As List(Of Integer)
        Dim maxCount = 8
        If VNN.Checked Then
            Con = {0, 1, 2, 3, 4}.ToList
            maxCount = 4
        Else
            Con = {0, 1, 2, 3, 4, 5, 6, 7, 8}.ToList
        End If
        Dim CoBv = ""
        Dim CoDv = ""
        Dim UC As New List(Of Integer)
        For i = 0 To Con.Count - 1
            Dim D = Randomizer.Next(0, 3)
            If D = 0 Then
                Dim s = ""
                s += CInt(Con(i)).ToString
                CoBv += s + ", "
            ElseIf D = 1 Then
                Dim s = ""
                s += CInt(Con(i)).ToString
                CoDv += s + ", "
            Else
                UC.Add(Con(i))
            End If
        Next
        If CoBv = "" Then
            Do Until CoBv <> ""
                Dim i = Randomizer.Next(0, UC.Count)
                Dim s = ""
                s += CInt(UC(i)).ToString
                CoBv += s
            Loop
        End If
        If CoDv = "" Then
            Do Until CoDv <> ""
                Dim i = Randomizer.Next(0, UC.Count)
                Dim s = ""
                s += CInt(UC(i)).ToString
                CoDv += s
            Loop
        End If
        CoB2D.Text = CoBv
        CoD2D.Text = CoDv

        Dim Seedv = ""
        ProgressBar2D.Maximum = Val(WotG2D.Text) * Val(HotG2D.Text) - 1
        For i = 0 To Val(WotG2D.Text) * Val(HotG2D.Text) - 1
            Seedv += Randomizer.Next(0, 2).ToString
            ProgressBar2D.Value = i
        Next

        Seed2D.Text = Seedv
        ProgressBar2D.Value = 0
        Make2DButton_Click(Nothing, Nothing)

    End Sub

    Private Sub Save2D_Click(sender As System.Object, e As System.EventArgs) Handles Save2D.Click
        Dim SFD As New FolderBrowserDialog
        If SFD.ShowDialog = Windows.Forms.DialogResult.OK Then
            For i = 0 To SimList2D.Count - 1
                SimList2D(i).Save(SFD.SelectedPath + "/" + i.ToString + ".png")
            Next
            MsgBox("Saved!")
        End If
    End Sub


    Private Sub UploadImage_Click(sender As System.Object, e As System.EventArgs) Handles UploadImage.Click
        SeedProgress.Value = 0
        Dim OFD As New OpenFileDialog
        Dim img As Bitmap
        If OFD.ShowDialog = Windows.Forms.DialogResult.OK Then
            'Try
            img = Bitmap.FromFile(OFD.FileName)

            Dim TC As Color = img.GetPixel(0, 0) 'testing 
            TC = Nothing

            Seed2DBox.Text = CreateSeed(img)
            'Catch ex As Exception
            '    MsgBox("invalid File, or Unsuported form, or index based image")
            'End Try
        End If
    End Sub

    Private Sub Copy_Click(sender As System.Object, e As System.EventArgs) Handles Copy.Click
        Seed2D.Text = Seed2DBox.Text
        TabControl1.SelectTab(1)
    End Sub

    Private Sub ImportProjectToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ImportProjectToolStripMenuItem.Click
0:      Dim OFD As New OpenFileDialog With {.Filter = "CASB Project|*.CASB", .Multiselect = False}
        Dim ProjectText As String
        If OFD.ShowDialog = Windows.Forms.DialogResult.OK Then
            ProjectText = My.Computer.FileSystem.ReadAllText(OFD.FileName)
            Dim InfoList As List(Of String) = ProjectText.Split({vbNewLine}, StringSplitOptions.RemoveEmptyEntries).ToList
            Dim FilteredLines As New List(Of String)()
            For Each item As String In InfoList
                If Not String.IsNullOrWhiteSpace(item) Then
                    FilteredLines.Add(item)
                End If
            Next
            InfoList = FilteredLines

            If InfoList(0) = "Type : 1D" Then
                WotG1D.Text = InfoList(1).Substring(6)
                NotG1D.Text = InfoList(2).Substring(6)
                CoB1D.Text = InfoList(3).Substring(6)
                CoD1D.Text = InfoList(4).Substring(6)
                Seed1D.Text = InfoList(5).Substring(7)
                TabControl1.SelectedIndex = 0
            ElseIf InfoList(0) = "Type : 2D" Then
                WotG2D.Text = InfoList(1).Substring(6)
                HotG2D.Text = InfoList(2).Substring(6)
                NotG2D.Text = InfoList(3).Substring(6)
                CoB2D.Text = InfoList(4).Substring(6)
                CoD2D.Text = InfoList(5).Substring(6)
                If InfoList(6).Substring(6) = "VNN" Then
                    VNN.Checked = True
                ElseIf InfoList(6).Substring(6) = "MN" Then
                    MN.Checked = True
                Else
                    GoTo eror
                End If
                Seed2D.Text = InfoList(7).Substring(7)
                TabControl1.SelectedIndex = 1
            Else

Eror:           MsgBox("Incorrect Script")
                GoTo 0

            End If
        End If
    End Sub

    Private Sub ExportProjectToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExportProjectToolStripMenuItem.Click

        Dim SFD As New SaveFileDialog With {.Filter = "CASB Project|*.CASB"}
        Dim ProjectText As String
        If SFD.ShowDialog = Windows.Forms.DialogResult.OK Then
            If TabControl1.SelectedIndex = 0 Then
                ProjectText = "Type : 1D" + vbNewLine + "WotG : " + WotG1D.Text + vbNewLine + "NotG : " + NotG1D.Text + vbNewLine + "CoB : " + CoB1D.Text + vbNewLine + "CoD : " + CoD1D.Text + vbNewLine + "Seed : " + Seed1D.Text
                My.Computer.FileSystem.WriteAllText(SFD.FileName, ProjectText, False)
            ElseIf TabControl1.SelectedIndex = 1 Then
                Dim NhT As String
                If VNN.Checked Then NhT = "VNN" Else If MN.Checked Then NhT = "MN"
                ProjectText = "Type : 2D" + vbNewLine + "WotG : " + WotG2D.Text + vbNewLine + "HotG : " + HotG2D.Text + vbNewLine + "NotG : " + NotG2D.Text + vbNewLine + "CoB : " + CoB2D.Text + vbNewLine + "CoD : " + CoD2D.Text + vbNewLine + "NhT : " + NhT + vbNewLine + "Seed : " + Seed2D.Text
                My.Computer.FileSystem.WriteAllText(SFD.FileName, ProjectText, False)
            End If
        End If

    End Sub

    Private Sub QuitToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles QuitToolStripMenuItem.Click
        Close()
    End Sub

End Class
