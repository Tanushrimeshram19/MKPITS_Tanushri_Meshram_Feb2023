create table teachers(teacherid int primary key ,age int)
create table teacherdetails1(teacherid int ,subject varchar(25), 
constraint c1 foreign key(teacherid) references teachers(teacherid))


insert into teachers values(1,30)
insert into teacherdetails1 values(1,'chemisrty')
insert into teacherdetails1 values(1,'biology')

insert into teachers values(2,40)
insert into teacherdetails1 values(2,'english')
insert into teacherdetails1 values(2,'maths')

insert into teachers values(3,45)
insert into teacherdetails1 values(3,'computer')

select*from teachers
select* from teacherdetails1



