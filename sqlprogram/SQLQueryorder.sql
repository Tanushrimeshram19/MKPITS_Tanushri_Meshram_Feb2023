create table orders(orderno int primary key,ordedate varchar(35),custid int)

create table orderid(orderno int,prodid int,rate int,qty int,
constraint t1 foreign key(orderno)references orders(orderno))

insert into orders values(1,12/12/2022,212)
insert into orderid values(1,123,200,2)
insert into orderid values(1,124,500,1)

insert into orders values(2,12/1/2023,213)
insert into orderid values(2,123,200,1)
insert into orderid values(2,125,600,2)

insert into orders values(3,13/2/2023,214)
insert into orderid values(3,124,600,1)
select*from orders
