create table order_details(orderid int,productid int ,quantity int primary key (orderid,productid))

insert into order_details values(1,11,2);
insert into order_details values(1,12,2);
insert into order_details values(1,13,3);
insert into order_details values(2,11,2);
select*from order_details

-----unique key-------
create table sample2(id int unique,name
varchar(20))
insert into sample2(name) values('ravi')
select * from sample2