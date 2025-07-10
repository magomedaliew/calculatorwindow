#Region ""
'بِسْمِ اللَّهِ الرَّحْمَـٰنِ الرَّحِيمِ
#End Region
#Region ""
Imports Windows.Storage
Imports Windows.UI.Xaml
Imports Windows.UI.Xaml.Shapes
Imports Windows.UI.Xaml.Controls
Imports Windows.UI.Xaml.Documents
Imports Windows.Networking.Connectivity
Imports Windows.ApplicationModel.Email
Imports Windows.ApplicationModel.Resources
Imports Windows.UI : Imports Windows.UI.Text
#End Region
#Region ""
Public Class Ξ_A_A
  Public AAA As New List(Of Integer)
  Public AAB As New List(Of Integer)
End Class
#End Region
#Region ""
Public NotInheritable Class MainPage
  Inherits Page
#Region "≡≡≡≡"
#Region "A-01"
  ' Controlls
  Private AA_ As New Line ' Text Kursor in Ξ101
  Private AԳ_ As New Line ' Text Kursor in Ξ102
  Private AԹ_ As New Line ' Text Kursor in Ξ102
  Private BA_ As New Button ' Chemisches Element
  Private CA_ As New Canvas ' AA00 Rows Canvas
  Private CԳ_ As New Canvas ' Canvas 1 in Ξ102
  Private CԹ_ As New Canvas ' Canvas 2 in Ξ102
  Private DA_ As New TextBox ' Übersetzung Ξ101
  Private DB_ As New TextBox ' Übersetzung Ξ102
  Private EA_ As New ListView ' Auto Suggestion
  Private EB_ As New ListView ' Chemische Liste
  Private FA_ As New TextBlock ' Periodentabelle
  Private FB_ As New TextBlock ' Periodentabelle
#End Region
#Region "A-02"
  ' Klassen
  Private Ξ_A As New Ξ_A_A
  Private A_A As New ResourceLoader("A_a_a_a_a")
  Private A_B As New ResourceLoader("A_a_a_a_b")
  Private A_C As New ResourceLoader("A_b_a_a_a")
  Private A_D As New ResourceLoader("Resources")
  Private A_E As New ResourceLoader("Source_aa")
#End Region
#Region "A-11"
  ' Allgemein
  Private AAA As Byte ' Quer-Hochformat Nummer'
  Private AAB As Byte ' Design Seiten Nummer'
  Private AAC As Byte ' A Board Umschalte Zahl'
  Private AAD As Byte ' B Board Umschalte Zahl'
  Private AAE As Byte ' Farben Nummer für ACAB'
  Private AAF As Byte ' Farben Nummer für ACAB'
  Private AAG As Byte ' Farben Nummer für ACAB'
  Private AAH As Byte ' Eingabe Umschalte Zahl'
  Private AΞA As DispatcherTimer ' Kursor Ξ101'
  Private AΞB As DispatcherTimer ' Kursor Ξ102'
#End Region
#Region "A-12"
  ' Mathematik
  Private BGA As String ' Übersetzung von DB_
  Private BHA As Boolean ' Eingabe Feld Auswahl

  Dim _AB As String
  Dim _AC As String
  Dim _AD As String
  Dim _AE As String
  Dim _AF As String
  Dim _AG As String
  Dim _AH As String
  Dim _AI As String

  Private CA As String ' M:Gefertigter Ausdruckstext
  Private CB As String ' M:Gesuchte Variable
  Private CC As String ' M:P:Kommentardefinitionsformel
  Private CH As String ' M:P:Skizzeart

  Dim _BA As Double
  Dim _BB As Double
  Dim _BC As Double


  Private BJA As Integer ' x Position Kursor DA_
  Private BJB As Integer ' y Position Kursor DA_
  Private BJC As Integer ' x Position Kursor DA_
  Private BJD As Integer ' Text Länge alt von DA_
  Private BJE As Integer ' Text Länge neu von DA_
  Private BJF As Integer ' Text Länge alt von DB_
  Private BJG As Integer ' Schichte des Substrings

  Private ReadOnly BԳA As New List(Of Byte) ' Term Vorzeichen
  Private ReadOnly BԳB As New List(Of Byte) ' Operatorgruppe
  Private ReadOnly BԳC As New List(Of Byte) ' Term Funktion
  Private ReadOnly BԳD As New List(Of Byte) ' Term Zahl
  Private ReadOnly BԳE As New List(Of Byte) ' Gesuchte Variable


  Private ReadOnly BՑA As New List(Of String) ' Term Operator
  Private ReadOnly BՑB As New List(Of String) ' Term


  Private ReadOnly BՆC As New List(Of Integer) ' Term Position
  Private ReadOnly BՆD As New List(Of Integer) ' Term Länge

  Private ReadOnly MA As New List(Of Integer) ' M:Teilungsanfang
  Private ReadOnly MC As New List(Of Integer) ' M:Eingangsanfang
  Private ReadOnly MD As New List(Of Integer) ' M:Eingangslänge


  Private ReadOnly ME_ As New List(Of Integer) ' M:Eingangsteilindex
  Private ReadOnly MF_ As New List(Of Integer) ' M:Ausgangsanfang
  Private ReadOnly MG_ As New List(Of Integer) ' M:Ausgangslänge
  Private ReadOnly MH_ As New List(Of Integer) ' M:Ausgangsteilenanzahl
  Private ReadOnly MI_ As New List(Of Integer) ' M:Ausgangsteilenanfangsindex
  Private ReadOnly MN_ As New List(Of Integer) ' M:Formelrechnungsbedingungen

  Private ReadOnly MO_ As New List(Of Integer) ' P:Von FAB ausgewählte Dimensionsgruppen
  Private ReadOnly MP_ As New List(Of Integer) ' P:Von FAB ausgewählte Dimensionsindexe
  Private ReadOnly MQ_ As New List(Of Integer)
  Private ReadOnly MR_ As New List(Of Integer)


  Dim A_, B_ As Boolean

  Dim _A, _B, _C, _D, _E, _F, _G As Integer
  Dim _H, _I, _J, _K, _L, _M, _N As Integer


  Dim _EA As New Color
  Dim _EB As New Color
  Dim _EC As New Color
  Dim _ED As New Color
  Dim _EE As New Color

  Dim _FA() As String
  Dim _FB() As String
  Dim _FD() As String
  Dim _GA() As Color


  Dim _HB() As Integer
  Dim H1(50) As Integer

  Private ReadOnly JA As New List(Of Color)
  Private ReadOnly JB As New List(Of Color)
  Private ReadOnly JC As New List(Of Color)

  Private ReadOnly KA As New List(Of String) ' M:Von KC ausgewählte Ergebnisse
  Private ReadOnly KB As New List(Of String) ' M:Kommentare für KA
  Private KC As New List(Of String) ' M:Von KE ausgewählte Ergebnisse
  Private ReadOnly KD As New List(Of String) ' M:Kommentare für KC
  Private ReadOnly KE As New List(Of String) ' M:Alle mögliche Ergebnisse
  Private ReadOnly KF As New List(Of String) ' M:Kommentare für KE
  Private ReadOnly KG As New List(Of String) ' M:Jeder Schritt der Rechnung


  Private ReadOnly KJ As New List(Of String)
  Private ReadOnly KK As New List(Of String)
  Private ReadOnly KL As New List(Of String)
  Private ReadOnly LA As New List(Of Boolean) ' M:Gesuchte Variable in Gleichung


  Private ReadOnly C1 As New List(Of Integer)
  Private ReadOnly C2 As New List(Of Integer)
  Private ReadOnly C3 As New List(Of Integer)
  Private ReadOnly C4 As New List(Of Integer)
  Private ReadOnly C5 As New List(Of Integer)
  Private ReadOnly C6 As New List(Of Integer)
  Private C7 As New List(Of Integer)


  Private ReadOnly BՆA As New List(Of Integer) ' Term Schichte
  Private ReadOnly BՆԳ As New List(Of Integer) ' BՆC Übersetzung
  Private ReadOnly BՆԹ As New List(Of Integer) ' Term x Position
  Private ReadOnly BՆԸ As New List(Of Integer) ' Term y Position
  Private ReadOnly BՆԺ As New List(Of Integer) ' Term x Skalierung
  Private ReadOnly BՆƐ As New List(Of Integer) ' Term y Skalierung

#End Region
#Region "A-13"
  ' Chemie
  Private CEA As String ' Listen Text Substring
#End Region
#Region "A-14"

#End Region
#Region "A-15"
  ' A Byte
  ' B Char
  ' C Long
  ' D Short
  ' E Double
  ' F Single
  ' G String
  ' H Boolean
  ' I Dezimal
  ' J Integer

  ' Ձ Byte()
  ' Հ Char()
  ' Ɔ Long()
  ' Ɖ Short()
  ' Յ Double()
  ' Է Single()
  ' Ճ String()
  ' Ϟ Boolean()
  ' Ր Dezimal()
  ' Ե Integer()

  ' Գ List Of Byte
  ' Թ List Of Char
  ' Ը List Of Long
  ' Ժ List Of Short
  ' Ɛ List Of Double
  ' Բ List Of Single
  ' Ց List Of String
  ' Կ List Of Boolean
  ' Ւ List Of Dezimal
  ' Ն List Of Integer

  ' Ξ DispatcherTimer

  ' ՁՀƆƉՅԷՃϞՐԵԳԹԸԺƐԲՑԿՒՆԶѰԱԻԽԾՄՇՈՉՊՋՌՎՔՖԴՂ ΔΓΘΛΞΠΣΦΨΩͲ БЗЛУЧЪЬЭЯ
  ' ƔƏƎƋƊƁƳƲƘƬƱ
  ' ႠႡႢႣႤႥႦႧႨႩႪႫႬႯႰႱႲႳႴႵႶႷႸႹႺႼႻႾႿჀჁჂჃჄჅ ჇꓕႮꓘꓛꓞꓤꓨꓩꓭꓯꓱꓶꓷ
#End Region
#End Region
#Region "○○○○"
#Region "AAA0"
  Private Sub A_A_() Handles AAA0.Loaded
    Try
      Dim title = ApplicationView.GetForCurrentView().TitleBar
      title.ButtonPressedForegroundColor = Colors.Pink : title.ButtonHoverForegroundColor = Colors.Pink

      ToolTipService.SetToolTip(A101, New ToolTip With {.Content = A_D.GetString("A001")})
      ToolTipService.SetToolTip(A102, New ToolTip With {.Content = A_D.GetString("A002")})
      ToolTipService.SetToolTip(A103, New ToolTip With {.Content = A_D.GetString("A003")})
      ToolTipService.SetToolTip(A104, New ToolTip With {.Content = A_D.GetString("A004")})
      ToolTipService.SetToolTip(A105, New ToolTip With {.Content = A_D.GetString("A005")})
      ToolTipService.SetToolTip(A106, New ToolTip With {.Content = A_D.GetString("A006")})
      ToolTipService.SetToolTip(A107, New ToolTip With {.Content = A_D.GetString("A007")})
      ToolTipService.SetToolTip(A108, New ToolTip With {.Content = A_D.GetString("A008")})

      AΞA = New DispatcherTimer With {.Interval = TimeSpan.FromMilliseconds(500)} : AddHandler AΞA.Tick, AddressOf B_ϞA
      AΞB = New DispatcherTimer With {.Interval = TimeSpan.FromMilliseconds(500)} : AddHandler AΞB.Tick, AddressOf B_ϞB

      A109.Content = "A1" : A110.Content = "B1" : Ϟ101.Text = A_D.GetString("A201") : Ϟ102.Text = A_D.GetString("A202")
      C126.Content = A_D.GetString("A254") : AA00.Children.Add(CA_) : DB_.AcceptsReturn = True

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

      AA00.Children.Add(DA_) : DA_.MaxHeight = 0 : DA_.MaxWidth = 0 : Ξ101.Children.Add(AA_) : AA_.StrokeThickness = 2
      AA00.Children.Add(DB_) : DB_.MaxHeight = 0 : DB_.MaxWidth = 0 : Ξ102.Children.Add(AԳ_) : AԳ_.StrokeThickness = 2
      B100.Children.Add(EA_) : Grid.SetColumn(EA_, 1) : Grid.SetRowSpan(EA_, 3) : EA_.Margin = New Thickness(0, 30, 0, 0)

      Grid.SetRow(B100, 2) : Grid.SetRow(B300, 2) : Grid.SetRow(C100, 4) : Grid.SetRow(Հ101, 0)
      Grid.SetRow(Հ102, 2) : Grid.SetRow(Հ104, 2) : Grid.SetRow(Ξ100, 0) : Grid.SetRow(EA_, 0)

      Grid.SetColumn(A101, 1) : Grid.SetColumn(A102, 2) : Grid.SetColumn(A103, 3) : Grid.SetColumn(A104, 4)
      Grid.SetColumn(A105, 5) : Grid.SetColumn(A106, 6) : Grid.SetColumn(A107, 7) : Grid.SetColumn(A108, 8)
      Grid.SetColumn(A109, 9) : Grid.SetColumn(A110, 10) : Grid.SetColumn(Հ103, 3) : Grid.SetColumn(Հ102, 1)
      Grid.SetColumn(Հ104, 3) : Grid.SetColumn(Ξ100, 1) : Grid.SetRowSpan(Ξ100, 3) : Grid.SetColumnSpan(Ξ100, 3)

      AddHandler Հ101.Tapped, AddressOf B_ՀA : AddHandler Հ102.Tapped, AddressOf B_ՀB
      AddHandler DA_.TextChanged, AddressOf B_ΔA : AddHandler DA_.SelectionChanged, AddressOf B_ΞA
      AddHandler DB_.TextChanged, AddressOf B_ΔB : AddHandler DB_.SelectionChanged, AddressOf B_ΞB

      Ξ100.Margin = New Thickness(-10, -10, -10, 0) : AAB = 1 : AAH = 1 : EA_.Visibility = 1

      DA_.Focus(3) : AΞA.Start() : AADA() : AADB() : AADC() : A_B_() : Catch ex As Exception : Ϟ104.Text = ex.Message
    End Try
  End Sub
  Private Sub A_B_() Handles AAA0.SizeChanged
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
    AAB = 2 : AAAA() : AΞA.Stop() : AΞB.Stop()
  End Sub
  Private Sub A_AC()
    BAAA() ' : A_AE()
    CA_.Background = New SolidColorBrush(ACAB(AAE))
  End Sub
  Private Sub A_AD()

    CA_.Background = New SolidColorBrush(ACAB(AAE))
  End Sub
  Private Sub A_AE()

    'If AAA = 2 Then AFAD(C003, C007) : AFAC(C004, C008) ' !!!

    'If A_E.Content = NAD.GetString("A005") Then
    '  For i = 0 To KA.Count - 1 Step 1 : AIAZ() : AIAE(Colors.Blue)
    '    AIAJ(KA(i).Replace(NAD.GetString("B003"), NAD.GetString("B004")) & vbCrLf)
    '    AIAZ() : AIAE(Colors.DeepSkyBlue) : AIAJ(KB(i) & vbCrLf & vbCrLf)
    '  Next
    '  A_E.Content = NAD.GetString("A052")
    '  B005.Foreground = New SolidColorBrush(Colors.Violet)
    'ElseIf A_E.Content = NAD.GetString("A052") Then
    '  B005.Foreground = New SolidColorBrush(Colors.Violet)
    '  For j = 0 To KL.Count - 1 Step 1
    '    AIAZ() : AIAE(JC(j)) : C004.Document.Selection.Text += KL(j)
    '  Next
    '  A_E.Content = NAD.GetString("A005")
    'End If

    CA_.Background = New SolidColorBrush(ACAB(AAE))
  End Sub
  Private Sub A_AF()

    CA_.Background = New SolidColorBrush(ACAB(AAE))
  End Sub
  Private Sub A_AG()

    CA_.Background = New SolidColorBrush(ACAB(AAE))
  End Sub
  Private Sub A_AH()

    CA_.Background = New SolidColorBrush(ACAB(AAE))
  End Sub
  Private Sub A_AI()
    AACA()
  End Sub
  Private Sub A_AJ()
    AACB()
  End Sub
#End Region
#Region "B100"
  Private Sub B_ՀA(a As Object, b As TappedRoutedEventArgs)
    Try : AΞB.Stop() : DA_.Focus(3) : AAH = 1 : DA_.SelectionLength = 0
      BJA = Math.Ceiling((b.GetPosition(Հ101).X - 4) / 10) : If BJA > DA_.Text.Length Then BJA = DA_.Text.Length
      AA_.Visibility = 0 : AΞA.Start() : AA_.X1 = BJA * 10 : AA_.X2 = BJA * 10 : AA_.Y1 = 2 : AA_.Y2 = 15
      AԳ_.Visibility = 1 : DA_.SelectionStart = BJA : Catch ex As Exception : Ϟ104.Text = "B_ՀA: " & ex.Message : End Try
  End Sub
  Private Sub B_ϞA()
    ' Kursor-1-Blinken
    Select Case AA_.Visibility : Case 0 : AA_.Visibility = 1 : Case 1 : AA_.Visibility = 0 : End Select
  End Sub
  Private Sub B_ΔA()
    Try ' DA_ Eingabe: TextChanged
      BJE = DA_.Text.Length
      ' Eignung zur TextBox Eigenschaften
      If BHA = True Then DA_.Focus(3) : BJA = BJC + BJE - BJD : DA_.SelectionStart = BJA : BHA = False
      ' wenn der Text kleiner geworden ist: ' a|bc)d
      If BJE - BJD < 0 Then
        For i = BJA + BJD - BJE - 1 To BJA Step -1 : Ξ101.Children.RemoveAt(i) : Next
        For i = BJA To Ξ101.Children.Count - 3 Step 1 : ACAF(Ξ101.Children(i)).Margin = New Thickness(i * 10, 0, 0, 0)
        Next : End If
      ' wenn der Text größer geworden ist: ' a(bc|d
      If BJE - BJD > 0 Then
        For i = BJA + BJD - BJE To BJA - 1 Step 1 : Ξ101.Children.Insert(i, New TextBlock With
                               {.Text = DA_.Text.Substring(i, 1), .Foreground = New SolidColorBrush(ACAB(AAG))}) : Next
        For i = BJA + BJD - BJE To Ξ101.Children.Count - 3 Step 1
          ACAF(Ξ101.Children(i)).Margin = New Thickness(i * 10, 0, 0, 0) : Next : End If

      BJD = BJE : If DA_.Text = "" Then Ϟ101.Text = A_D.GetString("A201") : Exit Sub Else Ϟ101.Text = ""

      'EA_.Items.Add(New TextBlock With {.Text = "AA_", .Foreground = New SolidColorBrush(Colors.White)})
      'EA_.Items.Add(New TextBlock With {.Text = "AA_", .Foreground = New SolidColorBrush(Colors.White)})
      'EA_.Items.Add(New TextBlock With {.Text = "AA_", .Foreground = New SolidColorBrush(Colors.White)})

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
      '  If CI <> "" Then
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

    Catch ex As Exception : Ϟ104.Text = "B_ΔA: " & ex.Message : End Try
  End Sub
  Private Sub B_ΞA()

    DA_.MaxWidth = 500 : DA_.MaxHeight = 100

    BJA = DA_.SelectionStart ' DA_ Eingabe: SelectionChanged
    For i = 0 To Ξ101.Children.Count - 2 Step 1
      ACAF(Ξ101.Children(i)).Foreground = New SolidColorBrush(ACAB(AAG))
    Next
    For i = BJA To BJA + DA_.SelectionLength - 1 Step 1
      ACAF(Ξ101.Children(i)).Foreground = New SolidColorBrush(Colors.SkyBlue)
    Next
    If DA_.SelectionLength = 0 Then : AΞA.Start() : AA_.Visibility = 0
      AA_.X1 = BJA * 10 : AA_.X2 = BJA * 10 : AA_.Y1 = 2 : AA_.Y2 = 15
    Else : AΞA.Stop() : AA_.Visibility = 1 : End If
  End Sub
  Private Sub B_ՀB(a As Object, b As TappedRoutedEventArgs)
    Try : AΞA.Stop() : DB_.Focus(3) : AAH = 2 : DB_.SelectionLength = 0
      BJA = Math.Ceiling((b.GetPosition(Հ102).X - 4) / 10) : If BJA > DB_.Text.Length Then BJA = DB_.Text.Length
      AԳ_.Visibility = 0 : AΞB.Start() : AԳ_.X1 = BJA * 10 : AԳ_.X2 = BJA * 10 : AԳ_.Y1 = 2 : AԳ_.Y2 = 15
      AA_.Visibility = 1 : DB_.SelectionStart = BJA : Catch ex As Exception : Ϟ104.Text = "B_ՀB: " & ex.Message : End Try
  End Sub
  Private Sub B_ϞB()
    ' Kursor-2-Blinken
    Select Case AԳ_.Visibility : Case 0 : AԳ_.Visibility = 1 : Case 1 : AԳ_.Visibility = 0 : End Select
  End Sub
  Private Sub B_ΔB()
    Try ' DB_ Eingabe: TextChanged
      BJE = DB_.Text.Length
      ' Eignung zur TextBox Eigenschaften
      If BHA = True Then DB_.Focus(3) : BJA = BJC + BJE - BJF : DB_.SelectionStart = BJA : BHA = False
      ' CLASSIC
      If ApplicationData.Current.LocalSettings.Values("textstyle") = "" Then
        ' wenn der Text kleiner geworden ist: ' a|bc)d
        If BJE - BJF < 0 Then
          For i = BJA + BJF - BJE - 1 To BJA Step -1 : Ξ102.Children.RemoveAt(i) : Next
          For i = BJA To Ξ102.Children.Count - 3 Step 1 : ACAF(Ξ102.Children(i)).Margin = New Thickness(i * 10, 0, 0, 0)
          Next : End If
        ' wenn der Text größer geworden ist: ' a(bc|d
        If BJE - BJF > 0 Then
          For i = BJA + BJF - BJE To BJA - 1 Step 1 : Ξ102.Children.Insert(i, New TextBlock With
                               {.Text = DB_.Text.Substring(i, 1), .Foreground = New SolidColorBrush(ACAB(AAG))}) : Next
          For i = BJA + BJF - BJE To Ξ102.Children.Count - 3 Step 1
            ACAF(Ξ102.Children(i)).Margin = New Thickness(i * 10, 0, 0, 0) : Next : End If
      End If
      ' MATHPRINT
      If ApplicationData.Current.LocalSettings.Values("textstyle") = "." Then
        BBAA()

      End If
      BJF = BJE : If DB_.Text = "" Then Ϟ102.Text = A_D.GetString("A202") : Exit Sub Else Ϟ102.Text = ""
    Catch ex As Exception : Ϟ104.Text = "B_ΔB: " & ex.Message : End Try
  End Sub
  Private Sub B_ΞB()
    BJA = DB_.SelectionStart ' DB_ Eingabe: SelectionChanged
    For i = 0 To Ξ102.Children.Count - 2 Step 1
      ACAF(Ξ102.Children(i)).Foreground = New SolidColorBrush(ACAB(AAG)) : Next
    For i = BJA To BJA + DB_.SelectionLength - 1 Step 1
      ACAF(Ξ102.Children(i)).Foreground = New SolidColorBrush(Colors.SkyBlue)
    Next
    If DB_.SelectionLength = 0 Then : AΞB.Start() : AԳ_.Visibility = 0

      AԳ_.X1 = BJA * 10 : AԳ_.X2 = BJA * 10 : AԳ_.Y1 = 2 : AԳ_.Y2 = 15

    Else : AΞB.Stop() : AԳ_.Visibility = 1 : End If
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

    'AAB = 3 : AAAA() : ABAD(0) : Ϟ104.FontFamily = New FontFamily("Consolas") : CEA = "				"
    'ABAE(Colors.AliceBlue, Colors.Blue, A_D.GetString("E002") & vbLf & vbLf & vbLf)
    'ABAE(Colors.AliceBlue, Colors.Blue, A_D.GetString("E201") & CEA & A_D.GetString("E202") & vbLf & vbLf)
    'CEA = "					"
    'ACA = 14 : ACB = 13 : ABAE(Colors.AliceBlue, Colors.Blue, "ab" & CEA & "a ^ b" & vbLf & vbLf) : ABAA()
    'ACA = 19 : ACB = 18 : ABAE(Colors.AliceBlue, Colors.Blue, "b√a" & CEA & "√(a ' b)" & vbLf & vbLf) : ABAA()
    'ACA = 20 : ACB = 19 : ABAE(Colors.AliceBlue, Colors.Blue, "logab" & CEA & "log(a ' b)" & vbLf & vbLf) : ABAB()
    'ACA = 20 : ACB = 19 : ABAE(Colors.AliceBlue, Colors.Blue, "limab" & CEA & "lim(a ' b)" & vbLf & vbLf) : ABAB()
    'ACA = 24 : ACB = 23 : ABAE(Colors.AliceBlue, Colors.Blue, "Ʃab c" & CEA & "Ʃ(a ' b ' c)" & vbLf & vbLf) : ABAB()
    'ACA = 23 : ACB = 24 : ABAA()
    'ACA = 24 : ACB = 23 : ABAE(Colors.AliceBlue, Colors.Blue, "∏ab c" & CEA & "∏(a ' b ' c)" & vbLf & vbLf) : ABAB()
    'ACA = 33 : ACB = 32 : ABAA() : CEA = "				"
    'ACA = 30 : ACB = 29 : ABAE(Colors.AliceBlue, Colors.Blue, "a∫b x dx" & CEA & "∫(a ' b ' x d(x))") : ABAB()
    'ACA = 28 : ACB = 27 : ABAA()
  End Sub
  Private Sub B_BC()
  End Sub
  Private Sub B_BD()
    AAB = 7 : B500.Visibility = 0 : B100.Visibility = 1 : B200.Visibility = 1 ' : AADA()

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
    Try : ADAA() : Catch ex As Exception : End Try
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
    'For i = 1 To 87 Step 1 : CEA = If(i < 10, "00", "0") & CStr(i)
    '  ABAE(Colors.White, Colors.Blue, (A_C.GetString("B" & CEA) & "       ").Substring(0, 8))
    '  ABAE(Colors.White, Colors.DeepSkyBlue, A_D.GetString("C" & CEA) & vbLf) : Next
  End Sub
  Private Sub B_BJ()
    AAB = 5 : AAAA()
  End Sub
#End Region
#Region "C100"
  Private Sub C_AA(a As Button, b As RoutedEventArgs)
    If AAH = 1 Then BJC = DA_.SelectionStart : BHA = True : DA_.Text = DA_.Text.Insert(BJC, a.Content)
    If AAH = 2 Then BJC = DB_.SelectionStart : BHA = True : DB_.Text = DB_.Text.Insert(BJC, a.Content)
  End Sub
  Private Sub C_AB(a As Button, b As RoutedEventArgs)
    If AAH = 1 Then BJC = DA_.SelectionStart : BHA = True : DA_.Text = DA_.Text.Insert(BJC, " " & a.Content & " ")
    If AAH = 2 Then BJC = DB_.SelectionStart : BHA = True : DB_.Text = DB_.Text.Insert(BJC, a.Content)
  End Sub
  Private Sub C_AC(a As Button, b As RoutedEventArgs)
    If AAH = 1 Then BJC = DA_.SelectionStart : BHA = True : DA_.Text = DA_.Text.Insert(BJC, a.Content & "()")
    If AAH = 2 Then BJC = DB_.SelectionStart : BHA = True : DB_.Text = DB_.Text.Insert(BJC, a.Content & "()")
  End Sub
  Private Sub C_AD(a As Button, b As RoutedEventArgs)
    If AAH = 1 Then BJC = DA_.SelectionStart : BHA = True : DA_.Text = DA_.Text.Insert(BJC, a.Content & "(')")
    If AAH = 2 Then BJC = DB_.SelectionStart : BHA = True : DB_.Text = DB_.Text.Insert(BJC, a.Content & "(')")
  End Sub
  Private Sub C_AE(a As Button, b As RoutedEventArgs)
    If AAH = 1 Then BJC = DA_.SelectionStart : BHA = True : DA_.Text = DA_.Text.Insert(BJC, a.Content & "('')")
    If AAH = 2 Then BJC = DB_.SelectionStart : BHA = True : DB_.Text = DB_.Text.Insert(BJC, a.Content & "('')")
  End Sub
  Private Sub C_AF(a As Button, b As RoutedEventArgs)
    If AAH = 1 Then BJC = DA_.SelectionStart : BHA = True : DA_.Text = DA_.Text.Insert(BJC, a.Content & "(''d)")
    If AAH = 2 Then BJC = DB_.SelectionStart : BHA = True : DB_.Text = DB_.Text.Insert(BJC, a.Content & "(''d)")
  End Sub
  Private Sub C_AG(a As Button, b As RoutedEventArgs)
    Select Case a.Content
      Case "⛭"
      Case "⛯"
      Case "⬜"
      Case "▲"
      Case "◀"
      Case "▶"
      Case "▼"
    End Select
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
        AAAB() : B200.Visibility = 1 : B300.Visibility = 0 : EB_.Visibility = 1 : If B300.Children.Count = 0 Then CAAA()
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
        AAAB() : B200.Visibility = 1 : B300.Visibility = 1 : EB_.Visibility = 0 : If EB_.Items.Count = 0 Then CAAB()
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
    End If : CA_.Background = New SolidColorBrush(ACAB(AAE))
    A100.ColumnDefinitions.Item(0).Width = New GridLength(0.3, 2)
  End Sub
  Private Sub AABA()
    ' S:Q-H: Start: Q und H
    B100.Visibility = 0 : B200.Visibility = 1 : B300.Visibility = 1 : B400.Visibility = 1 : C100.Visibility = 0
    B500.Visibility = 1 : EB_.Visibility = 1 : Հ101.Visibility = 0 : Հ103.Visibility = 0 : Հ102.Visibility = 0
    AA00.RowDefinitions.Item(1).Height = New GridLength(1, 2) : Grid.SetRow(CA_, 3)
    AA00.RowDefinitions.Item(2).Height = New GridLength(12, 2) : AA00.RowDefinitions.Item(4).Height = New GridLength(6, 2)
    B100.RowDefinitions.Item(0).Height = New GridLength(1, 2) : B100.RowDefinitions.Item(2).Height = New GridLength(7, 2)
  End Sub
  Private Sub AABB()
    ' A:Q-H: Anhang: Q und H
    B100.Visibility = 1 : B200.Visibility = 0 : B300.Visibility = 1 : B400.Visibility = 1 : C100.Visibility = 1
    B500.Visibility = 1 : CA_.Visibility = 0 : EB_.Visibility = 1 : Grid.SetRow(CA_, 4)

    AA00.RowDefinitions.Item(1).Height = New GridLength(0, 2) : AA00.RowDefinitions.Item(4).Height = New GridLength(3, 2)
    AA00.RowDefinitions.Item(2).Height = New GridLength(14, 2) : AAG = AAE : If AAG = 10 Then AAG = 4

    ' Anhang - Background
    B200.Background = New LinearGradientBrush With {.StartPoint = New Point(0.5, 0), .EndPoint = New Point(0.5, 1),
      .GradientStops = New GradientStopCollection From {New GradientStop With {.Color = ACAB(AAG), .Offset = 0},
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

    ToolTipService.SetToolTip(B201, New ToolTip With {.Content = A_D.GetString("A101")})
    ToolTipService.SetToolTip(B202, New ToolTip With {.Content = A_D.GetString("A102")})
    ToolTipService.SetToolTip(B203, New ToolTip With {.Content = A_D.GetString("A103")})
    ToolTipService.SetToolTip(B204, New ToolTip With {.Content = A_D.GetString("A104")})
    ToolTipService.SetToolTip(B205, New ToolTip With {.Content = A_D.GetString("A105")})
    ToolTipService.SetToolTip(B206, New ToolTip With {.Content = A_D.GetString("A106")})
    ToolTipService.SetToolTip(B207, New ToolTip With {.Content = A_D.GetString("A107")})
    ToolTipService.SetToolTip(B208, New ToolTip With {.Content = A_D.GetString("A108")})
    ToolTipService.SetToolTip(B209, New ToolTip With {.Content = A_D.GetString("A109")})
    ToolTipService.SetToolTip(B210, New ToolTip With {.Content = A_D.GetString("A110")})

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

    ' Icons 1-9
    For i = 0 To 8 Step 1 : ACAD(B200.Children.Item(i)).Content = New Image With {.Source = New BitmapImage With
        {.UriSource = New Uri("ms-appx:///Assets/A_A_00" & CStr(i + 1) & ".png")}} : Next
    ' Icon 10-99
    B210.Content = New Image With {.Source = New BitmapImage With {.UriSource = New Uri("ms-appx:///Assets/A_A_010.png")}}
  End Sub
  Private Sub AABC()
    ' L:Q-H: Listen: Q und H
    B100.Visibility = 0 : B200.Visibility = 1 : Հ102.Visibility = 1 : Հ104.Visibility = 0 : EB_.Visibility = 1
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
    '      EB_.Visibility = AAC : Else : B_ϞA() : End If : End Select
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
    Ξ100.Stroke = New SolidColorBrush(ACAB(AAG))
  End Sub
  Private Sub AADC()
    ' Helligkeit - Bearbeitung
    Select Case ApplicationData.Current.LocalSettings.Values("lightness")
      Case "."
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
        AA00.Background = New SolidColorBrush(Colors.Blue)
        Ϟ101.Foreground = New SolidColorBrush(Colors.White)
        Ϟ102.Foreground = New SolidColorBrush(Colors.White)
        Ϟ103.Foreground = New SolidColorBrush(Colors.White)
        Ϟ104.Foreground = New SolidColorBrush(Colors.White)
        C100.Background = New SolidColorBrush(Colors.Blue)
        B501.Visibility = 1 : B502.Visibility = 1 : B503.Visibility = 1
        B504.Visibility = 1 : B505.Visibility = 1 : B506.Visibility = 1
        AAE = 11 : AAF = 14 : AAG = 13 : AADD()
        ' genau hier
        ApplicationData.Current.LocalSettings.Values("colors") = ""
    End Select : AADE()
  End Sub
  Private Sub AADD()
    Dim title = ApplicationView.GetForCurrentView().TitleBar
    title.BackgroundColor = ACAB(AAE) : title.ButtonInactiveForegroundColor = ACAB(AAF)
    title.ForegroundColor = ACAB(AAF) : title.ButtonInactiveBackgroundColor = ACAB(AAE)
    title.ButtonBackgroundColor = ACAB(AAE) : title.InactiveBackgroundColor = ACAB(AAE)
    title.ButtonForegroundColor = ACAB(AAF) : title.InactiveForegroundColor = ACAB(AAF)
    title.ButtonHoverBackgroundColor = ACAB(AAE) : title.ButtonPressedBackgroundColor = ACAB(AAG)
  End Sub
  Private Sub AADE()
    'Colors
    Select Case ApplicationData.Current.LocalSettings.Values("colors")
      Case "" : AAE = 11 : AAF = 14 : AAG = 14 : Case "1" : AAE = 10 : AAF = 11 : AAG = 11
      Case "2" : AAE = 4 : AAF = 14 : AAG = 11 : Case "3" : AAE = 1 : AAF = 14 : AAG = 12
      Case "4" : AAE = 12 : AAF = 14 : AAG = 12 : Case "5" : AAE = 13 : AAF = 14 : AAG = 2
      Case "6" : AAE = 11 : AAF = 14 : AAG = 11 : End Select

    AA_.Stroke = New SolidColorBrush(ACAB(AAG)) : AԳ_.Stroke = New SolidColorBrush(ACAB(AAG))

    Ξ100.Stroke = New SolidColorBrush(ACAB(AAG))

    A100.Background = New SolidColorBrush(ACAB(AAE)) : CA_.Background = New SolidColorBrush(ACAB(AAE))

    For i = 0 To 9 Step 1 : ACAD(A100.Children.Item(i)).Foreground = New SolidColorBrush(ACAB(AAF))
    Next

    For i = 0 To 63 Step 1 : ACAD(C100.Children.Item(i)).Foreground = New SolidColorBrush(ACAB(AAG))
      ACAD(C100.Children.Item(i)).Background = New SolidColorBrush(Colors.White) : Next

    If AAE = 11 And AAG = 14 Then
      For i = 0 To 63 Step 1 : ACAD(C100.Children.Item(i)).Background = New SolidColorBrush(ACAB(AAE)) : Next
    End If

    If Ξ101.Children.Count > 2 Then : For i = 0 To Ξ101.Children.Count - 3 Step 1
        ACAF(Ξ101.Children(i)).Foreground = New SolidColorBrush(ACAB(AAG)) : Next
    End If

    B511.Background = New SolidColorBrush(ACAB(AAE)) : B511.Foreground = New SolidColorBrush(ACAB(AAF))
    B512.Background = New SolidColorBrush(ACAB(AAE)) : B512.Foreground = New SolidColorBrush(ACAB(AAF))
    B513.Background = New SolidColorBrush(ACAB(AAE)) : B513.Foreground = New SolidColorBrush(ACAB(AAF))
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
      ' genau hier
      ApplicationData.Current.LocalSettings.Values("colors") = "1"
    Else ' light ' dark_
      ApplicationData.Current.LocalSettings.Values("lightness") = ""
    End If : AADC()
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
#Region "A-AE"
  Private Sub AEAA()
    ' CLASSIC TO MATHPRINT 
    For i = 0 To BՆA.Count - 1 Step 1
      Select Case BՑB(i)
        Case "ʃ("
#Region ""
          ' wenn nicht schon einmal geändert wurde
          If i = 0 OrElse BՆA(i) >= BՆA(i - 1) Then AEAB(i) : AEAC() : AEAD()
#End Region
      End Select
    Next
  End Sub
  Private Sub AEAB(a As Integer)
    ' Funktions Terme Positionen
    Ξ_A.AAA.Clear() : Ξ_A.AAA.Add(a) : Ξ_A.AAA.Add(a + 1)
    For i = a + 1 To BՆA.Count - 1 Step 1
      If BՑA(i) = "'" And BՆA(a) = BՆA(i) - 1 Then : Ξ_A.AAA.Add(i) : End If
      If BՆA(a) = BՆA(i) Or i = BՆA.Count - 1 Then Ξ_A.AAA.Add(i) : Exit For
    Next
  End Sub
  Private Sub AEAC()
    ' TERME ÜBERSETZUNG FÜR INTEGRAL
    If Ξ_A.AAA.Count = 5 Then
      ' ʃ(''d) => ''ʃ'd'
      BGA = BGA.Remove(BՆC(Ξ_A.AAA(4)), 1) ' ʃ(''d
      BGA = BGA.Insert(BՆC(Ξ_A.AAA(4)), "'") ' ʃ(''d'
      BGA = BGA.Insert(BՆC(Ξ_A.AAA(2)), "ʃ") ' ʃ('ʃ'd'
      BGA = BGA.Remove(BՆC(Ξ_A.AAA(0)), 2) ' 'ʃ'd'
      BGA = BGA.Insert(BՆC(Ξ_A.AAA(0)), "'") ' ''ʃ'd'
    End If : Ϟ104.Text = BGA
  End Sub
  Private Sub AEAD()
    ' TERME MATHPRINT VIEW
    For i = 0 To BJE - 1 Step 1 : BՆԳ.Add(i)
      Select Case BGA.Substring(i, 1)
        Case "ʃ"
          BՆԸ.Clear() : BՆƐ.Clear()

          ' a + b + ʃ(c ' ʃ(d ' e ' x * dx) ' x * dx) + ʃ...

          ' a + b + 'c'ʃ d'ʃ e'x*dx''x*dx' + ʃ...

          '            e
          '           ʃx*dx
          '          d
          ' a + b + ʃ      x*dx + ʃ...
          '        c

      End Select
    Next


    ' □
    'FA_ = New TextBlock With {.Text = "∫", .FontFamily = New FontFamily("Consolas"),
    '  .Scale = New System.Numerics.Vector3(1.0, 3.0, 1.0),
    '  .Margin = New Thickness(BJA * 10, BJB * 10 - 10, 0, 0)} : B111.Children.Insert(BJA - 1, FA_)
    'BDA.Insert(BJA - 1, BJA * 10) : BDB.Insert(BJA - 1, BJB * 10 - 10) : BJA += 1
    'BJB += 1 : AA_.X1 = BJA * 10 : AA_.X2 = BJA * 10 : AA_.Y1 = BJB * 10 : AA_.Y2 = BJB * 10 + 17
    'If BJA > 2 Then : For i = 0 To BJA - 3 Step 1
    '    ACAF(B111.Children(i)).Margin = New Thickness(BDA(i), BJB * 10, 0, 0) : BDB(i) = BJB * 10
    '  Next : End If
    'If B111.Children.Count > BJA Then : For i = BJA - 1 To B111.Children.Count - 2 Step 1
    '    ACAF(B111.Children(i)).Margin = New Thickness(i * 10 + 10, BJB * 10, 0, 0)
    '    BDA(i) = i * 10 + 10 : BDB(i) = BJB * 10 : Next : End If


    'BGB = BGB.Replace("√)", "") : BGB = BGB.Replace("ln)", "")
    'BGB = BGB.Replace("cos)", "") : BGB = BGB.Replace("sin)", "")
    'BGB = BGB.Replace("tan)", "") : BGB = BGB.Replace("cot)", "")
    'BGB = BGB.Replace("acos)", "") : BGB = BGB.Replace("asin)", "")
    'BGB = BGB.Replace("atan)", "") : BGB = BGB.Replace("acot)", "")
    'BGB = BGB.Replace("lim')", "") : BGB = BGB.Replace("log')", "")
    'BGB = BGB.Replace("Ʃ'')", "") : BGB = BGB.Replace("∏'')", "")
    'BGB = BGB.Replace("√')", "") : BGB = BGB.Replace("ʃ''d())", "")

    'If BJD - BJE = 1 AndAlso BGA.Substring(BJC, 1) = ")" Then
    '  BGD = "√(" : BAAG() : BGD = "cos(" : BAAG() : BGD = "acos(" : BAAG() : BGD = "√('" : BAAG()
    '  BGD = "(`" : BAAG() : BGD = "sin(" : BAAG() : BGD = "asin(" : BAAG() : BGD = "ln(" : BAAG()
    '  BGD = "(´" : BAAG() : BGD = "tan(" : BAAG() : BGD = "atan(" : BAAG() : BGD = "lim('" : BAAG()
    '  BGD = "('" : BAAG() : BGD = "cot(" : BAAG() : BGD = "acot(" : BAAG() : BGD = "log('" : BAAG()
    '  BGD = "Ʃ(''" : BAAG() : BGD = "∏(''" : BAAG() : BGD = "ʃ(''d()" : BAAG() : End If

    'If BJE <> BGB.Length Then
    '  B102.Text = " " & CStr(BJC) & " " & CStr(BJE) & " " & CStr(BJD) ' Exit Sub ' Test
    '  DA_.Document.Selection.Text = DA_.Document.Selection.Text.Remove(BJC - BGD.Length, BGD.Length)
    'End If

  End Sub
#End Region
#End Region
#Region "BBBB"
#Region "B-AA"
  Private Sub BAAA()
    ' Aufruf von Mathematik
    If DA_.Text.Length > 1 Then
      Select Case DA_.Text.Substring(0, 2) : Case A_D.GetString("B001"), A_D.GetString("B002")
          _FD = DA_.Text.Split(":") : CB = _FD(1) : End Select : End If : CA = DB_.Text
    CA = CA.Replace(vbCrLf, vbLf) : CA = CA.Replace(vbCr, vbLf) : CA = CA.Replace(vbLf, "")
    ' Nicht leerer Ausdruck
    If DB_.Text <> "" Then BAAB()
  End Sub
  Private Sub BAAB()
    ' Aufruf von alle'
    AAB = 1 : AAAA() : If CA.Substring(0, 1) = "-" Then CA = CA.Remove(0, 1).Insert(0, "‐")
    CA = CA.Replace("*", "·") : CA = CA.Replace("^", "˄") : CA = CA.Replace("'-", "'‐")
    CA = CA.Replace("`-", "`‐") : CA = CA.Replace("→-", "→‐") : CA = CA.Replace("=-", "=‐")
    CA = CA.Replace("≠-", "≠‐") : CA = CA.Replace("<-", "<‐") : CA = CA.Replace(">-", ">‐")
    CA = CA.Replace("+-", "+‐") : CA = CA.Replace("--", "-‐") : CA = CA.Replace("±-", "±‐")
    CA = CA.Replace("∓-", "∓‐") : CA = CA.Replace("·-", "·‐") : CA = CA.Replace(":-", ":‐")
    CA = CA.Replace("˄-", "˄‐") : CA = CA.Replace("˅-", "˅‐") : CA = CA.Replace("(-", "(‐")
    CA = CA.Replace("ǀ-", "ǀ‐") : CA = CA.Replace("[-", "[‐") : CA = CA.Replace("{-", "{‐")

    MQ_.Add(0) : _M = 0 : KB.Add(A_D.GetString("A303") & "  : a = a") : KA.Add(CA)

    BGA = CA : BAAC() '(aaaa / ddddd)
    ToolTipService.SetToolTip(A105, New ToolTip With {.Content = A_D.GetString("A005")})


    '' Symbolen
    'JA.Clear() : JB.Clear()
    'JC.Clear() : KA.Clear()
    'KB.Clear() : KC.Clear()
    'KD.Clear() : KE.Clear()
    'KF.Clear() : KH.Clear()
    'KI.Clear() : KJ.Clear()
    'KK.Clear() : KL.Clear()
    'MQ_.Clear() : MR_.Clear()
    'KG.Clear() : MQ_.Add(0)
    '_M = 0
    '_AA = NAD.GetString("A152")
    '_AB = NAD.GetString("B003")
    '_AC = NAD.GetString("B004")
    'KB.Add(_AA & "  : a = a")
    '' Symbolen   Reihenfolge !!!
    'CA = CA.Replace("  ", " ")
    'CA = CA.Replace("  ", " ")
    'CA = CA.Replace("  ", " ")
    'CA = CA.Replace("  ", " ")
    'CA = CA.Replace("  ", " ")
    'CA = CA.Replace("*", "·")
    'CA = CA.Replace("/", ":")
    'CA = CA.Replace("^", "˄")
    'CA = CA.Replace("+∞", "▪")
    'CA = CA.Replace("+", " + ")
    'CA = CA.Replace("±", " ± ")
    'CA = CA.Replace("∓", " ∓ ")
    'CA = CA.Replace("·", " · ")
    'CA = CA.Replace(":", " : ")
    'CA = CA.Replace("˄", " ˄ ")
    'CA = CA.Replace("˅", " ˅ ")
    'CA = CA.Replace("˟", " ˟ ")
    'CA = CA.Replace("'", " ' ")
    'CA = CA.Replace("→", " → ")
    'CA = CA.Replace("=", " = ")
    'CA = CA.Replace("≠", " ≠ ")
    'CA = CA.Replace("<", " < ")
    'CA = CA.Replace(">", " > ")
    'CA = CA.Replace("  ", " ")
    'CA = CA.Replace("  ", " ")
    'CA = CA.Replace("  ", " ")
    'CA = CA.Replace("  ", " ")
    'CA = CA.Replace("  ", " ")
    'CA = CA.Replace(" ", " · ")
    'CA = CA.Replace(" · + · ", " + ")
    'CA = CA.Replace(" · ± · ", " ± ")
    'CA = CA.Replace(" · ∓ · ", " ∓ ")
    'CA = CA.Replace(" · - · ", " - ")
    'CA = CA.Replace(" · · · ", " · ")
    'CA = CA.Replace(" · : · ", " : ")
    'CA = CA.Replace(" · ˄ · ", " ˄ ")
    'CA = CA.Replace(" · ˅ · ", " ˅ ")
    'CA = CA.Replace(" · ˟ · ", " ˟ ")
    'CA = CA.Replace(" · = · ", " = ")
    'CA = CA.Replace(" · ≠ · ", " ≠ ")
    'CA = CA.Replace(" · < · ", " < ")
    'CA = CA.Replace(" · > · ", " > ")
    'CA = CA.Replace(" · ' · ", " ' ")
    'CA = CA.Replace(" · → · ", " → ")
    'CA = CA.Replace("▪", "+∞")
    'CA = CA.Replace("( ", "(")
    'CA = CA.Replace(" )", ")")
    'CA = CA.TrimStart(" ")
    'CA = CA.TrimEnd(" ")
    'KA.Add(CA) : DAAC()

  End Sub
  Private Sub BAAC()

    BCBA() : Exit Sub

    Do Until _M = KA.Count
      ' a = b
      Do : BCBA() : BBBB() : Loop Until _I = 0
      ' a b + a c = a (b + c)
      'Do : DBDB() : BBBB() : Loop Until _I = 0
    Loop
  End Sub
#End Region
#Region "B-AB"
  Private Sub BBAA()
    ' Ausdruckseigenschaften 1
    BՑB.Clear() : BՑA.Clear() : BՆA.Clear() : BՆC.Clear() : BՆD.Clear() : BՆԳ.Clear()
    BGA = DB_.Text : BՑA.Add("") : BՆA.Add(0) : BՆC.Add(0) : If BJE = 0 Then Exit Sub

    For i = 0 To BJE - 1 Step 1 : BՆԳ.Add(i)
      Select Case BGA.Substring(i, 1) ' - ‐ Operator und Vorzeichen
        Case "(", "ǀ", "[", "{"
          BJG += 1 : BՆA.Add(BJG) : BՆD.Add(i + 1 - BՆC(BՆC.Count - 1))
          BՑB.Add(BGA.Substring(BՆC(BՆC.Count - 1), BՆD(BՆD.Count - 1)))
          BՑA.Add("") : BՆC.Add(i + 1)
        Case ")", "|", "]", "}"
          BJG -= 1 : BՆA.Add(BJG) : BՆD.Add(i - BՆC(BՆC.Count - 1))
          BՑA.Add("")
          BՑB.Add(BGA.Substring(BՆC(BՆC.Count - 1), BՆD(BՆD.Count - 1)))
          BՆC.Add(i)
        Case "'", "`", "→", "=", "≠", "<", ">", "+", "-", "±", "∓", "·",
             ":", "˄", "˅" ' "-" Operator, "‐" Vorzeichen
          BՆA.Add(BJG) : BՆD.Add(i - BՆC(BՆC.Count - 1))
          BՑB.Add(BGA.Substring(BՆC(BՆC.Count - 1), BՆD(BՆD.Count - 1)))
          BՑA.Add(BGA.Substring(i, 1)) : BՆC.Add(i + 1)
      End Select
    Next
    BՆԳ.Add(BJE)
    If BՆC.Count > BՆD.Count Then : BՆD.Add(BJE - BՆC(BՆC.Count - 1))
      BՑB.Add(BGA.Substring(BՆC(BՆC.Count - 1), BՆD(BՆD.Count - 1)))
    End If
    BJG = 0 ' : AEAA() : DB_.MaxWidth = 500 : DB_.MaxHeight = 100
  End Sub
  Private Sub BBAB()
    ' Ausdruckseigenschaften 2
    If CH = CA And KA.Count > 1 Then Exit Sub Else CH = CA ' Wiederlaufverbot
    BՑB.Clear() : BՑA.Clear() : MA.Clear() : BԳC.Clear() : MC.Clear() : MD.Clear()
    ME_.Clear() : MF_.Clear() : MG_.Clear() : MH_.Clear() : MI_.Clear() : BԳD.Clear()
    BԳE.Clear() : BԳA.Clear() : BԳB.Clear() : LA.Clear() : BՑA.Add("") : BՑB.Add(CA)
    ME_.Add(0) : MA.Add(0) : KG.Add("DAAD") : _A = -1 : _F = 0 : _G = 0 ' 3 ÷ 2 × 3
    '1     Ausdruckteile
    Do
      '1.1     Anweisungen
      _A += 1 : _B = MA(_A) : _C = _B : _D = BՑB(_A).Length : _E = _D : A_ = False : AAD = 0
      C1.Clear() : C2.Clear() : C3.Clear() : C4.Clear() : C5.Clear() : C6.Clear() : C7.Clear()
      '1.2     Funktionen
      If CA.Substring(_B, 1) <> "-" Then
        ' Erstes ein Zeichen
        If _D > 1 Then : Select Case CA.Substring(_B, 1)
            Case "(" : _C += 1 : _E -= 2 : BԳC.Add(1)
            Case "{" : _C += 1 : _E -= 2 : BԳC.Add(1)
            Case "ǀ" : _C += 1 : _E -= 2 : BԳC.Add(2)
            Case "[" : _C += 1 : _E -= 2 : BԳC.Add(2)
          End Select : End If
        ' Erste zwei Zeichen
        If _D > 2 Then : Select Case CA.Substring(_B, 2)
            Case "√(" : _C += 2 : _E -= 3 : BԳC.Add(3)
            Case "d(" : _C += 2 : _E -= 3 : BԳC.Add(4)
            Case "ʃ(" : _C += 2 : _E -= 3 : BԳC.Add(5)
            Case "Ʃ(" : _C += 2 : _E -= 3 : BԳC.Add(6)
            Case "∏(" : _C += 2 : _E -= 3 : BԳC.Add(7)
          End Select : End If
        ' Erste drei Zeichen
        If _D > 3 Then : Select Case CA.Substring(_B, 3)
            Case "ln(" : _C += 3 : _E -= 4 : BԳC.Add(8)
          End Select : End If
        ' Erste vier Zeichen
        If _D > 4 Then : Select Case CA.Substring(_B, 2)
            Case "log(" : _C += 4 : _E -= 5 : BԳC.Add(9)
            Case "lim(" : _C += 4 : _E -= 5 : BԳC.Add(10)
            Case "cos(" : _C += 4 : _E -= 5 : BԳC.Add(11)
            Case "sin(" : _C += 4 : _E -= 5 : BԳC.Add(12)
            Case "tan(" : _C += 4 : _E -= 5 : BԳC.Add(13)
            Case "cot(" : _C += 4 : _E -= 5 : BԳC.Add(14)
          End Select : End If
        ' Erste fünf Zeichen
        If _D > 5 Then : Select Case CA.Substring(_B, 5)
            Case "acos(" : _C += 5 : _E -= 6 : BԳC.Add(15)
            Case "asin(" : _C += 5 : _E -= 6 : BԳC.Add(16)
            Case "atan(" : _C += 5 : _E -= 6 : BԳC.Add(17)
            Case "acot(" : _C += 5 : _E -= 6 : BԳC.Add(18)
          End Select : End If
      Else
        ' Erste zwei Zeichen
        If _D > 2 Then : Select Case CA.Substring(_B, 2)
            Case "-(" : _C += 2 : _E -= 3 : BԳC.Add(1)
            Case "-{" : _C += 2 : _E -= 3 : BԳC.Add(1)
            Case "-ǀ" : _C += 2 : _E -= 3 : BԳC.Add(2)
            Case "-[" : _C += 2 : _E -= 3 : BԳC.Add(2)
          End Select : End If
        ' Erste drei Zeichen
        If _D > 3 Then : Select Case CA.Substring(_B, 3)
            Case "-√(" : _C += 3 : _E -= 4 : BԳC.Add(3)
            Case "-d(" : _C += 3 : _E -= 4 : BԳC.Add(4)
            Case "-ʃ(" : _C += 3 : _E -= 4 : BԳC.Add(5)
            Case "-Ʃ(" : _C += 3 : _E -= 4 : BԳC.Add(6)
            Case "-∏(" : _C += 3 : _E -= 4 : BԳC.Add(7)
          End Select : End If
        ' Erste vier Zeichen
        If _D > 4 Then : Select Case CA.Substring(_B, 4)
            Case "-ln(" : _C += 4 : _E -= 5 : BԳC.Add(8)
          End Select : End If
        ' Erste fünf Zeichen
        If _D > 5 Then : Select Case CA.Substring(_B, 5)
            Case "-log(" : _C += 5 : _E -= 6 : BԳC.Add(9)
            Case "-lim(" : _C += 5 : _E -= 6 : BԳC.Add(10)
            Case "-cos(" : _C += 5 : _E -= 6 : BԳC.Add(11)
            Case "-sin(" : _C += 5 : _E -= 6 : BԳC.Add(12)
            Case "-tan(" : _C += 5 : _E -= 6 : BԳC.Add(13)
            Case "-cot(" : _C += 5 : _E -= 6 : BԳC.Add(14)
          End Select : End If
        ' Erste sechs Zeichen
        If _D > 6 Then : Select Case CA.Substring(_B, 6)
            Case "-acos(" : _C += 6 : _E -= 7 : BԳC.Add(15)
            Case "-asin(" : _C += 6 : _E -= 7 : BԳC.Add(16)
            Case "-atan(" : _C += 6 : _E -= 7 : BԳC.Add(17)
            Case "-acot(" : _C += 6 : _E -= 7 : BԳC.Add(18)
          End Select : End If
      End If

      '1.3     Funktionsgültigkeit
      If _B < _C Then AAD = 1 : A_ = True
      '1.4     Öffnungsklammer
      Select Case CA.Substring(_C, 1)
        Case "(" : AAD += 1 : Case "ǀ" : AAD += 1
        Case "{" : AAD += 1 : Case "[" : AAD += 1
      End Select
      '1.5     Operatoren
      If _E > 1 Then ' wenn bb = true dann _E > 1
        For i = _C To _C + _E - 2 Step 1
          Select Case CA.Substring(i, 1) ' ǀ <> | ǁ
            Case "(" : AAD += 1 : Case ")" : AAD -= 1
            Case "ǀ" : AAD += 1 : Case "|" : AAD -= 1
            Case "[" : AAD += 1 : Case "]" : AAD -= 1
            Case "{" : AAD += 1 : Case "}" : AAD -= 1
          End Select
          If AAD = 0 Then : Select Case CA.Substring(i, 2)
              Case "' " : C1.Add(i) : Case "→ " : C2.Add(i)
              Case "= " : C3.Add(i) : Case "≠ " : C3.Add(i)
              Case "< " : C3.Add(i) : Case "> " : C3.Add(i)
              Case "+ " : C4.Add(i) : Case "- " : C4.Add(i)
              Case "± " : C4.Add(i) : Case "∓ " : C4.Add(i)
              Case "· " : C5.Add(i) : Case ": " : C5.Add(i)
              Case "˄ " : C6.Add(i) : Case "˅ " : C6.Add(i)
              Case "˟ " : C6.Add(i) : End Select
            'Ein-Funktion-Unterschied von Mehr-Funktion: f(1) o f(2)
            If A_ = True Then BԳC.RemoveAt(BԳC.Count - 1) : A_ = False
          End If
        Next
      End If
      '1.6     Operatorengruppenwahl
      If C6.Count > 0 Then AAD = 6 : C7 = C6
      If C5.Count > 0 Then AAD = 5 : C7 = C5
      If C4.Count > 0 Then AAD = 4 : C7 = C4
      If C3.Count > 0 Then AAD = 3 : C7 = C3
      If C2.Count > 0 Then AAD = 2 : C7 = C2
      If C1.Count > 0 Then AAD = 1 : C7 = C1
      '1.7     Funktionslosigkeit
      If A_ = False Then _C = _B : _E = _D : BԳC.Add(0)
      '1.8     Wenn die Operatoren nicht gültig sind
      If C7.Count = 0 Then
        '1.8.1
        If A_ = True Then
          'Term, Operator, Teilungsanfang, Quellenteilindex,
          'Ausgangsteilenanzahl, Ausgangsteilenanfangsindex
          BՑB.Add(CA.Substring(_C, _E)) : BՑA.Add("") : MA.Add(_C)
          ME_.Add(_A) : MH_.Add(1) : MI_.Add(BՑA.Count - 1)
        Else
          MH_.Add(0) : MI_.Add(_A) ' BՑB, BՑA, MA, ME_ schon vorher angegeben
        End If
        'Eingangsanfang, Eingangslänge, Ausgangsanfang, Ausgangslänge, Operatorengruppe
        MC.Add(_B) : MD.Add(_D) : MF_.Add(_C) : MG_.Add(_E) : BԳB.Add(0)
        If BՑB(_A) <> "∞" And BՑB(_A) <> "-∞" And Double.TryParse(BՑB(_A), 0) = True Then
          BԳD.Add(1) : Else BԳD.Add(0) : End If ' Eingangsteil-Zahl
        If BՑB(_A) = CB Or BՑB(_A) = "-" & CB Then BԳE.Add(1) Else BԳE.Add(0) ' Gesuchte Variable
      End If
      '1.9     Wenn die Operatoren gültig sind !!! Reihenfolge
      If C7.Count > 0 Then
        C7.Insert(0, _C) : C7.Add(_C + _E)
        BԳD.Add(0) : BԳE.Add(0) ' : MAK.Add(0) ' betreffen nicht
        '1.8.1     Eigenschaften des Eingangsausdrucksubstrings
        MC.Add(_B) : MD.Add(_D) : MF_.Add(_C) : MG_.Add(_E)
        BԳB.Add(AAD) : MH_.Add(C7.Count - 1) : MI_.Add(BՑA.Count)
        '1.8.2     Ausgangsausdrucksubstringe
        For i = 1 To C7.Count - 1 Step 1
          If i = 1 Then : BՑB.Add(CA.Substring(_C, C7(i) - _C - 1))
            BՑA.Add("") : ME_.Add(_A) : MA.Add(_C)
          End If
          If i > 1 And i < C7.Count - 1 Then
            BՑB.Add(CA.Substring(C7(i - 1) + 2, C7(i) - C7(i - 1) - 3))
            BՑA.Add(CA.Substring(C7(i - 1), 1)) : ME_.Add(_A) : MA.Add(C7(i - 1) + 2)
          End If
          If i = C7.Count - 1 Then
            BՑB.Add(CA.Substring(C7(i - 1) + 2, C7(i) - C7(i - 1) - 2))
            BՑA.Add(CA.Substring(C7(i - 1), 1)) : ME_.Add(_A) : MA.Add(C7(i - 1) + 2)
          End If
          '1 Operator 2 Quellenteilindex 3 Teilungsanfang
        Next
      End If
      '1.10     Gemeinsame Eigenschaften auch wenn: ba = False And bb = False
      If CA.Substring(_B, 1) = "-" Then BԳA.Add(2) Else BԳA.Add(0) ' Vorzeichen vor Eingangsteiles
      LA.Add(False) '17 Gesuchte Variable in Gleichung im Nenner (Hinzufügen False ohne Bedingungen)
    Loop Until _A = BՑB.Count - 1
    '2     Eigenschaftenkorrektur
    For i = 0 To BՑB.Count - 1 Step 1
      'Vorzeichen
      If BԳB(i) = 6 Then
        If BԳA(i) = 0 Then BԳA(i) = 1 Else If BԳA(i) = 2 Then BԳA(i) = 3
        If BԳB(ME_(i)) = 5 And i = MI_(ME_(i)) Then BԳA(ME_(i)) = BԳA(i)
        'wenn Operatorengruppe 6 in Anfangsposition bei Operatorengruppe 5
      End If
      'Gesuchte Variable
      If BԳE(i) = 1 Then : _J = i : _K = 1
        Do : _K += 1 : BԳE(ME_(_J)) += _K : _J = ME_(_J) : Loop Until _J = 0
        If BՑA(i) = ":" Then : _J = i : Do : LA(ME_(_J)) = True : _J = ME_(_J) : Loop Until _J = 0 : End If
        If BՑA(ME_(i)) = ":" And BԳB(ME_(i)) = 6 Then : _J = i : Do : LA(ME_(_J)) = True : _J = ME_(_J)
          Loop Until _J = 0 : End If
      End If
    Next
  End Sub
  Private Sub BBAC()
    'If KC.Count > 0 Then : Static aa, ab() As String : KG.Add("BBAC")
    '  For i = 0 To KC.Count - 1 Step 1 : KA.Insert(_M + i + 1, KC(i)) : ab = KB(_M).Split(":")
    '    aa = ab(0).Remove(ab(0).Length - 1, 1) : aa &= "." & Convert.ToString(i + 1) & " : " & KD(i)
    '    If _M = 0 Then aa = aa.Replace(A_D.GetString("A152") & " .", A_D.GetString("A152") & " ")
    '    KB.Insert(_M + i + 1, aa) : KL.Add(vbLf & vbLf & aa) : KL.AddRange(KK.GetRange(0, MR_(i)))
    '    JC.Add(Colors.Blue) : JC.AddRange(JB.GetRange(0, MR_(i))) : KK.RemoveRange(0, MR_(i))
    '    JB.RemoveRange(0, MR_(i)) : Next : End If : MR_.Clear() : KC.Clear() : KD.Clear()
  End Sub
  Private Sub BBAD()
    'Ergebnissegleichheitsprüfer
    B_ = True : KG.Add("DAAF")
    If KA.Count > 0 Then : For i = 0 To KA.Count - 1 Step 1
        If KA(i) = CA Then : B_ = False : Exit For : End If
      Next : End If
    If KC.Count > 0 Then : For i = 0 To KC.Count - 1 Step 1
        If KC(i) = CA Then : B_ = False : Exit For : End If
      Next : End If
    If B_ = True Then : KE.Add(CA) : KF.Add(CC)
      KG.Add(CA) : Else CA = BՑB(0)
      KG.Add("Das Ergebnis ist dasselbe") : End If
  End Sub
  Private Sub BBBA()
    If _I = 0 Then
      KE.Clear() : KJ.Clear() : JA.Clear()
      KF.Clear() : KE.Add(KA(_M)) : End If

    DB_.MaxHeight = 500 : DB_.MaxWidth = 500 : Ϟ104.Text = CA & vbCrLf & CStr(BՑA.Count) : Exit Sub ' e + 3

    KE(_I) = KE(_I).Replace(_AB, _AC)
    CA = KE(_I)


    BBAB() : KF.Add(CC) : _L = BՑB.Count
  End Sub
  Private Sub BBBB()
    If CA <> KE(_I) Then
      KE.Add(CA) : _I += 1 : KG.Add(CA)
    Else : KG.Add("Kein Ergebnis") : _I = 0
      B_ = False : If KE.Count > 1 Then BBAD()
      If B_ = True Then
        KC.Add(KE(KE.Count - 1))
        KK.AddRange(KJ.GetRange(0, KJ.Count))
        JB.AddRange(JA.GetRange(0, JA.Count))
        MR_.Add(KJ.Count)
        KD.Add(KF(KF.Count - 1)) : End If
      KJ.Clear() : JA.Clear() : BBAC() : _M += 1
    End If
  End Sub
#End Region
#Region "B-AC"
  Private Sub BCBA()
    CC = "a = b" : BBBA()

    Exit Sub

    ' Einziger Term
    _F = -1 : Do : _F += 1 ' extrahierte Reihenfolge
      ' Rechnungen
      Select Case BՑB(_F)
          ' e = 2,72
        Case "e" : BEBA({1001, 1, 1, 1, 3, 3, 3, 0})
          ' π = 3,14
        Case "π" : BEBA({1002, 2, 1, 1, 3, 3, 3, 0})
          ' -e = 2,72
        Case "-e" : BEBA({1003, 3, 1, 1, 3, 3, 3, 0})
          ' -π = 3,14
        Case "-π" : BEBA({1004, 4, 1, 1, 3, 3, 3, 0})
          ' -0 = 0
        Case "-0" : BEBA({1005, 5, 1, 1, 3, 3, 3, 0})
          ' +∞ = ∞
        Case "+∞" : BEBA({1006, 6, 1, 1, 3, 3, 3, 0})
          ' ln(0) = -∞
        Case "ln(0)" : BEBA({1007, 7, 1, 1, 3, 3, 3, 0})
          ' -ln(0) = ∞
        Case "-ln(0)" : BEBA({1008, 6, 1, 1, 3, 3, 3, 0})
          ' ln(e) = 1
        Case "ln(e)" : BEBA({1009, 8, 1, 1, 3, 3, 3, 0})
          ' -ln(e) = -1
        Case "-ln(e)" : BEBA({1010, 9, 1, 1, 3, 3, 3, 0})
          ' log(0) = -∞
        Case "log(0)" : BEBA({1011, 7, 1, 1, 3, 3, 3, 0})
          ' -log(0) = ∞
        Case "-log(0)" : BEBA({1012, 6, 1, 1, 3, 3, 3, 0})
      End Select
      ' Exit Sub
      If CA <> BՑB(0) Then Exit Sub
    Loop While _F < _L - 1
    ' Vorzeichen "-"
    _F = -1 : Do : _F += 1 ' extrahierte Reihenfolge
      _AI = ""
      ' Bedingungen
      If BԳA(_F) > 1 Then : _AI = BՑA(_F) & "`" &
          BFAC(_F) : If BԳB(ME_(_F)) = 5 Then : _AI =
            BFAC(MI_(ME_(_F))) & "`" & _AI : End If
      End If
      ' Rechnungen
      Select Case _AI : Case "" : Exit Select
          ' a + -b = a - b
        Case "+`3" : BEBA({1021, 11, 2, 2, 3, 8, 8, 0})
          ' a - -b = a + b
        Case "-`3" : BEBA({1022, 12, 2, 2, 3, 8, 8, 0})
          ' a ± -b = a ∓ b
        Case "±`3" : BEBA({1023, 13, 2, 2, 3, 8, 8, 0})
          ' a ∓ -b = a ± b
        Case "∓`3" : BEBA({1024, 14, 2, 2, 3, 8, 8, 0})
          ' a + -b' = a - b'
        Case "+`44" : BEBA({1025, 11, 2, 3, 3, 13, 13, 2})
          ' a + -b'. = a - b'.
        Case "+`54" : BEBA({1025, 11, 2, 4, 3, 13, 13, 2})
          ' a - -b' = a + b'
        Case "-`44" : BEBA({1026, 12, 2, 3, 3, 13, 13, 2})
          ' a - -b'. = a + b'.
        Case "-`54" : BEBA({1026, 12, 2, 4, 3, 13, 13, 2})
          ' a ± -b' = a ∓ b'
        Case "±`44" : BEBA({1027, 13, 2, 3, 3, 13, 13, 2})
          ' a ± -b'. = a ∓ b'.
        Case "±`54" : BEBA({1027, 13, 2, 4, 3, 13, 13, 2})
          ' a ∓ -b' = a ± b'
        Case "∓`44" : BEBA({1028, 14, 2, 3, 3, 13, 13, 2})
          ' a ∓ -b'. = a ± b'.
        Case "∓`54" : BEBA({1028, 14, 2, 4, 3, 13, 13, 2})
          ' a · -b = -a · b
        Case "1`·`3" : BEBA({1031, 10, 3, 5, 3, 8, 6, 0})
          ' a : -b = -a : b
        Case "1`:`3" : BEBA({1031, 10, 3, 5, 3, 8, 6, 0})
          ' -a · -b = a · b
        Case "3`·`3" : BEBA({1032, 15, 4, 6, 4, 15, 1, 0})
          ' -a : -b = a : b
        Case "3`:`3" : BEBA({1032, 15, 4, 6, 4, 15, 1, 0})
          ' a' · -b = -a' · b
        Case "42`·`3" : BEBA({1033, 10, 3, 7, 3, 16, 14, 1})
          ' a' : -b = -a' : b
        Case "42`:`3" : BEBA({1033, 10, 3, 7, 3, 16, 14, 1})
          ' -a' · -b = a' · b
        Case "44`·`3" : BEBA({1034, 15, 4, 8, 4, 20, 7, 1})
          ' -a' : -b = a' : b
        Case "44`:`3" : BEBA({1034, 15, 4, 8, 4, 20, 7, 1})
          ' a · -b' = -a · b'
        Case "1`·`44" : BEBA({1035, 10, 3, 9, 3, 13, 9, 2})
          ' a : -b' = -a : b'
        Case "1`:`44" : BEBA({1035, 10, 3, 9, 3, 13, 9, 2})
          ' -a · -b' = a · b'
        Case "3`·`44" : BEBA({1036, 15, 4, 10, 4, 18, 5, 2})
          ' -a : -b' = a : b'
        Case "3`:`44" : BEBA({1036, 15, 4, 10, 4, 18, 5, 2})
          ' a' · -b' = -a' · b'
        Case "42`·`44" : BEBA({1037, 10, 3, 11, 3, 19, 17, 3})
          ' a' : -b' = -a' : b'
        Case "42`:`44" : BEBA({1037, 10, 3, 11, 3, 19, 17, 3})
            ' -a' · -b' = a' · b'
        Case "44`·`44" : BEBA({1038, 15, 4, 12, 4, 21, 12, 3})
          ' -a' : -b' = a' : b'
        Case "44`:`44" : BEBA({1038, 15, 4, 12, 4, 21, 12, 3})
      End Select
      ' Exit Sub
      If CA <> BՑB(0) Then Exit Sub
    Loop While _F < _L - 1
    ' Unbestimmte ☼
    _G = -1 : Do : _G += 1 ' extrahierte Reihenfolge
      ' Bedingungen
      If _G = MI_(ME_(_G)) Then _AI = "" ' ☼ □ ○ ◌ ∞
      Select Case BՑB(_G) : Case "0", "1", "-1", "∞", "-∞"
          If _AI = "" Then : _AI = "☼" : _F = _G : Else
            _AI = BՑA(_F) & "`" & BՑB(_F) & "`" &
              BՑA(_G) & "`" & BՑB(_G) : End If : End Select
      ' Rechnungen
      Select Case _AI : Case "", "☼" : Exit Select
          ' 0 ^ 0 = ☼
        Case "`0`˄`0" : BEBA({1041, 15, 5, 13, 6, 3, 3, 0})
          ' 0 : 0 = ☼
        Case "`0`:`0" : BEBA({1042, 15, 5, 13, 6, 3, 3, 0})
          ' ☼ · 0 : 0 = ☼
        Case "·`0`:`0" : BEBA({1043, 15, 6, 14, 6, 4, 4, 0})
          ' ☼ : 0 · 0 = ☼
        Case ":`0`·`0" : BEBA({1044, 18, 7, 15, 6, 4, 4, 0})
          ' 0 · ∞ = ☼
        Case "`0`·`∞" : BEBA({1045, 15, 5, 13, 6, 3, 3, 0})
          ' ☼ · 0 · ∞ = ☼
        Case "·`0`·`∞" : BEBA({1046, 15, 6, 14, 6, 4, 4, 0})
          ' 1 ^ ∞ = ☼
        Case "`1`˄`∞" : BEBA({1047, 15, 5, 13, 6, 3, 3, 0})
          ' 1 ^ -∞ = ☼
        Case "`1`˄`-∞" : BEBA({1048, 19, 5, 13, 6, 3, 3, 0})
          ' ∞ · 0 = ☼
        Case "`∞`·`0" : BEBA({1049, 15, 5, 13, 6, 3, 3, 0})
          ' -∞ · 0 = ☼
        Case "`-∞`·`0" : BEBA({1050, 15, 5, 13, 6, 3, 3, 4})
          ' a · ∞ · 0 = ☼
        Case "·`∞`·`0" : BEBA({1051, 15, 6, 14, 6, 4, 4, 0})
          ' ∞ ^ 0 = ☼
        Case "`∞`˄`0" : BEBA({1052, 15, 5, 13, 6, 3, 3, 0})
          ' -∞ ^ 0 = ☼
        Case "`-∞`˄`0" : BEBA({1053, 15, 5, 13, 6, 3, 3, 0})
          ' ∞ - ∞ = ☼
        Case "`∞`-`∞" : BEBA({1054, 15, 5, 13, 6, 3, 3, 0})
          ' -∞ + ∞ = ☼
        Case "`-∞`+`∞" : BEBA({1055, 15, 5, 13, 6, 3, 3, 0})
          ' a + ∞ - ∞ = ☼
        Case "+`∞`-`∞" : BEBA({1056, 15, 6, 14, 6, 4, 4, 0})
          ' a - ∞ + ∞ = ☼
        Case "-`∞`+`∞" : BEBA({1057, 17, 7, 15, 6, 4, 4, 0})
          ' ∞ : ∞ = ☼
        Case "`∞`:`∞" : BEBA({1058, 15, 5, 13, 6, 3, 3, 0})
          ' -∞ : ∞ = -☼
        Case "`-∞`:`∞" : BEBA({1059, 16, 5, 13, 6, 3, 3, 0})
          ' a · ∞ : ∞ = ☼
        Case "·`∞`:`∞" : BEBA({1060, 15, 6, 14, 6, 4, 4, 0})
          ' a : ∞ · ∞ = ☼
        Case ":`∞`·`∞" : BEBA({1061, 18, 7, 15, 6, 4, 4, 0})
      End Select
      ' Exit Sub
      If CA <> BՑB(0) Then Exit Sub
    Loop While _G < _L - 1
    ' Funktionelle'
    _F = -1 : Do : _F += 1 ' extrahierte Reihenfolge
      _AI = "" : H1(3) = MI_(_F) : _AF = "" 'ǀǁ
      ' Bedingungen
      If BԳD(_F) = 0 Then
        _AF = BՑB(_F).Remove(MD(_F) - 1, 1)
        ' a* = b
        If Double.TryParse(_AF, 0) = True Then
          If BՑB(_F)(MD(_F) - 1) = "´" Then
            _AI = "f-´´" : End If
        End If
        ' a! = b
        If Integer.TryParse(_AF, 0) = True Then
          If BՑB(_F)(MD(_F) - 1) = "!" Then
            _AI = "f-!´"
            H1(6) = CInt(_AF) : _BA = CDbl(_AF)
            If H1(6) < 0 Then H1(6) *= -1
            _AF = "" : If _BA = 0 Then _AF = "1"
            If _BA < 0 Then _AF = "-" : _BA *= -1
            For j = H1(6) - 1 To 1 Step -1
              _BA *= j : Next
            If _AF <> "1" Then _AF &= BFAA(_BA)
          End If
        End If
        ' f(z) = z
        If BԳC(_F) > 1 And BԳD(H1(3)) = 1 Then
          _AI = "1`" : _BA = CDbl(BՑB(H1(3)))
          H1(6) = If(BԳA(_F) > 1, -1, 1) : _BC =
            Math.PI / 180
          _BB = _BA * _BC : _BC = H1(6) / _BC
          ' f(a ' b) = c
        ElseIf BԳB(H1(3)) = 1 Then : _AI = "1"
          H1(6) = MI_(H1(3))
          If BԳD(H1(6)) = 1 Then : _AI &= "1"
            _BA = CDbl(BՑB(H1(6))) : End If
          If BԳD(H1(6) + 1) = 1 Then : _AI &= "2"
            _BB = CDbl(BՑB(H1(6) + 1)) : End If
        End If
        ' S e l e c t
        _AI &= CStr(BԳC(_F)) : Select Case _AI
            ' (a)
          Case "1" : If BԳB(H1(3)) = 0 Then
              _AI &= "```"
              If BԳA(_F) > 1 Then _AI &= BFAC(H1(3))
              ' (a o b) = a o b
            ElseIf BԳB(H1(3)) > 3 Then ' Operator umkehren
              If BԳB(ME_(_F)) > BԳB(H1(3)) Then Continue Do
              Select Case BՑA(_F)
                Case "-", ":", "˅" : _AI = "ou" : End Select
              If _AI = "ou" Then ' `o`u`
                If BԳB(ME_(_F)) = BԳB(H1(3)) Then _AI = "o"
                If BԳB(H1(3)) < 6 Then _AI &= "ou" ' oou
                ' Operator innen von Vorzeichen umkehren
              ElseIf BԳA(_F) = 2 Then : _AI = "v"
                If BԳB(H1(3)) = 4 Then _AI &= "ou" ' vou
              End If
              If _AI <> "oou" And _AI <> "vou" Then
                _AI = "`n`u`" ' ↓ (a ^ b) ^ c ≠ a ^ (b ^ c)
                If BԳB(ME_(_F)) = 6 Then _AI &= BՑA(_F)
                ' -(a * b) = -a * b
                If BԳA(_F) > 1 Then ' And BԳB(H1(3)) > 4
                  _AI &= BFAC(H1(3)) : End If ' -(a)
              ElseIf _AI = "oou" Then : _AI &= BՑA(_F)
              ElseIf _AI = "vou" Then
                _AI &= BFAC(MI_(H1(3)))
              End If ' nicht umkehren bzw nicht ausklammern
            End If
          ' |v| = b
          Case "2" : If BԳA(H1(3)) > 1 Then _AI &= "`-"
          ' |z| = b
          Case "1`2"
            _AI &= If(BԳA(_F) > 1, "`-", "`+")
            ' |-z| = b
            If _BA < 0 Then _AI &= "`-"
            ' √(a) = b
          Case "1`3" : _AF = BFAA(H1(6) * Math.Sqrt(_BA))
            ' If XAB < 0 Then 0 + XAB = Math.Sqrt(XAB)*i
            ' √(a ' b) = c
          Case "1123" : _BA = Math.Pow(_BA, 1 / _BB)
            If _BA >= 0 And CStr(_BA) <> "NaN" Then
              _AF = BFAA(_BA) : _AI &= "*"
              If BԳA(_F) > 1 Then _AF = "-" & _AF
              If _AF = "-0" Then : _AF = "0" : End If
            End If
            '√(a ' 2) = √(a)
          Case "123"
            If BՑB(H1(6) + 1) = "2" Then _AI &= "*"
            ' ln(a) = b
          Case "1`8" : _AF = BFAA(H1(6) * Math.Log(_BA))
            ' If XAB<0 Then 0+XAB=Math.Log(Math.E^Math.PI)*i
            ' log(a) = b
          Case "1`9" : _AF = BFAA(H1(6) * Math.Log10(_BA))
            ' If XAB<0 Then XAB=0+Math.Log(Math.E^Math.PI)*i
            ' log(a ' b) = c
          Case "1129"
            _BA = Math.Log(_BB) / Math.Log(_BA)
            If _BA >= 0 And CStr(_BA) <> "NaN" Then
              _AF = BFAA(_BA) : _AI &= "*"
              If BԳA(_F) > 1 Then _AF = "-" & _AF
              If _AF = "-0" Then : _AF = "0" : End If
            End If
            ' tan*(a) = b
          Case "1`11" : _AF = BFAA(H1(6) * Math.Cos(_BB))
          Case "1`12" : _AF = BFAA(H1(6) * Math.Sin(_BB))
          Case "1`13" : _AF = BFAA(H1(6) * Math.Tan(_BB))
          Case "1`14" : _AF = BFAA(H1(6) / Math.Tan(_BB))
          Case "1`15" : _AF = BFAA(_BC * Math.Acos(_BA))
          Case "1`16" : _AF = BFAA(_BC * Math.Asin(_BA))
          Case "1`17" : _AF = BFAA(_BC * Math.Atan(_BA))
          Case "1`18" : _AF = BFAA(_BC * Math.Atan(1 / _BA))
        End Select
      End If
      ' Rechnungen
      Select Case _AI : Case "" : Exit Select
          ' a! = b
        Case "f-!´0" : BEBA({1071, 0, 1, 1, 3, 3, 3, 5})
          ' a´ = 0
        Case "f-´´0" : BEBA({1072, 5, 1, 1, 3, 2, 3, 9})
          ' √(a) = b
        Case "1`3" : BEBA({1081, 0, 1, 1, 3, 11, 2, 8})
          ' ln(a) = b
        Case "1`8" : BEBA({1082, 0, 1, 1, 3, 11, 2, 8})
          ' log(a) = b
        Case "1`9" : BEBA({1083, 0, 1, 1, 3, 11, 2, 8})
          ' cos(a) = b
        Case "1`11" : BEBA({1091, 0, 1, 1, 3, 11, 2, 8})
          ' sin(a) = b
        Case "1`12" : BEBA({1092, 0, 1, 1, 3, 11, 2, 8})
          ' tan(a) = b
        Case "1`13" : BEBA({1093, 0, 1, 1, 3, 11, 2, 8})
          ' cot(a) = b
        Case "1`14" : BEBA({1094, 0, 1, 1, 3, 11, 2, 8})
          ' acos(a) = b
        Case "1`15" : BEBA({1095, 0, 1, 1, 3, 11, 2, 8})
          ' asin(a) = b
        Case "1`16" : BEBA({1096, 0, 1, 1, 3, 11, 2, 8})
          ' atan(a) = b
        Case "1`17" : BEBA({1097, 0, 1, 1, 3, 11, 2, 8})
          ' acot(a) = b
        Case "1`18" : BEBA({1098, 0, 1, 1, 3, 11, 2, 8})
          ' √(a ' 2) = √(a)
        Case "123*" : BEBA({1101, 0, 22, 50, 2, 8, 1, 0})
          ' √(a ' b) = c
        Case "1123*" : BEBA({1102, 0, 1, 1, 3, 3, 3, 11})
          ' log(a ' b) = c
        Case "1129*" : BEBA({1103, 0, 1, 1, 3, 3, 3, 11})
          ' (a) = a
        Case "1```" : BEBA({1111, 0, 16, 30, 4, 10, 1, 0})
          ' (a o b) = a o b
        Case "`n`u`" : BEBA({1111, 0, 16, 30, 4, 10, 1, 0})
          ' -(a) = -a
        Case "1```1" : BEBA({1112, 0, 17, 31, 4, 10, 6, 0})
          ' -(a o b) = -a o b
        Case "`n`u`1" : BEBA({1112, 0, 17, 31, 4, 10, 6, 0})
          ' -(-a) = a
        Case "1```3" : BEBA({1113, 0, 18, 32, 4, 10, 1, 0})
          ' -(-a o b) = a o b
        Case "`n`u`3" : BEBA({1113, 0, 18, 32, 4, 10, 1, 0})
          ' -(a') = -a'
        Case "`n`u`42" : BEBA({1114, 0, 17, 33, 4, 22, 9, 1})
          ' -(a'.) = -a'.
        Case "`n`u`52" : BEBA({1114, 0, 17, 34, 4, 22, 9, 1})
          ' -(-a') = a'
        Case "`n`u`44" : BEBA({1115, 0, 18, 35, 4, 22, 5, 1})
          ' -(-a'.) = a'.
        Case "`n`u`54" : BEBA({1115, 0, 18, 36, 4, 22, 5, 1})
          ' -(a'.) = -(a').
        Case "`n`u`12" : BEBA({1116, 0, 19, 37, 3, 4, 8, 0})
          ' -(-a'.) = -(-a').
        Case "`n`u`14" : BEBA({1116, 0, 19, 37, 3, 4, 8, 0})
          ' -(a'.) = -(a').
        Case "`n`u`32" : BEBA({1116, 0, 19, 37, 3, 4, 8, 0})
          ' -(-a'.) = -(-a').
        Case "`n`u`34" : BEBA({1116, 0, 19, 37, 3, 4, 8, 0})
          ' a - (b +- c) = a - b -+ c
        Case "oou-" : BEBA({1121, 0, 16, 38, 100, 23, 8, 0})
          ' a : (b ·: c) = a : b :· c
        Case "oou:" : BEBA({1122, 0, 16, 38, 100, 23, 8, 0})
          ' -(a +- b) = -a -+ b
        Case "vou1" : BEBA({1123, 0, 17, 39, 100, 24, 15, 0})
          ' -(-a +- b) = a -+ b
        Case "vou3" : BEBA({1124, 0, 18, 40, 100, 24, 8, 0})
          ' -(a ^ b +- c) = -(a ^ b) -+ c
        Case "vou2" : BEBA({1125, 0, 19, 41, 100, 25, 8, 0})
          ' -(-a ^ b +- c) = -(-a ^ b) -+ c
        Case "vou4" : BEBA({1125, 0, 19, 41, 100, 25, 8, 0})
          ' -(a ^ 2 +- b) = -(a ^ 2) -+ b
        Case "vou22" : BEBA({1125, 0, 19, 41, 100, 25, 8, 0})
          ' -(-a ^ 2 +- b) = -(-a ^ 2) -+ b
        Case "vou24" : BEBA({1125, 0, 19, 41, 100, 25, 8, 0})
          ' -(a ^ b · c +- d) = -(a ^ b) · c -+ d
        Case "vou12" : BEBA({1126, 0, 20, 42, 100, 25, 26, 0})
          ' -(-a ^ b · c +- d) = -(-a ^ b) · c -+ d
        Case "vou14" : BEBA({1126, 0, 20, 42, 100, 25, 26, 0})
          ' -(a ^ 2 · b +- c) = -(a ^ 2) · b -+ c
        Case "vou32" : BEBA({1126, 0, 20, 42, 100, 25, 26, 0})
          ' -(-a ^ 2 · b +- c) = -(-a ^ 2) · b -+ c
        Case "vou34" : BEBA({1126, 0, 20, 42, 100, 25, 26, 0})
          ' -(a ^ 3 +- b) = -a ^ 3 -+ b
        Case "vou42" : BEBA({1127, 0, 17, 43, 100, 28, 27, 1})
          ' -(a ^ 3 · b +- c) = -a ^ 3 · b -+ c
        Case "vou52" : BEBA({1127, 0, 17, 44, 100, 28, 27, 1})
          ' -(-a ^ 3 +- b) = a ^ 3 -+ b
        Case "vou44" : BEBA({1128, 0, 18, 45, 100, 28, 29, 1})
          ' -(-a ^ 3 · b +- c) = a ^ 3 · b -+ c
        Case "vou54" : BEBA({1128, 0, 18, 46, 100, 28, 29, 1})
          ' ǀz| = z
        Case "1`2`+" : BEBA({1131, 0, 16, 30, 4, 10, 1, 10})
          ' -ǀz| = -z
        Case "1`2`-" : BEBA({1132, 0, 17, 31, 4, 10, 6, 10})
          ' ǀ-z| = -z, z < 0
        Case "1`2`+`-" : BEBA({1133, 0, 21, 48, 4, 10, 1, 10})
          ' -ǀ-z| = -z, z < 0
        Case "1`2`-`-" : BEBA({1134, 0, 21, 49, 4, 10, 6, 10})
          ' ǀ-v| = ǀv|
        Case "2`-" : BEBA({1135, 0, 17, 47, 2, 8, 1, 0})
      End Select
      ' Exit Sub
      If CA <> BՑB(0) Then Exit Sub
    Loop While _F < _L - 1
    ' Null und Eins
    _F = _L : Do : _F -= 1 ' extrahierte Reihenfolge
      _AI = ""
      ' Bedingungen
      If BԳD(_F) = 1 Then : _AF = BՑB(_F) ' Zahlen
        _AI = BՑA(_F) & "`" & _AF : H1(4) = ME_(_F)
        H1(5) = MH_(H1(4))
        If _AF = "0" And BԳB(H1(4)) = 5 Then : BDBA()
        Else : _AI &= "`"
          If BՑA(_F) = "" And H1(5) > 1 Then
            _G = _F + 1 : _AI &= BՑA(_G) : End If
        End If
        ' 0 - a = -a
        If _AI = "`0`-" Then _AI &= "`" & BFAC(_G)
        ' -1 · a = -a
        If _AI = "`-1`·" Then _AI &= "`" & BFAC(_G)
        ' a ·: -1 = -a
        If _AI = "·`-1`" Or _AI = ":`-1`" Then
          _AI = BFAC(MI_(H1(4))) & "`" & _AI : End If
      End If
      ' Rechnungen
      Select Case _AI : Case "" : Exit Select
          ' a + 0 = a
        Case "+`0`" : BEBA({1141, 0, 8, 16, 2, 4, 1, 0})
          ' a - 0 = a
        Case "-`0`" : BEBA({1141, 0, 8, 16, 2, 4, 1, 0})
          ' a ± 0 = a
        Case "±`0`" : BEBA({1141, 0, 8, 16, 2, 4, 1, 0})
          ' a ∓ 0 = a
        Case "∓`0`" : BEBA({1142, 0, 8, 16, 2, 4, 1, 0})
          ' a · 0 = 0
        Case "`·`0" : BEBA({1143, 5, 9, 17, 6, 6, 1, 7})
          ' ☼ · a · 0 = ☼ · 0
        Case "·`·`0" : BEBA({1144, 5, 9, 18, 6, 8, 1, 7})
          ' a : 0 = ∞
        Case "`:`0" : BEBA({1145, 6, 10, 19, 6, 3, 3, 6})
          ' ☼ · a : 0 = ☼ · ∞
        Case "·`:`0" : BEBA({1146, 6, 9, 20, 6, 4, 4, 6})
          ' a ˄ 0 = 1
        Case "˄`0`" : BEBA({1147, 8, 10, 19, 6, 3, 3, 0})
          ' a · 1 = a
        Case "·`1`" : BEBA({1148, 0, 8, 16, 2, 4, 1, 0})
          ' a : 1 = a
        Case ":`1`" : BEBA({1148, 0, 8, 16, 2, 4, 1, 0})
          ' a ˄ 1 = a
        Case "˄`1`" : BEBA({1149, 0, 8, 16, 2, 4, 1, 0})
          ' 0 + a = a
        Case "`0`+" : BEBA({1150, 20, 5, 21, 6, 6, 1, 0})
          ' 0 · a = 0
        Case "`0`·" : BEBA({1151, 0, 11, 22, 2, 4, 1, 0})
          ' 0 : a = 0
        Case "`0`:" : BEBA({1151, 0, 11, 22, 2, 4, 1, 0})
          ' 1 · a = a
        Case "`1`·" : BEBA({1152, 20, 0, 5, 21, 6, 6, 1, 0})
          ' ☼ · 0 · a = ☼ · 0
        Case "·`0`·" : BEBA({1153, 0, 11, 23, 2, 4, 1, 7})
          ' ☼ · 0 : a = ☼ · 0
        Case "·`0`:" : BEBA({1153, 0, 11, 23, 2, 4, 1, 7})
          '' ☼ : a · 0 = ☼ · 0
          'Case ":`·`0" : BEBA({1114, 5, 9, 6, 8, 1, 7})
          ' 0 - a = -a
        Case "`0`-`1" : BEBA({1161, 10, 12, 24, 3, 6, 6, 0})
          ' 0 - a' = -(a')
        Case "`0`-`2" : BEBA({1162, 22, 13, 25, 5, 6, 10, 0})
          ' 0 - a'. = -(a').
        Case "`0`-`12" : BEBA({1162, 22, 14, 26, 5, 6, 10, 0})
          ' 0 - -a' = -(-a')
        Case "`0`-`4" : BEBA({1163, 22, 13, 25, 5, 6, 10, 0})
          ' 0 - -a'. = -(-a').
        Case "`0`-`14" : BEBA({1163, 22, 14, 26, 5, 6, 10, 0})
          ' 0 - a' = -(a')
        Case "`0`-`22" : BEBA({1163, 22, 13, 25, 5, 6, 10, 0})
          ' 0 - a'. = -(a').
        Case "`0`-`32" : BEBA({1163, 22, 14, 26, 5, 6, 10, 0})
          ' 0 - a' = -a'
        Case "`0`-`42" : BEBA({1164, 10, 12, 27, 3, 9, 9, 1})
          ' 0 - a'. = -a'.
        Case "`0`-`52" : BEBA({1164, 10, 12, 28, 3, 9, 9, 1})
          ' a' · -1 = -(a')
        Case "2`·`-1`" : BEBA({1165, 22, 15, 29, 5, 4, 10, 0})
          ' a' : -1 = -(a')
        Case "2`:`-1`" : BEBA({1165, 22, 15, 29, 5, 4, 10, 0})
          ' -a' · -1 = -(-a')
        Case "4`·`-1`" : BEBA({1165, 22, 15, 29, 5, 4, 10, 0})
          ' -a' : -1 = -(-a')
        Case "4`:`-1`" : BEBA({1165, 22, 15, 29, 5, 4, 10, 0})
          ' -1 · a = -a
        Case "`-1`·`1" : BEBA({1166, 10, 12, 24, 3, 6, 6, 0})
          ' -1 · a' = -(a')
        Case "`-1`·`2" : BEBA({1167, 22, 13, 25, 5, 6, 10, 0})
          ' -1 · a'. = -(a').
        Case "`-1`·`12" : BEBA({1167, 22, 14, 26, 5, 6, 10, 0})
          ' -1 · a' = -(a')
        Case "`-1`·`22" : BEBA({1167, 22, 13, 25, 5, 6, 10, 0})
          ' -1 · a'. = -(a').
        Case "`-1`·`32" : BEBA({1167, 22, 14, 26, 5, 6, 10, 0})
          ' -1 · -a' = -(-a')
        Case "`-1`·`4" : BEBA({1167, 22, 13, 25, 5, 6, 10, 0})
          ' -1 · -a'. = -(-a').
        Case "`-1`·`14" : BEBA({1168, 22, 14, 26, 5, 6, 10, 0})
          ' -1 · a' = -a' ! -a'.
        Case "`-1`·`42" : BEBA({1169, 10, 12, 27, 3, 9, 9, 1})
      End Select
      ' Exit Sub
      If CA <> BՑB(0) Then Exit Sub
    Loop While _F < _L - 1
    ' Zahlenrechnen
    _G = -1 : Do : _G += 1 ' extrahierte Reihenfolge
      If _G = MI_(ME_(_G)) Then _AI = ""
      ' Bedingungen
      If _AI = "" Then : _F = ME_(_G)
        ' Reihenfolge !!!
        If BԳB(_F) < 4 Then Continue Do
        If BԳD(_G) = 0 Then Continue Do
        _F = _G : _BA = CDbl(BՑB(_F))
        _AI = "*" : Continue Do : Else
        If BԳD(_G) = 0 Then Continue Do
        _AI = BՑA(_F) & "`" & BՑA(_G)
        _BB = CDbl(BՑB(_G)) : End If
      ' Rechnungen
      Select Case _AI
          ' a + b = c
        Case "`+" : _AF = BFAA(_BA + _BB)
          BEBA({1171, 0, 6, 13, 6, 3, 3, 11})
          ' a - b = c
        Case "`-" : _AF = BFAA(_BA - _BB)
          BEBA({1171, 0, 6, 13, 6, 3, 3, 11})
          ' a + b + c = a + (b + c) = a + d
        Case "+`+" : _AF = BFAA(_BA + _BB)
          BEBA({1172, 0, 6, 14, 6, 4, 4, 11})
          ' a + b - c = a + (b - c) = a + d
        Case "+`-" : _AF = BFAA(_BA - _BB)
          BEBA({1172, 0, 6, 14, 6, 4, 4, 11})
          ' a - b + c = a - (b - c) = a - d
        Case "-`+" : _AF = BFAA(_BA - _BB)
          BEBA({1173, 0, 6, 14, 6, 4, 4, 11})
          ' a - b - c = a - (b + c) = a - d
        Case "-`-" : _AF = BFAA(_BA + _BB)
          BEBA({1173, 0, 6, 14, 6, 4, 4, 11})
          ' a · b = c
        Case "`·" : _AF = BFAA(_BA * _BB)
          BEBA({1174, 0, 6, 13, 6, 3, 3, 11})
          ' a : b = c
        Case "`:" : _AF = BFAA(_BA / _BB)
          BEBA({1174, 0, 6, 13, 6, 3, 3, 11})
          ' a · b · c = a · (b · c) = a · d
        Case "·`·" : _AF = BFAA(_BA * _BB)
          BEBA({1175, 0, 6, 14, 6, 4, 4, 11})
          ' a · b : c = a · (b : c) = a · d
        Case "·`:" : _AF = BFAA(_BA / _BB)
          BEBA({1175, 0, 6, 14, 6, 4, 4, 11})
          ' a : b · c = a : (b : c) = a : d
        Case ":`·" : _AF = BFAA(_BA / _BB)
          BEBA({1176, 0, 6, 14, 6, 4, 4, 11})
          ' a : b : c = a : (b · c) = a : d
        Case ":`:" : _AF = BFAA(_BA * _BB)
          BEBA({1176, 0, 6, 14, 6, 4, 4, 11})
          ' a ˄ b = c
        Case "`˄"
          _AF = BFAA(Math.Pow(_BA, _BB))
          BEBA({1177, 0, 6, 13, 6, 3, 3, 11})
          ' a ˅ b = c
        Case "`˅"
          _AF = BFAA(Math.Pow(_BA, 1 / _BB))
          BEBA({1177, 0, 6, 13, 6, 3, 3, 11})
      End Select
      ' Exit Sub
      If CA <> BՑB(0) Then Exit Sub
    Loop While _G < _L - 1

    Exit Sub

    ' Zwei Gleiche
    _F = -1 : Do : _F += 1 ' extrahierte Reihenfolge
      ' Bedingungen
      If BFAD(_F) <> "☼" Then : _AI = ""
        _G = ME_(_F) : H1(4) = MI_(_G) + MH_(_G) - 1
        If _F = H1(4) Or BԳB(_G) < 4 Then Continue Do
        If BԳB(_G) = 6 Then : _AI = BFAC(_G)
        Else : For j = _F + 1 To H1(4) Step 1
            If BՑB(_F) = BՑB(j) Then : _G = j
              _AI = BՑA(_F) & "`" & BՑA(j) : Exit For
            ElseIf BFAD(_F) = BFAD(j) Then : _AI =
                BՑA(_F) & BFAC(_F) & BՑA(j) & BFAC(j)
              _G = j : Exit For : End If : Next : End If
      Else : Continue Do : End If
      ' Rechnungen
      Select Case _AI : Case "" : Exit Select
          ' a - a = 0
        Case "`-" : BEBA({1141, 0, 8, 16, 2, 4, 1, 0})
          ' a - b + b = a + 0
        Case "-`+" : BEBA({1141, 0, 8, 16, 2, 4, 1, 0})
          ' a + b - b = a + 0
        Case "+`-" : BEBA({1141, 0, 8, 16, 2, 4, 1, 0})
          ' a : a = 1
        Case "`:" : BEBA({1141, 0, 8, 16, 2, 4, 1, 0})
          ' a · b : b = a · 1
        Case "·`:" : BEBA({1141, 0, 8, 16, 2, 4, 1, 0})
          ' a : b · b = a · 1
        Case ":`·" : BEBA({1141, 0, 8, 16, 2, 4, 1, 0})

          ' -a + a = 0
        Case "3-1" : BEBA({1141, 0, 8, 16, 2, 4, 1, 0})
          ' -a' + a' = 0
        Case "44-42" : BEBA({1141, 0, 8, 16, 2, 4, 1, 0})
          ' -a'. + a'. = 0
        Case "54-52" : BEBA({1141, 0, 8, 16, 2, 4, 1, 0})

          ' a : -a = -1
        Case "1:3" : BEBA({1141, 0, 8, 16, 2, 4, 1, 0})
          ' -a : a = -1
        Case "3:1" : BEBA({1141, 0, 8, 16, 2, 4, 1, 0})

          ' a · b : -b = a · -1
        Case "·1:3" : BEBA({1141, 0, 8, 16, 2, 4, 1, 0})
          ' a · -b : b = a · -1
        Case "·3:1" : BEBA({1141, 0, 8, 16, 2, 4, 1, 0})
          ' a : b · -b = a · -1
        Case ":1·3" : BEBA({1141, 0, 8, 16, 2, 4, 1, 0})
          ' a : -b · b = a · -1
        Case ":3·1" : BEBA({1141, 0, 8, 16, 2, 4, 1, 0})

          ' a' : -a' = -1
        Case "42:44" : BEBA({1141, 0, 8, 16, 2, 4, 1, 0})
          ' -a' : a' = -1
        Case "44:42" : BEBA({1141, 0, 8, 16, 2, 4, 1, 0})
          ' a · b' : -b' = a · -1
        Case "·42:44" : BEBA({1141, 0, 8, 16, 2, 4, 1, 0})
          ' a · -b' : b' = a · -1
        Case "·44:42" : BEBA({1141, 0, 8, 16, 2, 4, 1, 0})
          ' a : b' · -b' = a · -1
        Case ":42·44" : BEBA({1141, 0, 8, 16, 2, 4, 1, 0})
          ' a : -b' · b' = a · -1
        Case ":44·42" : BEBA({1141, 0, 8, 16, 2, 4, 1, 0})

          ' a'. : -a'. = -1
        Case "52:54" : BEBA({1141, 0, 8, 16, 2, 4, 1, 0})
          ' -a'. : a'. = -1
        Case "54:52" : BEBA({1141, 0, 8, 16, 2, 4, 1, 0})
          ' a · b'. : -b'. = a · -1
        Case "·52:54" : BEBA({1141, 0, 8, 16, 2, 4, 1, 0})
          ' a · -b'. : b'. = a · -1
        Case "·54:52" : BEBA({1141, 0, 8, 16, 2, 4, 1, 0})
          ' a : b'. · -b'. = a · -1
        Case ":52·54" : BEBA({1141, 0, 8, 16, 2, 4, 1, 0})
          ' a : -b'. · b'. = a · -1
        Case ":54·52" : BEBA({1141, 0, 8, 16, 2, 4, 1, 0})
          ' -a ˄ G = a ˄ G
        Case "24" : BEBA({1141, 0, 8, 16, 2, 4, 1, 0})
          ' -a ˄ G. = a ˄ G.
        Case "34" : BEBA({1141, 0, 8, 16, 2, 4, 1, 0})

      End Select
      ' Exit Sub
      If CA <> BՑB(0) Then Exit Sub


      'If BFAC(_F) = 10 Then ' negativ mit geraden Exponent
      '  DCAA(MC(_F), 1) : DDCE("-`a ^ b` = `a ^ b")
      '  BEAA("   b = 2 k, k ∈ ℕ") : Exit Sub : End If

      'Case 1129 : _AH = "a - a` = `0"
      'Case 1130 : _AH = "a` - b + b` = `a"
      'Case 1131 : _AH = "-a + a` = `0"
      'Case 1132 : _AH = "-a ^ b + a ^ b` = `0"
      'Case 1133 : _AH = "a : a` = `1"
      'Case 1134 : _AH = "a` : b · b` = `a"
      'Case 1135 : _AH = "-a : a` = `-1"
      'Case 1136 : _AH = "a : -a` = `-1"
      'Case 1137 : _AH = "-a ^ b : a ^ b` = `-1"
      'Case 1138 : _AH = "a ^ b : -a ^ b` = `-1"
      'Case 1139 : _AH = "a` : -b · b` = `a` · -1"
      'Case 1140 : _AH = "a` : b · -b` = `a` · -1"
      'Case 1141 : _AH = "a` : -b ^ c · b ^ c` = `a` · -1"
      'Case 1142 : _AH = "a` : b ^ c · -b ^ c` = `a` · -1"

      'Case 1143 : _AH = "-`a ^ b` = `a ^ b"
      'Case 1144 : _AH = "a ± b` = `c"
      'Case 1145 : _AH = "a ·: b` = `c"
      'Case 1146 : _AH = "a ˄˅ b` = `c"
      'Case 1147 : _AH = "b` o `a` = `a` o `b"


      '      BԳB < 5                       BԳB = 5
      ' 1  - N Exp - Plus          '  1  - N Exp - Plus
      ' 2  - A Exp - Plus          ' 12  - A Exp - Plus
      ' 3  - N Exp - Minus         '  3  - N Exp - Minus
      ' 4  - A Exp - Minus         ' 14  - A Exp - Minus
      ' 22 - G Exp - Plus          ' 32  - G Exp - Plus
      ' 24 - G Exp - Minus         ' 34  - G Exp - Minus
      ' 42 - U Exp - Plus          ' 52  - U Exp - Plus
      ' 44 - U Exp - Minus         ' 54  - U Exp - Minus

      ' Exponent:
      ' N = Null, A = Allgemein, G = Gerade, U = Ungerade
      'Colors.CornflowerBlue

    Loop While _G < _L - 1

    ' Reihenfolge
    _F = -1 : Do : _F += 1 ' extrahierte Reihenfolge
      _AD = ""
      ' 1. Operatorengruppen: Verallgemeinerung und Trennung
      Select Case BԳB(_F) ' Vorrang ab bezüglich ag
        Case 4
          _A = 0 : BՑA(MI_(_F)) = "+" : _AD = "+" : _AE = "-"
        Case 5
          _A = 0 : BՑA(MI_(_F)) = "·" : _AD = "·" : _AE = ":"
        Case 6
          _A = 1 : If MH_(_F) > 2 Then _AD = "˄" : _AE = "˅"
      End Select

      For j = MI_(_F) + _A To MI_(_F) + MH_(_F) - 2 Step 1
        ' AAA = BFAA(j)
        For k = MI_(_F) + _A + 1 To MI_(_F) + MH_(_F) - 1 Step 2
          ' BBB = BFAA(k)

          If BՑB(j).CompareTo(BՑB(k)) = 1 Then _A = 0

          'If BԳC(j) < BԳC(k) Or AAA < BBB Then _A = 0

          If BՑB(j).Length < BՑB(k).Length Then _A = 0

          If BՑA(j) = _AE And BՑA(k) = _AD Then _A = 0

          'b.CompareTo(a) = 1   ! b.CompareTo(a) = 0 !
        Next
      Next



      Continue Do
      ' 1. Operatorengruppen: Verallgemeinerung und Trennung
      Select Case BԳB(_F) ' Vorrang ab bezüglich ag
        Case 4
          _A = 0 : BՑA(MI_(_F)) = "+" : _AD = "+" : _AE = "-"
        Case 5
          _A = 0 : BՑA(MI_(_F)) = "·" : _AD = "·" : _AE = ":"
        Case 6
          _A = 1 : If MH_(_F) > 2 Then _AD = "˄" : _AE = "˅"
      End Select
      ' 2. Operatorengruppe ist größer drei
      If _AD <> "" Then
        Dim av As New List(Of String) : MO_.Clear()
        ' 2.1. Minus: Vorzeichen => Operator
        If _AD = "+" Then : _B = BFAC(MI_(_F))
          If _B = 2 Or _B = 7 Then : BՑA(MI_(_F)) = "-"
            BՑB(MI_(_F)) = BՑB(MI_(_F)).TrimStart("-")
            If _B = 2 Then BԳA(MI_(_F)) = 0
            If _B = 7 Then BԳA(MI_(_F)) = 1
          End If : End If : MO_.Add(MI_(_F) + _A)
        av.Add(BՑA(MI_(_F) + _A)) : av.Add(BՑB(MI_(_F) + _A))
        ' 2.2. Variablen- und Operatorenvergleich
        For j = MI_(_F) + _A + 1 To MI_(_F) + MH_(_F) - 1 Step 1
          For k = 0 To av.Count - 2 Step 2  ' ! a ^ c ^ b !
            If av(k + 1).CompareTo(BՑB(j)) = 1 And
              (av(k) = _AD And BՑA(j) = _AE) = False Then
              'b.CompareTo(a) = 1   ! b.CompareTo(a) = 0 !
              av.Insert(k, BՑB(j)) : av.Insert(k, BՑA(j))
              MO_.Insert(k / 2, j) : Exit For : End If
            If k = av.Count - 2 Then ' wenn kein ↑ Exit For
              MO_.Add(j) : av.Add(BՑA(j))
              av.Add(BՑB(j)) : Exit For : End If : Next : Next
        ' 2.3. Minus: Operator => Vorzeichen
        If av(0) = "-" Then : Select Case BFAC(MO_(0))
            Case 0 : BԳA(MO_(0)) = 2 : av(1) = "-" & av(1)
              BՑB(MI_(_F)) = "-" & BՑB(MI_(_F))
            Case 5 : BԳA(MO_(0)) = 3 : av(1) = "-" & av(1)
              BՑB(MI_(_F)) = "-" & BՑB(MI_(_F))
            Case 1, 3, 4, 6, 8, 10 : av(1) = "-(" & av(1) & ")"
          End Select : End If : _AD = av(1) : BՑA(MI_(_F)) = ""
        ' 2.4. Variablen- und Operatorensammlung
        For j = 2 To av.Count - 1 Step 1 : _AD &= " " & av(j) : Next
        ' 2.5. Erste Extravariable der Operatorengruppe sechs
        If _A = 1 Then _AD = BՑB(MI_(_F)) & " " & av(0) & " " & _AD
        ' 2.6. Übersprung beim gleichen Ergebnis
        If BՑB(_F) = _AD Then Continue Do
        ' 2.7. Neuer Ausdruck - Ergebnis
        'DCBA(_AD, {MC(_F + _A), MD(_F)}) : DDED("b` o `a` = `a` o `b")
        Exit Sub : End If
      ' Exit Sub
      If CA <> BՑB(0) Then Exit Sub

      'BԳA()   Vorzeichen
      'BԳB()   Operatorengruppe
      'BՑB()   Term
      'BՑA()   Operator
      'LA()   Gesuchte im Nenner
      'BԳC()   Funktion
      'MC()   Eingangsanfang
      'MD()   Eingangslänge
      'ME_()   Quellenteilindex
      'MH_()   Ausgangsteilenanzahl
      'MI_()   Ausgangsteilenanfangsindex
      'BԳD()   Eingangsteil-Zahl
      'MM_()   Gesuchte Variable

      'MA()   Teilungsanfang
      'MF_()   Ausgangsanfang
      'MG_()   Ausgangslänge


    Loop While _F < _L - 1

  End Sub
#End Region
#Region "B-AD"
  Private Sub BDAA()
    KJ.Add(vbLf & vbLf & A_D.GetString("A154"))
    _FA = _AD.Split("´")
    KJ.Add(vbCrLf & CA.Substring(0, BFAB(_FA(1))))
    _J = 1 : _K = CInt(_FA(0)) - 2 : BDAC()
  End Sub
  Private Sub BDAB()
    KJ.Add(vbCrLf & vbLf & A_D.GetString("A155"))
    _H = BFAB(_FA(CInt(_FA(0))))
    KJ.Add(vbCrLf & CA.Substring(0, _H))
    _J = CInt(_FA(0)) : _K = _FA.Count - 2
    BDAC() : _H = BFAB(_FA(_FA.Count - 1))
    JA.Add(_ED) : JA.Add(_EA) : _J = 0
    KJ.Add(CA.Substring(_H, CA.Length - _H))
    _FD = _AE.Split("´") : _K = _FD.Count - 1
    BDAD() : JA.Add(_EA) ' Reihenfolge !
  End Sub
  Private Sub BDAC()
    For i = _J To _K Step 1 : _H = BFAB(_FA(i))
      KJ.Add(
        CA.Substring(_H, BFAB(_FA(i + 1)) - _H))
    Next
  End Sub
  Private Sub BDAD()
    For i = _J To _K Step 1
      JA.Add(_GA(CInt(_FD(i)))) : Next
  End Sub
  Private Sub BDAE()
    ' Positionen
    H1(0) = MD(0)
    H1(1) = MC(_F)
    H1(2) = MD(_F)
    H1(3) = MC(_G)
    H1(4) = MD(_G)
    H1(5) = ME_(_F)
    H1(6) = MI_(_F)
    H1(7) = MI_(_G)
    H1(8) = MI_(H1(5))
    H1(9) = MI_(H1(6))
    H1(10) = MI_(H1(7))
    H1(11) = MI_(H1(8))
    H1(12) = MI_(H1(9))
    H1(13) = MI_(H1(11))
    H1(14) = MI_(H1(12))
    H1(15) = MC(H1(6))
    H1(16) = MD(H1(6))
    H1(17) = MC(H1(7))
    H1(18) = MD(H1(7))
    H1(19) = MC(H1(8))
    H1(20) = MD(H1(8))
    H1(21) = MC(H1(9))
    H1(22) = MD(H1(9))
    H1(23) = MC(H1(10))
    H1(24) = MD(H1(10))
    H1(25) = MC(H1(11))
    H1(26) = MD(H1(11))
    H1(27) = MC(H1(12))
    H1(28) = MD(H1(12))
    H1(29) = MC(H1(14))
    H1(30) = MD(H1(14))
    H1(31) = _AF.Length
    H1(32) = H1(1) + H1(2)
    H1(33) = H1(1) + H1(31)
    H1(34) = H1(3) + H1(4)
    H1(35) = H1(3) + H1(31)
    H1(36) = H1(4) + H1(19)
    H1(37) = H1(15) + H1(16)
    H1(38) = H1(17) + H1(18)
    H1(39) = H1(18) + H1(19)
    H1(40) = H1(19) + H1(20)
    H1(41) = H1(1) - H1(40)
    H1(42) = H1(19) + H1(24)
    H1(43) = H1(19) + H1(31)
    H1(44) = H1(21) + H1(22)
    H1(45) = H1(23) + H1(24)
    H1(46) = H1(25) + H1(26)
    H1(47) = H1(27) + H1(28)
    H1(48) = H1(29) + H1(30)
  End Sub
  Private Sub BDBA()
    For i = MI_(H1(4)) To MI_(H1(4)) + H1(5) - 1 Step 1
      If BՑB(i) <> "☼" And BՑB(i) <> "-☼" Then : _G = i
        If i < _F Then _AI = BՑA(i) & "`" & _AI : Exit Sub
        If i > _F Then _AI &= "`" & BՑA(i) : Exit Sub
      End If : Next
  End Sub
#End Region
#Region "B-AE"
  Private Sub BEAA(a As String)
    KJ.Add(a) : JA.Add(_ED)
  End Sub
  Private Sub BEAB(a As String)
    KJ.Add(a) : JA.Add(_EE)
  End Sub
  Private Sub BEBA(a() As Integer)
    ' Formeln
    Select Case a(0)
        ' Einziger Term
      Case 1001 : _AH = "e` = `2,72"
      Case 1002 : _AH = "π` = `3,14"
      Case 1003 : _AH = "-e` = `-2,72"
      Case 1004 : _AH = "-π` = `-3,14"
      Case 1005 : _AH = "-0` = `0"
      Case 1006 : _AH = "+∞` = `∞"
      Case 1007 : _AH = "ln(0)` = `-∞"
      Case 1008 : _AH = "-ln(0)` = `∞"
      Case 1009 : _AH = "ln(e)` = `1"
      Case 1010 : _AH = "-ln(e)` = `-1"
      Case 1011 : _AH = "log(0)` = `-∞"
      Case 1012 : _AH = "-log(0)` = `∞"
        ' Vorzeichen "-"
      Case 1021 : _AH = "a` + -`b` = `a` - `b"
      Case 1022 : _AH = "a` - -`b` = `a` + `b"
      Case 1023 : _AH = "a` ± -`b` = `a` ∓ `b"
      Case 1024 : _AH = "a` ∓ -`b` = `a` ± `b"
      Case 1025 : _AH = "a` + -`b ˄˅ `c` = `a` - `b ˄˅ `c"
      Case 1026 : _AH = "a` - -`b ˄˅ `c` = `a` + `b ˄˅ `c"
      Case 1027 : _AH = "a` ± -`b ˄˅ `c` = `a` ± `b ˄˅ `c"
      Case 1028 : _AH = "a` ∓ -`b ˄˅ `c` = `a` ± `b ˄˅ `c"
        ' ·:   ˄˅ = ◊
      Case 1031 : _AH = "a ·: `-`b` = `-`a ·: b"
      Case 1032 : _AH = "-`a ·: `-`b` = `a ·: b"
      Case 1033 : _AH = "a ˄˅ `b` ·: `-`c` = `-`a ˄˅ `b` ·: c"
      Case 1034 : _AH = "-`a ˄˅ `b` ·: `-`c` = `a ˄˅ `b` ·: c"
      Case 1035 : _AH = "a ·: `-`b ˄˅ `c` = `-`a ·: b ˄˅ `c"
      Case 1036 : _AH = "-`a ·: `-`b ˄˅ `c` = `a ·: b ˄˅ `c"
      Case 1037 : _AH = "a ˄˅ `b` ·: `-`c ˄˅ `d` = `-`a ˄˅ `b` ·: c ˄˅ `d"
      Case 1038 : _AH = "-`a ˄˅ `b` ·: `-`c ˄˅ `d` = `a ˄˅ `b` ·: c ˄˅ `d"
        ' Unbestimmte
      Case 1041 : _AH = "0 ^ 0` = `☼"
      Case 1042 : _AH = "0 : 0` = `☼"
      Case 1043 : _AH = "a · `0 : 0` = `a · `☼"
      Case 1044 : _AH = "a` : 0 · 0` = `a · `☼"
      Case 1045 : _AH = "0 · ∞` = `☼"
      Case 1046 : _AH = "a · `0 · ∞` = `a · `☼"
      Case 1047 : _AH = "1 ^ ∞` = `☼"
      Case 1048 : _AH = "1 ^ -∞` = `1 : ☼"
      Case 1049 : _AH = "∞ · 0` = `☼"
      Case 1050 : _AH = "-∞ · 0` = `☼"
      Case 1051 : _AH = "a · `∞ · 0` = `a · `☼"
      Case 1052 : _AH = "∞ ^ 0` = `☼"
      Case 1053 : _AH = "-∞ ^ 0` = `☼"
      Case 1054 : _AH = "∞ - ∞` = `☼"
      Case 1055 : _AH = "-∞ + ∞` = `☼"
      Case 1056 : _AH = "a + `∞ - ∞` = `a + `☼"
      Case 1057 : _AH = "a` - ∞ + ∞` = `a` + ☼"
      Case 1058 : _AH = "∞ : ∞` = `☼"
      Case 1059 : _AH = "-∞ : ∞` = `-☼"
      Case 1060 : _AH = "a · `∞ : ∞` = `a · `☼"
      Case 1061 : _AH = "a` : ∞ · ∞` = `a` · ☼"
        ' Funktionszahlen
      Case 1071 : _AH = "a!` = `a · (a - 1) · ... · 1"
      Case 1072 : _AH = "a´` = `0"
      Case 1081 : _AH = "√(`a`)` = `b"
      Case 1082 : _AH = "ln(`a`)` = `b"
      Case 1083 : _AH = "log(`a`)` = `b"
      Case 1091 : _AH = "cos(`a`)` = `b"
      Case 1092 : _AH = "sin(`a`)` = `b"
      Case 1093 : _AH = "tan(`a`)` = `b"
      Case 1094 : _AH = "cot(`a`)` = `b"
      Case 1095 : _AH = "acos(`a`)` = `b"
      Case 1096 : _AH = "asin(`a`)` = `b"
      Case 1097 : _AH = "atan(`a`)` = `b"
      Case 1098 : _AH = "acot(`a`)` = `b"
      Case 1101 : _AH = "√(a` ' 2`)` = `√(a)"
      Case 1102 : _AH = "√(a ' b)` = `c"
      Case 1103 : _AH = "log(a ' b)` = `c"
        ' Klammern
      Case 1111 : _AH = "(`a`)` = `a"
      Case 1112 : _AH = "-(`a`)` = `-`a"
      Case 1113 : _AH = "-(-`a`)` = `a"
      Case 1114 : _AH = "-(`a` ^ b`)` = `-`a` ^ b"
      Case 1115 : _AH = "-(-`a` ^ b`)` = `a` ^ b"
      Case 1116 : _AH = "-(a ^ b ·: c`)` = `-(a ^ b`)` ·: c" : _AF = ")"
      Case 1121 : _AH = "a - `(`b` +- `c`)` = `a - b` -+ `c"
      Case 1122 : _AH = "a : `(`b` ·: `c`)` = `a : b` :· `c"
      Case 1123 : _AH = "-(`a` +- `b`)` = `-`a` -+ `b"
      Case 1124 : _AH = "-(-`a` +- `b`)` = `a` -+ `b"
      Case 1125 : _AH = "-(a ^ b` +- `c`)` = `-(a ^ b`) -+ `c" : _AF = ")"
      Case 1126 : _AH = "-(a ^ b * c` +- `d`)` = `-(a ^ b`)` * c` -+ `d" : _AF = ")"
      Case 1127 : _AH = "-(`a` ^ b` +- `c`)` = `-`a` ^ b` -+ `c"
      Case 1128 : _AH = "-(-`a` ^ b` +- `c`)` = `a` ^ b` -+ `c"
        ' Beträge
      Case 1131 : _AH = "ǀ`a`|` = `a" ' a ≥ 0
      Case 1132 : _AH = "-ǀ`a`|` = `-`a" ' a ≥ 0
      Case 1133 : _AH = "ǀ-`a`|` = `a" ' a ≥ 0
      Case 1134 : _AH = "-ǀ-`a`|` = `-`a" ' a ≥ 0
      Case 1135 : _AH = "ǀ`-`a|` = `|a|"
        ' Null und Eins
      Case 1141 : _AH = "a` ± 0` = `a"
      Case 1142 : _AH = "a` ∓ 0` = `a"
      Case 1143 : _AH = "a · `0` = `0"
      Case 1144 : _AH = "☼` · a` · 0` = `☼ · 0"
      Case 1145 : _AH = "a : 0` = `∞"
      Case 1146 : _AH = "☼ · `a : 0` = `☼ · `∞"
      Case 1147 : _AH = "a ^ 0` = `1"
      Case 1148 : _AH = "a` ·: 1` = `a"
      Case 1149 : _AH = "a` ^ 1` = `a"
      Case 1150 : _AH = "0 + `a` = `a"
      Case 1151 : _AH = "0` ·: a` = `0"
      Case 1152 : _AH = "1 · `a` = `a"
      Case 1153 : _AH = "☼ · 0` ·: a` = `☼ · 0"
          'Case 1114 : _AH = "☼` : a` · 0` = `☼ · 0"
      Case 1161 : _AH = "0 - `a` = `-`a"
      Case 1162 : _AH = "0 - `a ˄˅ b` = `-(`a ˄˅ b`)" : _AG = ")"
      Case 1163 : _AH = "0 - `-a ˄˅ b` = `-(`-a ˄˅ b`)" : _AG = ")"
      Case 1164 : _AH = "0 - `a ˄˅ `b` = `-`a ˄˅ `b" : _AG = ")"
      Case 1165 : _AH = "a ˄˅ b` ·: -1` = `-(`a ˄˅ b`)" : _AG = ")"
      Case 1166 : _AH = "-1 · `a` = `-`a"
      Case 1167 : _AH = "-1 · `a ˄˅ b` = `-(`a ˄˅ b`)" : _AG = ")"
      Case 1168 : _AH = "-1 · `-a ˄˅ b` = `-(`-a ˄˅ b`)" : _AG = ")"
      Case 1169 : _AH = "-1 · `a ˄˅ `b` = `-`a ˄˅ `b"
        ' Zahlen
      Case 1171 : _AH = "a ± b` = `c"
      Case 1172 : _AH = "a + `b ± c` = `a + `(b ± c)"
      Case 1173 : _AH = "a - `b ± c` = `a - `(b ∓ c)"
      Case 1174 : _AH = "a ·: b` = `c"
      Case 1175 : _AH = "a · `b ·: c` = `a · `(b ·: c)"
      Case 1176 : _AH = "a : `b ·: c` = `a : `(b :· c)"
      Case 1177 : _AH = "a ˄˅ b` = `c"


        'Case 1151 : _AH = "-`a ^ b` = `a ^ b"
        'Case 1129 : _AH = "a - a` = `0"
        'Case 1130 : _AH = "a` - b + b` = `a"
        'Case 1131 : _AH = "-a + a` = `0"
        'Case 1132 : _AH = "-a ^ b + a ^ b` = `0"
        'Case 1133 : _AH = "a : a` = `1"
        'Case 1134 : _AH = "a` : b · b` = `a"
        'Case 1135 : _AH = "-a : a` = `-1"
        'Case 1136 : _AH = "a : -a` = `-1"
        'Case 1137 : _AH = "-a ^ b : a ^ b` = `-1"
        'Case 1138 : _AH = "a ^ b : -a ^ b` = `-1"
        'Case 1139 : _AH = "a` : -b · b` = `a` · -1"
        'Case 1140 : _AH = "a` : b · -b` = `a` · -1"
        'Case 1141 : _AH = "a` : -b ^ c · b ^ c` = `a` · -1"
        'Case 1142 : _AH = "a` : b ^ c · -b ^ c` = `a` · -1"

        'Case 1147 : _AH = "b` o `a` = `a` o `b"
    End Select
    ' String 1
    Select Case a(1)
      Case 0 : Exit Select
      Case 1 : _AF = CStr(Math.E)
      Case 2 : _AF = CStr(Math.PI)
      Case 3 : _AF = CStr(-Math.E)
      Case 4 : _AF = CStr(-Math.PI)
      Case 5 : _AF = "0"
      Case 6 : _AF = "∞"
      Case 7 : _AF = "-∞"
      Case 8 : _AF = "1"
      Case 9 : _AF = "-1"
      Case 10 : _AF = "-"
      Case 11 : _AF = " - "
      Case 12 : _AF = " + "
      Case 13 : _AF = " ∓ "
      Case 14 : _AF = " ± "
      Case 15 : _AF = "☼"
      Case 16 : _AF = "-☼"
      Case 17 : _AF = " + ☼"
      Case 18 : _AF = " · ☼"
      Case 19 : _AF = "(1 : ☼)"
      Case 20 : _AF = BՑB(_G)
      Case 21 : _AF = "("
      Case 22 : _AF = "-("
    End Select
    ' Stellen 1
    Select Case a(2)
      Case 1 : BDAE() : _HB = {H1(1), H1(2), H1(1)}
      Case 2 : BDAE() : _HB = {H1(1) - 3, 4, H1(1) - 3}
      Case 3 : BDAE() : _HB = {H1(1), 1, H1(19)}
      Case 4 : BDAE() : _HB = {H1(1), 1, H1(19), 1}
      Case 5 : BDAE() : _HB = {H1(3) - 3, H1(4) + 3, H1(19), H1(20), H1(19)}
      Case 6 : BDAE() : _HB = {H1(3) - 3, H1(4) + 3, H1(1), H1(2), H1(1)}
      Case 7 : BDAE() : _HB = {H1(3) - 3, H1(4) + 3, H1(1) - 3, H1(2) + 3, H1(1) - 3}
      Case 8 : BDAE() : _HB = {H1(1) - 3, H1(2) + 3}
      Case 9 : BDAE() : _HB = {H1(1) - 3, H1(2) + 3, H1(3), H1(4), H1(3)}
      Case 10 : BDAE() : _HB = {H1(1) - 3, H1(2) + 3, H1(19), H1(20), H1(19)}
      Case 11 : BDAE() : _HB = {H1(3) - 3, H1(4) + 3}
      Case 12 : BDAE() : _HB = {H1(19), H1(20) + 3, H1(19)}
      Case 13 : BDAE() : _HB = {H1(19), H1(20) + 3, H1(19), H1(34) - H1(2) - 1}
      Case 14 : BDAE() : _HB = {H1(19), H1(20) + 3, H1(19), H1(38) - H1(2) - 1}
      Case 15 : BDAE() : _HB = {H1(1) - 3, H1(2) + 3, H1(19), H1(40) + 2}
      Case 16 : BDAE() : _HB = {H1(1), 1, H1(32) - 2, 1}
      Case 17 : BDAE() : _HB = {H1(1) + 1, 1, H1(32) - 2, 1}
      Case 18 : BDAE() : _HB = {H1(1), 3, H1(32) - 4, 1}
      Case 19 : BDAE() : _HB = {H1(32) - 1, 1, H1(44)}
      Case 20 : BDAE() : _HB = {H1(32) - 1, 1, H1(47)}
      Case 21 : BDAE() : _HB = {H1(1), 2, H1(32) - 3, 1}
      Case 22 : BDAE() : _HB = {H1(44), 4}
    End Select
    ' Stellen 2
    Select Case a(3)
      Case 1 ' R-GSG-R ' e = 2,72
        _AD = "4´1´32´0´1´33" : _AE = "2´0´3´0´2"
      Case 2 ' BGRB-GSG-BGRB ' a + -b = a - b
        _AD = "7´19´40´1:3´1·1´32´0´19´40´1:3´1´32:1" : _AE = "1´0´2´1´0´3´0´1´0´2´1"
      Case 3 ' BGRBL-GSG-BGRBL-1 ' a + -b' = a - b'
        _AD = "8´19´40´1:3´1·1´37·3´32´0´19´40´1:3´1´37·2´32:1" : _AE = "1´0´2´1´4´0´3´0´1´0´2´1´4"
      Case 4 ' BGRBL-GSG-BGRBL-2 ' a + -b'. = a - b'.
        _AD = "8´19´40´1:3´1·1´44·3´37·3´0´19´40´1:3´1´44·2´37·2" : _AE = "1´0´2´1´4´0´3´0´1´0´2´1´4"
      Case 5 ' BGBRB-GSG-RBGB ' a ·: -b = -a ·: b
        _AD = "8´19´40´1:3´1´1·1´32´0´19´19·1´40·1´1:2´32" : _AE = "1´0´1´2´1´0´3´0´2´1´0´1"
      Case 6 ' RBGBRB-GSG-BGB ' -a ·: -b = a ·: b
        _AD = "9´19´19·1´40´1:3´1´1·1´32´0´19´40:1´1:4´32:2" : _AE = "2´1´0´1´2´1´0´3´0´1´0´1"
      Case 7 ' BLGBRB-GSG-RBLGB ' a' ·: -b = -a' ·: b
        _AD = "9´19´46·3´40´1:3´1´1·1´32´0´19´19·1´46·4´40·1´1:2´32" : _AE = "1´4´0´1´2´1´0´3´0´2´1´4´0´1"
      Case 8 ' RBLGBRB-GSG-BLGB ' -a' ·: -b = a' ·: b
        _AD = "10´19´19·1´46·3´40´1:3´1´1·1´32´0´19´46·2´40:1´1:4´32:2" : _AE = "2´1´4´0´1´2´1´0´3´0´1´4´0´1"
      Case 9 ' BGBRBL-GSG-RBGBL ' a ·: -b' = -a ·: b'
        _AD = "9´19´40´1:3´1´1·1´37·3´32´0´19´19·1´40·1´1:2´37·3´32" : _AE = "1´0´1´2´1´4´0´3´0´2´1´0´1´4"
      Case 10 ' RBGBRBL-GSG-BGBL ' -a ·: -b' = a ·: b'
        _AD = "10´19´19·1´40´1:3´1´1·1´37·3´32´0´19´40:1´1:4´37·1´32:2" : _AE = "2´1´0´1´2´1´4´0´3´0´1´0´1´4"
      Case 11 ' BLGBRBL-GSG-RBLGBL ' a' ·: -b' = -a' ·: b'
        _AD = "10´19´46·3´40´1:3´1´1·1´37·3´32´0´19´19·1´46·4´40·1´1:2´37·3´32" : _AE = "1´4´0´1´2´1´4´0´3´0´2´1´4´0´1´4"
      Case 12 ' RBLGBRBL-GSG-BLGBL ' -a' ·: -b' = a' ·: b'
        _AD = "11´19´19·1´46·3´40´1:3´1´1·1´37·3´32´0´19´46·2´40:1´1:4´37·1´32:2" : _AE = "2´1´4´0´1´2´1´4´0´3´0´1´4´0´1´4"
      Case 13 ' RGR-GSG-R-1 ' 0 : 0 = ☼
        _AD = "6´19´40´3:3´34´0´19´33" : _AE = "2´0´2´0´3´0´2"
      Case 14 ' BGBRGR-GSG-BGBR-1 ' a · 0 : 0 = a · ☼
        _AD = "9´19´40´1:3´1´32´3:3´34´0´19´40´1:3´1´33" : _AE = "1´0´1´2´0´2´0´3´0´1´0´1´2"
      Case 15 ' BGRGR-GSG-BGR ' a : 0 · 0 = a · ☼
        _AD = "8´19´40´1:3´32´3:3´34´0´19´40´1:3´33:3" : _AE = "1´0´2´0´2´0´3´0´1´0´2"
      Case 16 ' BGR-GSG-B-1 ' a ± 0 = a
        _AD = "6´19´40´1:3´32´0´19´40" : _AE = "1´0´2´0´3´0´1"
      Case 17 ' RGRB-GSG-B ' a · 0 = 0
        _AD = "7´19´40´9´1´32´0´19´43" : _AE = "2´0´2´1´0´3´0´1"
      Case 18 ' BGRGB-GSG-BGB ' ☼ · a · 0 = ☼ · 0
        _AD = "8´19´40´3:3´34´1:3´32´0´19´40´3:3´35" : _AE = "1´0´2´0´1´0´3´0´1´0´1"
      Case 19 ' RGR-GSG-R-2 ' a : 0 = ∞
        _AD = "6´19´40´1:3´32´0´19´43" : _AE = "2´0´2´0´3´0´2"
      Case 20 ' BGBRGR-GSG-BGBR-2 ' ☼ · a : 0 = ☼ · ∞
        _AD = "9´19´40´3:3´3´34´1:3´32´0´19´40´3:3´3´35" : _AE = "1´0´1´2´0´2´0´3´0´1´0´1´2"
      Case 21 ' RGRB-GSG-B ' 0 + a = a
        _AD = "7´19´40´3:3´3´34´0´19´43" : _AE = "2´0´2´1´0´3´0´1"
      Case 22 ' BGR-GSG-B-2 ' 0 · a = 0
        _AD = "6´19´40´3:3´34´0´19´40" : _AE = "1´0´2´0´3´0´1"
      Case 23 ' BGBGBR-GSG-BGB ' ☼ · 0 · a = 0 = ☼ · 0
        _AD = "8´19´40´1:3´32´3:3´34´0´19´40´1:3´32" : _AE = "1´0´1´0´2´0´3´0´1´0´1"
      Case 24 ' RB-GSG-RB-1 ' 0 - a = -a
        _AD = "5´19´3´34´0´19´19·1´36·1" : _AE = "2´1´0´3´0´2´1"
      Case 25 ' RB-GSG-RB-2 ' 0 - a' = -(a')
        _AD = "5´19´3´34´0´19´19·2´36·2´36·3" : _AE = "2´1´0´3´0´2´1´2"
      Case 26 ' RB-GSG-RB-3 ' 0 - a'. = -(a').
        _AD = "5´19´3´38·3´0´19´19·2´39·2´39·3" : _AE = "2´1´0´3´0´2´1´2"
      Case 27 ' RBL-GSG-RBL-1 ' 0 - a' = -a'
        _AD = "6´19´3´38·3´34´0´19´19·1´39·4´36·1" : _AE = "2´1´4´0´3´0´2´1´4"
      Case 28 ' RBL-GSG-RBL-2 ' 0 - a'. = -a'.
        _AD = "6´19´3´45·3´38´0´19´19·1´42·4´39·1" : _AE = "2´1´4´0´3´0´2´1´4"
      Case 29 ' BGR-GSG-RBR ' a' · -1 = -(a')
        _AD = "6´19´40´1:3´32´0´19´19·2´40·2´40·3" : _AE = "1´0´2´0´3´0´2´1´2"
      Case 30 ' RBR-GSG-B - 1 ' (a) = a
        _AD = "6´1´1·1´32:1´32´0´1´32:2" : _AE = "2´1´2´0´3´0´1"
      Case 31 ' RBR-GSG-RB - 1 ' -(a) = -a
        _AD = "6´1´15´32:1´32´0´1´1·1´32:2" : _AE = "2´1´2´0´3´0´2´1"
      Case 32 ' RBR-GSG-B - 2 ' -(-a) = a
        _AD = "6´1´15·1´32:1´32´0´1´32:4" : _AE = "2´1´2´0´3´0´1"
      Case 33 ' RBLR-GSG-RBL ' -(a') = -a'
        _AD = "7´1´15´44´32:1´32´0´1´1·1´44:1´32:2" : _AE = "2´1´4´2´0´3´0´2´1´4"
      Case 34 ' RBLR-GSG-RBL ' -(a'.) = -a'.
        _AD = "8´1´15´47´44´32:1´32´0´1´1·1´47:1´44:1" : _AE = "2´1´4´0´2´0´3´0´2´1´4"
      Case 35 ' RBLR-GSG-BL ' -(-a') = a'
        _AD = "7´1´15·1´44´32:1´32´0´1´44:3´32:4" : _AE = "2´1´4´2´0´3´0´1´4"
      Case 36 ' RBLR-GSG-BL ' -(-a'.) = a'.
        _AD = "8´1´15·1´47´44´32:1´32´0´1´47:3´44:3" : _AE = "2´1´4´0´2´0´3´0´1´4"
      Case 37 ' BR-GSG-BRB ' -(a'.) = -(a').
        _AD = "5´1´32:1´32´0´1´44´44·1´32" : _AE = "1´2´0´3´0´1´2´1"
      Case 38 ' BRBRBR-GSG-BRB * ' a - (b +- c) = a - b -+ c
        _AD = "7´3´2´19´40´1:3´1´1·1´44´19´40´1:3´44:1" : _AE = "8´3´0´1´0´1´2´1´2´0´3´0´1´0´1"
      Case 39 ' RBRBR-GSG-RBRB * ' -(a +- b) = -a -+ b
        _AD = "4´3´2´1´1·2´44´1´1·1´44:1" : _AE = "5´3´0´2´1´2´0´3´0´2´1"
      Case 40 ' RBRBR-GSG-BRB * ' -(-a +- b) = a -+ b
        _AD = "4´5´4´1´1·3´44´1´44:3" : _AE = "5´3´0´2´1´2´0´3´0´1"
      Case 41 ' BRBR-GSG-BRB * ' -(a' +- b) = -(a') -+ b
        _AD = "3´1´0´1´44´1´44´44·1" : _AE = "4´3´0´1´2´0´3´0´1´2"
      Case 42 ' RBRBR-GSG-BRB * ' -(a'. +- b) = -(a'). -+ b
        _AD = "3´1´0´1´44´1´47´47·1´44·1" : _AE = "4´3´0´1´2´0´3´0´1´2´1"
      Case 43 ' RBLRBR-GSG-RBLRB * ' -(a' +- b) = -a' -+ b
        _AD = "5´3´2´1´1·2´47´44´1´1·1´47:1´44:1" : _AE = "6´3´0´2´1´4´2´0´3´0´2´1´4"
      Case 44 ' RBLRBR-GSG-RBLRB * ' -(a'. +- b) = -a'. -+ b
        _AD = "6´3´2´1´1·2´48´47´44´1´1·1´48:1´47:1´44:1" : _AE = "7´3´0´2´1´4´0´2´0´3´0´2´1´4´0"
      Case 45 ' RBLRBR-GSG-BLRB * ' -(-a' +- b) = a' -+ b
        _AD = "5´5´4´1´1·3´47´44´1´47:3´44:3" : _AE = "6´3´0´2´1´4´2´0´3´0´1´4"
      Case 46 ' RBLRBR-GSG-BLRB * ' -(-a'. +- b) = a'. -+ b
        _AD = "6´5´4´1´1·3´48´47´44´1´48:3´47:3´44:3" : _AE = "7´3´0´2´1´4´0´2´0´3´0´1´4´0"
      Case 47 ' BRB-GSG-B - 1 ' ǀ-a| = |a|
        _AD = "6´1´1·1´1·2´32´0´1´32:1" : _AE = "1´2´1´0´3´0´1"
      Case 48 ' RBR-GSG-B - 3 ' ǀ-a| = a
        _AD = "6´1´15·1´32:1´32´0´1´32:3" : _AE = "2´1´2´0´3´0´1"
      Case 49 ' RBR-GSG-RB - 2 ' -ǀ-a| = -a
        _AD = "6´1´15·1´32:1´32´0´1´1·1´32:3" : _AE = "2´1´2´0´3´0´2´1"
      Case 50 ' BRB-GSG-B - 2 ' √(a ' 2) = √(a)
        _AD = "6´1´44´44·4´32´0´1´44·1" : _AE = "1´2´1´0´3´0´1"

    End Select
    ' Funktionen
    Select Case a(4)
      Case 2 ' R: Remove
        BDAA() : CA = CA.Remove(_HB(0), _HB(1))
        BDAB()
      Case 3 ' RI: Remove-Insert
        BDAA() : CA = CA.Remove(_HB(0), _HB(1))
        CA = CA.Insert(_HB(2), _AF) : BDAB()
      Case 4 ' RR: Remove-Remove
        BDAA() : CA = CA.Remove(_HB(0), _HB(1))
        CA = CA.Remove(_HB(2), _HB(3)) : BDAB()
      Case 5 ' RII: Remove-Insert-Insert
        BDAA() : CA = CA.Remove(_HB(0), _HB(1))
        CA = CA.Insert(_HB(2), _AF)
        CA = CA.Insert(_HB(3), _AG) : BDAB()
      Case 6 ' RRI: Remove-Remove-Insert
        BDAA() : CA = CA.Remove(_HB(0), _HB(1))
        CA = CA.Remove(_HB(2), _HB(3))
        CA = CA.Insert(_HB(4), _AF) : BDAB()
      Case 100 ' R(RI)R:
        ' a - (b +- c) = a - b -+ c
        _FA = _AD.Split("´") : _FD = _AE.Split("´")
        _J = CInt(_FA(3))
        KJ.Add(vbLf & vbLf & A_D.GetString("A154"))
        KJ.Add(vbCrLf & CA.Substring(0, H1(_J)))
        ' *********************************************
        ' Farben : Index-Abkürzung
        _J = 3 : _K = CInt(_FA(0)) : BDAC()
        _J = 1 : _K = CInt(_FD(0)) - 1 : BDAD()
        ' *********************************************
        _J = H1(9) + 1 : _K = CInt(_FA(3))
        ' For-Schleife von zweiten bis letzten Operatoren
        For i = _J To _J + MH_(H1(6)) - 2 Step 1
          KJ.Add(" " & BՑA(i) & " ") : KJ.Add(BՑB(i))
          JA.Add(_EC) : JA.Add(_EB) : Next
        KJ.Add(CA.Substring(H1(32) - 1, 1))
        KJ.Add(CA.Substring(H1(32), H1(0) - H1(32)))
        KJ.Add(vbCrLf & vbLf & A_D.GetString("A155"))
        KJ.Add(vbCrLf & CA.Substring(0, H1(_K)))
        ' *********************************************
        If _AF = ")" Then
          CA = CA.Remove(_HB(0), _HB(1))
          CA = CA.Insert(_HB(2), _AF)
        Else
          CA = CA.Remove(_HB(0), _HB(1))
          CA = CA.Remove(_HB(2), _HB(3))
        End If
        ' *********************************************
        _J = CInt(_FA(0)) + 2 : _K = _FA.Count - 2
        BDAC()
        _J = CInt(_FD(0)) : _K = _FD.Count - 1
        BDAD()
        ' *********************************************
        ' Farben : Index-Abkürzung
        _J = H1(9) + 1
        ' For-Schleife von zweiten bis letzten Operatoren
        For i = _J To _J + MH_(H1(6)) - 2 Step 1
          ' Operatorentausch
          Select Case BՑA(i)
            Case "+" : _AF = "-" : Case "-" : _AF = "+"
            Case "·" : _AF = ":" : Case ":" : _AF = "·"
          End Select
          ' Operatoren RI mit Farben in CA
          ' *******************************************
          _H = MC(i) - CInt(_FA(1)) ' -(-a + b)
          CA = CA.Remove(_H, 1) : JA.Add(_EC)
          CA = CA.Insert(_H, _AF) : JA.Add(_EB)
          KJ.Add(" " & _AF & " ") : KJ.Add(BՑB(i))
        Next
        ' *********************************************
        JA.Add(_EA) : _H = H1(32) - CInt(_FA(2))
        KJ.Add(CA.Substring(_H, H1(0) - H1(32)))
        'AIAI("AAAAA") : Exit Sub ' -(a ^ b + c)
        ' *********************************************
    End Select
    ' Farben Teil 1-2
    For i = 0 To 1 : JA.Add(_ED)
      Select Case a(5 + i)
        Case 1 : JA.Add(_EB) ' B
        Case 2 : JA.Add(_EE) ' L
        Case 3 : JA.Add(_EC) ' R
        Case 4 : JA.AddRange({_EB, _EC}) ' BR
        Case 5 : JA.AddRange({_EB, _EE}) ' BL
        Case 6 : JA.AddRange({_EC, _EB}) ' RB
        Case 7 : JA.AddRange({_EB, _EE, _EB}) ' BLB
        Case 8 : JA.AddRange({_EB, _EC, _EB}) ' BRB
        Case 9 : JA.AddRange({_EC, _EB, _EE}) ' RBL
        Case 10 : JA.AddRange({_EC, _EB, _EC}) ' RBR
        Case 11 : JA.AddRange({_EC, _EE, _EC}) ' RLR
        Case 12 : JA.AddRange({_EB, _EE, _EB, _EE}) ' BLBL
        Case 13 : JA.AddRange({_EB, _EC, _EB, _EE}) ' BRBL
        Case 14 : JA.AddRange({_EC, _EB, _EE, _EB}) ' RBLB
        Case 15 : JA.AddRange({_EC, _EB, _EC, _EB}) ' RBRB
        Case 16 : JA.AddRange({_EB, _EE, _EB, _EC, _EB}) ' BLBRB
        Case 17 : JA.AddRange({_EC, _EB, _EE, _EB, _EE}) ' RBLBL
        Case 18 : JA.AddRange({_EC, _EB, _EC, _EB, _EE}) ' RBRBL
        Case 19 : JA.AddRange({_EB, _EE, _EB, _EC, _EB, _EE}) ' BLBRBL
        Case 20 : JA.AddRange({_EC, _EB, _EE, _EB, _EC, _EB}) ' RBLBRB
        Case 21 : JA.AddRange({_EC, _EB, _EE, _EB, _EC, _EB, _EE}) ' RBLBRBL
        Case 22 : JA.AddRange({_EC, _EB, _EE, _EC}) ' RBLR
        Case 23 : JA.AddRange({_EB, _EC, _EB, _EC, _EB, _EC}) ' BRBRBR
        Case 24 : JA.AddRange({_EC, _EB, _EC, _EB, _EC}) ' RBRBR
        Case 25 : JA.AddRange({_EB, _EC, _EB, _EC}) ' BRBR
        Case 26 : JA.AddRange({_EB, _EC, _EB, _EC, _EB}) ' BRBRB
        Case 27 : JA.AddRange({_EC, _EB, _EE, _EC, _EB}) ' RBLRB
        Case 28 : JA.AddRange({_EC, _EB, _EE, _EC, _EB, _EC}) ' RBLRBR
        Case 29 : JA.AddRange({_EB, _EE, _EC, _EB}) ' BLRB

          ' CB - Blue CC - Magenta CD - SkyBlue CE - Lime *
      End Select
      If i = 0 Then
        KJ.Add(vbCrLf & vbCrLf & A_D.GetString("A152") &
                vbCrLf) : _FA = _AH.Split("`")
        For j = 0 To _FA.Count - 1 Step 1 : KJ.Add(_FA(j))
        Next
      End If
    Next
    ' Kommentarmeldung
    If a(7) > 0 Then
      BEAA(vbCrLf & vbCrLf & A_D.GetString("A156") & vbCrLf)
    End If
    ' Kommentare
    Select Case a(7) : Case 0 : Exit Select
      Case 1 : BEAB("b = 2 k + 1, k є Z") ' ∈ ℕ
      Case 2 : BEAB("c = 2 k + 1, k є Z")
      Case 3 : BEAB("b, d = 2 k + 1, k є Z")
      Case 4 : BEAB("-∞ · 0 = -0 · ∞ = 0 · ∞ = ☼")
      Case 5 : BEAB("a є Z, a < 171, a > -171 (" &
                    A_D.GetString("A000") & ")")
      Case 6 : BEAB("a ≠ 0")
      Case 7 : BEAB("a ≠ ∞")
      Case 8 : BEAB("a, b є R")
      Case 9 : BEAB("a є R")
      Case 10 : BEAB("a ≥ 0")
      Case 11 : BEAB("b, c, d є R")
    End Select
  End Sub
#End Region
#Region "B-AF"
  Private Function BFAA(a As Double) As String
    Return a.ToString().Replace("E+", " · 10 ^ ").Replace(
      "E-0", " · 10 ^ -").Replace("E-", " · 10 ^ -")
  End Function
  Private Function BFAB(a As String) As Integer
    If a.Split("·").Count = 2 Then
      _FB = a.Split("·") : BFAB = H1(CInt(_FB(0))) + CInt(_FB(1))
    ElseIf a.Split(":").Count = 2 Then
      _FB = a.Split(":") : BFAB = H1(CInt(_FB(0))) - CInt(_FB(1))
    Else : BFAB = H1(CInt(a)) : End If : Return BFAB
  End Function
  Private Function BFAC(a As Integer) As String
    H1(0) = BԳA(a) + 1
    If H1(0) = 2 Or H1(0) = 4 Then : H1(1) = a
      If BԳB(a) = 5 Then H1(1) = MI_(a) : H1(0) += 10
      H1(2) = MI_(H1(1)) + 1 ' ! Reihenfolge !
      If MH_(H1(1)) = 2 And BՑA(H1(2)) = "˄" Then
        If Integer.TryParse(BՑB(H1(2)), 0) = True Then
          Select Case BՑB(H1(2)).Substring(MD(H1(2)) - 1, 1)
            Case "0", "2", "4", "6", "8" : H1(0) += 20
            Case "1", "3", "5", "7", "9" : H1(0) += 40
          End Select
        End If
      End If
    End If
    Return CStr(H1(0)) ' {0, 1, 2, 3} + 1

    '      IB < 5                       IB = 5
    ' 1  - N Exp - Plus          ' 11  - N Exp - Plus
    ' 2  - A Exp - Plus          ' 12  - A Exp - Plus
    ' 3  - N Exp - Minus         ' 13  - N Exp - Minus
    ' 4  - A Exp - Minus         ' 14  - A Exp - Minus
    ' 22 - G Exp - Plus          ' 32  - G Exp - Plus
    ' 24 - G Exp - Minus         ' 34  - G Exp - Minus
    ' 42 - U Exp - Plus          ' 52  - U Exp - Plus
    ' 44 - U Exp - Minus         ' 54  - U Exp - Minus

    ' N = Null, A = Allgemein, G = Gerade, U = Ungerade
  End Function
  Private Function BFAD(a As Integer) As String
    Return BՑB(a).TrimStart("-")
  End Function
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

    For i = 1 To 32 Step 1 : CEA = If(i < 10, "00", "0")
      eaaab = New TextBlock With {
        .FontSize = 12, .Text = A_A.GetString("A" & CEA & CStr(i)), .IsTextSelectionEnabled = False}
      eaaaa = New Button With {.Padding = New Thickness(0), .Content = eaaab,
            .Background = New SolidColorBrush(Colors.WhiteSmoke), .Margin = New Thickness(0.5)}
      B300.Children.Add(eaaaa)
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

    For i = 1 To 118 Step 1 : CEA = "B" & If(i < 10, "00", If(i < 100, "0", "")) & CStr(i)
      eaaab = New TextBlock With {
        .FontFamily = New FontFamily("Calibri Light"), .IsTextSelectionEnabled = False}
      Select Case ACAC(i - 1) : Case "0", "2", "8"
          eaaab.Foreground = New SolidColorBrush(Colors.White) : End Select
      eaaaa = New Button With {.Background = New SolidColorBrush(ACAB(CInt(ACAC(i - 1)))),
        .Padding = New Thickness(0), .HorizontalContentAlignment = 0, .Content = eaaab,
        .Margin = New Thickness(0.5)}
      Grid.SetRow(eaaaa, CInt(eaaba(i - 1))) : Grid.SetColumn(eaaaa, CInt(eaabb(i - 1)))
      eaaca = New Documents.Run With {.Text = A_A.GetString(CEA) & vbLf, .FontSize = 15}
      eaaab.Inlines.Add(eaaca) : B300.Children.Add(eaaaa)
      eaaca = New Documents.Run With {.Text = vbLf & A_D.GetString(CEA), .FontSize = 12}
      eaaab.Inlines.Add(eaaca) : AddHandler eaaaa.Click, AddressOf CABA : Next
  End Sub
  Private Sub CAAB()
    ' Liste der chemischen Elemente
    For i = 1 To 118 Step 1 : CEA = "B" & If(i < 10, "00", If(i < 100, "0", "")) & CStr(i)
      EB_.Items.Add(New TextBlock With {.FontFamily = New FontFamily("Consolas"),
        .FontSize = 16, .VerticalAlignment = 3, .HorizontalAlignment = 3,
        .Text = (A_A.GetString(CEA) & "          ").Substring(0, 10) & A_D.GetString(CEA)})
    Next : AA00.Children.
      Add(EB_) : Grid.SetRow(EB_, 2) : AddHandler EB_.SelectionChanged, AddressOf CABB
  End Sub
#End Region
#Region "C-AB"
  Private Sub CABA(a As Button, b As RoutedEventArgs)
    ' Die Auswahl des chemischen Elements von der Tabelle
    CEA = CStr(Grid.GetRow(a)) & "." & CStr(Grid.GetColumn(a))
    Select Case CEA
      Case "3.2" : CEA = "1" : Case "3.20" : CEA = "2" : Case "4.2" : CEA = "3" : Case "4.3" : CEA = "4"
      Case "4.15" : CEA = "5" : Case "4.16" : CEA = "6" : Case "4.17" : CEA = "7" : Case "4.18" : CEA = "8"
      Case "4.19" : CEA = "9" : Case "4.20" : CEA = "10" : Case "5.2" : CEA = "11" : Case "5.3" : CEA = "12"
      Case "5.15" : CEA = "13" : Case "5.16" : CEA = "14" : Case "5.17" : CEA = "15" : Case "5.18" : CEA = "16"
      Case "5.19" : CEA = "17" : Case "5.20" : CEA = "18" : Case "6.2" : CEA = "19" : Case "6.3" : CEA = "20"
      Case "6.4" : CEA = "21" : Case "6.6" : CEA = "22" : Case "6.7" : CEA = "23" : Case "6.8" : CEA = "24"
      Case "6.9" : CEA = "25" : Case "6.10" : CEA = "26" : Case "6.11" : CEA = "27" : Case "6.12" : CEA = "28"
      Case "6.13" : CEA = "29" : Case "6.14" : CEA = "30" : Case "6.15" : CEA = "31" : Case "6.16" : CEA = "32"
      Case "6.17" : CEA = "33" : Case "6.18" : CEA = "34" : Case "6.19" : CEA = "35" : Case "6.20" : CEA = "36"
      Case "7.2" : CEA = "37" : Case "7.3" : CEA = "38" : Case "7.4" : CEA = "39" : Case "7.6" : CEA = "40"
      Case "7.7" : CEA = "41" : Case "7.8" : CEA = "42" : Case "7.9" : CEA = "43" : Case "7.10" : CEA = "44"
      Case "7.11" : CEA = "45" : Case "7.12" : CEA = "46" : Case "7.13" : CEA = "47" : Case "7.14" : CEA = "48"
      Case "7.15" : CEA = "49" : Case "7.16" : CEA = "50" : Case "7.17" : CEA = "51" : Case "7.18" : CEA = "52"
      Case "7.19" : CEA = "53" : Case "7.20" : CEA = "54" : Case "8.2" : CEA = "55" : Case "8.3" : CEA = "56"
      Case "8.4" : CEA = "57" : Case "10.6" : CEA = "58" : Case "10.7" : CEA = "59" : Case "10.8" : CEA = "60"
      Case "10.9" : CEA = "61" : Case "10.10" : CEA = "62" : Case "10.11" : CEA = "63" : Case "10.12" : CEA = "64"
      Case "10.13" : CEA = "65" : Case "10.14" : CEA = "66" : Case "10.15" : CEA = "67" : Case "10.16" : CEA = "68"
      Case "10.17" : CEA = "69" : Case "10.18" : CEA = "70" : Case "10.19" : CEA = "71" : Case "8.6" : CEA = "72"
      Case "8.7" : CEA = "73" : Case "8.8" : CEA = "74" : Case "8.9" : CEA = "75" : Case "8.10" : CEA = "76"
      Case "8.11" : CEA = "77" : Case "8.12" : CEA = "78" : Case "8.13" : CEA = "79" : Case "8.14" : CEA = "80"
      Case "8.15" : CEA = "81" : Case "8.16" : CEA = "82" : Case "8.17" : CEA = "83" : Case "8.18" : CEA = "84"
      Case "8.19" : CEA = "85" : Case "8.20" : CEA = "86" : Case "9.2" : CEA = "87" : Case "9.3" : CEA = "88"
      Case "9.4" : CEA = "89" : Case "11.6" : CEA = "90" : Case "11.7" : CEA = "91" : Case "11.8" : CEA = "92"
      Case "11.9" : CEA = "93" : Case "11.10" : CEA = "94" : Case "11.11" : CEA = "95" : Case "11.12" : CEA = "96"
      Case "11.13" : CEA = "97" : Case "11.14" : CEA = "98" : Case "11.15" : CEA = "99" : Case "11.16" : CEA = "100"
      Case "11.17" : CEA = "101" : Case "11.18" : CEA = "102" : Case "11.19" : CEA = "103" : Case "9.6" : CEA = "104"
      Case "9.7" : CEA = "105" : Case "9.8" : CEA = "106" : Case "9.9" : CEA = "107" : Case "9.10" : CEA = "108"
      Case "9.11" : CEA = "109" : Case "9.12" : CEA = "110" : Case "9.13" : CEA = "111" : Case "9.14" : CEA = "112"
      Case "9.15" : CEA = "113" : Case "9.16" : CEA = "114" : Case "9.17" : CEA = "115" : Case "9.18" : CEA = "116"
      Case "9.19" : CEA = "117" : Case "9.20" : CEA = "118" : Case Else : CEA = 0 : End Select : CABC()
  End Sub
  Private Sub CABB()
    ' Die Auswahl des chemischen Elements von der Liste
    CEA = CStr(EB_.SelectedIndex + 1) : CABC()
  End Sub
  Private Sub CABC()
    ' Das Laden des chemischen Elements
    B401.Background = New SolidColorBrush(ACAB(CInt(ACAC(CInt(CEA) - 1)))) : B400.Visibility = 0
    CA_.Background = B401.Background : Select Case ACAC(CInt(CEA) - 1) : Case 0, 2, 8
        B401.Foreground = New SolidColorBrush(Colors.White) : End Select : B300.Visibility = 1
    AAB = 6
    CEA = If(CByte(CEA) < 10, "00", If(CByte(CEA) < 100, "0", "")) & CEA : EB_.Visibility = 1
    FB_.Text = A_B.GetString("A" & CEA) : FA_.Text = (A_A.GetString("B" & CEA) & "          ").
      Substring(0, 10) & A_D.GetString("B" & CEA) : If B400.RowDefinitions.Count > 0 Then Exit Sub

    Dim aaaaa As New Grid : Dim aaaab As TextBlock : Dim aaaac As New GridLength(7, 2)
    B400.ColumnDefinitions.Add(New ColumnDefinition) : B400.RowDefinitions.Add(New RowDefinition)
    B400.ColumnDefinitions.Add(New ColumnDefinition) : B400.RowDefinitions.Add(New RowDefinition)
    B400.ColumnDefinitions.Add(New ColumnDefinition) : B400.RowDefinitions.Add(New RowDefinition)
    aaaaa.ColumnDefinitions.Add(New ColumnDefinition) : aaaaa.RowDefinitions.Add(New RowDefinition)
    aaaaa.ColumnDefinitions.Add(New ColumnDefinition) : aaaaa.RowDefinitions.Add(New RowDefinition)
    aaaaa.ColumnDefinitions.Add(New ColumnDefinition) : aaaaa.RowDefinitions.Add(New RowDefinition)

    B400.RowDefinitions.Item(1).Height = aaaac : B400.ColumnDefinitions.Item(1).Width = aaaac
    aaaaa.RowDefinitions.Item(2).Height = aaaac : aaaaa.ColumnDefinitions.Item(0).Width = aaaac
    aaaaa.ColumnDefinitions.Item(2).Width = New GridLength(2, 2) : FA_.FontSize = 16
    B401.Content = aaaaa : FB_.FontSize = 16

    aaaaa.Children.Add(FA_) : Grid.SetRow(FA_, 0) : Grid.SetColumn(FA_, 0)
    aaaaa.Children.Add(FB_) : Grid.SetRow(FB_, 2) : Grid.SetColumn(FB_, 2) : Grid.SetRow(B400, 2)
    aaaab = New TextBlock With {.MinWidth = 50, .MinHeight = 20, .IsTextSelectionEnabled = False}
    aaaaa.Children.Add(aaaab) : Grid.SetRow(aaaab, 1) : Grid.SetColumn(aaaab, 1) : Grid.SetColumn(B401, 1)
    aaaab = New TextBlock With {.IsTextSelectionEnabled = False, .Text = A_E.GetString("A003"),
      .FontSize = 16}
    aaaaa.Children.Add(aaaab) : Grid.SetRow(aaaab, 2) : Grid.SetColumn(aaaab, 0) : Grid.SetRow(B401, 1)
  End Sub
  Private Sub CABD()
    ' Die Abwahl des chemischen Elements
    B400.Visibility = 1 : AAB = 5
    If AAA = 1 Then : B300.Visibility = 0 : EB_.Visibility = 1 : If B300.Children.Count = 0 Then CAAA()
    Else : B300.Visibility = 1 : EB_.Visibility = 0 : If EB_.Items.Count = 0 Then : CAAB() : End If : End If
  End Sub
#End Region
#End Region
#Region "DDDD"

#End Region
#Region "EEEE"

#End Region
#End Region
End Class
#End Region