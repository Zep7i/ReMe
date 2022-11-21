USE reme;
DELIMITER //
CREATE PROCEDURE Cambiar_Clave(n1 VARCHAR(12), n2 INT)
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