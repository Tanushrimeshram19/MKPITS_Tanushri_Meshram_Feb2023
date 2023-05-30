
--------------------inserted-------------------------
create table employees1(emp_id  int primary key,emp_name varchar(20))
CREATE TABLE EmpLog (
LogID int IDENTITY(1,1) NOT NULL,
EmpID int NOT NULL,
Operation nvarchar(10) NOT NULL,
UpdatedDate Datetime NOT NULL
)
insert into employees1 values(11,'tanu')
insert into employees1 values(12,'karishma')
insert into employees1 values(13,'mona')
create trigger empt
on employees1
for insert
as
insert into EmpLog(EmpID,Operation,UpdatedDate)
select emp_id,'insert',GETDATE() from inserted;

CREATE TRIGGER trgEmployeeInsert
ON Employees1
FOR INSERT
AS

INSERT INTO EmpLog(EmpID, Operation, UpdatedDate)
SELECT Emp_ID ,'INSERT',GETDATE() FROM INSERTED;
select *from employees1
select*from emplog

-----------------------after trigger-------------------------------
create trigger empu
on employees1
after update
as
insert into EmpLog(EmpID,Operation,UpdatedDate)
select emp_id,'update',GETDATE() from deleted
select * from employees1
update employees1 set emp_name='prachi' where
emp_id=11
select * from EmpLog

----------------------inserted------------------------------------
create table student