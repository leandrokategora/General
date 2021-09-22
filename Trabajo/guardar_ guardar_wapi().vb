Sub guardar_wapi()
'
' guardar_wapi Macro
'

'
Dim Name As String

Name = "Wapi " & Cells(1, 2).Value
    Application.CutCopyMode = False
    ChDir _
        "\\serverarchivos\archivosGT\PLANEAMIENTO\02-VENTAS\4-Acciones y negociaciones\Seguimiento Mayorista"
    ActiveWorkbook.SaveAs Filename:= _
        "\\serverarchivos\archivosGT\PLANEAMIENTO\02-VENTAS\4-Acciones y negociaciones\Seguimiento Mayorista\ " & Name & ".xlsm " _
        , FileFormat:=xlOpenXMLWorkbookMacroEnabled, CreateBackup:=False
    Rows("1:7").Select
    Range("A7").Activate
    Selection.Delete Shift:=xlUp
    Rows("1:1").Select
    ActiveWorkbook.Save
End Sub

