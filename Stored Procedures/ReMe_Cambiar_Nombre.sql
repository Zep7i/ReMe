USE reme;
DELIMITER //
CREATE PROCEDURE Cambiar_Nombre(n1 VARCHAR(15), n2 INT)
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