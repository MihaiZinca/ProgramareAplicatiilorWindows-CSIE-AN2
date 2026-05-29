CREATE TABLE PARC(
Id INT PRIMARY KEY,
Proprietar VARCHAR(30),
Pret FLOAT,
Nr_Locuri INT,
Nr_Curse INT,
GreutateMarfa VARCHAR(100)
);

INSERT INTO PARC VALUES
(2, 'Maria Ionescu', 1500, 40, 2, '10.0, 15.5'),
(3, 'Gigel Stan', 900, 30, 4, '8.5, 11.2, 14.7, 9.9');