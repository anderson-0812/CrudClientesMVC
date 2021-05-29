-- video https://www.youtube.com/watch?v=mavPb4BAvvg&ab_channel=AlejandroZapetaAlejandroZapeta
-- https://www.youtube.com/watch?v=ygBbKPmfiEc&ab_channel=CodigoWolf

CREATE PROCEDURE SP_INSERTAR_CLIENTE
@Nombres VARCHAR(300),
@Apellidos VARCHAR(300),
@Correo NCHAR(50),
@CI NCHAR(10)
AS 
BEGIN 
	BEGIN TRANSACTION 
		BEGIN TRY 
			insert into tblClientes values(@Nombres,@Apellidos,@Correo,@CI);
		COMMIT;
		SELECT 'OK' mensaje;
		END TRY

		BEGIN CATCH	
			IF @@TRANCOUNT > 0
				rollback transaction
				SELECT 'OK' mensaje;

		END CATCH
END