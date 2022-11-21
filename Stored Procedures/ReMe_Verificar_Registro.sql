USE reme;
DELIMITER //
CREATE PROCEDURE Verificar_Registro(n1 VARCHAR(15), n2 VARCHAR(35))
BEGIN
	 DECLARE c INT;
     DECLARE e INT;
	 DECLARE EXIT HANDLER FOR SQLEXCEPTION
     BEGIN
     ROLLBACK;
     END;
     DECLARE EXIT HANDLER FOR SQLWARNING
     BEGIN
     ROLLBACK;
     END;
     START TRANSACTION;
		SELECT COUNT(Nombre) INTO c FROM usuarios WHERE Nombre = n1;
        SELECT COUNT(Mail) INTO e FROM usuarios WHERE Mail = n2;
        IF c >= 1 OR e >= 1 THEN
			SELECT 'existente' AS Mensaje;
		ELSE
			SELECT 'correcto' AS Mensaje;
        END IF;
     COMMIT;
END //