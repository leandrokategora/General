Option Explicit

Sub Macro1()
'
' Macro1 Macro
'

'
    Range("D42:E45").Select
    Selection.Copy
    Sheets("Hoja1").Select
    Range("C6").Select
    ActiveSheet.Pictures.Paste.Select
    ActiveSheet.Shapes.Range(Array("Picture 1")).Select
    Range("F12").Select
End Sub


"Buenos dias  </br>" & _
              "<br>Adjunto el Informe del Avance de Ventas <br>" & _
              "Saludos Cordiales <br>" & _
              "<IMG SRC=""D:\01-Usuario\Documents\Firma Kategora Leandro.jpg"">  </IMG>"