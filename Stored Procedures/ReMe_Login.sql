USE reme;
DELIMITER //
CREATE PROCEDURE `Login`(n1 VARCHAR(15), n2 VARCHAR(12))
BEGIN
	 DECLARE c INT;
     DECLARE id INT;
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
		SELECT COUNT(Nombre) INTO c FROM usuarios WHERE Nombre = n1 AND Clave = n2;
        IF c = 0 THEN
			SELECT 'incorrecto' AS Mensaje;
        END IF;
        SELECT IdUsuario INTO id FROM usuarios WHERE Nombre = n1 AND Clave = n2;
        SELECT IdRol INTO r FROM usuarios WHERE Nombre = n1 AND Clave = n2;
        
        IF c = 1 THEN
			SELECT 'correcto' AS Mensaje, id AS Identify, r AS Rol;
        END IF;
     COMMIT;
END //