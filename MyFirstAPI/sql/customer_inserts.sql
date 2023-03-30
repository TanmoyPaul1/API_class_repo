USE customerdataservice;
DELETE FROM emails;
DELETE FROM customers;

INSERT INTO emails (EmailID, EmailAddress, IsSubscribed) VALUES (1, "hi@gmail.com", 1);
INSERT INTO emails (EmailID, EmailAddress, IsSubscribed) VALUES (2, "john@gmail.com", 0);
INSERT INTO emails (EmailID, EmailAddress, IsSubscribed) VALUES (3, "jane@gmail.com", 1);
INSERT INTO emails (EmailID, EmailAddress, IsSubscribed) VALUES (4, "goodbye@gmail.com", 0);

INSERT INTO customers (CustomerID, FirstName, MiddleName, LastName, EmailID) VALUES (1, "Tanmoy", NULL, "Paul", 1);
INSERT INTO customers (CustomerID, FirstName, MiddleName, LastName, EmailID) VALUES (2, "John", NULL, "Doe", 2);
INSERT INTO customers (CustomerID, FirstName, MiddleName, LastName, EmailID) VALUES (3, "Jane", NULL, "Doe", 2);

SELECT * FROM emails;
SELECT * FROM customers;