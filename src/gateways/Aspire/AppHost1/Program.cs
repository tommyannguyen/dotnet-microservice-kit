var builder = DistributedApplication.CreateBuilder(args);

var username = builder.AddParameter("PostgresUserName", secret: true);
var password = builder.AddParameter("PostgresPassword", secret: true);

var postgres = builder.AddPostgres("postgres", username, password)
                      .WithPgWeb();
var postgresdb = postgres.AddDatabase("postgresdb");


builder.AddProject<Projects.Category_Api>("category-api");

builder.AddProject<Projects.Identity_Api>("identity-api")
    .WithReference(postgresdb);


builder.Build().Run();
