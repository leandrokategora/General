# import sqlalchemy as sa
# import urllib
# parameters = urllib.parse.quote_plus("DRIVER={mysql};"
#                                      "Server=127.0.0.1;"
#                                      "DATABASE=rkd_challenge;"
#                                      "UID=root@localhost;"
#                                      "PWD=")

# try:
#     engine = sa.create_engine("mysql+pyodbc:///?odbc_conect={}".format(parameters))
#     print('Conexion exitosa')
# except Exception as ex:
#     print(ex)
    
import sqlalchemy as sa
import urllib
import pyodbc
parameters = urllib.parse.quote_plus("DRIVER=MySQL ODBC 8.0 Unicode Driver;"
                                     "Server=127.0.0.1;"
                                     "DATABASE=rkd_challenge;"
                                     "UID=root;"
                                     "PWD=")

try:
    engine = sa.create_engine("mysql+pyodbc:///?odbc_conect={}".format(parameters))
    print('Conexion exitosa')
except Exception as ex:
    print(ex)    