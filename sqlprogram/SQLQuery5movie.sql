create table movie(name varchar(30),theatername varchar(25),ticket int,price int,bookdate int)
insert into movie values('ved','panchashil',2,300,12-3-2003)
insert into movie values('sairat','vr',7,600,1-2-2002)
insert into movie values('pushpa','inox',6,800,12-3-2003)
insert into movie values('rakshabandan','smruti',4,1200,8-3-2009)
insert into movie values('kisikabhaikisikajaan','alankar',5,350,11-4-2000)
insert into movie values('pathan','liberty',12,400,19-2-2003)

select distinct name from movie
SELECT name from movie order by name
SELECT DISTINCT theatername from movie order by theatername
select * from movie where ticket>3
select * from movie where ticket>7
select * from movie where name='ved'
select * from movie where theatername='panchashil'
SELECT theatername,price,bookdate from movie  

