var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

// Books
app.MapGet("/books", () => "HERE ALL BOOKS");
app.MapGet("/books/{id}", (int id) => $"BOOKS BY ID: {id}");
app.MapPost("/books", async (HttpContext context) =>
{
    // Handle book 
    StreamReader reader = new StreamReader(context.Request.Body);
    string data = await reader.ReadToEndAsync();
    await context.Response.WriteAsync($"WE HAVE CREATED THE FOLLOW BOOK: {data}");
});

app.MapPut("/books/{id}", (int id) => $"UPDATED BOOK!!: {id}");
app.MapDelete("/books/{id}", (int id) => $"UPS DELETE BOOK: {id}");

// Readers
app.MapGet("/readers", () => "HERE ALL READERS BOOKS");
app.MapGet("/readers/{id}", (int id) => $"READERS BY ID: {id}");
app.MapPost("/readers", async (HttpContext context) =>
{
    // Handle reader 
    StreamReader reader = new StreamReader(context.Request.Body);
    string data = await reader.ReadToEndAsync();
    await context.Response.WriteAsync($"WE HAVE CREATED A NEW READER BOOK: {data}");
});

app.MapPut("/readers/{id}", (int id) => $"UPDATED READER BOOK BY ID: {id}");
app.MapDelete("/readers/{id}", (int id) => $"UPS DELETE READER BOOK BY ID: {id}");

// Borrowings
app.MapGet("/borrowings", () => "HERE ARE ALL THE BORROWED BOOKS");
app.MapGet("/borrowings/{id}", (int id) => $"BORROWED BOOKS BY ID: {id}");
app.MapPost("/borrowings", async (HttpContext context) =>
{
    // Handle borrowing 
    StreamReader reader = new StreamReader(context.Request.Body);
    string data = await reader.ReadToEndAsync();
    await context.Response.WriteAsync($"NEW BORROW BOOK: {data}");
});

app.MapPut("/borrowings/{id}", (int id) => $"UPDATED BORROW BOOK BY ID: {id}");
app.MapDelete("/borrowings/{id}", (int id) => $"UPS DELETE BORROWED BOOK BY ID: {id}");

app.Run();
