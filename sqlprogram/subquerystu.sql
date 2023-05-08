create table student1 (rno int primary key,name varchar(20),email varchar(20),city varchar(15),courseid int)
insert into student1 values(11,'tanu','tanu@','nagpur',123)
insert into student1 values(12,'karishma','kari@','mumbai',456)
insert into student1 values(13,'monali','mona@','delhi',789)

create table fees (feesid  int ,rno int constraint cs foreign key(rno)references student(rno),feesdate int,amount int,courseid varchar(20));
insert into fees values(14,11,12-2-2021,20000,876)
insert into fees values(15,12,14-1-2022,15000,987)
insert into fees values(16,13,19-2-2021,25000,321)
select*from student1
select*from fees

select feesid,rno,feesdate,amount,courseid from fees where rno in(select rno from student1 where city='nagpur')
select feesid,rno,feesdate,amount,courseid from fees where rno in(select rno from student1 where city='mumbai')
select feesid,rno,feesdate,amount,courseid from fees where rno in(select rno from student1 where city='delhi')

---------------------order--------------------------
create table orders(orderid int,custid int,orderdate int,productname varchar(20), quantity int)
insert into orders values(1,1,19-2-2021,'mouse',7)
insert into orders values(2,2,13-7-2022,'keyboard',5)
insert into orders values(3,3,7-8-2021,'pendrive',12)
insert into orders values(4,4,4-4-2021,'computer',1)
select*from orders

create table  customer(customerid int primary key,firstname varchar(20),lastname varchar(20),phone int,email varchar(25),street varchar(20),city varchar(15),state varchar(20),zipcode int)
insert into customer values(6,'tanu','meshram',12345,'tanu@','bardiroad','nagpur','maharashtra',678)
insert into customer values(7,'monali','mohtakar',56789,'monali@','sakardhara','pune','maharashtra',789)
insert into customer values(11,'karishma','pachdhare',78954,'kari@','mankapur','mumbai','maharashtra',123)
insert into customer values(19,'prachi','pachbhude',1589,'prachu@','kalmeshwar','delhi','maharashtra',964)
select*from customer


select orderid,custid,orderdate,productname,quantity
from orders
where custid in
(select custid from customer where
city='nagpur')

select orderid,custid,orderdate,productname,quantity
from orders
where custid in
(select custid from customer where
city='pune')

select orderid,custid,orderdate,productname,quantity
from orders
where custid in
(select custid from customer where
city='delhi')
order by orderdate desc
SELECT
customerid
FROM
customer
WHERE
city = 'pune'