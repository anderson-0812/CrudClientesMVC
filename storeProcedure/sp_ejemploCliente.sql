-- ALTER PROCEDURE => SIRVE PARA ALTERAR UN SP YA CREADOß
CREATE PROCEDURE sp_crearCliente
AS 
BEGIN 
	BEGIN TRANSACTION 
		BEGIN TRY 
			insert into tblClientes values('PruebaNombre2','Prueba Apellido2','Prueba correo2','110Prueba2');
		COMMIT;
		SELECT 'OK' mensaje;
		END TRY

		BEGIN CATCH	
			IF @@TRANCOUNT > 0
				rollback transaction
				SELECT 'OK' mensaje;

		END CATCH
END


-- consultar datos
select * from tblClientes;

-- asi se ejecuta un sotre prodecure
exec sp_crearCliente;

-- consultar datos
select * from tblClientes;
