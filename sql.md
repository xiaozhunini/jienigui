```sql
create table db_user(
	ID int not null primary key identity(1,1), -- 主键
	username varchar(255) not null,			   -- 用户名
	password varchar(255) not null,				-- 密码
	userid int not null UNIQUE 					-- 用户编号
)
GO
create table db_amount(
ID int not null primary key identity(1,1),		-- 主键
totalAmout int ,								-- 总金额
userid int not null								-- 用户编号
)
Go
create table db_tag(
ID int not null primary key identity(1,1) ,		--主键
tagName varchar(255),							--便签名
tagSort int not null,							--金额/便签
tagid int not null ,							--标签id
userid int not null								--用户编号
)
Go
create table db_note(
	ID int not null primary key identity(1,1),
	noteText varchar(255) ,
	noteStatus int,
	tagid int 
)
go
create table db_money(
	ID int not null primary key identity(1,1),
	moneySum int ,
	moneySort int,
	tagid int 
)

```

