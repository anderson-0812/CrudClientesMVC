-- video https://www.youtube.com/watch?v=mavPb4BAvvg&ab_channel=AlejandroZapetaAlejandroZapeta
-- https://www.youtube.com/watch?v=ygBbKPmfiEc&ab_channel=CodigoWolf

CREATE PROCEDURE SP_EDITAR_CLIENTE
@Nombres VARCHAR(300),
@Apellidos VARCHAR(300),
@Correo NCHAR(50),
@CI NCHAR(10),
@ID INT
AS 
BEGIN 
	BEGIN TRANSACTION 
		BEGIN TRY 
			update tblClientes set Nombres = @Nombres, Apellidos = @Apellidos, Correo = @Correo, Ci = @CI
			where ID = @ID;
		COMMIT;
		SELECT 'OK' mensaje;
		END TRY

		BEGIN CATCH	
			IF @@TRANCOUNT > 0
				rollback transaction
				SELECT 'OK' mensaje;

		END CATCH
END