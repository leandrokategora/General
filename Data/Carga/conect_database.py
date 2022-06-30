import sqlalchemy as sa
import urllib
import pyodbc

connection_string = (
    'DRIVER=MySQL ODBC 8.0 Unicode Driver;'
    'SERVER=localhost;'
    'DATABASE=rkd_challenge;'
    'UID=admin;'
    'PWD=admin1234;'
)
params = urllib.parse.quote_plus(connection_string)
engine = sa.create_engine("mysql+pyodbc:///?odbc_connect={}".format(params))
print("mysql+pyodbc:///?odbc_connect={}".format(params))