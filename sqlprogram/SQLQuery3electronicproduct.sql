create table product (name varchar(25) ,id int,quantity int,price int,orderdate int)
insert into product values('computer',1,7,50000,19-2-2002,2001)
insert into product values('freeze',2,5,25000,20-3-2001,2002)
insert into product values ('tv',3,6,5000,1-1-2000,2003)
insert into product values('tablet',4,8,40000,5-6-2003,2004)
insert into product values('laptop',5,10,54000,13-7-2000,2005)
insert into product values('mobile',6,9,25000,19-8-2000,2006)
SELECT id,name,orderdate,price from product
select id,name,orderdate,price from product where id=1 order by price desc
select id,name,price from product
SELECT id,name,orderdate,price  from product
SELECT id,name,orderdate,price from product where price >25000 
SELECT id,name,orderdate from product where price>25000 or price>50000 order by price desc


