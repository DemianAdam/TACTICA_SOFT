﻿Imports System.ComponentModel

Public Class PlaceholderComboBox
    Inherits UserControl

    Private _placeholderColor As Color
    Private _placeholder As String
    Private _baseForeColor As Color
    Private _baseDatasource As Object

    Public Sub New()
        InitializeComponent()
        Me.Padding = New Padding(0)
        Me.ComboBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Me.ComboBox1.Font = Me.Font
        Me.Height = ComboBox1.PreferredHeight + Me.Padding.Vertical
        Me.DataSource = New List(Of Object)()
    End Sub

    Public Property DataSource As Object
        Get
            Return ComboBox1.DataSource
        End Get
        Set(value As Object)
            _baseDatasource = value
            ComboBox1.DataSource = value
        End Set
    End Property

    Public Property DisplayMember As String
        Get
            Return ComboBox1.DisplayMember
        End Get
        Set(value As String)
            ComboBox1.DisplayMember = value
        End Set
    End Property

    Protected Overrides Sub OnPaddingChanged(e As EventArgs)
        MyBase.OnPaddingChanged(e)
        Me.Size = New Size(Me.ComboBox1.Size.Width, Me.ComboBox1.PreferredHeight + Me.Padding.Vertical + 2)
    End Sub
    Protected Overrides Sub SetBoundsCore(x As Integer, y As Integer, width As Integer, height As Integer, specified As BoundsSpecified)
        MyBase.SetBoundsCore(x, y, width, Me.ComboBox1.PreferredHeight + Me.Padding.Vertical + 2, specified)
    End Sub
    Protected Overrides Sub OnResize(e As EventArgs)
        MyBase.OnResize(e)
        Dim clientW As Integer = Me.ClientSize.Width - Me.Padding.Horizontal
        Dim clientH As Integer = Me.ClientSize.Height - Me.Padding.Vertical
        Me.ComboBox1.Size = New Size(clientW, clientH)
    End Sub
    Public Overrides Property BackColor As Color
        Get
            Return MyBase.BackColor
        End Get
        Set(value As Color)
            MyBase.BackColor = value
            Me.ComboBox1.BackColor = value
        End Set
    End Property

    Property SelectedItem As Object
        Get
            Return ComboBox1.SelectedItem
        End Get
        Set(value As Object)
            If value Is Nothing Then
                ResetPlaceholder()
            ElseIf _baseDatasource IsNot Nothing Then
                ComboBox1.DataSource = _baseDatasource
                ComboBox1.SelectedItem = value
            Else
                ComboBox1.SelectedItem = value
            End If
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
            If isInDesignMode Then
                Me.ComboBox1.Text = value
                Me.ComboBox1.ForeColor = _placeholderColor
            End If
        End Set
    End Property

    Private ReadOnly Property IsDropDownList As Boolean
        Get
            Return If(Me.ComboBox1 IsNot Nothing, Me.ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList, False)
        End Get
    End Property
    Private ReadOnly Property isInDesignMode As Boolean
        Get
            Return Me.DesignMode OrElse LicenseManager.UsageMode = LicenseUsageMode.Designtime
        End Get
    End Property
    Protected Overrides Sub OnEnter(e As EventArgs)
        MyBase.OnEnter(e)
        ComboBox1.DataSource = _baseDatasource
        If IsDropDownList Then
            If Me.ComboBox1.SelectedItem?.ToString() = Placeholder Then
                Me.ComboBox1.ForeColor = _baseForeColor
            End If
        ElseIf Me.ComboBox1.Text = Placeholder Then
            Me.ComboBox1.Text = String.Empty
            Me.ComboBox1.ForeColor = _baseForeColor
        End If

    End Sub

    Protected Overrides Sub OnLeave(e As EventArgs)
        MyBase.OnLeave(e)

        If IsDropDownList AndAlso String.IsNullOrEmpty(ComboBox1.SelectedItem?.ToString()) Then
            ComboBox1.DataSource = Nothing
            If Not Me.ComboBox1.Items.Contains(Placeholder) Then
                Me.ComboBox1.Items.Add(Placeholder)
            End If
            Me.ComboBox1.SelectedItem = Placeholder
            Me.ComboBox1.ForeColor = PlaceholderColor
        ElseIf String.IsNullOrEmpty(Me.ComboBox1.Text) Then
            Me.ComboBox1.Text = Placeholder
            Me.ComboBox1.ForeColor = PlaceholderColor
        End If

    End Sub

    Public Sub ResetPlaceholder()
        Me.ComboBox1.DataSource = Nothing
        Me.ComboBox1.Items.Add(Placeholder)
        Me.ComboBox1.SelectedItem = Placeholder
    End Sub

    Protected Overrides Sub OnFontChanged(e As EventArgs)
        MyBase.OnFontChanged(e)
        Me.ComboBox1.Font = Me.Font
    End Sub
    Private Sub PlaceholderComboBox_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.DataSource = Nothing
        _baseForeColor = Me.ForeColor
        If String.IsNullOrEmpty(Placeholder) Then
            Return
        End If

        If Not isInDesignMode Then
            Me.ForeColor = PlaceholderColor
        ElseIf Not String.IsNullOrEmpty(Me.Text) Then
            Me.Text = Placeholder
        End If

        If Not String.IsNullOrEmpty(Me.Text) Then
            Return
        End If

        If IsDropDownList Then
            If Not Me.ComboBox1.Items.Contains(Placeholder) Then
                Me.ComboBox1.Items.Add(Placeholder)
            End If
            Me.ComboBox1.SelectedItem = Placeholder
        Else
            Me.ComboBox1.Text = Placeholder
        End If
    End Sub

    <Browsable(True)>
    <EditorBrowsable(EditorBrowsableState.Always)>
    <DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
    <Bindable(True)>
    Public Overrides Property Text As String
        Get
            Return Me.ComboBox1.Text
        End Get
        Set(value As String)
            Dim text As String
            Dim color As Color
            If String.IsNullOrEmpty(value) OrElse value = Placeholder Then
                text = Placeholder
                color = _placeholderColor
            Else
                text = value
                color = _baseForeColor
            End If

            If ComboBox1.DataSource Is Nothing Then
                If IsDropDownList Then
                    If Not Me.ComboBox1.Items.Contains(value) Then
                        Me.ComboBox1.Items.Add(value)
                    End If
                    Me.ComboBox1.SelectedItem = value
                Else
                    Me.ComboBox1.Text = text
                End If
            End If


            Me.ComboBox1.ForeColor = color
        End Set
    End Property


    Private Sub ComboBox1_DropDownClosed(sender As Object, e As EventArgs) Handles ComboBox1.DropDownClosed
        If ComboBox1.SelectedItem Is Nothing Then
            Text = Placeholder
        End If

        If ComboBox1.DataSource IsNot Nothing AndAlso String.IsNullOrEmpty(ComboBox1.SelectedItem?.ToString()) Then
            ComboBox1.DataSource = Nothing
            ComboBox1.Items.Add(Placeholder)
            ComboBox1.SelectedItem = Placeholder
        End If
    End Sub
    Public Event SelectedIndexChanged As EventHandler
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        RaiseEvent SelectedIndexChanged(sender, e)
    End Sub
End Class
