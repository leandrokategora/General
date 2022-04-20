import pandas as pd
import numpy as np
dir_pandas = '~/Notebooks/db/{}'
visitas = pd.read_csv('D:\01-Usuario\Downloadsdata.csv', sep = ';')
visitas.to_excel(dir_pandas.format('ppto_read.xlsb'))