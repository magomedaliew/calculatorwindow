Imports Windows.UI
Imports Windows.UI.Text
Imports Windows.Storage
Imports Windows.ApplicationModel.Resources
Public NotInheritable Class MainPage
  ' بِسْمِ اللَّهِ الرَّحْمَـٰنِ الرَّحِيمِ
  Inherits Page
  ' * AAAA * AAAA * AAAA * AAAA *
#Region "AAAA"
#Region "A-A1"
  ' Deklaration
  Dim A_, B_, C_, D_, E_, F_, G_ As Boolean
  Dim H_, I_, J_, K_, L_, M_, N_ As Boolean

  Dim _A, _B, _C, _D, _E, _F, _G As Integer
  Dim _H, _I, _J, _K, _L, _M, _N As Integer

  Private AAA As Byte ' A:Bildschirmanwendungsnummer
  Private AAB As Byte ' A:Bildschirmanwendungsnummer
  Private AAC As Byte
  Private AAD As Byte

  Private BAA As Double ' A:Relative Zahl von Bildschirmgröße
  Dim _BA As Double
  Dim _BB As Double
  Dim _BC As Double


  Dim _AA As String
  Dim _AB As String
  Dim _AC As String
  Dim _AD As String
  Dim _AE As String
  Dim _AF As String
  Dim _AG As String
  Dim _AH As String
  Dim _AI As String
  Dim _AJ As String
  Private CAA As String ' M:Gefertigter Ausdruckstext
  Private CAB As String ' M:Gesuchte Variable
  Private CAC As String ' M:P:Kommentardefinitionsformel
  Private CAD As String ' M:P:A201 Kode für Bearbeitung
  Private CAE As String ' P:Kommentarumformungsformel
  Private CAF As String ' P:Dimensionstext
  Private CAG As String ' P:Formelnquellentext
  Private CAH As String ' M:P:Skizzeart
  Private CAI As String ' P:Letzte vom Benutzer gesuchte Dimension





  Dim _EA As New Color
  Dim _EB As New Color
  Dim _EC As New Color
  Dim _ED As New Color
  Dim _EE As New Color
  Dim _EF As New Color

  Dim _FA() As String
  Dim _FB() As String
  Dim _FC() As String
  Dim _FD() As String
  Private FAA() As String ' M:P:Gesplittete A1 Kode
  Private FAB() As String ' P:Dimensionsnamen
  Private FAC() As String ' P:Dimensionsformeln
  Private FAD() As String ' P:Dimensionsgruppen
  Private FAE() As String ' P:Definitionsformeln
  Private FAF() As String ' P:Ersetzbare Dimensionen

  Dim _GA() As Color

  Dim _HA() As Integer
  Dim _HB() As Integer
  Dim H1(50) As Integer

  Dim A_A, A_B, A_C, A_D As New ToolTip
  Dim A_E, A_F, A_G, A_H As New ToolTip

  Dim NAA As New ResourceLoader("Resources")
  Dim NAB As New ResourceLoader("Source_aa")
  Dim NAC As New ResourceLoader("Source_ab")
  Dim NAD As New ResourceLoader("Source_ac")
  Dim NAE As New ResourceLoader("Source_ad")
  Dim NAF As New ResourceLoader("A_a_a_a_a")
  Dim NAG As New ResourceLoader("A_a_a_a_b")
  Dim NAH As New ResourceLoader("B_a_a_a_a")





  Private GAA() As Control ' A:Steuerelemente Buttons
  Private Delegate Sub HAA()

  Dim IAA As New List(Of Byte) ' M:Vorzeichen vor Eingangsteiles
  Private IAB As New List(Of Byte) ' M:Ausgangsoperatorengruppe
  Private ReadOnly JAA As New List(Of Color)
  Private ReadOnly JAB As New List(Of Color)
  Private ReadOnly JAC As New List(Of Color)
  Private ReadOnly KAA As New List(Of String) ' M:Von KAC ausgewählte Ergebnisse
  Private ReadOnly KAB As New List(Of String) ' M:Kommentare für KAA
  Private KAC As New List(Of String) ' M:Von KAE ausgewählte Ergebnisse
  Private ReadOnly KAD As New List(Of String) ' M:Kommentare für KAC
  Private ReadOnly KAE As New List(Of String) ' M:Alle mögliche Ergebnisse
  Private ReadOnly KAF As New List(Of String) ' M:Kommentare für KAE
  Private ReadOnly KAG As New List(Of String) ' M:Jeder Schritt der Rechnung
  Private ReadOnly KAH As New List(Of String) ' M:Term
  Private ReadOnly KAI As New List(Of String) ' M:Operator
  Private ReadOnly KAJ As New List(Of String)
  Private ReadOnly KAK As New List(Of String)
  Private ReadOnly KAL As New List(Of String)
  Private ReadOnly LAA As New List(Of Boolean) ' M:Gesuchte Variable in Gleichung

  Private ReadOnly MAA As New List(Of Integer) ' M:Teilungsanfang
  Private ReadOnly MAB As New List(Of Integer) ' M:Funktion
  Private ReadOnly MAC As New List(Of Integer) ' M:Eingangsanfang
  Private ReadOnly MAD As New List(Of Integer) ' M:Eingangslänge
  Private ReadOnly MAE As New List(Of Integer) ' M:Eingangsteilindex
  Private ReadOnly MAF As New List(Of Integer) ' M:Ausgangsanfang
  Private ReadOnly MAG As New List(Of Integer) ' M:Ausgangslänge
  Private ReadOnly MAH As New List(Of Integer) ' M:Ausgangsteilenanzahl
  Private ReadOnly MAI As New List(Of Integer) ' M:Ausgangsteilenanfangsindex
  Private ReadOnly MAJ As New List(Of Integer) ' M:Eingangsteil-Zahl
  Private ReadOnly MAM As New List(Of Integer) ' M:Gesuchte Variable in Gleichung
  Private ReadOnly MAN As New List(Of Integer) ' M:Formelrechnungsbedingungen
  Private ReadOnly MAO As New List(Of Integer) ' P:Von FAB ausgewählte Dimensionsgruppen
  Private ReadOnly MAP As New List(Of Integer) ' P:Von FAB ausgewählte Dimensionsindexe
  Private ReadOnly MAQ As New List(Of Integer)
  Private ReadOnly MAR As New List(Of Integer)

  Private ReadOnly C1 As New List(Of Integer)
  Private ReadOnly C2 As New List(Of Integer)
  Private ReadOnly C3 As New List(Of Integer)
  Private ReadOnly C4 As New List(Of Integer)
  Private ReadOnly C5 As New List(Of Integer)
  Private ReadOnly C6 As New List(Of Integer)
  Private C7 As New List(Of Integer)
#End Region ' *****
#Region "A-A2"
  Private Function AAA1() As String()
    AAA1 = New String() {
      "I A", "II A", "III B", "IV B", "V B", "VI B", "VII B", "VIII B", "VIII B", "VIII B", "I B", "II B",
      "III A", "IV A", "V A", "VI A", "VII A", "0", "", "", "", "", "", "",
      "1 H", "2 He", "3 Li", "4 Be", "5 B", "6 C", "7 N", "8 O", "9 F", "10 Ne",
      "11 Na", "12 Mg", "13 Al", "14 Si", "15 P", "16 S", "17 Cl", "18 Ar", "19 K", "20 Ca",
      "21 Sc", "22 Ti", "23 V", "24 Cr", "25 Mn", "26 Fe", "27 Co", "28 Ni", "29 Cu", "30 Zn",
      "31 Ga", "32 Ge", "33 As", "34 Se", "35 Br", "36 Kr", "37 Rb", "38 Sr", "39 Y", "40 Zr",
      "41 Nb", "42 Mo", "43 Tc", "44 Ru", "45 Rh", "46 Pd", "47 Ag", "48 Cd", "49 In", "50 Sn",
      "51 Sb", "52 Te", "53 I", "54 Xe", "55 Cs", "56 Ba", "57 La", "58 Ce", "59 Pr", "60 Nd",
      "61 Pm", "62 Sm", "63 Eu", "64 Gd", "65 Tb", "66 Dy", "67 Ho", "68 Er", "69 Tm", "70 Yb",
      "71 Lu", "72 Hf", "73 Ta", "74 W", "75 Re", "76 Os", "77 Ir", "78 Pt", "79 Au", "80 Hg",
      "81 Tl", "82 Pb", "83 Bi", "84 Po", "85 At", "86 Rn", "87 Fr", "88 Ra", "89 Ac", "90 Th",
      "91 Pa", "92 U", "93 Np", "94 Pu", "95 Am", "96 Cm", "97 Bk", "98 Cf", "99 Es", "100 Fm",
      "101 Md", "102 No", "103 Lr", "104 Rf", "105 Db", "106 Sg", "107 Bh", "108 Hs", "109 Mt", "110 Ds",
      "111 Rg", "112 Cn", "113 Nh", "114 Fl", "115 Mc", "116 Lv", "117 Ts", "118 Og"
      }
    Return AAA1
  End Function
#End Region
#Region "A-AA"
  Private Sub AAAA() Handles AAAAA.Loaded
    Try
      A203.IsSpellCheckEnabled = False
      A204.IsSpellCheckEnabled = False
      'A101.Icon = New SymbolIcon(57615)
      'A101.Icon = New SymbolIcon(57656)
      'A101.Icon = New SymbolIcon(57808)
      'A101.Icon = New SymbolIcon(57606)
      A330.Content = NAA.GetString("S039")
      A401.Content = NAA.GetString("S011")
      A402.Content = NAA.GetString("S012")
      A403.Content = NAA.GetString("S013")
      A404.Content = NAA.GetString("S014")
      A405.Content = NAA.GetString("S015")
      A406.Content = NAA.GetString("S016")
      A407.Content = NAA.GetString("S017")
      A408.Content = NAA.GetString("S018")
      A409.Content = NAA.GetString("S019")
      A410.Content = NAA.GetString("S020")
      A_A.Content = NAA.GetString("S001")
      A_B.Content = NAA.GetString("S002")
      A_C.Content = NAA.GetString("S003")
      A_D.Content = NAA.GetString("S004")
      A_E.Content = NAA.GetString("S005")
      A_F.Content = NAA.GetString("S006")
      A_G.Content = NAA.GetString("S007")
      A_H.Content = NAA.GetString("S008")
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
      A301.Content = "1" : A302.Content = "2"
      A303.Content = "3" : A304.Content = "4"
      A305.Content = "+" : A306.Content = "*"
      A307.Content = "^" : A308.Content = "∞"
      A309.Content = "θ" : A310.Content = "Ʃ"
      A311.Content = "∏" : A312.Content = "ʃ"
      A313.Content = "5" : A314.Content = "6"
      A315.Content = "7" : A316.Content = "8"
      A317.Content = "–" : A318.Content = ":"
      A319.Content = "√" : A320.Content = "Δ"
      A321.Content = "ϕ" : A322.Content = "ln"
      A329.Content = "-" : A331.Content = "´"
      A325.Content = "9" : A326.Content = "0"
      A327.Content = "e" : A323.Content = "lim"
      A328.Content = "π" : A324.Content = "log"
      A109.Content = "A1" : A110.Content = "B1"
      A337.Content = "[" : A333.Content = "cos"
      A338.Content = "ǀ" : A334.Content = "sin"
      A339.Content = "|" : A335.Content = "tan"
      A340.Content = "]" : A336.Content = "cot"
      A341.Content = "(" : A345.Content = "acos"
      A342.Content = ")" : A346.Content = "asin"
      A343.Content = "!" : A347.Content = "atan"
      A344.Content = "→" : A348.Content = "acot"
      A332.Content = "°" : _HB = New Integer() {}
      A201.PlaceholderText = NAA.GetString("S025")
      A203.PlaceholderText = NAA.GetString("S026")
      A204.PlaceholderText = NAA.GetString("S100")
      '2     Load a setting that is local to the device
      Dim aa As ApplicationDataContainer
      aa = ApplicationData.Current.LocalSettings
      '3     Upgrade
      If aa.Values("upgrade") <> "18.02.2022" Then
        Dim ab, ac, ad, ae, af As New GradientStop
        Dim ag, ah, ai, aj, ak, al As New GradientStop
        Dim am As New LinearGradientBrush
        Dim an As New GradientStopCollection
        ab.Color = Colors.SkyBlue : ac.Color = Colors.White
        ad.Color = Colors.SkyBlue : ae.Color = Colors.White
        af.Color = Colors.SkyBlue : ag.Color = Colors.White
        ah.Color = Colors.SkyBlue : ai.Color = Colors.White
        aj.Color = Colors.SkyBlue : ak.Color = Colors.White
        al.Color = Colors.SkyBlue
        ab.Offset = 0.0 : an.Add(ab) : ac.Offset = 0.1 : an.Add(ac)
        ad.Offset = 0.2 : an.Add(ad) : ae.Offset = 0.3 : an.Add(ae)
        af.Offset = 0.4 : an.Add(af) : ag.Offset = 0.5 : an.Add(ag)
        ah.Offset = 0.6 : an.Add(ah) : ai.Offset = 0.7 : an.Add(ai)
        aj.Offset = 0.8 : an.Add(aj)
        ak.Offset = 0.9 : an.Add(ak) : al.Offset = 1.1 : an.Add(al)
        am.EndPoint = New Point(1, 1) : am.GradientStops = an
        am.StartPoint = New Point(0.1, 0) : A102.Background = am
        A402.Foreground = New SolidColorBrush(Colors.BlueViolet)
      Else
        A102.Background = New SolidColorBrush(Colors.AliceBlue)
        A402.Foreground = New SolidColorBrush(Colors.Goldenrod)
      End If
      '4     Steuerelemente
      GAA = New Control() {
               A101, A102, A103, A104, A105, A106, A107, A108, A109, A110,
               A201, A202, A203, A204,
               A301, A302, A303, A304, A305, A306, A307, A308, A309, A310,
               A311, A312, A313, A314, A315, A316, A317, A318, A319, A320,
               A321, A322, A323, A324, A325, A326, A327, A328, A329, A330,
               A331, A332, A333, A334, A335, A336, A337, A338, A339, A340,
               A341, A342, A343, A344, A345, A346, A347, A348,
               A401, A402, A403, A404, A405, A406, A407, A408, A409, A410}
      '5     Titel
      Dim title = ApplicationView.GetForCurrentView().TitleBar
      title.BackgroundColor = Colors.White
      title.ForegroundColor = Colors.Gray
      title.ButtonBackgroundColor = Colors.White
      title.ButtonForegroundColor = Colors.Gray
      title.ButtonHoverBackgroundColor = Colors.White
      title.ButtonHoverForegroundColor = Colors.Pink
      title.ButtonInactiveBackgroundColor = Colors.White
      title.ButtonInactiveForegroundColor = Colors.Gray
      title.ButtonPressedBackgroundColor = Colors.Gold
      title.ButtonPressedForegroundColor = Colors.Pink
      title.InactiveBackgroundColor = Colors.White
      title.InactiveForegroundColor = Colors.Gray
      '6     Hintergrund: Meer, Sommer, Tag
      AGAG(14, 61, Colors.White) : AGAH(0, 9, Colors.Blue)
      A001.Background = New SolidColorBrush(Colors.AliceBlue)
      A003.Background = New SolidColorBrush(Colors.AliceBlue)
      AGAH(14, 61, Colors.Blue) : AGAG(0, 9, Colors.AliceBlue)
      '7     Grids, Controls und Deklaration
      AGAI(10, 71, VerticalAlignment.Stretch) : AFAA(13, A012)
      AFAA(24, A013) : AGAJ(0, 71, HorizontalAlignment.Stretch)
      AFAB(4, A013) : AFAB(15, A012) : AFAB(20, A000)
      AFAA(16, A011) : AFAA(6, A014) : AFAB(5, A014) : AGAK(14, 61, 5)
      '8     Bildschirmformat
      AAA = 1 : AAAB() ' ! Ereignissen-Reihenfolge ER !
      '9     Rechenfarben
      _EA = Color.FromArgb(170, 170, 170, 170) : _EB = Colors.Blue
      _EC = Colors.Magenta : _ED = Colors.DeepSkyBlue
      _EE = Color.FromArgb(255, 0, 255, 120) : _EF = Colors.Orange
      _GA = New Color() {_EA, _EB, _EC, _ED, _EE, _EF}
      '10    Physikslisten
      FAB = New String() {
        "a", NAB.GetString("A001"), "1",
        "ax", NAB.GetString("A002"), "1",
        "ay", NAB.GetString("A003"), "1",
        "az", NAB.GetString("A004"), "1",
        "c", NAB.GetString("A005"), "0",
        "Ek1", NAB.GetString("A006"), "2",
        "Ek2", NAB.GetString("A007"), "2",
        "ΔEk", NAB.GetString("A008"), "2",
        "Ep1", NAB.GetString("A009"), "2",
        "Ep2", NAB.GetString("A010"), "2",
        "ΔEp", NAB.GetString("A011"), "2",
        "F", NAB.GetString("A012"), "3",
        "Fx", NAB.GetString("A013"), "3",
        "Fy", NAB.GetString("A014"), "3",
        "Fz", NAB.GetString("A015"), "3",
        "Ff", NAB.GetString("A016"), "4",
        "Ffx", NAB.GetString("A017"), "4",
        "Ffy", NAB.GetString("A018"), "4",
        "Ffz", NAB.GetString("A019"), "4",
        "|Fn|", NAB.GetString("A020"), "5",
        "Frg", NAB.GetString("A021"), "6",
        "Frgx", NAB.GetString("A022"), "6",
        "Frgy", NAB.GetString("A023"), "6",
        "Frgz", NAB.GetString("A024"), "6",
        "Frh", NAB.GetString("A025"), "7",
        "Frhx", NAB.GetString("A026"), "7",
        "Frhy", NAB.GetString("A027"), "7",
        "Frhz", NAB.GetString("A028"), "7",
        "Frr", NAB.GetString("A029"), "8",
        "Frrx", NAB.GetString("A030"), "8",
        "Frry", NAB.GetString("A031"), "8",
        "Frrz", NAB.GetString("A032"), "8",
        "Ft", NAB.GetString("A033"), "9",
        "Ftx", NAB.GetString("A034"), "9",
        "Fty", NAB.GetString("A035"), "9",
        "Ftz", NAB.GetString("A036"), "9",
        "k", NAB.GetString("A037"), "0",
        "M", NAB.GetString("A038"), "0",
        "m", NAB.GetString("A039"), "0",
        "μg", NAB.GetString("A040"), "0",
        "μh", NAB.GetString("A041"), "0",
        "μr", NAB.GetString("A042"), "0",
        "n", NAB.GetString("A043"), "0",
        "P", NAB.GetString("A044"), "0",
        "p", NAB.GetString("A045"), "10",
        "px", NAB.GetString("A046"), "10",
        "py", NAB.GetString("A047"), "10",
        "pz", NAB.GetString("A048"), "10",
        "s1", NAB.GetString("A049"), "11",
        "sx1", NAB.GetString("A050"), "11",
        "sy1", NAB.GetString("A051"), "11",
        "sz1", NAB.GetString("A052"), "11",
        "s2", NAB.GetString("A053"), "12",
        "sx2", NAB.GetString("A054"), "12",
        "sy2", NAB.GetString("A055"), "12",
        "sz2", NAB.GetString("A056"), "12",
        "Δs", NAB.GetString("A057"), "13",
        "Δsx", NAB.GetString("A058"), "13",
        "Δsy", NAB.GetString("A059"), "13",
        "Δsz", NAB.GetString("A060"), "13",
        "t1", NAB.GetString("A061"), "14",
        "t2", NAB.GetString("A062"), "14",
        "Δt", NAB.GetString("A063"), "14",
        "V", NAB.GetString("A064"), "0",
        "v", NAB.GetString("A065"), "15",
        "vx", NAB.GetString("A066"), "15",
        "vy", NAB.GetString("A067"), "15",
        "vz", NAB.GetString("A068"), "15",
        "v1", NAB.GetString("A069"), "16",
        "vx1", NAB.GetString("A070"), "16",
        "vy1", NAB.GetString("A071"), "16",
        "vz1", NAB.GetString("A072"), "16",
        "v2", NAB.GetString("A073"), "17",
        "vx2", NAB.GetString("A074"), "17",
        "vy2", NAB.GetString("A075"), "17",
        "vz2", NAB.GetString("A076"), "17",
        "Δv", NAB.GetString("A077"), "18",
        "Δvx", NAB.GetString("A078"), "18",
        "Δvy", NAB.GetString("A079"), "18",
        "Δvz", NAB.GetString("A080"), "18",
        "{v}", NAB.GetString("A081"), "19",
        "{vx}", NAB.GetString("A082"), "19",
        "{vy}", NAB.GetString("A083"), "19",
        "{vz}", NAB.GetString("A084"), "19",
        "W", NAB.GetString("A085"), "2",
        "θ", NAB.GetString("A086"), "0",
        "ϕ", NAB.GetString("A087"), "0"}
      FAF = New String() {
        "", "a", "W", "F", "Ff", "|Fn|", "Frg", "Frh", "Frr", "Ft",
        "p", "s1", "s2", "Δs", "Δt", "v", "v1", "v2", "Δv", "{v}"}
      FAE = New String() {
        NAB.GetString("A000"),
"Δs = s2 - s1   =>   Δs = s2 - s1",
"Δs = s2 - s1   =>   s1 = s2 - Δs",
"Δs = s2 - s1   =>   s2 = s1 + Δs",
"Δt = t2 - t1   =>   Δt = t2 - t1",
"Δt = t2 - t1   =>   t1 = t2 - Δt",
"Δt = t2 - t1   =>   t2 = t1 + Δt",
"Δv = v2 - v1   =>   Δv = v2 - v1",
"Δv = v2 - v1   =>   v1 = v2 - Δv",
"Δv = v2 - v1   =>   v2 = v1 + Δv",
"{v} = (v1 + v2) : 2   =>   {v} = (v1 + v2) : 2",
"{v} = (v1 + v2) : 2   =>   v1 = 2 · {v} - v2",
"{v} = (v1 + v2) : 2   =>   v2 = 2 · {v} - v1",
"Δv = 2 (v2 - {v})   =>   Δv = 2 · (v2 - {v}) *",
"Δv = 2 (v2 - {v})   =>   v2 = Δv : 2 + {v} *",
"Δv = 2 (v2 - {v})   =>   {v} = v2 - Δv : 2 *",
"Δv = 2 ({v} - v1)   =>   Δv = 2 · ({v} - v1) *",
"Δv = 2 ({v} - v1)   =>   v1 = {v} - Δv : 2 *",
"Δv = 2 ({v} - v1)   =>   {v} = v1 + Δv : 2 *",
"Δv {v} = (v2 ^ 2 - v1 ^ 2) : 2 *",
"{v} = Δs : Δt   =>   {v} = Δs : Δt",
"{v} = Δs : Δt   =>   Δs = Δt · {v}",
"{v} = Δs : Δt   =>   Δt = Δs : {v}",
"a = Δv : Δt   =>   a = Δv : Δt",
"a = Δv : Δt   =>   Δv = a · Δt",
"a = Δv : Δt   =>   Δt = Δv : a",
"F = a m   =>   F = a · m",
"F = a m   =>   a = F : m",
"F = a m   =>   m = F : a",
"W = F Δs   =>   W = F · Δs",
"W = F Δs   =>   F = W : Δs",
"W = F Δs   =>   Δs = W : F",
"W = ΔEk   =>   W = ΔEk",
"W = ΔEk   =>   ΔEk = W",
"W = -ΔEp   =>   W = -ΔEp",
"W = -ΔEp   =>   ΔEp = -W",
"ΔEk = Ek2 - Ek1   =>   ΔEk = Ek2 - Ek1",
"ΔEk = Ek2 - Ek1   =>   Ek1 = Ek2 - ΔEk",
"ΔEk = Ek2 - Ek1   =>   Ek2 = Ek1 + ΔEk",
"ΔEp = Ep2 - Ep1   =>   ΔEp = Ep2 - Ep1",
"ΔEp = Ep2 - Ep1   =>   Ep1 = Ep2 - ΔEp",
"ΔEp = Ep2 - Ep1   =>   Ep2 = Ep1 + ΔEp",
"P = W : Δt   =>   P = W : Δt",
"P = W : Δt   =>   Δt = W : P",
"P = W : Δt   =>   W = P · Δt",
"c = n : V   =>   c = n : V",
"c = n : V   =>   n = c · V",
"c = n : V   =>   V = n : c",
"M = m : n   =>   M = m : n",
"M = m : n   =>   m = M · n",
"M = m : n   =>   n = m : M",
"v = Δs : Δt   =>   v = Δs : Δt",
"v = Δs : Δt   =>   Δs = v · Δt",
"v = Δs : Δt   =>   Δt = Δs : v",
"p = m v   =>   p = m · v",
"p = m v   =>   m = p : v",
"p = m v   =>   v = p : m",
"F = -k Δs   =>   F = -k · Δs",
"F = -k Δs   =>   k = -F : Δs",
"F = -k Δs   =>   Δs = -F : k",
"P = F {v}   =>   P = F · {v} *",
"P = F {v}   =>   F = P : {v} *",
"P = F {v}   =>   {v} = P : F *",
"W = m Δv {v}   =>   W = m · Δv · {v} *",
"W = m Δv {v}   =>   m = W : Δv : {v} *",
"W = m Δv {v}   =>   Δv = W : m : {v} *",
"W = m Δv {v}   =>   {v} = W : m : Δv *",
"W = m Δv (v1 + Δv : 2)   =>   W = m · Δv · (v1 + Δv : 2) *",
"W = m Δv (v1 + Δv : 2)   =>   m = W : Δv : (v1 + Δv : 2) *",
"W = m Δv (v1 + Δv : 2)   =>   v1 = W : m : Δv - Δv : 2 *",
"W = m Δv (v1 + Δv : 2)   =>   Δv = -v1 ± √(v1 ^ 2 + 2 · W : m) *",
"W = m Δv (v2 - Δv : 2)   =>   W = m · Δv (v2 - Δv : 2)   *",
"W = m Δv (v2 - Δv : 2)   =>   m = W : Δv : (v2 - Δv : 2) *",
"W = m Δv (v2 - Δv : 2)   =>   v2 = W : m : Δv + Δv : 2 *",
"W = m Δv (v2 - Δv : 2)   =>   Δv = v2 ± √(v2 ^ 2 - 2 · W : m) *",
"F = √(-k W)   =>   F = √(-k · W) *",
"F = √(-k W)   =>   k = -(F ^ 2) : W *",
"F = √(-k W)   =>   W = -(F ^ 2) : k *",
"Δs = √(-W : k)   =>   Δs = √(-W : k) *",
"Δs = √(-W : k)   =>   k = -W : Δs ^ 2 *",
"Δs = √(-W : k)   =>   W = -k · (Δs ^ 2) *",
"W = m (v2 ^ 2 - v1 ^ 2) : 2   =>   W = m (v2 ^ 2 - v1 ^ 2) : 2 *",
"W = m (v2 ^ 2 - v1 ^ 2) : 2   =>   m = 2 W : (v2 ^ 2 - v1 ^ 2) *",
"W = m (v2 ^ 2 - v1 ^ 2) : 2   =>   v1 = √(v2 ^ 2 - 2 W : m) *",
"W = m (v2 ^ 2 - v1 ^ 2) : 2   =>   v2 = √(v1 ^ 2 + 2 W : m) *",
"F = |Fn| μg   =>   F = |Fn| μg *",
"F = |Fn| μg   =>   |Fn| = F : μg *",
"F = |Fn| μg   =>   μg = F : |Fn| *",
"F = |Fn| μh   =>   F = |Fn| μh *",
"F = |Fn| μh   =>   |Fn| = F : μh *",
"F = |Fn| μh   =>   μh = F : |Fn| *",
"F = |Fn| μr   =>   F = |Fn| μr *",
"F = |Fn| μr   =>   |Fn| = F : μr *",
"F = |Fn| μr   =>   μr = F : |Fn| *",
"W = |Fn| μg Δs   =>   W = |Fn| μg Δs *",
"W = |Fn| μg Δs   =>   |Fn| = W : μg : Δs *",
"W = |Fn| μg Δs   =>   μg = W : |Fn| : Δs *",
"W = |Fn| μg Δs   =>   Δs = W : |Fn| : μg *",
"W = |Fn| μh Δs   =>   W = |Fn| μh Δs *",
"W = |Fn| μh Δs   =>   |Fn| = W : μh : Δs *",
"W = |Fn| μh Δs   =>   μh = W : |Fn| : Δs *",
"W = |Fn| μh Δs   =>   Δs = W : |Fn| : μh *",
"W = |Fn| μr Δs   =>   W = |Fn| μr Δs *",
"W = |Fn| μr Δs   =>   |Fn| = W : μr : Δs *",
"W = |Fn| μr Δs   =>   μr = W : |Fn| : Δs *",
"W = |Fn| μr Δs   =>   Δs = W : |Fn| : μr *"}
      _FC = New String() {"a", "c", "F", "k", "M", "m", "n", "P",
      "p", "V", "v", "W", "θ", "ϕ", "ax", "ay", "az", "Ff", "Ft",
      "Fx", "Fy", "Fz", "μg", "μh", "μr", "px", "py", "pz", "s1",
      "s2", "Δs", "t1", "t2", "Δt", "v1", "v2", "vx", "vy", "vz",
      "Δv", "Ek1", "Ek2", "ΔEk", "Ep1", "Ep2", "ΔEp", "Ffx", "Ffy",
      "Ffz", "Frg", "Frh", "Frr", "Ftx", "Fty", "Ftz", "sx1", "sy1",
      "sz1", "sx2", "sy2", "sz2", "Δsx", "Δsy", "Δsz", "vx1", "vy1",
      "vz1", "vx2", "vy2", "vz2", "Δvx", "Δvy", "Δvz", "{v}", "Frgx",
      "Frgy", "Frgz", "Frhx", "Frhy", "Frhz", "Frrx", "Frry", "Frrz",
      "|Fn|", "{vx}", "{vy}", "{vz}"}
    Catch ex As Exception : End Try
  End Sub
  Private Sub AAAB() Handles AAAAA.SizeChanged
    Try : If AAA > 0 Then ' ! Ereignissen-Reihenfolge ER !
        If AAAAA.ActualWidth > 1.5 * AAAAA.ActualHeight Then
          If AAB <> 1 Then : AAB = 1
            BAA = AAAAA.ActualHeight / 500 : AEAA() : End If
        Else
          If AAB <> 2 Then : AAB = 2
            BAA = AAAAA.ActualHeight / 550 : AEAA() : End If
        End If
      End If
    Catch ex As Exception : End Try ' AAA > 0 GAA = Nothing
  End Sub
#End Region ' *****
#Region "A-AB"
  Private Sub ABAA()
    Try : A012.Opacity = 1 : If AAA > 1 Then : AFAC(A001, A011)
        AAA = 1 : AEAA()
      ElseIf A203.Visibility = 1 And AAA <> 6 Then
        AFAC(A203, A207) : If AAB = 2 Then AFAD(A204, A208)
        If AAB = 1 Then AFAF(5, A204, A208) : AFAH(8, A204, A208)
      Else
        AFAD(A203, A207) : If AAB = 2 Then AFAC(A204, A208)
        If AAB = 1 Then AFAF(0, A204, A208) : AFAH(13, A204, A208)
      End If : Catch ex As Exception : AEAZ("S001") : End Try
  End Sub
  Private Sub ABAB()
    Try : Dim aa, ab As New GradientStop : aa.Color = Colors.White
      Dim ac As New LinearGradientBrush : ab.Color = Colors.SkyBlue
      Dim ad As New GradientStopCollection From {aa, ab}
      A002.Background = ac : aa.Offset = 1 : ac.GradientStops = ad
      A003.Background = New SolidColorBrush(Colors.AliceBlue)
      ac.StartPoint = New Point(1, 0) : ac.EndPoint = New Point(0, 1)
      A401.Foreground = New SolidColorBrush(Colors.Goldenrod) : AAA = 2
      Grid.SetRow(A001, 0) : Grid.SetRow(A002, 1) : Grid.SetRow(A003, 14)
      Grid.SetRow(A011, 0) : Grid.SetRow(A012, 1) : Grid.SetRow(A014, 1)
      Grid.SetRowSpan(A002, 13) : A014.Margin = New Thickness(10 * BAA)
      AFAC(A001, A011, A014, A002) : AFAD(A012, A013, A015)
      Grid.SetRowSpan(A003, 6) : Grid.SetRowSpan(A014, 13) : A012.Opacity = 1

      AGAH(64, 71, Colors.Goldenrod) : AEAA()
    Catch ex As Exception : AEAZ("S002") : End Try
  End Sub
  Private Sub ABAC()
    ' Rechnen
    Try : AAA = 1 : AEAA() ' Quer- oder Hochformate
      A012.Opacity = 1 : If A202.Text = "" Then DAAA() Else EAAE()
    Catch ex As Exception ' : Exit Sub
      Try
        AIAJ(NAA.GetString("S028") & ": " & CAA & vbCrLf & vbCrLf)
        For i = 0 To KAH.Count - 1 Step 1
          AIAJ("IAA(" & CStr(i) & "): " & IAA(i) & vbCrLf) ' Vorzeichen
          AIAJ("IAB(" & CStr(i) & "): " & IAB(i) & vbCrLf) ' Operatorengruppe
          AIAJ("KAH(" & CStr(i) & "): " & KAH(i) & vbCrLf) ' Term
          AIAJ("KAI(" & CStr(i) & "): " & KAI(i) & vbCrLf) ' Operator
          AIAJ("MAB(" & CStr(i) & "): " & MAB(i) & vbCrLf) ' Funktion
          AIAJ("MAC(" & CStr(i) & "): " & MAC(i) & vbCrLf) ' Eingangsanfang
          AIAJ("MAD(" & CStr(i) & "): " & MAD(i) & vbCrLf) ' Eingangslänge
          AIAJ("MAE(" & CStr(i) & "): " & MAE(i) & vbCrLf) ' Quellenteilindex
          AIAJ("MAH(" & CStr(i) & "): " & MAH(i) & vbCrLf) ' Ausgangsteilenanzahl
          AIAJ("MAI(" & CStr(i) & "): " & MAI(i) & vbCrLf) ' Ausgangsteilenanfangsindex
          AIAJ("MAJ(" & CStr(i) & "): " & MAJ(i) & vbCrLf & vbCrLf) ' Eingangsteil-Zahl
        Next
      Catch ex1 As Exception : Exit Sub : End Try : End Try
  End Sub
  Private Sub ABAD()
    Try : AAA = 1 : AEAA() : A012.Opacity = 1 : AIAP(0) : AEAX() : A201.Text = ""
      AIAF(Colors.White) : Catch ex As Exception : AEAZ("S004") : End Try
  End Sub

  Private Sub ABAE()
    Try : If CAA = "" Then Exit Sub
      AAA = 1 : AEAA() : AIAP(0) : AIAB() : A012.Opacity = 1 : AIAF(Colors.White)

      If AAB = 2 Then AFAD(A203, A207) : AFAC(A204, A208) ' !!!

      If A_E.Content = NAA.GetString("S005") Then ' : A204.FontSize = BAA * 10
        For i = 0 To KAA.Count - 1 Step 1 : AIAZ() : AIAE(Colors.Blue)
          AIAJ(KAA(i).Replace(NAA.GetString("S038"), NAA.GetString("S039")) & vbCrLf)
          AIAZ() : AIAE(Colors.DeepSkyBlue) : AIAJ(KAB(i) & vbCrLf & vbCrLf)
        Next
        A_E.Content = NAA.GetString("S041")
        A105.Foreground = New SolidColorBrush(Colors.Violet)
      ElseIf A_E.Content = NAA.GetString("S041") Then
        A105.Foreground = New SolidColorBrush(Colors.Violet)
        For j = 0 To KAL.Count - 1 Step 1
          AIAZ() : AIAE(JAC(j)) : A204.Document.Selection.Text += KAL(j)
        Next
        A_E.Content = NAA.GetString("S005")
      End If
      A204.Document.Selection.StartPosition = 0
      A204.Document.Selection.EndPosition = A204.Document.Selection.StoryLength
      A204.FontFamily = New FontFamily("Consolas") ' Segoe UI
      'A204.FontSize = BAA * 10
      'A204.Document.Selection.CharacterFormat.Weight = 0
      A204.Document.Selection.CharacterFormat.Spacing = 1

    Catch ex As Exception : AEAZ("S005") : End Try
  End Sub
  Private Sub ABAF()
    Try : If CAF = "" Then Exit Sub

      If AAB = 2 Then AFAD(A203, A207) : AFAC(A204, A208) ' !!!

      AAA = 1 : AEAA() : A012.Opacity = 1 : AIAB() : AIAH(CAF)
      AIAP(10) : AIAE(Colors.Blue)
      AIAF(Colors.White) : Catch ex As Exception : AEAZ("S006")
    End Try
  End Sub
  Private Sub ABAG()
    Try
      If CAG = "" Then Exit Sub ' Fehlervermeiden beim unnötigen Klick auf "Quelle"
      Dim aa() As String ' Für vbLf-Textsplit des CAG mit Formeln und Definitionen
      AAA = 1 ' Es wird angegeben, dass die Startseite wiederhergestellt werden soll
      AEAA() ' Die Startseite wird wiederhergestellt in Hochformat oder Querformat
      AIAP(0) ' Der Zeilenabstand zwischen Zeilen in A204 wird in 0 wiederhergestellt
      AIAB() ' Löschen des möglichen Inhalts von A204 und Vorbereitung für neue Eingabe
      A012.Opacity = 1 ' Volle Sichtbarkeit für A203 und A204 gegen "Darstellung"
      AIAF(Colors.White) ' Weiße Hintergrundsfarbe für A204 gegen Inhalte vom Anhang
      aa = CAG.Split(vbLf) ' vbLf-Textsplit des CAG mit Formeln und ihre Definitionen

      If AAB = 2 Then : AFAD(A203, A207) : AFAC(A204, A208) : End If ' Bei H-Format
      For i = 0 To aa.Count - 1 Step 2 ' Schleife aller gesplitteten Texte der Liste
        AIAZ() ' Start- und Endpositionen von A204 sind an dem Ende des Dokuments
        AIAE(Colors.Blue) ' Die blaue Textfarbe des A204 vor Einfügung des Textes
        AIAJ(aa(i) & vbCrLf) ' Die Definitionsformel oder davon erhaltene Formel 
        AIAZ() ' Start- und Endpositionen von A204 sind an dem Ende des Dokuments
        AIAE(Colors.DeepSkyBlue) ' Die DeepSkyBlue Textfarbe in A204 des Kommentars
        AIAJ(aa(i + 1) & vbCrLf & vbCrLf) ' Die Definitionsformel unter ihre Formel
      Next
    Catch ex As Exception : AEAZ("S007") : End Try
  End Sub
  Private Sub ABAH()
    Try : AAA = 1 : AEAA() : A012.Opacity = 0.3
    Catch ex As Exception : AEAZ("S008") : End Try
  End Sub
  Private Sub ABAI()
    If A109.Content = "A1" Then
      A109.Content = "A2"
      A105.Visibility = Visibility.Collapsed
      A106.Visibility = Visibility.Collapsed
      A107.Visibility = Visibility.Visible
      A108.Visibility = Visibility.Visible
    Else
      A109.Content = "A1"
      A105.Visibility = Visibility.Visible
      A106.Visibility = Visibility.Visible
      A107.Visibility = Visibility.Collapsed
      A108.Visibility = Visibility.Collapsed
    End If
  End Sub
  Private Sub ABAJ()
    If A110.Content = "B1" Then : A110.Content = "B2"
      AGAB(22, 25) : AGAB(34, 37) : AGAB(46, 49) : AGAB(58, 61)
      AGAC(14, 21) : AGAC(26, 33) : AGAC(38, 45) : AGAC(50, 57)
    Else : A110.Content = "B1"
      AGAB(14, 21) : AGAB(26, 33) : AGAB(38, 45) : AGAB(50, 57)
      AGAC(22, 25) : AGAC(34, 37) : AGAC(46, 49) : AGAC(58, 61)
    End If
  End Sub

  Private Sub ABOA(a As Button, b As RoutedEventArgs)
    A203.Document.Selection.Text += a.Content
    'A201.Text += "AAA   " & FocusState.ToString()
    'If A201.FocusState = 1 Then
    '    A201.Text += a.Content
    'End If
    'If A203.FocusState = 1 Then
    '    A203.Document.Selection.Text += a.Content
    'End If
  End Sub
  Private Sub ABOB(a As Button, b As RoutedEventArgs)
    A203.Document.Selection.Text += " - "
  End Sub
  Private Sub ABOC(a As Button, b As RoutedEventArgs)
    A203.Document.Selection.Text += " " & a.Content & " "
  End Sub
  Private Sub ABOD(a As Button, b As RoutedEventArgs)
    Dim aa As String = a.Content
    Dim ab As Integer = A203.Document.Selection.StartPosition
    A203.Document.Selection.Text += a.Content & "()"
    ab += aa.Length + 1 : A203.Document.Selection.StartPosition = ab
  End Sub
  Private Sub ABOE(a As Button, b As RoutedEventArgs)
    Dim aa As String = a.Content : AIAS()
    Dim ab As Integer = A203.Document.Selection.StartPosition
    AIAI(a.Content & "(')") : ab += aa.Length + 1 : AIAK(ab)
  End Sub
  Private Sub ABOF(a As Button, b As RoutedEventArgs)
    Dim aa As String = a.Content : AIAS()
    Dim ab As Integer = A203.Document.Selection.StartPosition
    AIAI(a.Content & "('')") : ab += aa.Length + 1 : AIAK(ab)
  End Sub
  Private Sub ABOG(a As Button, b As RoutedEventArgs)
    Dim aa As String = a.Content : AIAS()
    Dim ab As Integer = A203.Document.Selection.StartPosition
    AIAI(a.Content & "(''d())") : ab += aa.Length + 1 : AIAK(ab)
  End Sub
#End Region ' *****
#Region "A-AC"
  Private Sub ACAA()
    AAA = 3 : AEAA() : AIAB() : AIAM(0) : AIAP(20)
    A204.FontFamily = New FontFamily("Segoe UI")
    AIAH(NAE.GetString("S001")) : AIAE(Colors.Blue)
    AIAF(Colors.White)
    'A401.NavigateUri = New Uri("http://www.bing.com")
  End Sub
  Private Sub ACAB()
    'Save a setting locally on the device
    Dim aa As ApplicationDataContainer
    aa = ApplicationData.Current.LocalSettings
    aa.Values("upgrade") = "01.06.2024"
    A102.Background = New SolidColorBrush(Colors.AliceBlue)
    A402.Foreground = New SolidColorBrush(Colors.Goldenrod)
    AAA = 3 : AEAA() : AIAB() : AIAM(0) : AIAP(20)
    AIAH(NAE.GetString("S002")) : AIAE(Colors.Blue)
    AIAF(Colors.White)
    A204.FontFamily = New FontFamily("Segoe UI")

    '        'Private Async Sub P1_Loaded(...)
    '        '    !!! Async bei Sub-Deklaration erforderlich !!!!

    '        '    'Deklaration
    '        '    Dim aaaaa As StorageFile
    '        '    Dim aaaab As StorageFolder

    '        '    'Eine Datei erstellen
    '        '    aaaab = ApplicationData.Current.LocalFolder
    '        '    Await aaaab.CreateFileAsync("MOWSN W1 TERWAR T1000 CALCULATOR C10.txt", CreationCollisionOption.FailIfExists)

    '        '    'In eine Datei schreiben
    '        '    aaaab = ApplicationData.Current.LocalFolder
    '        '    aaaaa = Await aaaab.WriteFileAsync("MOWSN W1 TERWAR T1000 CALCULATOR C10.txt")
    '        '    Await FileIO.WriteTextAsync(aaaaa, a) ' Swift as a shadow

    '        '    'Aus einer Datei lesen
    '        '    aaaab = ApplicationData.Current.LocalFolder
    '        '    aaaaa = Await aaaab.GetFileAsync("MOWSN W1 TERWAR T1000 CALCULATOR C10.txt")
    '        '    BAA1 = Await FileIO.ReadTextAsync(aaaab)

    '        'End Sub

    'Dim Uri As New Uri("ms-appx:///Assets/Dokumentik.rtf")
    'aaaaa = Await StorageFile.GetFileFromApplicationUriAsync(Uri)
    'Dim aaaab As Streams.IRandomAccessStream = Await aaaaa.OpenAsync(FileAccessMode.Read)
    'A204.Document.LoadFromStream(TextSetOptions.FormatRtf, aaaab)
  End Sub
  Private Sub ACAC()
    Dim aa, ad() As String : Dim ab, ac As Integer
    A204.FontFamily = New FontFamily("Segoe UI")
    AAA = 3 : AEAA()
    aa = NAE.GetString("S003") : aa = aa.Replace(vbLf & vbLf, "")
    aa = aa.Replace(vbLf, "") : ad = aa.Split("#")
    AIAB() : AIAM(0) : AIAP(0) : AIAJ(ad(0))
    ac = ab + ad(0).Length + 1 : AIAM(ab) : AIAN(ac) : AIAF(Colors.White)
    For i = 0 To 18 Step 2
      AIAE(Colors.Gray) : ab = ac : AIAJ(vbLf & ad(i + 1))
      ac = ab + ad(i + 1).Length + 1 : AIAM(ab) : AIAN(ac) ' 1-20
      AIAE(Colors.Blue) : ab = ac : AIAJ(vbLf & vbLf & ad(i + 2))
      ac = ab + ad(i + 2).Length + 2 : AIAM(ab) : AIAN(ac)
    Next
    AIAE(Colors.Gray) : ab = ac : AIAJ(vbLf & ad(21))
    ac = ab + ad(21).Length + 1 : AIAM(ab) : AIAN(ac) : AIAE(Colors.Blue) ' 21
  End Sub
  Private Sub ACAD()
    Dim aa, ad() As String : Dim ab, ac As Integer : AAA = 3 : AEAA() : AIAB() : AIAM(0) : AIAP(5)
    aa = NAE.GetString("S004") : aa = aa.Replace(vbLf & vbLf, "") : aa = aa.Replace(vbLf, "")
    ad = aa.Split("#") : AIAJ(ad(0)) : ac = ab + ad(0).Length : AIAM(ab) : AIAN(ac) : AIAF(Colors.White)
    AIAE(Colors.Gray) : ab = ac : AIAJ(vbLf & ad(1)) : ac = ab + ad(1).Length + 1 : AIAM(ab) : AIAN(ac)
    AIAE(Colors.DeepPink) : ab = ac : AIAJ(vbLf & ad(2)) : ac = ab + ad(2).Length + 1 : AIAM(ab) : AIAN(ac)
    AIAE(Colors.Blue) : ab = ac : AIAJ(vbLf & vbLf & ad(3)) : ac = ab + ad(3).Length + 2 : AIAM(ab) : AIAN(ac)
    AIAE(Colors.Gray) : ab = ac : AIAJ(vbLf & ad(4)) : ac = ab + ad(4).Length + 1 : AIAM(ab) : AIAN(ac)
    AIAE(Colors.DeepPink) : ab = ac : AIAJ(vbLf & ad(5)) : ac = ab + ad(5).Length + 2 : AIAM(ab) : AIAN(ac)
    AIAE(Colors.Blue) : ab = ac : AIAJ(vbLf & vbLf & ad(6)) : ac = ab + ad(6).Length + 2 : AIAM(ab) : AIAN(ac)
    AIAE(Colors.Gray) : ab = ac : AIAJ(vbLf & ad(7)) : ac = ab + ad(7).Length + 1 : AIAM(ab) : AIAN(ac)
    AIAE(Colors.DeepPink) : ab = ac : AIAJ(vbLf & ad(8)) : ac = ab + ad(8).Length + 2 : AIAM(ab) : AIAN(ac)
    AIAE(Colors.Blue) : A204.FontFamily = New FontFamily("Calibri")
  End Sub
  Private Sub ACAE()
    Dim aa As String : Dim ab, ac As Integer
    A204.FontFamily = New FontFamily("Consolas")
    AAA = 3 : AEAA() : AIAB()
    AIAM(0) : AIAP(0) : aa = NAA.GetString("S006")
    AIAJ("     " & aa & "     " & vbLf & vbLf & vbLf)
    ac = ab + aa.Length + 13 : AIAM(ab) : AIAN(ac)
    AIAF(Colors.AliceBlue) : AIAE(Colors.Gray) : aa = ""
    For i = 1 To 87 Step 1
      If i > 9 Then aa &= NAH.GetString("B0" & i.ToString()) &
        " = " & NAB.GetString("A0" & i.ToString()) & vbLf
      If i < 10 Then aa &= NAH.GetString("B00" & i.ToString()) &
        " = " & NAB.GetString("A00" & i.ToString()) & vbLf
    Next
    ab = ac : AIAJ(aa) : ac = ab + aa.Length + 87 : AIAM(ab)
    AIAN(ac) : AIAE(Colors.Blue) : AIAF(Colors.White) : AIAP(10)
  End Sub
  Private Sub ACAF()
    Dim aa, ad() As String : Dim ab, ac As Integer
    A204.FontFamily = New FontFamily("Calibri")
    AIAB() : AIAM(0) : AIAP(5)
    aa = NAE.GetString("S005") : aa = aa.Replace(vbLf & vbLf, "")
    aa = aa.Replace(vbLf, "")
    ad = aa.Split("#") : AIAJ("     " & ad(1) & "     (" &
                              NAA.GetString("S100") & ")" & vbLf & vbLf)
    ac = ab + ad(1).Length + 12 + NAA.GetString("S100").Length + 2
    AIAM(ab) : AIAN(ac) : AIAF(Colors.AliceBlue) : AIAE(Colors.Gray)
    ab = ac : aa = "c = n / V" & vbLf & "M = m / n"
    AAA = 3 : AEAA() : AIAJ(aa) : ac = ab + aa.Length : AIAM(ab)
    AIAN(ac) : AIAE(Colors.Blue) : AIAF(Colors.White)
  End Sub
  Private Sub ACAG()
    Dim aa, ad() As String : Dim ab, ac As Integer
    A204.FontFamily = New FontFamily("Consolas")
    AAA = 3 : AEAA() : AIAB() : AIAM(0) : AIAP(5)
    aa = NAE.GetString("S005") : aa = aa.Replace(vbLf & vbLf, "")
    aa = aa.Replace(vbLf, "") : ad = aa.Split("#")
    AIAJ("     " & ad(2) & "     (" & NAA.GetString("S100") & ")" & vbLf & vbLf)
    ac = ab + ad(2).Length + 12 + NAA.GetString("S100").Length + 2
    AIAM(ab) : AIAN(ac) : AIAF(Colors.AliceBlue) : AIAE(Colors.Gray)
    AIAJ(ad(4) & vbLf) : ab = ac : ac = ab + ad(4).Length + 1 : AIAM(ab)
    AIAN(ac) : AIAF(Colors.White) : AIAE(Colors.LimeGreen)
    aa = "a = Δv / Δt
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
W = -ΔEp"
    AIAJ(aa & vbLf & vbLf) : ab = ac : ac = ab + aa.Length - 17
    AIAM(ab) : AIAN(ac) : AIAE(Colors.Blue)
    AIAJ(ad(5) & vbLf) : ab = ac : ac = ab + ad(5).Length + 1
    AIAM(ab) : AIAN(ac) : AIAE(Colors.Green)
    aa = "F = ΣF"
    AIAJ(aa & vbLf & vbLf) : ab = ac : ac = ab + aa.Length + 2
    AIAM(ab) : AIAN(ac) : AIAE(Colors.Blue)
    AIAJ(ad(6) & vbLf) : ab = ac : ac = ab + ad(6).Length + 1
    AIAM(ab) : AIAN(ac) : AIAE(Colors.Green)
    aa = "A = Ax
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
A = √(Ax2 + Ay2 + Az2)"
    AIAJ(aa & vbLf) : ab = ac : ac = ab + aa.Length - 10
    AIAM(ab) : AIAN(ac) : AIAE(Colors.Blue)
  End Sub
  Private Sub ACAH()
    Dim aa, ab(), ac() As String : Dim ad, ae, af() As Integer
    A204.FontFamily = New FontFamily("Consolas")
    AIAB() : AIAM(0) : AIAP(5) : AAA = 3 : AEAA()
    aa = NAE.GetString("S005") : aa = aa.Replace(vbLf & vbLf, "")
    aa = aa.Replace(vbLf, "") : ab = aa.Split("#")
    AIAJ("     " & ab(3) & "     (" & NAA.GetString("S100") & ")")
    ae = ad + ab(3).Length + 10 + NAA.GetString("S100").Length + 2
    AIAM(ad) : AIAN(ae) : AIAF(Colors.AliceBlue)
    AIAE(Colors.Gray) : AIAJ(vbLf & vbLf) : ad = ae : ae = ad + 2
    AIAM(ad) : AIAN(ae) : AIAF(Colors.White)
    ac = New String() {
            "a = a",
            "a = b",
            "e = 2,718281828",
            "π = 3,141592654",
            "(a) = a",
            "a + (b +- c) = a + b +- c",
            "a - (b +- c) = a - b -+ c",
            "a · (b ·: c) = a · b ·: c",
            "a : (b ·: c) = a : b :· c",
            "|-a| = |a|",
            "|a| = a    a ≥ 0",
            "|a| = -a   a < 0",
            "a +- 0 = a",
            "a · 0 = 0",
            "a ^ 0 = 1",
            "a / 0 = ∞",
            "a ·: 1 = a",
            "a ^ 1 = a",
            "a - a = 0",
            "a / a = 1",
            "a + -b = a - b",
            "a - -b = a + b",
            "-a ·: -b = a ·: b",
            "a ·: -b = -a ·: b",
            "cos(a) = b",
            "sin(a) = b",
            "tan(a) = b",
            "cot(a) = b",
            "acos(a) = b",
            "asin(a) = b",
            "atan(a) = b",
            "acot(a) = b",
            "ln(a) = b",
            "ln(e) = 1",
            "log(a ' b) = с",
            "a! = a · (a - 1) · ... · 1    a < 170",
            "a´ = 0",
            "b + a = a + b",
            "b · a = a · b",
            "(a + b) · c = a · c + b · c",
            "(a + b) : c = a : c + b : c",
            "(a - b) · c = a · c - b · c",
            "(a - b) : c = a : c - b : c",
            "(a + b) · (c + d) = a c + a d + b c + b d",
            "a + a = a · (1 + 1)",
            "a · c + b · c = (a + b) · c",
            "a ± b : c = (a c ± b) / c",
            "a : b ± c = (a ± c b) / b",
            "a : b ± c : b = (a ± c) / b",
            "a : b ± c : d = (a d ± c b) / b : d",
            "a · a = a ^ 2",
            "a ^ b ^ c = a ^ (b · c)",
            "a ^ b ·: a ^ c = a ^ (b ± c)",
            "a ^ (b +- c) = a ^ b ·: a ^ c",
            "a ^ b ^ c = a ^ (b · c)",
            "(a ·: b) ^ c = a ^ c ·: b ^ c",
            "a ^ b = c => a = √(c ' b)",
            "a ^ (b ± c) = a ^ b ·: a ^ c",
            "a ^ c ·: b ^ c = (a ·: b) ^ c",
            "(a ·: b) ^ c = a ^ c ·: b ^ c",
            "a ^ -b = 1 : a ^ b",
            "a ^ b = 1 : a ^ -b",
            "a ˄ (b ·: c) = a ˄ b ˄˅ c",
            "√(a ·: b) = √(a) ·: √(b)",
            "√(a) ·: √(b) = √(a ·: b)",
            "√(a ·: b ' c) = √(a ' c) ·: √(b ' c)",
            "√(a ' c) ·: √(b ' c) = √(a ·: b ' c)",
            "√(a ' c) = a ^ (1 : c)",
            "lim(a → ∞ ' b ^ a) = 0, |b| < 1",
            "log(a ' b) = ln(b) : ln(a)",
            "Ʃ(a = 1 ' b ' a) = b (b + 1) : 2",
            "Ʃ(a = 1 ' b ' a ^ 2) = (2 b ^ 3 + 3 b ^ 2 + b) : 6",
            "Ʃ(a = 1 ' b ' a ^ 3) = (b ^ 4 + 2 b ^ 3 + b ^ 2) : 4",
            "Ʃ(a = 0 ' b ' c ^ a) = (1 - c ^ (b + 1)) : (1 - c)",
            "∏(a = 1 ' b ' a) = b!",
            "ʃ(a ' b ' c · d(c)) = (b ^ 2 - a ^ 2) : 2",
            "a = b +- c => a -+ c = b",
            "a = b ·: c => a :· c = b",
            "a = b +· c => a -: b = c",
            "a = b -: c => b -: a = c",
            "a +- b = c => a = c -+ b",
            "a ·: b = c => a = c :· b",
            "a +· b = c => b = c -: a",
            "a -: b = c => b = a -: c",
            "-a = b => a = -b",
            "a ^ 2 b + a c + d = 0 => a = (-c ± √ (c ^ 2 - 4 a d)) : 2 : b",
            "a ^ b = e ^ (b · ln(a))",
            "e ^ ln(a) = a",
            "log(a ' b · c) = log(a ' b) + log(a ' c)",
            "ln(a ·: b) = ln(a) +- ln(b)",
            "ln(a ^ b) = b · ln(a)",
            "ln(e ^ a) = a",
            "..."}
    af = New Integer() {
            0, 0, 1, 1, 2, 2, 3, 3, 4, 8, 9, 11, 12, 15, 16, 17, 18, 19, 20, 23, 24, 31, 32, 34, 35, 35, 36, 36, 37,
            38, 39, 43, 44, 45, 46, 49, 50, 62, 63, 67, 68, 68, 69, 69, 70, 73, 74, 74, 75, 75, 76, 84, 85, 85, 86, 92}
    For i = 0 To af.Count - 2 Step 2 : aa = ""
      For j = af(i) To af(i + 1) Step 1 : aa &= ac(j) & vbLf : Next
      ad = ae
      AIAJ(ab(i / 2 + 7) & vbLf) : ae = ad + ab(i / 2 + 7).Length + 1
      AIAM(ad) : AIAN(ae) : ad = ae : AIAE(Colors.Magenta)
      ae = ad + aa.Length + 1 : AIAJ(aa & vbLf) : AIAM(ad) : AIAN(ae)
      AIAE(Colors.Blue)
    Next
  End Sub
  Private Sub ACAI()
    Dim aa, ad() As String : aa = NAE.GetString("S005")
    A204.FontFamily = New FontFamily("Consolas")
    AAA = 3 ' zuerst AAA dann AEAA
    AEAA() : aa = aa.Replace(vbLf & vbLf, "")
    aa = aa.Replace(vbLf, "") : ad = aa.Split("#") : AIAB()
    AIAM(0) : AIAP(0) : aa = "     " & ad(35) & "     "
    aa = aa.Substring(0, 25) : AIAJ(aa & vbLf & vbLf)
    AIAM(0) : AIAN(27) : AIAF(Colors.AliceBlue)
    AIAE(Colors.Gray) : aa = ad(36) & "                    "
    aa = aa.Substring(0, 32) & ad(37)
    AIAJ(aa & vbLf & vbLf) : AIAM(27) : AIAE(Colors.Blue) ' 43 + 27 = 70
    aa = "" &
        "a ^ b                           ab" & vbLf & vbLf &
        "a ˟ √(b)                        a√b" & vbLf & vbLf &
        "√(a ' b)                        b√a" & vbLf & vbLf &
        "log(a ' b)                      logab" & vbLf & vbLf &
        "lim(a ' b)                      limab" & vbLf & vbLf &
        "Ʃ(a ' b ' c)                    Ʃab c" & vbLf & vbLf &
        "∏(a ' b ' c)                    ∏ab c" & vbLf & vbLf &
        "∫(a ' b ' x d(x))               a∫b x dx" ' 69 + 1 = 70
    '32 Zeichen zwischen rechten Seite und Rand (+ 70 obere)
    '70-102, 106-138, 143-175, 180-212, 219-251, 258-290, 297-329, 336-368
    AIAJ(aa) : AHAA(215, 216, 254, 255, 291, 292, 330, 331, 368, 369)
    AHAB(103, 104, 138, 139, 175, 176, 292, 293, 331, 332, 370, 371)
  End Sub
  Private Sub ACAJ()
    AAA = 4 : AEAA() : AFAC(A002, A015) : AFAD(A012, A013, A014)
  End Sub
#End Region ' *****
#Region "A-AD"
  Private Sub ADAA(sender As AutoSuggestBox, e As AutoSuggestBoxTextChangedEventArgs)
    Try
      Dim aaaab As New List(Of String)
      '1     Löschen alter Definitionen
      AEAX() : If A201.Text = "" Then Exit Sub
      '2     Autosuggestboxsplit
      FAA = A201.Text.TrimEnd(" ").Split(" ")
      '3     Aufgabe-Platz-Zeiger
      If A201.Text = NAA.GetString("S021") Or A201.Text = NAA.GetString("S022") Or A201.Text = "" Then
        A203.PlaceholderText = NAA.GetString("S026")
      End If
      '4     Gleichung-Platz-Zeiger
      If A201.Text.Length > 1 Then
        If A201.Text.Substring(0, 2) = NAA.GetString("S023") Or
                    A201.Text.Substring(0, 2) = NAA.GetString("S024") Then
          A203.PlaceholderText = NAA.GetString("S027")
        End If
      End If
      '5     Formelsuche
      If FAA.Count > 0 Then EAAA() : EAAB()
      '6     Filterung der Kods nach eingegebene Zeichen
      If CAI <> "" Then
        For i = 0 To FAC.Count - 5 Step 5
          If FAC(i).Length >= A201.Text.Length Then
            If A201.Text = FAC(i).Substring(0, A201.Text.Length) Then aaaab.Add(FAC(i))
          End If
        Next
      End If
      '7     Auswahl eines Vorschlags
      If e.Reason = AutoSuggestionBoxTextChangeReason.UserInput Then
        If aaaab.Count > 0 Then
          sender.ItemsSource = aaaab
          If A201.Text = aaaab(0) Then sender.ItemsSource = Nothing
        End If
        If A201.Text.Length = 0 Then sender.ItemsSource = Nothing
        If aaaab.Count = 0 Then sender.ItemsSource = Nothing
      End If
    Catch ex As Exception
      A204.Document.SetText(TextSetOptions.FormatRtf, "")
      A204.Document.Selection.Text = NAA.GetString("S028") & " A1"
      'A204.Document.Selection.Text += ex.HelpLink & vbCrLf
      'A204.Document.Selection.Text += ex.Message & vbCrLf
      'A204.Document.Selection.Text += ex.Source & vbCrLf
      'A204.Document.Selection.Text += ex.StackTrace & vbCrLf
    End Try
  End Sub
#End Region ' *****
#Region "A-AE"
  Private Sub AEAA()
    'Q-Format
    If AAB = 1 Then
      'Q-Allgemein
      If AAA > 0 Then
        AGAA(0, 0, 9, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9)
        A011.Margin = New Thickness(30 * BAA, 0, 0, 0)
        A012.Margin = New Thickness(50 * BAA, 0, 0, 10)
        A013.Margin = New Thickness(30 * BAA, 0, 0, 10)
        AFAD(A109, A110) : AGAE(1, 0, 9) : AGAB(0, 7)
      End If
      'Q-Startseite
      If AAA = 1 Then
        AFAG(0, A001, A011) : AGAE(1, 14, 61)
        AGAB(14, 61) : AFAD(A002, A014, A015)
        AFAI(12, A012, A203, A204, A207, A208)
        Grid.SetRow(A012, 1) : Grid.SetRowSpan(A003, 1)
        Grid.SetRow(A003, 13) : Grid.SetRowSpan(A013, 6)
        Grid.SetRow(A013, 14) : Grid.SetRowSpan(A348, 1)
        AGAA(0, 14, 25, 0, 1, 2, 3, 5, 6, 7, 8, 10, 11, 12, 13)
        AGAA(1, 26, 37, 0, 1, 2, 3, 5, 6, 7, 8, 10, 11, 12, 13)
        AGAA(2, 38, 49, 0, 1, 2, 3, 5, 6, 7, 8, 10, 11, 12, 13)
        AGAA(3, 50, 61, 0, 1, 2, 3, 5, 6, 7, 8, 10, 11, 12, 13)
        AFAG(1, A201, A202, A205, A206) : AFAG(3, A203, A204, A207, A208)
        AFAF(0, A201, A203, A205, A207) : AFAF(5, A202, A204, A206, A208)
        AFAH(5, A201, A203, A205, A207) : AFAH(8, A202, A204, A206, A208)
        AFAC(A012, A013, A201, A202, A203, A204, A205, A206, A207, A208)
      End If
      'Q-Anhangsseite
      If AAA = 2 Then : AGAE(1, 62, 71)
        Grid.SetColumn(A401, 0) : Grid.SetRow(A401, 0)
        Grid.SetColumn(A402, 0) : Grid.SetRow(A402, 1)
        Grid.SetColumn(A403, 0) : Grid.SetRow(A403, 2)
        Grid.SetColumn(A404, 0) : Grid.SetRow(A404, 3)
        Grid.SetColumn(A405, 0) : Grid.SetRow(A405, 4)
        Grid.SetColumn(A406, 1) : Grid.SetRow(A406, 0)
        Grid.SetColumn(A407, 1) : Grid.SetRow(A407, 1)
        Grid.SetColumn(A408, 1) : Grid.SetRow(A408, 2)
        Grid.SetColumn(A409, 1) : Grid.SetRow(A409, 3)
        Grid.SetColumn(A410, 1) : Grid.SetRow(A410, 4)
      End If
      'Q-Listenseite
      If AAA = 3 Then
        AFAD(A002, A014, A203, A207)
        AFAF(0, A202, A204, A206, A208) : AFAG(1, A202, A206)
        AFAC(A012, A202, A204, A206, A208) : AFAG(3, A204, A208)
        Grid.SetRowSpan(A204, 12) : Grid.SetRowSpan(A208, 12)
        Grid.SetColumnSpan(A201, 5) : Grid.SetColumnSpan(A202, 8)
        Grid.SetColumnSpan(A204, 13) : Grid.SetColumnSpan(A205, 5)
        Grid.SetColumnSpan(A206, 8) : Grid.SetColumnSpan(A208, 13)
      End If
      'Q-Tabelleseite
      If AAA = 4 Then
        If A501.Children.Count = 0 Then : Dim aa As String
          Dim ab As Button : AFAA(20, A501) : AFAB(11, A501)
          A015.Margin = New Thickness(10 * BAA)
          Grid.SetRow(A003, 16) : Grid.SetRowSpan(A003, 4)
          Grid.SetRowSpan(A015, 15) : Grid.SetRow(A015, 1)
          ' Buttons
          For i = 1 To 150 Step 1 : Dim ac As New TextBlock
            ab = New Button With {
              .FontFamily = New FontFamily("Calibri Light"),
              .Background = New SolidColorBrush(BBAA(i - 1)),
              .VerticalAlignment = 3, .HorizontalAlignment = 3,
              .Padding = New Thickness(0), .FontSize = 7.5 * BAA,
              .Content = ac, .Margin = New Thickness(0.5 * BAA)}
            ' Text-Unterschiede
            Select Case i : Case > 0, < 8 : ac.Text = CStr(i)
              Case > 7, < 15
                ac.Text = NAC.GetString("B00" & CStr((i - 7)))
              Case > 14, < 33
                If i < 24 Then aa = "B00" Else aa = "B0"
                ac.Text = CStr((i - 14)) & vbLf &
                  NAF.GetString(aa & CStr((i - 14)))
              Case > 32, < 151
                Dim ad, ae As New Documents.Run : aa = "A00"
                If i > 41 Then aa = "A0" : If i > 131 Then aa = "A"
                ad.Text = NAF.GetString(aa & CStr((i - 32))) & vbLf
                ac.Inlines.Add(ad) : ad.FontSize = 9 * BAA
                ae.Text = vbLf & NAC.GetString(aa & CStr((i - 32)))
                ac.Inlines.Add(ae) : ae.FontSize = 6 * BAA
            End Select
            ' Farbe-Unterschiede
            Select Case BBAA(i - 1)
              Case Colors.Gray, Colors.Olive, Colors.DarkViolet
                ab.Foreground = New SolidColorBrush(Colors.White)
            End Select
            ' Fertigung der Erzeugung
            A501.Children.Add(ab) : aa = "C00"
            If i > 9 Then aa = "C0" : If i > 99 Then aa = "C"
            Grid.SetRow(ab, CInt(NAF.GetString(aa & CStr(i))))
            aa = "D00" : AddHandler ab.Click, AddressOf BAAD
            If i > 9 Then aa = "D0" : If i > 99 Then aa = "D"
            Grid.SetColumn(ab, CInt(NAF.GetString(aa & CStr(i))))
          Next
        End If
        A501.Visibility = 0 : A502.Visibility = 1
        A503.Visibility = 1
        Grid.SetColumnSpan(A501.Children.Item(7), 2)
        Grid.SetColumnSpan(A501.Children.Item(9), 5)
        Grid.SetColumnSpan(A501.Children.Item(8), 11)
      End If
      'Q-Elementseite
      If AAA = 5 Then
        BAAC(200) : End If
    End If
    'H-Format
    If AAB = 2 Then
      'H-Allgemein
      If AAA > 0 Then
        AGAA(0, 0, 9, 0, 2, 4, 6, 8, 10, 8, 10, 12, 14)
        A011.Margin = New Thickness(10 * BAA, 0, 20 * BAA, 0)
        A012.Margin = New Thickness(20 * BAA, 0, 30 * BAA, 10)
        A013.Margin = New Thickness(10 * BAA, 0, 20 * BAA, 10)
        AFAC(A109, A110) : AGAE(2, 0, 9)
      End If
      'H-Startseite
      If AAA = 1 Then
        Grid.SetRow(A012, 0) : Grid.SetRow(A003, 13)
        Grid.SetRow(A013, 14) : Grid.SetRowSpan(A003, 1)
        Grid.SetRowSpan(A013, 6) : Grid.SetRowSpan(A012, 13)
        AFAG(13, A001, A011) : AFAG(5, A203, A204, A207, A208)
        AFAI(10, A203, A204, A207, A208) : AFAG(3, A202, A206)
        AFAF(0, A201, A202, A203, A204, A205, A206, A207, A208)
        AFAH(13, A201, A202, A203, A204, A205, A206, A207, A208)
        AFAG(1, A201, A205) : AFAD(A002, A014, A015, A204, A208)
        AGAA(0, 14, 25, 0, 3, 6, 9, 12, 15, 18, 21, 0, 6, 12, 18)
        AGAA(1, 26, 37, 0, 3, 6, 9, 12, 15, 18, 21, 3, 9, 15, 21)
        AGAA(2, 38, 49, 0, 3, 6, 9, 12, 15, 18, 21, 0, 6, 12, 18)
        AGAA(3, 50, 61, 0, 3, 6, 9, 12, 15, 18, 21, 3, 9, 15, 21)
        AFAC(A012, A013, A202, A203, A206, A207) : AGAE(3, 14, 61)
        AFAC(A201, A205)
        If A109.Content = "A1" Then AGAC(6, 7) Else AGAC(4, 5)
        If A110.Content = "B1" Then : AGAC(22, 25) : AGAC(34, 37)
          AGAC(46, 49) : AGAC(58, 61) : End If
        If A110.Content = "B2" Then : AGAC(14, 21) : AGAC(26, 33)
          AGAC(38, 45) : AGAC(50, 57) : End If
      End If
      'H-Anhangsseite
      If AAA = 2 Then
        Grid.SetColumn(A401, 0) : Grid.SetRow(A401, 0)
        Grid.SetColumn(A402, 0) : Grid.SetRow(A402, 1)
        Grid.SetColumn(A403, 0) : Grid.SetRow(A403, 2)
        Grid.SetColumn(A404, 0) : Grid.SetRow(A404, 3)
        Grid.SetColumn(A405, 0) : Grid.SetRow(A405, 4)
        Grid.SetColumn(A406, 2) : Grid.SetRow(A406, 0)
        Grid.SetColumn(A407, 2) : Grid.SetRow(A407, 1)
        Grid.SetColumn(A408, 2) : Grid.SetRow(A408, 2)
        Grid.SetColumn(A409, 2) : Grid.SetRow(A409, 3)
        Grid.SetColumn(A410, 2) : Grid.SetRow(A410, 4)
        If A109.Content = "A1" Then : A109.Content =
            "A2" : Else A109.Content = "A1" : End If
        AGAE(2, 62, 71) : ABAI()
      End If
      'H-Listenseite
      If AAA = 3 Then
        AFAH(13, A201, A204, A205, A208)
        AFAD(A002, A014, A202, A203, A206, A207)
        AFAF(0, A204, A208) : AFAI(12, A204, A208)
        AFAG(3, A204, A208) : AFAC(A012, A204, A208)
      End If
      'H-Tabelleseite
      If AAA = 4 Then

        If A109.Content = "A1" Then : A109.Content = "A2"
        Else : A109.Content = "A1" : End If : ABAI()
        A501.Visibility = 1 : A502.Visibility = 1
        A503.Visibility = 0

        If A503.Items.Count = 0 Then : Dim aa As String
          Grid.SetRow(A003, 16) : Grid.SetRowSpan(A003, 4)
          Grid.SetRowSpan(A015, 15) : Grid.SetRow(A015, 1)
          AddHandler A503.SelectionChanged, AddressOf BAAA
          Grid.SetRow(A003, 16)
          A015.Margin = New Thickness(10 * BAA)
          For i = 1 To 118 Step 1 : Dim ab As TextBlock
            ab = New TextBlock With {
              .VerticalAlignment = 3,
              .FontSize = 15 * BAA,
              .HorizontalAlignment = 3,
              .FontFamily = New FontFamily("Consolas")}
            aa = "A00"
            If i > 9 Then aa = "A0" : If i > 99 Then aa = "A"
            A503.Items.Add(ab)
            ab.Text = NAF.GetString(aa & CStr(i)) & "          "
            ab.Text = ab.Text.Substring(0, 10) &
              NAC.GetString(aa & CStr(i)) : Next : End If
      End If
      'H-Elementseite
      If AAA = 5 Then
        BAAC(200) : End If
    End If
  End Sub
  Private Sub AEAX()
    A202.Text = "" : CAG = "" : A012.Opacity = 1
    A203.Document.SetText(TextSetOptions.FormatRtf, "")
    A204.Document.SetText(TextSetOptions.FormatRtf, "")
    A204.Document.Selection.ParagraphFormat.SpaceAfter = 0
    MAO.Clear() : MAP.Clear()
  End Sub
  Private Sub AEAY()
    'aaaaj(1) = False
    'aaaaj(2) = False
    'aaaaj(3) = False
    'aaaaj(6) = False
    'aaaaj(7) = False
  End Sub
  Private Sub AEAZ(a As String)
    AIAB() : AIAH(NAA.GetString("S028") & ": " & NAA.GetString(a))
  End Sub
#End Region ' *****
#Region "A-AF"
  Private Sub AFAA(a As Byte, b As Grid)
    For i = 1 To a Step 1 : b.ColumnDefinitions.Add(New ColumnDefinition) : Next
  End Sub
  Private Sub AFAB(a As Byte, b As Grid)
    For i = 1 To a Step 1 : b.RowDefinitions.Add(New RowDefinition) : Next
  End Sub
  Private Sub AFAC(ParamArray a() As Object)
    For i = 0 To a.Count - 1 Step 1 : a(i).Visibility = Visibility.Visible : Next
  End Sub
  Private Sub AFAD(ParamArray a() As Object)
    For i = 0 To a.Count - 1 Step 1 : a(i).Visibility = Visibility.Collapsed : Next
  End Sub
  Private Sub AFAF(a As Byte, ParamArray b() As Object)
    For i = 0 To b.Count - 1 Step 1 : Grid.SetColumn(b(i), a) : Next
  End Sub
  Private Sub AFAG(a As Byte, ParamArray b() As Object)
    For i = 0 To b.Count - 1 Step 1 : Grid.SetRow(b(i), a) : Next
  End Sub
  Private Sub AFAH(a As Byte, ParamArray b() As Object)
    For i = 0 To b.Count - 1 Step 1 : Grid.SetColumnSpan(b(i), a) : Next
  End Sub
  Private Sub AFAI(a As Byte, ParamArray b() As Object)
    For i = 0 To b.Count - 1 Step 1 : Grid.SetRowSpan(b(i), a) : Next
  End Sub
#End Region ' *****
#Region "A-AG"
  Private Sub AGAA(ParamArray a() As Byte)
    Dim aa As Byte = 2
    For i = a(1) To a(2) Step 1 : aa += 1
      Grid.SetColumn(GAA(i), a(aa)) : Grid.SetRow(GAA(i), a(0))
    Next
  End Sub
  Private Sub AGAB(a As Byte, b As Byte)
    For i = a To b Step 1 : GAA(i).Visibility = Visibility.Visible : Next
  End Sub
  Private Sub AGAC(a As Byte, b As Byte)
    For i = a To b Step 1 : GAA(i).Visibility = Visibility.Collapsed : Next
  End Sub
  Private Sub AGAD(a As Byte, b As Byte, c As Double)
    For i = a To b Step 1 : GAA(i).FontSize = BAA * c : Next
  End Sub
  Private Sub AGAE(a As Byte, b As Byte, c As Byte)
    For i = b To c Step 1 : Grid.SetColumnSpan(GAA(i), a) : Next
  End Sub
  Private Sub AGAF(a As Byte, b As Byte, c As FontFamily)
    For i = a To b Step 1 : GAA(i).FontFamily = c : Next
  End Sub
  Private Sub AGAG(a As Byte, b As Byte, c As Color)
    For i = a To b Step 1 : GAA(i).Background = New SolidColorBrush(c) : Next
  End Sub
  Private Sub AGAH(a As Byte, b As Byte, c As Color)
    For i = a To b Step 1 : GAA(i).Foreground = New SolidColorBrush(c) : Next
  End Sub
  Private Sub AGAI(a As Byte, b As Byte, c As VerticalAlignment)
    For i = a To b Step 1 : GAA(i).VerticalAlignment = c : Next
  End Sub
  Private Sub AGAJ(a As Byte, b As Byte, c As HorizontalAlignment)
    For i = a To b Step 1 : GAA(i).HorizontalAlignment = c : Next
  End Sub
  Private Sub AGAK(a As Byte, b As Byte, c As Byte)
    For i = a To b Step 1 : GAA(i).Padding = New Thickness(c) : Next
  End Sub
#End Region ' *****
#Region "A-AH"
  Private Sub AHAA(ParamArray a() As Integer)
    For i = 0 To a.Count - 1 Step 2
      A204.Document.Selection.StartPosition = a(i)
      A204.Document.Selection.EndPosition = a(i + 1)
      A204.Document.Selection.CharacterFormat.Subscript = 1
    Next
  End Sub
  Private Sub AHAB(ParamArray a() As Integer)
    For i = 0 To a.Count - 1 Step 2
      A204.Document.Selection.StartPosition = a(i)
      A204.Document.Selection.EndPosition = a(i + 1)
      A204.Document.Selection.CharacterFormat.Superscript = 1
    Next
    '  A204.Document.Selection.CharacterFormat.ForegroundColor = c
    '  A204.Document.Selection.CharacterFormat.BackgroundColor = c
    '  A204.Document.Selection.CharacterFormat.Size = c
    '  A204.Document.Selection.CharacterFormat.FontStyle = c
    '  A204.Document.Selection.CharacterFormat.Underline = c
  End Sub
#End Region ' *****
#Region "A-AI"
  Private Sub AIAA()
    A203.Document.SetText(TextSetOptions.FormatRtf, "")
  End Sub
  Private Sub AIAB()
    A204.Document.SetText(TextSetOptions.FormatRtf, "")
  End Sub
  Private Sub AIAS()
    Select Case A203.Document.Selection.
      CharacterFormat.ForegroundColor
      Case Colors.Black : AIAC(Colors.Blue)
      Case Colors.Blue : AIAC(Colors.Green)
      Case Colors.Green : AIAC(Colors.Pink)
      Case Colors.Pink : AIAC(Colors.Black)
      Case Else : AIAC(Colors.Black) : End Select
  End Sub
  Private Sub AIAY()
    A204.Document.Selection.StartPosition = 0
    A204.Document.Selection.EndPosition = A204.Document.Selection.StoryLength
  End Sub
  Private Sub AIAZ()
    A204.Document.Selection.StartPosition = A204.Document.Selection.StoryLength
  End Sub
  Private Sub AIBA()
    A203.Document.Selection.StartPosition = 0
  End Sub
  Private Sub AIBB()
    A203.Document.Selection.EndPosition = A203.Document.Selection.StoryLength
  End Sub
  Private Sub AIBC()
    A203.Document.Selection.StartPosition = A203.Document.Selection.StoryLength
  End Sub
  Private Sub AIAO(a As Byte)
    A203.Document.Selection.ParagraphFormat.SpaceAfter = a * BAA
  End Sub
  Private Sub AIAP(a As Byte)
    A204.Document.Selection.ParagraphFormat.SpaceAfter = a * BAA
  End Sub
  Private Sub AIAC(a As Color)
    A203.Document.Selection.CharacterFormat.ForegroundColor = a
  End Sub
  Private Sub AIAD(a As Color)
    A203.Document.Selection.CharacterFormat.BackgroundColor = a
  End Sub
  Private Sub AIAE(a As Color)
    A204.Document.Selection.CharacterFormat.ForegroundColor = a
  End Sub
  Private Sub AIAF(a As Color)
    A204.Document.Selection.CharacterFormat.BackgroundColor = a
  End Sub
  Private Sub AIAG(a As String)
    A203.Document.Selection.Text = a
  End Sub
  Private Sub AIAH(a As String)
    A204.Document.Selection.Text = a
  End Sub
  Private Sub AIAI(a As String)
    A203.Document.Selection.Text += a
  End Sub
  Private Sub AIAJ(a As String)
    A204.Document.Selection.Text += a
  End Sub
  Private Sub AIAK(a As Integer)
    A203.Document.Selection.StartPosition = a
  End Sub
  Private Sub AIAL(a As Integer)
    A203.Document.Selection.EndPosition = a
  End Sub
  Private Sub AIAM(a As Integer)
    A204.Document.Selection.StartPosition = a
  End Sub
  Private Sub AIAN(a As Integer)
    A204.Document.Selection.EndPosition = a
  End Sub
  Private Sub AICB(a As FontStyle)
    A203.Document.Selection.CharacterFormat.FontStyle = a
  End Sub
#End Region ' *****
#Region "A-AJ"
  Private Function AJAA() As Boolean
    Dim aa As Boolean = False : If AAAAA.ActualWidth > AAAAA.ActualHeight Then : aa = True : End If : Return aa
  End Function
  Private Function AJAB(a As Color) As Boolean
    Dim aa As Boolean = False
    If A203.Document.Selection.CharacterFormat.ForegroundColor = a Then : aa = True : End If : Return aa
  End Function
#End Region ' *****
#End Region
  ' * BBBB * BBBB * BBBB * BBBB *
#Region "BBBB"
#Region "B-AA"
  Private Sub BAAA()
    BAAC(A503.SelectedIndex + 1)
  End Sub
  Private Sub BAAB()
    ACAJ()
  End Sub
  Private Sub BAAC(a As Byte)
    ' Deklaration
    Static aa As String : Static ab As New Grid
    Static ac, ad, ae, af, ag As New TextBlock
    AAA = 5 : A501.Visibility = 1
    ' Button - Exemplar
    Static ah As New Button With {
                .Content = ab,
                .Padding = New Thickness(20),
                .HorizontalAlignment = 3}
    ' Eine Bedingung
    If a = 200 And AAB = 1 Then : A502.Margin =
        New Thickness(150 * BAA, 0, 150 * BAA, 0)
      Grid.SetColumnSpan(ae, 1) : af.MinWidth = 100
      ah.HorizontalContentAlignment = 1 : Exit Sub
    ElseIf AAB <> 1 Then : af.MinWidth = 50
      A502.Margin = New Thickness(0)
      ah.HorizontalContentAlignment = 3
      Grid.SetColumnSpan(ae, 2) : Exit Sub : End If
    ' Zuweisungen, Bedingungen
    AddHandler ah.Click, AddressOf BAAB : aa = "A00"
    If a > 9 Then aa = "A0" : If a > 99 Then aa = "A"
    A503.SelectedIndex = -1 : ah.FontSize = 10 * BAA
    ah.Background = New SolidColorBrush(BBAA(a + 31))
    ' Positionen
    If A502.Children.Count = 0 Then
      ab.RowDefinitions.Add(New RowDefinition)
      ab.RowDefinitions.Add(New RowDefinition)
      ab.RowDefinitions.Add(New RowDefinition)
      ab.ColumnDefinitions.Add(New ColumnDefinition)
      ab.ColumnDefinitions.Add(New ColumnDefinition)
      ab.ColumnDefinitions.Add(New ColumnDefinition)
      A502.Children.Add(ah)
      ab.Children.Add(ac) : ab.Children.Add(ad)
      ab.Children.Add(ae) : ab.Children.Add(af)
      ab.Children.Add(ag)
      ae.Text = NAE.GetString("S006")
      Grid.SetRow(ac, 0) : Grid.SetColumn(ac, 0)
      Grid.SetRow(ad, 1) : Grid.SetColumn(ad, 0)
      Grid.SetRow(ae, 2) : Grid.SetColumn(ae, 0)
      Grid.SetRow(af, 0) : Grid.SetColumn(af, 1)
      Grid.SetRow(ag, 2) : Grid.SetColumn(ag, 2)
    End If
    ' Hell - Dunkel Farben
    Select Case BBAA(a + 31)
      Case Colors.Gray, Colors.Olive, Colors.DarkViolet
        ah.Foreground = New SolidColorBrush(Colors.White)
      Case Else
        ah.Foreground = New SolidColorBrush(Colors.Black)
    End Select
    ' Fertigung - Ende
    AEAA() : ag.Text = NAG.GetString(aa & a)
    A502.Visibility = 0 : A503.Visibility = 1
    ac.Text = NAF.GetString(aa & a) & vbLf &
      vbLf & NAC.GetString(aa & a)
  End Sub

  Private Sub BAAD(a As Button, b As RoutedEventArgs)
    Static aa As String = CStr(Grid.GetRow(a)) & "." &
      CStr(Grid.GetColumn(a)) : Static ab As Byte

    Select Case aa
      Case "2.1" : ab = 1 : Case "2.19" : ab = 2
      Case "3.1" : ab = 3 : Case "3.2" : ab = 4
      Case "3.14" : ab = 5 : Case "3.15" : ab = 6
      Case "3.16" : ab = 7 : Case "3.17" : ab = 8
      Case "3.18" : ab = 9 : Case "3.19" : ab = 10
      Case "4.1" : ab = 11 : Case "4.2" : ab = 12
      Case "4.14" : ab = 13 : Case "4.15" : ab = 14
      Case "4.16" : ab = 15 : Case "4.17" : ab = 16
      Case "4.18" : ab = 17 : Case "4.19" : ab = 18
      Case "5.1" : ab = 19 : Case "5.2" : ab = 20
      Case "5.3" : ab = 21 : Case "5.5" : ab = 22
      Case "5.6" : ab = 23 : Case "5.7" : ab = 24
      Case "5.8" : ab = 25 : Case "5.9" : ab = 26
      Case "5.10" : ab = 27 : Case "5.11" : ab = 28
      Case "5.12" : ab = 29 : Case "5.13" : ab = 30
      Case "5.14" : ab = 31 : Case "5.15" : ab = 32
      Case "5.16" : ab = 33 : Case "5.17" : ab = 34
      Case "5.18" : ab = 35 : Case "5.19" : ab = 36
      Case "6.1" : ab = 37
      Case "6.2" : ab = 38
      Case "6.3" : ab = 39
      Case "6.5" : ab = 40
      Case "6.6" : ab = 41
      Case "6.7" : ab = 42
      Case "6.8" : ab = 43
      Case "6.9" : ab = 44
      Case "6.10" : ab = 45
      Case "6.11" : ab = 46
      Case "6.12" : ab = 47
      Case "6.13" : ab = 48
      Case "6.14" : ab = 49
      Case "6.15" : ab = 50
      Case "6.16" : ab = 51
      Case "6.17" : ab = 52
      Case "6.18" : ab = 53
      Case "6.19" : ab = 54
      Case "7.1" : ab = 55
      Case "7.2" : ab = 56
      Case "7.3" : ab = 57
      Case "9.5" : ab = 58
      Case "9.6" : ab = 59
      Case "9.7" : ab = 60
      Case "9.8" : ab = 61
      Case "9.9" : ab = 62
      Case "9.10" : ab = 63
      Case "9.11" : ab = 64
      Case "9.12" : ab = 65
      Case "9.13" : ab = 66
      Case "9.14" : ab = 67
      Case "9.15" : ab = 68
      Case "9.16" : ab = 69
      Case "9.17" : ab = 70
      Case "9.18" : ab = 71
      Case "7.5" : ab = 72
      Case "7.6" : ab = 73
      Case "7.7" : ab = 74
      Case "7.8" : ab = 75
      Case "7.9" : ab = 76
      Case "7.10" : ab = 77
      Case "7.11" : ab = 78
      Case "7.12" : ab = 79
      Case "7.13" : ab = 80
      Case "7.14" : ab = 81
      Case "7.15" : ab = 82
      Case "7.16" : ab = 83
      Case "7.17" : ab = 84
      Case "7.18" : ab = 85
      Case "7.19" : ab = 86
      Case "8.1" : ab = 87
      Case "8.2" : ab = 88
      Case "8.3" : ab = 89
      Case "10.5" : ab = 90
      Case "10.6" : ab = 91
      Case "10.7" : ab = 92
      Case "10.8" : ab = 93
      Case "10.9" : ab = 94
      Case "10.10" : ab = 95
      Case "10.11" : ab = 96
      Case "10.12" : ab = 97
      Case "10.13" : ab = 98
      Case "10.14" : ab = 99
      Case "10.15" : ab = 100
      Case "10.16" : ab = 101
      Case "10.17" : ab = 102
      Case "10.18" : ab = 103
      Case "8.5" : ab = 104
      Case "8.6" : ab = 105
      Case "8.7" : ab = 106
      Case "8.8" : ab = 107
      Case "8.9" : ab = 108
      Case "8.10" : ab = 109
      Case "8.11" : ab = 110
      Case "8.12" : ab = 111
      Case "8.13" : ab = 112
      Case "8.14" : ab = 113
      Case "8.15" : ab = 114
      Case "8.16" : ab = 115
      Case "8.17" : ab = 116
      Case "8.18" : ab = 117
      Case "8.19" : ab = 118
      Case Else : ab = 0
    End Select
    If ab > 0 Then BAAC(ab)
    ' nur für Wissen - CD11.Width = New GridLength(1, GridUnitType.Star) - CD1 ist Row oder Column
  End Sub
#End Region ' *****
#Region "B-AB"
  Private Function BBAA() As Color()
    Static ca As Color = Colors.Gray
    Static cb As Color = Colors.Gold
    Static cc As Color = Colors.Olive
    Static cd As Color = Colors.Violet
    Static ce As Color = Colors.SkyBlue
    Static cf As Color = Colors.LightGray
    Static cg As Color = Colors.LightPink
    Static ch As Color = Colors.MistyRose
    Static ci As Color = Colors.DarkViolet
    Static cj As Color = Colors.WhiteSmoke
    Static ck As Color = Colors.GreenYellow
    BBAA = New Color() {
            cj, cj, cj, cj, cj, cj, cj, cj, cj, cj, cj, cj, cj, cj, cj,
            cj, cj, cj, cj, cj, cj, cj, cj, cj, cj, cj, cj, cj, cj, cj,
            cj, cj, ck, ce, ch, cb, cc, ck, ck, ck, ck, ce, ch, cb, ca,
            cc, ck, ck, ck, ce, ch, cb, cg, cg, cg, cg, cg, cg, cg, cg,
            cg, ca, ca, cc, cc, ck, ck, ce, ch, cb, cg, cg, cg, cg, cg,
            cg, cg, cg, cg, ca, ca, ca, cc, cc, ck, ce, ch, cb, cd, cd,
            cd, cd, cd, cd, cd, cd, cd, cd, cd, cd, cd, cd, cd, cg, cg,
            cg, cg, cg, cg, cg, cg, ca, ca, ca, ca, ca, cc, ce, ch, cb,
            ci, ci, ci, ci, ci, ci, ci, ci, ci, ci, ci, ci, ci, ci, ci,
            cg, cg, cg, cg, cg, cf, cf, cf, ca, cf, cf, cf, cf, cf, cf}
    '    GreenYellow - Reactive nonmetal
    '    SkyBlue - Noble gas
    '    MistyRose - Alkalimetal
    '    Gold - Alkaline earth metal
    '    Olive - Metalloid
    '    Gray - Post transition metal
    '    LightPink - Transition metal
    '    Violet - Lanthanide
    '    DarkViolet - Actinide
    '    LightGray - Unknown chemical properties
  End Function
#End Region ' *****
  ''Private Sub AACAAC(a As String, b As String, c As String, ParamArray d() As Integer)
  ''    'Drei Kreise
  ''    Dim aacaa As New Canvas
  ''    Dim aacab As New TextBlock
  ''    Dim aacac As New Abbildung
  ''    Dim aacad As Color
  ''    CS2.Children.Add(aacaa) : CS2.Children.Add(aacab)
  ''    aacaa.Margin = New Thickness(AAA1 * 700, BAA * 50, 0, 0)
  ''    aacab.Margin = New Thickness(AAA1 * 700, BAA * 500, 0, 0)
  ''    aacad = Violet
  ''    aacac.Kreis(aacad, aacad, aacaa, 0, 30, 30, 20, 50, BAA) : If d(0) = 1 Then Exit Sub
  ''    aacac.Kreis(aacad, aacad, aacaa, 0, 30, 30, 50, 20, BAA) : If d(0) = 2 Then Exit Sub
  ''    aacac.Kreis(aacad, aacad, aacaa, 0, 30, 30, 250, 250, BAA) : If d(0) = 3 Then Exit Sub
  ''End Sub

  ''Private Sub AACAAD(a As String, b As String, c As String, ParamArray d() As Integer)
  ''    'Drei Kreise
  ''    Dim aacaa As New Canvas
  ''    Dim aacab As New TextBlock
  ''    Dim aacac As New Abbildung
  ''    Dim aacad As Color
  ''    CS2.Children.Add(aacaa) : CS2.Children.Add(aacab)
  ''    aacaa.Margin = New Thickness(AAA1 * 700, BAA * 50, 0, 0)
  ''    aacab.Margin = New Thickness(AAA1 * 700, BAA * 500, 0, 0)
  ''    If d(0) = 1 Then
  ''        If d(1) = 1 Then aacad = AliceBlue
  ''        If d(1) = 2 Then aacad = AliceBlue
  ''        If d(1) = 3 Then aacad = AliceBlue
  ''    End If
  ''    aacac.Kreis(aacad, aacad, aacaa, 1, 30, 40, 250, 250, BAA) : If d(0) = 1 Then Exit Sub
  ''    aacac.Kreis(aacad, aacad, aacaa, 1, 30, 40, 250, 250, BAA) : If d(0) = 2 Then Exit Sub
  ''    aacac.Kreis(aacad, aacad, aacaa, 1, 30, 40, 250, 250, BAA) : If d(0) = 3 Then Exit Sub
  ''End Sub
#End Region
  ' * CCCC * CCCC * CCCC * CCCC *
#Region "CCCC"
  Private Sub AADAAA()
    If N_ = False Then Exit Sub
    If CAH <> "" Then
      '***
      '***
      '***
      A003.Children.Clear()
      Dim aaaaa As String
      Dim aaaab() As String
      Dim aaaac() As String
      Dim aaaad(FAA.Count - 1) As Double
      Dim aaaae(FAA.Count - 1) As Boolean
      '1     Sichtbarkeit der Steuerelemente
      AFAC(A012, A013) : AFAD(A014) : A003.Opacity = 0.4
      '2     Ergebnis der gesuchte Dimension
      aaaac = KAA(KAA.Count - 1).Split("=")
      '3     Ergebnisse gegebener Dimensionen
      AIBA() : AIBB()
      aaaaa = A203.Document.Selection.Text.TrimEnd(vbCr) : aaaab = aaaaa.Split(vbCr)
      '4     Ergebnisse aller Dimensionen
      aaaab(0) = aaaac(1).Trim(" ")
      For i = 1 To aaaab.Count - 1 Step 1
        aaaac = aaaab(i).Split("=")
        aaaab(i) = aaaac(1).Trim(" ")
      Next
      '5     Werteprüfen
      For i = 0 To FAA.Count - 1 Step 1
        If Double.TryParse(aaaab(i).Replace(NAA.GetString("S038"), NAA.GetString("S039")), 0) = True Then
          aaaae(i) = True : aaaad(i) = Convert.ToDouble(aaaab(i).Replace(NAA.GetString("S038"), NAA.GetString("S039")))
        End If
      Next
      '6     s1 s2 Δs
      If CAH = "1" Then
        Dim x1, x2 As Double
        Dim aabaa As New A_aa
        Dim aabab As New A_ab
        Dim v1, v2, v3, v4 As Integer
        If FAA(0) = "Δs" Then v1 = 1 : v2 = 2 : v3 = 0
        If FAA(2) = "Δs" Then v1 = 0 : v2 = 1 : v3 = 2
        If aaaae(v3) = True Then If aaaad(v3) < 0 Then v4 = 1
        If aaaae(v1) = True And aaaae(v2) = True Then
          If aaaad(v1) < aaaad(v2) Then x1 = aaaad(v1) : x2 = aaaad(v2) : If FAA(v1) = "s2" Then v4 = 1
          If aaaad(v1) > aaaad(v2) Then x1 = aaaad(v2) : x2 = aaaad(v1) : If FAA(v1) = "s1" Then v4 = 1
          If x1 = x2 Or aaaad(v3) = 0 Then Exit Sub
        Else
          x1 = 0 : x2 = 0
        End If
        aabab.AAX(A003, "s1", BAA, 520 + v4 * 350, 395, 20, 0, 2)
        aabab.AAX(A003, "s2", BAA, 1120 - v4 * 860, 395, 20, 0, 2)
        aabaa.AAAA("x", A003, BAA, 535 - v4 * 360, 460, 700, 0, x1, x2, 1)
        aabaa.AACA("Δs", A003, BAA, 530 + v4 * 340, 425, 624, 0 + v4 * 180, 2)
        aabaa.AAEB(NAD.GetString("S001"), A003, BAA, 730 - v4 * 240, 240, v4 * 2 - 1)
        aabaa.AAEA(NAD.GetString("S002"), A003, BAA, 400 + v4 * 600, 300, 45 - v4 * 90)
        aabaa.AAEA(NAD.GetString("S003"), A003, BAA, 1000 - v4 * 600, 300, 50 - v4 * 100)
      End If
      '7     t1 t2 Δt
      If CAH = "2" Then
        Dim x1, x2 As Double
        Dim v1, v2, v3 As Integer
        Dim aabaa As New A_aa
        Dim aabab As New A_ab
        If FAA(0) = "Δt" Then v1 = 1 : v2 = 2 : v3 = 0
        If FAA(2) = "Δt" Then v1 = 0 : v2 = 1 : v3 = 2
        If aaaae(v1) = True And aaaae(v2) = True Then
          If aaaad(v1) < aaaad(v2) And FAA(v1) = "t1" Then x1 = aaaad(v1) : x2 = aaaad(v2)
          If aaaad(v1) > aaaad(v2) And FAA(v1) = "t2" Then x1 = aaaad(v2) : x2 = aaaad(v1)
          If x1 = x2 Or aaaad(v3) = 0 Then aabaa.AAEA("0", A003, BAA, 800, 300, 50) : Exit Sub
        Else
          x1 = 0 : x2 = 0
        End If
        aabab.AAX(A003, "t1", BAA, 525, 395, 20, 0, 2)
        aabab.AAX(A003, "t2", BAA, 205, 395, 20, 0, 2)
        aabab.AAX(A003, "t1", BAA, 1160, 395, 20, 0, 2)
        aabab.AAX(A003, "t2", BAA, 1475, 395, 20, 0, 2)
        aabaa.AACA("Δt", A003, BAA, 1180, 425, 323, 0, 2)
        aabaa.AACA("Δt", A003, BAA, 520, 425, 323, 180, 2)
        aabaa.AAAA("t", A003, BAA, 1185, 460, 405, 0, x1, x2, 0)
        aabaa.AAAA("t", A003, BAA, 515, 460, 405, 180, x1, x2, 0)
        aabaa.AAEA(NAD.GetString("S004"), A003, BAA, 650, 300, -45)
        aabaa.AAEA(NAD.GetString("S004"), A003, BAA, 1050, 300, 45)
        aabaa.AAEA(NAD.GetString("S005"), A003, BAA, 350, 300, -50)
        aabaa.AAEA(NAD.GetString("S005"), A003, BAA, 1350, 300, 50)
      End If
      '8    v1 v2 Δv {v}
      If CAH = "3" Then
        Dim aabaa As New A_aa
        Dim aabab As New A_ab
        Dim aaaam(0 To 3) As Boolean
        Dim u1, u2, u3, u4, x1, x2, z1, z2, z3, z4 As Double
        Dim v1, v2, v3, v4, v5, v6, y1, y2, y3, y4 As Integer
        'Werte
        For i = 0 To FAA.Count - 1 Step 1
          If FAA(i) = "v1" And aaaae(i) = True Then aaaam(0) = True : z1 = aaaad(i) : y1 = 2 : If i = 0 Then y1 = 3
          If FAA(i) = "v2" And aaaae(i) = True Then aaaam(1) = True : z2 = aaaad(i) : y2 = 2 : If i = 0 Then y2 = 3
          If FAA(i) = "Δv" And aaaae(i) = True Then aaaam(2) = True : z3 = aaaad(i) : y3 = 2 : If i = 0 Then y3 = 3
          If FAA(i) = "{v}" And aaaae(i) = True Then aaaam(3) = True : z4 = aaaad(i) : y4 = 2 : If i = 0 Then y4 = 3
        Next
        'Werteherstellung 1: z1 z2 z3 z4
        If aaaam(0) = True And aaaam(3) = True Then z2 = 2 * z4 - z1 : z3 = z2 - z1
        If aaaam(1) = True And aaaam(3) = True Then z1 = 2 * z4 - z2 : z3 = z2 - z1
        If aaaam(0) = True And aaaam(1) = True Then z3 = z2 - z1 : z4 = (z1 + z2) / 2
        If aaaam(0) = True And aaaam(2) = True Then z2 = z1 + z3 : z4 = (z1 + z2) / 2
        If aaaam(1) = True And aaaam(2) = True Then z1 = z2 - z3 : z4 = (z1 + z2) / 2
        'Werteherstellung 2: z1 z2 z3 z4
        If z1 = 0 And z2 = 0 And z3 = 0 And z4 = 0 Then z1 = 1 : z2 = 3 : z3 = 2 : z4 = 2 ' auch wenn absichtlich 0
        'Werteherstellung 3: z1 z2 z3 z4
        If aaaam(0) = False And aaaam(1) = False And aaaam(2) = False And aaaam(3) = True Then z2 = 2 * z4 : z3 = z2
        If aaaam(0) = False And aaaam(1) = False And aaaam(3) = False And aaaam(2) = True Then z4 = z3 / 2 : z2 = z3
        If aaaam(0) = False And aaaam(2) = False And aaaam(3) = False And aaaam(1) = True Then z4 = z2 / 2 : z3 = z2
        If aaaam(1) = False And aaaam(2) = False And aaaam(3) = False And aaaam(0) = True Then z4 = z1 / 2 : z3 = z1
        'v-Achsenwerte
        If z1 = z2 Then x1 = z1 : x2 = z2
        If z1 < z2 Then x1 = z1 : x2 = z2
        If z1 > z2 Then x1 = z2 : x2 = z1
        'Wiederherstellung 1
        v5 = 200 : v6 = 450
        'u1 u2 u3 u4: Richtung, Längen, Längenbeträge
        If z1 < 0 Then v1 = 1 : u1 = -z1 Else u1 = z1
        If z2 < 0 Then v2 = 1 : u2 = -z2 Else u2 = z2
        If z3 < 0 Then v3 = 1 : u3 = -z3 Else u3 = z3
        If z4 < 0 Then v4 = 1 : u4 = -z4 Else u4 = z4
        'Längenkorrektur 1 Bild 1
        If u1 > u2 And u1 >= u3 Then u2 = 600 * u2 / u1 : u3 = 600 * u3 / u1 : u4 = 300 * u4 / u1 : u1 = 600
        If u2 > u1 And u2 >= u3 Then u1 = 600 * u1 / u2 : u3 = 600 * u3 / u2 : u4 = 300 * u4 / u2 : u2 = 600
        If u3 > u1 And u3 >= u2 Then u1 = 600 * u1 / u3 : u2 = 600 * u2 / u3 : u4 = 300 * u4 / u3 : u3 = 600
        If u1 = u2 And u3 >= u4 Then u1 = 600 * u1 / u2 : u3 = 600 * u3 / u2 : u4 = 300 * u4 / u3 : u2 = 600
        If u1 = u2 And u4 >= u3 Then u1 = 600 * u1 / u2 : u3 = 600 * u3 / u2 : u4 = 300 * u4 / u3 : u2 = 600
        'Längenkorrektur 1 Bild 2
        If u1 > u2 And z1 / z2 > 0 Then z3 = 300 : z4 = 100
        If u1 < u2 And z1 / z2 > 0 Then z3 = 100 : z4 = 300
        If u1 > u2 And z1 / z2 < 0 Then z3 = 150 : z4 = 150 * z2 / z1 : If z4 < 0 Then z4 = -z4
        If u1 < u2 And z1 / z2 < 0 Then z4 = 150 : z3 = 150 * z1 / z2 : If z3 < 0 Then z3 = -z3
        'Längenkorrektur 2 Bild 1
        If u1 < 60 And u1 > 0 Then u1 = 60 Else If u1 < 600 And u1 > 540 Then u1 = 540
        If u2 < 60 And u1 > 0 Then u2 = 60 Else If u2 < 600 And u2 > 540 Then u2 = 540
        If u3 < 60 And u1 > 0 Then u3 = 60 Else If u3 < 600 And u3 > 540 Then u3 = 540
        'Längenkorrektur 2 Bild 2
        If z3 <= 300 Then u4 = (z3 - 2 * v1 * z3 + z4 - 2 * v2 * z4) / 2 : If u4 < 0 Then u4 = -u4
        'Nullstelle
        If z1 < 0 And z1 < z2 Then v5 = 100 + Convert.ToInt32(Math.Round(u1)) : v6 = 400 - Convert.ToInt32(Math.Round(z3))
        If z1 < 0 And z1 = z2 Then v5 = 100 + Convert.ToInt32(Math.Round(u1)) : v6 = 400 - Convert.ToInt32(Math.Round(z3))
        If z2 < 0 And z2 < z1 Then v5 = 100 + Convert.ToInt32(Math.Round(u2)) : v6 = 400 - Convert.ToInt32(Math.Round(z4))
        'Bild 1
        aabaa.AACA("v1", A003, BAA, v5, 350, u1, 0 + v1 * 180, y1)
        aabaa.AACA("v2", A003, BAA, v5, 390, u2, 0 + v2 * 180, y2)
        aabaa.AAEB(NAD.GetString("S001"), A003, BAA, 300, 150, v2 * 2 - 1)
        aabaa.AACA("Δv", A003, BAA, v5 + u1 - 2 * u1 * v1, 430, u3, 0 + v3 * 180, y3)
        aabaa.AAAA("v1", A003, BAA, 100 + v4 * 600, 250, 30 + u1 / 8, 0 + v1 * 180, 0, 0, y1)
        aabaa.AAAA("v2", A003, BAA, 700 - v4 * 600, 250, 30 + u2 / 8, 0 + v2 * 180, 0, 0, y2)
        aabaa.AAAA("v", A003, BAA, v5 - 30 + u1 - 2 * u1 * v1 - v3 * u3, 470, u3 + 70, 0, x1, x2, 0)
        'Bild 2
        u1 = v6 - u4 + 2 * v4 * u4
        u2 = v6 - z3 + 2 * v1 * z3
        aabaa.AACB("{v}", A003, BAA, 1255, u1, u4, -90, y4)
        aabab.AAA(A003, BAA, 1240, 1380, u1 + 5, u1 + 5, 1, 0)
        aabab.AAA(A003, BAA, 1200, 1300, v6 + 6, v6 + 6, 1, 0)
        aabaa.AACB("{v}", A003, BAA, 1255, u1 + u4, u4, -90, y4)
        aabaa.AACB("2 {v}", A003, BAA, 1215, u1 + u4, 2 * u4, -90, y4)
        aabaa.AAAA("v1", A003, BAA, 1300, v6, z3, v1 * 180 - 90, 0, 0, y1)
        aabaa.AAAA("v2", A003, BAA, 1330, u2, z4, v2 * 180 - 90, 0, 0, y2)
        aabab.AAA(A003, BAA, 1200, 1330, u2 - z4 + 2 * v2 * z4 + 6, u2 - z4 + 2 * v2 * z4 + 6, 1, 0)
        'Bild 3
        u1 = v6 - u4 + 2 * v4 * u4
        aabaa.AAAA("", A003, BAA, 1430, v6, 300, 0, 0, 0, 0)
        aabaa.AAAA("v", A003, BAA, 1450, 450, 400, -90, 0, 0, 0)
        aabaa.AAAA("v1", A003, BAA, 1550, v6, z3, v1 * 180 - 90, 0, 0, y1)
        aabaa.AAAA("v2", A003, BAA, 1650, v6, z4, v2 * 180 - 90, 0, 0, y2)
        aabaa.AAAA("{v}", A003, BAA, 1600, v6, u4, v4 * 180 - 90, 0, 0, y4)
        u2 = (z4 - 2 * v2 * z4 - z3 + 2 * v1 * z3) / 2 : If u2 < 0 Then u2 = -u2
        aabab.AAA(A003, BAA, 1400, 1550, v6 - z3 + 2 * v1 * z3 + 5, v6 - z3 + 2 * v1 * z3 + 5, 1, 0)
        aabab.AAA(A003, BAA, 1400, 1650, v6 - z4 + 2 * v2 * z4 + 5, v6 - z4 + 2 * v2 * z4 + 5, 1, 0)
        aabab.AAA(A003, BAA, 1400, 1600, v6 - u4 + 2 * v4 * u4 + 5, v6 - u4 + 2 * v4 * u4 + 5, 1, 0)
        aabaa.AACB("Δv/2", A003, BAA, 1420, u1, u2, -90, y3) : aabaa.AACB("Δv/2", A003, BAA, 1420, u1 + u2, u2, -90, y3)
        'Pfeilstelle ist mit Pfeilrichtung und -größe angepasst: richtige Stellen von v1 und v2 wären v2<== =>v1 statt v1=> <==v2
        ' v1     v2      Δv       {v}               ' v2     v1      Δv       {v}
        ' =>     ==>     =>        =>               ' <=     <==     =>        <=
        ' ==>    =>      <=        =>               ' <==    <=      <=        <=
        ' <=     ==>     ===>      =>               ' =>     <==     ===>      <=
        ' ==>    <=      <===      =>               ' <==    =>      <===      <=
        'Die Stelle des größeren Pfeils von v1 und v2 passt mit seiner Richtung bezüglich kleineren
      End If
      '9    Vektoren- 2D-1
      If CAH = "4" Then
        Dim aabaa As New A_aa
        Dim aabab As New A_ab

        'aabaa.AAAB("x y a ax ay θ 1", A003, BAA, 50, 150, 360, 60)
        'aabaa.AAAB("x y a ax ay ϕ 1", A003, BAA, 450, 150, 360, 135)
        'aabaa.AAAB("x y a ax ay θ 2", A003, BAA, 900, 150, 360, 240)
        'aabaa.AAAB("x y a ax ay ϕ 2", A003, BAA, 1350, 150, 360, 330)

        'aabaa.AAAB("x y a ax ay θ 1", A003, BAA, 50, 150, 360, -300)
        'aabaa.AAAB("x y a ax ay ϕ 1", A003, BAA, 450, 150, 360, -230)
        'aabaa.AAAB("x y a ax ay θ 2", A003, BAA, 900, 150, 360, -140)
        'aabaa.AAAB("x y a ax ay ϕ 2", A003, BAA, 1350, 150, 360, -30)

        'aabaa.AAAD("a ax ay az", A003, BAA, 50, 50, 360, 20, 30)
        'aabaa.AAAD("a ax ay az", A003, BAA, 450, 50, 360, 125, 210)

        aabaa.AAAD("a ax ay az ax θ ϕ", A003, BAA, 50, 50, 360, 20, 30)
        aabaa.AAAD("a ax ay az az θ ϕ", A003, BAA, 450, 50, 360, 125, 210)
        aabaa.AAAD("a ax ay az ax θ ϕ", A003, BAA, 900, 50, 360, 245, 210)
        aabaa.AAAD("a ax ay az az θ ϕ", A003, BAA, 1350, 50, 360, 325, 30)

        'Quadrant 1: cos+ sin+ tan+
        'Quadrant 2: cos- sin+ tan-
        'Quadrant 3: cos- sin- tan+
        'Quadrant 4: cos+ sin- tan-

        'Grad 0:   cos=1  sin=0  tan=0
        'Grad 90:  cos=0  sin=1  tan=∞
        'Grad 180: cos=-1 sin=0  tan=0
        'Grad 270: cos=0  sin=-1 tan=∞

        'a ax         a = ax
        'a ay         a = ay
        'a az         a = az
        'a ax θ       a = ax : cos(θ)
        'a ay θ       a = ay : sin(θ)
        'a az θ       a = az : cos(θ)
        'a ax θ ϕ     a = ax : cos(θ) : sin(ϕ)
        'a az θ ϕ     a = az : cos(θ) : cos(ϕ)
        'a ax ay      a = √(ax ^ 2 + ay ^ 2)
        'a ax az      a = √(ax ^ 2 + az ^ 2)
        'a ay az      a = √(ay ^ 2 + az ^ 2)
        'a ax ay az   a = √(ax ^ 2 + ay ^ 2 + az ^ 2)

      End If

      'xxxxx.Background = New SolidColorBrush(Color.FromArgb(100, 150, 250, 150)) ' a r g b

      '				    R	G	B
      'LightGray			211	211	211
      'Gray				128	128	128
      'Green			    0	128	0
      'Lime				0	255	0
      'Red				255	0	0
      'Blue				0	0	255
      'Black			    0	0	0
      'White			    255	255	255
      'Orange	    		255	165	0
      'Violet		    	238	130	238
      'BlueViolet			138	43	226
      'Moccasin			255	228	181
      'DarkGray			169	169	169
      'SkyBlue			135	206	235
      'DarkGoldenrod		184	134	11
      'Gold				255	215	0

      'Bisque - hellrosa
      'Chartreuse - grün
      'CornflowerBlue - blau
      'Crimson - dunkelrot
      'DarkMagenta - magenta
      'DarkOrange - orange
      'DarkSalmon - hellrosa
      'Fuchsia - rosa
      'GreenYellow - hellgrün
      'LawnGreen - grün
      'LemonChiffon - sehrhellrosa
      'Moccasin - ...


      '***
      '***
    End If
    If CAH = "" Then
      Dim aaaaa As Double
      Dim aaaab As Double
      Dim aaaad As String
      Dim aaaae As Boolean
      Dim aaaaf As Integer
      Dim aaaag() As String
      Dim aaaah() As String
      Dim aaaaj(0 To 9) As Boolean
      Dim aaaak(0 To 1) As Boolean
      Dim aaaal(0 To 2) As Boolean
      Dim aaaam(0 To 4) As Integer
      Dim aaaan(0 To 2) As Integer
      Dim aaaao(0 To 13) As Boolean
      Dim aaaap(0 To 13) As Boolean
      Dim aaaaq As New Canvas
      Dim aaaar(0 To 39) As A_aa
      Dim aaaas As New CompositeTransform

      A003.Children.Clear()

      '1     Sichtbarkeit der Steuerelemente
      AFAC(A012, A013) : AFAD(A014) : A003.Opacity = 0.4
      '2     Ergebnis der gesuchte Dimension
      Try
        aaaah = KAA(KAA.Count - 1).Split("=")
      Catch ex As Exception
        Exit Sub
      End Try
      '3     Ergebnisse gegebener Dimensionen
      AIBA() : AIBB()
      aaaad = A203.Document.Selection.Text.TrimEnd(vbCr)
      aaaad = aaaad.Replace(vbCr & vbCr, vbCr)
      aaaag = aaaad.Split(vbCr)
      '4     Ergebnisse aller Dimensionen
      aaaag(0) = aaaah(1).Trim(" ")
      For i = 1 To aaaag.Count - 1 Step 1
        aaaah = aaaag(i).Split("=")
        aaaag(i) = aaaah(1).Trim(" ")
      Next
      '5     Eine Deklaration
      For i = 0 To 39 Step 1
        aaaar(i) = New A_aa
      Next
      '6     ........
      'Dimensionsmesse
      For f = 0 To FAA.Count - 1 Step 1
        Dim zc As Char
        If Double.TryParse(aaaag(f).Replace(".", ","), 0) = True Then
          If Convert.ToDouble(aaaag(f)) > 0 Then zc = "+"
          If Convert.ToDouble(aaaag(f)) < 0 Then zc = "-"
          If FAA(f) = "s1" Then aaaaj(0) = True : aaaam(0) = f
          If FAA(f) = "s2" Then aaaaj(1) = True : aaaam(1) = f
          If FAA(f) = "v1" Then aaaaj(2) = True : aaaam(2) = f
          If FAA(f) = "v2" Then aaaaj(3) = True : aaaam(3) = f
          If FAA(f) = "Δv" Then aaaaj(4) = True : aaaam(4) = f
          If FAA(f) = "Δs" And zc = "+" Then aaaao(0) = True
          If FAA(f) = "Δs" And zc = "-" Then aaaao(1) = True
          If FAA(f) = "{v}" And zc = "+" Then aaaao(2) = True
          If FAA(f) = "{v}" And zc = "-" Then aaaao(3) = True
          If FAA(f) = "v1" And zc = "+" Then aaaap(0) = True
          If FAA(f) = "v1" And zc = "-" Then aaaap(1) = True
          If FAA(f) = "v2" And zc = "+" Then aaaap(2) = True
          If FAA(f) = "v2" And zc = "-" Then aaaap(3) = True
          If FAA(f) = "ΔEk" Then aaaak(0) = True
          If FAA(f) = "ΔEp" Then aaaak(1) = True
          If FAA(f) = "Ff" Then aaaal(0) = True
          If FAA(f) = "k" Then aaaal(0) = True
          If FAA(f) = "|Fn|" Then aaaal(1) = True
          If FAA(f) = "Frg" Then aaaal(1) = True
          If FAA(f) = "Frh" Then aaaal(1) = True
          If FAA(f) = "Frr" Then aaaal(2) = True
          If FAA(f) = "μg" Then aaaal(1) = True
          If FAA(f) = "μh" Then aaaal(1) = True
          If FAA(f) = "μr" Then aaaal(2) = True
          If FAA(f) = "Δs" Then aaaab = Convert.ToDouble(aaaag(f))
          If FAA(f) = "c" Or FAA(f) = "M" Or FAA(f) = "n" Then aaaae = True ' Bedingung ist zeitlich beschränkt !!!
        End If
      Next
      'Vektorstellen
      If aaaaj(0) = True And aaaaj(1) = True Then ' s1 und s2
        If Convert.ToDouble(aaaag(aaaam(0))) < Convert.ToDouble(aaaag(aaaam(1))) Then aaaao(4) = True
        If Convert.ToDouble(aaaag(aaaam(0))) > Convert.ToDouble(aaaag(aaaam(1))) Then aaaao(5) = True
      End If ' Δs = s2 - s1
      If aaaaj(2) = True And aaaaj(3) = True Then ' v1 und v2
        If Convert.ToDouble(aaaag(aaaam(2))) + Convert.ToDouble(aaaag(aaaam(3))) > 0 Then aaaao(6) = True
        If Convert.ToDouble(aaaag(aaaam(2))) + Convert.ToDouble(aaaag(aaaam(3))) < 0 Then aaaao(7) = True
      End If ' {v} = (v1 + v2)/2
      If aaaaj(2) = True And aaaaj(4) = True Then ' v1 und Δv
        If Convert.ToDouble(aaaag(aaaam(2))) + (Convert.ToDouble(aaaag(aaaam(4))) / 2) > 0 Then aaaao(8) = True
        If Convert.ToDouble(aaaag(aaaam(2))) + (Convert.ToDouble(aaaag(aaaam(4))) / 2) < 0 Then aaaao(9) = True
      End If ' {v} = v1 + Δv/2
      If aaaaj(3) = True And aaaaj(4) = True Then ' v2 und Δv
        If Convert.ToDouble(aaaag(aaaam(3))) > Convert.ToDouble(aaaag(aaaam(4))) / 2 Then aaaao(10) = True
        If Convert.ToDouble(aaaag(aaaam(3))) < Convert.ToDouble(aaaag(aaaam(4))) / 2 Then aaaao(11) = True
      End If ' {v} = v2 - Δv/2
      If aaaap(0) = True And aaaap(2) = True Then
        If Convert.ToDouble(aaaag(aaaam(2))) < Convert.ToDouble(aaaag(aaaam(3))) Then aaaap(4) = True
        If Convert.ToDouble(aaaag(aaaam(2))) > Convert.ToDouble(aaaag(aaaam(3))) Then aaaap(5) = True
      End If
      If aaaap(0) = True And aaaap(3) = True Then
        If Convert.ToDouble(aaaag(aaaam(2))) < -1 * Convert.ToDouble(aaaag(aaaam(3))) Then aaaap(6) = True
        If Convert.ToDouble(aaaag(aaaam(2))) > -1 * Convert.ToDouble(aaaag(aaaam(3))) Then aaaap(7) = True
      End If
      If aaaap(1) = True And aaaap(2) = True Then
        If -1 * Convert.ToDouble(aaaag(aaaam(2))) < Convert.ToDouble(aaaag(aaaam(3))) Then aaaap(8) = True
        If -1 * Convert.ToDouble(aaaag(aaaam(2))) > Convert.ToDouble(aaaag(aaaam(3))) Then aaaap(9) = True
      End If
      If aaaap(1) = True And aaaap(3) = True Then
        If Convert.ToDouble(aaaag(aaaam(2))) > Convert.ToDouble(aaaag(aaaam(3))) Then aaaap(10) = True
        If Convert.ToDouble(aaaag(aaaam(2))) < Convert.ToDouble(aaaag(aaaam(3))) Then aaaap(11) = True
      End If
      A003.Children.Clear() : aaaaq.Children.Clear() : A003.Children.Add(aaaaq)
      aaaaq.Margin = New Thickness(0, 0, 0, 0) : aaaaq.Width = BAA * 600 : aaaaq.Height = BAA * 600
      aaaas.CenterX = BAA * 300 : aaaas.CenterY = BAA * 300
      aaaas.Rotation = 0 : aaaaq.RenderTransform = aaaas
      'Feder
      If aaaal(0) = True Then
        Dim fdr As Integer
        If aaaab > 0 Then fdr = 1
        If aaaab = 0 Then fdr = 0 : aaaaa = -60
        If aaaab < 0 Then fdr = -1 : aaaaa = -120
        aaaar(0).Linie(Colors.Black, aaaaq, 1, 30, 40, 250, 250, BAA)
        aaaar(1).Linie(Colors.Black, aaaaq, 1, 180, 190, 250, 250, BAA)
        aaaar(0).Feder(Colors.Black, aaaaq, 1, 40, 250, 47, 250, 1, 3, BAA)
        aaaar(1).Feder(Colors.Black, aaaaq, 1, 54, 250, 47, 250, 1, 3, BAA)
        aaaar(2).Feder(Colors.Black, aaaaq, 1, 54, 250, 61, 250, 1, 3, BAA)
        aaaar(3).Feder(Colors.Black, aaaaq, 1, 68, 250, 61, 250, 1, 3, BAA)
        aaaar(4).Feder(Colors.Black, aaaaq, 1, 68, 250, 75, 250, 1, 3, BAA)
        aaaar(5).Feder(Colors.Black, aaaaq, 1, 82, 250, 75, 250, 1, 3, BAA)
        aaaar(6).Feder(Colors.Black, aaaaq, 1, 82, 250, 89, 250, 1, 3, BAA)
        aaaar(7).Feder(Colors.Black, aaaaq, 1, 96, 250, 89, 250, 1, 3, BAA)
        aaaar(8).Feder(Colors.Black, aaaaq, 1, 96, 250, 103, 250, 1, 3, BAA)
        aaaar(9).Feder(Colors.Black, aaaaq, 1, 110, 250, 103, 250, 1, 3, BAA)
        aaaar(10).Feder(Colors.Black, aaaaq, 1, 110, 250, 117, 250, 1, 3, BAA)
        aaaar(11).Feder(Colors.Black, aaaaq, 1, 124, 250, 117, 250, 1, 3, BAA)
        aaaar(12).Feder(Colors.Black, aaaaq, 1, 124, 250, 131, 250, 1, 3, BAA)
        aaaar(13).Feder(Colors.Black, aaaaq, 1, 138, 250, 131, 250, 1, 3, BAA)
        aaaar(14).Feder(Colors.Black, aaaaq, 1, 138, 250, 145, 250, 1, 3, BAA)
        aaaar(15).Feder(Colors.Black, aaaaq, 1, 152, 250, 145, 250, 1, 3, BAA)
        aaaar(16).Feder(Colors.Black, aaaaq, 1, 152, 250, 159, 250, 1, 3, BAA)
        aaaar(17).Feder(Colors.Black, aaaaq, 1, 166, 250, 159, 250, 1, 3, BAA)
        aaaar(18).Feder(Colors.Black, aaaaq, 1, 166, 250, 173, 250, 1, 3, BAA)
        aaaar(19).Feder(Colors.Black, aaaaq, 1, 180, 250, 173, 250, 1, 3, BAA)
        aaaar(2).Linie(Colors.Black, aaaaq, 1, 30, 40, 350, 350, BAA)
        aaaar(3).Linie(Colors.Black, aaaaq, 1, 180 + 60 * fdr, 190 + 60 * fdr, 350, 350, BAA)
        aaaar(20).Feder(Colors.Black, aaaaq, 1, 40, 350, 47 + fdr * 3, 350, 1, 2 - fdr, BAA)
        aaaar(21).Feder(Colors.Black, aaaaq, 1, 54 + fdr * 6, 350, 47 + fdr * 3, 350, 1, 21 / (7 + 3 * fdr), BAA)
        aaaar(22).Feder(Colors.Black, aaaaq, 1, 54 + fdr * 6, 350, 61 + fdr * 9, 350, 1, 21 / (7 + 3 * fdr), BAA)
        aaaar(23).Feder(Colors.Black, aaaaq, 1, 68 + fdr * 12, 350, 61 + fdr * 9, 350, 1, 21 / (7 + 3 * fdr), BAA)
        aaaar(24).Feder(Colors.Black, aaaaq, 1, 68 + fdr * 12, 350, 75 + fdr * 15, 350, 1, 21 / (7 + 3 * fdr), BAA)
        aaaar(25).Feder(Colors.Black, aaaaq, 1, 82 + fdr * 18, 350, 75 + fdr * 15, 350, 1, 21 / (7 + 3 * fdr), BAA)
        aaaar(26).Feder(Colors.Black, aaaaq, 1, 82 + fdr * 18, 350, 89 + fdr * 21, 350, 1, 21 / (7 + 3 * fdr), BAA)
        aaaar(27).Feder(Colors.Black, aaaaq, 1, 96 + fdr * 24, 350, 89 + fdr * 21, 350, 1, 21 / (7 + 3 * fdr), BAA)
        aaaar(28).Feder(Colors.Black, aaaaq, 1, 96 + fdr * 24, 350, 103 + fdr * 27, 350, 1, 21 / (7 + 3 * fdr), BAA)
        aaaar(29).Feder(Colors.Black, aaaaq, 1, 110 + fdr * 30, 350, 103 + fdr * 27, 350, 1, 21 / (7 + 3 * fdr), BAA)
        aaaar(20).Feder(Colors.Black, aaaaq, 1, 110 + fdr * 30, 350, 117 + fdr * 33, 350, 1, 21 / (7 + 3 * fdr), BAA)
        aaaar(31).Feder(Colors.Black, aaaaq, 1, 124 + fdr * 36, 350, 117 + fdr * 33, 350, 1, 21 / (7 + 3 * fdr), BAA)
        aaaar(32).Feder(Colors.Black, aaaaq, 1, 124 + fdr * 36, 350, 131 + fdr * 39, 350, 1, 21 / (7 + 3 * fdr), BAA)
        aaaar(33).Feder(Colors.Black, aaaaq, 1, 138 + fdr * 42, 350, 131 + fdr * 39, 350, 1, 21 / (7 + 3 * fdr), BAA)
        aaaar(34).Feder(Colors.Black, aaaaq, 1, 138 + fdr * 42, 350, 145 + fdr * 45, 350, 1, 21 / (7 + 3 * fdr), BAA)
        aaaar(35).Feder(Colors.Black, aaaaq, 1, 152 + fdr * 48, 350, 145 + fdr * 45, 350, 1, 21 / (7 + 3 * fdr), BAA)
        aaaar(36).Feder(Colors.Black, aaaaq, 1, 152 + fdr * 48, 350, 159 + fdr * 51, 350, 1, 21 / (7 + 3 * fdr), BAA)
        aaaar(37).Feder(Colors.Black, aaaaq, 1, 166 + fdr * 54, 350, 159 + fdr * 51, 350, 1, 21 / (7 + 3 * fdr), BAA)
        aaaar(38).Feder(Colors.Black, aaaaq, 1, 166 + fdr * 54, 350, 173 + fdr * 57, 350, 1, 21 / (7 + 3 * fdr), BAA)
        aaaar(39).Feder(Colors.Black, aaaaq, 1, 180 + fdr * 60, 350, 173 + fdr * 57, 350, 1, 21 / (7 + 3 * fdr), BAA)
        If aaaal(2) = True And aaaab < 0 Then aaaar(0).Kreis(Colors.Gray, Colors.LightGray, aaaaq, 1, 100, 100, 180, 350, BAA)
        If aaaal(2) = True And aaaab = 0 Then aaaar(0).Kreis(Colors.Gray, Colors.LightGray, aaaaq, 1, 100, 100, 240, 350, BAA)
        If aaaal(2) = True And aaaab > 0 Then aaaar(0).Kreis(Colors.Gray, Colors.LightGray, aaaaq, 1, 100, 100, 300, 350, BAA)
        If aaaal(2) = False And aaaab < 0 Then aaaar(1).Rechteck(Colors.Gray, Colors.LightGray, aaaaq, 1, 100, 100, 130, 300, BAA)
        If aaaal(2) = False And aaaab = 0 Then aaaar(1).Rechteck(Colors.Gray, Colors.LightGray, aaaaq, 1, 100, 100, 190, 300, BAA)
        If aaaal(2) = False And aaaab > 0 Then aaaar(1).Rechteck(Colors.Gray, Colors.LightGray, aaaaq, 1, 100, 100, 250, 300, BAA)
      End If
      If aaaal(1) = True Then
        Dim Rc1 As New A_aa
        Rc1.Rechteck(Colors.Gray, Colors.LightGray, aaaaq, 1, 400, 50, 100, 400, BAA)
      End If
      If aaaal(0) = False And aaaal(2) = True Then
        Dim El1 As New A_aa
        El1.Kreis(Colors.Gray, Colors.LightGray, aaaaq, 1, 100, 100, 300, 350, BAA)
      End If
      If aaaal(0) = False And aaaal(2) = False Then
        Dim Rc1 As New A_aa
        Rc1.Rechteck(Colors.Gray, Colors.LightGray, aaaaq, 1, 100, 100, 250, 300, BAA)
      End If
      If aaaao(0) = True Or aaaao(2) = True Or aaaao(4) = True Or aaaao(6) = True Or aaaao(8) = True Or aaaao(10) = True Then aaaao(12) = True
      If aaaao(1) = True Or aaaao(3) = True Or aaaao(5) = True Or aaaao(7) = True Or aaaao(9) = True Or aaaao(11) = True Then aaaao(13) = True
      If aaaap(4) = True Or aaaap(6) = True Or aaaap(8) = True Or aaaap(10) = True Then aaaap(12) = True
      If aaaap(5) = True Or aaaap(7) = True Or aaaap(9) = True Or aaaap(11) = True Then aaaap(13) = True
      'Vektoren, Skalare
      For f = 0 To FAA.Count - 1 Step 1 ' a F p v // Δs Δv {v} // v1 v2 / s1 s2 <=> t1 t2 / m P Δt W Ekin Epot
        If Double.TryParse(aaaag(f).Replace(".", ","), 0) = True Then
          If Convert.ToDouble(aaaag(f)) > 0 Then aaaaf = 0
          If Convert.ToDouble(aaaag(f)) < 0 Then aaaaf = 180

          If FAA(f) = "a" Then aaaan(0) += 20 : aaaar(0).Vektor(FAA(f), aaaaq, 275 + aaaaa, 385 - aaaan(0), 50, aaaaf, BAA)
          If FAA(f) = "F" Then aaaan(0) += 20 : aaaar(1).Vektor(FAA(f), aaaaq, 275 + aaaaa, 385 - aaaan(0), 50, aaaaf, BAA)

          If FAA(f) = "Ff" Then aaaan(0) += 20 : aaaar(2).Vektor(FAA(f), aaaaq, 275, 385 - aaaan(0), 50, aaaaf, BAA)
          'If FAA(f) = "|Fn|" Then aaaan(0) += 20 : vk(1).Vektor(FAA(f), aaaaq, 275, 385 - aaaan(0), 50, aaaaf)
          'If FAA(f) = "Fg" Then aaaan(0) += 20 : vk(1).Vektor(FAA(f), aaaaq, 275, 385 - aaaan(0), 50, aaaaf)
          If FAA(f) = "Frg" Then aaaan(0) += 20 : aaaar(3).Vektor(FAA(f), aaaaq, 275, 385 - aaaan(0), 50, aaaaf, BAA)
          If FAA(f) = "Frh" Then aaaan(0) += 20 : aaaar(4).Vektor(FAA(f), aaaaq, 275, 385 - aaaan(0), 50, aaaaf, BAA)
          If FAA(f) = "Frr" Then aaaan(0) += 20 : aaaar(5).Vektor(FAA(f), aaaaq, 275, 385 - aaaan(0), 50, aaaaf, BAA)
          If FAA(f) = "p" Then aaaan(0) += 20 : aaaar(6).Vektor(FAA(f), aaaaq, 275 + aaaaa, 385 - aaaan(0), 50, aaaaf, BAA)
          If FAA(f) = "v" Then aaaan(0) += 20 : aaaar(7).Vektor(FAA(f), aaaaq, 275 + aaaaa, 385 - aaaan(0), 50, aaaaf, BAA)
          If FAA(f) = "Δs" And aaaal(0) = False Then aaaan(1) += 20 : aaaar(8).Vektor(FAA(f), aaaaq, 75, 385 + aaaan(1), 450, aaaaf, BAA)
          If FAA(f) = "Δs" And aaaal(0) = True Then aaaan(1) += 20 : aaaar(8).Vektor(FAA(f), aaaaq, 190 + aaaaa / 2, 210, 60, aaaaf, BAA)
          If FAA(f) = "v1" And aaaap(12) = True And aaaao(12) = True Then aaaar(9).Vektor(FAA(f), aaaaq, 37, 295, 25, aaaaf, BAA)
          If FAA(f) = "v1" And aaaap(12) = True And aaaao(13) = True Then aaaar(9).Vektor(FAA(f), aaaaq, 537, 295, 25, aaaaf, BAA)
          If FAA(f) = "v1" And aaaap(13) = True And aaaao(12) = True Then aaaar(9).Vektor(FAA(f), aaaaq, 25, 295, 50, aaaaf, BAA)
          If FAA(f) = "v1" And aaaap(13) = True And aaaao(13) = True Then aaaar(9).Vektor(FAA(f), aaaaq, 525, 295, 50, aaaaf, BAA)
          If FAA(f) = "v2" And aaaap(12) = True And aaaao(12) = True Then aaaar(10).Vektor(FAA(f), aaaaq, 525, 295, 50, aaaaf, BAA)
          If FAA(f) = "v2" And aaaap(12) = True And aaaao(13) = True Then aaaar(10).Vektor(FAA(f), aaaaq, 25, 295, 50, aaaaf, BAA)
          If FAA(f) = "v2" And aaaap(13) = True And aaaao(12) = True Then aaaar(10).Vektor(FAA(f), aaaaq, 537, 295, 25, aaaaf, BAA)
          If FAA(f) = "v2" And aaaap(13) = True And aaaao(13) = True Then aaaar(10).Vektor(FAA(f), aaaaq, 37, 295, 25, aaaaf, BAA)
          If FAA(f) = "Δv" Then aaaan(2) += 20 : aaaar(11).Vektor(FAA(f), aaaaq, 250 + aaaaa, 285 - aaaan(2), 100, aaaaf, BAA)
          If FAA(f) = "{v}" Then aaaan(2) += 20 : aaaar(12).Vektor(FAA(f), aaaaq, 250 + aaaaa, 285 - aaaan(0), 100, aaaaf, BAA)
          If FAA(f) = "ΔEkin" Then aaaan(1) += 20 : aaaar(0).Skalar(FAA(f), aaaaq, BAA, 75, 385 + aaaan(1), 450, 0)
          If FAA(f) = "ΔEpot" Then aaaan(1) += 20 : aaaar(1).Skalar(FAA(f), aaaaq, BAA, 75, 385 + aaaan(1), 400, 0)
          If FAA(f) = "k" Then aaaar(2).Skalar(FAA(f), aaaaq, BAA, 200 + aaaaa, 320)
          If FAA(f) = "m" Then aaaar(3).Skalar(FAA(f), aaaaq, BAA, 250 + aaaaa, 280)
          If FAA(f) = "μg" Then aaaar(4).Skalar(FAA(f), aaaaq, BAA, 265 + aaaaa, 280)
          If FAA(f) = "μh" Then aaaar(5).Skalar(FAA(f), aaaaq, BAA, 280 + aaaaa, 280)
          If FAA(f) = "μr" Then aaaar(6).Skalar(FAA(f), aaaaq, BAA, 295 + aaaaa, 280)
          If FAA(f) = "P" Then aaaar(7).Skalar(FAA(f), aaaaq, BAA, 310 + aaaaa, 280)
          If FAA(f) = "W" Then aaaar(8).Skalar(FAA(f), aaaaq, BAA, 325 + aaaaa, 280)
          If FAA(f) = "s1" And aaaao(12) = True Then aaaar(9).Skalar(FAA(f), aaaaq, BAA, 50, 385)
          If FAA(f) = "s1" And aaaao(13) = True Then aaaar(9).Skalar(FAA(f), aaaaq, BAA, 550, 385)
          If FAA(f) = "s2" And aaaao(12) = True Then aaaar(10).Skalar(FAA(f), aaaaq, BAA, 550, 385)
          If FAA(f) = "s2" And aaaao(13) = True Then aaaar(10).Skalar(FAA(f), aaaaq, BAA, 50, 385)
          If FAA(f) = "t1" And aaaao(12) = True Then aaaar(11).Skalar(FAA(f), aaaaq, BAA, 50, 365)
          If FAA(f) = "t1" And aaaao(13) = True Then aaaar(11).Skalar(FAA(f), aaaaq, BAA, 550, 365)
          If FAA(f) = "t2" And aaaao(12) = True Then aaaar(12).Skalar(FAA(f), aaaaq, BAA, 550, 365)
          If FAA(f) = "t2" And aaaao(13) = True Then aaaar(12).Skalar(FAA(f), aaaaq, BAA, 50, 365)
          If FAA(f) = "Δt" Then aaaan(1) += 20 : aaaar(13).Skalar(FAA(f), aaaaq, BAA, 75, 385 + aaaan(1), 450, 0)
        End If
      Next
      'x-Achse
      If aaaak(1) = False And aaaae = False Then
        aaaar(13).Vektor("x", aaaaq, 20, 385, 560, 0, BAA)
      End If
      'y-Achse
      If aaaak(1) = True And aaaae = False Then
        aaaar(13).Vektor("y", aaaaq, 20, 100, 560, 0, BAA)
        aaaas.Rotation = -90
        aaaaq.RenderTransform = aaaas
      End If
    End If
  End Sub ' *****
#End Region
  ' * DDED * DDED * DDED * DDED *
#Region "DDDD"
#Region "D-AA"
  Private Sub DAAA()
    If A201.Text.Length > 1 Then
      Select Case A201.Text.Substring(0, 2)
        Case NAA.GetString("S023") : _FD = A201.Text.Split(":") : CAB = _FD(1)
        Case NAA.GetString("S024") : _FD = A201.Text.Split(":") : CAB = _FD(1)
      End Select : End If
    If A203.Document.Selection.StoryLength < 2 Then Exit Sub
    AIBA() : AIBB() : CAA = A203.Document.Selection.Text
    CAA = CAA.Replace(vbCrLf, vbLf) : CAA = CAA.Replace(vbCr, vbLf)
    CAA = CAA.Replace(vbLf, "") : CAA = CAA.Replace(vbLf, "") : DAAB()
    ' Aufhebung der Selection
    A203.Document.Selection.StartPosition = A203.Document.Selection.StoryLength
  End Sub
  Private Sub DAAB()
    ' Symbolen
    JAA.Clear() : JAB.Clear()
    JAC.Clear() : KAA.Clear()
    KAB.Clear() : KAC.Clear()
    KAD.Clear() : KAE.Clear()
    KAF.Clear() : KAH.Clear()
    KAI.Clear() : KAJ.Clear()
    KAK.Clear() : KAL.Clear()
    MAQ.Clear() : MAR.Clear()
    KAG.Clear() : MAQ.Add(0)
    _M = 0
    _AA = NAA.GetString("S029")
    _AB = NAA.GetString("S038")
    _AC = NAA.GetString("S039")
    KAB.Add(_AA & "  : a = a")
    ' Symbolen   Reihenfolge !!!
    CAA = CAA.Replace("  ", " ")
    CAA = CAA.Replace("  ", " ")
    CAA = CAA.Replace("  ", " ")
    CAA = CAA.Replace("  ", " ")
    CAA = CAA.Replace("  ", " ")
    CAA = CAA.Replace("*", "·")
    CAA = CAA.Replace("/", ":")
    CAA = CAA.Replace("^", "˄")
    CAA = CAA.Replace("+∞", "▪")
    CAA = CAA.Replace("+", " + ")
    CAA = CAA.Replace("±", " ± ")
    CAA = CAA.Replace("∓", " ∓ ")
    CAA = CAA.Replace("·", " · ")
    CAA = CAA.Replace(":", " : ")
    CAA = CAA.Replace("˄", " ˄ ")
    CAA = CAA.Replace("˅", " ˅ ")
    CAA = CAA.Replace("˟", " ˟ ")
    CAA = CAA.Replace("'", " ' ")
    CAA = CAA.Replace("→", " → ")
    CAA = CAA.Replace("=", " = ")
    CAA = CAA.Replace("≠", " ≠ ")
    CAA = CAA.Replace("<", " < ")
    CAA = CAA.Replace(">", " > ")
    CAA = CAA.Replace("  ", " ")
    CAA = CAA.Replace("  ", " ")
    CAA = CAA.Replace("  ", " ")
    CAA = CAA.Replace("  ", " ")
    CAA = CAA.Replace("  ", " ")
    CAA = CAA.Replace(" ", " · ")
    CAA = CAA.Replace(" · + · ", " + ")
    CAA = CAA.Replace(" · ± · ", " ± ")
    CAA = CAA.Replace(" · ∓ · ", " ∓ ")
    CAA = CAA.Replace(" · - · ", " - ")
    CAA = CAA.Replace(" · · · ", " · ")
    CAA = CAA.Replace(" · : · ", " : ")
    CAA = CAA.Replace(" · ˄ · ", " ˄ ")
    CAA = CAA.Replace(" · ˅ · ", " ˅ ")
    CAA = CAA.Replace(" · ˟ · ", " ˟ ")
    CAA = CAA.Replace(" · = · ", " = ")
    CAA = CAA.Replace(" · ≠ · ", " ≠ ")
    CAA = CAA.Replace(" · < · ", " < ")
    CAA = CAA.Replace(" · > · ", " > ")
    CAA = CAA.Replace(" · ' · ", " ' ")
    CAA = CAA.Replace(" · → · ", " → ")
    CAA = CAA.Replace("▪", "+∞")
    CAA = CAA.Replace("( ", "(")
    CAA = CAA.Replace(" )", ")")
    CAA = CAA.TrimStart(" ")
    CAA = CAA.TrimEnd(" ")
    KAA.Add(CAA) : DAAC()
  End Sub
  Private Sub DAAC()
    Do Until _M = KAA.Count
      ' a = b (1)
      Do : DBCA() : D_Z2() : Loop Until _I = 0
      ' a b + a c = a (b + c)
      'Do : DBDB() : D_Z2() : Loop Until _I = 0
    Loop
    A_E.Content = NAA.GetString("S005")
    ABAE() ' !!!   Reihenfolge   !!!
  End Sub
  Private Sub DAAD()
    ' Ausdruckseigenschaften
    If CAH = CAA And KAA.Count > 1 Then Exit Sub Else CAH = CAA ' Wiederlaufverbot
    KAH.Clear() : KAI.Clear() : MAA.Clear() : MAB.Clear() : MAC.Clear() : MAD.Clear()
    MAE.Clear() : MAF.Clear() : MAG.Clear() : MAH.Clear() : MAI.Clear() : MAJ.Clear()
    MAM.Clear() : IAA.Clear() : IAB.Clear() : LAA.Clear() : KAH.Add(CAA) : KAI.Add("")
    MAE.Add(0) : MAA.Add(0) : KAG.Add("DAAD") : _A = -1 : _F = 0 : _G = 0 ' 3 ÷ 2 × 3
    '1     Ausdruckteile
    Do
      '1.1     Anweisungen
      _A += 1 : _B = MAA(_A) : _C = _B : _D = KAH(_A).Length : _E = _D : A_ = False : AAD = 0
      C1.Clear() : C2.Clear() : C3.Clear() : C4.Clear() : C5.Clear() : C6.Clear() : C7.Clear()
      '1.2     Funktionen
      If CAA.Substring(_B, 1) <> "-" Then
        If _D > 1 Then
          If CAA.Substring(_B, 1) = "(" Then _C += 1 : _E -= 2 : MAB.Add(1) : E_ = True
          If CAA.Substring(_B, 1) = "{" Then _C += 1 : _E -= 2 : MAB.Add(1) : E_ = True
          If CAA.Substring(_B, 1) = "ǀ" Then _C += 1 : _E -= 2 : MAB.Add(2) : E_ = True
          If CAA.Substring(_B, 1) = "[" Then _C += 1 : _E -= 2 : MAB.Add(2) : E_ = True
        End If
        If _D > 2 Then
          If CAA.Substring(_B, 2) = "√(" Then _C += 2 : _E -= 3 : MAB.Add(3) : F_ = True
          If CAA.Substring(_B, 2) = "d(" Then _C += 2 : _E -= 3 : MAB.Add(4) : G_ = True
          If CAA.Substring(_B, 2) = "ʃ(" Then _C += 2 : _E -= 3 : MAB.Add(5) : H_ = True
          If CAA.Substring(_B, 2) = "Ʃ(" Then _C += 2 : _E -= 3 : MAB.Add(6) : I_ = True
          If CAA.Substring(_B, 2) = "∏(" Then _C += 2 : _E -= 3 : MAB.Add(7) : J_ = True
        End If
        If _D > 4 Then
          If CAA.Substring(_B, 3) = "ln(" Then _C += 3 : _E -= 4 : MAB.Add(8) : K_ = True
          If CAA.Substring(_B, 4) = "log(" Then _C += 4 : _E -= 5 : MAB.Add(9) : K_ = True
          If CAA.Substring(_B, 4) = "lim(" Then _C += 4 : _E -= 5 : MAB.Add(10) : L_ = True
          If CAA.Substring(_B, 4) = "cos(" Then _C += 4 : _E -= 5 : MAB.Add(11) : M_ = True
          If CAA.Substring(_B, 4) = "sin(" Then _C += 4 : _E -= 5 : MAB.Add(12) : M_ = True
          If CAA.Substring(_B, 4) = "tan(" Then _C += 4 : _E -= 5 : MAB.Add(13) : M_ = True
          If CAA.Substring(_B, 4) = "cot(" Then _C += 4 : _E -= 5 : MAB.Add(14) : M_ = True
        End If
        If _D > 6 Then
          If CAA.Substring(_B, 5) = "acos(" Then _C += 5 : _E -= 6 : MAB.Add(15) : M_ = True
          If CAA.Substring(_B, 5) = "asin(" Then _C += 5 : _E -= 6 : MAB.Add(16) : M_ = True
          If CAA.Substring(_B, 5) = "atan(" Then _C += 5 : _E -= 6 : MAB.Add(17) : M_ = True
          If CAA.Substring(_B, 5) = "acot(" Then _C += 5 : _E -= 6 : MAB.Add(18) : M_ = True
        End If
      Else
        If _D > 2 Then
          If CAA.Substring(_B, 2) = "-(" Then _C += 2 : _E -= 3 : MAB.Add(1) : E_ = True
          If CAA.Substring(_B, 2) = "-{" Then _C += 2 : _E -= 3 : MAB.Add(1) : E_ = True
          If CAA.Substring(_B, 2) = "-ǀ" Then _C += 2 : _E -= 3 : MAB.Add(2) : E_ = True
          If CAA.Substring(_B, 2) = "-[" Then _C += 2 : _E -= 3 : MAB.Add(2) : E_ = True
        End If
        If _D > 4 Then
          If CAA.Substring(_B, 3) = "-√(" Then _C += 3 : _E -= 4 : MAB.Add(3) : F_ = True
          If CAA.Substring(_B, 3) = "-d(" Then _C += 3 : _E -= 4 : MAB.Add(4) : F_ = True
          If CAA.Substring(_B, 3) = "-ʃ(" Then _C += 3 : _E -= 4 : MAB.Add(5) : H_ = True
          If CAA.Substring(_B, 3) = "-Ʃ(" Then _C += 3 : _E -= 4 : MAB.Add(6) : I_ = True
          If CAA.Substring(_B, 3) = "-∏(" Then _C += 3 : _E -= 4 : MAB.Add(7) : J_ = True
          If CAA.Substring(_B, 4) = "-ln(" Then _C += 4 : _E -= 5 : MAB.Add(8) : K_ = True
        End If
        If _D > 6 Then
          If CAA.Substring(_B, 5) = "-log(" Then _C += 5 : _E -= 6 : MAB.Add(9) : K_ = True
          If CAA.Substring(_B, 5) = "-lim(" Then _C += 5 : _E -= 6 : MAB.Add(10) : L_ = True
          If CAA.Substring(_B, 5) = "-cos(" Then _C += 5 : _E -= 6 : MAB.Add(11) : M_ = True
          If CAA.Substring(_B, 5) = "-sin(" Then _C += 5 : _E -= 6 : MAB.Add(12) : M_ = True
          If CAA.Substring(_B, 5) = "-tan(" Then _C += 5 : _E -= 6 : MAB.Add(13) : M_ = True
          If CAA.Substring(_B, 5) = "-cot(" Then _C += 5 : _E -= 6 : MAB.Add(14) : M_ = True
          If CAA.Substring(_B, 6) = "-acos(" Then _C += 6 : _E -= 7 : MAB.Add(15) : M_ = True
          If CAA.Substring(_B, 6) = "-asin(" Then _C += 6 : _E -= 7 : MAB.Add(16) : M_ = True
          If CAA.Substring(_B, 6) = "-atan(" Then _C += 6 : _E -= 7 : MAB.Add(17) : M_ = True
          If CAA.Substring(_B, 6) = "-acot(" Then _C += 6 : _E -= 7 : MAB.Add(18) : M_ = True
        End If
      End If
      '1.3     Funktionsgültigkeit
      If _B < _C Then AAD = 1 : A_ = True
      '1.4     Öffnungsklammer
      Select Case CAA.Substring(_C, 1)
        Case "(" : AAD += 1 : Case "ǀ" : AAD += 1
        Case "{" : AAD += 1 : Case "[" : AAD += 1
      End Select
      '1.5     Operatoren
      If _E > 1 Then ' wenn bb = true dann _E > 1
        For i = _C To _C + _E - 2 Step 1
          Select Case CAA.Substring(i, 1) ' ǀ <> | ǁ
            Case "(" : AAD += 1 : Case ")" : AAD -= 1
            Case "ǀ" : AAD += 1 : Case "|" : AAD -= 1
            Case "[" : AAD += 1 : Case "]" : AAD -= 1
            Case "{" : AAD += 1 : Case "}" : AAD -= 1
          End Select
          If AAD = 0 Then : Select Case CAA.Substring(i, 2)
              Case "' " : C1.Add(i) : Case "→ " : C2.Add(i)
              Case "= " : C3.Add(i) : Case "≠ " : C3.Add(i)
              Case "< " : C3.Add(i) : Case "> " : C3.Add(i)
              Case "+ " : C4.Add(i) : Case "- " : C4.Add(i)
              Case "± " : C4.Add(i) : Case "∓ " : C4.Add(i)
              Case "· " : C5.Add(i) : Case ": " : C5.Add(i)
              Case "˄ " : C6.Add(i) : Case "˅ " : C6.Add(i)
              Case "˟ " : C6.Add(i) : End Select
            'Ein-Funktion-Unterschied von Mehr-Funktion: f(1) o f(2)
            If A_ = True Then MAB.RemoveAt(MAB.Count - 1) : A_ = False
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
      If A_ = False Then _C = _B : _E = _D : MAB.Add(0)
      '1.8     Wenn die Operatoren nicht gültig sind
      If C7.Count = 0 Then
        '1.8.1
        If A_ = True Then
          'Term, Operator, Teilungsanfang, Quellenteilindex,
          'Ausgangsteilenanzahl, Ausgangsteilenanfangsindex
          KAH.Add(CAA.Substring(_C, _E)) : KAI.Add("") : MAA.Add(_C)
          MAE.Add(_A) : MAH.Add(1) : MAI.Add(KAI.Count - 1)
        Else
          MAH.Add(0) : MAI.Add(_A) ' KAH, KAI, MAA, MAE schon vorher angegeben
        End If
        'Eingangsanfang, Eingangslänge, Ausgangsanfang, Ausgangslänge, Operatorengruppe
        MAC.Add(_B) : MAD.Add(_D) : MAF.Add(_C) : MAG.Add(_E) : IAB.Add(0)
        If KAH(_A) <> "∞" And KAH(_A) <> "-∞" And Double.TryParse(KAH(_A), 0) = True Then
          MAJ.Add(1) : Else MAJ.Add(0) : End If ' Eingangsteil-Zahl
        If KAH(_A) = CAB Or KAH(_A) = "-" & CAB Then MAM.Add(1) Else MAM.Add(0) ' Gesuchte Variable
      End If
      '1.9     Wenn die Operatoren gültig sind !!! Reihenfolge
      If C7.Count > 0 Then
        C7.Insert(0, _C) : C7.Add(_C + _E)
        MAJ.Add(0) : MAM.Add(0) ' : MAK.Add(0) ' betreffen nicht
        '1.8.1     Eigenschaften des Eingangsausdrucksubstrings
        MAC.Add(_B) : MAD.Add(_D) : MAF.Add(_C) : MAG.Add(_E)
        IAB.Add(AAD) : MAH.Add(C7.Count - 1) : MAI.Add(KAI.Count)
        '1.8.2     Ausgangsausdrucksubstringe
        For i = 1 To C7.Count - 1 Step 1
          If i = 1 Then : KAH.Add(CAA.Substring(_C, C7(i) - _C - 1))
            KAI.Add("") : MAE.Add(_A) : MAA.Add(_C)
          End If
          If i > 1 And i < C7.Count - 1 Then
            KAH.Add(CAA.Substring(C7(i - 1) + 2, C7(i) - C7(i - 1) - 3))
            KAI.Add(CAA.Substring(C7(i - 1), 1)) : MAE.Add(_A) : MAA.Add(C7(i - 1) + 2)
          End If
          If i = C7.Count - 1 Then
            KAH.Add(CAA.Substring(C7(i - 1) + 2, C7(i) - C7(i - 1) - 2))
            KAI.Add(CAA.Substring(C7(i - 1), 1)) : MAE.Add(_A) : MAA.Add(C7(i - 1) + 2)
          End If
          '1 Operator 2 Quellenteilindex 3 Teilungsanfang
        Next
      End If
      '1.10     Gemeinsame Eigenschaften auch wenn: ba = False And bb = False
      If CAA.Substring(_B, 1) = "-" Then IAA.Add(2) Else IAA.Add(0) ' Vorzeichen vor Eingangsteiles
      LAA.Add(False) '17 Gesuchte Variable in Gleichung im Nenner (Hinzufügen False ohne Bedingungen)
    Loop Until _A = KAH.Count - 1
    '2     Eigenschaftenkorrektur
    For i = 0 To KAH.Count - 1 Step 1
      'Vorzeichen
      If IAB(i) = 6 Then
        If IAA(i) = 0 Then IAA(i) = 1 Else If IAA(i) = 2 Then IAA(i) = 3
        If IAB(MAE(i)) = 5 And i = MAI(MAE(i)) Then IAA(MAE(i)) = IAA(i)
        'wenn Operatorengruppe 6 in Anfangsposition bei Operatorengruppe 5
      End If
      'Gesuchte Variable
      If MAM(i) = 1 Then : _J = i : _K = 1
        Do : _K += 1 : MAM(MAE(_J)) += _K : _J = MAE(_J) : Loop Until _J = 0
        If KAI(i) = ":" Then : _J = i : Do : LAA(MAE(_J)) = True : _J = MAE(_J) : Loop Until _J = 0 : End If
        If KAI(MAE(i)) = ":" And IAB(MAE(i)) = 6 Then : _J = i : Do : LAA(MAE(_J)) = True : _J = MAE(_J)
          Loop Until _J = 0 : End If
      End If
    Next
  End Sub
  Private Sub DAAE()
    If KAC.Count > 0 Then : Static aa, ab() As String : KAG.Add("DAAE")
      For i = 0 To KAC.Count - 1 Step 1 : KAA.Insert(_M + i + 1, KAC(i)) : ab = KAB(_M).Split(":")
        aa = ab(0).Remove(ab(0).Length - 1, 1) : aa &= "." & Convert.ToString(i + 1) & " : " & KAD(i)
        If _M = 0 Then aa = aa.Replace(NAA.GetString("S029") & " .", NAA.GetString("S029") & " ")
        KAB.Insert(_M + i + 1, aa) : KAL.Add(vbLf & vbLf & aa) : KAL.AddRange(KAK.GetRange(0, MAR(i)))
        JAC.Add(Colors.Blue) : JAC.AddRange(JAB.GetRange(0, MAR(i))) : KAK.RemoveRange(0, MAR(i))
        JAB.RemoveRange(0, MAR(i)) : Next : End If : MAR.Clear() : KAC.Clear() : KAD.Clear()
  End Sub
  Private Sub DAAF()
    'Ergebnissegleichheitsprüfer
    B_ = True : KAG.Add("DAAF")
    If KAA.Count > 0 Then : For i = 0 To KAA.Count - 1 Step 1
        If KAA(i) = CAA Then : B_ = False : Exit For : End If
      Next : End If
    If KAC.Count > 0 Then : For i = 0 To KAC.Count - 1 Step 1
        If KAC(i) = CAA Then : B_ = False : Exit For : End If
      Next : End If
    If B_ = True Then : KAE.Add(CAA) : KAF.Add(CAC)
      KAG.Add(CAA) : Else CAA = KAH(0)
      KAG.Add("Das Ergebnis ist dasselbe") : End If
  End Sub
  Private Sub D_Z1()
    If _I = 0 Then
      KAE.Clear() : KAJ.Clear() : JAA.Clear()
      KAF.Clear() : KAE.Add(KAA(_M)) : End If
    KAE(_I) = KAE(_I).Replace(_AB, _AC)
    CAA = KAE(_I)
    DAAD() : KAF.Add(CAC) : _L = KAH.Count
  End Sub
  Private Sub D_Z2()
    If CAA <> KAE(_I) Then
      KAE.Add(CAA) : _I += 1 : KAG.Add(CAA)
    Else : KAG.Add("Kein Ergebnis") : _I = 0
      B_ = False : If KAE.Count > 1 Then DAAF()
      If B_ = True Then
        KAC.Add(KAE(KAE.Count - 1))
        KAK.AddRange(KAJ.GetRange(0, KAJ.Count))
        JAB.AddRange(JAA.GetRange(0, JAA.Count))
        MAR.Add(KAJ.Count)
        KAD.Add(KAF(KAF.Count - 1)) : End If
      KAJ.Clear() : JAA.Clear() : DAAE() : _M += 1
    End If
  End Sub
#End Region ' *****
#Region "D-AB"
  Private Sub DB_1()
    For i = MAI(H1(4)) To MAI(H1(4)) + H1(5) - 1 Step 1
      If KAH(i) <> "☼" And KAH(i) <> "-☼" Then : _G = i
        If i < _F Then _AI = KAI(i) & "`" & _AI : Exit Sub
        If i > _F Then _AI &= "`" & KAI(i) : Exit Sub
      End If : Next
  End Sub
#End Region ' *****
#Region "D-AC"
  Private Sub DBAA()
    If IAB(0) = 3 And MAH(0) = 2 Then ' Operatorengruppe ist 3 <=> und es gibt nur 2 Seiten linke und rechte
      Dim ea As Integer : KAG.Add("DBAB")
      If MAM(2) > 1 Then ' Rechte Seite enthält eine Gesuchte
        If MAM(2) = MAM(MAI(2)) + 1 Then ' Nur erster Term in der rechten Seite enthält eine Gesuchte
          'a = b +- c => a - b = +- c
          If IAB(2) = 4 Then ' Operatorengruppe der rechten Seite ist 4: +-
            'a = b + c => a - b = c
            If KAI(MAI(2) + 1) = "+" Then : CAC = "a = b + c => a - b = c"
              DCBB(" - " & KAH(MAI(2)), {MAC(MAI(2)), MAD(MAI(2)) + 3, MAC(2) - 3})
              DDED("a = `b + `c` => `a` - b` = c") : Exit Sub
            End If ' Zweiter Operator der rechten Seite ist +
            'a = b - c => a - b = 0 - c
            If KAI(MAI(2) + 1) = "-" Then : CAC = "a = b - c => a - b = 0 - c"
              DCCA({" - " & KAH(MAI(2)), "0"}, {MAC(MAI(2)), MAD(MAI(2)), MAC(2) - 3, MAC(2)})
              DDEF("a = `b` - c` => `a` - b` = `0` - c") : Exit Sub
            End If ' Zweiter Operator der rechten Seite ist -
          End If
          'a = x ° b => a - x ° b = 0
          If IAB(2) > 4 Then ' Operatorengruppe der rechten Seite ist größer als 4: ·: ˄˅
            'a = x ° b => x ° b = a
            If MAM(1) = 0 Then : CAC = "a = b => b = a"
              DCBB(KAH(2) & " = ", {MAC(2) - 3, MAD(2) + 3, MAC(1)})
              DDCA("a` = b` => `b = `a") : Exit Sub
            End If ' Linke Seite enthält oder ist keine Gesuchte
            'x = x ° b => x - x ° b = 0
            If MAM(1) > 0 Then : CAC = "a = b => a - b = 0"
              DCCA({" - " & KAH(2), "0"}, {MAC(2), MAD(2), MAC(2) - 3, MAC(2)})
              DDCC("a = `b` => `a` - b` = `0") : Exit Sub
            End If ' Linke Seite enthält oder ist eine Gesuchte
          End If
        End If
        If MAM(2) > MAM(MAI(2)) + 1 Then ' Nicht nur erster Term der rechten Seite enthält eine Gesuchte
          'a = b +- c => a -+ c = b
          If IAB(2) = 4 Then : ea = 0 : CAC = "a = b +- c => a -+ c = b"
            'a = b +- c +- c => a -+ c -+ c = b
            For i = MAI(2) + MAH(2) - 1 To MAI(2) + 1 Step -1 ' rechts von letzten Term bis zweiten Term
              If MAM(i) > 0 Then ' ! Gesuchte im Nenner machen sowieso keinen Nenner für ganze linke Seite !
                If KAI(i) = "+" Then : DCBB(" - " & KAH(i), {MAC(i) + ea - 3, MAD(i) + 3, MAC(2) - 3})
                  DDCB("a = b` + c` => `a` - c` = b") : ea += MAD(i) + 3 : End If
                If KAI(i) = "-" Then : DCBB(" + " & KAH(i), {MAC(i) + ea - 3, MAD(i) + 3, MAC(2) - 3})
                  DDCB("a = b` - c` => `a` + c` = b") : ea += MAD(i) + 3 : End If
              End If
            Next
            If ea > 0 Then Exit Sub
          End If ' Operatorengruppe der rechten Seite: +-
          'a = b ·: c => a :· c = b
          If IAB(2) = 5 Then : ea = 0 : CAC = "a = b : c => a · c = b"
            'a ± b = c ·: d => (a ± b) :· d = c
            If IAB(1) = 4 Then
              'a ± b = c ·: d ·: d => (a ± b) :· d :· d = c
              For i = MAI(2) + MAH(2) - 1 To MAI(2) + 1 Step -1 ' rechts von letzten Term bis zweiten Term
                If LAA(i) = False And KAI(i) = ":" Then ' Gesuchte im Nenner machen keinen Nenner für ganze linke Seite
                  If ea > 0 Then : DCBB(" · " & KAH(i), {MAC(i) + ea - 1, MAD(i) + 3, MAC(2) - 1})
                    DDCB("a = b` : c` => `a` · c` = b")
                  Else : DCCA({"(", ") · " & KAH(i)}, {MAC(i) - 3, MAD(i) + 3, MAC(1), MAC(2) - 3})
                    DDCD("a ± b = c` : d` => `(`a ± b`) · d` = c")
                  End If : ea += MAD(i) + 3
                End If
              Next
            End If
            'a = b ·: c => a :· c = b
            If IAB(1) <> 4 Then
              'a = b ·: c ·: c => a :· c :· c = b
              For i = MAI(2) + MAH(2) - 1 To MAI(2) + 1 Step -1 ' rechts von letzten Term bis zweiten Term
                If LAA(i) = False And KAI(i) = ":" Then
                  DCBB(" · " & KAH(i), {MAC(i) + ea - 3, MAD(i) + 3, MAC(2) - 3})
                  DDCB("a = b` : c` => `a` · c` = b") : ea += MAD(i) + 3
                End If ' Gesuchte im Nenner machen keinen Nenner für ganze linke Seite
              Next
            End If
            'a => b
            If ea > 0 Then Exit Sub
          End If ' Operatorengruppe der rechten Seite ist 5: ·:
          'a = b ° x => b ° x = a
          If IAB(2) > 4 Then
            'a = b ° x => b ° x = a
            If MAM(1) = 0 Then : CAC = "a = b => b = a" ' a = b ° x => b ° x = a
              DCBB(KAH(2) & " = ", {MAC(2) - 3, MAD(2) + 3, MAC(1)})
              DDCA("a` = b` => `b = `a") : Exit Sub
            End If ' linke Seite enthält keine Gesuchte
            'x = b ° x => x - b ° x = 0
            If MAM(1) > 0 Then : CAC = "a = b => a - b = 0" ' x = b ° x => x - b ° x = 0
              DCCA({" - " & KAH(2), "0"}, {MAC(2), MAD(2), MAC(2) - 3, MAC(2)})
              DDCC("a = `b` => `a` - b` = `0") : Exit Sub
            End If ' linke Seite enthält eine gesuchte
          End If ' Operatorengruppe der rechten Seite ist > 4: ·: ˄˅
        End If
      End If
      If MAM(2) = 1 Then ' Rechte Seite ist eine Gesuchte
        'a = b => b = a
        If MAM(1) = 0 Then : CAC = "a = b => b = a" ' a = b => b = a
          DCBB(KAH(2) & " = ", {MAC(2) - 3, MAD(2) + 3, MAC(1)})
          DDCA("a` = b` => `b = `a") : Exit Sub
        End If ' linke Seite enthält keine Gesuchte
        'a = b => a - b = 0
        If MAM(1) > 0 Then ' ↓ Gesuchte ist keine Zahl, ← wenn linke Seite auch Gesuchte enthält
          If MAJ(2) = 0 Then : CAC = "a = b => a - b = 0" ' a = b => a - b = 0
            DCCA({" - " & KAH(2), "0"}, {MAC(2), MAD(2), MAC(2) - 3, MAC(2)})
            DDCC("a = `b` => `a` - b` = `0") : Exit Sub
          End If
        End If ' linke Seite enthält eine Gesuchte
      End If
      If MAM(2) = 0 Then ' Rechte Seite enthält keine Gesuchte
        Dim au, ua As Boolean : If MAM(MAI(1)) = 0 Then au = True
        If MAH(1) > 1 Then ' bei mehr als einen Term in rechter Seite
          For i = MAI(1) + 1 To MAI(1) + MAH(1) - 1 Step 1
            If MAM(i) = 0 Then ua = True : Exit For ' Nicht-Gesuchte
          Next
        End If
        If ua = True Then
          'a +- b = c => a = c -+ b
          If IAB(1) = 4 Then : Dim ab As Boolean : CAC = "a +- b = c => a = c -+ b"
            'a +- b +- c = d => a = d -+ b -+ c
            For i = MAI(1) + MAH(1) - 1 To MAI(1) + 1 Step -1 ' links von letzten Term bis zweiten Term
              If MAM(i) = 0 Then ' CAA.Length statt MAD(0), weil CAA ändert sich ↘
                If KAI(i) = "+" Then : DCBB(" - " & KAH(i), {MAC(i) - 3, MAD(i) + 3, CAA.Length - MAD(i) - 3})
                  DDEB("a` + b` = c` => `a = c` - b") : ab = True : End If
                If KAI(i) = "-" Then : DCBB(" + " & KAH(i), {MAC(i) - 3, MAD(i) + 3, CAA.Length - MAD(i) - 3})
                  DDEB("a` - b` = c` => `a = c` + b") : ab = True : End If
              End If
            Next
            'a => b
            If ab = True Then Exit Sub
          End If
          'a ·: b = c => a = c :· b
          If IAB(1) = 5 Then : Dim ab As Boolean : CAC = "a ·: b = c => a = c :· b"
            'a ·: b ·: c = d + e => a = (d ± e) :· b :· c
            If IAB(2) = 4 Then
              For i = MAI(1) + MAH(1) - 1 To MAI(1) + 1 Step -1 ' links von letzten Term bis zweiten Term
                If MAM(i) = 0 Or KAI(i) = ":" Then ' auch Gesuchte mit Operator ":" nach rechts umstellen
                  If ab = True Then ' a ·: c = (d ± e) :· b => a = (d ± e) :· b :· c
                    If KAI(i) = "·" Then
                      DCBB(" : " & KAH(i), {MAC(i) - 3, MAD(i) + 3, CAA.Length - MAD(i) - 3})
                      DDEB("a` · b` = c` => `a = c` : b") : End If
                    If KAI(i) = ":" Then
                      DCBB(" · " & KAH(i), {MAC(i) - 3, MAD(i) + 3, CAA.Length - MAD(i) - 3})
                      DDEB("a` : b` = c` => `a = c` · b") : End If
                  ElseIf KAI(i) = "·" Then
                    DCCA({"(", ") : " & KAH(i)}, {MAC(i) - 3, MAD(i) + 3, MAC(2) - MAD(i) - 3, CAA.Length - MAD(i) - 3})
                    DDEE("a` · b` = c ± d` => `a = `(`c ± d`) : b") : ab = True
                  Else
                    DCCA({"(", ") · " & KAH(i)}, {MAC(i) - 3, MAD(i) + 3, MAC(2) - MAD(i) - 3, CAA.Length - MAD(i) - 3})
                    DDEE("a` : b` = c ± d` => `a = `(`c ± d`) · b") : ab = True
                  End If
                End If
              Next
            End If
            'a ·: b ·: c = d => a = d :· b :· c
            If IAB(2) <> 4 Then
              For i = MAI(1) + MAH(1) - 1 To MAI(1) + 1 Step -1 ' links von letzten Term bis zweiten Term
                If MAM(i) = 0 Or KAI(i) = ":" Then ' auch Gesuchte mit Operator ":" nach rechts umstellen
                  If KAI(i) = "·" Then
                    DCBB(" : " & KAH(i), {MAC(i) - 3, MAD(i) + 3, CAA.Length - MAD(i) - 3})
                    DDEB("a` · b` = c` => `a = c` : b") : ab = True : End If
                  If KAI(i) = ":" Then
                    DCBB(" · " & KAH(i), {MAC(i) - 3, MAD(i) + 3, CAA.Length - MAD(i) - 3})
                    DDEB("a` : b` = c` => `a = c` · b") : ab = True : End If
                End If
              Next
            End If
            'a => b
            If ab = True Then Exit Sub
          End If

          'Exit Sub

          'a ˄˅ b = c => a = c ˅˄ b
          If IAB(1) = 6 Then
            If MAM(1) > 0 Then
              Dim ab As Integer : CAC = "a ^ b = c => a = √(c ' b)"
              'a ˄ b ˄ c = a ˄ (b · c) = d => a = d ˅ (b · c)
              For i = MAI(1) + MAH(1) - 1 To MAI(1) + 1 Step -1
                'a ^ b ^ c = d
                If MAM(i) = 0 Then : ab += 1
                  'a ^ b ^ c = √(d)
                  If ab = 1 Then : CAA = CAA.Insert(MAC(2), "√(") : CAA = CAA.Insert(CAA.Length, ")")
                    'a ^ b ^ c = √(d ' b)
                    CAA = CAA.Insert(CAA.Length - 1, " ' " & KAH(i)) : End If
                  'a ^ b ^ c = √(d ' b · c)
                  If ab > 1 Then CAA = CAA.Insert(CAA.Length - 1, " · " & KAH(i))
                  'a = √(d ' b · c)
                  CAA = CAA.Remove(MAC(i) - 3, MAD(i) + 3)  'DEAA(KAH(0), "a ^ b = c", "a = √(c ' b)")
                End If
              Next
              If ab > 0 Then : DAAF() : If B_ = True Then : Exit Sub : End If : End If
            End If
          End If
          '√(a ' b) = c => a = c ^ b
          If MAB(1) = 3 Then
            CAC = "√(a ' b) = c => a = c ^ b"
            If MAB(1) = 5 Then

              If IAB(2) = 4 Or IAB(2) = 6 Then

                CAA = CAA.Insert(CAA.Length, ")") : CAA = CAA.Insert(MAC(2), "(")
              End If
            Else
              If MAB(2) > 0 Or IAB(2) = 0 Or IAB(2) = 5 Then

                CAA = CAA.Insert(MAC(2), "-") : CAA = CAA.Replace("--", "")
              Else
                CAA = CAA.Insert(CAA.Length, ")") : CAA = CAA.Insert(MAC(2), "-(")
              End If
            End If
            If IAB(1) = 1 Then

              If MAH(MAI(1) + 1) < 2 Then CAA = CAA.Insert(CAA.Length, " ^ " & KAH(MAI(1) + 1))

              If MAH(MAI(1) + 1) > 1 Then CAA = CAA.Insert(CAA.Length, " ^ (" & KAH(MAI(1) + 1) & ")")
            Else
              CAA = CAA.Insert(CAA.Length, " ^ 2") : CAC = "√(a) = b => a = b ^ 2"
            End If
            CAA = CAA.Remove(0, MAD(1))
            CAA = CAA.Insert(0, KAH(MAI(1)))
            DAAF()
            'If B_ = True Then

            '    DAAI(vbLf & KAH(0) & vbLf) : DAAJ(CAA & vbLf) : DAAK(NAA.GetString("S040"))

            '    If IAB(1) <> 1 Then DAAI("√(a) = b") : DAAK(" => ") : DAAJ("a = b ^ 2" & vbLf)

            '    If IAB(1) = 1 Then DAAI("√(a ' b) = c") : DAAK(" => ") : DAAJ("a = c ^ b" & vbLf)

            '    Exit Sub
            'End If
          End If
        End If
        If au = True Then
          If IAB(1) = 4 Or IAB(1) = 5 Then
            'a +· b = c => b = c -: a
            If KAI(MAI(1) + 1) = "+" Or KAI(MAI(1) + 1) = "·" Then
              'If IAB(1) = 5 And IAB(2) = 4 Then CAA = KAH(0).Insert(MAC(2), "(") : CAA &= ")"
              'CAA = CAA.Remove(MAC(MAI(1)), MAD(MAI(1)) + 3)
              'If IAB(1) = 4 Then CAA &= " - " & KAH(MAI(1)) : CAC = "a + b = c => b = c - a"
              'If IAB(1) = 5 Then CAA &= " : " & KAH(MAI(1)) : CAC = "a · b = c => b = c : a"
              'DAAF()

              'If B_ = True Then DEAA(KAH(0), CAC.Substring(0, 9), CAC.Substring(13, 9)) : Exit Sub
            End If
            'a -: b = c => b = a -: c
            If KAI(MAI(1) + 1) = "-" Or KAI(MAI(1) + 1) = ":" Then
              'Dim ab, ac As String : ab = "" : aa = KAH(0)
              ''a -: b = c + d => b = a -: (c + d)
              'If IAB(1) >= IAB(2) And IAB(2) > 0 Then CAA = KAH(0).Insert(MAC(2), "(") : CAA &= ")"
              'CAA = CAA.Insert(MAC(2), KAH(MAI(1)) & " " & KAI(MAI(1) + 1) & " ")
              'CAA = CAA.Remove(MAC(1), MAD(1)) : ac = ab & KAH(MAI(1) + 1)
              'If IAB(1) = 4 Then CAC = "a - b = c => b = a - c" Else CAC = "a : b = c => b = a : c"
              'If MAH(1) > 2 Then
              '    For i = MAI(1) + 2 To MAI(1) + MAH(1) - 1 Step 1
              '        'a - b +- c = d => b -+ c = a - d
              '        If KAI(i) = "+" Then ab = " - " Else If KAI(i) = "-" Then ab = " + "
              '        'a : b ·: c = d => b :· c = a : d
              '        If KAI(i) = "·" Then ab = " : " Else If KAI(i) = ":" Then ab = " · "
              '        ac &= ab & KAH(i)
              '    Next
              'End If
              'CAA = ac & CAA : DAAF()
              'If B_ = True Then DEAA(aa, CAC.Substring(0, 9), CAC.Substring(13, 9)) : Exit Sub
            End If
          End If
          If IAB(1) = 6 And MAM(1) > 0 Then
            If MAH(1) = 2 And MAM(MAI(1) + 1) > 0 Then : CAC = "a ^ b = c => b = ln(c) : ln(a)"
              'CAA = CAA.Insert(MAC(2), "ln(") : CAA = CAA.Insert(CAA.Length, ") : ln(" & KAH(MAI(1)) & ")")
              'CAA = CAA.Remove(MAC(MAI(1)), MAD(MAI(1)) + 3) : DAAF()
              'If B_ = True Then DEAA(KAH(0), "a ^ b = c", "b = ln(c) : ln(a)") : Exit Sub
            End If
          End If
        End If
        If MAM(1) = 1 And IAA(1) = 1 Then ' !!! IAA !!!
          CAC = "-a = b => a = -b" ' ! -a < b => a > -b !
          'If KAI(2) = "<" Then CAA = CAA.Remove(MAC(2) - 2, 1) : CAA = CAA.Insert(MAC(2) - 2, ">") : CAC = "-a < b => a > -b"
          'If KAI(2) = ">" Then CAA = CAA.Remove(MAC(2) - 2, 1) : CAA = CAA.Insert(MAC(2) - 2, "<") : CAC = "-a > b => a < -b"
          'If IAB(2) = 4 Or IAB(2) = 6 Then : CAA = CAA.Insert(MAC(2), "(") : CAA &= ")" : End If : If IAB(2) = 5 Then

          '    If IAB(MAI(2)) = 6 Then CAA = CAA.Insert(MAC(2), "(") : CAA = CAA.Insert(MAC(MAI(2) + 1) - 2, ")")
          'End If
          'CAA = CAA.Insert(MAC(2), "-") : CAA = CAA.Replace("--", "") : CAA = CAA.TrimStart("-") : DAAF()

          'If B_ = True Then

          '    DAAI(vbLf & KAH(0) & vbLf) : DAAJ(CAA & vbLf) : DAAK(NAA.GetString("S040"))

          '    DAAI(CAC.Substring(0, 6)) : DAAK(" => ") : DAAJ(CAC.Substring(10, 6) & vbLf) : Exit Sub
          'End If
        End If
        If IAB(1) = 4 And MAH(1) = 2 And MAM(1) > 4 Then
          'a b ^ 2 + c b + d = 0
          Dim ae, af, ag, ah, ai, aj, ak, al As String : Dim am, an As Integer

          ae = "" : af = "" : ag = "" : ah = "" : ai = "" : aj = "" : ak = "" : al = "" : am = 1 : an = -1

          For i = 0 To 1 Step 1

            If IAB(MAI(1) + i) = 5 Then

              For j = MAI(MAI(1) + i) To MAI(MAI(1) + i) + MAH(MAI(1) + i) - 1 Step 1

                If KAI(j) <> ":" Then

                  If MAM(MAI(1) + i) = 2 Then If KAH(j) = CAB Or KAH(j) = "-" & CAB Then ae &= "1"

                  If MAM(MAI(1) + i) = 3 Then

                    If KAH(j) = CAB & " ^ 2" Or KAH(j) = "-" & CAB & " ^ 2" Or KAH(j) = "-(" & CAB & " ^ 2)" Then

                      ae &= "2" : End If
                  End If
                  If ae.Length = 1 + i Then

                    If j = MAI(MAI(1) + i) Then

                      aj = KAH(MAI(1) + i).Remove(MAC(j) - MAC(MAI(1) + i), MAD(j) + 3)

                      ak = KAH(2) : If IAA(2) = 1 Then ak = ak.TrimStart("-")

                      If IAB(2) = 4 Then ak = " · (" & ak & ")" Else ak = " · " & ak

                      If KAI(j + i) = ":" Then aj = aj.Insert(MAC(j) - MAC(MAI(1) + i), "1 : ")
                    End If
                    If j > MAI(MAI(1) + i) Then

                      aj = KAH(MAI(1) + i).Remove(MAC(j) - MAC(MAI(1) + i) - 3, MAD(j) + 3)

                      ak = KAH(2) : If IAA(2) = 1 Then ak = ak.TrimStart("-")

                      If IAB(2) = 4 Then ak = " · (" & ak & ")" Else ak = " · " & ak

                      If IAA(MAI(1) + i) = 1 Then aj = aj.TrimStart("-")
                    End If
                    If ae = "1" Or ae = "21" Then ag = aj : af = ag & " ^ 2"

                    If ae = "2" Or ae = "12" Then ah = "4 · " & aj & ak : ai = "2 : (" & aj & ")" : al = aj
                    Exit For
                  End If
                End If
              Next
            Else
              'a ^ 2 · b + a · c = d
              ak = KAH(2) : If IAA(2) = 1 Then ak = ak.TrimStart("-")

              If IAB(2) = 4 Then ak = "4 · (" & ak & ")" Else ak = "4 · " & ak

              If KAH(MAI(1) + i) = CAB Then ae &= "1" : af = "1" : ag = "1"

              If KAH(MAI(1) + i) = "-" & CAB Then ae &= "1" : af = "1" : ag = "1"

              If KAH(MAI(1) + i) = CAB & " ^ 2" Then ae &= "2" : ah = ak : ai = "2"

              If KAH(MAI(1) + i) = "-" & CAB & " ^ 2" Then ae &= "2" : ah = ak : ai = "2"

              If KAH(MAI(1) + i) = "-(" & CAB & " ^ 2)" Then ae &= "2" : ah = ak : ai = "2"
            End If
          Next
          If ae = "12" Or ae = "21" Then
            'a + a ^ 2 = d
            If ae = "12" Then

              If IAA(2) = 1 Then am *= -1

              If IAA(MAI(1)) = 1 Then an *= -1

              If IAA(MAI(1) + 1) = 1 Then am *= -1 : an *= -1

              If KAI(MAI(1) + 1) = "-" Then am *= -1 : an *= -1
            End If
            'a ^ 2 + a = d
            If ae = "21" Then

              If IAA(2) = 1 Then am *= -1

              If IAA(MAI(1) + 1) = 1 Then an *= -1

              If KAI(MAI(1) + 1) = "-" Then an *= -1

              If IAA(MAI(1)) = 1 Then am *= -1 : an *= -1
            End If
            If am = 1 Then aj = " + " Else aj = " - "

            If an = 1 Then ak = " + " Else ak = " - "
            'a ^ 2 + a = d
            If KAH(2) <> "0" Then

              Dim ao As String : ao = CAB & "1 = (√(" & af & aj & ah & ")" & ak & ag & ") : " & ai : KAC.Add(ao)

              KAD.Add("a ^ 2 b + a c + d = 0 => a1 = (-c + √(c ^ 2 - 4 b d)) : 2 : b")


              'DAAI(vbLf & CAA & vbLf)

              'DAAJ(ao & vbLf) : DAAK(NAA.GetString("S040")) : DAAI("a ^ 2 b + a c + d = 0") : DAAK(" => ")

              'DAAJ("a1 = (-c + √(c ^ 2 - 4 b d)) : 2 : b" & vbLf)



              'ZBZ.Document.Selection.StartPosition = 0

              'ZBZ.Document.Selection.EndPosition = ZBZ.Document.Selection.StoryLength - 1

              'MAR.Add(ZBZ.Document.Selection.StoryLength - 1)

              'ZBY.Document.Selection.FormattedText = ZBZ.Document.Selection.FormattedText

              ''ZBZ.Document.Selection.Cut() : ZBY.Document.Selection.Paste(0)

              'ZBZ.Document.SetText(TextSetOptions.FormatRtf, "")



              ao = CAB & "2 = (-√(" & af & aj & ah & ")" & ak & ag & ") : " & ai : KAC.Add(ao)

              KAD.Add("a ^ 2 b + a c + d = 0 => a2 = (-c - √(c ^ 2 - 4 b d)) : 2 : b")

              KAG.Add("a ^ 2 b + a c + d = 0 => a = (-c ± √(c ^ 2 - 4 b d)) : 2 : b")


              'DAAI(vbLf & CAA & vbLf) : DAAJ(ao & vbLf) : DAAK(NAA.GetString("S040"))

              'DAAI("a ^ 2 b + a c + d = 0") : DAAK(" => ") : DAAJ("a2 = (-c - √(c ^ 2 - 4 b d)) : 2 : b" & vbLf)



              'ZBZ.Document.Selection.StartPosition = 0

              'ZBZ.Document.Selection.EndPosition = ZBZ.Document.Selection.StoryLength - 1

              'MAR.Add(ZBZ.Document.Selection.StoryLength - 1)

              'ZBY.Document.Selection.FormattedText = ZBZ.Document.Selection.FormattedText

              ''ZBZ.Document.Selection.Cut() : ZBY.Document.Selection.Paste(0)


              DAAE() : _M += 1 : Exit Sub
            End If
            'a ^ 2 + a = 0
            If KAH(2) = "0" Then

              If an = -1 Then ak = "-" : ag = "(" & ag & ")" Else ak = ""

              If af = "1" And ai = "2" Then ae = ak & "1"

              If af <> "1" And ai = "2" Then ae = ak & ag

              If af = "1" And ai <> "2" Then ae = ak & "1 : (" & al & ")"

              If af <> "1" And ai <> "2" Then ae = ak & ag & " : (" & al & ")"

              Dim ao As String : ao = CAB & "1 = 0" : KAC.Add(ao)

              KAD.Add("a ^ 2 b + a c = 0 => a1 = 0")


              'DAAI(vbLf & CAA & vbLf) : DAAJ(ao & vbLf)

              'DAAK(NAA.GetString("S040")) : DAAI("a ^ 2 b + a c = 0") : DAAK(" => ")

              'DAAJ("a1 = 0" & vbLf)



              'ZBZ.Document.Selection.StartPosition = 0

              'ZBZ.Document.Selection.EndPosition = ZBZ.Document.Selection.StoryLength - 1

              'MAR.Add(ZBZ.Document.Selection.StoryLength - 1)

              'ZBY.Document.Selection.FormattedText = ZBZ.Document.Selection.FormattedText

              ''ZBZ.Document.Selection.Cut() : ZBY.Document.Selection.Paste(0)

              'ZBZ.Document.SetText(TextSetOptions.FormatRtf, "")



              ao = CAB & "2 = " & ae : KAC.Add(ao) : KAD.Add("a ^ 2 b + a c = 0 => a2 = -c / b")

              KAG.Add("a ^ 2 b + a c = 0 => a1 = 0, a2 = -c / b") '
              '
              'DAAI(vbLf & CAA & vbLf)

              'DAAJ(ao & vbLf) : DAAK(NAA.GetString("S040")) : DAAI("a ^ 2 b + a c = 0")

              'DAAK(" => ") : DAAJ("a2 = -c / b" & vbLf)
              '


              'ZBZ.Document.Selection.StartPosition = 0

              'ZBZ.Document.Selection.EndPosition = ZBZ.Document.Selection.StoryLength - 1

              'MAR.Add(ZBZ.Document.Selection.StoryLength - 1)

              'ZBY.Document.Selection.FormattedText = ZBZ.Document.Selection.FormattedText

              ''ZBZ.Document.Selection.Cut() : ZBY.Document.Selection.Paste(0)

              DAAE() : _M += 1 : Exit Sub
            End If
          End If
        End If
      End If
    End If
    'a = b +- c => a -+ c = b
    'a = b ·: c => a :· c = b
    'a = b +· c => a -: b = c
    'a = b -: c => b -: a = ɔ
    'a +- b = c => a = c -+ b
    'a ·: b = c => a = c :· b
    'a +· b = c => b = c -: a
    'a -: b = c => b = a -: c
    '-a = b => a = -b

    'a = b -: c => a -: b = -:c
    'a = b - c => a - b = 0 - c
    'a = b : c => a : b = 1 : c
  End Sub
  Private Sub DBCA()
    CAC = "a = b" : D_Z1()
    ' Einziger Term
    _F = -1 : Do : _F += 1 ' extrahierte Reihenfolge
      ' Rechnungen
      Select Case KAH(_F)
        ' e = 2,72
        Case "e" : DEWA({1001, 1, 1, 1, 3, 3, 3, 0})
        ' π = 3,14
        Case "π" : DEWA({1002, 2, 1, 1, 3, 3, 3, 0})
        ' -e = 2,72
        Case "-e" : DEWA({1003, 3, 1, 1, 3, 3, 3, 0})
        ' -π = 3,14
        Case "-π" : DEWA({1004, 4, 1, 1, 3, 3, 3, 0})
        ' -0 = 0
        Case "-0" : DEWA({1005, 5, 1, 1, 3, 3, 3, 0})
        ' +∞ = ∞
        Case "+∞" : DEWA({1006, 6, 1, 1, 3, 3, 3, 0})
        ' ln(0) = -∞
        Case "ln(0)" : DEWA({1007, 7, 1, 1, 3, 3, 3, 0})
        ' -ln(0) = ∞
        Case "-ln(0)" : DEWA({1008, 6, 1, 1, 3, 3, 3, 0})
        ' ln(e) = 1
        Case "ln(e)" : DEWA({1009, 8, 1, 1, 3, 3, 3, 0})
        ' -ln(e) = -1
        Case "-ln(e)" : DEWA({1010, 9, 1, 1, 3, 3, 3, 0})
        ' log(0) = -∞
        Case "log(0)" : DEWA({1011, 7, 1, 1, 3, 3, 3, 0})
        ' -log(0) = ∞
        Case "-log(0)" : DEWA({1012, 6, 1, 1, 3, 3, 3, 0})
      End Select
      ' Exit Sub
      If CAA <> KAH(0) Then Exit Sub
    Loop While _F < _L - 1
    ' Vorzeichen "-"
    _F = -1 : Do : _F += 1 ' extrahierte Reihenfolge
      _AI = ""
      ' Bedingungen
      If IAA(_F) > 1 Then : _AI = KAI(_F) & "`" &
          DFAC(_F) : If IAB(MAE(_F)) = 5 Then : _AI =
            DFAC(MAI(MAE(_F))) & "`" & _AI : End If
      End If
      ' Rechnungen
      Select Case _AI : Case "" : Exit Select
        ' a + -b = a - b
        Case "+`3" : DEWA({1021, 11, 2, 2, 3, 8, 8, 0})
        ' a - -b = a + b
        Case "-`3" : DEWA({1022, 12, 2, 2, 3, 8, 8, 0})
        ' a ± -b = a ∓ b
        Case "±`3" : DEWA({1023, 13, 2, 2, 3, 8, 8, 0})
        ' a ∓ -b = a ± b
        Case "∓`3" : DEWA({1024, 14, 2, 2, 3, 8, 8, 0})
        ' a + -b' = a - b'
        Case "+`44" : DEWA({1025, 11, 2, 3, 3, 13, 13, 2})
        ' a + -b'. = a - b'.
        Case "+`54" : DEWA({1025, 11, 2, 4, 3, 13, 13, 2})
        ' a - -b' = a + b'
        Case "-`44" : DEWA({1026, 12, 2, 3, 3, 13, 13, 2})
        ' a - -b'. = a + b'.
        Case "-`54" : DEWA({1026, 12, 2, 4, 3, 13, 13, 2})
        ' a ± -b' = a ∓ b'
        Case "±`44" : DEWA({1027, 13, 2, 3, 3, 13, 13, 2})
        ' a ± -b'. = a ∓ b'.
        Case "±`54" : DEWA({1027, 13, 2, 4, 3, 13, 13, 2})
        ' a ∓ -b' = a ± b'
        Case "∓`44" : DEWA({1028, 14, 2, 3, 3, 13, 13, 2})
        ' a ∓ -b'. = a ± b'.
        Case "∓`54" : DEWA({1028, 14, 2, 4, 3, 13, 13, 2})
        ' a · -b = -a · b
        Case "1`·`3" : DEWA({1031, 10, 3, 5, 3, 8, 6, 0})
        ' a : -b = -a : b
        Case "1`:`3" : DEWA({1031, 10, 3, 5, 3, 8, 6, 0})
        ' -a · -b = a · b
        Case "3`·`3" : DEWA({1032, 15, 4, 6, 4, 15, 1, 0})
        ' -a : -b = a : b
        Case "3`:`3" : DEWA({1032, 15, 4, 6, 4, 15, 1, 0})
        ' a' · -b = -a' · b
        Case "42`·`3" : DEWA({1033, 10, 3, 7, 3, 16, 14, 1})
        ' a' : -b = -a' : b
        Case "42`:`3" : DEWA({1033, 10, 3, 7, 3, 16, 14, 1})
        ' -a' · -b = a' · b
        Case "44`·`3" : DEWA({1034, 15, 4, 8, 4, 20, 7, 1})
        ' -a' : -b = a' : b
        Case "44`:`3" : DEWA({1034, 15, 4, 8, 4, 20, 7, 1})
        ' a · -b' = -a · b'
        Case "1`·`44" : DEWA({1035, 10, 3, 9, 3, 13, 9, 2})
        ' a : -b' = -a : b'
        Case "1`:`44" : DEWA({1035, 10, 3, 9, 3, 13, 9, 2})
        ' -a · -b' = a · b'
        Case "3`·`44" : DEWA({1036, 15, 4, 10, 4, 18, 5, 2})
        ' -a : -b' = a : b'
        Case "3`:`44" : DEWA({1036, 15, 4, 10, 4, 18, 5, 2})
        ' a' · -b' = -a' · b'
        Case "42`·`44" : DEWA({1037, 10, 3, 11, 3, 19, 17, 3})
        ' a' : -b' = -a' : b'
        Case "42`:`44" : DEWA({1037, 10, 3, 11, 3, 19, 17, 3})
          ' -a' · -b' = a' · b'
        Case "44`·`44" : DEWA({1038, 15, 4, 12, 4, 21, 12, 3})
        ' -a' : -b' = a' : b'
        Case "44`:`44" : DEWA({1038, 15, 4, 12, 4, 21, 12, 3})
      End Select
      ' Exit Sub
      If CAA <> KAH(0) Then Exit Sub
    Loop While _F < _L - 1
    ' Unbestimmte ☼
    _G = -1 : Do : _G += 1 ' extrahierte Reihenfolge
      ' Bedingungen
      If _G = MAI(MAE(_G)) Then _AI = "" ' ☼ □ ○ ◌ ∞
      Select Case KAH(_G) : Case "0", "1", "-1", "∞", "-∞"
          If _AI = "" Then : _AI = "☼" : _F = _G : Else
            _AI = KAI(_F) & "`" & KAH(_F) & "`" &
              KAI(_G) & "`" & KAH(_G) : End If : End Select
      ' Rechnungen
      Select Case _AI : Case "", "☼" : Exit Select
        ' 0 ^ 0 = ☼
        Case "`0`˄`0" : DEWA({1041, 15, 5, 13, 6, 3, 3, 0})
        ' 0 : 0 = ☼
        Case "`0`:`0" : DEWA({1042, 15, 5, 13, 6, 3, 3, 0})
        ' ☼ · 0 : 0 = ☼
        Case "·`0`:`0" : DEWA({1043, 15, 6, 14, 6, 4, 4, 0})
        ' ☼ : 0 · 0 = ☼
        Case ":`0`·`0" : DEWA({1044, 18, 7, 15, 6, 4, 4, 0})
        ' 0 · ∞ = ☼
        Case "`0`·`∞" : DEWA({1045, 15, 5, 13, 6, 3, 3, 0})
        ' ☼ · 0 · ∞ = ☼
        Case "·`0`·`∞" : DEWA({1046, 15, 6, 14, 6, 4, 4, 0})
        ' 1 ^ ∞ = ☼
        Case "`1`˄`∞" : DEWA({1047, 15, 5, 13, 6, 3, 3, 0})
        ' 1 ^ -∞ = ☼
        Case "`1`˄`-∞" : DEWA({1048, 19, 5, 13, 6, 3, 3, 0})
        ' ∞ · 0 = ☼
        Case "`∞`·`0" : DEWA({1049, 15, 5, 13, 6, 3, 3, 0})
        ' -∞ · 0 = ☼
        Case "`-∞`·`0" : DEWA({1050, 15, 5, 13, 6, 3, 3, 4})
        ' a · ∞ · 0 = ☼
        Case "·`∞`·`0" : DEWA({1051, 15, 6, 14, 6, 4, 4, 0})
        ' ∞ ^ 0 = ☼
        Case "`∞`˄`0" : DEWA({1052, 15, 5, 13, 6, 3, 3, 0})
        ' -∞ ^ 0 = ☼
        Case "`-∞`˄`0" : DEWA({1053, 15, 5, 13, 6, 3, 3, 0})
        ' ∞ - ∞ = ☼
        Case "`∞`-`∞" : DEWA({1054, 15, 5, 13, 6, 3, 3, 0})
        ' -∞ + ∞ = ☼
        Case "`-∞`+`∞" : DEWA({1055, 15, 5, 13, 6, 3, 3, 0})
        ' a + ∞ - ∞ = ☼
        Case "+`∞`-`∞" : DEWA({1056, 15, 6, 14, 6, 4, 4, 0})
        ' a - ∞ + ∞ = ☼
        Case "-`∞`+`∞" : DEWA({1057, 17, 7, 15, 6, 4, 4, 0})
        ' ∞ : ∞ = ☼
        Case "`∞`:`∞" : DEWA({1058, 15, 5, 13, 6, 3, 3, 0})
        ' -∞ : ∞ = -☼
        Case "`-∞`:`∞" : DEWA({1059, 16, 5, 13, 6, 3, 3, 0})
        ' a · ∞ : ∞ = ☼
        Case "·`∞`:`∞" : DEWA({1060, 15, 6, 14, 6, 4, 4, 0})
        ' a : ∞ · ∞ = ☼
        Case ":`∞`·`∞" : DEWA({1061, 18, 7, 15, 6, 4, 4, 0})
      End Select
      ' Exit Sub
      If CAA <> KAH(0) Then Exit Sub
    Loop While _G < _L - 1
    ' Funktionelle'
    _F = -1 : Do : _F += 1 ' extrahierte Reihenfolge
      _AI = "" : H1(3) = MAI(_F) : _AF = "" 'ǀǁ
      ' Bedingungen
      If MAJ(_F) = 0 Then
        _AF = KAH(_F).Remove(MAD(_F) - 1, 1)
        ' a* = b
        If Double.TryParse(_AF, 0) = True Then
          If KAH(_F)(MAD(_F) - 1) = "´" Then
            _AI = "f-´´" : End If
        End If
        ' a! = b
        If Integer.TryParse(_AF, 0) = True Then
          If KAH(_F)(MAD(_F) - 1) = "!" Then
            _AI = "f-!´"
            H1(6) = CInt(_AF) : _BA = CDbl(_AF)
            If H1(6) < 0 Then H1(6) *= -1
            _AF = "" : If _BA = 0 Then _AF = "1"
            If _BA < 0 Then _AF = "-" : _BA *= -1
            For j = H1(6) - 1 To 1 Step -1
              _BA *= j : Next
            If _AF <> "1" Then _AF &= DFAA(_BA)
          End If
        End If
        ' f(z) = z
        If MAB(_F) > 1 And MAJ(H1(3)) = 1 Then
          _AI = "1`" : _BA = CDbl(KAH(H1(3)))
          H1(6) = If(IAA(_F) > 1, -1, 1) : _BC =
            Math.PI / 180
          _BB = _BA * _BC : _BC = H1(6) / _BC
          ' f(a ' b) = c
        ElseIf IAB(H1(3)) = 1 Then : _AI = "1"
          H1(6) = MAI(H1(3))
          If MAJ(H1(6)) = 1 Then : _AI &= "1"
            _BA = CDbl(KAH(H1(6))) : End If
          If MAJ(H1(6) + 1) = 1 Then : _AI &= "2"
            _BB = CDbl(KAH(H1(6) + 1)) : End If
        End If
        ' S e l e c t
        _AI &= CStr(MAB(_F)) : Select Case _AI
          ' (a)
          Case "1" : If IAB(H1(3)) = 0 Then
              _AI &= "```"
              If IAA(_F) > 1 Then _AI &= DFAC(H1(3))
              ' (a o b) = a o b
            ElseIf IAB(H1(3)) > 3 Then ' Operator umkehren
              If IAB(MAE(_F)) > IAB(H1(3)) Then Continue Do
              Select Case KAI(_F)
                Case "-", ":", "˅" : _AI = "ou" : End Select
              If _AI = "ou" Then ' `o`u`
                If IAB(MAE(_F)) = IAB(H1(3)) Then _AI = "o"
                If IAB(H1(3)) < 6 Then _AI &= "ou" ' oou
                ' Operator innen von Vorzeichen umkehren
              ElseIf IAA(_F) = 2 Then : _AI = "v"
                If IAB(H1(3)) = 4 Then _AI &= "ou" ' vou
              End If
              If _AI <> "oou" And _AI <> "vou" Then
                _AI = "`n`u`" ' ↓ (a ^ b) ^ c ≠ a ^ (b ^ c)
                If IAB(MAE(_F)) = 6 Then _AI &= KAI(_F)
                ' -(a * b) = -a * b
                If IAA(_F) > 1 Then ' And IAB(H1(3)) > 4
                  _AI &= DFAC(H1(3)) : End If ' -(a)
              ElseIf _AI = "oou" Then : _AI &= KAI(_F)
              ElseIf _AI = "vou" Then
                _AI &= DFAC(MAI(H1(3)))
              End If ' nicht umkehren bzw nicht ausklammern
            End If
        ' |v| = b
          Case "2" : If IAA(H1(3)) > 1 Then _AI &= "`-"
        ' |z| = b
          Case "1`2"
            _AI &= If(IAA(_F) > 1, "`-", "`+")
            ' |-z| = b
            If _BA < 0 Then _AI &= "`-"
          ' √(a) = b
          Case "1`3" : _AF = DFAA(H1(6) * Math.Sqrt(_BA))
          ' If XAB < 0 Then 0 + XAB = Math.Sqrt(XAB)*i
          ' √(a ' b) = c
          Case "1123" : _BA = Math.Pow(_BA, 1 / _BB)
            If _BA >= 0 And CStr(_BA) <> "NaN" Then
              _AF = DFAA(_BA) : _AI &= "*"
              If IAA(_F) > 1 Then _AF = "-" & _AF
              If _AF = "-0" Then : _AF = "0" : End If
            End If
          '√(a ' 2) = √(a)
          Case "123"
            If KAH(H1(6) + 1) = "2" Then _AI &= "*"
          ' ln(a) = b
          Case "1`8" : _AF = DFAA(H1(6) * Math.Log(_BA))
          ' If XAB<0 Then 0+XAB=Math.Log(Math.E^Math.PI)*i
          ' log(a) = b
          Case "1`9" : _AF = DFAA(H1(6) * Math.Log10(_BA))
          ' If XAB<0 Then XAB=0+Math.Log(Math.E^Math.PI)*i
          ' log(a ' b) = c
          Case "1129"
            _BA = Math.Log(_BB) / Math.Log(_BA)
            If _BA >= 0 And CStr(_BA) <> "NaN" Then
              _AF = DFAA(_BA) : _AI &= "*"
              If IAA(_F) > 1 Then _AF = "-" & _AF
              If _AF = "-0" Then : _AF = "0" : End If
            End If
          ' tan*(a) = b
          Case "1`11" : _AF = DFAA(H1(6) * Math.Cos(_BB))
          Case "1`12" : _AF = DFAA(H1(6) * Math.Sin(_BB))
          Case "1`13" : _AF = DFAA(H1(6) * Math.Tan(_BB))
          Case "1`14" : _AF = DFAA(H1(6) / Math.Tan(_BB))
          Case "1`15" : _AF = DFAA(_BC * Math.Acos(_BA))
          Case "1`16" : _AF = DFAA(_BC * Math.Asin(_BA))
          Case "1`17" : _AF = DFAA(_BC * Math.Atan(_BA))
          Case "1`18" : _AF = DFAA(_BC * Math.Atan(1 / _BA))
        End Select
      End If
      ' Rechnungen
      Select Case _AI : Case "" : Exit Select
        ' a! = b
        Case "f-!´0" : DEWA({1071, 0, 1, 1, 3, 3, 3, 5})
        ' a´ = 0
        Case "f-´´0" : DEWA({1072, 5, 1, 1, 3, 2, 3, 9})
        ' √(a) = b
        Case "1`3" : DEWA({1081, 0, 1, 1, 3, 11, 2, 8})
        ' ln(a) = b
        Case "1`8" : DEWA({1082, 0, 1, 1, 3, 11, 2, 8})
        ' log(a) = b
        Case "1`9" : DEWA({1083, 0, 1, 1, 3, 11, 2, 8})
        ' cos(a) = b
        Case "1`11" : DEWA({1091, 0, 1, 1, 3, 11, 2, 8})
        ' sin(a) = b
        Case "1`12" : DEWA({1092, 0, 1, 1, 3, 11, 2, 8})
        ' tan(a) = b
        Case "1`13" : DEWA({1093, 0, 1, 1, 3, 11, 2, 8})
        ' cot(a) = b
        Case "1`14" : DEWA({1094, 0, 1, 1, 3, 11, 2, 8})
        ' acos(a) = b
        Case "1`15" : DEWA({1095, 0, 1, 1, 3, 11, 2, 8})
        ' asin(a) = b
        Case "1`16" : DEWA({1096, 0, 1, 1, 3, 11, 2, 8})
        ' atan(a) = b
        Case "1`17" : DEWA({1097, 0, 1, 1, 3, 11, 2, 8})
        ' acot(a) = b
        Case "1`18" : DEWA({1098, 0, 1, 1, 3, 11, 2, 8})
        ' √(a ' 2) = √(a)
        Case "123*" : DEWA({1101, 0, 22, 50, 2, 8, 1, 0})
        ' √(a ' b) = c
        Case "1123*" : DEWA({1102, 0, 1, 1, 3, 3, 3, 11})
        ' log(a ' b) = c
        Case "1129*" : DEWA({1103, 0, 1, 1, 3, 3, 3, 11})
        ' (a) = a
        Case "1```" : DEWA({1111, 0, 16, 30, 4, 10, 1, 0})
        ' (a o b) = a o b
        Case "`n`u`" : DEWA({1111, 0, 16, 30, 4, 10, 1, 0})
        ' -(a) = -a
        Case "1```1" : DEWA({1112, 0, 17, 31, 4, 10, 6, 0})
        ' -(a o b) = -a o b
        Case "`n`u`1" : DEWA({1112, 0, 17, 31, 4, 10, 6, 0})
        ' -(-a) = a
        Case "1```3" : DEWA({1113, 0, 18, 32, 4, 10, 1, 0})
        ' -(-a o b) = a o b
        Case "`n`u`3" : DEWA({1113, 0, 18, 32, 4, 10, 1, 0})
        ' -(a') = -a'
        Case "`n`u`42" : DEWA({1114, 0, 17, 33, 4, 22, 9, 1})
        ' -(a'.) = -a'.
        Case "`n`u`52" : DEWA({1114, 0, 17, 34, 4, 22, 9, 1})
        ' -(-a') = a'
        Case "`n`u`44" : DEWA({1115, 0, 18, 35, 4, 22, 5, 1})
        ' -(-a'.) = a'.
        Case "`n`u`54" : DEWA({1115, 0, 18, 36, 4, 22, 5, 1})
        ' -(a'.) = -(a').
        Case "`n`u`12" : DEWA({1116, 0, 19, 37, 3, 4, 8, 0})
        ' -(-a'.) = -(-a').
        Case "`n`u`14" : DEWA({1116, 0, 19, 37, 3, 4, 8, 0})
        ' -(a'.) = -(a').
        Case "`n`u`32" : DEWA({1116, 0, 19, 37, 3, 4, 8, 0})
        ' -(-a'.) = -(-a').
        Case "`n`u`34" : DEWA({1116, 0, 19, 37, 3, 4, 8, 0})
        ' a - (b +- c) = a - b -+ c
        Case "oou-" : DEWA({1121, 0, 16, 38, 100, 23, 8, 0})
        ' a : (b ·: c) = a : b :· c
        Case "oou:" : DEWA({1122, 0, 16, 38, 100, 23, 8, 0})
        ' -(a +- b) = -a -+ b
        Case "vou1" : DEWA({1123, 0, 17, 39, 100, 24, 15, 0})
        ' -(-a +- b) = a -+ b
        Case "vou3" : DEWA({1124, 0, 18, 40, 100, 24, 8, 0})
        ' -(a ^ b +- c) = -(a ^ b) -+ c
        Case "vou2" : DEWA({1125, 0, 19, 41, 100, 25, 8, 0})
        ' -(-a ^ b +- c) = -(-a ^ b) -+ c
        Case "vou4" : DEWA({1125, 0, 19, 41, 100, 25, 8, 0})
        ' -(a ^ 2 +- b) = -(a ^ 2) -+ b
        Case "vou22" : DEWA({1125, 0, 19, 41, 100, 25, 8, 0})
        ' -(-a ^ 2 +- b) = -(-a ^ 2) -+ b
        Case "vou24" : DEWA({1125, 0, 19, 41, 100, 25, 8, 0})
        ' -(a ^ b · c +- d) = -(a ^ b) · c -+ d
        Case "vou12" : DEWA({1126, 0, 20, 42, 100, 25, 26, 0})
        ' -(-a ^ b · c +- d) = -(-a ^ b) · c -+ d
        Case "vou14" : DEWA({1126, 0, 20, 42, 100, 25, 26, 0})
        ' -(a ^ 2 · b +- c) = -(a ^ 2) · b -+ c
        Case "vou32" : DEWA({1126, 0, 20, 42, 100, 25, 26, 0})
        ' -(-a ^ 2 · b +- c) = -(-a ^ 2) · b -+ c
        Case "vou34" : DEWA({1126, 0, 20, 42, 100, 25, 26, 0})
        ' -(a ^ 3 +- b) = -a ^ 3 -+ b
        Case "vou42" : DEWA({1127, 0, 17, 43, 100, 28, 27, 1})
        ' -(a ^ 3 · b +- c) = -a ^ 3 · b -+ c
        Case "vou52" : DEWA({1127, 0, 17, 44, 100, 28, 27, 1})
        ' -(-a ^ 3 +- b) = a ^ 3 -+ b
        Case "vou44" : DEWA({1128, 0, 18, 45, 100, 28, 29, 1})
        ' -(-a ^ 3 · b +- c) = a ^ 3 · b -+ c
        Case "vou54" : DEWA({1128, 0, 18, 46, 100, 28, 29, 1})
        ' ǀz| = z
        Case "1`2`+" : DEWA({1131, 0, 16, 30, 4, 10, 1, 10})
        ' -ǀz| = -z
        Case "1`2`-" : DEWA({1132, 0, 17, 31, 4, 10, 6, 10})
        ' ǀ-z| = -z, z < 0
        Case "1`2`+`-" : DEWA({1133, 0, 21, 48, 4, 10, 1, 10})
        ' -ǀ-z| = -z, z < 0
        Case "1`2`-`-" : DEWA({1134, 0, 21, 49, 4, 10, 6, 10})
        ' ǀ-v| = ǀv|
        Case "2`-" : DEWA({1135, 0, 17, 47, 2, 8, 1, 0})
      End Select
      ' Exit Sub
      If CAA <> KAH(0) Then Exit Sub
    Loop While _F < _L - 1
    ' Null und Eins
    _F = _L : Do : _F -= 1 ' extrahierte Reihenfolge
      _AI = ""
      ' Bedingungen
      If MAJ(_F) = 1 Then : _AF = KAH(_F) ' Zahlen
        _AI = KAI(_F) & "`" & _AF : H1(4) = MAE(_F)
        H1(5) = MAH(H1(4))
        If _AF = "0" And IAB(H1(4)) = 5 Then : DB_1()
        Else : _AI &= "`"
          If KAI(_F) = "" And H1(5) > 1 Then
            _G = _F + 1 : _AI &= KAI(_G) : End If
        End If
        ' 0 - a = -a
        If _AI = "`0`-" Then _AI &= "`" & DFAC(_G)
        ' -1 · a = -a
        If _AI = "`-1`·" Then _AI &= "`" & DFAC(_G)
        ' a ·: -1 = -a
        If _AI = "·`-1`" Or _AI = ":`-1`" Then
          _AI = DFAC(MAI(H1(4))) & "`" & _AI : End If
      End If
      ' Rechnungen
      Select Case _AI : Case "" : Exit Select
        ' a + 0 = a
        Case "+`0`" : DEWA({1141, 0, 8, 16, 2, 4, 1, 0})
        ' a - 0 = a
        Case "-`0`" : DEWA({1141, 0, 8, 16, 2, 4, 1, 0})
        ' a ± 0 = a
        Case "±`0`" : DEWA({1141, 0, 8, 16, 2, 4, 1, 0})
        ' a ∓ 0 = a
        Case "∓`0`" : DEWA({1142, 0, 8, 16, 2, 4, 1, 0})
        ' a · 0 = 0
        Case "`·`0" : DEWA({1143, 5, 9, 17, 6, 6, 1, 7})
        ' ☼ · a · 0 = ☼ · 0
        Case "·`·`0" : DEWA({1144, 5, 9, 18, 6, 8, 1, 7})
        ' a : 0 = ∞
        Case "`:`0" : DEWA({1145, 6, 10, 19, 6, 3, 3, 6})
        ' ☼ · a : 0 = ☼ · ∞
        Case "·`:`0" : DEWA({1146, 6, 9, 20, 6, 4, 4, 6})
        ' a ˄ 0 = 1
        Case "˄`0`" : DEWA({1147, 8, 10, 19, 6, 3, 3, 0})
        ' a · 1 = a
        Case "·`1`" : DEWA({1148, 0, 8, 16, 2, 4, 1, 0})
        ' a : 1 = a
        Case ":`1`" : DEWA({1148, 0, 8, 16, 2, 4, 1, 0})
        ' a ˄ 1 = a
        Case "˄`1`" : DEWA({1149, 0, 8, 16, 2, 4, 1, 0})
        ' 0 + a = a
        Case "`0`+" : DEWA({1150, 20, 5, 21, 6, 6, 1, 0})
        ' 0 · a = 0
        Case "`0`·" : DEWA({1151, 0, 11, 22, 2, 4, 1, 0})
        ' 0 : a = 0
        Case "`0`:" : DEWA({1151, 0, 11, 22, 2, 4, 1, 0})
        ' 1 · a = a
        Case "`1`·" : DEWA({1152, 20, 0, 5, 21, 6, 6, 1, 0})
        ' ☼ · 0 · a = ☼ · 0
        Case "·`0`·" : DEWA({1153, 0, 11, 23, 2, 4, 1, 7})
        ' ☼ · 0 : a = ☼ · 0
        Case "·`0`:" : DEWA({1153, 0, 11, 23, 2, 4, 1, 7})
        '' ☼ : a · 0 = ☼ · 0
        'Case ":`·`0" : DEWA({1114, 5, 9, 6, 8, 1, 7})
        ' 0 - a = -a
        Case "`0`-`1" : DEWA({1161, 10, 12, 24, 3, 6, 6, 0})
        ' 0 - a' = -(a')
        Case "`0`-`2" : DEWA({1162, 22, 13, 25, 5, 6, 10, 0})
        ' 0 - a'. = -(a').
        Case "`0`-`12" : DEWA({1162, 22, 14, 26, 5, 6, 10, 0})
        ' 0 - -a' = -(-a')
        Case "`0`-`4" : DEWA({1163, 22, 13, 25, 5, 6, 10, 0})
        ' 0 - -a'. = -(-a').
        Case "`0`-`14" : DEWA({1163, 22, 14, 26, 5, 6, 10, 0})
        ' 0 - a' = -(a')
        Case "`0`-`22" : DEWA({1163, 22, 13, 25, 5, 6, 10, 0})
        ' 0 - a'. = -(a').
        Case "`0`-`32" : DEWA({1163, 22, 14, 26, 5, 6, 10, 0})
        ' 0 - a' = -a'
        Case "`0`-`42" : DEWA({1164, 10, 12, 27, 3, 9, 9, 1})
        ' 0 - a'. = -a'.
        Case "`0`-`52" : DEWA({1164, 10, 12, 28, 3, 9, 9, 1})
        ' a' · -1 = -(a')
        Case "2`·`-1`" : DEWA({1165, 22, 15, 29, 5, 4, 10, 0})
        ' a' : -1 = -(a')
        Case "2`:`-1`" : DEWA({1165, 22, 15, 29, 5, 4, 10, 0})
        ' -a' · -1 = -(-a')
        Case "4`·`-1`" : DEWA({1165, 22, 15, 29, 5, 4, 10, 0})
        ' -a' : -1 = -(-a')
        Case "4`:`-1`" : DEWA({1165, 22, 15, 29, 5, 4, 10, 0})
        ' -1 · a = -a
        Case "`-1`·`1" : DEWA({1166, 10, 12, 24, 3, 6, 6, 0})
        ' -1 · a' = -(a')
        Case "`-1`·`2" : DEWA({1167, 22, 13, 25, 5, 6, 10, 0})
        ' -1 · a'. = -(a').
        Case "`-1`·`12" : DEWA({1167, 22, 14, 26, 5, 6, 10, 0})
        ' -1 · a' = -(a')
        Case "`-1`·`22" : DEWA({1167, 22, 13, 25, 5, 6, 10, 0})
        ' -1 · a'. = -(a').
        Case "`-1`·`32" : DEWA({1167, 22, 14, 26, 5, 6, 10, 0})
        ' -1 · -a' = -(-a')
        Case "`-1`·`4" : DEWA({1167, 22, 13, 25, 5, 6, 10, 0})
        ' -1 · -a'. = -(-a').
        Case "`-1`·`14" : DEWA({1168, 22, 14, 26, 5, 6, 10, 0})
        ' -1 · a' = -a' ! -a'.
        Case "`-1`·`42" : DEWA({1169, 10, 12, 27, 3, 9, 9, 1})
      End Select
      ' Exit Sub
      If CAA <> KAH(0) Then Exit Sub
    Loop While _F < _L - 1
    ' Zahlenrechnen
    _G = -1 : Do : _G += 1 ' extrahierte Reihenfolge
      If _G = MAI(MAE(_G)) Then _AI = ""
      ' Bedingungen
      If _AI = "" Then : _F = MAE(_G)
        ' Reihenfolge !!!
        If IAB(_F) < 4 Then Continue Do
        If MAJ(_G) = 0 Then Continue Do
        _F = _G : _BA = CDbl(KAH(_F))
        _AI = "*" : Continue Do : Else
        If MAJ(_G) = 0 Then Continue Do
        _AI = KAI(_F) & "`" & KAI(_G)
        _BB = CDbl(KAH(_G)) : End If
      ' Rechnungen
      Select Case _AI
        ' a + b = c
        Case "`+" : _AF = DFAA(_BA + _BB)
          DEWA({1171, 0, 6, 13, 6, 3, 3, 11})
        ' a - b = c
        Case "`-" : _AF = DFAA(_BA - _BB)
          DEWA({1171, 0, 6, 13, 6, 3, 3, 11})
        ' a + b + c = a + (b + c) = a + d
        Case "+`+" : _AF = DFAA(_BA + _BB)
          DEWA({1172, 0, 6, 14, 6, 4, 4, 11})
        ' a + b - c = a + (b - c) = a + d
        Case "+`-" : _AF = DFAA(_BA - _BB)
          DEWA({1172, 0, 6, 14, 6, 4, 4, 11})
        ' a - b + c = a - (b - c) = a - d
        Case "-`+" : _AF = DFAA(_BA - _BB)
          DEWA({1173, 0, 6, 14, 6, 4, 4, 11})
        ' a - b - c = a - (b + c) = a - d
        Case "-`-" : _AF = DFAA(_BA + _BB)
          DEWA({1173, 0, 6, 14, 6, 4, 4, 11})
        ' a · b = c
        Case "`·" : _AF = DFAA(_BA * _BB)
          DEWA({1174, 0, 6, 13, 6, 3, 3, 11})
        ' a : b = c
        Case "`:" : _AF = DFAA(_BA / _BB)
          DEWA({1174, 0, 6, 13, 6, 3, 3, 11})
        ' a · b · c = a · (b · c) = a · d
        Case "·`·" : _AF = DFAA(_BA * _BB)
          DEWA({1175, 0, 6, 14, 6, 4, 4, 11})
        ' a · b : c = a · (b : c) = a · d
        Case "·`:" : _AF = DFAA(_BA / _BB)
          DEWA({1175, 0, 6, 14, 6, 4, 4, 11})
        ' a : b · c = a : (b : c) = a : d
        Case ":`·" : _AF = DFAA(_BA / _BB)
          DEWA({1176, 0, 6, 14, 6, 4, 4, 11})
        ' a : b : c = a : (b · c) = a : d
        Case ":`:" : _AF = DFAA(_BA * _BB)
          DEWA({1176, 0, 6, 14, 6, 4, 4, 11})
        ' a ˄ b = c
        Case "`˄"
          _AF = DFAA(Math.Pow(_BA, _BB))
          DEWA({1177, 0, 6, 13, 6, 3, 3, 11})
        ' a ˅ b = c
        Case "`˅"
          _AF = DFAA(Math.Pow(_BA, 1 / _BB))
          DEWA({1177, 0, 6, 13, 6, 3, 3, 11})
      End Select
      ' Exit Sub
      If CAA <> KAH(0) Then Exit Sub
    Loop While _G < _L - 1

    Exit Sub

    ' Zwei Gleiche
    _F = -1 : Do : _F += 1 ' extrahierte Reihenfolge
      ' Bedingungen
      If DFAD(_F) <> "☼" Then : _AI = ""
        _G = MAE(_F) : H1(4) = MAI(_G) + MAH(_G) - 1
        If _F = H1(4) Or IAB(_G) < 4 Then Continue Do
        If IAB(_G) = 6 Then : _AI = DFAC(_G)
        Else : For j = _F + 1 To H1(4) Step 1
            If KAH(_F) = KAH(j) Then : _G = j
              _AI = KAI(_F) & "`" & KAI(j) : Exit For
            ElseIf DFAD(_F) = DFAD(j) Then : _AI =
                KAI(_F) & DFAC(_F) & KAI(j) & DFAC(j)
              _G = j : Exit For : End If : Next : End If
      Else : Continue Do : End If
      ' Rechnungen
      Select Case _AI : Case "" : Exit Select
        ' a - a = 0
        Case "`-" : DEWA({1141, 0, 8, 16, 2, 4, 1, 0})
        ' a - b + b = a + 0
        Case "-`+" : DEWA({1141, 0, 8, 16, 2, 4, 1, 0})
        ' a + b - b = a + 0
        Case "+`-" : DEWA({1141, 0, 8, 16, 2, 4, 1, 0})
        ' a : a = 1
        Case "`:" : DEWA({1141, 0, 8, 16, 2, 4, 1, 0})
        ' a · b : b = a · 1
        Case "·`:" : DEWA({1141, 0, 8, 16, 2, 4, 1, 0})
        ' a : b · b = a · 1
        Case ":`·" : DEWA({1141, 0, 8, 16, 2, 4, 1, 0})

        ' -a + a = 0
        Case "3-1" : DEWA({1141, 0, 8, 16, 2, 4, 1, 0})
        ' -a' + a' = 0
        Case "44-42" : DEWA({1141, 0, 8, 16, 2, 4, 1, 0})
        ' -a'. + a'. = 0
        Case "54-52" : DEWA({1141, 0, 8, 16, 2, 4, 1, 0})

        ' a : -a = -1
        Case "1:3" : DEWA({1141, 0, 8, 16, 2, 4, 1, 0})
        ' -a : a = -1
        Case "3:1" : DEWA({1141, 0, 8, 16, 2, 4, 1, 0})

        ' a · b : -b = a · -1
        Case "·1:3" : DEWA({1141, 0, 8, 16, 2, 4, 1, 0})
        ' a · -b : b = a · -1
        Case "·3:1" : DEWA({1141, 0, 8, 16, 2, 4, 1, 0})
        ' a : b · -b = a · -1
        Case ":1·3" : DEWA({1141, 0, 8, 16, 2, 4, 1, 0})
        ' a : -b · b = a · -1
        Case ":3·1" : DEWA({1141, 0, 8, 16, 2, 4, 1, 0})

        ' a' : -a' = -1
        Case "42:44" : DEWA({1141, 0, 8, 16, 2, 4, 1, 0})
        ' -a' : a' = -1
        Case "44:42" : DEWA({1141, 0, 8, 16, 2, 4, 1, 0})
        ' a · b' : -b' = a · -1
        Case "·42:44" : DEWA({1141, 0, 8, 16, 2, 4, 1, 0})
        ' a · -b' : b' = a · -1
        Case "·44:42" : DEWA({1141, 0, 8, 16, 2, 4, 1, 0})
        ' a : b' · -b' = a · -1
        Case ":42·44" : DEWA({1141, 0, 8, 16, 2, 4, 1, 0})
        ' a : -b' · b' = a · -1
        Case ":44·42" : DEWA({1141, 0, 8, 16, 2, 4, 1, 0})

        ' a'. : -a'. = -1
        Case "52:54" : DEWA({1141, 0, 8, 16, 2, 4, 1, 0})
        ' -a'. : a'. = -1
        Case "54:52" : DEWA({1141, 0, 8, 16, 2, 4, 1, 0})
        ' a · b'. : -b'. = a · -1
        Case "·52:54" : DEWA({1141, 0, 8, 16, 2, 4, 1, 0})
        ' a · -b'. : b'. = a · -1
        Case "·54:52" : DEWA({1141, 0, 8, 16, 2, 4, 1, 0})
        ' a : b'. · -b'. = a · -1
        Case ":52·54" : DEWA({1141, 0, 8, 16, 2, 4, 1, 0})
        ' a : -b'. · b'. = a · -1
        Case ":54·52" : DEWA({1141, 0, 8, 16, 2, 4, 1, 0})
        ' -a ˄ G = a ˄ G
        Case "24" : DEWA({1141, 0, 8, 16, 2, 4, 1, 0})
        ' -a ˄ G. = a ˄ G.
        Case "34" : DEWA({1141, 0, 8, 16, 2, 4, 1, 0})

      End Select
      ' Exit Sub
      If CAA <> KAH(0) Then Exit Sub


      If DFAC(_F) = 10 Then ' negativ mit geraden Exponent
        DCAA(MAC(_F), 1) : DDCE("-`a ^ b` = `a ^ b")
        DEBD("   b = 2 k, k ∈ ℕ") : Exit Sub : End If

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


      '      IAB < 5                       IAB = 5
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
      Select Case IAB(_F) ' Vorrang ab bezüglich ag
        Case 4
          _A = 0 : KAI(MAI(_F)) = "+" : _AD = "+" : _AE = "-"
        Case 5
          _A = 0 : KAI(MAI(_F)) = "·" : _AD = "·" : _AE = ":"
        Case 6
          _A = 1 : If MAH(_F) > 2 Then _AD = "˄" : _AE = "˅"
      End Select

      For j = MAI(_F) + _A To MAI(_F) + MAH(_F) - 2 Step 1
        ' AAA = DFAA(j)
        For k = MAI(_F) + _A + 1 To MAI(_F) + MAH(_F) - 1 Step 2
          ' BBB = DFAA(k)

          If KAH(j).CompareTo(KAH(k)) = 1 Then _A = 0

          'If MAB(j) < MAB(k) Or AAA < BBB Then _A = 0

          If KAH(j).Length < KAH(k).Length Then _A = 0

          If KAI(j) = _AE And KAI(k) = _AD Then _A = 0

          'b.CompareTo(a) = 1   ! b.CompareTo(a) = 0 !
        Next
      Next



      Continue Do
      ' 1. Operatorengruppen: Verallgemeinerung und Trennung
      Select Case IAB(_F) ' Vorrang ab bezüglich ag
        Case 4
          _A = 0 : KAI(MAI(_F)) = "+" : _AD = "+" : _AE = "-"
        Case 5
          _A = 0 : KAI(MAI(_F)) = "·" : _AD = "·" : _AE = ":"
        Case 6
          _A = 1 : If MAH(_F) > 2 Then _AD = "˄" : _AE = "˅"
      End Select
      ' 2. Operatorengruppe ist größer drei
      If _AD <> "" Then
        Dim av As New List(Of String) : MAO.Clear()
        ' 2.1. Minus: Vorzeichen => Operator
        If _AD = "+" Then : _B = DFAC(MAI(_F))
          If _B = 2 Or _B = 7 Then : KAI(MAI(_F)) = "-"
            KAH(MAI(_F)) = KAH(MAI(_F)).TrimStart("-")
            If _B = 2 Then IAA(MAI(_F)) = 0
            If _B = 7 Then IAA(MAI(_F)) = 1
          End If : End If : MAO.Add(MAI(_F) + _A)
        av.Add(KAI(MAI(_F) + _A)) : av.Add(KAH(MAI(_F) + _A))
        ' 2.2. Variablen- und Operatorenvergleich
        For j = MAI(_F) + _A + 1 To MAI(_F) + MAH(_F) - 1 Step 1
          For k = 0 To av.Count - 2 Step 2  ' ! a ^ c ^ b !
            If av(k + 1).CompareTo(KAH(j)) = 1 And
              (av(k) = _AD And KAI(j) = _AE) = False Then
              'b.CompareTo(a) = 1   ! b.CompareTo(a) = 0 !
              av.Insert(k, KAH(j)) : av.Insert(k, KAI(j))
              MAO.Insert(k / 2, j) : Exit For : End If
            If k = av.Count - 2 Then ' wenn kein ↑ Exit For
              MAO.Add(j) : av.Add(KAI(j))
              av.Add(KAH(j)) : Exit For : End If : Next : Next
        ' 2.3. Minus: Operator => Vorzeichen
        If av(0) = "-" Then : Select Case DFAC(MAO(0))
            Case 0 : IAA(MAO(0)) = 2 : av(1) = "-" & av(1)
              KAH(MAI(_F)) = "-" & KAH(MAI(_F))
            Case 5 : IAA(MAO(0)) = 3 : av(1) = "-" & av(1)
              KAH(MAI(_F)) = "-" & KAH(MAI(_F))
            Case 1, 3, 4, 6, 8, 10 : av(1) = "-(" & av(1) & ")"
          End Select : End If : _AD = av(1) : KAI(MAI(_F)) = ""
        ' 2.4. Variablen- und Operatorensammlung
        For j = 2 To av.Count - 1 Step 1 : _AD &= " " & av(j) : Next
        ' 2.5. Erste Extravariable der Operatorengruppe sechs
        If _A = 1 Then _AD = KAH(MAI(_F)) & " " & av(0) & " " & _AD
        ' 2.6. Übersprung beim gleichen Ergebnis
        If KAH(_F) = _AD Then Continue Do
        ' 2.7. Neuer Ausdruck - Ergebnis
        DCBA(_AD, {MAC(_F + _A), MAD(_F)}) : DDED("b` o `a` = `a` o `b")
        Exit Sub : End If
      ' Exit Sub
      If CAA <> KAH(0) Then Exit Sub

      'IAA()   Vorzeichen
      'IAB()   Operatorengruppe
      'KAH()   Term
      'KAI()   Operator
      'LAA()   Gesuchte im Nenner
      'MAB()   Funktion
      'MAC()   Eingangsanfang
      'MAD()   Eingangslänge
      'MAE()   Quellenteilindex
      'MAH()   Ausgangsteilenanzahl
      'MAI()   Ausgangsteilenanfangsindex
      'MAJ()   Eingangsteil-Zahl
      'MAM()   Gesuchte Variable

      'MAA()   Teilungsanfang
      'MAF()   Ausgangsanfang
      'MAG()   Ausgangslänge


    Loop While _F < _L - 1

  End Sub
#End Region ' *****
#Region "D-A_"
  Private Sub DBDA()
    '    If b = 22 Then
    '        'a : b ± c : d = (a · d ± c · b) : b : d
    '        KAG.Add("b = 22") : ac = "a : b ± c : d = (a · d ± c · b) : b : d"
    '        For aadaa = 0 To FEA.Count - 1 Step 1
    '            If IAB(aadaa) = 5 Then ' Extra wegen Geschwindigkeit
    '                If MAB(aadaa) = 0 And IAB(MAE(aadaa)) = 4 Then
    '                    If FEB(MAI(aadaa) + MAH(aadaa) - 1) = ":" Then
    '                        For aafaa = MAI(MAE(aadaa)) To MAI(MAE(aadaa)) + MAH(MAE(aadaa)) - 1 Step 1
    '                            If aadaa = aafaa Then Continue For
    '                            Dim aajaa As String
    '                            Dim aajab As String
    '                            Dim aajac As String
    '                            Dim aajad As Boolean : If MAB(aafaa) = 0 And IAB(aafaa) = 5 Then aajad = True
    '                            'a + b : c = (a · c + b) : c
    '                            If aajad = False Then
    '                                Dim aakaa As Integer ' a : c + b
    '                                Dim aakab As Integer
    '                                ab = aa : aajac = "+"
    '                                If aadaa < aafaa Then aakaa = aadaa : aakab = aafaa Else aakaa = aafaa : aakab = aadaa
    '                                ab = ab.Remove(MAC(aakab) - 3, MAD(aakab) + 3)
    '                                ab = ab.Remove(MAC(aakaa), MAD(aakaa))
    '                                aajaa = FEA(MAI(aadaa) + MAH(aadaa) - 1)
    '                                aajab = aa.Substring(MAC(aadaa), MAD(aadaa) - MAD(MAI(aadaa) + MAH(aadaa) - 1) - 3)
    '                                If FEB(aakaa) <> "-" Then aajac = FEB(aakab) ' a ± b : c = (a · c ± b) : c
    '                                If FEB(aakaa) = "-" And FEB(aakab) = "+" Then aajac = "-" ' a - b ± c : d = a - (b · d -+ c) : d
    '                                ab = ab.Insert(MAC(aakaa), "(" & FEA(aafaa) & " · " & aajaa & " " & aajac & " " & aajab & ") : " & aajaa)
    '                                AAEAAG(ab, ac) : If B_ = False Then ad += 1 : Continue Do Else Exit Sub
    '                            End If
    '                            'a : b ± c : d = (a · d ± c · b) : b : d
    '                            If aajad = True Then
    '                                If aadaa < aafaa And FEB(MAI(aafaa) + MAH(aafaa) - 1) = ":" Then
    '                                    Dim aalaa As String
    '                                    Dim aalab As String
    '                                    ab = aa : aajac = "+"
    '                                    ' a : b ± c : d = (a · d ± c · b) : b : d
    '                                    If FEB(aadaa) <> "-" Then aajac = FEB(aafaa)
    '                                    ' a - b : c ± d : f = a - (b · f -+ d · c) : (c · f)
    '                                    If FEB(aadaa) = "-" And FEB(aafaa) = "+" Then aajac = "-"
    '                                    aajaa = FEA(MAI(aadaa) + MAH(aadaa) - 1)
    '                                    aajab = aa.Substring(MAC(aadaa), MAD(aadaa) - MAD(MAI(aadaa) + MAH(aadaa) - 1) - 3)
    '                                    aalaa = FEA(MAI(aafaa) + MAH(aafaa) - 1)
    '                                    aalab = aa.Substring(MAC(aafaa), MAD(aafaa) - MAD(MAI(aafaa) + MAH(aafaa) - 1) - 3)
    '                                    ab = ab.Remove(MAC(aafaa) - 3, MAD(aafaa) + 3)
    '                                    ab = ab.Remove(MAC(aadaa), MAD(aadaa))
    '                                    ' a : b ± c : d = (a · d ± c · b) : b : d
    '                                    If aajaa <> aalaa Then ab = ab.Insert(MAC(aadaa), "(" & aajab & " · " & aalaa & " " & aajac & " " & aalab & " · " & aajaa & ") : " & aajaa & " : " & aalaa)
    '                                    ' a : b ± c : b = (a ± c) : b
    '                                    If aajaa = aalaa Then ab = ab.Insert(MAC(aadaa), "(" & aajab & " " & aajac & " " & aalab & ") : " & aajaa)
    '                                    AAEAAG(ab, ac) : If B_ = False Then ad += 1 : Continue Do Else Exit Sub
    '                                End If
    '                            End If
    '                        Next
    '                    End If
    '                End If
    '            End If
    '        Next
    '    End If

  End Sub
  Private Sub DBDB()
    ' a b + a c + a d = a (b + c + d)
    CAC = "a b + a c = a (b + c)" : A_ = False
    KAG.Add(_M.ToString() & ": " & CAC) : KAG.Add(CAA)
    For i = 0 To KAH.Count - 1 Step 1
      'Auswahl des Termes mit der Operatorengruppe 4 (±)
      If IAB(i) = 4 Then : Dim _A, _B, _C As String
        _C = CAA : _B = "" : _A = "" : MAO.Clear() : Me._A = 0
        'Die Schleife für die Auswahl der gleichen Terme
        For j = MAI(i) To MAI(i) + MAH(i) - 2 Step 1
          Select Case IAB(j)
            Case 0
              _A = KAH(j).TrimStart("-")
              'Von diesem Sub vorher eingefügte 1 wird vermieden
              If _A = "1" Then Continue For
              For k = j + 1 To MAI(i) + MAH(i) - 1 Step 1
                ' a ± a = a · (1 ± 1)
                If IAB(k) = 0 Then
                  If _A = KAH(k).TrimStart("-") Then
                    ' a ± a = a · (1 ± 1)
                    ' -a ± a = a · (-1 ± 1)
                    ' - a ± a = a · (-1 ± 1)
                    If _B = "" Then ' ganz erster Schritt
                      DEDB({j, k}) : _B = "(1"
                      If KAI(j) = "-" Xor IAA(j) = 2 Then _B = "(-1"
                    Else ' fortgeschrittene Bearbeitung
                      CAA = CAA.Remove(MAC(k) - 3 + Me._A, MAD(k) + 3)
                      DEBA(_C.Substring(Me._B, MAC(k) - Me._B - 3))
                      DEBB(_C.Substring(MAC(k) - 3, MAD(k) + 3))
                      Me._A -= (MAD(k) + 3)
                    End If
                    Me._B = MAC(k) + MAD(k)
                    _B &= " " & KAI(k) & " 1"
                  End If
                End If
                ' a ± a b = a (1 ± b)
                If IAB(k) = 5 Then
                  For m = MAI(k) To MAI(k) + MAH(k) - 1 Step 1
                    If _A = KAH(m).TrimStart("-") Then
                      ' a ± a b = a (1 ± b)
                      ' -a ± a b = a (1 ± b)
                      ' - a ± a b = a (1 ± b)
                      If _B = "" Then ' ganz erster Schritt
                        DEDB({j, k}) : _B = "(1"
                        If KAI(j) = "-" Xor IAA(j) = 2 Then _B = "(-1"
                      Else ' fortgeschrittene Bearbeitung
                        CAA = CAA.Remove(MAC(k) - 3 + Me._A, MAD(k) + 3)
                        DEBA(_C.Substring(Me._B, MAC(k) - Me._B - 3))
                        DEBB(_C.Substring(MAC(k) - 3, MAD(k) + 3))
                        Me._A -= (MAD(k) + 3)
                      End If
                      Me._B = MAC(k) + MAD(k)
                      _B &= " " & KAI(k) & " " & KAH(k).Remove(MAC(m) - MAC(k), MAD(m)).Insert(MAC(m) - MAC(k), "1")
                      Exit For ' zwei gleiche in einem Term für einen in anderem Term darf man nicht herausheben
                    End If
                  Next
                End If
              Next
            Case 5 : _A = KAH(j).TrimStart("-")
              'Von diesem Sub vorher eingefügte 1 wird vermieden
              For k = j + 1 To MAI(i) + MAH(i) - 1 Step 1
                ' a b + a = a · (b + 1)
                If IAB(k) = 0 Then
                  If _B = "" Then ' ganz erster Schritt
                    For l = MAI(j) To MAI(j) + MAH(j) - 1 Step 1
                      _A = KAH(l).TrimStart("-") : If _A = "1" Then Continue For
                      If _A = KAH(k).TrimStart("-") Then
                        _B = "1" : DEDB({j, k})
                        If KAI(j) = "-" Xor IAA(j) = 2 Then _B = "-1"
                        _B = "(" & KAH(j).Remove(MAC(l) - MAC(j), MAD(l)).Insert(MAC(l) - MAC(j), _B)
                        Me._B = MAC(k) + MAD(k) : _B &= " " & KAI(k) & " 1"
                        Exit For
                      End If
                    Next
                  ElseIf _A = KAH(k).TrimStart("-") Then ' fortgeschrittene Bearbeitung
                    CAA = CAA.Remove(MAC(k) - 3 + Me._A, MAD(k) + 3)
                    DEBA(_C.Substring(Me._B, MAC(k) - Me._B - 3))
                    DEBB(_C.Substring(MAC(k) - 3, MAD(k) + 3))
                    Me._A -= (MAD(k) + 3)
                    Me._B = MAC(k) + MAD(k) : _B &= " " & KAI(k) & " 1"
                  End If
                End If
                ' a b + a c = a (b + c)
                If IAB(k) = 5 Then
                  If _A = KAH(k).TrimStart("-") Then
                    If _B = "" Then ' ganz erster Schritt
                      Me._C = DFAC(j)
                      ' a ^ b · c + a ^ b · c = a ^ b · c · (1 + 1)
                      If Me._C = 2 Or Me._C = 7 Then
                        DEDB({j, k}) : _B = "(-1"
                      ElseIf KAH(j) = KAH(k) Then
                        DEDB({j, k}) : _B = "(1"
                        If KAI(j) = "-" Then _B = "(-1"
                      End If
                      Me._B = MAC(k) + MAD(k)
                      _B &= " " & KAI(k) & " 1"
                    Else ' fortgeschrittene Bearbeitung
                      CAA = CAA.Remove(MAC(k) - 3 + Me._A, MAD(k) + 3)
                      DEBA(_C.Substring(Me._B, MAC(k) - Me._B - 3))
                      DEBB(_C.Substring(MAC(k) - 3, MAD(k) + 3))
                      Me._A -= (MAD(j) + MAD(k) + 3)
                      Me._B = MAC(k) + MAD(k) : _B &= " " & KAI(k) & " 1"
                    End If
                  Else
                    For l = MAI(j) To MAI(j) + MAH(j) - 1 Step 1
                      For m = MAI(k) To MAI(k) + MAH(k) - 1 Step 1
                        If KAH(l).TrimStart("-") = KAH(m).TrimStart("-") Then
                          If _B = "" Then ' ganz erster Schritt
                            Me._C = DFAC(l)
                            ' a ^ b · c + a ^ b · c = a ^ b · c · (1 + 1)
                            If Me._C = 2 Or Me._C = 7 Then
                              DEDB({j, k}) : _B = "(-1"
                            ElseIf KAH(l) = KAH(m) Then
                              DEDB({j, k}) : _B = "(1"
                              If KAI(j) = "-" Then _B = "(-1"
                            End If
                            _B = "(" & KAH(j).Remove(MAC(l), MAD(l)).Insert(MAC(l), _B)
                          Else ' fortgeschrittene Bearbeitung
                            CAA = CAA.Remove(MAC(k) - 3 + Me._A, MAD(k) + 3)
                            DEBA(_C.Substring(Me._B, MAC(k) - Me._B - 3))
                            DEBB(_C.Substring(MAC(k) - 3, MAD(k) + 3))
                            Me._A -= (MAD(j) + MAD(k) + 3)
                          End If
                          Me._B = MAC(k) + MAD(k)
                          _B &= " " & KAI(k) & " " & KAH(k).Remove(MAC(m), MAD(m)).Insert(MAC(m), "1")
                        End If
                      Next
                    Next
                  End If
                End If
                ' a + a = a · (1 + 1)
                If IAB(k) = 6 Then
                  For l = MAI(j) To MAI(j) + MAH(j) - 1 Step 1
                    If KAH(l).TrimStart("-") = KAH(k).TrimStart("-") Then
                      If _B = "" Then : Me._C = DFAC(l) ' ganz erster Schritt
                        If Me._C = 7 Then : DEDB({j, k})
                          _B = "(" & KAH(j).Remove(MAC(l), MAD(l)).Insert(MAC(l), "-1")
                          Me._B = MAC(k) + MAD(k) : _B &= " " & KAI(k) & " 1"
                        ElseIf KAH(l) = KAH(k) Then : DEDB({j, k})
                          _B = "(" & KAH(j).Remove(MAC(l), MAD(l)).Insert(MAC(l), "1")
                          Me._B = MAC(k) + MAD(k) : _B &= " " & KAI(k) & " 1"
                        End If
                      Else ' fortgeschrittene Bearbeitung
                        CAA = CAA.Remove(MAC(k) - 3 + Me._A, MAD(k) + 3)
                        DEBA(_C.Substring(Me._B, MAC(k) - Me._B - 3))
                        DEBB(_C.Substring(MAC(k) - 3, MAD(k) + 3))
                        Me._A -= (MAD(j) + MAD(k) + 3)
                        Me._B = MAC(k) + MAD(k) : _B &= " " & KAI(k) & " 1"
                      End If
                    End If
                  Next
                End If
              Next
            Case 6 : _A = KAH(j).TrimStart("-")
              'Von diesem Sub vorher eingefügte 1 wird vermieden
              For k = j + 1 To MAI(i) + MAH(i) - 1 Step 1
                If IAB(k) = 5 Then
                  For m = MAI(k) To MAI(k) + MAH(k) - 1 Step 1
                    If KAH(j).TrimStart("-") = KAH(m).TrimStart("-") Then
                      If _B = "" Then : Me._C = DFAC(j) ' ganz erster Schritt
                        If Me._C = 7 Then : DEDB({j, k})
                          Me._B = MAC(k) + MAD(k) : _B = "(-1"
                          _B &= " " & KAI(k) & KAH(k).Remove(MAC(m), MAD(m)).Insert(MAC(m), "1")
                        ElseIf KAH(j) = KAH(m) Then : DEDB({j, k})
                          Me._B = MAC(k) + MAD(k) : _B = "(1"
                          '_B = " " & KAI(k) & KAH(k).Remove(MAC(m), MAD(m)).Insert(MAC(m), "1")
                        End If
                      Else ' fortgeschrittene Bearbeitung
                        CAA = CAA.Remove(MAC(k) - 3 + Me._A, MAD(k) + 3)
                        DEBA(_C.Substring(Me._B, MAC(k) - Me._B - 3))
                        DEBB(_C.Substring(MAC(k) - 3, MAD(k) + 3))
                        Me._A -= (MAD(j) + MAD(k) + 3)
                        Me._B = MAC(k) + MAD(k) : _B &= " " & KAI(k) & " 1"
                      End If
                    End If
                  Next
                End If
                If IAB(k) = 6 Then
                  If KAH(j).TrimStart("-") = KAH(k).TrimStart("-") Then
                    If _B = "" Then : Me._C = DFAC(j) ' ganz erster Schritt
                      If Me._C = 7 Then : DEDB({j, k})
                        Me._B = MAC(k) + MAD(k) : _B = "(-1"
                        _B &= " " & KAI(k) & " 1"
                      ElseIf KAH(j) = KAH(k) Then : DEDB({j, k})
                        Me._B = MAC(k) + MAD(k) : _B = "(1"
                        _B &= " " & KAI(k) & " 1"
                      End If
                    Else ' fortgeschrittene Bearbeitung
                      CAA = CAA.Remove(MAC(k) - 3 + Me._A, MAD(k) + 3)
                      DEBA(_C.Substring(Me._B, MAC(k) - Me._B - 3))
                      DEBB(_C.Substring(MAC(k) - 3, MAD(k) + 3))
                      Me._A -= (MAD(j) + MAD(k) + 3)
                      Me._B = MAC(k) + MAD(k) : _B &= " " & KAI(k) & " 1"
                    End If
                  End If

                End If
              Next
          End Select
          If _B <> "" Then : Exit For : End If : Next
        If _B <> "" And _A <> "1" Then
          _B = _A & " · " & _B & ")"
          CAA = CAA.Insert(MAC(i), _B)
          DEBC(vbCrLf & CAA.Substring(0, MAC(i))) : DEBB(_B)
          DEBC(CAA.Substring(MAC(i) + _B.Length, CAA.Length - MAC(i) - _B.Length))
          'a b + a c = a (b + c) ' BRB-GRGR
          DDEE("a b + `a `c` = `a `(`b + c`)")
        End If
      End If


      '_A = MAO(MAO.Count - 1) : _B = MAC(_A) + MAD(_A)
      '_C = _A : If IAB(MAE(_A)) = 5 Then _C = MAE(_A)
      '_A = MAC(_C) + MAD(_C) ' Windows => Blue ' ...)...
      'KAJ.Add(CAA.Substring(_B, _A - _B)) : KAJ.Add(")")
      'KAJ.Add(CAA.Substring(_A, CAA.Length - _A))
      'JAA.Add(Colors.Blue) : JAA.Add(Colors.Magenta)
      'JAA.Add(Colors.Blue) : CAA = CAA.Insert(_A, ")")


      ' !!! a - b + b - b = a + b * (-1 + 1 - 1) - für Klammer Setzen !!!

      'a · b ± a = a · (1 ± b)
      '-a · b ± a = a · (-b ± 1)
      '- a · b ± a = - a · (b ∓ 1)



      '± a ± a = ± 2 · a
      ' -a - a = -2 a
      'a ± a · b = a · (1 ± b)

      '- a b + a = - (1 - b) a
      '- a b - a = - (1 + b) a

      '-a b + a = (-b + 1) a
      '-a b - a = (-b - 1) a

      ' a b + a = (1 + b) a
      ' a b + a = (1 - b) a
      ' - a b + a c = - a (b - c)
      ' - a b - a c = - a (b + c)
      ' -a b + a c = a (c - b)
      ' -a b - a c = a (-b - c)
      ' a b + a c = a (b + c)
      ' a b - a c = a (b - c)

    Next

    '    If b = 23 Then
    '        'Kürzungsformeln sind erste als Erweiterungsformeln, weil nach Ausklammern der Ausdruck größer als 500 Zeichen werden kann
    '        'und es wird überhaupt nicht herausgehoben auch wenn einige Stellen vorher herausgehoben werden sollten.
    '        KAG.Add("b = 23") : ac = "a · b ± a · c = a · (b ± c)"
    '        Dim aaiaa As String
    '        Dim aajaa As String
    '        If aa.Length > 500 Then KAG.Add("Die Eingabe ist zu groß") : Exit Do
    '        For aadaa = 0 To FEA.Count - 1 Step 1
    '            If IAB(aadaa) = 4 Then
    '                ab = aa
    '                For aafaa = MAI(aadaa) To MAI(aadaa) + MAH(aadaa) - 2 Step 1
    '                    For aagaa = aafaa + 1 To MAI(aadaa) + MAH(aadaa) - 1 Step 1
    '                        'a + a = 2 · a
    '                        If FEA(aafaa) = FEA(aagaa) And FEB(aagaa) = "+" And FEA(aagaa) <> "0" And FEA(aagaa) <> "1" Then
    '                            ab = ab.Remove(MAC(aagaa) - 3, MAD(aagaa) + 3) : ab = ab.Remove(MAC(aafaa), MAD(aafaa))
    '                            ab = ab.Insert(MAC(aafaa), "2 · " & FEA(aafaa))
    '                            AAEAAG(ab, ac) : If B_ = False Then ad += 1 : Continue Do Else Exit Sub
    '                        End If
    '                        If FEA(aafaa).TrimStart("-") = FEA(aagaa) And IAA(aafaa) < 2 And FEA(aagaa) <> "0" And FEA(aagaa) <> "1" Then
    '                            ab = ab.Remove(MAC(aagaa) - 3, MAD(aagaa) + 3) : ab = ab.Remove(MAC(aafaa), MAD(aafaa))
    '                            ' ± a ± a = ± 2 · a
    '                            If FEB(aafaa) = FEB(aagaa) Then ab = ab.Insert(MAC(aafaa), "2 · " & FEA(aagaa))
    '                            If IAA(aafaa) = 1 And FEB(aagaa) = "-" Then
    '                                ab = ab.Insert(MAC(aafaa), "-2 · " & FEA(aagaa)) ' -a - a = -2 a
    '                            End If
    '                            AAEAAG(ab, ac) : If B_ = False Then ad += 1 : Continue Do Else Exit Sub
    '                        End If
    '                    Next
    '                Next
    '            End If
    '            If IAB(aadaa) = 5 Then ' Extra wegen Geschwindigkeit
    '                If MAB(aadaa) = 0 And IAB(MAE(aadaa)) = 4 Then
    '                    For aafaa = MAI(MAE(aadaa)) To MAI(MAE(aadaa)) + MAH(MAE(aadaa)) - 1 Step 1
    '                        If aadaa = aafaa Then Continue For
    '                        Dim aaeaa As Boolean : If MAB(aafaa) = 0 And IAB(aafaa) = 5 Then aaeaa = True
    '                        'a ± a · b = a · (1 ± b)
    '                        If aadaa > aafaa And aaeaa = False Then
    '                            ab = aa : aaiaa = FEA(aadaa)
    '                            For aagaa = MAI(aadaa) To MAI(aadaa) + MAH(aadaa) - 1 Step 1
    '                                'a ± a · b = a · (1 ± b)
    '                                If FEA(aafaa).TrimStart("-") = FEA(aagaa).TrimStart("-") And
    '                                FEA(aagaa) <> "0" And FEA(aagaa) <> "1" And FEB(aagaa) <> ":" Then
    '                                    ab = ab.Remove(MAC(aadaa) - 3, MAD(aadaa) + 3) : ab = ab.Remove(MAC(aafaa), MAD(aafaa))
    '                                    If aagaa = MAI(aadaa) Then
    '                                        If FEB(aagaa + 1) = "·" Then aaiaa = aaiaa.Remove(0, MAD(aagaa) + 3)
    '                                        If FEB(aagaa + 1) = ":" Then aaiaa = aaiaa.Remove(0, MAD(aagaa)) : aaiaa = aaiaa.Insert(0, "1")
    '                                    End If
    '                                    If aagaa > MAI(aadaa) Then aaiaa = aaiaa.Remove(MAC(aagaa) - MAF(aadaa) - 3, MAD(aagaa) + 3)
    '                                    If FEB(aafaa) = "-" And IAA(aafaa) = IAA(aagaa) Then ' - a + a b
    '                                        If FEB(aadaa) = "+" Then ab = ab.Insert(MAC(aafaa), "(1 - " & aaiaa & ") · " & FEA(aagaa)) ' - a + a b = - (1 - b) a
    '                                        If FEB(aadaa) = "-" Then ab = ab.Insert(MAC(aafaa), "(1 + " & aaiaa & ") · " & FEA(aagaa)) ' - a - a b = - (1 + b) a
    '                                    End If
    '                                    If IAA(aafaa) = 1 And IAA(aagaa) = 0 Then
    '                                        If FEB(aadaa) = "+" Then ab = ab.Insert(MAC(aafaa), "(-1 + " & aaiaa & ") · " & FEA(aagaa).TrimStart("-")) ' -a + a b = (-1 + b) a
    '                                        If FEB(aadaa) = "-" Then ab = ab.Insert(MAC(aafaa), "(-1 - " & aaiaa & ") · " & FEA(aagaa).TrimStart("-")) ' -a - a b = (-1 - b) a
    '                                    End If
    '                                    If FEB(aafaa) <> "-" And IAA(aafaa) = 0 And IAA(aagaa) = 0 Then
    '                                        If FEB(aadaa) = "+" Then ab = ab.Insert(MAC(aafaa), "(1 + " & aaiaa & ") · " & FEA(aagaa)) ' a + a b = (1 + b) a
    '                                        If FEB(aadaa) = "-" Then ab = ab.Insert(MAC(aafaa), "(1 - " & aaiaa & ") · " & FEA(aagaa)) ' a - a b = (1 - b) a
    '                                    End If
    '                                    AAEAAG(ab, ac) : If B_ = False Then ad += 1 : Continue Do Else Exit Sub
    '                                End If
    '                            Next
    '                        End If
    '                        'a · b + a = a · (b + 1)
    '                        If aadaa < aafaa And aaeaa = False Then
    '                            ab = aa : aaiaa = FEA(aadaa)
    '                            For aagaa = MAI(aadaa) To MAI(aadaa) + MAH(aadaa) - 1 Step 1
    '                                'a · b + a = a · (b + 1)
    '                                If FEA(aagaa).TrimStart("-") = FEA(aafaa).TrimStart("-") And
    '                                FEA(aafaa) <> "0" And FEA(aafaa) <> "1" And FEB(aagaa) <> ":" Then
    '                                    ab = ab.Remove(MAC(aafaa) - 3, MAD(aafaa) + 3) : ab = ab.Remove(MAC(aadaa), MAD(aadaa))
    '                                    If aagaa = MAI(aadaa) Then
    '                                        If FEB(aagaa + 1) = "·" Then aaiaa = aaiaa.Remove(0, MAD(aagaa) + 3)
    '                                        If FEB(aagaa + 1) = ":" Then aaiaa = aaiaa.Remove(0, MAD(aagaa)) : aaiaa = aaiaa.Insert(0, "1")
    '                                    End If
    '                                    If aagaa > MAI(aadaa) Then aaiaa = aaiaa.Remove(MAC(aagaa) - MAF(aadaa) - 3, MAD(aagaa) + 3)
    '                                    If FEB(aadaa) = "-" And IAA(aadaa) = IAA(aafaa) Then
    '                                        If FEB(aafaa) = "+" Then ab = ab.Insert(MAC(aadaa), "(" & aaiaa & " - 1) · " & FEA(aafaa)) ' - a b + a = - (1 - b) a
    '                                        If FEB(aafaa) = "-" Then ab = ab.Insert(MAC(aadaa), "(" & aaiaa & " + 1) · " & FEA(aafaa)) ' - a b - a = - (1 + b) a
    '                                    End If
    '                                    If IAA(aadaa) = 1 And IAA(aadaa) = 0 Then
    '                                        If FEB(aafaa) = "+" Then ab = ab.Insert(MAC(aadaa), "(-" & aaiaa & " + 1) · " & FEA(aafaa).TrimStart("-")) ' -a b + a = (-b + 1) a
    '                                        If FEB(aafaa) = "-" Then ab = ab.Insert(MAC(aadaa), "(-" & aaiaa & " - 1) · " & FEA(aafaa).TrimStart("-")) ' -a b - a = (-b - 1) a
    '                                    End If
    '                                    If FEB(aadaa) <> "-" And IAA(aadaa) = 0 And IAA(aadaa) = 0 Then
    '                                        If FEB(aafaa) = "+" Then ab = ab.Insert(MAC(aadaa), "(" & aaiaa & " + 1) · " & FEA(aafaa)) ' a b + a = (1 + b) a
    '                                        If FEB(aafaa) = "-" Then ab = ab.Insert(MAC(aadaa), "(" & aaiaa & " - 1) · " & FEA(aafaa)) ' a b + a = (1 - b) a
    '                                    End If
    '                                    AAEAAG(ab, ac) : If B_ = False Then ad += 1 : Continue Do Else Exit Sub
    '                                End If
    '                            Next
    '                        End If
    '                        'a · b + a · c = a · (b + c)
    '                        If aadaa < aafaa And aaeaa = True Then
    '                            ab = aa : aaiaa = FEA(aadaa) : aajaa = FEA(aafaa)
    '                            For aagaa = MAI(aadaa) To MAI(aadaa) + MAH(aadaa) - 1 Step 1
    '                                For aahaa = MAI(aafaa) To MAI(aafaa) + MAH(aafaa) - 1 Step 1
    '                                    If FEB(aagaa) <> ":" And FEB(aahaa) <> ":" Then
    '                                        ' a · b + a · c = a · (b + c)
    '                                        If FEA(aagaa).TrimStart("-") = FEA(aahaa).TrimStart("-") And FEA(aahaa) <> "0" And
    '                                        FEA(aahaa) <> "1" And FEB(aagaa) <> ":" And FEB(aahaa) <> ":" Then
    '                                            ab = ab.Remove(MAC(aafaa) - 3, MAD(aafaa) + 3) : ab = ab.Remove(MAC(aadaa), MAD(aadaa))
    '                                            If aagaa = MAI(aadaa) Then
    '                                                If FEB(aagaa + 1) = "·" Then aaiaa = aaiaa.Remove(0, MAD(aagaa) + 3)
    '                                                If FEB(aagaa + 1) = ":" Then aaiaa = aaiaa.Remove(0, MAD(aagaa)) : aaiaa = aaiaa.Insert(0, "1")
    '                                            End If
    '                                            If aagaa > MAI(aadaa) Then aaiaa = aaiaa.Remove(MAC(aagaa) - MAF(aadaa) - 3, MAD(aagaa) + 3)
    '                                            If aahaa = MAI(aafaa) Then
    '                                                If FEB(aahaa + 1) = "·" Then aajaa = aajaa.Remove(0, MAD(aahaa) + 3)
    '                                                If FEB(aahaa + 1) = ":" Then aajaa = aajaa.Remove(0, MAD(aahaa)) : aajaa = aajaa.Insert(0, "1")
    '                                            End If
    '                                            If aahaa > MAI(aafaa) Then aajaa = aajaa.Remove(MAC(aahaa) - MAF(aafaa) - 3, MAD(aahaa) + 3)
    '                                            If FEB(aadaa) = "-" And IAA(aadaa) = IAA(aafaa) Then ' - a b + a b
    '                                                If FEB(aafaa) = "+" Then ab = ab.Insert(MAC(aadaa), "(" & aaiaa & " - " & aajaa & ") · " & FEA(aahaa)) ' - a b + a c = - a (b - c)
    '                                                If FEB(aafaa) = "-" Then ab = ab.Insert(MAC(aadaa), "(" & aaiaa & " + " & aajaa & ") · " & FEA(aahaa)) ' - a b - a c = - a (b + c)
    '                                            End If
    '                                            If IAA(aadaa) = 1 And IAA(aafaa) = 0 Then ' -a b + a b
    '                                                If FEB(aafaa) = "+" Then ab = ab.Insert(MAC(aadaa), "(-" & aaiaa & " + " & aajaa & ") · " & FEA(aahaa)) ' -a b + a c = a (c - b)
    '                                                If FEB(aafaa) = "-" Then ab = ab.Insert(MAC(aadaa), "(-" & aaiaa & " - " & aajaa & ") · " & FEA(aahaa)) ' -a b - a c = a (-b - c)
    '                                            End If
    '                                            If FEB(aadaa) <> "-" And IAA(aadaa) = 0 And IAA(aafaa) = 0 Then ' -a b + a b
    '                                                If FEB(aafaa) = "+" Then ab = ab.Insert(MAC(aadaa), "(" & aaiaa & " + " & aajaa & ") · " & FEA(aahaa)) ' a b + a c = a (b + c)
    '                                                If FEB(aafaa) = "-" Then ab = ab.Insert(MAC(aadaa), "(" & aaiaa & " - " & aajaa & ") · " & FEA(aahaa)) ' a b - a c = a (b - c)
    '                                            End If
    '                                            AAEAAG(ab, ac) : If B_ = False Then ad += 1 : Continue Do Else Exit Sub
    '                                        End If
    '                                    End If
    '                                Next
    '                            Next
    '                        End If
    '                    Next
    '                End If
    '            End If
    '        Next
    '    End If


    'IAA()   Vorzeichen
    'IAB()   Operatorengruppe
    'KAH()   Term
    'KAI()   Operator
    'LAA()   Gesuchte im Nenner
    'MAB()   Funktion
    'MAC()   Eingangsanfang
    'MAD()   Eingangslänge
    'MAE()   Quellenteilindex
    'MAH()   Ausgangsteilenanzahl
    'MAI()   Ausgangsteilenanfangsindex
    'MAJ()   Eingangsteil-Zahl
    'MAM()   Gesuchte Variable

    'MAA()   Teilungsanfang
    'MAF()   Ausgangsanfang
    'MAG()   Ausgangslänge


  End Sub
  Private Sub DBDC()
    '    If b = 24 Then
    '        KAG.Add("b = 24") : ac = "(a ± b) ·: c = a ·: c ± b ·: c"
    '        For aadaa = 0 To FEA.Count - 1 Step 1
    '            If MAB(aadaa) = 1 Or MAB(aadaa) = 3 Then
    '                If IAB(aadaa) = 4 And IAB(MAE(aadaa)) = 5 And FEB(aadaa) <> ":" Then
    '                    Dim aaeaa As String
    '                    Dim aaeab As String = ""
    '                    Dim aaeac As String
    '                    Dim aaead As String
    '                    Dim aaeaf As Boolean
    '                    ab = aa
    '                    If MAB.Count > aadaa + 1 And aadaa < MAI(MAE(aadaa)) + MAH(MAE(aadaa)) - 1 Then
    '                        If MAB(aadaa + 1) = 1 Or MAB(aadaa + 1) = 3 Then
    '                            If IAB(aadaa + 1) = 4 Then aaeaf = True
    '                        End If
    '                    End If
    '                    For aaeag = MAI(aadaa) To MAI(aadaa) + MAH(aadaa) - 1 Step 1

    '                        aaeac = " + " : If FEB(aaeag) = "-" Then aaeac = " - "
    '                        If IAA(MAI(MAE(aadaa))) = 1 Or FEB(MAE(aadaa)) = "-" Then
    '                            If FEB(aaeag) = "0" Then aaeac = " - "
    '                            If FEB(aaeag) = "+" Then aaeac = " - "
    '                            If FEB(aaeag) = "-" Then aaeac = " + "
    '                        End If

    '                        aaeaa = aaeac
    '                        '(a + b) · (c + d) = a c + a d + b c + b d
    '                        If aaeaf = True Then
    '                            '(a ± b) · (c ± d)
    '                            '-(a ± b) · (c ± d)
    '                            If FEB(aadaa + 1) <> ":" Then
    '                                For aafab = MAI(aadaa + 1) To MAI(aadaa + 1) + MAH(aadaa + 1) - 1 Step 1
    '                                    aaeac = aaeaa
    '                                    If FEB(aafab) = "-" And aaeaa = " + " Then aaeac = " - "
    '                                    If FEB(aafab) = "-" And aaeaa = " - " Then aaeac = " + "
    '                                    aaeab &= aaeac & FEA(aaeag) & " · " & FEA(aafab)
    '                                Next
    '                            End If
    '                            '(a + b) : (c + d) = a : (c + d) + b : (c + d)
    '                            If FEB(aadaa + 1) = ":" Then
    '                                If aadaa < MAI(MAE(aadaa)) + MAH(MAE(aadaa)) - 1 Then aaeab &= aaeaa & FEA(aaeag) & aa.Substring(MAC(aadaa + 1) - 3, MAF(MAE(aadaa)) + MAG(MAE(aadaa)) - MAC(aadaa + 1) + 3)
    '                            End If
    '                        End If
    '                        '(a + b) · c = a c + b c
    '                        If aaeaf = False Then
    '                            '(a ± b) ·: c   -(a ± b) ·: c
    '                            If aadaa = MAI(MAE(aadaa)) Then
    '                                aaead = aa.Substring(MAC(aadaa + 1) - 3, MAF(MAE(aadaa)) + MAG(MAE(aadaa)) - MAC(aadaa + 1) + 3)
    '                                aaeab &= aaeaa & FEA(aaeag) & aaead
    '                            End If
    '                            'a · (b ± c)   -a · (b ± c)
    '                            If aadaa = MAI(MAE(aadaa)) + MAH(MAE(aadaa)) - 1 Then
    '                                aaead = aa.Substring(MAF(MAE(aadaa)), MAC(aadaa) - MAF(MAE(aadaa)))
    '                                If IAA(MAI(MAE(aadaa))) = 1 And aaeag > MAI(aadaa) Then aaead = aaead.TrimStart("-")
    '                                aaeab &= aaeaa & aaead & FEA(aaeag)
    '                            End If
    '                            'a · (b ± c) ·: d   -a · (b ± c) ·: d
    '                            If aadaa > MAI(MAE(aadaa)) And aadaa < MAI(MAE(aadaa)) + MAH(MAE(aadaa)) - 1 Then
    '                                aaead = aa.Substring(MAF(MAE(aadaa)), MAC(aadaa) - MAF(MAE(aadaa)))
    '                                If IAA(MAI(MAE(aadaa))) = 1 And aaeag > MAI(aadaa) Then aaead = aaead.TrimStart("-")
    '                                aaeab &= aaeaa & aaead & FEA(aaeag) &
    '                                aa.Substring(MAC(aadaa + 1) - 3, MAF(MAE(aadaa)) + MAG(MAE(aadaa)) - MAC(aadaa + 1) + 3)
    '                            End If
    '                        End If
    '                    Next
    '                    aaeab = aaeab.Remove(0, 3)
    '                    If IAA(MAI(MAE(aadaa))) = 1 Then aaeab = "-" & aaeab
    '                    If aaeaf = True Then
    '                        If FEB(aadaa + 1) <> ":" Then
    '                            If KAF(KAF.Count - 1) <> "(a ± b) ·: c = a ·: c ± b ·: c" Then ac = "(a + b) · (c + d) = a · c + a · d + b · c + b · d"
    '                            If MAH(MAE(aadaa)) > 2 Then aaeab = "(" & aaeab & ")"
    '                            ab = ab.Remove(MAC(aadaa), MAD(aadaa) + MAD(aadaa + 1) + 3)
    '                            ab = ab.Insert(MAC(aadaa), aaeab) ' : aaeaa = "(a + b) (c + d) = a c + a d + b c + b d"
    '                        End If
    '                        If FEB(aadaa + 1) = ":" Then
    '                            ab = ab.Remove(MAF(MAE(aadaa)), MAG(MAE(aadaa)))
    '                            ab = ab.Insert(MAF(MAE(aadaa)), aaeab) ' : aaeaa = "(a + b) : (c + d) = a : (c + d) + b : (c + d)"
    '                        End If
    '                    End If
    '                    If aaeaf = False Then
    '                        ab = ab.Remove(MAF(MAE(aadaa)), MAG(MAE(aadaa)))
    '                        ab = ab.Insert(MAF(MAE(aadaa)), aaeab) ' : aaeaa = "(a + b) · c = a c + b c"
    '                    End If
    '                    'E2.Text = ab & vbCrLf : Exit Sub
    '                    AAEAAG(ab, ac) : If B_ = False Then ad += 1 : Continue Do Else Exit Sub
    '                End If
    '            End If
    '        Next
    '    End If

  End Sub
  Private Sub DBAU()
    '    If b = 25 Then
    '        'Kürzungsformeln sind erste als Erweiterungsformeln, weil nach Ausklammern der Ausdruck größer als 500 Zeichen werden kann
    '        'und es wird überhaupt nicht herausgehoben auch wenn einige Stellen vorher herausgehoben werden sollten.
    '        'a ^ b ·: a ^ c = a ^ (b ± c)
    '        KAG.Add("b = 25") : ac = "a ^ b ·: a ^ c = a ^ (b ± c)"
    '        Dim aaiaa As String
    '        Dim aajaa As String
    '        If aa.Length > 500 Then KAG.Add("Die Eingabe ist zu groß") : Exit Do
    '        For aadaa = 0 To FEA.Count - 1 Step 1
    '            If IAB(aadaa) = 5 Then
    '                ab = aa
    '                For aafaa = MAI(aadaa) To MAI(aadaa) + MAH(aadaa) - 2 Step 1
    '                    For aagaa = aafaa + 1 To MAI(aadaa) + MAH(aadaa) - 1 Step 1
    '                        If FEA(aafaa).TrimStart("-") = FEA(aagaa).TrimStart("-") And FEA(aagaa) <> "0" And FEA(aagaa) <> "1" Then
    '                            ab = ab.Remove(MAC(aagaa) - 3, MAD(aagaa) + 3) : ab = ab.Remove(MAC(aafaa), MAD(aafaa))
    '                            If FEB(aafaa) = ":" Then
    '                                If FEB(aagaa) = ":" Then
    '                                    If IAA(aafaa) = IAA(aagaa) Then ab = ab.Insert(MAC(aafaa), FEA(aagaa) & " ^ 2") ' a : b : b = b ^ 2
    '                                    'If IAA(aafaa) = 0 And IAA(aagaa) = 1 Then ab = ab.Insert(MAC(aafaa), "-(" & FEA(aagaa) & " ^ 2)") ' a : b : -b = -(b ^ 2)
    '                                    'If IAA(aafaa) = 1 And IAA(aagaa) = 0 Then ab = ab.Insert(MAC(aafaa), "-(" & FEA(aagaa) & " ^ 2)") ' a : -b : b = -(b ^ 2)
    '                                End If
    '                            Else
    '                                If FEB(aagaa) = "·" Then
    '                                    If IAA(aafaa) = IAA(aagaa) Then ab = ab.Insert(MAC(aafaa), FEA(aagaa) & " ^ 2") ' a · a = a ^ 2
    '                                    If IAA(aafaa) = 0 And IAA(aagaa) = 1 Then ab = ab.Insert(MAC(aafaa), "-(" & FEA(aagaa) & " ^ 2)") ' a · -a = -(a ^ 2)
    '                                    If IAA(aafaa) = 1 And IAA(aagaa) = 0 Then ab = ab.Insert(MAC(aafaa), "-(" & FEA(aagaa) & " ^ 2)") ' -a · a = -(a ^ 2)
    '                                End If
    '                            End If
    '                            AAEAAG(ab, ac) : If B_ = False Then ad += 1 : Continue Do Else Exit Sub
    '                        End If
    '                    Next
    '                Next
    '            End If
    '            If IAB(aadaa) = 6 Then ' Extra wegen Geschwindigkeit
    '                If MAB(aadaa) = 0 And IAB(MAE(aadaa)) = 5 Then
    '                    For aafaa = MAI(MAE(aadaa)) To MAI(MAE(aadaa)) + MAH(MAE(aadaa)) - 1 Step 1
    '                        If aadaa = aafaa Then Continue For
    '                        Dim aaeaa As Boolean : If MAB(aafaa) = 0 And IAB(aafaa) = 6 Then aaeaa = True
    '                        'a ·: a ^ b = a ^ (1 ± b)
    '                        If aadaa > aafaa And MAH(aadaa) = 2 And aaeaa = False Then
    '                            ab = aa
    '                            'a ·: a ^ b = a ^ (1 ± b)
    '                            If FEA(aafaa) = FEA(MAI(aadaa)) Then
    '                                ab = ab.Remove(MAC(aadaa) - 3, MAD(aadaa) + 3)
    '                                ab = ab.Remove(MAC(aafaa), MAD(aafaa))
    '                                aaiaa = FEA(MAI(aadaa) + 1)
    '                                If FEB(aafaa) = ":" Then ' : a · a ^ b
    '                                    If FEB(aadaa) = "·" Then ab = ab.Insert(MAC(aafaa), FEA(aafaa) & " ^ (1 - " & aaiaa & ")") 'a : b · b ^ c = a : b ^ (1 - c)
    '                                    If FEB(aadaa) = ":" Then ab = ab.Insert(MAC(aafaa), FEA(aafaa) & " ^ (1 + " & aaiaa & ")")  'a : b : b ^ c = a : b ^ (1 + c)
    '                                Else
    '                                    If FEB(aadaa) = "·" Then ab = ab.Insert(MAC(aafaa), FEA(aafaa) & " ^ (1 + " & aaiaa & ")") 'a · b · b ^ c = a · b ^ (1 + c)
    '                                    If FEB(aadaa) = ":" Then ab = ab.Insert(MAC(aafaa), FEA(aafaa) & " ^ (1 - " & aaiaa & ")")  'a · b : b ^ c = a · b ^ (1 - c)
    '                                End If
    '                                AAEAAG(ab, ac) : If B_ = False Then ad += 1 : Continue Do Else Exit Sub
    '                            End If
    '                        End If
    '                        'a ^ b ·: a = a ^ (b ± 1)
    '                        If aadaa < aafaa And MAH(aadaa) = 2 And aaeaa = False Then
    '                            ab = aa
    '                            'a ^ b ·: a = a ^ (b ± 1)
    '                            If FEA(aafaa) = FEA(MAI(aadaa)) Then
    '                                ab = ab.Remove(MAC(aafaa) - 3, MAD(aafaa) + 3)
    '                                ab = ab.Remove(MAC(aadaa), MAD(aadaa))
    '                                aaiaa = FEA(MAI(aadaa) + 1)
    '                                If FEB(aadaa) = ":" Then ' : a ^ b · a
    '                                    If FEB(aafaa) = "·" Then ab = ab.Insert(MAC(aadaa), FEA(aafaa) & " ^ (" & aaiaa & " - 1)") 'a : b ^ c · b = a : b ^ (c - 1)
    '                                    If FEB(aafaa) = ":" Then ab = ab.Insert(MAC(aadaa), FEA(aafaa) & " ^ (" & aaiaa & " + 1)")  'a : b : b ^ c = a : b ^ (c + 1)
    '                                Else
    '                                    If FEB(aafaa) = "·" Then ab = ab.Insert(MAC(aadaa), FEA(aafaa) & " ^ (" & aaiaa & " + 1)") 'a · b · b ^ c = a · b ^ (c + 1)
    '                                    If FEB(aafaa) = ":" Then ab = ab.Insert(MAC(aadaa), FEA(aafaa) & " ^ (" & aaiaa & " - 1)")  'a · b : b ^ c = a · b ^ (c - 1)
    '                                End If
    '                                AAEAAG(ab, ac) : If B_ = False Then ad += 1 : Continue Do Else Exit Sub
    '                            End If
    '                        End If
    '                        'a ^ b ·: a ^ c = a ^ (b ± c)
    '                        If aadaa < aafaa And MAH(aadaa) = 2 And MAH(aafaa) = 2 And aaeaa = True Then
    '                            ab = aa
    '                            'a ^ b ·: a ^ c = a ^ (b ± c)
    '                            If FEA(MAI(aadaa)) = FEA(MAI(aafaa)) Then
    '                                aaiaa = FEA(MAI(aadaa) + 1)
    '                                aajaa = FEA(MAI(aafaa) + 1)
    '                                ab = ab.Remove(MAC(aafaa) - 3, MAD(aafaa) + 3)
    '                                ab = ab.Remove(MAC(aadaa), MAD(aadaa))
    '                                If FEB(aadaa) = ":" Then ' : a ^ b · a ^ c
    '                                    If FEB(aafaa) = "·" Then ab = ab.Insert(MAC(aadaa), FEA(MAI(aadaa)) & " ^ (" & aaiaa & " - " & aajaa & ")") 'a : b ^ c · b ^ d = a : b ^ (c - d)
    '                                    If FEB(aafaa) = ":" Then ab = ab.Insert(MAC(aadaa), FEA(MAI(aadaa)) & " ^ (" & aaiaa & " + " & aajaa & ")")  'a : b ^ c : b ^ d = a : b ^ (c + d)
    '                                Else
    '                                    If FEB(aafaa) = "·" Then ab = ab.Insert(MAC(aadaa), FEA(MAI(aadaa)) & " ^ (" & aaiaa & " + " & aajaa & ")") 'a · b ^ c · b ^ d = a · b ^ (c + d)
    '                                    If FEB(aafaa) = ":" Then ab = ab.Insert(MAC(aadaa), FEA(MAI(aadaa)) & " ^ (" & aaiaa & " - " & aajaa & ")")  'a · b ^ c : b ^ d = a · b ^ (c - d)
    '                                End If
    '                                AAEAAG(ab, ac) : If B_ = False Then ad += 1 : Continue Do Else Exit Sub
    '                            End If
    '                        End If
    '                    Next
    '                End If
    '            End If
    '        Next
    '    End If

  End Sub
  Private Sub DBAV()
    '    If b = 26 Then
    '        'a ^ (b ± c) = a ^ b ·: a ^ c
    '        KAG.Add("b = 26") : ac = "a ^ (b ± c) = a ^ b ·: a ^ c"
    '        For aadaa = 0 To FEA.Count - 1 Step 1
    '            If FEB(aadaa) = "^" And MAB(aadaa) = 1 And IAB(aadaa) = 4 Then
    '                ab = aa
    '                'a ^ (b ± c) = a ^ b ·: a ^ c
    '                If MAH(MAE(aadaa)) = 2 Then ab = ab.Remove(MAC(aadaa) + MAD(aadaa) - 1, 1)
    '                For aaeag = MAI(aadaa) + MAH(aadaa) - 1 To MAI(aadaa) + 1 Step -1
    '                    ab = ab.Insert(MAC(aaeag), FEA(aadaa - 1) & " ^ ")
    '                    ab = ab.Remove(MAC(aaeag) - 2, 1)
    '                    If FEB(MAE(aadaa)) = ":" Then
    '                        If FEB(aaeag) = "+" Then ab = ab.Insert(MAC(aaeag) - 2, ":")
    '                        If FEB(aaeag) = "-" Then ab = ab.Insert(MAC(aaeag) - 2, "·")
    '                    Else
    '                        If FEB(aaeag) = "+" Then ab = ab.Insert(MAC(aaeag) - 2, "·")
    '                        If FEB(aaeag) = "-" Then ab = ab.Insert(MAC(aaeag) - 2, ":")
    '                    End If
    '                Next
    '                ab = ab.Remove(MAC(aadaa), 1)
    '                If MAH(MAE(aadaa)) > 2 Then ab = ab.Insert(MAC(MAE(aadaa)), "(")
    '                AAEAAG(ab, ac) : If B_ = False Then ad += 1 : Continue Do Else Exit Sub
    '            End If
    '        Next
    '    End If

  End Sub
  Private Sub DBAW()
    '    If b = 27 Then
    '        'a ^ c ·: b ^ c = (a ·: b) ^ c
    '        KAG.Add("b = 27") : ac = "a ^ c ·: b ^ c = (a ·: b) ^ c"
    '        'Kürzungsformeln sind erste als Erweiterungsformeln, weil nach Ausklammern der Ausdruck größer als 500 Zeichen werden kann
    '        'und es wird überhaupt nicht herausgehoben auch wenn einige Stellen vorher herausgehoben werden sollten.
    '        If aa.Length > 500 Then KAG.Add("Die Eingabe ist zu groß") : Exit Do
    '        For aadaa = 0 To FEA.Count - 1 Step 1
    '            If IAB(aadaa) = 6 Then ' Extra wegen Geschwindigkeit
    '                If MAB(aadaa) = 0 And IAB(MAE(aadaa)) = 5 Then
    '                    For aafaa = aadaa To MAI(MAE(aadaa)) + MAH(MAE(aadaa)) - 1 Step 1
    '                        If aadaa = aafaa Then Continue For
    '                        'a ^ c ·: b ^ c = (a ·: b) ^ c
    '                        If MAB(aafaa) = 0 And IAB(aafaa) = 6 Then
    '                            ab = aa
    '                            Dim aahaa As Integer : Dim aahab As String = "" : Dim aahac As String : Dim aahad As String
    '                            If MAH(aadaa) < MAH(aafaa) Then aahaa = MAH(aadaa) - 1
    '                            If MAH(aafaa) <= MAH(aadaa) Then aahaa = MAH(aafaa) - 1
    '                            For aahae = 1 To aahaa Step 1
    '                                If FEA(MAI(aadaa) + MAH(aadaa) - aahae) = FEA(MAI(aafaa) + MAH(aafaa) - aahae) Then
    '                                    aahab = " " & FEB(MAI(aadaa) + MAH(aadaa) - aahae) & " " & FEA(MAI(aadaa) + MAH(aadaa) - aahae) & aahab
    '                                End If
    '                            Next
    '                            If aahab <> "" Then
    '                                ab = ab.Remove(MAC(aafaa) - 3, MAD(aafaa) + 3)
    '                                ab = ab.Remove(MAC(aadaa), MAD(aadaa))
    '                                aahac = FEA(aadaa).Substring(0, MAD(aadaa) - aahab.Length)
    '                                aahad = FEA(aafaa).Substring(0, MAD(aafaa) - aahab.Length)
    '                                If FEB(aadaa) = ":" Then
    '                                    If FEB(aafaa) = "·" Then ab = ab.Insert(MAC(aadaa), "(" & aahac & " : " & aahad & ")" & aahab) 'a : b ^ d · c ^ d = a : (b : c) ^ d
    '                                    If FEB(aafaa) = ":" Then ab = ab.Insert(MAC(aadaa), "(" & aahac & " · " & aahad & ")" & aahab)  'a : b ^ d : c ^ d = a : (b · c) ^ d
    '                                Else
    '                                    If FEB(aafaa) = "·" Then ab = ab.Insert(MAC(aadaa), "(" & aahac & " · " & aahad & ")" & aahab) 'a · b ^ d · c ^ d = a · (b · c) ^ d
    '                                    If FEB(aafaa) = ":" Then ab = ab.Insert(MAC(aadaa), "(" & aahac & " : " & aahad & ")" & aahab)  'a · b ^ d : c ^ d = a · (b : c) ^ d
    '                                End If
    '                                AAEAAG(ab, ac) : If B_ = False Then ad += 1 : Continue Do Else Exit Sub
    '                            End If
    '                        End If
    '                    Next
    '                End If
    '            End If
    '        Next
    '    End If

  End Sub
  Private Sub DBAX()
    '    If b = 28 Then
    '        '(a ·: b) ^ c = a ^ c ·: b ^ c
    '        KAG.Add("b = 28") : ac = "(a ·: b) ^ c = a ^ c ·: b ^ c"
    '        For aadaa = 0 To FEA.Count - 1 Step 1
    '            If FEB(aadaa) = "^" Then
    '                If MAB(aadaa - 1) = 1 And IAB(aadaa - 1) = 5 Then
    '                    ab = aa
    '                    Dim aaeaa As String
    '                    aaeaa = ab.Substring(MAC(aadaa) - 3, MAF(MAE(aadaa)) + MAG(MAE(aadaa)) - MAC(aadaa) + 3)
    '                    If aadaa > MAI(MAE(aadaa)) + 1 Then ab = ab.Insert(MAC(MAE(aadaa)) + MAD(MAE(aadaa)), ")")
    '                    ab = ab.Remove(MAC(aadaa) - 4, 1)
    '                    For aaeag = MAI(aadaa - 1) + MAH(aadaa - 1) - 2 To MAI(aadaa - 1) Step -1
    '                        If FEB(MAE(aadaa)) = ":" Then
    '                            ab = ab.Remove(MAC(aaeag + 1) - 2, 1)
    '                            If FEB(aaeag + 1) = "·" Then ab = ab.Insert(MAC(aaeag + 1) - 2, ":")
    '                            If FEB(aaeag + 1) = ":" Then ab = ab.Insert(MAC(aaeag + 1) - 2, "·")
    '                        End If
    '                        ab = ab.Insert(MAC(aaeag + 1) - 3, aaeaa)
    '                    Next
    '                    If aadaa = MAI(MAE(aadaa)) + 1 Then ab = ab.Remove(MAC(aadaa - 1), 1)
    '                    'a : (b · c) ^ d ^ g
    '                    AAEAAG(ab, ac) : If B_ = False Then ad += 1 : Continue Do Else Exit Sub
    '                End If
    '            End If
    '        Next
    '    End If

  End Sub
  Private Sub DBAY()
    '    If b = 29 Then
    '        'a ^ -b = 1 : a ^ b
    '        KAG.Add("b = 29") : ac = "a ^ -b = 1 : a ^ b"
    '        For aadaa = 0 To FEA.Count - 1 Step 1
    '            If IAB(aadaa) = 6 Then
    '                If IAA(MAI(aadaa) + 1) = 1 Then
    '                    ab = aa
    '                    ab = ab.Remove(MAC(MAI(aadaa) + 1), 1)
    '                    'a : b ^ -c = a · b ^ c
    '                    If FEB(aadaa) = ":" Then
    '                        ab = ab.Remove(MAC(aadaa) - 2, 1)
    '                        ab = ab.Insert(MAC(aadaa) - 2, "·")
    '                    End If
    '                    'a · b ^ -c = a : b ^ c
    '                    If FEB(aadaa) = "·" Then
    '                        ab = ab.Remove(MAC(aadaa) - 2, 1)
    '                        ab = ab.Insert(MAC(aadaa) - 2, ":")
    '                    End If
    '                    'a ^ -b = 1 : b ^ c
    '                    If FEB(aadaa) <> "·" And FEB(aadaa) <> ":" Then
    '                        ab = ab.Insert(MAC(aadaa), "1 : ")
    '                    End If
    '                    AAEAAG(ab, ac) : If B_ = False Then ad += 1 : Continue Do Else Exit Sub
    '                End If
    '            End If
    '        Next
    '    End If

  End Sub
  Private Sub DBAZ()
    '    If b = 30 Then
    '        'a ^ b = 1 : a ^ -b
    '        KAG.Add("b = 30") : ac = "a ^ b = 1 : a ^ -b"
    '        For aadaa = 0 To FEA.Count - 1 Step 1
    '            If IAB(aadaa) = 6 Then
    '                If IAA(MAI(aadaa) + 1) = 0 Then
    '                    ab = aa
    '                    ab = ab.Insert(MAC(MAI(aadaa) + 1), "-")
    '                    'a ^ (-b · c) = 1 : a ^ (b · c)
    '                    If IAB(MAI(aadaa) + 1) = 5 Then
    '                        If IAA(MAI(MAI(aadaa) + 1)) = 1 Then
    '                            ab = ab.Remove(MAC(MAI(aadaa) + 1), 1)
    '                            ab = ab.Remove(MAF(MAI(aadaa) + 1), 1)
    '                        End If
    '                    End If
    '                    'a : b ^ c = a · b ^ -c
    '                    If FEB(aadaa) = ":" Then
    '                        ab = ab.Remove(MAC(aadaa) - 2, 1)
    '                        ab = ab.Insert(MAC(aadaa) - 2, "·")
    '                    End If
    '                    'a · b ^ c = a : b ^ -c
    '                    If FEB(aadaa) = "·" Then
    '                        ab = ab.Remove(MAC(aadaa) - 2, 1)
    '                        ab = ab.Insert(MAC(aadaa) - 2, ":")
    '                    End If
    '                    'a ^ b = 1 : a ^ -b
    '                    If FEB(aadaa) <> "·" And FEB(aadaa) <> ":" Then
    '                        ab = ab.Insert(MAC(aadaa), "1 : ")
    '                    End If
    '                    AAEAAG(ab, ac) : If B_ = False Then ad += 1 : Continue Do Else Exit Sub
    '                End If
    '            End If
    '        Next
    '    End If

  End Sub
  Private Sub DBBA()
    '    If b = 31 Then
    '        KAG.Add("b = 31") : ac = "a ^ b ^ c = a ^ (b · c)"
    '        For aadaa = 0 To FEA.Count - 1 Step 1
    '            If MAB(aadaa) = 0 And IAB(aadaa) = 6 And MAH(aadaa) > 2 Then
    '                'a ^ b ^ c = a ^ (b · c)
    '                ab = aa
    '                Dim aafaa As Boolean
    '                If IAB(MAE(aadaa)) = 1 Then
    '                    If MAB(MAE(aadaa)) = 5 Or MAB(MAE(aadaa)) = 14 Then aafaa = True
    '                End If
    '                For aafab = MAI(aadaa) + MAH(aadaa) - 1 To MAI(aadaa) + 2 Step -1
    '                    ab = ab.Remove(MAC(aafab) - 2, 1)
    '                    ab = ab.Insert(MAC(aafab) - 2, "·")
    '                Next
    '                If aafaa = False Then
    '                    ab = ab.Insert(MAC(aadaa) + MAD(aadaa), ")")
    '                    ab = ab.Insert(MAC(MAI(aadaa) + 1), "(")
    '                End If
    '                If aafaa = True Then
    '                    For aagaa = MAI(aadaa + 1) + MAH(aadaa + 1) - 1 To MAI(aadaa + 1) + 1 Step -1
    '                        If FEB(aagaa) = "·" Then
    '                            ab = ab.Remove(MAC(aagaa) - 2, 1)
    '                            ab = ab.Insert(MAC(aagaa) - 2, ":")
    '                        End If
    '                        If FEB(aagaa) = ":" Then
    '                            ab = ab.Remove(MAC(aagaa) - 2, 1)
    '                            ab = ab.Insert(MAC(aagaa) - 2, "·")
    '                        End If
    '                    Next
    '                    ab = ab.Remove(MAC(aadaa + 1) - 2, 1) : ab = ab.Insert(MAC(aadaa + 1) - 2, ":")
    '                    ab = ab.Insert(MAC(MAI(aadaa) + 1), "(")
    '                    If MAB(MAE(aadaa)) = 5 Then ab = ab.Remove(MAC(MAE(aadaa)), 2)
    '                    If MAB(MAE(aadaa)) = 14 Then
    '                        ab = ab.Insert(MAC(MAE(aadaa)) + MAD(MAE(aadaa)), ")")
    '                        ab = ab.Remove(MAC(MAE(aadaa)) + 1, 1)
    '                    End If
    '                End If
    '                AAEAAG(ab, ac) : If B_ = False Then ad += 1 : Continue Do Else Exit Sub
    '            End If
    '        Next
    '    End If

  End Sub
  Private Sub DBBB()
    '    If b = 32 Then
    '        KAG.Add("b = 32") : ac = "a ˄ (b ·: c) = a ˄ b ˄˅ c"
    '        For aadaa = 0 To FEA.Count - 1 Step 1
    '            If IAB(aadaa) = 5 And IAA(aadaa) = 0 And FEB(aadaa) = "^" Then
    '                'a ^ (b · c) = a ^ b ^ c
    '                ab = aa
    '                Dim aafaa As Boolean
    '                For aafab = MAI(aadaa) + MAH(aadaa) - 1 To MAI(aadaa) + 1 Step -1
    '                    If FEB(aafab) = "·" Then
    '                        ab = ab.Remove(MAC(aafab) - 2, 1)
    '                        ab = ab.Insert(MAC(aafab) - 2, "^")
    '                    End If
    '                    If FEB(aafab) = ":" Then
    '                        aafaa = True
    '                        ab = ab.Remove(MAC(aafab) - 2, 1)
    '                        If FEB(aafab - 1) = ":" Then
    '                            ab = ab.Insert(MAC(aafab) - 2, "·")
    '                        Else
    '                            ab = ab.Insert(MAC(aafab) - 2, "'")
    '                        End If
    '                    End If
    '                Next
    '                If aafaa = True Then
    '                    ab = ab.Remove(MAC(aadaa), 1)
    '                    ab = ab.Insert(MAC(aadaa - 1), "√(")
    '                Else
    '                    ab = ab.Remove(MAC(aadaa) + MAD(aadaa) - 1, 1)
    '                    ab = ab.Remove(MAC(aadaa), 1)
    '                End If
    '                AAEAAG(ab, ac) : If B_ = False Then ad += 1 : Continue Do Else Exit Sub
    '            End If
    '        Next
    '    End If

  End Sub
  Private Sub DBBC()
    '    If b = 33 Then
    '        KAG.Add("b = 33") : ac = "√(a ' c) = a ^ (1 : c)"
    '        For aadaa = 0 To FEA.Count - 1 Step 1
    '            If IAB(aadaa) = 1 Then
    '                If MAB(aadaa) = 5 Or MAB(aadaa) = 14 Then
    '                    ab = aa
    '                    ab = ab.Remove(MAC(aadaa), MAD(aadaa))
    '                    If MAB(aadaa) = 14 Then ab = ab.Insert(MAC(aadaa), ")")
    '                    ab = ab.Insert(MAC(aadaa), "(" & FEA(MAI(aadaa)) & ") ^ (1 : (" & FEA(MAI(aadaa) + 1) & "))")
    '                    If MAB(aadaa) = 14 Then ab = ab.Insert(MAC(aadaa), "-(")
    '                    AAEAAG(ab, ac) : If B_ = False Then ad += 1 : Continue Do Else Exit Sub
    '                End If
    '            End If
    '        Next
    '    End If

  End Sub
  Private Sub DBBD()
    '    If b = 34 Then
    '        KAG.Add("b = 34") : ac = "√(a ·: b) = √(a) ·: √(b)"
    '        For aadaa = 0 To FEA.Count - 1 Step 1
    '            If MAB(aadaa) = 5 Or MAB(aadaa) = 14 Then ' Funktion
    '                '√(a ·: b) = √(a) ·: √(b)
    '                If IAB(aadaa) = 5 Then
    '                    ab = aa
    '                    If IAB(MAE(aadaa)) = 6 Then ab = ab.Insert(MAC(aadaa) + MAD(aadaa), ")")
    '                    ab = ab.Insert(MAC(MAI(aadaa) + MAH(aadaa) - 1), "√(")
    '                    For aagac = MAI(aadaa) + MAH(aadaa) - 2 To MAI(aadaa) Step -1
    '                        If FEB(aadaa) = ":" Then
    '                            If FEB(aagac + 1) = "·" Then
    '                                ab = ab.Remove(MAC(aagac + 1) - 2, 1)
    '                                ab = ab.Insert(MAC(aagac + 1) - 2, ":")
    '                            End If
    '                            If FEB(aagac + 1) = ":" Then
    '                                ab = ab.Remove(MAC(aagac + 1) - 2, 1)
    '                                ab = ab.Insert(MAC(aagac + 1) - 2, "·")
    '                            End If
    '                        End If
    '                        ab = ab.Insert(MAC(aagac + 1) - 3, ")")
    '                        If aagac > MAI(aadaa) Then ab = ab.Insert(MAC(aagac), "√(")
    '                    Next
    '                    If IAB(MAE(aadaa)) = 6 Then ab = ab.Insert(MAC(aadaa), "(")
    '                    AAEAAG(ab, ac) : If B_ = False Then ad += 1 : Continue Do Else Exit Sub
    '                    'a ^ b ˅ c   ‹a›   <<‹a›>>
    '                    'a ˄ b ˄˅ c = a ˄ (b ·: c)
    '                End If
    '                '√(a ·: b ' c) = √(a ' c) ·: √(b ' c)
    '                If IAB(aadaa) = 1 Then
    '                    If IAB(MAI(aadaa)) = 5 Then
    '                        ab = aa
    '                        If IAB(MAE(aadaa)) = 6 Then ab = ab.Insert(MAC(aadaa) + MAD(aadaa), ")")
    '                        ab = ab.Insert(MAC(MAI(MAI(aadaa)) + MAH(MAI(aadaa)) - 1), "√(")
    '                        For aagac = MAI(MAI(aadaa)) + MAH(MAI(aadaa)) - 2 To MAI(MAI(aadaa)) Step -1
    '                            If FEB(aadaa) = ":" Then
    '                                If FEB(aagac + 1) = "·" Then
    '                                    ab = ab.Remove(MAC(aagac + 1) - 2, 1)
    '                                    ab = ab.Insert(MAC(aagac + 1) - 2, ":")
    '                                End If
    '                                If FEB(aagac + 1) = ":" Then
    '                                    ab = ab.Remove(MAC(aagac + 1) - 2, 1)
    '                                    ab = ab.Insert(MAC(aagac + 1) - 2, "·")
    '                                End If
    '                            End If
    '                            ab = ab.Insert(MAC(aagac + 1) - 3, " ' " & FEA(MAI(aadaa) + 1) & ")")
    '                            If aagac > MAI(MAI(aadaa)) Then ab = ab.Insert(MAC(aagac), "√(")
    '                        Next
    '                        If IAB(MAE(aadaa)) = 6 Then ab = ab.Insert(MAC(aadaa), "(")
    '                        AAEAAG(ab, ac) : If B_ = False Then ad += 1 : Continue Do Else Exit Sub
    '                    End If
    '                End If
    '            End If
    '        Next
    '    End If

  End Sub
  Private Sub DBBE()
    '    If b = 35 Then
    '        KAG.Add("b = 35") : ac = "√(a) ·: √(b) = √(a ·: b)"
    '        For aadaa = 0 To FEA.Count - 1 Step 1
    '            If MAB(aadaa) = 5 Or MAB(aadaa) = 14 Then
    '                '√(a) ·: √(b) = √(a ·: b)
    '                If IAB(MAE(aadaa)) = 5 Then
    '                    ab = aa
    '                    '√(a) ·: √(b) = √(a ·: b)
    '                    If IAB(aadaa) <> 1 Then
    '                        Dim aahaa As String = ""
    '                        For aahab = MAI(MAE(aadaa)) + MAH(MAE(aadaa)) - 1 To aadaa + 1 Step -1
    '                            If MAB(aahab) = 5 Or MAB(aahab) = 14 Then
    '                                If IAB(aahab) <> 1 Then
    '                                    ab = ab.Remove(MAC(aahab) - 3, MAD(aahab) + 3)
    '                                    If FEB(aadaa) = ":" Then
    '                                        If IAB(aahab) = 4 Then
    '                                            If FEB(aahab) = "·" Then aahaa = " : (" & FEA(aahab).Substring(2, MAG(aahab)) & ")" & aahaa
    '                                            If FEB(aahab) = ":" Then aahaa = " · (" & FEA(aahab).Substring(2, MAG(aahab)) & ")" & aahaa
    '                                        End If
    '                                        If IAB(aahab) <> 4 Then
    '                                            If FEB(aahab) = "·" Then aahaa = " : " & FEA(aahab).Substring(2, MAG(aahab)) & aahaa
    '                                            If FEB(aahab) = ":" Then aahaa = " · " & FEA(aahab).Substring(2, MAG(aahab)) & aahaa
    '                                        End If
    '                                    Else
    '                                        If IAB(aahab) = 4 Then aahaa = " " & FEB(aahab) & " (" & FEA(aahab).Substring(2, MAG(aahab)) & ")" & aahaa
    '                                        If IAB(aahab) <> 4 Then aahaa = " " & FEB(aahab) & " " & FEA(aahab).Substring(2, MAG(aahab)) & aahaa
    '                                    End If
    '                                End If
    '                            End If
    '                        Next
    '                        If aahaa <> "" Then
    '                            ab = ab.Insert(MAC(aadaa) + MAD(aadaa) - 1, aahaa)
    '                            If IAB(aadaa) = 4 Then
    '                                ab = ab.Insert(MAC(aadaa) + MAD(aadaa) - 1, ")")
    '                                ab = ab.Insert(MAC(MAI(aadaa)), "(")
    '                            End If
    '                            AAEAAG(ab, ac) : If B_ = False Then ad += 1 : Continue Do Else Exit Sub
    '                        End If
    '                    End If
    '                    '√(a ' c) ·: √(b ' c) = √(a ·: b ' c)
    '                    If IAB(aadaa) = 1 Then
    '                        Dim aahaa As String = ""
    '                        For aahab = MAI(MAE(aadaa)) + MAH(MAE(aadaa)) - 1 To aadaa + 1 Step -1
    '                            '√(a ' c) ·: √(b ' c) = √(a ·: b ' c)
    '                            If MAB(aahab) = 5 Or MAB(aahab) = 14 Then
    '                                If IAB(aahab) = 1 Then
    '                                    If FEA(MAI(aadaa) + 1) = FEA(MAI(aahab) + 1) Then
    '                                        ab = ab.Remove(MAC(aahab) - 3, MAD(aahab) + 3)
    '                                        If FEB(aadaa) = ":" Then
    '                                            If IAB(MAI(aahab)) = 4 Then
    '                                                If FEB(aahab) = "·" Then aahaa = " : (" & FEA(MAI(aahab)) & ")" & aahaa
    '                                                If FEB(aahab) = ":" Then aahaa = " · (" & FEA(MAI(aahab)) & ")" & aahaa
    '                                            End If
    '                                            If IAB(MAI(aahab)) <> 4 Then
    '                                                If FEB(aahab) = "·" Then aahaa = " : " & FEA(MAI(aahab)) & aahaa
    '                                                If FEB(aahab) = ":" Then aahaa = " · " & FEA(MAI(aahab)) & aahaa
    '                                            End If
    '                                        Else
    '                                            If IAB(MAI(aahab)) = 4 Then aahaa = " " & FEB(aahab) & " (" & FEA(MAI(aahab)) & ")" & aahaa
    '                                            If IAB(MAI(aahab)) <> 4 Then aahaa = " " & FEB(aahab) & " " & FEA(MAI(aahab)) & aahaa
    '                                        End If
    '                                    End If
    '                                End If
    '                            End If
    '                        Next
    '                        If aahaa <> "" Then
    '                            ab = ab.Insert(MAC(MAI(aadaa) + 1) - 3, aahaa)
    '                            If IAB(MAI(aadaa)) = 4 Then
    '                                ab = ab.Insert(MAC(MAI(aadaa) + 1) - 3, ")")
    '                                ab = ab.Insert(MAC(MAI(aadaa)), "(")
    '                            End If
    '                            AAEAAG(ab, ac) : If B_ = False Then ad += 1 : Continue Do Else Exit Sub
    '                        End If
    '                    End If
    '                End If
    '            End If
    '        Next
    '    End If

  End Sub
  Private Sub DBBF()
    '    If b = 36 Then
    '        KAG.Add("b = 36") : ac = "log(a ' b) = ln(b) : ln(a)"
    '        For aadaa = 0 To FEA.Count - 1 Step 1
    '            If MAB(aadaa) = 16 Or MAB(aadaa) = 22 Then ' Funktion
    '                If IAB(aadaa) = 1 And MAH(aadaa) = 2 Then
    '                    Dim aagaa As String = " : "
    '                    If FEB(aadaa) = ":" Then aagaa = " · "
    '                    ab = aa
    '                    ab = ab.Remove(MAC(aadaa), MAD(aadaa))
    '                    ab = ab.Insert(MAC(aadaa), "ln(" & FEA(MAI(aadaa) + 1) & ")" & aagaa & "ln(" & FEA(MAI(aadaa)) & ")")
    '                    If MAB(aadaa) = 22 Then ab = ab.Insert(MAC(aadaa), "-")
    '                    If IAB(MAE(aadaa)) = 6 Then
    '                        ab = ab.Insert(MAC(aadaa), "(")
    '                        ab = ab.Insert(MAG(aadaa) + 9, ")")
    '                    End If
    '                    AAEAAG(ab, ac) : If B_ = False Then ad += 1 : Continue Do Else Exit Sub
    '                End If
    '            End If
    '        Next
    '        ' ' a ^ b = e ^ (b ln(a))
    '        ' ' e ^ ln(a) = a
    '        ' ' ln(a *: b) = ln(a) +- ln(b)
    '        ' ' ln(a ^ b) = b * ln(a)
    '        ' ' ln(e ^ a) = a
    '    End If
  End Sub
  Private Sub DBBG()
    '    If b = 37 Then
    '        KAG.Add("b = 37") : ac = "Ʃ(a = 1 ' b ' a) = b · (b + 1) : 2"
    '        For aadaa = 0 To FEA.Count - 1 Step 1
    '            ' Ʃ(a = 1 ' b ' a) = b · (b + 1) : 2
    '            If MAB(aadaa) = 8 Or MAB(aadaa) = 11 Then
    '                If IAB(aadaa) = 1 And MAH(aadaa) = 3 Then
    '                    If IAB(MAI(aadaa)) = 3 And MAH(MAI(aadaa)) = 2 Then
    '                        If FEA(MAI(MAI(aadaa))) = FEA(MAI(aadaa) + 2) And
    '                        FEA(MAI(MAI(aadaa)) + 1) = "1" Then
    '                            ab = aa
    '                            ab = ab.Remove(MAC(aadaa), MAD(aadaa))
    '                            If IAB(MAE(aadaa)) = 6 Then ab = ab.Insert(MAC(aadaa), ")")
    '                            ab = ab.Insert(MAC(aadaa), "(" & FEA(MAI(aadaa) + 1) & ") · (" & FEA(MAI(aadaa) + 1) & " + 1) : 2")
    '                            If MAB(aadaa) = 11 Then ab = ab.Insert(MAC(aadaa), "-")
    '                            If IAB(MAE(aadaa)) = 6 Then ab = ab.Insert(MAC(aadaa), "(")
    '                            AAEAAG(ab, ac) : If B_ = False Then ad += 1 : Continue Do Else Exit Sub
    '                        End If
    '                    End If
    '                End If
    '            End If
    '        Next
    '    End If

  End Sub
  Private Sub DBBH()
    '    If b = 38 Then
    '        KAG.Add("b = 38") : ac = "Ʃ(a = 1 ' b ' a ^ 2) = (2 · b ^ 3 + 3 · b ^ 2 + b) : 6"
    '        For aadaa = 0 To FEA.Count - 1 Step 1
    '            ' Ʃ(a = 1 ' b ' a ^ 2) = (2 · b ^ 3 + 3 · b ^ 2 + b) : 6
    '            If MAB(aadaa) = 8 Or MAB(aadaa) = 11 Then
    '                If IAB(aadaa) = 1 And MAH(aadaa) = 3 Then
    '                    If IAB(MAI(aadaa)) = 3 And MAH(MAI(aadaa)) = 2 And
    '                    IAB(MAI(aadaa) + 2) = 6 And MAH(MAI(aadaa) + 2) = 2 Then
    '                        If FEA(MAI(MAI(aadaa))) = FEA(MAI(MAI(aadaa) + 2)) And
    '                        FEA(MAI(MAI(aadaa) + 2) + 1) = "2" And
    '                        FEB(MAI(MAI(aadaa) + 2) + 1) = "^" And FEA(MAI(MAI(aadaa)) + 1) = "1" Then
    '                            ab = aa
    '                            ab = ab.Remove(MAC(aadaa), MAD(aadaa))
    '                            If IAB(MAE(aadaa)) = 6 Then ab = ab.Insert(MAC(aadaa), ")")
    '                            ab = ab.Insert(MAC(aadaa), "(2 · (" & FEA(MAI(aadaa) + 1) & ") ^ 3 + 3 · (" &
    '                                             FEA(MAI(aadaa) + 1) & ") ^ 2 + " & FEA(MAI(aadaa) + 1) & ") : 6")
    '                            If MAB(aadaa) = 11 Then ab = ab.Insert(MAC(aadaa), "-")
    '                            If IAB(MAE(aadaa)) = 6 Then ab = ab.Insert(MAC(aadaa), "(")
    '                            AAEAAG(ab, ac) : If B_ = False Then ad += 1 : Continue Do Else Exit Sub
    '                        End If
    '                    End If
    '                End If
    '            End If
    '        Next
    '    End If

  End Sub
  Private Sub DBBI()
    '    If b = 39 Then
    '        KAG.Add("b = 39") : ac = "Ʃ(a = 1 ' b ' a ^ 3) = (b ^ 4 + 2 · b ^ 3 + b ^ 2) : 4"
    '        For aadaa = 0 To FEA.Count - 1 Step 1
    '            ' Ʃ(a = 1 ' b ' a ^ 3) = (b ^ 4 + 2 · b ^ 3 + b ^ 2) : 4
    '            If MAB(aadaa) = 8 Or MAB(aadaa) = 11 Then
    '                If IAB(aadaa) = 1 And MAH(aadaa) = 3 Then
    '                    If IAB(MAI(aadaa)) = 3 And MAH(MAI(aadaa)) = 2 And
    '                    IAB(MAI(aadaa) + 2) = 6 And MAH(MAI(aadaa) + 2) = 2 Then
    '                        If FEA(MAI(MAI(aadaa))) = FEA(MAI(MAI(aadaa) + 2)) And
    '                        FEA(MAI(MAI(aadaa) + 2) + 1) = "3" And
    '                        FEB(MAI(MAI(aadaa) + 2) + 1) = "^" And FEA(MAI(MAI(aadaa)) + 1) = "1" Then
    '                            ab = aa
    '                            ab = ab.Remove(MAC(aadaa), MAD(aadaa))
    '                            If IAB(MAE(aadaa)) = 6 Then ab = ab.Insert(MAC(aadaa), ")")
    '                            ab = ab.Insert(MAC(aadaa), "((" & FEA(MAI(aadaa) + 1) & ") ^ 4 + 2 · (" &
    '                                             FEA(MAI(aadaa) + 1) & ") ^ 3 + (" & FEA(MAI(aadaa) + 1) & ") ^ 2) : 4")
    '                            If MAB(aadaa) = 11 Then ab = ab.Insert(MAC(aadaa), "-")
    '                            If IAB(MAE(aadaa)) = 6 Then ab = ab.Insert(MAC(aadaa), "(")
    '                            AAEAAG(ab, ac) : If B_ = False Then ad += 1 : Continue Do Else Exit Sub
    '                        End If
    '                    End If
    '                End If
    '            End If
    '        Next
    '    End If

  End Sub
  Private Sub DBBJ()
    '    If b = 40 Then
    '        KAG.Add("b = 40") : ac = "Ʃ(a = 0 ' b ' c ^ a) = (1 - c ^ (b + 1)) : (1 - c)"
    '        For aadaa = 0 To FEA.Count - 1 Step 1
    '            ' Ʃ(a = 0 ' b ' c ^ a) = (1 - c ^ (b + 1)) : (1 - c)
    '            If MAB(aadaa) = 8 Or MAB(aadaa) = 11 Then
    '                If IAB(aadaa) = 1 And MAH(aadaa) = 3 Then
    '                    If IAB(MAI(aadaa)) = 3 And MAH(MAI(aadaa)) = 2 And
    '                    IAB(MAI(aadaa) + 2) = 6 And MAH(MAI(aadaa) + 2) = 2 Then
    '                        If FEA(MAI(MAI(aadaa))) = FEA(MAI(MAI(aadaa) + 2) + 1) And
    '                        FEB(MAI(MAI(aadaa) + 2) + 1) = "^" And FEA(MAI(MAI(aadaa)) + 1) = "0" Then
    '                            ab = aa
    '                            ab = ab.Remove(MAC(aadaa), MAD(aadaa))
    '                            If IAB(MAE(aadaa)) = 6 Then ab = ab.Insert(MAC(aadaa), ")")
    '                            ab = ab.Insert(MAC(aadaa), "(1 - (" & FEA(MAI(MAI(aadaa) + 2)) & ") ^ (" &
    '                                             FEA(MAI(aadaa) + 1) & " + 1)) : (1 - " & FEA(MAI(MAI(aadaa) + 2)) & ")")
    '                            If MAB(aadaa) = 11 Then ab = ab.Insert(MAC(aadaa), "-")
    '                            If IAB(MAE(aadaa)) = 6 Then ab = ab.Insert(MAC(aadaa), "(")
    '                            AAEAAG(ab, ac) : If B_ = False Then ad += 1 : Continue Do Else Exit Sub
    '                        End If
    '                    End If
    '                End If
    '            End If
    '        Next
    '    End If

  End Sub
  Private Sub DBBK()
    '    If b = 41 Then
    '        '∏(a = 1 ' b ' a) = b!
    '        KAG.Add("b = 41") : ac = "∏(a = 1 ' b ' a) = b!"
    '        For aadaa = 0 To FEA.Count - 1 Step 1
    '            If MAB(aadaa) = 9 Or MAB(aadaa) = 12 Then
    '                If IAB(aadaa) = 1 And MAH(aadaa) = 3 Then
    '                    If IAB(MAI(aadaa)) = 3 And MAH(MAI(aadaa)) = 2 Then
    '                        If FEA(MAI(MAI(aadaa))) = FEA(MAI(aadaa) + 2) And
    '                        FEA(MAI(MAI(aadaa)) + 1) = "1" Then
    '                            ab = aa
    '                            ab = ab.Remove(MAC(aadaa), MAD(aadaa))
    '                            If IAB(MAE(aadaa)) = 6 Then ab = ab.Insert(MAC(aadaa), ")")
    '                            ab = ab.Insert(MAC(aadaa), FEA(MAI(aadaa) + 1) & "!")
    '                            If MAB(aadaa) = 12 Then ab = ab.Insert(MAC(aadaa), "-")
    '                            If IAB(MAE(aadaa)) = 6 Then ab = ab.Insert(MAC(aadaa), "(")
    '                            AAEAAG(ab, ac) : If B_ = False Then ad += 1 : Continue Do Else Exit Sub
    '                        End If
    '                    End If
    '                End If
    '            End If
    '        Next
    '    End If

  End Sub
  Private Sub DBBL()
    '    If b = 42 Then
    '        ' ʃ(a ' b ' c · d(c)) = (b ^ 2 - a ^ 2) : 2
    '        KAG.Add("b = 42") : ac = "ʃ(a ' b ' c · d(c)) = (b ^ 2 - a ^ 2) : 2"
    '        For aadaa = 0 To FEA.Count - 1 Step 1
    '            If MAB(aadaa) = 7 Or MAB(aadaa) = 10 Then
    '                If IAB(aadaa) = 1 And MAH(aadaa) = 3 Then
    '                    If IAB(MAI(aadaa) + 2) = 5 And MAH(MAI(aadaa) + 2) = 2 Then
    '                        ' ʃ(a ' b ' c · d(c)) = (b ^ 2 - a ^ 2) : 2
    '                        If MAB(MAI(MAI(aadaa) + 2) + 1) = 6 And MAH(MAI(MAI(aadaa) + 2) + 1) > 0 Then
    '                            If FEA(MAI(MAI(aadaa) + 2)) = FEA(MAI(MAI(MAI(aadaa) + 2) + 1)) Then
    '                                ab = aa
    '                                ab = ab.Remove(MAC(aadaa), MAD(aadaa))
    '                                If IAB(MAE(aadaa)) = 6 Then ab = ab.Insert(MAC(aadaa), ")")
    '                                ab = ab.Insert(MAC(aadaa), "((" & FEA(MAI(aadaa) + 1) & ") ^ 2 - (" & FEA(MAI(aadaa)) & ") ^ 2) : 2")
    '                                If MAB(aadaa) = 10 Then ab = ab.Insert(MAC(aadaa), "-")
    '                                If IAB(MAE(aadaa)) = 6 Then ab = ab.Insert(MAC(aadaa), "(")
    '                                AAEAAG(ab, ac) : If B_ = False Then ad += 1 : Continue Do Else Exit Sub
    '                            End If
    '                        End If
    '                        ' ʃ(a ' b ' d(c) · c) = (b ^ 2 - a ^ 2) : 2
    '                        If MAB(MAI(MAI(aadaa) + 2)) = 6 And MAH(MAI(MAI(aadaa) + 2) + 1) > 0 Then
    '                            If FEA(MAI(MAI(aadaa) + 2) + 1) = FEA(MAI(MAI(MAI(aadaa) + 2))) Then
    '                                ab = aa
    '                                ab = ab.Remove(MAC(aadaa), MAD(aadaa))
    '                                If IAB(MAE(aadaa)) = 6 Then ab = ab.Insert(MAC(aadaa), ")")
    '                                ab = ab.Insert(MAC(aadaa), "((" & FEA(MAI(aadaa) + 1) & ") ^ 2 - (" & FEA(MAI(aadaa)) & ") ^ 2) : 2")
    '                                If MAB(aadaa) = 10 Then ab = ab.Insert(MAC(aadaa), "-")
    '                                If IAB(MAE(aadaa)) = 6 Then ab = ab.Insert(MAC(aadaa), "(")
    '                                AAEAAG(ab, ac) : If B_ = False Then ad += 1 : Continue Do Else Exit Sub
    '                            End If
    '                        End If
    '                    End If
    '                End If
    '            End If
    '        Next
    '    End If

  End Sub
  Private Sub DBBM()
    '    If b = 43 Then
    '        'lim(a → ∞ ' b ^ a) = 0, |b| < 1
    '        KAG.Add("b = 43") : ac = "lim(a → ∞ ' b ^ a) = 0, |b| < 1"
    '        For aadaa = 0 To FEA.Count - 1 Step 1
    '            If MAB(aadaa) = 17 Or MAB(aadaa) = 23 Then
    '                If IAB(aadaa) = 1 And MAH(aadaa) = 2 Then
    '                    If MAH(MAI(aadaa)) = 2 And MAH(MAI(aadaa) + 1) = 2 Then
    '                        If IAB(MAI(aadaa)) = 2 And IAB(MAI(aadaa) + 1) = 6 And
    '                       FEA(MAI(MAI(aadaa))) = FEA(MAI(MAI(aadaa) + 1) + 1) And
    '                       FEA(MAI(MAI(aadaa)) + 1) = "∞" And MAJ(MAI(MAI(aadaa) + 1)) = 1 Then
    '                            If Convert.ToDouble(FEA(MAI(MAI(aadaa) + 1))) < 1 And
    '                           Convert.ToDouble(FEA(MAI(MAI(aadaa) + 1))) > -1 Then
    '                                ab = aa
    '                                ab = ab.Remove(MAC(aadaa), MAD(aadaa))
    '                                ab = ab.Insert(MAC(aadaa), "0")
    '                                AAEAAG(ab, ac) : If B_ = False Then ad += 1 : Continue Do Else Exit Sub
    '                            End If
    '                        End If
    '                    End If
    '                End If
    '            End If
    '        Next
    '    End If

  End Sub
  Private Sub DBBN()

    'If FEA.Count > 0 Then
    '    If aa <> FEA(0) Then AAEAAD(aa)
    'Else
    '    AAEAAD(aa)
    'End If


    '    If b = 44 Then
    '        'genaue Reihenfolge
    '        '1 : 1 · a = !!! = a und 1 : a
    '        '0 - 0 + a = !!! = a und -a

    '        'diese sind zu Prüfen
    '        'g ^ (-(a ^ b) : (c ^ d))
    '        'b ^ a ^ c ^ d = x

    '        'geprüfte
    '        '2 · x = 4 · x + 3
    '        '4 : (x - 2) + b = F
    '        '2 · (x - 4) : (3 · (x + 1)) = 4 : 3
    '        'x : y : z = c + F

    '        'FEA 0 Ausdrucksteil
    '        'FEB 1 Operator
    '        'MAE  2 Quellenausdruck
    '        'MAA  3 Teilungsanfang
    '        'MAB  4 Funktion (schon oben)
    '        'MAC  5 Eingangsanfang
    '        'MAD  6 Eingangslänge
    '        'MAF  7 Ausgangsanfang
    '        'MAG  8 Ausgangslänge
    '        'IAB  9 Ausgangsoperatorengruppe
    '        'MAH  10 Ausgangsteilenanzahl
    '        'MAI 11 Ausgangsteilenanfangsindex
    '        'MAJ 12 Eingangsteil-Zahl
    '        'IAA 13 Vorzeichen vor Eingangsteiles
    '        'MAL 14 Vorzeichen erstes Ausgangsteiles
    '        'MAK 15 Innere-Zahl
    '        'MAM 16 Gesuchte Variable in Gleichung
    '        '±, ∓

    '        ac = ""
    '        For aadaa = 0 To FEA.Count - 1 Step 1

    '        Next

    '    End If

  End Sub
  Private Sub DBXA()
    'Operatoren ±
    AAC = 0 : _A = 0 : For i = 0 To KAI.Count - 1 Step 1 : If KAI(i) = "±" Then : AAC += 1
        _A = i : End If : Next
    If AAC = 1 Then ' wird nur für einmalige ± von allen Ergebnisse angewendet
      CAA = KAH(0) : DCBA("+", {MAC(_A) - 2, 1}) : DDED("a` ± `b` = `a` + `b")
      KAK.AddRange(KAJ.GetRange(0, KAJ.Count)) : JAB.AddRange(JAA.GetRange(0, JAA.Count))
      MAR.Add(KAJ.Count) : KAJ.Clear() : JAA.Clear() : KAC.Add(CAA) : KAD.Add("a ± b = a + b")
      CAA = KAH(0) : DCBA("-", {MAC(_A) - 2, 1}) : DDED("a` ± `b` = `a` - `b")
      KAK.AddRange(KAJ.GetRange(0, KAJ.Count)) : JAB.AddRange(JAA.GetRange(0, JAA.Count))
      MAR.Add(KAJ.Count) : KAJ.Clear() : JAA.Clear() : KAC.Add(CAA) : KAD.Add("a ± b = a - b")
      DAAE() : _M += 1 : Exit Sub : End If ' DAAF ist nur für zweiten angewendet
  End Sub
#End Region ' *****
#Region "D-AD"
  Private Sub DCYY1()
    KAJ.Add(vbLf & vbLf & NAA.GetString("S042"))
    _FA = _AD.Split("´")
    KAJ.Add(vbCrLf & CAA.Substring(0, DFAB(_FA(1))))
    _J = 1 : _K = CInt(_FA(0)) - 2 : DCYY3()
  End Sub
  Private Sub DCYY2()
    KAJ.Add(vbCrLf & vbLf & NAA.GetString("S043"))
    _H = DFAB(_FA(CInt(_FA(0))))
    KAJ.Add(vbCrLf & CAA.Substring(0, _H))
    _J = CInt(_FA(0)) : _K = _FA.Count - 2
    DCYY3() : _H = DFAB(_FA(_FA.Count - 1))
    JAA.Add(_ED) : JAA.Add(_EA) : _J = 0
    KAJ.Add(CAA.Substring(_H, CAA.Length - _H))
    _FD = _AE.Split("´") : _K = _FD.Count - 1
    DCYY4() : JAA.Add(_EA) ' Reihenfolge !
  End Sub
  Private Sub DCYY3()
    For i = _J To _K Step 1 : _H = DFAB(_FA(i))
      KAJ.Add(
        CAA.Substring(_H, DFAB(_FA(i + 1)) - _H))
    Next
  End Sub
  Private Sub DCYY4()
    For i = _J To _K Step 1
      JAA.Add(_GA(CInt(_FD(i)))) : Next
  End Sub
  Private Sub DEA_()
    ' Positionen
    H1(0) = MAD(0)
    H1(1) = MAC(_F)
    H1(2) = MAD(_F)
    H1(3) = MAC(_G)
    H1(4) = MAD(_G)
    H1(5) = MAE(_F)
    H1(6) = MAI(_F)
    H1(7) = MAI(_G)
    H1(8) = MAI(H1(5))
    H1(9) = MAI(H1(6))
    H1(10) = MAI(H1(7))
    H1(11) = MAI(H1(8))
    H1(12) = MAI(H1(9))
    H1(13) = MAI(H1(11))
    H1(14) = MAI(H1(12))
    H1(15) = MAC(H1(6))
    H1(16) = MAD(H1(6))
    H1(17) = MAC(H1(7))
    H1(18) = MAD(H1(7))
    H1(19) = MAC(H1(8))
    H1(20) = MAD(H1(8))
    H1(21) = MAC(H1(9))
    H1(22) = MAD(H1(9))
    H1(23) = MAC(H1(10))
    H1(24) = MAD(H1(10))
    H1(25) = MAC(H1(11))
    H1(26) = MAD(H1(11))
    H1(27) = MAC(H1(12))
    H1(28) = MAD(H1(12))
    H1(29) = MAC(H1(14))
    H1(30) = MAD(H1(14))
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

  Private Sub DEWA(a() As Integer)
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
      Case 20 : _AF = KAH(_G)
      Case 21 : _AF = "("
      Case 22 : _AF = "-("
    End Select
    ' Stellen 1
    Select Case a(2)
      Case 1 : DEA_() : _HB = {H1(1), H1(2), H1(1)}
      Case 2 : DEA_() : _HB = {H1(1) - 3, 4, H1(1) - 3}
      Case 3 : DEA_() : _HB = {H1(1), 1, H1(19)}
      Case 4 : DEA_() : _HB = {H1(1), 1, H1(19), 1}
      Case 5 : DEA_() : _HB = {H1(3) - 3, H1(4) + 3, H1(19), H1(20), H1(19)}
      Case 6 : DEA_() : _HB = {H1(3) - 3, H1(4) + 3, H1(1), H1(2), H1(1)}
      Case 7 : DEA_() : _HB = {H1(3) - 3, H1(4) + 3, H1(1) - 3, H1(2) + 3, H1(1) - 3}
      Case 8 : DEA_() : _HB = {H1(1) - 3, H1(2) + 3}
      Case 9 : DEA_() : _HB = {H1(1) - 3, H1(2) + 3, H1(3), H1(4), H1(3)}
      Case 10 : DEA_() : _HB = {H1(1) - 3, H1(2) + 3, H1(19), H1(20), H1(19)}
      Case 11 : DEA_() : _HB = {H1(3) - 3, H1(4) + 3}
      Case 12 : DEA_() : _HB = {H1(19), H1(20) + 3, H1(19)}
      Case 13 : DEA_() : _HB = {H1(19), H1(20) + 3, H1(19), H1(34) - H1(2) - 1}
      Case 14 : DEA_() : _HB = {H1(19), H1(20) + 3, H1(19), H1(38) - H1(2) - 1}
      Case 15 : DEA_() : _HB = {H1(1) - 3, H1(2) + 3, H1(19), H1(40) + 2}
      Case 16 : DEA_() : _HB = {H1(1), 1, H1(32) - 2, 1}
      Case 17 : DEA_() : _HB = {H1(1) + 1, 1, H1(32) - 2, 1}
      Case 18 : DEA_() : _HB = {H1(1), 3, H1(32) - 4, 1}
      Case 19 : DEA_() : _HB = {H1(32) - 1, 1, H1(44)}
      Case 20 : DEA_() : _HB = {H1(32) - 1, 1, H1(47)}
      Case 21 : DEA_() : _HB = {H1(1), 2, H1(32) - 3, 1}
      Case 22 : DEA_() : _HB = {H1(44), 4}
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
        DCYY1() : CAA = CAA.Remove(_HB(0), _HB(1))
        DCYY2()
      Case 3 ' RI: Remove-Insert
        DCYY1() : CAA = CAA.Remove(_HB(0), _HB(1))
        CAA = CAA.Insert(_HB(2), _AF) : DCYY2()
      Case 4 ' RR: Remove-Remove
        DCYY1() : CAA = CAA.Remove(_HB(0), _HB(1))
        CAA = CAA.Remove(_HB(2), _HB(3)) : DCYY2()
      Case 5 ' RII: Remove-Insert-Insert
        DCYY1() : CAA = CAA.Remove(_HB(0), _HB(1))
        CAA = CAA.Insert(_HB(2), _AF)
        CAA = CAA.Insert(_HB(3), _AG) : DCYY2()
      Case 6 ' RRI: Remove-Remove-Insert
        DCYY1() : CAA = CAA.Remove(_HB(0), _HB(1))
        CAA = CAA.Remove(_HB(2), _HB(3))
        CAA = CAA.Insert(_HB(4), _AF) : DCYY2()
      Case 100 ' R(RI)R:
        ' a - (b +- c) = a - b -+ c
        _FA = _AD.Split("´") : _FD = _AE.Split("´")
        _J = CInt(_FA(3))
        KAJ.Add(vbLf & vbLf & NAA.GetString("S042"))
        KAJ.Add(vbCrLf & CAA.Substring(0, H1(_J)))
        ' *********************************************
        ' Farben : Index-Abkürzung
        _J = 3 : _K = CInt(_FA(0)) : DCYY3()
        _J = 1 : _K = CInt(_FD(0)) - 1 : DCYY4()
        ' *********************************************
        _J = H1(9) + 1 : _K = CInt(_FA(3))
        ' For-Schleife von zweiten bis letzten Operatoren
        For i = _J To _J + MAH(H1(6)) - 2 Step 1
          KAJ.Add(" " & KAI(i) & " ") : KAJ.Add(KAH(i))
          JAA.Add(_EC) : JAA.Add(_EB) : Next
        KAJ.Add(CAA.Substring(H1(32) - 1, 1))
        KAJ.Add(CAA.Substring(H1(32), H1(0) - H1(32)))
        KAJ.Add(vbCrLf & vbLf & NAA.GetString("S043"))
        KAJ.Add(vbCrLf & CAA.Substring(0, H1(_K)))
        ' *********************************************
        If _AF = ")" Then
          CAA = CAA.Remove(_HB(0), _HB(1))
          CAA = CAA.Insert(_HB(2), _AF)
        Else
          CAA = CAA.Remove(_HB(0), _HB(1))
          CAA = CAA.Remove(_HB(2), _HB(3))
        End If
        ' *********************************************
        _J = CInt(_FA(0)) + 2 : _K = _FA.Count - 2
        DCYY3()
        _J = CInt(_FD(0)) : _K = _FD.Count - 1
        DCYY4()
        ' *********************************************
        ' Farben : Index-Abkürzung
        _J = H1(9) + 1
        ' For-Schleife von zweiten bis letzten Operatoren
        For i = _J To _J + MAH(H1(6)) - 2 Step 1
          ' Operatorentausch
          Select Case KAI(i)
            Case "+" : _AF = "-" : Case "-" : _AF = "+"
            Case "·" : _AF = ":" : Case ":" : _AF = "·"
          End Select
          ' Operatoren RI mit Farben in CAA
          ' *******************************************
          _H = MAC(i) - CInt(_FA(1)) ' -(-a + b)
          CAA = CAA.Remove(_H, 1) : JAA.Add(_EC)
          CAA = CAA.Insert(_H, _AF) : JAA.Add(_EB)
          KAJ.Add(" " & _AF & " ") : KAJ.Add(KAH(i))
        Next
        ' *********************************************
        JAA.Add(_EA) : _H = H1(32) - CInt(_FA(2))
        KAJ.Add(CAA.Substring(_H, H1(0) - H1(32)))
        'AIAI("AAAAA") : Exit Sub ' -(a ^ b + c)
        ' *********************************************
    End Select
    ' Farben Teil 1-2
    For i = 0 To 1 : JAA.Add(_ED)
      Select Case a(5 + i)
        Case 1 : JAA.Add(_EB) ' B
        Case 2 : JAA.Add(_EE) ' L
        Case 3 : JAA.Add(_EC) ' R
        Case 4 : JAA.AddRange({_EB, _EC}) ' BR
        Case 5 : JAA.AddRange({_EB, _EE}) ' BL
        Case 6 : JAA.AddRange({_EC, _EB}) ' RB
        Case 7 : JAA.AddRange({_EB, _EE, _EB}) ' BLB
        Case 8 : JAA.AddRange({_EB, _EC, _EB}) ' BRB
        Case 9 : JAA.AddRange({_EC, _EB, _EE}) ' RBL
        Case 10 : JAA.AddRange({_EC, _EB, _EC}) ' RBR
        Case 11 : JAA.AddRange({_EC, _EE, _EC}) ' RLR
        Case 12 : JAA.AddRange({_EB, _EE, _EB, _EE}) ' BLBL
        Case 13 : JAA.AddRange({_EB, _EC, _EB, _EE}) ' BRBL
        Case 14 : JAA.AddRange({_EC, _EB, _EE, _EB}) ' RBLB
        Case 15 : JAA.AddRange({_EC, _EB, _EC, _EB}) ' RBRB
        Case 16 : JAA.AddRange({_EB, _EE, _EB, _EC, _EB}) ' BLBRB
        Case 17 : JAA.AddRange({_EC, _EB, _EE, _EB, _EE}) ' RBLBL
        Case 18 : JAA.AddRange({_EC, _EB, _EC, _EB, _EE}) ' RBRBL
        Case 19 : JAA.AddRange({_EB, _EE, _EB, _EC, _EB, _EE}) ' BLBRBL
        Case 20 : JAA.AddRange({_EC, _EB, _EE, _EB, _EC, _EB}) ' RBLBRB
        Case 21 : JAA.AddRange({_EC, _EB, _EE, _EB, _EC, _EB, _EE}) ' RBLBRBL
        Case 22 : JAA.AddRange({_EC, _EB, _EE, _EC}) ' RBLR
        Case 23 : JAA.AddRange({_EB, _EC, _EB, _EC, _EB, _EC}) ' BRBRBR
        Case 24 : JAA.AddRange({_EC, _EB, _EC, _EB, _EC}) ' RBRBR
        Case 25 : JAA.AddRange({_EB, _EC, _EB, _EC}) ' BRBR
        Case 26 : JAA.AddRange({_EB, _EC, _EB, _EC, _EB}) ' BRBRB
        Case 27 : JAA.AddRange({_EC, _EB, _EE, _EC, _EB}) ' RBLRB
        Case 28 : JAA.AddRange({_EC, _EB, _EE, _EC, _EB, _EC}) ' RBLRBR
        Case 29 : JAA.AddRange({_EB, _EE, _EC, _EB}) ' BLRB

          ' CB - Blue CC - Magenta CD - SkyBlue CE - Lime *
      End Select
      If i = 0 Then
        KAJ.Add(vbCrLf & vbCrLf & NAA.GetString("S040") &
                vbCrLf) : _FA = _AH.Split("`")
        For j = 0 To _FA.Count - 1 Step 1 : KAJ.Add(_FA(j))
        Next
      End If
    Next
    ' Kommentarmeldung
    If a(7) > 0 Then
      DEBD(vbCrLf & vbCrLf & NAA.GetString("S044") & vbCrLf)
    End If
    ' Kommentare
    Select Case a(7) : Case 0 : Exit Select
      Case 1 : DEBE("b = 2 k + 1, k є Z") ' ∈ ℕ
      Case 2 : DEBE("c = 2 k + 1, k є Z")
      Case 3 : DEBE("b, d = 2 k + 1, k є Z")
      Case 4 : DEBE("-∞ · 0 = -0 · ∞ = 0 · ∞ = ☼")
      Case 5 : DEBE("a є Z, a < 171, a > -171 (" &
                    NAA.GetString("S000") & ")")
      Case 6 : DEBE("a ≠ 0")
      Case 7 : DEBE("a ≠ ∞")
      Case 8 : DEBE("a, b є R")
      Case 9 : DEBE("a є R")
      Case 10 : DEBE("a ≥ 0")
      Case 11 : DEBE("b, c, d є R")
    End Select
  End Sub
#End Region ' *****
#Region "D-AE"
  Private Sub DCAA(a As Integer, b As Integer)
    'R: 1 Stelle vor und keine nach: nur Remove ohne Insert
    DEBA(vbCrLf & vbCrLf & CAA.Substring(0, a)) : DEBB(CAA.Substring(a, b))
    DEBA(CAA.Substring(a + b, CAA.Length - a - b)) : CAA = CAA.Remove(a, b) : DEBC(vbCrLf & CAA)
  End Sub
  Private Sub DCAB(a() As Integer)
    'RR: 2 Stellen vor und keine nach: nur Remove ohne Insert
    DEBA(vbCrLf & vbCrLf & CAA.Substring(0, a(0))) : DEBB(CAA.Substring(a(0), a(1)))
    DEBA(CAA.Substring(a(0) + a(1), a(2) - a(0) - a(1))) : DEBB(CAA.Substring(a(2), a(3)))
    DEBA(CAA.Substring(a(2) + a(3), CAA.Length - a(2) - a(3))) : CAA = CAA.Remove(a(2), a(3))
    CAA = CAA.Remove(a(0), a(1)) : DEBC(vbCrLf & CAA)
  End Sub
  Private Sub DCAD(a As String, b As Integer)
    'I: 1 Stelle: nur Insert
    DEBA(vbCrLf & vbCrLf & CAA) : CAA = CAA.Insert(b, a)
    DEBC(vbCrLf & CAA.Substring(0, b)) : DEBB(a)
    DEBC(CAA.Substring(b + a.Length, CAA.Length - b - a.Length))
  End Sub
  Private Sub DCBA(a As String, b() As Integer)
    'RI: 1 Stelle vor und 1 dieselbe nach: Remove und Insert
    DEBA(vbCrLf & vbCrLf & CAA.Substring(0, b(0)))
    DEBB(CAA.Substring(b(0), b(1)))
    DEBA(CAA.Substring(b(0) + b(1), CAA.Length - b(0) - b(1)))
    CAA = CAA.Remove(b(0), b(1)) : CAA = CAA.Insert(b(0), a)
    DEBC(vbCrLf & CAA.Substring(0, b(0))) : DEBB(a)
    DEBC(CAA.Substring(b(0) + a.Length, CAA.Length - b(0) - a.Length))
  End Sub
  Private Sub DCBB(a As String, b() As Integer)
    'RI: 1 Stelle vor und 1 allgemeine nach: Insert in dieselbe oder andere Stelle
    DEBA(vbCrLf & vbCrLf & CAA.Substring(0, b(0))) : DEBB(CAA.Substring(b(0), b(1)))
    DEBA(CAA.Substring(b(0) + b(1), CAA.Length - b(0) - b(1))) : CAA = CAA.Remove(b(0), b(1))
    CAA = CAA.Insert(b(2), a) : DEBC(vbCrLf & CAA.Substring(0, b(2))) : DEBB(a)
    DEBC(CAA.Substring(b(2) + a.Length, CAA.Length - b(2) - a.Length))
  End Sub
  Private Sub DCBC(a As String, b() As Integer)
    'RRI: 2 Stelle vor und 1-te nach
    DEBA(vbCrLf & vbCrLf & CAA.Substring(0, b(0)))
    DEBB(CAA.Substring(b(0), b(1)))
    DEBA(CAA.Substring(b(0) + b(1), b(2) - b(0) - b(1)))
    DEBB(CAA.Substring(b(2), b(3)))
    DEBA(CAA.Substring(b(2) + b(3), CAA.Length - b(2) - b(3)))
    CAA = CAA.Remove(b(2), b(3)) : CAA = CAA.Remove(b(0), b(1))
    CAA = CAA.Insert(b(0), a)
    DEBC(vbCrLf & CAA.Substring(0, b(0))) : DEBB(a)
    DEBC(CAA.Substring(b(0) + a.Length, CAA.Length - b(0) - a.Length))
  End Sub
  Private Sub DCCA(a() As String, b() As Integer)
    'RII: 1 Stelle vor und 2 andere nach
    Dim aa As Integer : aa = b(3) + a(0).Length + a(1).Length
    DEBA(vbCrLf & vbCrLf & CAA.Substring(0, b(0)))
    DEBB(CAA.Substring(b(0), b(1)))
    DEBA(CAA.Substring(b(0) + b(1), CAA.Length - b(0) - b(1)))
    CAA = CAA.Remove(b(0), b(1)) : CAA = CAA.Insert(b(3), a(1))
    CAA = CAA.Insert(b(2), a(0)) : DEBC(vbCrLf & CAA.Substring(0, b(2)))
    DEBB(a(0)) : DEBC(CAA.Substring(b(2) + a(0).Length, b(3) - b(2)))
    DEBB(a(1)) : DEBC(CAA.Substring(aa, CAA.Length - aa))
  End Sub
#End Region ' *****
#Region "D-AF"
  Private Sub DXBA()
    'Kommentar-Formel-Farbe: B-X
    DEBD(vbCrLf & NAA.GetString("S040")) : DEBA(_FA(0)) : DEBD(_FA(1))
  End Sub
  Private Sub DXAA()
    'Kommentar-Formel-Farbe: R-X
    DEBD(vbCrLf & NAA.GetString("S040")) : DEBB(_FA(0)) : DEBD(_FA(1))
  End Sub
  Private Sub DXAB()
    'Kommentar-Formel-Farbe: BR-X
    DEBD(vbCrLf & NAA.GetString("S040"))
    DEBA(_FA(0)) : DEBB(_FA(1)) : DEBD(_FA(2))
  End Sub
  Private Sub DXAC()
    'Kommentar-Formel-Farbe: RB-X
    DEBD(vbCrLf & NAA.GetString("S040"))
    DEBB(_FA(0)) : DEBA(_FA(1)) : DEBD(_FA(2))
  End Sub
  Private Sub DXAD()
    'Kommentar-Formel-Farbe: BRB-X
    DEBD(vbCrLf & NAA.GetString("S040")) : DEBA(_FA(0))
    DEBB(_FA(1)) : DEBA(_FA(2)) : DEBD(_FA(3))
  End Sub
  Private Sub DXAE()
    'Kommentar-Formel-Farbe: RBR-X
    DEBD(vbCrLf & NAA.GetString("S040")) : DEBB(_FA(0))
    DEBA(_FA(1)) : DEBB(_FA(2)) : DEBD(_FA(3))
  End Sub
  Private Sub DXAF()
    'Kommentar-Formel-Farbe: BRBR-X
    DEBD(vbCrLf & NAA.GetString("S040")) : DEBA(_FA(0))
    DEBB(_FA(1)) : DEBA(_FA(2)) : DEBB(_FA(3)) : DEBD(_FA(4))
  End Sub
  Private Sub DXAG()
    'Kommentar-Formel-Farbe: RBRB-X
    DEBD(vbCrLf & NAA.GetString("S040")) : DEBB(_FA(0))
    DEBA(_FA(1)) : DEBB(_FA(2)) : DEBA(_FA(3)) : DEBD(_FA(4))
  End Sub
  Private Sub DXAH()
    'Kommentar-Formel-Farbe: RBRBR-X
    DEBD(vbCrLf & NAA.GetString("S040")) : DEBB(_FA(0))
    DEBA(_FA(1)) : DEBB(_FA(2)) : DEBA(_FA(3)) : DEBB(_FA(4)) : DEBD(_FA(5))
  End Sub
  Private Sub DXAI()
    'Kommentar-Formel-Farbe: BRBRBR-X
    DEBD(vbCrLf & NAA.GetString("S040")) : DEBA(_FA(0)) : DEBB(_FA(1))
    DEBA(_FA(2)) : DEBB(_FA(3)) : DEBA(_FA(4)) : DEBB(_FA(5)) : DEBD(_FA(6))
  End Sub
  Private Sub DDAA(a As String)
    'Kommentar-Formel-Farbe: R-R
    DECA(a) : DXAA() : DEBB(_FA(2))
  End Sub
  Private Sub DDBA(a As String)
    'Kommentar-Formel-Farbe: B-RG
    DECA(a) : DXBA() : DEBB(_FA(2)) : DEBC(_FA(3))
  End Sub
  Private Sub DDCX(a As String)
    'Kommentar-Formel-Farbe: BR-G
    DECA(a) : DXAB() : DEBC(_FA(3))
  End Sub
  Private Sub DDCY(a As String)
    'Kommentar-Formel-Farbe: BR-GR
    DECA(a) : DXAB() : DEBC(_FA(3)) : DEBB(_FA(4))
  End Sub
  Private Sub DDCA(a As String)
    'Kommentar-Formel-Farbe: BR-RG
    DECA(a) : DXAB() : DEBB(_FA(3)) : DEBC(_FA(4))
  End Sub
  Private Sub DDCB(a As String)
    'Kommentar-Formel-Farbe: BR-GRG
    DECA(a) : DXAB() : DEBC(_FA(3)) : DEBB(_FA(4)) : DEBC(_FA(5))
  End Sub
  Private Sub DDCC(a As String)
    'Kommentar-Formel-Farbe: BR-GRGR
    DECA(a) : DXAB() : DEBC(_FA(3)) : DEBB(_FA(4)) : DEBC(_FA(5)) : DEBB(_FA(6))
  End Sub
  Private Sub DDCD(a As String)
    'Kommentar-Formel-Farbe: BR-RGRG
    DECA(a) : DXAB() : DEBB(_FA(3)) : DEBC(_FA(4)) : DEBB(_FA(5)) : DEBC(_FA(6))
  End Sub
  Private Sub DDCE(a As String)
    'Kommentar-Formel-Farbe: RB-G
    DECA(a) : DXAC() : DEBC(_FA(3))
  End Sub
  Private Sub DDCF(a As String)
    'Kommentar-Formel-Farbe: RB-RG
    DECA(a) : DXAC() : DEBB(_FA(3)) : DEBC(_FA(4))
  End Sub
  Private Sub DDCG(a As String)
    'Kommentar-Formel-Farbe: RB-RGR
    DECA(a) : DXAC() : DEBB(_FA(3)) : DEBC(_FA(4)) : DEBB(_FA(5))
  End Sub
  Private Sub DDEA(a As String)
    'Kommentar-Formel-Farbe: BRB-G
    DECA(a) : DXAD() : DEBC(_FA(4))
  End Sub
  Private Sub DDEB(a As String)
    'Kommentar-Formel-Farbe: BRB-GR
    DECA(a) : DXAD() : DEBC(_FA(4)) : DEBB(_FA(5))
  End Sub
  Private Sub DDED(a As String)
    'Kommentar-Formel-Farbe: BRB-GRG
    DECA(a) : DXAD() : DEBC(_FA(4)) : DEBB(_FA(5)) : DEBC(_FA(6))
  End Sub
  Private Sub DDEE(a As String)
    'Kommentar-Formel-Farbe: BRB-GRGR
    DECA(a) : DXAD() : DEBC(_FA(4)) : DEBB(_FA(5)) : DEBC(_FA(6)) : DEBB(_FA(7))
  End Sub
  Private Sub DDEF(a As String)
    'Kommentar-Formel-Farbe: BRB-GRGRG
    DECA(a) : DXAD() : DEBC(_FA(4)) : DEBB(_FA(5)) : DEBC(_FA(6)) : DEBB(_FA(7)) : DEBC(_FA(8))
  End Sub
  Private Sub DDEH(a As String)
    'Kommentar-Formel-Farbe: BRB-RG
    DECA(a) : DXAD() : DEBB(_FA(4)) : DEBC(_FA(5))
  End Sub
  Private Sub DDFA(a As String)
    'Kommentar-Formel-Farbe: RBR-G
    DECA(a) : DXAE() : DEBC(_FA(4))
  End Sub
  Private Sub DDFB(a As String)
    'Kommentar-Formel-Farbe: RBR-RG
    DECA(a) : DXAE() : DEBB(_FA(4)) : DEBC(_FA(5))
  End Sub
  Private Sub DDGA(a As String)
    'Kommentar-Formel-Farbe: BRBR-G
    DECA(a) : DXAF() : DEBC(_FA(5))
  End Sub
  Private Sub DDGB(a As String)
    'Kommentar-Formel-Farbe: BRBR-GRG
    DECA(a) : DXAF() : DEBC(_FA(5)) : DEBB(_FA(6)) : DEBC(_FA(7))
  End Sub
  Private Sub DDHA(a As String)
    'Kommentar-Formel-Farbe: RBRB-G
    DECA(a) : DXAG() : DEBC(_FA(5))
  End Sub
  Private Sub DDIA(a As String)
    'Kommentar-Formel-Farbe: RBRBR-GRG
    DECA(a) : DXAH() : DEBC(_FA(6)) : DEBB(_FA(7)) : DEBC(_FA(8))
  End Sub
  Private Sub DDJA(a As String)
    'Kommentar-Formel-Farbe: BRBRBR-GRG
    DECA(a) : DXAI() : DEBC(_FA(7)) : DEBB(_FA(8)) : DEBC(_FA(9))
  End Sub

  Private Sub DYAD()
    'Kommentar-Formel-Farbe: BRB-X
    DEBD(vbCrLf & NAA.GetString("S040") & vbCrLf)
    DEBB(_FA(0)) : DEBC(_FA(1)) : DEBB(_FA(2)) : DEBD(_FA(3))
  End Sub
  Private Sub DYAD1()
    'Kommentar-Formel-Farbe: RBRB-X
    DEBD(vbCrLf & NAA.GetString("S040") & vbCrLf) : DEBC(_FA(0))
    DEBB(_FA(1)) : DEBC(_FA(2)) : DEBB(_FA(3)) : DEBD(_FA(4))
  End Sub
  Private Sub DXAA1()
    'Kommentar-Formel-Farbe: R-X
    DEBD(vbCrLf & NAA.GetString("S040") & vbCrLf)
    DEBC(_FA(0)) : DEBD(_FA(1))
  End Sub
  Private Sub DXAB1()
    'Kommentar-Formel-Farbe: BR-X
    DEBD(vbCrLf & NAA.GetString("S040") & vbCrLf)
    DEBB(_FA(0)) : DEBC(_FA(1)) : DEBD(_FA(2))
  End Sub
  Private Sub DXAC1()
    'Kommentar-Formel-Farbe: RB-X
    DEBD(vbCrLf & NAA.GetString("S040") & vbCrLf)
    DEBC(_FA(0)) : DEBB(_FA(1)) : DEBD(_FA(2))
  End Sub

  Private Sub DDAA1(a As String)
    'Kommentar-Formel-Farbe: R-R
    DECA(a) : DXAA1() : DEBC(_FA(2))
  End Sub
  Private Sub DDAA2(a As String)
    'Kommentar-Formel-Farbe: BR-BR
    DECA(a) : DXAB1() : DEBB(_FA(3)) : DEBC(_FA(4))
  End Sub
  Private Sub DDAA3(a As String)
    'Kommentar-Formel-Farbe: BR-B
    DECA(a) : DXAB1() : DEBB(_FA(3))
  End Sub
  Private Sub DDCE1(a As String)
    'Kommentar-Formel-Farbe: RB-B
    DECA(a) : DXAC1() : DEBB(_FA(3))
  End Sub
  Private Sub DDCE2(a As String)
    'Kommentar-Formel-Farbe: RB-RB
    DECA(a) : DXAC1() : DEBC(_FA(3)) : DEBB(_FA(4))
  End Sub
  Private Sub DDCE3(a As String)
    'Kommentar-Formel-Farbe: RB-RBR
    DECA(a) : DXAC1() : DEBC(_FA(3))
    DEBB(_FA(4)) : DEBC(_FA(5))
  End Sub
  Private Sub DDED1(a As String)
    'Kommentar-Formel-Farbe: BRB-BRB
    DECA(a) : DYAD() : DEBB(_FA(4)) : DEBC(_FA(5)) : DEBB(_FA(6))
  End Sub
  Private Sub DDED2(a As String)
    'Kommentar-Formel-Farbe: BRB-RB
    DECA(a) : DYAD() : DEBC(_FA(4)) : DEBB(_FA(5))
  End Sub
  Private Sub DDED3(a As String)
    'Kommentar-Formel-Farbe: RBRB-B
    DECA(a) : DYAD1() : DEBB(_FA(5))
  End Sub

#End Region ' *****
#Region "D-AG"
  Private Sub DEBA(a As String)
    KAJ.Add(a) : JAA.Add(_EA)
  End Sub
  Private Sub DEBB(a As String)
    KAJ.Add(a) : JAA.Add(_EB)
  End Sub
  Private Sub DEBC(a As String)
    KAJ.Add(a) : JAA.Add(_EC)
  End Sub
  Private Sub DEBD(a As String)
    KAJ.Add(a) : JAA.Add(_ED)
  End Sub
  Private Sub DEBE(a As String)
    KAJ.Add(a) : JAA.Add(_EE)
  End Sub
  Private Sub DEBF(a As String)
    KAJ.Add(a) : JAA.Add(Colors.MediumAquamarine)
  End Sub

  Private Sub DECA(a As String)
    _FA = a.Split("`")
  End Sub
  Private Sub DECB(a As String)
    DEBD(vbCrLf & NAA.GetString("S044") & vbCrLf)
    DEBB(a & " = 2 k + 1, k є N") ' ∈ ℕ
  End Sub
  Private Sub DEDA(a() As Integer)
    For i = 0 To MAC.Count - 1 Step 1
      If a(0) <= MAC(i) Then MAC(i) += a(1)
    Next
  End Sub
  Private Sub DEDB(a() As Integer)
    Dim aa As Byte = KAI(a(0)).Length * 3
    _A -= (MAD(a(0)) + MAD(a(1)) + aa + 3)
    DEDC({MAC(a(0)) - aa, MAD(a(0)) + aa, MAC(a(1)) - 3, MAD(a(1)) + 3})
  End Sub
  Private Sub DEDC(a() As Integer)
    DEBA(vbCrLf & vbCrLf & CAA.Substring(0, a(0))) : DEBB(CAA.Substring(a(0), a(1)))
    DEBA(CAA.Substring(a(0) + a(1), a(2) - a(0) - a(1))) : DEBB(CAA.Substring(a(2), a(3)))
    CAA = CAA.Remove(a(2), a(3)) : CAA = CAA.Remove(a(0), a(1))
  End Sub
#End Region ' *****
#Region "D-AH"
  Private Function DFAA(a As Double) As String
    Return a.ToString().Replace("E+", " · 10 ^ ").Replace(
      "E-0", " · 10 ^ -").Replace("E-", " · 10 ^ -")
  End Function
  Private Function DFAB(a As String) As Integer
    If a.Split("·").Count = 2 Then
      _FB = a.Split("·") : DFAB = H1(CInt(_FB(0))) + CInt(_FB(1))
    ElseIf a.Split(":").Count = 2 Then
      _FB = a.Split(":") : DFAB = H1(CInt(_FB(0))) - CInt(_FB(1))
    Else : DFAB = H1(CInt(a)) : End If : Return DFAB
  End Function
  Private Function DFAC(a As Integer) As String
    H1(0) = IAA(a) + 1
    If H1(0) = 2 Or H1(0) = 4 Then : H1(1) = a
      If IAB(a) = 5 Then H1(1) = MAI(a) : H1(0) += 10
      H1(2) = MAI(H1(1)) + 1 ' ! Reihenfolge !
      If MAH(H1(1)) = 2 And KAI(H1(2)) = "˄" Then
        If Integer.TryParse(KAH(H1(2)), 0) = True Then
          Select Case KAH(H1(2)).Substring(MAD(H1(2)) - 1, 1)
            Case "0", "2", "4", "6", "8" : H1(0) += 20
            Case "1", "3", "5", "7", "9" : H1(0) += 40
          End Select
        End If
      End If
    End If
    Return CStr(H1(0)) ' {0, 1, 2, 3} + 1

    '      IAB < 5                       IAB = 5
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
  Private Function DFAD(a As Integer) As String
    Return KAH(a).TrimStart("-")
  End Function
#End Region ' *****
#End Region
  ' * EEEE * EEEE * EEEE * EEEE *
#Region "EEEE"
#Region "E-AA"
  Private Sub EAAA()
    Dim AA(0 To FAA.Count - 1) As String
    A203.Document.SetText(TextSetOptions.FormatRtf, "")
    A204.Document.SetText(TextSetOptions.FormatRtf, "")
    A203.Document.Selection.CharacterFormat.BackgroundColor = Colors.White
    A204.Document.Selection.CharacterFormat.BackgroundColor = Colors.White
    A203.Document.Selection.CharacterFormat.ForegroundColor = Colors.Black
    A204.Document.Selection.CharacterFormat.ForegroundColor = Colors.Blue
    A203.FontFamily = New FontFamily("Consolas")
    A204.FontFamily = New FontFamily("Consolas") : CAF = ""
    '1     Dimensionen in A203
    For f = 0 To FAA.Count - 1 Step 1
      AA(f) = FAA(f) & "     " : AA(f) = AA(f).Substring(0, 5)
      If f = 0 Then AA(f) &= "= ?" Else AA(f) &= "= "
      If f < FAA.Count - 1 Then AA(f) &= vbLf
      A203.Document.Selection.Text &= AA(f)
      For i = 0 To FAB.Count - 3 Step 3
        If FAA(f) = FAB(i) Then
          CAF &= FAA(f) & " = " & FAB(i + 1) & vbLf
          MAO.Add(Convert.ToInt32(FAB(i + 2)))
          MAP.Add(i) : Exit For : End If : Next : Next
    '2     Dimensionsamen in A204
    A204.Document.Selection.Text += CAF
    '3     Von A108 möglicherweise ausgeblendete A203 und A204 sichtbar machen
    AFAC(A012, A013, A203, A003) : AFAD(A014)
    ''4     Liniebreite
    AIAO(10) : AIAP(10)
  End Sub
  Private Sub EAAB()
    '1     Formelsuchen 1
    CAD = A201.Text : EAAC()
    '2     Kode bearbeiten und Formel suchen
    If A202.Text = "" And FAA.Count > 1 And FAA.Count = MAO.Count Then
      Dim AA, AB As Boolean
      Dim AC As New List(Of String)
      'AC = New List(Of String)
      CAD = ""
      '2.1     Kode ersetzen
      For i = 0 To FAA.Count - 1 Step 1
        AA = False : AB = False
        For j = 0 To FAA.Count - 1 Step 1
          'wird geprüft, ob mit ersetzende Variable auch ersetzbare Variable ist
          If FAF(MAO(i)) = FAA(j) Then AA = True : Exit For
        Next
        'die Kods für Formeln mit ersetzende Variable und ersetzbare Variable zusammen
        'müssen nicht erhaltet werden, sie sind schon fertig in den Listen
        If AA = False And MAO(i) > 0 Then
          If i > 0 Then
            'damit bei mehreren gleichen Nummern nur ersetzbare Variable ausgewählt wird,
            'muss man prüfen, ob es vor oder nach dieser betrachtete aaaag(aacad) Variable
            'noch andere Variablen gleicher Nummern sind. Es wird vor aaaag(aacad) geprüft.
            For k = 0 To i - 1 Step 1
              If MAO(i) = MAO(k) Then AB = True : Exit For
            Next
          End If
          'ersetzbare Variablen werden statt ersetzende ausgewählt
          If AB = False Then AC.Add(FAF(MAO(i)))
        Else
          If FAA(i) <> "θ" And FAA(i) <> "ϕ" Then
            'alle restliche nicht ersetzende Variablen außer θ und ϕ werden ausgewählt
            If FAA(i) = FAF(MAO(i)) Or MAO(i) = 0 Then AC.Add(FAA(i))
          End If
        End If
      Next
      For i = 0 To AC.Count - 1 Step 1
        If AC(i) = "W" And MAO(0) <> 2 Then AC.RemoveAt(i) : AC.Add("W") : Exit For
      Next
      If FAA(0) = "θ" Or FAA(0) = "ϕ" Then
        'Der Winkel wird nach erstes Vektor gesucht, deren im Kode nur eine Komponente ist:
        'dieses Vektor wird in den erste Platz verschoben. Es gibt keine Kods mit ϕ ohne θ.
        For i = 0 To AC.Count - 1 Step 1
          If MAO(i) > 0 Then
            AA = False
            For j = i To AC.Count - 1 Step 1
              If i <> j And MAO(i) = MAO(j) Then AA = True : Exit For
            Next
            If AA = False Then AC.Insert(0, AC(i)) : AC.RemoveAt(i + 1) : Exit For
          End If
        Next
      End If
      If AC.IndexOf(FAF(3)) = -1 Then
        'F Ff |Fn| Frg Frh Frr Ft
        Dim AD As Integer
        Dim AE As Integer
        For i = 0 To AC.Count - 1 Step 1
          If AC(i) = FAF(4) Or AC(i) = FAF(5) Or
                       AC(i) = FAF(6) Or AC(i) = FAF(7) Or
                       AC(i) = FAF(8) Or AC(i) = FAF(9) Then
            AD += 1 : AE = i
          End If
        Next
        If AD = 1 Then AC(AE) = FAF(3)
      End If
      If AC.IndexOf(FAF(13)) = -1 Then
        'Δs: s1 s2
        Dim AD As Integer = AC.IndexOf(FAF(11))
        Dim AE As Integer = AC.IndexOf(FAF(12))
        If AD > -1 And AE > -1 Then
          If AD < AE Then AC(AD) = FAF(13) : AC.RemoveAt(AE)
          If AE < AD Then AC(AE) = FAF(13) : AC.RemoveAt(AD)
        End If
      End If
      For i = 0 To AC.Count - 1 Step 1
        CAD &= AC(i) & " "
      Next
      CAD = CAD.TrimEnd(" ")
      '2.3     Formelsuchen 2
      EAAC()
      '2.3     Extra für Δv (nach früheren Verbot, weil es Formeln gibt mit v1 und v2 ohne von Δv)
      If A202.Text = "" Then
        'Δv: v1 v2
        If AC.IndexOf(FAF(18)) = -1 Then
          Dim AD As Integer = AC.IndexOf(FAF(16))
          Dim AE As Integer = AC.IndexOf(FAF(17))
          If AD > -1 And AE > -1 Then
            If AD < AE Then AC(AD) = FAF(18) : AC.RemoveAt(AE)
            If AE < AD Then AC(AE) = FAF(18) : AC.RemoveAt(AD)
          End If
        End If
        CAD = ""
        For i = 0 To AC.Count - 1 Step 1
          CAD &= AC(i) & " "
        Next
        CAD = CAD.TrimEnd(" ") : EAAC()
      End If
    End If
    '3     Quelle und Formelfertigung
    EAAD()
  End Sub
  Private Sub EAAC()
    '1     Laden von Formeln, wenn sie nicht schon einmal geladen worden sind
    Dim AA() As String = CAD.Split(" ")
    If CAI <> AA(0) Then
      If AA(0) = FAB(0) Then FAC = New String() {
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
         "a Δt Δv", "a = Δv : Δt", "", "23", ""} : CAI = AA(0) ' a => 10074
      If AA(0) = FAB(3) Then FAC = New String() {
         "ax a", "ax = a", "", "0", "",
         "ax a θ", "ax = a cos(θ)", "", "0", "",
         "ax ay θ", "ax = ay : tan(θ)", "", "0", "",
         "ax az ϕ", "ax = az tan(ϕ)", "", "0", "",
         "ax a ay", "ax = √(a ^ 2 - ay ^ 2)", "", "0", "",
         "ax a az", "ax = √(a ^ 2 - az ^ 2)", "", "0", "",
         "ax a θ ϕ", "ax = a cos(θ) sin(ϕ)", "", "0", "",
         "ax ay θ ϕ", "ax = ay sin(ϕ) : tan(θ)", "", "0", "",
         "ax a ay az", "ax = √(a ^ 2 - ay ^ 2 - az ^ 2)", "", "0", ""} : CAI = AA(0) ' ax => 9
      If AA(0) = FAB(6) Then FAC = New String() {
         "ay a", "ay = a", "", "0", "",
         "ay a θ", "ay = a sin(θ)", "", "0", "",
         "ay ax θ", "ay = ax tan(θ)", "", "0", "",
         "ay az θ", "ay = az tan(θ)", "", "0", "",
         "ay a ax", "ay = √(a ^ 2 - ax ^ 2)", "", "0", "",
         "ay a az", "ay = √(a ^ 2 - az ^ 2)", "", "0", "",
         "ay ax θ ϕ", "ay = ax tan(θ) : sin(ϕ)", "", "0", "",
         "ay az θ ϕ", "ay = az tan(θ) : cos(ϕ)", "", "0", "",
         "ay a ax az", "ay = √(a ^ 2 - ax ^ 2 - az ^ 2)", "", "0", ""} : CAI = AA(0) ' ay => 9
      If AA(0) = FAB(9) Then FAC = New String() {
         "az a", "az = a", "", "0", "",
         "az a θ", "az = a cos(θ)", "", "0", "",
         "az ax ϕ", "az = ax : tan(ϕ)", "", "0", "",
         "az ay θ", "az = ay : tan(θ)", "", "0", "",
         "az a ax", "az = √(a ^ 2 - ax ^ 2)", "", "0", "",
         "az a ay", "az = √(a ^ 2 - ay ^ 2)", "", "0", "",
         "az ay θ ϕ", "az = ay cos(ϕ) : tan(θ)", "", "0", "",
         "az a θ ϕ", "az = a cos(θ) cos(ϕ)", "", "0", "",
         "az a ax ay", "az = √(a ^ 2 - ax ^ 2 - ay ^ 2)", "", "0", ""} : CAI = AA(0) ' az => 9
      If AA(0) = FAB(12) Then FAC = New String() {
         "c M m V", "c = m : M : V", "c n V", "50", "",
         "c n V", "c = n : V", "", "45", ""} : CAI = AA(0) ' c => 2
      If AA(0) = FAB(15) Then FAC = New String() {
         "Ek1 Ek2 ΔEk", "Ek1 = Ek2 - ΔEk", "", "37", "",
         "Ek1 Ek2 Ep1 Ep2", "Ek1 = Ek2 + Ep2 - Ep1", "Ek1 Ek2 ΔEp", "39", "",
         "Ek1 Ek2 ΔEp", "Ek1 = Ek2 + ΔEp", "Ek1 Ek2 W", "34", "",
         "Ek1 Ek2 W", "Ek1 = Ek2 - W", "Ek1 Ek2 ΔEk", "33", ""} : CAI = AA(0) ' Ek1 => 4
      If AA(0) = FAB(18) Then FAC = New String() {
         "Ek2 Ek1 ΔEk", "Ek2 = Ek1 + ΔEk", "", "38", "",
         "Ek2 Ek1 Ep1 Ep2", "Ek2 = Ek1 + Ep1 - Ep2", "Ek2 Ek1 ΔEp", "39", "",
         "Ek2 Ek1 ΔEp", "Ek2 = Ek1 - ΔEp", "Ek2 Ek1 W", "34", "",
         "Ek2 Ek1 W", "Ek2 = Ek1 + W", "Ek2 Ek1 ΔEk", "33", ""} : CAI = AA(0) ' Ek2 => 4
      If AA(0) = FAB(21) Then FAC = New String() {
         "ΔEk Ek1 Ek2", "ΔEk = Ek2 - Ek1", "", "36", "",
         "ΔEk Ep1 Ep2", "ΔEk = Ep1 - Ep2", "ΔEk ΔEp", "39", "",
         "ΔEk ΔEp", "ΔEk = -ΔEp", "ΔEk W", "34", "",
         "ΔEk W", "ΔEk = W", "", "33", ""} : CAI = AA(0) ' ΔEk => 4
      If AA(0) = FAB(24) Then FAC = New String() {
         "Ep1 Ep2 Ek1 Ek2", "Ep1 = Ep2 + Ek2 - Ek1", "Ep1 ΔEk Ep2", "36", "",
         "Ep1 ΔEk Ep2", "Ep1 = Ep2 + ΔEk", "Ep1 Ep2 W", "32", "",
         "Ep1 Ep2 ΔEp", "Ep1 = Ep2 - ΔEp", "", "40", "",
         "Ep1 Ep2 W", "Ep1 = Ep2 + W", "Ep1 Ep2 ΔEp", "35", ""} : CAI = AA(0) ' Ep1 => 4
      If AA(0) = FAB(27) Then FAC = New String() {
         "Ep2 Ek1 Ek2 Ep2", "Ep2 = Ep1 + Ek1 - Ek2", "Ep2 ΔEk Ep1", "36", "",
         "Ep2 ΔEk Ep1", "Ep2 = Ep1 - ΔEk", "Ep2 Ep1 W", "32", "",
         "Ep2 Ep1 ΔEp", "Ep2 = Ep1 + ΔEp", "", "41", "",
         "Ep2 Ep1 W", "Ep2 = Ep1 - W", "Ep2 Ep1 ΔEp", "35", ""} : CAI = AA(0) ' Ep2 => 4
      If AA(0) = FAB(30) Then FAC = New String() {
         "ΔEp Ek1 Ek2", "ΔEp = Ek1 - Ek2", "ΔEp ΔEk", "36", "",
         "ΔEp ΔEk", "ΔEp = -ΔEk", "ΔEp W", "32", "",
         "ΔEp Ep1 Ep2", "ΔEp = Ep2 - Ep1", "", "39", "",
         "ΔEp W", "ΔEp = -W", "", "35", ""} : CAI = AA(0) ' ΔEp => 4
      If AA(0) = FAB(33) Then FAC = New String() {
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
         "F Δt {v} W", "F = W : Δt : {v}", "F Δs W", "21", ""} : CAI = AA(0) ' F => 3912
      If AA(0) = FAB(36) Then FAC = New String() {
         "Fx F", "Fx = F", "", "0", "",
         "Fx F θ", "Fx = F cos(θ)", "", "0", "",
         "Fx Fy θ", "Fx = Fy : tan(θ)", "", "0", "",
         "Fx Fz ϕ", "Fx = Fz tan(ϕ)", "", "0", "",
         "Fx F Fy", "Fx = √(F ^ 2 - Fy ^ 2)", "", "0", "",
         "Fx F Fz", "Fx = √(F ^ 2 - Fz ^ 2)", "", "0", "",
         "Fx F θ ϕ", "Fx = F cos(θ) sin(ϕ)", "", "0", "",
         "Fx Fy θ ϕ", "Fx = Fy sin(ϕ) : tan(θ)", "", "0", "",
         "Fx F Fy Fz", "Fx = √(F ^ 2 - Fy ^ 2 - Fz ^ 2)", "", "0", ""} : CAI = AA(0) ' Fx => 9
      If AA(0) = FAB(39) Then FAC = New String() {
         "Fy F", "Fy = F", "", "0", "",
         "Fy F θ", "Fy = F sin(θ)", "", "0", "",
         "Fy Fx θ", "Fy = Fx tan(θ)", "", "0", "",
         "Fy Fz θ", "Fy = Fz tan(θ)", "", "0", "",
         "Fy F Fx", "Fy = √(F ^ 2 - Fx ^ 2)", "", "0", "",
         "Fy F Fz", "Fy = √(F ^ 2 - Fz ^ 2)", "", "0", "",
         "Fy Fx θ ϕ", "Fy = Fx tan(θ) : sin(ϕ)", "", "0", "",
         "Fy Fz θ ϕ", "Fy = Fz tan(θ) : cos(ϕ)", "", "0", "",
         "Fy F Fx Fz", "Fy = √(F ^ 2 - Fx ^ 2 - Fz ^ 2)", "", "0", ""} : CAI = AA(0) ' Fy => 9
      If AA(0) = FAB(42) Then FAC = New String() {
         "Fz F", "Fz = F", "", "0", "",
         "Fz F θ", "Fz = F cos(θ)", "", "0", "",
         "Fz Fx ϕ", "Fz = Fx : tan(ϕ)", "", "0", "",
         "Fz Fy θ", "Fz = Fy : tan(θ)", "", "0", "",
         "Fz F Fx", "Fz = √(F ^ 2 - Fx ^ 2)", "", "0", "",
         "Fz F Fy", "Fz = √(F ^ 2 - Fy ^ 2)", "", "0", "",
         "Fz Fy θ ϕ", "Fz = Fy cos(ϕ) : tan(θ)", "", "0", "",
         "Fz F θ ϕ", "Fz = F cos(θ) cos(ϕ)", "", "0", "",
         "Fz F Fx Fy", "Fz = √(F ^ 2 - Fx ^ 2 - Fy ^ 2)", "", "0", ""} : CAI = AA(0) ' Fz => 9
      If AA(0) = FAB(45) Then FAC = New String() {
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
         "Ff k Δs", "Ff = -k Δs", "", "0", ""} : CAI = AA(0) ' Ff => 196
      If AA(0) = FAB(48) Then FAC = New String() {
         "Ffx Ff", "Ffx = Ff", "", "0", "",
         "Ffx Ff θ", "Ffx = Ff cos(θ)", "", "0", "",
         "Ffx Ffy θ", "Ffx = Ffy : tan(θ)", "", "0", "",
         "Ffx Ffz ϕ", "Ffx = Ffz tan(ϕ)", "", "0", "",
         "Ffx Ff Ffy", "Ffx = √(Ff ^ 2 - Ffy ^ 2)", "", "0", "",
         "Ffx Ff Ffz", "Ffx = √(Ff ^ 2 - Ffz ^ 2)", "", "0", "",
         "Ffx Ff θ ϕ", "Ffx = Ff cos(θ) sin(ϕ)", "", "0", "",
         "Ffx Ffy θ ϕ", "Ffx = Ffy sin(ϕ) : tan(θ)", "", "0", "",
         "Ffx Ff Ffy Ffz", "Ffx = √(Ff ^ 2 - Ffy ^ 2 - Ffz ^ 2)", "", "0", ""} : CAI = AA(0) ' Ffx => 9
      If AA(0) = FAB(51) Then FAC = New String() {
         "Ffy Ff", "Ffy = Ff", "", "0", "",
         "Ffy Ff θ", "Ffy = Ff sin(θ)", "", "0", "",
         "Ffy Ffx θ", "Ffy = Ffx tan(θ)", "", "0", "",
         "Ffy Ffz θ", "Ffy = Ffz tan(θ)", "", "0", "",
         "Ffy Ff Ffx", "Ffy = √(Ff ^ 2 - Ffx ^ 2)", "", "0", "",
         "Ffy Ff Ffz", "Ffy = √(Ff ^ 2 - Ffz ^ 2)", "", "0", "",
         "Ffy Ffx θ ϕ", "Ffy = Ffx tan(θ) : sin(ϕ)", "", "0", "",
         "Ffy Ffz θ ϕ", "Ffy = Ffz tan(θ) : cos(ϕ)", "", "0", "",
         "Ffy Ff Ffx Ffz", "Ffy = √(Ff ^ 2 - Ffx ^ 2 - Ffz ^ 2)", "", "0", ""} : CAI = AA(0) ' Ffy => 9
      If AA(0) = FAB(54) Then FAC = New String() {
         "Ffz Ff", "Ffz = Ff", "", "0", "",
         "Ffz Ff θ", "Ffz = Ff cos(θ)", "", "0", "",
         "Ffz Ffx ϕ", "Ffz = Ffx : tan(ϕ)", "", "0", "",
         "Ffz Ffy θ", "Ffz = Ffy : tan(θ)", "", "0", "",
         "Ffz Ff Ffx", "Ffz = √(Ff ^ 2 - Ffx ^ 2)", "", "0", "",
         "Ffz Ff Ffy", "Ffz = √(Ff ^ 2 - Ffy ^ 2)", "", "0", "",
         "Ffz Ffy θ ϕ", "Ffz = Ffy cos(ϕ) : tan(θ)", "", "0", "",
         "Ffz Ff θ ϕ", "Ffz = Ff cos(θ) cos(ϕ)", "", "0", "",
         "Ffz Ff Ffx Ffy", "Ffz = √(Ff ^ 2 - Ffx ^ 2 - Ffy ^ 2)", "", "0", ""} : CAI = AA(0) ' Ffz => 9
      If AA(0) = FAB(57) Then FAC = New String() {
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
         "|Fn| Frr μr", "|Fn| = Frr : μr", "", "0", ""} : CAI = AA(0) ' |Fn| => 315
      If AA(0) = FAB(60) Then FAC = New String() {
         "Frg F", "Frg = F", "", "0", "",
         "Frg F Ff", "Frg = F - Ff", "", "0", "",
         "Frg F Ff Ft", "Frg = F - Ft - Ff", "", "0", "",
         "Frg F Ft", "Frg = F - Ft", "", "0", "",
         "Frg F Ft k Δs", "Frg = F + k Δs - Ft", "", "0", "",
         "Frg F k Δs", "Frg = F + k Δs", "", "0", "",
         "Frg |Fn| μg", "Frg = μg |Fn|", "", "0", ""} : CAI = AA(0) ' Frg => 105
      If AA(0) = FAB(63) Then FAC = New String() {
         "Frgx Frg", "Frgx = Frg", "", "0", "",
         "Frgx Frg θ", "Frgx = Frg cos(θ)", "", "0", "",
         "Frgx Frgy θ", "Frgx = Frgy : tan(θ)", "", "0", "",
         "Frgx Frgz ϕ", "Frgx = Frgz tan(ϕ)", "", "0", "",
         "Frgx Frg Frgy", "Frgx = √(Frg ^ 2 - Frgy ^ 2)", "", "0", "",
         "Frgx Frg Frgz", "Frgx = √(Frg ^ 2 - Frgz ^ 2)", "", "0", "",
         "Frgx Frg θ ϕ", "Frgx = Frg cos(θ) sin(ϕ)", "", "0", "",
         "Frgx Frgy θ ϕ", "Frgx = Frgy sin(ϕ) : tan(θ)", "", "0", "",
         "Frgx Frg Frgy Frgz", "Frgx = √(Frg ^ 2 - Frgy ^ 2 - Frgz ^ 2)", "", "0", ""} : CAI = AA(0) ' Frgx => 9
      If AA(0) = FAB(66) Then FAC = New String() {
         "Frgy Frg", "Frgy = Frg", "", "0", "",
         "Frgy Frg θ", "Frgy = Frg sin(θ)", "", "0", "",
         "Frgy Frgx θ", "Frgy = Frgx tan(θ)", "", "0", "",
         "Frgy Frgz θ", "Frgy = Frgz tan(θ)", "", "0", "",
         "Frgy Frg Frgx", "Frgy = √(Frg ^ 2 - Frgx ^ 2)", "", "0", "",
         "Frgy Frg Frgz", "Frgy = √(Frg ^ 2 - Frgz ^ 2)", "", "0", "",
         "Frgy Frgx θ ϕ", "Frgy = Frgx tan(θ) : sin(ϕ)", "", "0", "",
         "Frgy Frgz θ ϕ", "Frgy = Frgz tan(θ) : cos(ϕ)", "", "0", "",
         "Frgy Frg Frgx Frgz", "Frgy = √(Frg ^ 2 - Frgx ^ 2 - Frgz ^ 2)", "", "0", ""} : CAI = AA(0) ' Frgy => 9
      If AA(0) = FAB(69) Then FAC = New String() {
         "Frgz Frg", "Frgz = Frg", "", "0", "",
         "Frgz Frg θ", "Frgz = Frg cos(θ)", "", "0", "",
         "Frgz Frgx ϕ", "Frgz = Frgx : tan(ϕ)", "", "0", "",
         "Frgz Frgy θ", "Frgz = Frgy : tan(θ)", "", "0", "",
         "Frgz Frg Frgx", "Frgz = √(Frg ^ 2 - Frgx ^ 2)", "", "0", "",
         "Frgz Frg Frgy", "Frgz = √(Frg ^ 2 - Frgy ^ 2)", "", "0", "",
         "Frgz Frgy θ ϕ", "Frgz = Frgy cos(ϕ) : tan(θ)", "", "0", "",
         "Frgz Frg θ ϕ", "Frgz = Frg cos(θ) cos(ϕ)", "", "0", "",
         "Frgz Frg Frgx Frgy", "Frgz = √(Frg ^ 2 - Frgx ^ 2 - Frgy ^ 2)", "", "0", ""} : CAI = AA(0) ' Frgz => 9
      If AA(0) = FAB(72) Then FAC = New String() {
         "Frh F", "Frh = F", "", "0", "",
         "Frh F Ff", "Frh = F - Ff", "", "0", "",
         "Frh F Ff Ft", "Frh = F - Ft - Ff", "", "0", "",
         "Frh F Ft", "Frh = F - Ft", "", "0", "",
         "Frh F Ft k Δs", "Frh = F + k Δs - Ft", "", "0", "",
         "Frh F k Δs", "Frh = F + k Δs", "", "0", "",
         "Frh |Fn| μh", "Frh = μh |Fn|", "", "0", ""} : CAI = AA(0) ' Frh => 105
      If AA(0) = FAB(75) Then FAC = New String() {
         "Frhx Frh", "Frhx = Frh", "", "0", "",
         "Frhx Frh θ", "Frhx = Frh cos(θ)", "", "0", "",
         "Frhx Frhy θ", "Frhx = Frhy : tan(θ)", "", "0", "",
         "Frhx Frhz ϕ", "Frhx = Frhz tan(ϕ)", "", "0", "",
         "Frhx Frh Frhy", "Frhx = √(Frh ^ 2 - Frhy ^ 2)", "", "0", "",
         "Frhx Frh Frhz", "Frhx = √(Frh ^ 2 - Frhz ^ 2)", "", "0", "",
         "Frhx Frh θ ϕ", "Frhx = Frh cos(θ) sin(ϕ)", "", "0", "",
         "Frhx Frhy θ ϕ", "Frhx = Frhy sin(ϕ) : tan(θ)", "", "0", "",
         "Frhx Frh Frhy Frhz", "Frhx = √(Frh ^ 2 - Frhy ^ 2 - Frhz ^ 2)", "", "0", ""} : CAI = AA(0) ' Frhx => 9
      If AA(0) = FAB(78) Then FAC = New String() {
         "Frhy Frh", "Frhy = Frh", "", "0", "",
         "Frhy Frh θ", "Frhy = Frh sin(θ)", "", "0", "",
         "Frhy Frhx θ", "Frhy = Frhx tan(θ)", "", "0", "",
         "Frhy Frhz θ", "Frhy = Frhz tan(θ)", "", "0", "",
         "Frhy Frh Frhx", "Frhy = √(Frh ^ 2 - Frhx ^ 2)", "", "0", "",
         "Frhy Frh Frhz", "Frhy = √(Frh ^ 2 - Frhz ^ 2)", "", "0", "",
         "Frhy Frhx θ ϕ", "Frhy = Frhx tan(θ) : sin(ϕ)", "", "0", "",
         "Frhy Frhz θ ϕ", "Frhy = Frhz tan(θ) : cos(ϕ)", "", "0", "",
         "Frhy Frh Frhx Frhz", "Frhy = √(Frh ^ 2 - Frhx ^ 2 - Frhz ^ 2)", "", "0", ""} : CAI = AA(0) ' Frhy => 9
      If AA(0) = FAB(81) Then FAC = New String() {
         "Frhz Frh", "Frhz = Frh", "", "0", "",
         "Frhz Frh θ", "Frhz = Frh cos(θ)", "", "0", "",
         "Frhz Frhx ϕ", "Frhz = Frhx : tan(ϕ)", "", "0", "",
         "Frhz Frhy θ", "Frhz = Frhy : tan(θ)", "", "0", "",
         "Frhz Frh Frhx", "Frhz = √(Frh ^ 2 - Frhx ^ 2)", "", "0", "",
         "Frhz Frh Frhy", "Frhz = √(Frh ^ 2 - Frhy ^ 2)", "", "0", "",
         "Frhz Frhy θ ϕ", "Frhz = Frhy cos(ϕ) : tan(θ)", "", "0", "",
         "Frhz Frh θ ϕ", "Frhz = Frh cos(θ) cos(ϕ)", "", "0", "",
         "Frhz Frh Frhx Frhy", "Frhz = √(Frh ^ 2 - Frhx ^ 2 - Frhy ^ 2)", "", "0", ""} : CAI = AA(0) ' Frhz => 9
      If AA(0) = FAB(84) Then FAC = New String() {
         "Frr F", "Frr = F", "", "0", "",
         "Frr F Ff", "Frr = F - Ff", "", "0", "",
         "Frr F Ff Ft", "Frr = F - Ft - Ff", "", "0", "",
         "Frr F Ft", "Frr = F - Ft", "", "0", "",
         "Frr F Ft k Δs", "Frr = F + k Δs - Ft", "", "0", "",
         "Frr F k Δs", "Frr = F + k Δs", "", "0", "",
         "Frr |Fn| μr", "Frr = μr |Fn|", "", "0", ""} : CAI = AA(0) ' Frr => 105
      If AA(0) = FAB(87) Then FAC = New String() {
         "Frrx Frr", "Frrx = Frr", "", "0", "",
         "Frrx Frr θ", "Frrx = Frr cos(θ)", "", "0", "",
         "Frrx Frry θ", "Frrx = Frry : tan(θ)", "", "0", "",
         "Frrx Frrz ϕ", "Frrx = Frrz tan(ϕ)", "", "0", "",
         "Frrx Frr Frry", "Frrx = √(Frr ^ 2 - Frry ^ 2)", "", "0", "",
         "Frrx Frr Frrz", "Frrx = √(Frr ^ 2 - Frrz ^ 2)", "", "0", "",
         "Frrx Frr θ ϕ", "Frrx = Frr cos(θ) sin(ϕ)", "", "0", "",
         "Frrx Frry θ ϕ", "Frrx = Frry sin(ϕ) : tan(θ)", "", "0", "",
         "Frrx Frr Frry Frrz", "Frrx = √(Frr ^ 2 - Frry ^ 2 - Frrz ^ 2)", "", "0", ""} : CAI = AA(0) ' Frrx => 9
      If AA(0) = FAB(90) Then FAC = New String() {
         "Frry Frr", "Frry = Frr", "", "0", "",
         "Frry Frr θ", "Frry = Frr sin(θ)", "", "0", "",
         "Frry Frrx θ", "Frry = Frrx tan(θ)", "", "0", "",
         "Frry Frrz θ", "Frry = Frrz tan(θ)", "", "0", "",
         "Frry Frr Frrx", "Frry = √(Frr ^ 2 - Frrx ^ 2)", "", "0", "",
         "Frry Frr Frrz", "Frry = √(Frr ^ 2 - Frrz ^ 2)", "", "0", "",
         "Frry Frrx θ ϕ", "Frry = Frrx tan(θ) : sin(ϕ)", "", "0", "",
         "Frry Frrz θ ϕ", "Frry = Frrz tan(θ) : cos(ϕ)", "", "0", "",
         "Frry Frr Frrx Frrz", "Frry = √(Frr ^ 2 - Frrx ^ 2 - Frrz ^ 2)", "", "0", ""} : CAI = AA(0) ' Frry => 9
      If AA(0) = FAB(93) Then FAC = New String() {
         "Frrz Frr", "Frrz = Frr", "", "0", "",
         "Frrz Frr θ", "Frrz = Frr cos(θ)", "", "0", "",
         "Frrz Frrx ϕ", "Frrz = Frrx : tan(ϕ)", "", "0", "",
         "Frrz Frry θ", "Frrz = Frry : tan(θ)", "", "0", "",
         "Frrz Frr Frrx", "Frrz = √(Frr ^ 2 - Frrx ^ 2)", "", "0", "",
         "Frrz Frr Frry", "Frrz = √(Frr ^ 2 - Frry ^ 2)", "", "0", "",
         "Frrz Frry θ ϕ", "Frrz = Frry cos(ϕ) : tan(θ)", "", "0", "",
         "Frrz Frr θ ϕ", "Frrz = Frr cos(θ) cos(ϕ)", "", "0", "",
         "Frrz Frr Frrx Frry", "Frrz = √(Frr ^ 2 - Frrx ^ 2 - Frry ^ 2)", "", "0", ""} : CAI = AA(0) ' Frrz => 9
      If AA(0) = FAB(96) Then FAC = New String() {
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
         "Ft F k Δs", "Ft = F + k Δs", "", "0", ""} : CAI = AA(0) ' Ft => 351
      If AA(0) = FAB(99) Then FAC = New String() {
         "Ftx Ft", "Ftx = Ft", "", "0", "",
         "Ftx Ft θ", "Ftx = Ft cos(θ)", "", "0", "",
         "Ftx Fty θ", "Ftx = Fty : tan(θ)", "", "0", "",
         "Ftx Ftz ϕ", "Ftx = Ftz tan(ϕ)", "", "0", "",
         "Ftx Ft Fty", "Ftx = √(Ft ^ 2 - Fty ^ 2)", "", "0", "",
         "Ftx Ft Ftz", "Ftx = √(Ft ^ 2 - Ftz ^ 2)", "", "0", "",
         "Ftx Ft θ ϕ", "Ftx = Ft cos(θ) sin(ϕ)", "", "0", "",
         "Ftx Fty θ ϕ", "Ftx = Fty sin(ϕ) : tan(θ)", "", "0", "",
         "Ftx Ft Fty Ftz", "Ftx = √(Ft ^ 2 - Fty ^ 2 - Ftz ^ 2)", "", "0", ""} : CAI = AA(0) ' Ftx => 9
      If AA(0) = FAB(102) Then FAC = New String() {
         "Fty Ft", "Fty = Ft", "", "0", "",
         "Fty Ft θ", "Fty = Ft sin(θ)", "", "0", "",
         "Fty Ftx θ", "Fty = Ftx tan(θ)", "", "0", "",
         "Fty Ftz θ", "Fty = Ftz tan(θ)", "", "0", "",
         "Fty Ft Ftx", "Fty = √(Ft ^ 2 - Ftx ^ 2)", "", "0", "",
         "Fty Ft Ftz", "Fty = √(Ft ^ 2 - Ftz ^ 2)", "", "0", "",
         "Fty Ftx θ ϕ", "Fty = Ftx tan(θ) : sin(ϕ)", "", "0", "",
         "Fty Ftz θ ϕ", "Fty = Ftz tan(θ) : cos(ϕ)", "", "0", "",
         "Fty Ft Ftx Ftz", "Fty = √(Ft ^ 2 - Ftx ^ 2 - Ftz ^ 2)", "", "0", ""} : CAI = AA(0) ' Fty => 9
      If AA(0) = FAB(105) Then FAC = New String() {
         "Ftz Ft", "Ftz = Ft", "", "0", "",
         "Ftz Ft θ", "Ftz = Ft cos(θ)", "", "0", "",
         "Ftz Ftx ϕ", "Ftz = Ftx : tan(ϕ)", "", "0", "",
         "Ftz Fty θ", "Ftz = Fty : tan(θ)", "", "0", "",
         "Ftz Ft Ftx", "Ftz = √(Ft ^ 2 - Ftx ^ 2)", "", "0", "",
         "Ftz Ft Fty", "Ftz = √(Ft ^ 2 - Fty ^ 2)", "", "0", "",
         "Ftz Fty θ ϕ", "Ftz = Fty cos(ϕ) : tan(θ)", "", "0", "",
         "Ftz Ft θ ϕ", "Ftz = Ft cos(θ) cos(ϕ)", "", "0", "",
         "Ftz Ft Ftx Fty", "Ftz = √(Ft ^ 2 - Ftx ^ 2 - Fty ^ 2)", "", "0", ""} : CAI = AA(0) ' Ftz => 9
      If AA(0) = FAB(108) Then FAC = New String() {
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
         "k Δt {v} W", "k = -W : (Δt {v}) ^ 2", "k Δs W", "21", ""} : CAI = AA(0) ' k => 4396
      If AA(0) = FAB(111) Then FAC = New String() {
         "M c m V", "M = m : c : V", "M m n", "46", "",
         "M m n", "M = m : n", "", "48", ""} : CAI = AA(0) ' M => 2
      If AA(0) = FAB(114) Then FAC = New String() {
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
         "m Δv {v} W", "m = W : Δv : {v}", "m a Δt {v} W", "23", ""} : CAI = AA(0) ' m => 8754
      If AA(0) = FAB(117) Then FAC = New String() {
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
         "μg |Fn| Δt {v} W", "μg = W : |Fn| : Δt : {v}", "μg |Fn| Δs W", "21", ""} : CAI = AA(0) ' μg => 2718
      If AA(0) = FAB(120) Then FAC = New String() {
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
         "μh |Fn| Δt {v} W", "μh = W : |Fn| : Δt : {v}", "μh |Fn| Δs W", "21", ""} : CAI = AA(0) ' μh => 2718
      If AA(0) = FAB(123) Then FAC = New String() {
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
         "μr |Fn| Δt {v} W", "μr = W : |Fn| : Δt : {v}", "μr |Fn| Δs W", "21", ""} : CAI = AA(0) ' μr => 2718
      If AA(0) = FAB(126) Then FAC = New String() {
         "n c V", "n = c V", "", "45", "",
         "n M m", "n = m : M", "", "50", ""} : CAI = AA(0) ' n => 2
      If AA(0) = FAB(129) Then FAC = New String() {
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
         "P Δt W", "P = W : Δt", "", "42", ""} : CAI = AA(0) ' P => 6932
      If AA(0) = FAB(132) Then FAC = New String() {
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
         "p px py pz", "p = √(px ^ 2 + py ^ 2 + pz ^ 2)", "", "0", ""} : CAI = AA(0) ' p => 77
      If AA(0) = FAB(135) Then FAC = New String() {
         "px p", "px = p", "", "0", "",
         "px p θ", "px = p cos(θ)", "", "0", "",
         "px py θ", "px = py : tan(θ)", "", "0", "",
         "px pz ϕ", "px = pz tan(ϕ)", "", "0", "",
         "px p py", "px = √(p ^ 2 - py ^ 2)", "", "0", "",
         "px p pz", "px = √(p ^ 2 - pz ^ 2)", "", "0", "",
         "px p θ ϕ", "px = p cos(θ) sin(ϕ)", "", "0", "",
         "px py θ ϕ", "px = py sin(ϕ) : tan(θ)", "", "0", "",
         "px p py pz", "px = √(p ^ 2 - py ^ 2 - pz ^ 2)", "", "0", ""} : CAI = AA(0) ' px => 9
      If AA(0) = FAB(138) Then FAC = New String() {
         "py p", "py = p", "", "0", "",
         "py p θ", "py = p sin(θ)", "", "0", "",
         "py px θ", "py = px tan(θ)", "", "0", "",
         "py pz θ", "py = pz tan(θ)", "", "0", "",
         "py p px", "py = √(p ^ 2 - px ^ 2)", "", "0", "",
         "py p pz", "py = √(p ^ 2 - pz ^ 2)", "", "0", "",
         "py px θ ϕ", "py = px tan(θ) : sin(ϕ)", "", "0", "",
         "py pz θ ϕ", "py = pz tan(θ) : cos(ϕ)", "", "0", "",
         "py p px pz", "py = √(p ^ 2 - px ^ 2 - pz ^ 2)", "", "0", ""} : CAI = AA(0) ' py => 9
      If AA(0) = FAB(141) Then FAC = New String() {
         "pz p", "pz = p", "", "0", "",
         "pz p θ", "pz = p cos(θ)", "", "0", "",
         "pz px ϕ", "pz = px : tan(ϕ)", "", "0", "",
         "pz py θ", "pz = py : tan(θ)", "", "0", "",
         "pz p px", "pz = √(p ^ 2 - px ^ 2)", "", "0", "",
         "pz p py", "pz = √(p ^ 2 - py ^ 2)", "", "0", "",
         "pz py θ ϕ", "pz = py cos(ϕ) : tan(θ)", "", "0", "",
         "pz p θ ϕ", "pz = p cos(θ) cos(ϕ)", "", "0", "",
         "pz p px py", "pz = √(p ^ 2 - px ^ 2 - py ^ 2)", "", "0", ""} : CAI = AA(0) ' pz => 9
      If AA(0) = FAB(144) Then FAC = New String() {
         "s1 s2 Δs", "s1 = s2 - Δs", "", "2", "1"} : CAI = AA(0) ' s1 => 13
      If AA(0) = FAB(147) Then FAC = New String() {
         "sx1 s1", "sx1 = s1", "", "0", "",
         "sx1 s1 θ", "sx1 = s1 cos(θ)", "", "0", "",
         "sx1 sy1 θ", "sx1 = sy1 : tan(θ)", "", "0", "",
         "sx1 sz1 ϕ", "sx1 = sz1 tan(ϕ)", "", "0", "",
         "sx1 s1 sy1", "sx1 = √(s1 ^ 2 - sy1 ^ 2)", "", "0", "",
         "sx1 s1 sz1", "sx1 = √(s1 ^ 2 - sz1 ^ 2)", "", "0", "",
         "sx1 s1 θ ϕ", "sx1 = s1 cos(θ) sin(ϕ)", "", "0", "",
         "sx1 sy1 θ ϕ", "sx1 = sy1 sin(ϕ) : tan(θ)", "", "0", "",
         "sx1 s1 sy1 sz1", "sx1 = √(s1 ^ 2 - sy1 ^ 2 - sz1 ^ 2)", "", "0", ""} : CAI = AA(0) ' sx1 => 9
      If AA(0) = FAB(150) Then FAC = New String() {
         "sy1 s1", "sy1 = s1", "", "0", "",
         "sy1 s1 θ", "sy1 = s1 sin(θ)", "", "0", "",
         "sy1 sx1 θ", "sy1 = sx1 tan(θ)", "", "0", "",
         "sy1 sz1 θ", "sy1 = sz1 tan(θ)", "", "0", "",
         "sy1 s1 sx1", "sy1 = √(s1 ^ 2 - sx1 ^ 2)", "", "0", "",
         "sy1 s1 sz1", "sy1 = √(s1 ^ 2 - sz1 ^ 2)", "", "0", "",
         "sy1 sx1 θ ϕ", "sy1 = sx1 tan(θ) : sin(ϕ)", "", "0", "",
         "sy1 sz1 θ ϕ", "sy1 = sz1 tan(θ) : cos(ϕ)", "", "0", "",
         "sy1 s1 sx1 sz1", "sy1 = √(s1 ^ 2 - sx1 ^ 2 - sz1 ^ 2)", "", "0", ""} : CAI = AA(0) ' sy1 => 9
      If AA(0) = FAB(153) Then FAC = New String() {
         "sz1 s1", "sz1 = s1", "", "0", "",
         "sz1 s1 θ", "sz1 = s1 cos(θ)", "", "0", "",
         "sz1 sx1 ϕ", "sz1 = sx1 : tan(ϕ)", "", "0", "",
         "sz1 sy1 θ", "sz1 = sy1 : tan(θ)", "", "0", "",
         "sz1 s1 sx1", "sz1 = √(s1 ^ 2 - sx1 ^ 2)", "", "0", "",
         "sz1 s1 sy1", "sz1 = √(s1 ^ 2 - sy1 ^ 2)", "", "0", "",
         "sz1 sy1 θ ϕ", "sz1 = sy1 cos(ϕ) : tan(θ)", "", "0", "",
         "sz1 s1 θ ϕ", "sz1 = s1 cos(θ) cos(ϕ)", "", "0", "",
         "sz1 s1 sx1 sy1", "sz1 = √(s1 ^ 2 - sx1 ^ 2 - sy1 ^ 2)", "", "0", ""} : CAI = AA(0) ' sz1 => 9
      If AA(0) = FAB(156) Then FAC = New String() {
         "s2 s1 Δs", "s2 = s1 + Δs", "", "3", "1"} : CAI = AA(0) ' s2 => 13
      If AA(0) = FAB(159) Then FAC = New String() {
         "sx2 s2", "sx2 = s2", "", "0", "",
         "sx2 s2 θ", "sx2 = s2 cos(θ)", "", "0", "",
         "sx2 sy2 θ", "sx2 = sy2 : tan(θ)", "", "0", "",
         "sx2 sz2 ϕ", "sx2 = sz2 tan(ϕ)", "", "0", "",
         "sx2 s2 sy2", "sx2 = √(s2 ^ 2 - sy2 ^ 2)", "", "0", "",
         "sx2 s2 sz2", "sx2 = √(s2 ^ 2 - sz2 ^ 2)", "", "0", "",
         "sx2 s2 θ ϕ", "sx2 = s2 cos(θ) sin(ϕ)", "", "0", "",
         "sx2 sy2 θ ϕ", "sx2 = sy2 sin(ϕ) : tan(θ)", "", "0", "",
         "sx2 s2 sy2 sz2", "sx2 = √(s2 ^ 2 - sy2 ^ 2 - sz2 ^ 2)", "", "0", ""} : CAI = AA(0) ' sx2 => 9
      If AA(0) = FAB(162) Then FAC = New String() {
         "sy2 s2", "sy2 = s2", "", "0", "",
         "sy2 s2 θ", "sy2 = s2 sin(θ)", "", "0", "",
         "sy2 sx2 θ", "sy2 = sx2 tan(θ)", "", "0", "",
         "sy2 sz2 θ", "sy2 = sz2 tan(θ)", "", "0", "",
         "sy2 s2 sx2", "sy2 = √(s2 ^ 2 - sx2 ^ 2)", "", "0", "",
         "sy2 s2 sz2", "sy2 = √(s2 ^ 2 - sz2 ^ 2)", "", "0", "",
         "sy2 sx2 θ ϕ", "sy2 = sx2 tan(θ) : sin(ϕ)", "", "0", "",
         "sy2 sz2 θ ϕ", "sy2 = sz2 tan(θ) : cos(ϕ)", "", "0", "",
         "sy2 s2 sx2 sz2", "sy2 = √(s2 ^ 2 - sx2 ^ 2 - sz2 ^ 2)", "", "0", ""} : CAI = AA(0) ' sy2 => 9
      If AA(0) = FAB(165) Then FAC = New String() {
         "sz2 s2", "sz2 = s2", "", "0", "",
         "sz2 s2 θ", "sz2 = s2 cos(θ)", "", "0", "",
         "sz2 sx2 ϕ", "sz2 = sx2 : tan(ϕ)", "", "0", "",
         "sz2 sy2 θ", "sz2 = sy2 : tan(θ)", "", "0", "",
         "sz2 s2 sx2", "sz2 = √(s2 ^ 2 - sx2 ^ 2)", "", "0", "",
         "sz2 s2 sy2", "sz2 = √(s2 ^ 2 - sy2 ^ 2)", "", "0", "",
         "sz2 sy2 θ ϕ", "sz2 = sy2 cos(ϕ) : tan(θ)", "", "0", "",
         "sz2 s2 θ ϕ", "sz2 = s2 cos(θ) cos(ϕ)", "", "0", "",
         "sz2 s2 sx2 sy2", "sz2 = √(s2 ^ 2 - sx2 ^ 2 - sy2 ^ 2)", "", "0", ""} : CAI = AA(0) ' sz2 => 9
      If AA(0) = FAB(168) Then FAC = New String() {
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
         "Δs Δt {v}", "Δs = Δt {v}", "", "20", ""} : CAI = AA(0) ' Δs => 6789
      If AA(0) = FAB(171) Then FAC = New String() {
         "Δsx Δs", "Δsx = Δs", "", "0", "",
         "Δsx Δs θ", "Δsx = Δs cos(θ)", "", "0", "",
         "Δsx Δsy θ", "Δsx = Δsy : tan(θ)", "", "0", "",
         "Δsx Δsz ϕ", "Δsx = Δsz tan(ϕ)", "", "0", "",
         "Δsx Δs Δsy", "Δsx = √(Δs ^ 2 - Δsy ^ 2)", "", "0", "",
         "Δsx Δs Δsz", "Δsx = √(Δs ^ 2 - Δsz ^ 2)", "", "0", "",
         "Δsx Δs θ ϕ", "Δsx = Δs cos(θ) sin(ϕ)", "", "0", "",
         "Δsx Δsy θ ϕ", "Δsx = Δsy sin(ϕ) : tan(θ)", "", "0", "",
         "Δsx Δs Δsy Δsz", "Δsx = √(Δs ^ 2 - Δsy ^ 2 - Δsz ^ 2)", "", "0", ""} : CAI = AA(0) ' Δsx => 9
      If AA(0) = FAB(174) Then FAC = New String() {
         "Δsy Δs", "Δsy = Δs", "", "0", "",
         "Δsy Δs θ", "Δsy = Δs sin(θ)", "", "0", "",
         "Δsy Δsx θ", "Δsy = Δsx tan(θ)", "", "0", "",
         "Δsy Δsz θ", "Δsy = Δsz tan(θ)", "", "0", "",
         "Δsy Δs Δsx", "Δsy = √(Δs ^ 2 - Δsx ^ 2)", "", "0", "",
         "Δsy Δs Δsz", "Δsy = √(Δs ^ 2 - Δsz ^ 2)", "", "0", "",
         "Δsy Δsx θ ϕ", "Δsy = Δsx tan(θ) : sin(ϕ)", "", "0", "",
         "Δsy Δsz θ ϕ", "Δsy = Δsz tan(θ) : cos(ϕ)", "", "0", "",
         "Δsy Δs Δsx Δsz", "Δsy = √(Δs ^ 2 - Δsx ^ 2 - Δsz ^ 2)", "", "0", ""} : CAI = AA(0) ' Δsy => 9
      If AA(0) = FAB(177) Then FAC = New String() {
         "Δsz Δs", "Δsz = Δs", "", "0", "",
         "Δsz Δs θ", "Δsz = Δs cos(θ)", "", "0", "",
         "Δsz Δsx ϕ", "Δsz = Δsx : tan(ϕ)", "", "0", "",
         "Δsz Δsy θ", "Δsz = Δsy : tan(θ)", "", "0", "",
         "Δsz Δs Δsx", "Δsz = √(Δs ^ 2 - Δsx ^ 2)", "", "0", "",
         "Δsz Δs Δsy", "Δsz = √(Δs ^ 2 - Δsy ^ 2)", "", "0", "",
         "Δsz Δsy θ ϕ", "Δsz = Δsy cos(ϕ) : tan(θ)", "", "0", "",
         "Δsz Δs θ ϕ", "Δsz = Δs cos(θ) cos(ϕ)", "", "0", "",
         "Δsz Δs Δsx Δsy", "Δsz = √(Δs ^ 2 - Δsx ^ 2 - Δsy ^ 2)", "", "0", ""} : CAI = AA(0) ' Δsz => 9
      If AA(0) = FAB(180) Then FAC = New String() {
         "t1 t2 Δt", "t1 = t2 - Δt", "", "5", "2"} : CAI = AA(0) ' t1 => 1
      If AA(0) = FAB(183) Then FAC = New String() {
         "t2 t1 Δt", "t2 = t1 + Δt", "", "6", "2"} : CAI = AA(0) ' t2 => 1
      If AA(0) = FAB(186) Then FAC = New String() {
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
         "Δt t1 t2", "Δt = t2 - t1", "", "4", "2"} : CAI = AA(0) ' Δt => 10047
      If AA(0) = FAB(189) Then FAC = New String() {
         "V c n", "V = n : c", "", "47", "",
         "V c M m", "V = m : c : M", "V c n", "50", ""} : CAI = AA(0) ' V => 2
      If AA(0) = FAB(192) Then FAC = New String() {
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
         "v vx vy vz", "v = √(vx ^ 2 + vy ^ 2 + vz ^ 2)", "", "0", ""} : CAI = AA(0) ' v => 77
      If AA(0) = FAB(195) Then FAC = New String() {
         "vx v", "vx = v", "", "0", "",
         "vx v θ", "vx = v cos(θ)", "", "0", "",
         "vx vy θ", "vx = vy : tan(θ)", "", "0", "",
         "vx vz ϕ", "vx = vz tan(ϕ)", "", "0", "",
         "vx v vy", "vx = √(v ^ 2 - vy ^ 2)", "", "0", "",
         "vx v vz", "vx = √(v ^ 2 - vz ^ 2)", "", "0", "",
         "vx v θ ϕ", "vx = v cos(θ) sin(ϕ)", "", "0", "",
         "vx vy θ ϕ", "vx = vy sin(ϕ) : tan(θ)", "", "0", "",
         "vx v vy vz", "vx = √(v ^ 2 - vy ^ 2 - vz ^ 2)", "", "0", ""} : CAI = AA(0) ' vx => 9
      If AA(0) = FAB(198) Then FAC = New String() {
         "vy v", "vy = v", "", "0", "",
         "vy v θ", "vy = v sin(θ)", "", "0", "",
         "vy vx θ", "vy = vx tan(θ)", "", "0", "",
         "vy vz θ", "vy = vz tan(θ)", "", "0", "",
         "vy v vx", "vy = √(v ^ 2 - vx ^ 2)", "", "0", "",
         "vy v vz", "vy = √(v ^ 2 - vz ^ 2)", "", "0", "",
         "vy vx θ ϕ", "vy = vx tan(θ) : sin(ϕ)", "", "0", "",
         "vy vz θ ϕ", "vy = vz tan(θ) : cos(ϕ)", "", "0", "",
         "vy v vx vz", "vy = √(v ^ 2 - vx ^ 2 - vz ^ 2)", "", "0", ""} : CAI = AA(0) ' vy => 9
      If AA(0) = FAB(201) Then FAC = New String() {
         "vz v", "vz = v", "", "0", "",
         "vz v θ", "vz = v cos(θ)", "", "0", "",
         "vz vx ϕ", "vz = vx : tan(ϕ)", "", "0", "",
         "vz vy θ", "vz = vy : tan(θ)", "", "0", "",
         "vz v vx", "vz = √(v ^ 2 - vx ^ 2)", "", "0", "",
         "vz v vy", "vz = √(v ^ 2 - vy ^ 2)", "", "0", "",
         "vz vy θ ϕ", "vz = vy cos(ϕ) : tan(θ)", "", "0", "",
         "vz v θ ϕ", "vz = v cos(θ) cos(ϕ)", "", "0", "",
         "vz v vx vy", "vz = √(v ^ 2 - vx ^ 2 - vy ^ 2)", "", "0", ""} : CAI = AA(0) ' vz => 9
      If AA(0) = FAB(204) Then FAC = New String() {
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
         "v1 Δv {v}", "v1 = {v} - Δv : 2", "v1 v2 Δv", "12", "3"} : CAI = AA(0) ' v1 => 8047
      If AA(0) = FAB(207) Then FAC = New String() {
         "vx1 v1", "vx1 = v1", "", "0", "",
         "vx1 v1 θ", "vx1 = v1 cos(θ)", "", "0", "",
         "vx1 vy1 θ", "vx1 = vy1 : tan(θ)", "", "0", "",
         "vx1 vz1 ϕ", "vx1 = vz1 tan(ϕ)", "", "0", "",
         "vx1 v1 vy1", "vx1 = √(v1 ^ 2 - vy1 ^ 2)", "", "0", "",
         "vx1 v1 vz1", "vx1 = √(v1 ^ 2 - vz1 ^ 2)", "", "0", "",
         "vx1 v1 θ ϕ", "vx1 = v1 cos(θ) sin(ϕ)", "", "0", "",
         "vx1 vy1 θ ϕ", "vx1 = vy1 sin(ϕ) : tan(θ)", "", "0", "",
         "vx1 v1 vy1 vz1", "vx1 = √(v1 ^ 2 - vy1 ^ 2 - vz1 ^ 2)", "", "0", ""} : CAI = AA(0) ' vx1 => 9
      If AA(0) = FAB(210) Then FAC = New String() {
         "vy1 v1", "vy1 = v1", "", "0", "",
         "vy1 v1 θ", "vy1 = v1 sin(θ)", "", "0", "",
         "vy1 vx1 θ", "vy1 = vx1 tan(θ)", "", "0", "",
         "vy1 vz1 θ", "vy1 = vz1 tan(θ)", "", "0", "",
         "vy1 v1 vx1", "vy1 = √(v1 ^ 2 - vx1 ^ 2)", "", "0", "",
         "vy1 v1 vz1", "vy1 = √(v1 ^ 2 - vz1 ^ 2)", "", "0", "",
         "vy1 vx1 θ ϕ", "vy1 = vx1 tan(θ) : sin(ϕ)", "", "0", "",
         "vy1 vz1 θ ϕ", "vy1 = vz1 tan(θ) : cos(ϕ)", "", "0", "",
         "vy1 v1 vx1 vz1", "vy1 = √(v1 ^ 2 - vx1 ^ 2 - vz1 ^ 2)", "", "0", ""} : CAI = AA(0) ' vy1 => 9
      If AA(0) = FAB(213) Then FAC = New String() {
         "vz1 v1", "vz1 = v1", "", "0", "",
         "vz1 v1 θ", "vz1 = v1 cos(θ)", "", "0", "",
         "vz1 vx1 ϕ", "vz1 = vx1 : tan(ϕ)", "", "0", "",
         "vz1 vy1 θ", "vz1 = vy1 : tan(θ)", "", "0", "",
         "vz1 v1 vx1", "vz1 = √(v1 ^ 2 - vx1 ^ 2)", "", "0", "",
         "vz1 v1 vy1", "vz1 = √(v1 ^ 2 - vy1 ^ 2)", "", "0", "",
         "vz1 vy1 θ ϕ", "vz1 = vy1 cos(ϕ) : tan(θ)", "", "0", "",
         "vz1 v1 θ ϕ", "vz1 = v1 cos(θ) cos(ϕ)", "", "0", "",
         "vz1 v1 vx1 vy1", "vz1 = √(v1 ^ 2 - vx1 ^ 2 - vy1 ^ 2)", "", "0", ""} : CAI = AA(0) ' vz1 => 9
      If AA(0) = FAB(216) Then FAC = New String() {
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
         "v2 Δv {v}", "v2 = {v} + Δv : 2", "v2 v1 Δv", "11", "3"} : CAI = AA(0) ' v2 => 8047
      If AA(0) = FAB(219) Then FAC = New String() {
         "vx2 v2", "vx2 = v2", "", "0", "",
         "vx2 v2 θ", "vx2 = v2 cos(θ)", "", "0", "",
         "vx2 vy2 θ", "vx2 = vy2 : tan(θ)", "", "0", "",
         "vx2 vz2 ϕ", "vx2 = vz2 tan(ϕ)", "", "0", "",
         "vx2 v2 vy2", "vx2 = √(v2 ^ 2 - vy2 ^ 2)", "", "0", "",
         "vx2 v2 vz2", "vx2 = √(v2 ^ 2 - vz2 ^ 2)", "", "0", "",
         "vx2 v2 θ ϕ", "vx2 = v2 cos(θ) sin(ϕ)", "", "0", "",
         "vx2 vy2 θ ϕ", "vx2 = vy2 sin(ϕ) : tan(θ)", "", "0", "",
         "vx2 v2 vy2 vz2", "vx2 = √(v2 ^ 2 - vy2 ^ 2 - vz2 ^ 2)", "", "0", ""} : CAI = AA(0) ' vx2 => 9
      If AA(0) = FAB(222) Then FAC = New String() {
         "vy2 v2", "vy2 = v2", "", "0", "",
         "vy2 v2 θ", "vy2 = v2 sin(θ)", "", "0", "",
         "vy2 vx2 θ", "vy2 = vx2 tan(θ)", "", "0", "",
         "vy2 vz2 θ", "vy2 = vz2 tan(θ)", "", "0", "",
         "vy2 v2 vx2", "vy2 = √(v2 ^ 2 - vx2 ^ 2)", "", "0", "",
         "vy2 v2 vz2", "vy2 = √(v2 ^ 2 - vz2 ^ 2)", "", "0", "",
         "vy2 vx2 θ ϕ", "vy2 = vx2 tan(θ) : sin(ϕ)", "", "0", "",
         "vy2 vz2 θ ϕ", "vy2 = vz2 tan(θ) : cos(ϕ)", "", "0", "",
         "vy2 v2 vx2 vz2", "vy2 = √(v2 ^ 2 - vx2 ^ 2 - vz2 ^ 2)", "", "0", ""} : CAI = AA(0) ' vy2 => 9
      If AA(0) = FAB(225) Then FAC = New String() {
         "vz2 v2", "vz2 = v2", "", "0", "",
         "vz2 v2 θ", "vz2 = v2 cos(θ)", "", "0", "",
         "vz2 vx2 ϕ", "vz2 = vx2 : tan(ϕ)", "", "0", "",
         "vz2 vy2 θ", "vz2 = vy2 : tan(θ)", "", "0", "",
         "vz2 v2 vx2", "vz2 = √(v2 ^ 2 - vx2 ^ 2)", "", "0", "",
         "vz2 v2 vy2", "vz2 = √(v2 ^ 2 - vy2 ^ 2)", "", "0", "",
         "vz2 vy2 θ ϕ", "vz2 = vy2 cos(ϕ) : tan(θ)", "", "0", "",
         "vz2 v2 θ ϕ", "vz2 = v2 cos(θ) cos(ϕ)", "", "0", "",
         "vz2 v2 vx2 vy2", "vz2 = √(v2 ^ 2 - vx2 ^ 2 - vy2 ^ 2)", "", "0", ""} : CAI = AA(0) ' vz2 => 9
      If AA(0) = FAB(228) Then FAC = New String() {
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
         "Δv Δvx Δvy Δvz", "Δv = √(Δvx ^ 2 + Δvy ^ 2 + Δvz ^ 2)", "", "0", ""} : CAI = AA(0) ' Δv => 6798
      If AA(0) = FAB(231) Then FAC = New String() {
         "Δvx Δv", "Δvx = Δv", "", "0", "",
         "Δvx Δv θ", "Δvx = Δv cos(θ)", "", "0", "",
         "Δvx Δvy θ", "Δvx = Δvy : tan(θ)", "", "0", "",
         "Δvx Δvz ϕ", "Δvx = Δvz tan(ϕ)", "", "0", "",
         "Δvx Δv Δvy", "Δvx = √(Δv ^ 2 - Δvy ^ 2)", "", "0", "",
         "Δvx Δv Δvz", "Δvx = √(Δv ^ 2 - Δvz ^ 2)", "", "0", "",
         "Δvx Δv θ ϕ", "Δvx = Δv cos(θ) sin(ϕ)", "", "0", "",
         "Δvx Δvy θ ϕ", "Δvx = Δvy sin(ϕ) : tan(θ)", "", "0", "",
         "Δvx Δv Δvy Δvz", "Δvx = √(Δv ^ 2 - Δvy ^ 2 - Δvz ^ 2)", "", "0", ""} : CAI = AA(0) ' Δvx => 9
      If AA(0) = FAB(234) Then FAC = New String() {
         "Δvy Δv", "Δvy = Δv", "", "0", "",
         "Δvy Δv θ", "Δvy = Δv sin(θ)", "", "0", "",
         "Δvy Δvx θ", "Δvy = Δvx tan(θ)", "", "0", "",
         "Δvy Δvz θ", "Δvy = Δvz tan(θ)", "", "0", "",
         "Δvy Δv Δvx", "Δvy = √(Δv ^ 2 - Δvx ^ 2)", "", "0", "",
         "Δvy Δv Δvz", "Δvy = √(Δv ^ 2 - Δvz ^ 2)", "", "0", "",
         "Δvy Δvx θ ϕ", "Δvy = Δvx tan(θ) : sin(ϕ)", "", "0", "",
         "Δvy Δvz θ ϕ", "Δvy = Δvz tan(θ) : cos(ϕ)", "", "0", "",
         "Δvy Δv Δvx Δvz", "Δvy = √(Δv ^ 2 - Δvx ^ 2 - Δvz ^ 2)", "", "0", ""} : CAI = AA(0) ' Δvy => 9
      If AA(0) = FAB(237) Then FAC = New String() {
         "Δvz Δv", "Δvz = Δv", "", "0", "",
         "Δvz Δv θ", "Δvz = Δv cos(θ)", "", "0", "",
         "Δvz Δvx ϕ", "Δvz = Δvx : tan(ϕ)", "", "0", "",
         "Δvz Δvy θ", "Δvz = Δvy : tan(θ)", "", "0", "",
         "Δvz Δv Δvx", "Δvz = √(Δv ^ 2 - Δvx ^ 2)", "", "0", "",
         "Δvz Δv Δvy", "Δvz = √(Δv ^ 2 - Δvy ^ 2)", "", "0", "",
         "Δvz Δvy θ ϕ", "Δvz = Δvy cos(ϕ) : tan(θ)", "", "0", "",
         "Δvz Δv θ ϕ", "Δvz = Δv cos(θ) cos(ϕ)", "", "0", "",
         "Δvz Δv Δvx Δvy", "Δvz = √(Δv ^ 2 - Δvx ^ 2 - Δvy ^ 2)", "", "0", ""} : CAI = AA(0) ' Δvz => 9
      If AA(0) = FAB(240) Then FAC = New String() {
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
         "{v} {vx} {vy} {vz}", "{v} = √({vx} ^ 2 + {vy} ^ 2 + {vz} ^ 2)", "", "0", ""} : CAI = AA(0) ' {v} => 3600
      If AA(0) = FAB(243) Then FAC = New String() {
         "{vx} {v}", "{vx} = {v}", "", "0", "",
         "{vx} {v} θ", "{vx} = {v} cos(θ)", "", "0", "",
         "{vx} {vy} θ", "{vx} = {vy} : tan(θ)", "", "0", "",
         "{vx} {vz} ϕ", "{vx} = {vz} tan(ϕ)", "", "0", "",
         "{vx} {v} {vy}", "{vx} = √({v} ^ 2 - {vy} ^ 2)", "", "0", "",
         "{vx} {v} {vz}", "{vx} = √({v} ^ 2 - {vz} ^ 2)", "", "0", "",
         "{vx} {v} θ ϕ", "{vx} = {v} cos(θ) sin(ϕ)", "", "0", "",
         "{vx} {vy} θ ϕ", "{vx} = {vy} sin(ϕ) : tan(θ)", "", "0", "",
         "{vx} {v} {vy} {vz}", "{vx} = √({v} ^ 2 - {vy} ^ 2 - {vz} ^ 2)", "", "0", ""} : CAI = AA(0) ' {vx} => 9
      If AA(0) = FAB(246) Then FAC = New String() {
         "{vy} {v}", "{vy} = {v}", "", "0", "",
         "{vy} {v} θ", "{vy} = {v} sin(θ)", "", "0", "",
         "{vy} {vx} θ", "{vy} = {vx} tan(θ)", "", "0", "",
         "{vy} {vz} θ", "{vy} = {vz} tan(θ)", "", "0", "",
         "{vy} {v} {vx}", "{vy} = √({v} ^ 2 - {vx} ^ 2)", "", "0", "",
         "{vy} {v} {vz}", "{vy} = √({v} ^ 2 - {vz} ^ 2)", "", "0", "",
         "{vy} {vx} θ ϕ", "{vy} = {vx} tan(θ) : sin(ϕ)", "", "0", "",
         "{vy} {vz} θ ϕ", "{vy} = {vz} tan(θ) : cos(ϕ)", "", "0", "",
         "{vy} {v} {vx} {vz}", "{vy} = √({v} ^ 2 - {vx} ^ 2 - {vz} ^ 2)", "", "0", ""} : CAI = AA(0) ' {vy} => 9
      If AA(0) = FAB(249) Then FAC = New String() {
         "{vz} {v}", "{vz} = {v}", "", "0", "",
         "{vz} {v} θ", "{vz} = {v} cos(θ)", "", "0", "",
         "{vz} {vx} ϕ", "{vz} = {vx} : tan(ϕ)", "", "0", "",
         "{vz} {vy} θ", "{vz} = {vy} : tan(θ)", "", "0", "",
         "{vz} {v} {vx}", "{vz} = √({v} ^ 2 - {vx} ^ 2)", "", "0", "",
         "{vz} {v} {vy}", "{vz} = √({v} ^ 2 - {vy} ^ 2)", "", "0", "",
         "{vz} {vy} θ ϕ", "{vz} = {vy} cos(ϕ) : tan(θ)", "", "0", "",
         "{vz} {v} θ ϕ", "{vz} = {v} cos(θ) cos(ϕ)", "", "0", "",
         "{vz} {v} {vx} {vy}", "{vz} = √({v} ^ 2 - {vx} ^ 2 - {vy} ^ 2)", "", "0", ""} : CAI = AA(0) ' {vz} => 9
      If AA(0) = FAB(252) Then FAC = New String() {
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
         "W P Δt", "W = P Δt", "", "44", ""} : CAI = AA(0) ' W => 13534
      If AA(0) = FAB(255) Then FAC = New String() {
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
         "θ {vy} {vz} ϕ", "θ = atan({vy} cos(ϕ) : {vz})", "", "0", ""} : CAI = AA(0) ' θ => 63
      If AA(0) = FAB(258) Then FAC = New String() {
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
         "ϕ {vx} {vz}", "ϕ = atan({vx} : {vz})", "", "0", ""} : CAI = AA(0) ' ϕ => 35
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
    End If
    '2     Für Vorschläge, Formeln und Formelnquelle
    If FAA.Count > 1 Then
      For i = 0 To FAC.Count - 5 Step 5
        If CAD = FAC(i) Then A202.Text = FAC(i + 1) : CAH = FAC(i + 4)
      Next
    End If
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
  Private Sub EAAD()
    If A202.Text = "" Then Exit Sub
    Dim aa As String
    Dim ab As String = ""
    Dim ac As Integer = 0
    Dim ad As Integer = 0
    Dim ae As Integer
    Dim ah As Boolean
    Dim ai As Boolean
    Dim aj As New List(Of String)
    Dim ak As New List(Of String)
    CAC = "" : CAE = "" : CAG = ""
    aa = A202.Text : FAD = New String(19) {}
    For i = 0 To 19 Step 1
      FAD(i) = ""
    Next
    '1     Dimensionsgruppen bestimmen
    For i = 0 To FAA.Count - 1 Step 1
      If MAO(i) > 0 Then FAD(MAO(i)) &= FAA(i) & " "
      If FAA(i) = "θ" Then ah = True
      If FAA(i) = "ϕ" Then ai = True
    Next
    '2     Den Kode trimmen
    For i = 1 To 19 Step 1
      If FAD(i) <> "" Then FAD(i) = FAD(i).TrimEnd(" ")
    Next
    '3     Quellenformeln finden
    Do
      ad += 1
      '3.1     Nächsten Quellenformel finden
      For j = 0 To FAC.Count - 5 Step 5
        If ad = 1 And FAC(j + 1) = aa Then aa = FAC(j + 2) : ab = FAC(j + 1) : ac = Convert.ToInt32(FAC(j + 3)) : Exit For
        If ad > 1 And FAC(j + 0) = aa Then aa = FAC(j + 2) : ab = FAC(j + 1) : ac = Convert.ToInt32(FAC(j + 3)) : Exit For
      Next
      aj.Add(ab) : ak.Add(FAE(ac))
      '3.2     Wenn es keine Quellenformel mehr gibt, beenden
      If aa = "" Then Exit Do
      If ad = 20000 Then Exit Sub
    Loop
    '4     Ersetzen der Formel
    If A201.Text <> CAD Then
      Dim aacaa() As String
      aacaa = CAD.Split(" ")
      For i = 1 To FAF.Count - 1 Step 1
        If aacaa(0) = FAF(i) Then ae = i : Exit For
      Next
      '4.1     Linke Seite der Formel
      If MAO(0) = 4 Then EBAD(4, aj, ak, "F", "Ff", "")
      If MAO(0) = 9 Then EBAD(9, aj, ak, "F", "Ft", "")
      If MAO(0) = 6 Then EBAD(6, aj, ak, "F", "Frg", "")
      If MAO(0) = 7 Then EBAD(7, aj, ak, "F", "Frh", "")
      If MAO(0) = 8 Then EBAD(8, aj, ak, "F", "Frr", "")
      If MAO(0) = 2 Then EBAD(2, aj, ak, "W", "ΔEk", "")
      If MAO(0) = 2 Then EBAD(2, aj, ak, "W", "ΔEp", "-")
      If MAO(0) = 2 Then EBAE(2, aj, ak, "W", "Ek1", "Ek2")
      If MAO(0) = 2 Then EBAE(2, aj, ak, "W", "Ep2", "Ep1")
      If MAO(0) = 14 Then EBAE(14, aj, ak, "Δt", "t1", "t2")
      If ae = 1 Then EBAH(1, ah, ai, aj, ak, "a", "ax", "ay", "az")
      If ae = 3 Then EBAH(3, ah, ai, aj, ak, "F", "Fx", "Fy", "Fz")
      If ae = 4 Then EBAH(4, ah, ai, aj, ak, "Ff", "Ffx", "Ffy", "Ffz")
      If ae = 6 Then EBAH(6, ah, ai, aj, ak, "Frg", "Frgx", "Frgy", "Frgz")
      If ae = 7 Then EBAH(7, ah, ai, aj, ak, "Frh", "Frhx", "Frhy", "Frhz")
      If ae = 8 Then EBAH(8, ah, ai, aj, ak, "Frr", "Frrx", "Frry", "Frrz")
      If ae = 9 Then EBAH(9, ah, ai, aj, ak, "Ft", "Ftx", "Fty", "Ftz")
      If ae = 10 Then EBAH(10, ah, ai, aj, ak, "p", "px", "py", "pz")
      If ae = 13 Then EBAH(13, ah, ai, aj, ak, "Δs", "Δsx", "Δsy", "Δsz")
      If ae = 15 Then EBAH(15, ah, ai, aj, ak, "v", "vx", "vy", "vz")
      If ae = 18 Then EBAH(18, ah, ai, aj, ak, "Δv", "Δvx", "Δvy", "Δvz")
      If ae = 19 Then EBAH(19, ah, ai, aj, ak, "{v}", "{vx}", "{vy}", "{vz}")
      EBAG(11, ah, ai, aj, ak, "Δs", "s1", "s2", "sx1", "sx2", "sy1", "sy2", "sz1", "sz2")
      EBAG(16, ah, ai, aj, ak, "Δv", "v1", "v2", "vx1", "vx2", "vy1", "vy2", "vz1", "vz2")
      '4.2     Linke Seite der Formel: Ersetzungsdefinitionsformel
      If CAE <> "" Then CAG = CAE & vbLf & CAC & "   =>   " & CAE & vbLf & CAG
      '4.3     Rechte Seite der Formel
      If MAO(0) <> 4 And FAD(4) <> "" Then EBAA(4, "F", "Ff", "")
      If MAO(0) <> 9 And FAD(9) <> "" Then EBAA(9, "F", "Ft", "")
      If MAO(0) <> 6 And FAD(6) <> "" Then EBAA(6, "F", "Frg", "")
      If MAO(0) <> 7 And FAD(7) <> "" Then EBAA(7, "F", "Frh", "")
      If MAO(0) <> 8 And FAD(8) <> "" Then EBAA(8, "F", "Frr", "")
      If MAO(0) <> 2 And FAD(2) <> "" Then EBAA(2, "W", "ΔEk", "")
      If MAO(0) <> 2 And FAD(2) <> "" Then EBAA(2, "W", "ΔEp", "-")
      If MAO(0) <> 2 And FAD(2) <> "" Then EBAB(2, "W", "Ek1", "Ek2", "")
      If MAO(0) <> 2 And FAD(2) <> "" Then EBAB(2, "W", "Ep1", "Ep2", ".")
      If MAO(0) <> 14 And FAD(14) <> "" Then EBAB(14, "Δt", "t1", "t2", "")
      If MAO(0) <> 1 And FAD(1) <> "" Then EBAF(1, ah, ai, "a", "ax", "ay", "az")
      If MAO(0) <> 3 And FAD(3) <> "" Then EBAF(3, ah, ai, "F", "Fx", "Fy", "Fz")
      If MAO(0) <> 4 And FAD(4) <> "" Then EBAF(4, ah, ai, "Ff", "Ffx", "Ffy", "Ffz")
      If MAO(0) <> 6 And FAD(6) <> "" Then EBAF(6, ah, ai, "Frg", "Frgx", "Frgy", "Frgz")
      If MAO(0) <> 7 And FAD(7) <> "" Then EBAF(7, ah, ai, "Frh", "Frhx", "Frhy", "Frhz")
      If MAO(0) <> 8 And FAD(8) <> "" Then EBAF(8, ah, ai, "Frr", "Frrx", "Frry", "Frrz")
      If MAO(0) <> 9 And FAD(9) <> "" Then EBAF(9, ah, ai, "Ft", "Ftx", "Fty", "Ftz")
      If MAO(0) <> 10 And FAD(10) <> "" Then EBAF(10, ah, ai, "p", "px", "py", "pz")
      If MAO(0) <> 13 And FAD(13) <> "" Then EBAF(13, ah, ai, "Δs", "Δsx", "Δsy", "Δsz")
      If MAO(0) <> 15 And FAD(15) <> "" Then EBAF(15, ah, ai, "v", "vx", "vy", "vz")
      If MAO(0) <> 18 And FAD(18) <> "" Then EBAF(18, ah, ai, "Δv", "Δvx", "Δvy", "Δvz")
      If MAO(0) <> 19 And FAD(19) <> "" Then EBAF(19, ah, ai, "{v}", "{vx}", "{vy}", "{vz}")
      EBAC(11, ah, ai, "Δs", "s1", "s2", "sx1", "sx2", "sy1", "sy2", "sz1", "sz2")
      EBAC(16, ah, ai, "Δv", "v1", "v2", "vx1", "vx2", "vy1", "vy2", "vz1", "vz2")
    End If
    '5     Wenn Formel nicht ersetzt wird
    If CAG = "" Then
      For i = aj.Count - 1 To 0 Step -1
        CAG &= aj(i) & vbLf & ak(i) & vbLf
      Next
    End If
    '6     aabac in TB1 anzeigen
    Dim aaaal() As String
    aaaal = CAG.TrimEnd(vbLf).Split(vbLf)
    A202.Text = aaaal(aaaal.Count - 2)
  End Sub
  Private Sub EAAE()
    'Eingaben in Formel einsetzen. (Fehler wird angezeigt)
    '1     Deklaration
    Dim aa, ab() As String : AIBA() : AIBB()
    N_ = False ' Eingabeneingangsprüfer zurücksetzen
    '2     Die Zeilen von E1 trennen
    aa = A203.Document.Selection.Text
    aa = aa.TrimEnd(vbCr) : ab = aa.Split(vbCr)
    '3     Aufhebung der Selection
    A203.Document.Selection.StartPosition =
      A203.Document.Selection.StoryLength
    '4     Die Eingaben von Zeilen trennen
    For f = 1 To ab.Count - 1 Step 1
      ab(f) = ab(f).Remove(0, 6)
      ab(f) = ab(f).TrimStart(" ")
      ab(f) = ab(f).TrimEnd(" ")
      ab(f) = "(" & ab(f) & ")"
    Next
    CAA = A202.Text
    '5     Eingaben einsetzen
    For i = 1 To FAA.Count - 1 Step 1
      For j = _FC.Count - 1 To 0 Step -1
        ' Mit dem Vermeiden des Einsetzen kleiner Var in größere in CAA
        If FAA(i) = _FC(j) Then CAA = CAA.Replace(_FC(j), ab(i)) : Exit For
      Next
    Next
    '6     Fertiger Ausdruck in mathematischer Funktion rechnen
    DAAB() : N_ = True
  End Sub
#End Region ' *****
#Region "E-AB"
  Private Sub EBAA(a As Integer, ParamArray b() As String)
    Dim aa(), ab As String
    If FAD(a) = b(1) And FAA(0) <> b(1) Then
      'Speziell für F: es darf in der Formel nur eine Kraft enthalten, um ihn in F einzusetzen
      If a < 10 And a <> 5 And a > 2 Then
        For i = 3 To 9 Step 1
          If a <> i And FAD(i) <> "" Then Exit Sub
        Next
      End If
      ab = CAG.TrimEnd(vbLf) : aa = ab.Split(vbLf) : ab = aa(aa.Count - 2).Replace(b(0), b(2) & b(1))
      CAG &= ab & vbLf & b(0) & " = " & b(2) & b(1) & "   =>  " & b(0) & " = " & b(2) & b(1) & vbLf
    End If
  End Sub
  Private Sub EBAB(ByVal a As Integer, ParamArray b() As String)
    Dim aa(), ab As String : Dim ac As String = ""
    If FAD(a) = b(1) & " " & b(2) And FAA(0) <> b(1) Then
      ab = CAG.TrimEnd(vbLf) : aa = ab.Split(vbLf)
      If b(3) = "" Then ac = b(2) & " - " & b(1)
      If b(3) = "." Then ac = b(1) & " - " & b(2)
      ab = aa(aa.Count - 2).Replace(b(0), "(" & ac & ")")
      CAG &= ab & vbLf & b(0) & " = " & ac & "   =>   " & b(0) & " = " & ac & "" & vbLf
    End If
  End Sub
  Private Sub EBAC(a As Integer, b As Boolean, c As Boolean, ParamArray d() As String)
    Dim aa(), ab As String : Dim ac As Boolean
    If FAA(0) <> d(0) And FAA(0) <> d(1) And FAA(0) <> d(2) And FAA(0) <> d(3) And FAA(0) <> d(4) And
            FAA(0) <> d(5) And FAA(0) <> d(6) And FAA(0) <> d(7) And FAA(0) <> d(8) Then
      ab = CAG.TrimEnd(vbLf) : aa = ab.Split(vbLf) : If aa.Count > 1 Then ab = aa(aa.Count - 2)
      If a = 16 Then
        'Prüfen, ob in Kode Δv ist
        If FAD(18) = "" Then ' wenn Δv nur bei der Bearbeitung erhalten ist
          For i = 0 To A202.Text.Length - 2 Step 1
            If A202.Text.Substring(i, 2) = "Δv" Then ac = True : Exit For
          Next
        End If
        'v1 oder v2 enthaltene Formel
        If MAO(0) = 16 And FAD(17) = "" Then EBAF(16, b, c, "v1", "vx1", "vy1", "vz1")
        If MAO(0) = 17 And FAD(16) = "" Then EBAF(17, b, c, "v2", "vx2", "vy2", "vz2")
        'v1 und v2 enthaltene Formel
        If ac = False Then
          If MAO(0) = 16 And FAD(17) <> "" Then EBAF(16, b, c, "v1", "vx1", "vy1", "vz1")
          If MAO(0) = 17 And FAD(16) <> "" Then EBAF(17, b, c, "v2", "vx2", "vy2", "vz2")
        End If
      End If
      If a = 11 Or ac = True Then
        'ΔAv = Av2 - Av1
        If FAD(a) <> "" And FAD(a + 1) <> "" Then
          CAC &= ab.Replace(d(0), "(" & d(2) & " - " & d(1) & ")") & vbLf &
                        d(0) & " = " & d(2) & " - " & d(1) & "   =>  " & d(0) & " = " & d(2) & " - " & d(1) & vbLf
          EBAF(a, b, c, d(1), d(3), d(5), d(7)) : EBAF(a + 1, b, c, d(2), d(4), d(6), d(8))
        End If
      End If
    End If
  End Sub
  Private Sub EBAD(a As Integer, b As List(Of String), c As List(Of String), ParamArray d() As String)
    'A = B
    If FAA(0) = d(1) And FAD(a) = d(1) Then
      'Speziell für F: es darf in der Formel nur eine Kraft enthalten, um ihn in F einzusetzen
      If a < 10 And a <> 5 And a > 2 Then
        For i = 3 To 9 Step 1
          If a <> i And FAD(i) <> "" Then Exit Sub
        Next
      End If
      For i = b.Count - 1 To 0 Step -1
        CAG &= d(1) & " = " & d(2) & b(i).Replace(d(0) & " = ", "") & vbLf & c(i) & vbLf
      Next
      CAC = d(0) & " = " & d(2) & d(1) : CAE = d(1) & " = " & d(2) & d(0)
    End If
  End Sub
  Private Sub EBAE(a As Integer, b As List(Of String), c As List(Of String), ParamArray d() As String)
    'A1 = A2 - ΔA
    If FAA(0) = d(1) And FAD(a) = d(1) & " " & d(2) Then
      For i = b.Count - 1 To 0 Step -1
        CAG &= d(1) & " = " & d(2) & " - (" & b(i).Replace(d(0) & " = ", "") & ")" & vbLf & c(i) & vbLf
      Next
      CAC = d(0) & " = " & d(2) & " - " & d(1) : CAE = d(1) & " = " & d(2) & " - " & d(0)
    End If
    'A2 = A1 + ΔA
    If FAA(0) = d(2) And FAD(a) = d(2) & " " & d(1) Then
      For i = b.Count - 1 To 0 Step -1
        CAG &= d(2) & " = " & d(1) & " + (" & b(i).Replace(d(0) & " = ", "") & ")" & vbLf & c(i) & vbLf
      Next
      CAC = d(0) & " = " & d(2) & " - " & d(1) : CAE = d(2) & " = " & d(1) & " + " & d(0)
    End If
  End Sub
  Private Sub EBAF(ByVal a As Integer, ByVal b As Boolean, ByVal c As Boolean, ParamArray d() As String)
    Dim aa(), ab, ac As String
    If FAA(0) <> d(0) And FAA(0) <> d(1) And FAA(0) <> d(2) And FAA(0) <> d(3) And FAA(0) <> "θ" And FAA(0) <> "ϕ" Then
      ab = CAG.TrimEnd(vbLf) : aa = ab.Split(vbLf) : If aa.Count > 1 Then ab = aa(aa.Count - 2)
      If b = False And c = False Then
        '(A) = Ax
        If FAD(a) = d(1) Then
          CAG &= ab.Replace(d(0), d(1)) & vbLf & d(0) & " = " & d(1) & "   =>   " & d(0) & " = " & d(1) & vbLf
        End If
        '(A) = Ay
        If FAD(a) = d(2) Then
          CAG &= ab.Replace(d(0), d(2)) & vbLf & d(0) & " = " & d(2) & "   =>   " & d(0) & " = " & d(2) & vbLf
        End If
        '(A) = Az
        If FAD(a) = d(3) Then
          CAG &= ab.Replace(d(0), d(3)) & vbLf & d(0) & " = " & d(3) & "   =>   " & d(0) & " = " & d(3) & vbLf
        End If
        '(A) = √(Ax ^ 2 + Ay ^ 2)
        If FAD(a) = d(1) & " " & d(2) Then
          ac = "√(" & d(1) & " ^ 2 + " & d(2) & " ^ 2)"
          CAG &= ab.Replace(d(0), ac) & vbLf & d(0) & " = " & ac & "   =>   " & d(0) & " = " & ac & vbLf
        End If
        '(A) = √(Ax ^ 2 + Az ^ 2)
        If FAD(a) = d(1) & " " & d(3) Then
          ac = "√(" & d(1) & " ^ 2 + " & d(3) & " ^ 2)"
          CAG &= ab.Replace(d(0), ac) & vbLf & d(0) & " = " & ac & "   =>   " & d(0) & " = " & ac & vbLf
        End If
        '(A) = √(Ay ^ 2 + Az ^ 2)
        If FAD(a) = d(2) & " " & d(3) Then
          ac = "√(" & d(2) & " ^ 2 + " & d(3) & " ^ 2)"
          CAG &= ab.Replace(d(0), ac) & vbLf & d(0) & " = " & ac & "   =>   " & d(0) & " = " & ac & vbLf
        End If
        '(A) = √(Ax ^ 2 + Ay ^ 2 + Az ^ 2)
        If FAD(a) = d(1) & " " & d(2) & " " & d(3) Then
          ac = "√(" & d(1) & " ^ 2 + " & d(2) & " ^ 2 + " & d(3) & " ^ 2)"
          CAG &= ab.Replace(d(0), ac) & vbLf & d(0) & " = " & ac & "   =>   " & d(0) & " = " & ac & vbLf
        End If
      End If
      If b = True And c = False Then
        '(A) = Ax : cos θ
        If FAD(a) = d(1) Then
          ac = d(1) & " : cos(θ)"
          CAG &= ab.Replace(d(0), "(" & ac & ")") & vbLf & d(0) & " = " & ac & "   =>   " & d(0) & " = " & ac & vbLf
        End If
        '(A) = Ay : sin θ
        If FAD(a) = d(2) Then
          ac = d(2) & " : sin(θ)"
          CAG &= ab.Replace(d(0), "(" & ac & ")") & vbLf & d(0) & " = " & ac & "   =>   " & d(0) & " = " & ac & vbLf
        End If
        '(A) = Az : cos θ
        If FAD(a) = d(3) Then
          ac = d(3) & " : cos(θ)"
          CAG &= ab.Replace(d(0), "(" & ac & ")") & vbLf & d(0) & " = " & ac & "   =>   " & d(0) & " = " & ac & vbLf
        End If
      End If
      If b = True And c = True Then
        '(A) = Ax : cos θ : sin ϕ
        If FAD(a) = d(1) Then
          ac = d(1) & " : cos(θ) : sin(ϕ)"
          CAG &= ab.Replace(d(0), "(" & ac & ")") & vbLf & d(0) & " = " & ac & "   =>   " & d(0) & " = " & ac & vbLf
        End If
        '(A) = Az : cos θ : cos ϕ
        If FAD(a) = d(3) Then
          ac = d(3) & " : cos(θ) : cos(ϕ)"
          CAG &= ab.Replace(d(0), "(" & ac & ")") & vbLf & d(0) & " = " & ac & "   =>   " & d(0) & " = " & ac & vbLf
        End If
      End If
    End If
  End Sub
  Private Sub EBAG(a As Integer, b As Boolean, c As Boolean, d As List(Of String), f As List(Of String), ParamArray g() As String)
    Dim aa As Boolean
    Dim ab As New List(Of String)
    If a = 16 Then
      'Prüfen, ob in Kode Δv ist
      If FAD(18) = "" Then ' wenn Δv nur bei der Bearbeitung erhalten ist
        For i = 0 To A202.Text.Length - 2 Step 1
          If A202.Text.Substring(i, 2) = "Δv" Then aa = True : Exit For
        Next
      End If
      'v1 oder v2 enthaltene Formel
      If MAO(0) = 16 And FAD(17) = "" Then EBAH(16, b, c, d, f, "v1", "vx1", "vy1", "vz1")
      If MAO(0) = 17 And FAD(16) = "" Then EBAH(17, b, c, d, f, "v2", "vx2", "vy2", "vz2")
      'v1 und v2 enthaltene Formel
      If aa = False Then
        If MAO(0) = 16 And FAD(17) <> "" Then EBAH(16, b, c, d, f, "v1", "vx1", "vy1", "vz1")
        If MAO(0) = 17 And FAD(16) <> "" Then EBAH(17, b, c, d, f, "v2", "vx2", "vy2", "vz2")
      End If
    End If
    If a = 11 Or aa = True Then
      'Av1 = Av2 - ΔAv
      If FAA(0) = g(1) Or FAA(0) = g(3) Or FAA(0) = g(5) Or FAA(0) = g(7) Then
        If FAD(a + 1) <> "" Then
          For i = 0 To d.Count - 1 Step 1
            ab.Add(g(1) & " = " & g(2) & " - (" & d(i).Replace(g(0) & " = ", "") & ")")
          Next
          CAC = g(0) & " = " & g(2) & " - " & g(1)
          CAE = g(1) & " = " & g(2) & " - " & g(0)
          EBAH(a, b, c, ab, f, g(1), g(3), g(5), g(7))
        End If
      End If
      'Av2 = Av1 + ΔAv
      If FAA(0) = g(2) Or FAA(0) = g(4) Or FAA(0) = g(6) Or FAA(0) = g(8) Then
        If FAD(a) <> "" Then
          For i = 0 To d.Count - 1 Step 1
            ab.Add(g(2) & " = " & g(1) & " + (" & d(i).Replace(g(0) & " = ", "") & ")")
          Next
          CAC = g(0) & " = " & g(2) & " - " & g(1)
          CAE = g(2) & " = " & g(1) & " + " & g(0)
          EBAH(a + 1, b, c, ab, f, g(2), g(4), g(6), g(8))
        End If
      End If
    End If
  End Sub
  Private Sub EBAH(a As Integer, b As Boolean, c As Boolean, d As List(Of String), f As List(Of String), ParamArray g() As String)
    If CAC = "" Then CAE = g(0) Else CAC &= ", " : CAE = "(" & CAE.Remove(0, 5) & ")"
    If FAA(0) = g(1) Then
      If b = False And c = False Then
        'Ax = (A)
        If FAD(a) = g(1) Then
          For i = d.Count - 1 To 0 Step -1
            CAG &= d(i).Replace(g(0), g(1)) & vbLf & f(i) & vbLf
          Next
          CAC &= g(0) & " = " & g(1)
          CAE = g(1) & " = " & CAE
          'Δs = s2 - s1, s1 = sx1   =>   sx1 = s2 - Δs
        End If
        'Ax = √((A) ^ 2 - Ay ^ 2)
        If FAD(a) = g(1) & " " & g(2) Then
          For i = d.Count - 1 To 0 Step -1
            CAG &= g(1) & " = √((" & d(i).Replace(g(0) & " = ", "") & ") ^ 2 - " & g(2) & " ^ 2)" & vbLf & f(i) & vbLf
          Next
          CAC &= g(0) & " = √(" & g(1) & " ^ 2 + " & g(2) & " ^ 2)"
          CAE = g(1) & " = √(" & CAE & " ^ 2 - " & g(2) & " ^ 2)"
        End If
        'Ax = √((A) ^ 2 - Az ^ 2)
        If FAD(a) = g(1) & " " & g(3) Then
          For i = d.Count - 1 To 0 Step -1
            CAG &= g(1) & " = √((" & d(i).Replace(g(0) & " = ", "") & ") ^ 2 - " & g(3) & " ^ 2)" & vbLf & f(i) & vbLf
          Next
          CAC &= g(0) & " = √(" & g(1) & " ^ 2 + " & g(3) & " ^ 2)"
          CAE = g(1) & " = √(" & CAE & " ^ 2 - " & g(3) & " ^ 2)"
        End If
        'Ax = √((A) ^ 2 - Ay ^ 2 - Az ^ 2)
        If FAD(a) = g(1) & " " & g(2) & " " & g(3) Then
          For i = d.Count - 1 To 0 Step -1
            CAG &= g(1) & " = √((" & d(i).Replace(g(0) & " = ", "") & ") ^ 2 - " & g(2) & " ^ 2 - " & g(3) & " ^ 2)" & vbLf & f(i) & vbLf
          Next
          CAC &= g(0) & " = √(" & g(1) & " ^ 2 + " & g(2) & " ^ 2 + " & g(3) & " ^ 2)"
          CAE = g(1) & " = √(" & CAE & " ^ 2 - " & g(2) & " ^ 2 - " & g(3) & " ^ 2)"
        End If
      End If
      If b = True And c = False Then
        'Ax = (A) cos θ
        If FAD(a) = g(1) Then
          For i = d.Count - 1 To 0 Step -1
            CAG &= g(1) & " = (" & d(i).Replace(g(0) & " = ", "") & ") · cos(θ)" & vbLf & f(i) & vbLf
          Next
          CAC &= g(0) & " = " & g(1) & " : cos(θ)"
          CAC = g(1) & " = " & CAE & " cos(θ)"
        End If
      End If
      If b = True And c = True Then
        'Ax = (A) cos θ sin ϕ
        If FAD(a) = g(1) Then
          For i = d.Count - 1 To 0 Step -1
            CAG &= g(1) & " = (" & d(i).Replace(g(0) & " = ", "") & ") · cos(θ) · sin(ϕ)" & vbLf & f(i) & vbLf
          Next
          CAC &= g(0) & " = " & g(1) & " : cos(θ) : sin(ϕ)"
          CAE = g(1) & " = " & CAE & " cos(θ) sin(ϕ)"
        End If
      End If
    End If
    If FAA(0) = g(2) Then
      If b = False And c = False Then
        'Ay = (A)
        If FAD(a) = g(2) Then
          For i = d.Count - 1 To 0 Step -1
            CAG &= d(i).Replace(g(0), g(2)) & vbLf & f(i) & vbLf
          Next
          CAC &= g(0) & " = " & g(2)
          CAE = g(2) & " = " & CAE
        End If
        'Ay = √((A) ^ 2 - Ax ^ 2)
        If FAD(a) = g(2) & " " & g(1) Then
          For i = d.Count - 1 To 0 Step -1
            CAG &= g(2) & " = √((" & d(i).Replace(g(0) & " = ", "") & ") ^ 2 - " & g(1) & " ^ 2)" & vbLf & f(i) & vbLf
          Next
          CAC &= g(0) & " = √(" & g(1) & " ^ 2 + " & g(2) & " ^ 2)"
          CAE = g(2) & " = √(" & CAE & " ^ 2 - " & g(1) & " ^ 2)"
        End If
        'Ay = √((A) ^ 2 - Az ^ 2)
        If FAD(a) = g(2) & " " & g(3) Then
          For i = d.Count - 1 To 0 Step -1
            CAG &= g(2) & " = √((" & d(i).Replace(g(0) & " = ", "") & ") ^ 2 - " & g(3) & " ^ 2)" & vbLf & f(i) & vbLf
          Next
          CAC &= g(0) & " = √(" & g(2) & " ^ 2 + " & g(3) & " ^ 2)"
          CAE = g(2) & " = √(" & CAE & " ^ 2 - " & g(3) & " ^ 2)"
        End If
        'Ay = √((A) ^ 2 - Ax ^ 2 - Az ^ 2)
        If FAD(a) = g(2) & " " & g(1) & " " & g(3) Then
          For i = d.Count - 1 To 0 Step -1
            CAG &= g(2) & " = √((" & d(i).Replace(g(0) & " = ", "") & ") ^ 2 - " & g(1) & " ^ 2 - " & g(3) & " ^ 2)" & vbLf & f(i) & vbLf
          Next
          CAC &= g(0) & " = √(" & g(1) & " ^ 2 + " & g(2) & " ^ 2 + " & g(3) & " ^ 2)"
          CAE = g(2) & " = √(" & CAE & " ^ 2 - " & g(1) & " ^ 2 - " & g(3) & " ^ 2)"
        End If
      End If
      If b = True And c = False Then
        'Ay = (A) sin θ
        If FAD(a) = g(2) Then
          For i = d.Count - 1 To 0 Step -1
            CAG &= g(2) & " = (" & d(i).Replace(g(0) & " = ", "") & ") · sin(θ)" & vbLf & f(i) & vbLf
          Next
          CAC &= g(0) & " = " & g(2) & " : sin(θ)"
          CAE = g(2) & " = " & CAE & " sin(θ)"
        End If
      End If
    End If
    If FAA(0) = g(3) Then
      If b = False And c = False Then
        'Az = (A)
        If FAD(a) = g(3) Then
          For i = d.Count - 1 To 0 Step -1
            CAG &= d(i).Replace(g(0), g(3)) & vbLf & f(i) & vbLf
          Next
          CAC &= g(0) & " = " & g(3)
          CAE = g(3) & " = " & CAE
        End If
        'Az = √((A) ^ 2 - Ax ^ 2)
        If FAD(a) = g(3) & " " & g(1) Then
          For i = d.Count - 1 To 0 Step -1
            CAG &= g(3) & " = √((" & d(i).Replace(g(0) & " = ", "") & ") ^ 2 - " & g(1) & " ^ 2)" & vbLf & f(i) & vbLf
          Next
          CAC &= g(0) & " = √(" & g(1) & " ^ 2 + " & g(3) & " ^ 2)"
          CAE = g(3) & " = √(" & CAE & " ^ 2 - " & g(1) & " ^ 2)"
        End If
        'Az = √((A) ^ 2 - Ay ^ 2)
        If FAD(a) = g(3) & " " & g(2) Then
          For i = d.Count - 1 To 0 Step -1
            CAG &= g(3) & " = √((" & d(i).Replace(g(0) & " = ", "") & ") ^ 2 - " & g(2) & " ^ 2)" & vbLf & f(i) & vbLf
          Next
          CAC &= g(0) & " = √(" & g(2) & " ^ 2 + " & g(3) & " ^ 2)"
          CAE = g(3) & " = √(" & CAE & " ^ 2 - " & g(2) & " ^ 2)"
        End If
        'Az = √((A) ^ 2 - Ax ^ 2 - Ay ^ 2)
        If FAD(a) = g(3) & " " & g(1) & " " & g(2) Then
          For i = d.Count - 1 To 0 Step -1
            CAG &= g(3) & " = √((" & d(i).Replace(g(0) & " = ", "") & ") ^ 2 - " & g(1) & " ^ 2 - " & g(2) & " ^ 2)" & vbLf & f(i) & vbLf
          Next
          CAC &= g(0) & " = √(" & g(1) & " ^ 2 + " & g(2) & " ^ 2 + " & g(3) & " ^ 2)"
          CAE = g(3) & " = √(" & CAE & " ^ 2 - " & g(1) & " ^ 2 - " & g(2) & " ^ 2)"
        End If
      End If
      If b = True And c = False Then
        'Az = (A) cos θ
        If FAD(a) = g(3) Then
          For i = d.Count - 1 To 0 Step -1
            CAG &= g(3) & " = (" & d(i).Replace(g(0) & " = ", "") & ") · cos(θ)" & vbLf & f(i) & vbLf
          Next
          CAC &= g(0) & " = " & g(3) & " : cos(θ)"
          CAE = g(3) & " = " & CAE & " cos(θ)"
        End If
      End If
      If b = True And c = True Then
        'Az = (A) cos θ cos ϕ
        If FAD(a) = g(3) Then
          For i = d.Count - 1 To 0 Step -1
            CAG &= g(3) & " = (" & d(i).Replace(g(0) & " = ", "") & ") · cos(θ) · cos(ϕ)" & vbLf & f(i) & vbLf
          Next
          CAC &= g(0) & " = " & g(3) & " : cos(θ) : cos(ϕ)"
          CAE = g(3) & " = " & CAE & " cos(θ) cos(ϕ)"
        End If
      End If
    End If
    If FAA(0) = "θ" Then
      'θ = acos(Ax : (A))
      If FAD(a) = g(1) And c = False Then
        For i = d.Count - 1 To 0 Step -1
          CAG &= "θ = acos(" & g(1) & " : (" & d(i).Replace(g(0) & " = ", "") & "))" & vbLf & f(i) & vbLf
        Next
        CAC &= g(0) & " = " & g(1) & " : cos(θ)"
        CAE = "θ = acos(" & g(1) & " : " & CAE & ")"
      End If
      'θ = asin(Ay : (A))
      If FAD(a) = g(2) And c = False Then
        For i = d.Count - 1 To 0 Step -1
          CAG &= "θ = asin(" & g(2) & " : (" & d(i).Replace(g(0) & " = ", "") & "))" & vbLf & f(i) & vbLf
        Next
        CAC &= g(0) & " = " & g(2) & " : sin(θ)"
        CAE = "θ = asin(" & g(2) & " : " & CAE & ")"
      End If
      'θ = acos(Az : (A))
      If FAD(a) = g(3) And c = False Then
        For i = d.Count - 1 To 0 Step -1
          CAG &= "θ = acos(" & g(3) & " : (" & d(i).Replace(g(0) & " = ", "") & "))" & vbLf & f(i) & vbLf
        Next
        CAC &= g(0) & " = " & g(3) & " : cos(θ)"
        CAE = "θ = acos(" & g(3) & " : " & CAE & ")"
      End If
      'θ = acos(Ax : (A) : sin(ϕ))
      If FAD(a) = g(1) And c = True Then
        For i = d.Count - 1 To 0 Step -1
          CAG &= "θ = acos(" & g(1) & " : sin(ϕ) : " & d(i).Replace(g(0) & " = ", "") & ")" & vbLf & f(i) & vbLf
        Next
        CAC &= g(0) & " = " & g(1) & " : cos(θ) : sin(ϕ)"
        CAE = "θ = acos(" & g(1) & " : " & CAE & " : sin(ϕ))"
      End If
      'θ = acos(Az : (A) : cos(ϕ))
      If FAD(a) = g(3) And c = True Then
        For i = d.Count - 1 To 0 Step -1
          CAG &= "θ = acos(" & g(3) & " : cos(ϕ) : " & d(i).Replace(g(0) & " = ", "") & ")" & vbLf & f(i) & vbLf
        Next
        CAC &= g(0) & " = " & g(3) & " : cos(θ) : cos(ϕ)"
        CAE = "θ = acos(" & g(3) & " : " & CAE & " : cos(ϕ))"
      End If
    End If
    If FAA(0) = "ϕ" Then
      'ϕ = asin(Ax : (A) : cos(θ))
      If FAD(a) = g(1) And b = True And c = True Then
        For i = d.Count - 1 To 0 Step -1
          CAG &= "ϕ = asin(" & g(1) & " : cos(θ) : " & d(i).Replace(g(0) & " = ", "") & ")" & vbLf & f(i) & vbLf
        Next
        CAC &= g(0) & " = " & g(1) & " : cos(θ) : sin(ϕ)"
        CAE = "ϕ = asin(" & g(1) & " : " & CAE & " : cos(θ))"
      End If
      'ϕ = acos(Az : (A) : cos(θ))
      If FAD(a) = g(3) And b = True And c = True Then
        For i = d.Count - 1 To 0 Step -1
          CAG &= "ϕ = acos(" & g(3) & " : cos(θ) : " & d(i).Replace(g(0) & " = ", "") & ")" & vbLf & f(i) & vbLf
        Next
        CAC &= g(0) & " = " & g(3) & " : cos(θ) : cos(ϕ)"
        CAE = "ϕ = acos(" & g(3) & " : " & CAE & " : cos(θ))"
      End If
    End If
  End Sub
#End Region ' *****
#End Region
End Class
