Imports Windows.Storage
Imports Windows.UI.Xaml
Imports Windows.UI.Xaml.Shapes
Imports Windows.UI.Xaml.Controls
Imports Windows.UI.Xaml.Documents
Imports Windows.Networking.Connectivity
Imports Windows.ApplicationModel.Email
Imports Windows.ApplicationModel.Resources
Imports Windows.UI : Imports Windows.UI.Text
#Region "Calcultorwindow"
'بِسْمِ اللَّهِ الرَّحْمَـٰنِ الرَّحِيمِ
#End Region
Public NotInheritable Class MainPage
  Inherits Page
#Region "≡≡≡≡"
#Region "A-01"
  ' Controlls
  Dim AA_, AB_ As New Line ' Text Kursor in B111
  Dim BA_ As New Button ' Chemisches Element
  Dim CA_ As New Canvas ' Border Canvas leer
  Dim DA_ As New ListView ' Chemische Liste
  Dim EA_, EB_ As New TextBlock ' Periodentabelle
  Dim FA_, FB_ As New TextBox ' Math - Classic
#End Region
#Region "A-02"
  ' Klassen
  Dim A_A As New ResourceLoader("A_a_a_a_a")
  Dim A_B As New ResourceLoader("A_a_a_a_b")
  Dim A_C As New ResourceLoader("A_b_a_a_a")
  Dim A_D As New ResourceLoader("Resources")
  Dim A_E As New ResourceLoader("Source_aa")
#End Region
#Region "A-10"
  ' Allgemein
  Dim AAA As Byte ' Quer-Hochformat Nummer
  Dim AAB As Byte ' Design Seiten Nummer
  Dim AAC As Byte ' A Board Umschalte Zahl
  Dim AAD As Byte ' B Board Umschalte Zahl
  Dim AAE As Byte ' Farben Nummer für ADAB
  Dim AAF As Byte ' Farben Nummer für ADAB
  Dim AAG As Byte ' Farben Nummer für ADAB

  Dim ABA As String ' Listen Text Substring

  Dim ACA, ACB As Integer
  Dim ADA() As String
  Dim AEA, AEB As DispatcherTimer
  ' Mathematik
  Dim BAA As Boolean
  Dim BBA As Integer ' x Position Kursor B111
  Dim BBB As Integer ' y Position Kursor B111
  Dim BBC As Integer ' x Position Kursor FA_
  Dim BBD As Integer ' Text Länge alt von FA_
  Dim BBE As Integer ' Text Länge neu von FA_
  Dim BBF As Integer ' Schichte des Substrings

  Dim BEA As String ' Text alt von FA_
  Dim BEB As String ' Text neu von FA_
  Dim BEC As String ' Substring von FA_
  Dim BED As String ' Substring von FA_

  Dim BCA, BCB, BCC As New List(Of Byte)
  Dim BDA, BDB As New List(Of Integer)



  Private IAB As New List(Of Byte) ' M:Ausgangsoperatorengruppe

  Private ReadOnly KAH As New List(Of String) ' M:Term
  Private ReadOnly KAI As New List(Of String) ' M:Operator

  Private ReadOnly MAA As New List(Of Integer) ' M:Liste von BBF
  Private ReadOnly MAC As New List(Of Integer) ' M:Eingangsanfang
  Private ReadOnly MAD As New List(Of Integer) ' M:Eingangslänge

  Dim sss As New TextBlock


  ' Chemie
  Dim CAA As String
  ' ΔΓΘΛΞΠΣΦΨΩͲ БЗЛУЧЪЬЭЯѰԱԲԳԴϞԵԶԷԸԹԻԺԽԾԿՀՁՂՃՄՅՆՇՈՉՊՋՌՎՐՑՒՔՖ
  ' ႠႡႢႣႤႥႦႧႨႩႪႫႬႯႰႱႲႳႴႵႶႷႸႹႺႼႻႾႿჀჁჂჃჄჅ ჇꓕႮꓘꓛꓞꓤꓨꓩꓭꓯꓱꓶꓷ
#End Region
#Region "A-11"
  Dim title = ApplicationView.GetForCurrentView().TitleBar
#End Region
#End Region
#Region "○○○○"
#Region "AAA0"
  Private Sub A_A_() Handles AAA0.Loaded
    ' Loaded
    Try
      title.ButtonPressedForegroundColor = Colors.Pink : title.ButtonHoverForegroundColor = Colors.Pink

      ToolTipService.SetToolTip(A101, New ToolTip With {.Content = A_D.GetString("A001"), .Placement = PlacementMode.Bottom})
      ToolTipService.SetToolTip(A102, New ToolTip With {.Content = A_D.GetString("A002"), .Placement = PlacementMode.Bottom})
      ToolTipService.SetToolTip(A103, New ToolTip With {.Content = A_D.GetString("A003"), .Placement = PlacementMode.Bottom})
      ToolTipService.SetToolTip(A104, New ToolTip With {.Content = A_D.GetString("A004"), .Placement = PlacementMode.Bottom})
      ToolTipService.SetToolTip(A105, New ToolTip With {.Content = A_D.GetString("A005"), .Placement = PlacementMode.Bottom})
      ToolTipService.SetToolTip(A106, New ToolTip With {.Content = A_D.GetString("A006"), .Placement = PlacementMode.Bottom})
      ToolTipService.SetToolTip(A107, New ToolTip With {.Content = A_D.GetString("A007"), .Placement = PlacementMode.Bottom})
      ToolTipService.SetToolTip(A108, New ToolTip With {.Content = A_D.GetString("A008"), .Placement = PlacementMode.Bottom})

      AEA = New DispatcherTimer With {.Interval = TimeSpan.FromMilliseconds(500)} : AddHandler AEA.Tick, AddressOf ACAC
      AEB = New DispatcherTimer With {.Interval = TimeSpan.FromMilliseconds(500)} : AddHandler AEB.Tick, AddressOf ACAD

      A109.Content = "A1" : A110.Content = "B1" : Ϟ101.Text = A_D.GetString("A201") : Ϟ102.Text = A_D.GetString("A202")
      C126.Content = A_D.GetString("A254") : AA00.Children.Add(CA_) : Ϟ101.Opacity = 0.5 : Ϟ102.Opacity = 0.5

      AA00.Children.Add(FA_) : FA_.MaxHeight = 0 : FA_.MaxWidth = 0 : Ξ101.Children.Add(AA_) : AA_.StrokeThickness = 1
      AA00.Children.Add(FB_) : FB_.MaxHeight = 0 : FB_.MaxWidth = 0 : Ξ102.Children.Add(AB_) : AB_.StrokeThickness = 1

      If ApplicationData.Current.LocalSettings.Values("upgrade") <> "18.02.2022" Then
        Ϟ104.FontFamily = New FontFamily("Segoe UI") : Ϟ104.Text = A_D.GetString("A900")

        'ABAD(5) : ABAE(Colors.White, Colors.Lime, A_D.GetString("E001") & vbCrLf)
        'ABAD(5) : ABAE(Colors.White, Colors.Black, A_E.GetString("A002"))
      End If

      For i = 1 To 5 Step 1 : AA00.RowDefinitions.Add(New RowDefinition) : Next
      For i = 1 To 12 Step 1 : A100.ColumnDefinitions.Add(New ColumnDefinition) : Next
      For i = 1 To 3 Step 1 : B100.RowDefinitions.Add(New RowDefinition) : Next
      For i = 1 To 5 Step 1 : B100.ColumnDefinitions.Add(New ColumnDefinition) : Next
      For i = 1 To 4 Step 1 : C100.RowDefinitions.Add(New RowDefinition) : Next
      For i = 1 To 21 Step 1 : C100.ColumnDefinitions.Add(New ColumnDefinition) : Next

      AAA = 0 : Do ' AAA0 Size Changed => AAA
        AAB += 1
        Grid.SetRow(C100.Children.Item(AAA), AAC) : Grid.SetColumn(C100.Children.Item(AAA), AAB)
        AAA += 1
        If AAB = 4 Or AAB = 9 Or AAB = 14 Or AAB = 19 Then : AAB = If(AAC = 3, AAB + 1, AAB - 4)
          AAC += 1 : End If
        If AAC = 4 Then : If AAB = 20 Then : Exit Do : Else : AAC = 0 : End If : End If : Loop

      Grid.SetRow(B100, 2) : Grid.SetRow(B300, 2) : Grid.SetRow(C100, 4) : Grid.SetRow(Հ101, 0)
      Grid.SetRow(Հ102, 2) : Grid.SetRow(Հ104, 2) : Grid.SetRow(Ξ100, 0)

      Grid.SetColumn(A101, 1) : Grid.SetColumn(A102, 2) : Grid.SetColumn(A103, 3) : Grid.SetColumn(A104, 4)
      Grid.SetColumn(A105, 5) : Grid.SetColumn(A106, 6) : Grid.SetColumn(A107, 7) : Grid.SetColumn(A108, 8)
      Grid.SetColumn(A109, 9) : Grid.SetColumn(A110, 10) : Grid.SetColumn(Հ103, 3) : Grid.SetColumn(Հ102, 1)
      Grid.SetColumn(Հ104, 3) : Grid.SetColumn(Ξ100, 1) : Grid.SetRowSpan(Ξ100, 3) : Grid.SetColumnSpan(Ξ100, 3)

      AddHandler Հ101.Tapped, AddressOf ACAA : AddHandler Հ102.Tapped, AddressOf ACAB
      AddHandler FA_.TextChanged, AddressOf ACBA : AddHandler FA_.SelectionChanged, AddressOf ACCA
      AddHandler FB_.TextChanged, AddressOf ACBB : AddHandler FB_.SelectionChanged, AddressOf ACCB

      FA_.Focus(3) : AAB = 1 : AADA() : AADB() : AADC() : A_B_() : Catch ex As Exception : Ϟ104.Text = ex.Message
    End Try
  End Sub
  Private Sub A_B_() Handles AAA0.SizeChanged
    ' Size Changed
    Try : If AAA0.ActualWidth > 1.5 * AAA0.ActualHeight Then
        If AAA <> 1 Then : AAA = 1 : End If : AAAA() : Else
        If AAA <> 2 Then : AAA = 2 : End If : AAAA() : End If
    Catch ex As Exception : Ϟ104.Text = ex.Message : End Try
  End Sub
#End Region
#Region "A100"
  Private Sub A_AA()
    AAB = 1 : AAAA()
  End Sub
  Private Sub A_AB()
    AAB = 2 : AAAA() : AEA.Stop() : AEB.Stop()
  End Sub
  Private Sub A_AC()

    CA_.Background = New SolidColorBrush(ADAB(AAE))
  End Sub
  Private Sub A_AD()

    CA_.Background = New SolidColorBrush(ADAB(AAE))
  End Sub
  Private Sub A_AE()

    CA_.Background = New SolidColorBrush(ADAB(AAE))
  End Sub
  Private Sub A_AF()

    CA_.Background = New SolidColorBrush(ADAB(AAE))
  End Sub
  Private Sub A_AG()

    CA_.Background = New SolidColorBrush(ADAB(AAE))
  End Sub
  Private Sub A_AH()

    CA_.Background = New SolidColorBrush(ADAB(AAE))
  End Sub
  Private Sub A_AI()
    AACA()
  End Sub
  Private Sub A_AJ()
    AACB()
  End Sub
#End Region
#Region "B100"
  Private Sub B_AA() ' sender As AutoSuggestBox, e As AutoSuggestBoxTextChangedEventArgs
    'Try
    '  Dim aaaab As New List(Of String)
    '  '1     Löschen alter Definitionen
    '  AEAX() : If B101.Text = "" Then Exit Sub
    '  '2     Autosuggestboxsplit
    '  FAA = B101.Text.TrimEnd(" ").Split(" ")
    '  '4     Gleichung-Platz-Zeiger
    '  If B101.Text.Length > 1 Then
    '    Select Case B101.Text.Substring(0, 2)
    '      Case A_D.GetString("B001"), A_D.GetString("B002")
    '        Ϟ102.PlaceholderText = A_D.GetString("A051")
    '    End Select
    '  End If
    '  '5     Formelsuche
    '  If FAA.Count > 0 Then EAAA() : EAAB()
    '  '6     Filterung der Kods nach eingegebene Zeichen
    '  If CAI <> "" Then
    '    For i = 0 To FAC.Count - 5 Step 5
    '      If FAC(i).Length >= B101.Text.Length Then
    '        If B101.Text = FAC(i).Substring(0, B101.Text.Length) Then aaaab.Add(FAC(i))
    '      End If
    '    Next
    '  End If
    '  '7     Auswahl eines Vorschlags
    '  If e.Reason = AutoSuggestionBoxTextChangeReason.UserInput Then
    '    If aaaab.Count > 0 Then
    '      sender.ItemsSource = aaaab
    '      If B101.Text = aaaab(0) Then sender.ItemsSource = Nothing
    '    End If
    '    If B101.Text.Length = 0 Then sender.ItemsSource = Nothing
    '    If aaaab.Count = 0 Then sender.ItemsSource = Nothing
    '  End If
    'Catch ex As Exception
    '  Ϟ104.Document.SetText(TextSetOptions.FormatRtf, "")
    '  Ϟ104.Document.Selection.Text = A_D.GetString("A151") & " A1"
    '  'B004.Document.Selection.Text += ex.HelpLink & vbCrLf
    '  'B004.Document.Selection.Text += ex.Message & vbCrLf
    '  'B004.Document.Selection.Text += ex.Source & vbCrLf
    '  'B004.Document.Selection.Text += ex.StackTrace & vbCrLf
    'End Try
  End Sub
#End Region
#Region "B200"
  Private Sub B_BA()
    ApplicationData.Current.LocalSettings.Values("upgrade") = "xxxx"
    Ϟ104.FontFamily = New FontFamily("Segoe UI") : AAB = 3 : AAAA()
    Ϟ104.Text = ""
    Ϟ104.Inlines.Add(New Run With {.Text = A_D.GetString("A000") & vbLf,
                     .Foreground = New SolidColorBrush(Colors.Blue)})
    Ϟ104.Inlines.Add(New Run With {.Text = vbLf & A_E.GetString("A001") &
                     vbLf & vbLf,
                     .Foreground = New SolidColorBrush(Colors.Black)})
    Ϟ104.Inlines.Add(New Run With {.Text = A_D.GetString("E001") & vbLf,
                     .Foreground = New SolidColorBrush(Colors.Lime)})
    Ϟ104.Inlines.Add(New Run With {.Text = vbLf & A_E.GetString("A002"),
                     .Foreground = New SolidColorBrush(Colors.Black)})
  End Sub
  Private Sub B_BB()

    'AAB = 3 : AAAA() : ABAD(0) : Ϟ104.FontFamily = New FontFamily("Consolas") : ABA = "				"
    'ABAE(Colors.AliceBlue, Colors.Blue, A_D.GetString("E002") & vbLf & vbLf & vbLf)
    'ABAE(Colors.AliceBlue, Colors.Blue, A_D.GetString("E201") & ABA & A_D.GetString("E202") & vbLf & vbLf)
    'ABA = "					"
    'ACA = 14 : ACB = 13 : ABAE(Colors.AliceBlue, Colors.Blue, "ab" & ABA & "a ^ b" & vbLf & vbLf) : ABAA()
    'ACA = 19 : ACB = 18 : ABAE(Colors.AliceBlue, Colors.Blue, "b√a" & ABA & "√(a ' b)" & vbLf & vbLf) : ABAA()
    'ACA = 20 : ACB = 19 : ABAE(Colors.AliceBlue, Colors.Blue, "logab" & ABA & "log(a ' b)" & vbLf & vbLf) : ABAB()
    'ACA = 20 : ACB = 19 : ABAE(Colors.AliceBlue, Colors.Blue, "limab" & ABA & "lim(a ' b)" & vbLf & vbLf) : ABAB()
    'ACA = 24 : ACB = 23 : ABAE(Colors.AliceBlue, Colors.Blue, "Ʃab c" & ABA & "Ʃ(a ' b ' c)" & vbLf & vbLf) : ABAB()
    'ACA = 23 : ACB = 24 : ABAA()
    'ACA = 24 : ACB = 23 : ABAE(Colors.AliceBlue, Colors.Blue, "∏ab c" & ABA & "∏(a ' b ' c)" & vbLf & vbLf) : ABAB()
    'ACA = 33 : ACB = 32 : ABAA() : ABA = "				"
    'ACA = 30 : ACB = 29 : ABAE(Colors.AliceBlue, Colors.Blue, "a∫b x dx" & ABA & "∫(a ' b ' x d(x))") : ABAB()
    'ACA = 28 : ACB = 27 : ABAA()
  End Sub
  Private Sub B_BC()
  End Sub
  Private Sub B_BD()
    AAB = 7 : B500.Visibility = 0 : B100.Visibility = 1 : B200.Visibility = 1 : AADA()

    If B500.RowDefinitions.Count > 0 Then : Exit Sub : End If : Grid.SetRow(B500, 2)

    If ApplicationData.Current.LocalSettings.Values("textstyle") = "." Then B511.IsOn = True
    If ApplicationData.Current.LocalSettings.Values("frameview") = "." Then B512.IsOn = True
    If ApplicationData.Current.LocalSettings.Values("lightness") = "." Then B513.IsOn = True

    B511.OffContent = A_D.GetString("E202") : B511.OnContent = A_D.GetString("E201")
    B512.OffContent = A_D.GetString("E251") : B512.OnContent = A_D.GetString("E252")
    B513.OffContent = A_D.GetString("E253") : B513.OnContent = A_D.GetString("E254")

    B500.RowDefinitions.Add(New RowDefinition) : B500.RowDefinitions.Add(New RowDefinition)
    B500.RowDefinitions.Add(New RowDefinition) : B500.RowDefinitions.Add(New RowDefinition)
    B500.RowDefinitions.Add(New RowDefinition) : B500.RowDefinitions.Add(New RowDefinition)
    B500.RowDefinitions.Add(New RowDefinition) : B500.RowDefinitions.Add(New RowDefinition)

    B500.ColumnDefinitions.Add(New ColumnDefinition) : B500.ColumnDefinitions.Add(New ColumnDefinition)
    B500.ColumnDefinitions.Add(New ColumnDefinition) : B500.RowDefinitions.Add(New RowDefinition)

    Grid.SetRow(B511, 0) : Grid.SetColumn(B511, 1) : Grid.SetRow(B512, 1) : Grid.SetColumn(B512, 1)
    Grid.SetRow(B513, 2) : Grid.SetColumn(B513, 1) : Grid.SetRow(B501, 3) : Grid.SetColumn(B501, 1)
    Grid.SetRow(B502, 4) : Grid.SetColumn(B502, 1) : Grid.SetRow(B503, 5) : Grid.SetColumn(B503, 1)
    Grid.SetRow(B504, 6) : Grid.SetColumn(B504, 1) : Grid.SetRow(B505, 7) : Grid.SetColumn(B505, 1)
    Grid.SetRow(B506, 8) : Grid.SetColumn(B506, 1)

    B500.ColumnDefinitions.Item(0).Width = New GridLength(0.2, 2)

    B501.Margin = New Thickness(10) : B502.Margin = New Thickness(10) : B503.Margin = New Thickness(10)
    B504.Margin = New Thickness(10) : B505.Margin = New Thickness(10) : B506.Margin = New Thickness(10)
    B511.Margin = New Thickness(10) : B512.Margin = New Thickness(10) : B513.Margin = New Thickness(10)

    B506.Background = New SolidColorBrush(Colors.Blue) : B502.Background = New SolidColorBrush(Colors.SkyBlue)
    B503.Background = New SolidColorBrush(Colors.Gold) : B504.Background = New SolidColorBrush(Colors.Magenta)
    B505.Background = New SolidColorBrush(Colors.Lime) : B501.Background = New SolidColorBrush(Colors.AliceBlue)
  End Sub
  Private Sub B_BE()
    Try : AEAA() : Catch ex As Exception : End Try
  End Sub
  Private Sub B_BF()
    '    AAB = 3 : AAAA() : ABAD(5) : Ϟ104.FontFamily = New FontFamily("Consolas")
    '    ' Mathematik - Formeln
    '    ABAE(Colors.AliceBlue, Colors.Blue, "   " & A_D.GetString("E003") & "   " & vbLf & vbLf)
    '    ABAE(Colors.White, Colors.Green, A_D.GetString("E101") & vbLf)
    '    ABAE(Colors.White, Colors.Blue, "a = a" & vbLf & vbLf)
    '    ABAE(Colors.White, Colors.Green, A_D.GetString("E102") & vbLf)
    '    ABAE(Colors.White, Colors.Blue, "a = b" & vbLf & vbLf)
    '    ABAE(Colors.White, Colors.Blue, "a = b" & vbLf & vbLf)
    '    ABAE(Colors.White, Colors.Green, A_D.GetString("E103") & vbLf)
    '    ABAE(Colors.White, Colors.Blue, "e = 2,718281828" & vbLf & vbLf)
    '    ABAE(Colors.White, Colors.Green, A_D.GetString("E104") & vbLf)
    '    ABAE(Colors.White, Colors.Blue, "π = 3,141592654" & vbLf & vbLf)
    '    ABAE(Colors.White, Colors.Green, A_D.GetString("E105") & vbLf)
    '    ABAE(Colors.White, Colors.Blue, "(a) = a
    'a + (b +- c) = a + b +- c
    'a - (b +- c) = a - b -+ c
    'a · (b ·: c) = a · b ·: c
    'a : (b ·: c) = a : b :· c" & vbLf & vbLf)
    '    ABAE(Colors.White, Colors.Green, A_D.GetString("E106") & vbLf)
    '    ABAE(Colors.White, Colors.Blue, "|-a| = |a|
    '|a| = a    a ≥ 0
    '|a| = -a   a < 0" & vbLf & vbLf)
    '    ABAE(Colors.White, Colors.Green, A_D.GetString("E107") & vbLf)
    '    ABAE(Colors.White, Colors.Blue, "a +- 0 = a
    'a · 0 = 0
    'a ^ 0 = 1
    'a / 0 = ∞" & vbLf & vbLf)
    '    ABAE(Colors.White, Colors.Green, A_D.GetString("E108") & vbLf)
    '    ABAE(Colors.White, Colors.Blue, "a ·: 1 = a
    'a ^ 1 = a" & vbLf & vbLf)
    '    ABAE(Colors.White, Colors.Green, A_D.GetString("E109") & vbLf)
    '    ABAE(Colors.White, Colors.Blue, "a - a = 0
    'a / a = 1" & vbLf & vbLf)
    '    ABAE(Colors.White, Colors.Green, A_D.GetString("E110") & vbLf)
    '    ABAE(Colors.White, Colors.Blue, "a + -b = a - b
    'a - -b = a + b
    '-a ·: -b = a ·: b
    'a ·: -b = -a ·: b" & vbLf & vbLf)
    '    ABAE(Colors.White, Colors.Green, A_D.GetString("E111") & vbLf)
    '    ABAE(Colors.White, Colors.Blue, "cos(a) = b
    'sin(a) = b
    'tan(a) = b
    'cot(a) = b
    'acos(a) = b
    'asin(a) = b
    'atan(a) = b
    'acot(a) = b" & vbLf & vbLf)
    '    ABAE(Colors.White, Colors.Green, A_D.GetString("E112") & vbLf)
    '    ABAE(Colors.White, Colors.Blue, "ln(a) = b
    'ln(e) = 1
    'log(a ' b) = с" & vbLf & vbLf)
    '    ABAE(Colors.White, Colors.Green, A_D.GetString("E113") & vbLf)
    '    ABAE(Colors.White, Colors.Blue, "a! = a · (a - 1) · ... · 1    a < 170" & vbLf & vbLf)
    '    ABAE(Colors.White, Colors.Green, A_D.GetString("E114") & vbLf)
    '    ABAE(Colors.White, Colors.Blue, "a´ = 0" & vbLf & vbLf)
    '    ABAE(Colors.White, Colors.Green, A_D.GetString("E115") & vbLf)
    '    ABAE(Colors.White, Colors.Blue, "a´ = 0" & vbLf & vbLf)
    '    ABAE(Colors.White, Colors.Gray, A_D.GetString("A900") & vbLf & "b + a = a + b
    'b · a = a · b
    '(a + b) · c = a · c + b · c
    '(a + b) : c = a : c + b : c
    '(a - b) · c = a · c - b · c
    '(a - b) : c = a : c - b : c
    '(a + b) · (c + d) = a c + a d + b c + b d
    'a + a = a · (1 + 1)
    'a · c + b · c = (a + b) · c
    'a ± b : c = (a c ± b) / c
    'a : b ± c = (a ± c b) / b
    'a : b ± c : b = (a ± c) / b
    'a : b ± c : d = (a d ± c b) / b : d
    'a · a = a ^ 2
    'a ^ b ^ c = a ^ (b · c)
    'a ^ b ·: a ^ c = a ^ (b ± c)
    'a ^ (b +- c) = a ^ b ·: a ^ c
    'a ^ b ^ c = a ^ (b · c)
    '(a ·: b) ^ c = a ^ c ·: b ^ c
    'a ^ b = c => a = √(c ' b)
    'a ^ (b ± c) = a ^ b ·: a ^ c
    'a ^ c ·: b ^ c = (a ·: b) ^ c
    '(a ·: b) ^ c = a ^ c ·: b ^ c
    'a ^ -b = 1 : a ^ b
    'a ^ b = 1 : a ^ -b
    'a ˄ (b ·: c) = a ˄ b ˄˅ c
    '√(a ·: b) = √(a) ·: √(b)
    '√(a) ·: √(b) = √(a ·: b)
    '√(a ·: b ' c) = √(a ' c) ·: √(b ' c)
    '√(a ' c) ·: √(b ' c) = √(a ·: b ' c)
    '√(a ' c) = a ^ (1 : c)
    'lim(a → ∞ ' b ^ a) = 0, |b| < 1
    'log(a ' b) = ln(b) : ln(a)
    'Ʃ(a = 1 ' b ' a) = b (b + 1) : 2
    'Ʃ(a = 1 ' b ' a ^ 2) = (2 b ^ 3 + 3 b ^ 2 + b) : 6
    'Ʃ(a = 1 ' b ' a ^ 3) = (b ^ 4 + 2 b ^ 3 + b ^ 2) : 4
    'Ʃ(a = 0 ' b ' c ^ a) = (1 - c ^ (b + 1)) : (1 - c)
    '∏(a = 1 ' b ' a) = b!
    'ʃ(a ' b ' c · d(c)) = (b ^ 2 - a ^ 2) : 2
    'a = b +- c => a -+ c = b
    'a = b ·: c => a :· c = b
    'a = b +· c => a -: b = c
    'a = b -: c => b -: a = c
    'a +- b = c => a = c -+ b
    'a ·: b = c => a = c :· b
    'a +· b = c => b = c -: a
    'a -: b = c => b = a -: c
    '-a = b => a = -b
    'a ^ 2 b + a c + d = 0 => a = (-c ± √ (c ^ 2 - 4 a d)) : 2 : b
    'a ^ b = e ^ (b · ln(a))
    'e ^ ln(a) = a
    'log(a ' b · c) = log(a ' b) + log(a ' c)
    'ln(a ·: b) = ln(a) +- ln(b)
    'ln(a ^ b) = b · ln(a)
    'ln(e ^ a) = a")
    '_EA = Color.FromArgb(255, 0, 176, 80)
    'Ϟ104.Document.Selection.CharacterFormat.Weight = 0
  End Sub
  Private Sub B_BG()
    'AAB = 3 : AAAA() : ABAD(5) : Ϟ104.FontFamily = New FontFamily("Consolas")
    '' Chemie - Formeln
    'ABAE(Colors.AliceBlue, Colors.Blue, "   " & A_D.GetString("E004") & "   " & vbLf &
    '     vbLf) : ABAE(Colors.White, Colors.Green, "c = n / V" & vbLf & "M = m / n")
  End Sub
  Private Sub B_BH()
    '    AAB = 3 : AAAA() : ABAD(10) : Ϟ104.FontFamily = New FontFamily("Consolas")
    '    ' Physik - Formeln
    '    ABAE(Colors.AliceBlue, Colors.Blue, "   " & A_D.GetString("E005") & "   " & vbLf & vbLf)
    '    ABAE(Colors.White, Colors.Green, A_D.GetString("A109") & vbLf)
    '    ABAE(Colors.White, Colors.DarkViolet, "a = Δv / Δt
    'ΔEk = Ek2 - Ek1
    'ΔEp = Ep2 - Ep1
    'F = a m
    'Ff = k Δs
    'Frg = μg |Fn|
    'Frh = μh |Fn|
    'Frr = μr |Fn|
    'P = W / Δt
    'p = m v
    'Δs = s2 - s1
    'Δt = t2 - t1
    'v = Δs / Δt
    'Δv = v2 - v1
    'Δv {v} = (v2 ^ 2 - v1 ^ 2)/2
    '{v} = Δs / Δt
    '{v} = (v1 + v2) / 2
    'W = F Δs
    'W = ΔEk
    'W = -ΔEp" & vbLf & vbLf)
    '    ABAE(Colors.White, Colors.Green, A_D.GetString("E051") & vbLf)
    '    ABAE(Colors.White, Colors.DarkViolet, "A = Ax
    'A = Ay
    'A = Az
    'A = Ax : cos(θ)
    'A = Ay : sin(θ)
    'A = Az : cos(θ)
    'A = Ax : cos(θ) : sin(ϕ)
    'A = Az : cos(θ) : cos(ϕ)
    'A = √(Ax2 + Ay2)
    'A = √(Ax2 + Az2)
    'A = √(Ay2 + Az2)
    'A = √(Ax2 + Ay2 + Az2)")
  End Sub
  Private Sub B_BI()
    'AAB = 3 : AAAA() : ABAD(10) : Ϟ104.FontFamily = New FontFamily("Consolas")
    '' Dimensionen
    'ABAE(Colors.AliceBlue, Colors.Blue, "   " & A_D.GetString("A109") & "   " & vbLf & vbLf)
    'For i = 1 To 87 Step 1 : ABA = If(i < 10, "00", "0") & CStr(i)
    '  ABAE(Colors.White, Colors.Blue, (A_C.GetString("B" & ABA) & "       ").Substring(0, 8))
    '  ABAE(Colors.White, Colors.DeepSkyBlue, A_D.GetString("C" & ABA) & vbLf) : Next
  End Sub
  Private Sub B_BJ()
    AAB = 5 : AAAA()
  End Sub
#End Region
#Region "C100"
  Private Sub C_AA(a As Button, b As RoutedEventArgs)
    'If ABB = "B101" Then : B101.Text = B101.Text.Insert(B101.SelectionStart, a.Content)
    'ElseIf ABB = "B111" Then : FA_.Document.Selection.Text += a.Content
    'ElseIf ABB = "Ϟ102" Then : Ϟ102.Document.Selection.Text += a.Content : End If
  End Sub
  Private Sub C_AB(a As Button, b As RoutedEventArgs)
    'If ABB = "B101" Then : B101.Text = B101.Text.Insert(B101.SelectionStart, "‐")
    'ElseIf ABB = "B111" Then : FA_.Document.Selection.Text += "‐"
    'ElseIf ABB = "Ϟ102" Then : Ϟ102.Document.Selection.Text += "‐" : End If
  End Sub
  Private Sub C_AC(a As Button, b As RoutedEventArgs)
    'If ABB = "B101" Then : B101.Text = B101.Text.Insert(B101.SelectionStart, a.Content & "()")
    'ElseIf ABB = "B111" Then : FA_.Document.Selection.Text += a.Content & "()"
    'ElseIf ABB = "Ϟ102" Then : Ϟ102.Document.Selection.Text += a.Content & "()" : End If
  End Sub
  Private Sub C_AD(a As Button, b As RoutedEventArgs)
    'If ABB = "B101" Then : B101.Text = B101.Text.Insert(B101.SelectionStart, a.Content & "(')")
    'ElseIf ABB = "B111" Then : FA_.Document.Selection.Text += a.Content & "(')"
    'ElseIf ABB = "Ϟ102" Then : Ϟ102.Document.Selection.Text += a.Content & "(')" : End If
  End Sub
  Private Sub C_AE(a As Button, b As RoutedEventArgs)
    'If ABB = "B101" Then : B101.Text = B101.Text.Insert(B101.SelectionStart, a.Content & "('')")
    'ElseIf ABB = "B111" Then : FA_.Document.Selection.Text += a.Content & "('')"
    'ElseIf ABB = "Ϟ102" Then : Ϟ102.Document.Selection.Text += a.Content & "('')" : End If
  End Sub
  Private Sub C_AF(a As Button, b As RoutedEventArgs)
    'If ABB = "B101" Then : B101.Text = B101.Text.Insert(B101.SelectionStart, a.Content & "(''d())")
    'ElseIf ABB = "B111" Then : FA_.Document.Selection.Text += a.Content & "(''d())"
    'ElseIf ABB = "Ϟ102" Then : Ϟ102.Document.Selection.Text += a.Content & "(''d())" : End If
  End Sub
#End Region
#End Region
#Region "□□□□"
#Region "AAAA"
#Region "A-AA"
  Private Sub AAAA()
    ' Quer-Hoch-Formaten-Seiten
    Select Case 100 * AAA + AAB
      Case = 101 ' Q-Start
#Region ""
        ' H-S => Q-S : Q-A° => Q-S
        AAAB() : Grid.SetColumn(Հ101, 1) : Grid.SetRow(Հ103, 0)
        AABA()
        B100.RowDefinitions.Item(1).Height = New GridLength(0, 2)
        B100.ColumnDefinitions.Item(1).Width = New GridLength(6, 2)
        B100.ColumnDefinitions.Item(2).Width = New GridLength(1, 2)
        B100.ColumnDefinitions.Item(3).Width = New GridLength(7, 2)
        C100.ColumnDefinitions.Item(0).Width = New GridLength(0.5, 2)
        C100.ColumnDefinitions.Item(20).Width = New GridLength(4.5, 2)
        For i = 5 To 19 Step 1 : C100.ColumnDefinitions.Item(i).
            Width = New GridLength(1, 2) : Next
#End Region
      Case = 102 ' Q-Anhang
#Region ""
        ' H-A => Q-A : Q-A° => Q-A
        AAAB() : AABB()
#End Region
      Case = 103 ' Q-Listen
#Region ""
        ' Q-A => Q-L,   H-L => Q-L
        AAAB() : AABC() : B100.ColumnDefinitions.Item(3).Width = New GridLength(14, 2)
#End Region
      Case = 104 ' Q-Beispiele
#Region ""
        AAAB()
#End Region
      Case = 105 ' Q-Tabelle
#Region ""
        ' H-T => Q-T,   Q-A => Q-T,   Q-E => Q-T
        AAAB() : B200.Visibility = 1 : B300.Visibility = 0 : DA_.Visibility = 1 : If B300.Children.Count = 0 Then CAAA()
        ' A104.Icon = New SymbolIcon(Symbol.Remove)
#End Region
      Case = 106 ' Q-Elemente
#Region ""
        AAAB()
#End Region
      Case = 201 ' H-Start
#Region ""
        ' Q-S => H-S : H-A° => H-S
        AAAB() : Grid.SetColumn(Հ101, 2) : Grid.SetRow(Հ103, 1)
        AABA() : CA_.Visibility = 1
        AA00.RowDefinitions.Item(0).Height = New GridLength(0, 2)
        B100.RowDefinitions.Item(1).Height = New GridLength(1, 2)
        B100.ColumnDefinitions.Item(1).Width = New GridLength(0, 2)
        B100.ColumnDefinitions.Item(2).Width = New GridLength(0, 2)
        B100.ColumnDefinitions.Item(3).Width = New GridLength(14, 2)
        C100.ColumnDefinitions.Item(0).Width = New GridLength(0.3, 2)
        C100.ColumnDefinitions.Item(5).Width = New GridLength(0, 2)
        C100.ColumnDefinitions.Item(10).Width = New GridLength(0, 2)
        C100.ColumnDefinitions.Item(20).Width = New GridLength(0.3, 2)
#End Region
      Case = 202 ' H-Anhang
#Region ""
        ' Q-A => H-A : H-A° => H-A
        AAAB() : AABB() : AA00.RowDefinitions.Item(0).Height = New GridLength(0, 2)
#End Region
      Case = 203 ' H-Listen
#Region ""
        ' Q-A => Q-L,   H-L => Q-L
        AAAB() : AA00.RowDefinitions.Item(0).Height = New GridLength(0, 2)
        AABC() : B100.ColumnDefinitions.Item(3).Width = New GridLength(13, 2)
#End Region
      Case = 204 ' H-Beispiele
#Region ""
        AAAB()
#End Region
      Case = 205 ' H-Tabelle*
#Region ""
        ' Q-T => H-T,   H-A => H-T,   H-E => H-T
        AAAB() : B200.Visibility = 1 : B300.Visibility = 1 : DA_.Visibility = 0 : If DA_.Items.Count = 0 Then CAAB()
#End Region
      Case = 206 ' H-Elemente
#Region ""
        AAAB()
#End Region
    End Select
  End Sub
  Private Sub AAAB()
    ' A°:Q-H: Alle Q oder H
    If AAA = 1 Then : CA_.Visibility = 0 : Grid.SetRow(A100, 0)
      A109.Visibility = 1 : A110.Visibility = 1
      AA00.RowDefinitions.Item(0).Height = New GridLength(1, 2)
      A100.ColumnDefinitions.Item(5).Width = New GridLength(1, 2)
      A100.ColumnDefinitions.Item(6).Width = New GridLength(1, 2)
      A100.ColumnDefinitions.Item(7).Width = New GridLength(1, 2)
      A100.ColumnDefinitions.Item(8).Width = New GridLength(1, 2)
      A100.ColumnDefinitions.Item(11).Width = New GridLength(1.7, 2)
    Else : Grid.SetRow(A100, 3)
      A100.ColumnDefinitions.Item(11).Width = New GridLength(0.3, 2)
      A109.Content = If(A109.Content = "A1", "A2", "A1") : AACA()
      A110.Content = If(A110.Content = "B1", "B2", "B1") : AACB()
      A109.Visibility = 0 : A110.Visibility = 0
    End If : CA_.Background = New SolidColorBrush(ADAB(AAE))
    A100.ColumnDefinitions.Item(0).Width = New GridLength(0.3, 2)
  End Sub
  Private Sub AABA()
    ' S:Q-H: Start: Q und H
    B100.Visibility = 0 : B200.Visibility = 1 : B300.Visibility = 1 : B400.Visibility = 1 : C100.Visibility = 0
    B500.Visibility = 1 : DA_.Visibility = 1 : Հ101.Visibility = 0 : Հ103.Visibility = 0 : Հ102.Visibility = 0
    AA00.RowDefinitions.Item(1).Height = New GridLength(1, 2) : Grid.SetRow(CA_, 3)
    AA00.RowDefinitions.Item(2).Height = New GridLength(12, 2) : AA00.RowDefinitions.Item(4).Height = New GridLength(6, 2)
    B100.RowDefinitions.Item(0).Height = New GridLength(1, 2) : B100.RowDefinitions.Item(2).Height = New GridLength(7, 2)
  End Sub
  Private Sub AABB()
    ' A:Q-H: Anhang: Q und H
    B100.Visibility = 1 : B200.Visibility = 0 : B300.Visibility = 1 : B400.Visibility = 1 : C100.Visibility = 1
    B500.Visibility = 1 : CA_.Visibility = 0 : DA_.Visibility = 1 : Grid.SetRow(CA_, 4)

    AA00.RowDefinitions.Item(1).Height = New GridLength(0, 2) : AA00.RowDefinitions.Item(4).Height = New GridLength(3, 2)
    AA00.RowDefinitions.Item(2).Height = New GridLength(14, 2) : AAG = AAE : If AAG = 10 Then AAG = 4

    ' Anhang - Background
    B200.Background = New LinearGradientBrush With {.StartPoint = New Point(0.5, 0), .EndPoint = New Point(0.5, 1),
      .GradientStops = New GradientStopCollection From {New GradientStop With {.Color = ADAB(AAG), .Offset = 0},
      New GradientStop With {.Color = Colors.White, .Offset = 1}}}

    If B200.RowDefinitions.Count > 0 Then : Exit Sub : End If : Grid.SetRow(B200, 2)

    For i = 1 To 12 Step 1
      B200.ColumnDefinitions.Add(New ColumnDefinition) : B200.RowDefinitions.Add(New RowDefinition) : Next

    Grid.SetRow(B201, 1) : Grid.SetColumn(B201, 1) : Grid.SetRow(B202, 3) : Grid.SetColumn(B202, 1)
    Grid.SetRow(B203, 5) : Grid.SetColumn(B203, 1) : Grid.SetRow(B204, 7) : Grid.SetColumn(B204, 1)
    Grid.SetRow(B205, 9) : Grid.SetColumn(B205, 1) : Grid.SetRow(B206, 1) : Grid.SetColumn(B206, 3)
    Grid.SetRow(B207, 3) : Grid.SetColumn(B207, 3) : Grid.SetRow(B208, 5) : Grid.SetColumn(B208, 3)
    Grid.SetRow(B209, 7) : Grid.SetColumn(B209, 3) : Grid.SetRow(B210, 9) : Grid.SetColumn(B210, 3)

    B201.CornerRadius = New CornerRadius(5) : B202.CornerRadius = New CornerRadius(5)
    B203.CornerRadius = New CornerRadius(5) : B204.CornerRadius = New CornerRadius(5)
    B205.CornerRadius = New CornerRadius(5) : B206.CornerRadius = New CornerRadius(5)
    B207.CornerRadius = New CornerRadius(5) : B208.CornerRadius = New CornerRadius(5)
    B209.CornerRadius = New CornerRadius(5) : B210.CornerRadius = New CornerRadius(5)

    B201.BorderBrush = New SolidColorBrush(Colors.Gray) : B202.BorderBrush = New SolidColorBrush(Colors.Gray)
    B203.BorderBrush = New SolidColorBrush(Colors.Gray) : B204.BorderBrush = New SolidColorBrush(Colors.Gray)
    B205.BorderBrush = New SolidColorBrush(Colors.Gray) : B206.BorderBrush = New SolidColorBrush(Colors.Gray)
    B207.BorderBrush = New SolidColorBrush(Colors.Gray) : B208.BorderBrush = New SolidColorBrush(Colors.Gray)
    B209.BorderBrush = New SolidColorBrush(Colors.Gray) : B210.BorderBrush = New SolidColorBrush(Colors.Gray)

    B201.HorizontalAlignment = 1 : B201.VerticalAlignment = 1 : B202.HorizontalAlignment = 1 : B202.VerticalAlignment = 1
    B203.HorizontalAlignment = 1 : B203.VerticalAlignment = 1 : B204.HorizontalAlignment = 1 : B204.VerticalAlignment = 1
    B205.HorizontalAlignment = 1 : B205.VerticalAlignment = 1 : B206.HorizontalAlignment = 1 : B206.VerticalAlignment = 1
    B207.HorizontalAlignment = 1 : B207.VerticalAlignment = 1 : B208.HorizontalAlignment = 1 : B208.VerticalAlignment = 1
    B209.HorizontalAlignment = 1 : B209.VerticalAlignment = 1 : B210.HorizontalAlignment = 1 : B210.VerticalAlignment = 1

    B201.Background = New SolidColorBrush(Colors.Transparent) : B202.Background = New SolidColorBrush(Colors.Transparent)
    B203.Background = New SolidColorBrush(Colors.Transparent) : B204.Background = New SolidColorBrush(Colors.Transparent)
    B205.Background = New SolidColorBrush(Colors.Transparent) : B206.Background = New SolidColorBrush(Colors.Transparent)
    B207.Background = New SolidColorBrush(Colors.Transparent) : B208.Background = New SolidColorBrush(Colors.Transparent)
    B209.Background = New SolidColorBrush(Colors.Transparent) : B210.Background = New SolidColorBrush(Colors.Transparent)

    ToolTipService.SetToolTip(B201, New ToolTip With {.Content = A_D.GetString("A101"), .Placement = PlacementMode.Right})
    ToolTipService.SetToolTip(B202, New ToolTip With {.Content = A_D.GetString("A102"), .Placement = PlacementMode.Right})
    ToolTipService.SetToolTip(B203, New ToolTip With {.Content = A_D.GetString("A103"), .Placement = PlacementMode.Right})
    ToolTipService.SetToolTip(B204, New ToolTip With {.Content = A_D.GetString("A104"), .Placement = PlacementMode.Right})
    ToolTipService.SetToolTip(B205, New ToolTip With {.Content = A_D.GetString("A105"), .Placement = PlacementMode.Right})
    ToolTipService.SetToolTip(B206, New ToolTip With {.Content = A_D.GetString("A106"), .Placement = PlacementMode.Right})
    ToolTipService.SetToolTip(B207, New ToolTip With {.Content = A_D.GetString("A107"), .Placement = PlacementMode.Right})
    ToolTipService.SetToolTip(B208, New ToolTip With {.Content = A_D.GetString("A108"), .Placement = PlacementMode.Right})
    ToolTipService.SetToolTip(B209, New ToolTip With {.Content = A_D.GetString("A109"), .Placement = PlacementMode.Right})
    ToolTipService.SetToolTip(B210, New ToolTip With {.Content = A_D.GetString("A110"), .Placement = PlacementMode.Right})

    ' Icons 1-9
    For i = 0 To 8 Step 1 : ADAD(B200.Children.Item(i)).Content = New Image With {.Source = New BitmapImage With
        {.UriSource = New Uri("ms-appx:///Assets/A_A_00" & CStr(i + 1) & ".png")}} : Next
    ' Icon 10-99
    B210.Content = New Image With {.Source = New BitmapImage With {.UriSource = New Uri("ms-appx:///Assets/A_A_010.png")}}
  End Sub
  Private Sub AABC()
    ' L:Q-H: Listen: Q und H
    B100.Visibility = 0 : B200.Visibility = 1 : Հ102.Visibility = 1 : Հ104.Visibility = 0 : DA_.Visibility = 1
    AA00.RowDefinitions.Item(1).Height = New GridLength(1, 2) : B100.RowDefinitions.Item(0).Height = New GridLength(0, 2)
    B100.RowDefinitions.Item(1).Height = New GridLength(0, 2) : B100.ColumnDefinitions.Item(1).Width = New GridLength(0, 2)
    B100.ColumnDefinitions.Item(2).Width = New GridLength(0, 2) : Հ101.Visibility = 1 : Հ103.Visibility = 1
  End Sub
  Private Sub AACA()
    If A109.Content = "A1" Then : A109.Content = "A2" : AAC = 0
      AAD = 1
    Else : A109.Content = "A1" : AAC = 1 : AAD = 0 : End If
    A100.ColumnDefinitions.Item(5).Width = New GridLength(AAC, 2)
    A100.ColumnDefinitions.Item(6).Width = New GridLength(AAC, 2)
    A100.ColumnDefinitions.Item(7).Width = New GridLength(AAD, 2)
    A100.ColumnDefinitions.Item(8).Width = New GridLength(AAD, 2)
  End Sub
  Private Sub AACB()
    If A110.Content = "B1" Then : A110.Content = "B2" : AAC = 0
      AAD = 1
    Else : A110.Content = "B1" : AAC = 1 : AAD = 0 : End If
    C100.ColumnDefinitions.Item(6).Width = New GridLength(AAC, 2)
    C100.ColumnDefinitions.Item(7).Width = New GridLength(AAC, 2)
    C100.ColumnDefinitions.Item(8).Width = New GridLength(AAC, 2)
    C100.ColumnDefinitions.Item(9).Width = New GridLength(AAC, 2)
    C100.ColumnDefinitions.Item(11).Width = New GridLength(AAD, 2)
    C100.ColumnDefinitions.Item(12).Width = New GridLength(AAD, 2)
    C100.ColumnDefinitions.Item(13).Width = New GridLength(AAD, 2)
    C100.ColumnDefinitions.Item(14).Width = New GridLength(AAD, 2)

    'Select Case AAB : Case 1
    '    C100.ColumnDefinitions.Item(6).Width = New GridLength(AAC, 2)
    '    C100.ColumnDefinitions.Item(7).Width = New GridLength(AAC, 2)
    '    C100.ColumnDefinitions.Item(8).Width = New GridLength(AAC, 2)
    '    C100.ColumnDefinitions.Item(9).Width = New GridLength(AAC, 2)
    '    C100.ColumnDefinitions.Item(11).Width = New GridLength(AAD, 2)
    '    C100.ColumnDefinitions.Item(12).Width = New GridLength(AAD, 2)
    '    C100.ColumnDefinitions.Item(13).Width = New GridLength(AAD, 2)
    '    C100.ColumnDefinitions.Item(14).Width = New GridLength(AAD, 2)
    '  Case 5 : If AAD = 0 Then : B300.Visibility = AAD
    '      DA_.Visibility = AAC : Else : ACAC() : End If : End Select
  End Sub
  Private Sub AADA()
    ' Textstyle - Bearbeitung
    Select Case ApplicationData.Current.LocalSettings.Values("textstyle")
      Case "."
      Case ""
    End Select
  End Sub
  Private Sub AADB()
    ' frameview - Bearbeitung '
    Select Case ApplicationData.Current.LocalSettings.Values("frameview")
      Case "." : Ξ100.Visibility = 0
      Case "" : Ξ100.Visibility = 1 : End Select
    Ξ100.Stroke = New SolidColorBrush(ADAB(AAG))
  End Sub
  Private Sub AADC()
    ' Helligkeit - Bearbeitung
    Select Case ApplicationData.Current.LocalSettings.Values("lightness")
      Case "."
        ApplicationData.Current.LocalSettings.Values("colors") = "1"
        AA00.Background = New SolidColorBrush(Colors.White)
        Ϟ101.Foreground = New SolidColorBrush(Colors.Black)
        Ϟ102.Foreground = New SolidColorBrush(Colors.Black)
        Ϟ103.Foreground = New SolidColorBrush(Colors.Black)
        Ϟ104.Foreground = New SolidColorBrush(Colors.Black)
        C100.Background = New SolidColorBrush(Colors.White)
        B501.Visibility = 0 : B502.Visibility = 0 : B503.Visibility = 0
        B504.Visibility = 0 : B505.Visibility = 0 : B506.Visibility = 0
        AAE = 14 : AAF = 0 : AAG = 1 : AADD()
      Case ""
        ApplicationData.Current.LocalSettings.Values("colors") = ""
        AA00.Background = New SolidColorBrush(Colors.Blue)
        Ϟ101.Foreground = New SolidColorBrush(Colors.White)
        Ϟ102.Foreground = New SolidColorBrush(Colors.White)
        Ϟ103.Foreground = New SolidColorBrush(Colors.White)
        Ϟ104.Foreground = New SolidColorBrush(Colors.White)
        C100.Background = New SolidColorBrush(Colors.Blue)
        B501.Visibility = 1 : B502.Visibility = 1 : B503.Visibility = 1
        B504.Visibility = 1 : B505.Visibility = 1 : B506.Visibility = 1
        AAE = 11 : AAF = 14 : AAG = 13 : AADD()
    End Select : AADE()
  End Sub
  Private Sub AADD()
    title.BackgroundColor = ADAB(AAE) : title.ButtonInactiveForegroundColor = ADAB(AAF)
    title.ForegroundColor = ADAB(AAF) : title.ButtonInactiveBackgroundColor = ADAB(AAE)
    title.ButtonBackgroundColor = ADAB(AAE) : title.InactiveBackgroundColor = ADAB(AAE)
    title.ButtonForegroundColor = ADAB(AAF) : title.InactiveForegroundColor = ADAB(AAF)
    title.ButtonHoverBackgroundColor = ADAB(AAE) : title.ButtonPressedBackgroundColor = ADAB(AAG)
  End Sub
  Private Sub AADE()
    'Colors
    Select Case ApplicationData.Current.LocalSettings.Values("colors")
      Case "" : AAE = 11 : AAF = 14 : AAG = 14 : Case "1" : AAE = 10 : AAF = 11 : AAG = 11
      Case "2" : AAE = 4 : AAF = 14 : AAG = 11 : Case "3" : AAE = 1 : AAF = 14 : AAG = 12
      Case "4" : AAE = 12 : AAF = 14 : AAG = 12 : Case "5" : AAE = 13 : AAF = 14 : AAG = 2
      Case "6" : AAE = 11 : AAF = 14 : AAG = 11 : End Select

    AA_.Stroke = New SolidColorBrush(ADAB(AAG)) : AB_.Stroke = New SolidColorBrush(ADAB(AAG))

    Ξ100.Stroke = New SolidColorBrush(ADAB(AAG))

    A100.Background = New SolidColorBrush(ADAB(AAE)) : CA_.Background = New SolidColorBrush(ADAB(AAE))

    For i = 0 To 9 Step 1 : ADAD(A100.Children.Item(i)).Foreground = New SolidColorBrush(ADAB(AAF))
    Next

    For i = 0 To 63 Step 1 : ADAD(C100.Children.Item(i)).Foreground = New SolidColorBrush(ADAB(AAG))
      ADAD(C100.Children.Item(i)).Background = New SolidColorBrush(Colors.White) : Next

    If AAE = 11 And AAG = 14 Then
      For i = 0 To 63 Step 1 : ADAD(C100.Children.Item(i)).Background = New SolidColorBrush(ADAB(AAE)) : Next
    End If

    B511.Background = New SolidColorBrush(ADAB(AAE)) : B511.Foreground = New SolidColorBrush(ADAB(AAF))
    B512.Background = New SolidColorBrush(ADAB(AAE)) : B512.Foreground = New SolidColorBrush(ADAB(AAF))
    B513.Background = New SolidColorBrush(ADAB(AAE)) : B513.Foreground = New SolidColorBrush(ADAB(AAF))
  End Sub
  'Private Sub AIAS()
  '  Select Case Ϟ104.Document.Selection.
  '    CharacterFormat.ForegroundColor
  '    Case Colors.Black : AIAC(Colors.Blue)
  '    Case Colors.Blue : AIAC(Colors.Green)
  '    Case Colors.Green : AIAC(Colors.Pink)
  '    Case Colors.Pink : AIAC(Colors.Black)
  '    Case Else : AIAC(Colors.Black) : End Select
  'End Sub
#End Region
#Region "A-AB"
  Private Sub ABAA()
    ' Colors AliceBlue
    ApplicationData.Current.LocalSettings.Values("colors") = "1" : AADE()
  End Sub
  Private Sub ABAB()
    ' Colors SkyBlue
    ApplicationData.Current.LocalSettings.Values("colors") = "2" : AADE()
  End Sub
  Private Sub ABAC()
    ' Colors Gold
    ApplicationData.Current.LocalSettings.Values("colors") = "3" : AADE()
  End Sub
  Private Sub ABAD()
    ' Colors Magenta
    ApplicationData.Current.LocalSettings.Values("colors") = "4" : AADE()
  End Sub
  Private Sub ABAE()
    ' Colors Lime
    ApplicationData.Current.LocalSettings.Values("colors") = "5" : AADE()
  End Sub
  Private Sub ABAF()
    ' Colors Blue
    ApplicationData.Current.LocalSettings.Values("colors") = "6" : AADE()
  End Sub
  Private Sub ABBA()
    ' Textstyle - Auswahl
    If B511.IsOn = True Then
      ApplicationData.Current.LocalSettings.Values("textstyle") = "."
    Else ' mathprint ' classic_r
      ApplicationData.Current.LocalSettings.Values("textstyle") = ""
    End If : AADA()
  End Sub
  Private Sub ABBB()
    ' frameview - Auswahl
    If B512.IsOn = True Then
      ApplicationData.Current.LocalSettings.Values("frameview") = "."
    Else ' outside ' inside_
      ApplicationData.Current.LocalSettings.Values("frameview") = ""
    End If : AADB()
  End Sub
  Private Sub ABBC()
    ' Helligkeit
    If B513.IsOn = True Then
      ApplicationData.Current.LocalSettings.Values("lightness") = "."
    Else ' light ' dark_
      ApplicationData.Current.LocalSettings.Values("lightness") = ""
    End If : AADC()
  End Sub
#End Region
#Region "A-AC"
  Private Sub ACAA(a As Object, b As TappedRoutedEventArgs)
    Try : AEB.Stop() : FA_.Focus(3) : AA_.StrokeThickness = If(BBA = 0 And Ξ100.Visibility = 0, 5, 1)
      BBA = Math.Ceiling(b.GetPosition(Հ101).X / 10) : If BBA > FA_.Text.Length Then BBA = FA_.Text.Length
      AA_.Visibility = 0 : AEA.Start() : AA_.X1 = BBA * 10 : AA_.X2 = BBA * 10 : AA_.Y1 = 2 : AA_.Y2 = 15
      AB_.Visibility = 1 : FA_.SelectionStart = BBA : Catch ex As Exception : Ϟ104.Text = "ACAA: " & ex.Message : End Try
  End Sub
  Private Sub ACAB(a As Object, b As TappedRoutedEventArgs)
    Try : AEA.Stop() : FB_.Focus(3)
      BBA = Math.Ceiling(b.GetPosition(Հ102).X / 15) : If BBA >= Ξ102.Children.Count Then BBA = Ξ102.Children.Count - 2
      AB_.Visibility = 0 : AEB.Start() : AB_.X1 = BBA * 15 : AB_.X2 = BBA * 15 : AB_.Y1 = BBB * 15 : AB_.Y2 = BBB * 15 + 15
      AA_.Visibility = 1 : FA_.SelectionStart = BBA : Catch ex As Exception : Ϟ104.Text = "ACAB: " & ex.Message : End Try
  End Sub
  Private Sub ACAC()
    ' Kursor-1-Blinken
    Select Case AA_.Visibility : Case 0 : AA_.Visibility = 1 : Case 1 : AA_.Visibility = 0 : End Select
  End Sub
  Private Sub ACAD()
    ' Kursor-2-Blinken
    Select Case AB_.Visibility : Case 0 : AB_.Visibility = 1 : Case 1 : AB_.Visibility = 0 : End Select
  End Sub
  Private Sub ACBA()
    Try ' FA_ Eingabe: TextChanged
      BBC = FA_.SelectionStart : BBE = FA_.Text.Length : If FA_.Text <> "" Then Ϟ101.Text = ""

      If BBE - BBD < 0 Then ' wenn der Text kleiner geworden ist: ' a|bc)d

        For i = BBC + BBD - BBE - 1 To BBC Step -1 : Ξ101.Children.RemoveAt(i) : Next

        For i = BBC To Ξ101.Children.Count - 3 Step 1
          ADAF(Ξ101.Children(i)).Margin = New Thickness(i * 10, 0, 0, 0) : Next
      End If

      If BBE - BBD > 0 Then ' wenn der Text größer geworden ist: ' a(bc|d

        For i = BBC + BBD - BBE To BBC - 1 Step 1
          Ξ101.Children.Insert(i, New TextBlock With {.Text = FA_.Text.Substring(i, 1),
                               .Foreground = New SolidColorBrush(ADAB(AAG))}) : Next

        For i = BBC + BBD - BBE To Ξ101.Children.Count - 3 Step 1
          ADAF(Ξ101.Children(i)).Margin = New Thickness(i * 10, 0, 0, 0) : Next
      End If
      BBD = BBE : If FA_.Text = "" Then Ϟ101.Text = A_D.GetString("A201")
    Catch ex As Exception : Ϟ104.Text = "ACBA: " & ex.Message : End Try
  End Sub
  Private Sub ACBB()
    ' Ϟ102.Text = A_D.GetString("A202")

    Try ' FA_ Eingabe: TextChanged
      If FA_.Text = "" Then Ϟ101.Text = A_D.GetString("A201")
      BBC = FA_.SelectionStart : BEB = FA_.SelectedText : BBE = BEB.Length
      'B102.Text = CStr(BBC) & " " & CStr(BBE) & " " & CStr(BBD) ' Test
      'BAAD()
      'If BBE - BBD < 0 Then : For i = BBC + BBD - BBE - 1 To BBC Step -1 : B111.Children.RemoveAt(i)
      '    For j = i To B111.Children.Count - 2 Step 1
      '      ADAF(B111.Children(j)).Margin = New Thickness((j + 1) * 10, BBB * 10, 0, 0) : Next : Next : BAAD()
      'End If
      'If BBE - BBD > 0 Then : BEC = BEB.Substring(BBC - BBE + BBD, BBE - BBD)
      '  For i = 0 To BEC.Length - 1 Step 1 : BED = BEC.Substring(i, 1) : BBA = BBC - BBE + BBD + i + 1 : BAAE()
      '  Next : BAAD() : End If
      'BAAF()

      'BEA = BEB : BBD = BBE
    Catch ex As Exception
      'Ϟ104.Visibility = 0 : Ϟ104.Document.Selection.Text = FA_.Document.Selection.Text
      'Ϟ104.Document.Selection.Text += vbCrLf & "FA_TextChanged: " & ex.Message : FA_.Visibility = 1
    End Try

  End Sub
  Private Sub ACCA()
    BBA = FA_.SelectionStart : AA_.X1 = BBA * 10 : AA_.X2 = BBA * 10 : AA_.Y1 = 2 : AA_.Y2 = 15
    AA_.StrokeThickness = If(BBA = 0 And Ξ100.Visibility = 0, 5, 1)
  End Sub
  Private Sub ACCB()
    'Try ' FA_: SelectionCanged
    '  BBA = FA_.Document.Selection.EndPosition + 1
    '  AA_.X1 = BBA * 10 : AA_.X2 = BBA * 10 : AA_.Y1 = BBB * 10 : AA_.Y2 = BBB * 10 + 17
    '  If BBA > 1 Then BBA -= 1
    'Catch ex As Exception
    '  FA_.Document.Selection.Text += "FA_.SelectionCanged" & vbCrLf & ex.Message : End Try
  End Sub
#End Region
#Region "A-AD"

#End Region
#Region "A-AE"
  Private Function ADAA() As Boolean
    Dim aaaaa As ConnectionProfile = NetworkInformation.GetInternetConnectionProfile()
    If aaaaa IsNot Nothing AndAlso aaaaa.GetNetworkConnectivityLevel() = 3 Then
      Return True : Else : Return False : End If  ' Internet verfügbar If ja Else nicht
  End Function
  Private Function ADAB() As Color()
    ADAB = New Color() {Colors.Gray, Colors.Gold, Colors.Olive, Colors.Violet, Colors.SkyBlue,
          Colors.LightGray, Colors.LightPink, Colors.MistyRose, Colors.DarkViolet, Colors.GreenYellow,
          Colors.AliceBlue, Colors.Blue, Colors.Magenta, Colors.Lime, Colors.White}
  End Function
  Private Function ADAC() As Integer()
    ADAC = New Integer() {9, 4, 7, 1, 2, 9, 9, 9, 9, 4, 7, 1, 0, 2, 9, 9, 9, 4, 7, 1, 6, 6, 6, 6, 6,
      6, 6, 6, 6, 0, 0, 2, 2, 9, 9, 4, 7, 1, 6, 6, 6, 6, 6, 6, 6, 6, 6, 0, 0, 0, 2, 2, 9, 4, 7, 1,
      3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 6, 6, 6, 6, 6, 6, 6, 6, 0, 0, 0, 0, 0, 2, 4, 7,
      1, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 6, 6, 6, 6, 6, 5, 5, 5, 0, 5, 5, 5, 5, 5, 5}
  End Function
  Private Function ADAD(a As Button) As Button
    Return a
  End Function
  Private Function ADAE(a As Canvas) As Canvas
    Return a
  End Function
  Private Function ADAF(a As TextBlock) As TextBlock
    Return a
  End Function
#End Region
#Region "A-AF"
  Private Async Sub AEAA()
    If ADAA() = True Then
      Dim aaaaa As String = "AA" ' : Ϟ102.Document.Selection.StartPosition = 0
      'Ϟ102.Document.Selection.EndPosition = _Ϟ102.Document.Selection.StoryLength

      'aaaaa = A_D.GetString("A201") & ":   " & B101.Text & vbCrLf &
      '  A_D.GetString("A202") & ":   " & Ϟ102.Document.Selection.Text

      Dim emailMessage As New EmailMessage With {.Body = aaaaa,
      .Subject = A_D.GetString("A105")}
      emailMessage.To.Add(New EmailRecipient("calculator_message_@outlook.com"))
      Await EmailManager.ShowComposeNewEmailAsync(emailMessage)
      'ABAE(Colors.AliceBlue, Colors.Blue, vbCrLf & "Internetverbindung besteht")
    Else
      'ABAE(Colors.AliceBlue, Colors.Blue, vbCrLf & "Keine Internetverbindung")
    End If
  End Sub
#End Region
#End Region
#Region "BBBB"
#Region "B-AA"
  Private Sub BAAD()
    KAH.Clear() : KAI.Clear() : MAA.Clear() : MAC.Clear() : MAD.Clear()
    KAI.Add("") : MAA.Add(0) : MAC.Add(0) : If BBE < 2 Then Exit Sub

    For i = 0 To BBE - 1 Step 1
      Select Case BEB.Substring(i, 1) ' - ‐ Operator und Vorzeichen
        Case "(", "ǀ", "[", "{"
          BBF += 1 : MAA.Add(BBF) : MAD.Add(i + 1 - MAC(MAC.Count - 1))
          KAH.Add(BEB.Substring(MAC(MAC.Count - 1), MAD(MAD.Count - 1)))
          KAI.Add("") : MAC.Add(i + 1)
        Case ")", "|", "]", "}"
          BBF -= 1 : MAA.Add(BBF) : MAD.Add(i - MAC(MAC.Count - 1))
          KAI.Add("")
          KAH.Add(BEB.Substring(MAC(MAC.Count - 1), MAD(MAD.Count - 1)))
          MAC.Add(i)
        Case "'", "`", "→", "=", "≠", "<", ">", "+", "-", "±", "∓", "·",
             ":", "˄", "˅"
          MAA.Add(BBF) : MAD.Add(i - MAC(MAC.Count - 1))
          KAH.Add(BEB.Substring(MAC(MAC.Count - 1), MAD(MAD.Count - 1)))
          KAI.Add(BEB.Substring(i, 1)) : MAC.Add(i + 1)
      End Select
    Next

    If MAC.Count > MAD.Count Then : MAD.Add(BBE - MAC(MAC.Count - 1))
      KAH.Add(BEB.Substring(MAC(MAC.Count - 1), MAD(MAD.Count - 1)))
      MAA.Add(0) : End If

    'sss.Text = CStr(KAH.Count) : Exit Sub
    sss.Text = ""
    For i = 0 To KAH.Count - 1 Step 1
      sss.Text &= "KAI: " & KAI(i) & "		" &
        "KAH: " & KAH(i) & "		" &
        "MAA: " & CStr(MAA(i)) & "		" &
        "MAC: " & CStr(MAC(i)) & "		" &
        "MAD: " & CStr(MAD(i)) & vbCrLf
    Next

    ' □
    'EA_ = New TextBlock With {.Text = "∫", .FontFamily = New FontFamily("Consolas"),
    '  .Scale = New System.Numerics.Vector3(1.0, 3.0, 1.0),
    '  .Margin = New Thickness(BBA * 10, BBB * 10 - 10, 0, 0)} : B111.Children.Insert(BBA - 1, EA_)
    'BDA.Insert(BBA - 1, BBA * 10) : BDB.Insert(BBA - 1, BBB * 10 - 10) : BBA += 1
    'BBB += 1 : AA_.X1 = BBA * 10 : AA_.X2 = BBA * 10 : AA_.Y1 = BBB * 10 : AA_.Y2 = BBB * 10 + 17
    'If BBA > 2 Then : For i = 0 To BBA - 3 Step 1
    '    ADAF(B111.Children(i)).Margin = New Thickness(BDA(i), BBB * 10, 0, 0) : BDB(i) = BBB * 10
    '  Next : End If
    'If B111.Children.Count > BBA Then : For i = BBA - 1 To B111.Children.Count - 2 Step 1
    '    ADAF(B111.Children(i)).Margin = New Thickness(i * 10 + 10, BBB * 10, 0, 0)
    '    BDA(i) = i * 10 + 10 : BDB(i) = BBB * 10 : Next : End If


    'BEB = BEB.Replace("√)", "") : BEB = BEB.Replace("ln)", "")
    'BEB = BEB.Replace("cos)", "") : BEB = BEB.Replace("sin)", "")
    'BEB = BEB.Replace("tan)", "") : BEB = BEB.Replace("cot)", "")
    'BEB = BEB.Replace("acos)", "") : BEB = BEB.Replace("asin)", "")
    'BEB = BEB.Replace("atan)", "") : BEB = BEB.Replace("acot)", "")
    'BEB = BEB.Replace("lim')", "") : BEB = BEB.Replace("log')", "")
    'BEB = BEB.Replace("Ʃ'')", "") : BEB = BEB.Replace("∏'')", "")
    'BEB = BEB.Replace("√')", "") : BEB = BEB.Replace("ʃ''d())", "")

    'If BBD - BBE = 1 AndAlso BEA.Substring(BBC, 1) = ")" Then
    '  BED = "√(" : BAAG() : BED = "cos(" : BAAG() : BED = "acos(" : BAAG() : BED = "√('" : BAAG()
    '  BED = "(`" : BAAG() : BED = "sin(" : BAAG() : BED = "asin(" : BAAG() : BED = "ln(" : BAAG()
    '  BED = "(´" : BAAG() : BED = "tan(" : BAAG() : BED = "atan(" : BAAG() : BED = "lim('" : BAAG()
    '  BED = "('" : BAAG() : BED = "cot(" : BAAG() : BED = "acot(" : BAAG() : BED = "log('" : BAAG()
    '  BED = "Ʃ(''" : BAAG() : BED = "∏(''" : BAAG() : BED = "ʃ(''d()" : BAAG() : End If

    'If BBE <> BEB.Length Then
    '  B102.Text = " " & CStr(BBC) & " " & CStr(BBE) & " " & CStr(BBD) ' Exit Sub ' Test
    '  FA_.Document.Selection.Text = FA_.Document.Selection.Text.Remove(BBC - BED.Length, BED.Length)
    'End If


  End Sub
  Private Sub BAAE()
    'Try
    '  EA_ = New TextBlock With {.Text = BED, .FontFamily = New FontFamily("Consolas"),
    '  .Margin = New Thickness(BBA * 10, BBB * 10, 0, 0)} : B111.Children.Insert(BBA - 1, EA_)
    '  BDA.Insert(BBA - 1, BBA * 10) : BDB.Insert(BBA - 1, BBB * 10) : BBA += 1
    '  AA_.X1 = BBA * 10 : AA_.X2 = BBA * 10 : AA_.Y1 = BBB * 10 : AA_.Y2 = BBB * 10 + 17
    '  If B111.Children.Count > BBA Then
    '    For i = BBA - 1 To B111.Children.Count - 2 Step 1 : BDA(i) = i * 10 + 10
    '      ADAF(B111.Children(i)).Margin = New Thickness(BDA(i), BDB(i), 0, 0) : Next : End If
    '  FA_.Focus(3)
    'Catch ex As Exception
    '  FA_.Document.Selection.Text += vbCrLf & "B111.ChildrenAdded: " & ex.Message & vbCrLf & ex.Source
    'End Try
  End Sub
#End Region
#Region "B-AB"

#End Region
#Region "B-AC"
#End Region
#End Region
#Region "CCCC"
#Region "C-AA"
  Private Sub CAAA()
    ' Perioden Tabelle der chemischen Elemente
    Dim eaaaa As New Button : Dim eaaab As TextBlock : Dim eaaba(), eaabb() As String
    Dim eaaca As New Documents.Run

    For i = 1 To 12 Step 1 : B300.RowDefinitions.Add(New RowDefinition) : Next
    For i = 1 To 22 Step 1 : B300.ColumnDefinitions.Add(New ColumnDefinition) : Next

    B300.RowDefinitions.Item(0).Height = New GridLength(0.2, 2)
    B300.RowDefinitions.Item(1).Height = New GridLength(0.6, 2)
    B300.RowDefinitions.Item(2).Height = New GridLength(0.8, 2)
    B300.ColumnDefinitions.Item(0).Width = New GridLength(0.2, 2)
    B300.ColumnDefinitions.Item(1).Width = New GridLength(0.8, 2)
    B300.ColumnDefinitions.Item(21).Width = New GridLength(0.2, 2)

    eaaba = ("1´1´1´1´2´10´11´2´2´2´2´2´2´2´2´2´2´2´2´2´2´2´2´2´2´3´4´5´6´7´8´9").Split("´")
    eaabb = ("2´4´15´20´1´5´5´2´3´4´6´7´8´9´10´11´12´13´14´15´16´17´18´19´20´1´1´1´1´1´1´1").Split("´")

    For i = 1 To 32 Step 1 : ABA = If(i < 10, "00", "0")
      eaaab = New TextBlock With {
        .FontSize = 12, .Text = A_A.GetString("A" & ABA & CStr(i)), .IsTextSelectionEnabled = False}
      eaaaa = New Button With {.Padding = New Thickness(0), .Content = eaaab,
            .Background = New SolidColorBrush(Colors.WhiteSmoke), .Margin = New Thickness(0.5)}
      B300.Children.Add(eaaaa)
      Grid.SetRow(eaaaa, CInt(eaaba(i - 1))) : Grid.SetColumn(eaaaa, CInt(eaabb(i - 1))) : Next

    Grid.SetColumnSpan(ADAD(B300.Children.Item(0)), 2) : Grid.SetColumnSpan(ADAD(B300.Children.Item(1)), 11)
    Grid.SetColumnSpan(ADAD(B300.Children.Item(2)), 5)

    eaaba = ("3´3´4´4´4´4´4´4´4´4´5´5´5´5´5´5´5´5´6´6´6´6´6´6´6´6´6´6´6´6´6´6´6´6´6´6´7´7´7´7´7´7´7´7´7´7" &
          "´7´7´7´7´7´7´7´7´8´8´8´10´10´10´10´10´10´10´10´10´10´10´10´10´10´8´8´8´8´8´8´8´8´8´8´8´8´8´8´8" &
          "´9´9´9´11´11´11´11´11´11´11´11´11´11´11´11´11´11´9´9´9´9´9´9´9´9´9´9´9´9´9´9´9").Split("´")
    eaabb = ("2´20´2´3´15´16´17´18´19´20´2´3´15´16´17´18´19´20´2´3´4´6´7´8´9´10´11´12´13´14´15´16´17´18´1" &
          "9´20´2´3´4´6´7´8´9´10´11´12´13´14´15´16´17´18´19´20´2´3´4´6´7´8´9´10´11´12´13´14´15´16´17´18´1" &
          "9´6´7´8´9´10´11´12´13´14´15´16´17´18´19´20´2´3´4´6´7´8´9´10´11´12´13´14´15´16´17´18´19´6´7´8´9" &
          "´10´11´12´13´14´15´16´17´18´19´20").Split("´")

    For i = 1 To 118 Step 1 : ABA = "B" & If(i < 10, "00", If(i < 100, "0", "")) & CStr(i)
      eaaab = New TextBlock With {
        .FontFamily = New FontFamily("Calibri Light"), .IsTextSelectionEnabled = False}
      Select Case ADAC(i - 1) : Case "0", "2", "8"
          eaaab.Foreground = New SolidColorBrush(Colors.White) : End Select
      eaaaa = New Button With {.Background = New SolidColorBrush(ADAB(CInt(ADAC(i - 1)))),
        .Padding = New Thickness(0), .HorizontalContentAlignment = 0, .Content = eaaab,
        .Margin = New Thickness(0.5)}
      Grid.SetRow(eaaaa, CInt(eaaba(i - 1))) : Grid.SetColumn(eaaaa, CInt(eaabb(i - 1)))
      eaaca = New Documents.Run With {.Text = A_A.GetString(ABA) & vbLf, .FontSize = 15}
      eaaab.Inlines.Add(eaaca) : B300.Children.Add(eaaaa)
      eaaca = New Documents.Run With {.Text = vbLf & A_D.GetString(ABA), .FontSize = 12}
      eaaab.Inlines.Add(eaaca) : AddHandler eaaaa.Click, AddressOf CABA : Next
  End Sub
  Private Sub CAAB()
    ' Liste der chemischen Elemente
    For i = 1 To 118 Step 1 : ABA = "B" & If(i < 10, "00", If(i < 100, "0", "")) & CStr(i)
      DA_.Items.Add(New TextBlock With {.FontFamily = New FontFamily("Consolas"),
        .FontSize = 16, .VerticalAlignment = 3, .HorizontalAlignment = 3,
        .Text = (A_A.GetString(ABA) & "          ").Substring(0, 10) & A_D.GetString(ABA)})
    Next : AA00.Children.
      Add(DA_) : Grid.SetRow(DA_, 2) : AddHandler DA_.SelectionChanged, AddressOf CABB
  End Sub
#End Region
#Region "C-AB"
  Private Sub CABA(a As Button, b As RoutedEventArgs)
    ' Die Auswahl des chemischen Elements von der Tabelle
    ABA = CStr(Grid.GetRow(a)) & "." & CStr(Grid.GetColumn(a))
    Select Case ABA
      Case "3.2" : ABA = "1" : Case "3.20" : ABA = "2" : Case "4.2" : ABA = "3" : Case "4.3" : ABA = "4"
      Case "4.15" : ABA = "5" : Case "4.16" : ABA = "6" : Case "4.17" : ABA = "7" : Case "4.18" : ABA = "8"
      Case "4.19" : ABA = "9" : Case "4.20" : ABA = "10" : Case "5.2" : ABA = "11" : Case "5.3" : ABA = "12"
      Case "5.15" : ABA = "13" : Case "5.16" : ABA = "14" : Case "5.17" : ABA = "15" : Case "5.18" : ABA = "16"
      Case "5.19" : ABA = "17" : Case "5.20" : ABA = "18" : Case "6.2" : ABA = "19" : Case "6.3" : ABA = "20"
      Case "6.4" : ABA = "21" : Case "6.6" : ABA = "22" : Case "6.7" : ABA = "23" : Case "6.8" : ABA = "24"
      Case "6.9" : ABA = "25" : Case "6.10" : ABA = "26" : Case "6.11" : ABA = "27" : Case "6.12" : ABA = "28"
      Case "6.13" : ABA = "29" : Case "6.14" : ABA = "30" : Case "6.15" : ABA = "31" : Case "6.16" : ABA = "32"
      Case "6.17" : ABA = "33" : Case "6.18" : ABA = "34" : Case "6.19" : ABA = "35" : Case "6.20" : ABA = "36"
      Case "7.2" : ABA = "37" : Case "7.3" : ABA = "38" : Case "7.4" : ABA = "39" : Case "7.6" : ABA = "40"
      Case "7.7" : ABA = "41" : Case "7.8" : ABA = "42" : Case "7.9" : ABA = "43" : Case "7.10" : ABA = "44"
      Case "7.11" : ABA = "45" : Case "7.12" : ABA = "46" : Case "7.13" : ABA = "47" : Case "7.14" : ABA = "48"
      Case "7.15" : ABA = "49" : Case "7.16" : ABA = "50" : Case "7.17" : ABA = "51" : Case "7.18" : ABA = "52"
      Case "7.19" : ABA = "53" : Case "7.20" : ABA = "54" : Case "8.2" : ABA = "55" : Case "8.3" : ABA = "56"
      Case "8.4" : ABA = "57" : Case "10.6" : ABA = "58" : Case "10.7" : ABA = "59" : Case "10.8" : ABA = "60"
      Case "10.9" : ABA = "61" : Case "10.10" : ABA = "62" : Case "10.11" : ABA = "63" : Case "10.12" : ABA = "64"
      Case "10.13" : ABA = "65" : Case "10.14" : ABA = "66" : Case "10.15" : ABA = "67" : Case "10.16" : ABA = "68"
      Case "10.17" : ABA = "69" : Case "10.18" : ABA = "70" : Case "10.19" : ABA = "71" : Case "8.6" : ABA = "72"
      Case "8.7" : ABA = "73" : Case "8.8" : ABA = "74" : Case "8.9" : ABA = "75" : Case "8.10" : ABA = "76"
      Case "8.11" : ABA = "77" : Case "8.12" : ABA = "78" : Case "8.13" : ABA = "79" : Case "8.14" : ABA = "80"
      Case "8.15" : ABA = "81" : Case "8.16" : ABA = "82" : Case "8.17" : ABA = "83" : Case "8.18" : ABA = "84"
      Case "8.19" : ABA = "85" : Case "8.20" : ABA = "86" : Case "9.2" : ABA = "87" : Case "9.3" : ABA = "88"
      Case "9.4" : ABA = "89" : Case "11.6" : ABA = "90" : Case "11.7" : ABA = "91" : Case "11.8" : ABA = "92"
      Case "11.9" : ABA = "93" : Case "11.10" : ABA = "94" : Case "11.11" : ABA = "95" : Case "11.12" : ABA = "96"
      Case "11.13" : ABA = "97" : Case "11.14" : ABA = "98" : Case "11.15" : ABA = "99" : Case "11.16" : ABA = "100"
      Case "11.17" : ABA = "101" : Case "11.18" : ABA = "102" : Case "11.19" : ABA = "103" : Case "9.6" : ABA = "104"
      Case "9.7" : ABA = "105" : Case "9.8" : ABA = "106" : Case "9.9" : ABA = "107" : Case "9.10" : ABA = "108"
      Case "9.11" : ABA = "109" : Case "9.12" : ABA = "110" : Case "9.13" : ABA = "111" : Case "9.14" : ABA = "112"
      Case "9.15" : ABA = "113" : Case "9.16" : ABA = "114" : Case "9.17" : ABA = "115" : Case "9.18" : ABA = "116"
      Case "9.19" : ABA = "117" : Case "9.20" : ABA = "118" : Case Else : ABA = 0 : End Select : CAA = ABA : CABC()
  End Sub
  Private Sub CABB()
    ' Die Auswahl des chemischen Elements von der Liste
    ABA = CStr(DA_.SelectedIndex + 1) : CABC()
  End Sub
  Private Sub CABC()
    ' Das Laden des chemischen Elements
    B401.Background = New SolidColorBrush(ADAB(CInt(ADAC(CInt(ABA) - 1)))) : B400.Visibility = 0
    CA_.Background = B401.Background : Select Case ADAC(CInt(ABA) - 1) : Case 0, 2, 8
        B401.Foreground = New SolidColorBrush(Colors.White) : End Select : B300.Visibility = 1
    AAB = 6
    ABA = If(CByte(ABA) < 10, "00", If(CByte(ABA) < 100, "0", "")) & ABA : DA_.Visibility = 1
    EB_.Text = A_B.GetString("A" & ABA) : EA_.Text = (A_A.GetString("B" & ABA) & "          ").
      Substring(0, 10) & A_D.GetString("B" & ABA) : If B400.RowDefinitions.Count > 0 Then Exit Sub

    Dim aaaaa As New Grid : Dim aaaab As TextBlock : Dim aaaac As New GridLength(7, 2)
    B400.ColumnDefinitions.Add(New ColumnDefinition) : B400.RowDefinitions.Add(New RowDefinition)
    B400.ColumnDefinitions.Add(New ColumnDefinition) : B400.RowDefinitions.Add(New RowDefinition)
    B400.ColumnDefinitions.Add(New ColumnDefinition) : B400.RowDefinitions.Add(New RowDefinition)
    aaaaa.ColumnDefinitions.Add(New ColumnDefinition) : aaaaa.RowDefinitions.Add(New RowDefinition)
    aaaaa.ColumnDefinitions.Add(New ColumnDefinition) : aaaaa.RowDefinitions.Add(New RowDefinition)
    aaaaa.ColumnDefinitions.Add(New ColumnDefinition) : aaaaa.RowDefinitions.Add(New RowDefinition)

    B400.RowDefinitions.Item(1).Height = aaaac : B400.ColumnDefinitions.Item(1).Width = aaaac
    aaaaa.RowDefinitions.Item(2).Height = aaaac : aaaaa.ColumnDefinitions.Item(0).Width = aaaac
    aaaaa.ColumnDefinitions.Item(2).Width = New GridLength(2, 2) : EA_.FontSize = 16
    B401.Content = aaaaa : EB_.FontSize = 16

    aaaaa.Children.Add(EA_) : Grid.SetRow(EA_, 0) : Grid.SetColumn(EA_, 0)
    aaaaa.Children.Add(EB_) : Grid.SetRow(EB_, 2) : Grid.SetColumn(EB_, 2) : Grid.SetRow(B400, 2)
    aaaab = New TextBlock With {.MinWidth = 50, .MinHeight = 20, .IsTextSelectionEnabled = False}
    aaaaa.Children.Add(aaaab) : Grid.SetRow(aaaab, 1) : Grid.SetColumn(aaaab, 1) : Grid.SetColumn(B401, 1)
    aaaab = New TextBlock With {.IsTextSelectionEnabled = False, .Text = A_E.GetString("A003"),
      .FontSize = 16}
    aaaaa.Children.Add(aaaab) : Grid.SetRow(aaaab, 2) : Grid.SetColumn(aaaab, 0) : Grid.SetRow(B401, 1)
  End Sub
  Private Sub CABD()
    ' Die Abwahl des chemischen Elements
    B400.Visibility = 1 : AAB = 5
    If AAA = 1 Then : B300.Visibility = 0 : DA_.Visibility = 1 : If B300.Children.Count = 0 Then CAAA()
    Else : B300.Visibility = 1 : DA_.Visibility = 0 : If DA_.Items.Count = 0 Then : CAAB() : End If : End If
  End Sub
#End Region
#End Region
#Region "DDDD"

#End Region
#Region "EEEE"

#End Region
#End Region
End Class