using System;
using System.Net.Http.Json;
using shared.Model;
using System.Text.Json;
using Microsoft.Extensions.Configuration;

namespace wedditBlazor.Services
{
    public class ApiService
    {
        private readonly HttpClient http;
        private readonly IConfiguration configuration;
        private readonly string baseAPI = "";

        public event Action RefreshRequired;

        public ApiService(HttpClient http, IConfiguration configuration)
        {
            this.http = http;
            this.configuration = configuration;
            this.baseAPI = configuration["base_api"];
        }

        public async Task<Post[]> GetPosts()
        {
            string url = $"{baseAPI}posts/";
            return await http.GetFromJsonAsync<Post[]>(url);
        }
        public async Task<Post> GetPost(int id)
        {
            string url = $"{baseAPI}posts/{id}/";
            return await http.GetFromJsonAsync<Post>(url);
        }

        public async Task<Post> VotePost(int id, bool votePost)
        {
            string url = $"{baseAPI}posts/{id}/vote/";

            // Post JSON to API, save the HttpResponseMessage
            HttpResponseMessage msg = await http.PutAsJsonAsync(url, new Vote { Stemmer = votePost } );

            // Get the JSON string from the response
            string json = msg.Content.ReadAsStringAsync().Result;

            // Deserialize the JSON string to a Post object
            Post? updatedPost = JsonSerializer.Deserialize<Post>(json, new JsonSerializerOptions {
                PropertyNameCaseInsensitive = true // Ignore case when matching JSON properties to C# properties
            });

            // Return the updated post (vote increased)
            return updatedPost;
        }

        public async Task<Comment> VoteComment(int id, bool voteComment)
        {
            string url = $"{baseAPI}posts/comments/{id}/vote/";

            // Post JSON to API, save the HttpResponseMessage
            HttpResponseMessage msg = await http.PutAsJsonAsync(url, new Vote { Stemmer = voteComment } );

            // Get the JSON string from the response
            string json = msg.Content.ReadAsStringAsync().Result;

            // Deserialize the JSON string to a Post object
            Comment? updatedComment = JsonSerializer.Deserialize<Comment>(json, new JsonSerializerOptions {
                PropertyNameCaseInsensitive = true // Ignore case when matching JSON properties to C# properties
            });

            // Return the updated post (vote increased)
            return updatedComment;
        }


        public async Task<Comment> CreateComment(string content, int postId, string username)
        {
            string url = $"{baseAPI}posts/{postId}/comments";
        
            // Post JSON to API, save the HttpResponseMessage
            HttpResponseMessage msg = await http.PostAsJsonAsync(url, new Comment { User = new User(username), Text = content, PostId = postId } );

            // Get the JSON string from the response
            string json = msg.Content.ReadAsStringAsync().Result;

            // Deserialize the JSON string to a Comment object
            Comment? newComment = JsonSerializer.Deserialize<Comment>(json, new JsonSerializerOptions {
                PropertyNameCaseInsensitive = true // Ignore case when matching JSON properties to C# properties 
            });

            // Return the new comment 
            return newComment;
        }

        public async Task<Post> CreatePost(string title, string username, string text)
        {
            string url = $"{baseAPI}posts/";
        
            // Post JSON to API, save the HttpResponseMessage
            HttpResponseMessage msg = await http.PostAsJsonAsync(url, new Post { User = new User(username), Text = text, Title = title } );

            // Get the JSON string from the response
            string json = msg.Content.ReadAsStringAsync().Result;

            // Deserialize the JSON string to a Comment object
            Post? newPost = JsonSerializer.Deserialize<Post>(json, new JsonSerializerOptions {
                PropertyNameCaseInsensitive = true // Ignore case when matching JSON properties to C# properties 
            });

            // Return the new comment 
            return newPost;
        }
    }
}

