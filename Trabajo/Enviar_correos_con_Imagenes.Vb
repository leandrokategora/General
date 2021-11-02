'EXCELeINFO
'MVP Sergio Alejandro Campos
'http://www.exceleinfo.com
'https://www.youtube.com/user/sergioacamposh
'http://blogs.itpro.es/exceleinfo
'
'Macro publicada originalmente en: http://excelforo.blogspot.mx/2017/12/vba-enviar-rango-destinatario-de-correo.html
'
Sub Enviar_Rango_a_Destinatario_de_correo()
   
'Seleccionamos el rango de celdas a enviar Select
ActiveSheet.Range("A8:F18").Select

For i = 1 To 2

    'El valor de i se pone en la celda F10 para que con BUSCARV se devuelvan
    'los datos correspondientes al ID.
    ThisWorkbook.Sheets("Resumen").Range("F10").Value = i
    
    'Mostramos la sección para enviar correo.
    ActiveWorkbook.EnvelopeVisible = True
    
    'Llamamos al envío...
    With ActiveSheet.MailEnvelope
       .Item.To = ThisWorkbook.Sheets("Resumen").Range("B11").Value
       '.Item.cc = "correo1@dominio.com"            'con copia a...
       '.Item.bcc = "correo2@dominio.com"      'con copia oculta a...
       .Item.Subject = "Resumen de ventas"
       .Introduction = "Se adjunta resumen de ventas del año 2017."
       .Item.Send
    End With

Next i
End Sub