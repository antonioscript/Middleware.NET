# Middleware.NET
Middleware.NET This repository demonstrates how to create and use custom middleware components in ASP.NET Core

![image](https://github.com/user-attachments/assets/60c6a23a-da4d-4bb0-bff2-172afa5816fc)

# Middleware order

![image](https://github.com/user-attachments/assets/2a2ce8dd-4cff-46ce-8471-d9387987e340)

----



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
