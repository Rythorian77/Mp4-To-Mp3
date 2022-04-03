Imports System.IO

Public Class Form1

    Dim proc As New Process

    Dim Dura As Double

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BackgroundWorker1.WorkerReportsProgress = True
        ImageAssignment()
    End Sub

    Private Sub ImageAssignment()

        PictureBox1.Visible = True
        PictureBox1.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "../../Images/logo.gif")

        PictureBox2.Visible = True
        PictureBox2.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "../../Images/logo.gif")

        PictureBox3.Visible = True
        PictureBox3.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "../../Images/giphy.gif")

        PictureBox4.Visible = True
        PictureBox4.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "../../Images/giphy.gif")
    End Sub

    'Open File Dialog
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        OpenFileDialog1.Title = "Select Source"
        OpenFileDialog1.Filter = "Supported File Types(*.avi, *.flv, *.mov, *.mp4)|*.avi; *.flv; *.mov; *.mp4"
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim input As String = OpenFileDialog1.FileName
            TextBox1.Text = input
            TextBox3.Text = Path.GetFileNameWithoutExtension(input) + ".mp3"
        End If
    End Sub

    'Save
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If FolderBrowserDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            TextBox2.Text = FolderBrowserDialog1.SelectedPath + "\" + TextBox3.Text
        End If
    End Sub

    'Convert/Transmute
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        BackgroundWorker1.RunWorkerAsync()
        Button3.Enabled = False
    End Sub

    Function StartConvert()
        CheckForIllegalCrossThreadCalls = False
        Dim StartInfo As New ProcessStartInfo
        Dim cmd As String = " -i """ + TextBox1.Text + """ -vn """ + TextBox2.Text + """"
        StartInfo.FileName = Application.StartupPath + ".\bin\ffmpeg.exe"
        StartInfo.Arguments = cmd
        StartInfo.UseShellExecute = False
        StartInfo.WindowStyle = ProcessWindowStyle.Hidden
        StartInfo.RedirectStandardError = True
        StartInfo.RedirectStandardOutput = True
        proc.StartInfo = StartInfo
        Application.DoEvents()
        proc.Start()
        lblStatus.Text = "Status : Transmuting...."
        Dim ffmpegStream As StreamReader = proc.StandardError
        Dim ffmpegStreamLine As String
        Do
            ffmpegStreamLine = ffmpegStream.ReadLine
            TextBox4.AppendText(ffmpegStreamLine & vbNewLine)
            If ffmpegStreamLine.Contains("Duration:") Then
                Dim str As String = ffmpegStreamLine.Substring(ffmpegStreamLine.IndexOf(":") + 2)
                Dura = TimeSpan.Parse(str.Remove(str.IndexOf(","))).TotalSeconds
            ElseIf ffmpegStreamLine.Contains("time=") Then
                Dim str2 As String = ffmpegStreamLine.Substring(ffmpegStreamLine.IndexOf(":") - 2)
                Dim percent As String = Convert.ToInt32(TimeSpan.Parse(str2.Remove(str2.IndexOf("b") - 1)).TotalSeconds / Dura * 100)
                If percent > 0 Then
                    ProgressBar2.Value = percent
                End If
            End If

        Loop Until proc.HasExited
        Return 0
    End Function

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        StartConvert()
        ProgressBar2.Minimum = 0
        ProgressBar2.Maximum = 100
        For i = 0 To ProgressBar2.Maximum
            BackgroundWorker1.ReportProgress(i)
        Next
    End Sub

    Private Sub BackgroundWorker1_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged

        ProgressBar2.Value = e.ProgressPercentage
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        MsgBox("Processing is Complete 😊", MsgBoxStyle.OkOnly)
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        BackgroundWorker1.Dispose()
        GC.Collect()
        GC.WaitForPendingFinalizers()
        Application.Exit()
    End Sub

    Private Sub MergeReactor_Click(sender As Object, e As EventArgs) Handles MergeReactor.Click
        Hide()
        Dim unify As New Merge
        unify.Show()
    End Sub

    Private Sub AudioSurgeon_Click(sender As Object, e As EventArgs) Handles AudioSurgeon.Click
        Hide()
        Dim scalpel As New Audio_Surgeon
        scalpel.Show()
    End Sub


    'AppDomain.CurrentDomain.BaseDirectory & "../../Images/en_us.aff"
End Class
