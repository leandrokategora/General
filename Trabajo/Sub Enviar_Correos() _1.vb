Sub Enviar_Correos()
'
' Enviar_Correos Macro
' Envia los correos especificados con los archivos adjuntos correspondientes
'
Dim aFSO As Object, Directorio As String
Dim dir_Archivo As Variant
'abrimos ventana de dialogo para seleccionar carpeta
Set dir_Archivo = Application.FileDialog(msoFileDialogFolderPicker)
dir_Archivo.Show
'si no seleccionamos nada salimos del proceso
If dir_Archivo.SelectedItems.Count = 0 Then
Exit Sub
End If
'capturamos el directorio
Directorio = dir_Archivo.SelectedItems(1)
'creamos objeto y ejecutamos funcion carpeta
Set sFSO = CreateObject("Scripting.FileSystemObject")
CARPETA sFSO.GetFolder(Directorio)
End Sub

Function CARPETA(ByVal nCarpeta)

'Declaramos variables Dim olApp As Outlook.Application
Dim olApp As Outlook.Application
Dim olMail As Outlook.MailItem
Dim fin As Long, i As Long, file As Variant
Dim adjunto As String, nFile As String
Dim olMailItem As Variant, Celda As Variant
Dim Signature As String

'Iniciamos Funcion
With Sheets("Hoja1")
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
olMail.HTMLBody = "Buenos dias  </br>" & _
              "<br>Adjunto el Informe del Avance de Ventas <br>" & _
              "Saludos Cordiales <br>" & _
              "<IMG SRC=""D:\01-Usuario\Documents\Firma Kategora Leandro.jpg"">  </IMG>"
              
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