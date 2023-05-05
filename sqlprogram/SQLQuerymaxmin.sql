------------minimum,maximum------------------

create table productqty2(id int,region varchar(25),productname varchar(20),year int,quantity int,price int)
insert into productqty2 values(1,'west','computer',2020,130,50000)
insert into productqty2 values(2,'south','computer',2020,450,45000)
insert into productqty2 values(3,'west','computer',2020,250,35000)
insert into productqty2 values(4,'east','harddisk',2021,219,5000)
insert into productqty2 values(5,'west','computer',2021,250,25000)
insert into productqty2 values(6,'south','harddisk',2021,650,35000)
insert into productqty2 values(7,'west','harddisk',2021,500,5000)
insert into productqty2 values(8,'east','pendrive',2021,120,6000)
insert into productqty2 values(9,'west','mouse',2019,50,2000)
insert into productqty2 values(10,'west','prndrive',2019,80,500)
SELECT MIN(quantity) AS "Minimum Quantity" FROM ProductQty1;
SELECT Max(quantity) AS "Maximum Quantity" FROM ProductQty1;

------------average-----------------
create table employeedetail(name varchar(20),occuption varchar(25),workingdate int,workinghour int,salary int)
insert into employeedetail values('tanu','hr',19-2-2023,9,60000)
insert into employeedetail values('prachi','engineer',18-3-2023,8,25000)
insert into employeedetail values('priyanka','software developer',1-4-2021,6,30000)
insert into employeedetail values('monali','manager',2-2-2021,5,70000)
insert into employeedetail values('karishma','writer',5-6-2023,3,40000)
insert into employeedetail values('anjali','writer',5-5-2021,9,40000)
insert into employeedetail values('pranoti','hr',19-6-2018,7,20000)
insert into employeedetail values('sanskruti','teacher',2-5-2021,3,6000)
insert into employeedetail values('pallavi','doctor',17-2-2023,6,45000)
insert into employeedetail values('vijeta','writer',6-6-2018,5,7000)
SELECT AVG(workinghour) AS "Average Working Hours"  FROM employeedetail;  
SELECT AVG(workinghour) AS "Average Working Hours"  FROM employeedetail WHERE occuption = 'Writer';   
SELECT occuption, AVG(workinghour) AS "Average Working Hours"   FROM employeedetail GROUP BY occuption;    

--------------sum function-------------------
create table employeedetail1(name varchar(20),occuption varchar(25),workingdate int,workinghour int,salary int)
insert into employeedetail1 values('tanu','hr',19-2-2023,9,60000)
insert into employeedetail1 values('prachi','engineer',18-3-2023,8,25000)
insert into employeedetail1 values('priyanka','software developer',1-4-2021,6,30000)
insert into employeedetail1 values('monali','manager',2-2-2021,5,70000)
insert into employeedetail1 values('karishma','writer',5-6-2023,3,40000)
insert into employeedetail1 values('anjali','writer',5-5-2021,9,40000)
insert into employeedetail1 values('pranoti','hr',19-6-2018,7,20000)
insert into employeedetail1 values('sanskruti','teacher',2-5-2021,3,6000)
insert into employeedetail1 values('pallavi','doctor',17-2-2023,6,45000)
insert into employeedetail1 values('vijeta','writer',6-6-2018,5,7000)
SELECT SUM(salary) AS "Total Salary"  FROM employeedetail WHERE workinghour>6;  
SELECT occuption, SUM(salary) AS "Total Salary"  FROM employeedetail  GROUP BY occuption;  

---------------count function-----------------
create table product(productid int,name varchar(20),qty int,price int)
insert into product values(1,'computer',1,50000)
insert into product values(2,'mouse',8,500)
insert into product values(3,'keyboard',5,5000)
insert into product values(4,'bluetooth',6,4000)
insert into product values(5,'laptop',3,80000)
insert into product values(6,'pendrive',10,500)
insert into product values(7,'mouse',2,400)
select * from product
select count(price) as 'total' from product
select count(price) as 'total' from product 
where name ='mouse'
select name,count(price) as 'total' from product
group by name





















  


  
   


