Imports System.ComponentModel

Public Class CustomTextBox
    Inherits TextBox
    Private baseForeColorSet = False
    Private placeholdeColorFirstTime = False
    Private foreColorTimes As Integer = 0
    Private placeholderColorTimes As Integer = 0
    Private _baseForeColor As Color
    Private _placeholder As String = ""
    Private _placeholderColor As Color

    Public Sub New()

    End Sub
    Public Overrides Property ForeColor As Color
        Get
            Return MyBase.ForeColor
        End Get
        Set(value As Color)
            MyBase.ForeColor = value
            SetBaseForeColor(value)

            'foreColorTimes = foreColorTimes + 1
            'If foreColorTimes = 2 Then
            '    _baseForeColor = value
            'Else
            '    _placeholderColor = value
            '    MyBase.ForeColor = value
            'End If
        End Set
    End Property

    Private Sub SetBaseForeColor(value As Color)
        If Not baseForeColorSet Then
            _baseForeColor = value
            baseForeColorSet = True
        End If
    End Sub
    Private Sub SetBasePlaceholderForeColor(value As Color)
        If Not placeholdeColorFirstTime Then
            _placeholderColor = value
            placeholdeColorFirstTime = True
            If baseForeColorSet Then
                ForeColor = value
            End If
        End If
    End Sub

    <Category("Placeholder")>
    <Description("Texto usado como Placeholder")>
    Property Placeholder As String
        Get
            Return _placeholder
        End Get
        Set(value As String)
            _placeholder = value
        End Set
    End Property

    <Category("Placeholder")>
    <Description("Color usado como Placeholder")>
    Property PlaceholderColor As Color
        Get
            Return _placeholderColor
        End Get
        Set(value As Color)
            _placeholderColor = value
            SetBasePlaceholderForeColor(value)
        End Set
    End Property
    Protected Overrides Sub OnEnter(e As EventArgs)
        MyBase.OnEnter(e)
        If Me.Text = Placeholder Then
            Me.Text = String.Empty
            Me.ForeColor = _baseForeColor
        End If
    End Sub

    Protected Overrides Sub OnLeave(e As EventArgs)
        MyBase.OnLeave(e)
        If String.IsNullOrEmpty(Me.Text) Then
            Me.Text = Placeholder
            Me.ForeColor = PlaceholderColor
        End If
    End Sub
End Class
