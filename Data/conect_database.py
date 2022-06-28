import sqlalchemy as sa
import urllib
parameters = urllib.parse.quote_plus("DRIVER={mysql};"
                                     "Server=127.0.0.1;"
                                     "DATABASE=rkd_challenge;"
                                     "UID=root@localhost;"
                                     "PWD=")

try:
    engine = sa.create_engine("mysql+pyodbc:///?odbc_conect={}".format(parameters))
    print('Conexion exitosa')
except Exception as ex:
    print(ex)
    