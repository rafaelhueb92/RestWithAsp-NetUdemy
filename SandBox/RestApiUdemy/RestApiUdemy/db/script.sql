use rest_with_asp_net_udemy;
/*CREATE TABLE persons
(
	Id 		 int(10) unsigned NULL DEFAULT NULL,
	FirstName varchar(50) 		NULL DEFAULT NULL,
	LastName  varchar(50) 	   NULL DEFAULT NULL,
	Address   varchar(50) 	   NULL DEFAULT NULL,
	Gender    varchar(50) 		NULL DEFAULT NULL
)
ENGINE=InnoDB;*/

ALTER TABLE persons MODIFY COLUMN ID INT(10) AUTO_INCREMENT PRIMARY KEY;