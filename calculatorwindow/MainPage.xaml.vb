Imports Windows.Storage
Imports Windows.ApplicationModel.Resources
Imports Windows.UI : Imports Windows.UI.Text
Imports Windows.UI.Xaml.Controls

Public NotInheritable Class MainPage
  ' بِسْمِ اللَّهِ الرَّحْمَـٰنِ الرَّحِيمِ
  Inherits Page
  ' * ≡≡≡≡ * ≡≡≡≡ * ≡≡≡≡ * ≡≡≡≡ *
#Region "≡≡≡≡"
#Region "A-00"
  ' Deklaration

  Dim AAA, AAB, AAC, AAD As Byte : Dim BAA As Double

  Dim NAA As New ResourceLoader("A_a_a_a_a") : Dim NAB As New ResourceLoader("A_a_a_a_b")
  Dim NAC As New ResourceLoader("A_b_a_a_a")
  Dim NAD As New ResourceLoader("Resources") : Dim NAE As New ResourceLoader("Source_aa")

  Dim _AA As String

  Dim _FA() As String

  Dim A_01 As New Canvas
#End Region ' *****
#End Region
  ' * ○○○○ * ○○○○ * ○○○○ * ○○○○ *
#Region "○○○○"
#Region "AAA0"
  Private Sub A_A_() Handles AAA0.Loaded
    Try
      ' Loaded
      B103.IsSpellCheckEnabled = False : B104.IsSpellCheckEnabled = False

      A101.Foreground = New SolidColorBrush(Colors.Blue) : A102.Foreground = New SolidColorBrush(Colors.Blue)
      A103.Foreground = New SolidColorBrush(Colors.Blue) : A104.Foreground = New SolidColorBrush(Colors.Blue)
      A105.Foreground = New SolidColorBrush(Colors.Blue) : A106.Foreground = New SolidColorBrush(Colors.Blue)
      A107.Foreground = New SolidColorBrush(Colors.Blue) : A108.Foreground = New SolidColorBrush(Colors.Blue)
      A109.Foreground = New SolidColorBrush(Colors.Blue) : A110.Foreground = New SolidColorBrush(Colors.Blue)

      A101.VerticalAlignment = 3 : A101.HorizontalAlignment = 3 : A102.VerticalAlignment = 3 : A102.HorizontalAlignment = 3
      A103.VerticalAlignment = 3 : A103.HorizontalAlignment = 3 : A104.VerticalAlignment = 3 : A104.HorizontalAlignment = 3
      A105.VerticalAlignment = 3 : A105.HorizontalAlignment = 3 : A106.VerticalAlignment = 3 : A106.HorizontalAlignment = 3
      A107.VerticalAlignment = 3 : A107.HorizontalAlignment = 3 : A108.VerticalAlignment = 3 : A108.HorizontalAlignment = 3
      A109.VerticalAlignment = 3 : A109.HorizontalAlignment = 3 : A110.VerticalAlignment = 3 : A110.HorizontalAlignment = 3
      B101.VerticalAlignment = 3 : B101.HorizontalAlignment = 3 : B102.VerticalAlignment = 3 : B102.HorizontalAlignment = 3

      ToolTipService.SetToolTip(A101, New ToolTip With {.Content = NAD.GetString("A001"), .Placement = PlacementMode.Bottom})
      ToolTipService.SetToolTip(A102, New ToolTip With {.Content = NAD.GetString("A002"), .Placement = PlacementMode.Bottom})
      ToolTipService.SetToolTip(A103, New ToolTip With {.Content = NAD.GetString("A003"), .Placement = PlacementMode.Bottom})
      ToolTipService.SetToolTip(A104, New ToolTip With {.Content = NAD.GetString("A004"), .Placement = PlacementMode.Bottom})
      ToolTipService.SetToolTip(A105, New ToolTip With {.Content = NAD.GetString("A005"), .Placement = PlacementMode.Bottom})
      ToolTipService.SetToolTip(A106, New ToolTip With {.Content = NAD.GetString("A006"), .Placement = PlacementMode.Bottom})
      ToolTipService.SetToolTip(A107, New ToolTip With {.Content = NAD.GetString("A007"), .Placement = PlacementMode.Bottom})
      ToolTipService.SetToolTip(A108, New ToolTip With {.Content = NAD.GetString("A008"), .Placement = PlacementMode.Bottom})

      A109.Content = "A1" : A110.Content = "B1"
      C101.Content = "1" : C102.Content = "2" : C103.Content = "3" : C104.Content = "4" : C105.Content = "5"
      C106.Content = "6" : C107.Content = "7" : C108.Content = "8" : C109.Content = "9" : C110.Content = "0"
      C111.Content = "e" : C112.Content = "π" : C113.Content = "[" : C114.Content = "ǀ" : C115.Content = "|"
      C116.Content = "]" : C117.Content = "+" : C118.Content = "*" : C119.Content = "^" : C120.Content = "∞"
      C121.Content = "–" : C122.Content = ":" : C123.Content = "√" : C124.Content = "Δ" : C125.Content = "-"
      C127.Content = "´" : C128.Content = "°" : C129.Content = "(" : C130.Content = ")" : C131.Content = "!"
      C132.Content = "→" : C133.Content = "θ" : C134.Content = "Ʃ" : C135.Content = "∏" : C136.Content = "ʃ"
      C137.Content = "ϕ" : C138.Content = "ln" : C139.Content = "lim" : C140.Content = "log"
      C141.Content = "cos" : C142.Content = "sin" : C143.Content = "tan" : C144.Content = "cot"
      C145.Content = "acos" : C146.Content = "asin" : C147.Content = "atan" : C148.Content = "acot"

      C126.Content = NAD.GetString("A254") : B101.PlaceholderText = NAD.GetString("A201")
      B103.PlaceholderText = NAD.GetString("A202") : B104.PlaceholderText = NAD.GetString("A900")

      If ApplicationData.Current.LocalSettings.Values("upgrade") <> "18.02.2022" Then
        B104.FontFamily = New FontFamily("Segoe UI")
        ABAA(5) : ABAB(Colors.White, Colors.Lime, NAD.GetString("E001") & vbCrLf)
        ABAA(5) : ABAB(Colors.White, Colors.Black, NAE.GetString("A002")) : End If

      Dim title = ApplicationView.GetForCurrentView().TitleBar
      title.BackgroundColor = Colors.White : title.ForegroundColor = Colors.Gray
      title.ButtonBackgroundColor = Colors.White : title.ButtonForegroundColor = Colors.Gray
      title.InactiveBackgroundColor = Colors.White : title.InactiveForegroundColor = Colors.Gray
      title.ButtonHoverBackgroundColor = Colors.White : title.ButtonHoverForegroundColor = Colors.Pink
      title.ButtonInactiveBackgroundColor = Colors.White : title.ButtonInactiveForegroundColor = Colors.Gray
      title.ButtonPressedBackgroundColor = Colors.Gold : title.ButtonPressedForegroundColor = Colors.Pink

      For i = 1 To 5 Step 1 : AA00.RowDefinitions.Add(New RowDefinition) : Next
      For i = 1 To 12 Step 1 : A100.ColumnDefinitions.Add(New ColumnDefinition) : Next
      For i = 1 To 3 Step 1 : B100.RowDefinitions.Add(New RowDefinition) : Next
      For i = 1 To 4 Step 1 : B100.ColumnDefinitions.Add(New ColumnDefinition) : Next
      For i = 1 To 4 Step 1 : C100.RowDefinitions.Add(New RowDefinition) : Next
      For i = 1 To 16 Step 1 : C100.ColumnDefinitions.Add(New ColumnDefinition) : Next

      AA00.Children.Add(A_01)
      Grid.SetColumn(A101, 1) : Grid.SetColumn(A102, 2) : Grid.SetColumn(A103, 3) : Grid.SetColumn(A104, 4)
      Grid.SetColumn(A105, 5) : Grid.SetColumn(A106, 6) : Grid.SetColumn(A107, 7) : Grid.SetColumn(A108, 8)
      Grid.SetColumn(A109, 9) : Grid.SetColumn(A110, 10) : Grid.SetColumn(B102, 2) : Grid.SetColumn(B106, 2)
      Grid.SetColumn(B103, 1) : Grid.SetColumn(B104, 2) : Grid.SetColumn(B107, 1) : Grid.SetColumn(B108, 2)

      Grid.SetRow(B100, 2) : Grid.SetRow(B101, 0) : Grid.SetRow(B105, 0) : Grid.SetRow(B103, 2) : Grid.SetRow(B104, 2)
      Grid.SetRow(B107, 2) : Grid.SetRow(B108, 2) : Grid.SetRow(B200, 2) : Grid.SetRow(B300, 2) : Grid.SetRow(C100, 4)

      _FA = ("0´1´0´2´0´3´0´4´1´1´1´2´1´3´1´4´2´1´2´2´2´3´2´4´3´1´3´2´3´3´3´4´0´6´0´7´0´8´0´9´1´6´1´7´1´8´1´9´2´6´2´7´2´" &
        "8´2´9´3´6´3´7´3´8´3´9´0´11´0´12´0´13´0´14´1´11´1´12´1´13´1´14´2´11´2´12´2´13´2´14´3´11´3´12´3´13´3´14").Split("´")

      For i As Byte = 0 To 95 Step 2 : AAA = i / 2 : ACAA(C100.Children.Item(AAA)).VerticalAlignment = 3
        ACAA(C100.Children.Item(AAA)).HorizontalAlignment = 3 : Grid.SetRow(C100.Children.Item(AAA), CInt(_FA(i)))
        Grid.SetColumn(C100.Children.Item(AAA), CInt(_FA(i + 1))) : ACAA(C100.Children.Item(AAA)).Background =
          New SolidColorBrush(Colors.White) : ACAA(C100.Children.Item(AAA)).Foreground = New SolidColorBrush(Colors.Blue)
      Next

      AAB = 1 : A_B_() : Catch ex As Exception : End Try
  End Sub
  Private Sub A_B_() Handles AAA0.SizeChanged
    ' Size Changed
    Try : If AAA0.ActualWidth > 1.5 * AAA0.ActualHeight Then
        If AAA <> 1 Then : AAA = 1 : BAA = AAA0.ActualHeight / 500 : End If : AAAA() : Else
        If AAA <> 2 Then : AAA = 2 : BAA = AAA0.ActualHeight / 550 : End If : AAAA() : End If
    Catch ex As Exception : End Try
  End Sub
#End Region ' *****
#Region "A100"
  Private Sub A_AA()
    AAB = 1 : AAAA()
  End Sub
  Private Sub A_AB()
    AAB = 2 : AAAA()
  End Sub
  Private Sub A_AC()
  End Sub
  Private Sub A_AD()
  End Sub
  Private Sub A_AE()
  End Sub
  Private Sub A_AF()
  End Sub
  Private Sub A_AG()
  End Sub
  Private Sub A_AH()
  End Sub
  Private Sub A_AI()
    AACA()
  End Sub
  Private Sub A_AJ()
    AACB()
  End Sub
#End Region ' *****
#Region "B100"
  Private Sub B_AA(sender As AutoSuggestBox, e As AutoSuggestBoxTextChangedEventArgs)
    'Try
    '  Dim aaaab As New List(Of String)
    '  '1     Löschen alter Definitionen
    '  AEAX() : If B101.Text = "" Then Exit Sub
    '  '2     Autosuggestboxsplit
    '  FAA = B101.Text.TrimEnd(" ").Split(" ")
    '  '4     Gleichung-Platz-Zeiger
    '  If B101.Text.Length > 1 Then
    '    Select Case B101.Text.Substring(0, 2)
    '      Case NAD.GetString("B001"), NAD.GetString("B002")
    '        B103.PlaceholderText = NAD.GetString("A051")
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
    '  B104.Document.SetText(TextSetOptions.FormatRtf, "")
    '  B104.Document.Selection.Text = NAD.GetString("A151") & " A1"
    '  'B004.Document.Selection.Text += ex.HelpLink & vbCrLf
    '  'B004.Document.Selection.Text += ex.Message & vbCrLf
    '  'B004.Document.Selection.Text += ex.Source & vbCrLf
    '  'B004.Document.Selection.Text += ex.StackTrace & vbCrLf
    'End Try
  End Sub
#End Region ' *****
#Region "B200"
  Private Sub B_BA()
    ApplicationData.Current.LocalSettings.Values("upgrade") = "xxxx" : AAB = 3
    AAAA() : ABAA(5) : B104.FontFamily = New FontFamily("Segoe UI")
    ' Rechner
    ABAB(Colors.AliceBlue, Colors.Blue, NAD.GetString("A000") & vbLf)
    ABAB(Colors.White, Colors.Black, vbLf & NAE.GetString("A001") & vbLf & vbLf)
    ' Upgrade
    ABAB(Colors.AliceBlue, Colors.Lime, NAD.GetString("E001") & vbLf)
    ABAB(Colors.White, Colors.Black, vbLf & NAE.GetString("A002"))
  End Sub
  Private Sub B_BB()

    'AAA = 3 : AEAA() : AIAB() : AIAM(0) : AIAP(0)
    'C004.FontFamily = New FontFamily("Consolas")
    '' Style
    'AIAZ() : AIAE(Colors.BlueViolet)
    'AIAH(NAD.GetString("E002") & vbLf & vbLf & vbLf)
    'AIAZ() : AIAE(Colors.Gray)
    'AIAJ(NAD.GetString("E201") & "		")
    'AIAJ(
    '  NAD.GetString("E202") & vbLf & vbLf) : AIAZ()
    'AIAE(Colors.BlueViolet) : AIAF(Colors.AliceBlue)
    '_N = C004.Document.Selection.StoryLength - 1
    'AIAJ("ab			a ^ b" & vbLf & vbLf)
    'AIAM(_N + 1) : AIAN(_N + 2) : AHAA() : AIAZ()
    'AIAE(Colors.BlueViolet) : AIAF(Colors.AliceBlue)
    '_N = C004.Document.Selection.StoryLength - 1
    'AIAJ("b√a			√(a ' b)" & vbLf & vbLf)
    'AIAM(_N) : AIAN(_N + 1) : AHAA() : AIAZ()
    'AIAE(Colors.BlueViolet) : AIAF(Colors.AliceBlue)
    '_N = C004.Document.Selection.StoryLength - 1
    'AIAJ("logab			log(a ' b)" & vbLf & vbLf)
    'AIAM(_N + 3) : AIAN(_N + 4) : AHAB() : AIAZ()
    'AIAE(Colors.BlueViolet) : AIAF(Colors.AliceBlue)
    '_N = C004.Document.Selection.StoryLength - 1
    'AIAJ("limab			lim(a ' b)" & vbLf & vbLf)
    'AIAM(_N + 3) : AIAN(_N + 4) : AHAB() : AIAZ()
    'AIAE(Colors.BlueViolet) : AIAF(Colors.AliceBlue)
    '_N = C004.Document.Selection.StoryLength - 1
    'AIAJ("Ʃab c			Ʃ(a ' b ' c)" & vbLf & vbLf)
    'AIAM(_N + 1) : AIAN(_N + 2) : AHAB()
    'AIAM(_N + 2) : AIAN(_N + 3) : AHAA() : AIAZ()
    'AIAE(Colors.BlueViolet) : AIAF(Colors.AliceBlue)
    '_N = C004.Document.Selection.StoryLength - 1
    'AIAJ("∏ab c			∏(a ' b ' c)" & vbLf & vbLf)
    'AIAM(_N + 1) : AIAN(_N + 2) : AHAB()
    'AIAM(_N + 2) : AIAN(_N + 3) : AHAA() : AIAZ()
    'AIAE(Colors.BlueViolet) : AIAF(Colors.AliceBlue)
    '_N = C004.Document.Selection.StoryLength - 1
    'AIAJ("a∫b x dx		∫(a ' b ' x d(x))")
    'AIAM(_N) : AIAN(_N + 1) : AHAB() : AIAM(_N + 2)
    'AIAN(_N + 3) : AHAA()

  End Sub
  Private Sub B_BC()
  End Sub
  Private Sub B_BD()
  End Sub
  Private Sub B_BE()
  End Sub
  Private Sub B_BF()
    AAB = 3 : AAAA() : ABAA(5) : B104.FontFamily = New FontFamily("Consolas")
    ' Mathematik - Formeln
    ABAB(Colors.AliceBlue, Colors.Blue, "   " & NAD.GetString("E003") & "   " & vbLf & vbLf)
    ABAB(Colors.White, Colors.Green, NAD.GetString("E101") & vbLf)
    ABAB(Colors.White, Colors.Blue, "a = a" & vbLf & vbLf)
    ABAB(Colors.White, Colors.Green, NAD.GetString("E102") & vbLf)
    ABAB(Colors.White, Colors.Blue, "a = b" & vbLf & vbLf)
    ABAB(Colors.White, Colors.Blue, "a = b" & vbLf & vbLf)
    ABAB(Colors.White, Colors.Green, NAD.GetString("E103") & vbLf)
    ABAB(Colors.White, Colors.Blue, "e = 2,718281828" & vbLf & vbLf)
    ABAB(Colors.White, Colors.Green, NAD.GetString("E104") & vbLf)
    ABAB(Colors.White, Colors.Blue, "π = 3,141592654" & vbLf & vbLf)
    ABAB(Colors.White, Colors.Green, NAD.GetString("E105") & vbLf)
    ABAB(Colors.White, Colors.Blue, "(a) = a
a + (b +- c) = a + b +- c
a - (b +- c) = a - b -+ c
a · (b ·: c) = a · b ·: c
a : (b ·: c) = a : b :· c" & vbLf & vbLf)
    ABAB(Colors.White, Colors.Green, NAD.GetString("E106") & vbLf)
    ABAB(Colors.White, Colors.Blue, "|-a| = |a|
|a| = a    a ≥ 0
|a| = -a   a < 0" & vbLf & vbLf)
    ABAB(Colors.White, Colors.Green, NAD.GetString("E107") & vbLf)
    ABAB(Colors.White, Colors.Blue, "a +- 0 = a
a · 0 = 0
a ^ 0 = 1
a / 0 = ∞" & vbLf & vbLf)
    ABAB(Colors.White, Colors.Green, NAD.GetString("E108") & vbLf)
    ABAB(Colors.White, Colors.Blue, "a ·: 1 = a
a ^ 1 = a" & vbLf & vbLf)
    ABAB(Colors.White, Colors.Green, NAD.GetString("E109") & vbLf)
    ABAB(Colors.White, Colors.Blue, "a - a = 0
a / a = 1" & vbLf & vbLf)
    ABAB(Colors.White, Colors.Green, NAD.GetString("E110") & vbLf)
    ABAB(Colors.White, Colors.Blue, "a + -b = a - b
a - -b = a + b
-a ·: -b = a ·: b
a ·: -b = -a ·: b" & vbLf & vbLf)
    ABAB(Colors.White, Colors.Green, NAD.GetString("E111") & vbLf)
    ABAB(Colors.White, Colors.Blue, "cos(a) = b
sin(a) = b
tan(a) = b
cot(a) = b
acos(a) = b
asin(a) = b
atan(a) = b
acot(a) = b" & vbLf & vbLf)
    ABAB(Colors.White, Colors.Green, NAD.GetString("E112") & vbLf)
    ABAB(Colors.White, Colors.Blue, "ln(a) = b
ln(e) = 1
log(a ' b) = с" & vbLf & vbLf)
    ABAB(Colors.White, Colors.Green, NAD.GetString("E113") & vbLf)
    ABAB(Colors.White, Colors.Blue, "a! = a · (a - 1) · ... · 1    a < 170" & vbLf & vbLf)
    ABAB(Colors.White, Colors.Green, NAD.GetString("E114") & vbLf)
    ABAB(Colors.White, Colors.Blue, "a´ = 0" & vbLf & vbLf)
    ABAB(Colors.White, Colors.Green, NAD.GetString("E115") & vbLf)
    ABAB(Colors.White, Colors.Blue, "a´ = 0" & vbLf & vbLf)
    ABAB(Colors.White, Colors.Gray, NAD.GetString("A900") & vbLf & "b + a = a + b
b · a = a · b
(a + b) · c = a · c + b · c
(a + b) : c = a : c + b : c
(a - b) · c = a · c - b · c
(a - b) : c = a : c - b : c
(a + b) · (c + d) = a c + a d + b c + b d
a + a = a · (1 + 1)
a · c + b · c = (a + b) · c
a ± b : c = (a c ± b) / c
a : b ± c = (a ± c b) / b
a : b ± c : b = (a ± c) / b
a : b ± c : d = (a d ± c b) / b : d
a · a = a ^ 2
a ^ b ^ c = a ^ (b · c)
a ^ b ·: a ^ c = a ^ (b ± c)
a ^ (b +- c) = a ^ b ·: a ^ c
a ^ b ^ c = a ^ (b · c)
(a ·: b) ^ c = a ^ c ·: b ^ c
a ^ b = c => a = √(c ' b)
a ^ (b ± c) = a ^ b ·: a ^ c
a ^ c ·: b ^ c = (a ·: b) ^ c
(a ·: b) ^ c = a ^ c ·: b ^ c
a ^ -b = 1 : a ^ b
a ^ b = 1 : a ^ -b
a ˄ (b ·: c) = a ˄ b ˄˅ c
√(a ·: b) = √(a) ·: √(b)
√(a) ·: √(b) = √(a ·: b)
√(a ·: b ' c) = √(a ' c) ·: √(b ' c)
√(a ' c) ·: √(b ' c) = √(a ·: b ' c)
√(a ' c) = a ^ (1 : c)
lim(a → ∞ ' b ^ a) = 0, |b| < 1
log(a ' b) = ln(b) : ln(a)
Ʃ(a = 1 ' b ' a) = b (b + 1) : 2
Ʃ(a = 1 ' b ' a ^ 2) = (2 b ^ 3 + 3 b ^ 2 + b) : 6
Ʃ(a = 1 ' b ' a ^ 3) = (b ^ 4 + 2 b ^ 3 + b ^ 2) : 4
Ʃ(a = 0 ' b ' c ^ a) = (1 - c ^ (b + 1)) : (1 - c)
∏(a = 1 ' b ' a) = b!
ʃ(a ' b ' c · d(c)) = (b ^ 2 - a ^ 2) : 2
a = b +- c => a -+ c = b
a = b ·: c => a :· c = b
a = b +· c => a -: b = c
a = b -: c => b -: a = c
a +- b = c => a = c -+ b
a ·: b = c => a = c :· b
a +· b = c => b = c -: a
a -: b = c => b = a -: c
-a = b => a = -b
a ^ 2 b + a c + d = 0 => a = (-c ± √ (c ^ 2 - 4 a d)) : 2 : b
a ^ b = e ^ (b · ln(a))
e ^ ln(a) = a
log(a ' b · c) = log(a ' b) + log(a ' c)
ln(a ·: b) = ln(a) +- ln(b)
ln(a ^ b) = b · ln(a)
ln(e ^ a) = a")
    '_EA = Color.FromArgb(255, 0, 176, 80)
    'B104.Document.Selection.CharacterFormat.Weight = 0
  End Sub
  Private Sub B_BG()
    AAB = 3 : AAAA() : ABAA(5) : B104.FontFamily = New FontFamily("Consolas")
    ' Chemie - Formeln
    ABAB(Colors.AliceBlue, Colors.Blue, "   " & NAD.GetString("E004") & "   " & vbLf &
         vbLf) : ABAB(Colors.White, Colors.Green, "c = n / V" & vbLf & "M = m / n")
  End Sub
  Private Sub B_BH()
    AAB = 3 : AAAA() : ABAA(10) : B104.FontFamily = New FontFamily("Consolas")
    ' Physik - Formeln
    ABAB(Colors.AliceBlue, Colors.Blue, "   " & NAD.GetString("E005") & "   " & vbLf & vbLf)
    ABAB(Colors.White, Colors.Green, NAD.GetString("A109") & vbLf)
    ABAB(Colors.White, Colors.DarkViolet, "a = Δv / Δt
ΔEk = Ek2 - Ek1
ΔEp = Ep2 - Ep1
F = a m
Ff = k Δs
Frg = μg |Fn|
Frh = μh |Fn|
Frr = μr |Fn|
P = W / Δt
p = m v
Δs = s2 - s1
Δt = t2 - t1
v = Δs / Δt
Δv = v2 - v1
Δv {v} = (v2 ^ 2 - v1 ^ 2)/2
{v} = Δs / Δt
{v} = (v1 + v2) / 2
W = F Δs
W = ΔEk
W = -ΔEp" & vbLf & vbLf)
    ABAB(Colors.White, Colors.Green, NAD.GetString("E051") & vbLf)
    ABAB(Colors.White, Colors.DarkViolet, "A = Ax
A = Ay
A = Az
A = Ax : cos(θ)
A = Ay : sin(θ)
A = Az : cos(θ)
A = Ax : cos(θ) : sin(ϕ)
A = Az : cos(θ) : cos(ϕ)
A = √(Ax2 + Ay2)
A = √(Ax2 + Az2)
A = √(Ay2 + Az2)
A = √(Ax2 + Ay2 + Az2)")
  End Sub
  Private Sub B_BI()
    AAB = 3 : AAAA() : ABAA(10) : B104.FontFamily = New FontFamily("Consolas")
    ' Dimensionen
    ABAB(Colors.AliceBlue, Colors.Blue, "   " & NAD.GetString("A109") & "   " & vbLf & vbLf)
    For i = 1 To 87 Step 1 : _AA = If(i < 10, "00", "0") & CStr(i)
      ABAB(Colors.White, Colors.Blue, (NAC.GetString("B" & _AA) & "       ").Substring(0, 8))
      ABAB(Colors.White, Colors.DeepSkyBlue, NAD.GetString("C" & _AA) & vbLf) : Next
  End Sub
  Private Sub B_BJ()
  End Sub
#End Region ' *****
#Region "C100"
  Private Sub C_AA()

  End Sub
#End Region ' *****
#End Region
  ' * □□□□ * □□□□ * □□□□ * □□□□ *
#Region "□□□□"
  ' * AAAA * AAAA * AAAA * AAAA *
#Region "AAAA"
#Region "A-AA"
  Private Sub AAAA()
    ' Quer-Hoch-Formaten-Seiten
    Select Case 100 * AAA + AAB
      Case = 101 ' Q-Start
#Region ""
        ' H-S => Q-S : Q-A° => Q-S
        AAAB() : A_01.Background = New SolidColorBrush(Colors.AliceBlue)
        AABA() : Grid.SetColumn(B101, 1) : Grid.SetColumn(B105, 1)
        Grid.SetRow(B102, 0) : Grid.SetRow(B106, 0)
        AA00.RowDefinitions.Item(0).Height = New GridLength(1, 2)
        B100.RowDefinitions.Item(1).Height = New GridLength(0, 2)
        B100.ColumnDefinitions.Item(1).Width = New GridLength(7, 2)
        B100.ColumnDefinitions.Item(2).Width = New GridLength(11, 2)
        C100.ColumnDefinitions.Item(0).Width = New GridLength(1, 2)
        C100.ColumnDefinitions.Item(15).Width = New GridLength(9, 2)
        For i = 5 To 14 Step 1 : C100.ColumnDefinitions.Item(i).
            Width = New GridLength(1, 2) : Next
#End Region
      Case = 102 ' Q-Anhang
#Region ""
        ' H-A => Q-A : Q-A° => Q-A
        AAAB() : AABB()
        A_01.Background = New SolidColorBrush(Colors.AliceBlue)
        AA00.RowDefinitions.Item(0).Height = New GridLength(1, 2)
#End Region
      Case = 103 ' Q-Listen
#Region ""
        ' Q-A => Q-L,   H-L => Q-L
        AAAB() : AABC() : Grid.SetRow(A100, 0) ' H-S=>H-A=>H-L=>Q-L
        AA00.RowDefinitions.Item(0).Height = New GridLength(1, 2)
        B100.ColumnDefinitions.Item(2).Width = New GridLength(18, 2)
#End Region
      Case = 104 ' Q-Beispiele
#Region ""
        AAAB()
#End Region
      Case = 105 ' Q-Tabelle
#Region ""
        AAAB()

        '_AA = "0´0´0´0´1´1´1´1´1´1´1´1´1´1´1´1´1´1´1´1´1´"
        '_AA &= "1´1´2´2´2´3´3´3´3´3´3´3´3´3´4´4´4´4´4´4´4´"
        '_AA &= "4´4´5´5´5´5´5´5´5´5´5´5´5´5´5´5´5´5´5´5´5´"
        '_AA &= "6´6´6´6´6´6´6´6´6´6´6´6´6´6´6´6´6´6´6´7´7´"
        '_AA &= "7´7´7´7´7´7´7´7´7´7´7´7´7´7´7´7´7´8´8´8´8´"
        '_AA &= "8´8´8´8´8´8´8´8´8´8´8´8´8´8´8´9´9´9´9´9´9´"
        '_AA &= "9´9´9´9´9´9´9´9´9´10´10´10´10´10´10´10´10´"
        '_AA &= "10´10´10´10´10´10´10" : _FA = _AA.Split("´")
        'For i = 0 To 149 Step 1 : Grid.
        '  SetRow(D000.Children.Item(i), CInt(_FA(i))) : Next
        '_AA = "1´3´14´19´0´1´2´3´5´6´7´8´9´10´11´12´13´14´15´"
        '_AA &= "16´17´18´19´0´1´19´0´1´2´14´15´16´17´18´19´"
        '_AA &= "0´1´2´14´15´16´17´18´19´0´1´2´3´5´6´7´8´9´10´"
        '_AA &= "11´12´13´14´15´16´17´18´19´0´1´2´3´5´6´7´8´9´"
        '_AA &= "10´11´12´13´14´15´16´17´18´19´0´1´2´3´5´6´7´"
        '_AA &= "8´9´10´11´12´13´14´15´16´17´18´19´0´1´2´3´5´"
        '_AA &= "6´7´8´9´10´11´12´13´14´15´16´17´18´19´4´5´6´"
        '_AA &= "7´8´9´10´11´12´13´14´15´16´17´18´4´5´6´7´8´"
        '_AA &= "9´10´11´12´13´14´15´16´17´18" : _FA = _AA.
        'Split("´") : For i = 0 To 149 Step 1 : Grid.
        '  SetColumn(C100.Children.Item(i), CInt(_FA(i))) : Next

#End Region
      Case = 106 ' Q-Elemente
#Region ""
        AAAB()

#End Region
      Case = 201 ' H-Start
#Region ""
        ' Q-S => H-S : H-A° => H-S
        AAAB() : Grid.SetColumn(B101, 2) : Grid.SetRow(B102, 1)
        AABA() : Grid.SetColumn(B105, 2) : Grid.SetRow(B106, 1)
        A_01.Visibility = 1
        AA00.RowDefinitions.Item(0).Height = New GridLength(0, 2)
        B100.RowDefinitions.Item(1).Height = New GridLength(1, 2)
        B100.ColumnDefinitions.Item(1).Width = New GridLength(0, 2)
        B100.ColumnDefinitions.Item(2).Width = New GridLength(14, 2)
        C100.ColumnDefinitions.Item(0).Width = New GridLength(0.3, 2)
        C100.ColumnDefinitions.Item(5).Width = New GridLength(0, 2)
        C100.ColumnDefinitions.Item(10).Width = New GridLength(0, 2)
        C100.ColumnDefinitions.Item(15).Width = New GridLength(0.3, 2)
        A109.Content = If(A109.Content = "A1", "A2", "A1") : AACA()
        A110.Content = If(A110.Content = "B1", "B2", "B1") : AACB()
#End Region
      Case = 202 ' H-Anhang
#Region ""
        ' Q-A => H-A : H-A° => H-A
        AAAB() : AABB()
        AA00.RowDefinitions.Item(0).Height = New GridLength(0, 2)
#End Region
      Case = 203 ' H-Listen
#Region ""
        ' Q-A => Q-L,   H-L => Q-L
        AAAB() : AABC() : Grid.SetRow(A100, 3)
        AA00.RowDefinitions.Item(0).Height = New GridLength(0, 2)
        B100.ColumnDefinitions.Item(2).Width = New GridLength(14, 2)
        A109.Content = If(A109.Content = "A1", "A2", "A1") : AACA()
        A110.Content = If(A110.Content = "B1", "B2", "B1") : AACB()
#End Region
      Case = 205 ' H-Beispiele
#Region ""
        AAAB()
#End Region
      Case = 205 ' H-Tabelle
#Region ""
        AAAB()
#End Region
      Case = 206 ' H-Elemente
#Region ""
        AAAB()
#End Region
    End Select
  End Sub
  Private Sub AAAB()
    ' A°:Q-H: Alle Q oder H
    If AAA = 1 Then : A_01.Visibility = 0 : Grid.SetRow(A100, 0)
      A109.Visibility = 1 : A110.Visibility = 1
      A100.ColumnDefinitions.Item(0).Width = New GridLength(0, 2)
      A100.ColumnDefinitions.Item(5).Width = New GridLength(1, 2)
      A100.ColumnDefinitions.Item(6).Width = New GridLength(1, 2)
      A100.ColumnDefinitions.Item(7).Width = New GridLength(1, 2)
      A100.ColumnDefinitions.Item(8).Width = New GridLength(1, 2)
      A100.ColumnDefinitions.Item(11).Width = New GridLength(3, 2)
    Else : A109.Visibility = 0
      A100.ColumnDefinitions.Item(0).Width = New GridLength(0.3, 2)
      A100.ColumnDefinitions.Item(11).Width = New GridLength(0.3, 2)
      A110.Visibility = 0 : Grid.SetRow(A100, 3) : End If
  End Sub
  Private Sub AABA()
    ' S:Q-H: Start: Q und H
    B100.Visibility = 0 : B200.Visibility = 1 : B300.Visibility = 1 : C100.Visibility = 0 : Grid.SetRow(A_01, 3)
    AA00.RowDefinitions.Item(1).Height = New GridLength(1, 2) : AA00.RowDefinitions.Item(2).Height = New GridLength(12, 2)
    AA00.RowDefinitions.Item(4).Height = New GridLength(6, 2) : B100.RowDefinitions.Item(0).Height = New GridLength(1, 2)
    B100.RowDefinitions.Item(2).Height = New GridLength(7, 2)
  End Sub
  Private Sub AABB()
    ' A:Q-H: Anhang: Q und H
    A_01.Visibility = 0 : B100.Visibility = 1 : B200.Visibility = 0 : B300.Visibility = 1 : C100.Visibility = 1
    Grid.SetRow(A_01, 4)
    AA00.RowDefinitions.Item(1).Height = New GridLength(0, 2) : AA00.RowDefinitions.Item(2).Height = New GridLength(14, 2)
    AA00.RowDefinitions.Item(4).Height = New GridLength(3, 2) : If B200.RowDefinitions.Count > 0 Then Exit Sub

    For i = 1 To 12 Step 1
      B200.ColumnDefinitions.Add(New ColumnDefinition) : B200.RowDefinitions.Add(New RowDefinition) : Next

    ToolTipService.SetToolTip(B201, New ToolTip With {.Content = NAD.GetString("A101"), .Placement = PlacementMode.Right})
    ToolTipService.SetToolTip(B202, New ToolTip With {.Content = NAD.GetString("A102"), .Placement = PlacementMode.Right})
    ToolTipService.SetToolTip(B203, New ToolTip With {.Content = NAD.GetString("A103"), .Placement = PlacementMode.Right})
    ToolTipService.SetToolTip(B204, New ToolTip With {.Content = NAD.GetString("A104"), .Placement = PlacementMode.Right})
    ToolTipService.SetToolTip(B205, New ToolTip With {.Content = NAD.GetString("A105"), .Placement = PlacementMode.Right})
    ToolTipService.SetToolTip(B206, New ToolTip With {.Content = NAD.GetString("A106"), .Placement = PlacementMode.Right})
    ToolTipService.SetToolTip(B207, New ToolTip With {.Content = NAD.GetString("A107"), .Placement = PlacementMode.Right})
    ToolTipService.SetToolTip(B208, New ToolTip With {.Content = NAD.GetString("A108"), .Placement = PlacementMode.Right})
    ToolTipService.SetToolTip(B209, New ToolTip With {.Content = NAD.GetString("A109"), .Placement = PlacementMode.Right})
    ToolTipService.SetToolTip(B210, New ToolTip With {.Content = NAD.GetString("A110"), .Placement = PlacementMode.Right})

    Grid.SetRow(B201, 1) : Grid.SetColumn(B201, 1) : Grid.SetRow(B202, 3) : Grid.SetColumn(B202, 1) : Grid.SetRow(B203, 5)
    Grid.SetColumn(B203, 1) : Grid.SetRow(B204, 7) : Grid.SetColumn(B204, 1) : Grid.SetRow(B205, 9) : Grid.SetColumn(B205, 1)
    Grid.SetRow(B206, 1) : Grid.SetColumn(B206, 3) : Grid.SetRow(B207, 3) : Grid.SetColumn(B207, 3) : Grid.SetRow(B208, 5)
    Grid.SetColumn(B208, 3) : Grid.SetRow(B209, 7) : Grid.SetColumn(B209, 3) : Grid.SetRow(B210, 9) : Grid.SetColumn(B210, 3)

    B201.CornerRadius = New CornerRadius(5) : B202.CornerRadius = New CornerRadius(5)
    B203.CornerRadius = New CornerRadius(5) : B204.CornerRadius = New CornerRadius(5)
    B205.CornerRadius = New CornerRadius(5) : B206.CornerRadius = New CornerRadius(5)
    B207.CornerRadius = New CornerRadius(5) : B208.CornerRadius = New CornerRadius(5)
    B209.CornerRadius = New CornerRadius(5) : B210.CornerRadius = New CornerRadius(5)

    B201.BorderThickness = New Thickness(1) : B202.BorderThickness = New Thickness(1)
    B203.BorderThickness = New Thickness(1) : B204.BorderThickness = New Thickness(1)
    B205.BorderThickness = New Thickness(1) : B206.BorderThickness = New Thickness(1)
    B207.BorderThickness = New Thickness(1) : B208.BorderThickness = New Thickness(1)
    B209.BorderThickness = New Thickness(1) : B210.BorderThickness = New Thickness(1)

    B201.BorderBrush = New SolidColorBrush(Colors.Blue) : B202.BorderBrush = New SolidColorBrush(Colors.Blue)
    B203.BorderBrush = New SolidColorBrush(Colors.Blue) : B204.BorderBrush = New SolidColorBrush(Colors.Blue)
    B205.BorderBrush = New SolidColorBrush(Colors.Blue) : B206.BorderBrush = New SolidColorBrush(Colors.Blue)
    B207.BorderBrush = New SolidColorBrush(Colors.Blue) : B208.BorderBrush = New SolidColorBrush(Colors.Blue)
    B209.BorderBrush = New SolidColorBrush(Colors.Blue) : B210.BorderBrush = New SolidColorBrush(Colors.Blue)

    B201.Background = New SolidColorBrush(Colors.Transparent)
    B202.Background = New SolidColorBrush(Colors.Transparent)
    B203.Background = New SolidColorBrush(Colors.Transparent)
    B204.Background = New SolidColorBrush(Colors.Transparent)
    B205.Background = New SolidColorBrush(Colors.Transparent)
    B206.Background = New SolidColorBrush(Colors.Transparent)
    B207.Background = New SolidColorBrush(Colors.Transparent)
    B208.Background = New SolidColorBrush(Colors.Transparent)
    B209.Background = New SolidColorBrush(Colors.Transparent)
    B210.Background = New SolidColorBrush(Colors.Transparent)
    ' Anhang - Background
    B200.Background = New LinearGradientBrush With {.StartPoint = New Point(0.5, 0), .EndPoint = New Point(0.5, 1),
      .GradientStops = New GradientStopCollection From {New GradientStop With {.Color = Colors.SkyBlue, .Offset = 0},
      New GradientStop With {.Color = Colors.White, .Offset = 1}}}
    ' Icons 1-9
    For i = 0 To 8 Step 1 : ACAA(B200.Children.Item(i)).Content = New Image With {.Source = New BitmapImage With
        {.UriSource = New Uri("ms-appx:///Assets/A_A_00" & CStr(i + 1) & ".png")}} : Next
    ' Icon 10-99
    B210.Content = New Image With {.Source = New BitmapImage With {.UriSource = New Uri("ms-appx:///Assets/A_A_010.png")}}
  End Sub
  Private Sub AABC()
    ' L:Q-H: Listen: Q und H
    B100.Visibility = 0 : B200.Visibility = 1 : B103.Visibility = 1 : B104.Visibility = 0
    AA00.RowDefinitions.Item(1).Height = New GridLength(1, 2) : B100.RowDefinitions.Item(0).Height = New GridLength(0, 2)
    B100.RowDefinitions.Item(1).Height = New GridLength(0, 2) : B100.ColumnDefinitions.Item(1).Width = New GridLength(0, 2)
  End Sub
  Private Sub AACA()
    If A109.Content = "A1" Then : A109.Content = "A2"
      AAC = 0 : AAD = 1
    Else : A109.Content = "A1" : AAC = 1 : AAD = 0 : End If
    A100.ColumnDefinitions.Item(5).Width = New GridLength(AAC, 2)
    A100.ColumnDefinitions.Item(6).Width = New GridLength(AAC, 2)
    A100.ColumnDefinitions.Item(7).Width = New GridLength(AAD, 2)
    A100.ColumnDefinitions.Item(8).Width = New GridLength(AAD, 2)
  End Sub
  Private Sub AACB()
    If A110.Content = "B1" Then : A110.Content = "B2"
      AAC = 0 : AAD = 1
    Else : A110.Content = "B1" : AAC = 1 : AAD = 0 : End If
    C100.ColumnDefinitions.Item(6).Width = New GridLength(AAC, 2)
    C100.ColumnDefinitions.Item(7).Width = New GridLength(AAC, 2)
    C100.ColumnDefinitions.Item(8).Width = New GridLength(AAC, 2)
    C100.ColumnDefinitions.Item(9).Width = New GridLength(AAC, 2)
    C100.ColumnDefinitions.Item(11).Width = New GridLength(AAD, 2)
    C100.ColumnDefinitions.Item(12).Width = New GridLength(AAD, 2)
    C100.ColumnDefinitions.Item(13).Width = New GridLength(AAD, 2)
    C100.ColumnDefinitions.Item(14).Width = New GridLength(AAD, 2)
  End Sub
  Private Sub AAXA()
    ' Design
    A100.Background = New SolidColorBrush(Colors.AliceBlue)

    B105.Visibility = 1
    B106.Visibility = 1
    B107.Visibility = 1
    B108.Visibility = 1

  End Sub

  'Private Sub AIAS()
  '  Select Case B104.Document.Selection.
  '    CharacterFormat.ForegroundColor
  '    Case Colors.Black : AIAC(Colors.Blue)
  '    Case Colors.Blue : AIAC(Colors.Green)
  '    Case Colors.Green : AIAC(Colors.Pink)
  '    Case Colors.Pink : AIAC(Colors.Black)
  '    Case Else : AIAC(Colors.Black) : End Select
  'End Sub
#End Region ' *****
#Region "A-AB"
  Private Sub ABAA(a As Byte)
    B104.Document.SetText(TextSetOptions.FormatRtf, "") : B104.Document.Selection.ParagraphFormat.SpaceAfter = a ' * BAA
  End Sub
  Private Sub ABAB(a As Color, b As Color, c As String)
    B104.Document.Selection.StartPosition = B104.Document.Selection.StoryLength - 1
    B104.Document.Selection.CharacterFormat.BackgroundColor = a
    B104.Document.Selection.CharacterFormat.ForegroundColor = b : B104.Document.Selection.Text += c
  End Sub
#End Region ' *****
#Region "A-AC"
  Private Function ACAA(a As Button) As Button
    Return a
  End Function
#End Region ' *****
#End Region
  ' * BBBB * BBBB * BBBB * BBBB *
#Region "BBBB"

#End Region
  ' * CCCC * CCCC * CCCC * CCCC *
#Region "CCCC"

#End Region
  ' * DDDD * DDDD * DDDD * DDDD *
#Region "DDDD"

#End Region
  ' * EEEE * EEEE * EEEE * EEEE *
#Region "EEEE"

#End Region
#End Region
End Class