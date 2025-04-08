Imports Windows.Storage
Imports Windows.UI.Xaml
Imports Windows.UI.Xaml.Shapes
Imports Windows.UI.Xaml.Controls
Imports Windows.Networking.Connectivity
Imports Windows.ApplicationModel.Email
Imports Windows.ApplicationModel.Resources
Imports Windows.UI : Imports Windows.UI.Text
Public NotInheritable Class MainPage
  ' بِسْمِ اللَّهِ الرَّحْمَـٰنِ الرَّحِيمِ
  Inherits Page
  ' * ≡≡≡≡ * ≡≡≡≡ * ≡≡≡≡ * ≡≡≡≡ *
#Region "≡≡≡≡"
#Region "A-00"
  ' Deklaration
  Dim _N, _M, _O As Integer
  Dim A_ As DispatcherTimer

  Dim _AA, _AB, _AC As String

  Dim _FA() As String

  Dim AAA, AAB, AAC, AAD, AAE, AAF, AAG As Byte : Dim BAA As Double

  Dim NAA As New ResourceLoader("A_a_a_a_a") : Dim NAB As New ResourceLoader("A_a_a_a_b")
  Dim NAC As New ResourceLoader("A_b_a_a_a")
  Dim NAD As New ResourceLoader("Resources") : Dim NAE As New ResourceLoader("Source_aa")

  'Dim SAA As New List(Of String)

  Dim A_01 As New Canvas
  Dim B_01 As New Button
  Dim C_01 As New ListView
  Dim D_01, D_02 As TextBlock
  Dim E_01 As New Line
#End Region ' *****
#End Region
  ' * ○○○○ * ○○○○ * ○○○○ * ○○○○ *
#Region "○○○○"
#Region "AAA0"
  Private Sub A_A_() Handles AAA0.Loaded
    Try
      ' Loaded
      B103.IsSpellCheckEnabled = False : B104.IsSpellCheckEnabled = False : D_01 = New TextBlock : D_02 = New TextBlock

      A101.Foreground = New SolidColorBrush(Colors.Blue) : A102.Foreground = New SolidColorBrush(Colors.Blue)
      A103.Foreground = New SolidColorBrush(Colors.Blue) : A104.Foreground = New SolidColorBrush(Colors.Blue)
      A105.Foreground = New SolidColorBrush(Colors.Blue) : A106.Foreground = New SolidColorBrush(Colors.Blue)
      A107.Foreground = New SolidColorBrush(Colors.Blue) : A108.Foreground = New SolidColorBrush(Colors.Blue)
      A109.Foreground = New SolidColorBrush(Colors.Blue) : A110.Foreground = New SolidColorBrush(Colors.Blue)

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

      A101.VerticalAlignment = 3 : A101.HorizontalAlignment = 3 : A102.VerticalAlignment = 3 : A102.HorizontalAlignment = 3
      A103.VerticalAlignment = 3 : A103.HorizontalAlignment = 3 : A104.VerticalAlignment = 3 : A104.HorizontalAlignment = 3
      A105.VerticalAlignment = 3 : A105.HorizontalAlignment = 3 : A106.VerticalAlignment = 3 : A106.HorizontalAlignment = 3
      A107.VerticalAlignment = 3 : A107.HorizontalAlignment = 3 : A108.VerticalAlignment = 3 : A108.HorizontalAlignment = 3
      A109.VerticalAlignment = 3 : A109.HorizontalAlignment = 3 : A110.VerticalAlignment = 3 : A110.HorizontalAlignment = 3
      B101.VerticalAlignment = 3 : B101.HorizontalAlignment = 3 : B102.VerticalAlignment = 3 : B102.HorizontalAlignment = 3

      If ApplicationData.Current.LocalSettings.Values("upgrade") <> "18.02.2022" Then
        B104.FontFamily = New FontFamily("Segoe UI")
        ABAF(5) : ABAH(Colors.White, Colors.Lime, NAD.GetString("E001") & vbCrLf)
        ABAF(5) : ABAH(Colors.White, Colors.Black, NAE.GetString("A002")) : End If

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
      For i = 1 To 5 Step 1 : B100.ColumnDefinitions.Add(New ColumnDefinition) : Next
      For i = 1 To 4 Step 1 : C100.RowDefinitions.Add(New RowDefinition) : Next
      For i = 1 To 16 Step 1 : C100.ColumnDefinitions.Add(New ColumnDefinition) : Next

      AA00.Children.Add(A_01)
      Grid.SetColumn(A101, 1) : Grid.SetColumn(A102, 2) : Grid.SetColumn(A103, 3) : Grid.SetColumn(A104, 4)
      Grid.SetColumn(A105, 5) : Grid.SetColumn(A106, 6) : Grid.SetColumn(A107, 7) : Grid.SetColumn(A108, 8)
      Grid.SetColumn(A109, 9) : Grid.SetColumn(A110, 10) : Grid.SetColumn(B102, 3) : Grid.SetColumn(B103, 1)
      Grid.SetColumn(B104, 3) : Grid.SetColumn(B106, 3) : Grid.SetColumn(B107, 1) : Grid.SetColumn(B108, 3)

      Grid.SetRow(B100, 2) : Grid.SetRow(B101, 0) : Grid.SetRow(B105, 0) : Grid.SetRow(B103, 2) : Grid.SetRow(B104, 2)
      Grid.SetRow(B107, 2) : Grid.SetRow(B108, 2) : Grid.SetRow(B200, 2) : Grid.SetRow(B300, 2) : Grid.SetRow(C100, 4)

      _FA = ("0´1´0´2´0´3´0´4´1´1´1´2´1´3´1´4´2´1´2´2´2´3´2´4´3´1´3´2´3´3´3´4´0´6´0´7´0´8´0´9´1´6´1´7´1´8´1´9´2´6´2´7´2´" &
        "8´2´9´3´6´3´7´3´8´3´9´0´11´0´12´0´13´0´14´1´11´1´12´1´13´1´14´2´11´2´12´2´13´2´14´3´11´3´12´3´13´3´14").Split("´")

      For i As Byte = 0 To 95 Step 2 : AAA = i / 2 : ACAD(C100.Children.Item(AAA)).VerticalAlignment = 3
        ACAD(C100.Children.Item(AAA)).HorizontalAlignment = 3 : Grid.SetRow(C100.Children.Item(AAA), CInt(_FA(i)))
        Grid.SetColumn(C100.Children.Item(AAA), CInt(_FA(i + 1))) : ACAD(C100.Children.Item(AAA)).Background =
          New SolidColorBrush(Colors.White) : ACAD(C100.Children.Item(AAA)).Foreground = New SolidColorBrush(Colors.Blue)
      Next

      AddHandler B101.GotFocus, AddressOf ABAC : AddHandler B103.GotFocus, AddressOf ABAC
      AddHandler B111.Tapped, AddressOf ABAE

      A_ = New DispatcherTimer With {.Interval = TimeSpan.FromMilliseconds(700)} : AddHandler A_.Tick, AddressOf A_C_

      B111.Children.Add(E_01) : AAB = 1 : B101.Focus(3) : AAXA() : A_B_() : Catch ex As Exception : End Try
  End Sub
  Private Sub A_B_() Handles AAA0.SizeChanged
    ' Size Changed
    Try : If AAA0.ActualWidth > 1.5 * AAA0.ActualHeight Then
        If AAA <> 1 Then : AAA = 1 : BAA = AAA0.ActualHeight / 500 : End If : AAAA() : Else
        If AAA <> 2 Then : AAA = 2 : BAA = AAA0.ActualHeight / 550 : End If : AAAA() : End If
    Catch ex As Exception : End Try
  End Sub
  Private Sub A_C_() ' sender As Object, e As Object
    Select Case E_01.Visibility : Case 0 : E_01.Visibility = 1 : Case 1 : E_01.Visibility = 0 : End Select
  End Sub
#End Region ' *****
#Region "A100"
  Private Sub A_AA()
    AAB = 1 : AAAA() : BAAA()
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
    AAAA() : ABAF(5) : B104.FontFamily = New FontFamily("Segoe UI")
    ' Rechner
    ABAH(Colors.AliceBlue, Colors.Blue, NAD.GetString("A000") & vbLf)
    ABAH(Colors.White, Colors.Black, vbLf & NAE.GetString("A001") & vbLf & vbLf)
    ' Upgrade
    ABAH(Colors.AliceBlue, Colors.Lime, NAD.GetString("E001") & vbLf)
    ABAH(Colors.White, Colors.Black, vbLf & NAE.GetString("A002"))
  End Sub
  Private Sub B_BB()
    AAB = 3 : AAAA() : ABAF(0) : B104.FontFamily = New FontFamily("Consolas") : _AA = "				"
    ABAH(Colors.AliceBlue, Colors.Blue, NAD.GetString("E002") & vbLf & vbLf & vbLf)
    ABAH(Colors.AliceBlue, Colors.Blue, NAD.GetString("E201") & _AA & NAD.GetString("E202") & vbLf & vbLf)
    _AA = "					"
    _N = 14 : _M = 13 : ABAH(Colors.AliceBlue, Colors.Blue, "ab" & _AA & "a ^ b" & vbLf & vbLf) : ABAA()
    _N = 19 : _M = 18 : ABAH(Colors.AliceBlue, Colors.Blue, "b√a" & _AA & "√(a ' b)" & vbLf & vbLf) : ABAA()
    _N = 20 : _M = 19 : ABAH(Colors.AliceBlue, Colors.Blue, "logab" & _AA & "log(a ' b)" & vbLf & vbLf) : ABAB()
    _N = 20 : _M = 19 : ABAH(Colors.AliceBlue, Colors.Blue, "limab" & _AA & "lim(a ' b)" & vbLf & vbLf) : ABAB()
    _N = 24 : _M = 23 : ABAH(Colors.AliceBlue, Colors.Blue, "Ʃab c" & _AA & "Ʃ(a ' b ' c)" & vbLf & vbLf) : ABAB()
    _N = 23 : _M = 24 : ABAA()
    _N = 24 : _M = 23 : ABAH(Colors.AliceBlue, Colors.Blue, "∏ab c" & _AA & "∏(a ' b ' c)" & vbLf & vbLf) : ABAB()
    _N = 33 : _M = 32 : ABAA() : _AA = "				"
    _N = 30 : _M = 29 : ABAH(Colors.AliceBlue, Colors.Blue, "a∫b x dx" & _AA & "∫(a ' b ' x d(x))") : ABAB()
    _N = 28 : _M = 27 : ABAA()
  End Sub
  Private Sub B_BC()
  End Sub
  Private Sub B_BD()
  End Sub
  Private Sub B_BE()
    Try : ADAA() : Catch ex As Exception : End Try
  End Sub
  Private Sub B_BF()
    AAB = 3 : AAAA() : ABAF(5) : B104.FontFamily = New FontFamily("Consolas")
    ' Mathematik - Formeln
    ABAH(Colors.AliceBlue, Colors.Blue, "   " & NAD.GetString("E003") & "   " & vbLf & vbLf)
    ABAH(Colors.White, Colors.Green, NAD.GetString("E101") & vbLf)
    ABAH(Colors.White, Colors.Blue, "a = a" & vbLf & vbLf)
    ABAH(Colors.White, Colors.Green, NAD.GetString("E102") & vbLf)
    ABAH(Colors.White, Colors.Blue, "a = b" & vbLf & vbLf)
    ABAH(Colors.White, Colors.Blue, "a = b" & vbLf & vbLf)
    ABAH(Colors.White, Colors.Green, NAD.GetString("E103") & vbLf)
    ABAH(Colors.White, Colors.Blue, "e = 2,718281828" & vbLf & vbLf)
    ABAH(Colors.White, Colors.Green, NAD.GetString("E104") & vbLf)
    ABAH(Colors.White, Colors.Blue, "π = 3,141592654" & vbLf & vbLf)
    ABAH(Colors.White, Colors.Green, NAD.GetString("E105") & vbLf)
    ABAH(Colors.White, Colors.Blue, "(a) = a
a + (b +- c) = a + b +- c
a - (b +- c) = a - b -+ c
a · (b ·: c) = a · b ·: c
a : (b ·: c) = a : b :· c" & vbLf & vbLf)
    ABAH(Colors.White, Colors.Green, NAD.GetString("E106") & vbLf)
    ABAH(Colors.White, Colors.Blue, "|-a| = |a|
|a| = a    a ≥ 0
|a| = -a   a < 0" & vbLf & vbLf)
    ABAH(Colors.White, Colors.Green, NAD.GetString("E107") & vbLf)
    ABAH(Colors.White, Colors.Blue, "a +- 0 = a
a · 0 = 0
a ^ 0 = 1
a / 0 = ∞" & vbLf & vbLf)
    ABAH(Colors.White, Colors.Green, NAD.GetString("E108") & vbLf)
    ABAH(Colors.White, Colors.Blue, "a ·: 1 = a
a ^ 1 = a" & vbLf & vbLf)
    ABAH(Colors.White, Colors.Green, NAD.GetString("E109") & vbLf)
    ABAH(Colors.White, Colors.Blue, "a - a = 0
a / a = 1" & vbLf & vbLf)
    ABAH(Colors.White, Colors.Green, NAD.GetString("E110") & vbLf)
    ABAH(Colors.White, Colors.Blue, "a + -b = a - b
a - -b = a + b
-a ·: -b = a ·: b
a ·: -b = -a ·: b" & vbLf & vbLf)
    ABAH(Colors.White, Colors.Green, NAD.GetString("E111") & vbLf)
    ABAH(Colors.White, Colors.Blue, "cos(a) = b
sin(a) = b
tan(a) = b
cot(a) = b
acos(a) = b
asin(a) = b
atan(a) = b
acot(a) = b" & vbLf & vbLf)
    ABAH(Colors.White, Colors.Green, NAD.GetString("E112") & vbLf)
    ABAH(Colors.White, Colors.Blue, "ln(a) = b
ln(e) = 1
log(a ' b) = с" & vbLf & vbLf)
    ABAH(Colors.White, Colors.Green, NAD.GetString("E113") & vbLf)
    ABAH(Colors.White, Colors.Blue, "a! = a · (a - 1) · ... · 1    a < 170" & vbLf & vbLf)
    ABAH(Colors.White, Colors.Green, NAD.GetString("E114") & vbLf)
    ABAH(Colors.White, Colors.Blue, "a´ = 0" & vbLf & vbLf)
    ABAH(Colors.White, Colors.Green, NAD.GetString("E115") & vbLf)
    ABAH(Colors.White, Colors.Blue, "a´ = 0" & vbLf & vbLf)
    ABAH(Colors.White, Colors.Gray, NAD.GetString("A900") & vbLf & "b + a = a + b
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
    AAB = 3 : AAAA() : ABAF(5) : B104.FontFamily = New FontFamily("Consolas")
    ' Chemie - Formeln
    ABAH(Colors.AliceBlue, Colors.Blue, "   " & NAD.GetString("E004") & "   " & vbLf &
         vbLf) : ABAH(Colors.White, Colors.Green, "c = n / V" & vbLf & "M = m / n")
  End Sub
  Private Sub B_BH()
    AAB = 3 : AAAA() : ABAF(10) : B104.FontFamily = New FontFamily("Consolas")
    ' Physik - Formeln
    ABAH(Colors.AliceBlue, Colors.Blue, "   " & NAD.GetString("E005") & "   " & vbLf & vbLf)
    ABAH(Colors.White, Colors.Green, NAD.GetString("A109") & vbLf)
    ABAH(Colors.White, Colors.DarkViolet, "a = Δv / Δt
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
    ABAH(Colors.White, Colors.Green, NAD.GetString("E051") & vbLf)
    ABAH(Colors.White, Colors.DarkViolet, "A = Ax
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
    AAB = 3 : AAAA() : ABAF(10) : B104.FontFamily = New FontFamily("Consolas")
    ' Dimensionen
    ABAH(Colors.AliceBlue, Colors.Blue, "   " & NAD.GetString("A109") & "   " & vbLf & vbLf)
    For i = 1 To 87 Step 1 : _AA = If(i < 10, "00", "0") & CStr(i)
      ABAH(Colors.White, Colors.Blue, (NAC.GetString("B" & _AA) & "       ").Substring(0, 8))
      ABAH(Colors.White, Colors.DeepSkyBlue, NAD.GetString("C" & _AA) & vbLf) : Next
  End Sub
  Private Sub B_BJ()
    AAB = 5 : AAAA()
  End Sub
#End Region ' *****
#Region "C100"
  Private Sub C_AA(a As Button, b As RoutedEventArgs)
    If _AC = "B101" Then : B101.Text = B101.Text.Insert(B101.SelectionStart, a.Content)
    Else : B103.Document.Selection.Text += a.Content : ABAG(a.Content) : End If
  End Sub
  Private Sub C_AB(a As Button, b As RoutedEventArgs)
    If _AC = "B101" Then B101.Text = B101.Text.Insert(B101.SelectionStart, "-")
    If B104.Visibility = 0 Then
      If _AC = "B103" Then B103.Document.Selection.Text += "-"
    Else

    End If
  End Sub
  Private Sub C_AC(a As Button, b As RoutedEventArgs)
    If _AC = "B101" Then B101.Text = B101.Text.Insert(B101.SelectionStart, " " & a.Content & " ")
    If B104.Visibility = 0 Then
      If _AC = "B103" Then B103.Document.Selection.Text += " " & a.Content & " "
    Else

    End If
  End Sub
  Private Sub C_AD(a As Button, b As RoutedEventArgs)
    If _AC = "B101" Then B101.Text = B101.Text.Insert(B101.SelectionStart, a.Content & "()")
    If B104.Visibility = 0 Then
      If _AC = "B103" Then B103.Document.Selection.Text += a.Content & "()"
    Else

    End If
  End Sub
  Private Sub C_AE(a As Button, b As RoutedEventArgs)
    If _AC = "B101" Then B101.Text = B101.Text.Insert(B101.SelectionStart, a.Content & "(')")
    If B104.Visibility = 0 Then
      If _AC = "B103" Then B103.Document.Selection.Text += a.Content & "(')"
    Else

    End If
  End Sub
  Private Sub C_AF(a As Button, b As RoutedEventArgs)
    If _AC = "B101" Then B101.Text = B101.Text.Insert(B101.SelectionStart, a.Content & "('')")
    If B104.Visibility = 0 Then
      If _AC = "B103" Then B103.Document.Selection.Text += a.Content & "('')"
    Else

    End If
  End Sub
  Private Sub C_AG(a As Button, b As RoutedEventArgs)
    If _AC = "B101" Then B101.Text = B101.Text.Insert(B101.SelectionStart, a.Content & "(''d())")
    If B104.Visibility = 0 Then
      If _AC = "B103" Then B103.Document.Selection.Text += a.Content & "(''d())"
    Else

    End If
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
        AAAB() : Grid.SetColumn(B101, 1) : Grid.SetRow(B102, 0)
        AABA() : Grid.SetColumn(B105, 1) : Grid.SetRow(B106, 0)
        B100.RowDefinitions.Item(1).Height = New GridLength(0, 2)
        B100.ColumnDefinitions.Item(1).Width = New GridLength(7, 2)
        B100.ColumnDefinitions.Item(2).Width = New GridLength(2, 2)
        B100.ColumnDefinitions.Item(3).Width = New GridLength(9, 2)
        C100.ColumnDefinitions.Item(0).Width = New GridLength(0.5, 2)
        C100.ColumnDefinitions.Item(15).Width = New GridLength(9.5, 2)
        For i = 5 To 14 Step 1 : C100.ColumnDefinitions.Item(i).
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
        AAAB() : AABC() : B100.ColumnDefinitions.Item(3).Width = New GridLength(18, 2)
#End Region
      Case = 104 ' Q-Beispiele
#Region ""
        AAAB()
#End Region
      Case = 105 ' Q-Tabelle
#Region ""
        ' H-T => Q-T,   Q-A => Q-T,   Q-E => Q-T
        AAAB() : B200.Visibility = 1 : B300.Visibility = 0 : C_01.Visibility = 1 : If B300.Children.Count = 0 Then CAAA()
        ' A104.Icon = New SymbolIcon(Symbol.Remove)
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
        AA00.RowDefinitions.Item(0).Height = New GridLength(0, 2)
        B100.RowDefinitions.Item(1).Height = New GridLength(1, 2)
        B100.ColumnDefinitions.Item(1).Width = New GridLength(0, 2)
        B100.ColumnDefinitions.Item(2).Width = New GridLength(0, 2)
        B100.ColumnDefinitions.Item(3).Width = New GridLength(14, 2)
        C100.ColumnDefinitions.Item(0).Width = New GridLength(0.3, 2)
        C100.ColumnDefinitions.Item(5).Width = New GridLength(0, 2)
        C100.ColumnDefinitions.Item(10).Width = New GridLength(0, 2)
        C100.ColumnDefinitions.Item(15).Width = New GridLength(0.3, 2)
        A104.Foreground = New SolidColorBrush(Colors.Blue)
        A_01.Visibility = 1  'A104.Icon = New SymbolIcon(Symbol.Delete)
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
        B100.ColumnDefinitions.Item(2).Width = New GridLength(0, 2)
        AABC() : B100.ColumnDefinitions.Item(3).Width = New GridLength(14, 2)
#End Region
      Case = 204 ' H-Beispiele
#Region ""
        AAAB()
#End Region
      Case = 205 ' H-Tabelle*
#Region ""
        ' Q-T => H-T,   H-A => H-T,   H-E => H-T
        AAAB() : B200.Visibility = 1 : B300.Visibility = 1 : C_01.Visibility = 0 : If C_01.Items.Count = 0 Then CAAB()
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
      AA00.RowDefinitions.Item(0).Height = New GridLength(1, 2)
      A100.ColumnDefinitions.Item(0).Width = New GridLength(0.1, 2)
      A100.ColumnDefinitions.Item(5).Width = New GridLength(1, 2)
      A100.ColumnDefinitions.Item(6).Width = New GridLength(1, 2)
      A100.ColumnDefinitions.Item(7).Width = New GridLength(1, 2)
      A100.ColumnDefinitions.Item(8).Width = New GridLength(1, 2)
      A100.ColumnDefinitions.Item(11).Width = New GridLength(1.9, 2)
    Else : Grid.SetRow(A100, 3)
      A100.ColumnDefinitions.Item(0).Width = New GridLength(0.3, 2)
      A100.ColumnDefinitions.Item(11).Width = New GridLength(0.3, 2)
      A109.Content = If(A109.Content = "A1", "A2", "A1") : AACA()
      A110.Content = If(A110.Content = "B1", "B2", "B1") : AACB()
      A109.Visibility = 0 : A110.Visibility = 0 : End If
  End Sub
  Private Sub AABA()
    ' S:Q-H: Start: Q und H
    A100.Background = New SolidColorBrush(ACAB(AAE)) : A_01.Background = New SolidColorBrush(ACAB(AAE))
    A101.Foreground = New SolidColorBrush(ACAB(AAF)) : A102.Foreground = New SolidColorBrush(ACAB(AAF))
    A103.Foreground = New SolidColorBrush(ACAB(AAF)) : A104.Foreground = New SolidColorBrush(ACAB(AAF))
    A105.Foreground = New SolidColorBrush(ACAB(AAF)) : A106.Foreground = New SolidColorBrush(ACAB(AAF))
    A107.Foreground = New SolidColorBrush(ACAB(AAF)) : A108.Foreground = New SolidColorBrush(ACAB(AAF))
    A109.Foreground = New SolidColorBrush(ACAB(AAF)) : A110.Foreground = New SolidColorBrush(ACAB(AAF))
    B105.Stroke = New SolidColorBrush(ACAB(AAG)) : B106.Stroke = New SolidColorBrush(ACAB(AAG))
    B107.Stroke = New SolidColorBrush(ACAB(AAG)) : B108.Stroke = New SolidColorBrush(ACAB(AAG))
    B100.Visibility = 0 : B200.Visibility = 1 : B300.Visibility = 1 : B400.Visibility = 1 : C100.Visibility = 0
    C_01.Visibility = 1 : AA00.RowDefinitions.Item(1).Height = New GridLength(1, 2) : Grid.SetRow(A_01, 3)
    AA00.RowDefinitions.Item(2).Height = New GridLength(12, 2) : AA00.RowDefinitions.Item(4).Height = New GridLength(6, 2)
    B100.RowDefinitions.Item(0).Height = New GridLength(1, 2) : B100.RowDefinitions.Item(2).Height = New GridLength(7, 2)
  End Sub
  Private Sub AABB()
    ' A:Q-H: Anhang: Q und H
    A_01.Visibility = 0 : B100.Visibility = 1 : Grid.SetRow(A_01, 4)
    A100.Background = New SolidColorBrush(ACAB(AAE)) : A_01.Background = New SolidColorBrush(ACAB(AAE))
    A101.Foreground = New SolidColorBrush(ACAB(AAF)) : A102.Foreground = New SolidColorBrush(ACAB(AAF))
    A103.Foreground = New SolidColorBrush(ACAB(AAF)) : A104.Foreground = New SolidColorBrush(ACAB(AAF))
    A105.Foreground = New SolidColorBrush(ACAB(AAF)) : A106.Foreground = New SolidColorBrush(ACAB(AAF))
    A107.Foreground = New SolidColorBrush(ACAB(AAF)) : A108.Foreground = New SolidColorBrush(ACAB(AAF))
    A109.Foreground = New SolidColorBrush(ACAB(AAF)) : A110.Foreground = New SolidColorBrush(ACAB(AAF))
    B105.Stroke = New SolidColorBrush(ACAB(AAG)) : B106.Stroke = New SolidColorBrush(ACAB(AAG))
    B107.Stroke = New SolidColorBrush(ACAB(AAG)) : B108.Stroke = New SolidColorBrush(ACAB(AAG))
    B200.Visibility = 0 : B300.Visibility = 1 : B400.Visibility = 1 : C100.Visibility = 1 : C_01.Visibility = 1
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
    For i = 0 To 8 Step 1 : ACAD(B200.Children.Item(i)).Content = New Image With {.Source = New BitmapImage With
        {.UriSource = New Uri("ms-appx:///Assets/A_A_00" & CStr(i + 1) & ".png")}} : Next
    ' Icon 10-99
    B210.Content = New Image With {.Source = New BitmapImage With {.UriSource = New Uri("ms-appx:///Assets/A_A_010.png")}}
  End Sub
  Private Sub AABC()
    ' L:Q-H: Listen: Q und H
    B100.Visibility = 0 : B200.Visibility = 1 : B103.Visibility = 1 : B104.Visibility = 0 : C_01.Visibility = 1
    AA00.RowDefinitions.Item(1).Height = New GridLength(1, 2) : B100.RowDefinitions.Item(0).Height = New GridLength(0, 2)
    B100.RowDefinitions.Item(1).Height = New GridLength(0, 2) : B100.ColumnDefinitions.Item(1).Width = New GridLength(0, 2)
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
    '      C_01.Visibility = AAC : Else : BAAB() : End If : End Select
  End Sub
  Private Sub AAXA()
    ' Design
    ApplicationData.Current.LocalSettings.Values("colors") = "2"
    Select Case ApplicationData.Current.LocalSettings.Values("colors")
      Case "1" : AAE = 10 : AAF = 11
      Case "2" : AAE = 11 : AAF = 14
    End Select
    ApplicationData.Current.LocalSettings.Values("border") = "2"
    Select Case ApplicationData.Current.LocalSettings.Values("colors")
      Case "1" : AAG = 14
        B105.StrokeThickness = 3 : B106.StrokeThickness = 3
        B107.StrokeThickness = 3 : B108.StrokeThickness = 3
      Case "2" : AAG = AAE
        B105.StrokeThickness = 1 : B106.StrokeThickness = 1
        B107.StrokeThickness = 1 : B108.StrokeThickness = 1
    End Select
    ApplicationData.Current.LocalSettings.Values("textstyle") = "mathprint"
    Select Case ApplicationData.Current.LocalSettings.Values("textstyle")
      Case "classic" : B103.Visibility = 0
        B104.Visibility = 0 : B110.Visibility = 1 : B120.Visibility = 1
      Case "mathprint" : B103.Visibility = 1
        B104.Visibility = 1 : B110.Visibility = 0 : B120.Visibility = 0
    End Select
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
  Private Sub ABAA()
    B104.Document.Selection.StartPosition = B104.Document.Selection.StoryLength - _N
    B104.Document.Selection.EndPosition = _B104.Document.Selection.StoryLength - _M
    B104.Document.Selection.CharacterFormat.Superscript = 1
  End Sub
  Private Sub ABAB()
    B104.Document.Selection.StartPosition = B104.Document.Selection.StoryLength - _N
    B104.Document.Selection.EndPosition = _B104.Document.Selection.StoryLength - _M
    B104.Document.Selection.CharacterFormat.Subscript = 1
  End Sub
  Private Sub ABAC()
    If TypeOf FocusManager.GetFocusedElement() Is TextBox Then
      _AC = CType(FocusManager.GetFocusedElement(), TextBox).Name : End If
    If TypeOf FocusManager.GetFocusedElement() Is RichEditBox Then
      _AC = CType(FocusManager.GetFocusedElement(), RichEditBox).Name : End If
  End Sub
  Private Sub ABAD(a As Object, b As TappedRoutedEventArgs)
    _M = b.GetPosition(a).X
    _N = b.GetPosition(B111).X

    '_O = B111.Children.IndexOf(b.OriginalSource) ' RoutedEventArgs
  End Sub
  Private Sub ABAE()
    E_01.Stroke = New SolidColorBrush(Colors.Magenta) : A_.Start()
    E_01.X1 = 20 : E_01.X2 = 20 : E_01.Y1 = 20 : E_01.Y2 = 150 : _AC = "B103"
  End Sub
  Private Sub ABAF(a As Byte)
    B104.Document.SetText(TextSetOptions.FormatRtf, "") : B104.Document.Selection.ParagraphFormat.SpaceAfter = a ' * BAA
  End Sub
  Private Sub ABAG(a As String)
    'B103.Document.SetText(TextSetOptions.FormatRtf, a)
    B111.Children.Insert(_O, New TextBlock With {.Text = a & " " & CStr(_N),
                         .Margin = New Thickness(_O * 20, _O * 20, 0, 0)})
    AddHandler ACAF(B111.Children(_O)).Tapped, AddressOf ABAD : _O += 1
  End Sub
  Private Sub ABAH(a As Color, b As Color, c As String)
    B104.Document.Selection.StartPosition = B104.Document.Selection.StoryLength
    B104.Document.Selection.CharacterFormat.BackgroundColor = a
    B104.Document.Selection.CharacterFormat.ForegroundColor = b : B104.Document.Selection.Text += c
  End Sub
#End Region ' *****
#Region "A-AC"
  Private Function ACAA() As Boolean
    Dim aaaaa As ConnectionProfile = NetworkInformation.GetInternetConnectionProfile()
    If aaaaa IsNot Nothing AndAlso aaaaa.GetNetworkConnectivityLevel() = 3 Then
      Return True : Else : Return False : End If  ' Internet verfügbar If ja Else nicht
  End Function
  Private Function ACAB() As Color()
    ACAB = New Color() {Colors.Gray, Colors.Gold, Colors.Olive, Colors.Violet, Colors.SkyBlue,
          Colors.LightGray, Colors.LightPink, Colors.MistyRose, Colors.DarkViolet, Colors.GreenYellow,
          Colors.AliceBlue, Colors.Blue, Colors.Magenta, Colors.Lime, Colors.White}
  End Function
  Private Function ACAC() As Integer()
    ACAC = New Integer() {9, 4, 7, 1, 2, 9, 9, 9, 9, 4, 7, 1, 0, 2, 9, 9, 9, 4, 7, 1, 6, 6, 6, 6, 6,
      6, 6, 6, 6, 0, 0, 2, 2, 9, 9, 4, 7, 1, 6, 6, 6, 6, 6, 6, 6, 6, 6, 0, 0, 0, 2, 2, 9, 4, 7, 1,
      3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 6, 6, 6, 6, 6, 6, 6, 6, 0, 0, 0, 0, 0, 2, 4, 7,
      1, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 6, 6, 6, 6, 6, 5, 5, 5, 0, 5, 5, 5, 5, 5, 5}
  End Function
  Private Function ACAD(a As Button) As Button
    Return a
  End Function
  Private Function ACAE(a As Canvas) As Canvas
    Return a
  End Function
  Private Function ACAF(a As TextBlock) As TextBlock
    Return a
  End Function
#End Region ' *****
#Region "A-AD"
  Private Async Sub ADAA()
    If ACAA() = True Then
      Dim aaaaa As String : B103.Document.Selection.StartPosition = 0
      B103.Document.Selection.EndPosition = _B103.Document.Selection.StoryLength

      aaaaa = NAD.GetString("A201") & ":   " & B101.Text & vbCrLf &
        NAD.GetString("A202") & ":   " & B103.Document.Selection.Text

      Dim emailMessage As New EmailMessage With {.Body = aaaaa,
      .Subject = NAD.GetString("A105")}
      emailMessage.To.Add(New EmailRecipient("calculator_message_@outlook.com"))
      Await EmailManager.ShowComposeNewEmailAsync(emailMessage)
      'ABAH(Colors.AliceBlue, Colors.Blue, vbCrLf & "Internetverbindung besteht")
    Else
      ABAH(Colors.AliceBlue, Colors.Blue, vbCrLf & "Keine Internetverbindung")
    End If
  End Sub
#End Region
#End Region
  ' * BBBB * BBBB * BBBB * BBBB *
#Region "BBBB"

  Private Sub BAAA()
    Dim aaaaa As New List(Of Object)
    Dim aaaab As New Canvas

    Dim aaaac As New TextBlock With {.Text = "∫"} ' − ∫
    aaaab.Scale = New System.Numerics.Vector3(2.0, 9.0, 1.0) ' 5.0F, 5.0F, 1.0F
    'Dim aaaac As New TextBlock With {.Text = "−"} ' − ∫
    'aaaab.Scale = New System.Numerics.Vector3(9.0, 1.0, 1.0) ' 5.0F, 5.0F, 1.0F

    B103.Visibility = 1
    aaaab.Children.Add(aaaac)
    B111.Children.Add(aaaab)
  End Sub

#End Region
  ' * CCCC * CCCC * CCCC * CCCC *
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

    For i = 1 To 32 Step 1 : _AA = If(i < 10, "00", "0")
      eaaab = New TextBlock With {.FontSize = 7.5 * BAA, .Text = NAA.GetString("A" & _AA & CStr(i))}
      eaaaa = New Button With {.Padding = New Thickness(0), .Content = eaaab, .VerticalAlignment = 3,
            .HorizontalAlignment = 3, .Background = New SolidColorBrush(Colors.WhiteSmoke),
            .Margin = New Thickness(0.5 * BAA)} : B300.Children.Add(eaaaa)
      Grid.SetRow(eaaaa, CInt(eaaba(i - 1))) : Grid.SetColumn(eaaaa, CInt(eaabb(i - 1))) : Next

    Grid.SetColumnSpan(ACAD(B300.Children.Item(0)), 2) : Grid.SetColumnSpan(ACAD(B300.Children.Item(1)), 11)
    Grid.SetColumnSpan(ACAD(B300.Children.Item(2)), 5)

    eaaba = ("3´3´4´4´4´4´4´4´4´4´5´5´5´5´5´5´5´5´6´6´6´6´6´6´6´6´6´6´6´6´6´6´6´6´6´6´7´7´7´7´7´7´7´7´7´7" &
          "´7´7´7´7´7´7´7´7´8´8´8´10´10´10´10´10´10´10´10´10´10´10´10´10´10´8´8´8´8´8´8´8´8´8´8´8´8´8´8´8´9´9" &
          "´9´11´11´11´11´11´11´11´11´11´11´11´11´11´11´9´9´9´9´9´9´9´9´9´9´9´9´9´9´9").Split("´")
    eaabb = ("2´20´2´3´15´16´17´18´19´20´2´3´15´16´17´18´19´20´2´3´4´6´7´8´9´10´11´12´13´14´15´16´17´18´1" &
          "9´20´2´3´4´6´7´8´9´10´11´12´13´14´15´16´17´18´19´20´2´3´4´6´7´8´9´10´11´12´13´14´15´16´17´18´19" &
          "´6´7´8´9´10´11´12´13´14´15´16´17´18´19´20´2´3´4´6´7´8´9´10´11´12´13´14´15´16´17´18´19´6´7´8´9´10´1" &
          "1´12´13´14´15´16´17´18´19´20").Split("´")
    'eaabc = ("9´4´7´1´2´9´9´9´9´4´7´1´0´2´9´9´9´4´7´1´6´6´6´6´6´6´6´6´6´0´0´2´2´9´9´4´7´1´6´6´6´6´6´6´6´6" &
    '      "´6´0´0´0´2´2´9´4´7´1´3´3´3´3´3´3´3´3´3´3´3´3´3´3´3´6´6´6´6´6´6´6´6´0´0´0´0´0´2´4´7´1´8´8´8´8´8´8´8" &
    '      "´8´8´8´8´8´8´8´8´6´6´6´6´6´5´5´5´0´5´5´5´5´5´5").Split("´")

    For i = 1 To 118 Step 1 : _AA = "B" & If(i < 10, "00", If(i < 100, "0", "")) & CStr(i)
      eaaab = New TextBlock With {.FontFamily = New FontFamily("Calibri Light")}
      Select Case ACAC(i - 1) : Case "0", "2", "8"
          eaaab.Foreground = New SolidColorBrush(Colors.White) : End Select
      eaaaa = New Button With {.Padding = New Thickness(0), .Content = eaaab,
            .VerticalAlignment = 3, .HorizontalAlignment = 3, .Margin = New Thickness(0.5 * BAA),
            .Background = New SolidColorBrush(ACAB(CInt(ACAC(i - 1))))} : B300.Children.Add(eaaaa)
      Grid.SetRow(eaaaa, CInt(eaaba(i - 1))) : Grid.SetColumn(eaaaa, CInt(eaabb(i - 1)))
      eaaca = New Documents.Run With {.Text = NAA.GetString(_AA) & vbLf, .FontSize = 9 * BAA}
      eaaab.Inlines.Add(eaaca)
      eaaca = New Documents.Run With {.Text = vbLf & NAD.GetString(_AA), .FontSize = 6 * BAA}
      eaaab.Inlines.Add(eaaca) : AddHandler eaaaa.Click, AddressOf CABA : Next
  End Sub
  Private Sub CAAB()
    ' Liste der chemischen Elemente
    For i = 1 To 118 Step 1 : _AA = "B" & If(i < 10, "00", If(i < 100, "0", "")) & CStr(i)
      C_01.Items.Add(New TextBlock With {.FontFamily = New FontFamily("Consolas"),
        .FontSize = 15 * BAA, .VerticalAlignment = 3, .HorizontalAlignment = 3,
        .Text = (NAA.GetString(_AA) & "          ").Substring(0, 10) & NAD.GetString(_AA)})
    Next : AA00.Children.
      Add(C_01) : Grid.SetRow(C_01, 2) : AddHandler C_01.SelectionChanged, AddressOf CABB
  End Sub
#End Region
#Region "C-AB"
  Private Sub CABA(a As Button, b As RoutedEventArgs)
    ' Die Auswahl des chemischen Elements von der Tabelle
    _AA = CStr(Grid.GetRow(a)) & "." & CStr(Grid.GetColumn(a))
    Select Case _AA
      Case "3.2" : _AA = "1" : Case "3.20" : _AA = "2" : Case "4.2" : _AA = "3" : Case "4.3" : _AA = "4"
      Case "4.15" : _AA = "5" : Case "4.16" : _AA = "6" : Case "4.17" : _AA = "7" : Case "4.18" : _AA = "8"
      Case "4.19" : _AA = "9" : Case "4.20" : _AA = "10" : Case "5.2" : _AA = "11" : Case "5.3" : _AA = "12"
      Case "5.15" : _AA = "13" : Case "5.16" : _AA = "14" : Case "5.17" : _AA = "15" : Case "5.18" : _AA = "16"
      Case "5.19" : _AA = "17" : Case "5.20" : _AA = "18" : Case "6.2" : _AA = "19" : Case "6.3" : _AA = "20"
      Case "6.4" : _AA = "21" : Case "6.6" : _AA = "22" : Case "6.7" : _AA = "23" : Case "6.8" : _AA = "24"
      Case "6.9" : _AA = "25" : Case "6.10" : _AA = "26" : Case "6.11" : _AA = "27" : Case "6.12" : _AA = "28"
      Case "6.13" : _AA = "29" : Case "6.14" : _AA = "30" : Case "6.15" : _AA = "31" : Case "6.16" : _AA = "32"
      Case "6.17" : _AA = "33" : Case "6.18" : _AA = "34" : Case "6.19" : _AA = "35" : Case "6.20" : _AA = "36"
      Case "7.2" : _AA = "37" : Case "7.3" : _AA = "38" : Case "7.4" : _AA = "39" : Case "7.6" : _AA = "40"
      Case "7.7" : _AA = "41" : Case "7.8" : _AA = "42" : Case "7.9" : _AA = "43" : Case "7.10" : _AA = "44"
      Case "7.11" : _AA = "45" : Case "7.12" : _AA = "46" : Case "7.13" : _AA = "47" : Case "7.14" : _AA = "48"
      Case "7.15" : _AA = "49" : Case "7.16" : _AA = "50" : Case "7.17" : _AA = "51" : Case "7.18" : _AA = "52"
      Case "7.19" : _AA = "53" : Case "7.20" : _AA = "54" : Case "8.2" : _AA = "55" : Case "8.3" : _AA = "56"
      Case "8.4" : _AA = "57" : Case "10.6" : _AA = "58" : Case "10.7" : _AA = "59" : Case "10.8" : _AA = "60"
      Case "10.9" : _AA = "61" : Case "10.10" : _AA = "62" : Case "10.11" : _AA = "63" : Case "10.12" : _AA = "64"
      Case "10.13" : _AA = "65" : Case "10.14" : _AA = "66" : Case "10.15" : _AA = "67" : Case "10.16" : _AA = "68"
      Case "10.17" : _AA = "69" : Case "10.18" : _AA = "70" : Case "10.19" : _AA = "71" : Case "8.6" : _AA = "72"
      Case "8.7" : _AA = "73" : Case "8.8" : _AA = "74" : Case "8.9" : _AA = "75" : Case "8.10" : _AA = "76"
      Case "8.11" : _AA = "77" : Case "8.12" : _AA = "78" : Case "8.13" : _AA = "79" : Case "8.14" : _AA = "80"
      Case "8.15" : _AA = "81" : Case "8.16" : _AA = "82" : Case "8.17" : _AA = "83" : Case "8.18" : _AA = "84"
      Case "8.19" : _AA = "85" : Case "8.20" : _AA = "86" : Case "9.2" : _AA = "87" : Case "9.3" : _AA = "88"
      Case "9.4" : _AA = "89" : Case "11.6" : _AA = "90" : Case "11.7" : _AA = "91" : Case "11.8" : _AA = "92"
      Case "11.9" : _AA = "93" : Case "11.10" : _AA = "94" : Case "11.11" : _AA = "95" : Case "11.12" : _AA = "96"
      Case "11.13" : _AA = "97" : Case "11.14" : _AA = "98" : Case "11.15" : _AA = "99" : Case "11.16" : _AA = "100"
      Case "11.17" : _AA = "101" : Case "11.18" : _AA = "102" : Case "11.19" : _AA = "103" : Case "9.6" : _AA = "104"
      Case "9.7" : _AA = "105" : Case "9.8" : _AA = "106" : Case "9.9" : _AA = "107" : Case "9.10" : _AA = "108"
      Case "9.11" : _AA = "109" : Case "9.12" : _AA = "110" : Case "9.13" : _AA = "111" : Case "9.14" : _AA = "112"
      Case "9.15" : _AA = "113" : Case "9.16" : _AA = "114" : Case "9.17" : _AA = "115" : Case "9.18" : _AA = "116"
      Case "9.19" : _AA = "117" : Case "9.20" : _AA = "118" : Case Else : _AA = 0 : End Select : _AB = _AA : CABC()
  End Sub
  Private Sub CABB()
    ' Die Auswahl des chemischen Elements von der Liste
    _AA = CStr(C_01.SelectedIndex + 1) : CABC()
  End Sub
  Private Sub CABC()
    ' Das Laden des chemischen Elements
    B401.Background = New SolidColorBrush(ACAB(CInt(ACAC(CInt(_AA) - 1)))) : B400.Visibility = 0
    A_01.Background = B401.Background : Select Case ACAC(CInt(_AA) - 1) : Case 0, 2, 8
        B401.Foreground = New SolidColorBrush(Colors.White) : End Select : B300.Visibility = 1
    AAB = 6 : A100.Background = B401.Background
    A101.Foreground = B401.Foreground : A102.Foreground = B401.Foreground : A103.Foreground =
      B401.Foreground : A104.Foreground = B401.Foreground : A105.Foreground = B401.Foreground
    A106.Foreground = B401.Foreground : A107.Foreground = B401.Foreground : A108.Foreground =
      B401.Foreground : A109.Foreground = B401.Foreground : A110.Foreground = B401.Foreground
    _AA = If(CByte(_AA) < 10, "00", If(CByte(_AA) < 100, "0", "")) & _AA : C_01.Visibility = 1
    D_02.Text = NAB.GetString("A" & _AA) : D_01.Text = (NAA.GetString("B" & _AA) & "          ").
      Substring(0, 10) & NAD.GetString("B" & _AA) : If B400.RowDefinitions.Count > 0 Then Exit Sub

    Dim aaaaa As New Grid : Dim aaaab As TextBlock : Dim aaaac As New GridLength(7, 2)
    B400.ColumnDefinitions.Add(New ColumnDefinition) : B400.RowDefinitions.Add(New RowDefinition)
    B400.ColumnDefinitions.Add(New ColumnDefinition) : B400.RowDefinitions.Add(New RowDefinition)
    B400.ColumnDefinitions.Add(New ColumnDefinition) : B400.RowDefinitions.Add(New RowDefinition)
    aaaaa.ColumnDefinitions.Add(New ColumnDefinition) : aaaaa.RowDefinitions.Add(New RowDefinition)
    aaaaa.ColumnDefinitions.Add(New ColumnDefinition) : aaaaa.RowDefinitions.Add(New RowDefinition)
    aaaaa.ColumnDefinitions.Add(New ColumnDefinition) : aaaaa.RowDefinitions.Add(New RowDefinition)

    B400.RowDefinitions.Item(1).Height = aaaac : B400.ColumnDefinitions.Item(1).Width = aaaac
    aaaaa.RowDefinitions.Item(2).Height = aaaac : aaaaa.ColumnDefinitions.Item(0).Width = aaaac
    aaaaa.ColumnDefinitions.Item(2).Width = New GridLength(2, 2) : D_01.FontSize = 10 * BAA
    B401.Content = aaaaa
    B401.VerticalAlignment = 3 : B401.HorizontalAlignment = 3 : D_02.FontSize = 10 * BAA

    aaaaa.Children.Add(D_01) : Grid.SetRow(D_01, 0) : Grid.SetColumn(D_01, 0)
    aaaaa.Children.Add(D_02) : Grid.SetRow(D_02, 2) : Grid.SetColumn(D_02, 2) : Grid.SetRow(B400, 2)
    aaaab = New TextBlock With {.MinWidth = 50, .MinHeight = 20}
    aaaaa.Children.Add(aaaab) : Grid.SetRow(aaaab, 1) : Grid.SetColumn(aaaab, 1) : Grid.SetColumn(B401, 1)
    aaaab = New TextBlock With {.FontSize = 10 * BAA, .Text = NAE.GetString("A003")}
    aaaaa.Children.Add(aaaab) : Grid.SetRow(aaaab, 2) : Grid.SetColumn(aaaab, 0) : Grid.SetRow(B401, 1)
  End Sub
  Private Sub CABD()
    ' Die Abwahl des chemischen Elements
    B400.Visibility = 1 : AAB = 5
    If AAA = 1 Then : B300.Visibility = 0 : C_01.Visibility = 1 : If B300.Children.Count = 0 Then CAAA()
    Else : B300.Visibility = 1 : C_01.Visibility = 0 : If C_01.Items.Count = 0 Then : CAAB() : End If : End If
  End Sub
#End Region
#End Region
  ' * DDDD * DDDD * DDDD * DDDD *
#Region "DDDD"

#End Region
  ' * EEEE * EEEE * EEEE * EEEE *
#Region "EEEE"

#End Region
#End Region
End Class