----------check constrain--------------
CREATE TABLE product(product_id INT IDENTITY PRIMARY KEY, product_name VARCHAR(255) NOT NULL,unit_price DEC(15,2) CHECK(unit_price > 0));
insert into product values('mouse',150)
insert into product values('keyboard',260)
insert into product values('computer',250)
insert into product values('laptop',230)
insert into product values('headphone',235)
insert into product values('bluetooth',150)
select*from product

-------------check (unit>0)-----------------
create table results(rno int primary key,marks int check(marks > 0))
insert into results values(1,25)
insert into results values(2,80)
insert into results values(3,70)
select *from results
 
 -----------check constraint and null------------
 create table product1(product_id int identity primary key,product_name varchar(300) NOT NULL,unit_price DEC(10,2) check(unit_price > 0),
discounted_price dec(20,4) check(discounted_price > 0),
check(discounted_price < unit_price));

insert into product1 values('keyboard',180,25)
insert into product1 values('mouse',150,30)
insert into product1 values('computer',190,30)
select* from product1

----------------alter --------------
create  table prd1(prdid int identity primary key,prdname varchar(20),price int,discount int,check(price>0),check(discount<price));
insert into prd1 values(null,50,12)
alter table prd1 add mobno varchar(20)
select * from prd1

--------------drop-------------------
create table prd2(prdid int identity primary key,prdname varchar(20),price int not null)
insert into  prd2 values(null,50,15)
select* from prd2
alter table prd2
drop column prdname;
select*from prd2





                                                                                                                                                                                                                                                                                                                                                                                                                                                                        




