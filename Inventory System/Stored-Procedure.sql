Create Procedure sp_createAccount 
@firstName varchar(50),
@lastName varchar(50),
@password varchar(50),
@email varchar(50)
as 
INSERT INTO UserAccount(FirstName,LastName,[Password],Email)
VALUES(@firstName,@lastName,@password,@email)