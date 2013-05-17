Imports Microsoft.Phone.Controls.Maps
Imports Location = System.Device.Location

Partial Public Class MainPage
    Inherits PhoneApplicationPage
    Dim Lat As Double = 38.7814
    Dim Long1 As Double = -77.13333
    Dim ZoomLevel As Integer = 15

    ' Constructor
    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub TextBox1_TextChanged(sender As System.Object, e As System.Windows.Controls.TextChangedEventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.Windows.RoutedEventArgs) Handles Button1.Click
        Lat = TextBox1.Text
        Long1 = TextBox2.Text
        Dim PushpinCustom = New Microsoft.Phone.Controls.Maps.Pushpin()
        PushpinCustom.Background = New SolidColorBrush(Colors.Blue)
        PushpinCustom.Foreground = New SolidColorBrush(Colors.White)
        PushpinCustom.Location = New Location.GeoCoordinate(Lat, Long1)
        PushpinCustom.Content = "Coordinates"
        Map1.Children.Add(PushpinCustom)
        Map1.SetView(New Location.GeoCoordinate(Lat, Long1, 20), 15)
    End Sub

    Private Sub PhoneApplicationPage_Loaded(sender As System.Object, e As System.Windows.RoutedEventArgs) Handles MyBase.Loaded
        Dim Pushpin2 = New Microsoft.Phone.Controls.Maps.Pushpin()
        Pushpin2.Background = New SolidColorBrush(Colors.Red)
        Pushpin2.Foreground = New SolidColorBrush(Colors.Black)
        Pushpin2.Location = New Location.GeoCoordinate(38.7814, -77.13333)
        Pushpin2.Content = "Edison High School"
        Map1.Children.Add(Pushpin2)
        Map1.SetView(New Location.GeoCoordinate(38.7814, -77.1333, 20), 15)

    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.Windows.RoutedEventArgs) Handles Button4.Click
        ZoomLevel = ZoomLevel - 1
        Map1.SetView(New Location.GeoCoordinate(Lat, Long1, 20), ZoomLevel)
    End Sub

    Private Sub Map1_DoubleTap(sender As System.Object, e As System.Windows.Input.GestureEventArgs) Handles Map1.DoubleTap
        ZoomLevel = ZoomLevel + 1
    End Sub
End Class
