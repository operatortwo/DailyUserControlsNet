Imports System.Reflection

Public Class AboutWindow
    Private Sub Window_Loaded(sender As Object, e As RoutedEventArgs)
        Dim appver As String = [GetType].Assembly.GetName().Version.ToString
        Dim libname As AssemblyName = GetType(DailyUserControlsNet.ImageButton).Assembly.GetName
        Dim libver As String = libname.Version.ToString

        tbAppVersion.Text = appver
        tbLibVersion.Text = libver

        Dim currentAssem As Assembly = [GetType].Assembly

        'Dim comp As AssemblyCompanyAttribute = currentAssem.GetCustomAttribute(GetType(AssemblyCompanyAttribute))

        'tbDescription.Text = My.Application.Info.Description
        Dim descr As AssemblyDescriptionAttribute = currentAssem.GetCustomAttribute(GetType(AssemblyDescriptionAttribute))
        tbDescription.Text = descr.Description

        'tbCopyright.Text = My.Application.Info.Copyright
        Dim cpr As AssemblyCopyrightAttribute = currentAssem.GetCustomAttribute(GetType(AssemblyCopyrightAttribute))
        tbCopyright.Text = cpr.Copyright

        ' Dim str = My.Application.Info.Copyright
        ' To access My.Application:
        ' MyType:Windows and UseWindowsForms:True must be declared in Project file PropertyGroup
        ' ( Project, right click, -> Edit project file)
        ' <PropertyGroup>
        ' <../>
        ' <MyType>Windows</MyType>
        ' <UseWindowsForms>True</UseWindowsForms>
        ' <../>        
    End Sub
End Class
