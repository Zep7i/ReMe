USE reme;
DELIMITER //
CREATE PROCEDURE `Reporte_Global`(n1 INT)
BEGIN
     DECLARE u VARCHAR(15);
     DECLARE aprobadas INT;
     DECLARE desaprobadas INT;
     DECLARE importantes INT;
     DECLARE globales INT;
     DECLARE olvidadas INT;
		-- Aprobadas
		SELECT COUNT(t.IdTarea) INTO aprobadas FROM tareas t, relusuariotarea rut, relestadotarea ret, reltareaaprobada rta, rol r, relusuariorol rur  WHERE r.IdRol = rur.IdRol AND rur.IdRol = 1 AND rut.IdUsuario = n1 AND ret.IdEstado = 2 AND t.IdTarea = rta.IdTarea AND t.IdTarea = ret.IdTarea AND t.IdTarea = rut.IdTarea; 
		-- Desaprobadas
		SELECT COUNT(t.IdTarea) INTO desaprobadas FROM tareas t, relestadotarea ret, estado e, relusuariotarea rut, usuarios u WHERE t.IdTarea = ret.IdTarea AND t.Estado = ret.IdEstado AND e.IdEstado = ret.IdEstado AND u.IdUsuario = rut.IdUsuario AND t.IdTarea = rut.IdTarea AND u.IdUsuario = n1 AND e.IdEstado = 3;
        -- Globales
        SELECT COUNT(t.IdTarea) INTO globales FROM tareas t, reltareanotif rtn, categorias c, relestadotarea ret, relusuariotarea rut, rol r, relusuariorol rur WHERE r.IdRol = rur.IdRol AND rur.IdRol = 1 AND rut.IdUsuario = n1 AND t.IdTarea = rtn.IdTarea AND t.IdCategoria = c.IdCategoria AND t.IdTarea = ret.IdTarea AND t.IdTarea = rut.IdTarea AND t.IdCategoria = 1 AND t.Estado = 1;
		-- Importantes
        SELECT COUNT(t.IdTarea) INTO importantes FROM tareas t, reltareanotif rtn, categorias c, relestadotarea ret, relusuariotarea rut, rol r, relusuariorol rur  WHERE r.IdRol = rur.IdRol AND rur.IdRol = 1 AND rut.IdUsuario = n1 AND t.IdTarea = rtn.IdTarea AND t.IdCategoria = c.IdCategoria AND t.IdTarea = ret.IdTarea AND t.IdTarea = rut.IdTarea AND t.IdCategoria = 2 AND t.Estado = 1;
		-- Olvidadas
		SELECT COUNT(t.IdTarea) INTO olvidadas FROM tareas t, reltareanotif rtn, categorias c, relestadotarea ret, relusuariotarea rut, rol r, relusuariorol rur  WHERE r.IdRol = rur.IdRol AND rur.IdRol = 1 AND rut.IdUsuario = n1 AND t.IdTarea = rtn.IdTarea AND t.IdCategoria = c.IdCategoria AND t.IdTarea = ret.IdTarea AND t.IdTarea = rut.IdTarea AND t.IdCategoria = 3 AND t.Estado = 1;
		
        SELECT Nombre INTO u FROM usuarios WHERE IdUsuario = n1;
        
        SELECT u, aprobadas, desaprobadas, importantes, olvidadas, globales;
END //