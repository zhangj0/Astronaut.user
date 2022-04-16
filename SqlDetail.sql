create database Astronaut
go
use  Astronaut --数据库名称
go
create table EmployeeInfo   --员工信息
(
Id int identity(1,1) primary key,			--主键索引Id
EmployeeId int not null,					--员工Id
EmployeeName nvarchar(50) not null,			--员工名称
RealName nvarchar(50) not null,				--真实姓名
EmployeeEmail nvarchar(50) not null,		--员工邮箱地址
IsEnable  bit default(0) not null,			--是否启用
CreatedDate datetime not null,				--创建时间
)
go
