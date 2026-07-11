using System.Net;
using System.Text.Json;

namespace IT_ELECTIVE_2_PRELIM_EXAM_HttpClient.Exercises;

// EXERCISE 1: GET Random Meal
// TheMealDB API: https://themealdb.com/api/json/v1/1/random.php
//
// Your task:
// 1. Use the HttpClient to send a GET request to the URL above
 // 2. Read the response as a string
// 3. Assert that the status code is 200 OK
// 4. Assert that the response body is not null or empty
//
// Hint: Use await client.GetAsync(url) then check response.StatusCode
// Hint: Use await response.Content.ReadAsStringAsync() to get the body

public static class GetRandomMeal
{
    public static async Task Run(System.Net.Http.HttpClient client)
    {
        // TODO: Send GET request to https://themealdb.com/api/json/v1/1/random.php
        // TODO: Read the response content as a string
        // TODO: Assert status code is 200 OK
        // TODO: Assert response body is not null or empty

        HttpResponseMessage response = await client.GetAsync("https://themealdb.com/api/json/v1/1/random.php");

        if (response.StatusCode != HttpStatusCode.OK)
        {
            throw new Exception($"Expected 200 OK but got {response.StatusCode}");
        }

        string body = await response.Content.ReadAsStringAsync();

        if (string.IsNullOrWhiteSpace(body))
        {
            throw new Exception("Response body is null or empty.");
        }

        Console.WriteLine("GetRandomMeal passed!");
    }
}
