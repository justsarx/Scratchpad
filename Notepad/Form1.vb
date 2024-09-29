Imports System.Diagnostics.Eventing.Reader
Imports System.IO

Public Class Form1
    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        Dim newresult As MsgBoxResult
        newresult = MsgBox("Clear Buffer ?", vbOKCancel + vbExclamation, "New")
        If newresult = vbOK Then
            Me.Text = "Scratchpad - Untitled"
            RichTextBox1.Text = ""
        Else
            Return
        End If
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        Dim openresult As DialogResult = OpenFileDialog1.ShowDialog()
        If openresult = DialogResult.OK Then
            RichTextBox1.Text = ""
            Using sr As StreamReader = New StreamReader(OpenFileDialog1.FileName)
                RichTextBox1.Text = sr.ReadToEnd
            End Using
            Me.Text = Format("Scratchpad - " + OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        If SaveFileDialog1.FileName = "" Then
            SaveAsToolStripMenuItem_Click(sender, e)
        Else
            Using sr As New StreamWriter(SaveFileDialog1.FileName)
                sr.WriteLine(RichTextBox1.Text)
            End Using
        End If

    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveAsToolStripMenuItem.Click
        Dim saveresult As DialogResult = SaveFileDialog1.ShowDialog()
        If saveresult = DialogResult.OK Then
            Using sr As New StreamWriter(SaveFileDialog1.FileName)
                sr.WriteLine(RichTextBox1.Text)
            End Using
            Me.Text = Format("Scratchpad - " + SaveFileDialog1.FileName)
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        If SaveFileDialog1.FileName = "" Then
            Dim exitresult As MsgBoxResult
            exitresult = MsgBox("Quit without saving ?", vbYesNoCancel + vbExclamation, "Exit")
            If exitresult = MsgBoxResult.Cancel Then
                Return
            ElseIf exitresult = MsgBoxResult.Yes Then
                Me.Close()
            ElseIf exitresult = MsgBoxResult.No Then
                SaveAsToolStripMenuItem_Click(sender, e)
            End If
        Else
            Me.Close()
        End If
    End Sub

    Private Sub CutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CutToolStripMenuItem.Click
        RichTextBox1.Cut()
    End Sub

    Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem.Click
        RichTextBox1.Copy()
    End Sub

    Private Sub PasteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PasteToolStripMenuItem.Click
        RichTextBox1.Paste()
    End Sub

    Private Sub FontToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FontToolStripMenuItem.Click
        Dim fontresult As DialogResult
        fontresult = FontDialog1.ShowDialog()
        If fontresult = DialogResult.OK Then
            RichTextBox1.Font = FontDialog1.Font
        End If
    End Sub

    Private Sub ZoomInToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ZoomInToolStripMenuItem.Click
        RichTextBox1.Font = New Font(RichTextBox1.Font.FontFamily, RichTextBox1.Font.Size + 1, RichTextBox1.Font.Style)
    End Sub

    Private Sub ZoomOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ZoomOutToolStripMenuItem.Click
        RichTextBox1.Font = New Font(RichTextBox1.Font.FontFamily, RichTextBox1.Font.Size - 1, RichTextBox1.Font.Style)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Scratchpad - Untitled"
    End Sub
End Class
