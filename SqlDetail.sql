create database Astronaut
go
use  Astronaut --���ݿ�����
go
create table EmployeeInfo   --Ա����Ϣ
(
Id int identity(1,1) primary key,			--��������Id
EmployeeId int not null,					--Ա��Id
EmployeeName nvarchar(50) not null,			--Ա������
RealName nvarchar(50) not null,				--��ʵ����
EmployeeEmail nvarchar(50) not null,		--Ա�������ַ
IsEnable  bit default(0) not null,			--�Ƿ�����
CreatedDate datetime not null,				--����ʱ��
)
go
