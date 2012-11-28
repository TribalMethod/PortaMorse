Imports System.Threading

Partial Public Class MainPage
    Inherits PhoneApplicationPage
    ' Public VC As VibrateController
    'Dim vibrate = New VibrateController
    ' Constructor
    Public Sub New()
        InitializeComponent()
    End Sub


    Private Sub Button1_Click(sender As System.Object, e As System.Windows.RoutedEventArgs) Handles Button1.Click
        'PARIS standard = 60 ms dot (1200/20 wpm); CODEX standard = 50 ms dot (1000/20 wpm)
        Dim DOT As Integer = 60
        Dim gap As Timer
        'Button1.Background = New SolidColorBrush(Colors.Green)

        'Dim VC As New VibrateController
        'Microsoft.Devices.VibrateController.Default.Start(TimeSpan.FromMilliseconds(1000))
        'Microsoft.Devices.VibrateController.Default.Stop()

        If Button1.IsPressed Then

            Microsoft.Devices.VibrateController.Default.Start(TimeSpan.FromMilliseconds(DOT * 3))
            Microsoft.Devices.VibrateController.Default.Stop()
            'System.Windows.Media.SystemSounds.Beep.Play()
            'Button1.Foreground = New SolidColorBrush(Colors.Red)

        Else

            'Button1.Foreground = New SolidColorBrush(Colors.Green)
            Microsoft.Devices.VibrateController.Default.Start(TimeSpan.FromMilliseconds(DOT))
            Microsoft.Devices.VibrateController.Default.Stop()
        End If

    End Sub

    Private Sub Button1_Hold(sender As Object, e As System.Windows.Input.GestureEventArgs) Handles Button1.Hold
        '
    End Sub

    Private Sub Button1_LostFocus(sender As Object, e As System.Windows.RoutedEventArgs) Handles Button1.LostFocus
        '        Button1.Background = New SolidColorBrush(Colors.LightGray)
    End Sub

    Private Sub Button1_LostMouseCapture(sender As Object, e As System.Windows.Input.MouseEventArgs) Handles Button1.LostMouseCapture
        '        Button1.Background = New SolidColorBrush(Colors.LightGray)
    End Sub

    Private Sub Button1_MouseLeftButtonUp(sender As Object, e As System.Windows.Input.MouseButtonEventArgs) Handles Button1.MouseLeftButtonUp
        '        Button1.Background = New SolidColorBrush(Colors.LightGray)
    End Sub

    Private Sub Button1_Tap(sender As Object, e As System.Windows.Input.GestureEventArgs) Handles Button1.Tap

    End Sub
End Class
