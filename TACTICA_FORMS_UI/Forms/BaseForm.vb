Imports System.Runtime.InteropServices

Public Class BaseForm
    Protected Const WM_NCLBUTTONDOWN As Integer = &HA1
    Protected Const HTCAPTION As Integer = 2
    Protected Const WM_SYSCOMMAND As Integer = &H112
    Protected Const SC_MINIMIZE As Integer = &HF020
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

End Class