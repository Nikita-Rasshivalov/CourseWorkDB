ALTER TABLE [dbo].Records
	ADD CONSTRAINT FK_Performers_Records
	FOREIGN KEY (PerformerId)
	REFERENCES [Performers] (Id)
