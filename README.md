# Middleware.NET
Middleware.NET This repository demonstrates how to create and use custom middleware components in ASP.NET Core


# Middleware
ASP.NET Core makes it easy to register middleware in the Program.cs file, where they are added to the pipeline using methods like 
- ```app.Use```
- ```app.Run```
- ```app.Map```

![image](https://github.com/user-attachments/assets/60c6a23a-da4d-4bb0-bff2-172afa5816fc)

----

![image](https://github.com/user-attachments/assets/6712af0f-95e8-4732-a50d-26f0367eee78)




# Middleware order

![image](https://github.com/user-attachments/assets/2a2ce8dd-4cff-46ce-8471-d9387987e340)

----

> Each middleware in the pipeline follows a simple pattern: it receives the HttpContext, performs some processing, and then either calls the next middleware or short-circuits the pipeline by generating a response immediately. If middleware short-circuits the request, it prevents further execution of other middleware components, allowing for optimizations like handling errors or returning cached responses early.

## Example


```csharp
app.Use(async (context, next) =>
{
    await context.Response.WriteAsync("Middleware 1: Incoming request");
    await next();  // Pass control to the next middleware
    await context.Response.WriteAsync("Middleware 1: Outgoing response");
});

app.Use(async (context, next) =>
{
    await context.Response.WriteAsync("Middleware 2: Incoming request");
    await next();
    await context.Response.WriteAsync("Middleware 2: Outgoing response");
});

app.Run(async (context) =>
{
    await context.Response.WriteAsync("Middleware 3: Handling request and terminating pipeline");
    await context.Response.WriteAsync("Hello, world!");
});
```

![image](https://github.com/user-attachments/assets/07cf7738-8f0d-4573-842c-88f8a0f0f2f5)


-----




# Examples Internal Middleare

### Middleware Presetation Central (controls all requests)
``` csharp
app.Run( async context =>
{
    await context.Response.WriteAsync("Hello World");
});
```
> It will always make "Hello World" appear. Regardless of the route

![image](https://github.com/user-attachments/assets/55126b40-ad35-4a4c-93d3-35b6ae537464)

---

![image](https://github.com/user-attachments/assets/b82e62b3-041e-4d81-a72b-cc73d8c28f7e)



# References
https://learn.microsoft.com/en-us/aspnet/core/fundamentals/middleware/?view=aspnetcore-8.0

https://codewithmukesh.com/blog/middlewares-in-aspnet-core/
