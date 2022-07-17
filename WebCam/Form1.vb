Imports AForge
Imports AForge.Video
Imports AForge.Video.DirectShow
Imports System.IO
Public Class Form1
    Dim CAMARA As VideoCaptureDevice
    Dim BMP As Bitmap
    Dim Cap As String = "Capture"

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Try
            CAMARA.Stop()
            ' PictureBox2.Image = Nothing
        Catch ex As Exception
            Me.Dispose()
            'PictureBox2.Image = Nothing
        End Try
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmdno.Visible = False
        cmdok.Visible = False
        Dim CAMARAS As VideoCaptureDeviceForm = New VideoCaptureDeviceForm()

        If CAMARAS.ShowDialog() = DialogResult.OK Then
            CAMARA = CAMARAS.VideoDevice
            AddHandler CAMARA.NewFrame, New NewFrameEventHandler(AddressOf CAPTURAR)
            CAMARA.Start()

        Else

            Me.Close()

        End If
    End Sub
    Private Sub CAPTURAR(sender As Object, eventArgs As NewFrameEventArgs)

        BMP = DirectCast(eventArgs.Frame.Clone(), Bitmap)
        pbcaptureimage.Image = DirectCast(eventArgs.Frame.Clone(), Bitmap)


    End Sub
    Private Sub pbcapture_Click(sender As Object, e As EventArgs) Handles pbcapture.Click
        If Cap = "Capture" Then
            cmdno.Visible = True
            cmdok.Visible = True
            pbcapture.Visible = False
            CAMARA.Stop()
            Cap = "Start"
        ElseIf Cap = "Start" Then
            Dim CAMARAS As VideoCaptureDeviceForm = New VideoCaptureDeviceForm()
            CAMARA.Start()
            cmdno.Visible = False
            cmdok.Visible = False
            Cap = "Capture"
        End If
    End Sub

    Private Sub cmdno_Click(sender As Object, e As EventArgs) Handles cmdno.Click
        Dim CAMARAS As VideoCaptureDeviceForm = New VideoCaptureDeviceForm()
        CAMARA.Start()
        cmdno.Visible = False
        cmdok.Visible = False
        pbcapture.Visible = True
        Cap = "Capture"
    End Sub

    Private Sub cmdok_Click(sender As Object, e As EventArgs) Handles cmdok.Click
        Dim SD As New SaveFileDialog
        SD.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.Desktop
        SD.FileName = "Visual Capture " & Date.Now.ToString("MM/dd/yy")
        SD.SupportMultiDottedExtensions = True
        SD.AddExtension = True
        SD.Filter = "PNG File|*.png"
        If SD.ShowDialog() = DialogResult.OK Then
            Try
                pbcaptureimage.Image.Save(SD.FileName, Imaging.ImageFormat.Png)
                Dim CAMARAS As VideoCaptureDeviceForm = New VideoCaptureDeviceForm()
                CAMARA.Start()
                cmdno.Visible = False
                cmdok.Visible = False
                pbcapture.Visible = True
                Cap = "Capture"
            Catch ex As Exception

            End Try
        Else
            Dim CAMARAS As VideoCaptureDeviceForm = New VideoCaptureDeviceForm()
            CAMARA.Start()
            cmdno.Visible = False
            cmdok.Visible = False
            pbcapture.Visible = True
            Cap = "Capture"
        End If
    End Sub
End Class
