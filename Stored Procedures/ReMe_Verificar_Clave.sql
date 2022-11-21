USE reme;
DELIMITER //
CREATE PROCEDURE Verificar_Clave(n1 VARCHAR(12), n2 INT)
BEGIN
	 DECLARE na VARCHAR(15);
     DECLARE r INT;
	 DECLARE EXIT HANDLER FOR SQLEXCEPTION
     BEGIN
     ROLLBACK;
     END;
     DECLARE EXIT HANDLER FOR SQLWARNING
     BEGIN
     ROLLBACK;
     END;
     START TRANSACTION;
		SELECT Nombre INTO na FROM usuarios WHERE IdUsuario = n2;
		SELECT COUNT(IdUsuario) INTO r FROM usuarios WHERE Clave = n1 AND Nombre = na;
        IF r = 1 THEN
			SELECT 'correcto' AS Mensaje;
		ELSE
			SELECT 'incorrecto' AS Mensaje;
		END IF;
     COMMIT;
END //