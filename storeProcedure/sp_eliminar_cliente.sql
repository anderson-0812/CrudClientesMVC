-- video https://www.youtube.com/watch?v=mavPb4BAvvg&ab_channel=AlejandroZapetaAlejandroZapeta
-- https://www.youtube.com/watch?v=ygBbKPmfiEc&ab_channel=CodigoWolf

CREATE PROCEDURE SP_ELIMINAR_CLIENTE
@ID INT
AS 
BEGIN 
	BEGIN TRANSACTION 
		BEGIN TRY 
			delete from tblClientes where ID = @ID;
		COMMIT;
		SELECT 'OK' mensaje;
		END TRY

		BEGIN CATCH	
			IF @@TRANCOUNT > 0
				rollback transaction
				SELECT 'OK' mensaje;

		END CATCH
END