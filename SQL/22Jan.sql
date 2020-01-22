SELECT PATINDEX('%ern%', 'SQL Pattern Index');

SELECT RTRIM(CompanyName) + '(' + RTRIM(Country) +')'
FROM Suppliers
ORDER By CompanyName;

SELECT ContactName, CompanyName
FROM Customers
WHERE SOUNDEX(CompanyName) = SOUNDEX('Special');

SELECT LOWER('SQL UPPER');

SELECT
	REPLACE(
		'It is a good tea at the famous tea store.',
		'tea',
		'coffee'
		) result;

SELECT
	REPLICATE('z',3) result;

SELECT
	SUBSTRING('SQL Server SUBSTRING', 5, 6) result;

SELECT
	DATEADD(SECOND, 1, '2018-12-31 23:59:59') result;

SELECT CAST(5.95 AS INT) result;

SELECT ISDATE('2020-06-15') is_date;

SELECT OrderID, SUM(UnitPrice * Quantity) AS Total
FROM [Order Details]
GROUP By OrderID
HAVING SUM(UnitPrice * Quantity) > 30
ORDER By Total DESC;