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