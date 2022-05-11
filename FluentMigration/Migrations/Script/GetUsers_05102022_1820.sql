CREATE PROCEDURE [dbo].[GetUsers]
AS
BEGIN
SET NOCOUNT ON
 
	SELECT Name, Surname, BirthDate
	FROM Users
 
END