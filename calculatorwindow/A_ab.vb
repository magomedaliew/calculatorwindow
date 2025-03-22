Imports Windows.UI
Imports Windows.UI.Xaml.Shapes
Public Class A_ab
  Public Sub AAA(a As Canvas, ParamArray c() As Double)
    Dim aaaaa As New Line
    Dim aaaab As New Color
    If c(6) = 1 Then aaaab = Colors.Gray
    If c(6) = 2 Then aaaab = Colors.Orange
    If c(6) = 3 Then aaaab = Colors.Violet
    If c(6) = 0 Then aaaab = Colors.LightGray
    aaaaa.StrokeThickness = c(0) * c(5) : a.Children.Add(aaaaa) : aaaaa.Stroke = New SolidColorBrush(aaaab)
    aaaaa.X1 = c(0) * c(1) : aaaaa.X2 = c(0) * c(2) : aaaaa.Y1 = c(0) * c(3) : aaaaa.Y2 = c(0) * c(4)
    If c.Count > 7 Then aaaaa.Stroke = New SolidColorBrush(Color.FromArgb(255, c(6), c(7), c(8)))
  End Sub
  Public Sub AAB(a As Canvas, ParamArray c() As Double)
    Dim aaaaa As New Ellipse
    a.Children.Add(aaaaa)
    aaaaa.Width = c(0) * c(1) : aaaaa.Height = c(0) * c(2)
    aaaaa.Margin = New Thickness(c(0) * c(3), c(0) * c(4), 0, 0)
    aaaaa.Fill = New SolidColorBrush(Color.FromArgb(255, c(5), c(6), c(7)))
  End Sub
  Public Sub AAC(a As Canvas, ParamArray c() As Double)
    Dim aaaaa As New Rectangle
    a.Children.Add(aaaaa)
    aaaaa.StrokeThickness = c(0) * c(5)
    aaaaa.Stroke = New SolidColorBrush(Colors.SkyBlue)
    aaaaa.Width = c(0) * c(1) : aaaaa.Height = c(0) * c(2)
    aaaaa.Margin = New Thickness(c(0) * c(3), c(0) * c(4), 0, 0)
    aaaaa.Fill = New SolidColorBrush(Color.FromArgb(255, c(6), c(7), c(8)))
  End Sub
  Public Sub AAD(a As Canvas, ParamArray c() As Double)
    Dim aaaaa As New Canvas
    Dim aaaab As New GradientStop
    Dim aaaac As New GradientStop
    Dim aaaad As New CompositeTransform
    Dim aaaae As New LinearGradientBrush
    Dim aaaaf As New GradientStopCollection

    aaaad.SkewX = c(5)
    aaaad.SkewY = c(6)
    aaaaa.Width = c(0) * c(3)
    aaaaa.Height = c(0) * c(4)
    aaaaa.RenderTransform = aaaad
    aaaae.EndPoint = New Point(0, 0)
    aaaae.StartPoint = New Point(1, 1)
    aaaab.Offset = 0.1 : aaaaf.Add(aaaab)
    aaaac.Offset = 0.9 : aaaaf.Add(aaaac)
    aaaab.Color = Color.FromArgb(255, c(7), c(8), c(9))
    aaaaa.Margin = New Thickness(c(0) * c(1), c(0) * c(2), 0, 0)
    aaaac.Color = Color.FromArgb(100, c(7) - 5, c(8) - 10, c(9) - 50)
    aaaae.GradientStops = aaaaf : aaaaa.Background = aaaae : a.Children.Add(aaaaa)
  End Sub
  Public Sub AAF(a As Canvas, ParamArray c() As Double)
    'Bogen
    Dim aa As New Path
    Dim ab As New Color
    Dim ac As New ArcSegment
    Dim ad As New PathFigure
    Dim ae As New PathGeometry
    Dim af As New GeometryGroup
    Dim ag As New PathFigureCollection
    Dim ah As New PathSegmentCollection
    If c(8) = 1 Then ab = Colors.Gray
    If c(8) = 2 Then ab = Colors.Orange
    If c(8) = 3 Then ab = Colors.Violet
    If c(8) = 0 Then ab = Colors.LightGray
    ag.Add(ad) : aa.Stroke = New SolidColorBrush(ab) : aa.StrokeThickness = c(7)
    ah.Add(ac) : ad.Segments = ah : af.Children.Add(ae) : aa.Data = af : a.Children.Add(aa)
    If c.Count > 9 Then aa.Stroke = New SolidColorBrush(Color.FromArgb(255, c(8), c(9), c(10)))
    ad.StartPoint = New Point(c(0) * c(1), c(0) * c(2)) : ad.IsClosed = False : ae.Figures = ag
    ac.Size = New Size(c(0) * c(5), c(0) * c(6)) : ac.Point = New Point(c(0) * c(3), c(0) * c(4))
  End Sub
  Public Sub AAG(a As Canvas, ParamArray c() As Double)
    'Polygon
    'Ein Polygon ist eine Form mit einer Grenze, die durch eine beliebige Anzahl von Punkten definiert ist.
    'Die Grenze wird erstellt, indem eine Linie von einem Punkt zum nächsten verbunden wird, wobei der letzte
    'Punkt mit dem ersten Punkt verbunden wird.
    Dim polygon1 As New Polygon
    polygon1.Fill = New SolidColorBrush(Colors.LightBlue)
    Dim points As New PointCollection
    points.Add(New Point(10, 200))
    points.Add(New Point(60, 140))
    points.Add(New Point(130, 140))
    points.Add(New Point(180, 200))
    polygon1.Points = points
  End Sub
  Public Sub AAH(a As Canvas, ParamArray c() As Double)
    'Polyline
    'Eine Polylinie ähnelt einem Polygon dahingehend, dass die Grenze der Form durch eine Reihe von Punkten
    'definiert wird, außer dass der letzte Punkt in einer Polylinie nicht mit dem ersten Punkt verbunden ist.
    Dim polyline1 As New Polyline
    polyline1.Stroke = New SolidColorBrush(Colors.Black)
    polyline1.StrokeThickness = 4
    Dim points As New PointCollection
    points.Add(New Point(10, 200))
    points.Add(New Point(60, 140))
    points.Add(New Point(130, 140))
    points.Add(New Point(180, 200))
    polyline1.Points = points
    'PolyLineSegment polylinesegment1.Points.Add(New Point(200, 200))
  End Sub
  Public Sub AAI(a As Canvas, ParamArray c() As Double)
    'BezierSegment 1
    Dim aa As New Path
    Dim ab As New Color
    Dim ac As New PathFigure
    Dim ad As New PathGeometry
    Dim ae As New BezierSegment
    Dim af As New GeometryGroup
    Dim ag As New PathFigureCollection
    Dim ah As New PathSegmentCollection
    If c(10) = 1 Then ab = Colors.Gray
    If c(10) = 2 Then ab = Colors.Orange
    If c(10) = 3 Then ab = Colors.Violet
    If c(10) = 0 Then ab = Colors.LightGray
    ae.Point1 = New Point(c(0) * c(3), c(0) * c(4))
    ae.Point2 = New Point(c(0) * c(5), c(0) * c(6))
    ae.Point3 = New Point(c(0) * c(7), c(0) * c(8))
    ag.Add(ac) : aa.Stroke = New SolidColorBrush(ab) : aa.StrokeThickness = c(9)
    ah.Add(ae) : ac.Segments = ah : af.Children.Add(ad) : aa.Data = af : a.Children.Add(aa)
    If c.Count > 11 Then aa.Stroke = New SolidColorBrush(Color.FromArgb(255, c(10), c(11), c(12)))
    ac.StartPoint = New Point(c(0) * c(1), c(0) * c(2)) : ac.IsClosed = False : ad.Figures = ag
  End Sub
  Public Sub AAJ(a As Canvas, ParamArray c() As Double)
    'BezierSegment 2
    Dim aa As New Path
    Dim ab As New Color
    Dim ac As New PathFigure
    Dim ad As New PathGeometry
    Dim ae As New GeometryGroup
    Dim af As New PathFigureCollection
    Dim ag As New PathSegmentCollection
    Dim ah(11) As Double : a.Children.Add(aa)
    'Für r gleich von 10 bis 100
    ah(7) = c(5) : ah(10) = c(6) - c(5)
    If c(3) <> c(4) Then
      Dim ai, aj, ak, al, am, an, ao, ap As Boolean
      If c(6) > 0 And c(6) < 90 Then ai = True
      If c(6) < 0 And c(6) > -90 Then am = True
      If c(6) > 90 And c(6) < 180 Then aj = True
      If c(6) > 180 And c(6) < 270 Then ak = True
      If c(6) > 270 And c(6) < 360 Then al = True
      If c(6) < -90 And c(6) > -180 Then an = True
      If c(6) < -180 And c(6) > -270 Then ao = True
      If c(6) < -270 And c(6) > -360 Then ap = True
      If ai = True Then ah(10) = Math.Atan(Math.Tan(c(6) * Math.PI / 180) * c(3) / c(4)) * 180 / Math.PI
      If aj = True Then ah(10) = Math.Atan(Math.Tan(c(6) * Math.PI / 180) * c(3) / c(4)) * 180 / Math.PI + 180
      If ak = True Then ah(10) = Math.Atan(Math.Tan(c(6) * Math.PI / 180) * c(3) / c(4)) * 180 / Math.PI + 180
      If al = True Then ah(10) = Math.Atan(Math.Tan(c(6) * Math.PI / 180) * c(3) / c(4)) * 180 / Math.PI + 360
      If am = True Then ah(10) = Math.Atan(Math.Tan(c(6) * Math.PI / 180) * c(3) / c(4)) * 180 / Math.PI
      If an = True Then ah(10) = Math.Atan(Math.Tan(c(6) * Math.PI / 180) * c(3) / c(4)) * 180 / Math.PI - 180
      If ao = True Then ah(10) = Math.Atan(Math.Tan(c(6) * Math.PI / 180) * c(3) / c(4)) * 180 / Math.PI - 180
      If ap = True Then ah(10) = Math.Atan(Math.Tan(c(6) * Math.PI / 180) * c(3) / c(4)) * 180 / Math.PI - 360
      If ah(10) / c(6) < 0 Then ah(10) *= -1
      If c(5) > 0 And c(5) < 90 Then ai = True
      If c(5) < 0 And c(5) > -90 Then am = True
      If c(5) > 90 And c(5) < 180 Then aj = True
      If c(5) > 180 And c(5) < 270 Then ak = True
      If c(5) > 270 And c(5) < 360 Then al = True
      If c(5) < -90 And c(5) > -180 Then an = True
      If c(5) < -180 And c(5) > -270 Then ao = True
      If c(5) < -270 And c(5) > -360 Then ap = True
      If ai = True Then ah(11) = Math.Atan(Math.Tan(c(5) * Math.PI / 180) * c(3) / c(4)) * 180 / Math.PI
      If aj = True Then ah(11) = Math.Atan(Math.Tan(c(5) * Math.PI / 180) * c(3) / c(4)) * 180 / Math.PI + 180
      If ak = True Then ah(11) = Math.Atan(Math.Tan(c(5) * Math.PI / 180) * c(3) / c(4)) * 180 / Math.PI + 180
      If al = True Then ah(11) = Math.Atan(Math.Tan(c(5) * Math.PI / 180) * c(3) / c(4)) * 180 / Math.PI + 360
      If am = True Then ah(11) = Math.Atan(Math.Tan(c(5) * Math.PI / 180) * c(3) / c(4)) * 180 / Math.PI
      If an = True Then ah(11) = Math.Atan(Math.Tan(c(5) * Math.PI / 180) * c(3) / c(4)) * 180 / Math.PI - 180
      If ao = True Then ah(11) = Math.Atan(Math.Tan(c(5) * Math.PI / 180) * c(3) / c(4)) * 180 / Math.PI - 180
      If ap = True Then ah(11) = Math.Atan(Math.Tan(c(5) * Math.PI / 180) * c(3) / c(4)) * 180 / Math.PI - 360
      If ah(11) / c(5) < 0 Then ah(11) *= -1
      ah(10) -= ah(11) : ah(7) = ah(11)
    End If
    ah(0) = ah(10) : ah(10) /= 10
    ah(10) = Math.Round(ah(10), 0)
    If ah(10) = 0 Then ah(10) = 1
    If ah(10) < 0 Then ah(10) = -ah(10)
    ah(0) = ah(0) / ah(10) / 2
    For i = 1 To Convert.ToInt32(ah(10)) Step 1 ' 25
      Dim ax As New BezierSegment
      ah(8) = ah(7) + ah(0) : ah(9) = ah(8) + ah(0)
      ah(1) = c(1) + c(3) * Math.Cos(ah(7) * Math.PI / 180)
      ah(2) = c(2) - c(4) * Math.Sin(ah(7) * Math.PI / 180)
      ah(3) = c(1) + c(3) * Math.Cos(ah(8) * Math.PI / 180)
      ah(4) = c(2) - c(4) * Math.Sin(ah(8) * Math.PI / 180)
      ah(5) = c(1) + c(3) * Math.Cos(ah(9) * Math.PI / 180)
      ah(6) = c(2) - c(4) * Math.Sin(ah(9) * Math.PI / 180)
      ax.Point1 = New Point(c(0) * ah(1), c(0) * ah(2))
      ax.Point2 = New Point(c(0) * ah(3), c(0) * ah(4))
      ax.Point3 = New Point(c(0) * ah(5), c(0) * ah(6))
      ag.Add(ax) : ah(7) = ah(9)
    Next
    If c(8) = 1 Then ab = Colors.Gray
    If c(8) = 2 Then ab = Colors.Orange
    If c(8) = 3 Then ab = Colors.Violet
    If c(8) = 0 Then ab = Colors.LightGray
    ah(1) = c(1) + c(3) * Math.Cos(ah(11) * Math.PI / 180)
    ah(2) = c(2) - c(4) * Math.Sin(ah(11) * Math.PI / 180)
    aa.Stroke = New SolidColorBrush(ab) : aa.StrokeThickness = c(7)
    af.Add(ac) : ac.Segments = ag : ae.Children.Add(ad) : aa.Data = ae
    If c.Count > 9 Then aa.Stroke = New SolidColorBrush(Color.FromArgb(255, c(8), c(9), c(10)))
    ac.StartPoint = New Point(c(0) * ah(1), c(0) * ah(2)) : ac.IsClosed = False : ad.Figures = af
  End Sub
  Public Sub AAW(a As Canvas, ParamArray c() As Double)
    'Path
    'Ein Pfad ist die vielseitigste Form, da Sie damit eine beliebige Geometrie definieren können.
    'Mit dieser Vielseitigkeit geht jedoch auch Komplexität einher.
    Dim path1 As New Path
    path1.Fill = New SolidColorBrush(Color.FromArgb(255, 204, 204, 255))
    path1.Stroke = New SolidColorBrush(Colors.Black)
    path1.StrokeThickness = 1

    Dim geometryGroup1 As New GeometryGroup
    Dim rectangleGeometry1 As New RectangleGeometry
    rectangleGeometry1.Rect = New Rect(50, 5, 100, 10)
    Dim rectangleGeometry2 As New RectangleGeometry
    rectangleGeometry2.Rect = New Rect(5, 5, 95, 180)
    geometryGroup1.Children.Add(rectangleGeometry1)
    geometryGroup1.Children.Add(rectangleGeometry2)

    Dim ellipseGeometry1 As New EllipseGeometry
    ellipseGeometry1.Center = New Point(100, 100)
    ellipseGeometry1.RadiusX = 20
    ellipseGeometry1.RadiusY = 30
    geometryGroup1.Children.Add(ellipseGeometry1)

    Dim pathGeometry1 As New PathGeometry
    Dim pathFigureCollection1 As New PathFigureCollection
    Dim pathFigure1 As New PathFigure
    pathFigure1.IsClosed = True
    pathFigure1.StartPoint = New Point(50, 50)
    pathFigureCollection1.Add(pathFigure1)
    pathGeometry1.Figures = pathFigureCollection1

    Dim pathSegmentCollection1 As New PathSegmentCollection
    Dim pathSegment1 As New BezierSegment
    pathSegment1.Point1 = New Point(75, 300)
    pathSegment1.Point2 = New Point(125, 100)
    pathSegment1.Point3 = New Point(150, 50)
    pathSegmentCollection1.Add(pathSegment1)

    Dim pathSegment2 As New BezierSegment
    pathSegment2.Point1 = New Point(125, 300)
    pathSegment2.Point2 = New Point(75, 100)
    pathSegment2.Point3 = New Point(50, 50)
    pathSegmentCollection1.Add(pathSegment2)
    pathFigure1.Segments = pathSegmentCollection1

    geometryGroup1.Children.Add(pathGeometry1)
    path1.Data = geometryGroup1

    a.Children.Add(path1)
  End Sub
  Public Sub AAX(a As Canvas, b As String, ParamArray c() As Double)
    Dim aaaaa As New Color
    Dim aaaac As New TextBlock

    Dim aaaad As New PlaneProjection
    Dim aaaae As New CompositeTransform
    aaaac.Text = b
    a.Children.Add(aaaac)
    aaaad.RotationZ = c(4)
    aaaac.Projection = aaaad
    aaaac.FontSize = c(0) * c(3)
    aaaac.RenderTransform = aaaae
    If c(5) = 1 Then aaaaa = Colors.Gray
    If c(5) = 2 Then aaaaa = Colors.Orange
    If c(5) = 3 Then aaaaa = Colors.Violet
    If c(5) = 0 Then aaaaa = Colors.LightGray
    aaaac.Foreground = New SolidColorBrush(aaaaa)
    aaaac.FontFamily = New FontFamily("Consolas")
    aaaac.Margin = New Thickness(c(0) * c(1), c(0) * c(2), 0, 0)
    If c.Count > 6 Then aaaac.Foreground = New SolidColorBrush(Color.FromArgb(255, c(5), c(6), c(7)))
  End Sub
  Public Sub AAY(a As Canvas, b As String, ParamArray c() As Double)
    Dim aaaaa As New Color
    Dim aaaac As New TextBlock
    Dim aaaad As New PlaneProjection
    Dim aaaae As New CompositeTransform

    aaaac.Text = b
    aaaae.SkewX = c(6)
    a.Children.Add(aaaac)
    aaaad.RotationZ = c(7)
    aaaac.Projection = aaaad
    aaaac.FontSize = c(0) * c(5)
    aaaac.RenderTransform = aaaae
    If c(1) <> 0 Then aaaac.Width = c(0) * c(3)
    If c(1) <> 0 Then aaaac.Height = c(0) * c(4)
    aaaac.Foreground = New SolidColorBrush(aaaaa)
    aaaac.Margin = New Thickness(c(0) * c(1), c(0) * c(2), 0, 0)
    If c(7) = 0 Then aaaac.TextAlignment = TextAlignment.Justify
    If c(7) <> 0 Then aaaac.TextAlignment = TextAlignment.Center
    If c(4) > c(5) Then aaaac.Padding = New Thickness(0, c(0) * (c(4) - c(5)) / 2, 0, 0)
    aaaac.Foreground = New SolidColorBrush(Color.FromArgb(255, c(8), c(9), c(10)))
  End Sub
End Class
