USE AdvancedSQLDB;
GO
CREATE TABLE ProductAudit
(
    AuditID INT IDENTITY(1,1) PRIMARY KEY,
    ProductID INT,
    ProductName VARCHAR(100),
    Price DECIMAL(10,2),
    ActionPerformed VARCHAR(20),
    ActionDate DATETIME DEFAULT GETDATE()
);

CREATE TRIGGER trg_ProductInsert
ON Products
AFTER INSERT
AS
BEGIN
    INSERT INTO ProductAudit
    (
        ProductID,
        ProductName,
        Price,
        ActionPerformed
    )
    SELECT
        ProductID,
        ProductName,
        Price,
        'INSERT'
    FROM inserted;
END;
GO

INSERT INTO Products
VALUES
(
    14,
    'Bluetooth Speaker',
    'Electronics',
    4500
);

SELECT * FROM ProductAudit;


DECLARE @ProductName VARCHAR(100);

DECLARE ProductCursor CURSOR FOR
SELECT ProductName
FROM Products;

OPEN ProductCursor;

FETCH NEXT FROM ProductCursor
INTO @ProductName;

WHILE @@FETCH_STATUS = 0
BEGIN
    PRINT @ProductName;

    FETCH NEXT FROM ProductCursor
    INTO @ProductName;
END;

CLOSE ProductCursor;
DEALLOCATE ProductCursor;