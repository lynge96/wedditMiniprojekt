using System.Threading;
using Data;
using Microsoft.AspNetCore.Http.Json;
using Microsoft.EntityFrameworkCore;
using shared.Model;
using weddit_api.Service;

var builder = WebApplication.CreateBuilder(args);

// Sætter CORS så API'en kan bruges fra andre domæner
var AllowSomeStuff = "_AllowSomeStuff";
builder.Services.AddCors(options =>
{
    options.AddPolicy(name: AllowSomeStuff, builder =>
    {
        builder.AllowAnyOrigin()
               .AllowAnyHeader()
               .AllowAnyMethod();
    });
});

// Tilføj DbContext factory som service.
builder.Services.AddDbContext<PostContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("ContextSQLite")));

// Tilføj DataService så den kan bruges i endpoints
builder.Services.AddScoped<DataService>();

// Dette kode kan bruges til at fjerne "cykler" i JSON objekterne.
builder.Services.Configure<JsonOptions>(options =>
{
    // Her kan man fjerne fejl der opstår, når man returnerer JSON med objekter,
    // der refererer til hinanden i en cykel.
    // (altså dobbelrettede associeringer)
    options.SerializerOptions.ReferenceHandler =
        System.Text.Json.Serialization.ReferenceHandler.IgnoreCycles;
});



var app = builder.Build();

// Seed data hvis nødvendigt.
using (var scope = app.Services.CreateScope())
{
    var dataService = scope.ServiceProvider.GetRequiredService<DataService>();
    dataService.SeedData(); // Fylder data på, hvis databasen er tom. Ellers ikke.
}

app.UseHttpsRedirection();
app.UseCors(AllowSomeStuff);

// Middleware der kører før hver request. Sætter ContentType for alle responses til "JSON".
app.Use(async (context, next) =>
{
    context.Response.ContentType = "application/json; charset=utf-8";
    await next(context);
});

// DataService fås via "Dependency Injection" (DI)
// app.MapGet("/", (DataService service) =>
// {
//     return new { message = "Hello World!" };
// });


// GET/api/posts - Returnerer en liste over alle tråde
app.MapGet("/api/posts", (DataService service) =>
    {
        return service.GetPosts().Select(x => new
        {
            postId = x.PostId,
            date = x.Date,
            title = x.Title,
            user = x.User,
            votes = x.Votes,
            text = x.Text,
            commentsCount = x.Comments.Count()
        });
    });


// GET /api/posts/{postId} - Returnerer en tråd med tilhørende kommentarer
app.MapGet("/api/posts/{postId}", (DataService service, int postId) =>
{
    return service.GetPost(postId);
});


// POST /api/posts/{postId}/comments - Poster en ny kommentar, og tilføjer den til tråden
app.MapPost("/api/posts/{postId}/comments", (DataService service, Comment comment, int postId) =>
{
    Comment newComment = new Comment { User = comment.User, Text = comment.Text, PostId = postId };

    string results = service.AddComment(newComment);

    return new { message = results };
});

// POST /api/posts - Laver en ny post, tilføjer til forsiden.
app.MapPost("/api/posts", (DataService service, Post post) =>
{
    Post newPost = new Post { Title = post.Title, User = post.User, Text = post
    .Text };

    string results = service.AddPost(newPost);

    return new { message = results };    
});


// PUT /api/post/{postId}/vote - Opdaterer en tråds antal stemmer
app.MapPut("/api/posts/{postId}/vote", (DataService service, Vote vote, int postId) =>
{

    string results = service.AddVotePost(postId, vote.Stemmer);

    return new { message = results };
});

// PUT /api/posts/comments/{commentId}/vote - Opdaterer en kommentars antal stemmer
app.MapPut("/api/posts/comments/{commentId}/vote", (DataService service, Vote vote, int commentId) =>
{
    string results = service.AddVoteComment(commentId, vote.Stemmer);

    return new { message = results };
});

app.Run();


