﻿CREATE TABLE [dbo].[BroadcastSchedule]
(
	
Id int not null identity(1,1) primary key,
DateAndTime Datetime,
EmployeeId int not null,
RecordId int not null
)
