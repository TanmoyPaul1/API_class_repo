USE traveldestinations;
DELETE FROM locations;
DELETE FROM landmarks;

INSERT INTO locations (Country, City) VALUES ("USA", "New York");
INSERT INTO locations (Country, City) VALUES ("Canada", "Niagara Falls");
INSERT INTO locations (Country, City) VALUES ("Mexico", "Mexico City");
INSERT INTO locations (Country, City) VALUES ("Argentina", "Buenos Aires");

INSERT INTO landmarks (LandmarkName, Rating, HotelCount, AvgTicketPrice, LocationID) VALUES ("Statue of Liberty", 4.80, 300, 200.00, 1);
INSERT INTO landmarks (LandmarkName, Rating, HotelCount, AvgTicketPrice, LocationID) VALUES ("Empire State Building", 4.90, 250, 300.00, 1);
INSERT INTO landmarks (LandmarkName, Rating, HotelCount, AvgTicketPrice, LocationID) VALUES ("Niagara Falls", 4.85, 150, 100.00, 2);

SELECT * FROM locations;
SELECT * FROM landmarks;
