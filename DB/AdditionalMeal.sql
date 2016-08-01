if exists(select * from sysobjects where name = N'AdditionalMealDetails' and type = N'U')
  drop table AdditionalMealDetails;
go

if exists(select * from sysobjects where name = N'AdditionalMeal' and type = N'U')
  drop table AdditionalMeal;
go

create table AdditionalMeal
( Id int identity(1, 1) primary key not null  
, HospId int not null
, OrderDate datetime not null
, LocationId int not null
, OrderStatus int not null default 0 /* 0-未提交 1-已提交 2-审核 3-作废 */
, Auditor int null
, AuditDate datetime null
, Canceller int null
, CancellationDate datetime null
, AddUser int not null
, AddDate datetime not null
, UpdtUser int not null
, UpdtDate datetime not null
);
go

alter table AdditionalMeal with check add constraint FK_AdditionalMeal_InHosInfo foreign key(HospId) references [dbo].InHosInfo(ID);
go
alter table AdditionalMeal with check add constraint FK_AdditionalMeal_BsLocation foreign key(LocationId) references [dbo].BsLocation(ID);
go
alter table AdditionalMeal with check add constraint FK_AdditionalMeal_BsUser_1 foreign key(Auditor) references [dbo].BsUser(ID);
go
alter table AdditionalMeal with check add constraint FK_AdditionalMeal_BsUser_2 foreign key(Canceller) references [dbo].BsUser(ID);
go
create nonclustered index IDX_AdditionalMeal_HospId on AdditionalMeal(HospId);
go
create nonclustered index IDX_AdditionalMeal_OrderDate on AdditionalMeal(OrderDate);
go
create nonclustered index IDX_AdditionalMeal_LocationId on AdditionalMeal(LocationId);
go
--alter table AdditionalMeal add constraint FK_AdditionalMeal_BsUser_3 foreign key(AddUser) references [dbo].BsUser(ID);
--go
--alter table AdditionalMeal add constraint FK_AdditionalMeal_BsUser_4 foreign key(UpdtUser) references [dbo].BsUser(ID);
--go

create table AdditionalMealDetails
( Id int identity(1, 1) primary key not null
, AdditionalMealId int not null
, AdditionalMealType char(1) not null
, FoodId int not null
, Qty int not null default 1
, UnitPrice decimal(8, 2) null
);
go
alter table AdditionalMealDetails with check add constraint FK_AdditionalMealDetails_AdditionalMeal foreign key(AdditionalMealId) references [dbo].AdditionalMeal(ID);
go
alter table AdditionalMealDetails with check add constraint FK_AdditionalMealDetails_LmFood foreign key(FoodId) references [dbo].lmfood(ID);
go
alter table AdditionalMealDetails with check add constraint FK_AdditionalMealDetails_AdditionalMealType check (AdditionalMealType in ('B', 'L', 'D'));
go
create nonclustered index IDX_AdditionalMealDetails_AdditionalMealType on AdditionalMealDetails(AdditionalMealType);
go

/*
alter table LmFood add ItemId int null;
go
alter table LmFood with nocheck add constraint FK_LmFood_BsItem foreign key(ItemId) references [dbo].BsItem(Id);
go
*/

--w bsItem