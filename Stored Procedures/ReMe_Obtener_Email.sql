USE reme;
DELIMITER //
CREATE PROCEDURE Obtener_Email(n1 VARCHAR(15), n2 VARCHAR(12))
BEGIN
	 DECLARE e VARCHAR(35);
    
	 DECLARE EXIT HANDLER FOR SQLEXCEPTION
     BEGIN
     ROLLBACK;
     END;
     DECLARE EXIT HANDLER FOR SQLWARNING
     BEGIN
     ROLLBACK;
     END;
     START TRANSACTION;
		SELECT Mail INTO e FROM usuarios WHERE Nombre = n1 AND Clave = n2;
        SELECT e AS Mail;
     COMMIT;
END //