﻿ALTER TABLE Employees
ADD CONSTRAINT FK_Employees_AspNetUsers
FOREIGN KEY (AspNetUserId) REFERENCES AspNetUsers(Id);
