
CREATE DATABASE rkd_challenge;

CREATE TABLE plataforma(
                        plataforma_id int not null auto_increment,
                        plataforma varchar(50) not null, 
                        primary key (plataforma_id)
                        );
 

CREATE TABLE calendario (
                        date date not null,
                         año int not null,
                        primary key (date)
                        );


CREATE TABLE shows (
                    show_id varchar(10) not null,
                    type varchar(15) null,      
                    title varchar(100) not null,
                    director varchar(80),
                    cast varchar(200),
                    country varchar(50),
                    date_added date not null,
                    release_year int,
                    rating varchar(15),
                    duration varchar(50),
                    listed_in varchar(150),
                    description varchar(250),
                    plataforma_id int not null,
                    primary key (show_id),
                    foreign key (plataforma_id) references plataforma(plataforma_id),
                    foreign key (date_added) references calendario(date)
                    ); 


