using System.Net;
using System.Text.Json;

namespace IT_ELECTIVE_2_PRELIM_EXAM_HttpClient.Exercises;

// EXERCISE 8: DELETE Remove Review
// JSONPlaceholder API: https://jsonplaceholder.typicode.com/posts/{id}
//
// Your task:
// 1. Send a DELETE request to remove post with ID 1
// 2. Assert status code is 200 OK
//
// Hint: Use await client.DeleteAsync(url)

public static class DeleteReview
{
    public static async Task Run(System.Net.Http.HttpClient client)
    {
        // TODO: Send DELETE request to https://jsonplaceholder.typicode.com/posts/1
        // TODO: Assert status code is 200 OK

        HttpResponseMessage response = await client.DeleteAsync("https://jsonplaceholder.typicode.com/posts/1", content);

        if (response.StatusCode != HttpStatusCode.OK)
        {
            throw new Exception($"Expected 200 OK but got {response.StatusCode}");
        }
    }
}
