Imports Windows.UI
Imports Windows.UI.Xaml.Shapes
Imports Windows.ApplicationModel.Resources
Public Class A_a_a
  Private ReadOnly XAA1 As New ResourceLoader("Resources1")
  'Imports Windows.UI
  'Imports Windows.UI.Xaml.Shapes
  Public Sub AAAA(a As String, b As Canvas, ParamArray c() As Double)
    'Achse-1D
    Dim aaaaa As Double
    Dim aaaab As Double
    Dim aaaac As New Canvas
    Dim aaaad As New A_a_b
    Dim aaaaf As New CompositeTransform With {.CenterX = 0, .Rotation = c(4), .CenterY = c(0) * 5}

    b.Children.Add(aaaac)
    aaaac.RenderTransform = aaaaf

    aaaad.AAA(aaaac, c(0), 0, c(3), 5, 5, 2, c(7))
    aaaad.AAA(aaaac, c(0), c(3) - 9, c(3), 8, 5, 2, c(7))
    aaaad.AAA(aaaac, c(0), c(3) - 9, c(3), 2, 5, 2, c(7))
    aaaad.AAX(aaaac, a, c(0), c(3) + 10, -10, 20, c(4), c(7))
    aaaac.Margin = New Thickness(c(0) * c(1), c(0) * c(2), 0, 0)

    If c(5) <> c(6) Then
      If c(4) > 90 Or c(4) < -90 Then aaaab = 1
      If c(5) < 0 And c(6) > 0 Then
        aaaaa = 30 + (c(3) - 70) * c(5) / (c(5) - c(6))
        If -c(5) / c(6) < 0.1 Then
          aaaaa = 30 + (c(3) - 70) / 10
          aaaad.AAA(aaaac, c(0), c(3) / 2 - 10, c(3) / 2, 10, 0, 2, 0, 0, 255)
          aaaad.AAA(aaaac, c(0), c(3) / 2, c(3) / 2 + 10, 10, 0, 2, 0, 0, 255)
        End If
        If c(6) / -c(5) < 0.1 Then
          aaaaa = c(3) - 40 - (c(3) - 70) / 10
          aaaad.AAA(aaaac, c(0), c(3) / 2 - 10, c(3) / 2, 10, 0, 2, 0, 0, 255)
          aaaad.AAA(aaaac, c(0), c(3) / 2, c(3) / 2 + 10, 10, 0, 2, 0, 0, 255)
        End If
        aaaad.AAB(aaaac, c(0), 10, 10, aaaaa - 5, 0, 255, 0, 0)
        aaaad.AAX(aaaac, Convert.ToString(0), c(0), aaaaa - 5, aaaab * 35 - 25, 20, c(4), c(7))
      End If
      aaaad.AAB(aaaac, c(0), 10, 10, 25, 0, 255, 0, 0)
      aaaad.AAB(aaaac, c(0), 10, 10, c(3) - 45, 0, 255, 0, 0)
      aaaad.AAX(aaaac, Convert.ToString(c(5)), c(0), 25, 10 - aaaab * 35, 20, c(4), c(7))
      aaaad.AAX(aaaac, Convert.ToString(c(6)), c(0), c(3) - 45, 10 - aaaab * 35, 20, c(4), c(7))
    End If

    'c(0) = Relative Zahl, c(1) = Px, c(2) = Py, c(3) = Länge, c(4) = Winkel, c(5) = Wert1, c(6) = Wert2, c(7) = Farbe
  End Sub
  Public Sub AAAB(a As String, b As Canvas, ParamArray c() As Double)
    'Achsen-2D-1
    Dim aa As New Canvas
    Dim ab As New A_a_b
    Dim ac As New CompositeTransform
    Dim aaax, aaay, aaaz() As String
    Dim ad, ae, af, ag, ah, ai, aj As Double : Dim aaaaa, aaaab, ak(5) As Integer
    '*****************************************************************************
    ac.Rotation = -c(4) : aa.RenderTransform = ac : b.Children.Add(aa) : ad = c(3) - 60
    ae = ad * Math.Cos(c(4) * Math.PI / 180) : If ae < 0 Then aaaaa = -1 Else aaaaa = 1
    af = ad * Math.Sin(c(4) * Math.PI / 180) : If af < 0 Then aaaab = -1 Else aaaab = 1
    ag = c(1) + 30 + ad * (1 - aaaaa) / 2 : ah = c(2) + 30 + ad * (1 + aaaab) / 2 : ai = ag + ae
    aj = ah - af : aaaz = a.Split(" ") : ac.CenterY = c(0) * 5 : aaax = aaaz(3) : aaay = aaaz(4)
    '*******************************************************************************************
    ak(0) = 200 : ak(1) = 100 : ak(2) = 250 : ak(3) = 200 : ak(4) = 100 : ak(5) = 250
    '*******************************************************************************************
    If aaaz.Count = 7 Then
      If c(4) > 0 Then
        If c(4) < 20 Then ab.AAJ(b, c(0), ag, ah, 65, 65, -10, c(4) + 10, 3, 3) : ab.AAX(b, aaaz(5), c(0), ag + 60, ah + 10, 20, 0, 3)
        If c(4) >= 20 Then ab.AAJ(b, c(0), ag, ah, 65, 65, 0, c(4), 3, 3) : ab.AAX(b, aaaz(5), c(0), ag + 75, ah - 25, 20, 0, 3)
      End If
      If c(4) < 0 Then
        If c(4) <= -20 Then ab.AAJ(b, c(0), ag, ah, 65, 65, 0, c(4), 3, 3) : ab.AAX(b, aaaz(5), c(0), ag + 75, ah - 1, 20, 0, 3)
        If c(4) > -20 Then ab.AAJ(b, c(0), ag, ah, 65, 65, 10, c(4) - 10, 3, 3) : ab.AAX(b, aaaz(5), c(0), ag + 60, ah - 40, 20, 0, 3)
      End If
      If aaaz(6) = "1" Then ak(0) = 211 : ak(1) = 211 : ak(2) = 211
      If aaaz(6) = "2" Then ak(3) = 211 : ak(4) = 211 : ak(5) = 211
    End If
    '**********************************************************************************************
    ab.AAA(aa, c(0), ad - 9, ad, 8, 5, 3, 2) : ab.AAX(b, aaaz(1), c(0), ag - 5, c(2) - 30, 20, 0, 1)
    ab.AAA(b, c(0), c(1), c(1) + c(3), ah, ah, 2, 3) : ab.AAA(b, c(0), ag, ag, c(2), c(2) + c(3), 2, 3)
    ab.AAA(aa, c(0), 0, ad, 5, 5, 3, 2) : ab.AAX(b, aaaz(0), c(0), c(1) + c(3) + 10, ah - 15, 20, 0, 1)
    ab.AAA(b, c(0), ag + 2, ag, c(2) + 9, c(2), 2, 3) : ab.AAA(b, c(0), ag - 2, ag, c(2) + 9, c(2), 2, 3)
    ab.AAA(aa, c(0), ad - 9, ad, 2, 5, 3, 2) : aa.Margin = New Thickness(c(0) * ag, c(0) * (ah - 5), 0, 0)
    ab.AAA(b, c(0), ai, ai, ah, aj, 2, 0) : ab.AAA(b, c(0), c(1) + c(3) - 9, c(1) + c(3), ah - 2, ah, 2, 3)
    ab.AAA(b, c(0), ag, ai, aj, aj, 2, 0) : ab.AAA(b, c(0), c(1) + c(3) - 9, c(1) + c(3), ah + 2, ah, 2, 3)
    ab.AAB(b, c(0), 10, 10, ag - 5, aj - 5, 255, 0, 0) : ab.AAX(aa, aaaz(2), c(0), ad + 10, -10, 20, -c(4), 2)
    ab.AAB(b, c(0), 10, 10, ag - 5, ah - 5, 255, 0, 0) : ab.AAA(b, c(0), ag, ai, ah, ah, 4, ak(0), ak(1), ak(2))
    ab.AAB(b, c(0), 10, 10, ai - 5, ah - 5, 255, 0, 0) : ab.AAA(b, c(0), ag, ag, ah, aj, 4, ak(3), ak(4), ak(5))
    If ae < 0 Then ag += 10 : ad = ag : ai -= 11 * aaax.Length Else ag -= 20 : ad = ag + 10 - 11 * aaay.Length
    ab.AAX(b, aaay, c(0), ad, aj - 13, 20, 0, ak(3), ak(4), ak(5)) : ah = ah - 12.5 + 17.5 * aaaab
    ab.AAX(b, "0", c(0), ag, ah, 20, 0, 1) : ab.AAX(b, aaax, c(0), ai, ah, 20, 0, ak(0), ak(1), ak(2))
    '**********************************************************************************************************
    'c(0) = Relative Zahl, c(1) = Px, c(2) = Py, c(3) = Größe, c(4) = Wert 1
  End Sub
  Public Sub AAAD(a As String, b As Canvas, ParamArray c() As Double)
    'Achsen-3D-1
    Dim aa As New Canvas
    Dim ab As New Canvas
    Dim ac As New A_a_b
    Dim ad As New CompositeTransform
    Dim aaaz() As String ' aaax, aaay,
    Dim af(5), ag(5), ah(5) As Double
    Dim ai, aj, ak, aal(6) As Integer
    Dim am As New CompositeTransform With {.Rotation = 135}

    aaaz = a.Split(" ") : ad.CenterY = c(0) * 5
    ab.RenderTransform = am : b.Children.Add(ab) : af(0) = c(3) - 60
    ad.Rotation = -c(4) : aa.RenderTransform = ad : b.Children.Add(aa)

    af(1) = Math.Cos(c(4) * Math.PI / 180) : af(2) = Math.Sin(c(4) * Math.PI / 180)
    af(3) = Math.Cos(c(5) * Math.PI / 180) : af(4) = Math.Sin(c(5) * Math.PI / 180)
    If af(1) < 0 And af(3) < 0 Then af(3) = -af(3)
    If af(1) < 0 And af(4) < 0 Then af(4) = -af(4)
    ag(0) = Math.Cos(45 * Math.PI / 180) : ag(5) = af(0) * ag(0) * (1 - aj) / 4
    af(2) *= af(0) : af(3) *= af(0) * af(1) * ag(0) / 2 : af(4) *= af(0) * af(1) ' y z x
    If af(2) < 0 Then af(2) = -af(2) : ai = -1 Else ai = 1 ' y
    If af(3) < 0 Then af(3) = -af(3) : aj = -1 Else aj = 1 ' z
    If af(4) < 0 Then af(4) = -af(4) : ak = -1 Else ak = 1 ' x
    ag(1) = c(1) + 30 + af(0) * (1 - ak) / 2 - ag(5) : ag(3) = ag(1) + ag(5) + 20 * ag(0) ' x ' z-x
    ag(2) = c(2) + 30 + af(0) * (1 + ai) / 2 + ag(5) : ag(4) = ag(2) - ag(5) - 20 * ag(0) ' y ' z-y
    ah(0) = ag(2) - af(2) * ai : ah(1) = ag(1) + af(4) * ak : ah(2) = ag(1) - af(3) * aj ' y ' x ' z-x
    ah(3) = ag(2) + af(3) * aj : ah(4) = ah(2) + af(4) * ak : ah(5) = ah(3) - af(2) * ai ' z-y ' x-n ' y-n

    ac.AAA(ab, c(0), 0, af(0) / 2 + 40, 0, 0, 2, 3) ' z-A
    ac.AAA(b, c(0), ag(1), ah(4), ag(2), ah(5), 4, 2) ' V
    ac.AAA(b, c(0), ag(1), ah(4), ag(2), ah(3), 1, 1) ' w
    ac.AAA(b, c(0), ag(1), ah(1), ah(0), ah(0), 1, 0) ' x-A1
    ac.AAA(b, c(0), ah(2), ah(4), ah(3), ah(3), 1, 0) ' x-A2
    ac.AAA(b, c(0), ah(2), ah(4), ah(5), ah(5), 1, 0) ' x-A3
    ac.AAA(b, c(0), ah(1), ah(1), ag(2), ah(0), 1, 0) ' y-A1
    ac.AAA(b, c(0), ah(2), ah(2), ah(3), ah(5), 1, 0) ' y-A2
    ac.AAA(b, c(0), ah(4), ah(4), ah(3), ah(5), 1, 0) ' y-A3
    ac.AAA(b, c(0), ah(1), ah(4), ag(2), ah(3), 1, 0) ' z-A1
    ac.AAA(b, c(0), ag(1), ah(2), ah(0), ah(5), 1, 0) ' z-A2
    ac.AAA(b, c(0), ah(1), ah(4), ah(0), ah(5), 1, 0) ' z-A3
    ac.AAX(ab, "z", c(0), af(0) / 2 + 50, -5, 20, 135, 1) ' z
    ab.Margin = New Thickness(c(0) * ag(3), c(0) * ag(4), 0, 0)
    ac.AAX(b, "y", c(0), ag(1) - 5, c(2) + ag(5) - 30, 20, 0, 1) ' y
    ac.AAA(ab, c(0), af(0) / 2 + 31, af(0) / 2 + 40, 2, 0, 2, 3) ' z-P1
    ac.AAA(ab, c(0), af(0) / 2 + 31, af(0) / 2 + 40, -2, 0, 2, 3) ' z-P2
    ac.AAX(b, "x", c(0), c(1) + c(3) - ag(5) + 10, ag(2) - 15, 20, 0, 1) ' x
    ac.AAA(b, c(0), c(1) - ag(5), c(1) + c(3) - ag(5), ag(2), ag(2), 2, 3) ' x-A
    ac.AAA(b, c(0), ag(1), ag(1), c(2) + ag(5), c(2) + c(3) + ag(5), 2, 3) ' y-A
    ac.AAA(b, c(0), ag(1) - 2, ag(1), c(2) + ag(5) + 9, c(2) + ag(5), 2, 3) ' y-P1
    ac.AAA(b, c(0), ag(1) + 2, ag(1), c(2) + ag(5) + 9, c(2) + ag(5), 2, 3) ' y-P2
    ac.AAA(b, c(0), c(1) + c(3) - ag(5) - 9, c(1) + c(3) - ag(5), ag(2) - 2, ag(2), 2, 3) ' x-P1
    ac.AAA(b, c(0), c(1) + c(3) - ag(5) - 9, c(1) + c(3) - ag(5), ag(2) + 2, ag(2), 2, 3) ' x-P2
    ac.AAA(b, c(0), ag(1), ah(1), ag(2), ag(2), 4, 255, 20, 147) ' x-A
    ac.AAA(b, c(0), ag(1), ag(1), ag(2), ah(0), 4, 255, 20, 147) ' y-A
    ac.AAA(b, c(0), ag(1), ah(2), ag(2), ah(3), 4, 255, 20, 147) ' z-A

    If aaaz.Count = 7 Then
      Dim dx, dy1, dy2 As Double
      If af(1) < 0 Then af(1) *= -1
      'ak(0) = 211 : ak(1) = 211 : ak(2) = 211
      'ak(3) = 211 : ak(4) = 211 : ak(5) = 211
      dx = ah(4) - ag(1) : dy1 = ag(2) - ah(3) : dy2 = ag(2) - ah(5)
      If dx > 0 And dy1 > 0 Then dy1 = Math.Atan(dy1 / dx) * 180 / Math.PI
      If dx > 0 And dy1 < 0 Then dy1 = Math.Atan(dy1 / dx) * 180 / Math.PI
      If dx > 0 And dy2 > 0 Then dy2 = Math.Atan(dy2 / dx) * 180 / Math.PI
      If dx > 0 And dy2 < 0 Then dy2 = Math.Atan(dy2 / dx) * 180 / Math.PI
      If dx < 0 And dy1 > 0 Then dy1 = 180 + Math.Atan(dy1 / dx) * 180 / Math.PI
      If dx < 0 And dy1 < 0 Then dy1 = 180 + Math.Atan(dy1 / dx) * 180 / Math.PI
      If dx < 0 And dy2 > 0 Then dy2 = 180 + Math.Atan(dy2 / dx) * 180 / Math.PI
      If dx < 0 And dy2 < 0 Then dy2 = 180 + Math.Atan(dy2 / dx) * 180 / Math.PI
      If aj = -1 Then ac.AAA(ab, c(0), af(0) / 2 + 40, af(0) / 2 + 90, 0, 0, 1, 1) ' z-A
      If c(5) > 0 Then
        If c(5) < 20 Then ac.AAJ(b, c(0), ag(1), ag(2), 70, 35, -145, dy1 + 10, 1, 124, 252, 0)
        If c(5) >= 20 Then ac.AAJ(b, c(0), ag(1), ag(2), 70, 35, -135, dy1, 1, 124, 252, 0)
      End If
      If c(5) < 0 Then
        If c(5) <= -20 Then ac.AAJ(b, c(0), ag(1), ag(2), 70, 35, -135, dy1, 1, 124, 252, 0)
        If c(5) > -20 Then ac.AAJ(b, c(0), ag(1), ag(2), 70, 35, -125, dy1 - 10, 1, 124, 252, 0)
      End If
      If c(4) > 0 Then
        If c(4) < 20 Then ac.AAJ(b, c(0), ag(1), ag(2), 50 * af(1), 50, dy1 - 10, dy2 + 10, 1, 32, 178, 170)
        If c(4) >= 20 Then ac.AAJ(b, c(0), ag(1), ag(2), 50 * af(1), 50, dy1, dy2, 1, 32, 178, 170)
      End If
      If c(4) < 0 Then
        If c(4) <= -20 Then ac.AAJ(b, c(0), ag(1), ag(2), 50 * af(1), 50, dy1, dy2, 1, 32, 178, 170)
        If c(4) > -20 Then ac.AAJ(b, c(0), ag(1), ag(2), 50 * af(1), 50, dy1 + 10, dy2 - 10, 1, 32, 178, 170)
      End If
      ac.AAX(b, aaaz(5) & " = " & XAA1.GetString("S086"), c(0), ag(1) + af(0) * ak, c(2) + ag(5) - 40, 20, 0, 32, 178, 170)
      ac.AAX(b, aaaz(6) & " = " & XAA1.GetString("S087"), c(0), ag(1) + af(0) * ak, c(2) + ag(5) - 10, 20, 0, 124, 252, 0)
    End If

    'c(0) = Relative Zahl, c(1) = Px, c(2) = Py, c(3) = Größe, c(4) = Wert 1, c(5) = Wert 2
  End Sub
  Public Sub AAAE(b As Canvas, ParamArray c() As Double) ' a As String, 
    'Achsen-2D-2
    Dim aaaaa As Double
    'Dim aaaab As Double
    Dim aaaac As New Canvas
    Dim aaaad As New Canvas
    Dim aaaae As New A_a_b
    Dim aaaaf As New CompositeTransform With {.CenterX = 0, .Rotation = -90, .CenterY = c(0) * 5}

    b.Children.Add(aaaac)
    b.Children.Add(aaaad)
    aaaad.RenderTransform = aaaaf

    aaaae.AAA(aaaac, c(0), 0, c(3), 5, 5, 2, c(8))
    aaaae.AAA(aaaad, c(0), 0, c(3), 5, 5, 2, c(8))
    aaaae.AAA(aaaac, c(0), c(3) - 9, c(3), 8, 5, 2, c(8))
    aaaae.AAA(aaaac, c(0), c(3) - 9, c(3), 2, 5, 2, c(8))
    aaaae.AAA(aaaad, c(0), c(3) - 9, c(3), 8, 5, 2, c(8))
    aaaae.AAA(aaaad, c(0), c(3) - 9, c(3), 2, 5, 2, c(8))
    aaaae.AAX(aaaac, "x", c(0), c(3) + 10, -10, 20, 0, c(8))
    aaaae.AAX(aaaad, "y", c(0), c(3) + 10, -10, 20, -90, c(8))
    aaaac.Margin = New Thickness(c(0) * c(1), c(0) * c(2), 0, 0)
    aaaad.Margin = New Thickness(c(0) * c(1), c(0) * c(2), 0, 0)

    If c(4) <> c(5) Then
      If c(4) < 0 And c(5) > 0 Then
        aaaaa = 30 + (c(3) - 70) * c(4) / (c(4) - c(5))
        If -c(4) / c(5) < 0.1 Then
          aaaaa = 30 + (c(3) - 70) / 10
          aaaae.AAA(aaaac, c(0), c(3) / 2 - 10, c(3) / 2, 10, 0, 2, 0, 0, 255)
          aaaae.AAA(aaaac, c(0), c(3) / 2, c(3) / 2 + 10, 10, 0, 2, 0, 0, 255)
        End If
        If c(5) / -c(4) < 0.1 Then
          aaaaa = c(3) - 40 - (c(3) - 70) / 10
          aaaae.AAA(aaaac, c(0), c(3) / 2 - 10, c(3) / 2, 10, 0, 2, 0, 0, 255)
          aaaae.AAA(aaaac, c(0), c(3) / 2, c(3) / 2 + 10, 10, 0, 2, 0, 0, 255)
        End If
        aaaae.AAB(aaaac, c(0), 10, 10, aaaaa - 5, 0, 255, 0, 0)
        aaaae.AAX(aaaac, Convert.ToString(0), c(0), aaaaa - 5, -25, 20, 0, c(8))
      End If
      aaaae.AAB(aaaac, c(0), 10, 10, 25, 0, 255, 0, 0)
      aaaae.AAB(aaaac, c(0), 10, 10, c(3) - 45, 0, 255, 0, 0)
      aaaae.AAX(aaaac, Convert.ToString(c(4)), c(0), 25, 10, 20, 0, c(8))
      aaaae.AAX(aaaac, Convert.ToString(c(5)), c(0), c(3) - 45, 10, 20, 0, c(8))
    End If

    If c(6) <> c(7) Then
      If c(6) < 0 And c(7) > 0 Then
        aaaaa = 30 + (c(3) - 70) * c(6) / (c(6) - c(7))
        If -c(6) / c(7) < 0.1 Then
          aaaaa = 30 + (c(3) - 70) / 10
          aaaae.AAA(aaaad, c(0), c(3) / 2 - 10, c(3) / 2, 10, 0, 2, 0, 0, 255)
          aaaae.AAA(aaaad, c(0), c(3) / 2, c(3) / 2 + 10, 10, 0, 2, 0, 0, 255)
        End If
        If c(7) / -c(6) < 0.1 Then
          aaaaa = c(3) - 40 - (c(3) - 70) / 10
          aaaae.AAA(aaaad, c(0), c(3) / 2 - 10, c(3) / 2, 10, 0, 2, 0, 0, 255)
          aaaae.AAA(aaaad, c(0), c(3) / 2, c(3) / 2 + 10, 10, 0, 2, 0, 0, 255)
        End If
        aaaae.AAB(aaaad, c(0), 10, 10, aaaaa - 5, 0, 255, 0, 0)
        aaaae.AAX(aaaad, Convert.ToString(0), c(0), aaaaa - 5, 10, 20, -90, c(8))
      End If
      aaaae.AAB(aaaad, c(0), 10, 10, 25, 0, 255, 0, 0)
      aaaae.AAB(aaaad, c(0), 10, 10, c(3) - 45, 0, 255, 0, 0)
      aaaae.AAX(aaaad, Convert.ToString(c(6)), c(0), 25, -25, 20, -90, c(8))
      aaaae.AAX(aaaad, Convert.ToString(c(7)), c(0), c(3) - 45, -25, 20, -90, c(8))
    End If

    'c(0) = Relative Zahl, c(1) = Px, c(2) = Py, c(3) = Größe, c(4) -&- c(7) = Werte, c(8) = Farbe

  End Sub
  Public Sub AACA(a As String, b As Canvas, ParamArray c() As Double)
    'Pfeil 1
    Dim aaaaa As Double
    Dim aaaab As New Canvas
    Dim aaaac As New A_a_b
    Dim aaaad As New CompositeTransform

    b.Children.Add(aaaab)
    aaaad.CenterX = 0 : aaaad.CenterY = 5
    If c(4) > 90 Or c(4) < -90 Then aaaaa = 1
    aaaad.Rotation = c(4) : aaaab.RenderTransform = aaaad
    aaaab.Margin = New Thickness(c(0) * c(1), c(0) * c(2), 0, 0)

    aaaac.AAA(aaaab, c(0), 0, c(3), 5, 5, 2, c(5))
    aaaac.AAA(aaaab, c(0), c(3) - 9, c(3), 2, 5, 2, c(5))
    aaaac.AAA(aaaab, c(0), c(3) - 9, c(3), 8, 5, 2, c(5))
    aaaac.AAX(aaaab, a, c(0), c(3) / 2, aaaaa * 30 - 25, 20, 0 + aaaaa * 180, c(5))

    'c(0) = relative Zahl, c(1) = Px, c(2) = Py, c(3) = Länge, c(4) = Winkel, c(5) = Farbe
  End Sub
  Public Sub AACB(a As String, b As Canvas, ParamArray c() As Double)
    'Pfeil 2
    Dim aaaaa As Double
    Dim aaaab As New Canvas
    Dim aaaac As New A_a_b
    Dim aaaad As New CompositeTransform

    b.Children.Add(aaaab)
    aaaad.CenterX = 0 : aaaad.CenterY = 5
    If c(4) > 90 Or c(4) < -90 Then aaaaa = 1
    aaaad.Rotation = c(4) : aaaab.RenderTransform = aaaad
    aaaab.Margin = New Thickness(c(0) * c(1), c(0) * c(2), 0, 0)

    aaaac.AAA(aaaab, c(0), 0, 9, 5, 2, 2, c(5))
    aaaac.AAA(aaaab, c(0), 0, 9, 5, 8, 2, c(5))
    aaaac.AAA(aaaab, c(0), 0, c(3), 5, 5, 2, c(5))
    aaaac.AAA(aaaab, c(0), c(3) - 9, c(3), 2, 5, 2, c(5))
    aaaac.AAA(aaaab, c(0), c(3) - 9, c(3), 8, 5, 2, c(5))
    aaaac.AAX(aaaab, a, c(0), (c(3) - 10 * a.Length) / 2, aaaaa * 30 - 25, 20, 0 + aaaaa * 180, c(5))

    'c(0) = relative Zahl, c(1) = Px, c(2) = Py, c(3) = Länge, c(4) = Winkel, c(5) = Farbe
  End Sub
  Public Sub AACC() ' a As String, b As Canvas, ParamArray c() As Double
    'Strichlinie
    'Dim aaaaa As Double
    'Dim aaaab As New Canvas
    'Dim aaaac As New Bauelement
    'Dim aaaad As New CompositeTransform

    'b.Children.Add(aaaab)
    'aaaad.CenterX = 0 : aaaad.CenterY = 0
    'If c(4) > 90 Or c(4) < -90 Then aaaaa = 1
    'aaaad.Rotation = c(4) : aaaab.RenderTransform = aaaad
    'aaaab.Margin = New Thickness(c(0) * c(1), c(0) * c(2), 0, 0)

    'aaaac.BJA(aaaab, c(0), 0, c(3), 30, 30, 2, c(5))
    'aaaac.BJA(aaaab, c(0), c(3) - 9, c(3), 27, 30, 2, c(5))
    'aaaac.BJA(aaaab, c(0), c(3) - 9, c(3), 33, 30, 2, c(5))
    'aaaac.CB(aaaab, a, c(0), c(3) / 2, 0 + aaaaa * 35, 0, 0, 20, 0 + aaaaa * 180, c(5))

    'c(0) = relative Zahl, c(1) = Px, c(2) = Py, c(3) = Länge, c(4) = Winkel, c(5) = Farbe
  End Sub
  Public Sub AAEA(a As String, b As Canvas, ParamArray c() As Double)
    'Flagge
    Dim aaaaa As Integer
    Dim aaaab As Integer
    Dim aaaac As New A_a_b
    If c(3) < 0 Then aaaaa = 10 Else aaaaa = 40
    aaaac.AAA(b, c(0), c(1), c(1), c(2), c(2) - 100, 3, 128, 128, 128)
    aaaac.AAC(b, c(0), 10, 10, c(1) - aaaaa + 10, c(2) - 90, 1, 255, 255, 255)
    aaaac.AAC(b, c(0), 10, 10, c(1) - aaaaa + 20, c(2) - 90, 1, 135, 206, 235)
    aaaac.AAC(b, c(0), 10, 10, c(1) - aaaaa + 30, c(2) - 90, 1, 255, 255, 255)
    aaaac.AAC(b, c(0), 10, 10, c(1) - aaaaa + 10, c(2) - 100, 1, 135, 206, 235)
    aaaac.AAC(b, c(0), 10, 10, c(1) - aaaaa + 20, c(2) - 100, 1, 255, 255, 255)
    aaaac.AAC(b, c(0), 10, 10, c(1) - aaaaa + 30, c(2) - 100, 1, 135, 206, 235)
    'Markierung
    If a <> "" Then
      If c(3) < 0 Then aaaaa = -90 : aaaab = 90 Else aaaaa = 10 : aaaab = -90
      aaaac.AAD(b, c(0), c(1) + aaaaa, c(2) + 10, 80, 80, c(3), 0, 255, 228, 181)
      aaaac.AAY(b, a, c(0), c(1) + aaaaa, c(2) + 10, 80, 80, 20, c(3), aaaab, 0, 0, 0)
    End If
    'c(0) = relative Zahl, c(1) = Px, c(2) = Py, c(3) = Winkel
  End Sub
  Public Sub AAEB(a As String, b As Canvas, ParamArray c() As Double)
    'Würfel
    Dim aaaaa As Integer
    Dim aaaab As Integer
    Dim aaaac As New A_a_b
    If c(3) = 1 Then aaaaa = 80 : aaaab = 140
    aaaac.AAD(b, c(0), c(1) + 40, c(2) + 40, 100, 100, 0, 0, 255, 225, 50)
    aaaac.AAY(b, a, c(0), c(1) + 50, c(2) + 40, 80, 80, 20, 0, 0, 184, 134, 11)
    aaaac.AAD(b, c(0), c(1) + aaaaa, c(2), 100, 40, -45 * c(3), 0, 255, 225, 50)
    aaaac.AAD(b, c(0), c(1) + aaaab, c(2) + aaaaa / 2, 40, 100, 0, -45 * c(3), 255, 225, 50)
    'c(0) = relative Zahl c(1) = Px, c(2) = Py, c(3) = Richtung,
  End Sub
  'Public Sub AAAI(a As String, b As Canvas, ParamArray c() As Double)
  '    'Feder
  '    Dim C1 As New Canvas

  '    Dim Path1 As New Path
  '    Dim GeometryGroup1 As New GeometryGroup
  '    Dim PathGeometry1 As New PathGeometry
  '    Dim PathFigureCollection1 As New PathFigureCollection
  '    Dim PathFigure1 As New PathFigure
  '    Dim PathSegment1 As New ArcSegment
  '    Dim PathSegmentCollection1 As New PathSegmentCollection
  '    'Path1.Stroke = New SolidColorBrush(color)
  '    Path1.StrokeThickness = c(0)
  '    PathFigure1.IsClosed = False
  '    PathGeometry1.Figures = PathFigureCollection1
  '    PathFigureCollection1.Add(PathFigure1)
  '    PathFigure1.StartPoint = New Point(c(1) * c(7), c(2) * c(7))
  '    PathSegment1.Point = New Point(c(3) * c(7), c(4) * c(7))
  '    PathSegment1.Size = New Size(c(5) * c(7), c(6) * c(7))
  '    PathSegmentCollection1.Add(PathSegment1)
  '    PathFigure1.Segments = PathSegmentCollection1
  '    GeometryGroup1.Children.Add(PathGeometry1)
  '    Path1.Data = GeometryGroup1
  '    b.Children.Add(C1) : C1.Children.Add(Path1)
  'End Sub

  'Public Sub AAAJ(a As String, b As Canvas, ParamArray c() As Double)
  '    'Welle
  '    Dim C1 As New Canvas

  '    Dim Path1 As New Path
  '    Dim GeometryGroup1 As New GeometryGroup
  '    Dim PathGeometry1 As New PathGeometry
  '    Dim PathFigureCollection1 As New PathFigureCollection
  '    Dim PathFigure1 As New PathFigure
  '    Dim PathSegment1 As New ArcSegment
  '    Dim PathSegmentCollection1 As New PathSegmentCollection
  '    'Path1.Stroke = New SolidColorBrush(color)
  '    Path1.StrokeThickness = c(0)
  '    PathFigure1.IsClosed = False
  '    PathGeometry1.Figures = PathFigureCollection1
  '    PathFigureCollection1.Add(PathFigure1)
  '    PathFigure1.StartPoint = New Point(c(1) * c(7), c(2) * c(7))
  '    PathSegment1.Point = New Point(c(3) * c(7), c(4) * c(7))
  '    PathSegment1.Size = New Size(c(5) * c(7), c(6) * c(7))
  '    PathSegmentCollection1.Add(PathSegment1)
  '    PathFigure1.Segments = PathSegmentCollection1
  '    GeometryGroup1.Children.Add(PathGeometry1)
  '    Path1.Data = GeometryGroup1
  '    b.Children.Add(C1) : C1.Children.Add(Path1)
  'End Sub


  'Public Sub AABR(a As String, b As Canvas, ParamArray c() As Double)
  '    'Tag

  'End Sub

  'Public Sub AABS(a As String, b As Canvas, ParamArray c() As Double)
  '    'Nacht

  'End Sub

  'Public Sub AABT(a As String, b As Canvas, ParamArray c() As Double)
  '    'Winter

  'End Sub

  'Public Sub AABU(a As String, b As Canvas, ParamArray c() As Double)
  '    'Frühling

  'End Sub

  'Public Sub AABV(a As String, b As Canvas, ParamArray c() As Double)
  '    'Sommer

  'End Sub

  'Public Sub AABW(a As String, b As Canvas, ParamArray c() As Double)
  '    'Herbst

  'End Sub

  'Public Sub AABX(a As String, b As Canvas, ParamArray c() As Double)
  '    'Uhr

  'End Sub


  'Public Sub Achse(a As Double, b As Double, color As Color, Cv As Canvas)
  '    Dim C1 As New Canvas


  '    Dim c As Double
  '    Dim d(0 To 9) As Double
  '    Dim d1(0 To 9) As String
  '    'Dim d2 As Boolean = False
  '    Dim d2 As Integer

  '    c = (b - a) / 10
  '    d(0) = a
  '    d(1) = a + c
  '    d(2) = a + 2 * c
  '    d(3) = a + 3 * c
  '    d(4) = a + 4 * c
  '    d(5) = a + 5 * c
  '    d(6) = a + 6 * c
  '    d(7) = a + 7 * c
  '    d(8) = a + 8 * c
  '    d(9) = b

  '    For f = 0 To 9 Step 1

  '        If d(f) > 0 Then d2 = f : Exit For
  '        If d(f) < 0 Then d1(f) = Convert.ToString(d(f))

  '        'If d(f) = 0 Then d2 = True
  '    Next


  '    For f = 0 To 9 Step 1
  '        'If d(f) = 0 Then d2 = True
  '    Next

  '    'TB(50, 310, Tb1, "0")

  '    'TB(100, 310, Tb2, Convert.ToString(a))
  '    'TB(150, 310, Tb3, Convert.ToString(d(1)))
  '    'TB(200, 310, Tb4, Convert.ToString(d(2)))
  '    'TB(250, 310, Tb5, Convert.ToString(d(3)))
  '    'TB(300, 310, Tb6, Convert.ToString(d(4)))
  '    'TB(350, 310, Tb7, Convert.ToString(d(5)))
  '    'TB(400, 310, Tb8, Convert.ToString(d(6)))
  '    'TB(450, 310, Tb9, Convert.ToString(d(7)))
  '    'TB(500, 310, Tb10, Convert.ToString(d(8)))
  '    'TB(550, 310, Tb11, Convert.ToString(b))

  '    'TB(585, 310, Tb12, "x")


  '    'Linie(0, 600, 300, 300, Ll1)
  '    'Linie(595, 600, 295, 300, Ll2)
  '    'Linie(595, 600, 305, 300, Ll3)
  'End Sub
  Public Sub Feder(color As Color, Cv As Canvas, ParamArray c() As Double)
    Dim C1 As New Canvas

    Dim Path1 As New Path
    Dim GeometryGroup1 As New GeometryGroup
    Dim PathGeometry1 As New PathGeometry
    Dim PathFigureCollection1 As New PathFigureCollection
    Dim PathFigure1 As New PathFigure
    Dim PathSegment1 As New ArcSegment
    Dim PathSegmentCollection1 As New PathSegmentCollection
    Path1.Stroke = New SolidColorBrush(color)
    Path1.StrokeThickness = c(0)
    PathFigure1.IsClosed = False
    PathGeometry1.Figures = PathFigureCollection1
    PathFigureCollection1.Add(PathFigure1)
    PathFigure1.StartPoint = New Point(c(1) * c(7), c(2) * c(7))
    PathSegment1.Point = New Point(c(3) * c(7), c(4) * c(7))
    PathSegment1.Size = New Size(c(5) * c(7), c(6) * c(7))
    PathSegmentCollection1.Add(PathSegment1)
    PathFigure1.Segments = PathSegmentCollection1
    GeometryGroup1.Children.Add(PathGeometry1)
    Path1.Data = GeometryGroup1
    Cv.Children.Add(C1) : C1.Children.Add(Path1)
  End Sub
  Public Sub Kreis(color1 As Color, color2 As Color, Cv As Canvas, ParamArray c() As Double)
    Dim C1 As New Canvas
    Dim El1 As New Ellipse With
        {.StrokeThickness = c(0),
        .Fill = New SolidColorBrush(color2),
        .Stroke = New SolidColorBrush(color1),
        .Width = c(1) * c(5), .Height = c(2) * c(5),
        .Margin = New Thickness(c(3) * c(5), c(4) * c(5), 0, 0)}
    Cv.Children.Add(C1) : C1.Children.Add(El1)
  End Sub
  Public Sub Linie(color As Color, Cv As Canvas, ParamArray c() As Double)
    Dim C1 As New Canvas
    Dim L1 As New Line With
        {.StrokeThickness = c(0),
        .Stroke = New SolidColorBrush(color),
        .X1 = c(1) * c(5), .X2 = c(2) * c(5),
        .Y1 = c(3) * c(5), .Y2 = c(4) * c(5)}
    Cv.Children.Add(C1) : C1.Children.Add(L1)
  End Sub
  Public Sub Rechteck(color1 As Color, color2 As Color, Cv As Canvas, ParamArray c() As Double)
    Dim C1 As New Canvas

    Dim Rc1 As New Rectangle With
        {.StrokeThickness = c(0),
        .Width = c(1) * c(5),
        .Height = c(2) * c(5),
        .Margin = New Thickness(c(3) * c(5), c(4) * c(5), 0, 0),
        .Stroke = New SolidColorBrush(color1),
        .Fill = New SolidColorBrush(color2)}
    Cv.Children.Add(C1) : C1.Children.Add(Rc1)
    'Rc1.RadiusX = 45 : Rc1.RadiusY = 45
  End Sub
  Public Sub Skalar(a As String, Cv As Canvas, ParamArray c() As Double)
    Dim C1 As New Canvas
    Dim L1 As New Line

    Dim T1 As New TextBlock
    Dim rt As New CompositeTransform
    Dim tr As New CompositeTransform

    If a <> "ΔEkin" And a <> "ΔEpot" And a <> "Δt" Then
      Cv.Children.Add(T1)
      T1.Text = a : T1.Width = c(0) * a.Length * 10 : T1.Height = c(0) * 15
      T1.Margin = New Thickness(c(0) * c(1), c(0) * c(2), 0, 0)
      T1.Foreground = New SolidColorBrush(Colors.Green) : T1.FontSize = c(0) * 12
    End If
    If a = "ΔEkin" Or a = "ΔEpot" Or a = "Δt" Then
      Cv.Children.Add(C1) : C1.Children.Add(L1) : C1.Children.Add(T1)
      L1.Stroke = New SolidColorBrush(Colors.Gray)
      rt.CenterX = c(0) * c(3) / 2 : rt.CenterY = c(0) * 10
      rt.Rotation = c(0) * c(4) : C1.RenderTransform = rt
      C1.Margin = New Thickness(c(0) * c(1), c(0) * c(2), 0, 0) : C1.Width = c(0) * c(3) : C1.Height = c(0) * 20
      T1.Margin = New Thickness(c(0) * L1.X2 - c(0) * 25, 0, 0, 0)
      L1.X1 = 0 : L1.X2 = C1.Width : L1.Y1 = c(0) * 15 : L1.Y2 = c(0) * 15
      L1.StrokeThickness = 1
      T1.Text = a : T1.Width = c(0) * a.Length * 10 : T1.Height = c(0) * 15 : T1.FontSize = c(0) * 12
      If c(4) > 90 Or c(4) < -90 Then
        tr.CenterX = c(0) * T1.Width / 2 : tr.CenterY = c(0) * 7.5
        tr.Rotation = 180 : T1.RenderTransform = tr
      End If
      T1.Foreground = New SolidColorBrush(Colors.Gray)
    End If
  End Sub
  Public Sub Vektor(a As String, Cv As Canvas, ParamArray c() As Double)
    Dim C1 As New Canvas
    Dim L1 As New Line
    Dim L2 As New Line
    Dim L3 As New Line
    Dim T1 As New TextBlock
    Dim rt As New CompositeTransform
    Dim tr As New CompositeTransform

    Cv.Children.Add(C1)
    C1.Children.Add(L1) : C1.Children.Add(L2) : C1.Children.Add(L3) : C1.Children.Add(T1)
    If a = "x" Or a = "y" Or a = "z" Then
      L1.Stroke = New SolidColorBrush(Colors.LightGray)
      L2.Stroke = New SolidColorBrush(Colors.LightGray)
      L3.Stroke = New SolidColorBrush(Colors.LightGray)
    Else
      L1.Stroke = New SolidColorBrush(Colors.BlueViolet)
      L2.Stroke = New SolidColorBrush(Colors.BlueViolet)
      L3.Stroke = New SolidColorBrush(Colors.BlueViolet)
    End If
    L1.X1 = 0 : L1.X2 = c(2) * c(4) : L1.Y1 = 15 * c(4) : L1.Y2 = 15 * c(4)
    L2.X1 = c(2) * c(4) - 9 * c(4) : L2.X2 = c(2) * c(4) : L2.Y1 = 12 * c(4) : L2.Y2 = 15 * c(4)
    L3.X1 = c(2) * c(4) - 9 * c(4) : L3.X2 = c(2) * c(4) : L3.Y1 = 18 * c(4) : L3.Y2 = 15 * c(4)
    L1.StrokeThickness = 2 : L2.StrokeThickness = 2 : L3.StrokeThickness = 2
    T1.Text = a : T1.Width = a.Length * 10 * c(4) : T1.Height = 15 * c(4) : T1.FontSize = 12 * c(4)
    T1.Foreground = New SolidColorBrush(Colors.Blue)
    T1.Margin = New Thickness(c(2) * c(4) - 25 * c(4), 0, 0, 0)
    C1.Margin = New Thickness(c(0) * c(4), c(1) * c(4), 0, 0) : C1.Width = c(2) * c(4) : C1.Height = 20 * c(4)
    If c(3) < 90 And c(3) > -90 Then
      rt.CenterX = c(2) * c(4) / 2 : rt.CenterY = 15 * c(4)
      rt.Rotation = c(3) : C1.RenderTransform = rt
    End If
    If c(3) > 90 Or c(3) < -90 Then
      L1.Y1 = 5 * c(4) : L1.Y2 = 5 * c(4)
      L2.Y1 = 2 * c(4) : L2.Y2 = 5 * c(4)
      L3.Y1 = 8 * c(4) : L3.Y2 = 5 * c(4)
      T1.Margin = New Thickness(c(2) * c(4) - 15 * c(4), 5 * c(4), 0, 0)
      tr.CenterX = T1.Width * c(4) / 2 : tr.CenterY = 7.5 * c(4)
      tr.Rotation = 180 : T1.RenderTransform = tr
      rt.CenterX = c(2) * c(4) / 2 : rt.CenterY = 10 * c(4)
      rt.Rotation = c(3) : C1.RenderTransform = rt
    End If
    'Math.Sin(c(7) * 0.017453293) !!!
  End Sub
End Class
