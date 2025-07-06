Imports System.Drawing.Imaging
Imports System.Runtime.InteropServices

Public Class BaseForm
    Inherits System.Windows.Forms.Form
    Protected Const WM_NCLBUTTONDOWN As Integer = &HA1
    Protected Const HTCAPTION As Integer = 2
    Protected Const WM_SYSCOMMAND As Integer = &H112
    Protected Const SC_MINIMIZE As Integer = &HF020
    Private ReadOnly formFactory As FormFactory
    Private displayedForm As Form
    Public Sub New()
        InitializeComponent()
    End Sub
    Public Sub New(formFactory As FormFactory)
        InitializeComponent()
        Me.formFactory = formFactory

    End Sub
    Protected Overrides Sub WndProc(ByRef m As Message)
        If m.Msg = &H84 Then ' WM_NCHITTEST
            Const resizeArea As Integer = 10
            Dim cursorPosition As Point = PointToClient(New Point(m.LParam.ToInt32() And &HFFFF, m.LParam.ToInt32() >> 16))

            Dim inLeft As Boolean = cursorPosition.X <= resizeArea
            Dim inRight As Boolean = cursorPosition.X >= ClientSize.Width - resizeArea
            Dim inTop As Boolean = cursorPosition.Y <= resizeArea
            Dim inBottom As Boolean = cursorPosition.Y >= ClientSize.Height - resizeArea

            ' Corners
            If inLeft AndAlso inTop Then
                m.Result = New IntPtr(13) ' HTTOPLEFT
                Return
            ElseIf inRight AndAlso inTop Then
                m.Result = New IntPtr(14) ' HTTOPRIGHT
                Return
            ElseIf inLeft AndAlso inBottom Then
                m.Result = New IntPtr(16) ' HTBOTTOMLEFT
                Return
            ElseIf inRight AndAlso inBottom Then
                m.Result = New IntPtr(17) ' HTBOTTOMRIGHT
                Return
            End If

            ' Edges
            If inTop Then
                m.Result = New IntPtr(12) ' HTTOP
                Return
            ElseIf inBottom Then
                m.Result = New IntPtr(15) ' HTBOTTOM
                Return
            ElseIf inLeft Then
                m.Result = New IntPtr(10) ' HTLEFT
                Return
            ElseIf inRight Then
                m.Result = New IntPtr(11) ' HTRIGHT
                Return
            End If
        End If

        MyBase.WndProc(m)
    End Sub

    Protected Sub MoveForm(e As MouseEventArgs)
        If e.Button = MouseButtons.Left Then
            ReleaseCapture()
            SendMessage(Me.Handle, WM_NCLBUTTONDOWN, New IntPtr(HTCAPTION), IntPtr.Zero)
        End If
    End Sub


    <DllImport("user32.dll")>
    Protected Shared Function SendMessage(hWnd As IntPtr, msg As Integer, wParam As IntPtr, lParam As IntPtr) As IntPtr
    End Function
    <DllImport("user32.dll")>
    Protected Shared Function ReleaseCapture() As Boolean
    End Function

    Protected Sub OpenForm(Of T As Form)(panel As Panel)
        If TypeOf displayedForm IsNot T Then
            displayedForm?.Close()
            Dim form As T = formFactory.CreateForm(Of T)()
            displayedForm = form
            form.TopLevel = False
            form.FormBorderStyle = FormBorderStyle.None
            form.BackgroundImage = ChangeOpacity(My.Resources.tacticalsoft_logo_, 0.01)
            form.BackgroundImageLayout = ImageLayout.Zoom
            form.Dock = DockStyle.Fill
            panel.Controls.Add(form)
            form.BringToFront()
            form.Show()
        End If
    End Sub

    Public Shared Function ChangeOpacity(ByVal img As Image, ByVal opacityvalue As Single) As Bitmap
        Dim bmp As New Bitmap(img.Width, img.Height)
        Dim graphics__1 As Graphics = Graphics.FromImage(bmp)
        Dim colormatrix As New ColorMatrix
        colormatrix.Matrix33 = opacityvalue
        Dim imgAttribute As New ImageAttributes
        imgAttribute.SetColorMatrix(colormatrix, ColorMatrixFlag.[Default], ColorAdjustType.Bitmap)
        graphics__1.DrawImage(img, New Rectangle(0, 0, bmp.Width, bmp.Height), 0, 0, img.Width, img.Height,
        GraphicsUnit.Pixel, imgAttribute)
        graphics__1.Dispose()
        Return bmp
    End Function
End Class