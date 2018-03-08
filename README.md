# XFBlogExample

Is an example of a simple ASP.NET Core API and Xamarin.Forms client.

## API

Has an integrated Swagger that is used to generate the client code.

## Xamarin.Forms Client

The API consumer code is generated using [NSwag](https://github.com/RSuter/NSwag):
```
dotnet dotnet-nswag.dll swagger2csclient /input:swagger.json /classname:BlogService /namespace:BlogReader /output:BlogService.cs
```
