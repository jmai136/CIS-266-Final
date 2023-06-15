DECLARE @SellerID AS INT = -1
DECLARE @FirstName AS VARCHAR(100) = 'Hoshi'
DECLARE @LastName AS VARCHAR(100) = 'Kask'
DECLARE @Email AS VARCHAR(100) = 'zzm4h94sr1a@icznn.com'
DECLARE @Password AS VARCHAR(100) = 'u3AeOX ^ 686 & h'

IF EXISTS 
	(SELECT TOP 1 SellerID FROM [Sellers] 
	WHERE FirstName = @FirstName 
	AND LastName = @LastName 
	AND Email=@Email 
	AND Password=HASHBYTES('SHA2_512', @Password)) 
                         BEGIN 
                             SET @SellerID=(SELECT SellerID FROM Sellers 
                             WHERE FirstName = @FirstName 
                             AND LastName = @LastName 
                             AND Email=@Email 
                             AND Password =HASHBYTES('SHA2_512', @Password)) 
                         END 
                     ELSE 
                     INSERT INTO Sellers (FirstName, LastName, Email, Password)  
                     VALUES (@FirstName, @LastName, @Email, HASHBYTES('SHA2_512', @Password))

PRINT @SellerID