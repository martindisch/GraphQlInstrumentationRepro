using GraphQlInstrumentationRepro;

var builder = WebApplication.CreateBuilder(args);
builder.Services
    .AddGraphQLServer()
    .AddQueryType<Query>();

var app = builder.Build();
app.MapGet("/", () => "Hello World!");
app.MapGraphQL();

app.Run();
