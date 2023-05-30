
create table salesman1(salesmanid int primary key,name varchar(20),city varchar(20),commission dec(10,2))
insert into salesman1 values(5001, 'James Hoog', 'New York', 0.15)
insert into salesman1 values(5002, 'Nail Knite', 'Paris', 0.13)
insert into salesman1 values(5005, 'Pit Alex', 'London', 0.11)
insert into salesman1 values(5006, 'Mc Lyon', 'Paris', 0.14)
insert into salesman1 values(5003, 'Lauson Hen', 'San Jose', 0.12)
insert into salesman1 values(5007, 'Paul Adam', 'Rome', 0.13)

create table customer2(cust_id int primary key,cust_name varchar(20),
city varchar(20),grade int,salesmanid int constraint s1 foreign key(salesmanid)references salesman1(salesmanid))
insert into customer2 values(3002 , 'Nick Rimando' ,' New York',  100,  5001)
insert into customer2 values(3007, 'Brad Davis', 'New York',  200 , 5001)
insert into customer2 values(3005 , 'Graham Zusi',  'California', 200,  5002)
insert into customer2 values(3008,  'Julian Green',  'London' , 300,  5002)
insert into customer2 values(3004 , 'Fabian Johnson',  'Paris',  300 , 5006)
insert into customer2 values(3009 , 'Geoff Cameron',  'Berlin',  100 , 5003)
insert into customer2 values(3003 , 'Jozy Altidor',  'Moscow', 200 , 5007)
insert into customer2 values(3001 , 'Brad Guzan', 'London',null, 5005)

create table orders1(ord_no int, purch_amt int,ord_date date,cust_id int,constraint s2 foreign key(cust_id)references customer2(cust_id),
salesmanid int,constraint s3 foreign key(salesmanid) references salesman1(salesmanid))

insert into orders1 values(70001, 150.5, '2012-10-05', 3005, 5002)
insert into orders1 values(70009, 270.65, '2012-09-10', 3001, 5005)
insert into orders1 values(70002, 65.26, '2012-10-05', 3002, 5001)
insert into orders1 values(70004, 110.5, '2012-08-17', 3009, 5003)
insert into orders1 values(70007, 948.5, '2012-09-10', 3005, 5002)
insert into orders1 values(70005, 2400.6, '2012-07-27', 3007, 5001)
insert into orders1 values(70008, 5760, '2012-09-10', 3002, 5001)
insert into orders1 values(70010,1983.43, '2012-10-10', 3004, 5006)
insert into orders1 values(70003, 2480.4, '2012-10-10', 3009, 5003)
insert into orders1 values(70012, 250.45, '2012-06-27', 3008, 5002)
insert into orders1 values(70011, 75.29, '2012-08-17', 3003, 5007)
insert into orders1 values(70013, 3045.6, '2012-04-25', 3002, 5001)

select*from salesman1
select*from customer2
select*from orders1
----------------1 query-----------------------------
select * from orders1 
where salesmanid=(select salesmanid
from salesman1
where name='Nail Knite');

---------------2 query--------------

select*
from orders1
where salesmanid In 
(select salesmanid from salesman1 where city='new york');
----------------3 query-----------------
SELECT *
FROM orders1
WHERE salesmanid =
(SELECT DISTINCT salesmanid
FROM orders1
WHERE cust_id =3007);

select*
from orders1
where salesmanid=(select distinct salesmanid
from orders1
where cust_id=3009);

-------------------4 query-------------------
SELECT *
FROM orders1
WHERE purch_amt >
(SELECT AVG(purch_amt)
FROM orders1
WHERE ord_date ='10/10/2012');
-----------------------5 query----------------
SELECT *
FROM orders1
WHERE salesmanid IN
(SELECT salesmanid
FROM salesman1
WHERE city ='New York');

------6 query----------------
SELECT commission
FROM salesman1
WHERE salesmanid IN
(SELECT salesmanid
FROM customer2
WHERE city = 'Paris');

--------------7 query-------------
SELECT *
FROM customer2
WHERE cust_id =
(SELECT salesmanid -2001
FROM salesman1
WHERE name = 'Mc Lyon');

---------------8 query-------------
SELECT grade, COUNT (*)
FROM customer2
GROUP BY grade

HAVING grade >
(SELECT AVG(grade)
FROM customer2
WHERE city = 'New York');

------------------9 query--------------
SELECT ord_no, purch_amt, ord_date, salesmanid
FROM orders1
WHERE salesmanid IN(
SELECT salesmanid

FROM salesman1
WHERE commission = (
SELECT MAX(commission)

from salesman1 where commission=
FROM salesman1));

---------------10 query-----------------------
SELECT b.*, a.cust_name
FROM orders1 b, customer2 a
WHERE a.cust_id=b.cust_id
AND b.ord_date='2012-08-17';

-----------------11 query----------------------
SELECT salesmanid,name
FROM salesman1 a
WHERE 1 <
(SELECT COUNT(*)
FROM customer2
WHERE salesmanid=a.salesmanid);

-----------------12 query----------------------
select*from orders1 a
where purch_amt>
(select avg(purch_amt)from orders1 b
where b.cust_id=a.cust_id);

----------------13 query-----------------------
select*from orders1 a
where purch_amt=(select avg(purch_amt)from orders b
where b.customer_id=a.cust_id);

select cust_id,cust_name,city
from customer2
where Exists
(select * from customer2
where city='paris');

select* from salesman1
where city In(select city from customer2);





