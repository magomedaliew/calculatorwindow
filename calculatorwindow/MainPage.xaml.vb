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
#Region "A-01"
  ' Controlls
  Dim AA_ As New Line
  Dim BA_ As New Button
  Dim CA_ As New Canvas
  Dim DA_ As New ListView
  Dim EA_, EB_ As TextBlock
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
  Dim AAA, AAB, AAC, AAD, AAE, AAF, AAG As Byte
  Dim ABA, ABB As String
  Dim ACA, ACB As Integer
  Dim ADA() As String
  Dim AEA As DispatcherTimer
#End Region
#Region "A-20"
  ' Mathematik
  Dim BAA, BAB As Integer
  Dim BBA, BBB, BBC As New List(Of Byte)
  Dim BCA, BCB As New List(Of Integer)
#End Region
#Region "A-30"
  ' Chemie
  Dim _AB As String
#End Region
#Region "A-40"
  ' Physik

#End Region
#Region "A-50"
  ' Darstellung

#End Region
#End Region
  ' * ○○○○ * ○○○○ * ○○○○ * ○○○○ *
#Region "○○○○"
#Region "AAA0"
  Private Sub A_A_() Handles AAA0.Loaded
    Try
      ' Loaded
      B103.IsSpellCheckEnabled = False : B104.IsSpellCheckEnabled = False : EA_ = New TextBlock : EB_ = New TextBlock

      A101.Foreground = New SolidColorBrush(Colors.Blue) : A102.Foreground = New SolidColorBrush(Colors.Blue)
      A103.Foreground = New SolidColorBrush(Colors.Blue) : A104.Foreground = New SolidColorBrush(Colors.Blue)
      A105.Foreground = New SolidColorBrush(Colors.Blue) : A106.Foreground = New SolidColorBrush(Colors.Blue)
      A107.Foreground = New SolidColorBrush(Colors.Blue) : A108.Foreground = New SolidColorBrush(Colors.Blue)
      A109.Foreground = New SolidColorBrush(Colors.Blue) : A110.Foreground = New SolidColorBrush(Colors.Blue)

      B101.VerticalAlignment = 3 : B101.HorizontalAlignment = 3 : B102.VerticalAlignment = 3 : B102.HorizontalAlignment = 3

      ToolTipService.SetToolTip(A101, New ToolTip With {.Content = A_D.GetString("A001"), .Placement = PlacementMode.Bottom})
      ToolTipService.SetToolTip(A102, New ToolTip With {.Content = A_D.GetString("A002"), .Placement = PlacementMode.Bottom})
      ToolTipService.SetToolTip(A103, New ToolTip With {.Content = A_D.GetString("A003"), .Placement = PlacementMode.Bottom})
      ToolTipService.SetToolTip(A104, New ToolTip With {.Content = A_D.GetString("A004"), .Placement = PlacementMode.Bottom})
      ToolTipService.SetToolTip(A105, New ToolTip With {.Content = A_D.GetString("A005"), .Placement = PlacementMode.Bottom})
      ToolTipService.SetToolTip(A106, New ToolTip With {.Content = A_D.GetString("A006"), .Placement = PlacementMode.Bottom})
      ToolTipService.SetToolTip(A107, New ToolTip With {.Content = A_D.GetString("A007"), .Placement = PlacementMode.Bottom})
      ToolTipService.SetToolTip(A108, New ToolTip With {.Content = A_D.GetString("A008"), .Placement = PlacementMode.Bottom})

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

      C126.Content = A_D.GetString("A254") : B101.PlaceholderText = A_D.GetString("A201")
      B103.PlaceholderText = A_D.GetString("A202") : B104.PlaceholderText = A_D.GetString("A900")

      A101.VerticalAlignment = 3 : A101.HorizontalAlignment = 3 : A102.VerticalAlignment = 3 : A102.HorizontalAlignment = 3
      A103.VerticalAlignment = 3 : A103.HorizontalAlignment = 3 : A104.VerticalAlignment = 3 : A104.HorizontalAlignment = 3
      A105.VerticalAlignment = 3 : A105.HorizontalAlignment = 3 : A106.VerticalAlignment = 3 : A106.HorizontalAlignment = 3
      A107.VerticalAlignment = 3 : A107.HorizontalAlignment = 3 : A108.VerticalAlignment = 3 : A108.HorizontalAlignment = 3
      A109.VerticalAlignment = 3 : A109.HorizontalAlignment = 3 : A110.VerticalAlignment = 3 : A110.HorizontalAlignment = 3
      B101.VerticalAlignment = 3 : B101.HorizontalAlignment = 3 : B102.VerticalAlignment = 3 : B102.HorizontalAlignment = 3

      If ApplicationData.Current.LocalSettings.Values("upgrade") <> "18.02.2022" Then
        B104.FontFamily = New FontFamily("Segoe UI")
        ABAD(5) : ABAE(Colors.White, Colors.Lime, A_D.GetString("E001") & vbCrLf)
        ABAD(5) : ABAE(Colors.White, Colors.Black, A_E.GetString("A002")) : End If

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

      AA00.Children.Add(CA_)
      Grid.SetColumn(A101, 1) : Grid.SetColumn(A102, 2) : Grid.SetColumn(A103, 3) : Grid.SetColumn(A104, 4)
      Grid.SetColumn(A105, 5) : Grid.SetColumn(A106, 6) : Grid.SetColumn(A107, 7) : Grid.SetColumn(A108, 8)
      Grid.SetColumn(A109, 9) : Grid.SetColumn(A110, 10) : Grid.SetColumn(B102, 3) : Grid.SetColumn(B103, 1)
      Grid.SetColumn(B104, 3) : Grid.SetColumn(B106, 3) : Grid.SetColumn(B107, 1) : Grid.SetColumn(B108, 3)

      Grid.SetRow(B100, 2) : Grid.SetRow(B101, 0) : Grid.SetRow(B105, 0) : Grid.SetRow(B103, 2) : Grid.SetRow(B104, 2)
      Grid.SetRow(B107, 2) : Grid.SetRow(B108, 2) : Grid.SetRow(B200, 2) : Grid.SetRow(B300, 2) : Grid.SetRow(C100, 4)

      ADA = ("0´1´0´2´0´3´0´4´1´1´1´2´1´3´1´4´2´1´2´2´2´3´2´4´3´1´3´2´3´3´3´4´0´6´0´7´0´8´0´9´1´6´1´7´1´8´1´9´2´6´2´7´2´" &
        "8´2´9´3´6´3´7´3´8´3´9´0´11´0´12´0´13´0´14´1´11´1´12´1´13´1´14´2´11´2´12´2´13´2´14´3´11´3´12´3´13´3´14").Split("´")

      For i As Byte = 0 To 95 Step 2 : AAA = i / 2 : ACAD(C100.Children.Item(AAA)).VerticalAlignment = 3
        ACAD(C100.Children.Item(AAA)).HorizontalAlignment = 3 : Grid.SetRow(C100.Children.Item(AAA), CInt(ADA(i)))
        Grid.SetColumn(C100.Children.Item(AAA), CInt(ADA(i + 1))) : ACAD(C100.Children.Item(AAA)).Background =
          New SolidColorBrush(Colors.White) : ACAD(C100.Children.Item(AAA)).Foreground = New SolidColorBrush(Colors.Blue)
      Next

      AddHandler B101.GotFocus, AddressOf ABAC : AddHandler B103.GotFocus, AddressOf ABAC
      AddHandler B111.Tapped, AddressOf ABAF

      AEA = New DispatcherTimer With {.Interval = TimeSpan.FromMilliseconds(500)} : AddHandler AEA.Tick, AddressOf BAAB

      B111.Children.Add(AA_) : BAA = 1 : BAB = 1 : AAB = 1 : B101.Focus(3) : AAXA() : A_B_() : Catch ex As Exception : End Try
  End Sub
  Private Sub A_B_() Handles AAA0.SizeChanged
    ' Size Changed
    Try : If AAA0.ActualWidth > 1.5 * AAA0.ActualHeight Then
        If AAA <> 1 Then : AAA = 1 : End If : AAAA() : Else
        If AAA <> 2 Then : AAA = 2 : End If : AAAA() : End If
    Catch ex As Exception : End Try
  End Sub
#End Region
#Region "A100"
  Private Sub A_AA()
    AAB = 1 : AAAA() : BXAA()
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
    '        B103.PlaceholderText = A_D.GetString("A051")
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
    '  B104.Document.Selection.Text = A_D.GetString("A151") & " A1"
    '  'B004.Document.Selection.Text += ex.HelpLink & vbCrLf
    '  'B004.Document.Selection.Text += ex.Message & vbCrLf
    '  'B004.Document.Selection.Text += ex.Source & vbCrLf
    '  'B004.Document.Selection.Text += ex.StackTrace & vbCrLf
    'End Try
  End Sub
#End Region
#Region "B200"
  Private Sub B_BA()
    ApplicationData.Current.LocalSettings.Values("upgrade") = "xxxx" : AAB = 3
    AAAA() : ABAD(5) : B104.FontFamily = New FontFamily("Segoe UI")
    ' Rechner
    ABAE(Colors.AliceBlue, Colors.Blue, A_D.GetString("A000") & vbLf)
    ABAE(Colors.White, Colors.Black, vbLf & A_E.GetString("A001") & vbLf & vbLf)
    ' Upgrade
    ABAE(Colors.AliceBlue, Colors.Lime, A_D.GetString("E001") & vbLf)
    ABAE(Colors.White, Colors.Black, vbLf & A_E.GetString("A002"))
  End Sub
  Private Sub B_BB()
    AAB = 3 : AAAA() : ABAD(0) : B104.FontFamily = New FontFamily("Consolas") : ABA = "				"
    ABAE(Colors.AliceBlue, Colors.Blue, A_D.GetString("E002") & vbLf & vbLf & vbLf)
    ABAE(Colors.AliceBlue, Colors.Blue, A_D.GetString("E201") & ABA & A_D.GetString("E202") & vbLf & vbLf)
    ABA = "					"
    ACA = 14 : ACB = 13 : ABAE(Colors.AliceBlue, Colors.Blue, "ab" & ABA & "a ^ b" & vbLf & vbLf) : ABAA()
    ACA = 19 : ACB = 18 : ABAE(Colors.AliceBlue, Colors.Blue, "b√a" & ABA & "√(a ' b)" & vbLf & vbLf) : ABAA()
    ACA = 20 : ACB = 19 : ABAE(Colors.AliceBlue, Colors.Blue, "logab" & ABA & "log(a ' b)" & vbLf & vbLf) : ABAB()
    ACA = 20 : ACB = 19 : ABAE(Colors.AliceBlue, Colors.Blue, "limab" & ABA & "lim(a ' b)" & vbLf & vbLf) : ABAB()
    ACA = 24 : ACB = 23 : ABAE(Colors.AliceBlue, Colors.Blue, "Ʃab c" & ABA & "Ʃ(a ' b ' c)" & vbLf & vbLf) : ABAB()
    ACA = 23 : ACB = 24 : ABAA()
    ACA = 24 : ACB = 23 : ABAE(Colors.AliceBlue, Colors.Blue, "∏ab c" & ABA & "∏(a ' b ' c)" & vbLf & vbLf) : ABAB()
    ACA = 33 : ACB = 32 : ABAA() : ABA = "				"
    ACA = 30 : ACB = 29 : ABAE(Colors.AliceBlue, Colors.Blue, "a∫b x dx" & ABA & "∫(a ' b ' x d(x))") : ABAB()
    ACA = 28 : ACB = 27 : ABAA()
  End Sub
  Private Sub B_BC()
  End Sub
  Private Sub B_BD()
  End Sub
  Private Sub B_BE()
    Try : ADAA() : Catch ex As Exception : End Try
  End Sub
  Private Sub B_BF()
    AAB = 3 : AAAA() : ABAD(5) : B104.FontFamily = New FontFamily("Consolas")
    ' Mathematik - Formeln
    ABAE(Colors.AliceBlue, Colors.Blue, "   " & A_D.GetString("E003") & "   " & vbLf & vbLf)
    ABAE(Colors.White, Colors.Green, A_D.GetString("E101") & vbLf)
    ABAE(Colors.White, Colors.Blue, "a = a" & vbLf & vbLf)
    ABAE(Colors.White, Colors.Green, A_D.GetString("E102") & vbLf)
    ABAE(Colors.White, Colors.Blue, "a = b" & vbLf & vbLf)
    ABAE(Colors.White, Colors.Blue, "a = b" & vbLf & vbLf)
    ABAE(Colors.White, Colors.Green, A_D.GetString("E103") & vbLf)
    ABAE(Colors.White, Colors.Blue, "e = 2,718281828" & vbLf & vbLf)
    ABAE(Colors.White, Colors.Green, A_D.GetString("E104") & vbLf)
    ABAE(Colors.White, Colors.Blue, "π = 3,141592654" & vbLf & vbLf)
    ABAE(Colors.White, Colors.Green, A_D.GetString("E105") & vbLf)
    ABAE(Colors.White, Colors.Blue, "(a) = a
a + (b +- c) = a + b +- c
a - (b +- c) = a - b -+ c
a · (b ·: c) = a · b ·: c
a : (b ·: c) = a : b :· c" & vbLf & vbLf)
    ABAE(Colors.White, Colors.Green, A_D.GetString("E106") & vbLf)
    ABAE(Colors.White, Colors.Blue, "|-a| = |a|
|a| = a    a ≥ 0
|a| = -a   a < 0" & vbLf & vbLf)
    ABAE(Colors.White, Colors.Green, A_D.GetString("E107") & vbLf)
    ABAE(Colors.White, Colors.Blue, "a +- 0 = a
a · 0 = 0
a ^ 0 = 1
a / 0 = ∞" & vbLf & vbLf)
    ABAE(Colors.White, Colors.Green, A_D.GetString("E108") & vbLf)
    ABAE(Colors.White, Colors.Blue, "a ·: 1 = a
a ^ 1 = a" & vbLf & vbLf)
    ABAE(Colors.White, Colors.Green, A_D.GetString("E109") & vbLf)
    ABAE(Colors.White, Colors.Blue, "a - a = 0
a / a = 1" & vbLf & vbLf)
    ABAE(Colors.White, Colors.Green, A_D.GetString("E110") & vbLf)
    ABAE(Colors.White, Colors.Blue, "a + -b = a - b
a - -b = a + b
-a ·: -b = a ·: b
a ·: -b = -a ·: b" & vbLf & vbLf)
    ABAE(Colors.White, Colors.Green, A_D.GetString("E111") & vbLf)
    ABAE(Colors.White, Colors.Blue, "cos(a) = b
sin(a) = b
tan(a) = b
cot(a) = b
acos(a) = b
asin(a) = b
atan(a) = b
acot(a) = b" & vbLf & vbLf)
    ABAE(Colors.White, Colors.Green, A_D.GetString("E112") & vbLf)
    ABAE(Colors.White, Colors.Blue, "ln(a) = b
ln(e) = 1
log(a ' b) = с" & vbLf & vbLf)
    ABAE(Colors.White, Colors.Green, A_D.GetString("E113") & vbLf)
    ABAE(Colors.White, Colors.Blue, "a! = a · (a - 1) · ... · 1    a < 170" & vbLf & vbLf)
    ABAE(Colors.White, Colors.Green, A_D.GetString("E114") & vbLf)
    ABAE(Colors.White, Colors.Blue, "a´ = 0" & vbLf & vbLf)
    ABAE(Colors.White, Colors.Green, A_D.GetString("E115") & vbLf)
    ABAE(Colors.White, Colors.Blue, "a´ = 0" & vbLf & vbLf)
    ABAE(Colors.White, Colors.Gray, A_D.GetString("A900") & vbLf & "b + a = a + b
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
    AAB = 3 : AAAA() : ABAD(5) : B104.FontFamily = New FontFamily("Consolas")
    ' Chemie - Formeln
    ABAE(Colors.AliceBlue, Colors.Blue, "   " & A_D.GetString("E004") & "   " & vbLf &
         vbLf) : ABAE(Colors.White, Colors.Green, "c = n / V" & vbLf & "M = m / n")
  End Sub
  Private Sub B_BH()
    AAB = 3 : AAAA() : ABAD(10) : B104.FontFamily = New FontFamily("Consolas")
    ' Physik - Formeln
    ABAE(Colors.AliceBlue, Colors.Blue, "   " & A_D.GetString("E005") & "   " & vbLf & vbLf)
    ABAE(Colors.White, Colors.Green, A_D.GetString("A109") & vbLf)
    ABAE(Colors.White, Colors.DarkViolet, "a = Δv / Δt
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
    ABAE(Colors.White, Colors.Green, A_D.GetString("E051") & vbLf)
    ABAE(Colors.White, Colors.DarkViolet, "A = Ax
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
    AAB = 3 : AAAA() : ABAD(10) : B104.FontFamily = New FontFamily("Consolas")
    ' Dimensionen
    ABAE(Colors.AliceBlue, Colors.Blue, "   " & A_D.GetString("A109") & "   " & vbLf & vbLf)
    For i = 1 To 87 Step 1 : ABA = If(i < 10, "00", "0") & CStr(i)
      ABAE(Colors.White, Colors.Blue, (A_C.GetString("B" & ABA) & "       ").Substring(0, 8))
      ABAE(Colors.White, Colors.DeepSkyBlue, A_D.GetString("C" & ABA) & vbLf) : Next
  End Sub
  Private Sub B_BJ()
    AAB = 5 : AAAA()
  End Sub
#End Region
#Region "C100"
  Private Sub C_AA(a As Button, b As RoutedEventArgs)
    If ABB = "B101" Then : B101.Text = B101.Text.Insert(B101.SelectionStart, a.Content)
    Else : B103.Document.Selection.Text += a.Content : BXAB(a.Content) : End If
  End Sub
  Private Sub C_AB(a As Button, b As RoutedEventArgs)
    If ABB = "B101" Then B101.Text = B101.Text.Insert(B101.SelectionStart, "-")
    If B104.Visibility = 0 Then
      If ABB = "B103" Then B103.Document.Selection.Text += "-"
    Else

    End If
  End Sub
  Private Sub C_AC(a As Button, b As RoutedEventArgs)
    If ABB = "B101" Then B101.Text = B101.Text.Insert(B101.SelectionStart, " " & a.Content & " ")
    If B104.Visibility = 0 Then
      If ABB = "B103" Then B103.Document.Selection.Text += " " & a.Content & " "
    Else

    End If
  End Sub
  Private Sub C_AD(a As Button, b As RoutedEventArgs)
    If ABB = "B101" Then B101.Text = B101.Text.Insert(B101.SelectionStart, a.Content & "()")
    If B104.Visibility = 0 Then
      If ABB = "B103" Then B103.Document.Selection.Text += a.Content & "()"
    Else

    End If
  End Sub
  Private Sub C_AE(a As Button, b As RoutedEventArgs)
    If ABB = "B101" Then B101.Text = B101.Text.Insert(B101.SelectionStart, a.Content & "(')")
    If B104.Visibility = 0 Then
      If ABB = "B103" Then B103.Document.Selection.Text += a.Content & "(')"
    Else

    End If
  End Sub
  Private Sub C_AF(a As Button, b As RoutedEventArgs)
    If ABB = "B101" Then B101.Text = B101.Text.Insert(B101.SelectionStart, a.Content & "('')")
    If B104.Visibility = 0 Then
      If ABB = "B103" Then B103.Document.Selection.Text += a.Content & "('')"
    Else

    End If
  End Sub
  Private Sub C_AG(a As Button, b As RoutedEventArgs)
    If ABB = "B101" Then : B101.Text = B101.Text.Insert(B101.SelectionStart, a.Content)
    Else : B103.Document.Selection.Text += a.Content & "(''d())" : BXAC(a.Content) : End If
  End Sub
#End Region
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
        CA_.Visibility = 1  'A104.Icon = New SymbolIcon(Symbol.Delete)
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
    A100.Background = New SolidColorBrush(ACAB(AAE)) : CA_.Background = New SolidColorBrush(ACAB(AAE))
    A101.Foreground = New SolidColorBrush(ACAB(AAF)) : A102.Foreground = New SolidColorBrush(ACAB(AAF))
    A103.Foreground = New SolidColorBrush(ACAB(AAF)) : A104.Foreground = New SolidColorBrush(ACAB(AAF))
    A105.Foreground = New SolidColorBrush(ACAB(AAF)) : A106.Foreground = New SolidColorBrush(ACAB(AAF))
    A107.Foreground = New SolidColorBrush(ACAB(AAF)) : A108.Foreground = New SolidColorBrush(ACAB(AAF))
    A109.Foreground = New SolidColorBrush(ACAB(AAF)) : A110.Foreground = New SolidColorBrush(ACAB(AAF))
    B105.Stroke = New SolidColorBrush(ACAB(AAG)) : B106.Stroke = New SolidColorBrush(ACAB(AAG))
    B107.Stroke = New SolidColorBrush(ACAB(AAG)) : B108.Stroke = New SolidColorBrush(ACAB(AAG))
    B100.Visibility = 0 : B200.Visibility = 1 : B300.Visibility = 1 : B400.Visibility = 1 : C100.Visibility = 0
    DA_.Visibility = 1 : AA00.RowDefinitions.Item(1).Height = New GridLength(1, 2) : Grid.SetRow(CA_, 3)
    AA00.RowDefinitions.Item(2).Height = New GridLength(12, 2) : AA00.RowDefinitions.Item(4).Height = New GridLength(6, 2)
    B100.RowDefinitions.Item(0).Height = New GridLength(1, 2) : B100.RowDefinitions.Item(2).Height = New GridLength(7, 2)
  End Sub
  Private Sub AABB()
    ' A:Q-H: Anhang: Q und H
    CA_.Visibility = 0 : B100.Visibility = 1 : Grid.SetRow(CA_, 4)
    A100.Background = New SolidColorBrush(ACAB(AAE)) : CA_.Background = New SolidColorBrush(ACAB(AAE))
    A101.Foreground = New SolidColorBrush(ACAB(AAF)) : A102.Foreground = New SolidColorBrush(ACAB(AAF))
    A103.Foreground = New SolidColorBrush(ACAB(AAF)) : A104.Foreground = New SolidColorBrush(ACAB(AAF))
    A105.Foreground = New SolidColorBrush(ACAB(AAF)) : A106.Foreground = New SolidColorBrush(ACAB(AAF))
    A107.Foreground = New SolidColorBrush(ACAB(AAF)) : A108.Foreground = New SolidColorBrush(ACAB(AAF))
    A109.Foreground = New SolidColorBrush(ACAB(AAF)) : A110.Foreground = New SolidColorBrush(ACAB(AAF))
    B105.Stroke = New SolidColorBrush(ACAB(AAG)) : B106.Stroke = New SolidColorBrush(ACAB(AAG))
    B107.Stroke = New SolidColorBrush(ACAB(AAG)) : B108.Stroke = New SolidColorBrush(ACAB(AAG))
    B200.Visibility = 0 : B300.Visibility = 1 : B400.Visibility = 1 : C100.Visibility = 1 : DA_.Visibility = 1
    AA00.RowDefinitions.Item(1).Height = New GridLength(0, 2) : AA00.RowDefinitions.Item(2).Height = New GridLength(14, 2)
    AA00.RowDefinitions.Item(4).Height = New GridLength(3, 2) : If B200.RowDefinitions.Count > 0 Then Exit Sub

    For i = 1 To 12 Step 1
      B200.ColumnDefinitions.Add(New ColumnDefinition) : B200.RowDefinitions.Add(New RowDefinition) : Next

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
    B100.Visibility = 0 : B200.Visibility = 1 : B103.Visibility = 1 : B104.Visibility = 0 : DA_.Visibility = 1
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
    '      DA_.Visibility = AAC : Else : BAAB() : End If : End Select
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
#End Region
#Region "A-AB"
  Private Sub ABAA()
    B104.Document.Selection.StartPosition = B104.Document.Selection.StoryLength - ACA
    B104.Document.Selection.EndPosition = _B104.Document.Selection.StoryLength - ACB
    B104.Document.Selection.CharacterFormat.Superscript = 1
  End Sub
  Private Sub ABAB()
    B104.Document.Selection.StartPosition = B104.Document.Selection.StoryLength - ACA
    B104.Document.Selection.EndPosition = _B104.Document.Selection.StoryLength - ACB
    B104.Document.Selection.CharacterFormat.Subscript = 1
  End Sub
  Private Sub ABAC()
    If TypeOf FocusManager.GetFocusedElement() Is TextBox Then
      ABB = CType(FocusManager.GetFocusedElement(), TextBox).Name : End If
    If TypeOf FocusManager.GetFocusedElement() Is RichEditBox Then
      ABB = CType(FocusManager.GetFocusedElement(), RichEditBox).Name : End If
  End Sub
  Private Sub ABAD(a As Byte)
    B104.Document.SetText(TextSetOptions.FormatRtf, "") : B104.Document.Selection.ParagraphFormat.SpaceAfter = a ' * BAA
  End Sub
  Private Sub ABAE(a As Color, b As Color, c As String)
    B104.Document.Selection.StartPosition = B104.Document.Selection.StoryLength
    B104.Document.Selection.CharacterFormat.BackgroundColor = a
    B104.Document.Selection.CharacterFormat.ForegroundColor = b : B104.Document.Selection.Text += c
  End Sub
  Private Sub ABAF(a As Object, b As TappedRoutedEventArgs)
    If B111.Children.Count > 1 Then
      BAA = Math.Ceiling(b.GetPosition(B111).X / 10) : If BAA > B111.Children.Count Then BAA = B111.Children.Count
    End If 'ACA = Math.Floor(BAA) ' Abrunden
    AEA.Start() : ABB = "B103" : AA_.X1 = BAA * 10 : AA_.X2 = BAA * 10 : AA_.Y1 = BAB * 10 : AA_.Y2 = BAB * 10 + 17
    AA_.Stroke = New SolidColorBrush(Colors.Magenta)
  End Sub
#End Region
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
#End Region
#Region "A-AD"
  Private Async Sub ADAA()
    If ACAA() = True Then
      Dim aaaaa As String : B103.Document.Selection.StartPosition = 0
      B103.Document.Selection.EndPosition = _B103.Document.Selection.StoryLength

      aaaaa = A_D.GetString("A201") & ":   " & B101.Text & vbCrLf &
        A_D.GetString("A202") & ":   " & B103.Document.Selection.Text

      Dim emailMessage As New EmailMessage With {.Body = aaaaa,
      .Subject = A_D.GetString("A105")}
      emailMessage.To.Add(New EmailRecipient("calculator_message_@outlook.com"))
      Await EmailManager.ShowComposeNewEmailAsync(emailMessage)
      'ABAE(Colors.AliceBlue, Colors.Blue, vbCrLf & "Internetverbindung besteht")
    Else
      ABAE(Colors.AliceBlue, Colors.Blue, vbCrLf & "Keine Internetverbindung")
    End If
  End Sub
#End Region
#End Region
  ' * BBBB * BBBB * BBBB * BBBB *
#Region "BBBB"
#Region "B-AA"
  Private Sub BAAB()
    Select Case AA_.Visibility : Case 0 : AA_.Visibility = 1 : Case 1 : AA_.Visibility = 0 : End Select
  End Sub
#End Region
#Region "B-AX"
  Private Sub BXAA()
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
  Private Sub BXAB(a As String)
    EA_ = New TextBlock With {.Text = a, .FontFamily = New FontFamily("Consolas"),
      .Margin = New Thickness(BAA * 10, BAB * 10, 0, 0)} : B111.Children.Insert(BAA - 1, EA_)
    BCA.Insert(BAA - 1, BAA * 10) : BCB.Insert(BAA - 1, BAB * 10) : BAA += 1
    AA_.X1 = BAA * 10 : AA_.X2 = BAA * 10 : AA_.Y1 = BAB * 10 : AA_.Y2 = BAB * 10 + 17
    If B111.Children.Count > BAA Then : For i = BAA - 1 To B111.Children.Count - 2 Step 1
        ACAF(B111.Children(i)).Margin = New Thickness(i * 10 + 10, BCB(i), 0, 0)
        BCA(i) = i * 10 + 10 : Next : End If
  End Sub
  Private Sub BXAC(a As String)
    EA_ = New TextBlock With {.Text = "∫", .FontFamily = New FontFamily("Consolas"),
      .Scale = New System.Numerics.Vector3(1.0, 3.0, 1.0),
      .Margin = New Thickness(BAA * 10, BAB * 10, 0, 0)} : B111.Children.Insert(BAA - 1, EA_)
    BCA.Insert(BAA - 1, BAA * 10) : BCB.Insert(BAA - 1, BAB * 10) : BAA += 1
    BAB += 2 : AA_.X1 = BAA * 10 : AA_.X2 = BAA * 10 : AA_.Y1 = BAB * 10 : AA_.Y2 = BAB * 10 + 17
    If BAA > 2 Then : For i = 0 To BAA - 3 Step 1
        ACAF(B111.Children(i)).Margin = New Thickness(BCA(i), BAB * 10, 0, 0) : BCB(i) = BAB * 10
      Next : End If
    If B111.Children.Count > BAA Then : For i = BAA - 1 To B111.Children.Count - 2 Step 1
        ACAF(B111.Children(i)).Margin = New Thickness(i * 10 + 10, BAB * 10, 0, 0)
        BCA(i) = i * 10 + 10 : BCB(i) = BAB * 10 : Next : End If
  End Sub
#End Region
#Region "B-AY"
#End Region
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

    For i = 1 To 32 Step 1 : ABA = If(i < 10, "00", "0")
      eaaab = New TextBlock With {.FontSize = 12, .Text = A_A.GetString("A" & ABA & CStr(i))} '  * BAA
      eaaaa = New Button With {.Padding = New Thickness(0), .Content = eaaab, .VerticalAlignment = 3,
            .HorizontalAlignment = 3, .Background = New SolidColorBrush(Colors.WhiteSmoke),
            .Margin = New Thickness(0.5)} : B300.Children.Add(eaaaa) '  * BAA
      Grid.SetRow(eaaaa, CInt(eaaba(i - 1))) : Grid.SetColumn(eaaaa, CInt(eaabb(i - 1))) : Next

    Grid.SetColumnSpan(ACAD(B300.Children.Item(0)), 2) : Grid.SetColumnSpan(ACAD(B300.Children.Item(1)), 11)
    Grid.SetColumnSpan(ACAD(B300.Children.Item(2)), 5)

    eaaba = ("3´3´4´4´4´4´4´4´4´4´5´5´5´5´5´5´5´5´6´6´6´6´6´6´6´6´6´6´6´6´6´6´6´6´6´6´7´7´7´7´7´7´7´7´7´7" &
          "´7´7´7´7´7´7´7´7´8´8´8´10´10´10´10´10´10´10´10´10´10´10´10´10´10´8´8´8´8´8´8´8´8´8´8´8´8´8´8´8" &
          "´9´9´9´11´11´11´11´11´11´11´11´11´11´11´11´11´11´9´9´9´9´9´9´9´9´9´9´9´9´9´9´9").Split("´")
    eaabb = ("2´20´2´3´15´16´17´18´19´20´2´3´15´16´17´18´19´20´2´3´4´6´7´8´9´10´11´12´13´14´15´16´17´18´1" &
          "9´20´2´3´4´6´7´8´9´10´11´12´13´14´15´16´17´18´19´20´2´3´4´6´7´8´9´10´11´12´13´14´15´16´17´18´1" &
          "9´6´7´8´9´10´11´12´13´14´15´16´17´18´19´20´2´3´4´6´7´8´9´10´11´12´13´14´15´16´17´18´19´6´7´8´9" &
          "´10´11´12´13´14´15´16´17´18´19´20").Split("´")

    For i = 1 To 118 Step 1 : ABA = "B" & If(i < 10, "00", If(i < 100, "0", "")) & CStr(i)
      eaaab = New TextBlock With {.FontFamily = New FontFamily("Calibri Light")}
      Select Case ACAC(i - 1) : Case "0", "2", "8"
          eaaab.Foreground = New SolidColorBrush(Colors.White) : End Select
      eaaaa = New Button With {.Background = New SolidColorBrush(ACAB(CInt(ACAC(i - 1)))),
        .Padding = New Thickness(0), .HorizontalContentAlignment = 0, .Content = eaaab,
        .VerticalAlignment = 3, .HorizontalAlignment = 3, .Margin = New Thickness(0.5)}
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
      Case "9.19" : ABA = "117" : Case "9.20" : ABA = "118" : Case Else : ABA = 0 : End Select : _AB = ABA : CABC()
  End Sub
  Private Sub CABB()
    ' Die Auswahl des chemischen Elements von der Liste
    ABA = CStr(DA_.SelectedIndex + 1) : CABC()
  End Sub
  Private Sub CABC()
    ' Das Laden des chemischen Elements
    B401.Background = New SolidColorBrush(ACAB(CInt(ACAC(CInt(ABA) - 1)))) : B400.Visibility = 0
    CA_.Background = B401.Background : Select Case ACAC(CInt(ABA) - 1) : Case 0, 2, 8
        B401.Foreground = New SolidColorBrush(Colors.White) : End Select : B300.Visibility = 1
    AAB = 6 : A100.Background = B401.Background
    A101.Foreground = B401.Foreground : A102.Foreground = B401.Foreground : A103.Foreground =
      B401.Foreground : A104.Foreground = B401.Foreground : A105.Foreground = B401.Foreground
    A106.Foreground = B401.Foreground : A107.Foreground = B401.Foreground : A108.Foreground =
      B401.Foreground : A109.Foreground = B401.Foreground : A110.Foreground = B401.Foreground
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
    B401.Content = aaaaa
    B401.VerticalAlignment = 3 : B401.HorizontalAlignment = 3 : EB_.FontSize = 16

    aaaaa.Children.Add(EA_) : Grid.SetRow(EA_, 0) : Grid.SetColumn(EA_, 0)
    aaaaa.Children.Add(EB_) : Grid.SetRow(EB_, 2) : Grid.SetColumn(EB_, 2) : Grid.SetRow(B400, 2)
    aaaab = New TextBlock With {.MinWidth = 50, .MinHeight = 20}
    aaaaa.Children.Add(aaaab) : Grid.SetRow(aaaab, 1) : Grid.SetColumn(aaaab, 1) : Grid.SetColumn(B401, 1)
    aaaab = New TextBlock With {.FontSize = 16, .Text = A_E.GetString("A003")}
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
  ' * DDDD * DDDD * DDDD * DDDD *
#Region "DDDD"

#End Region
  ' * EEEE * EEEE * EEEE * EEEE *
#Region "EEEE"

#End Region
#End Region
End Class