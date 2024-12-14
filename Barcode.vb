Imports MessagingToolkit.Barcode
Imports AForge.Video
Imports AForge.Video.DirectShow
Public Class Barcode

    ' Variables for camera capture
    Private videoSource As VideoCaptureDevice
    Private videoDevices As FilterInfoCollection
    Private isCameraRunning As Boolean = False

    ' MessagingToolkit.Barcode instance
    Private barcodeDecoder As MessagingToolkit.Barcode.BarcodeDecoder

    Private Sub Barcode_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Initialize barcode decoder
        barcodeDecoder = New MessagingToolkit.Barcode.BarcodeDecoder()

        ' Get video devices (webcams)
        videoDevices = New FilterInfoCollection(FilterCategory.VideoInputDevice)
        If videoDevices.Count > 0 Then
            For Each device As FilterInfo In videoDevices
                Debug.WriteLine("Found device: " & device.Name) ' Debugging
            Next
            videoSource = New VideoCaptureDevice(videoDevices(0).MonikerString)
        Else
            MessageBox.Show("No webcam found.")
        End If
    End Sub

    Private Sub btnScanBarcode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnScanBarcode.Click
        If videoSource IsNot Nothing Then
            Try
                AddHandler videoSource.NewFrame, AddressOf Video_NewFrame
                videoSource.Start()
                isCameraRunning = True
                MessageBox.Show("Camera started successfully.")
            Catch ex As Exception
                MessageBox.Show("Error starting camera: " & ex.Message)
            End Try
        Else
            MessageBox.Show("No webcam available for scanning.")
        End If
    End Sub

    Private Sub btnCapture_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCapture.Click
        If isCameraRunning AndAlso videoSource IsNot Nothing Then
            Try
                ' Capture the current frame
                Dim frame As Bitmap = CType(picCamera.Image, Bitmap)

                ' Preprocess the image (optional)
                Dim processedFrame As Bitmap = PreprocessImage(frame)

                ' Decode the barcode from the processed frame
                Dim result = barcodeDecoder.Decode(processedFrame)
                If result IsNot Nothing Then
                    txtBarcode.Text = result.Text ' Display the decoded text
                Else
                    MessageBox.Show("No barcode detected.")
                End If
            Catch ex As MessagingToolkit.Barcode.NotFoundException
                MessageBox.Show("No barcode found. Please adjust the camera or barcode.")
            Catch ex As Exception
                MessageBox.Show("Error capturing image or decoding barcode: " & ex.Message)
            End Try
        Else
            MessageBox.Show("Camera is not running.")
        End If
    End Sub
    Private Function PreprocessImage(ByVal image As Bitmap) As Bitmap
        ' Create a new bitmap for grayscale conversion
        Dim grayscaleImage As New Bitmap(image.Width, image.Height)

        ' Use graphics to apply a grayscale color matrix
        Using g As Graphics = Graphics.FromImage(grayscaleImage)
            ' Define the grayscale color matrix
            Dim colorMatrix As New Imaging.ColorMatrix(New Single()() {
                New Single() {0.3F, 0.3F, 0.3F, 0, 0},
                New Single() {0.59F, 0.59F, 0.59F, 0, 0},
                New Single() {0.11F, 0.11F, 0.11F, 0, 0},
                New Single() {0, 0, 0, 1, 0},
                New Single() {0, 0, 0, 0, 1}
            })

            ' Create image attributes to use the color matrix
            Dim attributes As New Imaging.ImageAttributes()
            attributes.SetColorMatrix(colorMatrix)

            ' Draw the original image as grayscale
            g.DrawImage(image, New Rectangle(0, 0, image.Width, image.Height),
                        0, 0, image.Width, image.Height, GraphicsUnit.Pixel, attributes)
        End Using

        ' Return the processed grayscale image
        Return grayscaleImage
    End Function



    Private Sub Video_NewFrame(ByVal sender As Object, ByVal eventArgs As NewFrameEventArgs)
        Try
            Dim frame As Bitmap = CType(eventArgs.Frame.Clone(), Bitmap)
            picCamera.Image = frame
            Debug.WriteLine("New frame received.") ' Debugging
        Catch ex As Exception
            MessageBox.Show("Error in NewFrame: " & ex.Message)
        End Try
    End Sub

    Private Sub Barcode_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles MyBase.FormClosing
        If videoSource IsNot Nothing AndAlso videoSource.IsRunning Then
            videoSource.SignalToStop()
            videoSource.WaitForStop()
            videoSource.VideoResolution = videoSource.VideoCapabilities.Last() ' Select the highest resolution

        End If
    End Sub

    Public Property ScannedBarcode As String = ""

    ' Handles the barcode scanning
    Private Sub BarcodeForm_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        ' Simulate barcode scanning (you can replace this with actual scanner input logic)
        Dim scannedCode As String = "1234567890" ' This is a placeholder for actual scanned barcode.

        ' Set the scanned barcode value
        ScannedBarcode = scannedCode
    End Sub

    ' Close the form after scanning
    Private Sub CloseForm_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub
    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub
End Class

