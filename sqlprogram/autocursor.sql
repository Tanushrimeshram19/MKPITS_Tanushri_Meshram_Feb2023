create table products(pro_id int primary key,pro_name varchar(20),price int,quantity int)
insert into products values(123,'mouse',2000,6)
insert into products values(456,'keyboard',5000,9)
insert into products values(789,'pendrive',1000,12)
insert into products values(987,'laptop',50000,1)
insert into products values(654,'speaker',5000,2)
insert into products values(432,'scanner',4000,3)
   
   set implicit_transactions on
    begin transaction
   insert into Products VALUES(278,'scanner',4000,3)  
     UPDATE Products set Price = 450 WHERE Pro_id = 123  
        
   commit transaction
   BEGIN TRANSACTION  
      
    UPDATE Products SET Price = 5000 WHERE Pro_id = 987 
    DELETE FROM Products WHERE Pro_id = 432 
	
	set implicit_transactions on 
    BEGIN TRANSACTION  
     
    UPDATE Products SET Price = 5000 WHERE Pro_id = 114  
    DELETE FROM Products WHERE Pro_id = 116  

	DECLARE
@product_name VARCHAR(MAX),
@list_price DECIMAL;

DECLARE cursor_product CURSOR
FOR SELECT

pro_name, price
FROM products;
     ROLLBACK TRANSACTION  

	 FETCH NEXT FROM cursor_product INTO
@pro_name,
@price;

WHILE @@FETCH_STATUS = 0
BEGIN
PRINT @pro_name + CAST(@price AS varchar);
FETCH NEXT FROM cursor_products INTO
@pro_name,
@price;
end;





 
