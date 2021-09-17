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








Function CARPETA(ByVal nCarpeta)

'Declaramos variables Dim olApp As Outlook.Application
Dim olApp As Outlook.Application
Dim olMail As Outlook.MailItem
Dim fin As Long, i As Long, file As Variant
Dim adjunto As String, nFile As String
Dim olMailItem As Variant, Celda As Variant
Dim Signature As String

'Iniciamos Funcion
With Sheets("AUX")
fin = Application.CountA(.Range("A:A"))
'recorremos hoja y celda para comprobar si hace
'referencia a varios archivos
For i = 2 To fin
Set olApp = CreateObject("Outlook.Application")
Set olMail = olApp.CreateItem(olMailItem)
For Each Celda In Split(.Cells(i, 1), "|")
For Each file In nCarpeta.Files
adjunto = file
nFile = Left(file.Name, InStr(file.Name, ".") - 1)
If Celda = nFile Then
'destinatario
olMail.To = .Cells(i, 2)
'con copia a
olMail.CC = .Cells(i, 3)
'con copia oculta a
olMail.BCC = .Cells(i, 4)
'asunto
olMail.Subject = .Cells(i, 5)
'cuerpo de correo


Selection.Copy
olMail.HTMLBody = "Buenos dias  </br>" & _
              "<br>Adjunto el Informe del Avance de Ventas <br>" & _
              "Saludos Cordiales <br>" & _
              "<IMG SRC=""D:\01-Usuario\Documents\Firma Kategora Leandro.jpg"">  </IMG>"
              
Sheets("Seguimiento TC").Activate
Range("B5:Y30").Select
    Application.CutCopyMode = False
    Selection.Copy
    Range("K8").Select
    ActiveWindow.SmallScroll Down:=-42
    Application.CutCopyMode = False
    ActiveWorkbook.Save             
'olMail.Display
'olMail.Signature = "Kategora Leandro"
'olMail.HTMLBody = Insert
'Adjuntamos archivo y dejamos correo en bandeja de salida
olMail.Attachments.Add (adjunto)
'para enviar usar Send en ves de Display
olMail.Display
'olMail.Send
End If
Next file
Next Celda
olMail: Close
olApp: Close
Next i
End With
Set olMail = Nothing
Set olApp = Nothing
End Function