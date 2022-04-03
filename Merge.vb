Imports System.IO

Public Class Merge
    Private Sub Merge_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Merge_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Hide()
        Dim mother As New Form1
        mother.Show()
    End Sub

    Private Sub StartFile_Click(sender As Object, e As EventArgs) Handles StartFile.Click
        Dim start As New OpenFileDialog With {
            .Multiselect = False,
            .Filter = ".mp3|*.mp3"
        }
        If start.ShowDialog = Windows.Forms.DialogResult.OK Then
            Label2.Text = start.FileName
        End If
    End Sub

    Private Sub EndFile_Click(sender As Object, e As EventArgs) Handles EndFile.Click
        Dim start As New OpenFileDialog With {
          .Multiselect = False,
          .Filter = ".mp3|*.mp3"
      }
        If start.ShowDialog = Windows.Forms.DialogResult.OK Then
            Label4.Text = start.FileName
        End If
    End Sub

    Private Sub Coalesce_Click(sender As Object, e As EventArgs) Handles Coalesce.Click
        Dim save As New SaveFileDialog With {
            .Filter = ".mp3|*.mp3"
        }
        If save.ShowDialog = Windows.Forms.DialogResult.OK Then
            Label5.Text = save.FileName
            Dim fsFile1 As String = Label2.Text
            Dim fsFile2 As String = Label4.Text
            Dim fsFile3 As String = Label5.Text
            Dim fs1 As FileStream = Nothing
            Dim fs2 As FileStream = Nothing
            Dim fs3 As FileStream = Nothing
            Try
                fs1 = File.Open(fsFile1, FileMode.Open)
                fs2 = File.Open(fsFile1, FileMode.Open)
                fs3 = File.Open(fsFile1, FileMode.Append)
                Dim fs1Data As Byte() = New Byte(fs1.Length - 1) {}
                Dim fs2Data As Byte() = New Byte(fs2.Length - 1) {}
                fs1.Read(fs1Data, 0, CInt(fs1.Length))
                fs2.Read(fs2Data, 0, CInt(fs2.Length))
                fs1.Write(fs1Data, 0, CInt(fs1.Length))
                fs2.Write(fs2Data, 0, CInt(fs2.Length))
                MsgBox("File Fusion Has been Saved")
            Catch ex As Exception
                MsgBox(ex.Message + " : " + ex.StackTrace)
            Finally
                fs1.Close()
                fs2.Close()
                fs3.Close()
            End Try

        End If
    End Sub
End Class