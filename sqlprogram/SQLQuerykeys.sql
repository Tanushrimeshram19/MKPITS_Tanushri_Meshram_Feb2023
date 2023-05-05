create table order_details(orderid int,productid int ,quantity int primary key (orderid,productid))

insert into order_details values(1,11,2);
insert into order_details values(1,12,2);
insert into order_details values(1,13,3);
insert into order_details values(2,11,2);
select*from order_details

-------unique keys-----------
create table sample(id int unique,name varchar(20))
insert into sample(name) values('tanu')

select * from sample

create table emp(empid int primary key,empname varchar(20),mobno int unique,dlno int unique)

insert into emp values(1,'tanu',234,678)
insert into emp values(2,'karishma',256,289)
insert into emp values(3,'monali',356,987)
insert into emp values(4,'anjali',672,123)
insert into emp values(5,'prachi',287,213)
insert into emp values(6,'sachi',278,236)
select*from emp

create table employee(empid int primary key,empname varchar(20),passportno int,drivinglicenceno int,constraint e1
unique(passportno,drivinglicenceno))

insert into employee values(1,'tanu',56789,2345)
insert into employee values(2,'tanu',56678,9876)
insert into employee values(3,'tanu',12345,4567)
insert into employee values(4,'tanu',98762,67543)
insert into employee values(5,'tanu',99834,54321)
insert into employee values(6,'tanu',23456,96543)

select * from employee

-----------identity---------------

create table customer1(custid int primary key identity,custname varchar(50))

insert into customer1 values('tanu')
select * from customer1
insert into customer1 values('karishma')
select * from customer1
insert into customer1 values('mona')
select* from customer1
insert into customer1 values('anju')
select*from customer1

create table students (studid int primary key identity,studname varchar(20))
insert into students values('samiksha')
select*from students
insert into students values('kalyani')
select*from students
insert into students values('prachi')
select*from students




