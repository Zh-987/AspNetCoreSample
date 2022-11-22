using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Primitives;
using System.Xml.Linq;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
/*
 builder.Configuration.GetSection();
builder.Environment();
builder.Logging();
*/
var app = builder.Build();

// Configure the HTTP request pipeline.
/*if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();*/
/*app.UseWelcomePage();*/
app.Run(HandleRequest);
app.Run();


async Task HandleRequest(HttpContext context)
{
    var response = context.Response;
    var request = context.Request;
    /*await response.SendFileAsync("ItStep.jpeg");*/

    response.Headers.ContentType = "text/html; charset=utf-8";

    var stringBuilder = new System.Text.StringBuilder("<table>");

    if(request.Path == "/postuser")
    {
        var form = request.Form;
        string Name = form["name"];
        string Age = form["age"];

        await response.WriteAsync($"<div><p>Name: {Name}</p><br><p>Age: {Age}</p></div>"); 
    }
    else
    {
        await response.SendFileAsync("Html/index.html");
    }
    /*
     *  response.Headers.ContentLanguage = "kz-KZ";
     *  response.Headers.Append("secret-id","123");
    await response.WriteAsync("<h1>Hello It step</h1>");*/


    /* foreach (var header in context.Request.Headers)
     {
         stringBuilder.Append($"<tr><td>{header.Key}</td> <td> {header.Value}</td></tr>");
     }
     stringBuilder.Append("</table>");

     await response.WriteAsync(stringBuilder.ToString());*/

    /*response.StatusCode = 404;
    await response.WriteAsync("Resource not found");*/
}

/*app.RunAsync();
app.Start();
app.StartAsync();
app.StopAsync();*/