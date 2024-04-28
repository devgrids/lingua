/*
  Author: Yordy Leonidas MV

  This stored procedure inserts a new user into the '[user]' table.

  Procedure Name: sp_InsertUser

  Parameters:
    - @first_name: First name of the user
    - @last_name: Last name of the user
    - @email: Email address of the user
    - @password: Password of the user (plain text)
    - @birth_date: Date of birth of the user
    - @gender: Gender of the user

*/

-- Create procedure to insert user
CREATE PROCEDURE [dbo].[sp_InsertUser]
    @first_name VARCHAR(50),
    @last_name VARCHAR(50),
    @email VARCHAR(100),
    @password VARCHAR(100), -- Password as plain text
    @birth_date DATE,
    @gender VARCHAR(10)
AS
BEGIN
    DECLARE @password_hash VARBINARY(256);
    SET @password_hash = HASHBYTES('SHA2_256', @password);

    INSERT INTO [user] (first_name, last_name, email, password_hash, birth_date, gender)
    VALUES (@first_name, @last_name, @email, @password_hash, @birth_date, @gender)
END;
GO

-- Execute sp_InsertUser
EXEC [dbo].[sp_InsertUser]
    @first_name = 'John',
    @last_name = 'Doe',
    @email = 'john@example.com',
    @password = 'password', -- Password should be entered as plain text here
    @birth_date = '1990-01-01',
    @gender = 'Male';
