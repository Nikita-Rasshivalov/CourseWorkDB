ALTER TABLE [dbo].BroadcastSchedule
	ADD CONSTRAINT FK_BroadcastSchedule_Employees
	FOREIGN KEY (EmployeeId)
	REFERENCES [Employees] (Id)
