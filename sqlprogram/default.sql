------------default-----------------
CREATE TABLE Geeks (ID int NOT NULL,Name varchar(255),Age int,Location varchar(255) default 'Noida');
insert into Geeks VALUES (4, 'tanu', 23, 'Delhi');
insert into Geeks(ID,Name,Age) VALUES (5,'prachi', 27);
insert into Geeks(ID,Name,Age)Values(6,'mona',20);
insert into Geeks(ID,Name,Age)Values(7,'karishma',29)
insert into Geeks(ID,Name,Age)Values(8,'anjali',30)
select*from geeks

-----------not null-------------
CREATE TABLE Student(ID int NOT NULL,NAME varchar(10) NOT NULL,ADDRESS varchar(20));
insert into student values(1,'tanu','nagpur')
insert into student values(2,'anjali','kalmeshwar')
insert into student values(3,'monali','savner')
insert into student values(4,'karishma','mankapur')
insert into student values(5,'prachi','umred')
insert into student values(6,'mona','pune')
select*from student

--------------unique--------------
CREATE TABLE Student1(ID int UNIQUE,NAME varchar(10),);
insert into student1 values(1,'tanu')
insert into student1(name) values('tanushri')
select * from student1


CREATE TABLE Student3(ID int UNIQUE,rno int primary key,NAME varchar(10),);
insert into student3 values(1,11,'tanu')
insert into student3(rno,name)values(12,'amit1')
select * from student3
insert into student3(name) values('amit1')

CREATE TABLE Student6(ID int primary key,rno int unique,aadarno dec(30,0) unique,name varchar(10),);

insert into student6
values(1,11,1234567890,'amit')

insert into student6
values(2,12,987654321,'amita')

select* from student1
select*from student3
select*from student6

----------------join---------------------
CREATE TABLE Student8 (id int PRIMARY KEY IDENTITY,admission_no varchar(45) NOT NULL,
first_name varchar(45) NOT NULL,
last_name varchar(45) NOT NULL,
age int,
city varchar(25) NOT NULL);
insert into student8 values(5678,'prachi','jadhav',23,'umred')
 insert into student8 values(1234,'karishma','pachdhare',25,'pune')
 insert into student8 values(4567,'monali','mohtakar',26,'amravati')
 insert into student8 values(6543,'anjali','patak',27,'yavtmal')


CREATE TABLE Fee1 (admission_no varchar(45) NOT NULL,
course varchar(45) NOT NULL,
amount_paid int,);

   insert into fee1 values(3354,'java',20000)
   insert into fee1 values(5678,'python',30000)
   insert into fee1 values(1234,'sql',40000)
   insert into fee1 values(4567,'machine learning',60000)
   insert into fee1 values(6543,'c++',50000)

   SELECT Student8.admission_no, Student8.first_name, Student8.last_name, Fee1.course,fee1.amount_paid from student8
    INNER JOIN Fee1
    ON Student8.admission_no = Fee1.admission_no;

	---------------cross join----------------
	CREATE TABLE Student9 (id int PRIMARY KEY IDENTITY,admission_no varchar(45) NOT NULL,
first_name varchar(45) NOT NULL,last_name varchar(45) NOT NULL,
age int,city varchar(25) NOT NULL);
insert into student9 values(5678,'prachi','jadhav',23,'umred')
 insert into student9 values(1234,'karishma','pachdhare',25,'pune')
 insert into student9 values(4567,'monali','mohtakar',26,'amravati')
 insert into student9 values(6543,'anjali','patak',27,'yavtmal')

CREATE TABLE Fee2 (admission_no varchar(45) NOT NULL,
course varchar(45) NOT NULL,
amount_paid int);

   insert into fee2 values(3354,'java',20000)
   insert into fee2 values(5678,'python',30000)
   insert into fee2 values(1234,'sql',40000)
   insert into fee2 values(4567,'machine learning',60000)
   insert into fee2 values(6543,'c++',50000)

   SELECT Student9.admission_no,Student9.first_name,Student9.last_name, Fee2.course,Fee2.amount_paid
  FROM Student9 CROSS JOIN Fee2  where Student9.admission_no=fee2.admission_no;

  -----------outer join-------------
 SELECT Student9.admission_no, Student9.first_name, Student9.last_name, Fee2.course,
Fee2.amount_paid FROM Student9 FULL OUTER JOIN Fee2
ON Student9.admission_no = Fee2.admission_no;

-------------right outer join-----------
SELECT Student9.admission_no, Student9.first_name, Student9.last_name, Fee2.course,Fee2.amount_paid
FROM Student9 RIGHT OUTER JOIN Fee2
ON Student9.admission_no = Fee2.admission_no;

-----------left outer join--------------------
SELECT Student9.admission_no, Student9.first_name, Student9.last_name, Fee2.course,Fee2.amount_paid
FROM Student9 LEFT OUTER JOIN Fee2
ON Student9.admission_no = Fee2.admission_no;



