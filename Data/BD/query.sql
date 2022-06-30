LOAD DATA INFILE '../disney_plus_titles_data.csv'
    INTO TABLE shows
    FIELDS TERMINATED BY ','
    OPTIONALLY ENCLOSED BY '"'
    LINES TERMINATED BY '\r\n'

