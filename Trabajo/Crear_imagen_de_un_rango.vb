
Sub CrearImagenRango()
Dim she As Worksheet
Application.ScreenUpdating = False
Application.DisplayAlerts = False
On Error Resume Next
Set a = Sheets("Seguimiento TC")
myfile = ActiveWorkbook.Path & "\Seg_TC.jpg"
' a partir de la direccion del libro se guarda el archivo con el nombre entre parentesis
ThisWorkbook.Sheets("Seguimiento TC").Range("B5:Y30").CopyPicture
With Range("B5:Y30")
Izq = .Left
Arr = .Top
Ancho = .Width
Alto = .Height
End With
Range(«b23»).Select
ActiveSheet.Shapes.AddChart
ActiveSheet.ChartObjects(1).Select
With Selection
.Width = Ancho
.Height = Alto
.Chart.Paste
.Chart.Export myfile
.Delete
End With 
MsgBox ("El archivo de imagen con extensión JPG se guardró en " & myfile), vbInformation, "AVISO"
Application.ScreenUpdating = True
Application.DisplayAlerts = True
End Sub
