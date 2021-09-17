Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.IO
Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.Reflection

Public Class ImageHelper

    Public Shared Function ByteArrayToImage(ByVal byteArrayIn As Byte()) As Image

        Dim ms As New MemoryStream(byteArrayIn)
        Return Image.FromStream(ms)

    End Function

    Public Shared Function ImageToByteArray(ByVal imageIn As Image) As Byte()
       
        Dim ms As New MemoryStream()
        Dim bmap As New Bitmap(imageIn, 320, 288)
        bmap.Save(ms, imageIn.RawFormat)
        Return ms.ToArray()

    End Function

    Public Shared Function ConvertToByteArray(ByVal value As Bitmap) As Byte()

        Dim bitmapBytes As Byte()

        Using stream As New System.IO.MemoryStream

            value.Save(stream, value.RawFormat)

            bitmapBytes = stream.ToArray

        End Using
        Return bitmapBytes

    End Function

    Public Shared Function ObtenerImagenNoDisponible() As Image

        Dim assembly As Assembly = System.Reflection.Assembly.GetExecutingAssembly()

        Dim file As Stream = assembly.GetManifestResourceStream("Helpers.NoDisponible.jpg")
        Return Image.FromStream(file)

    End Function

End Class

