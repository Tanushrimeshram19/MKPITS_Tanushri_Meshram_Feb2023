create table students(id int,name varchar(25),subject varchar(20),marks int)
insert into students values(1,'tanu','maths',500)
insert into students values(2,'priyanka','chemistry',600)
----------maximum,minimum-----------
insert into students values(3,'prachi','biology',700)
insert into students values(4,'sonal','marathi',800)
insert into students values(5,'sachi','maths',550)
insert into students values(6,'rashi','marathi',400)
insert into students values(7,'pranoti','history',350)
insert into students values(8,'vijeta','gography',400)

SELECT MIN(marks) AS "Minimum Quantity" FROM students;
SELECT Max(marks) AS "Maximum Quantity" FROM students;

create table studentdetail(name varchar(20),subject varchar(25),marks int,
insert into studentdetail values('tanu','hr',19-2-2023,9,60000)
insert into studentdetail values('prachi','engineer',18-3-2023,8,25000)
insert into studentdetail values('priyanka','software developer',1-4-2021,6,30000)
insert into studentdetail values('monali','manager',2-2-2021,5,70000)
insert into studentdetail values('karishma','writer',5-6-2023,3,40000)
insert into studentdetail values('anjali','writer',5-5-2021,9,40000)
insert into studentdetail values('pranoti','hr',19-6-2018,7,20000)
insert into studentdetail values('sanskruti','teacher',2-5-2021,3,6000)
insert into studentdetail values('pallavi','doctor',17-2-2023,6,45000)
insert into studentdetail values('vijeta','writer',6-6-2018,5,7000)
SELECT AVG(workinghour) AS "Average Working Hours"  FROM employeedetail;  
SELECT AVG(workinghour) AS "Average Working Hours"  FROM employeedetail WHERE occuption = 'Writer';   
SELECT occuption, AVG(workinghour) AS "Average Working Hours"   FROM employeedetail GROUP BY occuption;    

