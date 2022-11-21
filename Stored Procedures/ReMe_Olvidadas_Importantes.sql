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