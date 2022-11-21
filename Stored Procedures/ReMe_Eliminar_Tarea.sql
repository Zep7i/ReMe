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