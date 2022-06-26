Sub Imprime_PDF()
'toma el rango de celdas donde esta la info y lo guarda como pdf con el nombre del primer vendedor que aparece arriba.
Application.ScreenUpdating = False

If MsgBox("¿Desea Convertir a PDF?", vbQuestion + vbYesNo) = vbYes Then
'----------------------------------------------
        
    Dim HResumen As Worksheet
    Dim Ruta As String
    Dim Titulo As String

        Set HResumen = Worksheets("Venta Clientes x Dia")

        'Ruta = ThisWorkbook.Path
        Ruta = "\\serverarchivos\archivosGT\PLANEAMIENTO\02-VENTAS\30-BEES\Enviar\Clientes x dia KG"
        Titulo = HResumen.Range("C2").Text
        
        
        
        Range("Tabla1[[#Headers],[Supervisor]]").Select
        Range(Selection, Selection.End(xlToRight)).Select
        Range(Selection, Selection.End(xlDown)).Select
'''===============================================================================
            
        Cells.Select
        'HResumen.Range("A1:I20").Select
            
        Selection.ExportAsFixedFormat Type:=xlTypePDF, Filename:=Ruta & Titulo, Quality:= _
        xlQualityStandard, IncludeDocProperties:=True, IgnorePrintAreas:=False, _
        OpenAfterPublish:=True
'''===============================================================================
         
    HResumen.Range("A1").Select
'----------------------------------------------

End If

End Sub
