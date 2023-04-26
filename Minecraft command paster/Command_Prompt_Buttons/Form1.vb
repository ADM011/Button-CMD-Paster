Imports System.IO.Ports
Imports System.Runtime.InteropServices
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1
    Private Const WM_SETTEXT As Integer = &HC
    Private Const WM_KEYDOWN As Integer = &H100

    Private Declare Function FindWindowEx Lib "user32" Alias "FindWindowExA" (ByVal hWnd1 As IntPtr, ByVal hWnd2 As IntPtr, ByVal lpsz1 As String, ByVal lpsz2 As String) As IntPtr
    Private Declare Function SendMessage Lib "user32" Alias "SendMessageA" (ByVal hWnd As IntPtr, ByVal wMsg As Integer, ByVal wParam As IntPtr, ByVal lParam As String) As IntPtr
    Private Declare Function PostMessage Lib "user32" Alias "PostMessageA" (ByVal hWnd As IntPtr, ByVal wMsg As Integer, ByVal wParam As IntPtr, ByVal lParam As IntPtr) As IntPtr

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cmdHwnd As IntPtr = FindWindowEx(IntPtr.Zero, IntPtr.Zero, "ConsoleWindowClass", Nothing)

        If cmdHwnd <> IntPtr.Zero Then
            ' Send the contents of the textbox to the command prompt window
            SendMessage(cmdHwnd, WM_SETTEXT, IntPtr.Zero, TextBox1.Text)
            PostMessage(cmdHwnd, WM_KEYDOWN, Keys.Enter, 0)
        Else
            MessageBox.Show("Command prompt not found")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim cmdHwnd As IntPtr = FindWindowEx(IntPtr.Zero, IntPtr.Zero, "ConsoleWindowClass", Nothing)

        If cmdHwnd <> IntPtr.Zero Then
            ' Send the contents of the textbox to the command prompt window
            SendMessage(cmdHwnd, WM_SETTEXT, IntPtr.Zero, TextBox2.Text)
            PostMessage(cmdHwnd, WM_KEYDOWN, Keys.Enter, 0)
        Else
            MessageBox.Show("Command prompt not found")
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        TextBox1.Text = "save"
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        TextBox1.Text = "stop"
    End Sub

End Class
