create table product3 (name varchar(25) ,id int,quantity int,price int,orderdate int)
insert into product3 values('computer',1,7,50000,12-3-2021)
insert into product3 values('freeze',2,5,25000,19-2-2020)
insert into product3 values ('tv',3,6,5000,3-3-2000)
insert into product3 values('tablet',4,8,40000,5-7-2021)
insert into product3 values('laptop',5,10,54000,6-5-2023)
insert into product3 values('mobile',6,9,25000,13-7-2021)


SELECT name,price FROM
product3 ORDER BY name;

create procedure prod1
as
begin

select * from product2
end;

exec prod

CREATE PROCEDURE uspProductList
AS BEGIN SELECT name,
price FROM product3
ORDER BY name;
END;

EXECUTE sp name;

alter procedure prod1
as
begin
select name,price from product3
order by price
end;

exec prod1

ALTER PROCEDURE uspProductList
AS BEGIN
SELECT name,
price
FROM
product3
ORDER BY
price
END;
EXEC uspProductList;

DROP PROCEDURE sp_name;


DROP PROCEDURE uspProductList;

SELECT name,
price
FROM
product2
ORDER BY
price;

CREATE PROCEDURE uspFindProducts
AS BEGIN
SELECT name,
price FROM
product3
ORDER BY
price;
END;
create proc prod3(@minprice as decimal)
as
begin
select * from product3
where price > @minprice
order by price
end;

exec prod3 5000

create proc pp2(@pn as varchar(20))
as
begin
select * from product3
where name=@pn
end

exec pp2 'mobile'
exec pp2 'computer'

create proc prod5(@pname as varchar(20))
as
begin
select * from product3
where name = @pname
order by name
end;

exec prod5 'freeze'
exec prod5 'tv'
---------stored two parameters--------------
create proc prod6(@pname as varchar(20),@p as
decimal)
as
begin
select * from product3
where name = @pname
and price >= @p
order by name
end;

exec prod6 'computer',50000
exec prod6 'freeze',25000

ALTER PROCEDURE uspFindProducts(@min_list_price AS DECIMAL)
AS
BEGIN
SELECT
name,
price
FROM
product3
WHERE
price >= @min_list_price
ORDER BY
price;
END;
EXEC uspFindProducts 40000;

---------stored procedure multiple parameters-----------
create proc prod7(@minp as decimal,@maxp as
decimal)
as
begin
select * from product3

where price > @minp and price < @maxp
order by name
end;

exec prod7 50000,25000
--------@min and @max---------------
ALTER PROCEDURE uspFindProducts(
@min_list_price AS DECIMAL
,@max_list_price AS DECIMAL
)
AS
BEGIN
SELECT
name,
price
FROM
product3
WHERE
price >= @min_list_price AND
price <= @max_list_price
ORDER BY
price;
END;
EXECUTE uspFindProducts 5000, 25000;
exec prod7 @minp=54000,@maxp=50000
exec prod7 @minp=40000,@maxp=25000

create proc prod8(@minp as decimal,@maxp as
decimal,@pn as varchar(max))
as
begin
select * from product3
where price > @minp and price < @maxp
and name=@pn
order by name
end;
exec prod8 @minp=25000,@maxp=50000,@pn='computer'

create proc prod11(@minp as decimal=100,@maxp
as decimal=null,@pn as varchar(max))
as
begin
select * from product3
where
price >= @minp AND

(@maxp IS NULL OR price <= @maxp) AND
name LIKE '%' + @pn + '%'

end;

exec prod11 5000,50000,'computer'
exec prod11 25000,20000,'freeze'
exec prod11 @minp=500,@pn='e'
--------------------------------------------------------
create proc sp_inprod
as
begin
insert into product3
values('freeze',2,5,25000,19-2-2020);
end

create proc sp_inprod2(@pid as int,@pn as
varchar(20),
@pr as decimal,@q as int)
as
begin
update product3 set
name=@pn,price=@pr,quantity=@q
where id=@pid
end

exec sp_inprod2 'mobile',6,9,25000
select * from product2

exec sp_inprod
select * from product3


create proc sp_inprod3(@pid as int,@pn as
varchar(20))
as

begin
delete from product2
where id=@pid or name=@pn
end

exec sp_inprod3 23,'computer'
select * from product3