-- Creeaza baza de date
IF NOT EXISTS (
    SELECT name 
    FROM sys.databases 
    WHERE name = 'Paw_25'
)
BEGIN
    CREATE DATABASE Paw_25;
END
GO

USE Paw_25;
GO

-- Creeaza tabela
IF NOT EXISTS (
    SELECT * 
    FROM sys.tables 
    WHERE name = 'Persoane'
)
BEGIN
    CREATE TABLE Persoane (
        Marca INT PRIMARY KEY,
        Nume NVARCHAR(80),
    );
END
GO

-- Insereaza date
INSERT INTO Persoane
VALUES 
(100, 'Vasile'),
(200, 'Ionescu'),
(300, 'Valentina');
GO