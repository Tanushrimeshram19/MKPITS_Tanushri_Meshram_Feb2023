create table country(countryid int primary key,countryname  varchar(20))
insert into country values(1,'india')
insert into country values(2,'usa')

create table state(stateid  int primary key,statename varchar(20), countryid int constraint c1 foreign key(countryid) references country(countryid));
insert into state values(11,'maharashtra',1)
insert into state values(12,'mp',1)
insert into state values(13,'washingtone',2)
insert into state values(14,'texas',2)

create table city(cityid int primary key,cityname varchar(20),stateid int constraint c2 foreign key(stateid) references state(stateid));
insert into city values(15,'nagpur',11)
insert into city values(16,'mumbai',11)
insert into city values(17,'bhopal',12)
insert into city values(18,'LA',13)
insert into city values(19,'algam',14)

select*from country
select*from state
select*from city

select  c1.countryid,c1.countryname,s1.statename from country c1 inner join  state s1 on c1.countryid=s1.countryid where c1.countryname='india';
select c1.countryid,c1.countryname,s1.statename from country c1 inner join  state s1 on c1.countryid=s1.countryid where c1.countryname='usa';

select s1.statename from country c1 inner join  state s1 on c1.countryid=s1.countryid where c1.countryname='india';
select s1.statename from country c1 inner join  state s1 on c1.countryid=s1.countryid where c1.countryname='usa';

select ct.cityname from city ct 
inner join state s1 on ct.stateid=s1.stateid where s1.statename='maharashtra'

select ct.cityname from city ct 
inner join state s1 on ct.stateid=s1.stateid where s1.statename='mp'

select ct.cityname from city ct 
inner join state s1 on ct.stateid=s1.stateid where s1.statename='washingtone'

select ct.cityname from city ct 
inner join state s1 on ct.stateid=s1.stateid where s1.statename='texas'
----------subquery-------------
select statename from state where countryid=(select countryid from country where countryname='india');
select statename from state where countryid=(select countryid from country where countryname='usa');


select cityname from city where stateid=(select stateid from state where statename='maharashtra');
select cityname from city where stateid=(select stateid from state where statename='mp');
select cityname from city where stateid=(select stateid from state where statename='wasingtone');
select cityname from city where stateid=(select stateid from state where statename='texas');