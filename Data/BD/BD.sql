
CREATE DATABASE IF NOT EXISTS rkd_challenge;

USE rkd_challenge;

CREATE TABLE IF NOT EXISTS `plataforma`(
                        `plataforma_id` int not null auto_increment,
                        `plataforma` varchar(50) not null, 
                        primary key (plataforma_id)
                        )ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
 

CREATE TABLE IF NOT EXISTS `calendario` (
                        `date` date not null,
                        `año` int not null,
                        primary key (`date`)
                        )ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

CREATE TABLE IF NOT EXISTS `shows` (
  `id` int not null,
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
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- CREATE TABLE `shows` (
--                     `id` int,
--                     `show_id` varchar(10) null,
--                     `type` varchar(15) null,      
--                     `title` varchar(100) not null,
--                     `director` varchar(80),
--                     `cast` varchar(200),
--                     `country` varchar(50),
--                     `date_added` date not null,
--                     `release_year` int,
--                     `rating` varchar(15),
--                     `duration` varchar(50),
--                     `listed_in` varchar(150),
--                     `description` varchar(250),
--                     `plataforma_id` int not null
--                     )ENGINE=InnoDB DEFAULT CHARSET=utf8mb4; 

-- primary key (`id`),
--                     foreign key (`plataforma_id`) references `plataforma`(`plataforma_id`),
--                     foreign key (`date_added`) references `calendario`(`date`)

--   primary key (`id`),
--   foreign key (`plataforma_id`) references `plataforma`(`plataforma_id`),
--   foreign key (`date_added`) references `calendario`(`date`)                

-- DESDE ACA
-- ALTER TABLE `shows`
--   ADD PRIMARY KEY (`id`),
--   ADD KEY `plataforma_id` (`plataforma_id`),
--   ADD KEY `date_added` (`date_added`);

-- ALTER TABLE `shows`
--   MODIFY `id` int(20) NOT NULL AUTO_INCREMENT;
  

-- ALTER TABLE `shows`
--   ADD CONSTRAINT `shows_ibfk_1` FOREIGN KEY (`plataforma_id`) REFERENCES `plataforma` (`plataforma_id`),
--   ADD CONSTRAINT `shows_ibfk_2` FOREIGN KEY (`date_added`) REFERENCES `calendario` (`date`);
-- -- COMMIT;
-- HASTA ACA
-- ALTER TABLE `calendario`
--   ADD PRIMARY KEY (`date`);

--
-- Indices de la tabla `plataforma`
--
-- ALTER TABLE `plataforma`
--   ADD PRIMARY KEY (`plataforma_id`);

--
-- Indices de la tabla `shows`
--   ADD PRIMARY KEY (`show_id`),
ALTER TABLE `shows`
  ADD PRIMARY KEY (`id`);
--   ADD KEY `plataforma_id` (`plataforma_id`),
--   ADD KEY `date_added` (`date_added`);

--
ALTER TABLE `shows`
  MODIFY `id` int(20) NOT NULL AUTO_INCREMENT;

-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `plataforma`
--
ALTER TABLE `plataforma`
  MODIFY `plataforma_id` bigint(20) NOT NULL AUTO_INCREMENT;

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `shows`
--
ALTER TABLE `shows`
  ADD CONSTRAINT `shows_ibfk_1` FOREIGN KEY (`plataforma_id`) REFERENCES `plataforma` (`plataforma_id`),
  ADD CONSTRAINT `shows_ibfk_2` FOREIGN KEY (`date_added`) REFERENCES `calendario` (`date`);
COMMIT;
