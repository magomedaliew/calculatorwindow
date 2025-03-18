Imports Windows.UI
Imports Windows.UI.Text
Imports Windows.Storage
Imports Windows.ApplicationModel.Resources
Public NotInheritable Class MainPage
  ' بِسْمِ اللَّهِ الرَّحْمَـٰنِ الرَّحِيمِ
  Inherits Page
  ' * AAAA * AAAA * AAAA * AAAA *
#Region "AAAA"
#Region "A-00"
  ' Deklaration
  Dim AAA, AAB As Byte : Dim BAA As Double

  Dim NAA As New ResourceLoader("A_a_a_a_a")
  Dim NAB As New ResourceLoader("A_a_a_a_b")
  Dim NAC As New ResourceLoader("A_b_a_a_a")
  Dim NAD As New ResourceLoader("Resources")
  Dim NAE As New ResourceLoader("Source_aa")

  Dim _AA As String

  Dim _FA() As String

  Dim _EA, _EB, _EC, _ED, _EE, _EF, _EG, _EH As New Color
  Dim _EI, _EJ, _EK, _EL, _EM, _EN, _EO, _EP As New Color
  Dim _EQ, _ER, _ES, _ET As New Color

  Dim A_A, A_B, A_C, A_D, A_E, A_F, A_G, A_H As New ToolTip

  Dim A_01 As New Canvas


#End Region ' *****
#Region "A-A0"
  Private Sub A_A_() Handles AAA0.Loaded
    Try
      '1     Anweisungen
      B103.IsSpellCheckEnabled = False
      B104.IsSpellCheckEnabled = False
      A_A.Content = NAD.GetString("A001")
      A_B.Content = NAD.GetString("A002")
      A_C.Content = NAD.GetString("A003")
      A_D.Content = NAD.GetString("A004")
      A_E.Content = NAD.GetString("A005")
      A_F.Content = NAD.GetString("A006")
      A_G.Content = NAD.GetString("A007")
      A_H.Content = NAD.GetString("A008")
      ToolTipService.SetToolTip(A101, A_A)
      ToolTipService.SetToolTip(A102, A_B)
      ToolTipService.SetToolTip(A103, A_C)
      ToolTipService.SetToolTip(A104, A_D)
      ToolTipService.SetToolTip(A105, A_E)
      ToolTipService.SetToolTip(A106, A_F)
      ToolTipService.SetToolTip(A107, A_G)
      ToolTipService.SetToolTip(A108, A_H)
      A_A.Placement = PlacementMode.Bottom
      A_B.Placement = PlacementMode.Bottom
      A_C.Placement = PlacementMode.Bottom
      A_D.Placement = PlacementMode.Bottom
      A_E.Placement = PlacementMode.Bottom
      A_F.Placement = PlacementMode.Bottom
      A_G.Placement = PlacementMode.Bottom
      A_H.Placement = PlacementMode.Bottom
      _EA = Color.FromArgb(255, 0, 255, 120)
      _EB = Color.FromArgb(170, 170, 170, 170)
      _EC = Colors.Olive : _ED = Colors.Orange
      _EE = Colors.Gray : _EF = Colors.LightGray
      _EG = Colors.Pink : _EH = Colors.LightPink
      _EI = Colors.White : _EJ = Colors.WhiteSmoke
      _EK = Colors.Blue : _EL = Colors.DeepSkyBlue
      _EM = Colors.Gold : _EN = Colors.GreenYellow
      _EO = Colors.SkyBlue : _EP = Colors.AliceBlue
      _EQ = Colors.Violet : _ER = Colors.DarkViolet
      _ES = Colors.Magenta : _ET = Colors.MistyRose
      A109.Content = "A1" : A110.Content = "B1"
      C101.Content = "1" : C102.Content = "2"
      C103.Content = "3" : C104.Content = "4"
      C105.Content = "5" : C106.Content = "6"
      C107.Content = "7" : C108.Content = "8"
      C109.Content = "9" : C110.Content = "0"
      C111.Content = "e" : C112.Content = "π"
      C113.Content = "[" : C114.Content = "ǀ"
      C115.Content = "|" : C116.Content = "]"
      C117.Content = "+" : C118.Content = "*"
      C119.Content = "^" : C120.Content = "∞"
      C121.Content = "–" : C122.Content = ":"
      C123.Content = "√" : C124.Content = "Δ"
      C125.Content = "-"
      C127.Content = "´" : C128.Content = "°"
      C129.Content = "(" : C130.Content = ")"
      C131.Content = "!" : C132.Content = "→"
      C133.Content = "θ" : C134.Content = "Ʃ"
      C135.Content = "∏" : C136.Content = "ʃ"
      C137.Content = "ϕ" : C138.Content = "ln"
      C139.Content = "lim" : C140.Content = "log"
      C141.Content = "cos" : C142.Content = "sin"
      C143.Content = "tan" : C144.Content = "cot"
      C145.Content = "acos" : C146.Content = "asin"
      C147.Content = "atan" : C148.Content = "acot"
      A101.Foreground = New SolidColorBrush(_EK)
      A102.Foreground = New SolidColorBrush(_EK)
      A103.Foreground = New SolidColorBrush(_EK)
      A104.Foreground = New SolidColorBrush(_EK)
      A105.Foreground = New SolidColorBrush(_EK)
      A106.Foreground = New SolidColorBrush(_EK)
      A107.Foreground = New SolidColorBrush(_EK)
      A108.Foreground = New SolidColorBrush(_EK)
      A109.Foreground = New SolidColorBrush(_EK)
      A110.Foreground = New SolidColorBrush(_EK)
      B101.PlaceholderText = NAD.GetString("A021")
      B103.PlaceholderText = NAD.GetString("A021")
      B104.PlaceholderText = NAD.GetString("A200")
      C126.Content = NAD.GetString("A104")
      '2     Load a setting that is local to the device
      Dim aa As ApplicationDataContainer
      aa = ApplicationData.Current.LocalSettings
      '3     Upgrade
      If aa.Values("upgrade") <> "18.02.2022" Then
        AFAA() : AFAB() : AFAD(5) : AFAE(Colors.White)
        B104.FontFamily = New FontFamily("Segoe UI")
        AFAH(NAD.GetString("E001") & vbCrLf)
        AFAF(Colors.Lime) : AFAB()
        AFAH(NAE.GetString("A002") & vbCrLf & vbCrLf)
        AFAF(Colors.Black) : End If
      '4     Titel
      Dim title = ApplicationView.GetForCurrentView().
        TitleBar : title.BackgroundColor = _EI
      title.ForegroundColor = Colors.Gray
      title.ButtonBackgroundColor = Colors.White
      title.ButtonForegroundColor = Colors.Gray
      title.InactiveBackgroundColor = Colors.White
      title.InactiveForegroundColor = Colors.Gray
      title.ButtonHoverBackgroundColor = Colors.White
      title.ButtonHoverForegroundColor = Colors.Pink
      title.ButtonInactiveBackgroundColor = _EI
      title.ButtonInactiveForegroundColor = Colors.Gray
      title.ButtonPressedBackgroundColor = Colors.Gold
      title.ButtonPressedForegroundColor = Colors.Pink
      '5    GridDefinitionsAdd
      For i = 1 To 5 Step 1
        AA00.RowDefinitions.Add(New RowDefinition) : Next
      For i = 1 To 12 Step 1
        A100.ColumnDefinitions.Add(New ColumnDefinition) : Next
      For i = 1 To 2 Step 1
        B100.RowDefinitions.Add(New RowDefinition) : Next
      For i = 1 To 4 Step 1
        B100.ColumnDefinitions.Add(New ColumnDefinition) : Next
      For i = 1 To 4 Step 1
        C100.RowDefinitions.Add(New RowDefinition) : Next
      For i = 1 To 16 Step 1
        C100.ColumnDefinitions.Add(New ColumnDefinition) : Next
      '6    GridDefinitionsSet
      AA00.Children.Add(A_01) : Grid.SetRow(B100, 2)
      Grid.SetColumn(A101, 1) : Grid.SetColumn(A102, 2)
      Grid.SetColumn(A103, 3) : Grid.SetColumn(A104, 4)
      Grid.SetColumn(A105, 5) : Grid.SetColumn(A106, 6)
      Grid.SetColumn(A107, 7) : Grid.SetColumn(A108, 8)
      Grid.SetColumn(A109, 9) : Grid.SetColumn(A110, 10)
      Grid.SetRow(B101, 0) : Grid.SetRow(B102, 0)
      Grid.SetRow(B103, 1) : Grid.SetRow(B104, 1)
      Grid.SetRow(B105, 0) : Grid.SetRow(B106, 0)
      Grid.SetRow(B107, 1) : Grid.SetRow(B108, 1)
      Grid.SetRow(B200, 2) : Grid.SetRow(B300, 2)
      Grid.SetColumn(B101, 1) : Grid.SetColumn(B102, 2)
      Grid.SetColumn(B103, 1) : Grid.SetColumn(B104, 2)
      Grid.SetColumn(B105, 1) : Grid.SetColumn(B106, 2)
      Grid.SetColumn(B107, 1) : Grid.SetColumn(B108, 2)
      Grid.SetRow(A_01, 3) : Grid.SetRow(C100, 4)
      _AA = "0´1´0´2´0´3´0´4´1´1´1´2´1´3´1´4´2´1´2´2´2´3"
      _AA &= "´2´4´3´1´3´2´3´3´3´4´0´6´0´7´0´8´0´9´1´6´1"
      _AA &= "´7´1´8´1´9´2´6´2´7´2´8´2´9´3´6´3´7´3´8´3´9"
      _AA &= "´0´11´0´12´0´13´0´14´1´11´1´12´1´13´1´14´"
      _AA &= "2´11´2´12´2´13´2´14´3´11´3´12´3´13´3´14"
      _FA = _AA.Split("´") : For i = 0 To 95 Step 2 : Grid.
          SetRow(C100.Children.Item(i / 2), CInt(_FA(i)))
        Grid.SetColumn(C100.
          Children.Item(i / 2), CInt(_FA(i + 1))) : Next
      '7    C000 Buttons
      For i = 0 To 47 Step 1
        AGAA(C100.Children.Item(i)).HorizontalAlignment = 3
        AGAA(C100.Children.Item(i)).VerticalAlignment = 3
        AGAA(C100.Children.
             Item(i)).Background = New SolidColorBrush(_EI)
        AGAA(C100.Children.Item(i)).
          Foreground = New SolidColorBrush(_EK) : Next
      '8    Alignment
      B101.VerticalAlignment = 3 : B101.HorizontalAlignment = 3
      B102.VerticalAlignment = 3 : B102.HorizontalAlignment = 3
      '9    Ende
      AAB = 1 : A_B_() : Catch ex As Exception : End Try
  End Sub
  Private Sub A_B_() Handles AAA0.SizeChanged
    Try
      If AAA0.ActualWidth > 1.5 * AAA0.ActualHeight Then
        If AAA <> 1 Then : AAA = 1
          BAA = AAA0.ActualHeight / 500 : End If : AEAA()
      Else
        If AAA <> 2 Then : AAA = 2
          BAA = AAA0.ActualHeight / 550 : End If : AEAA()
      End If
    Catch ex As Exception : End Try ' AAA > 0 GAA = Nothing
  End Sub
#End Region ' *****
#Region "A-AA"
  Private Sub A_AA()

  End Sub
  Private Sub A_AB()

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

  End Sub
  Private Sub A_AJ()

  End Sub
#End Region ' *****
#Region "A-AB"
  Private Sub A_BA(sender As AutoSuggestBox, e As AutoSuggestBoxTextChangedEventArgs)
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
#Region "A-AC"
  Private Sub A_CA()

  End Sub
#End Region ' *****
#Region "A-AD"
  Private Sub A_DA()

  End Sub

#End Region ' *****
#Region "A-AE"
  Private Sub AEAA()
    ' Quer-Hoch-Formaten-Seiten
    Select Case 100 * AAA + AAB
      Case = 101 ' Q-Start
#Region ""
        Grid.SetRow(A100, 0) : A_01.Visibility = 0
        A_01.Background = New SolidColorBrush(_EP)
        A109.Visibility = 1 : A110.Visibility = 1 :: AEAB()
        A100.ColumnDefinitions.Item(0).Width = New GridLength(0.3, 2)
        A100.ColumnDefinitions.Item(4).Width = New GridLength(1, 2)
        A100.ColumnDefinitions.Item(5).Width = New GridLength(1, 2)
        A100.ColumnDefinitions.Item(6).Width = New GridLength(1, 2)
        A100.ColumnDefinitions.Item(7).Width = New GridLength(1, 2)
        B100.ColumnDefinitions.Item(1).Width = New GridLength(7, 2)
        B100.ColumnDefinitions.Item(2).Width = New GridLength(11, 2)
        C100.ColumnDefinitions.Item(15).Width = New GridLength(9, 2)
        C100.ColumnDefinitions.Item(0).Width = New GridLength(0.6, 2)
        For i = 5 To 14 Step 1
          C100.ColumnDefinitions.Item(i).Width = New GridLength(1, 2)
        Next
#End Region
      Case = 102 ' Q-Anhang
#Region ""
                'Dim ccc As Object = "AAA0"
        'C145.Content = ccc

        'Dim iii As New Image : Dim biib As BitmapImage : biib = New BitmapImage
        'Dim uuu As Uri : uuu = New Uri("ms-appx:///Assets/LockScreenLogo.scale-200.png")
        'biib.UriSource = uuu : iii.Source = biib
        'A401.Content = iii

#End Region
      Case = 103 ' Q-Listen
#Region ""

#End Region
      Case = 104 ' Q-Tabelle
#Region ""

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
      Case = 105 ' Q-Elemente
#Region ""

#End Region
      Case = 201 ' H-Start
#Region ""
        Grid.SetRow(A100, 3) : A_01.Visibility = 1
        A109.Visibility = 0 : A110.Visibility = 0 : AEAB()
        A100.ColumnDefinitions.Item(0).Width = New GridLength(0.1, 2)
        'A100.ColumnDefinitions.Item(4).Width = New GridLength(1, 2)
        'A100.ColumnDefinitions.Item(5).Width = New GridLength(1, 2)
        'A100.ColumnDefinitions.Item(6).Width = New GridLength(1, 2)
        'A100.ColumnDefinitions.Item(7).Width = New GridLength(1, 2)
        B100.ColumnDefinitions.Item(1).Width = New GridLength(0, 2)
        B100.ColumnDefinitions.Item(2).Width = New GridLength(118, 2)
        C100.ColumnDefinitions.Item(15).Width = New GridLength(0.2, 2)
        C100.ColumnDefinitions.Item(0).Width = New GridLength(0.2, 2)
        'For i = 5 To 14 Step 1
        '  C100.ColumnDefinitions.Item(i).Width = New GridLength(1, 2)
        'Next
#End Region
      Case = 202 ' H-Anhang
#Region ""

#End Region
      Case = 203 ' H-Listen
#Region ""

#End Region
      Case = 204 ' H-Tabelle
#Region ""

#End Region
      Case = 205 ' H-Elemente
#Region ""

#End Region
    End Select
  End Sub
  Private Sub AEAB()
    A100.Background = New SolidColorBrush(_EP) : B100.
      Visibility = 0 : B200.Visibility = 1 : B300.Visibility = 1
    AA00.RowDefinitions.Item(2).Height = New GridLength(12, 2)
    AA00.RowDefinitions.Item(4).Height = New GridLength(6, 2)
    B100.RowDefinitions.Item(0).Height = New GridLength(1, 2)
    B100.RowDefinitions.Item(1).Height = New GridLength(7, 2)
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
#Region "A-AF"
  Private Sub AFAA()
    B104.Document.SetText(TextSetOptions.FormatRtf, "")
  End Sub
  Private Sub AFAB()
    B104.Document.Selection.StartPosition = B104.Document.Selection.StoryLength
  End Sub
  Private Sub AFAC()
    B104.Document.Selection.EndPosition = B104.Document.Selection.StoryLength
  End Sub
  Private Sub AFAD(a As Byte)
    B104.Document.Selection.ParagraphFormat.SpaceAfter = a ' * BAA
  End Sub
  Private Sub AFAE(a As Color)
    B104.Document.Selection.CharacterFormat.BackgroundColor = a
  End Sub
  Private Sub AFAF(a As Color)
    B104.Document.Selection.CharacterFormat.ForegroundColor = a
  End Sub
  Private Sub AFAG(a As String)
    B104.Document.Selection.Text = a
  End Sub
  Private Sub AFAH(a As String)
    B104.Document.Selection.Text += a
  End Sub
  Private Sub AFAI(a As Integer)
    B104.Document.Selection.StartPosition = a
  End Sub
  Private Sub AFAJ(a As Integer)
    B104.Document.Selection.EndPosition = a
  End Sub
  Private Sub AFAK(a As FontStyle)
    B104.Document.Selection.CharacterFormat.FontStyle = a
  End Sub
#End Region ' *****
#Region "A-AG"
  Private Function AGAA(a As Button) As Button
    Return a
  End Function
#End Region
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
End Class
