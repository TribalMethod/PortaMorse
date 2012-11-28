Partial Public Class MainPage
    Inherits PhoneApplicationPage

    ' Constructor
    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.Windows.RoutedEventArgs) Handles Button1.Click
        If Button1.IsPressed Then
            Button1.Background = Color.Green

        Else
            Button1.Background = Color.LightGreen
        End If
    End Sub
End Class
