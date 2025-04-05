Imports System.Security.AccessControl
Imports System.Windows.Interop
Imports DailyUserControlsNet

Class MainWindow
    Private Sub TabControlExpander_HelpButtonClick(sender As Object, e As RoutedEventArgs)
        MessageWindow.Show(Me, "The Help Button on TabControlExpander" & vbCrLf & "was clicked", "Click event",
                           MessageIcon.Information, Brushes.Cornsilk, 12)
    End Sub
End Class
