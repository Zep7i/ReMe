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