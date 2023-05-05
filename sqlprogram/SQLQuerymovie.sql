create table movies(bookingid int primary key,theatername varchar(30))
create table theaterdetails(bookingid int,seatno int,moviename varchar(25),
constraint m1 foreign key(bookingid) references movies(bookingid))

insert into movies values(123,'inox')
insert into movies values(123,23,'ved')

insert into movies values(234,'panchashil')
insert into movies values(234,35,'sairat')

insert into movies values(567,'alankar')
insert into movies values(567,67,'pushpa')

insert into movies values(789,'smruti')
insert into movies values(789,69,'pathan')

select*from movies

