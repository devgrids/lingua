/*
  Author: Yordy Leonidas MV

  This stored procedure updates user information in the '[user]' table.

  Procedure Name: sp_UpdateUser

  Parameters:
    - @user_id: ID of the user to be updated
    - @first_name: First name of the user
    - @last_name: Last name of the user
    - @email: Email address of the user
    - @birth_date: Date of birth of the user
    - @gender: Gender of the user
    - @account_status: Status of the user account

*/

-- Create procedure to update user
CREATE PROCEDURE [dbo].[sp_UpdateUser]
    @user_id INT,
    @first_name VARCHAR(50),
    @last_name VARCHAR(50),
    @email VARCHAR(100),
    @birth_date DATE,
    @gender VARCHAR(10),
    @account_status VARCHAR(20)
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE [user]
    SET first_name = @first_name,
        last_name = @last_name,
        email = @email,
        birth_date = @birth_date,
        gender = @gender,
        account_status = @account_status,
        last_update = GETDATE()
    WHERE user_id = @user_id;
END;
GO

-- Declare variables
DECLARE @user_id INT = 1;
DECLARE @first_name VARCHAR(50) = 'Juan';
DECLARE @last_name VARCHAR(50) = 'Pérez';
DECLARE @new_email VARCHAR(100) = 'juan.perez@example.com';
DECLARE @birth_date DATE = '1990-05-15';
DECLARE @gender VARCHAR(10) = 'Male';
DECLARE @account_status VARCHAR(20) = 'Inactive';

-- Execute sp_UpdateUser
EXEC [dbo].[sp_UpdateUser] 
    @user_id = @user_id,
    @first_name = @first_name,
    @last_name = @last_name,
    @email = @new_email,
    @birth_date = @birth_date,
    @gender = @gender,
    @account_status = @account_status;
