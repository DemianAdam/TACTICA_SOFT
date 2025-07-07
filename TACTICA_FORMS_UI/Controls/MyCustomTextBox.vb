Imports System.ComponentModel
Imports System.Drawing.Design

Public Class MyCustomTextBox
    Inherits UserControl
    Private _baseForeColorSetted As Boolean = False
    Private _placeholdeColorSetted As Boolean = False
    Private _baseMaskSetted As Boolean = False
    Private _baseForeColor As Color
    Private _placeholder As String = ""
    Private _placeholderColor As Color
    Private _baseMask As String
    Private _baseEmptyMask As String
    Private _numericOnly As Boolean
    Public Sub New()
        InitializeComponent()
        Me.Padding = New Padding(0)
        Me.Margin = New Padding(0)
        MaskedTextBox1.BorderStyle = BorderStyle.None
        MaskedTextBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        MaskedTextBox1.Font = Me.Font
        Me.Height = MaskedTextBox1.PreferredHeight + Me.Padding.Vertical
    End Sub

    <Category("Numeric")>
    <Description("Establece el Textbox para solo admitir numeros")>
    Public Property NumericOnly As Boolean
        Get
            Return _numericOnly
        End Get
        Set(value As Boolean)
            _numericOnly = value
        End Set
    End Property

    Public Property Mask As String
        Get
            Return _baseMask
        End Get
        Set(value As String)
            _baseMask = value
            If Not String.IsNullOrEmpty(value) Then
                _baseEmptyMask = New MaskedTextProvider(value).ToString()
            End If
        End Set
    End Property
    Protected Overrides Sub OnEnter(e As EventArgs)
        MyBase.OnEnter(e)
        If Me.MaskedTextBox1.Text = Placeholder Then
            Me.MaskedTextBox1.Text = String.Empty
            If _baseMask IsNot Nothing Then
                Me.MaskedTextBox1.Mask = _baseMask
            End If

            MaskedTextBox1.ForeColor = _baseForeColor

        End If
        Dim caretPosition As Integer = Me.MaskedTextBox1.Text.Length
        If Not String.IsNullOrEmpty(Me.MaskedTextBox1.Mask) Then
            caretPosition = 0
            If Not String.IsNullOrEmpty(Me.Text) Then
                For index As Integer = Me.Text.Length - 1 To 0 Step -1
                    Dim character As Char = Me.Text(index)
                    If Char.IsDigit(character) Then
                        caretPosition = index + 1
                        Exit For
                    End If
                Next
            End If
        End If



        BeginInvoke(New MethodInvoker(Sub()
                                          MaskedTextBox1.SelectionStart = caretPosition
                                          MaskedTextBox1.SelectionLength = 0
                                      End Sub))

    End Sub

    Protected Overrides Sub OnLeave(e As EventArgs)
        MyBase.OnLeave(e)
        If Me.Text = _baseEmptyMask Then
            Me.MaskedTextBox1.Mask = Nothing
            Me.MaskedTextBox1.Text = ""
        End If
        If String.IsNullOrEmpty(Me.Text) Then
            Me.MaskedTextBox1.Text = Placeholder
            Me.MaskedTextBox1.ForeColor = PlaceholderColor
        End If
    End Sub

    <Category("Placeholder")>
    <Description("Color usado como Placeholder")>
    Property PlaceholderColor As Color
        Get
            Return _placeholderColor
        End Get
        Set(value As Color)
            _placeholderColor = value
        End Set
    End Property

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


    Public Overrides Property BackColor As Color
        Get
            Return MyBase.BackColor
        End Get
        Set(value As Color)
            MyBase.BackColor = value
            MaskedTextBox1.BackColor = value
        End Set
    End Property
    Protected Overrides Sub OnFontChanged(e As EventArgs)
        MyBase.OnFontChanged(e)
        MaskedTextBox1.Font = Me.Font
    End Sub

    Protected Overrides Sub OnResize(e As EventArgs)
        MyBase.OnResize(e)

        Dim clientW As Integer = Me.ClientSize.Width - Me.Padding.Horizontal
        Dim clientH As Integer = Me.ClientSize.Height - Me.Padding.Vertical
        MaskedTextBox1.Size = New Size(clientW, clientH)
    End Sub
    Protected Overrides Sub OnPaddingChanged(e As EventArgs)
        MyBase.OnPaddingChanged(e)
        Me.Size = New Size(MaskedTextBox1.Size.Width, MaskedTextBox1.PreferredHeight + Me.Padding.Vertical + 2)
    End Sub
    Protected Overrides Sub SetBoundsCore(x As Integer, y As Integer, width As Integer, height As Integer, specified As BoundsSpecified)
        MyBase.SetBoundsCore(x, y, width, MaskedTextBox1.PreferredHeight + Me.Padding.Vertical + 2, specified)
    End Sub

    <Browsable(True)>
    <EditorBrowsable(EditorBrowsableState.Always)>
    <DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
    <Bindable(True)>
    Public Overrides Property Text As String
        Get
            Return MaskedTextBox1.Text
        End Get
        Set(value As String)
            If String.IsNullOrEmpty(value) OrElse value = Placeholder Then
                MaskedTextBox1.Text = Placeholder
                MaskedTextBox1.ForeColor = _placeholderColor
            Else
                MaskedTextBox1.Text = value
                MaskedTextBox1.ForeColor = _baseForeColor
            End If

        End Set
    End Property

    Private Sub MyCustomTextBox_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _baseForeColor = Me.ForeColor
        If Not String.IsNullOrEmpty(Placeholder) Then
            If Not (Me.DesignMode OrElse LicenseManager.UsageMode = LicenseUsageMode.Designtime) Then
                Me.ForeColor = PlaceholderColor
            End If
            Me.Text = Placeholder

        End If
    End Sub

    Public Event TextChangedPublic As EventHandler
    Private Sub MaskedTextBox1_TextChanged(sender As Object, e As EventArgs) Handles MaskedTextBox1.TextChanged
        RaiseEvent TextChangedPublic(Me, e)
    End Sub

    Private Sub MaskedTextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MaskedTextBox1.KeyPress
        If NumericOnly Then
            ' Allow digits and control characters (Backspace, etc.)
            If Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar) Then
                Exit Sub
            End If

            ' Allow only one decimal point (adapt "." if needed for locale)
            If (e.KeyChar = "."c OrElse e.KeyChar = ","c) AndAlso Not Me.Text.Contains(e.KeyChar) Then
                Exit Sub
            End If

            ' Otherwise, block the input
            e.Handled = True
        End If
    End Sub
End Class
