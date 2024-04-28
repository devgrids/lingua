/*
  Author: Yordy Leonidas MV

  This stored procedure retrieves user information from the '[user]' table based on the user ID.

  Procedure Name: sp_GetUser

  Parameters:
    - @user_id: ID of the user to retrieve

*/

CREATE PROCEDURE [dbo].[sp_GetUser]
    @user_id INT
AS
BEGIN
    SET NOCOUNT ON;

    SELECT *
    FROM [user]
    WHERE user_id = @user_id;
END;
GO

-- Declare variables
DECLARE @user_id INT = 1;

-- Execute sp_GetUser
EXEC [dbo].[sp_GetUser] 
    @user_id = @user_id;
