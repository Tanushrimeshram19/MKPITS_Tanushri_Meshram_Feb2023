create table  stud2(first_name varchar(20),last_name varchar(20),course varchar(20),marks int,city varchar(25),state varchar(25))
insert into stud2 values('tanu','meshram','dotnet',500,'nagpur','mah')
insert into stud2 values('karishma','mpachdhare','java',600,'nagpur','mah')
insert into stud2 values('monali','mohtakar','python',700,'pune','mah')
insert into stud2 values('anjali','pathak','php',700,'mumbai','mah')
insert into stud2 values('mayuri','meshram','c++',500,'nagpur','mah')
insert into stud2 values('prachi','sharma','php',800,'nagpur','mah')
select first_name,last_name from stud2
order by first_name desc
select first_name,last_name from stud2
order by last_name
SELECT city,first_name from stud2
SELECT city,first_name from stud2 order by city desc,first_name asc
 select first_name, last_name from stud2 order by len(first_name)
 select   marks ,first_name from stud2
 select city from stud2 order by len(city)
 select course from stud2 order by len(course)
 select first_name from stud2 order by marks desc,first_name asc
 select distinct first_name from stud2