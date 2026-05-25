#Region ""
'بِسْمِ اللَّهِ الرَّحْمَـٰنِ الرَّحِيمِ
#End Region
#Region ""
Imports Windows.Storage
'Imports Windows.UI.Xaml
Imports Windows.UI.Xaml.Shapes
Imports Windows.UI.Xaml.Media
Imports Windows.UI.ViewManagement
Imports Windows.ApplicationModel.Core
'Imports Windows.UI.Xaml.Controls
Imports Windows.UI.Xaml.Documents
Imports Windows.Networking.Connectivity
Imports Windows.ApplicationModel.Email
Imports Windows.ApplicationModel.Resources
Imports Windows.UI ' : Imports Windows.UI.Text
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
  'Private AA_ As New Line ' Text Kursor in FB_
  Private BԳ_ As New Button ' Chemisches Element
  Private CA_ As New Canvas ' AA01 Rows Canvas
  Private CԳ_ As New Canvas ' Canvas 1 in Ξ102
  Private DA_ As New TextBox ' Übersetzung FB_
  Private EB_ As New ListView ' Chemische Liste
  Private FA_ As New TextBlock ' Allgemeiner TB
  Private FB_ As New TextBlock ' Eingabe Block
  Private FC_ As New TextBlock ' Periodentabelle
  Private FD_ As New TextBlock ' Periodentabelle
  Private Ϟ101 As New TextBlock
  Private Ϟ102 As New TextBlock
  'Private SA_ As New ScrollViewer
  'Private SB_ As New ScrollViewer
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
  Private AAA As Byte ' Quer-Hochformat Nummer
  Private AAB As Byte ' Design Seiten Nummer
  Private AAC As Byte ' A Board Umschalte Zahl
  Private AAD As Byte ' B Board Umschalte Zahl
  Private AAE As Byte ' Farben Nummer für ACAB
  Private AAF As Byte ' Farben Nummer für ACAB
  Private AAG As Byte ' Farben Nummer für ACAB
  Private AAI As Byte ' Quer-Hochformat-Design
  Private AAJ As Integer ' Dimension-Tabelle-Zahl
  Private AAK As Integer ' Dimension-Tabelle-Zahl
  Private AGA As String ' Allgemeiner Substring
  Private AΞA As DispatcherTimer ' Kursor Ξ101
#End Region
#Region "A-12"
  ' Mathematik
  Private BGA As String ' Übersetzung von DB_
  Private BHA As Boolean ' Eingabe Feld Auswahl

  Dim _AA As String
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
  Dim _EF As New Color

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
#End Region
#Region "A-14"
  ' Physik
  Private DGA As String ' Gesuchte Dimension
  Private DGB As String ' Gesuchte Dimension
  Private DGC As String ' Mehrzwecks String
  Private DՃA() As String ' Dimensions-Liste
  Private DՃB() As String ' Dimensions-Split
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
#Region "A_10"
  Private Sub A_A_() Handles AAA0.Loaded
    Try
      For i = 1 To 2 Step 1 : AA00.RowDefinitions.Add(New RowDefinition) : Next
      For i = 1 To 4 Step 1 : AԹ01.ColumnDefinitions.Add(New ColumnDefinition) : Next
      For i = 1 To 5 Step 1 : AA01.RowDefinitions.Add(New RowDefinition) : Next
      For i = 1 To 12 Step 1 : A100.ColumnDefinitions.Add(New ColumnDefinition) : Next
      For i = 1 To 4 Step 1 : C100.RowDefinitions.Add(New RowDefinition) : Next
      For i = 1 To 21 Step 1 : C100.ColumnDefinitions.Add(New ColumnDefinition) : Next
      For i = 1 To 12 Step 1 : Ξ101.RowDefinitions.Add(New RowDefinition) : Next
      For i = 1 To 15 Step 1 : Ξ101.ColumnDefinitions.Add(New ColumnDefinition) : Next
      For i = 1 To 50 Step 1 : Ξ102.RowDefinitions.Add(New RowDefinition) : Next
      For i = 1 To 6 Step 1 : Ξ102.ColumnDefinitions.Add(New ColumnDefinition) : Next

      AA01.Children.Add(CA_) : AA01.Children.Add(DA_) : Ξ102.Children.Add(CԳ_) : CԳ_.Children.Add(Ϟ101)

      AA00.RowDefinitions.Item(0).Height = New GridLength(32, 1)
      AԹ01.ColumnDefinitions.Item(0).Width = New GridLength(46, 1)
      AԹ01.ColumnDefinitions.Item(1).Width = New GridLength(46, 1)
      AԹ01.ColumnDefinitions.Item(2).Width = New GridLength(46, 1)
      Ξ102.ColumnDefinitions.Item(0).Width = New GridLength(20, 1)
      Ξ102.ColumnDefinitions.Item(1).Width = New GridLength(20, 1)
      AԹ01.ColumnDefinitions.Item(3).Width = New GridLength(AAA0.ActualWidth - 46 * 6, 1)

      ToolTipService.SetToolTip(A101, New ToolTip With {.Content = A_D.GetString("A011")})
      ToolTipService.SetToolTip(A102, New ToolTip With {.Content = A_D.GetString("A012")})
      ToolTipService.SetToolTip(A103, New ToolTip With {.Content = A_D.GetString("A013")})
      ToolTipService.SetToolTip(A104, New ToolTip With {.Content = A_D.GetString("A014")})
      ToolTipService.SetToolTip(A105, New ToolTip With {.Content = A_D.GetString("A015")})
      ToolTipService.SetToolTip(A106, New ToolTip With {.Content = A_D.GetString("A016")})
      ToolTipService.SetToolTip(A107, New ToolTip With {.Content = A_D.GetString("A017")})
      ToolTipService.SetToolTip(A108, New ToolTip With {.Content = A_D.GetString("A018")})
      ToolTipService.SetToolTip(A109, New ToolTip With {.Content = A_D.GetString("A019")})
      ToolTipService.SetToolTip(A110, New ToolTip With {.Content = A_D.GetString("A020")})
      ToolTipService.SetToolTip(A111, New ToolTip With {.Content = A_D.GetString("A021")})

      Grid.SetRow(Թ101, 0) : Grid.SetColumn(Թ101, 0) : Grid.SetRow(Թ102, 0) : Grid.SetColumn(Թ102, 1)
      Grid.SetRow(Թ103, 0) : Grid.SetColumn(Թ103, 2) : Grid.SetRow(Թ104, 0) : Grid.SetColumn(Թ104, 3)
      Grid.SetRow(A101, 0) : Grid.SetColumn(A101, 0) : Grid.SetRow(A102, 0) : Grid.SetColumn(A102, 1)
      Grid.SetRow(A103, 0) : Grid.SetColumn(A103, 2) : Grid.SetRow(A104, 0) : Grid.SetColumn(A104, 3)
      Grid.SetRow(A105, 0) : Grid.SetColumn(A105, 4) : Grid.SetRow(A106, 0) : Grid.SetColumn(A106, 5)
      Grid.SetRow(A107, 0) : Grid.SetColumn(A107, 6) : Grid.SetRow(A108, 0) : Grid.SetColumn(A108, 7)
      Grid.SetRow(A109, 0) : Grid.SetColumn(A109, 8) : Grid.SetRow(A110, 0) : Grid.SetColumn(A110, 9)
      Grid.SetRow(A111, 0) : Grid.SetColumn(A111, 10) : Grid.SetRow(A112, 0) : Grid.SetColumn(A112, 11)

      Grid.SetRow(AԹ01, 0) : Grid.SetRow(AA01, 1) : Grid.SetRow(B100, 2) : Grid.SetRow(B200, 2)
      Grid.SetRow(B400, 2) : Grid.SetRow(B500, 2) : Grid.SetRow(B300, 2) : Grid.SetRow(C100, 4)

      Grid.SetRow(C101, 0) : Grid.SetColumn(C101, 1) : Grid.SetRow(C102, 0) : Grid.SetColumn(C102, 2)
      Grid.SetRow(C103, 0) : Grid.SetColumn(C103, 3) : Grid.SetRow(C104, 0) : Grid.SetColumn(C104, 4)
      Grid.SetRow(C105, 1) : Grid.SetColumn(C105, 1) : Grid.SetRow(C106, 1) : Grid.SetColumn(C106, 2)
      Grid.SetRow(C107, 1) : Grid.SetColumn(C107, 3) : Grid.SetRow(C108, 1) : Grid.SetColumn(C108, 4)
      Grid.SetRow(C109, 2) : Grid.SetColumn(C109, 1) : Grid.SetRow(C110, 2) : Grid.SetColumn(C110, 2)
      Grid.SetRow(C111, 2) : Grid.SetColumn(C111, 3) : Grid.SetRow(C112, 2) : Grid.SetColumn(C112, 4)
      Grid.SetRow(C113, 3) : Grid.SetColumn(C113, 1) : Grid.SetRow(C114, 3) : Grid.SetColumn(C114, 2)
      Grid.SetRow(C115, 3) : Grid.SetColumn(C115, 3) : Grid.SetRow(C116, 3) : Grid.SetColumn(C116, 4)

      Grid.SetRow(C117, 0) : Grid.SetColumn(C117, 6) : Grid.SetRow(C118, 0) : Grid.SetColumn(C118, 7)
      Grid.SetRow(C119, 0) : Grid.SetColumn(C119, 8) : Grid.SetRow(C120, 0) : Grid.SetColumn(C120, 9)
      Grid.SetRow(C121, 1) : Grid.SetColumn(C121, 6) : Grid.SetRow(C122, 1) : Grid.SetColumn(C122, 7)
      Grid.SetRow(C123, 1) : Grid.SetColumn(C123, 8) : Grid.SetRow(C124, 1) : Grid.SetColumn(C124, 9)
      Grid.SetRow(C125, 2) : Grid.SetColumn(C125, 6) : Grid.SetRow(C126, 2) : Grid.SetColumn(C126, 7)
      Grid.SetRow(C127, 2) : Grid.SetColumn(C127, 8) : Grid.SetRow(C128, 2) : Grid.SetColumn(C128, 9)
      Grid.SetRow(C129, 3) : Grid.SetColumn(C129, 6) : Grid.SetRow(C130, 3) : Grid.SetColumn(C130, 7)
      Grid.SetRow(C131, 3) : Grid.SetColumn(C131, 8) : Grid.SetRow(C132, 3) : Grid.SetColumn(C132, 9)

      Grid.SetRow(C133, 0) : Grid.SetColumn(C133, 11) : Grid.SetRow(C134, 0) : Grid.SetColumn(C134, 12)
      Grid.SetRow(C135, 0) : Grid.SetColumn(C135, 13) : Grid.SetRow(C136, 0) : Grid.SetColumn(C136, 14)
      Grid.SetRow(C137, 1) : Grid.SetColumn(C137, 11) : Grid.SetRow(C138, 1) : Grid.SetColumn(C138, 12)
      Grid.SetRow(C139, 1) : Grid.SetColumn(C139, 13) : Grid.SetRow(C140, 1) : Grid.SetColumn(C140, 14)
      Grid.SetRow(C141, 2) : Grid.SetColumn(C141, 11) : Grid.SetRow(C142, 2) : Grid.SetColumn(C142, 12)
      Grid.SetRow(C143, 2) : Grid.SetColumn(C143, 13) : Grid.SetRow(C144, 2) : Grid.SetColumn(C144, 14)
      Grid.SetRow(C145, 3) : Grid.SetColumn(C145, 11) : Grid.SetRow(C146, 3) : Grid.SetColumn(C146, 12)
      Grid.SetRow(C147, 3) : Grid.SetColumn(C147, 13) : Grid.SetRow(C148, 3) : Grid.SetColumn(C148, 14)

      Grid.SetRow(C149, 0) : Grid.SetColumn(C149, 16) : Grid.SetRow(C150, 0) : Grid.SetColumn(C150, 17)
      Grid.SetRow(C151, 0) : Grid.SetColumn(C151, 18) : Grid.SetRow(C152, 0) : Grid.SetColumn(C152, 19)
      Grid.SetRow(C153, 1) : Grid.SetColumn(C153, 16) : Grid.SetRow(C154, 1) : Grid.SetColumn(C154, 17)
      Grid.SetRow(C155, 1) : Grid.SetColumn(C155, 18) : Grid.SetRow(C156, 1) : Grid.SetColumn(C156, 19)
      Grid.SetRow(C157, 2) : Grid.SetColumn(C157, 16) : Grid.SetRow(C158, 2) : Grid.SetColumn(C158, 17)
      Grid.SetRow(C159, 2) : Grid.SetColumn(C159, 18) : Grid.SetRow(C160, 2) : Grid.SetColumn(C160, 19)
      Grid.SetRow(C161, 3) : Grid.SetColumn(C161, 16) : Grid.SetRow(C162, 3) : Grid.SetColumn(C162, 17)
      Grid.SetRow(C163, 3) : Grid.SetColumn(C163, 18) : Grid.SetRow(C164, 3) : Grid.SetColumn(C164, 19)

      AΞA = New DispatcherTimer With {.Interval = TimeSpan.FromMilliseconds(500)}

      'If ApplicationData.Current.LocalSettings.Values("upgrade") <> "18.02.2022" Then
      '  Ϟ102.FontFamily = New FontFamily("Segoe UI") : Ϟ102.Text = A_D.GetString("A900")
      'End If

      B101.Margin = New Thickness(10, 0, 10, 0) : B102.Margin = New Thickness(5, -25, 5, 2)
      Հ101.Margin = New Thickness(15, 5, 15, 7) : Հ102.Margin = New Thickness(15, 5, 15, 7)
      Հ103.Margin = New Thickness(15, 5, 15, 7)

      AddHandler Հ102.Tapped, AddressOf B_ՀA : AddHandler DA_.SelectionChanged, AddressOf B_ΞA
      AddHandler AΞA.Tick, AddressOf B_ϞA : AddHandler B101.SelectionChanged, AddressOf Թ_AB
      AddHandler DA_.TextChanged, AddressOf B_ΔA

      Dim aa = CoreApplication.GetCurrentView().TitleBar : aa.ExtendViewIntoTitleBar = True
      Dim ab = ApplicationView.GetForCurrentView().TitleBar : Window.Current.SetTitleBar(Թ104)
      Dim ac = ApplicationView.GetForCurrentView().TitleBar ' !!! Reihenfolge !!!
      ac.ButtonPressedForegroundColor = Colors.Pink : ac.ButtonHoverForegroundColor = Colors.Pink

      DA_.MaxHeight = 0 : DA_.MaxWidth = 0 : DA_.AcceptsReturn = True : DA_.TextWrapping = TextWrapping.Wrap

      B101.Visibility = 1 : B511.Visibility = 1 : B513.Visibility = 1 : Հ101.Visibility = 1 : Հ103.Visibility = 1

      A111.Content = "A1" : A112.Content = "B1" : C126.Content = A_D.GetString("A254") : Թ103.Content = "⛭"
      Թ102.Icon = New FontIcon With {.Glyph = ChrW(&HE80F), .FontFamily = New FontFamily("Segoe MDL2 Assets")}

      _EA = Color.FromArgb(170, 170, 170, 170) : _EB = Colors.Blue : _EC = Colors.Magenta : _ED = Colors.DeepSkyBlue
      _EE = Color.FromArgb(255, 0, 255, 120) : _EF = Colors.Orange : _GA = New Color() {_EA, _EB, _EC, _ED, _EE, _EF}

      DA_.Focus(3) : BՆԹ.Add(0) : BՆԸ.Add(0) : AAB = 1 : AAFC() : AAFB() : A_B_()
    Catch ex As Exception : End Try ' Ϟ102.Text = ex.Message
  End Sub
  Private Sub A_B_() Handles AAA0.SizeChanged
    Try : If AAA0.ActualWidth > 1.5 * AAA0.ActualHeight Then
        If AAA <> 1 Then : AAA = 1 : End If : AAAA() : Else
        If AAA <> 2 Then : AAA = 2 : End If : AAAA() : End If
    Catch ex As Exception : End Try '  : Ϟ102.Text = ex.Message
  End Sub
#End Region
#Region "Թ_10"
  Private Sub Թ_A_()
    Select Case AAB
      Case 1, 7 ' Anhang
        AAB = 2 : ToolTipService.SetToolTip(Թ102, New ToolTip With {.Content = A_D.GetString("A002")}) : AAAA()
        Թ102.Icon = New FontIcon With {.Glyph = ChrW(&HE8A9), .FontFamily = New FontFamily("Segoe MDL2 Assets")}
      Case Else ' Home ' Segoe MDL2 Assets ' Segoe Fluent Icons
        AAB = 1 : ToolTipService.SetToolTip(Թ102, New ToolTip With {.Content = A_D.GetString("A001")}) : AAAA()
        Թ102.Icon = New FontIcon With {.Glyph = ChrW(&HE80F), .FontFamily = New FontFamily("Segoe MDL2 Assets")}
    End Select
  End Sub
  Private Sub Թ_B_()
    ABBC()
  End Sub
#End Region
#Region "A100"
  Private Sub A_AA()
    ' Dimensionen-Buttons Erstellen ! Reihenfolge !
    If Ξ101.Children.Count = 0 Then
      Dim eaaaa As New Button ' : Dim eaaab As TextBlock
      For i = 1 To 87 Step 1 : AGA = "B" & If(i < 10, "00", If(i < 100, "0", "")) & CStr(i)
        'eaaab = New TextBlock With {.Text = A_C.GetString(AGA),
        '.Foreground = New SolidColorBrush(Colors.Black), .IsTextSelectionEnabled = False}
        eaaaa = New Button With {.Background = New SolidColorBrush(Colors.AliceBlue),
        .Padding = New Thickness(0), .HorizontalContentAlignment = 1, .Content = A_C.GetString(AGA),
        .Margin = New Thickness(2)}
        Ξ101.Children.Add(eaaaa) : AddHandler eaaaa.Click, AddressOf Թ_AA : Next : End If
    ' Dimensionen-Buttons Verstellen ! Reihenfolge !
    If AAB = 7 Then
      Հ101.Visibility = 1 : Հ102.Visibility = 0 : Հ103.Visibility = 1 : AAB = 1
    Else
      B101.Visibility = 1 : Հ101.Visibility = 0 : Հ102.Visibility = 1 : AAB = 7
      Հ103.Visibility = 1 : AAAA() : End If

    'Dim aa As DispatcherTimer
    'aa = New DispatcherTimer With {.Interval = TimeSpan.FromMilliseconds(500)}
    'AddHandler aa.Tick, AddressOf B_ϞA
    'aa.Start()
  End Sub
  Private Sub A_AB()
  End Sub
  Private Sub A_AC()
  End Sub
  Private Sub A_AD()
    BAAA() ' : A_AF()
    CA_.Background = New SolidColorBrush(ACAB(AAE))
  End Sub
  Private Sub A_AE()

    CA_.Background = New SolidColorBrush(ACAB(AAE))
  End Sub
  Private Sub A_AF()
    Try : AAB = 1 : AAAA() : If CA = "" Then Exit Sub
      Ϟ102.Text = "" : Ϟ102.FontFamily = New FontFamily("Consolas")

      If A105.Background.ToString() = New SolidColorBrush(Colors.Lime).ToString() Then
        A105.Background = New SolidColorBrush(Colors.Pink)

        Ξ102.Children.Add(New Button With {.Width = 15, .Height = 15, .Background = New SolidColorBrush(Colors.Pink)})

        For i = 0 To 3 Step 1 ' KA.Count - 1
          Ϟ102.Inlines.Add(New Run With {.Text = KA(i).Replace(_AB, _AC) & vbCrLf,
                     .Foreground = New SolidColorBrush(Colors.Blue)})
          Ϟ102.Inlines.Add(New Run With {.Text = KB(i) & vbCrLf & vbCrLf,
                           .Foreground = New SolidColorBrush(Colors.SkyBlue)})
        Next
      ElseIf A105.Background.ToString() = New SolidColorBrush(Colors.Pink).ToString() Then
        A105.Background = New SolidColorBrush(Colors.Lime)

        '  B005.Foreground = New SolidColorBrush(Colors.Violet)
        '  For j = 0 To KL.Count - 1 Step 1
        '    AIAZ() : AIAE(JC(j)) : C004.Document.Selection.Text += KL(j)
        '  Next
        '  A_E.Content = NAD.GetString("A005")

      End If
    Catch ex As Exception : End Try
  End Sub
  Private Sub A_AG()

    CA_.Background = New SolidColorBrush(ACAB(AAE))
  End Sub
  Private Sub A_AH()

    CA_.Background = New SolidColorBrush(ACAB(AAE))
  End Sub
  Private Sub A_AI()

    CA_.Background = New SolidColorBrush(ACAB(AAE))
  End Sub
  Private Sub A_AJ()
    AAEA()
  End Sub
  Private Sub A_AK()
    AAEA()
  End Sub
  Private Sub A_AL()
    AAEB()
  End Sub
#End Region
#Region "B100"
  Private Sub B_ՀA(a As Object, b As TappedRoutedEventArgs)
    BJC = Math.Ceiling((b.GetPosition(CԳ_).X) / 10)
    BJB = Math.Ceiling((b.GetPosition(CԳ_).Y) / 32.8)
    BJA = DA_.Text.Length : BJB -= 1
    For i = 0 To BՆԹ.Count - 2 Step 1
      If BՆԹ(i) = BJC And BՆԸ(i) = BJB Then BJA = i : Exit For
    Next : B_ՀB()
  End Sub
  Private Sub B_ՀB()
    Try : DA_.Focus(3) : DA_.SelectionLength = 0
      Ϟ101.Visibility = 0 : AΞA.Start() : DA_.SelectionStart = BJA
      Ϟ101.Margin = New Thickness(BՆԹ(BJA) * 10 - 5, BՆԸ(BJA) * 32.8, 0, 0)
      If DA_.Text = "" Then : Ϟ101.Text = "💎" : Exit Sub
      Else : Ϟ101.Text = "|" : End If
    Catch ex As Exception : Ϟ102.Text = "B_ՀA: " & ex.Message
    End Try ' A_D.GetString("A201") & ☘️💎🔆🏵️🍁
  End Sub
  Private Sub B_ϞA()
    ' Kursor-1-Blinken AA_
    Select Case Ϟ101.Visibility : Case 0 : Ϟ101.Visibility = 1 : Case 1 : Ϟ101.Visibility = 0 : End Select
  End Sub
  Private Sub B_ΞA()
    Try : BJA = DA_.SelectionStart
      ' Farben Korrektur
      For i = 0 To CԳ_.Children.Count - 2 Step 1
        ACAF(CԳ_.Children(i)).Foreground = New SolidColorBrush(ACAB(AAG))
      Next
      ' Farben Selection
      For i = BJA To BJA + DA_.SelectionLength - 1 Step 1
        ACAF(CԳ_.Children(i)).Foreground = New SolidColorBrush(Colors.SkyBlue)
      Next
      ' Kursor Visibility
      If DA_.SelectionLength = 0 Then : AΞA.Start()
        Ϟ101.Visibility = 0
      Else : AΞA.Stop() : Ϟ101.Visibility = 1 : End If
      ' Kursor Position
      Ϟ101.Margin = New Thickness(BՆԹ(BJA) * 10 - 5, BՆԸ(BJA) * 32.8, 0, 0)
      'Ϟ101.Text = "      " & CStr(BJA) & " " & CStr(BJB) & " " & CStr(BJC)
      ' Exception Message
    Catch ex As Exception : Ϟ102.Text = "B_ΞA: " & ex.Message
    End Try
  End Sub
  Private Sub B_ΔA()
    Try : BJE = DA_.Text.Length : DA_.MaxWidth = 500 : DA_.MaxHeight = 100
      ' Elemente Bearbeitung
      Select Case BJE - BJD
        Case > 0 ' wenn der Text größer geworden ist: a(bc|d
          ' Einstellungen BJB, BJC
          BJB = BՆԸ(BJA + BJD - BJE) : BJC = BՆԹ(BJA + BJD - BJE)
          ' Elemente Insert
          For i = BJA + BJD - BJE To BJA - 1 Step 1

            Select Case DA_.Text.Substring(i, 1)
              Case vbCr : AGA = "" : Case vbLf : AGA = "" : Case vbCrLf : AGA = ""
              Case Else : AGA = DA_.Text.Substring(i, 1) : End Select

            BՆԹ.Insert(i, 0) : BՆԸ.Insert(i, 0)

            CԳ_.Children.Insert(i, New TextBlock With {.Text = AGA,
                              .Foreground = New SolidColorBrush(ACAB(AAG))})
          Next
          ' Elemente Positionen
          For i = BJA + BJD - BJE To CԳ_.Children.Count - 1 Step 1
            ' Positionen Kursor in BՆԹ, BՆԸ
            BՆԹ(i) = BJC : BՆԸ(i) = BJB
            ' Positionen einschlißlich Kursor
            ACAF(CԳ_.Children(i)).Margin = New Thickness(BՆԹ(i) * 10, BՆԸ(i) * 32.8, 0, 0)
            ' Einstellungen BJB, BJC ! Reihenfolge !
            If ACAF(CԳ_.Children(i)).Text = "" Then BJC = 0 : BJB += 1 Else BJC += 1
            ' Rückstellung BJC für Kursor 
            If i = CԳ_.Children.Count - 1 Then : BJC -= 1 : End If : Next
        Case < 0 ' wenn der Text kleiner geworden ist: a|bc)d
          ' Einstellungen BJB, BJC
          BJB = BՆԸ(BJA) : BJC = BՆԹ(BJA)
          ' Elemente Remove
          For i = BJA To BJA + BJD - BJE - 1 Step 1
            CԳ_.Children.RemoveAt(BJA) : BՆԹ.RemoveAt(BJA) : BՆԸ.RemoveAt(BJA) : Next
          ' Positionen Korrektur
          For i = BJA To CԳ_.Children.Count - 1 Step 1
            ' Positionen Kursor in BՆԹ, BՆԸ
            BՆԸ(i) = BJB : BՆԹ(i) = BJC
            ' Positionen einschlißlich Kursor
            ACAF(CԳ_.Children(i)).Margin = New Thickness(BՆԹ(i) * 10, BՆԸ(i) * 32.8, 0, 0)
            ' Einstellungen BJB, BJC ! Reihenfolge !
            If ACAF(CԳ_.Children(i)).Text = "" Then BJC = 0 : BJB += 1 Else BJC += 1
            ' Rückstellung BJC für Kursor 
            If i = CԳ_.Children.Count - 1 Then : BJC -= 1 : End If
          Next
          'Case = 0 ' wenn der Text gleich groß geblieben ist: abcd
      End Select
      ' Kursor Position
      Ϟ101.Margin = New Thickness(BՆԹ(BJA) * 10 - 5, BՆԸ(BJA) * 32.8, 0, 0)
      ' Kursor Zeichen
      Ϟ101.Text = If(DA_.Text = "", "💎", "|") : BJD = BJE
    Catch ex As Exception : End Try
  End Sub
  Private Sub B_ΔB()
    Try ' DB_ Eingabe: TextChanged
      'BJE = DB_.Text.Length
      '' Eignung zur TextBox Eigenschaften
      'If BHA = True Then DB_.Focus(3) : BJA = BJC + BJE - BJF : DB_.SelectionStart = BJA : BHA = False
      ' CLASSIC
      If ApplicationData.Current.LocalSettings.Values("textstyle") = "" Then
        ' wenn der Text kleiner geworden ist: ' a|bc)d
        If BJE - BJF < 0 Then
          For i = BJA + BJF - BJE - 1 To BJA Step -1 : Ξ102.Children.RemoveAt(i) : Next
          For i = BJA To Ξ102.Children.Count - 3 Step 1 : ACAF(Ξ102.Children(i)).Margin = New Thickness(i * 10, 0, 0, 0)
          Next : End If
        ' wenn der Text größer geworden ist: ' a(bc|d
        If BJE - BJF > 0 Then
          'For i = BJA + BJF - BJE To BJA - 1 Step 1 : Ξ102.Children.Insert(i, New TextBlock With
          '                     {.Text = DB_.Text.Substring(i, 1), .Foreground = New SolidColorBrush(ACAB(AAG))}) : Next
          For i = BJA + BJF - BJE To Ξ102.Children.Count - 3 Step 1
            ACAF(Ξ102.Children(i)).Margin = New Thickness(i * 10, 0, 0, 0) : Next : End If
      End If
      ' MATHPRINT
      If ApplicationData.Current.LocalSettings.Values("textstyle") = "." Then
        BBAB()

      End If
      'BJF = BJE : If DB_.Text = "" Then Ϟ102.Text = A_D.GetString("A202") : Exit Sub Else Ϟ102.Text = ""
    Catch ex As Exception : Ϟ102.Text = "B_ΔB: " & ex.Message : End Try
  End Sub
#End Region
#Region "B200"
  Private Sub B_BA()
    ApplicationData.Current.LocalSettings.Values("upgrade") = "xxxx"
    Ϟ102.FontFamily = New FontFamily("Segoe UI") : AAB = 3 : AAAA()
    Ξ102.Children.Clear() : Ξ102.Children.Add(Ϟ102) : Ϟ102.Text = ""
    Ϟ102.Inlines.Add(New Run With {.Text = A_D.GetString("A000") & vbLf,
                     .Foreground = New SolidColorBrush(Colors.Blue)})
    Ϟ102.Inlines.Add(New Run With {.Text = vbLf & A_E.GetString("A001") &
                     vbLf & vbLf,
                     .Foreground = New SolidColorBrush(Colors.Black)})
    Ϟ102.Inlines.Add(New Run With {.Text = A_D.GetString("E001") & vbLf,
                     .Foreground = New SolidColorBrush(Colors.Lime)})
    Ϟ102.Inlines.Add(New Run With {.Text = vbLf & A_E.GetString("A002"),
                     .Foreground = New SolidColorBrush(Colors.Black)})
  End Sub
  Private Sub B_BB()
    Ϟ102.FontFamily = New FontFamily("Consolas") : AAB = 3 : AAAA()
    Ξ102.Children.Clear() : Ξ102.Children.Add(Ϟ102) : Ϟ102.Text = ""

    Dim aa() As String : aa = New String() {
    A_D.GetString("E002"), A_D.GetString("E201"), A_D.GetString("E202"),
    "a", "b", "a ^ b", "b", "√a", "√(a ' b)", "log", "a", "b", "log(a ' b)",
    "lim", "a", "b", "lim(a ' b)", "Ʃ", "a", "b", "c", "Ʃ(a ' b ' c)", "∏",
    "a", "b", "c", "∏(a ' b ' c)", "a", "∫", "b", "x dx", "∫(a ' b ' x d(x))"
    }
    Dim ab() As Thickness : ab = New Thickness() {New Thickness(30, 0, 0, 0),
    New Thickness(30, 50, 0, 0),
    New Thickness(200, 50, 0, 0), New Thickness(30, 100, 0, 0), New Thickness(38, 97, 0, 0),
    New Thickness(200, 100, 0, 0), New Thickness(30, 147, 0, 0), New Thickness(37, 150, 0, 0),
    New Thickness(200, 150, 0, 0), New Thickness(30, 200, 0, 0), New Thickness(55, 205, 0, 0),
    New Thickness(62, 200, 0, 0), New Thickness(200, 200, 0, 0), New Thickness(30, 250, 0, 0),
    New Thickness(55, 255, 0, 0), New Thickness(62, 250, 0, 0), New Thickness(200, 250, 0, 0),
    New Thickness(30, 300, 0, 0), New Thickness(39, 307, 0, 0), New Thickness(39, 295, 0, 0),
    New Thickness(45, 300, 0, 0), New Thickness(200, 300, 0, 0), New Thickness(30, 350, 0, 0),
    New Thickness(39, 357, 0, 0), New Thickness(39, 345, 0, 0), New Thickness(45, 350, 0, 0),
    New Thickness(200, 350, 0, 0), New Thickness(30, 407, 0, 0), New Thickness(37, 400, 0, 0),
    New Thickness(46, 395, 0, 0), New Thickness(52, 400, 0, 0), New Thickness(200, 400, 0, 0)}

    Ξ102.Children.Add(New Canvas With {.Margin = New Thickness(0, -3, 0, 0),
                      .Background = New SolidColorBrush(Colors.AliceBlue), .Width = 350, .Height = 25})
    Ξ102.Children.Add(New Canvas With {.Margin = New Thickness(0, 47, 0, 0),
                      .Background = New SolidColorBrush(Colors.AliceBlue), .Width = 350, .Height = 25})
    Ξ102.Children.Add(New Canvas With {.Margin = New Thickness(0, 97, 0, 0),
                      .Background = New SolidColorBrush(Colors.AliceBlue), .Width = 350, .Height = 25})
    Ξ102.Children.Add(New Canvas With {.Margin = New Thickness(0, 147, 0, 0),
                      .Background = New SolidColorBrush(Colors.AliceBlue), .Width = 350, .Height = 25})
    Ξ102.Children.Add(New Canvas With {.Margin = New Thickness(0, 197, 0, 0),
                      .Background = New SolidColorBrush(Colors.AliceBlue), .Width = 350, .Height = 25})
    Ξ102.Children.Add(New Canvas With {.Margin = New Thickness(0, 247, 0, 0),
                      .Background = New SolidColorBrush(Colors.AliceBlue), .Width = 350, .Height = 25})
    Ξ102.Children.Add(New Canvas With {.Margin = New Thickness(0, 297, 0, 0),
                      .Background = New SolidColorBrush(Colors.AliceBlue), .Width = 350, .Height = 25})
    Ξ102.Children.Add(New Canvas With {.Margin = New Thickness(0, 347, 0, 0),
                      .Background = New SolidColorBrush(Colors.AliceBlue), .Width = 350, .Height = 25})
    Ξ102.Children.Add(New Canvas With {.Margin = New Thickness(0, 397, 0, 0),
                      .Background = New SolidColorBrush(Colors.AliceBlue), .Width = 350, .Height = 25})

    For i = 0 To 31 Step 1
      Ξ102.Children.Add(New TextBlock With {.Text = aa(i), .Margin = ab(i),
                      .Foreground = New SolidColorBrush(Colors.Blue)}) : Next ' ACAB(AAG)

  End Sub
  Private Sub B_BC()

    AAB = 4 : AAAA() : Ξ102.Children.Clear() : Ξ102.Children.Add(Ϟ102) : Ϟ102.Text = ""
    Ϟ102.Inlines.Add(New Run With {.Text = A_D.GetString("A300") & vbLf,
                     .Foreground = New SolidColorBrush(Colors.Blue)})
    Ϟ102.Inlines.Add(New Run With {.Text = vbLf & A_E.GetString("A003") &
                     vbLf & vbLf,
                     .Foreground = New SolidColorBrush(Colors.Black)})
    Ϟ102.Inlines.Add(New Run With {.Text = A_D.GetString("E301") & vbLf,
                     .Foreground = New SolidColorBrush(Colors.Lime)})
    Ϟ102.Inlines.Add(New Run With {.Text = vbLf & A_E.GetString("A004"),
                     .Foreground = New SolidColorBrush(Colors.Black)})

  End Sub
  Private Sub B_BD()
    AAB = 7 : B500.Visibility = 0 : B100.Visibility = 1 : B200.Visibility = 1 ' : AAFA()

    If B500.RowDefinitions.Count > 0 Then : Exit Sub : End If : Grid.SetRow(B500, 2)

    'If ApplicationData.Current.LocalSettings.Values("textstyle") = "m" Then B511.IsOn = True
    If ApplicationData.Current.LocalSettings.Values("rectangle") = "i" Then B512.IsOn = True
    'If ApplicationData.Current.LocalSettings.Values("lightness") = "l" Then B513.IsOn = True

    'B511.OffContent = A_D.GetString("E202") : B511.OnContent = A_D.GetString("E201")
    B512.OffContent = A_D.GetString("E251") : B512.OnContent = A_D.GetString("E252")
    'B513.OffContent = A_D.GetString("A004") : B513.OnContent = A_D.GetString("A003")

    B500.RowDefinitions.Add(New RowDefinition) : B500.RowDefinitions.Add(New RowDefinition)
    B500.RowDefinitions.Add(New RowDefinition) : B500.RowDefinitions.Add(New RowDefinition)
    B500.RowDefinitions.Add(New RowDefinition) : B500.RowDefinitions.Add(New RowDefinition)
    B500.RowDefinitions.Add(New RowDefinition) : B500.RowDefinitions.Add(New RowDefinition)

    B500.ColumnDefinitions.Add(New ColumnDefinition) : B500.ColumnDefinitions.Add(New ColumnDefinition)
    B500.ColumnDefinitions.Add(New ColumnDefinition) : B500.RowDefinitions.Add(New RowDefinition)

    Grid.SetRow(B512, 1) : Grid.SetColumn(B512, 1)
    'Grid.SetRow(B511, 0) : Grid.SetColumn(B511, 1) : Grid.SetRow(B513, 2) : Grid.SetColumn(B513, 1)
    Grid.SetRow(B501, 3) : Grid.SetColumn(B501, 1) : Grid.SetRow(B502, 4) : Grid.SetColumn(B502, 1)
    Grid.SetRow(B503, 5) : Grid.SetColumn(B503, 1) : Grid.SetRow(B504, 6) : Grid.SetColumn(B504, 1)
    Grid.SetRow(B505, 7) : Grid.SetColumn(B505, 1) : Grid.SetRow(B506, 8) : Grid.SetColumn(B506, 1)

    B500.ColumnDefinitions.Item(0).Width = New GridLength(0.2, 2)

    B501.Margin = New Thickness(10) : B502.Margin = New Thickness(10) : B503.Margin = New Thickness(10)
    B504.Margin = New Thickness(10) : B505.Margin = New Thickness(10) : B506.Margin = New Thickness(10)
    B512.Margin = New Thickness(10) ' : B511.Margin = New Thickness(10) : B513.Margin = New Thickness(10)

    B506.Background = New SolidColorBrush(Colors.Blue) : B502.Background = New SolidColorBrush(Colors.SkyBlue)
    B503.Background = New SolidColorBrush(Colors.Gold) : B504.Background = New SolidColorBrush(Colors.Magenta)
    B505.Background = New SolidColorBrush(Colors.Lime) : B501.Background = New SolidColorBrush(Colors.AliceBlue)
  End Sub
  Private Sub B_BE()
    Try : ADAA() : Catch ex As Exception : End Try
  End Sub
  Private Sub B_BF()
    '    AAB = 3 : AAAA() : ABAD(5) : Ϟ102.FontFamily = New FontFamily("Consolas")
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
    'Ϟ102.Document.Selection.CharacterFormat.Weight = 0
  End Sub
  Private Sub B_BG()
    'AAB = 3 : AAAA() : ABAD(5) : Ϟ102.FontFamily = New FontFamily("Consolas")
    '' Chemie - Formeln
    'ABAE(Colors.AliceBlue, Colors.Blue, "   " & A_D.GetString("E004") & "   " & vbLf &
    '     vbLf) : ABAE(Colors.White, Colors.Green, "c = n / V" & vbLf & "M = m / n")
  End Sub
  Private Sub B_BH()
    '    AAB = 3 : AAAA() : ABAD(10) : Ϟ102.FontFamily = New FontFamily("Consolas")
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
    'AAB = 3 : AAAA() : ABAD(10) : Ϟ102.FontFamily = New FontFamily("Consolas")
    '' Dimensionen
    'ABAE(Colors.AliceBlue, Colors.Blue, "   " & A_D.GetString("A109") & "   " & vbLf & vbLf)
    'For i = 1 To 87 Step 1 : AGA = If(i < 10, "00", "0") & CStr(i)
    '  ABAE(Colors.White, Colors.Blue, (A_C.GetString("B" & AGA) & "       ").Substring(0, 8))
    '  ABAE(Colors.White, Colors.DeepSkyBlue, A_D.GetString("C" & AGA) & vbLf) : Next
  End Sub
  Private Sub B_BJ()
    AAB = 5 : AAAA()
  End Sub
#End Region
#Region "C100"
  Private Sub C_AA(a As Button, b As RoutedEventArgs)
    DA_.Text = DA_.Text.Insert(BJA, a.Content) : BJA += a.Content.Length : DA_.SelectionStart = BJA
  End Sub
  Private Sub C_AB(a As Button, b As RoutedEventArgs)
    DA_.Text = DA_.Text.Insert(BJA, " " & a.Content & " ") : BJA += a.Content.Length : DA_.SelectionStart = BJA
  End Sub
  Private Sub C_AC(a As Button, b As RoutedEventArgs)
    BJC = DA_.SelectionStart : BHA = True : DA_.Text = DA_.Text.Insert(BJC, " - ")
  End Sub
  Private Sub C_AD(a As Button, b As RoutedEventArgs)
    BJC = DA_.SelectionStart : BHA = True : DA_.Text = DA_.Text.Insert(BJC, a.Content & "()")
  End Sub
  Private Sub C_AE(a As Button, b As RoutedEventArgs)
    BJC = DA_.SelectionStart : BHA = True : DA_.Text = DA_.Text.Insert(BJC, a.Content & "(')")
  End Sub
  Private Sub C_AF(a As Button, b As RoutedEventArgs)
    BJC = DA_.SelectionStart : BHA = True : DA_.Text = DA_.Text.Insert(BJC, a.Content & "('')")
  End Sub
  Private Sub C_AG(a As Button, b As RoutedEventArgs)
    BJC = DA_.SelectionStart : BHA = True : DA_.Text = DA_.Text.Insert(BJC, a.Content & "(''d)")
  End Sub
  Private Sub C_AH(a As Button, b As RoutedEventArgs)
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
#Region "Թ100"
  Private Sub Թ_AA(a As Button, b As RoutedEventArgs)
    DGA = a.Content : AAB = 1 : If DGA <> DGB Then DAAA() : DGB = DGA
    Հ101.Visibility = 1 : B101.Visibility = 0
    B101.ItemsSource = DՃA.Where(Function(item, index) index Mod 5 = 0)
  End Sub
  Private Sub Թ_AB()

    B101.Visibility = 1 : Հ102.Visibility = 0
    DՃB = B101.Items(B101.SelectedIndex).Split(" ")

    ' Formel
    FA_ = New TextBlock With {.Text = DՃA(B101.SelectedIndex * 5 + 1)}
    Ξ102.Children.Add(FA_) : Grid.SetRow(FA_, 0) : Grid.SetColumn(FA_, 4)
    Ξ102.RowDefinitions.Item(1).Height = New GridLength(3, 2)

    ' Dimensionen
    For Each i In DՃB
      DGC &= (i & "     ").Substring(0, 5) & "= " & vbCrLf & vbCrLf : Next
    FA_ = New TextBlock With {.Text = DGC} : DGC = ""
    Ξ102.Children.Add(FA_) : Grid.SetRow(FA_, 2) : Grid.SetColumn(FA_, 2)
    Ξ102.ColumnDefinitions.Item(2).Width = New GridLength(70, 1)

    ' Eingabe
    Grid.SetRow(CԳ_, 2) : Grid.SetColumn(CԳ_, 3) : Grid.SetColumnSpan(CԳ_, 2)
    BJA = 0 : B_ՀB()
  End Sub
#End Region
#End Region
#Region "□□□□"
#Region "AAAA"
#Region "A-AA"
  Private Sub AAAA()
    ' Widerholungsverbot
    If AAI = 100 * AAA + AAB Then Exit Sub Else AAI = 100 * AAA + AAB
    ' Quer-Hoch-Formaten
    Select Case AAI
      Case = 101 : AABA() ' Q-Start
      Case = 102 : AABB() ' Q-Anhang
      Case = 103 : AABC() ' Q-Listen
      Case = 104 : AADA() ' Q-Beispiele
      Case = 105 : AABE() ' Q-Tabelle
      Case = 106 : AADA() ' Q-Elemente
      Case = 107 : AABG() ' Q-Dimensionen
      Case = 201 : AACA() ' H-Start
      Case = 202 : AACB() ' H-Anhang
      Case = 203 : AACC() ' H-Listen
      Case = 204 : AADA() ' H-Beispiele
      Case = 205 : AACE() ' H-Tabelle*
      Case = 206 : AADA() ' H-Elemente
      Case = 207 : AACG() ' H-Dimensionen
    End Select
  End Sub
  Private Sub AABA()
    ' H-S => Q-S : Q-A° => Q-S
    AADA() : AADB()
    A100.Padding = New Thickness(138, 0, 138, 0)
    C100.ColumnDefinitions.Item(0).Width = New GridLength(0.5, 2)
    C100.ColumnDefinitions.Item(20).Width = New GridLength(4.5, 2)
    For i = 5 To 19 Step 1 : C100.ColumnDefinitions.Item(i).Width = New GridLength(1, 2) : Next
    ToolTipService.SetToolTip(Թ102, New ToolTip With {.Content = A_D.GetString("A001")})
    Թ102.Icon = New FontIcon With {.Glyph = ChrW(&HE80F), .FontFamily = New FontFamily("Segoe MDL2 Assets")}
  End Sub
  Private Sub AABB()
    ' H-A => Q-A : Q-A° => Q-A
    AADA() : AADC()
  End Sub
  Private Sub AABC()
    ' Q-A => Q-L,   H-L => Q-L
    AADA() : AADD()
  End Sub
  Private Sub AABE()
    ' H-T => Q-T,   Q-A => Q-T,   Q-E => Q-T
    AADA() : B200.Visibility = 1 : B300.Visibility = 0
    EB_.Visibility = 1 : If B300.Children.Count = 0 Then CAAA()
  End Sub
  Private Sub AABG()
    AABA() : AAJ = 1 : AAK = 0
    For i = 0 To 86 Step 1
      Grid.SetRow(Ξ101.Children(i), AAJ) : Grid.SetColumn(Ξ101.Children(i), AAK)
      AAK += 1 : If AAK = 14 Then AAJ += 1 : AAK = 0
    Next
    Ξ101.RowDefinitions.Item(10).Height = New GridLength(0, 2)
    Ξ101.RowDefinitions.Item(11).Height = New GridLength(0, 2)
    Ξ101.ColumnDefinitions.Item(8).Width = New GridLength(1, 2)
    Ξ101.ColumnDefinitions.Item(9).Width = New GridLength(1, 2)
    Ξ101.ColumnDefinitions.Item(10).Width = New GridLength(1, 2)
    Ξ101.ColumnDefinitions.Item(11).Width = New GridLength(1, 2)
    Ξ101.ColumnDefinitions.Item(12).Width = New GridLength(1, 2)
    Ξ101.ColumnDefinitions.Item(13).Width = New GridLength(1, 2)
    Ξ101.ColumnDefinitions.Item(14).Width = New GridLength(1, 2)
  End Sub
  Private Sub AACA()
    ' Q-S => H-S : H-A° => H-S
    AADA() : AADB()
    A100.Padding = New Thickness(30, 0, 30, 0)
    AA01.RowDefinitions.Item(0).Height = New GridLength(0, 2)
    'C100.ColumnDefinitions.Item(0).Width = New GridLength(0.3, 2)
    C100.ColumnDefinitions.Item(0).Width = New GridLength(30, 1)
    C100.ColumnDefinitions.Item(5).Width = New GridLength(0, 2)
    C100.ColumnDefinitions.Item(10).Width = New GridLength(0, 2)
    C100.ColumnDefinitions.Item(20).Width = New GridLength(30, 1)
    'C100.ColumnDefinitions.Item(20).Width = New GridLength(0.3, 2)
    ToolTipService.SetToolTip(Թ102, New ToolTip With {.Content = A_D.GetString("A001")})
    Թ102.Icon = New FontIcon With {.Glyph = ChrW(&HE80F), .FontFamily = New FontFamily("Segoe MDL2 Assets")}
  End Sub
  Private Sub AACB()
    ' Q-A => H-A : H-A° => H-A
    AADA() : AADC() : AA01.RowDefinitions.Item(0).Height = New GridLength(0, 2)
  End Sub
  Private Sub AACC()
    ' Q-A => Q-L,   H-L => Q-L
    AADA() : AADD()
    AA01.RowDefinitions.Item(0).Height = New GridLength(0, 2)
  End Sub
  Private Sub AACE()
    ' Q-T => H-T,   H-A => H-T,   H-E => H-T
    AADA() : B200.Visibility = 1 : B300.Visibility = 1
    EB_.Visibility = 0 : If EB_.Items.Count = 0 Then CAAB()
  End Sub
  Private Sub AACG()
    AACA() : AAJ = 1 : AAK = 0
    For i = 0 To 86 Step 1
      Grid.SetRow(Ξ101.Children(i), AAJ) : Grid.SetColumn(Ξ101.Children(i), AAK)
      AAK += 1 : If AAK = 8 Then AAJ += 1 : AAK = 0
    Next
    Ξ101.RowDefinitions.Item(10).Height = New GridLength(1, 2)
    Ξ101.RowDefinitions.Item(11).Height = New GridLength(1, 2)
    Ξ101.ColumnDefinitions.Item(8).Width = New GridLength(0, 2)
    Ξ101.ColumnDefinitions.Item(9).Width = New GridLength(0, 2)
    Ξ101.ColumnDefinitions.Item(10).Width = New GridLength(0, 2)
    Ξ101.ColumnDefinitions.Item(11).Width = New GridLength(0, 2)
    Ξ101.ColumnDefinitions.Item(12).Width = New GridLength(0, 2)
    Ξ101.ColumnDefinitions.Item(13).Width = New GridLength(0, 2)
    Ξ101.ColumnDefinitions.Item(14).Width = New GridLength(0, 2)
  End Sub
  Private Sub AADA()
    ' A°:Q-H: Alle Q oder H
    If AAA = 1 Then : CA_.Visibility = 0 : Grid.SetRow(A100, 0)
      A111.Visibility = 1 : A112.Visibility = 1
      AA01.RowDefinitions.Item(0).Height = New GridLength(1, 2)
      A100.ColumnDefinitions.Item(4).Width = New GridLength(1, 2)
      A100.ColumnDefinitions.Item(5).Width = New GridLength(1, 2)
      A100.ColumnDefinitions.Item(6).Width = New GridLength(1, 2)
      A100.ColumnDefinitions.Item(7).Width = New GridLength(1, 2)
      A100.ColumnDefinitions.Item(8).Width = New GridLength(1, 2)
      A100.ColumnDefinitions.Item(9).Width = New GridLength(1, 2)
      A100.ColumnDefinitions.Item(10).Width = New GridLength(0, 2)
      A100.ColumnDefinitions.Item(11).Width = New GridLength(0, 2)
      ' ! Bis Upgrade !
      C100.ColumnDefinitions.Item(15).Width = New GridLength(1, 2)
      C100.ColumnDefinitions.Item(16).Width = New GridLength(1, 2)
      C100.ColumnDefinitions.Item(17).Width = New GridLength(1, 2)
      C100.ColumnDefinitions.Item(18).Width = New GridLength(1, 2)
      C100.ColumnDefinitions.Item(19).Width = New GridLength(1, 2)
    Else : CA_.Visibility = 1 : Grid.SetRow(A100, 3)
      A111.Content = If(A111.Content = "A1", "A2", "A1") : AAEA()
      A112.Content = If(A112.Content = "B1", "B2", "B1") : AAEB()
      A111.Visibility = 0 : A112.Visibility = 0
      A100.ColumnDefinitions.Item(10).Width = New GridLength(1, 2)
      A100.ColumnDefinitions.Item(11).Width = New GridLength(1, 2)
      ' ! Bis Upgrade !
      C100.ColumnDefinitions.Item(15).Width = New GridLength(0, 2)
      C100.ColumnDefinitions.Item(16).Width = New GridLength(0, 2)
      C100.ColumnDefinitions.Item(17).Width = New GridLength(0, 2)
      C100.ColumnDefinitions.Item(18).Width = New GridLength(0, 2)
      C100.ColumnDefinitions.Item(19).Width = New GridLength(0, 2)
    End If
    CA_.Background = New SolidColorBrush(ACAB(AAE))
  End Sub
  Private Sub AADB()
    ' S:Q-H: Start: Q und H
    B100.Visibility = 0 : B200.Visibility = 1 : B300.Visibility = 1
    B400.Visibility = 1 : C100.Visibility = 0 : B500.Visibility = 1
    EB_.Visibility = 1 : Grid.SetRow(CA_, 3)
    AA01.RowDefinitions.Item(1).Height = New GridLength(1, 2)
    AA01.RowDefinitions.Item(2).Height = New GridLength(12, 2)
    AA01.RowDefinitions.Item(4).Height = New GridLength(6, 2)
  End Sub
  Private Sub AADC()
    ' A:Q-H: Anhang: Q und H
    AA01.RowDefinitions.Item(1).Height = New GridLength(0, 2)
    AA01.RowDefinitions.Item(4).Height = New GridLength(3, 2)
    AA01.RowDefinitions.Item(2).Height = New GridLength(14, 2)

    B100.Visibility = 1 : B200.Visibility = 0 : B300.Visibility = 1
    B400.Visibility = 1 : C100.Visibility = 1 : Grid.SetRow(CA_, 4)
    B500.Visibility = 1 : CA_.Visibility = 0 : EB_.Visibility = 1
    AAG = AAE : If AAG = 10 Then AAG = 4

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

    ' Icons 1-9
    For i = 0 To 8 Step 1 : ACAD(B200.Children.Item(i)).Content = New Image With {.Source = New BitmapImage With
        {.UriSource = New Uri("ms-appx:///Assets/A_A_00" & CStr(i + 1) & ".png")}} : Next
    ' Icon 10-99
    B210.Content = New Image With {.Source = New BitmapImage With {.UriSource = New Uri("ms-appx:///Assets/A_A_010.png")}}
  End Sub
  Private Sub AADD()
    ' L:Q-H: Listen: Q und H
    B100.Visibility = 0 : B200.Visibility = 1 : Հ101.Visibility = 1
    Հ102.Visibility = 1 : Հ103.Visibility = 0 : EB_.Visibility = 1
    AA01.RowDefinitions.Item(1).Height = New GridLength(1, 2)
  End Sub
  Private Sub AAEA()
    If A111.Content = "A1" Then : A111.Content = "A2" : AAC = 0
      AAD = 1
    Else : A111.Content = "A1" : AAC = 1 : AAD = 0 : End If
    A100.ColumnDefinitions.Item(0).Width = New GridLength(AAC, 2)
    A100.ColumnDefinitions.Item(1).Width = New GridLength(AAC, 2)
    A100.ColumnDefinitions.Item(2).Width = New GridLength(AAC, 2)
    A100.ColumnDefinitions.Item(3).Width = New GridLength(AAC, 2)
    A100.ColumnDefinitions.Item(6).Width = New GridLength(AAD, 2)
    A100.ColumnDefinitions.Item(7).Width = New GridLength(AAD, 2)
    A100.ColumnDefinitions.Item(8).Width = New GridLength(AAD, 2)
    A100.ColumnDefinitions.Item(9).Width = New GridLength(AAD, 2)
  End Sub
  Private Sub AAEB()
    If A112.Content = "B1" Then : A112.Content = "B2" : AAC = 0
      AAD = 1
    Else : A112.Content = "B1" : AAC = 1 : AAD = 0 : End If
    C100.ColumnDefinitions.Item(6).Width = New GridLength(AAC, 2)
    C100.ColumnDefinitions.Item(7).Width = New GridLength(AAC, 2)
    C100.ColumnDefinitions.Item(8).Width = New GridLength(AAC, 2)
    C100.ColumnDefinitions.Item(9).Width = New GridLength(AAC, 2)
    C100.ColumnDefinitions.Item(11).Width = New GridLength(AAD, 2)
    C100.ColumnDefinitions.Item(12).Width = New GridLength(AAD, 2)
    C100.ColumnDefinitions.Item(13).Width = New GridLength(AAD, 2)
    C100.ColumnDefinitions.Item(14).Width = New GridLength(AAD, 2)
  End Sub
  Private Sub AAFA()
    ' Textstyle - Bearbeitung
    Select Case ApplicationData.Current.LocalSettings.Values("textstyle")
      Case "m"
      Case "c"
    End Select
  End Sub
  Private Sub AAFB()
    ' Rectangle - Bearbeitung '
    Select Case ApplicationData.Current.LocalSettings.Values("rectangle")
      Case "i" : B102.Visibility = 0
      Case "o" : B102.Visibility = 1 : End Select
    B102.Stroke = New SolidColorBrush(ACAB(AAG))
  End Sub
  Private Sub AAFC()
    ' Helligkeit - Bearbeitung
    Select Case ApplicationData.Current.LocalSettings.Values("lightness")
      Case "l"
        ToolTipService.SetToolTip(Թ102, New ToolTip With {.Content = A_D.GetString("A002")})
        ToolTipService.SetToolTip(Թ103, New ToolTip With {.Content = A_D.GetString("A004")})
        ' ms-appx:///Assets/A_0_001.png
        Թ110.Source = New BitmapImage(New Uri("ms-appx:///Assets/LockScreenLogo.scale-200.png"))
        AAE = 14 : AAF = 0 : AAG = 1 : AAGB()
      Case "d"
        ToolTipService.SetToolTip(Թ102, New ToolTip With {.Content = A_D.GetString("A001")})
        ToolTipService.SetToolTip(Թ103, New ToolTip With {.Content = A_D.GetString("A003")})
        ' ms-appx:///Assets/A_0_002.png
        Թ110.Source = New BitmapImage(New Uri("ms-appx:///Assets/LockScreenLogo.scale-200.png"))
        AAE = 11 : AAF = 14 : AAG = 13 : AAGB()
    End Select : AAGA()
  End Sub
  Private Sub AAGA()
    'Colors
    Select Case ApplicationData.Current.LocalSettings.Values("colors")
      Case "1" : AAE = 10 : AAF = 11 : AAG = 11 : Case "2" : AAE = 4 : AAF = 14 : AAG = 11
      Case "3" : AAE = 1 : AAF = 14 : AAG = 12 : Case "4" : AAE = 12 : AAF = 14 : AAG = 12
      Case "5" : AAE = 13 : AAF = 14 : AAG = 2 : Case "6" : AAE = 11 : AAF = 14 : AAG = 11
    End Select

    If Թ103.Content = "⛯" Then AAE = 11 : AAF = 14 : AAG = 14

    'AA_.Stroke = New SolidColorBrush(ACAB(AAG))
    B102.Stroke = New SolidColorBrush(ACAB(AAG))

    A100.Background = New SolidColorBrush(ACAB(AAE)) : CA_.Background = New SolidColorBrush(ACAB(AAE))

    For i = 0 To 11 Step 1 : ACAD(A100.Children.Item(i)).Foreground = New SolidColorBrush(ACAB(AAF))
    Next

    For i = 0 To 63 Step 1 : ACAD(C100.Children.Item(i)).Foreground = New SolidColorBrush(ACAB(AAG))
    Next

    Select Case AAF + AAG
      Case 22
        A101.Content = New Image With
          {.Source = New BitmapImage With {.UriSource = New Uri("ms-appx:///Assets/A_1_001.png")}}
        A102.Content = New Image With
          {.Source = New BitmapImage With {.UriSource = New Uri("ms-appx:///Assets/A_1_002.png")}}
        A103.Content = New Image With
          {.Source = New BitmapImage With {.UriSource = New Uri("ms-appx:///Assets/A_1_003.png")}}
        A104.Content = New Image With
          {.Source = New BitmapImage With {.UriSource = New Uri("ms-appx:///Assets/A_1_004.png")}}
      Case Else
        A101.Content = New Image With
          {.Source = New BitmapImage With {.UriSource = New Uri("ms-appx:///Assets/A_1_006.png")}}
        A102.Content = New Image With
          {.Source = New BitmapImage With {.UriSource = New Uri("ms-appx:///Assets/A_1_007.png")}}
        A103.Content = New Image With
          {.Source = New BitmapImage With {.UriSource = New Uri("ms-appx:///Assets/A_1_008.png")}}
        A104.Content = New Image With
          {.Source = New BitmapImage With {.UriSource = New Uri("ms-appx:///Assets/A_1_009.png")}}
    End Select

    If Ξ101.Children.Count > 2 Then : For i = 0 To Ξ101.Children.Count - 3 Step 1
        ACAF(Ξ101.Children(i)).Foreground = New SolidColorBrush(ACAB(AAG)) : Next
    End If

    'B511.Background = New SolidColorBrush(ACAB(AAE)) : B511.Foreground = New SolidColorBrush(ACAB(AAF))
    B512.Background = New SolidColorBrush(ACAB(AAE)) : B512.Foreground = New SolidColorBrush(ACAB(AAF))
    'B513.Background = New SolidColorBrush(ACAB(AAE)) : B513.Foreground = New SolidColorBrush(ACAB(AAF))
  End Sub
  Private Sub AAGB()
    Dim title = ApplicationView.GetForCurrentView().TitleBar
    title.BackgroundColor = ACAB(AAE) : title.ButtonInactiveForegroundColor = ACAB(AAF)
    title.ForegroundColor = ACAB(AAF) : title.ButtonInactiveBackgroundColor = ACAB(AAE)
    title.ButtonBackgroundColor = ACAB(AAE) : title.InactiveBackgroundColor = ACAB(AAE)
    title.ButtonForegroundColor = ACAB(AAF) : title.InactiveForegroundColor = ACAB(AAF)
    title.ButtonHoverBackgroundColor = ACAB(AAE) : title.ButtonPressedBackgroundColor = ACAB(AAG)
    C100.Background = New SolidColorBrush(ACAB(AAE)) : Թ104.Background = New SolidColorBrush(ACAB(AAE))
    Թ102.Foreground = New SolidColorBrush(ACAB(AAF)) : Թ103.Foreground = New SolidColorBrush(ACAB(AAF))
    AA00.Background = New SolidColorBrush(ACAB(AAE)) : AA01.Background = New SolidColorBrush(ACAB(AAE))
  End Sub
  'Private Sub AIAS()
  '  Select Case Ϟ102.Document.Selection.
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
    ApplicationData.Current.LocalSettings.Values("colors") = "1" : AAGA()
  End Sub
  Private Sub ABAB()
    ' Colors SkyBlue
    ApplicationData.Current.LocalSettings.Values("colors") = "2" : AAGA()
  End Sub
  Private Sub ABAC()
    ' Colors Gold
    ApplicationData.Current.LocalSettings.Values("colors") = "3" : AAGA()
  End Sub
  Private Sub ABAD()
    ' Colors Magenta
    ApplicationData.Current.LocalSettings.Values("colors") = "4" : AAGA()
  End Sub
  Private Sub ABAE()
    ' Colors Lime
    ApplicationData.Current.LocalSettings.Values("colors") = "5" : AAGA()
  End Sub
  Private Sub ABAF()
    ' Colors Blue
    ApplicationData.Current.LocalSettings.Values("colors") = "6" : AAGA()
  End Sub
  Private Sub ABBA()
    ' Textstyle - Auswahl
    If B511.IsOn = True Then
      ApplicationData.Current.LocalSettings.Values("textstyle") = "m"
    Else ' mathprint ' classic
      ApplicationData.Current.LocalSettings.Values("textstyle") = "c"
    End If : AAFA()
  End Sub
  Private Sub ABBB()
    ' Rectangle - Auswahl
    If B512.IsOn = True Then
      ApplicationData.Current.LocalSettings.Values("rectangle") = "i"
    Else ' outside ' inside_
      ApplicationData.Current.LocalSettings.Values("rectangle") = "o"
    End If : AAFB()
  End Sub
  Private Sub ABBC()
    ' Helligkeit - Auswahl
    If Թ103.Content = "⛭" Then
      Թ103.Content = "⛯" ' ☀️
      ApplicationData.Current.LocalSettings.Values("lightness") = "d"
    Else ' dark ' light
      Թ103.Content = "⛭"
      ApplicationData.Current.LocalSettings.Values("lightness") = "l"
    End If : AAFC()
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

      'aaaaa = A_D.GetString("A201") & ":   " & B102.Text & vbCrLf &
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
    End If : Ϟ102.Text = BGA
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

    ' □
    'FC_ = New TextBlock With {.Text = "∫", .FontFamily = New FontFamily("Consolas"),
    '  .Scale = New System.Numerics.Vector3(1.0, 3.0, 1.0),
    '  .Margin = New Thickness(BJA * 10, BJB * 10 - 10, 0, 0)} : B111.Children.Insert(BJA - 1, FC_)
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
          _FD = DA_.Text.Split(":") : CB = _FD(1) : End Select : End If
    CA = CA.Replace(vbCrLf, vbLf) : CA = CA.Replace(vbCr, vbLf) : CA = CA.Replace(vbLf, "")
    ' Nicht leerer Ausdruck
    BAAB()
  End Sub
  Private Sub BAAB()
    ' Aufruf von alle'
    AAB = 1 : AAAA()

    ' Symbolen
    JA.Clear() : JB.Clear() : JC.Clear() : KA.Clear()
    KB.Clear() : KC.Clear() : KD.Clear() : KE.Clear()
    KF.Clear() : BՑB.Clear() : BՑA.Clear() : KJ.Clear()
    KK.Clear() : KL.Clear() : MQ_.Clear() : MR_.Clear()
    KG.Clear() : _M = 0 : MQ_.Add(0)
    _AA = A_D.GetString("A302") : _AB = A_D.GetString("A253")
    _AC = A_D.GetString("A254") : KB.Add(_AA & "  : a = a")
    ' Symbolen   Reihenfolge !!!
    CA = CA.Replace("  ", " ") : CA = CA.Replace("  ", " ")
    CA = CA.Replace("  ", " ") : CA = CA.Replace("  ", " ")
    CA = CA.Replace("*", "·") : CA = CA.Replace("/", ":")
    CA = CA.Replace("^", "˄") : CA = CA.Replace("+∞", "▪")
    CA = CA.Replace("+", " + ") : CA = CA.Replace("±", " ± ")
    CA = CA.Replace("∓", " ∓ ") : CA = CA.Replace("·", " · ")
    CA = CA.Replace(":", " : ") : CA = CA.Replace("˄", " ˄ ")
    CA = CA.Replace("˅", " ˅ ") : CA = CA.Replace("˟", " ˟ ")
    CA = CA.Replace("'", " ' ") : CA = CA.Replace("→", " → ")
    CA = CA.Replace("=", " = ") : CA = CA.Replace("≠", " ≠ ")
    CA = CA.Replace("<", " < ") : CA = CA.Replace(">", " > ")
    CA = CA.Replace("  ", " ") : CA = CA.Replace("  ", " ")
    CA = CA.Replace("  ", " ") : CA = CA.Replace("  ", " ")
    CA = CA.Replace(" ", " · ")
    CA = CA.Replace(" · + · ", " + ") : CA = CA.Replace(" · ± · ", " ± ")
    CA = CA.Replace(" · ∓ · ", " ∓ ") : CA = CA.Replace(" · - · ", " - ")
    CA = CA.Replace(" · · · ", " · ") : CA = CA.Replace(" · : · ", " : ")
    CA = CA.Replace(" · ˄ · ", " ˄ ") : CA = CA.Replace(" · ˅ · ", " ˅ ")
    CA = CA.Replace(" · ˟ · ", " ˟ ") : CA = CA.Replace(" · = · ", " = ")
    CA = CA.Replace(" · ≠ · ", " ≠ ") : CA = CA.Replace(" · < · ", " < ")
    CA = CA.Replace(" · > · ", " > ") : CA = CA.Replace(" · ' · ", " ' ")
    CA = CA.Replace(" · → · ", " → ") : CA = CA.Replace("▪", "+∞")
    CA = CA.Replace("( ", "(") : CA = CA.Replace(" )", ")")
    CA = CA.TrimStart(" ") : CA = CA.TrimEnd(" ")

    MQ_.Add(0) : _M = 0 : KB.Add(A_D.GetString("A303") & "  : a = a") : KA.Add(CA)

    ToolTipService.SetToolTip(A105, New ToolTip With {.Content = A_D.GetString("A005")})
    A105.Background = New SolidColorBrush(Colors.Lime) : BGA = CA : BAAD() : A_AF() ' –/‐
  End Sub
  Private Sub BAAC()
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

    ToolTipService.SetToolTip(A105, New ToolTip With {.Content = A_D.GetString("A005")})
    A105.Background = New SolidColorBrush(Colors.Lime) : BGA = CA : BAAD() : A_AF()
  End Sub
  Private Sub BAAD()
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
  Private Sub BBAB()
    ' Ausdruckseigenschaften 2
    BՑB.Clear() : BՑA.Clear() : BՆA.Clear() : BՆC.Clear() : BՆD.Clear() : BՆԳ.Clear()
    BՑA.Add("") : BՆA.Add(0) : BՆC.Add(0) : If BJE = 0 Then Exit Sub ' BGA = DB_.Text : 

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
  Private Sub BBAC()
    If KC.Count > 0 Then : Static aa, ab() As String : KG.Add("BBAC")
      For i = 0 To KC.Count - 1 Step 1 : KA.Insert(_M + i + 1, KC(i)) : ab = KB(_M).Split(":")
        aa = ab(0).Remove(ab(0).Length - 1, 1) : aa &= "." & Convert.ToString(i + 1) & " : " & KD(i)
        If _M = 0 Then aa = aa.Replace(A_D.GetString("A152") & " .", A_D.GetString("A152") & " ")
        KB.Insert(_M + i + 1, aa) : KL.Add(vbLf & vbLf & aa) : KL.AddRange(KK.GetRange(0, MR_(i)))
        JC.Add(Colors.Blue) : JC.AddRange(JB.GetRange(0, MR_(i))) : KK.RemoveRange(0, MR_(i))
        JB.RemoveRange(0, MR_(i)) : Next : End If : MR_.Clear() : KC.Clear() : KD.Clear()
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
    If _I = 0 Then : KE.Clear() : KJ.Clear() : JA.Clear() : KF.Clear() : KE.Add(KA(_M)) : End If

    'Ϟ102.Text = CA & vbCrLf & CStr(BՑA.Count) ' : DB_.MaxHeight = 500 : DB_.MaxWidth = 500

    KE(_I) = KE(_I).Replace(_AB, _AC) : CA = KE(_I) : BBAA() : KF.Add(CC) : _L = BՑB.Count
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

    For i = 1 To 32 Step 1 : AGA = If(i < 10, "00", "0")
      eaaab = New TextBlock With {
        .FontSize = 12, .Text = A_A.GetString("A" & AGA & CStr(i)), .IsTextSelectionEnabled = False}
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

    For i = 1 To 118 Step 1 : AGA = "B" & If(i < 10, "00", If(i < 100, "0", "")) & CStr(i)
      eaaab = New TextBlock With {
        .FontFamily = New FontFamily("Calibri Light"), .IsTextSelectionEnabled = False}
      Select Case ACAC(i - 1) : Case "0", "2", "8"
          eaaab.Foreground = New SolidColorBrush(Colors.White) : End Select
      eaaaa = New Button With {.Background = New SolidColorBrush(ACAB(CInt(ACAC(i - 1)))),
        .Padding = New Thickness(0), .HorizontalContentAlignment = 0, .Content = eaaab,
        .Margin = New Thickness(0.5)}
      Grid.SetRow(eaaaa, CInt(eaaba(i - 1))) : Grid.SetColumn(eaaaa, CInt(eaabb(i - 1)))
      eaaca = New Documents.Run With {.Text = A_A.GetString(AGA) & vbLf, .FontSize = 15}
      eaaab.Inlines.Add(eaaca) : B300.Children.Add(eaaaa)
      eaaca = New Documents.Run With {.Text = vbLf & A_D.GetString(AGA), .FontSize = 12}
      eaaab.Inlines.Add(eaaca) : AddHandler eaaaa.Click, AddressOf CABA : Next
  End Sub
  Private Sub CAAB()
    ' Liste der chemischen Elemente
    For i = 1 To 118 Step 1 : AGA = "B" & If(i < 10, "00", If(i < 100, "0", "")) & CStr(i)
      EB_.Items.Add(New TextBlock With {.FontFamily = New FontFamily("Consolas"),
        .FontSize = 16, .VerticalAlignment = 3, .HorizontalAlignment = 3,
        .Text = (A_A.GetString(AGA) & "          ").Substring(0, 10) & A_D.GetString(AGA)})
    Next : AA01.Children.
      Add(EB_) : Grid.SetRow(EB_, 2) : AddHandler EB_.SelectionChanged, AddressOf CABB
  End Sub
#End Region
#Region "C-AB"
  Private Sub CABA(a As Button, b As RoutedEventArgs)
    ' Die Auswahl des chemischen Elements von der Tabelle
    AGA = CStr(Grid.GetRow(a)) & "." & CStr(Grid.GetColumn(a))
    Select Case AGA
      Case "3.2" : AGA = "1" : Case "3.20" : AGA = "2" : Case "4.2" : AGA = "3" : Case "4.3" : AGA = "4"
      Case "4.15" : AGA = "5" : Case "4.16" : AGA = "6" : Case "4.17" : AGA = "7" : Case "4.18" : AGA = "8"
      Case "4.19" : AGA = "9" : Case "4.20" : AGA = "10" : Case "5.2" : AGA = "11" : Case "5.3" : AGA = "12"
      Case "5.15" : AGA = "13" : Case "5.16" : AGA = "14" : Case "5.17" : AGA = "15" : Case "5.18" : AGA = "16"
      Case "5.19" : AGA = "17" : Case "5.20" : AGA = "18" : Case "6.2" : AGA = "19" : Case "6.3" : AGA = "20"
      Case "6.4" : AGA = "21" : Case "6.6" : AGA = "22" : Case "6.7" : AGA = "23" : Case "6.8" : AGA = "24"
      Case "6.9" : AGA = "25" : Case "6.10" : AGA = "26" : Case "6.11" : AGA = "27" : Case "6.12" : AGA = "28"
      Case "6.13" : AGA = "29" : Case "6.14" : AGA = "30" : Case "6.15" : AGA = "31" : Case "6.16" : AGA = "32"
      Case "6.17" : AGA = "33" : Case "6.18" : AGA = "34" : Case "6.19" : AGA = "35" : Case "6.20" : AGA = "36"
      Case "7.2" : AGA = "37" : Case "7.3" : AGA = "38" : Case "7.4" : AGA = "39" : Case "7.6" : AGA = "40"
      Case "7.7" : AGA = "41" : Case "7.8" : AGA = "42" : Case "7.9" : AGA = "43" : Case "7.10" : AGA = "44"
      Case "7.11" : AGA = "45" : Case "7.12" : AGA = "46" : Case "7.13" : AGA = "47" : Case "7.14" : AGA = "48"
      Case "7.15" : AGA = "49" : Case "7.16" : AGA = "50" : Case "7.17" : AGA = "51" : Case "7.18" : AGA = "52"
      Case "7.19" : AGA = "53" : Case "7.20" : AGA = "54" : Case "8.2" : AGA = "55" : Case "8.3" : AGA = "56"
      Case "8.4" : AGA = "57" : Case "10.6" : AGA = "58" : Case "10.7" : AGA = "59" : Case "10.8" : AGA = "60"
      Case "10.9" : AGA = "61" : Case "10.10" : AGA = "62" : Case "10.11" : AGA = "63" : Case "10.12" : AGA = "64"
      Case "10.13" : AGA = "65" : Case "10.14" : AGA = "66" : Case "10.15" : AGA = "67" : Case "10.16" : AGA = "68"
      Case "10.17" : AGA = "69" : Case "10.18" : AGA = "70" : Case "10.19" : AGA = "71" : Case "8.6" : AGA = "72"
      Case "8.7" : AGA = "73" : Case "8.8" : AGA = "74" : Case "8.9" : AGA = "75" : Case "8.10" : AGA = "76"
      Case "8.11" : AGA = "77" : Case "8.12" : AGA = "78" : Case "8.13" : AGA = "79" : Case "8.14" : AGA = "80"
      Case "8.15" : AGA = "81" : Case "8.16" : AGA = "82" : Case "8.17" : AGA = "83" : Case "8.18" : AGA = "84"
      Case "8.19" : AGA = "85" : Case "8.20" : AGA = "86" : Case "9.2" : AGA = "87" : Case "9.3" : AGA = "88"
      Case "9.4" : AGA = "89" : Case "11.6" : AGA = "90" : Case "11.7" : AGA = "91" : Case "11.8" : AGA = "92"
      Case "11.9" : AGA = "93" : Case "11.10" : AGA = "94" : Case "11.11" : AGA = "95" : Case "11.12" : AGA = "96"
      Case "11.13" : AGA = "97" : Case "11.14" : AGA = "98" : Case "11.15" : AGA = "99" : Case "11.16" : AGA = "100"
      Case "11.17" : AGA = "101" : Case "11.18" : AGA = "102" : Case "11.19" : AGA = "103" : Case "9.6" : AGA = "104"
      Case "9.7" : AGA = "105" : Case "9.8" : AGA = "106" : Case "9.9" : AGA = "107" : Case "9.10" : AGA = "108"
      Case "9.11" : AGA = "109" : Case "9.12" : AGA = "110" : Case "9.13" : AGA = "111" : Case "9.14" : AGA = "112"
      Case "9.15" : AGA = "113" : Case "9.16" : AGA = "114" : Case "9.17" : AGA = "115" : Case "9.18" : AGA = "116"
      Case "9.19" : AGA = "117" : Case "9.20" : AGA = "118" : Case Else : AGA = 0 : End Select : CABC()
  End Sub
  Private Sub CABB()
    ' Die Auswahl des chemischen Elements von der Liste
    AGA = CStr(EB_.SelectedIndex + 1) : CABC()
  End Sub
  Private Sub CABC()
    ' Das Laden des chemischen Elements
    B401.Background = New SolidColorBrush(ACAB(CInt(ACAC(CInt(AGA) - 1)))) : B400.Visibility = 0
    CA_.Background = B401.Background : Select Case ACAC(CInt(AGA) - 1) : Case 0, 2, 8
        B401.Foreground = New SolidColorBrush(Colors.White) : End Select : B300.Visibility = 1
    AAB = 6
    AGA = If(CByte(AGA) < 10, "00", If(CByte(AGA) < 100, "0", "")) & AGA : EB_.Visibility = 1
    FD_.Text = A_B.GetString("A" & AGA) : FC_.Text = (A_A.GetString("B" & AGA) & "          ").
      Substring(0, 10) & A_D.GetString("B" & AGA) : If B400.RowDefinitions.Count > 0 Then Exit Sub

    Dim aaaaa As New Grid : Dim aaaab As TextBlock : Dim aaaac As New GridLength(7, 2)
    B400.ColumnDefinitions.Add(New ColumnDefinition) : B400.RowDefinitions.Add(New RowDefinition)
    B400.ColumnDefinitions.Add(New ColumnDefinition) : B400.RowDefinitions.Add(New RowDefinition)
    B400.ColumnDefinitions.Add(New ColumnDefinition) : B400.RowDefinitions.Add(New RowDefinition)
    aaaaa.ColumnDefinitions.Add(New ColumnDefinition) : aaaaa.RowDefinitions.Add(New RowDefinition)
    aaaaa.ColumnDefinitions.Add(New ColumnDefinition) : aaaaa.RowDefinitions.Add(New RowDefinition)
    aaaaa.ColumnDefinitions.Add(New ColumnDefinition) : aaaaa.RowDefinitions.Add(New RowDefinition)

    B400.RowDefinitions.Item(1).Height = aaaac : B400.ColumnDefinitions.Item(1).Width = aaaac
    aaaaa.RowDefinitions.Item(2).Height = aaaac : aaaaa.ColumnDefinitions.Item(0).Width = aaaac
    aaaaa.ColumnDefinitions.Item(2).Width = New GridLength(2, 2) : FC_.FontSize = 16
    B401.Content = aaaaa : FD_.FontSize = 16

    aaaaa.Children.Add(FC_) : Grid.SetRow(FC_, 0) : Grid.SetColumn(FC_, 0)
    aaaaa.Children.Add(FD_) : Grid.SetRow(FD_, 2) : Grid.SetColumn(FD_, 2) : Grid.SetRow(B400, 2)
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
#Region "D-AA"
  Private Sub DAAA()
    '1     Formeln Laden
    Select Case DGA
      Case "a" : DՃA = New String() {
         "a ax", "a = ax", "", "0", "4",
         "a ay", "a = ay", "", "0", "",
         "a az", "a = az", "", "0", "",
         "a ax θ", "a = ax : cos(θ)", "", "0", "",
         "a ay θ", "a = ay : sin(θ)", "", "0", "",
         "a az θ", "a = az : cos(θ)", "", "0", "",
         "a ax θ ϕ", "a = ax : cos(θ) : sin(ϕ)", "", "0", "",
         "a az θ ϕ", "a = az : cos(θ) : cos(ϕ)", "", "0", "",
         "a ax ay", "a = √(ax ^ 2 + ay ^ 2)", "", "0", "",
         "a ax az", "a = √(ax ^ 2 + az ^ 2)", "", "0", "",
         "a ay az", "a = √(ay ^ 2 + az ^ 2)", "", "0", "",
         "a ax ay az", "a = √(ax ^ 2 + ay ^ 2 + az ^ 2)", "", "0", "",
         "a F k P v1", "a = -2 k P (P : F - v1) : F ^ 2", "a F k v1 {v}", "62", "",
         "a F k P v2", "a = -2 k P (v2 - P : F) : F ^ 2", "a F k v1 {v}", "62", "",
         "a F k P Δv", "a = -k P Δv : F ^ 2", "a F k Δv {v}", "62", "",
         "a F k Δt v1", "a = -2 (F : k : Δt + v1) : Δt", "a Δs Δt v1", "59", "",
         "a F k Δt v2", "a = 2 (v2 + F : k : Δt) : Δt", "a Δs Δt v2", "59", "",
         "a F k v1 v2", "a = -k (v2 ^ 2 - v1 ^ 2) : F : 2", "a F k Δv {v}", "19", "",
         "a F k v1 Δv", "a = -k Δv (v1 + Δv : 2) : F", "a F k Δv {v}", "18", "",
         "a F k v1 {v}", "a = -2 k {v} ({v} - v1) : F", "a F k Δv {v}", "16", "",
         "a F k v2 Δv", "a = -k Δv (v2 - Δv : 2) : F", "a F k Δv {v}", "15", "",
         "a F k v2 {v}", "a = -2 k {v} (v2 - {v}) : F", "a F k Δv {v}", "13", "",
         "a F k Δv {v}", "a = -k Δv {v} : F", "a k m Δv {v}", "28", "",
         "a F m", "a = F : m", "", "27", "",
         "a F P Δs v1", "a = 2 (P ^ 2 : F - v1 P) : F : Δs", "a F P v1 W", "29", "",
         "a F P Δs v2", "a = 2 (P v2 - P ^ 2 : F) : F : Δs", "a F P v2 W", "29", "",
         "a F P Δs Δv", "a = P Δv : F : Δs", "a P Δv W", "29", "",
         "a F P Δt v1", "a = 2 (P : F - v1) : Δt", "a F Δt v1 W", "62", "",
         "a F P Δt v2", "a = 2 (v2 - P : F) : Δt", "a F Δt v2 W", "62", "",
         "a F P v1 W", "a = 2 P (P : F - v1) : W", "a F P Δt v1", "43", "",
         "a F P v2 W", "a = 2 P (v2 - P : F) : W", "a F P Δt v2", "43", "",
         "a F Δt v1 W", "a = 2 (W : F : Δt - v1) : Δt", "a Δs Δt v1", "31", "",
         "a F Δt v2 W", "a = 2 (v2 - W : F : Δt) : Δt", "a Δs Δt v2", "31", "",
         "a F v1 v2 W", "a = F (v2 ^ 2 - v1 ^ 2) : W : 2", "a F Δv {v} W", "19", "",
         "a F v1 Δv W", "a = F Δv (v1 + Δv : 2) : W", "a F Δv {v} W", "18", "",
         "a F v1 {v} W", "a = 2 F {v} ({v} - v1) : W", "a F Δv {v} W", "16", "",
         "a F v2 Δv W", "a = F Δv (v2 - Δv : 2) : W", "a F Δv {v} W", "15", "",
         "a F v2 {v} W", "a = 2 F {v} (v2 - {v}) : W", "a F Δv {v} W", "13", "",
         "a F Δv {v} W", "a = F Δv {v} : W", "a Δs Δv {v}", "31", "",
         "a |Fn| m μg", "a = |Fn| μg : m", "a F m", "85", "",
         "a |Fn| m μh", "a = |Fn| μh : m", "a F m", "88", "",
         "a |Fn| m μr", "a = |Fn| μr : m", "a F m", "91", "",
         "a |Fn| μg P Δs v1", "a = 2 P (P : |Fn| : μg - v1) : |Fn| : μg : Δs", "a F P Δs v1", "85", "",
         "a |Fn| μg P Δs v2", "a = 2 P (v2 - P : |Fn| : μg) : |Fn| : μg : Δs", "a F P Δs v2", "85", "",
         "a |Fn| μg P Δs Δv", "a = P Δv : |Fn| : μg : Δs", "a F P Δs Δv", "85", "",
         "a |Fn| μg P Δt v1", "a = 2 (P : |Fn| : μg - v1) : Δt", "a F P Δt v1", "85", "",
         "a |Fn| μg P Δt v2", "a = 2 (v2 - P : |Fn| : μg) : Δt", "a F P Δt v2", "85", "",
         "a |Fn| μg P v1 W", "a = 2 P (P : |Fn| : μg - v1) : W", "a F P v1 W", "85", "",
         "a |Fn| μg P v2 W", "a = 2 P (v2 - P : |Fn| : μg) : W", "a F P v2 W", "85", "",
         "a |Fn| μg Δt v1 W", "a = 2 (W : |Fn| : μg : Δt - v1) : Δt", "a F Δt v1 W", "85", "",
         "a |Fn| μg Δt v2 W", "a = 2 (v2 - W : |Fn| : μg : Δt) : Δt", "a F Δt v2 W", "85", "",
         "a |Fn| μg v1 v2 W", "a = |Fn| μg (v2 ^ 2 - v1 ^ 2) : 2 : W", "a F v1 v2 W", "85", "",
         "a |Fn| μg v1 Δv W", "a = |Fn| μg Δv (v1 + Δv : 2) : W", "a F v1 Δv W", "85", "",
         "a |Fn| μg v1 {v} W", "a = 2 |Fn| μg {v} ({v} - v1) : W", "a F v1 {v} W", "85", "",
         "a |Fn| μg v2 Δv W", "a = |Fn| μg (v2 - Δv : 2) Δv : W", "a F v2 Δv W", "85", "",
         "a |Fn| μg v2 {v} W", "a = 2 |Fn| μg {v} (v2 - {v}) : W", "a F v2 {v} W", "85", "",
         "a |Fn| μg Δv {v} W", "a = |Fn| μg Δv {v} : W", "a F Δv {v} W", "85", "",
         "a |Fn| μh P Δs v1", "a = 2 P (P : |Fn| : μh - v1) : |Fn| : μh : Δs", "a F P Δs v1", "88", "",
         "a |Fn| μh P Δs v2", "a = 2 P (v2 - P : |Fn| : μh) : |Fn| : μh : Δs", "a F P Δs v2", "88", "",
         "a |Fn| μh P Δs Δv", "a = P Δv : |Fn| : μh : Δs", "a F P Δs Δv", "88", "",
         "a |Fn| μh P Δt v1", "a = 2 (P : |Fn| : μh - v1) : Δt", "a F P Δt v1", "88", "",
         "a |Fn| μh P Δt v2", "a = 2 (v2 - P : |Fn| : μh) : Δt", "a F P Δt v2", "88", "",
         "a |Fn| μh P v1 W", "a = 2 P (P : |Fn| : μh - v1) : W", "a F P v1 W", "88", "",
         "a |Fn| μh P v2 W", "a = 2 P (v2 - P : |Fn| : μh) : W", "a F P v2 W", "88", "",
         "a |Fn| μh Δt v1 W", "a = 2 (W : |Fn| : μh : Δt - v1) : Δt", "a F Δt v1 W", "88", "",
         "a |Fn| μh Δt v2 W", "a = 2 (v2 - W : |Fn| : μh : Δt) : Δt", "a F Δt v2 W", "88", "",
         "a |Fn| μh v1 v2 W", "a = |Fn| μh (v2 ^ 2 - v1 ^ 2) : 2 : W", "a F v1 v2 W", "88", "",
         "a |Fn| μh v1 Δv W", "a = |Fn| μh Δv (v1 + Δv : 2) : W", "a F v1 Δv W", "88", "",
         "a |Fn| μh v1 {v} W", "a = 2 |Fn| μh {v} ({v} - v1) : W", "a F v1 {v} W", "88", "",
         "a |Fn| μh v2 Δv W", "a = |Fn| μh (v2 - Δv : 2) Δv : W", "a F v2 Δv W", "88", "",
         "a |Fn| μh v2 {v} W", "a = 2 |Fn| μh {v} (v2 - {v}) : W", "a F v2 {v} W", "88", "",
         "a |Fn| μh Δv {v} W", "a = |Fn| μh Δv {v} : W", "a F Δv {v} W", "88", "",
         "a |Fn| μr P Δs v1", "a = 2 P (P : |Fn| : μr - v1) : |Fn| : μr : Δs", "a F P Δs v1", "91", "",
         "a |Fn| μr P Δs v2", "a = 2 P (v2 - P : |Fn| : μr) : |Fn| : μr : Δs", "a F P Δs v2", "91", "",
         "a |Fn| μr P Δs Δv", "a = P Δv : |Fn| : μr : Δs", "a F P Δs Δv", "91", "",
         "a |Fn| μr P Δt v1", "a = 2 (P : |Fn| : μr - v1) : Δt", "a F P Δt v1", "91", "",
         "a |Fn| μr P Δt v2", "a = 2 (v2 - P : |Fn| : μr) : Δt", "a F P Δt v2", "91", "",
         "a |Fn| μr P v1 W", "a = 2 P (P : |Fn| : μr - v1) : W", "a F P v1 W", "91", "",
         "a |Fn| μr P v2 W", "a = 2 P (v2 - P : |Fn| : μr) : W", "a F P v2 W", "91", "",
         "a |Fn| μr Δt v1 W", "a = 2 (W : |Fn| : μr : Δt - v1) : Δt", "a F Δt v1 W", "91", "",
         "a |Fn| μr Δt v2 W", "a = 2 (v2 - W : |Fn| : μr : Δt) : Δt", "a F Δt v2 W", "91", "",
         "a |Fn| μr v1 v2 W", "a = |Fn| μr (v2 ^ 2 - v1 ^ 2) : 2 : W", "a F v1 v2 W", "91", "",
         "a |Fn| μr v1 Δv W", "a = |Fn| μr Δv (v1 + Δv : 2) : W", "a F v1 Δv W", "91", "",
         "a |Fn| μr v1 {v} W", "a = 2 |Fn| μr {v} ({v} - v1) : W", "a F v1 {v} W", "91", "",
         "a |Fn| μr v2 Δv W", "a = |Fn| μr (v2 - Δv : 2) Δv : W", "a F v2 Δv W", "91", "",
         "a |Fn| μr v2 {v} W", "a = 2 |Fn| μr {v} (v2 - {v}) : W", "a F v2 {v} W", "91", "",
         "a |Fn| μr Δv {v} W", "a = |Fn| μr Δv {v} : W", "a F Δv {v} W", "91", "",
         "a k m P Δt", "a = √(-k P Δt) : m", "a k m W", "44", "",
         "a k m P Δv", "a = √(-k P Δv : m ^ 2 ' 3)", "a k m P Δt", "25", "",
         "a k m Δs", "a = -k Δs : m", "a F m", "57", "",
         "a k m Δt v1", "a = -v1 : (Δt : 2 + m : k : Δt)", "a F k Δt v1", "26", "",
         "a k m Δt v2", "a = v2 : (Δt : 2 - m : k : Δt)", "a F k Δt v2", "26", "",
         "a k m Δt {v}", "a = -k Δt {v} : m", "a k m Δs", "21", "",
         "a k m v1 v2", "a = √(-k (v2 ^ 2 - v1 ^ 2) : m : 2)", "a k m Δv {v}", "19", "",
         "a k m v1 Δv", "a = √(-k Δv (v1 + Δv : 2) : m)", "a k m Δv {v}", "18", "",
         "a k m v1 {v}", "a = √(-2 k {v} ({v} - v1) : m)", "a k m Δv {v}", "16", "",
         "a k m v2 Δv", "a = √(-k Δv (v2 - Δv : 2) : m)", "a k m Δv {v}", "15", "",
         "a k m v2 {v}", "a = √(-2 k {v} (v2 - {v}) : m)", "a k m Δv {v}", "13", "",
         "a k m Δv {v}", "a = √(-k Δv {v} : m)", "a k m Δt {v}", "25", "",
         "a k m W", "a = √(-k W) : m", "a k m Δv {v}", "75", "",
         "a k P Δs v1", "a = 2 P (P : k : Δs + v1) : k : Δs ^ 2", "a F P Δs v1", "57", "",
         "a k P Δs v2", "a = -2 P (v2 + P : k : Δs) : k : Δs ^ 2", "a F P Δs v2", "57", "",
         "a k P Δs Δv", "a = -P Δv : k : Δs ^ 2", "a F k P Δv", "57", "",
         "a k P Δt v1", "a = 2 (√(-P : k : Δt) - v1) : Δt", "a k Δt v1 W", "44", "",
         "a k P Δt v2", "a = 2 (v2 - √(-P : k : Δt)) : Δt", "a k Δt v2 W", "44", "",
         "a k P v1 v2", "a = -k (v2 - v1) (v1 + v2) ^ 2 : P : 4", "a k P Δv {v}", "19", "",
         "a k P v1 Δv", "a = -k Δv (v1 + Δv : 2) ^ 2 : P", "a k P Δv {v}", "18", "",
         "a k P v1 {v}", "a = -2 k ({v} - v1) {v} ^ 2 : P", "a k P Δv {v}", "16", "",
         "a k P v1 W", "a = 2 P (√(-(P ^ 2) : k : W) - v1) : W", "a k Δt v1 W", "43", "",
         "a k P v2 Δv", "a = -k Δv (v2 - Δv : 2) ^ 2 : P", "a k P Δv {v}", "15", "",
         "a k P v2 {v}", "a = -2 k (v2 - {v}) {v} ^ 2 : P", "a k P Δv {v}", "13", "",
         "a k P v2 W", "a = 2 P (v2 - √(-(P ^ 2) : k : W)) : W", "a k Δt v2 W", "43", "",
         "a k P Δv {v}", "a = -k Δv {v} ^ 2 : P", "a F k Δv {v}", "61", "",
         "a k Δt v1 W", "a = 2 (√(-W : k) : Δt - v1) : Δt", "a k v1 Δv W", "24", "",
         "a k Δt v2 W", "a = 2 (v2 - √(-W : k) : Δt) : Δt", "a k v2 Δv W", "24", "",
         "a k v1 v2 W", "a = √(-k : W) (v2 ^ 2 - v1 ^ 2) : 2", "a k Δv {v} W", "19", "",
         "a k v1 Δv W", "a = √(-k : W) Δv (v1 + Δv : 2)", "a k Δv {v} W", "18", "",
         "a k v1 {v} W", "a = 2 √(-k : W) {v} ({v} - v1)", "a k Δv {v} W", "16", "",
         "a k v2 Δv W", "a = √(-k : W) Δv (v2 - Δv : 2)", "a k Δv {v} W", "15", "",
         "a k v2 {v} W", "a = 2 √(-k : W) {v} (v2 - {v})", "a k Δv {v} W", "13", "",
         "a k Δv {v} W", "a = √(-k : W) Δv {v}", "a k m Δv {v}", "78", "",
         "a m P Δs Δt", "a = P Δt : m : Δs", "a m Δs W", "44", "",
         "a m P Δs Δv", "a = √(P Δv : m : Δs)", "a F P Δs Δv", "26", "",
         "a m P Δt v1", "a = (-v1 ± √(v1 ^ 2 + 2 P Δt : m)) : Δt", "a m Δt v1 W", "44", "",
         "a m P Δt v2", "a = (v2 ± √(v2 ^ 2 - 2 P Δt : m)) : Δt", "a m Δt v2 W", "44", "",
         "a m P v1 v2", "a = 2 P : m : (v1 + v2)", "a m P {v}", "10", "",
         "a m P v1 Δv", "a = P : m : (v1 + Δv : 2)", "a m P {v}", "18", "",
         "a m P v1 W", "a = 2 P : m : (v1 ± √(v1 ^ 2 + 2 W : m))", "a m Δt v1 W", "43", "",
         "a m P v2 Δv", "a = P : m : (v2 - Δv : 2)", "a m P {v}", "15", "",
         "a m P v2 W", "a = 2 P : m : (v2 ± √(v2 ^ 2 - 2 W : m))", "a m Δt v2 W", "43", "",
         "a m P {v}", "a = P : m : {v}", "a m Δt {v} W", "61", "",
         "a m Δs W", "a = W : m : Δs", "a F m", "30", "",
         "a m Δt v1 W", "a = (-v1 ± √(v1 ^ 2 + 2 W : m)) : Δt", "a F Δt v1 W", "26", "",
         "a m Δt v2 W", "a = (v2 ± √(v2 ^ 2 - 2 W : m)) : Δt", "a F Δt v2 W", "26", "",
         "a m Δt {v} W", "a = W : m : Δt : {v}", "a m Δs W", "21", "",
         "a P Δs v1 W", "a = 2 P (P Δs : W - v1) : W", "a F P v1 W", "30", "",
         "a P Δs v2 W", "a = 2 P (v2 - P Δs : W) : W", "a F P v2 W", "30", "",
         "a P v1 {v} W", "a = 2 P ({v} - v1) : W", "a Δt v1 {v}", "43", "",
         "a P v2 {v} W", "a = 2 P (v2 - {v}) : W", "a Δt v2 {v}", "43", "",
         "a P Δv W", "a = P Δv : W", "a Δt Δv", "43", "",
         "a Δs Δt v1", "a = 2 (Δs : Δt - v1) : Δt", "a Δt v1 {v}", "20", "",
         "a Δs Δt v2", "a = 2 (v2 - Δs : Δt) : Δt", "a Δt v2 {v}", "20", "",
         "a Δs v1 v2", "a = (v2 ^ 2 - v1 ^ 2) : Δs : 2", "a Δs Δv {v}", "19", "",
         "a Δs v1 Δv", "a = (v1 + Δv : 2) Δv : Δs", "a Δs Δv {v}", "18", "",
         "a Δs v1 {v}", "a = 2 {v} ({v} - v1) : Δs", "a Δs Δv {v}", "16", "",
         "a Δs v2 Δv", "a = Δv (v2 - Δv : 2) : Δs", "a Δs Δv {v}", "15", "",
         "a Δs v2 {v}", "a = 2 {v} (v2 - {v}) : Δs", "a Δs Δv {v}", "13", "",
         "a Δs Δv {v}", "a = Δv {v} : Δs", "a Δt Δv", "22", "", "",
         "a Δt v1 {v}", "a = 2 ({v} - v1) : Δt", "a Δt Δv", "16", "",
         "a Δt v2 {v}", "a = 2 (v2 - {v}) : Δt", "a Δt Δv", "13", "",
         "a Δt Δv", "a = Δv : Δt", "", "23", ""} ' a => 10074
      Case "c" : DՃA = New String() {
         "c M m V", "c = m : M : V", "c n V", "50", "",
         "c n V", "c = n : V", "", "45", ""} ' c => 2
      Case "F" : DՃA = New String() {
         "F a k P Δv", "F = √(-k P Δv : a)", "F k P Δt", "25", "",
         "F a k Δt v1", "F = -k Δt (v1 + a Δt : 2)", "F k Δt v1 Δv", "24", "",
         "F a k Δt v2", "F = -k Δt (v2 - a Δt : 2)", "F k Δt v2 Δv", "24", "",
         "F a k v1 v2", "F = -k (v2 ^ 2 - v1 ^ 2) : a : 2", "F a k Δv {v}", "19", "",
         "F a k v1 Δv", "F = -k Δv (v1 + Δv : 2) : a", "F a k Δv {v}", "18", "",
         "F a k v1 {v}", "F = -2 k {v} ({v} - v1) : a", "F a k Δv {v}", "16", "",
         "F a k v2 Δv", "F = -k Δv (v2 - Δv : 2) : a", "F a k Δv {v}", "15", "",
         "F a k v2 {v}", "F = -2 k {v} (v2 - {v}) : a", "F a k Δv {v}", "13", "",
         "F a k Δv {v}", "F = -k Δv {v} : a", "F k Δt {v}", "25", "",
         "F a m", "F = a m", "", "26", "",
         "F a P Δs v1", "F = P (-v1 ± √(v1 ^ 2 + 2 a Δs)) : a : Δs", "F a P v1 W", "29", "",
         "F a P Δs v2", "F = P (v2 ± √(v2 ^ 2 - 2 a Δs)) : a : Δs", "F a P v2 W", "29", "",
         "F a P Δs Δv", "F = P Δv : a : Δs", "F P Δs Δt", "25", "",
         "F a P Δt v1", "F = P : (v1 + a Δt : 2)", "F P v1 Δv", "24", "",
         "F a P Δt v2", "F = P : (v2 - a Δt : 2)", "F P v2 Δv", "24", "",
         "F a P v1 W", "F = 2 a W : ((a W : P) ^ 2 + 2 a v1 W : P)", "F a P Δt v1", "43", "",
         "F a P v2 W", "F = 2 a W : (2 a v2 W : P - (a W : P) ^ 2)", "F a P Δt v2", "43", "",
         "F a Δt v1 W", "F = W : Δt : (v1 + a Δt : 2)", "F Δt v1 Δv W", "24", "",
         "F a Δt v2 W", "F = W : Δt : (v2 - a Δt : 2)", "F Δt v2 Δv W", "24", "",
         "F a v1 v2 W", "F = 2 a W : (v2 ^ 2 - v1 ^ 2)", "F a Δv {v} W", "19", "",
         "F a v1 Δv W", "F = a W : Δv : (v1 + Δv : 2)", "F a Δv {v} W", "18", "",
         "F a v1 {v} W", "F = a W : {v} : ({v} - v1) : 2", "F a Δv {v} W", "16", "",
         "F a v2 Δv W", "F = a W : Δv : (v2 - Δv : 2)", "F a Δv {v} W", "15", "",
         "F a v2 {v} W", "F = a W : {v} : (v2 - {v}) : 2", "F a Δv {v} W", "13", "",
         "F a Δv {v} W", "F = a W : Δv : {v}", "F Δt {v} W", "25", "",
         "F Ff", "F = Ff", "", "0", "",
         "F Ff Frg", "F = Ff + Frg", "", "0", "",
         "F Ff Frg Ft", "F = Ft + Ff + Frg", "", "0", "",
         "F Ff Frh", "F = Ff + Frh", "", "0", "",
         "F Ff Frh Ft", "F = Ft + Ff + Frh", "", "0", "",
         "F Ff Frr", "F = Ff + Frr", "", "0", "",
         "F Ff Frr Ft", "F = Ft + Ff + Frr", "", "0", "",
         "F Ff |Fn| μg", "F = Ff + μg |Fn|", "", "0", "",
         "F Ff |Fn| μh", "F = Ff + μh |Fn|", "", "0", "",
         "F Ff |Fn| μr", "F = Ff + μr |Fn|", "", "0", "",
         "F Ff |Fn| Ft μg", "F = Ft + Ff + μg |Fn|", "", "0", "",
         "F Ff |Fn| Ft μh", "F = Ft + Ff + μh |Fn|", "", "0", "",
         "F Ff |Fn| Ft μr", "F = Ft + Ff + μr |Fn|", "", "0", "",
         "F Ff Ft", "F = Ft + Ff", "", "0", "",
         "F |Fn| Ft k μg Δs", "F = Ft + μg |Fn| - k Δs", "", "0", "",
         "F |Fn| Ft k μh Δs", "F = Ft + μh |Fn| - k Δs", "", "0", "",
         "F |Fn| Ft k μr Δs", "F = Ft + μr |Fn| - k Δs", "", "0", "",
         "F |Fn| Ft μg", "F = Ft + μg |Fn|", "", "0", "",
         "F |Fn| Ft μh", "F = Ft + μh |Fn|", "", "0", "",
         "F |Fn| Ft μr", "F = Ft + μr |Fn|", "", "0", "",
         "F |Fn| k μg Δs", "F = μg |Fn| - k Δs", "", "0", "",
         "F |Fn| k μh Δs", "F = μh |Fn| - k Δs", "", "0", "",
         "F |Fn| k μr Δs", "F = μr |Fn| - k Δs", "", "0", "",
         "F |Fn| μg", "F = μg |Fn|", "", "0", "",
         "F |Fn| μh", "F = μh |Fn|", "", "0", "",
         "F |Fn| μr", "F = μr |Fn|", "", "0", "",
         "F Frg", "F = Frg", "", "0", "",
         "F Frg Ft", "F = Ft + Frg", "", "0", "",
         "F Frg Ft k Δs", "F = Ft + Frg - k Δs", "", "0", "",
         "F Frg k Δs", "F = Frg - k Δs", "", "0", "",
         "F Frh", "F = Frh", "", "0", "",
         "F Frh Ft", "F = Ft + Frh", "", "0", "",
         "F Frh Ft k Δs", "F = Ft + Frh - k Δs", "", "0", "",
         "F Frh k Δs", "F = Frh - k Δs", "", "0", "",
         "F Frr", "F = Frr", "", "0", "",
         "F Frr Ft", "F = Ft + Frr", "", "0", "",
         "F Frr Ft k Δs", "F = Ft + Frr - k Δs", "", "0", "",
         "F Frr k Δs", "F = Frr - k Δs", "", "0", "",
         "F Ft k Δs", "F = Ft - k Δs", "", "0", "",
         "F Fx", "F = Fx", "", "0", "",
         "F Fy", "F = Fy", "", "0", "",
         "F Fz", "F = Fz", "", "0", "",
         "F Fx θ", "F = Fx : cos(θ)", "", "0", "",
         "F Fy θ", "F = Fy : sin(θ)", "", "0", "",
         "F Fz θ", "F = Fz : cos(θ)", "", "0", "",
         "F Fx θ ϕ", "F = Fx : cos(θ) : sin(ϕ)", "", "0", "",
         "F Fz θ ϕ", "F = Fz : cos(θ) : cos(ϕ)", "", "0", "",
         "F Fx Fy", "F = √(Fx ^ 2 + Fy ^ 2)", "", "0", "",
         "F Fx Fz", "F = √(Fx ^ 2 + Fz ^ 2)", "", "0", "",
         "F Fy Fz", "F = √(Fy ^ 2 + Fz ^ 2)", "", "0", "",
         "F Fx Fy Fz", "F = √(Fx ^ 2 + Fy ^ 2 + Fz ^ 2)", "", "0", "",
         "F k m P Δv", "F = √(-k m P Δv ' 3)", "F a k P Δv", "27", "",
         "F k m Δt v1", "F = -v1 : (1 : k : Δt + Δt : m : 2)", "F a k Δt v1", "27", "",
         "F k m Δt v2", "F = v2 : (Δt : m : 2 - 1 : k : Δt)", "F a k Δt v2", "27", "",
         "F k m v1 v2", "F = √(-k m (v2 ^ 2 - v1 ^ 2) : 2)", "F k m Δv {v}", "19", "",
         "F k m v1 Δv", "F = √(-k m Δv (v1 + Δv : 2))", "F k m Δv {v}", "18", "",
         "F k m v1 {v}", "F = √(-2 k m {v} ({v} - v1))", "F k m Δv {v}", "16", "",
         "F k m v2 Δv", "F = √(-k m Δv (v2 - Δv : 2))", "F k m Δv {v}", "15", "",
         "F k m v2 {v}", "F = √(-2 k m {v} (v2 - {v}))", "F k m Δv {v}", "13", "",
         "F k m Δv {v}", "F = √(-k m Δv {v})", "F a k Δv {v}", "27", "",
         "F k P Δt", "F = √(-k P Δt)", "F k W", "44", "",
         "F k Δs", "F = -k Δs", "", "57", "",
         "F k Δt v1 v2", "F = -k Δt (v1 + v2) : 2", "F k Δt {v}", "10", "",
         "F k Δt v1 Δv", "F = -k Δt (v1 + Δv : 2)", "F k Δt {v}", "18", "",
         "F k Δt v2 Δv", "F = -k Δt (v2 - Δv : 2)", "F k Δt {v}", "15", "",
         "F k Δt {v}", "F = -k Δt {v}", "F k Δs", "21", "",
         "F k W", "F = √(-k W)", "F k Δs", "31", "",
         "F m P Δs Δv", "F = √(P m Δv : Δs)", "F a P Δs Δv", "29", "",
         "F m P Δt v1", "F = m (-v1 ± √(v1 ^ 2 + 2 P Δt : m)) : Δt", "F m Δt v1 W", "44", "",
         "F m P Δt v2", "F = m (v2 ± √(v2 ^ 2 - 2 P Δt : m)) : Δt", "F m Δt v2 W", "44", "",
         "F m P v1 W", "F = m P (-v1 ± √(v1 ^ 2 + 2 W : m)) : W", "F m Δt v1 W", "43", "",
         "F m P v2 W", "F = m P (v2 ± √(v2 ^ 2 - 2 W : m)) : W", "F m Δt v2 W", "43", "",
         "F m P Δv W", "F = m P Δv : W", "F m Δt Δv", "43", "",
         "F m Δs Δt v1", "F = 2 m (Δs : Δt - v1) : Δt", "F m Δt v1 {v}", "20", "",
         "F m Δs Δt v2", "F = 2 m (v2 - Δs : Δt) : Δt", "F m Δt v2 {v}", "20", "",
         "F m Δs v1 v2", "F = m (v2 ^ 2 - v1 ^ 2) : Δs : 2", "F m Δs Δv {v}", "19", "",
         "F m Δs v1 Δv", "F = m Δv (v1 + Δv : 2) : Δs", "F m Δs Δv {v}", "18", "",
         "F m Δs v1 {v}", "F = 2 m {v} ({v} - v1) : Δs", "F m Δs Δv {v}", "16", "",
         "F m Δs v2 Δv", "F = m Δv (v2 - Δv : 2) : Δs", "F m Δs Δv {v}", "15", "",
         "F m Δs v2 {v}", "F = 2 m {v} (v2 - {v}) : Δs", "F m Δs Δv {v}", "13", "",
         "F m Δs Δv {v}", "F = m Δv {v} : Δs", "F m Δt Δv", "22", "",
         "F m Δt v1 {v}", "F = 2 m ({v} - v1) : Δt", "F m Δt Δv", "16", "",
         "F m Δt v1 W", "F = m (-v1 ± √(v1 ^ 2 + 2 W : m)) : Δt", "F m Δt Δv", "70", "",
         "F m Δt v2 {v}", "F = 2 m (v2 - {v}) : Δt", "F m Δt Δv", "13", "",
         "F m Δt v2 W", "F = m (v2 ± √(v2 ^ 2 - 2 W : m)) : Δt", "F m Δt Δv", "74", "",
         "F m Δt Δv", "F = m Δv : Δt", "F a m", "23", "",
         "F P Δs Δt", "F = P Δt : Δs", "F Δs W", "44", "",
         "F P v1 v2", "F = 2 P : (v1 + v2)", "F P {v}", "10", "",
         "F P v1 Δv", "F = P : (v1 + Δv : 2)", "F P {v}", "18", "",
         "F P v2 Δv", "F = P : (v2 - Δv : 2)", "F P {v}", "15", "",
         "F P {v}", "F = P : {v}", "F P Δs Δt", "21", "",
         "F Δs W", "F = W : Δs", "", "30", "",
         "F Δt v1 v2 W", "F = 2 W : Δt : (v1 + v2)", "F Δt {v} W", "10", "",
         "F Δt v1 Δv W", "F = W : Δt : (v1 + Δv : 2)", "F Δt {v} W", "18", "",
         "F Δt v2 Δv W", "F = W : Δt : (v2 - Δv : 2)", "F Δt {v} W", "15", "",
         "F Δt {v} W", "F = W : Δt : {v}", "F Δs W", "21", ""} ' F => 3912
      Case "k" : DՃA = New String() {
         "k a F P v1", "k = -a F ^ 2 : P : (P : F - v1) : 2", "k a F v1 {v}", "62", "",
         "k a F P v2", "k = -a F ^ 2 : P : (v2 - P : F) : 2", "k a F v2 {v}", "62", "",
         "k a F P Δv", "k = -a F ^ 2 : P : Δv", "k F P Δt", "25", "",
         "k a F Δt v1", "k = -F : Δt : (v1 + a Δt : 2)", "k F Δt v1 Δv", "24", "",
         "k a F Δt v2", "k = -F : Δt : (v2 - a Δt : 2)", "k F Δt v2 Δv", "24", "",
         "k a F v1 v2", "k = -2 a F : (v2 ^ 2 - v1 ^ 2)", "k a F Δv {v}", "19", "",
         "k a F v1 Δv", "k = -a F : Δv : (v1 + Δv : 2)", "k a F Δv {v}", "18", "",
         "k a F v1 {v}", "k = -a F : {v} : ({v} - v1) : 2", "k a F Δv {v}", "16", "",
         "k a F v2 Δv", "k = -a F : Δv : (v2 - Δv : 2)", "k a F Δv {v}", "15", "",
         "k a F v2 {v}", "k = -a F : {v} : (v2 - {v}) : 2", "k a F v2 {v}", "13", "",
         "k a F Δv {v}", "k = -a F : Δv : {v}", "k F Δt {v}", "25", "",
         "k a m P Δt", "k = -(a m) ^ 2 : P : Δt", "k F P Δt", "26", "",
         "k a m P v1", "k = -a ^ 3 m ^ 2 : P : (P : a : m - v1) : 2", "k a F P v1", "26", "",
         "k a m P v2", "k = -a ^ 3 m ^ 2 : P : (v2 - P : a : m) : 2", "k a F P v2", "26", "",
         "k a m P Δv", "k = -a ^ 3 m ^ 2 : P : Δv", "k a F P Δv", "26", "",
         "k a m Δs", "k = -a m : Δs", "k F Δs", "26", "",
         "k a m Δt v1", "k = -a m : Δt : (v1 + a Δt : 2)", "k a F Δt v1", "26", "",
         "k a m Δt v2", "k = -a m : Δt : (v2 - a Δt : 2)", "k a F Δt v2", "26", "",
         "k a m Δt {v}", "k = -a m : Δt : {v}", "k a m Δs", "21", "",
         "k a m v1 v2", "k = -2 a ^ 2 m : (v2 ^ 2 - v1 ^ 2)", "k a m Δv {v}", "19", "",
         "k a m v1 Δv", "k = -(a ^ 2) m : Δv : (v1 + Δv : 2)", "k a m Δv {v}", "18", "",
         "k a m v1 {v}", "k = -(a ^ 2) m : {v} : ({v} - v1) : 2", "k a m Δv {v}", "16", "",
         "k a m v2 Δv", "k = -(a ^ 2) m : Δv : (v2 - Δv : 2)", "k a m Δv {v}", "15", "",
         "k a m v2 {v}", "k = -(a ^ 2) m : {v} : (v2 - {v}) : 2", "k a m Δv {v}", "13", "",
         "k a m Δv {v}", "k = -(a ^ 2 m) : Δv : {v}", "k a F Δv {v}", "26", "",
         "k a m W", "k = -(a m) ^ 2 : W", "k F W", "26", "",
         "k a P Δs v1", "k = -P (-v1 ± √(v1 ^ 2 + 2 a Δs)) : a : Δs ^ 2", "k a F P v1", "57", "",
         "k a P Δs v2", "k = -P (v2 ± √(v2 ^ 2 - 2 a Δs)) : a : Δs ^ 2", "k a F P v2", "57", "",
         "k a P Δs Δv", "k = -P Δv : a : Δs ^ 2", "k P Δs Δt", "25", "",
         "k a P Δt v1", "k = -P : Δt : (v1 + a Δt : 2) ^ 2", "k P Δt v1 Δv", "24", "",
         "k a P Δt v2", "k = -P : Δt : (v2 - a Δt : 2) ^ 2", "k P Δt v2 Δv", "24", "",
         "k a P v1 v2", "k = -4 a P : (v2 ^ 2 - v1 ^ 2) : (v1 + v2)", "k a P Δv {v}", "19", "",
         "k a P v1 Δv", "k = -a P : Δv : (v1 + Δv : 2) ^ 2", "k a P Δv {v}", "18", "",
         "k a P v1 {v}", "k = -a P : ({v} - v1) : {v} ^ 2 : 2", "k a P Δv {v}", "16", "",
         "k a P v1 W", "k = -(P ^ 2) : W : (v1 + a W : P : 2) ^ 2", "k a P Δt v1", "43", "",
         "k a P v2 Δv", "k = -a P : Δv : (v2 - Δv : 2) ^ 2", "k a P Δv {v}", "15", "",
         "k a P v2 {v}", "k = -a P : (v2 - {v}) : {v} ^ 2 : 2", "k a P Δv {v}", "13", "",
         "k a P v2 W", "k = -(P ^ 2) : W : (v2 - a W : P : 2) ^ 2", "k a P Δt v2", "43", "",
         "k a P Δv {v}", "k = -a P : Δv : {v} ^ 2", "k P Δt {v}", "25", "",
         "k a Δt v1 W", "k = -W : (Δt (v1 + a Δt : 2)) ^ 2", "k Δt v1 Δv W", "24", "",
         "k a Δt v2 W", "k = -W : (Δt (v2 - a Δt : 2)) ^ 2", "k Δt v2 Δv W", "24", "",
         "k a v1 v2 W", "k = -4 a ^ 2 W : (v2 ^ 2 - v1 ^ 2) ^ 2", "k a Δv {v} W", "19", "",
         "k a v1 Δv W", "k = -(a ^ 2) W : ((v1 + Δv : 2) Δv) ^ 2", "k a Δv {v} W", "18", "",
         "k a v1 {v} W", "k = -(a ^ 2) W : (2 ({v} - v1) {v}) ^ 2", "k a Δv {v} W", "16", "",
         "k a v2 Δv W", "k = -(a ^ 2) W : ((v2 - Δv : 2) Δv) ^ 2", "k a Δv {v} W", "15", "",
         "k a v2 {v} W", "k = -(a ^ 2) W : (2 (v2 - {v}) {v}) ^ 2", "k a Δv {v} W", "13", "",
         "k a Δv {v} W", "k = -(a ^ 2) W : (Δv {v}) ^ 2", "k Δt {v} W", "25", "",
         "k F |Fn| Ft μg Δs", "k = (Ft + μg |Fn| - F): Δs", "", "0", "",
         "k F |Fn| Ft μh Δs", "k = (Ft + μh |Fn| - F): Δs", "", "0", "",
         "k F |Fn| Ft μr Δs", "k = (Ft + μr |Fn| - F): Δs", "", "0", "",
         "k F |Fn| μg Δs", "k = (μg |Fn| - F) : Δs", "", "0", "",
         "k F |Fn| μh Δs", "k = (μh |Fn| - F) : Δs", "", "0", "",
         "k F |Fn| μr Δs", "k = (μr |Fn| - F) : Δs", "", "0", "",
         "k F Frg Ft Δs", "k = (Ft + Frg - F) : Δs", "", "0", "",
         "k F Frh Ft Δs", "k = (Ft + Frh - F) : Δs", "", "0", "",
         "k F Frr Ft Δs", "k = (Ft + Frr - F) : Δs", "", "0", "",
         "k F Frg Δs", "k = (Frg - F) : Δs", "", "0", "",
         "k F Frh Δs", "k = (Frh - F) : Δs", "", "0", "",
         "k F Frr Δs", "k = (Frr - F) : Δs", "", "0", "",
         "k F Ft Δs", "k = (Ft - F) : Δs", "", "0", "",
         "k F m P v1", "k = -F ^ 3 : m : P : (P : F - v1) : 2", "k a F P v1", "27", "",
         "k F m P v2", "k = -F ^ 3 : m : P : (v2 - P : F) : 2", "k a F P v2", "27", "",
         "k F m P Δv", "k = -F ^ 3 : P : m : Δv", "k a F P Δv", "27", "",
         "k F m Δt v1", "k = -F : Δt : (v1 + F Δt : m : 2)", "k a F Δt v1", "27", "",
         "k F m Δt v2", "k = -F : Δt : (v2 - F Δt : m : 2)", "k a F Δt v2", "27", "",
         "k F m v1 v2", "k = -2 F ^ 2 : m : (v2 ^ 2 - v1 ^ 2)", "k F m Δv {v}", "19", "",
         "k F m v1 Δv", "k = -(F ^ 2) : m : Δv : (v1 + Δv : 2)", "k F m Δv {v}", "18", "",
         "k F m v1 {v}", "k = -(F ^ 2) : m : {v} : ({v} - v1) : 2", "k F m Δv {v}", "16", "",
         "k F m v2 Δv", "k = -(F ^ 2) : m : Δv : (v2 - Δv : 2)", "k F m Δv {v}", "15", "",
         "k F m v2 {v}", "k = -(F ^ 2) : m : {v} : (v2 - {v}) : 2", "k F m Δv {v}", "13", "",
         "k F m Δv {v}", "k = -(F ^ 2) : m : Δv : {v}", "k a F Δv {v}", "27", "",
         "k F P Δt", "k = -(F ^ 2) : P : Δt", "k F W", "44", "",
         "k F Δs", "k = -F : Δs", "", "58", "",
         "k F Δt v1 v2", "k = -2 F : Δt : (v1 + v2)", "k F Δt {v}", "10", "",
         "k F Δt v1 Δv", "k = -F : Δt : (v1 + Δv : 2)", "k F Δt {v}", "18", "",
         "k F Δt v2 Δv", "k = -F : Δt : (v2 - Δv : 2)", "k F Δt {v}", "15", "",
         "k F Δt {v}", "k = -F : Δt : {v}", "k F Δs", "21", "",
         "k F W", "k = -(F ^ 2) : W", "k F Δs", "59", "",
         "k Ff Δs", "k = -Ff : Δs", "", "0", "",
         "k m P Δs Δv", "k = -√ (P m Δv : Δs ^ 3)", "k F m P Δv", "57", "",
         "k m P Δt v1", "k = -4 P : Δt : (v1 ± √(v1 ^ 2 + 2 P Δt : m)) ^ 2", "k m Δt v1 W", "44", "",
         "k m P Δt v2", "k = -4 P : Δt : (v2 ± √(v2 ^ 2 - 2 P Δt : m)) ^ 2", "k m Δt v2 W", "44", "",
         "k m P Δt Δv", "k = -(m Δv) ^ 2 : P : Δt ^ 3", "k m Δt Δv W", "44", "",
         "k m P v1 v2", "k = -8 P ^ 2 : m : (v2 - v1) : (v1 + v2) ^ 3", "k m P Δv {v}", "19", "",
         "k m P v1 Δv", "k = -(P ^ 2) : m : Δv : (v1 + Δv : 2) ^ 3", "k m P Δv {v}", "18", "",
         "k m P v1 {v}", "k = -(P ^ 2) : m : {v} ^ 3 : ({v} - v1) : 2", "k m P Δv {v}", "16", "",
         "k m P v1 W", "k = -4 P ^ 2 : W : (v1 ± √(v1 ^ 2 + 2 W : m)) ^ 2", "k m P Δt v1", "43", "",
         "k m P v2 Δv", "k = -(P ^ 2) : m : Δv : (v2 - Δv : 2) ^ 3", "k m P Δv {v}", "15", "",
         "k m P v2 {v}", "k = -(P ^ 2) : m : {v} ^ 3 : (v2 - {v}) : 2", "k m P Δv {v}", "13", "",
         "k m P v2 W", "k = -4 P ^ 2 : W : (v2 ± √(v2 ^ 2 - 2 W : m)) ^ 2", "k m P Δt v2", "43", "",
         "k m P Δv {v}", "k = -(P ^ 2) : m : Δv : {v} ^ 3", "k P {v} W", "63", "",
         "k m P Δv W", "k = -(m P Δv) ^ 2 : W ^ 3", "k m Δt Δv W", "43", "",
         "k m Δs Δt v1", "k = -2 m (Δs : Δt - v1) : Δs : Δt", "k m Δs v1 {v}", "20", "",
         "k m Δs Δt v2", "k = -2 m (v2 - Δs : Δt) : Δs : Δt", "k m Δs v2 {v}", "20", "",
         "k m Δs Δt Δv", "k = -m Δv : Δs : Δt", "k a m Δs", "23", "",
         "k m Δs v1 v2", "k = -m (v2 ^ 2 - v1 ^ 2) : Δs ^ 2 : 2", "k m Δs Δv {v}", "19", "",
         "k m Δs v1 Δv", "k = -m Δv (v1 + Δv : 2) : Δs ^ 2", "k m Δs Δv {v}", "18", "",
         "k m Δs v1 {v}", "k = -2 m {v} ({v} - v1) : Δs ^ 2", "k m Δs Δv {v}", "16", "",
         "k m Δs v2 Δv", "k = -m Δv (v2 - Δv : 2) : Δs ^ 2", "k m Δs Δv {v}", "15", "",
         "k m Δs v2 {v}", "k = -2 m {v} (v2 - {v}) : Δs ^ 2", "k m Δs Δv {v}", "13", "",
         "k m Δs Δv {v}", "k = -m Δv {v} : Δs ^ 2", "k m Δs Δt Δv", "22", "",
         "k m Δt v1 v2", "k = -2 m (v2 - v1) : Δt ^ 2 : (v1 + v2)", "k m Δt Δv {v}", "19", "",
         "k m Δt v1 Δv", "k = -m Δv : Δt ^ 2 : (v1 + Δv : 2)", "k m Δt Δv {v}", "18", "",
         "k m Δt v1 {v}", "k = -2 m ({v} - v1) : Δt ^ 2 : {v}", "k m Δt Δv {v}", "16", "",
         "k m Δt v1 W", "k = -4 W : (Δt (v1 ± √(v1 ^ 2 + 2 W : m))) ^ 2", "k Δt v1 Δv W", "70", "",
         "k m Δt v2 Δv", "k = -m Δv : Δt ^ 2 : (v2 - Δv : 2)", "k m Δt Δv {v}", "15", "",
         "k m Δt v2 {v}", "k = -2 m (v2 - {v}) : Δt ^ 2 : {v}", "k m Δt Δv {v}", "13", "",
         "k m Δt v2 W", "k = -4 W : (Δt (v2 ± √(v2 ^ 2 - 2 W : m))) ^ 2", "k Δt v2 Δv W", "74", "",
         "k m Δt Δv {v}", "k = -m Δv : Δt ^ 2 : {v}", "k m Δs Δt Δv", "21", "",
         "k m Δt Δv W", "k = -(m Δv) ^ 2 : Δt ^ 2 : W", "k a m W", "23", "",
         "k P Δs Δt", "k = -P Δt : Δs ^ 2", "k Δs W", "44", "",
         "k P Δs v1 v2", "k = -2 P : Δs : (v1 + v2)", "k P Δs {v}", "10", "",
         "k P Δs v1 Δv", "k = -P : Δs : (v1 + Δv : 2)", "k P Δs {v}", "18", "",
         "k P Δs v2 Δv", "k = -P : Δs : (v2 - Δv : 2)", "k P Δs {v}", "15", "",
         "k P Δs {v}", "k = -P : Δs : {v}", "k P Δs Δt", "61", "",
         "k P Δt v1 v2", "k = -4 P : Δt : (v1 + v2) ^ 2", "k P Δt {v}", "10", "",
         "k P Δt v1 Δv", "k = -P : Δt : (v1 + Δv : 2) ^ 2", "k P Δt {v}", "18", "",
         "k P Δt v2 Δv", "k = -P : Δt : (v2 - Δv : 2) ^ 2", "k P Δt {v}", "15", "",
         "k P Δt {v}", "k = -P : Δt : {v} ^ 2", "k Δt {v} W", "21", "",
         "k P v1 v2 W", "k = -4 P ^ 2 : (v1 + v2) ^ 2 : W", "k P {v} W", "10", "",
         "k P v1 Δv W", "k = -(P ^ 2) : (v1 + Δv : 2) ^ 2 : W", "k P {v} W", "18", "",
         "k P v2 Δv W", "k = -(P ^ 2) : (v2 - Δv : 2) ^ 2 : W", "k P {v} W", "15", "",
         "k P {v} W", "k = -(P ^ 2) : {v} ^ 2 : W", "k Δt {v} W", "61", "",
         "k Δs W", "k = -W : Δs ^ 2", "k F Δs", "30", "",
         "k Δt v1 v2 W", "k = -4 W : (Δt (v1 + v2)) ^ 2", "k Δt {v} W", "10", "",
         "k Δt v1 Δv W", "k = -W : (Δt (v1 + Δv : 2)) ^ 2", "k Δt {v} W", "18", "",
         "k Δt v2 Δv W", "k = -W : (Δt (v2 - Δv : 2)) ^ 2", "k Δt {v} W", "15", "",
         "k Δt {v} W", "k = -W : (Δt {v}) ^ 2", "k Δs W", "21", ""} ' k => 4396
      Case "M" : DՃA = New String() {
         "M c m V", "M = m : c : V", "M m n", "46", "",
         "M m n", "M = m : n", "", "48", ""} ' M => 2
      Case "m" : DՃA = New String() {
         "m a F", "m = F : a", "", "28", "",
         "m a |Fn| μg", "m = |Fn| μg : a", "m a F", "85", "",
         "m a |Fn| μh", "m = |Fn| μh : a", "m a F", "88", "",
         "m a |Fn| μr", "m = |Fn| μr : a", "m a F", "91", "",
         "m a k P Δt", "m = √(-k P Δt) : a", "m a k W", "44", "",
         "m a k P Δv", "m = √(-k P Δv : a ^ 3)", "m a k P Δt", "25", "",
         "m a k Δs", "m = -k Δs : a", "m a F", "57", "",
         "m a k Δt v1", "m = -k Δt (v1 + a Δt : 2) : a", "m a k v1 Δv", "24", "",
         "m a k Δt v2", "m = -k Δt (v2 - a Δt : 2) : a", "m a k v2 Δv", "24", "",
         "m a k Δt {v}", "m = -k Δt {v} : a", "m a k Δs", "21", "",
         "m a k v1 v2", "m = -k (v2 ^ 2 - v1 ^ 2) : a ^ 2 : 2", "m a k Δv {v}", "19", "",
         "m a k v1 Δv", "m = -k Δv (v1 + Δv : 2) : a ^ 2", "m a k Δv {v}", "18", "",
         "m a k v1 {v}", "m = -2 k {v} ({v} - v1) : a ^ 2", "m a k Δv {v}", "16", "",
         "m a k v2 Δv", "m = -k Δv (v2 - Δv : 2) : a ^ 2", "m a k Δv {v}", "15", "",
         "m a k v2 {v}", "m = -2 k {v} (v2 - {v}) : a ^ 2", "m a k Δv {v}", "13", "",
         "m a k Δv {v}", "m = -k Δv {v} : a ^ 2", "m a k Δt {v}", "25", "",
         "m a k W", "m = √(-k W) : a", "m a F", "75", "",
         "m a P Δs Δt", "m = P Δt : a : Δs", "m a Δs W", "20", "",
         "m a P Δs v1", "m = P (-v1 ± √(v1 ^ 2 + 2 a Δs)) : a ^ 2 : Δs", "m F P Δs v1", "26", "",
         "m a P Δs v2", "m = P (v2 ± √(v2 ^ 2 - 2 a Δs)) : a ^ 2 : Δs", "m F P Δs v2", "26", "",
         "m a P Δs Δv", "m = P Δv : a ^ 2 : Δs", "m a P Δs Δt", "25", "",
         "m a P Δt v1", "m = P : a : (v1 + a Δt : 2)", "m a P v1 Δv", "24", "",
         "m a P Δt v2", "m = P : a : (v2 - a Δt : 2)", "m a P v2 Δv", "24", "",
         "m a P v1 v2", "m = 2 P : a : (v1 + v2)", "m a P {v}", "10", "",
         "m a P v1 Δv", "m = P : a : (v1 + Δv : 2)", "m a P {v}", "18", "",
         "m a P v1 W", "m = 2 P ^ 2 : (a ^ 2 W + 2 a P v1)", "m a P Δt v1", "43", "",
         "m a P v2 Δv", "m = P : a : (v2 - Δv : 2)", "m a P {v}", "15", "",
         "m a P v2 W", "m = 2 P ^ 2 : (2 a P v2 - a ^ 2 W)", "m a P Δt v2", "43", "",
         "m a P {v}", "m = P : a : {v}", "m a Δt {v} W", "61", "",
         "m a Δs W", "m = W : a : Δs", "m a F", "30", "",
         "m a Δt v1 W", "m = W : a : Δt : (v1 + a Δt : 2)", "m v1 Δv W", "24", "",
         "m a Δt v2 W", "m = W : a : Δt : (v2 - a Δt : 2)", "m v2 Δv W", "24", "",
         "m a Δt {v} W", "m = W : a : Δt : {v}", "m a Δs W", "21", "",
         "m c M V", "m = c M V", "m M n", "46", "",
         "m F k P v1", "m = -F ^ 3 : k : P : (P : F - v1) : 2", "m F k v1 {v}", "62", "",
         "m F k P v2", "m = -F ^ 3 : k : P : (v2 - P : F) : 2", "m F k v2 {v}", "62", "",
         "m F k P Δv", "m = -F ^ 3 : k : P : Δv", "m F P Δs Δv", "59", "",
         "m F k Δt v1", "m = -Δt : (2 : k : Δt + 2 v1 : F)", "m k Δs Δt v1", "59", "",
         "m F k Δt v2", "m = Δt : (2 : k : Δt + 2 v2 : F)", "m k Δs Δt v2", "59", "",
         "m F k v1 v2", "m = -2 F ^ 2 : k : (v2 ^ 2 - v1 ^ 2)", "m F k Δv {v}", "19", "",
         "m F k v1 Δv", "m = -(F ^ 2) : k : Δv : (v1 + Δv : 2)", "m F k Δv {v}", "18", "",
         "m F k v1 {v}", "m = -(F ^ 2) : k : {v} : ({v} - v1) : 2", "m F k Δv {v}", "16", "",
         "m F k v2 Δv", "m = -(F ^ 2) : k : Δv : (v2 - Δv : 2)", "m F k Δv {v}", "15", "",
         "m F k v2 {v}", "m = -(F ^ 2) : k : {v} : (v2 - {v}) : 2", "m F k Δv {v}", "13", "",
         "m F k Δv {v}", "m = -(F ^ 2) : k : Δv : {v}", "m k Δs Δv {v}", "59", "",
         "m F P Δs v1", "m = F ^ 3 Δs : (2 P ^ 2 - 2 F P v1)", "m F P v1 W", "29", "",
         "m F P Δs v2", "m = F ^ 3 Δs : (2 F P v2 - 2 P ^ 2)", "m F P v2 W", "29", "",
         "m F P Δs Δv", "m = F ^ 2 Δs : P : Δv", "m P Δs Δv W", "29", "",
         "m F P Δt v1", "m = F Δt : (P : F - v1) : 2", "m F Δt v1 W", "62", "",
         "m F P Δt v2", "m = F Δt : (v2 - P : F) : 2", "m F Δt v2 W", "62", "",
         "m F P v1 W", "m = F W : P : (P : F - v1) : 2", "m F P Δt v1", "43", "",
         "m F P v2 W", "m = F W : P : (v2 - P : F) : 2", "m F P Δt v2", "43", "",
         "m F P Δv W", "m = F W : P : Δv", "m F Δt Δv", "43", "",
         "m F Δs Δt v1", "m = F Δt : (Δs : Δt - v1) : 2", "m F Δt v1 {v}", "20", "",
         "m F Δs Δt v2", "m = F Δt : (v2 - Δs : Δt) : 2", "m F Δt v2 {v}", "20", "",
         "m F Δs v1 v2", "m = 2 F Δs : (v2 ^ 2 - v1 ^ 2)", "m F Δs Δv {v}", "19", "",
         "m F Δs v1 Δv", "m = F Δs : Δv : (v1 + Δv : 2)", "m F Δs Δv {v}", "18", "",
         "m F Δs v1 {v}", "m = F Δs : {v} : ({v} - v1) : 2", "m F Δs Δv {v}", "16", "",
         "m F Δs v2 Δv", "m = F Δs : Δv : (v2 - Δv : 2)", "m F Δs Δv {v}", "15", "",
         "m F Δs v2 {v}", "m = F Δs : {v} : (v2 - {v}) : 2", "m F Δs Δv {v}", "13", "",
         "m F Δs Δv {v}", "m = F Δs : Δv : {v}", "m F Δt Δv", "22", "",
         "m F Δt v1 {v}", "m = F Δt : ({v} - v1) : 2", "m F Δt Δv", "16", "",
         "m F Δt v1 W", "m = F Δt : (W : F : Δt - v1) : 2", "m F Δs Δt v1", "31", "",
         "m F Δt v2 {v}", "m = F Δt : (v2 - {v}) : 2", "m F Δt Δv", "13", "",
         "m F Δt v2 W", "m = F Δt : (v2 - W : F : Δt) : 2", "m F Δs Δt v2", "31", "",
         "m F Δt Δv", "m = F Δt : Δv", "m a F", "23", "",
         "m |Fn| μg P Δs v1", "m = (|Fn| μg) ^ 2 Δs : P : (P : |Fn| : μg - v1) : 2", "m F P Δs v1", "85", "",
         "m |Fn| μg P Δs v2", "m = (|Fn| μg) ^ 2 Δs : P : (v2 - P : |Fn| : μg) : 2", "m F P Δs v2", "85", "",
         "m |Fn| μg P Δs Δv", "m = (|Fn| μg) ^ 2 Δs : P : Δv", "m F P Δs Δv", "85", "",
         "m |Fn| μg P Δt v1", "m = |Fn| μg Δt : (P : |Fn| : μg - v1) : 2", "m F P Δt v1", "85", "",
         "m |Fn| μg P Δt v2", "m = |Fn| μg Δt : (v2 - P : |Fn| : μg) : 2", "m F P Δt v2", "85", "",
         "m |Fn| μg P v1 W", "m = |Fn| μg W : P : (P : |Fn| : μg - v1) : 2", "m F P v1 W", "85", "",
         "m |Fn| μg P v2 W", "m = |Fn| μg W : P : (v2 - P : |Fn| : μg) : 2", "m F P v2 W", "85", "",
         "m |Fn| μg P Δv W", "m = |Fn| μg W : P : Δv", "m F P Δv W", "85", "",
         "m |Fn| μg Δs Δt v1", "m = |Fn| μg Δt : (Δs : Δt - v1) : 2", "m F Δs Δt v1", "85", "",
         "m |Fn| μg Δs Δt v2", "m = |Fn| μg Δt : (v2 - Δs : Δt) : 2", "m F Δs Δt v2", "85", "",
         "m |Fn| μg Δs v1 v2", "m = 2 |Fn| μg Δs : (v2 ^ 2 - v1 ^ 2)", "m F Δs v1 v2", "85", "",
         "m |Fn| μg Δs v1 Δv", "m = |Fn| μg Δs : Δv : (v1 + Δv : 2)", "m F Δs v1 Δv", "85", "",
         "m |Fn| μg Δs v1 {v}", "m = |Fn| μg Δs : {v} : ({v} - v1) : 2", "m F Δs v1 {v}", "85", "",
         "m |Fn| μg Δs v2 Δv", "m = |Fn| μg Δs : Δv : (v2 - Δv : 2)", "m F Δs v2 Δv", "85", "",
         "m |Fn| μg Δs v2 {v}", "m = |Fn| μg Δs : {v} : (v2 - {v}) : 2", "m F Δs v2 {v}", "85", "",
         "m |Fn| μg Δs Δv {v}", "m = |Fn| μg Δs : Δv : {v}", "m F Δs Δv {v}", "85", "",
         "m |Fn| μg Δt v1 {v}", "m = |Fn| μg Δt : ({v} - v1) : 2", "m F Δt v1 {v}", "85", "",
         "m |Fn| μg Δt v1 W", "m = |Fn| μg Δt : (W : |Fn| : μg : Δt - v1) : 2", "m F Δt v1 W", "85", "",
         "m |Fn| μg Δt v2 {v}", "m = |Fn| μg Δt : (v2 - {v}) : 2", "m F Δt v2 {v}", "85", "",
         "m |Fn| μg Δt v2 W", "m = |Fn| μg Δt : (v2 - W : |Fn| : μg : Δt) : 2", "m F Δt v2 W", "85", "",
         "m |Fn| μg Δt Δv", "m = |Fn| μg Δt : Δv", "m F Δt Δv", "85", "",
         "m |Fn| μh P Δs v1", "m = (|Fn| μh) ^ 2 Δs : P : (P : |Fn| : μh - v1) : 2", "m F P Δs v1", "88", "",
         "m |Fn| μh P Δs v2", "m = (|Fn| μh) ^ 2 Δs : P : (v2 - P : |Fn| : μh) : 2", "m F P Δs v2", "88", "",
         "m |Fn| μh P Δs Δv", "m = (|Fn| μh) ^ 2 Δs : P : Δv", "m F P Δs Δv", "88", "",
         "m |Fn| μh P Δt v1", "m = |Fn| μh Δt : (P : |Fn| : μh - v1) : 2", "m F P Δt v1", "88", "",
         "m |Fn| μh P Δt v2", "m = |Fn| μh Δt : (v2 - P : |Fn| : μh) : 2", "m F P Δt v2", "88", "",
         "m |Fn| μh P v1 W", "m = |Fn| μh W : P : (P : |Fn| : μh - v1) : 2", "m F P v1 W", "88", "",
         "m |Fn| μh P v2 W", "m = |Fn| μh W : P : (v2 - P : |Fn| : μh) : 2", "m F P v2 W", "88", "",
         "m |Fn| μh P Δv W", "m = |Fn| μh W : P : Δv", "m F P Δv W", "88", "",
         "m |Fn| μh Δs Δt v1", "m = |Fn| μh Δt : (Δs : Δt - v1) : 2", "m F Δs Δt v1", "88", "",
         "m |Fn| μh Δs Δt v2", "m = |Fn| μh Δt : (v2 - Δs : Δt) : 2", "m F Δs Δt v2", "88", "",
         "m |Fn| μh Δs v1 v2", "m = 2 |Fn| μh Δs : (v2 ^ 2 - v1 ^ 2)", "m F Δs v1 v2", "88", "",
         "m |Fn| μh Δs v1 Δv", "m = |Fn| μh Δs : Δv : (v1 + Δv : 2)", "m F Δs v1 Δv", "88", "",
         "m |Fn| μh Δs v1 {v}", "m = |Fn| μh Δs : {v} : ({v} - v1) : 2", "m F Δs v1 {v}", "88", "",
         "m |Fn| μh Δs v2 Δv", "m = |Fn| μh Δs : Δv : (v2 - Δv : 2)", "m F Δs v2 Δv", "88", "",
         "m |Fn| μh Δs v2 {v}", "m = |Fn| μh Δs : {v} : (v2 - {v}) : 2", "m F Δs v2 {v}", "88", "",
         "m |Fn| μh Δs Δv {v}", "m = |Fn| μh Δs : Δv : {v}", "m F Δs Δv {v}", "88", "",
         "m |Fn| μh Δt v1 {v}", "m = |Fn| μh Δt : ({v} - v1) : 2", "m F Δt v1 {v}", "88", "",
         "m |Fn| μh Δt v1 W", "m = |Fn| μh Δt : (W : |Fn| : μh : Δt - v1) : 2", "m F Δt v1 W", "88", "",
         "m |Fn| μh Δt v2 {v}", "m = |Fn| μh Δt : (v2 - {v}) : 2", "m F Δt v2 {v}", "88", "",
         "m |Fn| μh Δt v2 W", "m = |Fn| μh Δt : (v2 - W : |Fn| : μh : Δt) : 2", "m F Δt v2 W", "88", "",
         "m |Fn| μh Δt Δv", "m = |Fn| μh Δt : Δv", "m F Δt Δv", "88", "",
         "m |Fn| μr P Δs v1", "m = (|Fn| μr) ^ 2 Δs : P : (P : |Fn| : μr - v1) : 2", "m F P Δs v1", "91", "",
         "m |Fn| μr P Δs v2", "m = (|Fn| μr) ^ 2 Δs : P : (v2 - P : |Fn| : μr) : 2", "m F P Δs v2", "91", "",
         "m |Fn| μr P Δs Δv", "m = (|Fn| μr) ^ 2 Δs : P : Δv", "m F P Δs Δv", "91", "",
         "m |Fn| μr P Δt v1", "m = |Fn| μr Δt : (P : |Fn| : μr - v1) : 2", "m F P Δt v1", "91", "",
         "m |Fn| μr P Δt v2", "m = |Fn| μr Δt : (v2 - P : |Fn| : μr) : 2", "m F P Δt v2", "91", "",
         "m |Fn| μr P v1 W", "m = |Fn| μr W : P : (P : |Fn| : μr - v1) : 2", "m F P v1 W", "91", "",
         "m |Fn| μr P v2 W", "m = |Fn| μr W : P : (v2 - P : |Fn| : μr) : 2", "m F P v2 W", "91", "",
         "m |Fn| μr P Δv W", "m = |Fn| μr W : P : Δv", "m F P Δv W", "91", "",
         "m |Fn| μr Δs Δt v1", "m = |Fn| μr Δt : (Δs : Δt - v1) : 2", "m F Δs Δt v1", "91", "",
         "m |Fn| μr Δs Δt v2", "m = |Fn| μr Δt : (v2 - Δs : Δt) : 2", "m F Δs Δt v2", "91", "",
         "m |Fn| μr Δs v1 v2", "m = 2 |Fn| μr Δs : (v2 ^ 2 - v1 ^ 2)", "m F Δs v1 v2", "91", "",
         "m |Fn| μr Δs v1 Δv", "m = |Fn| μr Δs : Δv : (v1 + Δv : 2)", "m F Δs v1 Δv", "91", "",
         "m |Fn| μr Δs v1 {v}", "m = |Fn| μr Δs : {v} : ({v} - v1) : 2", "m F Δs v1 {v}", "91", "",
         "m |Fn| μr Δs v2 Δv", "m = |Fn| μr Δs : Δv : (v2 - Δv : 2)", "m F Δs v2 Δv", "91", "",
         "m |Fn| μr Δs v2 {v}", "m = |Fn| μr Δs : {v} : (v2 - {v}) : 2", "m F Δs v2 {v}", "91", "",
         "m |Fn| μr Δs Δv {v}", "m = |Fn| μr Δs : Δv : {v}", "m F Δs Δv {v}", "91", "",
         "m |Fn| μr Δt v1 {v}", "m = |Fn| μr Δt : ({v} - v1) : 2", "m F Δt v1 {v}", "91", "",
         "m |Fn| μr Δt v1 W", "m = |Fn| μr Δt : (W : |Fn| : μr : Δt - v1) : 2", "m F Δt v1 W", "91", "",
         "m |Fn| μr Δt v2 {v}", "m = |Fn| μr Δt : (v2 - {v}) : 2", "m F Δt v2 {v}", "91", "",
         "m |Fn| μr Δt v2 W", "m = |Fn| μr Δt : (v2 - W : |Fn| : μr : Δt) : 2", "m F Δt v2 W", "91", "",
         "m |Fn| μr Δt Δv", "m = |Fn| μr Δt : Δv", "m F Δt Δv", "91", "",
         "m M n", "m = M n", "", "49", "",
         "m k P Δs v1", "m = -k ^ 3 Δs ^ 4 : P : (P + k Δs v1) : 2", "m F k P v1", "57", "",
         "m k P Δs v2", "m = k ^ 3 Δs ^ 4 : P : (P + k Δs v2) : 2", "m F k P v2", "57", "",
         "m k P Δs Δv", "m = -k ^ 2 Δs ^ 3 : P : Δv", "m F P Δs Δv", "57", "",
         "m k P Δt v1", "m = -k Δt ^ 2 : (2 v1 √(-k Δt : P) + 2)", "m k Δt v1 W", "44", "",
         "m k P Δt v2", "m = k Δt ^ 2 : (2 v2 √(-k Δt : P) + 2)", "m k Δt v2 W", "44", "",
         "m k P Δt Δv", "m = √(-k P Δt) Δt : Δv", "m a k P Δt", "23", "",
         "m k P v1 v2", "m = -8 P ^ 2 : k : (v2 - v1) : (v1 + v2) ^ 3", "m k P Δv {v}", "19", "",
         "m k P v1 Δv", "m = -(P ^ 2) : k : Δv : (v1 + Δv : 2) ^ 3", "m k P Δv {v}", "18", "",
         "m k P v1 {v}", "m = -(P ^ 2) : k : {v} ^ 3 : ({v} - v1) : 2", "m k P Δv {v}", "16", "",
         "m k P v1 W", "m = -k W : (2 P v1 √(-k : W) + 2 P ^ 2 : W)", "m k Δt v1 W", "43", "",
         "m k P v2 Δv", "m = -(P ^ 2) : k : Δv : (v2 - Δv : 2) ^ 3", "m k P Δv {v}", "15", "",
         "m k P v2 {v}", "m = -(P ^ 2) : k : {v} ^ 3 : (v2 - {v}) : 2", "m k P Δv {v}", "13", "",
         "m k P v2 W", "m = k W : (2 P v2 √(-k : W) + 2 P ^ 2 : W)", "m k Δt v2 W", "43", "",
         "m k P Δv {v}", "m = -(P ^ 2) : k : Δv : {v} ^ 3", "m F k Δv {v}", "61", "",
         "m k P Δv W", "m = √(-k W) W : P : Δv", "m k P Δt Δv", "43", "",
         "m k Δs Δt v1", "m = -k Δs Δt : (Δs : Δt - v1) : 2", "m k Δs v1 {v}", "20", "",
         "m k Δs Δt v2", "m = -k Δs Δt : (v2 - Δs : Δt) : 2", "m k Δs v2 {v}", "20", "",
         "m k Δs Δt Δv", "m = -k Δs Δt : Δv", "m a k Δs", "23", "",
         "m k Δs v1 v2", "m = -2 k Δs ^ 2 : (v2 ^ 2 - v1 ^ 2)", "m k Δs Δv {v}", "19", "",
         "m k Δs v1 Δv", "m = -k Δs ^ 2 : Δv : (v1 + Δv : 2)", "m k Δs Δv {v}", "18", "",
         "m k Δs v1 {v}", "m = -k Δs ^ 2 : {v} : ({v} - v1) : 2", "m k Δs Δv {v}", "16", "",
         "m k Δs v2 Δv", "m = -k Δs ^ 2 : Δv : (v2 - Δv : 2)", "m k Δs Δv {v}", "15", "",
         "m k Δs v2 {v}", "m = -k Δs ^ 2 : {v} : (v2 - {v}) : 2", "m k Δs Δv {v}", "13", "",
         "m k Δs Δv {v}", "m = -k Δs ^ 2 : Δv : {v}", "m k Δs Δt Δv", "22", "",
         "m k Δt v1 v2", "m = -k Δt ^ 2 (v1 + v2) : (v2 - v1) : 2", "m k Δt Δv {v}", "19", "",
         "m k Δt v1 Δv", "m = -k Δt ^ 2 (v1 + Δv : 2) : Δv", "m k Δt Δv {v}", "18", "",
         "m k Δt v1 {v}", "m = -k Δt ^ 2 {v} : ({v} - v1) : 2", "m k Δt Δv {v}", "16", "",
         "m k Δt v1 W", "m = -k Δt : (2 v1 √(-k : W) + 2 : Δt)", "m k Δt Δv W", "70", "",
         "m k Δt v2 Δv", "m = -k Δt ^ 2 (v2 - Δv : 2) : Δv", "m k Δt Δv {v}", "15", "",
         "m k Δt v2 {v}", "m = -k Δt ^ 2 {v} : (v2 - {v}) : 2", "m k Δt Δv {v}", "13", "",
         "m k Δt v2 W", "m = k Δt : (2 v2 √(-k : W) + 2 : Δt)", "m k Δt Δv W", "74", "",
         "m k Δt Δv {v}", "m = -k Δt ^ 2 {v} : Δv", "m k Δs Δt Δv", "21", "",
         "m k Δt Δv W", "m = √(-k W) Δt : Δv", "m a k W", "23", "",
         "m P Δs Δt v1", "m = P Δt ^ 2 : Δs : (Δs : Δt - v1) : 2", "m Δs Δt v1 W", "44", "",
         "m P Δs Δt v2", "m = P Δt ^ 2 : Δs : (v2 - Δs : Δt) : 2", "m Δs Δt v2 W", "44", "",
         "m P Δs Δt Δv", "m = P Δt ^ 2 : Δs : Δv", "m a P Δs Δt", "23", "",
         "m P Δs v1 v2", "m = 4 P Δs : (v2 ^ 2 - v1 ^ 2) : (v1 + v2)", "m P Δs Δv {v}", "19", "",
         "m P Δs v1 Δv", "m = P Δs : Δv : (v1 + Δv : 2) ^ 2", "m P Δs Δv {v}", "18", "",
         "m P Δs v1 {v}", "m = P Δs : {v} ^ 2 : ({v} - v1) : 2", "m P Δs Δv {v}", "16", "",
         "m P Δs v1 W", "m = W ^ 3 : (2 (P Δs) ^ 2 - 2 P Δs v1 W)", "m F P Δs v1", "30", "",
         "m P Δs v2 Δv", "m = P Δs : Δv : (v2 - Δv : 2) ^ 2", "m P Δs Δv {v}", "15", "",
         "m P Δs v2 {v}", "m = P Δs : {v} ^ 2 : (v2 - {v}) : 2", "m P Δs Δv {v}", "13", "",
         "m P Δs v2 W", "m = W ^ 3 : (2 P Δs v2 W - 2 (P Δs) ^ 2)", "m F P Δs v2", "30", "",
         "m P Δs Δv {v}", "m = P Δs : Δv : {v} ^ 2", "m P Δt Δv {v}", "22", "",
         "m P Δs Δv W", "m = W ^ 2 : P : Δs : Δv", "m F P Δv W", "30", "",
         "m P Δt v1 v2", "m = 2 P Δt : (v2 ^ 2 - v1 ^ 2)", "m P Δt Δv {v}", "19", "",
         "m P Δt v1 Δv", "m = P Δt : Δv : (v1 + Δv : 2)", "m P Δt Δv {v}", "18", "",
         "m P Δt v1 {v}", "m = P Δt : {v} : ({v} - v1) : 2", "m P Δt Δv {v}", "16", "",
         "m P Δt v2 Δv", "m = P Δt : Δv : (v2 - Δv : 2)", "m P Δt Δv {v}", "15", "",
         "m P Δt v2 {v}", "m = P Δt : {v} : (v2 - {v}) : 2", "m P Δt Δv {v}", "13", "",
         "m P Δt Δv {v}", "m = P Δt : Δv : {v}", "m Δv {v} W", "61", "",
         "m p Δs Δt", "m = p Δt : Δs", "m p v", "51", "",
         "m p v", "m = p : v", "", "55", "",
         "m Δs Δt v1 W", "m = Δt W : Δs : (Δs : Δt - v1) : 2", "m F Δs Δt v1", "30", "",
         "m Δs Δt v2 W", "m = Δt W : Δs : (v2 - Δs : Δt) : 2", "m F Δs Δt v2", "30", "",
         "m Δs Δt Δv W", "m = W Δt : Δs : Δv", "m F Δt Δv", "30", "",
         "m v1 v2 W", "m = 2 W : (v2 ^ 2 - v1 ^ 2)", "m Δv {v} W", "19", "",
         "m v1 Δv W", "m = W : Δv : (v1 + Δv : 2)", "m Δv {v} W", "18", "",
         "m v1 {v} W", "m = W : {v} : ({v} - v1) : 2", "m Δv {v} W", "16", "",
         "m v2 Δv W", "m = W : Δv : (v2 - Δv : 2)", "m Δv {v} W", "15", "",
         "m v2 {v} W", "m = W : {v} : (v2 - {v}) : 2", "m Δv {v} W", "13", "",
         "m Δv {v} W", "m = W : Δv : {v}", "m a Δt {v} W", "23", ""} ' m => 8754
      Case "n" : DՃA = New String() {
         "n c V", "n = c V", "", "45", "",
         "n M m", "n = m : M", "", "50", ""} ' n => 2
      Case "P" : DՃA = New String() {
         "P a F k v1", "P = F (v1 ± √(v1 ^ 2 - 2 a F : k)) : 2", "P a F v1 W", "77", "",
         "P a F k v2", "P = F (v2 ± √(v2 ^ 2 + 2 a F : k)) : 2", "P a F v2 W", "77", "",
         "P a F k Δv", "P = -a F ^ 2 : k : Δv", "P F k Δt", "25", "",
         "P a F Δs v1", "P = F (v1 ± √(v1 ^ 2 + 2 a Δs)) : 2", "P a m Δs v1 W", "29", "",
         "P a F Δs v2", "P = F (v2 ± √(v2 ^ 2 - 2 a Δs)) : 2", "P a m Δs v2", "29", "",
         "P a F Δs Δv", "P = a F Δs : Δv", "P a Δv W", "29", "",
         "P a F Δt v1", "P = F (v1 + a Δt : 2)", "P F v1 Δv", "24", "",
         "P a F Δt v2", "P = F (v2 - a Δt : 2)", "P F v2 Δv", "24", "",
         "P a F v1 W", "P = F (v1 ± √(v1 ^ 2 + 2 a W : F)) : 2", "P F m v1 W", "43", "",
         "P a F v2 W", "P = F (v2 ± √(v2 ^ 2 - 2 a W : F)) : 2", "P F m v2 W", "43", "",
         "P a |Fn| μg Δs v1", "P = |Fn| μg (v1 ± √(v1 ^ 2 + 2 a Δs)) : 2", "P a F Δs v1", "85", "",
         "P a |Fn| μg Δs v2", "P = |Fn| μg (v2 ± √(v2 ^ 2 - 2 a Δs)) : 2", "P a F Δs v2", "85", "",
         "P a |Fn| μg Δs Δv", "P = a |Fn| μg Δs : Δv", "P a F Δs Δv", "85", "",
         "P a |Fn| μg Δt v1", "P = |Fn| μg (v1 + a Δt : 2)", "P a F Δt v1", "85", "",
         "P a |Fn| μg Δt v2", "P = |Fn| μg (v2 - a Δt : 2)", "P a F Δt v2", "85", "",
         "P a |Fn| μg v1 W", "P = |Fn| μg (v1 ± √(v1 ^ 2 + 2 a W : |Fn| : μg)) : 2", "P a F v1 W", "85", "",
         "P a |Fn| μg v2 W", "P = |Fn| μg (v2 ± √(v2 ^ 2 - 2 a W : |Fn| : μg)) : 2", "P a F v2 W", "85", "",
         "P a |Fn| μh Δs v1", "P = |Fn| μh (v1 ± √(v1 ^ 2 + 2 a Δs)) : 2", "P a F Δs v1", "88", "",
         "P a |Fn| μh Δs v2", "P = |Fn| μh (v2 ± √(v2 ^ 2 - 2 a Δs)) : 2", "P a F Δs v2", "88", "",
         "P a |Fn| μh Δs Δv", "P = a |Fn| μh Δs : Δv", "P a F Δs Δv", "88", "",
         "P a |Fn| μh Δt v1", "P = |Fn| μh (v1 + a Δt : 2)", "P a F Δt v1", "88", "",
         "P a |Fn| μh Δt v2", "P = |Fn| μh (v2 - a Δt : 2)", "P a F Δt v2", "88", "",
         "P a |Fn| μh v1 W", "P = |Fn| μh (v1 ± √(v1 ^ 2 + 2 a W : |Fn| : μh)) : 2", "P a F v1 W", "88", "",
         "P a |Fn| μh v2 W", "P = |Fn| μh (v2 ± √(v2 ^ 2 - 2 a W : |Fn| : μh)) : 2", "P a F v2 W", "88", "",
         "P a |Fn| μr Δs v1", "P = |Fn| μr (v1 ± √(v1 ^ 2 + 2 a Δs)) : 2", "P a F Δs v1", "91", "",
         "P a |Fn| μr Δs v2", "P = |Fn| μr (v2 ± √(v2 ^ 2 - 2 a Δs)) : 2", "P a F Δs v2", "91", "",
         "P a |Fn| μr Δs Δv", "P = a |Fn| μr Δs : Δv", "P a F Δs Δv", "91", "",
         "P a |Fn| μr Δt v1", "P = |Fn| μr (v1 + a Δt : 2)", "P a F Δt v1", "91", "",
         "P a |Fn| μr Δt v2", "P = |Fn| μr (v2 - a Δt : 2)", "P a F Δt v2", "91", "",
         "P a |Fn| μr v1 W", "P = |Fn| μr (v1 ± √(v1 ^ 2 + 2 a W : |Fn| : μr)) : 2", "P a F v1 W", "91", "",
         "P a |Fn| μr v2 W", "P = |Fn| μr (v2 ± √(v2 ^ 2 - 2 a W : |Fn| : μr)) : 2", "P a F v2 W", "91", "",
         "P a k m Δt", "P = -(a m) ^ 2 : k : Δt", "P F k Δt", "26", "",
         "P a k m v1", "P = a m (v1 ± √(v1 ^ 2 - 2 a ^ 2 m : k)) : 2", "P a F k v1", "26", "",
         "P a k m v2", "P = a m (v2 ± √(v2 ^ 2 + 2 a ^ 2 m : k)) : 2", "P a F k v2", "26", "",
         "P a k m Δv", "P = -a ^ 3 m ^ 2 : k : Δv", "P F a k Δv", "26", "",
         "P a k Δs v1", "P = -k Δs (v1 ± √(v1 ^ 2 + 2 a Δs)) : 2", "P a F k v1", "57", "",
         "P a k Δs v2", "P = -k Δs (v2 ± √(v2 ^ 2 - 2 a Δs)) : 2", "P a F k v2", "57", "",
         "P a k Δs Δv", "P = -a k Δs ^ 2 : Δv", "P a F k Δv", "57", "",
         "P a k Δt v1", "P = -k Δt (v1 + a Δt : 2) ^ 2", "P k Δt v1 Δv", "24", "",
         "P a k Δt v2", "P = -k Δt (v2 - a Δt : 2) ^ 2", "P k Δt v2 Δv", "24", "",
         "P a k v1 v2", "P = -k (v2 - v1) (v1 + v2) ^ 2 : a : 4", "P a k Δv {v}", "19", "",
         "P a k v1 Δv", "P = -k Δv (v1 + Δv : 2) ^ 2 : a", "P a k Δv {v}", "18", "",
         "P a k v1 {v}", "P = -2 k ({v} - v1) {v} ^ 2 : a", "P a k Δv {v}", "16", "",
         "P a k v2 Δv", "P = -k Δv (v2 - Δv : 2) ^ 2 : a", "P a k Δv {v}", "15", "",
         "P a k v2 {v}", "P = -2 k (v2 - {v}) {v} ^ 2 : a", "P a k Δv {v}", "13", "",
         "P a k Δv {v}", "P = -k Δv {v} ^ 2 : a", "P k Δt {v}", "25", "",
         "P a m Δs Δt", "P = a m Δs : Δt", "P F Δs Δt", "26", "",
         "P a m Δs v1", "P = a m (v1 ± √(v1 ^ 2 + 2 a Δs)) : 2", "P F m Δs v1", "26", "",
         "P a m Δs v2", "P = a m (v2 ± √(v2 ^ 2 - 2 a Δs)) : 2", "P F m Δs v2", "26", "",
         "P a m Δs Δv", "P = a ^ 2 m Δs : Δv", "P a m Δs Δt", "25", "",
         "P a m Δt v1", "P = a m (v1 + a Δt : 2)", "P a m v1 Δv", "24", "",
         "P a m Δt v2", "P = a m (v2 - a Δt : 2)", "P a m v2 Δv", "24", "",
         "P a m v1 v2", "P = a m (v1 + v2) : 2", "P a m {v}", "10", "",
         "P a m v1 Δv", "P = a m (v1 + Δv : 2)", "P a m {v}", "18", "",
         "P a m v1 W", "P = a m (v1 ± √(v1 ^ 2 + 2 W : m)) : 2", "P F m v1 W", "26", "",
         "P a m v2 Δv", "P = a m (v2 - Δv : 2)", "P a m {v}", "15", "",
         "P a m v2 W", "P = a m (v2 ± √(v2 ^ 2 - 2 W : m)) : 2", "P F m v2 W", "26", "",
         "P a m {v}", "P = a m {v}", "P F {v}", "26", "",
         "P a Δs v1 W", "P = W (v1 ± √(v1 ^ 2 + 2 a Δs)) : Δs : 2", "P a F Δs v1", "30", "",
         "P a Δs v2 W", "P = W (v2 ± √(v2 ^ 2 - 2 a Δs)) : Δs : 2", "P a F Δs v2", "30", "",
         "P a v1 {v} W", "P = a W : ({v} - v1) : 2", "P a Δv W", "16", "",
         "P a v2 {v} W", "P = a W : (v2 - {v}) : 2", "P a Δv W", "13", "",
         "P a Δv W", "P = a W : Δv", "P Δt W", "25", "",
         "P F k m v1", "P = F (v1 ± √(v1 ^ 2 - 2 F ^ 2 : k : m)) : 2", "P a F k v1", "27", "",
         "P F k m v2", "P = F (v2 ± √(v2 ^ 2 + 2 F ^ 2 : k : m)) : 2", "P a F k v2", "27", "",
         "P F k m Δv", "P = -F ^ 3 : k : m : Δv", "P a F k Δv", "27", "",
         "P F k Δt", "P = -(F ^ 2) : k : Δt", "P Δt W", "77", "",
         "P F m Δs v1", "P = F (v1 ± √(v1 ^ 2 + 2 F Δs : m)) : 2", "P F m v1 W", "27", "",
         "P F m Δs v2", "P = F (v2 ± √(v2 ^ 2 - 2 F Δs : m)) : 2", "P F m v2 W", "27", "",
         "P F m Δs Δv", "P = F ^ 2 Δs : m : Δv", "P a F Δs Δv", "27", "",
         "P F m Δt v1", "P = F (v1 + F Δt : m : 2)", "P a F Δt v1", "27", "",
         "P F m Δt v2", "P = F (v2 - F Δt : m : 2)", "P a F Δt v2", "27", "",
         "P F m v1 W", "P = F (v1 ± √(v1 ^ 2 + 2 W : m)) : 2", "P F m Δt v1", "43", "",
         "P F m v2 W", "P = F (v2 ± √(v2 ^ 2 - 2 W : m)) : 2", "P F m Δt v2", "43", "",
         "P F m Δv W", "P = F W : m : Δv", "P a Δv W", "27", "",
         "P F Δs Δt", "P = F Δs : Δt", "P Δt W", "29", "",
         "P F v1 v2", "P = F (v1 + v2) : 2", "P F {v}", "10", "",
         "P F v1 Δv", "P = F (v1 + Δv : 2)", "P F {v}", "18", "",
         "P F v2 Δv", "P = F (v2 - Δv : 2)", "P F {v}", "15", "",
         "P F {v}", "P = F {v}", "P F Δs Δt", "21", "",
         "P |Fn| m μg Δs v1", "P = |Fn| μg (v1 ± √(v1 ^ 2 + 2 |Fn| μg Δs : m)) : 2", "P F m Δs v1", "85", "",
         "P |Fn| m μg Δs v2", "P = |Fn| μg (v2 ± √(v2 ^ 2 - 2 |Fn| μg Δs : m)) : 2", "P F m Δs v2", "85", "",
         "P |Fn| m μg Δs Δv", "P = (|Fn| μg) ^ 2 Δs : m : Δv", "P F m Δs Δv", "85", "",
         "P |Fn| m μg Δt v1", "P = |Fn| μg (v1 + |Fn| μg Δt : m : 2)", "P F m Δt v1", "85", "",
         "P |Fn| m μg Δt v2", "P = |Fn| μg (v2 - |Fn| μg Δt : m : 2)", "P F m Δt v2", "85", "",
         "P |Fn| m μg v1 W", "P = |Fn| μg (v1 ± √(v1 ^ 2 + 2 W : m)) : 2", "P F m v1 W", "85", "",
         "P |Fn| m μg v2 W", "P = |Fn| μg (v2 ± √(v2 ^ 2 - 2 W : m)) : 2", "P F m v2 W", "85", "",
         "P |Fn| m μg Δv W", "P = |Fn| μg W : m : Δv", "P F m Δv W", "85", "",
         "P |Fn| μg Δs Δt", "P = |Fn| μg Δs : Δt", "P F Δs Δt", "85", "",
         "P |Fn| μg v1 v2", "P = |Fn| μg (v1 + v2) : 2", "P F v1 v2", "85", "",
         "P |Fn| μg v1 Δv", "P = |Fn| μg (v1 + Δv : 2)", "P F v1 Δv", "85", "",
         "P |Fn| μg v2 Δv", "P = |Fn| μg (v2 - Δv : 2)", "P F v2 Δv", "85", "",
         "P |Fn| μg {v}", "P = |Fn| μg {v}", "P F {v}", "85", "",
         "P |Fn| m μh Δs v1", "P = |Fn| μh (v1 ± √(v1 ^ 2 + 2 |Fn| μh Δs : m)) : 2", "P F m Δs v1", "88", "",
         "P |Fn| m μh Δs v2", "P = |Fn| μh (v2 ± √(v2 ^ 2 - 2 |Fn| μh Δs : m)) : 2", "P F m Δs v2", "88", "",
         "P |Fn| m μh Δs Δv", "P = (|Fn| μh) ^ 2 Δs : m : Δv", "P F m Δs Δv", "88", "",
         "P |Fn| m μh Δt v1", "P = |Fn| μh (v1 + |Fn| μh Δt : m : 2)", "P F m Δt v1", "88", "",
         "P |Fn| m μh Δt v2", "P = |Fn| μh (v2 - |Fn| μh Δt : m : 2)", "P F m Δt v2", "88", "",
         "P |Fn| m μh v1 W", "P = |Fn| μh (v1 ± √(v1 ^ 2 + 2 W : m)) : 2", "P F m v1 W", "88", "",
         "P |Fn| m μh v2 W", "P = |Fn| μh (v2 ± √(v2 ^ 2 - 2 W : m)) : 2", "P F m v2 W", "88", "",
         "P |Fn| m μh Δv W", "P = |Fn| μh W : m : Δv", "P F m Δv W", "88", "",
         "P |Fn| μh Δs Δt", "P = |Fn| μh Δs : Δt", "P F Δs Δt", "88", "",
         "P |Fn| μh v1 v2", "P = |Fn| μh (v1 + v2) : 2", "P F v1 v2", "88", "",
         "P |Fn| μh v1 Δv", "P = |Fn| μh (v1 + Δv : 2)", "P F v1 Δv", "88", "",
         "P |Fn| μh v2 Δv", "P = |Fn| μh (v2 - Δv : 2)", "P F v2 Δv", "88", "",
         "P |Fn| μh {v}", "P = |Fn| μh {v}", "P F {v}", "88", "",
         "P |Fn| m μr Δs v1", "P = |Fn| μr (v1 ± √(v1 ^ 2 + 2 |Fn| μr Δs : m)) : 2", "P F m Δs v1", "91", "",
         "P |Fn| m μr Δs v2", "P = |Fn| μr (v2 ± √(v2 ^ 2 - 2 |Fn| μr Δs : m)) : 2", "P F m Δs v2", "91", "",
         "P |Fn| m μr Δs Δv", "P = (|Fn| μr) ^ 2 Δs : m : Δv", "P F m Δs Δv", "91", "",
         "P |Fn| m μr Δt v1", "P = |Fn| μr (v1 + |Fn| μr Δt : m : 2)", "P F m Δt v1", "91", "",
         "P |Fn| m μr Δt v2", "P = |Fn| μr (v2 - |Fn| μr Δt : m : 2)", "P F m Δt v2", "91", "",
         "P |Fn| m μr v1 W", "P = |Fn| μr (v1 ± √(v1 ^ 2 + 2 W : m)) : 2", "P F m v1 W", "91", "",
         "P |Fn| m μr v2 W", "P = |Fn| μr (v2 ± √(v2 ^ 2 - 2 W : m)) : 2", "P F m v2 W", "91", "",
         "P |Fn| m μr Δv W", "P = |Fn| μr W : m : Δv", "P F m Δv W", "91", "",
         "P |Fn| μr Δs Δt", "P = |Fn| μr Δs : Δt", "P F Δs Δt", "91", "",
         "P |Fn| μr v1 v2", "P = |Fn| μr (v1 + v2) : 2", "P F v1 v2", "91", "",
         "P |Fn| μr v1 Δv", "P = |Fn| μr (v1 + Δv : 2)", "P F v1 Δv", "91", "",
         "P |Fn| μr v2 Δv", "P = |Fn| μr (v2 - Δv : 2)", "P F v2 Δv", "91", "",
         "P |Fn| μr {v}", "P = |Fn| μr {v}", "P F {v}", "91", "",
         "P k m Δs v1", "P = -k Δs (v1 ± √(v1 ^ 2 - 2 k Δs ^ 2 : m)) : 2", "P F k m v1", "57", "",
         "P k m Δs v2", "P = -k Δs (v2 ± √(v2 ^ 2 + 2 k Δs ^ 2 : m)) : 2", "P F k m v2", "57", "",
         "P k m Δs Δv", "P = k ^ 2 Δs ^ 3 : m : Δv", "P F m Δs Δv", "57", "",
         "P k m Δt v1", "P = -(2 v1 : (Δt : m + 2 : k : Δt)) ^ 2 : k : Δt", "P k m v1 W", "44", "",
         "P k m Δt v2", "P = -(2 v2 : (Δt : m - 2 : k : Δt)) ^ 2 : k : Δt", "P k m v2 W", "44", "",
         "P k m Δt Δv", "P = -(m Δv) ^ 2 : k : Δt ^ 3", "P a k m Δt", "23", "",
         "P k m v1 v2", "P = √(-k m (v2 - v1) (v1 + v2) ^ 3 : 8)", "P k m Δv {v}", "19", "",
         "P k m v1 Δv", "P = √(-k m Δv (v1 + Δv : 2) ^ 3)", "P k m Δv {v}", "18", "",
         "P k m v1 {v}", "P = √(-2 k m {v} ^ 3 ({v} - v1))", "P k m Δv {v}", "16", "",
         "P k m v1 W", "P = √(-k W) (v1 ± √ (v1 ^ 2 + 2 W : m)) : 2)", "P F m v1 W", "75", "",
         "P k m v2 Δv", "P = √(-k m Δv (v2 - Δv : 2) ^ 3)", "P k m Δv {v}", "15", "",
         "P k m v2 {v}", "P = √(-2 k m {v} ^ 3 (v2 - {v}))", "P k m Δv {v}", "13", "",
         "P k m v2 W", "P = √(-k W) (v2 ± √ (v2 ^ 2 - 2 W : m)) : 2)", "P F m v2 W", "75", "",
         "P k m Δv {v}", "P = √(-k m Δv {v} ^ 3)", "P k {v} W", "61", "",
         "P k m Δv W", "P = √(-k W) W : m : Δv", "P F k m Δv", "75", "",
         "P k Δs Δt", "P = -k Δs ^ 2 : Δt", "P Δt W", "80", "",
         "P k Δs v1 v2", "P = -k Δs (v1 + v2) : 2", "P k Δs {v}", "10", "",
         "P k Δs v1 Δv", "P = -k Δs (v1 + Δv : 2)", "P k Δs {v}", "18", "",
         "P k Δs v2 Δv", "P = -k Δs (v2 - Δv : 2)", "P k Δs {v}", "15", "",
         "P k Δs {v}", "P = -k Δs {v}", "P k Δs Δt", "22", "",
         "P k Δt v1 v2", "P = -k Δt (v1 + v2) ^ 2 : 4", "P k Δt {v}", "10", "",
         "P k Δt v1 Δv", "P = -k Δt (v1 + Δv : 2) ^ 2", "P k Δt {v}", "18", "",
         "P k Δt v2 Δv", "P = -k Δt (v2 - Δv : 2) ^ 2", "P k Δt {v}", "15", "",
         "P k Δt {v}", "P = -k Δt {v} ^ 2", "P k Δs {v}", "21", "",
         "P k v1 v2 W", "P = √(-k W) (v1 + v2) : 2", "P k {v} W", "10", "",
         "P k v1 Δv W", "P = √(-k W) (v1 + Δv : 2)", "P k {v} W", "18", "",
         "P k v2 Δv W", "P = √(-k W) (v2 - Δv : 2)", "P k {v} W", "15", "",
         "P k {v} W", "P = √(-k W) {v}", "P F {v}", "75", "",
         "P m Δs Δt v1", "P = 2 m Δs (Δs : Δt - v1) : Δt ^ 2", "P m Δt v1 {v}", "20", "",
         "P m Δs Δt v2", "P = 2 m Δs (v2 - Δs : Δt) : Δt ^ 2", "P m Δt v2 {v}", "20", "",
         "P m Δs Δt Δv", "P = m Δs Δv : Δt ^ 2", "P a m Δs Δt", "23", "",
         "P m Δs v1 v2", "P = m (v2 ^ 2 - v1 ^ 2) (v1 + v2) : Δs : 4", "P m Δs Δv {v}", "19", "",
         "P m Δs v1 Δv", "P = m Δv (v1 + Δv : 2) ^ 2 : Δs", "P m Δs Δv {v}", "18", "",
         "P m Δs v1 {v}", "P = 2 m {v} ^ 2 ({v} - v1) : Δs", "P m Δs Δv {v}", "16", "",
         "P m Δs v1 W", "P = W (v1 ± √(v1 ^ 2 + 2 W : m)) : Δs : 2", "P F m v1 W", "30", "",
         "P m Δs v2 Δv", "P = m Δv (v2 - Δv : 2) ^ 2 : Δs", "P m Δs Δv {v}", "15", "",
         "P m Δs v2 {v}", "P = 2 m {v} ^ 2 (v2 - {v}) : Δs", "P m Δs Δv {v}", "13", "",
         "P m Δs v2 W", "P = W (v2 ± √(v2 ^ 2 - 2 W : m)) : Δs : 2", "P F m v2 W", "30", "",
         "P m Δs Δv {v}", "P = m Δv {v} ^ 2 : Δs", "P m Δs Δt Δv", "22", "",
         "P m Δs Δv W", "P = W ^ 2 : m : Δs : Δv", "P F m Δv W", "30", "",
         "P m Δt v1 v2", "P = m (v2 ^ 2 - v1 ^ 2) : Δt : 2", "P m Δt Δv {v}", "19", "",
         "P m Δt v1 Δv", "P = m (v1 + Δv : 2) Δv : Δt", "P m Δt Δv {v}", "18", "",
         "P m Δt v1 {v}", "P = 2 m ({v} - v1) {v} : Δt", "P m Δt Δv {v}", "16", "",
         "P m Δt v2 Δv", "P = m (v2 - Δv : 2) Δv : Δt", "P m Δt Δv {v}", "15", "",
         "P m Δt v2 {v}", "P = 2 m (v2 - {v}) {v} : Δt", "P m Δt Δv {v}", "13", "",
         "P m Δt Δv {v}", "P = m Δv {v} : Δt", "P m Δs Δt Δv", "21", "",
         "P Δs v1 v2 W", "P = (v1 + v2) W : Δs : 2", "P Δs {v} W", "10", "",
         "P Δs v1 Δv W", "P = (v1 + Δv : 2) W : Δs", "P Δs {v} W", "18", "",
         "P Δs v2 Δv W", "P = (v2 - Δv : 2) W : Δs", "P Δs {v} W", "15", "",
         "P Δs {v} W", "P = {v} W : Δs", "P Δt W", "22", "",
         "P Δt W", "P = W : Δt", "", "42", ""} ' P => 6932
      Case "p" : DՃA = New String() {
         "p m Δs Δt", "p = m Δs : Δt", "", "51", "",
         "p m v", "p = m v", "", "54", "",
         "p px", "p = px", "", "0", "",
         "p py", "p = py", "", "0", "",
         "p pz", "p = pz", "", "0", "",
         "p px θ", "p = px : cos(θ)", "", "0", "",
         "p py θ", "p = py : sin(θ)", "", "0", "",
         "p pz θ", "p = pz : cos(θ)", "", "0", "",
         "p px θ ϕ", "p = px : cos(θ) : sin(ϕ)", "", "0", "",
         "p pz θ ϕ", "p = pz : cos(θ) : cos(ϕ)", "", "0", "",
         "p px py", "p = √(px ^ 2 + py ^ 2)", "", "0", "",
         "p px pz", "p = √(px ^ 2 + pz ^ 2)", "", "0", "",
         "p py pz", "p = √(py ^ 2 + pz ^ 2)", "", "0", "",
         "p px py pz", "p = √(px ^ 2 + py ^ 2 + pz ^ 2)", "", "0", ""} ' p => 77
      Case "V" : DՃA = New String() {
         "V c n", "V = n : c", "", "47", "",
         "V c M m", "V = m : c : M", "V c n", "50", ""} ' V => 2
      Case "v" : DՃA = New String() {
         "v m p", "v = p : m", "", "56", "",
         "v Δs Δt", "v = Δs : Δt", "", "51", "",
         "v vx", "v = vx", "", "0", "",
         "v vy", "v = vy", "", "0", "",
         "v vz", "v = vz", "", "0", "",
         "v vx θ", "v = vx : cos(θ)", "", "0", "",
         "v vy θ", "v = vy : sin(θ)", "", "0", "",
         "v vz θ", "v = vz : cos(θ)", "", "0", "",
         "v vx θ ϕ", "v = vx : cos(θ) : sin(ϕ)", "", "0", "",
         "v vz θ ϕ", "v = vz : cos(θ) : cos(ϕ)", "", "0", "",
         "v vx vy", "v = √(vx ^ 2 + vy ^ 2)", "", "0", "",
         "v vx vz", "v = √(vx ^ 2 + vz ^ 2)", "", "0", "",
         "v vy vz", "v = √(vy ^ 2 + vz ^ 2)", "", "0", "",
         "v vx vy vz", "v = √(vx ^ 2 + vy ^ 2 + vz ^ 2)", "", "0", ""} ' v => 77
      Case "W" : DՃA = New String() {
         "W a F P v1", "W = 2 P (P : F - v1) : a", "W a F Δt v1", "43", "",
         "W a F P v2", "W = 2 P (v2 - P : F) : a", "W a F Δt v2", "43", "",
         "W a F Δt v1", "W = F Δt (v1 + a Δt : 2)", "W F Δt v1 Δv", "24", "",
         "W a F Δt v2", "W = F Δt (v2 - a Δt : 2)", "W F Δt v2 Δv", "24", "",
         "W a F v1 v2", "W = F (v2 ^ 2 - v1 ^ 2) : a : 2", "W a F Δv {v}", "19", "",
         "W a F v1 Δv", "W = F Δv (v1 + Δv : 2) : a", "W a F Δv {v}", "18", "",
         "W a F v1 {v}", "W = 2 F {v} ({v} - v1) : a", "W a F Δv {v}", "16", "",
         "W a F v2 Δv", "W = F Δv (v2 - Δv : 2) : a", "W a F Δv {v}", "15", "",
         "W a F v2 {v}", "W = 2 F {v} (v2 - {v}) : a", "W a F Δv {v}", "13", "",
         "W a F Δv {v}", "W = F Δv {v} : a", "W F Δt {v}", "25", "",
         "W a |Fn| μg P v1", "W = 2 P (P : |Fn| : μg - v1) : a", "W a F P v1", "85", "",
         "W a |Fn| μg P v2", "W = 2 P (v2 - P : |Fn| : μg) : a", "W a F P v2", "85", "",
         "W a |Fn| μg Δt v1", "W = |Fn| μg Δt (v1 + a Δt : 2)", "W a F Δt v1", "85", "",
         "W a |Fn| μg Δt v2", "W = |Fn| μg Δt (v2 - a Δt : 2)", "W a F Δt v2", "85", "",
         "W a |Fn| μg v1 v2", "W = |Fn| μg (v2 ^ 2 - v1 ^ 2) : a : 2", "W a F v1 v2", "85", "",
         "W a |Fn| μg v1 Δv", "W = |Fn| μg (v1 + Δv : 2) Δv : a", "W a F v1 Δv", "85", "",
         "W a |Fn| μg v1 {v}", "W = 2 |Fn| μg {v} ({v} - v1) : a", "W a F v1 {v}", "85", "",
         "W a |Fn| μg v2 Δv", "W = |Fn| μg (v2 - Δv : 2) Δv : a", "W a F v2 Δv", "85", "",
         "W a |Fn| μg v2 {v}", "W = 2 |Fn| μg {v} (v2 - {v}) : a", "W a F v2 {v}", "85", "",
         "W a |Fn| μg Δv {v}", "W = |Fn| μg Δv {v} : a", "W a F Δv {v}", "85", "",
         "W a |Fn| μh P v1", "W = 2 P (P : |Fn| : μh - v1) : a", "W a F P v1", "88", "",
         "W a |Fn| μh P v2", "W = 2 P (v2 - P : |Fn| : μh) : a", "W a F P v2", "88", "",
         "W a |Fn| μh Δt v1", "W = |Fn| μh Δt (v1 + a Δt : 2)", "W a F Δt v1", "88", "",
         "W a |Fn| μh Δt v2", "W = |Fn| μh Δt (v2 - a Δt : 2)", "W a F Δt v2", "88", "",
         "W a |Fn| μh v1 v2", "W = |Fn| μh (v2 ^ 2 - v1 ^ 2) : a : 2", "W a F v1 v2", "88", "",
         "W a |Fn| μh v1 Δv", "W = |Fn| μh (v1 + Δv : 2) Δv : a", "W a F v1 Δv", "88", "",
         "W a |Fn| μh v1 {v}", "W = 2 |Fn| μh {v} ({v} - v1) : a", "W a F v1 {v}", "88", "",
         "W a |Fn| μh v2 Δv", "W = |Fn| μh (v2 - Δv : 2) Δv : a", "W a F v2 Δv", "88", "",
         "W a |Fn| μh v2 {v}", "W = 2 |Fn| μh {v} (v2 - {v}) : a", "W a F v2 {v}", "88", "",
         "W a |Fn| μh Δv {v}", "W = |Fn| μh Δv {v} : a", "W a F Δv {v}", "88", "",
         "W a |Fn| μr P v1", "W = 2 P (P : |Fn| : μr - v1) : a", "W a F P v1", "91", "",
         "W a |Fn| μr P v2", "W = 2 P (v2 - P : |Fn| : μr) : a", "W a F P v2", "91", "",
         "W a |Fn| μr Δt v1", "W = |Fn| μr Δt (v1 + a Δt : 2)", "W a F Δt v1", "91", "",
         "W a |Fn| μr Δt v2", "W = |Fn| μr Δt (v2 - a Δt : 2)", "W a F Δt v2", "91", "",
         "W a |Fn| μr v1 v2", "W = |Fn| μr (v2 ^ 2 - v1 ^ 2) : a : 2", "W a F v1 v2", "91", "",
         "W a |Fn| μr v1 Δv", "W = |Fn| μr (v1 + Δv : 2) Δv : a", "W a F v1 Δv", "91", "",
         "W a |Fn| μr v1 {v}", "W = 2 |Fn| μr {v} ({v} - v1) : a", "W a F v1 {v}", "91", "",
         "W a |Fn| μr v2 Δv", "W = |Fn| μr (v2 - Δv : 2) Δv : a", "W a F v2 Δv", "91", "",
         "W a |Fn| μr v2 {v}", "W = 2 |Fn| μr {v} (v2 - {v}) : a", "W a F v2 {v}", "91", "",
         "W a |Fn| μr Δv {v}", "W = |Fn| μr Δv {v} : a", "W a F Δv {v}", "91", "",
         "W a k m", "W = -(a m) ^ 2 : k", "W F k", "26", "",
         "W a k Δt v1", "W = -k (Δt (v1 + a Δt : 2)) ^ 2", "W k Δt v1 Δv", "24", "",
         "W a k Δt v2", "W = -k (Δt (v2 - a Δt : 2)) ^ 2", "W k Δt v2 Δv", "24", "",
         "W a k v1 v2", "W = -k ((v2 ^ 2 - v1 ^ 2) : a : 2) ^ 2", "W a k Δv {v}", "19", "",
         "W a k v1 Δv", "W = -k (Δv (v1 + Δv : 2) : a) ^ 2", "W a k Δv {v}", "18", "",
         "W a k v1 {v}", "W = -k (2 {v} ({v} - v1) : a) ^ 2", "W a k Δv {v}", "16", "",
         "W a k v2 Δv", "W = -k (Δv (v2 - Δv : 2) : a) ^ 2", "W a k Δv {v}", "15", "",
         "W a k v2 {v}", "W = -k (2 {v} (v2 - {v}) : a) ^ 2", "W a k Δv {v}", "13", "",
         "W a k Δv {v}", "W = -k (Δv {v} : a) ^ 2", "W k Δt {v}", "25", "",
         "W a m P v1", "W = 2 P (P : a : m - v1) : a", "W a F P v1", "26", "",
         "W a m P v2", "W = 2 P (v2 - P : a : m) : a", "W a F P v2", "26", "",
         "W a m Δs", "W = a m Δs", "W F Δs", "26", "",
         "W a m Δt v1", "W = a m Δt (v1 + a Δt : 2)", "W a F Δt v1", "26", "",
         "W a m Δt v2", "W = a m Δt (v2 - a Δt : 2)", "W a F Δt v2", "26", "",
         "W a m Δt {v}", "W = a m Δt {v}", "W a m Δs", "21", "",
         "W a P Δs v1", "W = P (-v1 ± √(v1 ^ 2 + 2 a Δs)) : a", "W a F P v1", "30", "",
         "W a P Δs v2", "W = P (v2 ± √(v2 ^ 2 - 2 a Δs)) : a", "W a F P v2", "30", "",
         "W a P v1 {v}", "W = 2 P ({v} - v1) : a", "W a P Δv", "16", "",
         "W a P v2 {v}", "W = 2 P (v2 - {v}) : a", "W a P Δv", "13", "",
         "W a P Δv", "W = P Δv : a", "W P Δt", "25", "",
         "W Ek1 Ek2", "W = Ek2 - Ek1", "W ΔEk", "32", "",
         "W ΔEk", "W = ΔEk", "", "32", "",
         "W Ep1 Ep2", "W = Ep1 - Ep2", "W ΔEp", "34", "",
         "W ΔEp", "W = -ΔEp", "", "34", "",
         "W F k", "W = -(F ^ 2) : k", "W F Δs", "78", "",
         "W F m P v1", "W = 2 m P (P : F - v1) : F", "W a F P v1", "27", "",
         "W F m P v2", "W = 2 m P (v2 - P : F) : F", "W a F P v2", "27", "",
         "W F m P Δv", "W = m P Δv : F", "W a P Δv", "27", "",
         "W F m Δt v1", "W = F Δt (v1 + F Δt : m : 2)", "W a F Δt v1", "27", "",
         "W F m Δt v2", "W = F Δt (v2 - F Δt : m : 2)", "W a F Δt v2", "27", "",
         "W F Δs", "W = F Δs", "", "29", "",
         "W F Δt v1 v2", "W = F Δt (v1 + v2) : 2", "W F Δt {v}", "10", "",
         "W F Δt v1 Δv", "W = F Δt (v1 + Δv : 2)", "W F Δt {v}", "18", "",
         "W F Δt v2 Δv", "W = F Δt (v2 - Δv : 2)", "W F Δt {v}", "15", "",
         "W F Δt {v}", "W = F Δt {v}", "W F Δs", "21", "",
         "W |Fn| m μg P v1", "W = 2 m P (P : |Fn| : μg - v1) : |Fn| : μg", "W F m P v1", "85", "",
         "W |Fn| m μg P v2", "W = 2 m P (v2 - P : |Fn| : μg) : |Fn| : μg", "W F m P v2", "85", "",
         "W |Fn| m μg P Δv", "W = m P Δv : |Fn| : μg", "W F m P Δv", "85", "",
         "W |Fn| m μg Δt v1", "W = |Fn| μg Δt (v1 + |Fn| μg Δt : m : 2)", "W F m Δt v1", "85", "",
         "W |Fn| m μg Δt v2", "W = |Fn| μg Δt (v2 - |Fn| μg Δt : m : 2)", "W F m Δt v2", "85", "",
         "W |Fn| m μh P v1", "W = 2 m P (P : |Fn| : μh - v1) : |Fn| : μh", "W F m P v1", "88", "",
         "W |Fn| m μh P v2", "W = 2 m P (v2 - P : |Fn| : μh) : |Fn| : μh", "W F m P v2", "88", "",
         "W |Fn| m μh P Δv", "W = m P Δv : |Fn| : μh", "W F m P Δv", "88", "",
         "W |Fn| m μh Δt v1", "W = |Fn| μh Δt (v1 + |Fn| μh Δt : m : 2)", "W F m Δt v1", "88", "",
         "W |Fn| m μh Δt v2", "W = |Fn| μh Δt (v2 - |Fn| μh Δt : m : 2)", "W F m Δt v2", "88", "",
         "W |Fn| m μr P v1", "W = 2 m P (P : |Fn| : μr - v1) : |Fn| : μr", "W F m P v1", "91", "",
         "W |Fn| m μr P v2", "W = 2 m P (v2 - P : |Fn| : μr) : |Fn| : μr", "W F m P v2", "91", "",
         "W |Fn| m μr P Δv", "W = m P Δv : |Fn| : μr", "W F m P Δv", "91", "",
         "W |Fn| m μr Δt v1", "W = |Fn| μr Δt (v1 + |Fn| μr Δt : m : 2)", "W F m Δt v1", "91", "",
         "W |Fn| m μr Δt v2", "W = |Fn| μr Δt (v2 - |Fn| μr Δt : m : 2)", "W F m Δt v2", "91", "",
         "W |Fn| μg Δs", "W = |Fn| μg Δs", "W F Δs", "85", "",
         "W |Fn| μg Δt v1 v2", "W = |Fn| μg Δt (v1 + v2) : 2", "W F Δt v1 v2", "85", "",
         "W |Fn| μg Δt v1 Δv", "W = |Fn| μg Δt (v1 + Δv : 2)", "W F Δt v1 Δv", "85", "",
         "W |Fn| μg Δt v2 Δv", "W = |Fn| μg Δt (v2 - Δv : 2)", "W F Δt v2 Δv", "85", "",
         "W |Fn| μg Δt {v}", "W = |Fn| μg Δt {v}", "W F Δt {v}", "85", "",
         "W |Fn| μh Δs", "W = |Fn| μh Δs", "W F Δs", "88", "",
         "W |Fn| μh Δt v1 v2", "W = |Fn| μh Δt (v1 + v2) : 2", "W F Δt v1 v2", "88", "",
         "W |Fn| μh Δt v1 Δv", "W = |Fn| μh Δt (v1 + Δv : 2)", "W F Δt v1 Δv", "88", "",
         "W |Fn| μh Δt v2 Δv", "W = |Fn| μh Δt (v2 - Δv : 2)", "W F Δt v2 Δv", "88", "",
         "W |Fn| μh Δt {v}", "W = |Fn| μh Δt {v}", "W F Δt {v}", "88", "",
         "W |Fn| μr Δs", "W = |Fn| μr Δs", "W F Δs", "91", "",
         "W |Fn| μr Δt v1 v2", "W = |Fn| μr Δt (v1 + v2) : 2", "W F Δt v1 v2", "91", "",
         "W |Fn| μr Δt v1 Δv", "W = |Fn| μr Δt (v1 + Δv : 2)", "W F Δt v1 Δv", "91", "",
         "W |Fn| μr Δt v2 Δv", "W = |Fn| μr Δt (v2 - Δv : 2)", "W F Δt v2 Δv", "91", "",
         "W |Fn| μr Δt {v}", "W = |Fn| μr Δt {v}", "W F Δt {v}", "91", "",
         "W k m P Δv", "W = √(-(m P Δv) ^ 2 : k ' 3)", "W k m Δt Δv", "43", "",
         "W k m Δt v1", "W = -k (2 v1 : (-k Δt : m - 2 : Δt)) ^ 2", "W k m Δt Δv", "70", "",
         "W k m Δt v2", "W = -k (2 v2 : (k Δt : m - 2 : Δt)) ^ 2", "W k m Δt Δv", "74", "",
         "W k m Δt Δv", "W = -(m Δv) ^ 2 : k : Δt ^ 2", "W a k m", "23", "",
         "W k P v1 v2", "W = -4 P ^ 2 : k : (v1 + v2) ^ 2", "W k P {v}", "10", "",
         "W k P v1 Δv", "W = -(P ^ 2) : k : (v1 + Δv : 2) ^ 2", "W k P {v}", "18", "",
         "W k P v2 Δv", "W = -(P ^ 2) : k : (v2 - Δv : 2) ^ 2", "W k P {v}", "15", "",
         "W k P {v}", "W = -(P ^ 2) : k : {v} ^ 2", "W F k", "61", "",
         "W k Δs", "W = -k Δs ^ 2", "W F Δs", "75", "",
         "W k Δt v1 v2", "W = -k (Δt (v1 + v2) : 2) ^ 2", "W k Δt {v}", "10", "",
         "W k Δt v1 Δv", "W = -k (Δt (v1 + Δv : 2)) ^ 2", "W k Δt {v}", "18", "",
         "W k Δt v2 Δv", "W = -k (Δt (v2 - Δv : 2)) ^ 2", "W k Δt {v}", "15", "",
         "W k Δt {v}", "W = -k (Δt {v}) ^ 2", "W k Δs", "21", "",
         "W m P Δs Δv", "W = √(m P Δs Δv)", "W m Δs Δt Δv", "43", "",
         "W m Δs Δt v1", "W = 2 m Δs (Δs : Δt - v1) : Δt", "W m v1 {v}", "20", "",
         "W m Δs Δt v2", "W = 2 m Δs (v2 - Δs : Δt) : Δt", "W m v2 {v}", "20", "",
         "W m Δs Δt Δv", "W = m Δs Δv : Δt", "W a m Δs", "23", "",
         "W m v1 v2", "W = m (v2 ^ 2 - v1 ^ 2) : 2", "W m Δv {v}", "19", "",
         "W m v1 Δv", "W = m (v1 + Δv : 2) Δv", "W m Δv {v}", "18", "",
         "W m v1 {v}", "W = 2 m ({v} - v1) {v}", "W m Δv {v}", "16", "",
         "W m v2 Δv", "W = m (v2 - Δv : 2) Δv", "W m Δv {v}", "15", "",
         "W m v2 {v}", "W = 2 m (v2 - {v}) {v}", "W m Δv {v}", "13", "",
         "W m Δv {v}", "W = m Δv {v}", "W a m Δt {v}", "23", "",
         "W P Δs v1 v2", "W = 2 P Δs : (v1 + v2)", "W P Δs {v}", "10", "",
         "W P Δs v1 Δv", "W = P Δs : (v1 + Δv : 2)", "W P Δs {v}", "18", "",
         "W P Δs v2 Δv", "W = P Δs : (v2 - Δv : 2)", "W P Δs {v}", "15", "",
         "W P Δs {v}", "W = P Δs : {v}", "W P Δt", "22", "",
         "W P Δt", "W = P Δt", "", "44", ""} ' W => 13534
      Case "θ" : DՃA = New String() {
         "θ a ax", "θ = acos(ax : a)", "", "0", "",
         "θ a az", "θ = acos(az : a)", "", "0", "",
         "θ a ay", "θ = asin(ay : a)", "", "0", "",
         "θ ax ay", "θ = atan(ay : ax)", "", "0", "",
         "θ ay az", "θ = atan(ay : az)", "", "0", "",
         "θ a ax ϕ", "θ = acos(ax : a : sin(ϕ))", "", "0", "",
         "θ a az ϕ", "θ = acos(az : a : cos(ϕ))", "", "0", "",
         "θ ax ay ϕ", "θ = atan(ay sin(ϕ) : ax)", "", "0", "",
         "θ ay az ϕ", "θ = atan(ay cos(ϕ) : az)", "", "0", "",
         "θ F Fx", "θ = acos(Fx : F)", "", "0", "",
         "θ F Fz", "θ = acos(Fz : F)", "", "0", "",
         "θ F Fy", "θ = asin(Fy : F)", "", "0", "",
         "θ Fx Fy", "θ = atan(Fy : Fx)", "", "0", "",
         "θ Fy Fz", "θ = atan(Fy : Fz)", "", "0", "",
         "θ F Fx ϕ", "θ = acos(Fx : F : sin(ϕ))", "", "0", "",
         "θ F Fz ϕ", "θ = acos(Fz : F : cos(ϕ))", "", "0", "",
         "θ Fx Fy ϕ", "θ = atan(Fy sin(ϕ) : Fx)", "", "0", "",
         "θ Fy Fz ϕ", "θ = atan(Fy cos(ϕ) : Fz)", "", "0", "",
         "θ Ft Ftx", "θ = acos(Ftx : Ft)", "", "0", "",
         "θ Ft Ftz", "θ = acos(Ftz : Ft)", "", "0", "",
         "θ Ft Fty", "θ = asin(Fty : Ft)", "", "0", "",
         "θ Ftx Fty", "θ = atan(Fty : Ftx)", "", "0", "",
         "θ Fty Ftz", "θ = atan(Fty : Ftz)", "", "0", "",
         "θ Ft Ftx ϕ", "θ = acos(Ftx : Ft : sin(ϕ))", "", "0", "",
         "θ Ft Ftz ϕ", "θ = acos(Ftz : Ft : cos(ϕ))", "", "0", "",
         "θ Ftx Fty ϕ", "θ = atan(Fty sin(ϕ) : Ftx)", "", "0", "",
         "θ Fty Ftz ϕ", "θ = atan(Fty cos(ϕ) : Ftz)", "", "0", "",
         "θ p px", "θ = acos(px : p)", "", "0", "",
         "θ p pz", "θ = acos(pz : p)", "", "0", "",
         "θ p py", "θ = asin(py : p)", "", "0", "",
         "θ px py", "θ = atan(py : px)", "", "0", "",
         "θ py pz", "θ = atan(py : pz)", "", "0", "",
         "θ p px ϕ", "θ = acos(px : p : sin(ϕ))", "", "0", "",
         "θ p pz ϕ", "θ = acos(pz : p : cos(ϕ))", "", "0", "",
         "θ px py ϕ", "θ = atan(py sin(ϕ) : px)", "", "0", "",
         "θ py pz ϕ", "θ = atan(py cos(ϕ) : pz)", "", "0", "",
         "θ Δs Δsx", "θ = acos(Δsx : Δs)", "", "0", "",
         "θ Δs Δsz", "θ = acos(Δsz : Δs)", "", "0", "",
         "θ Δs Δsy", "θ = asin(Δsy : Δs)", "", "0", "",
         "θ Δsx Δsy", "θ = atan(Δsy : Δsx)", "", "0", "",
         "θ Δsy Δsz", "θ = atan(Δsy : Δsz)", "", "0", "",
         "θ Δs Δsx ϕ", "θ = acos(Δsx : Δs : sin(ϕ))", "", "0", "",
         "θ Δs Δsz ϕ", "θ = acos(Δsz : Δs : cos(ϕ))", "", "0", "",
         "θ Δsx Δsy ϕ", "θ = atan(Δsy sin(ϕ) : Δsx)", "", "0", "",
         "θ Δsy Δsz ϕ", "θ = atan(Δsy cos(ϕ) : Δsz)", "", "0", "",
         "θ Δv Δvx", "θ = acos(Δvx : Δv)", "", "0", "",
         "θ Δv Δvz", "θ = acos(Δvz : Δv)", "", "0", "",
         "θ Δv Δvy", "θ = asin(Δvy : Δv)", "", "0", "",
         "θ Δvx Δvy", "θ = atan(Δvy : Δvx)", "", "0", "",
         "θ Δvy Δvz", "θ = atan(Δvy : Δvz)", "", "0", "",
         "θ Δv Δvx ϕ", "θ = acos(Δvx : Δv : sin(ϕ))", "", "0", "",
         "θ Δv Δvz ϕ", "θ = acos(Δvz : Δv : cos(ϕ))", "", "0", "",
         "θ Δvx Δvy ϕ", "θ = atan(Δvy sin(ϕ) : Δvx)", "", "0", "",
         "θ Δvy Δvz ϕ", "θ = atan(Δvy cos(ϕ) : Δvz)", "", "0", "",
         "θ {v} {vx}", "θ = acos({vx} : {v})", "", "0", "",
         "θ {v} {vz}", "θ = acos({vz} : {v})", "", "0", "",
         "θ {v} {vy}", "θ = asin({vy} : {v})", "", "0", "",
         "θ {vx} {vy}", "θ = atan({vy} : {vx})", "", "0", "",
         "θ {vy} {vz}", "θ = atan({vy} : {vz})", "", "0", "",
         "θ {v} {vx} ϕ", "θ = acos({vx} : {v} : sin(ϕ))", "", "0", "",
         "θ {v} {vz} ϕ", "θ = acos({vz} : {v} : cos(ϕ))", "", "0", "",
         "θ {vx} {vy} ϕ", "θ = atan({vy} sin(ϕ) : {vx})", "", "0", "",
         "θ {vy} {vz} ϕ", "θ = atan({vy} cos(ϕ) : {vz})", "", "0", ""} ' θ => 63
      Case "ϕ" : DՃA = New String() {
         "ϕ ay az θ", "ϕ = acos(az tan(θ) : ay)", "", "0", "",
         "ϕ a az θ", "ϕ = acos(az : a : cos(θ))", "", "0", "",
         "ϕ a ax θ", "ϕ = asin(ax : a : cos(θ))", "", "0", "",
         "ϕ ax ay θ", "ϕ = asin(ax tan(θ) : ay)", "", "0", "",
         "ϕ ax az", "ϕ = atan(ax : az)", "", "0", "",
         "ϕ F Fx θ", "ϕ = asin(Fx : F : cos(θ))", "", "0", "",
         "ϕ F Fz θ", "ϕ = acos(Fz : F : cos(θ))", "", "0", "",
         "ϕ Fx Fy θ", "ϕ = asin(Fx tan(θ) : Fy)", "", "0", "",
         "ϕ Fx Fz", "ϕ = atan(Fx : Fz)", "", "0", "",
         "ϕ Fy Fz θ", "ϕ = acos(Fz tan(θ) : Fy)", "", "0", "",
         "ϕ Ft Ftx θ", "ϕ = asin(Ftx : Ft : cos(θ))", "", "0", "",
         "ϕ Ft Ftz θ", "ϕ = acos(Ftz : Ft : cos(θ))", "", "0", "",
         "ϕ Ftx Fty θ", "ϕ = asin(Ftx tan(θ) : Fty)", "", "0", "",
         "ϕ Ftx Ftz", "ϕ = atan(Ftx : Ftz)", "", "0", "",
         "ϕ Fty Ftz θ", "ϕ = acos(Ftz tan(θ) : Fty)", "", "0", "",
         "ϕ py pz θ", "ϕ = acos(pz tan(θ) : py)", "", "0", "",
         "ϕ p pz θ", "ϕ = acos(pz : p : cos(θ))", "", "0", "",
         "ϕ p px θ", "ϕ = asin(px : p : cos(θ))", "", "0", "",
         "ϕ px py θ", "ϕ = asin(px tan(θ) : py)", "", "0", "",
         "ϕ px pz", "ϕ = atan(px : pz)", "", "0", "",
         "ϕ Δsy Δsz θ", "ϕ = acos(Δsz tan(θ) : Δsy)", "", "0", "",
         "ϕ Δs Δsz θ", "ϕ = acos(Δsz : Δs : cos(θ))", "", "0", "",
         "ϕ Δs Δsx θ", "ϕ = asin(Δsx : Δs : cos(θ))", "", "0", "",
         "ϕ Δsx Δsy θ", "ϕ = asin(Δsx tan(θ) : Δsy)", "", "0", "",
         "ϕ Δsx Δsz", "ϕ = atan(Δsx : Δsz)", "", "0", "",
         "ϕ Δvy Δvz θ", "ϕ = acos(Δvz tan(θ) : Δvy)", "", "0", "",
         "ϕ Δv Δvz θ", "ϕ = acos(Δvz : Δv : cos(θ))", "", "0", "",
         "ϕ Δv Δvx θ", "ϕ = asin(Δvx : Δv : cos(θ))", "", "0", "",
         "ϕ Δvx Δvy θ", "ϕ = asin(Δvx tan(θ) : Δvy)", "", "0", "",
         "ϕ Δvx Δvz", "ϕ = atan(Δvx : Δvz)", "", "0", "",
         "ϕ {vy} {vz} θ", "ϕ = acos({vz} tan(θ) : {vy})", "", "0", "",
         "ϕ {v} {vz} θ", "ϕ = acos({vz} : {v} : cos(θ))", "", "0", "",
         "ϕ {v} {vx} θ", "ϕ = asin({vx} : {v} : cos(θ))", "", "0", "",
         "ϕ {vx} {vy} θ", "ϕ = asin({vx} tan(θ) : {vy})", "", "0", "",
         "ϕ {vx} {vz}", "ϕ = atan({vx} : {vz})", "", "0", ""} ' ϕ => 35
      Case "ax" : DՃA = New String() {
         "ax a", "ax = a", "", "0", "",
         "ax a θ", "ax = a cos(θ)", "", "0", "",
         "ax ay θ", "ax = ay : tan(θ)", "", "0", "",
         "ax az ϕ", "ax = az tan(ϕ)", "", "0", "",
         "ax a ay", "ax = √(a ^ 2 - ay ^ 2)", "", "0", "",
         "ax a az", "ax = √(a ^ 2 - az ^ 2)", "", "0", "",
         "ax a θ ϕ", "ax = a cos(θ) sin(ϕ)", "", "0", "",
         "ax ay θ ϕ", "ax = ay sin(ϕ) : tan(θ)", "", "0", "",
         "ax a ay az", "ax = √(a ^ 2 - ay ^ 2 - az ^ 2)", "", "0", ""} ' ax => 9
      Case "ay" : DՃA = New String() {
         "ay a", "ay = a", "", "0", "",
         "ay a θ", "ay = a sin(θ)", "", "0", "",
         "ay ax θ", "ay = ax tan(θ)", "", "0", "",
         "ay az θ", "ay = az tan(θ)", "", "0", "",
         "ay a ax", "ay = √(a ^ 2 - ax ^ 2)", "", "0", "",
         "ay a az", "ay = √(a ^ 2 - az ^ 2)", "", "0", "",
         "ay ax θ ϕ", "ay = ax tan(θ) : sin(ϕ)", "", "0", "",
         "ay az θ ϕ", "ay = az tan(θ) : cos(ϕ)", "", "0", "",
         "ay a ax az", "ay = √(a ^ 2 - ax ^ 2 - az ^ 2)", "", "0", ""} ' ay => 9
      Case "az" : DՃA = New String() {
         "az a", "az = a", "", "0", "",
         "az a θ", "az = a cos(θ)", "", "0", "",
         "az ax ϕ", "az = ax : tan(ϕ)", "", "0", "",
         "az ay θ", "az = ay : tan(θ)", "", "0", "",
         "az a ax", "az = √(a ^ 2 - ax ^ 2)", "", "0", "",
         "az a ay", "az = √(a ^ 2 - ay ^ 2)", "", "0", "",
         "az ay θ ϕ", "az = ay cos(ϕ) : tan(θ)", "", "0", "",
         "az a θ ϕ", "az = a cos(θ) cos(ϕ)", "", "0", "",
         "az a ax ay", "az = √(a ^ 2 - ax ^ 2 - ay ^ 2)", "", "0", ""} ' az => 9
      Case "Ff" : DՃA = New String() {
         "Ff F", "Ff = F", "", "0", "",
         "Ff F |Fn| Ft μg", "Ff = F - Ft - μg |Fn|", "", "0", "",
         "Ff F |Fn| Ft μh", "Ff = F - Ft - μh |Fn|", "", "0", "",
         "Ff F |Fn| Ft μr", "Ff = F - Ft - μr |Fn|", "", "0", "",
         "Ff F |Fn| μg", "Ff = F - μg |Fn|", "", "0", "",
         "Ff F |Fn| μh", "Ff = F - μh |Fn|", "", "0", "",
         "Ff F |Fn| μr", "Ff = F - μr |Fn|", "", "0", "",
         "Ff F Frg", "Ff = F - Frg", "", "0", "",
         "Ff F Frg Ft", "Ff = F - Ft - Frg", "", "0", "",
         "Ff F Frh", "Ff = F - Frh", "", "0", "",
         "Ff F Frh Ft", "Ff = F - Ft - Frh", "", "0", "",
         "Ff F Frr", "Ff = F - Frr", "", "0", "",
         "Ff F Frr Ft", "Ff = F - Ft - Frr", "", "0", "",
         "Ff F Ft", "Ff = F - Ft", "", "0", "",
         "Ff k Δs", "Ff = -k Δs", "", "0", ""} ' Ff => 196
      Case "Ft" : DՃA = New String() {
         "Ft F Ff", "Ft = F - Ff", "", "0", "",
         "Ft F Ff |Fn| μg", "Ft = F - Ff - μg |Fn|", "", "0", "",
         "Ft F Ff |Fn| μh", "Ft = F - Ff - μh |Fn|", "", "0", "",
         "Ft F Ff |Fn| μr", "Ft = F - Ff - μr |Fn|", "", "0", "",
         "Ft F Ff Frg", "Ft = F - Ff - Frg", "", "0", "",
         "Ft F Ff Frh", "Ft = F - Ff - Frh", "", "0", "",
         "Ft F Ff Frr", "Ft = F - Ff - Frr", "", "0", "",
         "Ft F |Fn| k μg Δs", "Ft = F + k Δs - μg |Fn|", "", "0", "",
         "Ft F |Fn| k μh Δs", "Ft = F + k Δs - μh |Fn|", "", "0", "",
         "Ft F |Fn| k μr Δs", "Ft = F + k Δs - μr |Fn|", "", "0", "",
         "Ft F |Fn| μg", "Ft = F - μg |Fn|", "", "0", "",
         "Ft F |Fn| μh", "Ft = F - μh |Fn|", "", "0", "",
         "Ft F |Fn| μr", "Ft = F - μr |Fn|", "", "0", "",
         "Ft F Frg", "Ft = F - Frg", "", "0", "",
         "Ft F Frg k Δs", "Ft = F + k Δs - Frg", "", "0", "",
         "Ft F Frh", "Ft = F - Frh", "", "0", "",
         "Ft F Frh k Δs", "Ft = F + k Δs - Frh", "", "0", "",
         "Ft F Frr", "Ft = F - Frr", "", "0", "",
         "Ft F Frr k Δs", "Ft = F + k Δs - Frr", "", "0", "",
         "Ft F k Δs", "Ft = F + k Δs", "", "0", ""} ' Ft => 351
      Case "Fx" : DՃA = New String() {
         "Fx F", "Fx = F", "", "0", "",
         "Fx F θ", "Fx = F cos(θ)", "", "0", "",
         "Fx Fy θ", "Fx = Fy : tan(θ)", "", "0", "",
         "Fx Fz ϕ", "Fx = Fz tan(ϕ)", "", "0", "",
         "Fx F Fy", "Fx = √(F ^ 2 - Fy ^ 2)", "", "0", "",
         "Fx F Fz", "Fx = √(F ^ 2 - Fz ^ 2)", "", "0", "",
         "Fx F θ ϕ", "Fx = F cos(θ) sin(ϕ)", "", "0", "",
         "Fx Fy θ ϕ", "Fx = Fy sin(ϕ) : tan(θ)", "", "0", "",
         "Fx F Fy Fz", "Fx = √(F ^ 2 - Fy ^ 2 - Fz ^ 2)", "", "0", ""} ' Fx => 9
      Case "Fy" : DՃA = New String() {
         "Fy F", "Fy = F", "", "0", "",
         "Fy F θ", "Fy = F sin(θ)", "", "0", "",
         "Fy Fx θ", "Fy = Fx tan(θ)", "", "0", "",
         "Fy Fz θ", "Fy = Fz tan(θ)", "", "0", "",
         "Fy F Fx", "Fy = √(F ^ 2 - Fx ^ 2)", "", "0", "",
         "Fy F Fz", "Fy = √(F ^ 2 - Fz ^ 2)", "", "0", "",
         "Fy Fx θ ϕ", "Fy = Fx tan(θ) : sin(ϕ)", "", "0", "",
         "Fy Fz θ ϕ", "Fy = Fz tan(θ) : cos(ϕ)", "", "0", "",
         "Fy F Fx Fz", "Fy = √(F ^ 2 - Fx ^ 2 - Fz ^ 2)", "", "0", ""} ' Fy => 9
      Case "Fz" : DՃA = New String() {
         "Fz F", "Fz = F", "", "0", "",
         "Fz F θ", "Fz = F cos(θ)", "", "0", "",
         "Fz Fx ϕ", "Fz = Fx : tan(ϕ)", "", "0", "",
         "Fz Fy θ", "Fz = Fy : tan(θ)", "", "0", "",
         "Fz F Fx", "Fz = √(F ^ 2 - Fx ^ 2)", "", "0", "",
         "Fz F Fy", "Fz = √(F ^ 2 - Fy ^ 2)", "", "0", "",
         "Fz Fy θ ϕ", "Fz = Fy cos(ϕ) : tan(θ)", "", "0", "",
         "Fz F θ ϕ", "Fz = F cos(θ) cos(ϕ)", "", "0", "",
         "Fz F Fx Fy", "Fz = √(F ^ 2 - Fx ^ 2 - Fy ^ 2)", "", "0", ""} ' Fz => 9
      Case "μg" : DՃA = New String() {
         "μg a |Fn| m", "μg = a m : |Fn|", "μg F |Fn|", "26", "",
         "μg a |Fn| P Δs v1", "μg = P (-v1 ± √(v1 ^ 2 + 2 a Δs)) : a : |Fn| : Δs", "μg a |Fn| P v1 W", "94", "",
         "μg a |Fn| P Δs v2", "μg = P (v2 ± √(v2 ^ 2 - 2 a Δs)) : a : |Fn| : Δs", "μg a |Fn| P v2 W", "94", "",
         "μg a |Fn| P Δs Δv", "μg = P Δv : a : |Fn| : Δs", "μg |Fn| P Δs Δt", "25", "",
         "μg a |Fn| P Δt v1", "μg = P : |Fn| : (v1 + a Δt : 2)", "μg |Fn| P v1 Δv", "24", "",
         "μg a |Fn| P Δt v2", "μg = P : |Fn| : (v2 - a Δt : 2)", "μg |Fn| P v2 Δv", "24", "",
         "μg a |Fn| P v1 W", "μg = P : |Fn| : (v1 + a W : 2 : P)", "μg a |Fn| P Δt v1", "43", "",
         "μg a |Fn| P v2 W", "μg = P : |Fn| : (v2 - a W : 2 : P)", "μg a |Fn| P Δt v2", "43", "",
         "μg a |Fn| Δt v1 W", "μg = W : |Fn| : Δt : (v1 + a Δt : 2)", "μg |Fn| Δt v1 Δv W", "24", "",
         "μg a |Fn| Δt v2 W", "μg = W : |Fn| : Δt : (v2 - a Δt : 2)", "μg |Fn| Δt v2 Δv W", "24", "",
         "μg a |Fn| v1 v2 W", "μg = 2 a W : |Fn| : (v2 ^ 2 - v1 ^ 2)", "μg a |Fn| Δv {v} W", "19", "",
         "μg a |Fn| v1 Δv W", "μg = a W : |Fn| : Δv : (v1 + Δv : 2)", "μg a |Fn| Δv {v} W", "18", "",
         "μg a |Fn| v1 {v} W", "μg = a W : |Fn| : {v} : ({v} - v1) : 2", "μg a |Fn| Δv {v} W", "16", "",
         "μg a |Fn| v2 Δv W", "μg = a W : |Fn| : Δv : (v2 - Δv : 2)", "μg a |Fn| Δv {v} W", "15", "",
         "μg a |Fn| v2 {v} W", "μg = a W : |Fn| : {v} : (v2 - {v}) : 2", "μg a |Fn| Δv {v} W", "13", "",
         "μg a |Fn| Δv {v} W", "μg = a W : |Fn| : Δv : {v}", "μg |Fn| Δt {v} W", "25", "",
         "μg F Ff |Fn|", "μg = (F - Ff) : |Fn|", "", "0", "",
         "μg F Ff |Fn| Ft", "μg = (F - Ft - Ff) : |Fn|", "", "0", "",
         "μg F |Fn|", "μg = F : |Fn|", "", "87", "",
         "μg F |Fn| Ft", "μg = (F - Ft) : |Fn|", "", "0", "",
         "μg F |Fn| Ft k Δs", "μg = (F + k Δs - Ft) : |Fn|", "", "0", "",
         "μg F |Fn| k Δs", "μg = (F + k Δs) : |Fn|", "", "0", "",
         "μg |Fn| Frg", "μg = Frg : |Fn|", "", "0", "",
         "μg |Fn| m P Δs Δv", "μg = √(P m Δv : Δs) : |Fn|", "μg |Fn| m P Δv W", "94", "",
         "μg |Fn| m P Δt v1", "μg = m (-v1 ± √(v1 ^ 2 + 2 P Δt : m)) : |Fn| : Δt", "μg |Fn| m Δt v1 W", "44", "",
         "μg |Fn| m P Δt v2", "μg = m (v2 ± √(v2 ^ 2 - 2 P Δt : m)) : |Fn| : Δt", "μg |Fn| m Δt v2 W", "44", "",
         "μg |Fn| m P v1 W", "μg = m P (-v1 ± √(v1 ^ 2 + 2 W : m)) : |Fn| : W", "μg |Fn| m Δt v1 W", "43", "",
         "μg |Fn| m P v2 W", "μg = m P (v2 ± √(v2 ^ 2 - 2 W : m) : |Fn| : W", "μg |Fn| m Δt v2 W", "43", "",
         "μg |Fn| m P Δv W", "μg = m P Δv : |Fn| : W", "μg |Fn| m Δt Δv", "43", "",
         "μg |Fn| m Δs Δt v1", "μg = 2 m (Δs : Δt - v1) : |Fn| : Δt", "μg |Fn| m Δt v1 {v}", "20", "",
         "μg |Fn| m Δs Δt v2", "μg = 2 m (v2 - Δs : Δt) : |Fn| : Δt", "μg |Fn| m Δt v2 {v}", "20", "",
         "μg |Fn| m Δs v1 v2", "μg = m (v2 ^ 2 - v1 ^ 2) : |Fn| : Δs : 2", "μg |Fn| m Δs Δv {v}", "19", "",
         "μg |Fn| m Δs v1 Δv", "μg = m Δv (v1 + Δv : 2) : |Fn| : Δs", "μg |Fn| m Δs Δv {v}", "18", "",
         "μg |Fn| m Δs v1 {v}", "μg = 2 m {v} ({v} - v1) : |Fn| : Δs", "μg |Fn| m Δs Δv {v}", "16", "",
         "μg |Fn| m Δs v2 Δv", "μg = m Δv (v2 - Δv : 2) : |Fn| : Δs", "μg |Fn| m Δs Δv {v}", "15", "",
         "μg |Fn| m Δs v2 {v}", "μg = 2 m {v} (v2 - {v}) : |Fn| : Δs", "μg |Fn| m Δs Δv {v}", "13", "",
         "μg |Fn| m Δs Δv {v}", "μg = m Δv {v} : |Fn| : Δs", "μg |Fn| m Δt Δv", "22", "",
         "μg |Fn| m Δt v1 {v}", "μg = 2 m ({v} - v1) : |Fn| : Δt", "μg |Fn| m Δt Δv", "16", "",
         "μg |Fn| m Δt v1 W", "μg = m (-v1 ± √(v1 ^ 2 + 2 W : m) : |Fn| : Δt", "μg |Fn| m Δt Δv", "70", "",
         "μg |Fn| m Δt v2 {v}", "μg = 2 m (v2 - {v}) : |Fn| : Δt", "μg |Fn| m Δt Δv", "13", "",
         "μg |Fn| m Δt v2 W", "μg = m (v2 ± √(v2 ^ 2 - 2 W : m) : |Fn| : Δt", "μg |Fn| m Δt Δv", "74", "",
         "μg |Fn| m Δt Δv", "μg = m Δv : |Fn| : Δt", "μg a |Fn| m", "23", "",
         "μg |Fn| P Δs Δt", "μg = P Δt : |Fn| : Δs", "μg |Fn| Δs W", "44", "",
         "μg |Fn| P v1 v2", "μg = 2 P : |Fn| : (v1 + v2)", "μg |Fn| P {v}", "10", "",
         "μg |Fn| P v1 Δv", "μg = P : |Fn| : (v1 + Δv : 2)", "μg |Fn| P {v}", "18", "",
         "μg |Fn| P v2 Δv", "μg = P : |Fn| : (v2 - Δv : 2)", "μg |Fn| P {v}", "15", "",
         "μg |Fn| P {v}", "μg = P : |Fn| : {v}", "μg |Fn| P Δs Δt", "21", "",
         "μg |Fn| Δs W", "μg = W : |Fn| : Δs", "", "96", "",
         "μg |Fn| Δt v1 v2 W", "μg = 2 W : |Fn| : Δt : (v1 + v2)", "μg |Fn| Δt {v} W", "10", "",
         "μg |Fn| Δt v1 Δv W", "μg = W : |Fn| : Δt : (v1 + Δv : 2)", "μg |Fn| Δt {v} W", "18", "",
         "μg |Fn| Δt v2 Δv W", "μg = W : |Fn| : Δt : (v2 - Δv : 2)", "μg |Fn| Δt {v} W", "15", "",
         "μg |Fn| Δt {v} W", "μg = W : |Fn| : Δt : {v}", "μg |Fn| Δs W", "21", ""} ' μg => 2718
      Case "μh" : DՃA = New String() {
         "μh a |Fn| m", "μh = a m : |Fn|", "μh F |Fn|", "26", "",
         "μh a |Fn| P Δs v1", "μh = P (-v1 ± √(v1 ^ 2 + 2 a Δs)) : a : |Fn| : Δs", "μh a |Fn| P v1 W", "98", "",
         "μh a |Fn| P Δs v2", "μh = P (v2 ± √(v2 ^ 2 - 2 a Δs)) : a : |Fn| : Δs", "μh a |Fn| P v2 W", "98", "",
         "μh a |Fn| P Δs Δv", "μh = P Δv : a : |Fn| : Δs", "μh |Fn| P Δs Δt", "25", "",
         "μh a |Fn| P Δt v1", "μh = P : |Fn| : (v1 + a Δt : 2)", "μh |Fn| P v1 Δv", "24", "",
         "μh a |Fn| P Δt v2", "μh = P : |Fn| : (v2 - a Δt : 2)", "μh |Fn| P v2 Δv", "24", "",
         "μh a |Fn| P v1 W", "μh = P : |Fn| : (v1 + a W : 2 : P)", "μh a |Fn| P Δt v1", "43", "",
         "μh a |Fn| P v2 W", "μh = P : |Fn| : (v2 - a W : 2 : P)", "μh a |Fn| P Δt v2", "43", "",
         "μh a |Fn| Δt v1 W", "μh = W : |Fn| : Δt : (v1 + a Δt : 2)", "μh |Fn| Δt v1 Δv W", "24", "",
         "μh a |Fn| Δt v2 W", "μh = W : |Fn| : Δt : (v2 - a Δt : 2)", "μh |Fn| Δt v2 Δv W", "24", "",
         "μh a |Fn| v1 v2 W", "μh = 2 a W : |Fn| : (v2 ^ 2 - v1 ^ 2)", "μh a |Fn| Δv {v} W", "19", "",
         "μh a |Fn| v1 Δv W", "μh = a W : |Fn| : Δv : (v1 + Δv : 2)", "μh a |Fn| Δv {v} W", "18", "",
         "μh a |Fn| v1 {v} W", "μh = a W : |Fn| : {v} : ({v} - v1) : 2", "μh a |Fn| Δv {v} W", "16", "",
         "μh a |Fn| v2 Δv W", "μh = a W : |Fn| : Δv : (v2 - Δv : 2)", "μh a |Fn| Δv {v} W", "15", "",
         "μh a |Fn| v2 {v} W", "μh = a W : |Fn| : {v} : (v2 - {v}) : 2", "μh a |Fn| Δv {v} W", "13", "",
         "μh a |Fn| Δv {v} W", "μh = a W : |Fn| : Δv : {v}", "μh |Fn| Δt {v} W", "25", "",
         "μh F Ff |Fn|", "μh = (F - Ff) : |Fn|", "", "0", "",
         "μh F Ff |Fn| Ft", "μh = (F - Ft - Ff) : |Fn|", "", "0", "",
         "μh F |Fn|", "μh = F : |Fn|", "", "90", "",
         "μh F |Fn| Ft", "μh = (F - Ft) : |Fn|", "", "0", "",
         "μh F |Fn| Ft k Δs", "μh = (F + k Δs - Ft) : |Fn|", "", "0", "",
         "μh F |Fn| k Δs", "μh = (F + k Δs) : |Fn|", "", "0", "",
         "μh |Fn| Frh", "μh = Frh : |Fn|", "", "0", "",
         "μh |Fn| m P Δs Δv", "μh = √(P m Δv : Δs) : |Fn|", "μh |Fn| m P Δv W", "98", "",
         "μh |Fn| m P Δt v1", "μh = m (-v1 ± √(v1 ^ 2 + 2 P Δt : m)) : |Fn| : Δt", "μh |Fn| m Δt v1 W", "44", "",
         "μh |Fn| m P Δt v2", "μh = m (v2 ± √(v2 ^ 2 - 2 P Δt : m)) : |Fn| : Δt", "μh |Fn| m Δt v2 W", "44", "",
         "μh |Fn| m P v1 W", "μh = m P (-v1 ± √(v1 ^ 2 + 2 W : m)) : |Fn| : W", "μh |Fn| m Δt v1 W", "43", "",
         "μh |Fn| m P v2 W", "μh = m P (v2 ± √(v2 ^ 2 - 2 W : m) : |Fn| : W", "μh |Fn| m Δt v2 W", "43", "",
         "μh |Fn| m P Δv W", "μh = m P Δv : |Fn| : W", "μh |Fn| m Δt Δv", "43", "",
         "μh |Fn| m Δs Δt v1", "μh = 2 m (Δs : Δt - v1) : |Fn| : Δt", "μh |Fn| m Δt v1 {v}", "20", "",
         "μh |Fn| m Δs Δt v2", "μh = 2 m (v2 - Δs : Δt) : |Fn| : Δt", "μh |Fn| m Δt v2 {v}", "20", "",
         "μh |Fn| m Δs v1 v2", "μh = m (v2 ^ 2 - v1 ^ 2) : |Fn| : Δs : 2", "μh |Fn| m Δs Δv {v}", "19", "",
         "μh |Fn| m Δs v1 Δv", "μh = m Δv (v1 + Δv : 2) : |Fn| : Δs", "μh |Fn| m Δs Δv {v}", "18", "",
         "μh |Fn| m Δs v1 {v}", "μh = 2 m {v} ({v} - v1) : |Fn| : Δs", "μh |Fn| m Δs Δv {v}", "16", "",
         "μh |Fn| m Δs v2 Δv", "μh = m Δv (v2 - Δv : 2) : |Fn| : Δs", "μh |Fn| m Δs Δv {v}", "15", "",
         "μh |Fn| m Δs v2 {v}", "μh = 2 m {v} (v2 - {v}) : |Fn| : Δs", "μh |Fn| m Δs Δv {v}", "13", "",
         "μh |Fn| m Δs Δv {v}", "μh = m Δv {v} : |Fn| : Δs", "μh |Fn| m Δt Δv", "22", "",
         "μh |Fn| m Δt v1 {v}", "μh = 2 m ({v} - v1) : |Fn| : Δt", "μh |Fn| m Δt Δv", "16", "",
         "μh |Fn| m Δt v1 W", "μh = m (-v1 ± √(v1 ^ 2 + 2 W : m) : |Fn| : Δt", "μh |Fn| m Δt Δv", "70", "",
         "μh |Fn| m Δt v2 {v}", "μh = 2 m (v2 - {v}) : |Fn| : Δt", "μh |Fn| m Δt Δv", "13", "",
         "μh |Fn| m Δt v2 W", "μh = m (v2 ± √(v2 ^ 2 - 2 W : m) : |Fn| : Δt", "μh |Fn| m Δt Δv", "74", "",
         "μh |Fn| m Δt Δv", "μh = m Δv : |Fn| : Δt", "μh a |Fn| m", "23", "",
         "μh |Fn| P Δs Δt", "μh = P Δt : |Fn| : Δs", "μh |Fn| Δs W", "44", "",
         "μh |Fn| P v1 v2", "μh = 2 P : |Fn| : (v1 + v2)", "μh |Fn| P {v}", "10", "",
         "μh |Fn| P v1 Δv", "μh = P : |Fn| : (v1 + Δv : 2)", "μh |Fn| P {v}", "18", "",
         "μh |Fn| P v2 Δv", "μh = P : |Fn| : (v2 - Δv : 2)", "μh |Fn| P {v}", "15", "",
         "μh |Fn| P {v}", "μh = P : |Fn| : {v}", "μh |Fn| P Δs Δt", "10", "",
         "μh |Fn| Δs W", "μh = W : |Fn| : Δs", "", "100", "",
         "μh |Fn| Δt v1 v2 W", "μh = 2 W : |Fn| : Δt : (v1 + v2)", "μh |Fn| Δt {v} W", "10", "",
         "μh |Fn| Δt v1 Δv W", "μh = W : |Fn| : Δt : (v1 + Δv : 2)", "μh |Fn| Δt {v} W", "18", "",
         "μh |Fn| Δt v2 Δv W", "μh = W : |Fn| : Δt : (v2 - Δv : 2)", "μh |Fn| Δt {v} W", "15", "",
         "μh |Fn| Δt {v} W", "μh = W : |Fn| : Δt : {v}", "μh |Fn| Δs W", "21", ""} ' μh => 2718
      Case "μr" : DՃA = New String() {
         "μr a |Fn| m", "μr = a m : |Fn|", "μr F |Fn|", "26", "",
         "μr a |Fn| P Δs v1", "μr = P (-v1 ± √(v1 ^ 2 + 2 a Δs)) : a : |Fn| : Δs", "μr a |Fn| P v1 W", "102", "",
         "μr a |Fn| P Δs v2", "μr = P (v2 ± √(v2 ^ 2 - 2 a Δs)) : a : |Fn| : Δs", "μr a |Fn| P v2 W", "102", "",
         "μr a |Fn| P Δs Δv", "μr = P Δv : a : |Fn| : Δs", "μr |Fn| P Δs Δt", "25", "",
         "μr a |Fn| P Δt v1", "μr = P : |Fn| : (v1 + a Δt : 2)", "μr |Fn| P v1 Δv", "24", "",
         "μr a |Fn| P Δt v2", "μr = P : |Fn| : (v2 - a Δt : 2)", "μr |Fn| P v2 Δv", "24", "",
         "μr a |Fn| P v1 W", "μr = P : |Fn| : (v1 + a W : 2 : P)", "μr a |Fn| P Δt v1", "43", "",
         "μr a |Fn| P v2 W", "μr = P : |Fn| : (v2 - a W : 2 : P)", "μr a |Fn| P Δt v2", "43", "",
         "μr a |Fn| Δt v1 W", "μr = W : |Fn| : Δt : (v1 + a Δt : 2)", "μr |Fn| Δt v1 Δv W", "24", "",
         "μr a |Fn| Δt v2 W", "μr = W : |Fn| : Δt : (v2 - a Δt : 2)", "μr |Fn| Δt v2 Δv W", "24", "",
         "μr a |Fn| v1 v2 W", "μr = 2 a W : |Fn| : (v2 ^ 2 - v1 ^ 2)", "μr a |Fn| Δv {v} W", "19", "",
         "μr a |Fn| v1 Δv W", "μr = a W : |Fn| : Δv : (v1 + Δv : 2)", "μr a |Fn| Δv {v} W", "18", "",
         "μr a |Fn| v1 {v} W", "μr = a W : |Fn| : {v} : ({v} - v1) : 2", "μr a |Fn| Δv {v} W", "16", "",
         "μr a |Fn| v2 Δv W", "μr = a W : |Fn| : Δv : (v2 - Δv : 2)", "μr a |Fn| Δv {v} W", "15", "",
         "μr a |Fn| v2 {v} W", "μr = a W : |Fn| : {v} : (v2 - {v}) : 2", "μr a |Fn| Δv {v} W", "13", "",
         "μr a |Fn| Δv {v} W", "μr = a W : |Fn| : Δv : {v}", "μr |Fn| Δt {v} W", "25", "",
         "μr F Ff |Fn|", "μr = (F - Ff) : |Fn|", "", "0", "",
         "μr F Ff |Fn| Ft", "μr = (F - Ft - Ff) : |Fn|", "", "0", "",
         "μr F |Fn|", "μr = F : |Fn|", "", "93", "",
         "μr F |Fn| Ft", "μr = (F - Ft) : |Fn|", "", "0", "",
         "μr F |Fn| Ft k Δs", "μr = (F + k Δs - Ft) : |Fn|", "", "0", "",
         "μr F |Fn| k Δs", "μr = (F + k Δs) : |Fn|", "", "0", "",
         "μr |Fn| Frr", "μr = Frr : |Fn|", "", "0", "",
         "μr |Fn| m P Δs Δv", "μr = √(P m Δv : Δs) : |Fn|", "μr |Fn| m P Δv W", "102", "",
         "μr |Fn| m P Δt v1", "μr = m (-v1 ± √(v1 ^ 2 + 2 P Δt : m)) : |Fn| : Δt", "μr |Fn| m Δt v1 W", "44", "",
         "μr |Fn| m P Δt v2", "μr = m (v2 ± √(v2 ^ 2 - 2 P Δt : m)) : |Fn| : Δt", "μr |Fn| m Δt v2 W", "44", "",
         "μr |Fn| m P v1 W", "μr = m P (-v1 ± √(v1 ^ 2 + 2 W : m)) : |Fn| : W", "μr |Fn| m Δt v1 W", "43", "",
         "μr |Fn| m P v2 W", "μr = m P (v2 ± √(v2 ^ 2 - 2 W : m) : |Fn| : W", "μr |Fn| m Δt v2 W", "43", "",
         "μr |Fn| m P Δv W", "μr = m P Δv : |Fn| : W", "μr |Fn| m Δt Δv", "43", "",
         "μr |Fn| m Δs Δt v1", "μr = 2 m (Δs : Δt - v1) : |Fn| : Δt", "μr |Fn| m Δt v1 {v}", "20", "",
         "μr |Fn| m Δs Δt v2", "μr = 2 m (v2 - Δs : Δt) : |Fn| : Δt", "μr |Fn| m Δt v2 {v}", "20", "",
         "μr |Fn| m Δs v1 v2", "μr = m (v2 ^ 2 - v1 ^ 2) : |Fn| : Δs : 2", "μr |Fn| m Δs Δv {v}", "19", "",
         "μr |Fn| m Δs v1 Δv", "μr = m Δv (v1 + Δv : 2) : |Fn| : Δs", "μr |Fn| m Δs Δv {v}", "18", "",
         "μr |Fn| m Δs v1 {v}", "μr = 2 m {v} ({v} - v1) : |Fn| : Δs", "μr |Fn| m Δs Δv {v}", "16", "",
         "μr |Fn| m Δs v2 Δv", "μr = m Δv (v2 - Δv : 2) : |Fn| : Δs", "μr |Fn| m Δs Δv {v}", "15", "",
         "μr |Fn| m Δs v2 {v}", "μr = 2 m {v} (v2 - {v}) : |Fn| : Δs", "μr |Fn| m Δs Δv {v}", "13", "",
         "μr |Fn| m Δs Δv {v}", "μr = m Δv {v} : |Fn| : Δs", "μr |Fn| m Δt Δv", "22", "",
         "μr |Fn| m Δt v1 {v}", "μr = 2 m ({v} - v1) : |Fn| : Δt", "μr |Fn| m Δt Δv", "16", "",
         "μr |Fn| m Δt v1 W", "μr = m (-v1 ± √(v1 ^ 2 + 2 W : m) : |Fn| : Δt", "μr |Fn| m Δt Δv", "70", "",
         "μr |Fn| m Δt v2 {v}", "μr = 2 m (v2 - {v}) : |Fn| : Δt", "μr |Fn| m Δt Δv", "13", "",
         "μr |Fn| m Δt v2 W", "μr = m (v2 ± √(v2 ^ 2 - 2 W : m) : |Fn| : Δt", "μr |Fn| m Δt Δv", "74", "",
         "μr |Fn| m Δt Δv", "μr = m Δv : |Fn| : Δt", "μr a |Fn| m", "23", "",
         "μr |Fn| P Δs Δt", "μr = P Δt : |Fn| : Δs", "μr |Fn| Δs W", "44", "",
         "μr |Fn| P v1 v2", "μr = 2 P : |Fn| : (v1 + v2)", "μr |Fn| P {v}", "10", "",
         "μr |Fn| P v1 Δv", "μr = P : |Fn| : (v1 + Δv : 2)", "μr |Fn| P {v}", "18", "",
         "μr |Fn| P v2 Δv", "μr = P : |Fn| : (v2 - Δv : 2)", "μr |Fn| P {v}", "15", "",
         "μr |Fn| P {v}", "μr = P : |Fn| : {v}", "μr |Fn| P Δs Δt", "21", "",
         "μr |Fn| Δs W", "μr = W : |Fn| : Δs", "", "104", "",
         "μr |Fn| Δt v1 v2 W", "μr = 2 W : |Fn| : Δt : (v1 + v2)", "μr |Fn| Δt {v} W", "10", "",
         "μr |Fn| Δt v1 Δv W", "μr = W : |Fn| : Δt : (v1 + Δv : 2)", "μr |Fn| Δt {v} W", "18", "",
         "μr |Fn| Δt v2 Δv W", "μr = W : |Fn| : Δt : (v2 - Δv : 2)", "μr |Fn| Δt {v} W", "15", "",
         "μr |Fn| Δt {v} W", "μr = W : |Fn| : Δt : {v}", "μr |Fn| Δs W", "21", ""} ' μr => 2718
      Case "px" : DՃA = New String() {
         "px p", "px = p", "", "0", "",
         "px p θ", "px = p cos(θ)", "", "0", "",
         "px py θ", "px = py : tan(θ)", "", "0", "",
         "px pz ϕ", "px = pz tan(ϕ)", "", "0", "",
         "px p py", "px = √(p ^ 2 - py ^ 2)", "", "0", "",
         "px p pz", "px = √(p ^ 2 - pz ^ 2)", "", "0", "",
         "px p θ ϕ", "px = p cos(θ) sin(ϕ)", "", "0", "",
         "px py θ ϕ", "px = py sin(ϕ) : tan(θ)", "", "0", "",
         "px p py pz", "px = √(p ^ 2 - py ^ 2 - pz ^ 2)", "", "0", ""} ' px => 9
      Case "py" : DՃA = New String() {
         "py p", "py = p", "", "0", "",
         "py p θ", "py = p sin(θ)", "", "0", "",
         "py px θ", "py = px tan(θ)", "", "0", "",
         "py pz θ", "py = pz tan(θ)", "", "0", "",
         "py p px", "py = √(p ^ 2 - px ^ 2)", "", "0", "",
         "py p pz", "py = √(p ^ 2 - pz ^ 2)", "", "0", "",
         "py px θ ϕ", "py = px tan(θ) : sin(ϕ)", "", "0", "",
         "py pz θ ϕ", "py = pz tan(θ) : cos(ϕ)", "", "0", "",
         "py p px pz", "py = √(p ^ 2 - px ^ 2 - pz ^ 2)", "", "0", ""} ' py => 9
      Case "pz" : DՃA = New String() {
         "pz p", "pz = p", "", "0", "",
         "pz p θ", "pz = p cos(θ)", "", "0", "",
         "pz px ϕ", "pz = px : tan(ϕ)", "", "0", "",
         "pz py θ", "pz = py : tan(θ)", "", "0", "",
         "pz p px", "pz = √(p ^ 2 - px ^ 2)", "", "0", "",
         "pz p py", "pz = √(p ^ 2 - py ^ 2)", "", "0", "",
         "pz py θ ϕ", "pz = py cos(ϕ) : tan(θ)", "", "0", "",
         "pz p θ ϕ", "pz = p cos(θ) cos(ϕ)", "", "0", "",
         "pz p px py", "pz = √(p ^ 2 - px ^ 2 - py ^ 2)", "", "0", ""} ' pz => 9
      Case "s1" : DՃA = New String() {
         "s1 s2 Δs", "s1 = s2 - Δs", "", "2", "1"} ' s1 => 13
      Case "s2" : DՃA = New String() {
         "s2 s1 Δs", "s2 = s1 + Δs", "", "3", "1"} ' s2 => 13
      Case "Δs" : DՃA = New String() {
         "Δs a F P v1", "Δs = 2 P (P : F - v1) : a : F", "Δs a P v1 W", "29", "",
         "Δs a F P v2", "Δs = 2 P (v2 - P : F) : a : F", "Δs a P v2 W", "29", "",
         "Δs a F P Δv", "Δs = P Δv : a : F", "Δs F P Δt", "25", "",
         "Δs a |Fn| μg P v1", "Δs = 2 P (P : |Fn| : μg - v1) : a : |Fn| : μg", "Δs a F P v1", "85", "",
         "Δs a |Fn| μg P v2", "Δs = 2 P (v2 - P : |Fn| : μg) : a : |Fn| : μg", "Δs a F P v2", "85", "",
         "Δs a |Fn| μg P Δv", "Δs = P Δv : a : |Fn| : μg", "Δs a F P Δv", "85", "",
         "Δs a |Fn| μh P v1", "Δs = 2 P (P : |Fn| : μh - v1) : a : |Fn| : μh", "Δs a F P v1", "88", "",
         "Δs a |Fn| μh P v2", "Δs = 2 P (v2 - P : |Fn| : μh) : a : |Fn| : μh", "Δs a F P v2", "88", "",
         "Δs a |Fn| μh P Δv", "Δs = P Δv : a : |Fn| : μh", "Δs a F P Δv", "88", "",
         "Δs a |Fn| μr P v1", "Δs = 2 P (P : |Fn| : μr - v1) : a : |Fn| : μr", "Δs a F P v1", "91", "",
         "Δs a |Fn| μr P v2", "Δs = 2 P (v2 - P : |Fn| : μr) : a : |Fn| : μr", "Δs a F P v2", "91", "",
         "Δs a |Fn| μr P Δv", "Δs = P Δv : a : |Fn| : μr", "Δs a F P Δv", "91", "",
         "Δs a k m", "Δs = -a m : k", "Δs F k", "2", "",
         "Δs a k P Δv", "Δs = √(-P Δv : a : k)", "Δs k P Δt", "2", "",
         "Δs a m P Δt", "Δs = P Δt : a : m", "Δs a m W", "44", "",
         "Δs a m P v1", "Δs = 2 P (P : a : m - v1) : (a ^ 2 m)", "Δs a F P v1", "26", "",
         "Δs a m P v2", "Δs = 2 P (v2 - P : a : m) : a ^ 2 : m", "Δs a F P v2", "26", "",
         "Δs a m P Δv", "Δs = P Δv : a ^ 2 : m", "Δs a F P Δv", "26", "",
         "Δs a m W", "Δs = W : a : m", "Δs F W", "26", "",
         "Δs a P v1 W", "Δs = a W ^ 2 : P ^ 2 : 2 + v1 W : P", "Δs a Δt v1", "43", "",
         "Δs a P v2 W", "Δs = v2 W : P - a W ^ 2 : P ^ 2 : 2", "Δs a Δt v2", "43", "",
         "Δs a Δt v1", "Δs = Δt (v1 + a Δt : 2)", "Δs Δt v1 Δv", "24", "",
         "Δs a Δt v2", "Δs = Δt (v2 - a Δt : 2)", "Δs Δt v2 Δv", "24", "",
         "Δs a v1 v2", "Δs = (v2 ^ 2 - v1 ^ 2) : a : 2", "Δs a Δv {v}", "19", "",
         "Δs a v1 Δv", "Δs = Δv (v1 + Δv : 2) : a", "Δs a Δv {v}", "18", "",
         "Δs a v1 {v}", "Δs = 2 {v} ({v} - v1) : a", "Δs a Δv {v}", "16", "",
         "Δs a v2 Δv", "Δs = Δv (v2 - Δv : 2) : a", "Δs a Δv {v}", "15", "",
         "Δs a v2 {v}", "Δs = 2 {v} (v2 - {v}) : a", "Δs a Δv {v}", "13", "",
         "Δs a Δv {v}", "Δs = Δv {v} : a", "Δs Δt {v}", "25", "",
         "Δs F |Fn| Ft k μg", "Δs = (Ft + μg |Fn| - F) : k", "", "0", "",
         "Δs F |Fn| Ft k μh", "Δs = (Ft + μh |Fn| - F) : k", "", "0", "",
         "Δs F |Fn| Ft k μr", "Δs = (Ft + μr |Fn| - F) : k", "", "0", "",
         "Δs F |Fn| k μg", "Δs = (μg |Fn| - F) : k", "", "0", "",
         "Δs F |Fn| k μh", "Δs = (μh |Fn| - F) : k", "", "0", "",
         "Δs F |Fn| k μr", "Δs = (μr |Fn| - F) : k", "", "0", "",
         "Δs F Frg Ft k", "Δs = (Ft + Frg - F) : k", "", "0", "",
         "Δs F Frg k", "Δs = (Frg - F) : k", "", "0", "",
         "Δs F Frh Ft k", "Δs = (Ft + Frh - F) : k", "", "0", "",
         "Δs F Frh k", "Δs = (Frh - F) : k", "", "0", "",
         "Δs F Frr Ft k", "Δs = (Ft + Frr - F) : k", "", "0", "",
         "Δs F Frr k", "Δs = (Frr - F) : k", "", "0", "",
         "Δs F Ft k", "Δs = (Ft - F) : k", "", "0", "",
         "Δs F k", "Δs = -F : k", "", "0", "",
         "Δs F m P v1", "Δs = 2 m P (P - F v1) : F ^ 3", "Δs a F P v1", "27", "",
         "Δs F m P v2", "Δs = 2 m P (F v2 - P) : F ^ 3", "Δs a F P v2", "27", "",
         "Δs F m P Δv", "Δs = P m Δv : F ^ 2", "Δs a F P Δv", "27", "",
         "Δs F m Δt v1", "Δs = Δt (v1 + F Δt) : m : 2", "Δs a Δt v1", "27", "",
         "Δs F m Δt v2", "Δs = Δt (v2 - F Δt) : m : 2", "Δs a Δt v2", "27", "",
         "Δs F m v1 v2", "Δs = m (v2 ^ 2 - v1 ^ 2) : F : 2", "Δs F m Δv {v}", "19", "",
         "Δs F m v1 Δv", "Δs = m Δv (v1 + Δv : 2) : F", "Δs F m Δv {v}", "18", "",
         "Δs F m v1 {v}", "Δs = 2 m {v} ({v} - v1) : F", "Δs F m Δv {v}", "16", "",
         "Δs F m v2 Δv", "Δs = m Δv (v2 - Δv : 2) : F", "Δs F m Δv {v}", "15", "",
         "Δs F m v2 {v}", "Δs = 2 m {v} (v2 - {v}) : F", "Δs F m Δv {v}", "13", "",
         "Δs F m Δv {v}", "Δs = m Δv {v} : F", "Δs a Δv {v}", "27", "",
         "Δs F P Δt", "Δs = P Δt : F", "Δs F W", "44", "",
         "Δs F W", "Δs = W : F", "", "29", "",
         "Δs Ff k", "Δs = -Ff : k", "", "0", "",
         "Δs |Fn| m μg P v1", "Δs = 2 m P (P - |Fn| : μg v1) : (|Fn| μg) ^ 3", "Δs F m P v1", "85", "",
         "Δs |Fn| m μg P v2", "Δs = 2 m P (|Fn| μg v2 - P) : (|Fn| μg) ^ 3", "Δs F m P v2", "85", "",
         "Δs |Fn| m μg P Δv", "Δs = P m Δv : (|Fn| μg) ^ 2", "Δs F m P Δv", "85", "",
         "Δs |Fn| m μg Δt v1", "Δs = Δt (v1 + |Fn| μg Δt : m : 2)", "Δs F m Δt v1", "85", "",
         "Δs |Fn| m μg Δt v2", "Δs = Δt (v2 - |Fn| μg Δt : m : 2)", "Δs F m Δt v2", "85", "",
         "Δs |Fn| m μg v1 v2", "Δs = m (v2 ^ 2 - v1 ^ 2) : |Fn| : μg : 2", "Δs F m v1 v2", "85", "",
         "Δs |Fn| m μg v1 Δv", "Δs = m (v1 + Δv : 2) Δv : |Fn| : μg", "Δs F m v1 Δv", "85", "",
         "Δs |Fn| m μg v1 {v}", "Δs = 2 m {v} ({v} - v1) : |Fn| : μg", "Δs F m v1 {v}", "85", "",
         "Δs |Fn| m μg v2 Δv", "Δs = m (v2 - Δv : 2) Δv : |Fn| : μg", "Δs F m v2 Δv", "85", "",
         "Δs |Fn| m μg v2 {v}", "Δs = 2 m {v} (v2 - {v}) : |Fn| : μg", "Δs F m v2 {v}", "85", "",
         "Δs |Fn| m μg Δv {v}", "Δs = m Δv {v} : |Fn| : μg", "Δs F m Δv {v}", "85", "",
         "Δs |Fn| μg P Δt", "Δs = P Δt : |Fn| : μg", "Δs F P Δt", "85", "",
         "Δs |Fn| μg W", "Δs = W : |Fn| : μg", "Δs F W", "85", "",
         "Δs |Fn| m μh P v1", "Δs = 2 m P (P - |Fn| : μh v1) : (|Fn| μh) ^ 3", "Δs F m P v1", "88", "",
         "Δs |Fn| m μh P v2", "Δs = 2 m P (|Fn| μh v2 - P) : (|Fn| μh) ^ 3", "Δs F m P v2", "88", "",
         "Δs |Fn| m μh P Δv", "Δs = P m Δv : (|Fn| μh) ^ 2", "Δs F m P Δv", "88", "",
         "Δs |Fn| m μh Δt v1", "Δs = Δt (v1 + |Fn| μh Δt : m : 2)", "Δs F m Δt v1", "88", "",
         "Δs |Fn| m μh Δt v2", "Δs = Δt (v2 - |Fn| μh Δt : m : 2)", "Δs F m Δt v2", "88", "",
         "Δs |Fn| m μh v1 v2", "Δs = m (v2 ^ 2 - v1 ^ 2) : |Fn| : μh : 2", "Δs F m v1 v2", "88", "",
         "Δs |Fn| m μh v1 Δv", "Δs = m (v1 + Δv : 2) Δv : |Fn| : μh", "Δs F m v1 Δv", "88", "",
         "Δs |Fn| m μh v1 {v}", "Δs = 2 m {v} ({v} - v1) : |Fn| : μh", "Δs F m v1 {v}", "88", "",
         "Δs |Fn| m μh v2 Δv", "Δs = m (v2 - Δv : 2) Δv : |Fn| : μh", "Δs F m v2 Δv", "88", "",
         "Δs |Fn| m μh v2 {v}", "Δs = 2 m {v} (v2 - {v}) : |Fn| : μh", "Δs F m v2 {v}", "88", "",
         "Δs |Fn| m μh Δv {v}", "Δs = m Δv {v} : |Fn| : μh", "Δs F m Δv {v}", "88", "",
         "Δs |Fn| μh P Δt", "Δs = P Δt : |Fn| : μh", "Δs F P Δt", "88", "",
         "Δs |Fn| μh W", "Δs = W : |Fn| : μh", "Δs F W", "88", "",
         "Δs |Fn| m μr P v1", "Δs = 2 m P (P - |Fn| : μr v1) : (|Fn| μr) ^ 3", "Δs F m P v1", "91", "",
         "Δs |Fn| m μr P v2", "Δs = 2 m P (|Fn| μr v2 - P) : (|Fn| μr) ^ 3", "Δs F m P v2", "91", "",
         "Δs |Fn| m μr P Δv", "Δs = P m Δv : (|Fn| μr) ^ 2", "Δs F m P Δv", "91", "",
         "Δs |Fn| m μr Δt v1", "Δs = Δt (v1 + |Fn| μr Δt : m : 2)", "Δs F m Δt v1", "91", "",
         "Δs |Fn| m μr Δt v2", "Δs = Δt (v2 - |Fn| μr Δt : m : 2)", "Δs F m Δt v2", "91", "",
         "Δs |Fn| m μr v1 v2", "Δs = m (v2 ^ 2 - v1 ^ 2) : |Fn| : μr : 2", "Δs F m v1 v2", "91", "",
         "Δs |Fn| m μr v1 Δv", "Δs = m (v1 + Δv : 2) Δv : |Fn| : μr", "Δs F m v1 Δv", "91", "",
         "Δs |Fn| m μr v1 {v}", "Δs = 2 m {v} ({v} - v1) : |Fn| : μr", "Δs F m v1 {v}", "91", "",
         "Δs |Fn| m μr v2 Δv", "Δs = m (v2 - Δv : 2) Δv : |Fn| : μr", "Δs F m v2 Δv", "91", "",
         "Δs |Fn| m μr v2 {v}", "Δs = 2 m {v} (v2 - {v}) : |Fn| : μr", "Δs F m v2 {v}", "91", "",
         "Δs |Fn| m μr Δv {v}", "Δs = m Δv {v} : |Fn| : μr", "Δs F m Δv {v}", "91", "",
         "Δs |Fn| μr P Δt", "Δs = P Δt : |Fn| : μr", "Δs F P Δt", "91", "",
         "Δs |Fn| μr W", "Δs = W : |Fn| : μr", "Δs F W", "91", "",
         "Δs k m P v1", "Δs = √(-2 m P (P + k Δs v1) : k ^ 3 ' 4)", "Δs F m P v1", "2", "",
         "Δs k m P v2", "Δs = √(2 m P (P + k Δs v2) : k ^ 3 ' 4)", "Δs F m P v2", "2", "",
         "Δs k m P Δv", "Δs = √(-P m Δv : k ^ 2 ' 3)", "Δs F m P Δv", "2", "",
         "Δs k m Δt v1", "Δs = v1 : (1 : Δt + k Δt : m : 2)", "Δs k m v1 {v}", "2", "",
         "Δs k m Δt v2", "Δs = v2 : (1 : Δt - k Δt : m : 2)", "Δs k m v2 {v}", "2", "",
         "Δs k m Δt Δv", "Δs = -m Δv : k : Δt", "Δs a k m", "2", "",
         "Δs k m v1 v2", "Δs = √(-m (v2 ^ 2 - v1 ^ 2) : k : 2)", "Δs k m Δv {v}", "2", "",
         "Δs k m v1 Δv", "Δs = √(-m Δv (v1 + Δv : 2) : k)", "Δs k m Δv {v}", "2", "",
         "Δs k m v1 {v}", "Δs = √(-2 m {v} ({v} - v1) : k)", "Δs k m Δv {v}", "2", "",
         "Δs k m v2 Δv", "Δs = √(-m Δv (v2 - Δv : 2) : k)", "Δs k m Δv {v}", "2", "",
         "Δs k m v2 {v}", "Δs = √(-2 m {v} (v2 - {v}) : k)", "Δs k m Δv {v}", "2", "",
         "Δs k m Δv {v}", "Δs = √(-m Δv {v} : k)", "Δs k W", "2", "",
         "Δs k P Δt", "Δs = √(-P Δt : k)", "Δs k W", "2", "",
         "Δs k P v1 v2", "Δs = -2 P : k : (v1 + v2)", "Δs k P {v}", "2", "",
         "Δs k P v1 Δv", "Δs = -P : k : (v1 + Δv : 2)", "Δs k P {v}", "2", "",
         "Δs k P v2 Δv", "Δs = -P : k : (v2 - Δv : 2)", "Δs k P {v}", "2", "",
         "Δs k P {v}", "Δs = -P : k : {v}", "Δs F k", "2", "",
         "Δs k W", "Δs = √(-W : k)", "Δs F k", "2", "",
         "Δs m P Δt v1", "Δs = Δt (v1 ± √(v1 ^ 2 + 2 P Δt : m)) : 2", "Δs m Δt v1 W", "44", "",
         "Δs m P Δt v2", "Δs = Δt (v2 ± √(v2 ^ 2 - 2 P Δt : m)) : 2", "Δs m Δt v2 W", "44", "",
         "Δs m P Δt Δv", "Δs = P Δt ^ 2 : (m Δv)", "Δs m Δt Δv W", "44", "",
         "Δs m P v1 v2", "Δs = m (v2 ^ 2 - v1 ^ 2) (v1 + v2) : P : 4", "Δs m P Δv {v}", "19", "",
         "Δs m P v1 Δv", "Δs = m Δv (v1 + Δv : 2) ^ 2 : P", "Δs m P Δv {v}", "18", "",
         "Δs m P v1 {v}", "Δs = 2 m {v} ^ 2 ({v} - v1) : P", "Δs m P Δv {v}", "16", "",
         "Δs m P v1 W", "Δs = W (v1 ± √(v1 ^ 2 + 2 W : m)) : P : 2", "Δs m Δt v1 W", "43", "",
         "Δs m P v2 Δv", "Δs = m Δv (v2 - Δv : 2) ^ 2 : P", "Δs m P Δv {v}", "15", "",
         "Δs m P v2 {v}", "Δs = 2 m {v} ^ 2 (v2 - {v}) : P", "Δs m P Δv {v}", "13", "",
         "Δs m P v2 W", "Δs = W (v2 ± √(v2 ^ 2 - 2 W : m)) : P : 2", "Δs m Δt v2 W", "43", "",
         "Δs m P Δv {v}", "Δs = m Δv {v} ^ 2 : P", "Δs m P Δt Δv", "22", "",
         "Δs m P Δv W", "Δs = W ^ 2 : m : P : Δv", "Δs m Δt Δv W", "43", "",
         "Δs m p Δt", "Δs = p Δt : m", "Δs Δt v", "56", "",
         "Δs m Δt v1 W", "Δs = Δt (v1 ± √(v1 ^ 2 + 2 W : m)) : 2", "Δs F m Δt v1", "30", "",
         "Δs m Δt v2 W", "Δs = Δt (v2 ± √(v2 ^ 2 - 2 W : m)) : 2", "Δs F m Δt v2", "30", "",
         "Δs m Δt Δv W", "Δs = W Δt : m : Δv", "Δs a m W", "23", "",
         "Δs P v1 v2 W", "Δs = (v1 + v2) W : P : 2", "Δs P {v} W", "10", "",
         "Δs P v1 Δv W", "Δs = (v1 + Δv : 2) W : P", "Δs P {v} W", "18", "",
         "Δs P v2 Δv W", "Δs = (v2 - Δv : 2) W : P", "Δs P {v} W", "15", "",
         "Δs P {v} W", "Δs = {v} W : P", "Δs Δt {v}", "43", "",
         "Δs s1 s2", "Δs = s2 - s1", "", "1", "1",
         "Δs Δsx", "Δs = Δsx", "", "0", "",
         "Δs Δsy", "Δs = Δsy", "", "0", "",
         "Δs Δsz", "Δs = Δsz", "", "0", "",
         "Δs Δsx θ", "Δs = Δsx : cos(θ)", "", "0", "",
         "Δs Δsy θ", "Δs = Δsy : sin(θ)", "", "0", "",
         "Δs Δsz θ", "Δs = Δsz : cos(θ)", "", "0", "",
         "Δs Δsx θ ϕ", "Δs = Δsx : cos(θ) : sin(ϕ)", "", "0", "",
         "Δs Δsz θ ϕ", "Δs = Δsz : cos(θ) : cos(ϕ)", "", "0", "",
         "Δs Δsx Δsy", "Δs = √(Δsx ^ 2 + Δsy ^ 2)", "", "0", "",
         "Δs Δsx Δsz", "Δs = √(Δsx ^ 2 + Δsz ^ 2)", "", "0", "",
         "Δs Δsy Δsz", "Δs = √(Δsy ^ 2 + Δsz ^ 2)", "", "0", "",
         "Δs Δsx Δsy Δsz", "Δs = √(Δsx ^ 2 + Δsy ^ 2 + Δsz ^ 2)", "", "0", "",
         "Δs Δt v", "Δs = v Δt", "", "51", "",
         "Δs Δt v1 v2", "Δs = Δt (v1 + v2) : 2", "Δs Δt {v}", "10", "",
         "Δs Δt v1 Δv", "Δs = Δt (v1 + Δv : 2)", "Δs Δt {v}", "18", "",
         "Δs Δt v2 Δv", "Δs = Δt (v2 - Δv : 2)", "Δs Δt {v}", "15", "",
         "Δs Δt {v}", "Δs = Δt {v}", "", "20", ""} ' Δs => 6789
      Case "t1" : DՃA = New String() {
         "t1 t2 Δt", "t1 = t2 - Δt", "", "5", "2"} ' t1 => 1
      Case "t2" : DՃA = New String() {
         "t2 t1 Δt", "t2 = t1 + Δt", "", "6", "2"} ' t2 => 1
      Case "Δt" : DՃA = New String() {
         "Δt a F k v1", "Δt = (-v1 ± √(v1 ^ 2 - 2 a F : k)) : a", "Δt a Δs v1", "59", "",
         "Δt a F k v2", "Δt = (v2 ± √(v2 ^ 2 + 2 a F : k)) : a", "Δt a Δs v2", "59", "",
         "Δt a F P v1", "Δt = 2 (P : F - v1) : a", "Δt a F v1 W", "44", "",
         "Δt a F P v2", "Δt = 2 (v2 - P : F) : a", "Δt a F v2 W", "44", "",
         "Δt a F v1 W", "Δt = (-v1 ± √(v1 ^ 2 + 2 a W : F)) : a", "Δt a Δs v1", "31", "",
         "Δt a F v2 W", "Δt = (v2 ± √(v2 ^ 2 - 2 a W : F)) : a", "Δt a Δs v2", "31", "",
         "Δt a |Fn| μg P v1", "Δt = 2 (P : |Fn| : μg - v1) : a", "Δt a F P v1", "85", "",
         "Δt a |Fn| μg P v2", "Δt = 2 (v2 - P : |Fn| : μg) : a", "Δt a F P v2", "85", "",
         "Δt a |Fn| μg v1 W", "Δt = (-v1 ± √(v1 ^ 2 + 2 a W : |Fn| : μg)) : a", "Δt a F v1 W", "85", "",
         "Δt a |Fn| μg v2 W", "Δt = (v2 ± √(v2 ^ 2 - 2 a W : |Fn| : μg)) : a", "Δt a F v2 W", "85", "",
         "Δt a |Fn| μh P v1", "Δt = 2 (P : |Fn| : μh - v1) : a", "Δt a F P v1", "88", "",
         "Δt a |Fn| μh P v2", "Δt = 2 (v2 - P : |Fn| : μh) : a", "Δt a F P v2", "88", "",
         "Δt a |Fn| μh v1 W", "Δt = (-v1 ± √(v1 ^ 2 + 2 a W : |Fn| : μh)) : a", "Δt a F v1 W", "88", "",
         "Δt a |Fn| μh v2 W", "Δt = (v2 ± √(v2 ^ 2 - 2 a W : |Fn| : μh)) : a", "Δt a F v2 W", "88", "",
         "Δt a |Fn| μr P v1", "Δt = 2 (P : |Fn| : μr - v1) : a", "Δt a F P v1", "91", "",
         "Δt a |Fn| μr P v2", "Δt = 2 (v2 - P : |Fn| : μr) : a", "Δt a F P v2", "91", "",
         "Δt a |Fn| μr v1 W", "Δt = (-v1 ± √(v1 ^ 2 + 2 a W : |Fn| : μr)) : a", "Δt a F v1 W", "91", "",
         "Δt a |Fn| μr v2 W", "Δt = (v2 ± √(v2 ^ 2 - 2 a W : |Fn| : μr)) : a", "Δt a F v2 W", "91", "",
         "Δt a k m P", "Δt = -(a m) ^ 2 : k : P", "Δt F k P", "26", "",
         "Δt a k m v1", "Δt = (-v1 ± √(v1 ^ 2 - 2 a ^ 2 m : k)) : a", "Δt a F k v1", "26", "",
         "Δt a k m v2", "Δt = (v2 ± √(v2 ^ 2 + 2 a ^ 2 m : k)) : a", "Δt a F k v2", "26", "",
         "Δt a k m {v}", "Δt = -a m : k : {v}", "Δt F k {v}", "26", "",
         "Δt a k v1 W", "Δt = (-v1 ± √(v1 ^ 2 + 2 a √(-W : k))) : a", "Δt a Δs v1", "78", "",
         "Δt a k v2 W", "Δt = (v2 ± √(v2 ^ 2 - 2 a √(-W : k))) : a", "Δt a Δs v2", "78", "",
         "Δt a m P Δs", "Δt = a m Δs : P", "Δt F P Δs", "26", "",
         "Δt a m P v1", "Δt = 2 (P : a : m - v1) : a", "Δt a F P v1", "26", "",
         "Δt a m P v2", "Δt = 2 (v2 - P : a : m) : a", "Δt a F P v2", "26", "",
         "Δt a m v1 W", "Δt = (-v1 ± √(v1 ^ 2 + 2 W : m)) : a", "Δt a F v1 W", "26", "",
         "Δt a m v2 W", "Δt = (v2 ± √(v2 ^ 2 - 2 W : m)) : a", "Δt a F v2 W", "26", "",
         "Δt a m {v} W", "Δt = W : a : m : {v}", "Δt F {v} W", "26", "",
         "Δt a Δs v1", "Δt = (-v1 ± √(v1 ^ 2 + 2 a Δs)) : a", "Δt a v1 {v}", "20", "",
         "Δt a Δs v2", "Δt = (v2 ± √(v2 ^ 2 - 2 a Δs)) : a", "Δt a v2 {v}", "20", "",
         "Δt a v1 {v}", "Δt = 2 ({v} - v1) : a", "Δt a Δv", "16", "",
         "Δt a v2 {v}", "Δt = 2 (v2 - {v}) : a", "Δt a Δv", "13", "",
         "Δt a Δv", "Δt = Δv : a", "", "23", "",
         "Δt F k m v1", "Δt = m (-v1 ± √(v1 ^ 2 - 2 F ^ 2 : k : m)) : F", "Δt a F k v1", "27", "",
         "Δt F k m v2", "Δt = m (v2 ± √(v2 ^ 2 + 2 F ^ 2 : k : m)) : F", "Δt a F k v2", "27", "",
         "Δt F k P", "Δt = -(F ^ 2) : k : P", "Δt F k {v}", "62", "",
         "Δt F k v1 v2", "Δt = -2 F : k : (v1 + v2)", "Δt F k {v}", "10", "",
         "Δt F k v1 Δv", "Δt = -F : k : (v1 + Δv : 2)", "Δt F k {v}", "18", "",
         "Δt F k v2 Δv", "Δt = -F : k : (v2 - Δv : 2)", "Δt F k {v}", "15", "",
         "Δt F k {v}", "Δt = -F : k : {v}", "Δt Δs {v}", "59", "",
         "Δt F m P v1", "Δt = 2 m (P : F - v1) : F", "Δt a F P v1", "27", "",
         "Δt F m P v2", "Δt = 2 m (v2 - P : F) : F", "Δt F m P v2", "27", "",
         "Δt F m Δs v1", "Δt = m (-v1 ± √(v1 ^ 2 + 2 F Δs : m)) : F", "Δt a Δs v1", "27", "",
         "Δt F m Δs v2", "Δt = m (v2 ± √(v2 ^ 2 - 2 F Δs : m)) : F", "Δt a Δs v2", "27", "",
         "Δt F m v1 {v}", "Δt = 2 m ({v} - v1) : F", "Δt F m Δv", "16", "",
         "Δt F m v1 W", "Δt = m (-v1 ± √(v1 ^ 2 + 2 W : m)) : F", "Δt F m Δs v1", "31", "",
         "Δt F m v2 {v}", "Δt = 2 m (v2 - {v}) : F", "Δt F m Δv", "13", "",
         "Δt F m v2 W", "Δt = m (v2 ± √(v2 ^ 2 - 2 W : m)) : F", "Δt F m Δs v2", "31", "",
         "Δt F m Δv", "Δt = m Δv : F", "Δt a Δv", "27", "",
         "Δt F P Δs", "Δt = F Δs : P", "Δt P W", "29", "",
         "Δt F v1 v2 W", "Δt = 2 W : F : (v1 + v2)", "Δt F {v} W", "10", "",
         "Δt F v1 Δv W", "Δt = W : F : (v1 + Δv : 2)", "Δt F {v} W", "18", "",
         "Δt F v2 Δv W", "Δt = W : F : (v2 - Δv : 2)", "Δt F {v} W", "15", "",
         "Δt F {v} W", "Δt = W : F : {v}", "Δt Δs {v}", "31", "",
         "Δt |Fn| m μg P v1", "Δt = 2 m (P : |Fn| : μg - v1) : |Fn| : μg", "Δt F m P v1", "85", "",
         "Δt |Fn| m μg P v2", "Δt = 2 m (v2 - P : |Fn| : μg) : |Fn| : μg", "Δt F m P v2", "85", "",
         "Δt |Fn| m μg Δs v1", "Δt = m (-v1 ± √(v1 ^ 2 + 2 |Fn| μg Δs : m)) : |Fn| : μg", "Δt F m Δs v1", "85", "",
         "Δt |Fn| m μg Δs v2", "Δt = m (v2 ± √(v2 ^ 2 - 2 |Fn| μg Δs : m)) : |Fn| : μg", "Δt F m Δs v2", "85", "",
         "Δt |Fn| m μg v1 {v}", "Δt = 2 m ({v} - v1) : |Fn| : μg", "Δt F m v1 {v}", "85", "",
         "Δt |Fn| m μg v1 W", "Δt = m (-v1 ± √(v1 ^ 2 + 2 W : m)) : |Fn| : μg", "Δt F m v1 W", "85", "",
         "Δt |Fn| m μg v2 {v}", "Δt = 2 m (v2 - {v}) : |Fn| : μg", "Δt F m v2 {v}", "85", "",
         "Δt |Fn| m μg v2 W", "Δt = m (v2 ± √(v2 ^ 2 - 2 W : m)) : |Fn| : μg", "Δt F m v2 W", "85", "",
         "Δt |Fn| m μg Δv", "Δt = m Δv : |Fn| : μg", "Δt F m Δv", "85", "",
         "Δt |Fn| m μh P v1", "Δt = 2 m (P : |Fn| : μh - v1) : |Fn| : μh", "Δt F m P v1", "88", "",
         "Δt |Fn| m μh P v2", "Δt = 2 m (v2 - P : |Fn| : μh) : |Fn| : μh", "Δt F m P v2", "88", "",
         "Δt |Fn| m μh Δs v1", "Δt = m (-v1 ± √(v1 ^ 2 + 2 |Fn| μh Δs : m)) : |Fn| : μh", "Δt F m Δs v1", "88", "",
         "Δt |Fn| m μh Δs v2", "Δt = m (v2 ± √(v2 ^ 2 - 2 |Fn| μh Δs : m)) : |Fn| : μh", "Δt F m Δs v2", "88", "",
         "Δt |Fn| m μh v1 {v}", "Δt = 2 m ({v} - v1) : |Fn| : μh", "Δt F m v1 {v}", "88", "",
         "Δt |Fn| m μh v1 W", "Δt = m (-v1 ± √(v1 ^ 2 + 2 W : m)) : |Fn| : μh", "Δt F m v1 W", "88", "",
         "Δt |Fn| m μh v2 {v}", "Δt = 2 m (v2 - {v}) : |Fn| : μh", "Δt F m v2 {v}", "88", "",
         "Δt |Fn| m μh v2 W", "Δt = m (v2 ± √(v2 ^ 2 - 2 W : m)) : |Fn| : μh", "Δt F m v2 W", "88", "",
         "Δt |Fn| m μh Δv", "Δt = m Δv : |Fn| : μh", "Δt F m Δv", "88", "",
         "Δt |Fn| m μr P v1", "Δt = 2 m (P : |Fn| : μr - v1) : |Fn| : μr", "Δt F m P v1", "91", "",
         "Δt |Fn| m μr P v2", "Δt = 2 m (v2 - P : |Fn| : μr) : |Fn| : μr", "Δt F m P v2", "91", "",
         "Δt |Fn| m μr Δs v1", "Δt = m (-v1 ± √(v1 ^ 2 + 2 |Fn| μr Δs : m)) : |Fn| : μr", "Δt F m Δs v1", "91", "",
         "Δt |Fn| m μr Δs v2", "Δt = m (v2 ± √(v2 ^ 2 - 2 |Fn| μr Δs : m)) : |Fn| : μr", "Δt F m Δs v2", "91", "",
         "Δt |Fn| m μr v1 {v}", "Δt = 2 m ({v} - v1) : |Fn| : μr", "Δt F m v1 {v}", "91", "",
         "Δt |Fn| m μr v1 W", "Δt = m (-v1 ± √(v1 ^ 2 + 2 W : m)) : |Fn| : μr", "Δt F m v1 W", "91", "",
         "Δt |Fn| m μr v2 {v}", "Δt = 2 m (v2 - {v}) : |Fn| : μr", "Δt F m v2 {v}", "91", "",
         "Δt |Fn| m μr v2 W", "Δt = m (v2 ± √(v2 ^ 2 - 2 W : m)) : |Fn| : μr", "Δt F m v2 W", "91", "",
         "Δt |Fn| m μr Δv", "Δt = m Δv : |Fn| : μr", "Δt F m Δv", "91", "",
         "Δt |Fn| μg P Δs", "Δt = |Fn| μg Δs : P", "Δt F P Δs", "85", "",
         "Δt |Fn| μg v1 v2 W", "Δt = 2 W : |Fn| : μg : (v1 + v2)", "Δt F v1 v2 W", "85", "",
         "Δt |Fn| μg v1 Δv W", "Δt = W : |Fn| : μg : (v1 + Δv : 2)", "Δt F v1 Δv W", "85", "",
         "Δt |Fn| μg v2 Δv W", "Δt = W : |Fn| : μg : (v2 - Δv : 2)", "Δt F v2 Δv W", "85", "",
         "Δt |Fn| μg {v} W", "Δt = W : |Fn| : μg : {v}", "Δt F {v} W", "85", "",
         "Δt |Fn| μh P Δs", "Δt = |Fn| μh Δs : P", "Δt F P Δs", "88", "",
         "Δt |Fn| μh v1 v2 W", "Δt = 2 W : |Fn| : μh : (v1 + v2)", "Δt F v1 v2 W", "88", "",
         "Δt |Fn| μh v1 Δv W", "Δt = W : |Fn| : μh : (v1 + Δv : 2)", "Δt F v1 Δv W", "88", "",
         "Δt |Fn| μh v2 Δv W", "Δt = W : |Fn| : μh : (v2 - Δv : 2)", "Δt F v2 Δv W", "88", "",
         "Δt |Fn| μh {v} W", "Δt = W : |Fn| : μh : {v}", "Δt F {v} W", "88", "",
         "Δt |Fn| μr P Δs", "Δt = |Fn| μr Δs : P", "Δt F P Δs", "91", "",
         "Δt |Fn| μr v1 v2 W", "Δt = 2 W : |Fn| : μr : (v1 + v2)", "Δt F v1 v2 W", "91", "",
         "Δt |Fn| μr v1 Δv W", "Δt = W : |Fn| : μr : (v1 + Δv : 2)", "Δt F v1 Δv W", "91", "",
         "Δt |Fn| μr v2 Δv W", "Δt = W : |Fn| : μr : (v2 - Δv : 2)", "Δt F v2 Δv W", "91", "",
         "Δt |Fn| μr {v} W", "Δt = W : |Fn| : μr : {v}", "Δt F {v} W", "91", "",
         "Δt k m P Δv", "Δt = √(-(m Δv) ^ 2 : k : P ' 3)", "Δt k m Δv W", "44", "",
         "Δt k m Δs v1", "Δt = m (v1 ± √(v1 ^ 2 - 2 k Δs ^ 2 : m)) : k : Δs", "Δt F k m v1", "57", "",
         "Δt k m Δs v2", "Δt = -m (v2 ± √(v2 ^ 2 + 2 k Δs ^ 2 : m)) : k : Δs", "Δt F k m v2", "57", "",
         "Δt k m Δs Δv", "Δt = -m Δv : k : Δs", "Δt F m Δv", "57", "",
         "Δt k m v1 v2", "Δt = √(-2 m (v2 - v1) : k : (v1 + v2))", "Δt k m Δv {v}", "19", "",
         "Δt k m v1 Δv", "Δt = √(-m Δv : k : (v1 + Δv : 2))", "Δt k m Δv {v}", "18", "",
         "Δt k m v1 {v}", "Δt = √(-2 m ({v} - v1) : k : {v})", "Δt k m Δv {v}", "16", "",
         "Δt k m v1 W", "Δt = m (-v1 ± √(v1 ^ 2 + 2 W : m)) : √(-k W)", "Δt F k m v1", "75", "",
         "Δt k m v2 Δv", "Δt = √(-m Δv : k : (v2 - Δv : 2))", "Δt k m Δv {v}", "15", "",
         "Δt k m v2 {v}", "Δt = √(-2 m (v2 - {v}) : k : {v})", "Δt k m Δv {v}", "13", "",
         "Δt k m v2 W", "Δt = m (v2 ± √(v2 ^ 2 - 2 W : m)) : √(-k W)", "Δt F k m v2", "75", "",
         "Δt k m Δv W", "Δt = m Δv : √(-k W)", "Δt F m Δv", "75", "",
         "Δt k m Δv {v}", "Δt = √(-m Δv : k : {v})", "Δt k m Δs Δv", "21", "",
         "Δt k P Δs", "Δt = -k Δs ^ 2 : P", "Δt F k P", "57", "",
         "Δt k P v1 v2", "Δt = -4 P : k : (v1 + v2) ^ 2", "Δt k P {v}", "10", "",
         "Δt k P v1 Δv", "Δt = -P : k : (v1 + Δv : 2) ^ 2", "Δt k P {v}", "18", "",
         "Δt k P v2 Δv", "Δt = -P : k : (v2 - Δv : 2) ^ 2", "Δt k P {v}", "15", "",
         "Δt k P {v}", "Δt = -P : k : {v} ^ 2", "Δt F k {v}", "61", "",
         "Δt k v1 v2 W", "Δt = 2 √(-W : k) : (v1 + v2)", "Δt k {v} W", "10", "",
         "Δt k v1 Δv W", "Δt = √(-W : k) : (v1 + Δv : 2)", "Δt k {v} W", "18", "",
         "Δt k v2 Δv W", "Δt = √(-W : k) : (v2 - Δv : 2)", "Δt k {v} W", "15", "",
         "Δt k {v} W", "Δt = √(-W : k) : {v}", "Δt F k {v}", "75", "",
         "Δt m P Δs Δv", "Δt = √(m Δs Δv : P)", "Δt m Δs Δv W", "44", "",
         "Δt m P v1 v2", "Δt = m (v2 ^ 2 - v1 ^ 2) : P : 2", "Δt m P Δv {v}", "19", "",
         "Δt m P v1 Δv", "Δt = m Δv (v1 + Δv : 2) : P", "Δt m P Δv {v}", "18", "",
         "Δt m P v1 {v}", "Δt = 2 m {v} ({v} - v1) : P", "Δt m P Δv {v}", "16", "",
         "Δt m P v2 Δv", "Δt = m Δv (v2 - Δv : 2) : P", "Δt m P Δv {v}", "15", "",
         "Δt m P v2 {v}", "Δt = 2 m {v} (v2 - {v}) : P", "Δt m P Δv {v}", "13", "",
         "Δt m P Δv {v}", "Δt = m Δv {v} : P", "Δt m P Δs Δv", "61", "",
         "Δt m p Δs", "Δt = m Δs : p", "Δt Δs v", "56", "",
         "Δt m Δs v1 W", "Δt = m Δs (-v1 ± √(v1 ^ 2 + 2 W : m)) : W", "Δt F m Δs v1", "30", "",
         "Δt m Δs v2 W", "Δt = m Δs (v2 ± √(v2 ^ 2 - 2 W : m)) : W", "Δt F m Δs v2", "30", "",
         "Δt m Δs Δv W", "Δt = m Δs Δv : W", "Δt F m Δv", "30", "",
         "Δt P W", "Δt = W : P", "", "43", "",
         "Δt Δs v", "Δt = Δs : v", "", "53", "",
         "Δt Δs v1 v2", "Δt = 2 Δs : (v1 + v2)", "Δt Δs {v}", "10", "",
         "Δt Δs v1 Δv", "Δt = Δs : (v1 + Δv : 2)", "Δt Δs {v}", "18", "",
         "Δt Δs v2 Δv", "Δt = Δs : (v2 - Δv : 2)", "Δt Δs {v}", "15", "",
         "Δt Δs {v}", "Δt = Δs : {v}", "", "22", "",
         "Δt t1 t2", "Δt = t2 - t1", "", "4", "2"} ' Δt => 10047
      Case "vx" : DՃA = New String() {
         "vx v", "vx = v", "", "0", "",
         "vx v θ", "vx = v cos(θ)", "", "0", "",
         "vx vy θ", "vx = vy : tan(θ)", "", "0", "",
         "vx vz ϕ", "vx = vz tan(ϕ)", "", "0", "",
         "vx v vy", "vx = √(v ^ 2 - vy ^ 2)", "", "0", "",
         "vx v vz", "vx = √(v ^ 2 - vz ^ 2)", "", "0", "",
         "vx v θ ϕ", "vx = v cos(θ) sin(ϕ)", "", "0", "",
         "vx vy θ ϕ", "vx = vy sin(ϕ) : tan(θ)", "", "0", "",
         "vx v vy vz", "vx = √(v ^ 2 - vy ^ 2 - vz ^ 2)", "", "0", ""} ' vx => 9
      Case "vy" : DՃA = New String() {
         "vy v", "vy = v", "", "0", "",
         "vy v θ", "vy = v sin(θ)", "", "0", "",
         "vy vx θ", "vy = vx tan(θ)", "", "0", "",
         "vy vz θ", "vy = vz tan(θ)", "", "0", "",
         "vy v vx", "vy = √(v ^ 2 - vx ^ 2)", "", "0", "",
         "vy v vz", "vy = √(v ^ 2 - vz ^ 2)", "", "0", "",
         "vy vx θ ϕ", "vy = vx tan(θ) : sin(ϕ)", "", "0", "",
         "vy vz θ ϕ", "vy = vz tan(θ) : cos(ϕ)", "", "0", "",
         "vy v vx vz", "vy = √(v ^ 2 - vx ^ 2 - vz ^ 2)", "", "0", ""} ' vy => 9
      Case "vz" : DՃA = New String() {
         "vz v", "vz = v", "", "0", "",
         "vz v θ", "vz = v cos(θ)", "", "0", "",
         "vz vx ϕ", "vz = vx : tan(ϕ)", "", "0", "",
         "vz vy θ", "vz = vy : tan(θ)", "", "0", "",
         "vz v vx", "vz = √(v ^ 2 - vx ^ 2)", "", "0", "",
         "vz v vy", "vz = √(v ^ 2 - vy ^ 2)", "", "0", "",
         "vz vy θ ϕ", "vz = vy cos(ϕ) : tan(θ)", "", "0", "",
         "vz v θ ϕ", "vz = v cos(θ) cos(ϕ)", "", "0", "",
         "vz v vx vy", "vz = √(v ^ 2 - vx ^ 2 - vy ^ 2)", "", "0", ""} ' vz => 9
      Case "v1" : DՃA = New String() {
         "v1 a F k P", "v1 = P : F + a F ^ 2 : k : P : 2", "v1 a F k {v}", "62", "",
         "v1 a F k Δt", "v1 = -F : k : Δt - a Δt : 2", "v1 F k Δt Δv", "24", "",
         "v1 a F k v2", "v1 = √(v2 ^ 2 + 2 a F : k)", "v1 a Δs v2", "59", "",
         "v1 a F k Δv", "v1 = -a F : k : Δv - Δv : 2", "v1 F k Δt Δv", "25", "",
         "v1 a F k {v}", "v1 = {v} + a F : k : {v} : 2", "v1 a Δs {v}", "59", "",
         "v1 a F P Δs", "v1 = P : F - a F Δs : P : 2", "v1 a F P W", "29", "",
         "v1 a F P Δt", "v1 = P : F - a Δt : 2", "v1 F P Δv", "24", "",
         "v1 a F P W", "v1 = P (2 a W : F - (a W : P) ^ 2) : a : W : 2", "v1 a F P Δt", "43", "",
         "v1 a F Δt W", "v1 = W : F : Δt - a Δt : 2", "v1 a Δs Δt", "31", "",
         "v1 a F v2 W", "v1 = √(v2 ^ 2 - 2 a W : F)", "v1 a Δs v2", "31", "",
         "v1 a F Δv W", "v1 = a W : F : Δv - Δv : 2", "v1 a Δs Δv", "31", "",
         "v1 a F {v} W", "v1 = {v} - a W : F : {v} : 2", "v1 a Δs {v}", "31", "",
         "v1 a |Fn| μg P Δs", "v1 = P : |Fn| : μg - a |Fn| μg Δs : P : 2", "v1 a F P Δs", "85", "",
         "v1 a |Fn| μg P Δt", "v1 = P : |Fn| : μg - a Δt : 2", "v1 a F P Δt", "85", "",
         "v1 a |Fn| μg P W", "v1 = P : |Fn| : μg - a W : P : 2", "v1 a F P W", "85", "",
         "v1 a |Fn| μg Δt W", "v1 = W : |Fn| : μg : Δt - a Δt : 2", "v1 a F Δt W", "85", "",
         "v1 a |Fn| μg v2 W", "v1 = √(v2 ^ 2 - 2 a W : |Fn| : μg)", "v1 a F v2 W", "85", "",
         "v1 a |Fn| μg Δv W", "v1 = a W : |Fn| : μg : Δv - Δv : 2", "v1 a F Δv W", "85", "",
         "v1 a |Fn| μg {v} W", "v1 = {v} - a W : |Fn| : μg : {v} : 2", "v1 a F {v} W", "85", "",
         "v1 a |Fn| μh P Δs", "v1 = P : |Fn| : μh - a |Fn| μh Δs : P : 2", "v1 a F P Δs", "88", "",
         "v1 a |Fn| μh P Δt", "v1 = P : |Fn| : μh - a Δt : 2", "v1 a F P Δt", "88", "",
         "v1 a |Fn| μh P W", "v1 = P : |Fn| : μh - a W : P : 2", "v1 a F P W", "88", "",
         "v1 a |Fn| μh Δt W", "v1 = W : |Fn| : μh : Δt - a Δt : 2", "v1 a F Δt W", "88", "",
         "v1 a |Fn| μh v2 W", "v1 = √(v2 ^ 2 - 2 a W : |Fn| : μh)", "v1 a F v2 W", "88", "",
         "v1 a |Fn| μh Δv W", "v1 = a W : |Fn| : μh : Δv - Δv : 2", "v1 a F Δv W", "88", "",
         "v1 a |Fn| μh {v} W", "v1 = {v} - a W : |Fn| : μh : {v} : 2", "v1 a F {v} W", "88", "",
         "v1 a |Fn| μr P Δs", "v1 = P : |Fn| : μr - a |Fn| μr Δs : P : 2", "v1 a F P Δs", "91", "",
         "v1 a |Fn| μr P Δt", "v1 = P : |Fn| : μr - a Δt : 2", "v1 a F P Δt", "91", "",
         "v1 a |Fn| μr P W", "v1 = P : |Fn| : μr - a W : P : 2", "v1 a F P W", "91", "",
         "v1 a |Fn| μr Δt W", "v1 = W : |Fn| : μr : Δt - a Δt : 2", "v1 a F Δt W", "91", "",
         "v1 a |Fn| μr v2 W", "v1 = √(v2 ^ 2 - 2 a W : |Fn| : μr)", "v1 a F v2 W", "91", "",
         "v1 a |Fn| μr Δv W", "v1 = a W : |Fn| : μr : Δv - Δv : 2", "v1 a F Δv W", "91", "",
         "v1 a |Fn| μr {v} W", "v1 = {v} - a W : |Fn| : μr : {v} : 2", "v1 a F {v} W", "91", "",
         "v1 a k m P", "v1 = P : a : m + a ^ 3 m ^ 2 : k : P : 2", "v1 a F k P", "26", "",
         "v1 a k m Δt", "v1 = -a m : k : Δt - a Δt : 2", "v1 a F k Δt", "26", "",
         "v1 a k m v2", "v1 = √(v2 ^ 2 + 2 a ^ 2 m : k)", "v1 a F k v2", "26", "",
         "v1 a k m Δv", "v1 = -(a ^ 2) m : k : Δv - Δv : 2", "v1 a F k Δv", "26", "",
         "v1 a k m {v}", "v1 = {v} + a ^ 2 m : k : {v} : 2", "v1 a F k {v}", "26", "",
         "v1 a k P Δs", "v1 = -P : k : Δs + a k Δs ^ 2 : P : 2", "v1 a F k P", "57", "",
         "v1 a k P Δt", "v1 = √(-P : k : Δt) - a Δt : 2", "v1 k P Δt Δv", "24", "",
         "v1 a k P Δv", "v1 = √(-a P : k : Δv) - Δv : 2", "v1 k P Δt Δv", "25", "",
         "v1 a k P {v}", "v1 = {v} + a P : k : {v} ^ 2 : 2", "v1 a F k {v}", "61", "",
         "v1 a k P W", "v1 = P : √(-k W) - a W : P : 2", "v1 a k P Δt", "43", "",
         "v1 a k Δt W", "v1 = √(-W : k) : Δt - a Δt : 2", "v1 a k P Δt", "42", "",
         "v1 a k v2 W", "v1 = √(v2 ^ 2 - 2 a √(-W : k))", "v1 a F k v2", "75", "",
         "v1 a k Δv W", "v1 = a √(-W : k) : Δv - Δv : 2", "v1 k Δt Δv W", "25", "",
         "v1 a k {v} W", "v1 = {v} - a √(-W : k) : {v} : 2", "v1 a F k {v}", "75", "",
         "v1 a m P Δs", "v1 = P : a : m - a ^ 2 m Δs : P : 2", "v1 a F P Δs", "26", "",
         "v1 a m P Δt", "v1 = P : a : m - a Δt : 2", "v1 a m P Δv", "24", "",
         "v1 a m P v2", "v1 = 2 P : a : m - v2", "v1 F P v2", "26", "",
         "v1 a m P Δv", "v1 = P : a : m - Δv : 2", "v1 F P Δv", "26", "",
         "v1 a m P W", "v1 = P : a : m - a W : P : 2", "v1 F P W", "26", "",
         "v1 a m Δt W", "v1 = W : a : m : Δt - a Δt : 2", "v1 a F Δt W", "26", "",
         "v1 a P Δs W", "v1 = P Δs : W - a W : P : 2", "v1 a F P W", "30", "",
         "v1 a P {v} W", "v1 = {v} - a W : P : 2", "v1 a Δt {v}", "43", "",
         "v1 a Δs Δt", "v1 = Δs : Δt - a Δt : 2", "v1 a Δt {v}", "20", "",
         "v1 a Δs v2", "v1 = √(v2 ^ 2 - 2 a Δs)", "v1 a Δs Δv", "7", "",
         "v1 a Δs Δv", "v1 = a Δs : Δv - Δv : 2", "v1 Δs Δt Δv", "25", "",
         "v1 a Δs {v}", "v1 = {v} - a Δs : {v} : 2", "v1 a Δt {v}", "22", "",
         "v1 a Δt {v}", "v1 = {v} - a Δt : 2", "v1 Δv {v}", "24", "",
         "v1 F k m P", "v1 = P : F + F ^ 3 : k : m : P : 2", "v1 a F k P", "27", "",
         "v1 F k m Δt", "v1 = -F : k : Δt - F Δt : m : 2", "v1 a F k Δt", "27", "",
         "v1 F k m v2", "v1 = √(v2 ^ 2 + 2 F ^ 2 : k : m)", "v1 a F k v2", "27", "",
         "v1 F k m Δv", "v1 = -(F ^ 2) : k : m : Δv - Δv : 2", "v1 a F k Δv", "27", "",
         "v1 F k m {v}", "v1 = {v} + F ^ 2 : k : m : {v} : 2", "v1 a F k {v}", "27", "",
         "v1 F k Δt v2", "v1 = -2 F : k : Δt - v2", "v1 Δs Δt v2", "59", "",
         "v1 F k Δt Δv", "v1 = -F : k : Δt - Δv : 2", "v1 Δs Δt Δv", "59", "",
         "v1 F m P Δs", "v1 = P : F - F ^ 2 Δs : m : P : 2", "v1 F m P W", "29", "",
         "v1 F m P Δt", "v1 = P : F - F Δt : m : 2", "v1 a F P Δt", "27", "",
         "v1 F m P W", "v1 = P : F - F W : m : P : 2", "v1 a F P W", "27", "",
         "v1 F m Δs Δt", "v1 = Δs : Δt - F Δt : m : 2", "v1 a Δs Δt", "27", "",
         "v1 F m Δs v2", "v1 = √(v2 ^ 2 - 2 F Δs : m)", "v1 a Δs v2", "27", "",
         "v1 F m Δs Δv", "v1 = F Δs : m : Δv - Δv : 2", "v1 a Δs Δv", "27", "",
         "v1 F m Δs {v}", "v1 = {v} - F Δs : m : {v} : 2", "v1 a Δs {v}", "27", "",
         "v1 F m Δt {v}", "v1 = {v} - F Δt : m : 2", "v1 a Δt {v}", "27", "",
         "v1 F m Δt W", "v1 = W : F : Δt - F Δt : m : 2", "v1 a F Δt W", "27", "",
         "v1 F P v2", "v1 = 2 P : F - v2", "v1 F Δt v2 W", "43", "",
         "v1 F P Δv", "v1 = P : F - Δv : 2", "v1 Δv {v}", "62", "",
         "v1 F Δt v2 W", "v1 = 2 W : F : Δt - v2", "v1 Δs Δt v2", "31", "",
         "v1 F Δt Δv W", "v1 = W : F : Δt - Δv : 2", "v1 Δs Δt Δv", "31", "",
         "v1 |Fn| m μg P Δs", "v1 = P : |Fn| : μg - (|Fn| μg) ^ 2 Δs : m : P : 2", "v1 F m P Δs", "85", "",
         "v1 |Fn| m μg P Δt", "v1 = P : |Fn| : μg - |Fn| μg Δt : m : 2", "v1 F m P Δt", "85", "",
         "v1 |Fn| m μg P W", "v1 = P : |Fn| : μg - |Fn| μg W : m : P : 2", "v1 F m P W", "85", "",
         "v1 |Fn| m μg Δs Δt", "v1 = Δs : Δt - |Fn| μg Δt : m : 2", "v1 F m Δs Δt", "85", "",
         "v1 |Fn| m μg Δs v2", "v1 = √(v2 ^ 2 - 2 |Fn| μg Δs : m)", "v1 F m Δs v2", "85", "",
         "v1 |Fn| m μg Δs Δv", "v1 = |Fn| μg Δs : m : Δv - Δv : 2", "v1 F m Δs Δv", "85", "",
         "v1 |Fn| m μg Δs {v}", "v1 = {v} - |Fn| μg Δs : m : {v} : 2", "v1 F m Δs {v}", "85", "",
         "v1 |Fn| m μg Δt {v}", "v1 = {v} - |Fn| μg Δt : m : 2", "v1 F m Δt {v}", "85", "",
         "v1 |Fn| m μg Δt W", "v1 = W : |Fn| : μg : Δt - |Fn| μg Δt : m : 2", "v1 F m Δt W", "85", "",
         "v1 |Fn| m μh P Δs", "v1 = P : |Fn| : μh - (|Fn| μh) ^ 2 Δs : m : P : 2", "v1 F m P Δs", "88", "",
         "v1 |Fn| m μh P Δt", "v1 = P : |Fn| : μh - |Fn| μh Δt : m : 2", "v1 F m P Δt", "88", "",
         "v1 |Fn| m μh P W", "v1 = P : |Fn| : μh - |Fn| μh W : m : P : 2", "v1 F m P W", "88", "",
         "v1 |Fn| m μh Δs Δt", "v1 = Δs : Δt - |Fn| μh Δt : m : 2", "v1 F m Δs Δt", "88", "",
         "v1 |Fn| m μh Δs v2", "v1 = √(v2 ^ 2 - 2 |Fn| μh Δs : m)", "v1 F m Δs v2", "88", "",
         "v1 |Fn| m μh Δs Δv", "v1 = |Fn| μh Δs : m : Δv - Δv : 2", "v1 F m Δs Δv", "88", "",
         "v1 |Fn| m μh Δs {v}", "v1 = {v} - |Fn| μh Δs : m : {v} : 2", "v1 F m Δs {v}", "88", "",
         "v1 |Fn| m μh Δt {v}", "v1 = {v} - |Fn| μh Δt : m : 2", "v1 F m Δt {v}", "88", "",
         "v1 |Fn| m μh Δt W", "v1 = W : |Fn| : μh : Δt - |Fn| μh Δt : m : 2", "v1 F m Δt W", "88", "",
         "v1 |Fn| m μr P Δs", "v1 = P : |Fn| : μr - (|Fn| μr) ^ 2 Δs : m : P : 2", "v1 F m P Δs", "91", "",
         "v1 |Fn| m μr P Δt", "v1 = P : |Fn| : μr - |Fn| μr Δt : m : 2", "v1 F m P Δt", "91", "",
         "v1 |Fn| m μr P W", "v1 = P : |Fn| : μr - |Fn| μr W : m : P : 2", "v1 F m P W", "91", "",
         "v1 |Fn| m μr Δs Δt", "v1 = Δs : Δt - |Fn| μr Δt : m : 2", "v1 F m Δs Δt", "91", "",
         "v1 |Fn| m μr Δs v2", "v1 = √(v2 ^ 2 - 2 |Fn| μr Δs : m)", "v1 F m Δs v2", "91", "",
         "v1 |Fn| m μr Δs Δv", "v1 = |Fn| μr Δs : m : Δv - Δv : 2", "v1 F m Δs Δv", "91", "",
         "v1 |Fn| m μr Δs {v}", "v1 = {v} - |Fn| μr Δs : m : {v} : 2", "v1 F m Δs {v}", "91", "",
         "v1 |Fn| m μr Δt {v}", "v1 = {v} - |Fn| μr Δt : m : 2", "v1 F m Δt {v}", "91", "",
         "v1 |Fn| m μr Δt W", "v1 = W : |Fn| : μr : Δt - |Fn| μr Δt : m : 2", "v1 F m Δt W", "91", "",
         "v1 |Fn| μg P v2", "v1 = 2 P : |Fn| : μg - v2", "v1 F P v2", "85", "",
         "v1 |Fn| μg P Δv", "v1 = P : |Fn| : μg - Δv : 2", "v1 F P Δv", "85", "",
         "v1 |Fn| μg Δt v2 W", "v1 = 2 W : |Fn| : μg : Δt - v2", "v1 F Δt v2 W", "85", "",
         "v1 |Fn| μg Δt Δv W", "v1 = W : |Fn| : μg : Δt - Δv : 2", "v1 F Δt Δv W", "85", "",
         "v1 |Fn| μh P v2", "v1 = 2 P : |Fn| : μh - v2", "v1 F P v2", "88", "",
         "v1 |Fn| μh P Δv", "v1 = P : |Fn| : μh - Δv : 2", "v1 F P Δv", "88", "",
         "v1 |Fn| μh Δt v2 W", "v1 = 2 W : |Fn| : μh : Δt - v2", "v1 F Δt v2 W", "88", "",
         "v1 |Fn| μh Δt Δv W", "v1 = W : |Fn| : μh : Δt - Δv : 2", "v1 F Δt Δv W", "88", "",
         "v1 |Fn| μr P v2", "v1 = 2 P : |Fn| : μr - v2", "v1 F P v2", "91", "",
         "v1 |Fn| μr P Δv", "v1 = P : |Fn| : μr - Δv : 2", "v1 F P Δv", "91", "",
         "v1 |Fn| μr Δt v2 W", "v1 = 2 W : |Fn| : μr : Δt - v2", "v1 F Δt v2 W", "91", "",
         "v1 |Fn| μr Δt Δv W", "v1 = W : |Fn| : μr : Δt - Δv : 2", "v1 F Δt Δv W", "91", "",
         "v1 k m P Δs", "v1 = (-k ^ 3 Δs ^ 4 : m : P : 2 - P) : k : Δs", "v1 F k m P", "57", "",
         "v1 k m P Δt", "v1 = √(-k P Δt) (-Δt : m : 2 - 1 : k : Δt)", "v1 k m Δt W", "44", "",
         "v1 k m P Δv", "v1 = √(-(P ^ 2) : k : m : Δv ' 3) - Δv : 2", "v1 k P Δv W", "67", "",
         "v1 k m P {v}", "v1 = {v} + P ^ 2 : k : m : {v} ^ 3 : 2", "v1 F k m {v}", "61", "",
         "v1 k m P W", "v1 = √(-k W) (-W : m : P : 2 - P : k : W)", "v1 k m Δt W", "43", "",
         "v1 k m Δs Δt", "v1 = Δs : Δt + k Δs Δt : m : 2", "v1 k m Δs {v}", "20", "",
         "v1 k m Δs v2", "v1 = √(v2 ^ 2 + 2 k Δs ^ 2 : m)", "v1 F k m v2", "57", "",
         "v1 k m Δs Δv", "v1 = -k Δs ^ 2 : m : Δv - Δv : 2", "v1 F k m Δv", "57", "",
         "v1 k m Δs {v}", "v1 = {v} + k Δs ^ 2 : m : {v} : 2", "v1 F k m {v}", "57", "",
         "v1 k m Δt v2", "v1 = v2 (2 m : k : Δt ^ 2 + 1) : (2 m : k : Δt ^ 2 - 1)", "v1 k Δt v2 W", "81", "",
         "v1 k m Δt Δv", "v1 = -m Δv : k : Δt ^ 2 - Δv : 2", "v1 a k m Δt", "23", "",
         "v1 k m Δt {v}", "v1 = {v} + k Δt ^ 2 {v} : m : 2", "v1 k m Δs {v}", "21", "",
         "v1 k m Δt W", "v1 = √(-k W) (-Δt : m : 2 - 1 : k : Δt)", "v1 k Δt Δv W", "70", "",
         "v1 k P Δs v2", "v1 = -2 P : k : Δs - v2", "v1 F P v2", "57", "",
         "v1 k P Δs Δv", "v1 = -P : k : Δs - Δv : 2", "v1 F P Δv", "57", "",
         "v1 k P Δt v2", "v1 = 2 √(-P : k : Δt) - v2", "v1 k P v2 W", "44", "",
         "v1 k P Δt Δv", "v1 = √(-P : k : Δt) - Δv : 2", "v1 k P Δv W", "44", "",
         "v1 k P v2 W", "v1 = 2 P : √(-k W) - v2", "v1 k P Δs v2", "78", "",
         "v1 k P Δv W", "v1 = P : √(-k W) - Δv : 2", "v1 k P Δs Δv", "78", "",
         "v1 k Δt v2 W", "v1 = 2 √(-W : k) : Δt - v2", "v1 F k Δt v2", "75", "",
         "v1 k Δt Δv W", "v1 = √(-W : k) : Δt - Δv : 2", "v1 k P Δv W", "42", "",
         "v1 m P Δs Δt", "v1 = Δs : Δt - P Δt ^ 2 : m : Δs : 2", "v1 m Δs Δt W", "44", "",
         "v1 m P Δs Δv", "v1 = -Δv : 2 ± √(P Δs : m : Δv)", "v1 m P Δs {v}", "18", "",
         "v1 m P Δs {v}", "v1 = {v} - P Δs : m : {v} ^ 2 : 2", "v1 m P Δt {v}", "22", "",
         "v1 m P Δs W", "v1 = P Δs : W - W ^ 2 : m : P : Δs : 2", "v1 F m P W", "30", "",
         "v1 m P Δt v2", "v1 = √(v2 ^ 2 - 2 P Δt : m)", "v1 m v2 W", "44", "",
         "v1 m P Δt Δv", "v1 = P Δt : m : Δv - Δv : 2", "v1 m P Δt {v}", "18", "",
         "v1 m P Δt {v}", "v1 = {v} - P Δt : m : {v} : 2", "v1 F m Δt {v}", "61", "",
         "v1 m Δs Δt W", "v1 = Δs : Δt - Δt W : m : Δs : 2", "v1 F m Δs Δt", "30", "",
         "v1 m v2 W", "v1 = √(v2 ^ 2 - 2 W : m)", "v1 F m Δs v2", "30", "",
         "v1 m Δv W", "v1 = W : m : Δv - Δv : 2", "v1 F m Δs Δv", "30", "",
         "v1 m {v} W", "v1 = {v} - W : m : {v} : 2", "v1 F m Δs {v}", "30", "",
         "v1 P Δs v2 W", "v1 = 2 P Δs : W - v2", "v1 Δs Δt v2", "43", "",
         "v1 P Δs Δv W", "v1 = P Δs : W - Δv : 2", "v1 F P Δv", "30", "",
         "v1 Δs Δt v2", "v1 = 2 Δs : Δt - v2", "v1 v2 {v}", "20", "",
         "v1 Δs Δt Δv", "v1 = Δs : Δt - Δv : 2", "v1 Δv {v}", "20", "",
         "v1 v2 Δv", "v1 = v2 - Δv", "", "8", "3",
         "v1 v2 {v}", "v1 = 2 {v} - v2", "", "11", "3",
         "v1 Δv {v}", "v1 = {v} - Δv : 2", "v1 v2 Δv", "12", "3"} ' v1 => 8047
      Case "v2" : DՃA = New String() {
         "v2 a F k P", "v2 = P : F - a F ^ 2 : k : P : 2", "v2 a F k {v}", "62", "",
         "v2 a F k Δt", "v2 = a Δt : 2 - F : k : Δt", "v2 F k Δt Δv", "24", "",
         "v2 a F k v1", "v2 = √(v1 ^ 2 - 2 a F : k)", "v2 a Δs v1", "59", "",
         "v2 a F k Δv", "v2 = Δv : 2 - a F : k : Δv", "v2 F k Δt Δv", "25", "",
         "v2 a F k {v}", "v2 = {v} - a F : k : {v} : 2", "v2 a Δs {v}", "59", "",
         "v2 a F P Δs", "v2 = P : F + a F Δs : P : 2", "v2 a F P W", "29", "",
         "v2 a F P Δt", "v2 = P : F + a Δt : 2", "v2 F P Δv", "24", "",
         "v2 a F P W", "v2 = P : F + a W : P : 2", "v2 a F P Δt", "43", "",
         "v2 a F Δt W", "v2 = W : F : Δt + a Δt : 2", "v2 a Δs Δt", "31", "",
         "v2 a F v1 W", "v2 = √(v1 ^ 2 + 2 a W : F)", "v2 a Δs v1", "31", "",
         "v2 a F Δv W", "v2 = a W : F : Δv + Δv : 2", "v2 a Δs Δv", "31", "",
         "v2 a F {v} W", "v2 = {v} + a W : F : {v} : 2", "v2 a Δs {v}", "31", "",
         "v2 a |Fn| μg P Δs", "v2 = P : |Fn| : μg + a |Fn| μg Δs : P : 2", "v2 a F P Δs", "85", "",
         "v2 a |Fn| μg P Δt", "v2 = P : |Fn| : μg + a Δt : 2", "v2 a F P Δt", "85", "",
         "v2 a |Fn| μg P W", "v2 = P : |Fn| : μg + a W : P : 2", "v2 a F P W", "85", "",
         "v2 a |Fn| μg Δt W", "v2 = W : |Fn| : μg : Δt + a Δt : 2", "v2 a F Δt W", "85", "",
         "v2 a |Fn| μg v1 W", "v2 = √(v1 ^ 2 + 2 a W : |Fn| : μg)", "v2 a F v1 W", "85", "",
         "v2 a |Fn| μg Δv W", "v2 = a W : |Fn| : μg : Δv + Δv : 2", "v2 a F Δv W", "85", "",
         "v2 a |Fn| μg {v} W", "v2 = {v} + a W : |Fn| : μg : {v} : 2", "v2 a F {v} W", "85", "",
         "v2 a |Fn| μh P Δs", "v2 = P : |Fn| : μh + a |Fn| μh Δs : P : 2", "v2 a F P Δs", "88", "",
         "v2 a |Fn| μh P Δt", "v2 = P : |Fn| : μh + a Δt : 2", "v2 a F P Δt", "88", "",
         "v2 a |Fn| μh P W", "v2 = P : |Fn| : μh + a W : P : 2", "v2 a F P W", "88", "",
         "v2 a |Fn| μh Δt W", "v2 = W : |Fn| : μh : Δt + a Δt : 2", "v2 a F Δt W", "88", "",
         "v2 a |Fn| μh v1 W", "v2 = √(v1 ^ 2 + 2 a W : |Fn| : μh)", "v2 a F v1 W", "88", "",
         "v2 a |Fn| μh Δv W", "v2 = a W : |Fn| : μh : Δv + Δv : 2", "v2 a F Δv W", "88", "",
         "v2 a |Fn| μh {v} W", "v2 = {v} + a W : |Fn| : μh : {v} : 2", "v2 a F {v} W", "88", "",
         "v2 a |Fn| μr P Δs", "v2 = P : |Fn| : μr + a |Fn| μr Δs : P : 2", "v2 a F P Δs", "91", "",
         "v2 a |Fn| μr P Δt", "v2 = P : |Fn| : μr + a Δt : 2", "v2 a F P Δt", "91", "",
         "v2 a |Fn| μr P W", "v2 = P : |Fn| : μr + a W : P : 2", "v2 a F P W", "91", "",
         "v2 a |Fn| μr Δt W", "v2 = W : |Fn| : μr : Δt + a Δt : 2", "v2 a F Δt W", "91", "",
         "v2 a |Fn| μr v1 W", "v2 = √(v1 ^ 2 + 2 a W : |Fn| : μr)", "v2 a F v1 W", "91", "",
         "v2 a |Fn| μr Δv W", "v2 = a W : |Fn| : μr : Δv + Δv : 2", "v2 a F Δv W", "91", "",
         "v2 a |Fn| μr {v} W", "v2 = {v} + a W : |Fn| : μr : {v} : 2", "v2 a F {v} W", "91", "",
         "v2 a k m P", "v2 = P : a : m - a ^ 3 m ^ 2 : k : P : 2", "v2 a F k P", "26", "",
         "v2 a k m Δt", "v2 = a Δt : 2 - a m : k : Δt", "v2 a F k Δt", "26", "",
         "v2 a k m v1", "v2 = √(v1 ^ 2 - 2 a ^ 2 m : k)", "v2 a F k v1", "26", "",
         "v2 a k m Δv", "v2 = Δv : 2 - a ^ 2 m : k : Δv", "v2 a F k Δv", "26", "",
         "v2 a k m {v}", "v2 = {v} - a ^ 2 m : k : {v} : 2", "v2 a F k {v}", "26", "",
         "v2 a k P Δs", "v2 = -P : k : Δs - a k Δs ^ 2 : P : 2", "v2 a F k P", "57", "",
         "v2 a k P Δt", "v2 = a Δt : 2 + √(-P : k : Δt)", "v2 k P Δt Δv", "24", "",
         "v2 a k P Δv", "v2 = Δv : 2 + √(-a P : k : Δv)", "v2 k P Δt Δv", "25", "",
         "v2 a k P {v}", "v2 = {v} - a P : k : {v} ^ 2 : 2", "v2 a F k {v}", "61", "",
         "v2 a k P W", "v2 = P : √(-k W) + a W : P : 2", "v2 a k P Δt", "43", "",
         "v2 a k Δt W", "v2 = a Δt : 2 + √(-W : k) : Δt", "v2 a k P Δt", "42", "",
         "v2 a k v1 W", "v2 = √(v1 ^ 2 + 2 a √(-W : k))", "v2 a F k v1", "75", "",
         "v2 a k Δv W", "v2 = Δv : 2 + a √(-W : k) : Δv", "v2 k Δt Δv W", "25", "",
         "v2 a k {v} W", "v2 = {v} + a √(-W : k) : {v} : 2", "v2 a F k {v}", "75", "",
         "v2 a m P Δs", "v2 = P : a : m + a ^ 2 m Δs : P : 2", "v2 a F P Δs", "26", "",
         "v2 a m P Δt", "v2 = P : a : m + a Δt : 2", "v2 a m P Δv", "24", "",
         "v2 a m P v1", "v2 = 2 P : a : m - v1", "v2 F P v1", "26", "",
         "v2 a m P Δv", "v2 = P : a : m + Δv : 2", "v2 F P Δv", "26", "",
         "v2 a m P W", "v2 = P : a : m + a W : P : 2", "v2 a F P W", "26", "",
         "v2 a m Δt W", "v1 = W : a : m : Δt + a Δt : 2", "v2 a F Δt W", "26", "",
         "v2 a P Δs W", "v2 = P Δs : W + a W : P : 2", "v2 a F P W", "30", "",
         "v2 a P {v} W", "v2 = {v} + a W : P : 2", "v2 a Δt {v}", "43", "",
         "v2 a Δs Δt", "v2 = Δs : Δt + a Δt : 2", "v2 a Δt {v}", "20", "",
         "v2 a Δs v1", "v2 = √(v1 ^ 2 + 2 a Δs)", "v2 a Δs Δv", "7", "",
         "v2 a Δs Δv", "v2 = a Δs : Δv + Δv : 2", "v2 Δs Δt Δv", "25", "",
         "v2 a Δs {v}", "v2 = {v} + a Δs : {v} : 2", "v2 a Δt {v}", "22", "",
         "v2 a Δt {v}", "v2 = {v} + a Δt : 2", "v2 Δv {v}", "24", "",
         "v2 F k m P", "v2 = P : F - F ^ 3 : k : m : P : 2", "v2 a F k P", "27", "",
         "v2 F k m Δt", "v2 = F Δt : m : 2 - F : k : Δt", "v2 a F k Δt", "27", "",
         "v2 F k m v1", "v2 = √(v1 ^ 2 - 2 F ^ 2 : k : m)", "v2 a F k v1", "27", "",
         "v2 F k m Δv", "v2 = Δv : 2 - F ^ 2 : k : m : Δv", "v2 a F k Δv", "27", "",
         "v2 F k m {v}", "v2 = {v} - F ^ 2 : k : m : {v} : 2", "v2 a F k {v}", "27", "",
         "v2 F k Δt v1", "v2 = -2 F : k : Δt - v1", "v2 Δs Δt v1", "59", "",
         "v2 F k Δt Δv", "v2 = Δv : 2 - F : k : Δt", "v2 Δs Δt Δv", "59", "",
         "v2 F m P Δs", "v2 = P : F + F ^ 2 Δs : m : P : 2", "v2 F m P W", "29", "",
         "v2 F m P Δt", "v2 = P : F + F Δt : m : 2", "v2 a F P Δt", "27", "",
         "v2 F m P W", "v2 = P : F + F W : m : P : 2", "v2 a F P W", "27", "",
         "v2 F m Δs Δt", "v2 = Δs : Δt + F Δt : m : 2", "v2 a Δs Δt", "27", "",
         "v2 F m Δs v1", "v2 = √(v1 ^ 2 + 2 F Δs : m)", "v2 a Δs v1", "27", "",
         "v2 F m Δs Δv", "v2 = F Δs : m : Δv + Δv : 2", "v2 a Δs Δv", "27", "",
         "v2 F m Δs {v}", "v2 = {v} + F Δs : m : {v} : 2", "v2 a Δs {v}", "27", "",
         "v2 F m Δt {v}", "v2 = {v} + F Δt : m : 2", "v2 a Δt {v}", "27", "",
         "v2 F m Δt W", "v2 = W : F : Δt + F Δt : m : 2", "v2 a F Δt W", "27", "",
         "v2 F P v1", "v2 = 2 P : F - v1", "v2 F Δt v1 W", "43", "",
         "v2 F P Δv", "v2 = P : F + Δv : 2", "v2 Δv {v}", "62", "",
         "v2 F Δt v1 W", "v2 = 2 W : F : Δt - v1", "v2 Δs Δt v1", "31", "",
         "v2 F Δt Δv W", "v2 = W : F : Δt + Δv : 2", "v2 Δs Δt Δv", "31", "",
         "v2 |Fn| m μg P Δs", "v2 = P : |Fn| : μg + (|Fn| μg) ^ 2 Δs : m : P : 2", "v2 F m P Δs", "85", "",
         "v2 |Fn| m μg P Δt", "v2 = P : |Fn| : μg + |Fn| μg Δt : m : 2", "v2 F m P Δt", "85", "",
         "v2 |Fn| m μg P W", "v2 = P : |Fn| : μg + |Fn| μg W : m : P : 2", "v2 F m P W", "85", "",
         "v2 |Fn| m μg Δs Δt", "v2 = Δs : Δt + |Fn| μg Δt : m : 2", "v2 F m Δs Δt", "85", "",
         "v2 |Fn| m μg Δs v1", "v2 = √(v1 ^ 2 + 2 |Fn| μg Δs : m)", "v2 F m Δs v1", "85", "",
         "v2 |Fn| m μg Δs Δv", "v2 = |Fn| μg Δs : m : Δv + Δv : 2", "v2 F m Δs Δv", "85", "",
         "v2 |Fn| m μg Δs {v}", "v2 = {v} + |Fn| μg Δs : m : {v} : 2", "v2 F m Δs {v}", "85", "",
         "v2 |Fn| m μg Δt {v}", "v2 = {v} + |Fn| μg Δt : m : 2", "v2 F m Δt {v}", "85", "",
         "v2 |Fn| m μg Δt W", "v2 = W : |Fn| : μg : Δt + |Fn| μg Δt : m : 2", "v2 F m Δt W", "85", "",
         "v2 |Fn| m μh P Δs", "v2 = P : |Fn| : μh + (|Fn| μh) ^ 2 Δs : m : P : 2", "v2 F m P Δs", "88", "",
         "v2 |Fn| m μh P Δt", "v2 = P : |Fn| : μh + |Fn| μh Δt : m : 2", "v2 F m P Δt", "88", "",
         "v2 |Fn| m μh P W", "v2 = P : |Fn| : μh + |Fn| μh W : m : P : 2", "v2 F m P W", "88", "",
         "v2 |Fn| m μh Δs Δt", "v2 = Δs : Δt + |Fn| μh Δt : m : 2", "v2 F m Δs Δt", "88", "",
         "v2 |Fn| m μh Δs v1", "v2 = √(v1 ^ 2 + 2 |Fn| μh Δs : m)", "v2 F m Δs v1", "88", "",
         "v2 |Fn| m μh Δs Δv", "v2 = |Fn| μh Δs : m : Δv + Δv : 2", "v2 F m Δs Δv", "88", "",
         "v2 |Fn| m μh Δs {v}", "v2 = {v} + |Fn| μh Δs : m : {v} : 2", "v2 F m Δs {v}", "88", "",
         "v2 |Fn| m μh Δt {v}", "v2 = {v} + |Fn| μh Δt : m : 2", "v2 F m Δt {v}", "88", "",
         "v2 |Fn| m μh Δt W", "v2 = W : |Fn| : μh : Δt + |Fn| μh Δt : m : 2", "v2 F m Δt W", "88", "",
         "v2 |Fn| m μr P Δs", "v2 = P : |Fn| : μr + (|Fn| μr) ^ 2 Δs : m : P : 2", "v2 F m P Δs", "91", "",
         "v2 |Fn| m μr P Δt", "v2 = P : |Fn| : μr + |Fn| μr Δt : m : 2", "v2 F m P Δt", "91", "",
         "v2 |Fn| m μr P W", "v2 = P : |Fn| : μr + |Fn| μr W : m : P : 2", "v2 F m P W", "91", "",
         "v2 |Fn| m μr Δs Δt", "v2 = Δs : Δt + |Fn| μr Δt : m : 2", "v2 F m Δs Δt", "91", "",
         "v2 |Fn| m μr Δs v1", "v2 = √(v1 ^ 2 + 2 |Fn| μr Δs : m)", "v2 F m Δs v1", "91", "",
         "v2 |Fn| m μr Δs Δv", "v2 = |Fn| μr Δs : m : Δv + Δv : 2", "v2 F m Δs Δv", "91", "",
         "v2 |Fn| m μr Δs {v}", "v2 = {v} + |Fn| μr Δs : m : {v} : 2", "v2 F m Δs {v}", "91", "",
         "v2 |Fn| m μr Δt {v}", "v2 = {v} + |Fn| μr Δt : m : 2", "v2 F m Δt {v}", "91", "",
         "v2 |Fn| m μr Δt W", "v2 = W : |Fn| : μr : Δt + |Fn| μr Δt : m : 2", "v2 F m Δt W", "91", "",
         "v2 |Fn| μg P v1", "v2 = 2 P : |Fn| : μg - v1", "v2 F P v1", "85", "",
         "v2 |Fn| μg P Δv", "v2 = P : |Fn| : μg + Δv : 2", "v2 F P Δv", "85", "",
         "v2 |Fn| μg Δt v1 W", "v2 = 2 W : |Fn| : μg : Δt - v1", "v2 F Δt v1 W", "85", "",
         "v2 |Fn| μg Δt Δv W", "v2 = W : |Fn| : μg : Δt + Δv : 2", "v2 F Δt Δv W", "85", "",
         "v2 |Fn| μh P v1", "v2 = 2 P : |Fn| : μh - v1", "v2 F P v1", "88", "",
         "v2 |Fn| μh P Δv", "v2 = P : |Fn| : μh + Δv : 2", "v2 F P Δv", "88", "",
         "v2 |Fn| μh Δt v1 W", "v2 = 2 W : |Fn| : μh : Δt - v1", "v2 F Δt v1 W", "88", "",
         "v2 |Fn| μh Δt Δv W", "v2 = W : |Fn| : μh : Δt + Δv : 2", "v2 F Δt Δv W", "88", "",
         "v2 |Fn| μr P v1", "v2 = 2 P : |Fn| : μr - v1", "v2 F P v1", "91", "",
         "v2 |Fn| μr P Δv", "v2 = P : |Fn| : μr + Δv : 2", "v2 F P Δv", "91", "",
         "v2 |Fn| μr Δt v1 W", "v2 = 2 W : |Fn| : μr : Δt - v1", "v2 F Δt v1 W", "91", "",
         "v2 |Fn| μr Δt Δv W", "v2 = W : |Fn| : μr : Δt + Δv : 2", "v2 F Δt Δv W", "91", "",
         "v2 k m P Δs", "v2 = k ^ 2 Δs ^ 3 : m : P : 2 - P : k : Δs", "v2 F k m P", "57", "",
         "v2 k m P Δt", "v2 = √(-k P Δt) (Δt : m - 2 : k : Δt) : 2", "v2 k m Δt W", "44", "",
         "v2 k m P Δv", "v2 = Δv : 2 + √(-(P ^ 2) : k : m : Δv ' 3)", "v2 k P Δv W", "71", "",
         "v2 k m P {v}", "v2 = {v} - P ^ 2 : k : m : {v} ^ 3 : 2", "v2 F k m {v}", "61", "",
         "v2 k m P W", "v2 = √(-k W) (W : m : P : 2 - P : k : W)", "v2 k m Δt W", "43", "",
         "v2 k m Δs Δt", "v2 = Δs : Δt - k Δs Δt : m : 2", "v2 k m Δs {v}", "20", "",
         "v2 k m Δs v1", "v2 = √(v1 ^ 2 - 2 k Δs ^ 2 : m)", "v2 F k m v1", "57", "",
         "v2 k m Δs Δv", "v2 = Δv : 2 - k Δs ^ 2 : m : Δv", "v2 F k m Δv", "57", "",
         "v2 k m Δs {v}", "v2 = {v} - k Δs ^ 2 : m : {v} : 2", "v2 F k m {v}", "57", "",
         "v2 k m Δt v1", "v2 = v1 (2 m : k : Δt ^ 2 - 1) : (2 m : k : Δt ^ 2 + 1)", "v2 k Δt v1 W", "81", "",
         "v2 k m Δt Δv", "v2 = Δv : 2 - m Δv : k : Δt ^ 2", "v2 a k m Δt", "23", "",
         "v2 k m Δt {v}", "v2 = {v} - k Δt ^ 2 {v} : m : 2", "v2 k m Δs {v}", "21", "",
         "v2 k m Δt W", "v2  = √(-k W) (Δt : m : 2 - 1 : k : Δt)", "v2 k Δt Δv W", "74", "",
         "v2 k P Δs v1", "v2 = -2 P : k : Δs - v1", "v2 F P v1", "57", "",
         "v2 k P Δs Δv", "v2 = Δv : 2 - P : k : Δs", "v2 F P Δv", "57", "",
         "v2 k P Δt v1", "v2 = √(-4 P : k : Δt) - v1", "v2 k P v1 W", "44", "",
         "v2 k P Δt Δv", "v2 = Δv : 2 + √(-P : k : Δt)", "v2 k P Δv W", "44", "",
         "v2 k P v1 W", "v2 = 2 P √(-1 : k : W) - v1", "v2 k P Δs v1", "78", "",
         "v2 k P Δv W", "v2 = Δv : 2 + P √(-1 : k : W)", "v2 k P Δs Δv", "78", "",
         "v2 k Δt v1 W", "v2 = 2 √(-W : k) : Δt - v1", "v2 F k Δt v1", "75", "",
         "v2 k Δt Δv W", "v2 = Δv : 2 + √(-W : k) : Δt", "v2 k P Δv W", "42", "",
         "v2 m P Δs Δt", "v2 = Δs : Δt + P Δt ^ 2 : m : Δs : 2", "v2 m Δs Δt W", "44", "",
         "v2 m P Δs Δv", "v2 = Δv : 2 ± √(P Δs : m : Δv)", "v2 m P Δs {v}", "15", "",
         "v2 m P Δs {v}", "v2 = {v} + P Δs : m : {v} ^ 2 : 2", "v2 m P Δt {v}", "22", "",
         "v2 m P Δs W", "v2 = P Δs : W + W ^ 2 : m : P : Δs : 2", "v2 F m P W", "30", "",
         "v2 m P Δt v1", "v2 = √(v1 ^ 2 + 2 P Δt : m)", "v2 m v1 W", "44", "",
         "v2 m P Δt Δv", "v2 = P Δt : m : Δv + Δv : 2", "v2 m P Δt {v}", "15", "",
         "v2 m P Δt {v}", "v2 = {v} + P Δt : m : {v} : 2", "v2 F m Δt {v}", "61", "",
         "v2 m Δs Δt W", "v2 = Δs : Δt + Δt W : m : Δs : 2", "v2 F m Δs Δt", "30", "",
         "v2 m v1 W", "v2 = √(v1 ^ 2 + 2 W : m)", "v2 F m Δs v1", "30", "",
         "v2 m Δv W", "v2 = W : m : Δv + Δv : 2", "v2 F m Δs Δv", "30", "",
         "v2 m {v} W", "v2 = {v} + W : m : {v} : 2", "v2 F m Δs {v}", "30", "",
         "v2 P Δs v1 W", "v2 = 2 P Δs : W - v1", "v2 Δs Δt v1", "43", "",
         "v2 P Δs Δv W", "v2 = P Δs : W + Δv : 2", "v2 F P Δv", "30", "",
         "v2 Δs Δt v1", "v2 = 2 Δs : Δt - v1", "v2 v1 {v}", "20", "",
         "v2 Δs Δt Δv", "v2 = Δs : Δt + Δv : 2", "v2 Δv {v}", "20", "",
         "v2 v1 Δv", "v2 = v1 + Δv", "", "9", "3",
         "v2 v1 {v}", "v2 = 2 {v} - v1", "", "12", "3",
         "v2 Δv {v}", "v2 = {v} + Δv : 2", "v2 v1 Δv", "11", "3"} ' v2 => 8047
      Case "Δv" : DՃA = New String() {
         "Δv a F k P", "Δv = -a F ^ 2 : k : P", "Δv a F k {v}", "62", "",
         "Δv a F k v1", "Δv = -v1 ± √(v1 ^ 2 - 2 a F : k)", "Δv a Δs v1", "59", "",
         "Δv a F k v2", "Δv = v2 ± √(v2 ^ 2 + 2 a F : k)", "Δv a Δs v2", "59", "",
         "Δv a F k {v}", "Δv = -a F : k : {v}", "Δv a Δs {v}", "59", "",
         "Δv a F P Δs", "Δv = a F Δs : P", "Δv a P W", "29", "",
         "Δv a F v1 W", "Δv = -v1 ± √(v1 ^ 2 + 2 a W : F)", "Δv a Δs v1", "31", "",
         "Δv a F v2 W", "Δv = v2 ± √(v2 ^ 2 - 2 a W : F)", "Δv a Δs v2", "31", "",
         "Δv a F {v} W", "Δv = a W : F : {v}", "Δv a Δs {v}", "31", "",
         "Δv a |Fn| μg P Δs", "Δv = a |Fn| μg Δs : P", "Δv a F P Δs", "85", "",
         "Δv a |Fn| μg v1 W", "Δv = -v1 ± √(v1 ^ 2 + 2 a W : |Fn| : μg)", "Δv a F v1 W", "85", "",
         "Δv a |Fn| μg v2 W", "Δv = v2 ± √(v2 ^ 2 - 2 a W : |Fn| : μg)", "Δv a F v2 W", "85", "",
         "Δv a |Fn| μg {v} W", "Δv = a W : |Fn| : μg : {v}", "Δv a F {v} W", "85", "",
         "Δv a |Fn| μh P Δs", "Δv = a |Fn| μh Δs : P", "Δv a F P Δs", "88", "",
         "Δv a |Fn| μh v1 W", "Δv = -v1 ± √(v1 ^ 2 + 2 a W : |Fn| : μh)", "Δv a F v1 W", "88", "",
         "Δv a |Fn| μh v2 W", "Δv = v2 ± √(v2 ^ 2 - 2 a W : |Fn| : μh)", "Δv a F v2 W", "88", "",
         "Δv a |Fn| μh {v} W", "Δv = a W : |Fn| : μh : {v}", "Δv a F {v} W", "88", "",
         "Δv a |Fn| μr P Δs", "Δv = a |Fn| μr Δs : P", "Δv a F P Δs", "91", "",
         "Δv a |Fn| μr v1 W", "Δv = -v1 ± √(v1 ^ 2 + 2 a W : |Fn| : μr)", "Δv a F v1 W", "91", "",
         "Δv a |Fn| μr v2 W", "Δv = v2 ± √(v2 ^ 2 - 2 a W : |Fn| : μr)", "Δv a F v2 W", "91", "",
         "Δv a |Fn| μr {v} W", "Δv = a W : |Fn| : μr : {v}", "Δv a F {v} W", "91", "",
         "Δv a k m P", "Δv = -a ^ 3 m ^ 2 : k : P", "Δv a F k P", "26", "",
         "Δv a k m v1", "Δv = -v1 ± √(v1 ^ 2 - 2 a ^ 2 m : k)", "Δv a F k v1", "26", "",
         "Δv a k m v2", "Δv = v2 ± √(v2 ^ 2 + 2 a ^ 2 m : k)", "Δv a F k v2", "26", "",
         "Δv a k m {v}", "Δv = -(a ^ 2) m : k : {v}", "Δv a F k {v}", "26", "",
         "Δv a k P Δs", "Δv = -a k Δs ^ 2 : P", "Δv a F k P", "57", "",
         "Δv a k P {v}", "Δv = -a P : k : {v} ^ 2", "Δv a F k {v}", "61", "",
         "Δv a k v1 W", "Δv = -v1 ± √(v1 ^ 2 + 2 a √(-W : k))", "Δv a F k v1", "75", "",
         "Δv a k v2 W", "Δv = v2 ± √(v2 ^ 2 - 2 a √(-W : k))", "Δv a F k v2", "75", "",
         "Δv a k {v} W", "Δv = a √(-W : k) : {v}", "Δv a F k {v}", "75", "",
         "Δv a m P Δs", "Δv = a ^ 2 m Δs : P", "Δv a F P Δs", "26", "",
         "Δv a m P v1", "Δv = 2 (P : a : m - v1)", "Δv F P v1", "26", "",
         "Δv a m P v2", "Δv = 2 (v2 - P : a : m)", "Δv F P v2", "26", "",
         "Δv a P W", "Δv = a W : P", "Δv a Δt", "43", "",
         "Δv a Δs v1", "Δv = -v1 ± √(v1 ^ 2 + 2 a Δs)", "Δv Δs Δt v1", "25", "",
         "Δv a Δs v2", "Δv = v2 ± √(v2 ^ 2 - 2 a Δs)", "Δv Δs Δt v2", "25", "",
         "Δv a Δs {v}", "Δv = a Δs : {v}", "Δv a Δt", "22", "",
         "Δv a Δt", "Δv = a Δt", "", "24", "",
         "Δv F k m P", "Δv = -F ^ 3 : k : P : m", "Δv F k m {v}", "62", "",
         "Δv F k m v1", "Δv = -v1 ± √(v1 ^ 2 - 2 F ^ 2 : k : m)", "Δv a F k v1", "27", "",
         "Δv F k m v2", "Δv = v2 ± √(v2 ^ 2 + 2 F ^ 2 : k : m)", "Δv a F k v2", "27", "",
         "Δv F k m {v}", "Δv = -(F ^ 2) : k : m : {v}", "Δv a F k {v}", "27", "",
         "Δv F k Δt v1", "Δv = -2 (F : k : Δt + v1)", "Δv Δs Δt v1", "59", "",
         "Δv F k Δt v2", "Δv = 2 (v2 + F : k : Δt)", "Δv Δs Δt v2", "59", "",
         "Δv F m P Δs", "Δv = F ^ 2 Δs : m : P", "Δv a m P Δs", "27", "",
         "Δv F m P W", "Δv = F W : m : P", "Δv F m P Δs", "31", "",
         "Δv F m Δs v1", "Δv = -v1 ± √(v1 ^ 2 + 2 F Δs : m)", "Δv a Δs v1", "27", "",
         "Δv F m Δs v2", "Δv = v2 ± √(v2 ^ 2 - 2 F Δs : m)", "Δv a Δs v2", "27", "",
         "Δv F m Δs {v}", "Δv = F Δs : m : {v}", "Δv a Δs {v}", "27", "",
         "Δv F m Δt", "Δv = F Δt : m", "Δv a Δt", "27", "",
         "Δv F P v1", "Δv = 2 (P : F - v1)", "Δv v1 {v}", "62", "",
         "Δv F P v2", "Δv = 2 (v2 - P : F)", "Δv v2 {v}", "62", "",
         "Δv F Δt v1 W", "Δv = 2 (W : F : Δt - v1)", "Δv Δs Δt v1", "31", "",
         "Δv F Δt v2 W", "Δv = 2 (v2 - W : F : Δt)", "Δv Δs Δt v2", "31", "",
         "Δv |Fn| m μg P Δs", "Δv = (|Fn| μg) ^ 2 Δs : m : P", "Δv F m P Δs", "85", "",
         "Δv |Fn| m μg P W", "Δv = |Fn| μg W : m : P", "Δv F m P W", "85", "",
         "Δv |Fn| m μg Δs v1", "Δv = -v1 ± √(v1 ^ 2 + 2 |Fn| μg Δs : m)", "Δv F m Δs v1", "85", "",
         "Δv |Fn| m μg Δs v2", "Δv = v2 ± √(v2 ^ 2 - 2 |Fn| μg Δs : m)", "Δv F m Δs v2", "85", "",
         "Δv |Fn| m μg Δs {v}", "Δv = |Fn| μg Δs  :  m : {v}", "Δv F m Δs {v}", "85", "",
         "Δv |Fn| m μg Δt", "Δv = |Fn| μg Δt : m", "Δv F m Δt", "85", "",
         "Δv |Fn| m μh P Δs", "Δv = (|Fn| μh) ^ 2 Δs : m : P", "Δv F m P Δs", "88", "",
         "Δv |Fn| m μh P W", "Δv = |Fn| μh W : m : P", "Δv F m P W", "88", "",
         "Δv |Fn| m μh Δs v1", "Δv = -v1 ± √(v1 ^ 2 + 2 |Fn| μh Δs : m)", "Δv F m Δs v1", "88", "",
         "Δv |Fn| m μh Δs v2", "Δv = v2 ± √(v2 ^ 2 - 2 |Fn| μh Δs : m)", "Δv F m Δs v2", "88", "",
         "Δv |Fn| m μh Δs {v}", "Δv = |Fn| μh Δs  :  m : {v}", "Δv F m Δs {v}", "88", "",
         "Δv |Fn| m μh Δt", "Δv = |Fn| μh Δt : m", "Δv F m Δt", "88", "",
         "Δv |Fn| m μr P Δs", "Δv = (|Fn| μr) ^ 2 Δs : m : P", "Δv F m P Δs", "91", "",
         "Δv |Fn| m μr P W", "Δv = |Fn| μr W : m : P", "Δv F m P W", "91", "",
         "Δv |Fn| m μr Δs v1", "Δv = -v1 ± √(v1 ^ 2 + 2 |Fn| μr Δs : m)", "Δv F m Δs v1", "91", "",
         "Δv |Fn| m μr Δs v2", "Δv = v2 ± √(v2 ^ 2 - 2 |Fn| μr Δs : m)", "Δv F m Δs v2", "91", "",
         "Δv |Fn| m μr Δs {v}", "Δv = |Fn| μr Δs  :  m : {v}", "Δv F m Δs {v}", "91", "",
         "Δv |Fn| m μr Δt", "Δv = |Fn| μr Δt : m", "Δv F m Δt", "91", "",
         "Δv |Fn| μg P v1", "Δv = 2 (P : |Fn| : μg - v1)", "Δv F P v1", "85", "",
         "Δv |Fn| μg P v2", "Δv = 2 (v2 - P : |Fn| : μg)", "Δv F P v2", "85", "",
         "Δv |Fn| μg Δt v1 W", "Δv = 2 (W : |Fn| : μg : Δt - v1)", "Δv F Δt v1 W", "85", "",
         "Δv |Fn| μg Δt v2 W", "Δv = 2 (v2 - W : |Fn| : μg : Δt)", "Δv F Δt v2 W", "85", "",
         "Δv |Fn| μh P v1", "Δv = 2 (P : |Fn| : μh - v1)", "Δv F P v1", "88", "",
         "Δv |Fn| μh P v2", "Δv = 2 (v2 - P : |Fn| : μh)", "Δv F P v2", "88", "",
         "Δv |Fn| μh Δt v1 W", "Δv = 2 (W : |Fn| : μh : Δt - v1)", "Δv F Δt v1 W", "88", "",
         "Δv |Fn| μh Δt v2 W", "Δv = 2 (v2 - W : |Fn| : μh : Δt)", "Δv F Δt v2 W", "88", "",
         "Δv |Fn| μr P v1", "Δv = 2 (P : |Fn| : μr - v1)", "Δv F P v1", "91", "",
         "Δv |Fn| μr P v2", "Δv = 2 (v2 - P : |Fn| : μr)", "Δv F P v2", "91", "",
         "Δv |Fn| μr Δt v1 W", "Δv = 2 (W : |Fn| : μr : Δt - v1)", "Δv F Δt v1 W", "91", "",
         "Δv |Fn| μr Δt v2 W", "Δv = 2 (v2 - W : |Fn| : μr : Δt)", "Δv F Δt v2 W", "91", "",
         "Δv k m P Δs", "Δv = -k ^ 2 Δs ^ 3 : m : P", "Δv F k m P", "57", "",
         "Δv k m P Δt", "Δv = √(-k P Δt ^ 3) : m", "Δv k m Δt W", "44", "",
         "Δv k m P {v}", "Δv = -(P ^ 2) : k : m : {v} ^ 3", "Δv F k m {v}", "61", "",
         "Δv k m P W", "Δv = √(-k W ^ 3) : m : P", "Δv k m Δt W", "43", "",
         "Δv k m Δs Δt", "Δv = -k Δs Δt : m", "Δv F m  Δt", "57", "",
         "Δv k m Δs v1", "Δv = -v1 ± √(v1 ^ 2 - 2 k Δs ^ 2 : m)", "Δv F k m v1", "57", "",
         "Δv k m Δs v2", "Δv = v2 ± √(v2 ^ 2 + 2 k Δs ^ 2 : m)", "Δv F k m v2", "57", "",
         "Δv k m Δs {v}", "Δv = -k Δs ^ 2 : m : {v}", "Δv F k m {v}", "57", "",
         "Δv k m Δt v1", "Δv = -v1 : (1 : 2 + m : k : Δt ^ 2)", "Δv k Δt v1 W", "67", "",
         "Δv k m Δt v2", "Δv = v2 : (1 : 2 - m : k : Δt ^ 2)", "Δv k Δt v2 W", "67", "",
         "Δv k m Δt {v}", "Δv = -k Δt ^ 2 {v} : m", "Δv k m Δs {v}", "21", "",
         "Δv k m Δt W", "Δv = Δt √(-k W) : m", "Δv k m Δs Δt", "78", "",
         "Δv k P Δs v1", "Δv = -2 (P : k : Δs + v1)", "Δv F P v1", "57", "",
         "Δv k P Δs v2", "Δv = 2 (v2 + P : k : Δs)", "Δv F P v2", "57", "",
         "Δv k P Δt v1", "Δv = 2 (√(-P : k : Δt) - v1)", "Δv k Δt v1 W", "44", "",
         "Δv k P Δt v2", "Δv = 2 (v2 - √(-P : k : Δt))", "Δv k Δt v2 W", "44", "",
         "Δv k P v1 W", "Δv = 2 (P √(-1 : k : W) - v1)", "Δv k Δt v1 W", "43", "",
         "Δv k P v2 W", "Δv = 2 (v2 - P √(-1 : k : W))", "Δv k Δt v2 W", "43", "",
         "Δv k Δt v1 W", "Δv = 2 (√(-W : k) : Δt - v1)", "Δv Δs Δt v1", "78", "",
         "Δv k Δt v2 W", "Δv = 2 (v2 - √(-W : k) : Δt)", "Δv Δs Δt v2", "78", "",
         "Δv m P Δs Δt", "Δv = P Δt ^ 2 : m : Δs", "Δv m Δs Δt W", "44", "",
         "Δv m P Δs {v}", "Δv = P Δs : m : {v} ^ 2", "Δv m P Δt {v}", "22", "",
         "Δv m P Δs W", "Δv = W ^ 2 : m : P : Δs", "Δv m Δs Δt W", "43", "",
         "Δv m P Δt v1", "Δv = -v1 ± √(v1 ^ 2 + 2 P Δt : m)", "Δv m v1 W", "44", "",
         "Δv m P Δt v2", "Δv = v2 ± √(v2 ^ 2 - 2 P Δt : m)", "Δv m v2 W", "44", "",
         "Δv m P Δt {v}", "Δv = P Δt : m : {v}", "Δv m {v} W", "44", "",
         "Δv m Δs Δt W", "Δv = W Δt : m : Δs", "Δv F m Δt", "30", "",
         "Δv m v1 W", "Δv = -v1 ± √(v1 ^ 2 + 2 W : m)", "Δv a F v1 W", "27", "",
         "Δv m v2 W", "Δv = v2 ± √(v2 ^ 2 - 2 W : m)", "Δv a F v2 W", "27", "",
         "Δv m {v} W", "Δv = W : m : {v}", "Δv a F {v} W", "27", "",
         "Δv P Δs v1 W", "Δv = 2 (P Δs : W - v1)", "Δv Δs Δt v1", "43", "",
         "Δv P Δs v2 W", "Δv = 2 (v2 - P Δs : W)", "Δv Δs Δt v2", "43", "",
         "Δv Δs Δt v1", "Δv = 2 (Δs : Δt - v1)", "Δv v1 {v}", "20", "",
         "Δv Δs Δt v2", "Δv = 2 (v2 - Δs : Δt)", "Δv v2 {v}", "20", "",
         "Δv v1 v2", "Δv = v2 - v1", "", "7", "3",
         "Δv v1 {v}", "Δv = 2 ({v} - v1)", "Δv v1 v2", "12", "3",
         "Δv v2 {v}", "Δv = 2 (v2 - {v})", "Δv v1 v2", "11", "3",
         "Δv Δvx", "Δv = Δvx", "", "0", "",
         "Δv Δvy", "Δv = Δvy", "", "0", "",
         "Δv Δvz", "Δv = Δvz", "", "0", "",
         "Δv Δvx θ", "Δv = Δvx : cos(θ)", "", "0", "",
         "Δv Δvy θ", "Δv = Δvy : sin(θ)", "", "0", "",
         "Δv Δvz θ", "Δv = Δvz : cos(θ)", "", "0", "",
         "Δv Δvx θ ϕ", "Δv = Δvx : cos(θ) : sin(ϕ))", "", "0", "",
         "Δv Δvz θ ϕ", "Δv = Δvz : cos(θ) : cos(ϕ)", "", "0", "",
         "Δv Δvx Δvy", "Δv = √(Δvx ^ 2 + Δvy ^ 2)", "", "0", "",
         "Δv Δvx Δvz", "Δv = √(Δvx ^ 2 + Δvz ^ 2)", "", "0", "",
         "Δv Δvy Δvz", "Δv = √(Δvy ^ 2 + Δvz ^ 2)", "", "0", "",
         "Δv Δvx Δvy Δvz", "Δv = √(Δvx ^ 2 + Δvy ^ 2 + Δvz ^ 2)", "", "0", ""} ' Δv => 6798
      Case "Ek1" : DՃA = New String() {
         "Ek1 Ek2 ΔEk", "Ek1 = Ek2 - ΔEk", "", "37", "",
         "Ek1 Ek2 Ep1 Ep2", "Ek1 = Ek2 + Ep2 - Ep1", "Ek1 Ek2 ΔEp", "39", "",
         "Ek1 Ek2 ΔEp", "Ek1 = Ek2 + ΔEp", "Ek1 Ek2 W", "34", "",
         "Ek1 Ek2 W", "Ek1 = Ek2 - W", "Ek1 Ek2 ΔEk", "33", ""} ' Ek1 => 4
      Case "Ek2" : DՃA = New String() {
             "Ek2 Ek1 ΔEk", "Ek2 = Ek1 + ΔEk", "", "38", "",
             "Ek2 Ek1 Ep1 Ep2", "Ek2 = Ek1 + Ep1 - Ep2", "Ek2 Ek1 ΔEp", "39", "",
             "Ek2 Ek1 ΔEp", "Ek2 = Ek1 - ΔEp", "Ek2 Ek1 W", "34", "",
             "Ek2 Ek1 W", "Ek2 = Ek1 + W", "Ek2 Ek1 ΔEk", "33", ""} ' Ek2 => 4
      Case "ΔEk" : DՃA = New String() {
         "ΔEk Ek1 Ek2", "ΔEk = Ek2 - Ek1", "", "36", "",
         "ΔEk Ep1 Ep2", "ΔEk = Ep1 - Ep2", "ΔEk ΔEp", "39", "",
         "ΔEk ΔEp", "ΔEk = -ΔEp", "ΔEk W", "34", "",
         "ΔEk W", "ΔEk = W", "", "33", ""} ' ΔEk => 4
      Case "Ep1" : DՃA = New String() {
         "Ep1 Ep2 Ek1 Ek2", "Ep1 = Ep2 + Ek2 - Ek1", "Ep1 ΔEk Ep2", "36", "",
         "Ep1 ΔEk Ep2", "Ep1 = Ep2 + ΔEk", "Ep1 Ep2 W", "32", "",
         "Ep1 Ep2 ΔEp", "Ep1 = Ep2 - ΔEp", "", "40", "",
         "Ep1 Ep2 W", "Ep1 = Ep2 + W", "Ep1 Ep2 ΔEp", "35", ""} ' Ep1 => 4
      Case "Ep2" : DՃA = New String() {
         "Ep2 Ek1 Ek2 Ep2", "Ep2 = Ep1 + Ek1 - Ek2", "Ep2 ΔEk Ep1", "36", "",
         "Ep2 ΔEk Ep1", "Ep2 = Ep1 - ΔEk", "Ep2 Ep1 W", "32", "",
         "Ep2 Ep1 ΔEp", "Ep2 = Ep1 + ΔEp", "", "41", "",
         "Ep2 Ep1 W", "Ep2 = Ep1 - W", "Ep2 Ep1 ΔEp", "35", ""} ' Ep2 => 4
      Case "ΔEp" : DՃA = New String() {
         "ΔEp Ek1 Ek2", "ΔEp = Ek1 - Ek2", "ΔEp ΔEk", "36", "",
         "ΔEp ΔEk", "ΔEp = -ΔEk", "ΔEp W", "32", "",
         "ΔEp Ep1 Ep2", "ΔEp = Ep2 - Ep1", "", "39", "",
         "ΔEp W", "ΔEp = -W", "", "35", ""} ' ΔEp => 4
      Case "Ffx" : DՃA = New String() {
         "Ffx Ff", "Ffx = Ff", "", "0", "",
         "Ffx Ff θ", "Ffx = Ff cos(θ)", "", "0", "",
         "Ffx Ffy θ", "Ffx = Ffy : tan(θ)", "", "0", "",
         "Ffx Ffz ϕ", "Ffx = Ffz tan(ϕ)", "", "0", "",
         "Ffx Ff Ffy", "Ffx = √(Ff ^ 2 - Ffy ^ 2)", "", "0", "",
         "Ffx Ff Ffz", "Ffx = √(Ff ^ 2 - Ffz ^ 2)", "", "0", "",
         "Ffx Ff θ ϕ", "Ffx = Ff cos(θ) sin(ϕ)", "", "0", "",
         "Ffx Ffy θ ϕ", "Ffx = Ffy sin(ϕ) : tan(θ)", "", "0", "",
         "Ffx Ff Ffy Ffz", "Ffx = √(Ff ^ 2 - Ffy ^ 2 - Ffz ^ 2)", "", "0", ""} ' Ffx => 9
      Case "Ffy" : DՃA = New String() {
         "Ffy Ff", "Ffy = Ff", "", "0", "",
         "Ffy Ff θ", "Ffy = Ff sin(θ)", "", "0", "",
         "Ffy Ffx θ", "Ffy = Ffx tan(θ)", "", "0", "",
         "Ffy Ffz θ", "Ffy = Ffz tan(θ)", "", "0", "",
         "Ffy Ff Ffx", "Ffy = √(Ff ^ 2 - Ffx ^ 2)", "", "0", "",
         "Ffy Ff Ffz", "Ffy = √(Ff ^ 2 - Ffz ^ 2)", "", "0", "",
         "Ffy Ffx θ ϕ", "Ffy = Ffx tan(θ) : sin(ϕ)", "", "0", "",
         "Ffy Ffz θ ϕ", "Ffy = Ffz tan(θ) : cos(ϕ)", "", "0", "",
         "Ffy Ff Ffx Ffz", "Ffy = √(Ff ^ 2 - Ffx ^ 2 - Ffz ^ 2)", "", "0", ""} ' Ffy => 9
      Case "Ffz" : DՃA = New String() {
         "Ffz Ff", "Ffz = Ff", "", "0", "",
         "Ffz Ff θ", "Ffz = Ff cos(θ)", "", "0", "",
         "Ffz Ffx ϕ", "Ffz = Ffx : tan(ϕ)", "", "0", "",
         "Ffz Ffy θ", "Ffz = Ffy : tan(θ)", "", "0", "",
         "Ffz Ff Ffx", "Ffz = √(Ff ^ 2 - Ffx ^ 2)", "", "0", "",
         "Ffz Ff Ffy", "Ffz = √(Ff ^ 2 - Ffy ^ 2)", "", "0", "",
         "Ffz Ffy θ ϕ", "Ffz = Ffy cos(ϕ) : tan(θ)", "", "0", "",
         "Ffz Ff θ ϕ", "Ffz = Ff cos(θ) cos(ϕ)", "", "0", "",
         "Ffz Ff Ffx Ffy", "Ffz = √(Ff ^ 2 - Ffx ^ 2 - Ffy ^ 2)", "", "0", ""} ' Ffz => 9
      Case "Frg" : DՃA = New String() {
         "Frg F", "Frg = F", "", "0", "",
         "Frg F Ff", "Frg = F - Ff", "", "0", "",
         "Frg F Ff Ft", "Frg = F - Ft - Ff", "", "0", "",
         "Frg F Ft", "Frg = F - Ft", "", "0", "",
         "Frg F Ft k Δs", "Frg = F + k Δs - Ft", "", "0", "",
         "Frg F k Δs", "Frg = F + k Δs", "", "0", "",
         "Frg |Fn| μg", "Frg = μg |Fn|", "", "0", ""} ' Frg => 105
      Case "Frh" : DՃA = New String() {
         "Frh F", "Frh = F", "", "0", "",
         "Frh F Ff", "Frh = F - Ff", "", "0", "",
         "Frh F Ff Ft", "Frh = F - Ft - Ff", "", "0", "",
         "Frh F Ft", "Frh = F - Ft", "", "0", "",
         "Frh F Ft k Δs", "Frh = F + k Δs - Ft", "", "0", "",
         "Frh F k Δs", "Frh = F + k Δs", "", "0", "",
         "Frh |Fn| μh", "Frh = μh |Fn|", "", "0", ""} ' Frh => 105
      Case "Frr" : DՃA = New String() {
         "Frr F", "Frr = F", "", "0", "",
         "Frr F Ff", "Frr = F - Ff", "", "0", "",
         "Frr F Ff Ft", "Frr = F - Ft - Ff", "", "0", "",
         "Frr F Ft", "Frr = F - Ft", "", "0", "",
         "Frr F Ft k Δs", "Frr = F + k Δs - Ft", "", "0", "",
         "Frr F k Δs", "Frr = F + k Δs", "", "0", "",
         "Frr |Fn| μr", "Frr = μr |Fn|", "", "0", ""} ' Frr => 105
      Case "Ftx" : DՃA = New String() {
         "Ftx Ft", "Ftx = Ft", "", "0", "",
         "Ftx Ft θ", "Ftx = Ft cos(θ)", "", "0", "",
         "Ftx Fty θ", "Ftx = Fty : tan(θ)", "", "0", "",
         "Ftx Ftz ϕ", "Ftx = Ftz tan(ϕ)", "", "0", "",
         "Ftx Ft Fty", "Ftx = √(Ft ^ 2 - Fty ^ 2)", "", "0", "",
         "Ftx Ft Ftz", "Ftx = √(Ft ^ 2 - Ftz ^ 2)", "", "0", "",
         "Ftx Ft θ ϕ", "Ftx = Ft cos(θ) sin(ϕ)", "", "0", "",
         "Ftx Fty θ ϕ", "Ftx = Fty sin(ϕ) : tan(θ)", "", "0", "",
         "Ftx Ft Fty Ftz", "Ftx = √(Ft ^ 2 - Fty ^ 2 - Ftz ^ 2)", "", "0", ""} ' Ftx => 9
      Case "Fty" : DՃA = New String() {
         "Fty Ft", "Fty = Ft", "", "0", "",
         "Fty Ft θ", "Fty = Ft sin(θ)", "", "0", "",
         "Fty Ftx θ", "Fty = Ftx tan(θ)", "", "0", "",
         "Fty Ftz θ", "Fty = Ftz tan(θ)", "", "0", "",
         "Fty Ft Ftx", "Fty = √(Ft ^ 2 - Ftx ^ 2)", "", "0", "",
         "Fty Ft Ftz", "Fty = √(Ft ^ 2 - Ftz ^ 2)", "", "0", "",
         "Fty Ftx θ ϕ", "Fty = Ftx tan(θ) : sin(ϕ)", "", "0", "",
         "Fty Ftz θ ϕ", "Fty = Ftz tan(θ) : cos(ϕ)", "", "0", "",
         "Fty Ft Ftx Ftz", "Fty = √(Ft ^ 2 - Ftx ^ 2 - Ftz ^ 2)", "", "0", ""} ' Fty => 9
      Case "Ftz" : DՃA = New String() {
         "Ftz Ft", "Ftz = Ft", "", "0", "",
         "Ftz Ft θ", "Ftz = Ft cos(θ)", "", "0", "",
         "Ftz Ftx ϕ", "Ftz = Ftx : tan(ϕ)", "", "0", "",
         "Ftz Fty θ", "Ftz = Fty : tan(θ)", "", "0", "",
         "Ftz Ft Ftx", "Ftz = √(Ft ^ 2 - Ftx ^ 2)", "", "0", "",
         "Ftz Ft Fty", "Ftz = √(Ft ^ 2 - Fty ^ 2)", "", "0", "",
         "Ftz Fty θ ϕ", "Ftz = Fty cos(ϕ) : tan(θ)", "", "0", "",
         "Ftz Ft θ ϕ", "Ftz = Ft cos(θ) cos(ϕ)", "", "0", "",
         "Ftz Ft Ftx Fty", "Ftz = √(Ft ^ 2 - Ftx ^ 2 - Fty ^ 2)", "", "0", ""} ' Ftz => 9
      Case "sx1" : DՃA = New String() {
         "sx1 s1", "sx1 = s1", "", "0", "",
         "sx1 s1 θ", "sx1 = s1 cos(θ)", "", "0", "",
         "sx1 sy1 θ", "sx1 = sy1 : tan(θ)", "", "0", "",
         "sx1 sz1 ϕ", "sx1 = sz1 tan(ϕ)", "", "0", "",
         "sx1 s1 sy1", "sx1 = √(s1 ^ 2 - sy1 ^ 2)", "", "0", "",
         "sx1 s1 sz1", "sx1 = √(s1 ^ 2 - sz1 ^ 2)", "", "0", "",
         "sx1 s1 θ ϕ", "sx1 = s1 cos(θ) sin(ϕ)", "", "0", "",
         "sx1 sy1 θ ϕ", "sx1 = sy1 sin(ϕ) : tan(θ)", "", "0", "",
         "sx1 s1 sy1 sz1", "sx1 = √(s1 ^ 2 - sy1 ^ 2 - sz1 ^ 2)", "", "0", ""} ' sx1 => 9
      Case "sy1" : DՃA = New String() {
         "sy1 s1", "sy1 = s1", "", "0", "",
         "sy1 s1 θ", "sy1 = s1 sin(θ)", "", "0", "",
         "sy1 sx1 θ", "sy1 = sx1 tan(θ)", "", "0", "",
         "sy1 sz1 θ", "sy1 = sz1 tan(θ)", "", "0", "",
         "sy1 s1 sx1", "sy1 = √(s1 ^ 2 - sx1 ^ 2)", "", "0", "",
         "sy1 s1 sz1", "sy1 = √(s1 ^ 2 - sz1 ^ 2)", "", "0", "",
         "sy1 sx1 θ ϕ", "sy1 = sx1 tan(θ) : sin(ϕ)", "", "0", "",
         "sy1 sz1 θ ϕ", "sy1 = sz1 tan(θ) : cos(ϕ)", "", "0", "",
         "sy1 s1 sx1 sz1", "sy1 = √(s1 ^ 2 - sx1 ^ 2 - sz1 ^ 2)", "", "0", ""} ' sy1 => 9
      Case "sz1" : DՃA = New String() {
         "sz1 s1", "sz1 = s1", "", "0", "",
         "sz1 s1 θ", "sz1 = s1 cos(θ)", "", "0", "",
         "sz1 sx1 ϕ", "sz1 = sx1 : tan(ϕ)", "", "0", "",
         "sz1 sy1 θ", "sz1 = sy1 : tan(θ)", "", "0", "",
         "sz1 s1 sx1", "sz1 = √(s1 ^ 2 - sx1 ^ 2)", "", "0", "",
         "sz1 s1 sy1", "sz1 = √(s1 ^ 2 - sy1 ^ 2)", "", "0", "",
         "sz1 sy1 θ ϕ", "sz1 = sy1 cos(ϕ) : tan(θ)", "", "0", "",
         "sz1 s1 θ ϕ", "sz1 = s1 cos(θ) cos(ϕ)", "", "0", "",
         "sz1 s1 sx1 sy1", "sz1 = √(s1 ^ 2 - sx1 ^ 2 - sy1 ^ 2)", "", "0", ""} ' sz1 => 9
      Case "sx2" : DՃA = New String() {
         "sx2 s2", "sx2 = s2", "", "0", "",
         "sx2 s2 θ", "sx2 = s2 cos(θ)", "", "0", "",
         "sx2 sy2 θ", "sx2 = sy2 : tan(θ)", "", "0", "",
         "sx2 sz2 ϕ", "sx2 = sz2 tan(ϕ)", "", "0", "",
         "sx2 s2 sy2", "sx2 = √(s2 ^ 2 - sy2 ^ 2)", "", "0", "",
         "sx2 s2 sz2", "sx2 = √(s2 ^ 2 - sz2 ^ 2)", "", "0", "",
         "sx2 s2 θ ϕ", "sx2 = s2 cos(θ) sin(ϕ)", "", "0", "",
         "sx2 sy2 θ ϕ", "sx2 = sy2 sin(ϕ) : tan(θ)", "", "0", "",
         "sx2 s2 sy2 sz2", "sx2 = √(s2 ^ 2 - sy2 ^ 2 - sz2 ^ 2)", "", "0", ""} ' sx2 => 9
      Case "sy2" : DՃA = New String() {
         "sy2 s2", "sy2 = s2", "", "0", "",
         "sy2 s2 θ", "sy2 = s2 sin(θ)", "", "0", "",
         "sy2 sx2 θ", "sy2 = sx2 tan(θ)", "", "0", "",
         "sy2 sz2 θ", "sy2 = sz2 tan(θ)", "", "0", "",
         "sy2 s2 sx2", "sy2 = √(s2 ^ 2 - sx2 ^ 2)", "", "0", "",
         "sy2 s2 sz2", "sy2 = √(s2 ^ 2 - sz2 ^ 2)", "", "0", "",
         "sy2 sx2 θ ϕ", "sy2 = sx2 tan(θ) : sin(ϕ)", "", "0", "",
         "sy2 sz2 θ ϕ", "sy2 = sz2 tan(θ) : cos(ϕ)", "", "0", "",
         "sy2 s2 sx2 sz2", "sy2 = √(s2 ^ 2 - sx2 ^ 2 - sz2 ^ 2)", "", "0", ""} ' sy2 => 9
      Case "sz2" : DՃA = New String() {
         "sz2 s2", "sz2 = s2", "", "0", "",
         "sz2 s2 θ", "sz2 = s2 cos(θ)", "", "0", "",
         "sz2 sx2 ϕ", "sz2 = sx2 : tan(ϕ)", "", "0", "",
         "sz2 sy2 θ", "sz2 = sy2 : tan(θ)", "", "0", "",
         "sz2 s2 sx2", "sz2 = √(s2 ^ 2 - sx2 ^ 2)", "", "0", "",
         "sz2 s2 sy2", "sz2 = √(s2 ^ 2 - sy2 ^ 2)", "", "0", "",
         "sz2 sy2 θ ϕ", "sz2 = sy2 cos(ϕ) : tan(θ)", "", "0", "",
         "sz2 s2 θ ϕ", "sz2 = s2 cos(θ) cos(ϕ)", "", "0", "",
         "sz2 s2 sx2 sy2", "sz2 = √(s2 ^ 2 - sx2 ^ 2 - sy2 ^ 2)", "", "0", ""} ' sz2 => 9
      Case "Δsx" : DՃA = New String() {
         "Δsx Δs", "Δsx = Δs", "", "0", "",
         "Δsx Δs θ", "Δsx = Δs cos(θ)", "", "0", "",
         "Δsx Δsy θ", "Δsx = Δsy : tan(θ)", "", "0", "",
         "Δsx Δsz ϕ", "Δsx = Δsz tan(ϕ)", "", "0", "",
         "Δsx Δs Δsy", "Δsx = √(Δs ^ 2 - Δsy ^ 2)", "", "0", "",
         "Δsx Δs Δsz", "Δsx = √(Δs ^ 2 - Δsz ^ 2)", "", "0", "",
         "Δsx Δs θ ϕ", "Δsx = Δs cos(θ) sin(ϕ)", "", "0", "",
         "Δsx Δsy θ ϕ", "Δsx = Δsy sin(ϕ) : tan(θ)", "", "0", "",
         "Δsx Δs Δsy Δsz", "Δsx = √(Δs ^ 2 - Δsy ^ 2 - Δsz ^ 2)", "", "0", ""} ' Δsx => 9
      Case "Δsy" : DՃA = New String() {
         "Δsy Δs", "Δsy = Δs", "", "0", "",
         "Δsy Δs θ", "Δsy = Δs sin(θ)", "", "0", "",
         "Δsy Δsx θ", "Δsy = Δsx tan(θ)", "", "0", "",
         "Δsy Δsz θ", "Δsy = Δsz tan(θ)", "", "0", "",
         "Δsy Δs Δsx", "Δsy = √(Δs ^ 2 - Δsx ^ 2)", "", "0", "",
         "Δsy Δs Δsz", "Δsy = √(Δs ^ 2 - Δsz ^ 2)", "", "0", "",
         "Δsy Δsx θ ϕ", "Δsy = Δsx tan(θ) : sin(ϕ)", "", "0", "",
         "Δsy Δsz θ ϕ", "Δsy = Δsz tan(θ) : cos(ϕ)", "", "0", "",
         "Δsy Δs Δsx Δsz", "Δsy = √(Δs ^ 2 - Δsx ^ 2 - Δsz ^ 2)", "", "0", ""} ' Δsy => 9
      Case "Δsz" : DՃA = New String() {
         "Δsz Δs", "Δsz = Δs", "", "0", "",
         "Δsz Δs θ", "Δsz = Δs cos(θ)", "", "0", "",
         "Δsz Δsx ϕ", "Δsz = Δsx : tan(ϕ)", "", "0", "",
         "Δsz Δsy θ", "Δsz = Δsy : tan(θ)", "", "0", "",
         "Δsz Δs Δsx", "Δsz = √(Δs ^ 2 - Δsx ^ 2)", "", "0", "",
         "Δsz Δs Δsy", "Δsz = √(Δs ^ 2 - Δsy ^ 2)", "", "0", "",
         "Δsz Δsy θ ϕ", "Δsz = Δsy cos(ϕ) : tan(θ)", "", "0", "",
         "Δsz Δs θ ϕ", "Δsz = Δs cos(θ) cos(ϕ)", "", "0", "",
         "Δsz Δs Δsx Δsy", "Δsz = √(Δs ^ 2 - Δsx ^ 2 - Δsy ^ 2)", "", "0", ""} ' Δsz => 9
      Case "vx1" : DՃA = New String() {
         "vx1 v1", "vx1 = v1", "", "0", "",
         "vx1 v1 θ", "vx1 = v1 cos(θ)", "", "0", "",
         "vx1 vy1 θ", "vx1 = vy1 : tan(θ)", "", "0", "",
         "vx1 vz1 ϕ", "vx1 = vz1 tan(ϕ)", "", "0", "",
         "vx1 v1 vy1", "vx1 = √(v1 ^ 2 - vy1 ^ 2)", "", "0", "",
         "vx1 v1 vz1", "vx1 = √(v1 ^ 2 - vz1 ^ 2)", "", "0", "",
         "vx1 v1 θ ϕ", "vx1 = v1 cos(θ) sin(ϕ)", "", "0", "",
         "vx1 vy1 θ ϕ", "vx1 = vy1 sin(ϕ) : tan(θ)", "", "0", "",
         "vx1 v1 vy1 vz1", "vx1 = √(v1 ^ 2 - vy1 ^ 2 - vz1 ^ 2)", "", "0", ""} ' vx1 => 9
      Case "vy1" : DՃA = New String() {
         "vy1 v1", "vy1 = v1", "", "0", "",
         "vy1 v1 θ", "vy1 = v1 sin(θ)", "", "0", "",
         "vy1 vx1 θ", "vy1 = vx1 tan(θ)", "", "0", "",
         "vy1 vz1 θ", "vy1 = vz1 tan(θ)", "", "0", "",
         "vy1 v1 vx1", "vy1 = √(v1 ^ 2 - vx1 ^ 2)", "", "0", "",
         "vy1 v1 vz1", "vy1 = √(v1 ^ 2 - vz1 ^ 2)", "", "0", "",
         "vy1 vx1 θ ϕ", "vy1 = vx1 tan(θ) : sin(ϕ)", "", "0", "",
         "vy1 vz1 θ ϕ", "vy1 = vz1 tan(θ) : cos(ϕ)", "", "0", "",
         "vy1 v1 vx1 vz1", "vy1 = √(v1 ^ 2 - vx1 ^ 2 - vz1 ^ 2)", "", "0", ""} ' vy1 => 9
      Case "vz1" : DՃA = New String() {
         "vz1 v1", "vz1 = v1", "", "0", "",
         "vz1 v1 θ", "vz1 = v1 cos(θ)", "", "0", "",
         "vz1 vx1 ϕ", "vz1 = vx1 : tan(ϕ)", "", "0", "",
         "vz1 vy1 θ", "vz1 = vy1 : tan(θ)", "", "0", "",
         "vz1 v1 vx1", "vz1 = √(v1 ^ 2 - vx1 ^ 2)", "", "0", "",
         "vz1 v1 vy1", "vz1 = √(v1 ^ 2 - vy1 ^ 2)", "", "0", "",
         "vz1 vy1 θ ϕ", "vz1 = vy1 cos(ϕ) : tan(θ)", "", "0", "",
         "vz1 v1 θ ϕ", "vz1 = v1 cos(θ) cos(ϕ)", "", "0", "",
         "vz1 v1 vx1 vy1", "vz1 = √(v1 ^ 2 - vx1 ^ 2 - vy1 ^ 2)", "", "0", ""} ' vz1 => 9
      Case "vx2" : DՃA = New String() {
         "vx2 v2", "vx2 = v2", "", "0", "",
         "vx2 v2 θ", "vx2 = v2 cos(θ)", "", "0", "",
         "vx2 vy2 θ", "vx2 = vy2 : tan(θ)", "", "0", "",
         "vx2 vz2 ϕ", "vx2 = vz2 tan(ϕ)", "", "0", "",
         "vx2 v2 vy2", "vx2 = √(v2 ^ 2 - vy2 ^ 2)", "", "0", "",
         "vx2 v2 vz2", "vx2 = √(v2 ^ 2 - vz2 ^ 2)", "", "0", "",
         "vx2 v2 θ ϕ", "vx2 = v2 cos(θ) sin(ϕ)", "", "0", "",
         "vx2 vy2 θ ϕ", "vx2 = vy2 sin(ϕ) : tan(θ)", "", "0", "",
         "vx2 v2 vy2 vz2", "vx2 = √(v2 ^ 2 - vy2 ^ 2 - vz2 ^ 2)", "", "0", ""} ' vx2 => 9
      Case "vy2" : DՃA = New String() {
         "vy2 v2", "vy2 = v2", "", "0", "",
         "vy2 v2 θ", "vy2 = v2 sin(θ)", "", "0", "",
         "vy2 vx2 θ", "vy2 = vx2 tan(θ)", "", "0", "",
         "vy2 vz2 θ", "vy2 = vz2 tan(θ)", "", "0", "",
         "vy2 v2 vx2", "vy2 = √(v2 ^ 2 - vx2 ^ 2)", "", "0", "",
         "vy2 v2 vz2", "vy2 = √(v2 ^ 2 - vz2 ^ 2)", "", "0", "",
         "vy2 vx2 θ ϕ", "vy2 = vx2 tan(θ) : sin(ϕ)", "", "0", "",
         "vy2 vz2 θ ϕ", "vy2 = vz2 tan(θ) : cos(ϕ)", "", "0", "",
         "vy2 v2 vx2 vz2", "vy2 = √(v2 ^ 2 - vx2 ^ 2 - vz2 ^ 2)", "", "0", ""} ' vy2 => 9
      Case "vz2" : DՃA = New String() {
         "vz2 v2", "vz2 = v2", "", "0", "",
         "vz2 v2 θ", "vz2 = v2 cos(θ)", "", "0", "",
         "vz2 vx2 ϕ", "vz2 = vx2 : tan(ϕ)", "", "0", "",
         "vz2 vy2 θ", "vz2 = vy2 : tan(θ)", "", "0", "",
         "vz2 v2 vx2", "vz2 = √(v2 ^ 2 - vx2 ^ 2)", "", "0", "",
         "vz2 v2 vy2", "vz2 = √(v2 ^ 2 - vy2 ^ 2)", "", "0", "",
         "vz2 vy2 θ ϕ", "vz2 = vy2 cos(ϕ) : tan(θ)", "", "0", "",
         "vz2 v2 θ ϕ", "vz2 = v2 cos(θ) cos(ϕ)", "", "0", "",
         "vz2 v2 vx2 vy2", "vz2 = √(v2 ^ 2 - vx2 ^ 2 - vy2 ^ 2)", "", "0", ""} ' vz2 => 9
      Case "Δvx" : DՃA = New String() {
         "Δvx Δv", "Δvx = Δv", "", "0", "",
         "Δvx Δv θ", "Δvx = Δv cos(θ)", "", "0", "",
         "Δvx Δvy θ", "Δvx = Δvy : tan(θ)", "", "0", "",
         "Δvx Δvz ϕ", "Δvx = Δvz tan(ϕ)", "", "0", "",
         "Δvx Δv Δvy", "Δvx = √(Δv ^ 2 - Δvy ^ 2)", "", "0", "",
         "Δvx Δv Δvz", "Δvx = √(Δv ^ 2 - Δvz ^ 2)", "", "0", "",
         "Δvx Δv θ ϕ", "Δvx = Δv cos(θ) sin(ϕ)", "", "0", "",
         "Δvx Δvy θ ϕ", "Δvx = Δvy sin(ϕ) : tan(θ)", "", "0", "",
         "Δvx Δv Δvy Δvz", "Δvx = √(Δv ^ 2 - Δvy ^ 2 - Δvz ^ 2)", "", "0", ""} ' Δvx => 9
      Case "Δvy" : DՃA = New String() {
         "Δvy Δv", "Δvy = Δv", "", "0", "",
         "Δvy Δv θ", "Δvy = Δv sin(θ)", "", "0", "",
         "Δvy Δvx θ", "Δvy = Δvx tan(θ)", "", "0", "",
         "Δvy Δvz θ", "Δvy = Δvz tan(θ)", "", "0", "",
         "Δvy Δv Δvx", "Δvy = √(Δv ^ 2 - Δvx ^ 2)", "", "0", "",
         "Δvy Δv Δvz", "Δvy = √(Δv ^ 2 - Δvz ^ 2)", "", "0", "",
         "Δvy Δvx θ ϕ", "Δvy = Δvx tan(θ) : sin(ϕ)", "", "0", "",
         "Δvy Δvz θ ϕ", "Δvy = Δvz tan(θ) : cos(ϕ)", "", "0", "",
         "Δvy Δv Δvx Δvz", "Δvy = √(Δv ^ 2 - Δvx ^ 2 - Δvz ^ 2)", "", "0", ""} ' Δvy => 9
      Case "Δvz" : DՃA = New String() {
         "Δvz Δv", "Δvz = Δv", "", "0", "",
         "Δvz Δv θ", "Δvz = Δv cos(θ)", "", "0", "",
         "Δvz Δvx ϕ", "Δvz = Δvx : tan(ϕ)", "", "0", "",
         "Δvz Δvy θ", "Δvz = Δvy : tan(θ)", "", "0", "",
         "Δvz Δv Δvx", "Δvz = √(Δv ^ 2 - Δvx ^ 2)", "", "0", "",
         "Δvz Δv Δvy", "Δvz = √(Δv ^ 2 - Δvy ^ 2)", "", "0", "",
         "Δvz Δvy θ ϕ", "Δvz = Δvy cos(ϕ) : tan(θ)", "", "0", "",
         "Δvz Δv θ ϕ", "Δvz = Δv cos(θ) cos(ϕ)", "", "0", "",
         "Δvz Δv Δvx Δvy", "Δvz = √(Δv ^ 2 - Δvx ^ 2 - Δvy ^ 2)", "", "0", ""} ' Δvz => 9
      Case "{v}" : DՃA = New String() {
         "{v} a F k v1", "{v} = (v1 ± √(v1 ^ 2 - 2 a F : k)) : 2", "{v} a Δs v1", "59", "",
         "{v} a F k v2", "{v} = (v2 ± √(v2 ^ 2 + 2 a F : k)) : 2", "{v} a Δs v2", "59", "",
         "{v} a F k Δv", "{v} = -a F : k : Δv", "{v} F k Δt", "25", "",
         "{v} a F v1 W", "{v} = (v1 ± √(v1 ^ 2 + 2 a W : F)) : 2", "{v} m v1 W", "28", "",
         "{v} a F v2 W", "{v} = (v2 ± √(v2 ^ 2 - 2 a W : F)) : 2", "{v} m v2 W", "28", "",
         "{v} a F Δv W", "{v} = a W : F : Δv", "{v} a Δs Δv", "31", "",
         "{v} a |Fn| μg v1 W", "{v} = (v1 ± √(v1 ^ 2 + 2 a W : |Fn| : μg)) : 2", "{v} a F v1 W", "85", "",
         "{v} a |Fn| μg v2 W", "{v} = (v2 ± √(v2 ^ 2 - 2 a W : |Fn| : μg)) : 2", "{v} a F v2 W", "85", "",
         "{v} a |Fn| μg Δv W", "{v} = a W : |Fn| : μg : Δv", "{v} a F Δv W", "85", "",
         "{v} a |Fn| μh v1 W", "{v} = (v1 ± √(v1 ^ 2 + 2 a W : |Fn| : μh)) : 2", "{v} a F v1 W", "88", "",
         "{v} a |Fn| μh v2 W", "{v} = (v2 ± √(v2 ^ 2 - 2 a W : |Fn| : μh)) : 2", "{v} a f v2 W", "88", "",
         "{v} a |Fn| μh Δv W", "{v} = a W : |Fn| : μh : Δv", "{v} a F Δv W", "88", "",
         "{v} a |Fn| μr v1 W", "{v} = (v1 ± √(v1 ^ 2 + 2 a W : |Fn| : μr)) : 2", "{v} a F v1 W", "91", "",
         "{v} a |Fn| μr v2 W", "{v} = (v2 ± √(v2 ^ 2 - 2 a W : |Fn| : μr)) : 2", "{v} a F v2 W", "91", "",
         "{v} a |Fn| μr Δv W", "{v} = a W : |Fn| : μr : Δv", "{v} a F Δv W", "91", "",
         "{v} a k m Δt", "{v} = -a m : k : Δt", "{v} F k Δt", "26", "",
         "{v} a k m v1", "{v} = (v1 ± √(v1 ^ 2 - 2 a ^ 2 m : k)) : 2", "{v} a F k v1", "26", "",
         "{v} a k m v2", "{v} = (v2 ± √(v2 ^ 2 + 2 a ^ 2 m : k)) : 2", "{v} a F k v2", "26", "",
         "{v} a k m Δv", "{v} = -(a ^ 2) m : k : Δv", "{v} a F k Δv", "26", "",
         "{v} a k P Δv", "{v} = √(-a P : k : Δv)", "{v} k P Δt", "25", "",
         "{v} a k v1 W", "{v} = (v1 ± √(v1 ^ 2 + 2 a √(-W : k))) : 2", "{v} a F k v1", "75", "",
         "{v} a k v2 W", "{v} = (v2 ± √(v2 ^ 2 - 2 a √(-W : k))) : 2", "{v} a F k v2", "75", "",
         "{v} a k Δv W", "{v} = a √(-W : k) : Δv", "{v} a F k Δv", "75", "",
         "{v} a m P", "{v} = P : a : m", "{v} F P", "26", "",
         "{v} a m Δt W", "{v} = W : a : m : Δt", "{v} F Δt W", "26", "",
         "{v} a P v1 W", "{v} = v1 + a W : P : 2", "{v} a Δt v1", "43", "",
         "{v} a P v2 W", "{v} = v2 - a W : P : 2", "{v} a Δt v2", "43", "",
         "{v} a Δs v1", "{v} = (v1 ± √(v1 ^ 2 + 2 a Δs)) : 2", "{v} a Δt v1", "22", "",
         "{v} a Δs v2", "{v} = (v2 ± √(v2 ^ 2 - 2 a Δs)) : 2", "{v} a Δt v2", "22", "",
         "{v} a Δs Δv", "{v} = a Δs : Δv", "{v} Δs Δt", "25", "",
         "{v} a Δt v1", "{v} = v1 + a Δt : 2", "{v} v1 Δv", "24", "",
         "{v} a Δt v2", "{v} = v2 - a Δt : 2", "{v} v2 Δv", "24", "",
         "{v} F k m v1", "{v} = (v1 ± √(v1 ^ 2 - 2 F ^ 2 : k : m)) : 2", "{v} a F k v1", "27", "",
         "{v} F k m v2", "{v} = (v2 ± √(v2 ^ 2 + 2 F ^ 2 : k : m)) : 2", "{v} a F k v2", "27", "",
         "{v} F k m Δv", "{v} = -(F ^ 2) : k : m : Δv", "{v} a F k Δv", "27", "",
         "{v} F k Δt", "{v} = -F : k : Δt", "{v} Δs Δt", "59", "",
         "{v} F m Δs v1", "{v} = (v1 ± √(v1 ^ 2 + 2 F Δs : m)) : 2", "{v} a Δs v1", "27", "",
         "{v} F m Δs v2", "{v} = (v2 ± √(v2 ^ 2 - 2 F Δs : m)) : 2", "{v} a Δs v2", "27", "",
         "{v} F m Δs Δv", "{v} = F Δs : m : Δv", "{v} a Δs Δv", "27", "",
         "{v} F m Δt v1", "{v} = v1 + F Δt : m : 2", "{v} a Δt v1", "27", "",
         "{v} F m Δt v2", "{v} = v2 - F Δt : m : 2", "{v} a Δt v2", "27", "",
         "{v} F P", "{v} = P : F", "{v} F Δt W", "43", "",
         "{v} F Δt W", "{v} = W : F : Δt", "{v} Δs Δt", "31", "",
         "{v} |Fn| m μg Δs v1", "{v} = (v1 ± √(v1 ^ 2 + 2 |Fn| μg Δs : m)) : 2", "{v} F m  Δs v1", "85", "",
         "{v} |Fn| m μg Δs v2", "{v} = (v2 ± √(v2 ^ 2 - 2 |Fn| μg Δs : m)) : 2", "{v} F m Δs v2", "85", "",
         "{v} |Fn| m μg Δs Δv", "{v} = |Fn| μg Δs : m : Δv", "{v} F m Δs Δv", "85", "",
         "{v} |Fn| m μg Δt v1", "{v} = v1 + |Fn| μg Δt : m : 2", "{v} F m Δt v1", "85", "",
         "{v} |Fn| m μg Δt v2", "{v} = v2 - |Fn| μg Δt : m : 2", "{v} F m Δt v2", "85", "",
         "{v} |Fn| m μh Δs v1", "{v} = (v1 ± √(v1 ^ 2 + 2 |Fn| μh Δs : m)) : 2", "{v} F m Δs v1", "88", "",
         "{v} |Fn| m μh Δs v2", "{v} = (v2 ± √(v2 ^ 2 - 2 |Fn| μh Δs : m)) : 2", "{v} F m Δs v2", "88", "",
         "{v} |Fn| m μh Δs Δv", "{v} = |Fn| μh Δs : m : Δv", "{v} F m Δs Δv", "88", "",
         "{v} |Fn| m μh Δt v1", "{v} = v1 + |Fn| μh Δt : m : 2", "{v} F m Δt v1", "88", "",
         "{v} |Fn| m μh Δt v2", "{v} = v2 - |Fn| μh Δt : m : 2", "{v} F m Δt v2", "88", "",
         "{v} |Fn| m μr Δs v1", "{v} = (v1 ± √(v1 ^ 2 + 2 |Fn| μr Δs : m)) : 2", "{v} F m Δs v1", "91", "",
         "{v} |Fn| m μr Δs v2", "{v} = (v2 ± √(v2 ^ 2 - 2 |Fn| μr Δs : m)) : 2", "{v} F m Δs v2", "91", "",
         "{v} |Fn| m μr Δs Δv", "{v} = |Fn| μr Δs : m : Δv", "{v} F m Δs Δv", "91", "",
         "{v} |Fn| m μr Δt v1", "{v} = v1 + |Fn| μr Δt : m : 2", "{v} F m Δt v1", "91", "",
         "{v} |Fn| m μr Δt v2", "{v} = v2 - |Fn| μr Δt : m : 2", "{v} F m Δt v2", "91", "",
         "{v} |Fn| μg P", "{v} = P : |Fn| : μg", "{v} F P", "85", "",
         "{v} |Fn| μg Δt W", "{v} = W : |Fn| : μg : Δt", "{v} F Δt W", "85", "",
         "{v} |Fn| μh P", "{v} = P : |Fn| : μh", "{v} F P", "88", "",
         "{v} |Fn| μh Δt W", "{v} = W : |Fn| : μh : Δt", "{v} F Δt W", "88", "",
         "{v} |Fn| μr P", "{v} = P : |Fn| : μr", "{v} F P", "91", "",
         "{v} |Fn| μr Δt W", "{v} = W : |Fn| : μr : Δt", "{v} F Δt W", "91", "",
         "{v} k m P Δv", "{v} = √(-(P ^ 2) : k : m : Δv ' 3)", "{v} k P W", "63", "",
         "{v} k m Δs v1", "{v} = (v1 ± √(v1 ^ 2 - 2 k Δs ^ 2 : m)) : 2", "{v} F k m v1", "57", "",
         "{v} k m Δs v2", "{v} = (v2 ± √(v2 ^ 2 + 2 k Δs ^ 2 : m)) : 2", "{v} F k m v2", "57", "",
         "{v} k m Δs Δv", "{v} = -k Δs ^ 2 : m : Δv", "{v} F k m Δv", "57", "",
         "{v} k m Δt v1", "{v} = v1 : (1 + k Δt ^ 2 : m : 2)", "{v} k m Δt Δv", "16", "",
         "{v} k m Δt v2", "{v} = v2 : (1 - k Δt ^ 2 : m : 2)", "{v} k m Δt Δv", "13", "",
         "{v} k m Δt Δv", "{v} = -m Δv : k : Δt ^ 2", "{v} a k m Δt", "23", "",
         "{v} k P Δs", "{v} = -P : k : Δs", "{v} F P", "57", "",
         "{v} k P Δt", "{v} = √(-P : k : Δt)", "{v} k P Δs", "21", "",
         "{v} k P W", "{v} = P √(-1 : k : W)", "{v} k P Δt", "43", "",
         "{v} k Δt W", "{v} = √(-W : k) : Δt", "{v} k P Δt", "42", "",
         "{v} m P Δs Δv", "{v} = √(P Δs : m : Δv)", "{v} m P Δt Δv", "22", "",
         "{v} m P Δt v1", "{v} = (v1 ± √(v1 ^ 2 + 2 P Δt : m)) : 2", "{v} m v1 W", "44", "",
         "{v} m P Δt v2", "{v} = (v2 ± √(v2 ^ 2 - 2 P Δt : m)) : 2", "{v} m v2 W", "44", "",
         "{v} m P Δt Δv", "{v} = P Δt : m : Δv", "{v} m Δv W", "44", "",
         "{v} m v1 W", "{v} = (v1 ± √(v1 ^ 2 + 2 W : m)) : 2", "{v} F m Δs v1", "30", "",
         "{v} m v2 W", "{v} = (v2 ± √(v2 ^ 2 - 2 W : m)) : 2", "{v} F m Δs v2", "30", "",
         "{v} m Δv W", "{v} = W : m : Δv", "{v} a m Δt W", "23", "",
         "{v} P Δs W", "{v} = P Δs : W", "{v} Δs Δt", "43", "",
         "{v} Δs Δt", "{v} = Δs : Δt", "", "20", "",
         "{v} v1 v2", "{v} = (v1 + v2) : 2", "", "10", "3",
         "{v} v1 Δv", "{v} = v1 + Δv : 2", "{v} v1 v2", "9", "3",
         "{v} v2 Δv", "{v} = v2 - Δv : 2", "{v} v1 v2", "8", "3",
         "{v} {vx}", "{v} = {vx}", "", "0", "",
         "{v} {vy}", "{v} = {vy}", "", "0", "",
         "{v} {vz}", "{v} = {vz}", "", "0", "",
         "{v} {vx} θ", "{v} = {vx} : cos(θ)", "", "0", "",
         "{v} {vy} θ", "{v} = {vy} : sin(θ)", "", "0", "",
         "{v} {vz} θ", "{v} = {vz} : cos(θ)", "", "0", "",
         "{v} {vx} θ ϕ", "{v} = {vx} : cos(θ) : sin(ϕ)", "", "0", "",
         "{v} {vz} θ ϕ", "{v} = {vz} : cos(θ) : cos(ϕ)", "", "0", "",
         "{v} {vx} {vy}", "{v} = √({vx} ^ 2 + {vy} ^ 2)", "", "0", "",
         "{v} {vx} {vz}", "{v} = √({vx} ^ 2 + {vz} ^ 2)", "", "0", "",
         "{v} {vy} {vz}", "{v} = √({vy} ^ 2 + {vz} ^ 2)", "", "0", "",
         "{v} {vx} {vy} {vz}", "{v} = √({vx} ^ 2 + {vy} ^ 2 + {vz} ^ 2)", "", "0", ""} ' {v} => 3600
      Case "|Fn|" : DՃA = New String() {
         "|Fn| F Ff Ft μg", "|Fn| = (F - Ft - Ff) : μg", "", "0", "",
         "|Fn| F Ff Ft μh", "|Fn| = (F - Ft - Ff) : μh", "", "0", "",
         "|Fn| F Ff Ft μr", "|Fn| = (F - Ft - Ff) : μr", "", "0", "",
         "|Fn| F Ff μg", "|Fn| = (F - Ff) : μg", "", "0", "",
         "|Fn| F Ff μh", "|Fn| = (F - Ff) : μh", "", "0", "",
         "|Fn| F Ff μr", "|Fn| = (F - Ff) : μr", "", "0", "",
         "|Fn| F Ft k μg Δs", "|Fn| = (F + k Δs - Ft) : μg", "", "0", "",
         "|Fn| F Ft k μh Δs", "|Fn| = (F + k Δs - Ft) : μh", "", "0", "",
         "|Fn| F Ft k μr Δs", "|Fn| = (F + k Δs - Ft) : μr", "", "0", "",
         "|Fn| F Ft μg", "|Fn| = (F - Ft) : μg", "", "0", "",
         "|Fn| F Ft μh", "|Fn| = (F - Ft) : μh", "", "0", "",
         "|Fn| F Ft μr", "|Fn| = (F - Ft) : μr", "", "0", "",
         "|Fn| F k μg Δs", "|Fn| = (F + k Δs) : μg", "", "0", "",
         "|Fn| F k μh Δs", "|Fn| = (F + k Δs) : μh", "", "0", "",
         "|Fn| F k μr Δs", "|Fn| = (F + k Δs) : μr", "", "0", "",
         "|Fn| F μg", "|Fn| = F : μg", "", "0", "",
         "|Fn| F μh", "|Fn| = F : μh", "", "0", "",
         "|Fn| F μr", "|Fn| = F : μr", "", "0", "",
         "|Fn| Frg μg", "|Fn| = Frg : μg", "", "0", "",
         "|Fn| Frh μh", "|Fn| = Frh : μh", "", "0", "",
         "|Fn| Frr μr", "|Fn| = Frr : μr", "", "0", ""} ' |Fn| => 315
      Case "Frgx" : DՃA = New String() {
         "Frgx Frg", "Frgx = Frg", "", "0", "",
         "Frgx Frg θ", "Frgx = Frg cos(θ)", "", "0", "",
         "Frgx Frgy θ", "Frgx = Frgy : tan(θ)", "", "0", "",
         "Frgx Frgz ϕ", "Frgx = Frgz tan(ϕ)", "", "0", "",
         "Frgx Frg Frgy", "Frgx = √(Frg ^ 2 - Frgy ^ 2)", "", "0", "",
         "Frgx Frg Frgz", "Frgx = √(Frg ^ 2 - Frgz ^ 2)", "", "0", "",
         "Frgx Frg θ ϕ", "Frgx = Frg cos(θ) sin(ϕ)", "", "0", "",
         "Frgx Frgy θ ϕ", "Frgx = Frgy sin(ϕ) : tan(θ)", "", "0", "",
         "Frgx Frg Frgy Frgz", "Frgx = √(Frg ^ 2 - Frgy ^ 2 - Frgz ^ 2)", "", "0", ""} ' Frgx => 9
      Case "Frgy" : DՃA = New String() {
         "Frgy Frg", "Frgy = Frg", "", "0", "",
         "Frgy Frg θ", "Frgy = Frg sin(θ)", "", "0", "",
         "Frgy Frgx θ", "Frgy = Frgx tan(θ)", "", "0", "",
         "Frgy Frgz θ", "Frgy = Frgz tan(θ)", "", "0", "",
         "Frgy Frg Frgx", "Frgy = √(Frg ^ 2 - Frgx ^ 2)", "", "0", "",
         "Frgy Frg Frgz", "Frgy = √(Frg ^ 2 - Frgz ^ 2)", "", "0", "",
         "Frgy Frgx θ ϕ", "Frgy = Frgx tan(θ) : sin(ϕ)", "", "0", "",
         "Frgy Frgz θ ϕ", "Frgy = Frgz tan(θ) : cos(ϕ)", "", "0", "",
         "Frgy Frg Frgx Frgz", "Frgy = √(Frg ^ 2 - Frgx ^ 2 - Frgz ^ 2)", "", "0", ""} ' Frgy => 9
      Case "Frgz" : DՃA = New String() {
         "Frgz Frg", "Frgz = Frg", "", "0", "",
         "Frgz Frg θ", "Frgz = Frg cos(θ)", "", "0", "",
         "Frgz Frgx ϕ", "Frgz = Frgx : tan(ϕ)", "", "0", "",
         "Frgz Frgy θ", "Frgz = Frgy : tan(θ)", "", "0", "",
         "Frgz Frg Frgx", "Frgz = √(Frg ^ 2 - Frgx ^ 2)", "", "0", "",
         "Frgz Frg Frgy", "Frgz = √(Frg ^ 2 - Frgy ^ 2)", "", "0", "",
         "Frgz Frgy θ ϕ", "Frgz = Frgy cos(ϕ) : tan(θ)", "", "0", "",
         "Frgz Frg θ ϕ", "Frgz = Frg cos(θ) cos(ϕ)", "", "0", "",
         "Frgz Frg Frgx Frgy", "Frgz = √(Frg ^ 2 - Frgx ^ 2 - Frgy ^ 2)", "", "0", ""} ' Frgz => 9
      Case "Frhx" : DՃA = New String() {
         "Frhx Frh", "Frhx = Frh", "", "0", "",
         "Frhx Frh θ", "Frhx = Frh cos(θ)", "", "0", "",
         "Frhx Frhy θ", "Frhx = Frhy : tan(θ)", "", "0", "",
         "Frhx Frhz ϕ", "Frhx = Frhz tan(ϕ)", "", "0", "",
         "Frhx Frh Frhy", "Frhx = √(Frh ^ 2 - Frhy ^ 2)", "", "0", "",
         "Frhx Frh Frhz", "Frhx = √(Frh ^ 2 - Frhz ^ 2)", "", "0", "",
         "Frhx Frh θ ϕ", "Frhx = Frh cos(θ) sin(ϕ)", "", "0", "",
         "Frhx Frhy θ ϕ", "Frhx = Frhy sin(ϕ) : tan(θ)", "", "0", "",
         "Frhx Frh Frhy Frhz", "Frhx = √(Frh ^ 2 - Frhy ^ 2 - Frhz ^ 2)", "", "0", ""} ' Frhx => 9
      Case "Frhy" : DՃA = New String() {
         "Frhy Frh", "Frhy = Frh", "", "0", "",
         "Frhy Frh θ", "Frhy = Frh sin(θ)", "", "0", "",
         "Frhy Frhx θ", "Frhy = Frhx tan(θ)", "", "0", "",
         "Frhy Frhz θ", "Frhy = Frhz tan(θ)", "", "0", "",
         "Frhy Frh Frhx", "Frhy = √(Frh ^ 2 - Frhx ^ 2)", "", "0", "",
         "Frhy Frh Frhz", "Frhy = √(Frh ^ 2 - Frhz ^ 2)", "", "0", "",
         "Frhy Frhx θ ϕ", "Frhy = Frhx tan(θ) : sin(ϕ)", "", "0", "",
         "Frhy Frhz θ ϕ", "Frhy = Frhz tan(θ) : cos(ϕ)", "", "0", "",
         "Frhy Frh Frhx Frhz", "Frhy = √(Frh ^ 2 - Frhx ^ 2 - Frhz ^ 2)", "", "0", ""} ' Frhy => 9
      Case "Frhz" : DՃA = New String() {
         "Frhz Frh", "Frhz = Frh", "", "0", "",
         "Frhz Frh θ", "Frhz = Frh cos(θ)", "", "0", "",
         "Frhz Frhx ϕ", "Frhz = Frhx : tan(ϕ)", "", "0", "",
         "Frhz Frhy θ", "Frhz = Frhy : tan(θ)", "", "0", "",
         "Frhz Frh Frhx", "Frhz = √(Frh ^ 2 - Frhx ^ 2)", "", "0", "",
         "Frhz Frh Frhy", "Frhz = √(Frh ^ 2 - Frhy ^ 2)", "", "0", "",
         "Frhz Frhy θ ϕ", "Frhz = Frhy cos(ϕ) : tan(θ)", "", "0", "",
         "Frhz Frh θ ϕ", "Frhz = Frh cos(θ) cos(ϕ)", "", "0", "",
         "Frhz Frh Frhx Frhy", "Frhz = √(Frh ^ 2 - Frhx ^ 2 - Frhy ^ 2)", "", "0", ""} ' Frhz => 9
      Case "Frrx" : DՃA = New String() {
         "Frrx Frr", "Frrx = Frr", "", "0", "",
         "Frrx Frr θ", "Frrx = Frr cos(θ)", "", "0", "",
         "Frrx Frry θ", "Frrx = Frry : tan(θ)", "", "0", "",
         "Frrx Frrz ϕ", "Frrx = Frrz tan(ϕ)", "", "0", "",
         "Frrx Frr Frry", "Frrx = √(Frr ^ 2 - Frry ^ 2)", "", "0", "",
         "Frrx Frr Frrz", "Frrx = √(Frr ^ 2 - Frrz ^ 2)", "", "0", "",
         "Frrx Frr θ ϕ", "Frrx = Frr cos(θ) sin(ϕ)", "", "0", "",
         "Frrx Frry θ ϕ", "Frrx = Frry sin(ϕ) : tan(θ)", "", "0", "",
         "Frrx Frr Frry Frrz", "Frrx = √(Frr ^ 2 - Frry ^ 2 - Frrz ^ 2)", "", "0", ""} ' Frrx => 9
      Case "Frry" : DՃA = New String() {
         "Frry Frr", "Frry = Frr", "", "0", "",
         "Frry Frr θ", "Frry = Frr sin(θ)", "", "0", "",
         "Frry Frrx θ", "Frry = Frrx tan(θ)", "", "0", "",
         "Frry Frrz θ", "Frry = Frrz tan(θ)", "", "0", "",
         "Frry Frr Frrx", "Frry = √(Frr ^ 2 - Frrx ^ 2)", "", "0", "",
         "Frry Frr Frrz", "Frry = √(Frr ^ 2 - Frrz ^ 2)", "", "0", "",
         "Frry Frrx θ ϕ", "Frry = Frrx tan(θ) : sin(ϕ)", "", "0", "",
         "Frry Frrz θ ϕ", "Frry = Frrz tan(θ) : cos(ϕ)", "", "0", "",
         "Frry Frr Frrx Frrz", "Frry = √(Frr ^ 2 - Frrx ^ 2 - Frrz ^ 2)", "", "0", ""} ' Frry => 9
      Case "Frrz" : DՃA = New String() {
         "Frrz Frr", "Frrz = Frr", "", "0", "",
         "Frrz Frr θ", "Frrz = Frr cos(θ)", "", "0", "",
         "Frrz Frrx ϕ", "Frrz = Frrx : tan(ϕ)", "", "0", "",
         "Frrz Frry θ", "Frrz = Frry : tan(θ)", "", "0", "",
         "Frrz Frr Frrx", "Frrz = √(Frr ^ 2 - Frrx ^ 2)", "", "0", "",
         "Frrz Frr Frry", "Frrz = √(Frr ^ 2 - Frry ^ 2)", "", "0", "",
         "Frrz Frry θ ϕ", "Frrz = Frry cos(ϕ) : tan(θ)", "", "0", "",
         "Frrz Frr θ ϕ", "Frrz = Frr cos(θ) cos(ϕ)", "", "0", "",
         "Frrz Frr Frrx Frry", "Frrz = √(Frr ^ 2 - Frrx ^ 2 - Frry ^ 2)", "", "0", ""} ' Frrz => 9
      Case "{vx}" : DՃA = New String() {
         "{vx} {v}", "{vx} = {v}", "", "0", "",
         "{vx} {v} θ", "{vx} = {v} cos(θ)", "", "0", "",
         "{vx} {vy} θ", "{vx} = {vy} : tan(θ)", "", "0", "",
         "{vx} {vz} ϕ", "{vx} = {vz} tan(ϕ)", "", "0", "",
         "{vx} {v} {vy}", "{vx} = √({v} ^ 2 - {vy} ^ 2)", "", "0", "",
         "{vx} {v} {vz}", "{vx} = √({v} ^ 2 - {vz} ^ 2)", "", "0", "",
         "{vx} {v} θ ϕ", "{vx} = {v} cos(θ) sin(ϕ)", "", "0", "",
         "{vx} {vy} θ ϕ", "{vx} = {vy} sin(ϕ) : tan(θ)", "", "0", "",
         "{vx} {v} {vy} {vz}", "{vx} = √({v} ^ 2 - {vy} ^ 2 - {vz} ^ 2)", "", "0", ""} ' {vx} => 9
      Case "{vy}" : DՃA = New String() {
         "{vy} {v}", "{vy} = {v}", "", "0", "",
         "{vy} {v} θ", "{vy} = {v} sin(θ)", "", "0", "",
         "{vy} {vx} θ", "{vy} = {vx} tan(θ)", "", "0", "",
         "{vy} {vz} θ", "{vy} = {vz} tan(θ)", "", "0", "",
         "{vy} {v} {vx}", "{vy} = √({v} ^ 2 - {vx} ^ 2)", "", "0", "",
         "{vy} {v} {vz}", "{vy} = √({v} ^ 2 - {vz} ^ 2)", "", "0", "",
         "{vy} {vx} θ ϕ", "{vy} = {vx} tan(θ) : sin(ϕ)", "", "0", "",
         "{vy} {vz} θ ϕ", "{vy} = {vz} tan(θ) : cos(ϕ)", "", "0", "",
         "{vy} {v} {vx} {vz}", "{vy} = √({v} ^ 2 - {vx} ^ 2 - {vz} ^ 2)", "", "0", ""} ' {vy} => 9
      Case "{vz}" : DՃA = New String() {
         "{vz} {v}", "{vz} = {v}", "", "0", "",
         "{vz} {v} θ", "{vz} = {v} cos(θ)", "", "0", "",
         "{vz} {vx} ϕ", "{vz} = {vx} : tan(ϕ)", "", "0", "",
         "{vz} {vy} θ", "{vz} = {vy} : tan(θ)", "", "0", "",
         "{vz} {v} {vx}", "{vz} = √({v} ^ 2 - {vx} ^ 2)", "", "0", "",
         "{vz} {v} {vy}", "{vz} = √({v} ^ 2 - {vy} ^ 2)", "", "0", "",
         "{vz} {vy} θ ϕ", "{vz} = {vy} cos(ϕ) : tan(θ)", "", "0", "",
         "{vz} {v} θ ϕ", "{vz} = {v} cos(θ) cos(ϕ)", "", "0", "",
         "{vz} {v} {vx} {vy}", "{vz} = √({v} ^ 2 - {vx} ^ 2 - {vy} ^ 2)", "", "0", ""} ' {vz} => 9
    End Select

    'Formelkombinationen insgesamt:		101 005 + 726

    'EBAE("a k m P v1", "a => a ^ 4 m ^ 3 - 2 a k m P v1 + 2 k P ^ 2 = 0", "a F k P v1", 25) ' 13
    'EBAE("a k m P v1", "a => ", "a F k P v1", 25) ' 13
    'EBAE("a k m P v2", "a => a ^ 4 m ^ 3 + 2 a m k P v2 - 2 k P ^ 2 = 0", "a F k P v2", 25) ' 13
    'EBAE("a k m P v2", "a => ", "a F k P v2", 25) ' 13
    'EBAE("a m P Δs v1", "", "", 25) ' a = 3 √(P ^ 2 : m ^ 2 : Δs) (3 √ (1 + E3.1) - 3 √ (-1 + E3.1)) ' 26
    'EBAE("a m P Δs v1", "", "", 25) ' a = √(-8 P v1 : m : Δs : 3) E3.3 ' 26
    'EBAE("a m P Δs v2", "", "", 25) ' a = 3√(P ^ 2 : m ^ 2 : Δs) E4.2 ' 26
    'EBAE("a m P Δs v2", "", "", 25) ' a = √(8 P v2 : m : Δs : 3) E4.3 ' 26
    'EBAE("F a k P v1", "F => a F ^ 3 - 2 F k P v1 + 2 k P ^ 2 = 0", "F a k v1 {v}", 61) ' 13
    'EBAE("F a k P v1", "F => ", "F a k v1 {v}", 61) ' 13
    'EBAE("F a k P v2", "F => a F ^ 3 + 2 k F P v2 - 2 k P ^ 2 = 0", "F a k v2 {v}", 61) ' 13
    'EBAE("F a k P v2", "F => ", "F a k v2 {v}", 61) ' 13
    'EBAE("F k m P v1", "F => F ^ 4 - F (2 k m P v1) + 2 k m P ^ 2 = 0", "F a k P v1", 61) ' 13
    'EBAE("F k m P v1", "F => ", "F a k P v1", 61) ' 13
    'EBAE("F k m P v2", "F => F ^ 4 + F (2 k m P v2) - 2 k m P ^ 2 = 0", "F a k P v2", 61) ' 13
    'EBAE("F k m P v2", "F => ", "F a k P v2", 61) ' 13
    'EBAE("F m P Δs v1", "F = 3√(P ^ 2 m : Δs) (3√(1 + E3.1) - 3√(-1 + E3.1))", "F m P v1 W", 28) ' 26
    'EBAE("F m P Δs v1", "F = √(-8 m P v1 : Δs : 3) E3.3", "F m P v1 W", 28) ' 26
    'EBAE("F m P Δs v2", "F = 3√(m P ^ 2 : Δs) E4.2", "F m P v2 W", 28) ' 26
    'EBAE("F m P Δs v2", "F = √(8 m P v2 : Δs : 3) E4.3", "F m P v2 W", 28) ' 26
    'EBAE("k m P Δs v1", "k = 3 √(P ^ 2 m : Δs ^ 4) (3 √(-1 + E3.1) - 3√(1 + E3.1))", "k F m P v1", 56) ' 
    'EBAE("k m P Δs v1", "k = -√(-8 m P v1 : Δs ^ 3 : 3) E3.3", "k F m P v1", 56) ' 
    'EBAE("k m P Δs v2", "k = -(3 √(m P ^ 2 : Δs ^ 4)) E4.2", "k m P Δs v2", 56) ' 
    'EBAE("k m P Δs v2", "k = -√(8 m P v2 : Δs ^ 3 : 3) E4.3", "k m P Δs v2", 56) ' 
    'EBAE("m a k P v1 1", "m => a ^ 4 m ^ 3 - 2 a k m P v1 + 2 k P ^ 2 = 0", "m F k P v1", 25) ' 13
    'EBAE("m a k P v1 2", "m => ", "m F k P v1", 25) ' 13
    'EBAE("m a k P v2 1", "m => a ^ 4 m ^ 3 + 2 a m k P v2 - 2 k P ^ 2 = 0", "m F k P v2", 25) ' 13
    'EBAE("m a k P v2 2", "m => ", "m F k P v2", 25) ' 13
    'EBAE("μg |Fn| m P Δs v1 1", "μg = 3√(P ^ 2 m : Δs) (3√(1 + E3.1) - 3√(-1 + E3.1)) : |Fn|", "μg |Fn| m P v1 W", 93) ' 26
    'EBAE("μg |Fn| m P Δs v1 2", "μg = √(-8 m P v1 : 3 : Δs) E3.3 : |Fn|", "μg |Fn| m P v1 W", 93) ' 26
    'EBAE("μg |Fn| m P Δs v2 1", "μg = 3√(m P ^ 2 : Δs) E4.2 : |Fn|", "μg |Fn| m P v2 W", 93) ' 26
    'EBAE("μg |Fn| m P Δs v2 2", "μg = √(8 m P v2 : 3 : Δs) E4.3 : |Fn|", "μg |Fn| m P v2 W", 93) ' 26
    'EBAE("μh |Fn| m P Δs v1 1", "μh = 3√(P ^ 2 m : Δs) (3√(1 + E3.1) - 3√(-1 + E3.1)) : |Fn|", "μh |Fn| m P v1 W", 97) ' 26
    'EBAE("μh |Fn| m P Δs v1 2", "μh = √(-8 m P v1 : 3 : Δs) E3.3 : |Fn|", "μh |Fn| m P v1 W", 97) ' 26
    'EBAE("μh |Fn| m P Δs v2 1", "μh = 3√(m P ^ 2 : Δs) E4.2 : |Fn|", "μh |Fn| m P v2 W", 97) ' 26
    'EBAE("μh |Fn| m P Δs v2 2", "μh = √(8 m P v2 : 3 : Δs) E4.3 : |Fn|", "μh |Fn| m P v2 W", 97) ' 26
    'EBAE("μr |Fn| m P Δs v1 1", "μr = 3√(P ^ 2 m : Δs) (3√(1 + E3.1) - 3√(-1 + E3.1)) : |Fn|", "μr |Fn| m P v1 W", 101) ' 26
    'EBAE("μr |Fn| m P Δs v1 2", "μr = √(-8 m P v1 : 3 : Δs) E3.3 : |Fn|", "μr |Fn| m P v1 W", 101) ' 26
    'EBAE("μr |Fn| m P Δs v2 1", "μr = 3√(m P ^ 2 : Δs) E4.2 : |Fn|", "μr |Fn| m P v2 W", 101) ' 26
    'EBAE("μr |Fn| m P Δs v2 2", "μr = √(8 m P v2 : 3 : Δs) E4.3 : |Fn|", "μr |Fn| m P v2 W", 101) ' 26
    'EBAE("P a k v1 W 1", "P => P ^ 4 : k + P ^ 2 v1 ^ 2 W + a P v1 W ^ 2 + a ^ 2 W ^ 3 : 4 = 0", "P a k Δt v1", 42) ' 65
    'EBAE("P a k v1 W 2", "P => ", "P a k Δt v1", 42) ' 65
    'EBAE("P a k v2 W 1", "P => P ^ 4 : k + (P v2) ^ 2 W - a P v2 W ^ 2 + a ^ 2 W ^ 3 : 4 = 0", "P a k Δt v2", 42) ' 65
    'EBAE("P a k v2 W 2", "P => ", "", 42) ' 65
    'EBAE("Δs a k P v1 1", "a k Δs ^ 3 : P : 2 - Δs v1 - P : k = 0", "Δs a F P v1", 1) ' 26
    'EBAE("Δs a k P v1 2", "a k Δs ^ 3 : P : 2 - Δs v1 - P : k = 0", "Δs a F P v1", 1) ' 26
    'EBAE("Δs a k P v2 1", "a k Δs ^ 3 : P : 2 + Δs v2 + P : k = 0", "Δs a F P v2", 1) ' 26
    'EBAE("Δs a k P v2 2", "a k Δs ^ 3 : P : 2 + Δs v2 + P : k = 0", "Δs a F P v2", 1) ' 26
    'EBAE("Δt a k P v1 1", "a ^ 2 Δt ^ 3 : 4 + a Δt ^ 2 v1 + Δt v1 ^ 2 = -P : k", "Δt k P v1 Δv", 23) ' 26
    'EBAE("Δt a k P v1 2", "a ^ 2 Δt ^ 3 : 4 + a Δt ^ 2 v1 + Δt v1 ^ 2 = -P : k", "Δt k P v1 Δv", 23) ' 26
    'EBAE("Δt a k P v2 1", "a ^ 2 Δt ^ 3 : 4 - a Δt ^ 2 v2 + Δt v2 ^ 2 = -P : k", "Δt k P v2 Δv", 23) ' 26
    'EBAE("Δt a k P v2 2", "a ^ 2 Δt ^ 3 : 4 - a Δt ^ 2 v2 + Δt v2 ^ 2 = -P : k", "Δt k P v2 Δv", 23) ' 26
    'EBAE("Δt k m P v1 1", "Δt ^ 4 (k : m : 2) ^ 2 + Δt ^ 2 k : m + Δt k v1 ^ 2 : P + 1 = 0", "Δt k m v1 W", 43) ' 26
    'EBAE("Δt k m P v1 2", "Δt ^ 4 (k : m : 2) ^ 2 + Δt ^ 2 k : m + Δt k v1 ^ 2 : P + 1 = 0", "Δt k m v1 W", 43) ' 26
    'EBAE("Δt k m P v2 1", "Δt ^ 4 (k : m : 2) ^ 2 - Δt ^ 2 k : m + Δt k v2 ^ 2 : P + 1 = 0", "Δt k m v2 W", 43) ' 26
    'EBAE("Δt k m P v2 2", "Δt ^ 4 (k : m : 2) ^ 2 - Δt ^ 2 k : m + Δt k v2 ^ 2 : P + 1 = 0", "Δt k m v2 W", 43) ' 26
    'EBAE("Δt m P Δs v1", "Δt = 3√(m Δs^2 : P) (3√(1 + E3.1) - 3√(-1 + E3.1))", "Δt m P v1 {v}", 19) ' 52
    'EBAE("Δt m P Δs v1", "Δt = √(-8 m Δs v1 : (3 P)) E3.3", "Δt m P v1 {v}", 19) ' 52
    'EBAE("Δt m P Δs v2", "Δt = 3√(m Δs ^ 2 : P) E4.2", "Δt m P v2 {v}", 19) ' 52
    'EBAE("Δt m P Δs v2", "Δt = Δt = √(8 m Δs v2 : (3 P)) E4.3", "Δt m P v2 {v}", 19) ' 52
    'EBAE("v1 a k P v2 1", "v1 ^ 3 + v1 ^ 2 v2 - v1 v2 ^ 2 - v2 ^ 3 - 4 a P : k = 0", "v1 a k P {v}", 9) ' 13
    'EBAE("v1 a k P v2 2", "v1 ^ 3 + v1 ^ 2 v2 - v1 v2 ^ 2 - v2 ^ 3 - 4 a P : k = 0", "v1 a k P {v}", 9) ' 13
    'EBAE("v1 k m P v2 1", "v1 ^ 4 + 2 v1 ^ 3 v2 - 2 v2 ^ 3 v1 - v2 ^ 4 - 8 P ^ 2 : k : m = 0", "v1 k P v2 W", 80) ' 13
    'EBAE("v1 k m P v2 2", "v1 ^ 4 + 2 v1 ^ 3 v2 - 2 v2 ^ 3 v1 - v2 ^ 4 - 8 P ^ 2 : k : m = 0", "v1 k P v2 W", 80) ' 13
    'EBAE("v1 m P Δs v2", "v1 = 3√(E1.1 + √ E1.2) - 3√(-E1.1 + √ E1.2) - v2 : 3", "v1 m P Δs {v}", 9) ' 26
    'EBAE("v1 m P Δs v2", "v1 = √(16 v2 ^ 2 : 9) E1.3 - v2 : 3", "v1 m P Δs {v}", 9) ' 26
    'EBAE("v2 a k P v1 1", "v2 ^ 3 + v1 v2 ^ 2 - v1 ^ 2 v2 - v1 ^ 3 + 4 a P : k = 0", "v2 a k P {v}", 9) ' 13
    'EBAE("v2 a k P v1 2", "v2 ^ 3 + v1 v2 ^ 2 - v1 ^ 2 v2 - v1 ^ 3 + 4 a P : k = 0", "v2 a k P {v}", 9) ' 13
    'EBAE("v2 k m P v1 1", "v2 ^ 4 + 2 v2 ^ 3 v1 - 2 v1 ^ 3 v2 - v1 ^ 4 + 8 P ^ 2 : k : m = 0", "v2 k P v1 W", 80) ' 13
    'EBAE("v2 k m P v1 2", "v2 ^ 4 + 2 v2 ^ 3 v1 - 2 v1 ^ 3 v2 - v1 ^ 4 + 8 P ^ 2 : k : m = 0", "v2 k P v1 W", 80) ' 13
    'EBAE("v2 m P Δs v1", "v2 = 3√(E2.1 + √ E2.2) - 3√(-E2.1 + √ E2.2) - v1 : 3", "v2 m P Δs {v}", 9) ' 26
    'EBAE("v2 m P Δs v1", "v2 = √(16 v1 ^ 2 : 9) E2.3 - v1 : 3", "v2 m P Δs {v}", 9) ' 26
    'EBAE("Δv a k P v1 1", "Δv ^ 3 : 4 + v1 Δv ^ 2 + Δv v1 ^ 2 + a P : k = 0", "Δv a k P {v}", 17) ' 13
    'EBAE("Δv a k P v1 2", "Δv ^ 3 : 4 + v1 Δv ^ 2 + Δv v1 ^ 2 + a P : k = 0", "Δv a k P {v}", 17) ' 13
    'EBAE("Δv a k P v2 1", "Δv ^ 3 : 4 - v2 Δv ^ 2 + Δv v2 ^ 2 + a P : k = 0", "Δv a k P {v}", 14) ' 13
    'EBAE("Δv a k P v2 2", "Δv ^ 3 : 4 - v2 Δv ^ 2 + Δv v2 ^ 2 + a P : k = 0", "Δv a k P {v}", 14) ' 13
    'EBAE("Δv k m P v1 1", "Δv ^ 4 + 6 Δv ^ 3 v1 + 12 Δv ^ 2 v1 ^ 2 + 8 Δv v1 ^ 3 + 8 P ^ 2 : k : m = 0", "Δv k m P {v}", 17) ' 13
    'EBAE("Δv k m P v1 2", "Δv ^ 4 + 6 Δv ^ 3 v1 + 12 Δv ^ 2 v1 ^ 2 + 8 Δv v1 ^ 3 + 8 P ^ 2 : k : m = 0", "Δv k m P {v}", 17) ' 13
    'EBAE("Δv k m P v2 1", "Δv ^ 4 - 6 Δv ^ 3 v2 + 12 Δv ^ 2 v2 ^ 2 - 8 Δv v2 ^ 3 - 8 P ^ 2 : k : m = 0", "Δv k m P {v}", 14) ' 13
    'EBAE("Δv k m P v2 2", "Δv ^ 4 - 6 Δv ^ 3 v2 + 12 Δv ^ 2 v2 ^ 2 - 8 Δv v2 ^ 3 - 8 P ^ 2 : k : m = 0", "Δv k m P {v}", 14) ' 13
    'EBAE("Δv m P Δs v1", "Δv = 3√(E2.1 + √ E2.2) - 3√(-E2.1 + √ E2.2) - 4 v1 : 3", "Δv m P Δs {v}", 17) ' 26
    'EBAE("Δv m P Δs v1", "Δv = √(16 v1 ^ 2 : 9) E2.3 - 4 v1 : 3", "Δv m P Δs {v}", 17) ' 26
    'EBAE("Δv m P Δs v2", "Δv = 4 v2 : 3 + 3√(-E1.1 + √ E1.2) - 3√(E1.1 + √ E1.2)", "Δv m P Δs {v}", 14) ' 26
    'EBAE("Δv m P Δs v2", "Δv = 4 v2 : 3 - √(16 v2 ^ 2 : 9) E1.3", "Δv m P Δs {v}", 14) ' 26
    'EBAE("{v} a k P v1 1", "{v} ^ 3 - v1 {v} ^ 2 + a P : k : 2 = 0", "{v} a k P Δv", 15) ' 13
    'EBAE("{v} a k P v1 2", "{v} ^ 3 - v1 {v} ^ 2 + a P : k : 2 = 0", "{v} a k P Δv", 15) ' 13
    'EBAE("{v} a k P v2 1", "{v} ^ 3 - v2 {v} ^ 2 - a P : k : 2 = 0", "{v} a k P Δv", 12) ' 13
    'EBAE("{v} a k P v2 2", "{v} ^ 3 - v2 {v} ^ 2 - a P : k : 2 = 0", "{v} a k P Δv", 12) ' 13
    'EBAE("{v} k m P v1 1", "{v} ^ 4 - v1 {v} ^ 3 + P ^ 2 : k : m : 2 = 0", "{v} k m P Δv", 15) ' 13
    'EBAE("{v} k m P v1 2", "{v} ^ 4 - v1 {v} ^ 3 + P ^ 2 : k : m : 2 = 0", "{v} k m P Δv", 15) ' 13
    'EBAE("{v} k m P v2 1", "{v} ^ 4 - {v} ^ 3 v2 - P ^ 2 : k : m : 2", "{v} k m P Δv", 12) ' 13
    'EBAE("{v} k m P v2 2", "{v} ^ 4 - {v} ^ 3 v2 - P ^ 2 : k : m : 2", "{v} k m P Δv", 12) ' 13
    'EBAE("{v} m P Δs v1", "{v} = (3 √(E2.1 + √ E2.2) - 3 √(-E2.1 + √ E2.2) + 2 v1 : 3) : 2", "{v} m P Δs Δv", 15) ' 26
    'EBAE("{v} m P Δs v1", "{v} = √(16 v1 ^ 2 : 36) E2.3 + v1 : 3", "{v} m P Δs Δv", 15) ' 26
    'EBAE("{v} m P Δs v2", "{v} = (3 √(E1.1 + √ E1.2) - 3 √(-E1.1 + √ E1.2) + 2 v2 : 3) : 2", "{v} m P Δs Δv", 12) ' 26
    'EBAE("{v} m P Δs v2", "{v} = √(16 v2 ^ 2 : 36) E1.3 + v2 : 3", "{v} m P Δs Δv", 12) ' 26
    'EBAE("W a k P v1 1", "a ^ 2 W ^ 3 : 4 + a P v1 W ^ 2 + (P v1) ^ 2 W + P ^ 4 : k = 0", "W a k Δt v1", 42) ' 65
    'EBAE("W a k P v1 2", "a ^ 2 W ^ 3 : 4 + a P v1 W ^ 2 + (P v1) ^ 2 W + P ^ 4 : k = 0", "W a k Δt v1", 42) ' 65
    'EBAE("W a k P v2 1", "a ^ 2 W ^ 3 : 4 - a P v2 W ^ 2 + (P v2) ^ 2 W + P ^ 4 : k = 0", "W a k Δt v2", 42) ' 65
    'EBAE("W a k P v2 2", "a ^ 2 W ^ 3 : 4 - a P v2 W ^ 2 + (P v2) ^ 2 W + P ^ 4 : k = 0", "W a k Δt v2", 42) ' 65
    'EBAE("W k m P v1 1", "W ^ 4 k : (2 m P) ^ 2 + W ^ 2 : m + v1 ^ 2 W + P ^ 2 : k = 0", "W k m Δt v1", 42) ' 65
    'EBAE("W k m P v1 2", "W ^ 4 k : (2 m P) ^ 2 + W ^ 2 : m + v1 ^ 2 W + P ^ 2 : k = 0", "W k m Δt v1", 42) ' 65
    'EBAE("W k m P v2 1", "W ^ 4 k : (2 m P) ^ 2 - W ^ 2 : m + v2 ^ 2 W + P ^ 2 : k = 0", "W k m Δt v2", 42) ' 65
    'EBAE("W k m P v2 2", "W ^ 4 k : (2 m P) ^ 2 - W ^ 2 : m + v2 ^ 2 W + P ^ 2 : k = 0", "W k m Δt v2", 42) ' 65
    'EBAE("W m P Δs v1", "W = 3√(m (P Δs) ^ 2) (3√(1 + E3.1) - 3√(-1 + E3.1))", "W F m P v1", 29) ' 130
    'EBAE("W m P Δs v1", "W = √(-8 m P Δs v1 : 3) E3.3", "W F m P v1", 29) ' 130
    'EBAE("W m P Δs v2", "W = 3√(m (P Δs) ^ 2) E4.2", "W F m P v2", 29) ' 130
    'EBAE("W m P Δs v2", "W = √(8 m P Δs v2 : 3) E4.3", "W F m P v2", 29) ' 130

    '2     Für Vorschläge, Formeln und Formelnquelle
    'If FAA.Count > 1 Then
    '  For i = 0 To DՃA.Count - 5 Step 5
    '    If CD = DՃA(i) Then C002.Text = DՃA(i + 1) : CH = DՃA(i + 4)
    '  Next
    'End If

    '"s1 sx1 sy1 sz1 s2 sx2 sy2 sz2", "s1 = s2 - √((sx2 - sx1) ^ 2 + (sy2 - sy1) ^ 2 + (sz2 - sz1) ^ 2)", "", "110",
    '"s1 sx1 sy1 s2 sx2 sy2", "s1 = s2 - √((sx2 - sx1) ^ 2 + (sy2 - sy1) ^ 2)", "", "110",
    '"s1 sx1 sy1 s2 sx2 sy2 Δsz", "s1 = s2 - √((sx2 - sx1) ^ 2 + (sy2 - sy1) ^ 2 + Δsz ^ 2)", "", "110",
    '"s1 sx1 sz1 s2 sx2 sz2", "s1 = s2 - √((sx2 - sx1) ^ 2 + (sz2 - sz1) ^ 2)", "", "110",
    '"s1 sx1 sz1 s2 sx2 sz2 Δsy", "s1 = s2 - √((sx2 - sx1) ^ 2 + Δsy ^ 2 + (sz2 - sz1) ^ 2)", "", "110",
    '"s1 sx1 s2 sx2", "s1 = s2 + sx1 - sx2", "", "110",
    '"s1 sx1 s2 sx2 Δsy", "s1 = s2 - √((sx2 - sx1) ^ 2 + Δsy ^ 2)", "", "110",
    '"s1 sx1 s2 sx2 Δsy Δsz", "s1 = s2 - √((sx2 - sx1) ^ 2 + Δsy ^ 2 + Δsz ^ 2)", "", "110",
    '"s1 sx1 s2 sx2 Δsz", "s1 = s2 - √((sx2 - sx1) ^ 2 + Δsz ^ 2)", "", "110",
    '"s1 sx1 s2 sx2 θ", "s1 = s2 - (sx2 - sx1) : cos(θ)", "", "110",
    '"s1 sy1 sz1 s2 sy2 sz2", "s1 = s2 - √((sy2 - sy1) ^ 2 + (sz2 - sz1) ^ 2)", "", "110",
    '"s1 sy1 sz1 s2 sy2 sz2 Δsx", "s1 = s2 - √(Δsx ^ 2 + (sy2 - sy1) ^ 2 + (sz2 - sz1) ^ 2)", "", "110",
    '"s1 sy1 s2 sy2", "s1 = s2 + sy1 - sy2", "", "110",
    '"s1 sy1 s2 sy2 Δsx", "s1 = s2 - √(Δsx ^ 2 + (sy2 - sy1) ^ 2)", "", "110",
    '"s1 sy1 s2 sy2 Δsx Δsz", "s1 = s2 - √(Δsx ^ 2 + (sy2 - sy1) ^ 2 + Δsz ^ 2)", "", "110",
    '"s1 sy1 s2 sy2 Δsz", "s1 = s2 - √((sy2 - sy1) ^ 2 + Δsz ^ 2)", "", "110",
    '"s1 sy1 s2 sy2 θ", "s1 = s2 - (sy2 - sy1) : sin(θ)", "", "110",
    '"s1 sz1 s2 sz2", "s1 = s2 + sz1 - sz2", "", "110",
    '"s1 sz1 s2 sz2 Δsx", "s1 = s2 - √(Δsx ^ 2 + (sz2 - sz1) ^ 2)", "", "110",
    '"s1 sz1 s2 sz2 Δsx Δsy", "s1 = s2 - √(Δsx ^ 2 + Δsy ^ 2 + (sz2 - sz1) ^ 2)", "", "110",
    '"s1 sz1 s2 sz2 Δsy", "s1 = s2 - √(Δsy ^ 2 + (sz2 - sz1) ^ 2)", "", "110",
    '"s1 sz1 s2 sz2 θ", "s1 = s2 - (sz2 - sz1) : cos(θ)", "", "110",
    '"s1 sz1 s2 sz2 θ ϕ", "s1 = s2 - (sz2 - sz1) : cos(θ) : cos(ϕ)", "", "110",
    '"s1 s2 sx1 sx2 θ ϕ", "s1 = s2 - (sx2 - sx1) : cos(θ) : sin(ϕ)", "", "110",
    '"s1 s2 Δsx", "s1 = s2 - Δsx", "", "110",
    '"s1 s2 Δsx Δsy", "s1 = s2 - √(Δsx ^ 2 + Δsy ^ 2)", "", "110",
    '"s1 s2 Δsx Δsy Δsz", "s1 = s2 - √(Δsx ^ 2 + Δsy ^ 2 + Δsz ^ 2)", "", "110",
    '"s1 s2 Δsx Δsz", "s1 = s2 - √(Δsx ^ 2 + Δsz ^ 2)", "", "110",
    '"s1 s2 Δsx θ", "s1 = s2 - Δsx : cos(θ)", "", "110",
    '"s1 s2 Δsx θ ϕ", "s1 = s2 - Δsx : cos(θ) : sin(ϕ)", "", "110",
    '"s1 s2 Δsy", "s1 = s2 - Δsy", "", "110",
    '"s1 s2 Δsy Δsz", "s1 = s2 - √(Δsy ^ 2 + Δsz ^ 2)", "", "110",
    '"s1 s2 Δsy θ", "s1 = s2 - Δsy : sin(θ)", "", "110",
    '"s1 s2 Δsz", "s1 = s2 - Δsz", "", "110",
    '"s1 s2 Δsz θ", "s1 = s2 - Δsz : cos(θ)", "", "110",
    '"s1 s2 Δsz θ ϕ", "s1 = s2 - Δsz : cos(θ) : cos(ϕ)", "", "110",

    '"sx1 s1 sy1 sz1 s2 sx2 sy2 sz2", "sx1 = sx2 - √((s2 - s1) ^ 2 - (sy2 - sy1) ^ 2 - (sz2 - sz1) ^ 2)", "", "110",
    '"sx1 s1 sy1 s2 sx2 sy2", "sx1 = sx2 - √((s2 - s1) ^ 2 - (sy2 - sy1) ^ 2)", "", "110",
    '"sx1 s1 sy1 s2 sx2 sy2 Δsz", "sx1 = sx2 - √((s2 - s1) ^ 2 - (sy2 - sy1) ^ 2 - Δsz ^ 2)", "", "110",
    '"sx1 s1 sz1 s2 sx2 sz2", "sx1 = sx2 - √((s2 - s1) ^ 2 - (sz2 - sz1) ^ 2)", "", "110",
    '"sx1 s1 sz1 s2 sx2 sz2 Δsy", "sx1 = sx2 - √((s2 - s1) ^ 2 - Δsy ^ 2 - (sz2 - sz1) ^ 2)", "", "110",
    '"sx1 s1 s2 sx2", "sx1 = sx2 + s1 - s2", "", "110",
    '"sx1 s1 s2 sx2 Δsy", "sx1 = sx2 - √((s2 - s1) ^ 2 - Δsy ^ 2)", "", "110",
    '"sx1 s1 s2 sx2 Δsy Δsz", "sx1 = sx2 - √((s2 - s1) ^ 2 - Δsy ^ 2 - Δsz ^ 2)", "", "110",
    '"sx1 s1 s2 sx2 Δsz", "sx1 = sx2 - √((s2 - s1) ^ 2 - Δsz ^ 2)", "", "110",
    '"sx1 s1 s2 sx2 θ", "sx1 = sx2 - (s2 - s1) cos(θ)", "", "110",
    '"sx1 s1 s2 sx2 θ ϕ", "sx1 = sx2 - (s2 - s1) cos(θ) sin(ϕ)", "", "110",
    '"sx1 sy1 sz1 sx2 sy2 sz2 Δs", "sx1 = sx2 - √(Δs ^ 2 - (sy2 - sy1) ^ 2 - (sz2 - sz1) ^ 2)", "", "110",
    '"sx1 sy1 sx2 sy2 Δs", "sx1 = sx2 - √(Δs ^ 2 - (sy2 - sy1) ^ 2)", "", "110",
    '"sx1 sy1 sx2 sy2 Δs Δsz", "sx1 = sx2 - √(Δs ^ 2 - (sy2 - sy1) ^ 2 - Δsz ^ 2)", "", "110",
    '"sx1 sy1 sx2 sy2 θ", "sx1 = sx2 - (sy2 - sy1) : tan(θ)", "", "110",
    '"sx1 sy1 sx2 sy2 θ ϕ", "sx1 = sx2 - (sy2 - sy1) sin(ϕ) : tan(θ)", "", "110",
    '"sx1 sz1 sx2 sz2 Δs", "sx1 = sx2 - √(Δs ^ 2 - (sz2 - sz1) ^ 2)", "", "110",
    '"sx1 sz1 sx2 sz2 Δs Δsy", "sx1 = sx2 - √(Δs ^ 2 - Δsy ^ 2 - (sz2 - sz1) ^ 2)", "", "110",
    '"sx1 sz1 sx2 sz2 ϕ", "sx1 = sx2 - (sz2 - sz1) tan(ϕ)", "", "110",
    '"sx1 sx2 Δs", "sx1 = sx2 - Δs", "", "110",
    '"sx1 sx2 Δs Δsy", "sx1 = sx2 - √(Δs ^ 2 - Δsy ^ 2)", "", "110",
    '"sx1 sx2 Δs Δsy Δsz", "sx1 = sx2 - √(Δs ^ 2 - Δsy ^ 2 - Δsz ^ 2)", "", "110",
    '"sx1 sx2 Δs Δsz", "sx1 = sx2 - √(Δs ^ 2 - Δsz ^ 2)", "", "110",
    '"sx1 sx2 Δs θ", "sx1 = sx2 - Δs cos(θ)", "", "110",
    '"sx1 sx2 Δs θ ϕ", "sx1 = sx2 - Δs cos(θ) sin(ϕ)", "", "110",
    '"sx1 sx2 Δsy θ", "sx1 = sx2 - Δsy : tan(θ)", "", "110",
    '"sx1 sx2 Δsy θ ϕ", "sx1 = sx2 - Δsy sin(ϕ) : tan(θ)", "", "110",
    '"sx1 sx2 Δsz ϕ", "sx1 = sx2 - Δsz tan(ϕ)", "", "110",

    '"sy1 s1 sx1 sz1 s2 sx2 sy2 sz2", "sy1 = sy2 - √((s2 - s1) ^ 2 - (sx2 - sx1) ^ 2 - (sz2 - sz1) ^ 2)", "", "110",
    '"sy1 s1 sx1 s2 sx2 sy2", "sy1 = sy2 - √((s2 - s1) ^ 2 - (sx2 - sx1) ^ 2)", "", "110",
    '"sy1 s1 sx1 s2 sx2 sy2 Δsz", "sy1 = sy2 - √((s2 - s1) ^ 2 - (sx2 - sx1) ^ 2 - Δsz ^ 2)", "", "110",
    '"sy1 s1 sz1 s2 sy2 sz2", "sy1 = sy2 - √((s2 - s1) ^ 2 - (sz2 - sz1) ^ 2)", "", "110",
    '"sy1 s1 sz1 s2 sy2 sz2 Δsx", "sy1 = sy2 - √((s2 - s1) ^ 2 - Δsx ^ 2 - (sz2 - sz1) ^ 2)", "", "110",
    '"sy1 s1 s2 sy2", "sy1 = sy2 + s1 - s2", "", "110",
    '"sy1 s1 s2 sy2 Δsx", "sy1 = sy2 - √((s2 - s1) ^ 2 - Δsx ^ 2)", "", "110",
    '"sy1 s1 s2 sy2 Δsx Δsz", "sy1 = sy2 - √((s2 - s1) ^ 2 - Δsx ^ 2 - Δsz ^ 2)", "", "110",
    '"sy1 s1 s2 sy2 Δsz", "sy1 = sy2 - √((s2 - s1) ^ 2 - Δsz ^ 2)", "", "110",
    '"sy1 s1 s2 sy2 θ", "sy1 = sy2 - (s2 - s1) sin(θ)", "", "110",
    '"sy1 sx1 sz1 sx2 sy2 sz2 Δs", "sy1 = sy2 - √(Δs ^ 2 - (sx2 - sx1) ^ 2 - (sz2 - sz1) ^ 2)", "", "110",
    '"sy1 sx1 sx2 sy2 Δs", "sy1 = sy2 - √(Δs ^ 2 - (sx2 - sx1) ^ 2)", "", "110",
    '"sy1 sx1 sx2 sy2 Δs Δsz", "sy1 = sy2 - √(Δs ^ 2 - (sx2 - sx1) ^ 2 - Δsz ^ 2)", "", "110",
    '"sy1 sx1 sx2 sy2 θ", "sy1 = sy2 - (sx2 - sx1) tan(θ)", "", "110",
    '"sy1 sx1 sx2 sy2 θ ϕ", "sy1 = sy2 - (sx2 - sx1) tan(θ) : sin(ϕ)", "", "110",
    '"sy1 sz1 sy2 sz2 Δs", "sy1 = sy2 - √(Δs ^ 2 - (sz2 - sz1) ^ 2)", "", "110",
    '"sy1 sz1 sy2 sz2 Δs Δsx", "sy1 = sy2 - √(Δs ^ 2 - Δsx ^ 2 - (sz2 - sz1) ^ 2)", "", "110",
    '"sy1 sz1 sy2 sz2 θ", "sy1 = sy2 - (sz2 - sz1) tan(θ)", "", "110",
    '"sy1 sz1 sy2 sz2 θ ϕ", "sy1 = sy2 - (sz2 - sz1) tan(θ) : cos(ϕ)", "", "110",
    '"sy1 sy2 Δs", "sy1 = sy2 - Δs", "", "110",
    '"sy1 sy2 Δs Δsx", "sy1 = sy2 - √(Δs ^ 2 - Δsx ^ 2)", "", "110",
    '"sy1 sy2 Δs Δsx Δsz", "sy1 = sy2 - √(Δs ^ 2 - Δsx ^ 2 - Δsz ^ 2)", "", "110",
    '"sy1 sy2 Δs Δsz", "sy1 = sy2 - √(Δs ^ 2 - Δsz ^ 2)", "", "110",
    '"sy1 sy2 Δs θ", "sy1 = sy2 - Δs sin(θ)", "", "110",
    '"sy1 sy2 Δsx θ", "sy1 = sy2 - Δsx tan(θ)", "", "110",
    '"sy1 sy2 Δsx θ ϕ", "sy1 = sy2 - Δsx tan(θ) : sin(ϕ)", "", "110",
    '"sy1 sy2 Δsz θ", "sy1 = sy2 - Δsz tan(θ)", "", "110",
    '"sy1 sy2 Δsz θ ϕ", "sy1 = sy2 - Δsz tan(θ) : cos(ϕ)", "", "110",

    '"sz1 s1 sx1 sy1 s2 sx2 sy2 sz2", "sz1 = sz2 - √((s2 - s1) ^ 2 - (sx2 - sx1) ^ 2 - (sy2 - sy1) ^ 2)", "", "110",
    '"sz1 s1 sx1 s2 sx2 sz2", "sz1 = sz2 - √((s2 - s1) ^ 2 - (sx2 - sx1) ^ 2)", "", "110",
    '"sz1 s1 sx1 s2 sx2 sz2 Δsy", "sz1 = sz2 - √((s2 - s1) ^ 2 - (sx2 - sx1) ^ 2 - Δsy ^ 2)", "", "110",
    '"sz1 s1 sy1 s2 sy2 sz2", "sz1 = sz2 - √((s2 - s1) ^ 2 - (sy2 - sy1) ^ 2)", "", "110",
    '"sz1 s1 sy1 s2 sy2 sz2 Δsx", "sz1 = sz2 - √((s2 - s1) ^ 2 - Δsx ^ 2 - (sy2 - sy1) ^ 2)", "", "110",
    '"sz1 s1 s2 sz2", "sz1 = sz2 + s1 - s2", "", "110",
    '"sz1 s1 s2 sz2 Δsx", "sz1 = sz2 - √((s2 - s1) ^ 2 - Δsx ^ 2)", "", "110",
    '"sz1 s1 s2 sz2 Δsx Δsy", "sz1 = sz2 - √((s2 - s1) ^ 2 - Δsx ^ 2 - Δsy ^ 2)", "", "110",
    '"sz1 s1 s2 sz2 Δsy", "sz1 = sz2 - √((s2 - s1) ^ 2 - Δsy ^ 2)", "", "110",
    '"sz1 s1 s2 sz2 θ", "sz1 = sz2 - (s2 - s1) cos(θ)", "", "110",
    '"sz1 s1 s2 sz2 θ ϕ", "sz1 = sz2 - (s2 - s1) cos(θ) cos(ϕ)", "", "110",
    '"sz1 sx1 sy1 sx2 sy2 sz2 Δs", "sz1 = sz2 - √(Δs ^ 2 - (sx2 - sx1) ^ 2 - (sy2 - sy1) ^ 2)", "", "110",
    '"sz1 sx1 sx2 sz2 Δs", "sz1 = sz2 - √(Δs ^ 2 - (sx2 - sx1) ^ 2)", "", "110",
    '"sz1 sx1 sx2 sz2 Δs Δsy", "sz1 = sz2 - √(Δs ^ 2 - (sx2 - sx1) ^ 2 - Δsy ^ 2)", "", "110",
    '"sz1 sx1 sx2 sz2 ϕ", "sz1 = sz2 - (sx2 - sx1) : tan(ϕ)", "", "110",
    '"sz1 sy1 sy2 sz2 Δs", "sz1 = sz2 - √(Δs ^ 2 - (sy2 - sy1) ^ 2)", "", "110",
    '"sz1 sy1 sy2 sz2 Δs Δsx", "sz1 = sz2 - √(Δs ^ 2 - Δsx ^ 2 - (sy2 - sy1) ^ 2)", "", "110",
    '"sz1 sy1 sy2 sz2 θ", "sz1 = sz2 - (sy2 - sy1) : tan(θ)", "", "110",
    '"sz1 sy1 sy2 sz2 θ ϕ", "sz1 = sz2 - (sy2 - sy1) cos(ϕ) : tan(θ)", "", "110",
    '"sz1 sz2 Δs", "sz1 = sz2 - Δs", "", "110",
    '"sz1 sz2 Δs Δsx", "sz1 = sz2 - √(Δs ^ 2 - Δsx ^ 2)", "", "110",
    '"sz1 sz2 Δs Δsx Δsy", "sz1 = sz2 - √(Δs ^ 2 - Δsx ^ 2 - Δsy ^ 2)", "", "110",
    '"sz1 sz2 Δs Δsy", "sz1 = sz2 - √(Δs ^ 2 - Δsy ^ 2)", "", "110",
    '"sz1 sz2 Δs θ", "sz1 = sz2 - Δs cos(θ)", "", "110",
    '"sz1 sz2 Δs θ ϕ", "sz1 = sz2 - Δs cos(θ) cos(ϕ)", "", "110",
    '"sz1 sz2 Δsx ϕ", "sz1 = sz2 - Δsx : tan(ϕ)", "", "110",
    '"sz1 sz2 Δsy θ", "sz1 = sz2 - Δsy : tan(θ)", "", "110",
    '"sz1 sz2 Δsy θ ϕ", "sz1 = sz2 - Δsy cos(ϕ) : tan(θ)", "", "110",

    '"s2 s1 sx1 sy1 sz1 sx2 sy2 sz2", "s2 = s1 + √((sx2 - sx1) ^ 2 + (sy2 - sy1) ^ 2 + (sz2 - sz1) ^ 2)", "", "110",
    '"s2 s1 sx1 sy1 sx2 sy2", "s2 = s1 + √((sx2 - sx1) ^ 2 + (sy2 - sy1) ^ 2)", "", "110",
    '"s2 s1 sx1 sy1 sx2 sy2 Δsz", "s2 = s1 + √((sx2 - sx1) ^ 2 + (sy2 - sy1) ^ 2 + Δsz ^ 2)", "", "110",
    '"s2 s1 sx1 sz1 sx2 sz2", "s2 = s1 + √((sx2 - sx1) ^ 2 + (sz2 - sz1) ^ 2)", "", "110",
    '"s2 s1 sx1 sz1 sx2 sz2 Δsy", "s2 = s1 + √((sx2 - sx1) ^ 2 + Δsy ^ 2 + (sz2 - sz1) ^ 2)", "", "110",
    '"s2 s1 sx1 sx2", "s2 = s1 + sx2 - sx1", "", "110",
    '"s2 s1 sx1 sx2 Δsy", "s2 = s1 + √((sx2 - sx1) ^ 2 + Δsy ^ 2)", "", "110",
    '"s2 s1 sx1 sx2 Δsy Δsz", "s2 = s1 + √((sx2 - sx1) ^ 2 + Δsy ^ 2 + Δsz ^ 2)", "", "110",
    '"s2 s1 sx1 sx2 Δsz", "s2 = s1 + √((sx2 - sx1) ^ 2 + Δsz ^ 2)", "", "110",
    '"s2 s1 sx1 sx2 θ", "s2 = s1 + (sx2 - sx1) : cos(θ)", "", "110",
    '"s2 s1 sx1 sx2 θ ϕ", "s2 = s1 + (sx2 - sx1) : cos(θ) : sin(ϕ)", "", "110",
    '"s2 s1 sy1 sz1 sy2 sz2", "s2 = s1 + √((sy2 - sy1) ^ 2 + (sz2 - sz1) ^ 2)", "", "110",
    '"s2 s1 sy1 sz1 sy2 sz2 Δsx", "s2 = s1 + √(Δsx ^ 2 + (sy2 - sy1) ^ 2 + (sz2 - sz1) ^ 2)", "", "110",
    '"s2 s1 sy1 sy2", "s2 = s1 + sy2 - sy1", "", "110",
    '"s2 s1 sy1 sy2 Δsx", "s2 = s1 + √(Δsx ^ 2 + (sy2 - sy1) ^ 2)", "", "110",
    '"s2 s1 sy1 sy2 Δsx Δsz", "s2 = s1 + √(Δsx ^ 2 + (sy2 - sy1) ^ 2 + Δsz ^ 2)", "", "110",
    '"s2 s1 sy1 sy2 Δsz", "s2 = s1 + √((sy2 - sy1) ^ 2 + Δsz ^ 2)", "", "110",
    '"s2 s1 sy1 sy2 θ", "s2 = s1 + (sy2 - sy1) : sin(θ)", "", "110",
    '"s2 s1 sz1 sz2", "s2 = s1 + sz2 - sz1", "", "110",
    '"s2 s1 sz1 sz2 Δsx", "s2 = s1 + √(Δsx ^ 2 + (sz2 - sz1) ^ 2)", "", "110",
    '"s2 s1 sz1 sz2 Δsx Δsy", "s2 = s1 + √(Δsx ^ 2 + Δsy ^ 2 + (sz2 - sz1) ^ 2)", "", "110",
    '"s2 s1 sz1 sz2 Δsy", "s2 = s1 + √(Δsy ^ 2 + (sz2 - sz1) ^ 2)", "", "110",
    '"s2 s1 sz1 sz2 θ", "s2 = s1 + (sz2 - sz1) : cos(θ)", "", "110",
    '"s2 s1 sz1 sz2 θ ϕ", "s2 = s1 + (sz2 - sz1) : cos(θ) : cos(ϕ)", "", "110",
    '"s2 s1 Δsx", "s2 = s1 + Δsx", "", "110",
    '"s2 s1 Δsx Δsy", "s2 = s1 + √(Δsx ^ 2 + Δsy ^ 2)", "", "110",
    '"s2 s1 Δsx Δsy Δsz", "s2 = s1 + √(Δsx ^ 2 + Δsy ^ 2 + Δsz ^ 2)", "", "110",
    '"s2 s1 Δsx Δsz", "s2 = s1 + √(Δsx ^ 2 + Δsz ^ 2)", "", "110",
    '"s2 s1 Δsx θ", "s2 = s1 + Δsx : cos(θ)", "", "110",
    '"s2 s1 Δsx θ ϕ", "s2 = s1 + Δsx : cos(θ) : sin(ϕ)", "", "110",
    '"s2 s1 Δsy", "s2 = s1 + Δsy", "", "110",
    '"s2 s1 Δsy Δsz", "s2 = s1 + √(Δsy ^ 2 + Δsz ^ 2)", "", "110",
    '"s2 s1 Δsy θ", "s2 = s1 + Δsy : sin(θ)", "", "110",
    '"s2 s1 Δsz", "s2 = s1 + Δsz", "", "110",
    '"s2 s1 Δsz θ", "s2 = s1 + Δsz : cos(θ)", "", "110",
    '"s2 s1 Δsz θ ϕ", "s2 = s1 + Δsz : cos(θ) : cos(ϕ)", "", "110",

    '"sx2 s1 sx1 sy1 sz1 s2 sy2 sz2", "sx2 = sx1 + √((s2 - s1) ^ 2 - (sy2 - sy1) ^ 2 - (sz2 - sz1) ^ 2)", "", "110",
    '"sx2 s1 sx1 sy1 s2 sy2 Δsz", "sx2 = sx1 + √((s2 - s1) ^ 2 - (sy2 - sy1) ^ 2 - Δsz ^ 2)", "", "110",
    '"sx2 s1 sx1 sz1 s2 sz2", "sx2 = sx1 + √((s2 - s1) ^ 2 - (sz2 - sz1) ^ 2)", "", "110",
    '"sx2 s1 sx1 sz1 s2 sz2 Δsy", "sx2 = sx1 + √((s2 - s1) ^ 2 - Δsy ^ 2 - (sz2 - sz1) ^ 2)", "", "110",
    '"sx2 s1 sx1 s2", "sx2 = sx1 + s2 - s1", "", "110",
    '"sx2 s1 sx1 s2 sy1 sy2", "sx2 = sx1 + √((s2 - s1) ^ 2 - (sy2 - sy1) ^ 2)", "", "110",
    '"sx2 s1 sx1 s2 Δsy", "sx2 = sx1 + √((s2 - s1) ^ 2 - Δsy ^ 2)", "", "110",
    '"sx2 s1 sx1 s2 Δsy Δsz", "sx2 = sx1 + √((s2 - s1) ^ 2 - Δsy ^ 2 - Δsz ^ 2)", "", "110",
    '"sx2 s1 sx1 s2 Δsz", "sx2 = sx1 + √((s2 - s1) ^ 2 - Δsz ^ 2)", "", "110",
    '"sx2 s1 sx1 s2 θ", "sx2 = sx1 + (s2 - s1) cos(θ)", "", "110",
    '"sx2 s1 sx1 s2 θ ϕ", "sx2 = sx1 + (s2 - s1) cos(θ) sin(ϕ)", "", "110",
    '"sx2 sx1 sy1 sz1 sy2 sz2 Δs", "sx2 = sx1 + √(Δs ^ 2 - (sy2 - sy1) ^ 2 - (sz2 - sz1) ^ 2)", "", "110",
    '"sx2 sx1 sy1 sy2 Δs", "sx2 = sx1 + √(Δs ^ 2 - (sy2 - sy1) ^ 2)", "", "110",
    '"sx2 sx1 sy1 sy2 Δs Δsz", "sx2 = sx1 + √(Δs ^ 2 - (sy2 - sy1) ^ 2 - Δsz ^ 2)", "", "110",
    '"sx2 sx1 sy1 sy2 θ", "sx2 = sx1 + (sy2 - sy1) : tan(θ)", "", "110",
    '"sx2 sx1 sy1 sy2 θ ϕ", "sx2 = sx1 + (sy2 - sy1) sin(ϕ) : tan(θ)", "", "110",
    '"sx2 sx1 sz1 sz2 Δs", "sx2 = sx1 + √(Δs ^ 2 - (sz2 - sz1) ^ 2)", "", "110",
    '"sx2 sx1 sz1 sz2 Δs Δsy", "sx2 = sx1 + √(Δs ^ 2 - Δsy ^ 2 - (sz2 - sz1) ^ 2)", "", "110",
    '"sx2 sx1 sz1 sz2 ϕ", "sx2 = sx1 + (sz2 - sz1) tan(ϕ)", "", "110",
    '"sx2 sx1 Δs", "sx2 = sx1 + Δs", "", "110", "",
    '"sx2 sx1 Δs Δsy", "sx2 = sx1 + √(Δs ^ 2 - Δsy ^ 2)", "", "110",
    '"sx2 sx1 Δs Δsy Δsz", "sx2 = sx1 + √(Δs ^ 2 - Δsy ^ 2 - Δsz ^ 2)", "", "110",
    '"sx2 sx1 Δs Δsz", "sx2 = sx1 + √(Δs ^ 2 - Δsz ^ 2)", "", "110",
    '"sx2 sx1 Δs θ", "sx2 = sx1 + Δs cos(θ)", "", "110",
    '"sx2 sx1 Δs θ ϕ", "sx2 = sx1 + Δs cos(θ) sin(ϕ)", "", "110",
    '"sx2 sx1 Δsy θ", "sx2 = sx1 + Δsy : tan(θ)", "", "110",
    '"sx2 sx1 Δsy θ ϕ", "sx2 = sx1 + Δsy sin(ϕ) : tan(θ)", "", "110",
    '"sx2 sx1 Δsz ϕ", "sx2 = sx1 + Δsz tan(ϕ)", "", "110",

    '"sy2 s1 sx1 sy1 sz1 s2 sx2 sz2", "sy2 = sy1 + √((s2 - s1) ^ 2 - (sx2 - sx1) ^ 2 - (sz2 - sz1) ^ 2)", "", "110",
    '"sy2 s1 sx1 sy1 s2 sx2 Δsz", "sy2 = sy1 + √((s2 - s1) ^ 2 - (sx2 - sx1) ^ 2 - Δsz ^ 2)", "", "110",
    '"sy2 s1 sx1 s2 sx2 sy1", "sy2 = sy1 + √((s2 - s1) ^ 2 - (sx2 - sx1) ^ 2)", "", "110",
    '"sy2 s1 sy1 sz1 s2 sz2", "sy2 = sy1 + √((s2 - s1) ^ 2 - (sz2 - sz1) ^ 2)", "", "110",
    '"sy2 s1 sy1 sz1 s2 sz2 Δsx", "sy2 = sy1 + √((s2 - s1) ^ 2 - Δsx ^ 2 - (sz2 - sz1) ^ 2)", "", "110",
    '"sy2 s1 sy1 s2", "sy2 = sy1 + s2 - s1", "", "110",
    '"sy2 s1 sy1 s2 Δsx", "sy2 = sy1 + √((s2 - s1) ^ 2 - Δsx ^ 2)", "", "110",
    '"sy2 s1 sy1 s2 Δsx Δsz", "sy2 = sy1 + √((s2 - s1) ^ 2 - Δsx ^ 2 - Δsz ^ 2)", "", "110",
    '"sy2 s1 sy1 s2 Δsz", "sy2 = sy1 + √((s2 - s1) ^ 2 - Δsz ^ 2)", "", "110",
    '"sy2 s1 sy1 s2 θ", "sy2 = sy1 + (s2 - s1) sin(θ)", "", "110",
    '"sy2 sx1 sy1 sx2 Δs", "sy2 = sy1 + √(Δs ^ 2 - (sx2 - sx1) ^ 2)", "", "110",
    '"sy2 sx1 sy1 sx2 Δs Δsz", "sy2 = sy1 + √(Δs ^ 2 - (sx2 - sx1) ^ 2 - Δsz ^ 2)", "", "110",
    '"sy2 sx1 sy1 sx2 θ", "sy2 = sy1 + (sx2 - sx1) tan(θ)", "", "110",
    '"sy2 sx1 sy1 sx2 θ ϕ", "sy2 = sy1 + (sx2 - sx1) tan(θ) : sin(ϕ)", "", "110",
    '"sy2 sx1 sy1 sz1 sx2 sz2 Δs", "sy2 = sy1 + √(Δs ^ 2 - (sx2 - sx1) ^ 2 - (sz2 - sz1) ^ 2)", "", "110",
    '"sy2 sy1 sz1 sz2 Δs", "sy2 = sy1 + √(Δs ^ 2 - (sz2 - sz1) ^ 2)", "", "110",
    '"sy2 sy1 sz1 sz2 Δs Δsx", "sy2 = sy1 + √(Δs ^ 2 - Δsx ^ 2 - (sz2 - sz1) ^ 2)", "", "110",
    '"sy2 sy1 sz1 sz2 θ", "sy2 = sy1 + (sz2 - sz1) tan(θ)", "", "110",
    '"sy2 sy1 sz1 sz2 θ ϕ", "sy2 = sy1 + (sz2 - sz1) tan(θ) : cos(ϕ)", "", "110",
    '"sy2 sy1 Δs", "sy2 = sy1 + Δs", "", "110",
    '"sy2 sy1 Δs Δsx", "sy2 = sy1 + √(Δs ^ 2 - Δsx ^ 2)", "", "110",
    '"sy2 sy1 Δs Δsx Δsz", "sy2 = sy1 + √(Δs ^ 2 - Δsx ^ 2 - Δsz ^ 2)", "", "110",
    '"sy2 sy1 Δs Δsz", "sy2 = sy1 + √(Δs ^ 2 - Δsz ^ 2)", "", "110",
    '"sy2 sy1 Δs θ", "sy2 = sy1 + Δs sin(θ)", "", "110",
    '"sy2 sy1 Δsx θ", "sy2 = sy1 + Δsx tan(θ)", "", "110",
    '"sy2 sy1 Δsx θ ϕ", "sy2 = sy1 + Δsx tan(θ) : sin(ϕ)", "", "110",
    '"sy2 sy1 Δsz θ", "sy2 = sy1 + Δsz tan(θ)", "", "110",
    '"sy2 sy1 Δsz θ ϕ", "sy2 = sy1 + Δsz tan(θ) : cos(ϕ)", "", "110",

    '"sz2 s1 sx1 sy1 sz1 s2 sx2 sy2", "sz2 = sz1 + √((s2 - s1) ^ 2 - (sx2 - sx1) ^ 2 - (sy2 - sy1) ^ 2)", "", "110",
    '"sz2 s1 sx1 sz1 s2 sx2", "sz2 = sz1 + √((s2 - s1) ^ 2 - (sx2 - sx1) ^ 2)", "", "110",
    '"sz2 s1 sx1 sz1 s2 sx2 Δsy", "sz2 = sz1 + √((s2 - s1) ^ 2 - (sx2 - sx1) ^ 2 - Δsy ^ 2)", "", "110",
    '"sz2 s1 sy1 sz1 s2 sy2", "sz2 = sz1 + √((s2 - s1) ^ 2 - (sy2 - sy1) ^ 2)", "", "110",
    '"sz2 s1 sy1 sz1 s2 sy2 Δsx", "sz2 = sz1 + √((s2 - s1) ^ 2 - Δsx ^ 2 - (sy2 - sy1) ^ 2)", "", "110",
    '"sz2 s1 sz1 s2", "sz2 = sz1 + s2 - s1", "", "110",
    '"sz2 s1 sz1 s2 Δsx", "sz2 = sz1 + √((s2 - s1) ^ 2 - Δsx ^ 2)", "", "110",
    '"sz2 s1 sz1 s2 Δsx Δsy", "sz2 = sz1 + √((s2 - s1) ^ 2 - Δsx ^ 2 - Δsy ^ 2)", "", "110",
    '"sz2 s1 sz1 s2 Δsy", "sz2 = sz1 + √((s2 - s1) ^ 2 - Δsy ^ 2)", "", "110",
    '"sz2 s1 sz1 s2 θ", "sz2 = sz1 + (s2 - s1) cos(θ)", "", "110",
    '"sz2 s1 sz1 s2 θ ϕ", "sz2 = sz1 + (s2 - s1) cos(θ) cos(ϕ)", "", "110",
    '"sz2 sx1 sy1 sz1 sx2 sy2 Δs", "sz2 = sz1 + √(Δs ^ 2 - (sx2 - sx1) ^ 2 - (sy2 - sy1) ^ 2)", "", "110",
    '"sz2 sx1 sz1 sx2 Δs", "sz2 = sz1 + √(Δs ^ 2 - (sx2 - sx1) ^ 2)", "", "110",
    '"sz2 sx1 sz1 sx2 Δs Δsy", "sz2 = sz1 + √(Δs ^ 2 - (sx2 - sx1) ^ 2 - Δsy ^ 2)", "", "110",
    '"sz2 sx1 sz1 sx2 ϕ", "sz2 = sz1 + (sx2 - sx1) : tan(ϕ)", "", "110",
    '"sz2 sy1 sz1 sy2 Δs", "sz2 = sz1 + √(Δs ^ 2 - (sy2 - sy1) ^ 2)", "", "110",
    '"sz2 sy1 sz1 sy2 Δs Δsx", "sz2 = sz1 + √(Δs ^ 2 - Δsx ^ 2 - (sy2 - sy1) ^ 2)", "", "110",
    '"sz2 sy1 sz1 sy2 θ", "sz2 = sz1 + (sy2 - sy1) : tan(θ)", "", "110",
    '"sz2 sy1 sz1 sy2 θ ϕ", "sz2 = sz1 + (sy2 - sy1) cos(ϕ) : tan(θ)", "", "110",
    '"sz2 sz1 Δs", "sz2 = sz1 + Δs", "", "110",
    '"sz2 sz1 Δs θ", "sz2 = sz1 + Δs cos(θ)", "", "110",
    '"sz2 sz1 Δs θ ϕ", "sz2 = sz1 + Δs cos(θ) cos(ϕ)", "", "110",
    '"sz2 sz1 Δs Δsx", "sz2 = sz1 + √(Δs ^ 2 - Δsx ^ 2)", "", "110",
    '"sz2 sz1 Δs Δsx Δsy", "sz2 = sz1 + √(Δs ^ 2 - Δsx ^ 2 - Δsy ^ 2)", "", "110",
    '"sz2 sz1 Δs Δsy", "sz2 = sz1 + √(Δs ^ 2 - Δsy ^ 2)", "", "110",
    '"sz2 sz1 Δsx ϕ", "sz2 = sz1 + Δsx : tan(ϕ)", "", "110",
    '"sz2 sz1 Δsy θ", "sz2 = sz1 + Δsy : tan(θ)", "", "110",
    '"sz2 sz1 Δsy θ ϕ", "sz2 = sz1 + Δsy cos(ϕ) : tan(θ)", "", "110",

    '"Δs sx1 sy1 sz1 sx2 sy2 sz2", "Δs = √((sx2 - sx1) ^ 2 + (sy2 - sy1) ^ 2 + (sz2 - sz1) ^ 2)", "", "110",
    '"Δs sx1 sy1 sx2 sy2", "Δs = √((sx2 - sx1) ^ 2 + (sy2 - sy1) ^ 2)", "", "110",
    '"Δs sx1 sy1 sx2 sy2 Δsz", "Δs = √((sx2 - sx1) ^ 2 + (sy2 - sy1) ^ 2 + Δsz ^ 2)", "", "110",
    '"Δs sx1 sz1 sx2 sz2", "Δs = √((sx2 - sx1) ^ 2 + (sz2 - sz1) ^ 2)", "", "110",
    '"Δs sx1 sz1 sx2 sz2 Δsy", "Δs = √((sx2 - sx1) ^ 2 + Δsy ^ 2 + (sz2 - sz1) ^ 2)", "", "110",
    '"Δs sx1 sx2", "Δs = sx2 - sx1", "", "110",
    '"Δs sx1 sx2 Δsy", "Δs = √((sx2 - sx1) ^ 2 + Δsy ^ 2)", "", "110",
    '"Δs sx1 sx2 Δsy Δsz", "Δs = √((sx2 - sx1) ^ 2 + Δsy ^ 2 + Δsz ^ 2)", "", "110",
    '"Δs sx1 sx2 Δsz", "Δs = √((sx2 - sx1) ^ 2 + Δsz ^ 2)", "", "110",
    '"Δs sx1 sx2 θ", "Δs = (sx2 - sx1) : cos(θ)", "", "110",
    '"Δs sx1 sx2 θ ϕ", "Δs = (sx2 - sx1) : cos(θ) : sin(ϕ)", "", "110",
    '"Δs sy1 sz1 sy2 sz2", "Δs = √((sy2 - sy1) ^ 2 + (sz2 - sz1) ^ 2)", "", "110",
    '"Δs sy1 sz1 sy2 sz2 Δsx", "Δs = √(Δsx ^ 2 + (sy2 - sy1) ^ 2 + (sz2 - sz1) ^ 2)", "", "110",
    '"Δs sy1 sy2", "Δs = sy2 - sy1", "", "110",
    '"Δs sy1 sy2 Δsx", "Δs = √(Δsx ^ 2 + (sy2 - sy1) ^ 2)", "", "110",
    '"Δs sy1 sy2 Δsx Δsz", "Δs = √(Δsx ^ 2 + (sy2 - sy1) ^ 2 + Δsz ^ 2)", "", "110",
    '"Δs sy1 sy2 Δsz", "Δs = √((sy2 - sy1) ^ 2 + Δsz ^ 2)", "", "110",
    '"Δs sy1 sy2 θ", "Δs = (sy2 - sy1) : sin(θ)", "", "110",
    '"Δs sz1 sz2", "Δs = sz2 - sz1", "", "110",
    '"Δs sz1 sz2 Δsx", "Δs = √(Δsx ^ 2 + (sz2 - sz1) ^ 2)", "", "110",
    '"Δs sz1 sz2 Δsx Δsy", "Δs = √(Δsx ^ 2 + Δsy ^ 2 + (sz2 - sz1) ^ 2)", "", "110",
    '"Δs sz1 sz2 Δsy", "Δs = √(Δsy ^ 2 + (sz2 - sz1) ^ 2)", "", "110",
    '"Δs sz1 sz2 θ", "Δs = (sz2 - sz1) : cos(θ)", "", "110",
    '"Δs sz1 sz2 θ ϕ", "Δs = (sz2 - sz1) : cos(θ) : cos(ϕ)", "", "110",

    '"Δsx s1 sy1 sz1 s2 sy2 sz2", "Δsx = √((s2 - s1) ^ 2 - (sy2 - sy1) ^ 2 - (sz2 - sz1) ^ 2)", "", "110",
    '"Δsx s1 sy1 s2 sy2", "Δsx = √((s2 - s1) ^ 2 + (sy2 - sy1) ^ 2)", "", "110",
    '"Δsx s1 sy1 s2 sy2 Δsz", "Δsx = √((s2 - s1) ^ 2 - (sy2 - sy1) ^ 2 - Δsz ^ 2)", "", "110",
    '"Δsx s1 sz1 s2 sz2", "Δsx = √((s2 - s1) ^ 2 - (sz2 - sz1) ^ 2)", "", "110",
    '"Δsx s1 sz1 s2 sz2 Δsy", "Δsx = √((s2 - s1) ^ 2 - Δsy ^ 2 - (sz2 - sz1) ^ 2)", "", "110",
    '"Δsx s1 s2", "Δsx = s2 - s1", "", "110",
    '"Δsx s1 s2 Δsy", "Δsx = √((s2 - s1) ^ 2 - Δsy ^ 2)", "", "110",
    '"Δsx s1 s2 Δsy Δsz", "Δsx = √((s2 - s1) ^ 2 - Δsy ^ 2 - Δsz ^ 2)", "", "110",
    '"Δsx s1 s2 Δsz", "Δsx = √((s2 - s1) ^ 2 - Δsz ^ 2)", "", "110",
    '"Δsx s1 s2 θ", "Δsx = (s2 - s1) cos(θ)", "", "110",
    '"Δsx s1 s2 θ ϕ", "Δsx = (s2 - s1) cos(θ) sin(ϕ)", "", "110",
    '"Δsx sy1 sz1 sy2 sz2 Δs", "Δsx = √(Δs ^ 2 - (sy2 - sy1) ^ 2 - (sz2 - sz1) ^ 2)", "", "110",
    '"Δsx sy1 sy2 Δs", "Δsx = √(Δs ^ 2 - (sy2 - sy1) ^ 2)", "", "110",
    '"Δsx sy1 sy2 Δs Δsz", "Δsx = √(Δs ^ 2 - (sy2 - sy1) ^ 2 - Δsz ^ 2)", "", "110",
    '"Δsx sy1 sy2 θ", "Δsx = (sy2 - sy1) : tan(θ)", "", "110",
    '"Δsx sy1 sy2 θ ϕ", "Δsx = (sy2 - sy1) sin(ϕ) : tan(θ)", "", "110",
    '"Δsx sz1 sz2 Δs", "Δsx = √(Δs ^ 2 - (sz2 - sz1) ^ 2)", "", "110",
    '"Δsx sz1 sz2 Δs Δsy", "Δsx = √(Δs ^ 2 - Δsy ^ 2 - (sz2 - sz1) ^ 2)", "", "110",
    '"Δsx sz1 sz2 ϕ", "Δsx = (sz2 - sz1) tan(ϕ)", "", "110",

    '"Δsy s1 sx1 sz1 s2 sx2 sz2", "Δsy = √((s2 - s1) ^ 2 - (sx2 - sx1) ^ 2 - (sz2 - sz1) ^ 2)", "", "110",
    '"Δsy s1 sx1 s2 sx2", "Δsy = √((s2 - s1) ^ 2 - (sx2 - sx1) ^ 2)", "", "110",
    '"Δsy s1 sx1 s2 sx2 Δsz", "Δsy = √((s2 - s1) ^ 2 - (sx2 - sx1) ^ 2 - Δsz ^ 2)", "", "110",
    '"Δsy s1 sz1 s2 sz2", "Δsy = √((s2 - s1) ^ 2 - (sz2 - sz1) ^ 2)", "", "110",
    '"Δsy s1 sz1 s2 sz2 Δsx", "Δsy = √((s2 - s1) ^ 2 - Δsx ^ 2 - (sz2 - sz1) ^ 2)", "", "110",
    '"Δsy s1 s2", "Δsy = s2 - s1", "", "110",
    '"Δsy s1 s2 Δsx", "Δsy = √((s2 - s1) ^ 2 - Δsx ^ 2)", "", "110",
    '"Δsy s1 s2 Δsx Δsz", "Δsy = √((s2 - s1) ^ 2 - Δsx ^ 2 - Δsz ^ 2)", "", "110",
    '"Δsy s1 s2 Δsz", "Δsy = √((s2 - s1) ^ 2 - Δsz ^ 2)", "", "110",
    '"Δsy s1 s2 θ", "Δsy = (s2 - s1) sin(θ)", "", "110",
    '"Δsy sx1 sz1 sx2 sz2 Δs", "Δsy = √(Δs ^ 2 - (sx2 - sx1) ^ 2 - (sz2 - sz1) ^ 2)", "", "110",
    '"Δsy sx1 sx2 Δs", "Δsy = √(Δs ^ 2 - (sx2 - sx1) ^ 2)", "", "110",
    '"Δsy sx1 sx2 Δs Δsz", "Δsy = √(Δs ^ 2 - (sx2 - sx1) ^ 2 - Δsz ^ 2)", "", "110",
    '"Δsy sx1 sx2 θ", "Δsy = (sx2 - sx1) tan(θ)", "", "110",
    '"Δsy sx1 sx2 θ ϕ", "Δsy = (sx2 - sx1) tan(θ) : sin(ϕ)", "", "110",
    '"Δsy sz1 sz2 Δs", "Δsy = √(Δs ^ 2 + (sz2 - sz1) ^ 2)", "", "110",
    '"Δsy sz1 sz2 Δs Δsx", "Δsy = √(Δs ^ 2 - Δsx ^ 2 - (sz2 - sz1) ^ 2)", "", "110",
    '"Δsy sz1 sz2 θ", "Δsy = (sz2 - sz1) tan(θ)", "", "110",
    '"Δsy sz1 sz2 θ ϕ", "Δsy = (sz2 - sz1) tan(θ) : cos(ϕ)", "", "110",

    '"Δsz s1 sx1 sy1 s2 sx2 sy2", "Δsz = √((s2 - s1) ^ 2 - (sx2 - sx1) ^ 2 - (sy2 - sy1) ^ 2)", "", "110",
    '"Δsz s1 sx1 s2 sx2", "Δsz = √((s2 - s1) ^ 2 - (sx2 - sx1) ^ 2)", "", "110",
    '"Δsz s1 sx1 s2 sx2 Δsy", "Δsz = √((s2 - s1) ^ 2 - (sx2 - sx1) ^ 2 - Δsy ^ 2)", "", "110",
    '"Δsz s1 sy1 s2 sy2", "Δsz = √((s2 - s1) ^ 2 - (sy2 - sy1) ^ 2)", "", "110",
    '"Δsz s1 sy1 s2 sy2 Δsx", "Δsz = √((s2 - s1) ^ 2 - Δsx ^ 2 - (sy2 - sy1) ^ 2)", "", "110",
    '"Δsz s1 s2", "Δsz = s2 - s1", "", "110",
    '"Δsz s1 s2 θ", "Δsz = (s2 - s1) cos(θ)", "", "110",
    '"Δsz s1 s2 θ ϕ", "Δsz = (s2 - s1) cos(θ) cos(ϕ)", "", "110",
    '"Δsz s1 s2 Δsx", "Δsz = √((s2 - s1) ^ 2 - Δsx ^ 2)", "", "110",
    '"Δsz s1 s2 Δsx Δsy", "Δsz = √((s2 - s1) ^ 2 - Δsx ^ 2 - Δsy ^ 2)", "", "110",
    '"Δsz s1 s2 Δsy", "Δsz = √((s2 - s1) ^ 2 - Δsy ^ 2)", "", "110",
    '"Δsz sx1 sy1 sx2 sy2 Δs", "Δsz = √(Δs ^ 2 - (sx2 - sx1) ^ 2 - (sy2 - sy1) ^ 2)", "", "110",
    '"Δsz sx1 sx2 Δs", "Δsz = √(Δs ^ 2 - (sx2 - sx1) ^ 2)", "", "110",
    '"Δsz sx1 sx2 Δs Δsy", "Δsz = √(Δs ^ 2 - (sx2 - sx1) ^ 2 - Δsy ^ 2)", "", "110",
    '"Δsz sx1 sx2 ϕ", "Δsz = (sx2 - sx1) : tan(ϕ)", "", "110",
    '"Δsz sy1 sy2 Δs", "Δsz = √(Δs ^ 2 - (sy2 - sy1) ^ 2)", "", "110",
    '"Δsz sy1 sy2 Δs Δsx", "Δsz = √(Δs ^ 2 - (sy2 - sy1) ^ 2 - Δsx ^ 2)", "", "110",
    '"Δsz sy1 sy2 θ", "Δsz = (sy2 - sy1) : tan(θ)", "", "110",
    '"Δsz sy1 sy2 θ ϕ", "Δsz = (sy2 - sy1) cos(ϕ) : tan(θ)", "", "110",

    '"θ s1 sx1 s2 sx2", "θ = acos((sx2 - sx1) : (s2 - s1))", "", "110",
    '"θ s1 sx1 s2 sx2 ϕ", "θ = acos((sx2 - sx1) : (s2 - s1) : sin(ϕ))", "", "110",
    '"θ s1 sy1 s2 sy2", "θ = asin((sy2 - sy1) : (s2 - s1))", "", "110",
    '"θ s1 sz1 s2 sz2", "θ = acos((sz2 - sz1) : (s2 - s1))", "", "110",
    '"θ s1 sz1 s2 sz2 ϕ", "θ = acos((sz2 - sz1) : (s2 - s1) : cos(ϕ))", "", "110",
    '"θ s1 s2 Δsx", "θ = acos(Δsx : (s2 - s1))", "", "110",
    '"θ s1 s2 Δsx ϕ", "θ = acos(Δsx : (s2 - s1) : sin(ϕ))", "", "110",
    '"θ s1 s2 Δsy", "θ = asin(Δsy : (s2 - s1))", "", "110",
    '"θ s1 s2 Δsz", "θ = acos(Δsz : (s2 - s1))", "", "110",
    '"θ s1 s2 Δsz ϕ", "θ = acos(Δsz : (s2 - s1) : cos(ϕ))", "", "110",
    '"θ sx1 sy1 sx2 sy2", "θ = atan((sy2 - sy1) : (sx2 - sx1))", "", "110",
    '"θ sx1 sy1 sx2 sy2 ϕ", "θ = atan((sy2 - sy1) sin(ϕ) : (sx2 - sx1))", "", "110",
    '"θ sx1 sx2 Δs", "θ = acos((sx2 - sx1) : Δs)", "", "110",
    '"θ sx1 sx2 Δs ϕ", "θ = acos((sx2 - sx1) : Δs : sin(ϕ))", "", "110",
    '"θ sx1 sx2 Δsy", "θ = atan(Δsy : (sx2 - sx1))", "", "110",
    '"θ sx1 sx2 Δsy ϕ", "θ = atan(Δsy sin(ϕ) : (sx2 - sx1))", "", "110",
    '"θ sy1 sz1 sy2 sz2", "θ = atan((sy2 - sy1) : (sz2 - sz1))", "", "110",
    '"θ sy1 sz1 sy2 sz2 ϕ", "θ = atan((sy2 - sy1) cos(ϕ) : (sz2 - sz1))", "", "110",
    '"θ sy1 sy2 Δs", "θ = asin((sy2 - sy1) : Δs)", "", "110",
    '"θ sy1 sy2 Δsx", "θ = atan((sy2 - sy1) : Δsx)", "", "110",
    '"θ sy1 sy2 Δsx ϕ", "θ = atan((sy2 - sy1) sin(ϕ) : Δsx)", "", "110",
    '"θ sy1 sy2 Δsz", "θ = atan((sy2 - sy1) : Δsz)", "", "110",
    '"θ sy1 sy2 Δsz ϕ", "θ = atan((sy2 - sy1) cos(ϕ) : Δsz)", "", "110",
    '"θ sz1 sz2 Δs", "θ = acos((sz2 - sz1) : Δs)", "", "110",
    '"θ sz1 sz2 Δs ϕ", "θ = acos((sz2 - sz1) : Δs : cos(ϕ))", "", "110",
    '"θ sz1 sz2 Δsy", "θ = atan(Δsy : (sz2 - sz1))", "", "110",
    '"θ sz1 sz2 Δsy ϕ", "θ = atan(Δsy cos(ϕ) : (sz2 - sz1))", "", "110",

    '"ϕ s1 sx1 s2 sx2 θ", "ϕ = asin((sx2 - sx1) : (s2 - s1) : cos(θ))", "", "110",
    '"ϕ s1 sz1 s2 sz2 θ", "ϕ = acos((sz2 - sz1) : (s2 - s1) : cos(θ))", "", "110",
    '"ϕ s1 s2 Δsx θ", "ϕ = asin(Δsx : (s2 - s1) : cos(θ))", "", "110",
    '"ϕ s1 s2 Δsz θ", "ϕ = acos(Δsz : (s2 - s1) : cos(θ))", "", "110",
    '"ϕ sx1 sy1 sx2 sy2 θ", "ϕ = asin((sx2 - sx1) tan(θ) : (sy2 - sy1))", "", "110",
    '"ϕ sx1 sz1 sx2 sz2", "ϕ = atan((sx2 - sx1) : (sz2 - sz1))", "", "110",
    '"ϕ sx1 sx2 Δs θ", "ϕ = asin((sx2 - sx1) : Δs : cos(θ))", "", "110",
    '"ϕ sx1 sx2 Δsy θ", "ϕ = atan((sx2 - sx1) tan(θ) : Δsy)", "", "110",
    '"ϕ sx1 sx2 Δsz", "ϕ = atan((sx2 - sx1) : Δsz)", "", "110",
    '"ϕ sy1 sz1 sy2 sz2 θ", "ϕ = acos((sz2 - sz1) tan(θ) : (sy2 - sy1))", "", "110",
    '"ϕ sy1 sy2 Δsx θ", "ϕ = asin(Δsx tan(θ) : (sy2 - sy1))", "", "110",
    '"ϕ sy1 sy2 Δsz θ", "ϕ = acos(Δsz tan(θ) : (sy2 - sy1))", "", "110",
    '"ϕ sz1 sz2 Δs θ", "ϕ = acos((sz2 - sz1) : Δs : cos(θ))", "", "110",
    '"ϕ sz1 sz2 Δsx", "ϕ = atan(Δsx : (sz2 - sz1))", "", "110",
    '"ϕ sz1 sz2 Δsy θ", "ϕ = acos((sz2 - sz1) tan(θ) : Δsy)", "", "110",


    '"v1 vx1 vy1 vz1 v2 vx2 vy2 vz2", "v1 = v2 - √((vx2 - vx1) ^ 2 + (vy2 - vy1) ^ 2 + (vz2 - vz1) ^ 2)", "", "110",
    '"v1 vx1 vy1 v2 vx2 vy2", "v1 = v2 - √((vx2 - vx1) ^ 2 + (vy2 - vy1) ^ 2)", "", "110",
    '"v1 vx1 vy1 v2 vx2 vy2 Δvz", "v1 = v2 - √((vx2 - vx1) ^ 2 + (vy2 - vy1) ^ 2 + Δvz ^ 2)", "", "110",
    '"v1 vx1 vz1 v2 vx2 vz2", "v1 = v2 - √((vx2 - vx1) ^ 2 + (vz2 - vz1) ^ 2)", "", "110",
    '"v1 vx1 vz1 v2 vx2 vz2 Δvy", "v1 = v2 - √((vx2 - vx1) ^ 2 + Δvy ^ 2 + (vz2 - vz1) ^ 2)", "", "110",
    '"v1 vx1 v2 vx2", "v1 = v2 + vx1 - vx2", "", "110",
    '"v1 vx1 v2 vx2 Δvy", "v1 = v2 - √((vx2 - vx1) ^ 2 + Δvy ^ 2)", "", "110",
    '"v1 vx1 v2 vx2 Δvy Δvz", "v1 = v2 - √((vx2 - vx1) ^ 2 + Δvy ^ 2 + Δvz ^ 2)", "", "110",
    '"v1 vx1 v2 vx2 Δvz", "v1 = v2 - √((vx2 - vx1) ^ 2 + Δvz ^ 2)", "", "110",
    '"v1 vx1 v2 vx2 θ", "v1 = v2 - (vx2 - vx1) : cos(θ)", "", "110",
    '"v1 vy1 vz1 v2 vy2 vz2", "v1 = v2 - √((vy2 - vy1) ^ 2 + (vz2 - vz1) ^ 2)", "", "110",
    '"v1 vy1 vz1 v2 vy2 vz2 Δvx", "v1 = v2 - √(Δvx ^ 2 + (vy2 - vy1) ^ 2 + (vz2 - vz1) ^ 2)", "", "110",
    '"v1 vy1 v2 vy2", "v1 = v2 + vy1 - vy2", "", "110",
    '"v1 vy1 v2 vy2 Δvx", "v1 = v2 - √(Δvx ^ 2 + (vy2 - vy1) ^ 2)", "", "110",
    '"v1 vy1 v2 vy2 Δvx Δvz", "v1 = v2 - √(Δvx ^ 2 + (vy2 - vy1) ^ 2 + Δvz ^ 2)", "", "110",
    '"v1 vy1 v2 vy2 Δvz", "v1 = v2 - √((vy2 - vy1) ^ 2 + Δvz ^ 2)", "", "110",
    '"v1 vy1 v2 vy2 θ", "v1 = v2 - (vy2 - vy1) : sin(θ)", "", "110",
    '"v1 vz1 v2 vz2", "v1 = v2 + vz1 - vz2", "", "110",
    '"v1 vz1 v2 vz2 Δvx", "v1 = v2 - √(Δvx ^ 2 + (vz2 - vz1) ^ 2)", "", "110",
    '"v1 vz1 v2 vz2 Δvx Δvy", "v1 = v2 - √(Δvx ^ 2 + Δvy ^ 2 + (vz2 - vz1) ^ 2)", "", "110",
    '"v1 vz1 v2 vz2 Δvy", "v1 = v2 - √(Δvy ^ 2 + (vz2 - vz1) ^ 2)", "", "110",
    '"v1 vz1 v2 vz2 θ", "v1 = v2 - (vz2 - vz1) : cos(θ)", "", "110",
    '"v1 vz1 v2 vz2 θ ϕ", "v1 = v2 - (vz2 - vz1) : cos(θ) : cos(ϕ)", "", "110",
    '"v1 v2 vx1 vx2 θ ϕ", "v1 = v2 - (vx2 - vx1) : cos(θ) : sin(ϕ)", "", "110",
    '"v1 v2 Δvx", "v1 = v2 - Δvx", "", "110",
    '"v1 v2 Δvx Δvy", "v1 = v2 - √(Δvx ^ 2 + Δvy ^ 2)", "", "110",
    '"v1 v2 Δvx Δvy Δvz", "v1 = v2 - √(Δvx ^ 2 + Δvy ^ 2 + Δvz ^ 2)", "", "110",
    '"v1 v2 Δvx Δvz", "v1 = v2 - √(Δvx ^ 2 + Δvz ^ 2)", "", "110",
    '"v1 v2 Δvx θ", "v1 = v2 - Δvx : cos(θ)", "", "110",
    '"v1 v2 Δvx θ ϕ", "v1 = v2 - Δvx : cos(θ) : sin(ϕ)", "", "110",
    '"v1 v2 Δvy", "v1 = v2 - Δvy", "", "110",
    '"v1 v2 Δvy Δvz", "v1 = v2 - √(Δvy ^ 2 + Δvz ^ 2)", "", "110",
    '"v1 v2 Δvy θ", "v1 = v2 - Δvy : sin(θ)", "", "110",
    '"v1 v2 Δvz", "v1 = v2 - Δvz", "", "110",
    '"v1 v2 Δvz θ", "v1 = v2 - Δvz : cos(θ)", "", "110",
    '"v1 v2 Δvz θ ϕ", "v1 = v2 - Δvz : cos(θ) : cos(ϕ)", "", "110",

    '"vx1 v1 vy1 vz1 v2 vx2 vy2 vz2", "vx1 = vx2 - √((v2 - v1) ^ 2 - (vy2 - vy1) ^ 2 - (vz2 - vz1) ^ 2)", "", "110",
    '"vx1 v1 vy1 v2 vx2 vy2", "vx1 = vx2 - √((v2 - v1) ^ 2 - (vy2 - vy1) ^ 2)", "", "110",
    '"vx1 v1 vy1 v2 vx2 vy2 Δvz", "vx1 = vx2 - √((v2 - v1) ^ 2 - (vy2 - vy1) ^ 2 - Δvz ^ 2)", "", "110",
    '"vx1 v1 vz1 v2 vx2 vz2", "vx1 = vx2 - √((v2 - v1) ^ 2 - (vz2 - vz1) ^ 2)", "", "110",
    '"vx1 v1 vz1 v2 vx2 vz2 Δvy", "vx1 = vx2 - √((v2 - v1) ^ 2 - Δvy ^ 2 - (vz2 - vz1) ^ 2)", "", "110",
    '"vx1 v1 v2 vx2", "vx1 = vx2 + v1 - v2", "", "110",
    '"vx1 v1 v2 vx2 Δvy", "vx1 = vx2 - √((v2 - v1) ^ 2 - Δvy ^ 2)", "", "110",
    '"vx1 v1 v2 vx2 Δvy Δvz", "vx1 = vx2 - √((v2 - v1) ^ 2 - Δvy ^ 2 - Δvz ^ 2)", "", "110",
    '"vx1 v1 v2 vx2 Δvz", "vx1 = vx2 - √((v2 - v1) ^ 2 - Δvz ^ 2)", "", "110",
    '"vx1 v1 v2 vx2 θ", "vx1 = vx2 - (v2 - v1) cos(θ)", "", "110",
    '"vx1 v1 v2 vx2 θ ϕ", "vx1 = vx2 - (v2 - v1) cos(θ) sin(ϕ)", "", "110",
    '"vx1 vy1 vz1 vx2 vy2 vz2 Δv", "vx1 = vx2 - √(Δv ^ 2 - (vy2 - vy1) ^ 2 - (vz2 - vz1) ^ 2)", "", "110",
    '"vx1 vy1 vx2 vy2 Δv", "vx1 = vx2 - √(Δv ^ 2 - (vy2 - vy1) ^ 2)", "", "110",
    '"vx1 vy1 vx2 vy2 Δv Δvz", "vx1 = vx2 - √(Δv ^ 2 - (vy2 - vy1) ^ 2 - Δvz ^ 2)", "", "110",
    '"vx1 vy1 vx2 vy2 θ", "vx1 = vx2 - (vy2 - vy1) : tan(θ)", "", "110",
    '"vx1 vy1 vx2 vy2 θ ϕ", "vx1 = vx2 - (vy2 - vy1) sin(ϕ) : tan(θ)", "", "110",
    '"vx1 vz1 vx2 vz2 Δv", "vx1 = vx2 - √(Δv ^ 2 - (vz2 - vz1) ^ 2)", "", "110",
    '"vx1 vz1 vx2 vz2 Δv Δvy", "vx1 = vx2 - √(Δv ^ 2 - Δvy ^ 2 - (vz2 - vz1) ^ 2)", "", "110",
    '"vx1 vz1 vx2 vz2 ϕ", "vx1 = vx2 - (vz2 - vz1) tan(ϕ)", "", "110",
    '"vx1 vx2 Δv", "vx1 = vx2 - Δv", "", "110",
    '"vx1 vx2 Δv Δvy", "vx1 = vx2 - √(Δv ^ 2 - Δvy ^ 2)", "", "110",
    '"vx1 vx2 Δv Δvy Δvz", "vx1 = vx2 - √(Δv ^ 2 - Δvy ^ 2 - Δvz ^ 2)", "", "110",
    '"vx1 vx2 Δv Δvz", "vx1 = vx2 - √(Δv ^ 2 - Δvz ^ 2)", "", "110",
    '"vx1 vx2 Δv θ", "vx1 = vx2 - Δv cos(θ)", "", "110",
    '"vx1 vx2 Δv θ ϕ", "vx1 = vx2 - Δv cos(θ) sin(ϕ)", "", "110",
    '"vx1 vx2 Δvy θ", "vx1 = vx2 - Δvy : tan(θ)", "", "110",
    '"vx1 vx2 Δvy θ ϕ", "vx1 = vx2 - Δvy sin(ϕ) : tan(θ)", "", "110",
    '"vx1 vx2 Δvz ϕ", "vx1 = vx2 - Δvz tan(ϕ)", "", "110",

    '"vy1 v1 vx1 vz1 v2 vx2 vy2 vz2", "vy1 = vy2 - √((v2 - v1) ^ 2 - (vx2 - vx1) ^ 2 - (vz2 - vz1) ^ 2)", "", "110",
    '"vy1 v1 vx1 v2 vx2 vy2", "vy1 = vy2 - √((v2 - v1) ^ 2 - (vx2 - vx1) ^ 2)", "", "110",
    '"vy1 v1 vx1 v2 vx2 vy2 Δvz", "vy1 = vy2 - √((v2 - v1) ^ 2 - (vx2 - vx1) ^ 2 - Δvz ^ 2)", "", "110",
    '"vy1 v1 vz1 v2 vy2 vz2", "vy1 = vy2 - √((v2 - v1) ^ 2 - (vz2 - vz1) ^ 2)", "", "110",
    '"vy1 v1 vz1 v2 vy2 vz2 Δvx", "vy1 = vy2 - √((v2 - v1) ^ 2 - Δvx ^ 2 - (vz2 - vz1) ^ 2)", "", "110",
    '"vy1 v1 v2 vy2", "vy1 = vy2 + v1 - v2", "", "110",
    '"vy1 v1 v2 vy2 Δvx", "vy1 = vy2 - √((v2 - v1) ^ 2 - Δvx ^ 2)", "", "110",
    '"vy1 v1 v2 vy2 Δvx Δvz", "vy1 = vy2 - √((v2 - v1) ^ 2 - Δvx ^ 2 - Δvz ^ 2)", "", "110",
    '"vy1 v1 v2 vy2 Δvz", "vy1 = vy2 - √((v2 - v1) ^ 2 - Δvz ^ 2)", "", "110",
    '"vy1 v1 v2 vy2 θ", "vy1 = vy2 - (v2 - v1) sin(θ)", "", "110",
    '"vy1 vx1 vz1 vx2 vy2 vz2 Δv", "vy1 = vy2 - √(Δv ^ 2 - (vx2 - vx1) ^ 2 - (vz2 - vz1) ^ 2)", "", "110",
    '"vy1 vx1 vx2 vy2 Δv", "vy1 = vy2 - √(Δv ^ 2 - (vx2 - vx1) ^ 2)", "", "110",
    '"vy1 vx1 vx2 vy2 Δv Δvz", "vy1 = vy2 - √(Δv ^ 2 - (vx2 - vx1) ^ 2 - Δvz ^ 2)", "", "110",
    '"vy1 vx1 vx2 vy2 θ", "vy1 = vy2 - (vx2 - vx1) tan(θ)", "", "110",
    '"vy1 vx1 vx2 vy2 θ ϕ", "vy1 = vy2 - (vx2 - vx1) tan(θ) : sin(ϕ)", "", "110",
    '"vy1 vz1 vy2 vz2 Δv", "vy1 = vy2 - √(Δv ^ 2 - (vz2 - vz1) ^ 2)", "", "110",
    '"vy1 vz1 vy2 vz2 Δv Δvx", "vy1 = vy2 - √(Δv ^ 2 - Δvx ^ 2 - (vz2 - vz1) ^ 2)", "", "110",
    '"vy1 vz1 vy2 vz2 θ", "vy1 = vy2 - (vz2 - vz1) tan(θ)", "", "110",
    '"vy1 vz1 vy2 vz2 θ ϕ", "vy1 = vy2 - (vz2 - vz1) tan(θ) : cos(ϕ)", "", "110",
    '"vy1 vy2 Δv", "vy1 = vy2 - Δv", "", "110",
    '"vy1 vy2 Δv Δvx", "vy1 = vy2 - √(Δv ^ 2 - Δvx ^ 2)", "", "110",
    '"vy1 vy2 Δv Δvx Δvz", "vy1 = vy2 - √(Δv ^ 2 - Δvx ^ 2 - Δvz ^ 2)", "", "110",
    '"vy1 vy2 Δv Δvz", "vy1 = vy2 - √(Δv ^ 2 - Δvz ^ 2)", "", "110",
    '"vy1 vy2 Δv θ", "vy1 = vy2 - Δv sin(θ)", "", "110",
    '"vy1 vy2 Δvx θ", "vy1 = vy2 - Δvx tan(θ)", "", "110",
    '"vy1 vy2 Δvx θ ϕ", "vy1 = vy2 - Δvx tan(θ) : sin(ϕ)", "", "110",
    '"vy1 vy2 Δvz θ", "vy1 = vy2 - Δvz tan(θ)", "", "110",
    '"vy1 vy2 Δvz θ ϕ", "vy1 = vy2 - Δvz tan(θ) : cos(ϕ)", "", "110",

    '"vz1 v1 vx1 vy1 v2 vx2 vy2 vz2", "vz1 = vz2 - √((v2 - v1) ^ 2 - (vx2 - vx1) ^ 2 - (vy2 - vy1) ^ 2)", "", "110",
    '"vz1 v1 vx1 v2 vx2 vz2", "vz1 = vz2 - √((v2 - v1) ^ 2 - (vx2 - vx1) ^ 2)", "", "110",
    '"vz1 v1 vx1 v2 vx2 vz2 Δvy", "vz1 = vz2 - √((v2 - v1) ^ 2 - (vx2 - vx1) ^ 2 - Δvy ^ 2)", "", "110",
    '"vz1 v1 vy1 v2 vy2 vz2", "vz1 = vz2 - √((v2 - v1) ^ 2 - (vy2 - vy1) ^ 2)", "", "110",
    '"vz1 v1 vy1 v2 vy2 vz2 Δvx", "vz1 = vz2 - √((v2 - v1) ^ 2 - Δvx ^ 2 - (vy2 - vy1) ^ 2)", "", "110",
    '"vz1 v1 v2 vz2", "vz1 = vz2 + v1 - v2", "", "110",
    '"vz1 v1 v2 vz2 Δvx", "vz1 = vz2 - √((v2 - v1) ^ 2 - Δvx ^ 2)", "", "110",
    '"vz1 v1 v2 vz2 Δvx Δvy", "vz1 = vz2 - √((v2 - v1) ^ 2 - Δvx ^ 2 - Δvy ^ 2)", "", "110",
    '"vz1 v1 v2 vz2 Δvy", "vz1 = vz2 - √((v2 - v1) ^ 2 - Δvy ^ 2)", "", "110",
    '"vz1 v1 v2 vz2 θ", "vz1 = vz2 - (v2 - v1) cos(θ)", "", "110",
    '"vz1 v1 v2 vz2 θ ϕ", "vz1 = vz2 - (v2 - v1) cos(θ) cos(ϕ)", "", "110",
    '"vz1 vx1 vy1 vx2 vy2 vz2 Δv", "vz1 = vz2 - √(Δv ^ 2 - (vx2 - vx1) ^ 2 - (vy2 - vy1) ^ 2)", "", "110",
    '"vz1 vx1 vx2 vz2 Δv", "vz1 = vz2 - √(Δv ^ 2 - (vx2 - vx1) ^ 2)", "", "110",
    '"vz1 vx1 vx2 vz2 Δv Δvy", "vz1 = vz2 - √(Δv ^ 2 - (vx2 - vx1) ^ 2 - Δvy ^ 2)", "", "110",
    '"vz1 vx1 vx2 vz2 ϕ", "vz1 = vz2 - (vx2 - vx1) : tan(ϕ)", "", "110",
    '"vz1 vy1 vy2 vz2 Δv", "vz1 = vz2 - √(Δv ^ 2 - (vy2 - vy1) ^ 2)", "", "110",
    '"vz1 vy1 vy2 vz2 Δv Δvx", "vz1 = vz2 - √(Δv ^ 2 - Δvx ^ 2 - (vy2 - vy1) ^ 2)", "", "110",
    '"vz1 vy1 vy2 vz2 θ", "vz1 = vz2 - (vy2 - vy1) : tan(θ)", "", "110",
    '"vz1 vy1 vy2 vz2 θ ϕ", "vz1 = vz2 - (vy2 - vy1) cos(ϕ) : tan(θ)", "", "110",
    '"vz1 vz2 Δv", "vz1 = vz2 - Δv", "", "110",
    '"vz1 vz2 Δv Δvx", "vz1 = vz2 - √(Δv ^ 2 - Δvx ^ 2)", "", "110",
    '"vz1 vz2 Δv Δvx Δvy", "vz1 = vz2 - √(Δv ^ 2 - Δvx ^ 2 - Δvy ^ 2)", "", "110",
    '"vz1 vz2 Δv Δvy", "vz1 = vz2 - √(Δv ^ 2 - Δvy ^ 2)", "", "110",
    '"vz1 vz2 Δv θ", "vz1 = vz2 - Δv cos(θ)", "", "110",
    '"vz1 vz2 Δv θ ϕ", "vz1 = vz2 - Δv cos(θ) cos(ϕ)", "", "110",
    '"vz1 vz2 Δvx ϕ", "vz1 = vz2 - Δvx : tan(ϕ)", "", "110",
    '"vz1 vz2 Δvy θ", "vz1 = vz2 - Δvy : tan(θ)", "", "110",
    '"vz1 vz2 Δvy θ ϕ", "vz1 = vz2 - Δvy cos(ϕ) : tan(θ)", "", "110",

    '"v2 v1 vx1 vy1 vz1 vx2 vy2 vz2", "v2 = v1 + √((vx2 - vx1) ^ 2 + (vy2 - vy1) ^ 2 + (vz2 - vz1) ^ 2)", "", "110",
    '"v2 v1 vx1 vy1 vx2 vy2", "v2 = v1 + √((vx2 - vx1) ^ 2 + (vy2 - vy1) ^ 2)", "", "110",
    '"v2 v1 vx1 vy1 vx2 vy2 Δvz", "v2 = v1 + √((vx2 - vx1) ^ 2 + (vy2 - vy1) ^ 2 + Δvz ^ 2)", "", "110",
    '"v2 v1 vx1 vz1 vx2 vz2", "v2 = v1 + √((vx2 - vx1) ^ 2 + (vz2 - vz1) ^ 2)", "", "110",
    '"v2 v1 vx1 vz1 vx2 vz2 Δvy", "v2 = v1 + √((vx2 - vx1) ^ 2 + Δvy ^ 2 + (vz2 - vz1) ^ 2)", "", "110",
    '"v2 v1 vx1 vx2", "v2 = v1 + vx2 - vx1", "", "110",
    '"v2 v1 vx1 vx2 Δvy", "v2 = v1 + √((vx2 - vx1) ^ 2 + Δvy ^ 2)", "", "110",
    '"v2 v1 vx1 vx2 Δvy Δvz", "v2 = v1 + √((vx2 - vx1) ^ 2 + Δvy ^ 2 + Δvz ^ 2)", "", "110",
    '"v2 v1 vx1 vx2 Δvz", "v2 = v1 + √((vx2 - vx1) ^ 2 + Δvz ^ 2)", "", "110",
    '"v2 v1 vx1 vx2 θ", "v2 = v1 + (vx2 - vx1) : cos(θ)", "", "110",
    '"v2 v1 vx1 vx2 θ ϕ", "v2 = v1 + (vx2 - vx1) : cos(θ) : sin(ϕ)", "", "110",
    '"v2 v1 vy1 vz1 vy2 vz2", "v2 = v1 + √((vy2 - vy1) ^ 2 + (vz2 - vz1) ^ 2)", "", "110",
    '"v2 v1 vy1 vz1 vy2 vz2 Δvx", "v2 = v1 + √(Δvx ^ 2 + (vy2 - vy1) ^ 2 + (vz2 - vz1) ^ 2)", "", "110",
    '"v2 v1 vy1 vy2", "v2 = v1 + vy2 - vy1", "", "110",
    '"v2 v1 vy1 vy2 Δvx", "v2 = v1 + √(Δvx ^ 2 + (vy2 - vy1) ^ 2)", "", "110",
    '"v2 v1 vy1 vy2 Δvx Δvz", "v2 = v1 + √(Δvx ^ 2 + (vy2 - vy1) ^ 2 + Δvz ^ 2)", "", "110",
    '"v2 v1 vy1 vy2 Δvz", "v2 = v1 + √((vy2 - vy1) ^ 2 + Δvz ^ 2)", "", "110",
    '"v2 v1 vy1 vy2 θ", "v2 = v1 + (vy2 - vy1) : sin(θ)", "", "110",
    '"v2 v1 vz1 vz2", "v2 = v1 + vz2 - vz1", "", "110",
    '"v2 v1 vz1 vz2 Δvx", "v2 = v1 + √(Δvx ^ 2 + (vz2 - vz1) ^ 2)", "", "110",
    '"v2 v1 vz1 vz2 Δvx Δvy", "v2 = v1 + √(Δvx ^ 2 + Δvy ^ 2 + (vz2 - vz1) ^ 2)", "", "110",
    '"v2 v1 vz1 vz2 Δvy", "v2 = v1 + √(Δvy ^ 2 + (vz2 - vz1) ^ 2)", "", "110",
    '"v2 v1 vz1 vz2 θ", "v2 = v1 + (vz2 - vz1) : cos(θ)", "", "110",
    '"v2 v1 vz1 vz2 θ ϕ", "v2 = v1 + (vz2 - vz1) : cos(θ) : cos(ϕ)", "", "110",
    '"v2 v1 Δvx", "v2 = v1 + Δvx", "", "110",
    '"v2 v1 Δvx Δvy", "v2 = v1 + √(Δvx ^ 2 + Δvy ^ 2)", "", "110",
    '"v2 v1 Δvx Δvy Δvz", "v2 = v1 + √(Δvx ^ 2 + Δvy ^ 2 + Δvz ^ 2)", "", "110",
    '"v2 v1 Δvx Δvz", "v2 = v1 + √(Δvx ^ 2 + Δvz ^ 2)", "", "110",
    '"v2 v1 Δvx θ", "v2 = v1 + Δvx : cos(θ)", "", "110",
    '"v2 v1 Δvx θ ϕ", "v2 = v1 + Δvx : cos(θ) : sin(ϕ)", "", "110",
    '"v2 v1 Δvy", "v2 = v1 + Δvy", "", "110",
    '"v2 v1 Δvy Δvz", "v2 = v1 + √(Δvy ^ 2 + Δvz ^ 2)", "", "110",
    '"v2 v1 Δvy θ", "v2 = v1 + Δvy : sin(θ)", "", "110",
    '"v2 v1 Δvz", "v2 = v1 + Δvz", "", "110",
    '"v2 v1 Δvz θ", "v2 = v1 + Δvz : cos(θ)", "", "110",
    '"v2 v1 Δvz θ ϕ", "v2 = v1 + Δvz : cos(θ) : cos(ϕ)", "", "110",

    '"vx2 v1 vx1 vy1 vz1 v2 vy2 vz2", "vx2 = vx1 + √((v2 - v1) ^ 2 - (vy2 - vy1) ^ 2 - (vz2 - vz1) ^ 2)", "", "110",
    '"vx2 v1 vx1 vy1 v2 vy2 Δvz", "vx2 = vx1 + √((v2 - v1) ^ 2 - (vy2 - vy1) ^ 2 - Δvz ^ 2)", "", "110",
    '"vx2 v1 vx1 vz1 v2 vz2", "vx2 = vx1 + √((v2 - v1) ^ 2 - (vz2 - vz1) ^ 2)", "", "110",
    '"vx2 v1 vx1 vz1 v2 vz2 Δvy", "vx2 = vx1 + √((v2 - v1) ^ 2 - Δvy ^ 2 - (vz2 - vz1) ^ 2)", "", "110",
    '"vx2 v1 vx1 v2", "vx2 = vx1 + v2 - v1", "", "110",
    '"vx2 v1 vx1 v2 vy1 vy2", "vx2 = vx1 + √((v2 - v1) ^ 2 - (vy2 - vy1) ^ 2)", "", "110",
    '"vx2 v1 vx1 v2 Δvy", "vx2 = vx1 + √((v2 - v1) ^ 2 - Δvy ^ 2)", "", "110",
    '"vx2 v1 vx1 v2 Δvy Δvz", "vx2 = vx1 + √((v2 - v1) ^ 2 - Δvy ^ 2 - Δvz ^ 2)", "", "110",
    '"vx2 v1 vx1 v2 Δvz", "vx2 = vx1 + √((v2 - v1) ^ 2 - Δvz ^ 2)", "", "110",
    '"vx2 v1 vx1 v2 θ", "vx2 = vx1 + (v2 - v1) cos(θ)", "", "110",
    '"vx2 v1 vx1 v2 θ ϕ", "vx2 = vx1 + (v2 - v1) cos(θ) sin(ϕ)", "", "110",
    '"vx2 vx1 vy1 vz1 vy2 vz2 Δv", "vx2 = vx1 + √(Δv ^ 2 - (vy2 - vy1) ^ 2 - (vz2 - vz1) ^ 2)", "", "110",
    '"vx2 vx1 vy1 vy2 Δv", "vx2 = vx1 + √(Δv ^ 2 - (vy2 - vy1) ^ 2)", "", "110",
    '"vx2 vx1 vy1 vy2 Δv Δvz", "vx2 = vx1 + √(Δv ^ 2 - (vy2 - vy1) ^ 2 - Δvz ^ 2)", "", "110",
    '"vx2 vx1 vy1 vy2 θ", "vx2 = vx1 + (vy2 - vy1) : tan(θ)", "", "110",
    '"vx2 vx1 vy1 vy2 θ ϕ", "vx2 = vx1 + (vy2 - vy1) sin(ϕ) : tan(θ)", "", "110",
    '"vx2 vx1 vz1 vz2 Δv", "vx2 = vx1 + √(Δv ^ 2 - (vz2 - vz1) ^ 2)", "", "110",
    '"vx2 vx1 vz1 vz2 Δv Δvy", "vx2 = vx1 + √(Δv ^ 2 - Δvy ^ 2 - (vz2 - vz1) ^ 2)", "", "110",
    '"vx2 vx1 vz1 vz2 ϕ", "vx2 = vx1 + (vz2 - vz1) tan(ϕ)", "", "110",
    '"vx2 vx1 Δv", "vx2 = vx1 + Δv", "", "110", "",
    '"vx2 vx1 Δv Δvy", "vx2 = vx1 + √(Δv ^ 2 - Δvy ^ 2)", "", "110",
    '"vx2 vx1 Δv Δvy Δvz", "vx2 = vx1 + √(Δv ^ 2 - Δvy ^ 2 - Δvz ^ 2)", "", "110",
    '"vx2 vx1 Δv Δvz", "vx2 = vx1 + √(Δv ^ 2 - Δvz ^ 2)", "", "110",
    '"vx2 vx1 Δv θ", "vx2 = vx1 + Δv cos(θ)", "", "110",
    '"vx2 vx1 Δv θ ϕ", "vx2 = vx1 + Δv cos(θ) sin(ϕ)", "", "110",
    '"vx2 vx1 Δvy θ", "vx2 = vx1 + Δvy : tan(θ)", "", "110",
    '"vx2 vx1 Δvy θ ϕ", "vx2 = vx1 + Δvy sin(ϕ) : tan(θ)", "", "110",
    '"vx2 vx1 Δvz ϕ", "vx2 = vx1 + Δvz tan(ϕ)", "", "110",

    '"vy2 v1 vx1 vy1 vz1 v2 vx2 vz2", "vy2 = vy1 + √((v2 - v1) ^ 2 - (vx2 - vx1) ^ 2 - (vz2 - vz1) ^ 2)", "", "110",
    '"vy2 v1 vx1 vy1 v2 vx2 Δvz", "vy2 = vy1 + √((v2 - v1) ^ 2 - (vx2 - vx1) ^ 2 - Δvz ^ 2)", "", "110",
    '"vy2 v1 vx1 v2 vx2 vy1", "vy2 = vy1 + √((v2 - v1) ^ 2 - (vx2 - vx1) ^ 2)", "", "110",
    '"vy2 v1 vy1 vz1 v2 vz2", "vy2 = vy1 + √((v2 - v1) ^ 2 - (vz2 - vz1) ^ 2)", "", "110",
    '"vy2 v1 vy1 vz1 v2 vz2 Δvx", "vy2 = vy1 + √((v2 - v1) ^ 2 - Δvx ^ 2 - (vz2 - vz1) ^ 2)", "", "110",
    '"vy2 v1 vy1 v2", "vy2 = vy1 + v2 - v1", "", "110",
    '"vy2 v1 vy1 v2 Δvx", "vy2 = vy1 + √((v2 - v1) ^ 2 - Δvx ^ 2)", "", "110",
    '"vy2 v1 vy1 v2 Δvx Δvz", "vy2 = vy1 + √((v2 - v1) ^ 2 - Δvx ^ 2 - Δvz ^ 2)", "", "110",
    '"vy2 v1 vy1 v2 Δvz", "vy2 = vy1 + √((v2 - v1) ^ 2 - Δvz ^ 2)", "", "110",
    '"vy2 v1 vy1 v2 θ", "vy2 = vy1 + (v2 - v1) sin(θ)", "", "110",
    '"vy2 vx1 vy1 vx2 Δv", "vy2 = vy1 + √(Δv ^ 2 - (vx2 - vx1) ^ 2)", "", "110",
    '"vy2 vx1 vy1 vx2 Δv Δvz", "vy2 = vy1 + √(Δv ^ 2 - (vx2 - vx1) ^ 2 - Δvz ^ 2)", "", "110",
    '"vy2 vx1 vy1 vx2 θ", "vy2 = vy1 + (vx2 - vx1) tan(θ)", "", "110",
    '"vy2 vx1 vy1 vx2 θ ϕ", "vy2 = vy1 + (vx2 - vx1) tan(θ) : sin(ϕ)", "", "110",
    '"vy2 vx1 vy1 vz1 vx2 vz2 Δv", "vy2 = vy1 + √(Δv ^ 2 - (vx2 - vx1) ^ 2 - (vz2 - vz1) ^ 2)", "", "110",
    '"vy2 vy1 vz1 vz2 Δv", "vy2 = vy1 + √(Δv ^ 2 - (vz2 - vz1) ^ 2)", "", "110",
    '"vy2 vy1 vz1 vz2 Δv Δvx", "vy2 = vy1 + √(Δv ^ 2 - Δvx ^ 2 - (vz2 - vz1) ^ 2)", "", "110",
    '"vy2 vy1 vz1 vz2 θ", "vy2 = vy1 + (vz2 - vz1) tan(θ)", "", "110",
    '"vy2 vy1 vz1 vz2 θ ϕ", "vy2 = vy1 + (vz2 - vz1) tan(θ) : cos(ϕ)", "", "110",
    '"vy2 vy1 Δv", "vy2 = vy1 + Δv", "", "110",
    '"vy2 vy1 Δv Δvx", "vy2 = vy1 + √(Δv ^ 2 - Δvx ^ 2)", "", "110",
    '"vy2 vy1 Δv Δvx Δvz", "vy2 = vy1 + √(Δv ^ 2 - Δvx ^ 2 - Δvz ^ 2)", "", "110",
    '"vy2 vy1 Δv Δvz", "vy2 = vy1 + √(Δv ^ 2 - Δvz ^ 2)", "", "110",
    '"vy2 vy1 Δv θ", "vy2 = vy1 + Δv sin(θ)", "", "110",
    '"vy2 vy1 Δvx θ", "vy2 = vy1 + Δvx tan(θ)", "", "110",
    '"vy2 vy1 Δvx θ ϕ", "vy2 = vy1 + Δvx tan(θ) : sin(ϕ)", "", "110",
    '"vy2 vy1 Δvz θ", "vy2 = vy1 + Δvz tan(θ)", "", "110",
    '"vy2 vy1 Δvz θ ϕ", "vy2 = vy1 + Δvz tan(θ) : cos(ϕ)", "", "110",

    '"vz2 v1 vx1 vy1 vz1 v2 vx2 vy2", "vz2 = vz1 + √((v2 - v1) ^ 2 - (vx2 - vx1) ^ 2 - (vy2 - vy1) ^ 2)", "", "110",
    '"vz2 v1 vx1 vz1 v2 vx2", "vz2 = vz1 + √((v2 - v1) ^ 2 - (vx2 - vx1) ^ 2)", "", "110",
    '"vz2 v1 vx1 vz1 v2 vx2 Δvy", "vz2 = vz1 + √((v2 - v1) ^ 2 - (vx2 - vx1) ^ 2 - Δvy ^ 2)", "", "110",
    '"vz2 v1 vy1 vz1 v2 vy2", "vz2 = vz1 + √((v2 - v1) ^ 2 - (vy2 - vy1) ^ 2)", "", "110",
    '"vz2 v1 vy1 vz1 v2 vy2 Δvx", "vz2 = vz1 + √((v2 - v1) ^ 2 - Δvx ^ 2 - (vy2 - vy1) ^ 2)", "", "110",
    '"vz2 v1 vz1 v2", "vz2 = vz1 + v2 - v1", "", "110",
    '"vz2 v1 vz1 v2 Δvx", "vz2 = vz1 + √((v2 - v1) ^ 2 - Δvx ^ 2)", "", "110",
    '"vz2 v1 vz1 v2 Δvx Δvy", "vz2 = vz1 + √((v2 - v1) ^ 2 - Δvx ^ 2 - Δvy ^ 2)", "", "110",
    '"vz2 v1 vz1 v2 Δvy", "vz2 = vz1 + √((v2 - v1) ^ 2 - Δvy ^ 2)", "", "110",
    '"vz2 v1 vz1 v2 θ", "vz2 = vz1 + (v2 - v1) cos(θ)", "", "110",
    '"vz2 v1 vz1 v2 θ ϕ", "vz2 = vz1 + (v2 - v1) cos(θ) cos(ϕ)", "", "110",
    '"vz2 vx1 vy1 vz1 vx2 vy2 Δv", "vz2 = vz1 + √(Δv ^ 2 - (vx2 - vx1) ^ 2 - (vy2 - vy1) ^ 2)", "", "110",
    '"vz2 vx1 vz1 vx2 Δv", "vz2 = vz1 + √(Δv ^ 2 - (vx2 - vx1) ^ 2)", "", "110",
    '"vz2 vx1 vz1 vx2 Δv Δvy", "vz2 = vz1 + √(Δv ^ 2 - (vx2 - vx1) ^ 2 - Δvy ^ 2)", "", "110",
    '"vz2 vx1 vz1 vx2 ϕ", "vz2 = vz1 + (vx2 - vx1) : tan(ϕ)", "", "110",
    '"vz2 vy1 vz1 vy2 Δv", "vz2 = vz1 + √(Δv ^ 2 - (vy2 - vy1) ^ 2)", "", "110",
    '"vz2 vy1 vz1 vy2 Δv Δvx", "vz2 = vz1 + √(Δv ^ 2 - Δvx ^ 2 - (vy2 - vy1) ^ 2)", "", "110",
    '"vz2 vy1 vz1 vy2 θ", "vz2 = vz1 + (vy2 - vy1) : tan(θ)", "", "110",
    '"vz2 vy1 vz1 vy2 θ ϕ", "vz2 = vz1 + (vy2 - vy1) cos(ϕ) : tan(θ)", "", "110",
    '"vz2 vz1 Δv", "vz2 = vz1 + Δv", "", "110",
    '"vz2 vz1 Δv θ", "vz2 = vz1 + Δv cos(θ)", "", "110",
    '"vz2 vz1 Δv θ ϕ", "vz2 = vz1 + Δv cos(θ) cos(ϕ)", "", "110",
    '"vz2 vz1 Δv Δvx", "vz2 = vz1 + √(Δv ^ 2 - Δvx ^ 2)", "", "110",
    '"vz2 vz1 Δv Δvx Δvy", "vz2 = vz1 + √(Δv ^ 2 - Δvx ^ 2 - Δvy ^ 2)", "", "110",
    '"vz2 vz1 Δv Δvy", "vz2 = vz1 + √(Δv ^ 2 - Δvy ^ 2)", "", "110",
    '"vz2 vz1 Δvx ϕ", "vz2 = vz1 + Δvx : tan(ϕ)", "", "110",
    '"vz2 vz1 Δvy θ", "vz2 = vz1 + Δvy : tan(θ)", "", "110",
    '"vz2 vz1 Δvy θ ϕ", "vz2 = vz1 + Δvy cos(ϕ) : tan(θ)", "", "110",

    '"Δv vx1 vy1 vz1 vx2 vy2 vz2", "Δv = √((vx2 - vx1) ^ 2 + (vy2 - vy1) ^ 2 + (vz2 - vz1) ^ 2)", "", "110",
    '"Δv vx1 vy1 vx2 vy2", "Δv = √((vx2 - vx1) ^ 2 + (vy2 - vy1) ^ 2)", "", "110",
    '"Δv vx1 vy1 vx2 vy2 Δvz", "Δv = √((vx2 - vx1) ^ 2 + (vy2 - vy1) ^ 2 + Δvz ^ 2)", "", "110",
    '"Δv vx1 vz1 vx2 vz2", "Δv = √((vx2 - vx1) ^ 2 + (vz2 - vz1) ^ 2)", "", "110",
    '"Δv vx1 vz1 vx2 vz2 Δvy", "Δv = √((vx2 - vx1) ^ 2 + Δvy ^ 2 + (vz2 - vz1) ^ 2)", "", "110",
    '"Δv vx1 vx2", "Δv = vx2 - vx1", "", "110",
    '"Δv vx1 vx2 Δvy", "Δv = √((vx2 - vx1) ^ 2 + Δvy ^ 2)", "", "110",
    '"Δv vx1 vx2 Δvy Δvz", "Δv = √((vx2 - vx1) ^ 2 + Δvy ^ 2 + Δvz ^ 2)", "", "110",
    '"Δv vx1 vx2 Δvz", "Δv = √((vx2 - vx1) ^ 2 + Δvz ^ 2)", "", "110",
    '"Δv vx1 vx2 θ", "Δv = (vx2 - vx1) : cos(θ)", "", "110",
    '"Δv vx1 vx2 θ ϕ", "Δv = (vx2 - vx1) : cos(θ) : sin(ϕ)", "", "110",
    '"Δv vy1 vz1 vy2 vz2", "Δv = √((vy2 - vy1) ^ 2 + (vz2 - vz1) ^ 2)", "", "110",
    '"Δv vy1 vz1 vy2 vz2 Δvx", "Δv = √(Δvx ^ 2 + (vy2 - vy1) ^ 2 + (vz2 - vz1) ^ 2)", "", "110",
    '"Δv vy1 vy2", "Δv = vy2 - vy1", "", "110",
    '"Δv vy1 vy2 Δvx", "Δv = √(Δvx ^ 2 + (vy2 - vy1) ^ 2)", "", "110",
    '"Δv vy1 vy2 Δvx Δvz", "Δv = √(Δvx ^ 2 + (vy2 - vy1) ^ 2 + Δvz ^ 2)", "", "110",
    '"Δv vy1 vy2 Δvz", "Δv = √((vy2 - vy1) ^ 2 + Δvz ^ 2)", "", "110",
    '"Δv vy1 vy2 θ", "Δv = (vy2 - vy1) : sin(θ)", "", "110",
    '"Δv vz1 vz2", "Δv = vz2 - vz1", "", "110",
    '"Δv vz1 vz2 Δvx", "Δv = √(Δvx ^ 2 + (vz2 - vz1) ^ 2)", "", "110",
    '"Δv vz1 vz2 Δvx Δvy", "Δv = √(Δvx ^ 2 + Δvy ^ 2 + (vz2 - vz1) ^ 2)", "", "110",
    '"Δv vz1 vz2 Δvy", "Δv = √(Δvy ^ 2 + (vz2 - vz1) ^ 2)", "", "110",
    '"Δv vz1 vz2 θ", "Δv = (vz2 - vz1) : cos(θ)", "", "110",
    '"Δv vz1 vz2 θ ϕ", "Δv = (vz2 - vz1) : cos(θ) : cos(ϕ)", "", "110",

    '"Δvx v1 vy1 vz1 v2 vy2 vz2", "Δvx = √((v2 - v1) ^ 2 - (vy2 - vy1) ^ 2 - (vz2 - vz1) ^ 2)", "", "110",
    '"Δvx v1 vy1 v2 vy2", "Δvx = √((v2 - v1) ^ 2 + (vy2 - vy1) ^ 2)", "", "110",
    '"Δvx v1 vy1 v2 vy2 Δvz", "Δvx = √((v2 - v1) ^ 2 - (vy2 - vy1) ^ 2 - Δvz ^ 2)", "", "110",
    '"Δvx v1 vz1 v2 vz2", "Δvx = √((v2 - v1) ^ 2 - (vz2 - vz1) ^ 2)", "", "110",
    '"Δvx v1 vz1 v2 vz2 Δvy", "Δvx = √((v2 - v1) ^ 2 - Δvy ^ 2 - (vz2 - vz1) ^ 2)", "", "110",
    '"Δvx v1 v2", "Δvx = v2 - v1", "", "110",
    '"Δvx v1 v2 Δvy", "Δvx = √((v2 - v1) ^ 2 - Δvy ^ 2)", "", "110",
    '"Δvx v1 v2 Δvy Δvz", "Δvx = √((v2 - v1) ^ 2 - Δvy ^ 2 - Δvz ^ 2)", "", "110",
    '"Δvx v1 v2 Δvz", "Δvx = √((v2 - v1) ^ 2 - Δvz ^ 2)", "", "110",
    '"Δvx v1 v2 θ", "Δvx = (v2 - v1) cos(θ)", "", "110",
    '"Δvx v1 v2 θ ϕ", "Δvx = (v2 - v1) cos(θ) sin(ϕ)", "", "110",
    '"Δvx vy1 vz1 vy2 vz2 Δv", "Δvx = √(Δv ^ 2 - (vy2 - vy1) ^ 2 - (vz2 - vz1) ^ 2)", "", "110",
    '"Δvx vy1 vy2 Δv", "Δvx = √(Δv ^ 2 - (vy2 - vy1) ^ 2)", "", "110",
    '"Δvx vy1 vy2 Δv Δvz", "Δvx = √(Δv ^ 2 - (vy2 - vy1) ^ 2 - Δvz ^ 2)", "", "110",
    '"Δvx vy1 vy2 θ", "Δvx = (vy2 - vy1) : tan(θ)", "", "110",
    '"Δvx vy1 vy2 θ ϕ", "Δvx = (vy2 - vy1) sin(ϕ) : tan(θ)", "", "110",
    '"Δvx vz1 vz2 Δv", "Δvx = √(Δv ^ 2 - (vz2 - vz1) ^ 2)", "", "110",
    '"Δvx vz1 vz2 Δv Δvy", "Δvx = √(Δv ^ 2 - Δvy ^ 2 - (vz2 - vz1) ^ 2)", "", "110",
    '"Δvx vz1 vz2 ϕ", "Δvx = (vz2 - vz1) tan(ϕ)", "", "110",

    '"Δvy v1 vx1 vz1 v2 vx2 vz2", "Δvy = √((v2 - v1) ^ 2 - (vx2 - vx1) ^ 2 - (vz2 - vz1) ^ 2)", "", "110",
    '"Δvy v1 vx1 v2 vx2", "Δvy = √((v2 - v1) ^ 2 - (vx2 - vx1) ^ 2)", "", "110",
    '"Δvy v1 vx1 v2 vx2 Δvz", "Δvy = √((v2 - v1) ^ 2 - (vx2 - vx1) ^ 2 - Δvz ^ 2)", "", "110",
    '"Δvy v1 vz1 v2 vz2", "Δvy = √((v2 - v1) ^ 2 - (vz2 - vz1) ^ 2)", "", "110",
    '"Δvy v1 vz1 v2 vz2 Δvx", "Δvy = √((v2 - v1) ^ 2 - Δvx ^ 2 - (vz2 - vz1) ^ 2)", "", "110",
    '"Δvy v1 v2", "Δvy = v2 - v1", "", "110",
    '"Δvy v1 v2 Δvx", "Δvy = √((v2 - v1) ^ 2 - Δvx ^ 2)", "", "110",
    '"Δvy v1 v2 Δvx Δvz", "Δvy = √((v2 - v1) ^ 2 - Δvx ^ 2 - Δvz ^ 2)", "", "110",
    '"Δvy v1 v2 Δvz", "Δvy = √((v2 - v1) ^ 2 - Δvz ^ 2)", "", "110",
    '"Δvy v1 v2 θ", "Δvy = (v2 - v1) sin(θ)", "", "110",
    '"Δvy vx1 vz1 vx2 vz2 Δv", "Δvy = √(Δv ^ 2 - (vx2 - vx1) ^ 2 - (vz2 - vz1) ^ 2)", "", "110",
    '"Δvy vx1 vx2 Δv", "Δvy = √(Δv ^ 2 - (vx2 - vx1) ^ 2)", "", "110",
    '"Δvy vx1 vx2 Δv Δvz", "Δvy = √(Δv ^ 2 - (vx2 - vx1) ^ 2 - Δvz ^ 2)", "", "110",
    '"Δvy vx1 vx2 θ", "Δvy = (vx2 - vx1) tan(θ)", "", "110",
    '"Δvy vx1 vx2 θ ϕ", "Δvy = (vx2 - vx1) tan(θ) : sin(ϕ)", "", "110",
    '"Δvy vz1 vz2 Δv", "Δvy = √(Δv ^ 2 + (vz2 - vz1) ^ 2)", "", "110",
    '"Δvy vz1 vz2 Δv Δvx", "Δvy = √(Δv ^ 2 - Δvx ^ 2 - (vz2 - vz1) ^ 2)", "", "110",
    '"Δvy vz1 vz2 θ", "Δvy = (vz2 - vz1) tan(θ)", "", "110",
    '"Δvy vz1 vz2 θ ϕ", "Δvy = (vz2 - vz1) tan(θ) : cos(ϕ)", "", "110",

    '"Δvz v1 vx1 vy1 v2 vx2 vy2", "Δvz = √((v2 - v1) ^ 2 - (vx2 - vx1) ^ 2 - (vy2 - vy1) ^ 2)", "", "110",
    '"Δvz v1 vx1 v2 vx2", "Δvz = √((v2 - v1) ^ 2 - (vx2 - vx1) ^ 2)", "", "110",
    '"Δvz v1 vx1 v2 vx2 Δvy", "Δvz = √((v2 - v1) ^ 2 - (vx2 - vx1) ^ 2 - Δvy ^ 2)", "", "110",
    '"Δvz v1 vy1 v2 vy2", "Δvz = √((v2 - v1) ^ 2 - (vy2 - vy1) ^ 2)", "", "110",
    '"Δvz v1 vy1 v2 vy2 Δvx", "Δvz = √((v2 - v1) ^ 2 - Δvx ^ 2 - (vy2 - vy1) ^ 2)", "", "110",
    '"Δvz v1 v2", "Δvz = v2 - v1", "", "110",
    '"Δvz v1 v2 θ", "Δvz = (v2 - v1) cos(θ)", "", "110",
    '"Δvz v1 v2 θ ϕ", "Δvz = (v2 - v1) cos(θ) cos(ϕ)", "", "110",
    '"Δvz v1 v2 Δvx", "Δvz = √((v2 - v1) ^ 2 - Δvx ^ 2)", "", "110",
    '"Δvz v1 v2 Δvx Δvy", "Δvz = √((v2 - v1) ^ 2 - Δvx ^ 2 - Δvy ^ 2)", "", "110",
    '"Δvz v1 v2 Δvy", "Δvz = √((v2 - v1) ^ 2 - Δvy ^ 2)", "", "110",
    '"Δvz vx1 vy1 vx2 vy2 Δv", "Δvz = √(Δv ^ 2 - (vx2 - vx1) ^ 2 - (vy2 - vy1) ^ 2)", "", "110",
    '"Δvz vx1 vx2 Δv", "Δvz = √(Δv ^ 2 - (vx2 - vx1) ^ 2)", "", "110",
    '"Δvz vx1 vx2 Δv Δvy", "Δvz = √(Δv ^ 2 - (vx2 - vx1) ^ 2 - Δvy ^ 2)", "", "110",
    '"Δvz vx1 vx2 ϕ", "Δvz = (vx2 - vx1) : tan(ϕ)", "", "110",
    '"Δvz vy1 vy2 Δv", "Δvz = √(Δv ^ 2 - (vy2 - vy1) ^ 2)", "", "110",
    '"Δvz vy1 vy2 Δv Δvx", "Δvz = √(Δv ^ 2 - (vy2 - vy1) ^ 2 - Δvx ^ 2)", "", "110",
    '"Δvz vy1 vy2 θ", "Δvz = (vy2 - vy1) : tan(θ)", "", "110",
    '"Δvz vy1 vy2 θ ϕ", "Δvz = (vy2 - vy1) cos(ϕ) : tan(θ)", "", "110",

    '"θ v1 vx1 v2 vx2", "θ = acos((vx2 - vx1) : (v2 - v1))", "", "110",
    '"θ v1 vx1 v2 vx2 ϕ", "θ = acos((vx2 - vx1) : (v2 - v1) : sin(ϕ))", "", "110",
    '"θ v1 vy1 v2 vy2", "θ = asin((vy2 - vy1) : (v2 - v1))", "", "110",
    '"θ v1 vz1 v2 vz2", "θ = acos((vz2 - vz1) : (v2 - v1))", "", "110",
    '"θ v1 vz1 v2 vz2 ϕ", "θ = acos((vz2 - vz1) : (v2 - v1) : cos(ϕ))", "", "110",
    '"θ v1 v2 Δvx", "θ = acos(Δvx : (v2 - v1))", "", "110",
    '"θ v1 v2 Δvx ϕ", "θ = acos(Δvx : (v2 - v1) : sin(ϕ))", "", "110",
    '"θ v1 v2 Δvy", "θ = asin(Δvy : (v2 - v1))", "", "110",
    '"θ v1 v2 Δvz", "θ = acos(Δvz : (v2 - v1))", "", "110",
    '"θ v1 v2 Δvz ϕ", "θ = acos(Δvz : (v2 - v1) : cos(ϕ))", "", "110",
    '"θ vx1 vy1 vx2 vy2", "θ = atan((vy2 - vy1) : (vx2 - vx1))", "", "110",
    '"θ vx1 vy1 vx2 vy2 ϕ", "θ = atan((vy2 - vy1) sin(ϕ) : (vx2 - vx1))", "", "110",
    '"θ vx1 vx2 Δv", "θ = acos((vx2 - vx1) : Δv)", "", "110",
    '"θ vx1 vx2 Δv ϕ", "θ = acos((vx2 - vx1) : Δv : sin(ϕ))", "", "110",
    '"θ vx1 vx2 Δvy", "θ = atan(Δvy : (vx2 - vx1))", "", "110",
    '"θ vx1 vx2 Δvy ϕ", "θ = atan(Δvy sin(ϕ) : (vx2 - vx1))", "", "110",
    '"θ vy1 vz1 vy2 vz2", "θ = atan((vy2 - vy1) : (vz2 - vz1))", "", "110",
    '"θ vy1 vz1 vy2 vz2 ϕ", "θ = atan((vy2 - vy1) cos(ϕ) : (vz2 - vz1))", "", "110",
    '"θ vy1 vy2 Δv", "θ = asin((vy2 - vy1) : Δv)", "", "110",
    '"θ vy1 vy2 Δvx", "θ = atan((vy2 - vy1) : Δvx)", "", "110",
    '"θ vy1 vy2 Δvx ϕ", "θ = atan((vy2 - vy1) sin(ϕ) : Δvx)", "", "110",
    '"θ vy1 vy2 Δvz", "θ = atan((vy2 - vy1) : Δvz)", "", "110",
    '"θ vy1 vy2 Δvz ϕ", "θ = atan((vy2 - vy1) cos(ϕ) : Δvz)", "", "110",
    '"θ vz1 vz2 Δv", "θ = acos((vz2 - vz1) : Δv)", "", "110",
    '"θ vz1 vz2 Δv ϕ", "θ = acos((vz2 - vz1) : Δv : cos(ϕ))", "", "110",
    '"θ vz1 vz2 Δvy", "θ = atan(Δvy : (vz2 - vz1))", "", "110",
    '"θ vz1 vz2 Δvy ϕ", "θ = atan(Δvy cos(ϕ) : (vz2 - vz1))", "", "110",

    '"ϕ v1 vx1 v2 vx2 θ", "ϕ = asin((vx2 - vx1) : (v2 - v1) : cos(θ))", "", "110",
    '"ϕ v1 vz1 v2 vz2 θ", "ϕ = acos((vz2 - vz1) : (v2 - v1) : cos(θ))", "", "110",
    '"ϕ v1 v2 Δvx θ", "ϕ = asin(Δvx : (v2 - v1) : cos(θ))", "", "110",
    '"ϕ v1 v2 Δvz θ", "ϕ = acos(Δvz : (v2 - v1) : cos(θ))", "", "110",
    '"ϕ vx1 vy1 vx2 vy2 θ", "ϕ = asin((vx2 - vx1) tan(θ) : (vy2 - vy1))", "", "110",
    '"ϕ vx1 vz1 vx2 vz2", "ϕ = atan((vx2 - vx1) : (vz2 - vz1))", "", "110",
    '"ϕ vx1 vx2 Δv θ", "ϕ = asin((vx2 - vx1) : Δv : cos(θ))", "", "110",
    '"ϕ vx1 vx2 Δvy θ", "ϕ = atan((vx2 - vx1) tan(θ) : Δvy)", "", "110",
    '"ϕ vx1 vx2 Δvz", "ϕ = atan((vx2 - vx1) : Δvz)", "", "110",
    '"ϕ vy1 vz1 vy2 vz2 θ", "ϕ = acos((vz2 - vz1) tan(θ) : (vy2 - vy1))", "", "110",
    '"ϕ vy1 vy2 Δvx θ", "ϕ = asin(Δvx tan(θ) : (vy2 - vy1))", "", "110",
    '"ϕ vy1 vy2 Δvz θ", "ϕ = acos(Δvz tan(θ) : (vy2 - vy1))", "", "110",
    '"ϕ vz1 vz2 Δv θ", "ϕ = acos((vz2 - vz1) : Δv : cos(θ))", "", "110",
    '"ϕ vz1 vz2 Δvx", "ϕ = atan(Δvx : (vz2 - vz1))", "", "110",
    '"ϕ vz1 vz2 Δvy θ", "ϕ = acos((vz2 - vz1) tan(θ) : Δvy)", "", "110",

    '363 * 2 = 726 (Δs, Δv)
    '''''''''''''''''''''''''''''''''
    '''''''''''''''''''''''''''''''''
    '''''''''''''''''''''''''''''''''
    '''''''''''''''''''''''''''''''''
    '''''''''''''''''''''''''''''''''
    '''''''''''''''''''''''''''''''''

  End Sub
#End Region
#End Region
#Region "EEEE"

#End Region
#End Region
End Class
#End Region