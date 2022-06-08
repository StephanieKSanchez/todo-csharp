var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/todo-items", () => {});
app.MapGet("/todo-items/{id}", (string id) => {
    var todoItem = new {
        Id = Guid.NewGuid().ToString(),
        Title = "Complete Todo in C#",
        IsCompleted = false
    };
    return Results.Ok(todoItem);
});
app.MapPost("/todo-items", () => {});
app.MapPut("/todo-items/{id}", (string id) => {});
app.MapDelete("/todo-items", (string id) => {});

app.Run();
