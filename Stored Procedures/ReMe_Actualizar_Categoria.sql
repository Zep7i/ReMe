USE reme;
DELIMITER //
CREATE PROCEDURE `Actualizar_Categoria`(n1 INT, n2 INT)
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
		UPDATE tareas SET IdCategoria = n2 WHERE IdTarea = n1;
     COMMIT;
END //