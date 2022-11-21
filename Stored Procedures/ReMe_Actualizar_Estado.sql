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