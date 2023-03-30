-- DROP SCHEMA customerdataservice;
-- CREATE SCHEMA customerdataservice;
USE customerdataservice;

DROP TABLE customers;
DROP TABLE emails;

CREATE TABLE emails (
    EmailID INT AUTO_INCREMENT,
    EmailAddress VARCHAR(64),
    IsSubscribed TINYINT,
	PRIMARY KEY (EmailID)
);

CREATE TABLE customers (
    CustomerID INT NOT NULL AUTO_INCREMENT,
    FirstName VARCHAR(64) NOT NULL,
    MiddleName VARCHAR(64),
    LastName VARCHAR(64),
	EmailID INT NOT NULL,
    PRIMARY KEY (CustomerID),
    FOREIGN KEY (EmailID) REFERENCES emails(EmailID)
);



