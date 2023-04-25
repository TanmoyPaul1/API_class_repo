# This is my repo for CSCI 39537: Intro to APIs at Hunter College

In the MyFirstAPI folder is a demo API. 
In the final project folder is my Travel API. It uses the .NET and Entity Framework. 

To run the final project API:
1. clone the repo
2. open the _FinalProject\FinalProject\\_ folder in command prompt
3. use the command ```dotnet run```
4. alternatively, open the FinalProject.sln solution in Visual Studio and press Start. 

This API has a list of countries and cities in the locations endpoint. When the user wants to travel, they can find the city they wish to travel to and see all the landmarks in that city. The landmarks have the number of hotels nearby, the rating, and the average price of the ticket there. 


## Endpoints
1. **/api/locations**  -  This gives you a list of all the locations and their respective landmarks. 
2. **/api/locations/{id}**  -  This gives you the location with the specified id and all of that location's landmarks. 
3. **/api/landmarks**  -  This gives you a list of all the landmarks. 
4. **/api/landmarks/{id}**  -  This gives you the landmark with the specified id. 


## HTTPS Methods
1. GET  -  This request returns a response body of the specified endpoint. 
Here is the template:
```
{
    "locationID": INTEGER,
    "country": STRING,
    "city": STRING,
    "landmark": [
        {
            "landmarkID": INTEGER,
            "landmarkName": STRING,
            "rating": FLOAT,
            "hotelCount": INTEGER,
            "avgTicketPrice": FLOAT,
            "locationID": INTEGER
        } // one or more of these landmark objects
    ]
}
```
Here is an example response:
```
{
    "locationID": 1,
    "country": "USA",
    "city": "New York",
    "landmark": [
        {
            "landmarkID": 2,
            "landmarkName": "Statue of Liberty",
            "rating": 4.8,
            "hotelCount": 300,
            "avgTicketPrice": 200,
            "locationID": 1
        },
        {
            "landmarkID": 3,
            "landmarkName": "Empire State Building",
            "rating": 4.9,
            "hotelCount": 250,
            "avgTicketPrice": 300,
            "locationID": 1
        }
    ]
}
```
2. POST  -  This request sends data to be inserted into the database. 
This is an example body for this request, the ID numbers are automatically incremented:
```
{
    "country": "USA",
    "city": "New York",
    "landmark": [
        {
            "landmarkName": "Empire State Building",
            "rating": 4.9,
            "hotelCount": 250,
            "avgTicketPrice": 300.0
        },
        {
            "landmarkName": "Statue of Liberty",
            "rating": 4.8,
            "hotelCount": 300,
            "avgTicketPrice": 200.0
        }
    ]
}
```
3. DELETE  -  This request deletes data from the database. 

