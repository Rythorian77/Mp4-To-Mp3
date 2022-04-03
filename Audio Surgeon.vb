Imports NAudio.Wave
Imports NAudio.Wave.SampleProviders

Public Class Audio_Surgeon

    Shadows startPosition As New TimeSpan
    Dim endPosition As TimeSpan


    Private Sub Audio_Surgeon_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Audio_Surgeon_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Hide()
        Dim mother As New Form1
        mother.Show()
    End Sub

    Private Sub OpenFile_Click(sender As Object, e As EventArgs) Handles OpenFile.Click
        Dim start As New OpenFileDialog With {
          .Multiselect = False,
          .Filter = "All Media Files|*.wav;*.aac;*.wma;*.wmv;*.avi;*.mpg;*.mpeg;*.m1v;*.mp2;*.mp3;*.mpa;*.mpe;*.m3u;*.mp4;*.mov;*.3g2;*.3gp2;*.3gp;*.3gpp;*.m4a;*.cda;*.aif;*.aifc;*.aiff;*.mid;*.midi;*.rmi;*.mkv;*.WAV;*.AAC;*.WMA;*.WMV;*.AVI;*.MPG;*.MPEG;*.M1V;*.MP2;*.MP3;*.MPA;*.MPE;*.M3U;*.MP4;*.MOV;*.3G2;*.3GP2;*.3GP;*.3GPP;*.M4A;*.CDA;*.AIF;*.AIFC;*.AIFF;*.MID;*.MIDI;*.RMI;*.MKV",
          .InitialDirectory = "C:\"
      }
        If start.ShowDialog = Windows.Forms.DialogResult.OK Then
            TextBox1.Text = start.FileName


        End If
    End Sub

    Public Function CutAudio(wave As WaveStream, startPosition As TimeSpan, endPosition As TimeSpan) As IWaveProvider
        Dim sourceProvider As ISampleProvider = wave.ToSampleProvider()
        Dim currentPosition As Long = wave.Position
        wave.Position = currentPosition
        Dim offset2 As New OffsetSampleProvider(sourceProvider) With {
        .SkipOver = (endPosition - startPosition),
        .Take = TimeSpan.Zero
    }
        Dim offset1 As New OffsetSampleProvider(sourceProvider) With {
        .Take = startPosition
    }
        Return (offset1.FollowedBy(offset2)).ToWaveProvider()
    End Function


    REM: I tried using 2 Textboxes to enter the time intervals when trimming an audio file and TimeSpan.Parse
    REM: and it kept telling me (String is not a valid member of Timespan.) I tried numerous attepts to make it work and
    REM: found that using DirectCast
    Private Sub Statis()
        Dim outputFile As String = My.Computer.FileSystem.SpecialDirectories.Desktop & "\output.wav"     '"C:\Users\justin.ross\Desktop\Output.wav"

        Dim reader As New AudioFileReader(TextBox1.Text)
        REM: Without the use of a Combobox, replace "Cbox1.Text", and "Cbox2.Text" the numbers below that are greyed out.
        REM: You can set it to any desired time frame.
        REM: This >> Statis() will have to go into Form1_Load if you do.

        startPosition = TimeSpan.Parse("00:00:05.000") '"00:00:05.000"

        endPosition = TimeSpan.Parse("00:00:05.000") '"00:00:05.000"  

        Dim wave As IWaveProvider = CutAudio(reader, startPosition, endPosition)
        WaveFileWriter.CreateWaveFile(outputFile, wave)
    End Sub



End Class