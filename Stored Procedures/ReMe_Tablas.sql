CREATE SCHEMA `ReMe`;

CREATE TABLE `ReMe`.`Categorias` (
  `IdCategoria` int(11) NOT NULL AUTO_INCREMENT,
  `NombreCategoria` varchar(20) DEFAULT NULL,
  `Descripcion` varchar(120) DEFAULT NULL,
  PRIMARY KEY (`IdCategoria`)
);

CREATE TABLE `ReMe`.`CategoriasAdc` (
  `IdCategoriaAdc` int(11) NOT NULL AUTO_INCREMENT,
  `NombreCategoriaAdc` varchar(20) DEFAULT NULL,
  `Descripcion` varchar(120) DEFAULT NULL,
  PRIMARY KEY (`IdCategoriaAdc`)
);

CREATE TABLE `ReMe`.`Rol` (
  `IdRol` int(11) NOT NULL AUTO_INCREMENT,
  `NombreRol` varchar(20) DEFAULT NULL,
  `Descripcion` varchar(120) DEFAULT NULL,
  PRIMARY KEY (`IdRol`)
);

CREATE TABLE `ReMe`.`Usuarios` (
  `IdUsuario` int(11) NOT NULL AUTO_INCREMENT,
  `Nombre` varchar(15) DEFAULT NULL,
  `Mail` varchar(35) DEFAULT NULL,
  `Clave` varchar(12) DEFAULT NULL,
  `IdRol` int(11) NOT NULL,
  PRIMARY KEY (`IdUsuario`,`IdRol`)
);

CREATE TABLE `ReMe`.`Tareas` (
  `IdTarea` int(11) NOT NULL AUTO_INCREMENT,
  `NombreTarea` varchar(15) DEFAULT NULL,
  `IdCategoria` int(11) NOT NULL,
  `Estado` int(11) DEFAULT NULL,
  `IdCategoriaAdc` int(11) NOT NULL,
  `FechaInicio` date DEFAULT NULL,
  `FechaFinaliza` date DEFAULT NULL,
  PRIMARY KEY (`IdTarea`,`IdCategoria`,`IdCategoriaAdc`),
  KEY `IdCategoria` (`IdCategoria`),
  KEY `IdCategoriaAdc` (`IdCategoriaAdc`),
  CONSTRAINT `tareas_ibfk_1` FOREIGN KEY (`IdCategoria`) REFERENCES `categorias` (`IdCategoria`),
  CONSTRAINT `tareas_ibfk_2` FOREIGN KEY (`IdCategoriaAdc`) REFERENCES `categoriasadc` (`IdCategoriaAdc`)
);

CREATE TABLE `ReMe`.`RelUsuarioTarea` (
  `IdRelUsuarioTarea` int(11) NOT NULL AUTO_INCREMENT,
  `IdUsuario` int(11) NOT NULL,
  `IdTarea` int(11) NOT NULL,
  PRIMARY KEY (`IdRelUsuarioTarea`,`IdUsuario`,`IdTarea`),
  KEY `IdUsuario` (`IdUsuario`),
  KEY `IdTarea` (`IdTarea`),
  CONSTRAINT `relusuariotarea_ibfk_1` FOREIGN KEY (`IdUsuario`) REFERENCES `usuarios` (`IdUsuario`),
  CONSTRAINT `relusuariotarea_ibfk_2` FOREIGN KEY (`IdTarea`) REFERENCES `tareas` (`IdTarea`)
);

CREATE TABLE `ReMe`.`RelUsuarioRol` (
  `IdRelUsuarioRol` int(11) NOT NULL AUTO_INCREMENT,
  `IdUsuario` int(11) NOT NULL,
  `IdRol` int(11) NOT NULL,
  PRIMARY KEY (`IdRelUsuarioRol`,`IdUsuario`,`IdRol`),
  KEY `IdUsuario` (`IdUsuario`),
  KEY `IdRol` (`IdRol`),
  CONSTRAINT `relusuariorol_ibfk_1` FOREIGN KEY (`IdUsuario`) REFERENCES `usuarios` (`IdUsuario`),
  CONSTRAINT `relusuariorol_ibfk_2` FOREIGN KEY (`IdRol`) REFERENCES `rol` (`IdRol`)
);

CREATE TABLE `reme`.`estado` (
  `IdEstado` int(11) NOT NULL AUTO_INCREMENT,
  `Tipo` varchar(45) DEFAULT NULL,
  `Descripcion` varchar(125) DEFAULT NULL,
  PRIMARY KEY (`IdEstado`)
);

CREATE TABLE `reme`.`relestadotarea` (
   `idrelestadotarea` int(11) NOT NULL AUTO_INCREMENT,
  `IdEstado` int(11) NOT NULL,
  `IdTarea` int(11) NOT NULL,
  PRIMARY KEY (`idrelestadotarea`),
  KEY `IdEstado` (`IdEstado`),
  KEY `IdTarea` (`IdTarea`),
  CONSTRAINT `relestadotarea_ibfk_1` FOREIGN KEY (`IdEstado`) REFERENCES `estado` (`IdEstado`),
  CONSTRAINT `relestadotarea_ibfk_2` FOREIGN KEY (`IdTarea`) REFERENCES `tareas` (`IdTarea`),
  CONSTRAINT `relestadotarea_ibfk_3` FOREIGN KEY (`IdTarea`) REFERENCES `tareas` (`IdTarea`)
  );
  
CREATE TABLE `reme`.`reltareaaprobada` (
  `idreltareaaprobada` int(11) NOT NULL AUTO_INCREMENT,
  `IdTarea` int(11) NOT NULL,
  `FechaAprobada` date NOT NULL,
  PRIMARY KEY (`idreltareaaprobada`),
  KEY `IdTarea` (`IdTarea`),
  CONSTRAINT `reltareaaprobada_ibfk_1` FOREIGN KEY (`IdTarea`) REFERENCES `tareas` (`IdTarea`)
);
  
CREATE TABLE `reme`.`reltareanotif` (
  `idreltareanotif` int(11) NOT NULL AUTO_INCREMENT,
  `IdTarea` int(11) NOT NULL,
  `FechaNotif` date NOT NULL,
  `EstadoNotif` int(11) NOT NULL DEFAULT 0,
  PRIMARY KEY (`idreltareanotif`),
  KEY `IdTarea` (`IdTarea`),
  CONSTRAINT `reltareanotif_ibfk_1` FOREIGN KEY (`IdTarea`) REFERENCES `tareas` (`IdTarea`),
  CONSTRAINT `reltareanotif_ibfk_2` FOREIGN KEY (`IdTarea`) REFERENCES `tareas` (`IdTarea`)
);
  
CREATE TABLE `reme`.`reltareadesaprobada` (
  `idreltareadesaprobada` int(11) NOT NULL AUTO_INCREMENT,
  `IdTarea` int(11) NOT NULL,
  `FechaDesaprobada` date NOT NULL,
  PRIMARY KEY (`idreltareadesaprobada`)
);