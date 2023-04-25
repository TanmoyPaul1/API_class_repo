USE traveldestinations;
DELETE FROM locations;
DELETE FROM landmarks;

INSERT INTO locations (Country, City) VALUES ("USA", "New York");
INSERT INTO locations (Country, City) VALUES ("Canada", "Niagara Falls");
INSERT INTO locations (Country, City) VALUES ("Mexico", "Mexico City");

INSERT INTO landmarks (LandmarkName, Rating, HotelCount, AvgTicketPrice, LocationID) VALUES ("Statue of Liberty", 4.7, 300, 23.30, 1);
INSERT INTO landmarks (LandmarkName, Rating, HotelCount, AvgTicketPrice, LocationID) VALUES ("Empire State Building", 4.7, 250, 44.00, 1);
INSERT INTO landmarks (LandmarkName, Rating, HotelCount, AvgTicketPrice, LocationID) VALUES ("Niagara Falls", 4.8, 10, 0.00, 2);

SELECT * FROM locations;
SELECT * FROM landmarks;
