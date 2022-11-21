USE reme;
DELIMITER //
CREATE PROCEDURE Crear_Tarea(n1 VARCHAR(15), n2 INT, n3 INT, n4 INT, n5 DATE, n6 DATE, n7 INT, n8 DATE)
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