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