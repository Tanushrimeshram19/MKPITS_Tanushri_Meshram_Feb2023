create table product(pro_id int,pro_name varchar(20),qty int,price int)
insert into product values(1,'keyboard',5,2500)
insert into product values(2,'mouse',2,650)
insert into product values(3,'pendrive',10,1000)
insert into product values(4,'speaker',3,500)
insert into product values(5,'computer',1,50000)
insert into product values(6,'laptop',2,60000)
select * from product
update product set price=10000
where pro_name='computer'

update product set price=300
where pro_name='keyboard' and price=2500

delete from product
where pro_name='mouse'


create table sample56789(id int identity primary key,name varchar(20))
insert into sample56789 values('mouse')
insert into sample56789 values('keyboard')
insert into sample56789 values('pendrive')
insert into sample56789 values('laptop')
insert into sample56789 values('computer')
insert into sample56789 values('scanner')

select * from sample56789
delete from sample56789
select * from sample56789

insert into sample56789 values('mouse')

insert into sample56789 values('keyboard')
select * from sample56789

truncate table sample56789
select * from sample56789
insert into sample56789 values('mouse')
insert into sample56789 values('keyboard')
select * from sample56789

EXEC sp_rename 'product.pro_id','prodid','column'


