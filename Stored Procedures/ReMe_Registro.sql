USE reme;
DELIMITER //
CREATE PROCEDURE `Registro`(n1 VARCHAR(15), n2 VARCHAR(35), n3 VARCHAR(12))
BEGIN
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
		INSERT INTO `reme`.`usuarios` (`Nombre`, `Mail`, `Clave`, `IdRol`) VALUES (n1, n2, n3, '1');
        SELECT IdUsuario INTO a FROM usuarios ORDER BY IdUsuario DESC LIMIT 1;
        SELECT a;
     COMMIT;
END //