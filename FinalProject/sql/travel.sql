-- CREATE SCHEMA traveldestinations;
USE traveldestinations;
DROP TABLE landmarks;
DROP TABLE locations;

CREATE TABLE locations (
    LocationID INT NOT NULL AUTO_INCREMENT,
    Country VARCHAR(64),
    City VARCHAR(64),
    PRIMARY KEY (LocationID)
);

CREATE TABLE landmarks (
    LandmarkID INT AUTO_INCREMENT,
    LandmarkName VARCHAR(64),
	Rating FLOAT,
	HotelCount INT,
    AvgTicketPrice FLOAT,
	LocationID INT, 
    PRIMARY KEY (LandmarkID),
	FOREIGN KEY (LocationID) REFERENCES locations(LocationID)
); 

