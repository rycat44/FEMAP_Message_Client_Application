Imports System.Runtime.InteropServices
Public Class Form1

    Private Const WM_MOUSEWHEEL As Integer = &H20A
    Private Const WM_COPYDATA As Integer = &H4A

    Public Declare Function RegisterWindowMessage Lib "user32" Alias "RegisterWindowMessageA" (ByVal lpString As String) As Long

    Private Structure COPYDATASTRUCT
        Public dwData As IntPtr
        Public cbData As Integer
        Public lpData As String
    End Structure

    Public femap As Object
    Public Sub CaptureMessages()
        Dim rc As Long
        femap = GetObject(, "femap.model")

        rc = femap.feAppRegisterAddInPane(True, Me.Handle, Me.Handle, True, False, 2, 0)
        rc = femap.feAppRegisterMessageHandler(True, Me.Handle)
        'WM_FEMAP_MESSAGE = RegisterWindowMessage("FE_EVENT_MESSAGE")
        'PreviousWindowProc = SetWindowLong(Me.Handle, GWL_WNDPROC, AddressOf MsgWindowProc)
    End Sub

    Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)
        Select Case m.Msg
            Case WM_MOUSEWHEEL
                ' ...do something...
                Me.FemapMsgHandlerListBox.Items.Add("scrolling on Form")
                'Exit Sub ' Suppress Default Action (because we don't reach the last line below
            Case WM_COPYDATA
                'Me.FemapMsgHandlerListBox.Items.Add(m.Msg)
                Dim cds As COPYDATASTRUCT = DirectCast(Marshal.PtrToStructure(m.LParam, GetType(COPYDATASTRUCT)), COPYDATASTRUCT)
                Me.FemapMsgHandlerListBox.Items.Add(cds.lpData)

        End Select

        MyBase.WndProc(m)
    End Sub
    '================================================================
    ' Stop capturing messages
    '----------------------------------------------------------------
    Public Sub ReleaseMessages()
        Dim rc As Long
        'If PreviousWindowProc Then
        rc = femap.feAppRegisterAddInPane(False, Me.Handle, Me.Handle, True, False, 2, 0)
        rc = femap.feAppRegisterMessageHandler(False, Me.Handle)
        Environment.Exit(0)
        'rc = SetWindowLong(Me.Handle, GWL_WNDPROC, PreviousWindowProc)
        'PreviousWindowProc = 0
        'End If
    End Sub

    '------------------------- Form events ---------------------------------------
    Private Sub CaptureMsgButton_Click(sender As Object, e As EventArgs) Handles CaptureMsgButton.Click
        CaptureMessages()
    End Sub

    Private Sub ListModelInfoButton_Click(sender As Object, e As EventArgs) Handles ListModelInfoButton.Click
        Dim rc As Long
        rc = femap.feFileProgramRun(False, True, False, "{LI}")
    End Sub

    Private Sub ReleaseMsgButton_Click(sender As Object, e As EventArgs) Handles ReleaseMsgButton.Click
        ReleaseMessages()
    End Sub

    Private Sub Form1_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        ReleaseMessages()
    End Sub

    Private Structure RECT
        Public Left As Long
        Public Top As Long
        Public Right As Long
        Public Bottom As Long
    End Structure

    Private Declare Function GetWindowRect Lib "user32" (ByVal hWnd As Long,
    lpRect As RECT) As Long

    ' get a window's size in pixel
    Sub GetWindowSize(ByVal hWnd As Long, Width As Long, Height As Long)
        Dim rcc As RECT
        Dim localByName As Process() = Process.GetProcessesByName("notepad")
        GetWindowRect(hWnd, rcc)
        Width = rcc.Right - rcc.Left
        Height = rcc.Bottom - rcc.Top
    End Sub

End Class