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