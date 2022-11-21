USE reme;
DELIMITER //
CREATE PROCEDURE `Actualizar_Categoria`(n1 INT, n2 INT)
BEGIN
	 DECLARE EXIT HANDLER FOR SQLEXCEPTION
     BEGIN
     ROLLBACK;
     END;
     DECLARE EXIT HANDLER FOR SQLWARNING
     BEGIN
     ROLLBACK;
     END;
     START TRANSACTION;
		UPDATE tareas SET IdCategoria = n2 WHERE IdTarea = n1;
     COMMIT;
END //

USE reme;
DELIMITER //
CREATE PROCEDURE `Actualizar_Estado`(n1 INT, n2 INT)
BEGIN
	 DECLARE EXIT HANDLER FOR SQLEXCEPTION
     BEGIN
     ROLLBACK;
     END;
     DECLARE EXIT HANDLER FOR SQLWARNING
     BEGIN
     ROLLBACK;
     END;
     START TRANSACTION;
		UPDATE relestadotarea SET IdEstado = n1 WHERE IdTarea = n2;
		UPDATE tareas SET Estado = n1 WHERE IdTarea = n2;
        IF n1 = 2 THEN
			INSERT INTO reltareaaprobada (IdTarea, FechaAprobada) VALUES (n2, DATE(NOW()));
            DELETE FROM reltareanotif WHERE IdTarea = n2;
		ELSEIF n1 = 3 THEN
			INSERT INTO reltareadesaprobada (IdTarea, FechaDesaprobada) VALUES (n2, DATE(NOW()));
            DELETE FROM reltareanotif WHERE IdTarea = n2;
        END IF;
     COMMIT;
END //

USE reme;
DELIMITER //
CREATE PROCEDURE `Actualizar_EstadoNotif`(n1 INT)
BEGIN
	 DECLARE EXIT HANDLER FOR SQLEXCEPTION
     BEGIN
     ROLLBACK;
     END;
     DECLARE EXIT HANDLER FOR SQLWARNING
     BEGIN
     ROLLBACK;
     END;
     START TRANSACTION;
		UPDATE reltareanotif SET EstadoNotif = 1 WHERE IdTarea = n1;
     COMMIT;
END //

USE reme;
DELIMITER //
CREATE PROCEDURE `Buscar_Aprobadas`(n1 INT)
BEGIN
	 DECLARE EXIT HANDLER FOR SQLEXCEPTION
     BEGIN
     ROLLBACK;
     END;
     DECLARE EXIT HANDLER FOR SQLWARNING
     BEGIN
     ROLLBACK;
     END;
     START TRANSACTION;
		SELECT t.IdTarea, t.NombreTarea,  rta.FechaAprobada FROM tareas t, relusuariotarea rut, relestadotarea ret, reltareaaprobada rta WHERE rut.IdUsuario = n1 AND ret.IdEstado = 2 AND t.IdTarea = rta.IdTarea AND t.IdTarea = ret.IdTarea AND t.IdTarea = rut.IdTarea; 
     COMMIT;
END //

USE reme;
DELIMITER //
CREATE PROCEDURE `Buscar_Globales`(n1 INT)
BEGIN
	 DECLARE EXIT HANDLER FOR SQLEXCEPTION
     BEGIN
     ROLLBACK;
     END;
     DECLARE EXIT HANDLER FOR SQLWARNING
     BEGIN
     ROLLBACK;
     END;
     START TRANSACTION;
		SELECT t.IdTarea, t.NombreTarea, t.FechaFinaliza, rtn.FechaNotif, rtn.EstadoNotif FROM tareas t, reltareanotif rtn, categorias c, relestadotarea ret, relusuariotarea rut WHERE t.IdTarea = rtn.IdTarea AND t.IdCategoria = c.IdCategoria AND t.IdTarea = ret.IdTarea AND t.IdTarea = rut.IdTarea AND rut.IdUsuario = n1 AND t.IdCategoria = 1 AND t.Estado = 1;
     COMMIT;
END //

USE reme;
DELIMITER //
CREATE PROCEDURE `Buscar_Importantes`(n1 INT)
BEGIN
	 DECLARE EXIT HANDLER FOR SQLEXCEPTION
     BEGIN
     ROLLBACK;
     END;
     DECLARE EXIT HANDLER FOR SQLWARNING
     BEGIN
     ROLLBACK;
     END;
     START TRANSACTION;
		SELECT t.IdTarea, t.NombreTarea, t.FechaFinaliza, rtn.FechaNotif, rtn.EstadoNotif FROM tareas t, reltareanotif rtn, categorias c, relestadotarea ret, relusuariotarea rut WHERE t.IdTarea = rtn.IdTarea AND t.IdCategoria = c.IdCategoria AND t.IdTarea = ret.IdTarea AND t.IdTarea = rut.IdTarea AND rut.IdUsuario = n1 AND t.IdCategoria = 2 AND t.Estado = 1;
     COMMIT;
END //

USE reme;
DELIMITER //
CREATE PROCEDURE `Buscar_Olvidadas`(n1 INT)
BEGIN
	 DECLARE EXIT HANDLER FOR SQLEXCEPTION
     BEGIN
     ROLLBACK;
     END;
     DECLARE EXIT HANDLER FOR SQLWARNING
     BEGIN
     ROLLBACK;
     END;
     START TRANSACTION;
		SELECT t.IdTarea, t.NombreTarea, t.FechaFinaliza, rtn.FechaNotif, rtn.EstadoNotif FROM tareas t, reltareanotif rtn, categorias c, relestadotarea ret, relusuariotarea rut WHERE t.IdTarea = rtn.IdTarea AND t.IdCategoria = c.IdCategoria AND t.IdTarea = ret.IdTarea AND t.IdTarea = rut.IdTarea AND rut.IdUsuario = n1 AND t.IdCategoria = 3 AND t.Estado = 1;
     COMMIT;
END //

USE reme;
DELIMITER //
CREATE PROCEDURE `Cambiar_Clave`(n1 VARCHAR(12), n2 INT)
BEGIN
	 DECLARE EXIT HANDLER FOR SQLEXCEPTION
     BEGIN
     ROLLBACK;
     END;
     DECLARE EXIT HANDLER FOR SQLWARNING
     BEGIN
     ROLLBACK;
     END;
     START TRANSACTION;
		UPDATE reme.usuarios SET Clave = n1 WHERE IdUsuario = n2;
     COMMIT;
END //

USE reme;
DELIMITER //
CREATE PROCEDURE `Cambiar_Nombre`(n1 VARCHAR(15), n2 INT)
BEGIN
	 DECLARE EXIT HANDLER FOR SQLEXCEPTION
     BEGIN
     ROLLBACK;
     END;
     DECLARE EXIT HANDLER FOR SQLWARNING
     BEGIN
     ROLLBACK;
     END;
     START TRANSACTION;
		UPDATE reme.usuarios SET Nombre = n1 WHERE IdUsuario = n2;
     COMMIT;
END //

USE reme;
DELIMITER //
CREATE PROCEDURE `Crear_Tarea`(n1 VARCHAR(15), n2 INT, n3 INT, n4 INT, n5 DATE, n6 DATE, n7 INT, n8 DATE)
BEGIN
	 DECLARE id_t INT;
     DECLARE efn INT;
	 DECLARE EXIT HANDLER FOR SQLEXCEPTION
     BEGIN
     ROLLBACK;
     END;
     DECLARE EXIT HANDLER FOR SQLWARNING
     BEGIN
     ROLLBACK;
     END;
     START TRANSACTION;
		INSERT INTO tareas (NombreTarea, IdCategoria, Estado, IdCategoriaAdc, FechaInicio, FechaFinaliza) VALUES (n1, n2, n3, n4, n5, n6);
        SELECT IdTarea INTO id_t FROM tareas ORDER BY IdTarea DESC LIMIT 1;
        INSERT INTO relusuariotarea (IdUsuario, IdTarea) VALUES (n7, id_t);
        INSERT INTO relestadotarea (IdEstado, IdTarea) VALUES (n3 ,id_t);
        INSERT INTO reltareanotif (IdTarea, FechaNotif) VALUES (id_t, n8);
        SELECT rtn.EstadoNotif INTO efn FROM tareas t, reltareanotif rtn WHERE t.IdTarea = rtn.IdTarea AND t.IdTarea = id_t;
        SELECT id_t, efn;
     COMMIT;
END //

USE reme;
DELIMITER //
CREATE PROCEDURE `Eliminar_Notif`(n1 INT)
BEGIN
	 DECLARE EXIT HANDLER FOR SQLEXCEPTION
     BEGIN
     ROLLBACK;
     END;
     DECLARE EXIT HANDLER FOR SQLWARNING
     BEGIN
     ROLLBACK;
     END;
     START TRANSACTION;
		DELETE FROM reltareanotif WHERE IdTarea = n1;
     COMMIT;
END //

DELIMITER //
CREATE PROCEDURE `Eliminar_Tarea`(n1 INT)
BEGIN
	 DECLARE d INT;
     DECLARE a INT;
	 DECLARE EXIT HANDLER FOR SQLEXCEPTION
     BEGIN
     ROLLBACK;
     END;
     DECLARE EXIT HANDLER FOR SQLWARNING
     BEGIN
     ROLLBACK;
     END;
     START TRANSACTION;
		DELETE FROM relusuariotarea WHERE IdTarea = n1;
        DELETE FROM relestadotarea WHERE IdTarea = n1;
        DELETE FROM reltareanotif WHERE IdTarea = n1;
        SELECT count(IdTarea) INTO d FROM reltareadesaprobada WHERE IdTarea = n1;
        IF d = 1 THEN
			DELETE FROM reltareadesaprobada WHERE IdTarea = n1;
        END IF;
        SELECT count(IdTarea) INTO a FROM reltareaaprobada WHERE IdTarea = n1;
        IF a = 1 THEN
			DELETE FROM reltareaaprobada WHERE IdTarea = n1;
        END IF;
		DELETE FROM tareas WHERE IdTarea = n1;
     COMMIT;
END //

USE reme;
DELIMITER //
CREATE PROCEDURE `Login`(n1 VARCHAR(15), n2 VARCHAR(12))
BEGIN
	 DECLARE c INT;
     DECLARE id INT;
     DECLARE r INT;
     
	 DECLARE EXIT HANDLER FOR SQLEXCEPTION
     BEGIN
     ROLLBACK;
     END;
     DECLARE EXIT HANDLER FOR SQLWARNING
     BEGIN
     ROLLBACK;
     END;
     START TRANSACTION;
		SELECT COUNT(Nombre) INTO c FROM usuarios WHERE Nombre = n1 AND Clave = n2;
        IF c = 0 THEN
			SELECT 'incorrecto' AS Mensaje;
        END IF;
        SELECT IdUsuario INTO id FROM usuarios WHERE Nombre = n1 AND Clave = n2;
        SELECT IdRol INTO r FROM usuarios WHERE Nombre = n1 AND Clave = n2;
        
        IF c = 1 THEN
			SELECT 'correcto' AS Mensaje, id AS Identify, r AS Rol;
        END IF;
     COMMIT;
END //

USE reme;
DELIMITER //
CREATE PROCEDURE `Obtener_Clave`(n1 INT)
BEGIN
	 DECLARE c VARCHAR(12);
	 DECLARE EXIT HANDLER FOR SQLEXCEPTION
     BEGIN
     ROLLBACK;
     END;
     DECLARE EXIT HANDLER FOR SQLWARNING
     BEGIN
     ROLLBACK;
     END;
     START TRANSACTION;
		SELECT Clave INTO c FROM usuarios WHERE IdUsuario = n1;
        SELECT c AS Mensaje;
     COMMIT;
END //

USE reme;
DELIMITER //
CREATE PROCEDURE `Obtener_Email`(n1 VARCHAR(15), n2 VARCHAR(12))
BEGIN
	 DECLARE e VARCHAR(35);
    
	 DECLARE EXIT HANDLER FOR SQLEXCEPTION
     BEGIN
     ROLLBACK;
     END;
     DECLARE EXIT HANDLER FOR SQLWARNING
     BEGIN
     ROLLBACK;
     END;
     START TRANSACTION;
		SELECT Mail INTO e FROM usuarios WHERE Nombre = n1 AND Clave = n2;
        SELECT e AS Mail;
     COMMIT;
END //

USE reme;
DELIMITER //
CREATE PROCEDURE `Obtener_Registrados`()
BEGIN
	 DECLARE c INT;
     SELECT COUNT(usuarios.IdUsuario) INTO c FROM usuarios, relusuariorol rur, rol WHERE rur.IdRol = rol.IdRol AND rol.IdRol = 1 AND usuarios.IdRol = 1;
	 SELECT c, usuarios.IdUsuario FROM usuarios, relusuariorol rur, rol WHERE rur.IdRol = rol.IdRol AND rol.IdRol = 1 AND usuarios.IdRol = 1;
END //

USE reme;
DELIMITER //
CREATE PROCEDURE `Olvidadas_Importantes`(n1 INT, n2 DATE, n3 DATE, n4 DATE)
BEGIN
	 DECLARE EXIT HANDLER FOR SQLEXCEPTION
     BEGIN
     ROLLBACK;
     END;
     DECLARE EXIT HANDLER FOR SQLWARNING
     BEGIN
     ROLLBACK;
     END;
     START TRANSACTION;
		UPDATE reme.tareas SET IdCategoria = 2 WHERE IdTarea = n1;
        UPDATE reme.tareas SET IdCategoriaAdc = 2 WHERE IdTarea = n1;
        UPDATE reme.tareas SET FechaInicio = n2 WHERE IdTarea = n1;
        UPDATE reme.tareas SET FechaFinaliza = n3 WHERE IdTarea = n1;
        UPDATE reme.reltareanotif SET EstadoNotif = 0 WHERE IdTarea = n1;
        UPDATE reme.reltareanotif SET FechaNotif = n4 WHERE IdTarea = n1;
     COMMIT;
END //

USE reme;
DELIMITER //
-- n1
-- 1: Global
-- 2: Importante
-- 3: Olvidadas
-- 4: Aprobada
-- n2
-- 1: Ordenar por fecha (reciente a viejos)
--  2: Ordenar por nombre de forma ASC
-- 3: Ordenar por nombre de forma DESC
-- n3 ID DE USUARIO
CREATE PROCEDURE `Ordenar_Tareas`(n1 INT, n2 INT, n3 INT)
BEGIN
	 DECLARE EXIT HANDLER FOR SQLEXCEPTION
     BEGIN
     ROLLBACK;
     END;
     DECLARE EXIT HANDLER FOR SQLWARNING
     BEGIN
     ROLLBACK;
     END;
     START TRANSACTION;
		IF n1 = 1 AND n2 = 1 THEN
			SELECT t.IdTarea, t.NombreTarea, t.FechaFinaliza, rtn.FechaNotif FROM tareas t, reltareanotif rtn, categorias c, relestadotarea ret, relusuariotarea rut WHERE t.IdTarea = rtn.IdTarea AND t.IdCategoria = c.IdCategoria AND t.IdTarea = ret.IdTarea AND t.IdTarea = rut.IdTarea AND rut.IdUsuario = n3 AND t.IdCategoria = 1 AND t.Estado = 1 ORDER BY t.FechaFinaliza ASC;
		ELSEIF n1 = 1 AND n2 = 2 THEN
			SELECT t.IdTarea, t.NombreTarea, t.FechaFinaliza, rtn.FechaNotif FROM tareas t, reltareanotif rtn, categorias c, relestadotarea ret, relusuariotarea rut WHERE t.IdTarea = rtn.IdTarea AND t.IdCategoria = c.IdCategoria AND t.IdTarea = ret.IdTarea AND t.IdTarea = rut.IdTarea AND rut.IdUsuario = n3 AND t.IdCategoria = 1 AND t.Estado = 1 ORDER BY t.NombreTarea ASC;
		ELSEIF n1 = 1 AND n2 = 3 THEN
			SELECT t.IdTarea, t.NombreTarea, t.FechaFinaliza, rtn.FechaNotif FROM tareas t, reltareanotif rtn, categorias c, relestadotarea ret, relusuariotarea rut WHERE t.IdTarea = rtn.IdTarea AND t.IdCategoria = c.IdCategoria AND t.IdTarea = ret.IdTarea AND t.IdTarea = rut.IdTarea AND rut.IdUsuario = n3 AND t.IdCategoria = 1 AND t.Estado = 1 ORDER BY t.NombreTarea DESC;
        END IF;
        
        IF n1 = 2 AND n2 = 1 THEN
			SELECT t.IdTarea, t.NombreTarea, t.FechaFinaliza, rtn.FechaNotif FROM tareas t, reltareanotif rtn, categorias c, relestadotarea ret, relusuariotarea rut WHERE t.IdTarea = rtn.IdTarea AND t.IdCategoria = c.IdCategoria AND t.IdTarea = ret.IdTarea AND t.IdTarea = rut.IdTarea AND rut.IdUsuario = n3 AND t.IdCategoria = 2 AND t.Estado = 1 ORDER BY t.FechaFinaliza ASC;
		ELSEIF n1 = 2 AND n2 = 2 THEN
			SELECT t.IdTarea, t.NombreTarea, t.FechaFinaliza, rtn.FechaNotif FROM tareas t, reltareanotif rtn, categorias c, relestadotarea ret, relusuariotarea rut WHERE t.IdTarea = rtn.IdTarea AND t.IdCategoria = c.IdCategoria AND t.IdTarea = ret.IdTarea AND t.IdTarea = rut.IdTarea AND rut.IdUsuario = n3 AND t.IdCategoria = 2 AND t.Estado = 1 ORDER BY t.NombreTarea ASC;
        ELSEIF n1 = 2 AND n2 = 3 THEN
			SELECT t.IdTarea, t.NombreTarea, t.FechaFinaliza, rtn.FechaNotif FROM tareas t, reltareanotif rtn, categorias c, relestadotarea ret, relusuariotarea rut WHERE t.IdTarea = rtn.IdTarea AND t.IdCategoria = c.IdCategoria AND t.IdTarea = ret.IdTarea AND t.IdTarea = rut.IdTarea AND rut.IdUsuario = n3 AND t.IdCategoria = 2 AND t.Estado = 1 ORDER BY t.NombreTarea DESC;
        END IF;
        
        IF n1 = 3 AND n2 = 1 THEN
			SELECT t.IdTarea, t.NombreTarea, t.FechaFinaliza, rtn.FechaNotif FROM tareas t, reltareanotif rtn, categorias c, relestadotarea ret, relusuariotarea rut WHERE t.IdTarea = rtn.IdTarea AND t.IdCategoria = c.IdCategoria AND t.IdTarea = ret.IdTarea AND t.IdTarea = rut.IdTarea AND rut.IdUsuario = n3 AND t.IdCategoria = 3 AND t.Estado = 1 ORDER BY t.FechaFinaliza ASC;
		ELSEIF n1 = 3 AND n2 = 2 THEN
			SELECT t.IdTarea, t.NombreTarea, t.FechaFinaliza, rtn.FechaNotif FROM tareas t, reltareanotif rtn, categorias c, relestadotarea ret, relusuariotarea rut WHERE t.IdTarea = rtn.IdTarea AND t.IdCategoria = c.IdCategoria AND t.IdTarea = ret.IdTarea AND t.IdTarea = rut.IdTarea AND rut.IdUsuario = n3 AND t.IdCategoria = 3 AND t.Estado = 1 ORDER BY t.NombreTarea ASC;
		ELSEIF n1 = 3 AND n2 = 3 THEN
			SELECT t.IdTarea, t.NombreTarea, t.FechaFinaliza, rtn.FechaNotif FROM tareas t, reltareanotif rtn, categorias c, relestadotarea ret, relusuariotarea rut WHERE t.IdTarea = rtn.IdTarea AND t.IdCategoria = c.IdCategoria AND t.IdTarea = ret.IdTarea AND t.IdTarea = rut.IdTarea AND rut.IdUsuario = n3 AND t.IdCategoria = 3 AND t.Estado = 1 ORDER BY t.NombreTarea DESC;
		END IF;
        
		IF n1 = 4 AND n2 = 1 THEN
			SELECT t.IdTarea, t.NombreTarea,  rta.FechaAprobada FROM tareas t, relusuariotarea rut, relestadotarea ret, reltareaaprobada rta WHERE rut.IdUsuario = n3 AND ret.IdEstado = 2 AND t.IdTarea = rta.IdTarea AND t.IdTarea = ret.IdTarea AND t.IdTarea = rut.IdTarea ORDER BY rta.FechaAprobada DESC; 
		ELSEIF n1 = 4 AND n2 = 2 THEN
			SELECT t.IdTarea, t.NombreTarea,  rta.FechaAprobada FROM tareas t, relusuariotarea rut, relestadotarea ret, reltareaaprobada rta WHERE rut.IdUsuario = n3 AND ret.IdEstado = 2 AND t.IdTarea = rta.IdTarea AND t.IdTarea = ret.IdTarea AND t.IdTarea = rut.IdTarea ORDER BY t.NombreTarea ASC; 
		ELSEIF n1 = 4 AND n2 = 3 THEN
			SELECT t.IdTarea, t.NombreTarea,  rta.FechaAprobada FROM tareas t, relusuariotarea rut, relestadotarea ret, reltareaaprobada rta WHERE rut.IdUsuario = n3 AND ret.IdEstado = 2 AND t.IdTarea = rta.IdTarea AND t.IdTarea = ret.IdTarea AND t.IdTarea = rut.IdTarea ORDER BY t.NombreTarea DESC; 
		END IF;
     COMMIT;
END //

use reme;
INSERT INTO usuarios (Nombre, Mail, Clave, IdRol) VALUES ('UsuarioPrueba', 'usuarioprueba@gmail.com', 'usuario99', 1);
INSERT INTO usuarios (Nombre, Mail, Clave, IdRol) VALUES ('AdminPrueba', 'adminprueba@gmail.com', 'admin99', 2);
INSERT INTO rol (NombreRol, Descripcion) VALUES ('Usuario', 'Usuario del sistema');
INSERT INTO rol (NombreRol, Descripcion) VALUES ('Administrador', 'Administrador del sistema');
INSERT INTO relusuariorol (IdUsuario, IdRol) VALUES (1, 1);
INSERT INTO relusuariorol (IdUsuario, IdRol) VALUES (2, 2);
INSERT INTO categoriasadc (NombreCategoriaAdc, Descripcion) VALUES ('Tarea', 'Tarea común');
INSERT INTO categoriasadc (NombreCategoriaAdc, Descripcion) VALUES ('TP', 'Trabajo Práctico');
INSERT INTO categorias (NombreCategoria, Descripcion) VALUES ('Global', 'Tarea sin clasificar');
INSERT INTO categorias (NombreCategoria, Descripcion) VALUES ('Importante', 'Tarea prioritaria');
INSERT INTO categorias (NombreCategoria, Descripcion) VALUES ('Olvidada', 'Tarea olvidada');
INSERT INTO estado (Tipo, Descripcion) VALUES ('En proceso', 'Tarea sin terminar');
INSERT INTO estado (Tipo, Descripcion) VALUES ('Aprobada', 'Tarea finalizada y aprobada');
INSERT INTO estado (Tipo, Descripcion) VALUES ('Desaprobada', 'Tarea finalizada y desaprobada');

USE reme;
DELIMITER //
CREATE PROCEDURE `Registro`(n1 VARCHAR(15), n2 VARCHAR(35), n3 VARCHAR(12))
BEGIN
	 DECLARE a INT;
	 DECLARE EXIT HANDLER FOR SQLEXCEPTION
     BEGIN
     ROLLBACK;
     END;
     DECLARE EXIT HANDLER FOR SQLWARNING
     BEGIN
     ROLLBACK;
     END;
     START TRANSACTION;
		INSERT INTO `reme`.`usuarios` (`Nombre`, `Mail`, `Clave`, `IdRol`) VALUES (n1, n2, n3, '1');
        SELECT IdUsuario INTO a FROM usuarios ORDER BY IdUsuario DESC LIMIT 1;
        SELECT a;
     COMMIT;
END //

USE reme;
DELIMITER //
CREATE PROCEDURE `Reporte_Global`(n1 INT)
BEGIN
     DECLARE u VARCHAR(15);
     DECLARE aprobadas INT;
     DECLARE desaprobadas INT;
     DECLARE importantes INT;
     DECLARE globales INT;
     DECLARE olvidadas INT;
		-- Aprobadas
		SELECT COUNT(t.IdTarea) INTO aprobadas FROM tareas t, relusuariotarea rut, relestadotarea ret, reltareaaprobada rta, rol r, relusuariorol rur  WHERE r.IdRol = rur.IdRol AND rur.IdRol = 1 AND rut.IdUsuario = n1 AND ret.IdEstado = 2 AND t.IdTarea = rta.IdTarea AND t.IdTarea = ret.IdTarea AND t.IdTarea = rut.IdTarea; 
		-- Desaprobadas
		SELECT COUNT(t.IdTarea) INTO desaprobadas FROM tareas t, relestadotarea ret, estado e, relusuariotarea rut, usuarios u WHERE t.IdTarea = ret.IdTarea AND t.Estado = ret.IdEstado AND e.IdEstado = ret.IdEstado AND u.IdUsuario = rut.IdUsuario AND t.IdTarea = rut.IdTarea AND u.IdUsuario = n1 AND e.IdEstado = 3;
        -- Globales
        SELECT COUNT(t.IdTarea) INTO globales FROM tareas t, reltareanotif rtn, categorias c, relestadotarea ret, relusuariotarea rut, rol r, relusuariorol rur WHERE r.IdRol = rur.IdRol AND rur.IdRol = 1 AND rut.IdUsuario = n1 AND t.IdTarea = rtn.IdTarea AND t.IdCategoria = c.IdCategoria AND t.IdTarea = ret.IdTarea AND t.IdTarea = rut.IdTarea AND t.IdCategoria = 1 AND t.Estado = 1;
		-- Importantes
        SELECT COUNT(t.IdTarea) INTO importantes FROM tareas t, reltareanotif rtn, categorias c, relestadotarea ret, relusuariotarea rut, rol r, relusuariorol rur  WHERE r.IdRol = rur.IdRol AND rur.IdRol = 1 AND rut.IdUsuario = n1 AND t.IdTarea = rtn.IdTarea AND t.IdCategoria = c.IdCategoria AND t.IdTarea = ret.IdTarea AND t.IdTarea = rut.IdTarea AND t.IdCategoria = 2 AND t.Estado = 1;
		-- Olvidadas
		SELECT COUNT(t.IdTarea) INTO olvidadas FROM tareas t, reltareanotif rtn, categorias c, relestadotarea ret, relusuariotarea rut, rol r, relusuariorol rur  WHERE r.IdRol = rur.IdRol AND rur.IdRol = 1 AND rut.IdUsuario = n1 AND t.IdTarea = rtn.IdTarea AND t.IdCategoria = c.IdCategoria AND t.IdTarea = ret.IdTarea AND t.IdTarea = rut.IdTarea AND t.IdCategoria = 3 AND t.Estado = 1;
		
        SELECT Nombre INTO u FROM usuarios WHERE IdUsuario = n1;
        
        SELECT u, aprobadas, desaprobadas, importantes, olvidadas, globales;
END //

USE reme;
DELIMITER //
CREATE PROCEDURE `Verificar_Clave`(n1 VARCHAR(12), n2 INT)
BEGIN
	 DECLARE na VARCHAR(15);
     DECLARE r INT;
	 DECLARE EXIT HANDLER FOR SQLEXCEPTION
     BEGIN
     ROLLBACK;
     END;
     DECLARE EXIT HANDLER FOR SQLWARNING
     BEGIN
     ROLLBACK;
     END;
     START TRANSACTION;
		SELECT Nombre INTO na FROM usuarios WHERE IdUsuario = n2;
		SELECT COUNT(IdUsuario) INTO r FROM usuarios WHERE Clave = n1 AND Nombre = na;
        IF r = 1 THEN
			SELECT 'correcto' AS Mensaje;
		ELSE
			SELECT 'incorrecto' AS Mensaje;
		END IF;
     COMMIT;
END //

USE reme;
DELIMITER //
CREATE PROCEDURE `Verificar_Nombre`(n1 VARCHAR(15))
BEGIN
	 DECLARE c INT;
	 DECLARE EXIT HANDLER FOR SQLEXCEPTION
     BEGIN
     ROLLBACK;
     END;
     DECLARE EXIT HANDLER FOR SQLWARNING
     BEGIN
     ROLLBACK;
     END;
     START TRANSACTION;
		SELECT COUNT(Nombre) INTO c FROM usuarios WHERE Nombre = n1;
        IF c >= 1 THEN
			SELECT 'existente' AS Mensaje;
		ELSE
			SELECT 'correcto' AS Mensaje;
        END IF;
     COMMIT;
END //

USE reme;
DELIMITER //
CREATE PROCEDURE `Verificar_Registro`(n1 VARCHAR(15), n2 VARCHAR(35))
BEGIN
	 DECLARE c INT;
     DECLARE e INT;
	 DECLARE EXIT HANDLER FOR SQLEXCEPTION
     BEGIN
     ROLLBACK;
     END;
     DECLARE EXIT HANDLER FOR SQLWARNING
     BEGIN
     ROLLBACK;
     END;
     START TRANSACTION;
		SELECT COUNT(Nombre) INTO c FROM usuarios WHERE Nombre = n1;
        SELECT COUNT(Mail) INTO e FROM usuarios WHERE Mail = n2;
        IF c >= 1 OR e >= 1 THEN
			SELECT 'existente' AS Mensaje;
		ELSE
			SELECT 'correcto' AS Mensaje;
        END IF;
     COMMIT;
END //