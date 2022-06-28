CREATE DATABASE IF NOT EXISTS rkd_challenge;

USE rkd_challenge;

CREATE TABLE IF NOT EXISTS `plataforma`(
                        `plataforma_id` bigint(20) PRIMARY KEY AUTO_INCREMENT,
                        `plataforma` varchar(50) not null
                        )ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

CREATE TABLE IF NOT EXISTS `calendario` (
                        `date` datetime PRIMARY KEY,
                        `año` text not null                        
                        )ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

CREATE TABLE IF NOT EXISTS `shows`(
                        `id` INT PRIMARY KEY AUTO_INCREMENT,
                        `show_id` text(10) DEFAULT NULL,
                        `type` text DEFAULT NULL,
                        `title` text DEFAULT NULL,
                        `director` text DEFAULT NULL,
                        `cast` text DEFAULT NULL,
                        `country` text DEFAULT NULL,
                        `date_added` datetime DEFAULT NULL,
                        `release_year` text DEFAULT NULL,
                        `rating` text DEFAULT NULL,
                        `duration` text DEFAULT NULL,
                        `listed_in` text DEFAULT NULL,
                        `description` text DEFAULT NULL,
                        `plataforma_id` bigint(20) DEFAULT NULL                        
                        )ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
-- FOREIGN KEY (`plataforma_id`) REFERENCES `plataforma`(`plataforma_id`)
-- FOREIGN KEY (`date_added`) REFERENCES `calendario`(`date`)

 












