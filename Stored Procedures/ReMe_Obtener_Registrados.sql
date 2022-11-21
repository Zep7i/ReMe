USE reme;
DELIMITER //
CREATE PROCEDURE `Obtener_Registrados`()
BEGIN
	 DECLARE c INT;
     SELECT COUNT(usuarios.IdUsuario) INTO c FROM usuarios, relusuariorol rur, rol WHERE rur.IdRol = rol.IdRol AND rol.IdRol = 1 AND usuarios.IdRol = 1;
	 SELECT c, usuarios.IdUsuario FROM usuarios, relusuariorol rur, rol WHERE rur.IdRol = rol.IdRol AND rol.IdRol = 1 AND usuarios.IdRol = 1;
END //