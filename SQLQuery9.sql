UPDATE Products
SET Photo = 
    (SELECT  BulkColumn FROM OPENROWSET(BULK  'C:\Users\shado\Downloads\Новая папка\Панасоник микроыолновка.jpg', SINGLE_BLOB) AS x)
WHERE ID=36