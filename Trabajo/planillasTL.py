from pyPDF2 import PDFFileReader
temp = open('./CARGAS 28-01.pdf', 'rb')
PDF_read = PDFFileReader(temp)
first_page = PDF_read.getPage(0)
print(first_page.extractText())

