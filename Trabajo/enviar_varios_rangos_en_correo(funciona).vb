Sub enviar_varios_rangos_en_correo()
    Dim TempFilePath As String
    Dim xOutApp As Object
    Dim xOutMail As Object
    Dim xHTMLBody As String
    Dim xRg As Range
    Dim xSheet As Worksheet
    Dim xAcSheet As Worksheet
    Dim xFileName As String
    Dim xSrc As String
    On Error Resume Next
    TempFilePath = Environ$("temp") & "\RangePic\"
    If Len(VBA.Dir(TempFilePath, vbDirectory)) = False Then
      VBA.MkDir TempFilePath
    End If
    Set xAcSheet = Application.ActiveSheet
    For Each xSheet In Application.Worksheets
        xSheet.Activate
        Set xRg = xSheet.Application.Selection
        If xRg.Cells.Count > 1 Then
            Call createJpg(xSheet.Name, xRg.Address, "DashboardFile" & VBA.Trim(VBA.Str(xSheet.Index)))
        End If
    Next
    xAcSheet.Activate
    With Application
        .Calculation = xlManual
        .ScreenUpdating = False
        .EnableEvents = False
    End With
    Set xOutApp = CreateObject("outlook.application")
    Set xOutMail = xOutApp.CreateItem(olMailItem)
    xSrc = ""
    xFileName = Dir(TempFilePath & "*.*")
    Do While xFileName <> ""
        xSrc = xSrc + VBA.vbCrLf + "<img src='cid:" + xFileName + "'><br>"
        xFileName = Dir
        If xFileName = "" Then Exit Do
    Loop
    xHTMLBody = "<span LANG=EN>" _
                & "<p class=style2><span LANG=EN><font FACE=Calibri SIZE=3>" _
                & "Hello, this is the data range that you want:<br> " _
                & "<br>" _
                & xSrc _
                & "<br>Best Regards!</font></span>"
    With xOutMail
        .Subject = ""
        .HTMLBody = xHTMLBody
        xFileName = Dir(TempFilePath & "*.*")
        Do While xFileName <> ""
            .Attachments.Add TempFilePath & xFileName, olByValue
            xFileName = Dir
        If xFileName = "" Then Exit Do
        Loop
        .To = " "
        .CC = " "
       .Display
    End With
    If VBA.Dir(TempFilePath & "*.*") <> "" Then
        VBA.Kill TempFilePath & "*.*"
    End If
End Sub
Sub createJpg(SheetName As String, xRgAddrss As String, nameFile As String)
    Dim xRgPic As Range
    ThisWorkbook.Activate
    Worksheets(SheetName).Activate
    Set xRgPic = ThisWorkbook.Worksheets(SheetName).Range(xRgAddrss)
    xRgPic.CopyPicture
    With ThisWorkbook.Worksheets(SheetName).ChartObjects.Add(xRgPic.Left, xRgPic.Top, xRgPic.Width, xRgPic.Height)
        .Activate
        .Chart.Paste
        .Chart.Export Environ$("temp") & "\RangePic\" & nameFile & ".jpg", "JPG"
    End With
    Worksheets(SheetName).ChartObjects(Worksheets(SheetName).ChartObjects.Count).Delete
Set xRgPic = Nothing
End Sub