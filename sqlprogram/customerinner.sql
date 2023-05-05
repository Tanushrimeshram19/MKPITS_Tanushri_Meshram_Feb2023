CREATE TABLE customer (custid int PRIMARY KEY IDENTITY,custname varchar(45) NOT NUll ,telno int)
 insert into customer values('prachi',12345)
 insert into customer values('karishma',56789)
 insert into customer values('monali',98765)
 insert into customer values('anjali',34578)


CREATE TABLE orders (orderid int,orderdate int,custid int,prodname varchar(20) NOT NULL,qty int,rate int)
   insert into orders values(3354,12-3-2021,1234,'computer',1,50000)
   insert into orders values(5678,19-2-2002,4567,'keyboard',5,6000)
   insert into orders values(1234,13-7-2000,6789,'pendrive',10,5000)
   insert into orders values(4567,12-4-2003,2694,'laptop',2,70000)
  
select c.custid,c.custname,o.orderid,o.prodname
from customer c inner join orders o on c.custid=o.custid
select * from customer
select * from orders
   