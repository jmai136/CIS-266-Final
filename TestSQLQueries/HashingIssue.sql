DECLARE @HashOG AS VARCHAR(MAX)
DECLARE @HashUnicode AS VARCHAR(MAX)
DECLARE @HashConvertedToNVarchar AS NVARCHAR(MAX)

SET @HashOG = (HASHBYTES('SHA2_512', 'u3AeOX ^ 686 & h'))
SET @HashConvertedToNVarchar = (HASHBYTES('SHA2_512', CAST('u3AeOX ^ 686 & h' AS NVARCHAR)))
SET @HashUnicode = (HASHBYTES('SHA2_512', N'u3AeOX ^ 686 & h'))

PRINT @HashOG
PRINT @HashConvertedToNVarChar
PRINT @HashUnicode

SELECT HASHBYTES('SHA2_512', 'u3AeOX ^ 686 & h') AS Hash, HASHBYTES('SHA2_512', N'u3AeOX ^ 686 & h') AS HashUnicode