# XFBlogExample

Is an example of a simple ASP.NET Core API and Xamarin.Forms client. There is a blogpost with all the details about this project on [my blog](https://smellyc0de.wordpress.com/2018/03/08/using-swagger-to-automatically-generate-the-client-code/).

## API

Has an integrated Swagger that is used to generate the client code.

## Xamarin.Forms Client

The API consumer code is generated using [NSwag](https://github.com/RSuter/NSwag):
```
dotnet dotnet-nswag.dll swagger2csclient /input:swagger.json /classname:BlogService /namespace:BlogReader /output:BlogService.cs
```
