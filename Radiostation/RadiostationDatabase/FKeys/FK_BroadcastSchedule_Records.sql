ALTER TABLE [dbo].BroadcastSchedule
	ADD CONSTRAINT FK_BroadcastSchedule_Records
	FOREIGN KEY (RecordId)
	REFERENCES Records (Id)
