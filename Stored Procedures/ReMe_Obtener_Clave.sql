USE reme;
DELIMITER //
CREATE PROCEDURE `Obtener_Clave`(n1 INT)
BEGIN
	 DECLARE c VARCHAR(12);
	 DECLARE EXIT HANDLER FOR SQLEXCEPTION
     BEGIN
     ROLLBACK;
     END;
     DECLARE EXIT HANDLER FOR SQLWARNING
     BEGIN
     ROLLBACK;
     END;
     START TRANSACTION;
		SELECT Clave INTO c FROM usuarios WHERE IdUsuario = n1;
        SELECT c AS Mensaje;
     COMMIT;
END //