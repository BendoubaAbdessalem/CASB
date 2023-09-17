Imports System.Math
Public Class CASBEngin

    Public Shared progression As Integer = 0

    Public Shared Function CelluarAutomataGenerator1D(WidthOfTheGeneration As Integer, NumberOfTheGeneration As Integer, ConditionOfBorn As List(Of List(Of Boolean)), ConditionOfDeath As List(Of List(Of Boolean)), Seed As List(Of Boolean)) As Bitmap
        'Setting the seed up

        MainSandBox.ProgressBar1D.Value = 0
        If Seed.Count > WidthOfTheGeneration Then
            For i = Seed.Count - 1 To WidthOfTheGeneration - 1 Step -1
                If i <> WidthOfTheGeneration Then Seed.RemoveAt(i) Else Exit For
            Next
        ElseIf Seed.Count < WidthOfTheGeneration Then
            For i = Seed.Count To WidthOfTheGeneration - 1
                Seed.Add(0)
            Next
        End If

        'Simulating the results

        Dim Sim As New Bitmap(WidthOfTheGeneration, NumberOfTheGeneration)
        Dim SeedMap As New List(Of List(Of Boolean))
        SeedMap.Add(Seed)
        MainSandBox.ProgressBar1D.Value += 1

        For i = 1 To NumberOfTheGeneration - 1
            Dim LastSeed = SeedMap(i - 1)
            Dim CurrnetSeed As New List(Of Boolean)

            For j = 0 To WidthOfTheGeneration - 1

                Dim ConditionCheker As New List(Of Boolean)
                CurrnetSeed.Add(LastSeed(j))

                If j - 1 = -1 Then ConditionCheker.Add(LastSeed(WidthOfTheGeneration - 1)) Else ConditionCheker.Add(LastSeed(j - 1))
                ConditionCheker.Add(LastSeed(j))
                If j + 1 = WidthOfTheGeneration Then ConditionCheker.Add(LastSeed(0)) Else ConditionCheker.Add(LastSeed(j + 1))



                If ConditionOfBorn.Any(Function(innerList) innerList.SequenceEqual(ConditionCheker)) Then CurrnetSeed(j) = True
                If ConditionOfDeath.Any(Function(innerList) innerList.SequenceEqual(ConditionCheker)) Then CurrnetSeed(j) = False

            Next
            SeedMap.Add(CurrnetSeed)
            MainSandBox.ProgressBar1D.Value += 1
        Next

        For y = 0 To NumberOfTheGeneration - 1
            For x = 0 To WidthOfTheGeneration - 1
                Dim c As Color
                If SeedMap(y)(x) = True Then c = Color.Black Else c = Color.White
                Sim.SetPixel(x, y, c)
            Next
            MainSandBox.ProgressBar1D.Value += 1
        Next
        My.Computer.Clipboard.SetImage(Sim)

        Return Sim

    End Function

    Public Enum SimulationNighborhood
        VonNeumann
        Moore
    End Enum

    Public Shared Function CelluarAutomataGenerator2D(WidthOfTheGeneration As Integer, HeightOfTheGeneration As Integer, NumberOfTheGeneration As Integer, ConditionOfBorn As List(Of Integer), ConditionOfDeath As List(Of Integer), Seed As List(Of Boolean), TypeOfNighborhood As SimulationNighborhood) As List(Of Bitmap)
        ' Setting up the seed

        MainSandBox.ProgressBar2D.Value = 0
        If Seed.Count > (WidthOfTheGeneration * HeightOfTheGeneration) Then
            For i = Seed.Count - 1 To (WidthOfTheGeneration * HeightOfTheGeneration) - 1 Step -1
                If i <> (WidthOfTheGeneration * HeightOfTheGeneration) Then Seed.RemoveAt(i) Else Exit For
            Next
        ElseIf Seed.Count < (WidthOfTheGeneration * HeightOfTheGeneration) Then
            For i = Seed.Count To (WidthOfTheGeneration * HeightOfTheGeneration) - 1
                Seed.Add(0)
            Next
        End If

        Dim MatrixSeed As New List(Of List(Of Boolean))

        Dim rowIndex As Integer = 0
        Dim colIndex As Integer = 0

        For i = 0 To HeightOfTheGeneration
            MatrixSeed.Add(New List(Of Boolean))
        Next

        For Each value As Boolean In Seed


            MatrixSeed(rowIndex).Add(value)

            colIndex += 1
            If colIndex = WidthOfTheGeneration Then
                colIndex = 0
                rowIndex += 1
            End If
            'If rowIndex = WidthOfTheGeneration Then Exit For
        Next



        'Simulating the results
        Dim Sim As New List(Of Bitmap)
        Dim MatrixMedia As New List(Of List(Of List(Of Boolean)))

        MatrixMedia.Add(MatrixSeed)
        MainSandBox.ProgressBar2D.Value += 1

        Dim SimSeed As New Bitmap(WidthOfTheGeneration, HeightOfTheGeneration)
        For y = 0 To HeightOfTheGeneration - 1
            For x = 0 To WidthOfTheGeneration - 1
                If y = 2 And x = 4 Then
                    x = x
                End If
                If MatrixSeed(y)(x) = True Then
                    SimSeed.SetPixel(x, y, Color.Black)
                ElseIf MatrixSeed(y)(x) = False Then
                    SimSeed.SetPixel(x, y, Color.White)
                End If

            Next
        Next

        Sim.Add(SimSeed)

        For t = 1 To NumberOfTheGeneration - 1
            Dim LastMatrix = MatrixMedia(t - 1)
            Dim CurrentMatrix As New List(Of List(Of Boolean))

            For y = 0 To HeightOfTheGeneration - 1

                y = y ' 2 
                Dim CurentLine As New List(Of Boolean)
                CurrentMatrix.Add(CurentLine)
                For x = 0 To WidthOfTheGeneration - 1
                    x = x ' 4
                    Dim ConditionCheker As New List(Of List(Of Boolean))
                    Dim Lx = x - 1
                    If Lx < 0 Then Lx = WidthOfTheGeneration - 1

                    Dim Uy = y - 1
                    If Uy < 0 Then Uy = HeightOfTheGeneration - 1

                    Dim Rx = x + 1
                    If Rx > WidthOfTheGeneration - 1 Then Rx = 0

                    Dim Dy = y + 1
                    If Dy > HeightOfTheGeneration - 1 Then Dy = 0

                    If TypeOfNighborhood = SimulationNighborhood.Moore Then
                        ConditionCheker.Add({LastMatrix(Uy)(Lx), LastMatrix(Uy)(x), LastMatrix(Uy)(Rx)}.ToList)
                        ConditionCheker.Add({LastMatrix(y)(Lx), LastMatrix(y)(Rx)}.ToList)
                        ConditionCheker.Add({LastMatrix(Dy)(Lx), LastMatrix(Dy)(x), LastMatrix(Dy)(Rx)}.ToList)
                    ElseIf TypeOfNighborhood = SimulationNighborhood.VonNeumann Then
                        ConditionCheker.Add({LastMatrix(Uy)(x)}.ToList)
                        ConditionCheker.Add({LastMatrix(y)(Lx), LastMatrix(y)(Rx)}.ToList)
                        ConditionCheker.Add({LastMatrix(Dy)(x)}.ToList)
                    End If


                    Dim CellCounter As Integer = 0

                    For Each Line In ConditionCheker
                        For Each Value As Boolean In Line
                            If Value = True Then CellCounter += 1
                        Next
                    Next

                    If ConditionOfBorn.Contains(CellCounter) Then
                        CurrentMatrix(y).Add(True)
                    ElseIf ConditionOfDeath.Contains(CellCounter) Then
                        CurrentMatrix(y).Add(False)
                    Else
                        CurrentMatrix(y).Add(LastMatrix(y)(x))
                    End If
                Next

            Next

            MatrixMedia.Add(CurrentMatrix)
            MainSandBox.ProgressBar2D.Value += 1

            Dim Instant As New Bitmap(WidthOfTheGeneration, HeightOfTheGeneration)
            For y = 0 To HeightOfTheGeneration - 1
                For x = 0 To WidthOfTheGeneration - 1
                    If y = 2 And x = 4 Then
                        x = x
                    End If
                    If MatrixMedia(t)(y)(x) = True Then
                        Instant.SetPixel(x, y, Color.Black)
                    ElseIf MatrixMedia(t)(y)(x) = False Then
                        Instant.SetPixel(x, y, Color.White)
                    End If

                Next
            Next

            Sim.Add(Instant)
            MainSandBox.ProgressBar2D.Value += 1
        Next


        Return Sim
    End Function

    Public Shared Function CreateSeed(Input As Bitmap) As String
        Dim Output As String = ""
        MainSandBox.SeedProgress.Maximum = (Input.Width) * (Input.Height)
        For y = 0 To Input.Height - 1
            For x = 0 To Input.Width - 1
                Dim c As Color = Input.GetPixel(x, y)
                Dim Luma As Double = c.R / 255 * 0.299 + 0.587 * c.G / 255 + 0.114 * c.B / 255
                If Luma < 0.5 Then Output += "1" Else Output += "0"
                MainSandBox.SeedProgress.Value += 1
            Next
        Next
        Return Output
    End Function
End Class
