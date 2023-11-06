// See https://aka.ms/new-console-template for more information

using Flight;

AirSearchClient client = new AirSearchClient();

// Use the 'client' variable to call operations on the service.

// Always close the client.
SearchRequest request = new SearchRequest
{
    Destination = "05.11.2023",
    DepartureDate = new DateTime(2023, 11, 5, 18, 20, 0),
    Origin = "SAW"
};

var response =await client.AvailabilitySearchAsync(request);

client.Close();

