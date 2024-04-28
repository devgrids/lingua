/*
  Author: Yordy Leonidas MV

  This stored procedure retrieves user information from the '[user]' table based on the email and password.

  Procedure Name: sp_GetUserByEmailAndPassword

  Parameters:
    - @email: Email address of the user
    - @password: Password of the user (plain text)

*/

CREATE PROCEDURE [dbo].[sp_GetUserByEmailAndPassword]
    @user_email VARCHAR(100),
    @password VARCHAR(100)
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @password_hash VARBINARY(256);
    SET @password_hash = HASHBYTES('SHA2_256', @password);

    SELECT *
    FROM [user]
    WHERE email = @user_email
    AND password_hash = @password_hash;
END;
GO

-- Declare variables
DECLARE @user_email VARCHAR(100) = 'juan.perez@example.com';
DECLARE @password VARCHAR(100) = 'password1';

-- Execute sp_GetUserByEmailAndPassword
EXEC [dbo].[sp_GetUserByEmailAndPassword] 
    @user_email,
    @password;
