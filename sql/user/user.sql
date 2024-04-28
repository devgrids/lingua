/*
  Author: Yordy Leonidas MV

  This script creates a table named '[user]' to store user information and inserts sample data into it.

  Table Structure:
    - user_id:       Primary key, auto-incremented integer
    - first_name:    First name of the user
    - last_name:     Last name of the user
    - email:         Email address of the user (unique)
    - password_hash: Hashed password of the user
    - birth_date:    Date of birth of the user
    - gender:        Gender of the user
    - registration_date: Date and time of user registration (default current date and time)
    - last_update:   Date and time of last update (default current date and time)
    - account_status: Status of the user account (default 'Active')

  Sample Data:
    - 10 sample users with their information

*/

USE lingua
GO

-- Create users table
CREATE TABLE [user] (
    user_id INT IDENTITY(1,1) PRIMARY KEY,
    first_name VARCHAR(50) NOT NULL,
    last_name VARCHAR(50) NOT NULL,
    email VARCHAR(100) UNIQUE NOT NULL,
    password_hash VARBINARY(256) NOT NULL,
    birth_date DATE,
    gender VARCHAR(10),
    registration_date DATETIME2 DEFAULT GETDATE(),
    last_update DATETIME2 DEFAULT GETDATE(),
    account_status VARCHAR(20) DEFAULT 'Active'
);
GO

-- Insert sample data into users table
INSERT INTO [user] (first_name, last_name, email, password_hash, birth_date, gender)
VALUES
('John', 'Doe', 'john.doe@example.com', HASHBYTES('SHA2_256', 'password1'), '1990-05-15', 'Male'),
('Jane', 'Doe', 'jane.doe@example.com', HASHBYTES('SHA2_256', 'password2'), '1992-08-20', 'Female'),
('Alice', 'Smith', 'alice.smith@example.com', HASHBYTES('SHA2_256', 'password3'), '1985-11-10', 'Female'),
('Bob', 'Johnson', 'bob.johnson@example.com', HASHBYTES('SHA2_256', 'password4'), '1988-03-25', 'Male'),
('Emily', 'Brown', 'emily.brown@example.com', HASHBYTES('SHA2_256', 'password5'), '1993-07-18', 'Female'),
('Michael', 'Jones', 'michael.jones@example.com', HASHBYTES('SHA2_256', 'password6'), '1982-09-30', 'Male'),
('Sarah', 'Williams', 'sarah.williams@example.com', HASHBYTES('SHA2_256', 'password7'), '1991-12-05', 'Female'),
('David', 'Martinez', 'david.martinez@example.com', HASHBYTES('SHA2_256', 'password8'), '1987-04-12', 'Male'),
('Sophia', 'Taylor', 'sophia.taylor@example.com', HASHBYTES('SHA2_256', 'password9'), '1984-06-28', 'Female'),
('Daniel', 'Anderson', 'daniel.anderson@example.com', HASHBYTES('SHA2_256', 'password10'), '1995-02-08', 'Male');
GO

-- Display all records from the users table
SELECT * FROM [user];
