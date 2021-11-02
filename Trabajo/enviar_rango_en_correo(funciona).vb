Sub sendMail()
    Dim TempFilePath As String
    Dim xOutApp As Object
    Dim xOutMail As Object
    Dim xHTMLBody As String
    Dim xRg As Range
    On Error Resume Next
    Set xRg = Application.InputBox("Please select the data range:", "KuTools for Excel", Selection.Address, , , , , 8)
    If xRg Is Nothing Then Exit Sub
    With Application
        .Calculation = xlManual
        .ScreenUpdating = False
        .EnableEvents = False
    End With
    Set xOutApp = CreateObject("outlook.application")
    Set xOutMail = xOutApp.CreateItem(olMailItem)
    Call createJpg(ActiveSheet.Name, xRg.Address, "DashboardFile")
    TempFilePath = Environ$("temp") & "\"
    xHTMLBody = "<span LANG=EN>" _
            & "<p class=style2><span LANG=EN><font FACE=Calibri SIZE=3>" _
            & "Hello, this is the data range that you want:<br> " _
            & "<br>" _
            & "<img src='cid:DashboardFile.jpg'>" _
            & "<br>Best Regards!</font></span>"
    With xOutMail
        .Subject = ""
        .HTMLBody = xHTMLBody
      .Attachments.Add TempFilePath & "DashboardFile.jpg", olByValue
        .To = " "
        .Cc = " "
        .Display
    End With
End Sub
Sub createJpg(SheetName As String, xRgAddrss As String, nameFile As String)
    Dim xRgPic As Range
    Dim xShape As Shape
    ThisWorkbook.Activate
    Worksheets(SheetName).Activate
    Set xRgPic = ThisWorkbook.Worksheets(SheetName).Range(xRgAddrss)
    xRgPic.CopyPicture
    With ThisWorkbook.Worksheets(SheetName).ChartObjects.Add(xRgPic.Left, xRgPic.Top, xRgPic.Width, xRgPic.Height)
        .Activate
        For Each xShape In ActiveSheet.Shapes
            xShape.Line.Visible = msoFalse
        Next
        .Chart.Paste
        .Chart.Export Environ$("temp") & "\" & nameFile & ".jpg", "JPG"
    End With
   Worksheets(SheetName).ChartObjects(Worksheets(SheetName).ChartObjects.Count).Delete
Set xRgPic = Nothing
End Sub