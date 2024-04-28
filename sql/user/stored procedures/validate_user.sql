/*
  Author: Yordy Leonidas MV

  This stored procedure validates user credentials by checking the provided email and password against the database.

  Procedure Name: sp_ValidateUser

  Parameters:
    - @input_email: Email address of the user
    - @input_password: Password of the user

  Returns:
    - 1: If the provided email and password are valid
    - 0: If the provided email and password are invalid

*/

-- Create procedure to validate user
CREATE PROCEDURE [dbo].[sp_ValidateUser]
    @input_email VARCHAR(100),
    @input_password VARCHAR(100)
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @hashed_password VARBINARY(256);

    -- Get the password hash for the given email
    SELECT @hashed_password = password_hash FROM [user]
    WHERE email = @input_email;

    -- Validate the password
    IF @hashed_password IS NOT NULL AND @hashed_password = HASHBYTES('SHA2_256', @input_password)
    BEGIN
        -- Valid username and password
        SELECT 1 AS result;
    END
    ELSE
    BEGIN
        -- Invalid username or password
        SELECT 0 AS result;
    END
END;
GO

-- Execute the stored procedure to validate user
EXEC [dbo].[sp_ValidateUser] 'sophia.taylor@example.com', 'password9';
